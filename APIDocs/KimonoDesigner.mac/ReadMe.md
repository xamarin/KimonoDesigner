#API Documentation

####Version 01.00.00

##Table of Contents

* [Namespaces](#Namespaces)
* [Types](#Types)
* [Fields](#Fields)
* [Properties](#Properties)
* [Methods](#Methods)
* [Events](#Events)

<a name="Namespaces"></a>
#Namespaces


---

<a name="1e257306-8e53-45d6-a2bd-7300974e04be"></a>
##KimonoMac

###Summary

Holds the MacOS implementation of the Kimono Designer that allows a developer to graphically edit Skia based graphic objects that can can be converted to code and included in any cross-platform language and OS that SkiaSharp supports.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6b183c9a-bfbf-4b36-aba5-4113a11c9413'>ActivatableItem</a></td><td style='width:75%' ><p>The public <code>ActivatableItem</code> class inherits from the <code>AppKit.NSToolbarItem</code> class and is defined in the <code>KimonoMac</code> namespace. It defines one field, one property, 7 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85c5cfff-5452-46bd-a635-bc6028026976'>AppDelegate</a></td><td style='width:75%' class='def'><p>The public <code>AppDelegate</code> class inherits from the <code>AppKit.NSApplicationDelegate</code> class and is defined in the <code>KimonoMac</code> namespace. It defines no fields, no properties, 3 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c9586fd-9c41-46bf-8bdd-8416188a35a4'>CenteringClipView</a></td><td style='width:75%' ><p>The public <code>CenteringClipView</code> class inherits from the <code>AppKit.NSClipView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines no fields, no properties, 4 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec2d093d-ce8c-40d5-b0cc-1640e6614119'>KimonoInspectorArrow</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorArrow</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 10 fields, 9 properties, 31 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff84e343-fa58-40cb-b6b6-106a85c91868'>KimonoInspectorAttachedStyle</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorAttachedStyle</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 10 fields, 6 properties, 33 methods and 5 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022'>KimonoInspectorFill</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorFill</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 23 fields, 22 properties, 69 methods and 2 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a50ac7b7-6b94-4bc1-9316-853d036a6761'>KimonoInspectorFont</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorFont</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 16 fields, 14 properties, 50 methods and 2 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df0cadf3-a029-444e-a899-d6857919e56f'>KimonoInspectorFrame</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorFrame</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 46 fields, 45 properties, 137 methods and 2 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e36b0e08-8c34-452a-ae2f-60578ed14dcd'>KimonoInspectorGeneralInfo</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorGeneralInfo</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 18 fields, 13 properties, 57 methods and 5 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e50f6195-392c-42de-9b13-7433a22ed099'>KimonoInspectorGradient</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorGradient</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 27 fields, 23 properties, 82 methods and 5 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b963c8f-344b-43de-a7a0-bc6c6f206d9d'>KimonoInspectorPaleteColor</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorPaleteColor</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 24 fields, 20 properties, 73 methods and 4 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7fbdce9-839e-40fc-a6d1-72b34f837de0'>KimonoInspectorPolygon</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorPolygon</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 5 fields, 4 properties, 17 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49df7770-93d5-42c4-9a0a-efeef5a8cf12'>KimonoInspectorSketch</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorSketch</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 12 fields, 9 properties, 40 methods and 3 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f'>KimonoInspectorStar</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorStar</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 9 fields, 8 properties, 27 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d966c642-1886-482d-a924-0dc9c962accb'>KimonoInspectorStyle</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorStyle</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 14 fields, 8 properties, 45 methods and 6 events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#520dbfc1-d25b-4528-bb05-f6158e6171d2'>KimonoInspectorText</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorText</code> class inherits from the <code>AppKit.NSView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 5 fields, 3 properties, 15 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd'>KimonoTextView</a></td><td style='width:75%' ><p>The public <code>KimonoTextView</code> class inherits from the <code>AppKit.NSTextView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines one field, no properties, 8 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9659011a-32e0-4e33-a1b3-022dcd95c073'>MainClass</a></td><td style='width:75%' class='def'><p>The private <code>MainClass</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoMac</code> namespace. It defines no fields, no properties, one method and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35062bb9-5a44-4214-9296-32c4d5467add'>MainWindowController</a></td><td style='width:75%' ><p>The public <code>MainWindowController</code> class inherits from the <code>AppKit.NSWindowController</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 13 fields, 14 properties, 35 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6363465-6e0a-4cff-a55f-b89a7306f4ec'>SourceListDataSource</a></td><td style='width:75%' class='def'><p>The public <code>SourceListDataSource</code> class inherits from the <code>AppKit.NSOutlineViewDataSource</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 2 fields, no properties, 6 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8ba5633-ee96-4674-bbab-f97c6bf7fae4'>SourceListDelegate</a></td><td style='width:75%' ><p>The public <code>SourceListDelegate</code> class inherits from the <code>AppKit.NSOutlineViewDelegate</code> class and is defined in the <code>KimonoMac</code> namespace. It defines one field, no properties, 7 methods and no events.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa'>SourceListItem</a></td><td style='width:75%' class='def'><p>The public <code>SourceListItem</code> class inherits from the <code>Foundation.NSObject</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 6 fields, 7 properties, 37 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af72ceec-0ee0-4d13-add5-6380ca3fff2f'>SourceListView</a></td><td style='width:75%' ><p>The public <code>SourceListView</code> class inherits from the <code>AppKit.NSOutlineView</code> class and is defined in the <code>KimonoMac</code> namespace. It defines one field, one property, 11 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8'>ViewController</a></td><td style='width:75%' class='def'><p>The public <code>ViewController</code> class inherits from the <code>AppKit.NSViewController</code> class and is defined in the <code>KimonoMac</code> namespace. It defines 43 fields, 41 properties, 195 methods and one event.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="6b183c9a-bfbf-4b36-aba5-4113a11c9413"></a>
##Public Class ActivatableItem

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSToolbarItem`

###Summary

The public `ActivatableItem` class inherits from the `AppKit.NSToolbarItem` class and is defined in the `KimonoMac` namespace. It defines one field, one property, 7 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1773ea96-3e19-498d-a97c-4dbc70171fa8'>Active</a></td><td style='width:75%' ><p>The public <code>Active</code> property of the <code>ActivatableItem</code> class has a <code>System.Boolean</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0c580caf-a22a-47f4-b080-4b42523e94e5'>ActivatableItem</a></td><td style='width:75%' ><p>The public <code>ActivatableItem ()</code> constructor for the <code>ActivatableItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d590ef4-4cad-4865-9a8d-2290490dd372'>ActivatableItem</a></td><td style='width:75%' class='def'><p>The public <code>ActivatableItem (Foundation.NSObjectFlag)</code> constructor for the <code>ActivatableItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18af9f6d-a738-4d4a-9dfd-73f15f7910eb'>ActivatableItem</a></td><td style='width:75%' ><p>The public <code>ActivatableItem (System.IntPtr)</code> constructor for the <code>ActivatableItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc9b5617-6357-4892-ab54-885bb35948a1'>ActivatableItem</a></td><td style='width:75%' class='def'><p>The public <code>ActivatableItem (System.String)</code> constructor for the <code>ActivatableItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cd47c06-fbe6-44a7-bbb7-32ba9396b79a'>Validate</a></td><td style='width:75%' ><p>The public virtual <code>Validate ()</code> member of the <code>ActivatableItem</code> class.</p>
</td></tr></table></p>


---

<a name="85c5cfff-5452-46bd-a635-bc6028026976"></a>
##Public Class AppDelegate

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSApplicationDelegate`

###Summary

The public `AppDelegate` class inherits from the `AppKit.NSApplicationDelegate` class and is defined in the `KimonoMac` namespace. It defines no fields, no properties, 3 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0793d88b-57ca-4fd7-bf2d-4ab1c25fd876'>AppDelegate</a></td><td style='width:75%' ><p>The public <code>AppDelegate ()</code> constructor for the <code>AppDelegate</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51fa7000-a265-42b6-853d-13fd8360f83e'>DidFinishLaunching</a></td><td style='width:75%' class='def'><p>The public virtual <code>DidFinishLaunching (Foundation.NSNotification)</code> member of the <code>AppDelegate</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b3d4d22-870c-4e50-a488-93256c17bbba'>WillTerminate</a></td><td style='width:75%' ><p>The public virtual <code>WillTerminate (Foundation.NSNotification)</code> member of the <code>AppDelegate</code> class.</p>
</td></tr></table></p>


---

<a name="1c9586fd-9c41-46bf-8bdd-8416188a35a4"></a>
##Public Class CenteringClipView

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSClipView`

###Summary

The public `CenteringClipView` class inherits from the `AppKit.NSClipView` class and is defined in the `KimonoMac` namespace. It defines no fields, no properties, 4 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1b2e0790-2354-45fe-a094-f0551e08b088'>CenteringClipView</a></td><td style='width:75%' ><p>The public <code>CenteringClipView ()</code> constructor for the <code>CenteringClipView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d740894a-2b50-4e8a-9839-575319554fbe'>CenteringClipView</a></td><td style='width:75%' class='def'><p>The public <code>CenteringClipView (System.IntPtr)</code> constructor for the <code>CenteringClipView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0011f38f-dc2f-458f-bef1-02c6ed32c637'>ConstrainBoundsRect</a></td><td style='width:75%' ><p>The public virtual <code>ConstrainBoundsRect (CoreGraphics.CGRect)</code> member of the <code>CenteringClipView</code> class returns a <code>CoreGraphics.CGRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8eb34a3-a92a-4e2b-92fc-d1a42cda7bdf'>ConvertContentInsetsToProposedBoundsSize</a></td><td style='width:75%' class='def'><p>The private <code>ConvertContentInsetsToProposedBoundsSize (CoreGraphics.CGSize)</code> member of the <code>CenteringClipView</code> class returns a <code>AppKit.NSEdgeInsets</code> value.</p>
</td></tr></table></p>


---

<a name="ec2d093d-ce8c-40d5-b0cc-1640e6614119"></a>
##Public Class KimonoInspectorArrow

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorArrow` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 10 fields, 9 properties, 31 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#226f8bbe-0ac7-41eb-89bf-b318d51f8443'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorArrow</code> class holds a <code>KimonoCore.KimonoShapeArrow</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02a6cfe7-0c82-4bba-a2a5-bd11ecef5261'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorArrow</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#953dd786-dc43-478f-9e18-260f480754bf'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorArrow</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad396e84-61ee-41e3-96a9-03637c5f2272'>HeadCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>HeadCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcccbb3d-8135-4b2b-9f5e-80b6159c2c7a'>InnerSlider</a></td><td style='width:75%' ><p>The private read only <code>InnerSlider</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c191894-5441-4343-937f-9163bb1873cc'>InnerValue</a></td><td style='width:75%' class='def'><p>The private read only <code>InnerValue</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d08ca565-4ba2-43f9-b3a2-46bd230d868c'>OuterSlider</a></td><td style='width:75%' ><p>The private read only <code>OuterSlider</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a08046a-fac8-40c8-af40-46be400ed5b7'>OuterValue</a></td><td style='width:75%' class='def'><p>The private read only <code>OuterValue</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#831f559c-e50e-4457-99c8-cd6bcf0aa74d'>SelectedShape</a></td><td style='width:75%' ><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorArrow</code> class has a <code>KimonoCore.KimonoShapeArrow</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1de82342-28a3-4c97-9da1-38989a71d219'>StreamlinedCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>StreamlinedCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efb8257f-69e1-4e2a-ab59-02daf28a1962'>TailCheckbox</a></td><td style='width:75%' ><p>The private read only <code>TailCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ead0d64b-1db1-47b1-a745-6277e847aa1d'>HeadChanged</a></td><td style='width:75%' ><p>The private <code>HeadChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eb991ff-343a-4f44-b274-26c4e7a6984b'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d12e6b5c-6c8b-4dc3-a93b-2343401fa263'>InnerChanged</a></td><td style='width:75%' ><p>The private <code>InnerChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#feedc03b-34a0-488d-b895-a2f5253fd5fd'>KimonoInspectorArrow</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorArrow (System.IntPtr)</code> constructor for the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35634afb-e1ca-4ad2-a722-84eb969c88d4'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorArrow</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e962dc63-6920-4bc5-8e46-b899f543e033'>OuterChanged</a></td><td style='width:75%' class='def'><p>The private <code>OuterChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4ecf91b-dfd9-4f97-a345-cf13939d045a'>RaiseShapeModified</a></td><td style='width:75%' ><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98591941-0fe3-480c-b20a-38bdf1b3164b'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44d41b41-9042-4d08-9771-b5293519af87'>StreamlinedChanged</a></td><td style='width:75%' ><p>The private <code>StreamlinedChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2191478e-1a96-494b-b867-daab20792fc1'>TailChanged</a></td><td style='width:75%' class='def'><p>The private <code>TailChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a9e37be-11a1-4574-b07e-755d2c6cd3e7'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d9929e95-406c-424d-b406-451d13ea49f4'>ShapeModified</a></td><td style='width:75%' ><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorArrow</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="ff84e343-fa58-40cb-b6b6-106a85c91868"></a>
##Public Class KimonoInspectorAttachedStyle

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorAttachedStyle` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 10 fields, 6 properties, 33 methods and 5 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b69f34ca-f456-42ee-adeb-43fb6786e532'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#710cd46c-8cea-4e4e-ad84-738ea252eee2'>_selectedStyle</a></td><td style='width:75%' class='def'><p>The private <code>_selectedStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e2f5068-3260-4fc7-9c20-d8aaba1a5b0e'>ConvertToStyle</a></td><td style='width:75%' ><p>The private <code>ConvertToStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7858f562-02eb-4551-9a83-b9031115f782'>EditAttachedStyle</a></td><td style='width:75%' class='def'><p>The private <code>EditAttachedStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ed90439-b0a1-4ebe-b176-2588dcb164d7'>RemoveStyle</a></td><td style='width:75%' ><p>The private <code>RemoveStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6a048ce-f6cb-4078-a9cf-e8d253514752'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a218ff7a-d7ce-4e88-a760-17cde1500eff'>StyleModified</a></td><td style='width:75%' ><p>The private <code>StyleModified</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#72338e1e-b338-4fbd-a16e-696854bcb738'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5eb79975-ab88-4c8e-b5ab-090514c39ddb'>EditButton</a></td><td style='width:75%' class='def'><p>The private read only <code>EditButton</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa7557e4-aa4c-4979-a51f-f63f5ed2a9c0'>Portfolio</a></td><td style='width:75%' ><p>The public read only <code>Portfolio</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56ec58cd-0a09-4976-a9ce-cb5d5d5eeca4'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b139938a-1073-4333-a2d1-88c193bd89b0'>SelectedStyle</a></td><td style='width:75%' ><p>The public <code>SelectedStyle</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b8ac11e-140e-437a-b16d-4d5b18420bd8'>StyleSelector</a></td><td style='width:75%' class='def'><p>The private read only <code>StyleSelector</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3f72237a-9145-4bba-a273-aa972897b85e'>EditStyle</a></td><td style='width:75%' ><p>The private <code>EditStyle (Foundation.NSObject)</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14011427-2a4b-4ce8-bac8-62a93c24dfe0'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11b5bddc-a8cc-45ba-9694-ca58127b8136'>KimonoInspectorAttachedStyle</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorAttachedStyle (System.IntPtr)</code> constructor for the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a41a6dd-9c8c-4c89-93f5-833c8591e775'>MoveTo</a></td><td style='width:75%' class='def'><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorAttachedStyle</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4677cf5e-e27b-4bad-be03-b474cf3ad31e'>RaiseConvertToStyle</a></td><td style='width:75%' ><p>The  <code>RaiseConvertToStyle ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e1276fa-599a-4de6-8c48-3120c4071058'>RaiseEditAttachedStyle</a></td><td style='width:75%' class='def'><p>The  <code>RaiseEditAttachedStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e1111d9-5896-4df2-8446-a7855d7e510c'>RaiseRemoveStyle</a></td><td style='width:75%' ><p>The  <code>RaiseRemoveStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20a6fa45-aec8-4fbe-8498-9e346064ca6b'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseShapeModified (KimonoCore.KimonoShape)</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ff1647f-76eb-435e-9a64-4cd226fe7093'>RaiseStyleModified</a></td><td style='width:75%' ><p>The  <code>RaiseStyleModified ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dd45148-13ba-4d94-ad6f-be2d0c2a4dcb'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1a45b81-c5d9-417d-9c1e-2524b2b9c373'>StyleChanged</a></td><td style='width:75%' ><p>The private <code>StyleChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75453952-f414-40d4-942b-cea2cf684d3b'>UpdateInspector</a></td><td style='width:75%' class='def'><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#65aced65-6fca-460a-bb69-ef4afb7d169d'>ConvertToStyle</a></td><td style='width:75%' ><p>The <code>ConvertToStyle</code> event of the <code>KimonoInspectorAttachedStyle</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3382dab-82cd-4b1c-84cc-2fa774bd2361'>EditAttachedStyle</a></td><td style='width:75%' class='def'><p>The <code>EditAttachedStyle</code> event of the <code>KimonoInspectorAttachedStyle</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69c5857d-3689-4598-a95e-997e356c86a5'>RemoveStyle</a></td><td style='width:75%' ><p>The <code>RemoveStyle</code> event of the <code>KimonoInspectorAttachedStyle</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad0c6d43-8015-448b-a7e4-9685c80b2658'>ShapeModified</a></td><td style='width:75%' class='def'><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorAttachedStyle</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cf158a9-1eed-4115-83b7-5ba21fade856'>StyleModified</a></td><td style='width:75%' ><p>The <code>StyleModified</code> event of the <code>KimonoInspectorAttachedStyle</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="5a3f4354-d1b2-4fb1-a0bd-4ca279c42022"></a>
##Public Class KimonoInspectorFill

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorFill` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 23 fields, 22 properties, 69 methods and 2 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d32fd6cc-2f0c-44ef-9812-f4f35f9f705f'>_selectedStyle</a></td><td style='width:75%' ><p>The private <code>_selectedStyle</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6c7d0f7-46d8-47ca-9268-9c854b9b6e5a'>MakeNewColor</a></td><td style='width:75%' class='def'><p>The private <code>MakeNewColor</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a2eeb33-c6e1-473c-bdf2-1598ec8634cf'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#572ce4f9-dcf0-4d51-a34b-5f637768e5b2'>AddColorButton</a></td><td style='width:75%' ><p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e038aa0-7bfe-4e94-a0fa-3d1a028b80b7'>AntialiaseCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AntialiaseCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55f2e832-5800-4b04-8df7-42bcb48d2286'>BlendMode</a></td><td style='width:75%' ><p>The private read only <code>BlendMode</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8ad7835-3e9c-426a-b301-c747caac3027'>BlurCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>BlurCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2777f216-8b39-42ce-9170-141f5afc16a4'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorFill</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2637a886-25b5-4925-afb4-8160893f509f'>DeviationSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>DeviationSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80f8c8ad-eb01-48be-b5de-ddc4f16bd717'>DeviationValue</a></td><td style='width:75%' ><p>The private read only <code>DeviationValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d881d62f-74d5-4e24-8f5f-8855e9e08674'>FillCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>FillCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4b4888f-2776-449b-b3cc-a3b3f4ba7bc0'>FillColor</a></td><td style='width:75%' ><p>The private read only <code>FillColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7dd7f160-9371-4509-8f8c-75fa936a79ed'>GradientDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>GradientDropdown</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51cabeed-c7ad-4b5f-a93a-51c04fc83747'>HorizontalBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61f570c9-2585-4430-a4af-1372266f2782'>HorizontalBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd34caff-961e-40f0-9106-f13408d4cd5f'>JitterCheckbox</a></td><td style='width:75%' ><p>The private read only <code>JitterCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e710119-1276-4545-908d-efc6a1038f81'>LengthSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>LengthSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1303a516-05d5-440a-8a82-c41757ad6500'>LengthValue</a></td><td style='width:75%' ><p>The private read only <code>LengthValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b22b3fcb-5305-4d7e-a74e-0763f806b2b4'>LinkedColorSelector</a></td><td style='width:75%' class='def'><p>The private read only <code>LinkedColorSelector</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ab7c4a5-fd88-4639-b981-ebde2f279def'>OpacitySlider</a></td><td style='width:75%' ><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad580012-efbf-46db-bfae-71b6683179ed'>OpacityValue</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee5abe5f-756c-41c0-9b39-131952d1148b'>Portfolio</a></td><td style='width:75%' ><p>The public read only <code>Portfolio</code> property of the <code>KimonoInspectorFill</code> class has a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ce5f811-eaf4-4afe-8f98-9d7a0c1c1d89'>SelectedStyle</a></td><td style='width:75%' class='def'><p>The public <code>SelectedStyle</code> property of the <code>KimonoInspectorFill</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dd6be13-a4ce-4670-904b-657cb8868e16'>VerticalBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>VerticalBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6a8aeea-8521-4b87-9e3e-8a68aff29403'>VerticalBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7addaa15-137d-4b78-8991-88377dd40fb2'>AddColor</a></td><td style='width:75%' ><p>The private <code>AddColor (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a71efa7d-b167-4fd6-93df-f548af89c17b'>AntialiaseChanged</a></td><td style='width:75%' class='def'><p>The private <code>AntialiaseChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#942d410a-c885-4b86-a19f-4a2bf675d46a'>BlendModeChanged</a></td><td style='width:75%' ><p>The private <code>BlendModeChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb44032c-230f-4c0d-9b8d-4f090e63e584'>BlurChanged</a></td><td style='width:75%' class='def'><p>The private <code>BlurChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a780034-3c5c-4b32-8886-ef6443f13cef'>DeviationChanged</a></td><td style='width:75%' ><p>The private <code>DeviationChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0adc62da-9b8a-46f6-8af2-eb568d6c61d1'>FillChanged</a></td><td style='width:75%' class='def'><p>The private <code>FillChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9c84c66-5879-4974-96bf-dcc3d3931a77'>FillColorChanged</a></td><td style='width:75%' ><p>The private <code>FillColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe8b9927-3203-41f2-8c0f-4fe910f738df'>GradientChanged</a></td><td style='width:75%' class='def'><p>The private <code>GradientChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f0702a3-9085-4c9e-b6a9-1b4f6d8ffb1f'>HorizontalBlurChanged</a></td><td style='width:75%' ><p>The private <code>HorizontalBlurChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77a7318f-747c-48d9-8b19-494a64441222'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f1aac23-260f-42aa-a07e-a47d5ceee6de'>JitterChanged</a></td><td style='width:75%' ><p>The private <code>JitterChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41b51610-a48f-4b39-b598-b5f5e5e76fa1'>KimonoInspectorFill</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorFill (System.IntPtr)</code> constructor for the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#912b30e3-5aea-45a7-928e-aecd07cf2402'>LengthChanged</a></td><td style='width:75%' ><p>The private <code>LengthChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b82b09a0-3f34-49fe-8226-3baa293d0d23'>LinkedColorChanged</a></td><td style='width:75%' class='def'><p>The private <code>LinkedColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea137135-ea88-47c0-8d78-d40a1cba5de2'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorFill</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf46ec25-d706-4cc3-a096-4bc3a2428d76'>OpacityChanged</a></td><td style='width:75%' class='def'><p>The private <code>OpacityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa3fa108-1e54-4063-b5c6-073bd9636d84'>RaiseMakeNewColor</a></td><td style='width:75%' ><p>The  <code>RaiseMakeNewColor (SkiaSharp.SKColor)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#864d461b-9843-4c99-a9b5-8745bb60d188'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62f0fa2a-8a4f-4ccd-a082-6b7276d84403'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c8a4343-8a8b-43e3-802f-b24a6b80837c'>ShowCurrentColor</a></td><td style='width:75%' class='def'><p>The private <code>ShowCurrentColor ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fb006cd-be77-4ffa-b7df-9997fbf4235a'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f17c626-bf44-40e0-8909-dc673492fead'>VerticalBlurChanged</a></td><td style='width:75%' class='def'><p>The private <code>VerticalBlurChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5a428823-ce86-4382-8b07-ff4af196583a'>MakeNewColor</a></td><td style='width:75%' ><p>The <code>MakeNewColor</code> event of the <code>KimonoInspectorFill</code> class returns a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26f4d650-a572-4934-988c-05ed5c4c9907'>ShapeModified</a></td><td style='width:75%' class='def'><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorFill</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="a50ac7b7-6b94-4bc1-9316-853d036a6761"></a>
##Public Class KimonoInspectorFont

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorFont` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 16 fields, 14 properties, 50 methods and 2 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#61b32667-a800-424b-87cf-c5b233f82cc6'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#004b725b-c4ad-4cf4-b35f-2fd1e3a285fe'>_selectedStyle</a></td><td style='width:75%' class='def'><p>The private <code>_selectedStyle</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5692941-cf17-4084-ba13-7ff6d1a77a48'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb980fc6-9c13-4a48-9943-10bad114d735'>StyleModified</a></td><td style='width:75%' class='def'><p>The private <code>StyleModified</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#387e7464-a981-4f73-8f09-bfb3f88595d0'>Alignment</a></td><td style='width:75%' ><p>The private read only <code>Alignment</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSegmentedControl</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5b76d82-e318-4702-8758-4f01eefa2db9'>DesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorFont</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0689dc37-a016-4f13-ac97-ac2daaf93e21'>ScaleSlider</a></td><td style='width:75%' ><p>The private read only <code>ScaleSlider</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9d562ea-512b-405d-9a8d-50e6d077589f'>ScaleValue</a></td><td style='width:75%' class='def'><p>The private read only <code>ScaleValue</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ed5ce01-8902-4084-976a-b4068d124837'>SelectedShape</a></td><td style='width:75%' ><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorFont</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72e59244-57c0-42ea-a343-944d1cc47029'>SelectedStyle</a></td><td style='width:75%' class='def'><p>The public <code>SelectedStyle</code> property of the <code>KimonoInspectorFont</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfca10b6-4bbc-4edf-a470-3ffb508c0f78'>Size</a></td><td style='width:75%' ><p>The private read only <code>Size</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSComboBox</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f52e6fc-64d4-4760-aa85-b9b76dc806c9'>SkewSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>SkewSlider</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5650b4bd-9480-47f9-9c17-aaba1656e282'>SkewValue</a></td><td style='width:75%' ><p>The private read only <code>SkewValue</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b31a2a96-0692-4e48-a23c-2353340fef34'>StrikeThruCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>StrikeThruCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c64b3c7-5a65-472d-9501-101915a65eca'>TypefaceDropdown</a></td><td style='width:75%' ><p>The private read only <code>TypefaceDropdown</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b8ef83f-bd78-4c82-8e50-83713f5f1deb'>UnderlineCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>UnderlineCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#634dc2e5-8d57-4113-9e8d-3367f647049b'>VerticalCheckbox</a></td><td style='width:75%' ><p>The private read only <code>VerticalCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56fe9e76-150a-48e9-af25-331d360c828c'>WeightDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>WeightDropdown</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0e1ba524-1155-41d1-aa76-6ed54ae1f752'>AlignmentChanged</a></td><td style='width:75%' ><p>The private <code>AlignmentChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9722831-7f20-4f83-948b-691fdcd6512e'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3c9d1d7-bae1-4954-9263-0b96874d59f1'>KimonoInspectorFont</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorFont (System.IntPtr)</code> constructor for the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#454ef24b-e41e-44bd-8938-98c2e77e7523'>MoveTo</a></td><td style='width:75%' class='def'><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorFont</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c497619b-6628-4ef8-8f39-81f4cdbee289'>RaiseShapeModified</a></td><td style='width:75%' ><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70220db1-881d-4efe-9870-4d2742f3a183'>RaiseStyleModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseStyleModified ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#356cdfd3-8bce-4c0f-b173-786a8831a957'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2ac416b-e920-4f17-b43e-65cd280e57ed'>ScaleChanged</a></td><td style='width:75%' class='def'><p>The private <code>ScaleChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfdc0851-730e-48f3-bec0-9a45fde3e5fa'>SelectFontFamily</a></td><td style='width:75%' ><p>The private <code>SelectFontFamily (System.String)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc1b4dd6-5566-4431-9e25-b69f63d68ed3'>SizeChanged</a></td><td style='width:75%' class='def'><p>The private <code>SizeChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddfb04ec-8f31-434e-afa1-03923debe223'>SkewChanged</a></td><td style='width:75%' ><p>The private <code>SkewChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa423925-cd13-4363-bad6-9c881048ea70'>StrikeThruChanged</a></td><td style='width:75%' class='def'><p>The private <code>StrikeThruChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97a8c814-5a79-42a3-8ad4-e0fb6400583d'>TypefaceChanged</a></td><td style='width:75%' ><p>The private <code>TypefaceChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#879a3f6f-26ac-47b8-9eb7-1a91022aca57'>UnderlineChanged</a></td><td style='width:75%' class='def'><p>The private <code>UnderlineChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2745e845-a081-44cf-b28a-f7f747436ffe'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68c859c4-11b6-4e2a-957d-b408e63aa32d'>VerticalChanged</a></td><td style='width:75%' class='def'><p>The private <code>VerticalChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcbaf200-b137-45d9-b84a-d945b0721ed8'>WeightChanged</a></td><td style='width:75%' ><p>The private <code>WeightChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#04e2952e-7e0b-46c1-b64a-d2782ca41aa0'>ShapeModified</a></td><td style='width:75%' ><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorFont</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb35d18c-69be-43e3-87ac-5c573328cd42'>StyleModified</a></td><td style='width:75%' class='def'><p>The <code>StyleModified</code> event of the <code>KimonoInspectorFont</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="df0cadf3-a029-444e-a899-d6857919e56f"></a>
##Public Class KimonoInspectorFrame

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorFrame` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 46 fields, 45 properties, 137 methods and 2 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0a8893b5-e6a2-415a-8701-a967b2c92a78'>_selectedStyle</a></td><td style='width:75%' ><p>The private <code>_selectedStyle</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bf02d05-b18c-4e40-9d44-3405c2f2dad3'>MakeNewColor</a></td><td style='width:75%' class='def'><p>The private <code>MakeNewColor</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d102163b-08eb-4d0d-9861-3bcb4a6ba314'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#80e19e20-a681-44c5-8151-78d1ed25287d'>AddColorButton</a></td><td style='width:75%' ><p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eacec212-0498-4e50-89a3-d18119f68423'>AntialiasCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AntialiasCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21b8a845-0bf0-4395-a373-1e1bc80109e2'>BlendMode</a></td><td style='width:75%' ><p>The private read only <code>BlendMode</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b689ef9-2680-4818-8e7e-7e504cfdc859'>BlurCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>BlurCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c187bfd-fc65-44b9-9de6-55358ff1c2bb'>Dash1</a></td><td style='width:75%' ><p>The private read only <code>Dash1</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85c2797e-1df5-43ae-baf5-47ba159b25a8'>Dash10</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash10</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b45502be-62bd-44bf-bec3-d62e9954d5b1'>Dash11</a></td><td style='width:75%' ><p>The private read only <code>Dash11</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9cecab6d-6c32-4dfa-bc4d-4425cc799804'>Dash12</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash12</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36432e84-3e2a-4d31-81bf-b7100deb1075'>Dash13</a></td><td style='width:75%' ><p>The private read only <code>Dash13</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fadf8b1-0003-4951-8900-7e935c3eb653'>Dash14</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash14</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a6203aa-dc8b-46c3-850b-0b83c1a5b9c3'>Dash15</a></td><td style='width:75%' ><p>The private read only <code>Dash15</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa99e79d-2128-431f-ad2b-ab946dea4032'>Dash16</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash16</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a60e87a-561c-42ff-8c1c-4947b79c3995'>Dash2</a></td><td style='width:75%' ><p>The private read only <code>Dash2</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a64fb513-a323-483e-a11d-862171b169c2'>Dash3</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash3</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43cc722f-f563-42f5-b662-91788874e816'>Dash4</a></td><td style='width:75%' ><p>The private read only <code>Dash4</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2126ef00-449c-49f6-869d-74f6684d5ae6'>Dash5</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash5</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd44eef5-81c0-45ba-988a-e50c6c47b06c'>Dash6</a></td><td style='width:75%' ><p>The private read only <code>Dash6</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#addee740-9b9e-48e2-8a66-457eb785e595'>Dash7</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash7</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ad788af-4d2e-4bfb-bde1-898f6991382a'>Dash8</a></td><td style='width:75%' ><p>The private read only <code>Dash8</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01555121-3efa-4ecd-92f3-9bd61ccc52ba'>Dash9</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash9</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87ad1660-3a7a-4ce5-b27b-890dd86f33f9'>DashCheckbox</a></td><td style='width:75%' ><p>The private read only <code>DashCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25271ad0-88ac-49e7-942f-522d83e524c9'>DesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorFrame</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2de50ca1-1889-4e4a-9261-8d1372c7faa9'>DeviationSlider</a></td><td style='width:75%' ><p>The private read only <code>DeviationSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc521e67-0217-4039-bdac-8f0e262d01eb'>DeviationValue</a></td><td style='width:75%' class='def'><p>The private read only <code>DeviationValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#971456eb-1fac-4293-a1be-7320be49b155'>EndCap</a></td><td style='width:75%' ><p>The private read only <code>EndCap</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20fe12de-5c9e-417d-8dec-3c5a9ed835f6'>FrameCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>FrameCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40354962-434f-4ab6-bb7c-611fb52d3799'>FrameColor</a></td><td style='width:75%' ><p>The private read only <code>FrameColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90edc16b-e739-48ad-b4d9-dec2db6a5b0f'>GradientDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>GradientDropdown</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8726397a-a6d1-42ff-96a9-372ebe03fe20'>HorizontalBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01093757-49d3-4848-81b6-146615bf660c'>HorizontalBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e781bd26-d95f-4285-a1f2-e85525349186'>JitterCheckbox</a></td><td style='width:75%' ><p>The private read only <code>JitterCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5504504c-6448-4ce8-8dc7-3326d3623c7d'>JoinType</a></td><td style='width:75%' class='def'><p>The private read only <code>JoinType</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20bb2638-c508-42b9-9f98-06dcf8cf8dfe'>LengthSlider</a></td><td style='width:75%' ><p>The private read only <code>LengthSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ed84530-b8f6-4db6-93c6-b12a620c5ee8'>LengthValue</a></td><td style='width:75%' class='def'><p>The private read only <code>LengthValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33bcf6f4-345d-49bf-b899-4e3b6eebafb0'>LinkedColorSelector</a></td><td style='width:75%' ><p>The private read only <code>LinkedColorSelector</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76442057-ef47-4b48-964d-c173d615fe98'>MiterSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>MiterSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57635a91-175e-44f0-933d-f9a896049768'>MiterValue</a></td><td style='width:75%' ><p>The private read only <code>MiterValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#460a800f-720b-44e7-abc2-1e8d2f2cb691'>OpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d021a58-2a5e-42cc-a5fb-9da2153f7646'>OpacityValue</a></td><td style='width:75%' ><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d06775b-0dfc-44ef-a4e9-65ae8d092c99'>Portfolio</a></td><td style='width:75%' class='def'><p>The public read only <code>Portfolio</code> property of the <code>KimonoInspectorFrame</code> class has a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41e3e4cc-32b5-4a7d-9037-c62fe25a40d3'>SelectedStyle</a></td><td style='width:75%' ><p>The public <code>SelectedStyle</code> property of the <code>KimonoInspectorFrame</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e571947-cadc-4d1b-a796-6a2850afd76c'>VerticalBlurSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#767037be-a8ae-4513-92d9-0349285e66ff'>VerticalBlurValue</a></td><td style='width:75%' ><p>The private read only <code>VerticalBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b4658f5-4d78-489a-8678-9f7caa570355'>WidthSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>WidthSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7592c6b0-bab8-4755-ba9b-4c7267e60a29'>WidthValue</a></td><td style='width:75%' ><p>The private read only <code>WidthValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2b7a5b0e-2df7-46e1-8ebb-3a09807ffd63'>AddColor</a></td><td style='width:75%' ><p>The private <code>AddColor (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a386448f-cf4c-444e-a044-de22df3a519e'>AntialiasChanged</a></td><td style='width:75%' class='def'><p>The private <code>AntialiasChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d0a8b28-9d9b-4158-a5cd-d6342a9cbee1'>BlendModeChanged</a></td><td style='width:75%' ><p>The private <code>BlendModeChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aecc211e-3994-4838-a903-a25b8669a77e'>BlurChanged</a></td><td style='width:75%' class='def'><p>The private <code>BlurChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aff9cce3-3ad8-43cc-9a77-2cb25a6df2f0'>Dash10Changed</a></td><td style='width:75%' ><p>The private <code>Dash10Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a1ea685-0db4-4759-81ee-7bdca200d8e6'>Dash11Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash11Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98281119-0b10-4555-a211-f21062415b85'>Dash12Changed</a></td><td style='width:75%' ><p>The private <code>Dash12Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a45ab55a-7a69-402d-8d43-e66b4b20d534'>Dash13Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash13Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad2ca0c1-ae4b-40ff-b4ed-646c32ece25e'>Dash14Changed</a></td><td style='width:75%' ><p>The private <code>Dash14Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e02f1fa1-acf0-436e-a326-6250eebbd75d'>Dash15Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash15Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b383d78a-ed2b-4fc5-b0ce-d522c1f500d7'>Dash16Changed</a></td><td style='width:75%' ><p>The private <code>Dash16Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dfba120-ccba-4d15-a418-c779cc51ead1'>Dash1Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash1Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b171ba37-51a2-4d51-ae78-56df4acac28e'>Dash2Changed</a></td><td style='width:75%' ><p>The private <code>Dash2Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cd75468-0070-4578-8867-1ab14ac948aa'>Dash3Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash3Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ba45669-4e05-4b84-a2b0-5ffb2e4861b1'>Dash4Changed</a></td><td style='width:75%' ><p>The private <code>Dash4Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e993e072-d5e9-4437-bcf8-e5c1a0f53298'>Dash5Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash5Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19db634c-19ea-47bb-a1bc-f7a145ad99b0'>Dash6Changed</a></td><td style='width:75%' ><p>The private <code>Dash6Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea77ff5c-1515-4830-8c14-0da6ff73fd2e'>Dash7Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash7Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3ad1eee-4f24-4b32-ad7c-234a08375a88'>Dash8Changed</a></td><td style='width:75%' ><p>The private <code>Dash8Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83b02f4d-88d1-432e-8129-72bd50a1f18e'>Dash9Changed</a></td><td style='width:75%' class='def'><p>The private <code>Dash9Changed (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93263d95-4ca5-46e4-8964-776e676fea1b'>DashChanged</a></td><td style='width:75%' ><p>The private <code>DashChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9effdea-6499-41a3-ab5a-550b235c7268'>DeviationChanged</a></td><td style='width:75%' class='def'><p>The private <code>DeviationChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89f35bad-4982-4ad5-84a1-bdef4e4366ab'>EndCapChanged</a></td><td style='width:75%' ><p>The private <code>EndCapChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6648015a-4f72-4613-8590-7a0e55a6d808'>FrameChanged</a></td><td style='width:75%' class='def'><p>The private <code>FrameChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05ebbbed-e9a9-406b-b1bf-e375bc189caf'>FrameColorChanged</a></td><td style='width:75%' ><p>The private <code>FrameColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce7fd85f-bd66-45ef-932b-7a0c93a1bdf9'>GradientChanged</a></td><td style='width:75%' class='def'><p>The private <code>GradientChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76a623ae-d883-4490-b505-a7fc6428b34a'>HorizontalBlurChanged</a></td><td style='width:75%' ><p>The private <code>HorizontalBlurChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5120a60e-11bf-450c-9154-e738ae87585d'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8621ab32-823e-454a-a1d8-517df3c4293e'>JitterChanged</a></td><td style='width:75%' ><p>The private <code>JitterChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f87e7635-40c9-4ed6-b801-1396d8511a2c'>JoinTypeChanged</a></td><td style='width:75%' class='def'><p>The private <code>JoinTypeChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f0d4693-0ded-453f-86fb-7560197e5871'>KimonoInspectorFrame</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorFrame (System.IntPtr)</code> constructor for the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e36922ec-93fc-47f8-b1dd-24f96d3ed079'>LengthChanged</a></td><td style='width:75%' class='def'><p>The private <code>LengthChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#395eb0a2-de9a-46b7-a07f-49d22a8a2c88'>LinkedColorChanged</a></td><td style='width:75%' ><p>The private <code>LinkedColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46b840af-7134-44ae-9697-d8cf71b02bce'>MiterChanged</a></td><td style='width:75%' class='def'><p>The private <code>MiterChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a9e31ca-433c-4535-a500-4e7c84b64121'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorFrame</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56cbd23e-e688-4a43-8233-7c807d164193'>OpacityChanged</a></td><td style='width:75%' class='def'><p>The private <code>OpacityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9293983-fcf0-42f3-9745-09088bd21500'>RaiseMakeNewColor</a></td><td style='width:75%' ><p>The  <code>RaiseMakeNewColor (SkiaSharp.SKColor)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0b31d0b-8540-4e5e-8cde-62df6bdc1b58'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d4baacc-03f5-4a27-ba8d-20262e4c3aec'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12d90d09-0e5d-4073-89f2-5d2b15eae5d1'>ShowCurrentColor</a></td><td style='width:75%' class='def'><p>The private <code>ShowCurrentColor ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d5558a4-6586-4a57-8de2-1ae90cf0457b'>ShowDashEditor</a></td><td style='width:75%' ><p>The private <code>ShowDashEditor ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d92dcd16-5a16-4cf5-9bd8-9f960ac9e853'>UpdateInspector</a></td><td style='width:75%' class='def'><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc706412-9eac-4049-803c-4f947150a7d5'>VerticalBlurChanged</a></td><td style='width:75%' ><p>The private <code>VerticalBlurChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2194aa4e-c361-4ca4-8559-db7d56ce1a09'>WidthChanged</a></td><td style='width:75%' class='def'><p>The private <code>WidthChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5df7b27e-5466-40ff-8bb0-148efac8cad0'>MakeNewColor</a></td><td style='width:75%' ><p>The <code>MakeNewColor</code> event of the <code>KimonoInspectorFrame</code> class returns a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86f16778-c8e4-4079-ba8a-b8e426d00193'>ShapeModified</a></td><td style='width:75%' class='def'><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorFrame</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="e36b0e08-8c34-452a-ae2f-60578ed14dcd"></a>
##Public Class KimonoInspectorGeneralInfo

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorGeneralInfo` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 18 fields, 13 properties, 57 methods and 5 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4ac96772-653f-48ea-9622-0e3f1a6975d0'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6700cee4-a904-45f3-8bb9-982b10f76095'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efeedd02-30b8-4c78-9ec5-b54e0ca3d040'>RemoveShape</a></td><td style='width:75%' ><p>The private <code>RemoveShape</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9d57952-754b-4030-a9b9-8eb6485c4faf'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectionChanged</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#713de8f5-5111-4d17-9653-7eca8461d3fd'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#147b1d26-e98b-444a-adb4-a06fa1319831'>SketchModified</a></td><td style='width:75%' class='def'><p>The private <code>SketchModified</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d94a2cc-d5c5-4aca-b52b-1219775aa089'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31c0f260-bdac-4baf-8d6d-6856bc7b3f82'>EditButton</a></td><td style='width:75%' class='def'><p>The private read only <code>EditButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2085b477-96c2-45a9-b9bc-f8011704cb65'>GroupUngroupButton</a></td><td style='width:75%' ><p>The private read only <code>GroupUngroupButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4265b61d-8a12-40a5-972c-282723357b89'>RotationSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>RotationSlider</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4acf2da-20e6-4578-a4b0-9f4b1b6f6173'>RotationValue</a></td><td style='width:75%' ><p>The private read only <code>RotationValue</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44c5e62c-6456-4c06-99f0-7e238ab8011c'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d1d2d97-3294-4fa9-b169-3a5e92e0a3da'>ShapeHeight</a></td><td style='width:75%' ><p>The private read only <code>ShapeHeight</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c21ad47-aaf0-4f76-9829-cca073cccda3'>ShapeName</a></td><td style='width:75%' class='def'><p>The private read only <code>ShapeName</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#140b1c03-4f34-4f65-a0b4-61d1883ad233'>ShapeType</a></td><td style='width:75%' ><p>The private read only <code>ShapeType</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#241606ad-5f48-4a21-a0b7-9c08fabd25e8'>ShapeWidth</a></td><td style='width:75%' class='def'><p>The private read only <code>ShapeWidth</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#815fb56f-e8f2-40c5-a28a-f96b3493d8d7'>ShapeX</a></td><td style='width:75%' ><p>The private read only <code>ShapeX</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#197f26df-9542-4f91-b863-44338ca2b444'>ShapeY</a></td><td style='width:75%' class='def'><p>The private read only <code>ShapeY</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0e067f0-1094-4370-aadb-2438d2115608'>VisibleButton</a></td><td style='width:75%' ><p>The private read only <code>VisibleButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cede4770-a452-45f8-8f9a-2d80e40d76fc'>DeleteShape</a></td><td style='width:75%' ><p>The private <code>DeleteShape (Foundation.NSObject)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11798e99-13f0-40a0-bf99-ca900ab2bbe0'>DuplicateShape</a></td><td style='width:75%' class='def'><p>The private <code>DuplicateShape (Foundation.NSObject)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6eaa6ce2-1cf8-4c4a-9aa4-30ba5ce50799'>EditOrFinalizeShape</a></td><td style='width:75%' ><p>The private <code>EditOrFinalizeShape (Foundation.NSObject)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6847a4a-6a46-4564-a88c-cea6c8612efb'>GroupUngroupShapes</a></td><td style='width:75%' class='def'><p>The private <code>GroupUngroupShapes (Foundation.NSObject)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2466b190-5248-4e46-9348-368e288749fa'>Initialize</a></td><td style='width:75%' ><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e22b7786-4bb7-464a-96ac-9c96d7204433'>KimonoInspectorGeneralInfo</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorGeneralInfo (System.IntPtr)</code> constructor for the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d47f57a4-1401-44a6-a6a7-10d048adf541'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorGeneralInfo</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c86939f-2501-4a0f-bf28-47409df72606'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p>The  <code>RaiseMakeDuplicate ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4272a9d9-82c8-41b0-b9aa-e23cfa84c8ce'>RaiseRemoveShape</a></td><td style='width:75%' ><p>The  <code>RaiseRemoveShape ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fe3601d-70b2-4b94-899e-f16e69841d24'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSelectionChanged (KimonoCore.KimonoShape)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cadee3e-f886-4909-804c-f9f4fe33cc65'>RaiseShapeModified</a></td><td style='width:75%' ><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e754f581-1c73-4f62-843a-91971c20bb24'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSketchModified ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08798a82-8e85-4842-8282-a8d9c623d119'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4086c06-cb4b-46aa-944f-899a8a923e54'>RotationChanged</a></td><td style='width:75%' class='def'><p>The private <code>RotationChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9447178-4c28-4fa3-96c7-16dd49ec5ef5'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#869b4f91-67b8-4b4c-8eb4-2147b1538226'>VisibilityChanged</a></td><td style='width:75%' class='def'><p>The private <code>VisibilityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3551ae81-5eae-4faf-9360-6a7b8c20fab8'>MakeDuplicate</a></td><td style='width:75%' ><p>The <code>MakeDuplicate</code> event of the <code>KimonoInspectorGeneralInfo</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c9eaed2-6c4d-4725-b2e3-338a0ab42466'>RemoveShape</a></td><td style='width:75%' class='def'><p>The <code>RemoveShape</code> event of the <code>KimonoInspectorGeneralInfo</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30575d99-1407-43de-bbf0-10eaeaffd3a2'>SelectionChanged</a></td><td style='width:75%' ><p>The <code>SelectionChanged</code> event of the <code>KimonoInspectorGeneralInfo</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c794eff4-0e1f-4ab3-89e9-eb23f9f05951'>ShapeModified</a></td><td style='width:75%' class='def'><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorGeneralInfo</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0228cf20-4e2d-4b13-bdcd-d5c2ccd6f6ac'>SketchModified</a></td><td style='width:75%' ><p>The <code>SketchModified</code> event of the <code>KimonoInspectorGeneralInfo</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="e50f6195-392c-42de-9b13-7433a22ed099"></a>
##Public Class KimonoInspectorGradient

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorGradient` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 27 fields, 23 properties, 82 methods and 5 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#01f186d2-9da1-4a93-9c1a-4d89efb842a1'>_selectedGradient</a></td><td style='width:75%' ><p>The private <code>_selectedGradient</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#754ee023-dfb0-4541-90bf-3c6fe6f177f6'>_selectedShape</a></td><td style='width:75%' class='def'><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cc7b234-5d5f-47e0-9eb5-9d0beb03a16d'>GradientModified</a></td><td style='width:75%' ><p>The private <code>GradientModified</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f068d852-531b-477b-8b88-e9aae4b55d30'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d9ccaff-8127-4dd7-9042-f0d55510986f'>RemoveGradient</a></td><td style='width:75%' ><p>The private <code>RemoveGradient</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf327f91-8f0a-458b-a7d7-7d564f4e60af'>ReturnToShape</a></td><td style='width:75%' class='def'><p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c49ac6c-46b1-493c-afb4-9cb249c34ba6'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cf44b36f-b9c6-4ae6-a623-dfb4b6dfa39b'>AddColorButton</a></td><td style='width:75%' ><p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2554f3ef-46ac-49c5-a049-79ddc74fb135'>AddPointButton</a></td><td style='width:75%' class='def'><p>The private read only <code>AddPointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68ecccf0-8e10-43f6-a7cf-8c6384fb7973'>BackButton</a></td><td style='width:75%' ><p>The private read only <code>BackButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d6ecdc4-8c78-4baa-8042-464957a43f82'>DeleteButton</a></td><td style='width:75%' class='def'><p>The private read only <code>DeleteButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11566787-ceeb-40fa-a7c3-0c29ac3ac318'>DeletePointButton</a></td><td style='width:75%' ><p>The private read only <code>DeletePointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da6d364c-138e-4fd3-b01b-1e70c39c8ec9'>DesignBar</a></td><td style='width:75%' class='def'><p>The private read only <code>DesignBar</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoGradientDesignBar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f0d875d-c310-458b-b181-c49597e72584'>DesignPreview</a></td><td style='width:75%' ><p>The private read only <code>DesignPreview</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoGradientDesignPreview</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#534933cf-6767-4d9f-a940-c749622b12f7'>DesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a7d574f-0c50-4a09-b20d-8073677ebad8'>DuplicateButton</a></td><td style='width:75%' ><p>The private read only <code>DuplicateButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b672e30b-0f9b-4f3e-9b4e-1fb04b25cfa8'>DuplicatePointButton</a></td><td style='width:75%' class='def'><p>The private read only <code>DuplicatePointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfb411ce-a139-43ad-b931-f1e0fa02d3e5'>GradientName</a></td><td style='width:75%' ><p>The private read only <code>GradientName</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6183820-0e69-4eda-bb65-5ab4dd2b6e2a'>LinkedColorDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>LinkedColorDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2597aec9-f590-4489-960e-1c701ab2f017'>OpacitySlider</a></td><td style='width:75%' ><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#930d2ef8-14c2-435e-bb20-3827fbff2f82'>OpacityValue</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#180e8858-67ae-4881-b18d-9cd5a111f48e'>PointColor</a></td><td style='width:75%' ><p>The private read only <code>PointColor</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05ab9939-6c8a-46fd-baeb-280be0ceba83'>Portfolio</a></td><td style='width:75%' class='def'><p>The public read only <code>Portfolio</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d05ea4d-d8be-4553-a806-dd6061a313b7'>RadiusSlider</a></td><td style='width:75%' ><p>The private read only <code>RadiusSlider</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3ced308-9970-4766-b94c-696dc9220c0f'>RadiusValue</a></td><td style='width:75%' class='def'><p>The private read only <code>RadiusValue</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1dc34a1-39fc-4ff0-bd9d-12c3f727d3d9'>SelectedColorTitle</a></td><td style='width:75%' ><p>The private read only <code>SelectedColorTitle</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b2591fb-d8d6-4ff6-b412-eb606d7d4544'>SelectedGradient</a></td><td style='width:75%' class='def'><p>The public <code>SelectedGradient</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e001373c-72dd-43ec-98a0-0f922d56e0fa'>SelectedShape</a></td><td style='width:75%' ><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#113a842d-9293-4cb7-ae7d-d2fff979374d'>TileDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>TileDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b58600a-8d52-4219-932b-c6cf434cc41e'>TypeDropdown</a></td><td style='width:75%' ><p>The private read only <code>TypeDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#44ab1148-e098-4e3a-9c94-1ee8dc91fb14'>AddColor</a></td><td style='width:75%' ><p>The private <code>AddColor (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c91e199-d929-4940-9820-d945b9e208e6'>AddPoint</a></td><td style='width:75%' class='def'><p>The private <code>AddPoint (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b50d174-630d-4a7a-a69e-9717d31f1acd'>DeleteGradient</a></td><td style='width:75%' ><p>The private <code>DeleteGradient (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#566826d0-ed6c-40d8-99f8-1562da503753'>DeletePoint</a></td><td style='width:75%' class='def'><p>The private <code>DeletePoint (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d6aa38b-f954-41aa-af7e-7abce0f38808'>DuplicateGradient</a></td><td style='width:75%' ><p>The private <code>DuplicateGradient (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a4a6591-8092-4c09-b278-6484261f3270'>DuplicatePoint</a></td><td style='width:75%' class='def'><p>The private <code>DuplicatePoint (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71bf05ef-d331-45f0-9dc2-6e93a47d1980'>GoBack</a></td><td style='width:75%' ><p>The private <code>GoBack (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55e2a9fa-3b7b-4fd9-a968-ca6d8555f3b2'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b857853-a65d-480d-8293-e73b1486780f'>KimonoInspectorGradient</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorGradient (System.IntPtr)</code> constructor for the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5ff76bd-6439-4488-abc9-cbec0b3e91c4'>LinkedColorChanged</a></td><td style='width:75%' class='def'><p>The private <code>LinkedColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9797f19c-8b87-496b-8e3c-a040a52a307b'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorGradient</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3415957a-4c98-4e98-9a50-86208ef9727c'>OpacityChanged</a></td><td style='width:75%' class='def'><p>The private <code>OpacityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4f0cfa6-89dd-4614-947d-32a15af747bd'>PointColorChanged</a></td><td style='width:75%' ><p>The private <code>PointColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#836564b6-c542-4671-941b-3d8daff6f019'>RadiusChanged</a></td><td style='width:75%' class='def'><p>The private <code>RadiusChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dd0f709-fb75-4a51-bb13-6911fd83f257'>RaiseGradientModified</a></td><td style='width:75%' ><p>The  <code>RaiseGradientModified (KimonoCore.KimonoGradient)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b1a0aee-1aa2-4a25-9091-ed7077a25fb9'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p>The  <code>RaiseMakeDuplicate (KimonoCore.KimonoGradient)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#240d1d3c-0d52-48af-a574-f7599d641177'>RaiseRemoveGradient</a></td><td style='width:75%' ><p>The  <code>RaiseRemoveGradient (KimonoCore.KimonoGradient)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f31fcca3-7b61-4ef9-8a05-36534592194e'>RaiseReturnToShape</a></td><td style='width:75%' class='def'><p>The  <code>RaiseReturnToShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3619f1b-d17d-4071-9983-dc0a85b90a47'>RaiseShapeModified</a></td><td style='width:75%' ><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c114c9bd-faef-4cca-aa94-c2da77ebeb3e'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5db5594-3961-47e7-b4e0-f39b46a088df'>ShowCurrentColor</a></td><td style='width:75%' ><p>The private <code>ShowCurrentColor ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7f9ae94-deda-43f5-ae65-8690415e6d56'>TileChanged</a></td><td style='width:75%' class='def'><p>The private <code>TileChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d84791c0-00e6-42c0-8ddd-176e2d70c230'>TypeChanged</a></td><td style='width:75%' ><p>The private <code>TypeChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05313bc2-2908-40c4-8e30-c52366831c47'>UpdateInspector</a></td><td style='width:75%' class='def'><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#744dd5e7-9e5e-48f0-b229-6bf3c18076b6'>GradientModified</a></td><td style='width:75%' ><p>The <code>GradientModified</code> event of the <code>KimonoInspectorGradient</code> class returns a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eefc7b73-2a7a-4622-bcf9-afe785b50a0c'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The <code>MakeDuplicate</code> event of the <code>KimonoInspectorGradient</code> class returns a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04e141d2-bb3f-4fc1-919d-b15df892ed09'>RemoveGradient</a></td><td style='width:75%' ><p>The <code>RemoveGradient</code> event of the <code>KimonoInspectorGradient</code> class returns a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5539355f-5803-47b0-a38c-fadb53c2a6dc'>ReturnToShape</a></td><td style='width:75%' class='def'><p>The <code>ReturnToShape</code> event of the <code>KimonoInspectorGradient</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66eee82c-87d3-47d5-8d73-4e65ccb430c0'>ShapeModified</a></td><td style='width:75%' ><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorGradient</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="5b963c8f-344b-43de-a7a0-bc6c6f206d9d"></a>
##Public Class KimonoInspectorPaleteColor

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorPaleteColor` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 24 fields, 20 properties, 73 methods and 4 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e08a5438-66f8-425b-9df1-89a8f25bd205'>_selectedColor</a></td><td style='width:75%' ><p>The private <code>_selectedColor</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47d1c52f-a93b-420b-b03f-0d6b49687889'>AvailableBaseColors</a></td><td style='width:75%' class='def'><p>The private <code>AvailableBaseColors</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>System.Collections.Generic.List&lt;KimonoCore.KimonoColor&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bb04c8c-7d44-420c-999f-f2b37184759c'>ColorModified</a></td><td style='width:75%' ><p>The private <code>ColorModified</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8fbfe25-0dbc-4cd6-a3f8-332d9f044cc9'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e26f0b6f-0cb2-40de-b6c2-945a41ca5fd3'>RemoveColor</a></td><td style='width:75%' ><p>The private <code>RemoveColor</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26f5b764-7b46-4326-8568-364da2295795'>ReturnToShape</a></td><td style='width:75%' class='def'><p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8ad2cb31-7d12-423d-a0b5-46e6f56358c3'>AdjustBrightnessCheckbox</a></td><td style='width:75%' ><p>The private read only <code>AdjustBrightnessCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1977a7de-33bc-48fe-bad9-ac0dcfb9ffd7'>AdjustHueCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AdjustHueCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd85adbe-0aa8-4074-94be-d6cafffd62b8'>AdjustOpacityCheckbox</a></td><td style='width:75%' ><p>The private read only <code>AdjustOpacityCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e8f0039-84fb-479a-84a6-c2dccd7741e4'>AdjustSaturationCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AdjustSaturationCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d88c4b4-1946-4ce1-85db-13f132cdd9fb'>BaseColorSelector</a></td><td style='width:75%' ><p>The private read only <code>BaseColorSelector</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#509086d6-18f7-47f6-a607-3e9ead141d61'>BrightnessSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>BrightnessSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a033172-a07a-41ef-b553-9babb7d9021c'>BrightnessValue</a></td><td style='width:75%' ><p>The private read only <code>BrightnessValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#422022c3-375f-4cac-b7fb-6eca54215370'>Color</a></td><td style='width:75%' class='def'><p>The private read only <code>Color</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca2cb823-9b31-451a-bf7f-7d55779022ff'>ColorName</a></td><td style='width:75%' ><p>The private read only <code>ColorName</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3a9ab20-de99-4f34-93cc-cb7e9cc2ed53'>DesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7ca58e5-6382-408b-9b59-eadc0b471999'>GoBackButton</a></td><td style='width:75%' ><p>The private read only <code>GoBackButton</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eaf1f34-cb36-420c-a20e-c801b78df74f'>HueSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>HueSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23eca598-d568-48b2-91a2-d2afd7039192'>HueValue</a></td><td style='width:75%' ><p>The private read only <code>HueValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71c4a528-77aa-4a5c-b570-35deefbd6729'>OpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0ac95fc-b37f-40be-93f0-c98533f926d1'>OpacityValue</a></td><td style='width:75%' ><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2b3f04d-61d5-453a-a5f3-3a85487c9a87'>Portfolio</a></td><td style='width:75%' class='def'><p>The public read only <code>Portfolio</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>KimonoCore.KimonoPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce863677-f9c0-4192-bf4d-4160a104e434'>SaturationSlider</a></td><td style='width:75%' ><p>The private read only <code>SaturationSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c94af99d-13aa-4e31-b779-2ecb8e55f4ef'>SaturationValue</a></td><td style='width:75%' class='def'><p>The private read only <code>SaturationValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75d29502-d2d2-4ac8-8364-2a12e077713e'>SelectedColor</a></td><td style='width:75%' ><p>The public <code>SelectedColor</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>KimonoCore.KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62599413-99f1-4c4b-81a8-b78784dd37e1'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#226111da-2bac-404e-bd3f-2b104a464c30'>AdjustBrightnessChanged</a></td><td style='width:75%' ><p>The private <code>AdjustBrightnessChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f37f94b-de60-4fea-b19b-6f8496c29faf'>AdjustHueChanged</a></td><td style='width:75%' class='def'><p>The private <code>AdjustHueChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cbfd4b7-a0ba-459a-92b1-a966bd566637'>AdjustOpacityChanged</a></td><td style='width:75%' ><p>The private <code>AdjustOpacityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e544aaa1-b051-43eb-930f-6df3e5dc7149'>AdjustSaturationChanged</a></td><td style='width:75%' class='def'><p>The private <code>AdjustSaturationChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2ffbb18-5fb3-4b11-9fd4-0f7fc358a4fb'>BaseColorChanged</a></td><td style='width:75%' ><p>The private <code>BaseColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c048b136-98e2-4dce-87c1-25768902c9e5'>BrightnessChanged</a></td><td style='width:75%' class='def'><p>The private <code>BrightnessChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90106296-13dc-4e35-ac66-328dbe049146'>ColorChanged</a></td><td style='width:75%' ><p>The private <code>ColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e82f924-91e9-45b0-991e-e2c5efa8e511'>ColorNameChanged</a></td><td style='width:75%' class='def'><p>The private <code>ColorNameChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cba47685-6d7b-4f5c-985e-03fda59cdb0d'>DeleteColor</a></td><td style='width:75%' ><p>The private <code>DeleteColor (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ae8f9b9-007a-4924-891b-8ed4dcc565bd'>DisplayCurrentColor</a></td><td style='width:75%' class='def'><p>The private <code>DisplayCurrentColor ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d89f94db-eacc-4cf6-aab0-3c91a6b88ba4'>DuplicateColor</a></td><td style='width:75%' ><p>The private <code>DuplicateColor (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6954e03b-993d-4476-bab9-8515b0260cb9'>GoBack</a></td><td style='width:75%' class='def'><p>The private <code>GoBack (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11ed0e36-e40e-4fbb-9335-f5af77050160'>HueChanged</a></td><td style='width:75%' ><p>The private <code>HueChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#648e407f-c2a3-417c-b759-f0bc0ad59107'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69bfa4dc-b428-4095-bc92-843848eba2aa'>KimonoInspectorPaleteColor</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorPaleteColor (System.IntPtr)</code> constructor for the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8d6bbeb-5fa1-46c3-a3de-e938706efb03'>MoveTo</a></td><td style='width:75%' class='def'><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorPaleteColor</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51278f0e-7212-42e1-abff-67bae981860d'>OpacityChanged</a></td><td style='width:75%' ><p>The private <code>OpacityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2714d098-1f9c-4859-aa26-59dd6bcab246'>RaiseColorModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseColorModified (KimonoCore.KimonoColor)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42238f62-e041-40af-887f-02a6667f11c4'>RaiseMakeDuplicate</a></td><td style='width:75%' ><p>The  <code>RaiseMakeDuplicate (KimonoCore.KimonoColor)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e092934e-abf7-4edd-98a1-037e24efe646'>RaiseRemoveColor</a></td><td style='width:75%' class='def'><p>The  <code>RaiseRemoveColor (KimonoCore.KimonoColor)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fad22e0-54cf-4e93-994a-90f052eca1e2'>RaiseReturnToShape</a></td><td style='width:75%' ><p>The  <code>RaiseReturnToShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5e9f841-7786-4f5f-bb20-a0896bb10450'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#742d0e8e-25fe-4095-876f-a65138a7c730'>SaturationChanged</a></td><td style='width:75%' ><p>The private <code>SaturationChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8ea5cdd-dcdf-42d0-b6df-950fc5b2eaa9'>SetColorValues</a></td><td style='width:75%' class='def'><p>The private <code>SetColorValues ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c215568-c500-4a4e-a364-8081c28a2c65'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0ce08c7b-98f0-4609-965b-36dd7a476543'>ColorModified</a></td><td style='width:75%' ><p>The <code>ColorModified</code> event of the <code>KimonoInspectorPaleteColor</code> class returns a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84f1ff7c-ccf2-4e3b-b9c9-127646fcb844'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The <code>MakeDuplicate</code> event of the <code>KimonoInspectorPaleteColor</code> class returns a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5db0cc62-db6c-46bc-9617-1197532c3ee3'>RemoveColor</a></td><td style='width:75%' ><p>The <code>RemoveColor</code> event of the <code>KimonoInspectorPaleteColor</code> class returns a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52b87f08-7238-40f1-a536-9b46074c22d1'>ReturnToShape</a></td><td style='width:75%' class='def'><p>The <code>ReturnToShape</code> event of the <code>KimonoInspectorPaleteColor</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="f7fbdce9-839e-40fc-a6d1-72b34f837de0"></a>
##Public Class KimonoInspectorPolygon

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorPolygon` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 5 fields, 4 properties, 17 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#44e43360-0ff3-4f6a-8172-9150a85cc671'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorPolygon</code> class holds a <code>KimonoCore.KimonoShapePolygon</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec737447-aa6a-49d5-9134-46651fa8a908'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorPolygon</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6dd711e7-0e9e-4982-8fd4-b4e19fe65062'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e8c164d-8c5b-437c-8754-720eec1925bb'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>KimonoCore.KimonoShapePolygon</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4f18005-5f65-475f-b715-0c3b73291fc2'>SidesSlider</a></td><td style='width:75%' ><p>The private read only <code>SidesSlider</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddd1ad82-7012-4dd2-adf9-804e14c3e55e'>SidesValue</a></td><td style='width:75%' class='def'><p>The private read only <code>SidesValue</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d1fb6a83-dcd5-4011-bf7e-0ff4361934e8'>Initialize</a></td><td style='width:75%' ><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f0a41ad-630a-404a-83c4-5d5cbd8e5d7b'>KimonoInspectorPolygon</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorPolygon (System.IntPtr)</code> constructor for the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe5005cd-da19-4ddc-b87a-490824aa5121'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorPolygon</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cf5e3d0-8c3b-49ff-972f-7ff721e7ae16'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#685bbec7-d253-4885-ac90-8a8d32abbe40'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36f189f7-9b23-4c53-9474-2c4904d5fde7'>SidesChanged</a></td><td style='width:75%' class='def'><p>The private <code>SidesChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ad07805-8ca3-4d0c-be47-d0800c666512'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#152e4aee-6544-40d6-9dc6-cea28a7462c3'>ShapeModified</a></td><td style='width:75%' ><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorPolygon</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="49df7770-93d5-42c4-9a0a-efeef5a8cf12"></a>
##Public Class KimonoInspectorSketch

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorSketch` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 12 fields, 9 properties, 40 methods and 3 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#68d22a83-512d-42dc-8c88-1ae7d4ef0364'>_selectedSketch</a></td><td style='width:75%' ><p>The private <code>_selectedSketch</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73364969-594e-4863-b144-8e6b72062c68'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#399aca6a-9d75-42d5-bb1d-9926693525cf'>RemoveSketch</a></td><td style='width:75%' ><p>The private <code>RemoveSketch</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#213968db-fb19-4df7-b512-aab6f6950360'>SketchModified</a></td><td style='width:75%' class='def'><p>The private <code>SketchModified</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d63f107-922d-4342-9e07-166188118703'>CanvasColor</a></td><td style='width:75%' ><p>The private read only <code>CanvasColor</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e5e6965-d7b0-4564-9eaf-3c0411a4ad31'>CanvasColorCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>CanvasColorCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65d562d6-40d8-46bd-98d9-bacbd2a27e73'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorSketch</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e144bc17-353b-48bd-8f43-e23a17d17f63'>OpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d7c76f4-9cd8-4a63-8afd-f35219378617'>OpacityValue</a></td><td style='width:75%' ><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a89d74d-d7c4-4701-92b7-caada6adff91'>SelectedSketch</a></td><td style='width:75%' class='def'><p>The public <code>SelectedSketch</code> property of the <code>KimonoInspectorSketch</code> class has a <code>KimonoCore.KimonoSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebcc08a2-a6a7-4cd3-8fd2-14a150e50de5'>SketchHeight</a></td><td style='width:75%' ><p>The private read only <code>SketchHeight</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70a57e02-f6b0-4276-8228-558782b5f1d7'>SketchName</a></td><td style='width:75%' class='def'><p>The private read only <code>SketchName</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c166615-6d9a-4bc9-b4a7-57d8607c9287'>SketchWidth</a></td><td style='width:75%' ><p>The private read only <code>SketchWidth</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#661b0ea1-38eb-4d60-ad02-42aa40e19f5b'>CanvasColorChanged</a></td><td style='width:75%' ><p>The private <code>CanvasColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c51e59c1-47bb-432e-b135-1a57186f45f1'>DeleteSketch</a></td><td style='width:75%' class='def'><p>The private <code>DeleteSketch (Foundation.NSObject)</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1aaec07-612f-4fd2-be9d-573bfabbbd30'>DuplicateSketch</a></td><td style='width:75%' ><p>The private <code>DuplicateSketch (Foundation.NSObject)</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#015fc021-5031-4645-b09b-16fb024c1f75'>HasCanvasColorChanged</a></td><td style='width:75%' class='def'><p>The private <code>HasCanvasColorChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d18ce89-1c5e-4a5a-b55f-5c22c2335900'>Initialize</a></td><td style='width:75%' ><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85433aed-9251-441a-a5f9-d99c8abe7a3a'>KimonoInspectorSketch</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorSketch (System.IntPtr)</code> constructor for the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb213250-8567-4803-a285-2cc37e8b9ab6'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorSketch</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b571795-55f9-433f-8f66-67fb364770be'>OpacityChanged</a></td><td style='width:75%' class='def'><p>The private <code>OpacityChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bae93c9-8689-4683-832a-9c25aa4f86dd'>RaiseMakeDuplicate</a></td><td style='width:75%' ><p>The  <code>RaiseMakeDuplicate ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76e1adee-9f1c-4dc1-ba89-10e681de80b4'>RaiseRemoveSketch</a></td><td style='width:75%' class='def'><p>The  <code>RaiseRemoveSketch ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1508d627-4883-4f1c-bd14-3e9ccd392c0a'>RaiseSketchModified</a></td><td style='width:75%' ><p>The  <code>RaiseSketchModified ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b927e1e4-63c7-4645-b321-203925a13678'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f333b337-e96c-4da1-b5bf-5ab74ba7b9dc'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5d9d5f0b-d866-4afc-93fa-6eec041d3d50'>MakeDuplicate</a></td><td style='width:75%' ><p>The <code>MakeDuplicate</code> event of the <code>KimonoInspectorSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc8f9693-bcde-42f2-b1e5-f836b59e730d'>RemoveSketch</a></td><td style='width:75%' class='def'><p>The <code>RemoveSketch</code> event of the <code>KimonoInspectorSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a1d8f45-1320-4c0c-baa6-8f220dc17ed1'>SketchModified</a></td><td style='width:75%' ><p>The <code>SketchModified</code> event of the <code>KimonoInspectorSketch</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="b64e1740-fcf6-4e2e-9154-2ef3efb5e43f"></a>
##Public Class KimonoInspectorStar

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorStar` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 9 fields, 8 properties, 27 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fdaba297-81e7-4c68-9997-f9f84bf94869'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorStar</code> class holds a <code>KimonoCore.KimonoShapeStar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2b0b0ca-81a2-4463-847b-6dc4928a3339'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorStar</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#051acc14-584f-4f8d-9309-95e3c52bf6e0'>DepthSlider</a></td><td style='width:75%' ><p>The private read only <code>DepthSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#220ddfa6-2dd4-4407-ba7a-1aae76f8118c'>DepthValue</a></td><td style='width:75%' class='def'><p>The private read only <code>DepthValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5feaede4-4a05-485f-8369-d3c76c91195f'>DesignSurface</a></td><td style='width:75%' ><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorStar</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02f7716d-0b31-43b9-9487-3346a7bfb9ce'>PointsSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>PointsSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9f663a2-d7af-4f1e-ba16-ff2b59c6c8aa'>PointsValue</a></td><td style='width:75%' ><p>The private read only <code>PointsValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71668770-d809-4ebf-9f77-fb0dd8bbe4dd'>SelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorStar</code> class has a <code>KimonoCore.KimonoShapeStar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df388527-aedc-4937-9c62-0f4610eb6a15'>SkipSlider</a></td><td style='width:75%' ><p>The private read only <code>SkipSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92a79205-f2df-4c03-b3ce-f1bcf1cde473'>SkipValue</a></td><td style='width:75%' class='def'><p>The private read only <code>SkipValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7937463d-2881-4ab1-a0ed-78b39746c562'>DepthChanged</a></td><td style='width:75%' ><p>The private <code>DepthChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b09fcc5f-cbf9-40b3-a962-511535e50b12'>Initialize</a></td><td style='width:75%' class='def'><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f89ad76-46f5-43bb-a3bb-6a77412105a3'>KimonoInspectorStar</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorStar (System.IntPtr)</code> constructor for the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#439f45d2-295d-46eb-880e-091543f40a55'>MoveTo</a></td><td style='width:75%' class='def'><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorStar</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32900929-2399-49d2-914c-deee3ae537ac'>PointsChanged</a></td><td style='width:75%' ><p>The private <code>PointsChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52cd4e29-9a72-4ec6-88a9-1bc0bd6a2320'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ded2329f-9d65-4be3-ae95-a3dd54c33486'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b97fcac3-afb7-41fe-be3c-798b86cdb5f2'>SkipChanged</a></td><td style='width:75%' class='def'><p>The private <code>SkipChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd894f46-f0c8-4d1f-9501-c9e14ab4bf73'>UpdateInspector</a></td><td style='width:75%' ><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#56add2de-09c1-4757-86bb-6281fab95eb0'>ShapeModified</a></td><td style='width:75%' ><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorStar</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="d966c642-1886-482d-a924-0dc9c962accb"></a>
##Public Class KimonoInspectorStyle

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorStyle` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 14 fields, 8 properties, 45 methods and 6 events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c99d67ab-a4f5-449c-9a89-6872e5610007'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ea55da8-af61-4714-bd49-7e02bfda8a9b'>_selectedStyle</a></td><td style='width:75%' class='def'><p>The private <code>_selectedStyle</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dbec3a5-e104-4609-afd0-f6019af846a5'>MakeDuplicate</a></td><td style='width:75%' ><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42e7aa8d-a8d0-4e6c-9361-19390c9b4a86'>RemoveStyle</a></td><td style='width:75%' class='def'><p>The private <code>RemoveStyle</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5baca6c1-caeb-475d-b765-cba4499446d9'>ReturnToShape</a></td><td style='width:75%' ><p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04371a5e-b04c-4064-a0b3-527c2e1d05de'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cf2c79b-1ba8-4d9d-947d-e46ea1ac7536'>StyleModified</a></td><td style='width:75%' ><p>The private <code>StyleModified</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6128e4da-b293-4ba2-afb2-a469838623ac'>StyleTypeChanged</a></td><td style='width:75%' class='def'><p>The private <code>StyleTypeChanged</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3c444bb5-1553-4d32-89ca-0b85078c044b'>ApplyButton</a></td><td style='width:75%' ><p>The private read only <code>ApplyButton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2aa5300-fce2-4874-84e3-a20895db1935'>Backbutton</a></td><td style='width:75%' class='def'><p>The private read only <code>Backbutton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21d0606c-090d-48d2-be6a-8dd68f222002'>DeleteButton</a></td><td style='width:75%' ><p>The private read only <code>DeleteButton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d05afe23-49b4-4fc6-81a2-1c379ff2e287'>DesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorStyle</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a59caa9c-1974-44ea-a57f-ed742ba05ac3'>SelectedShape</a></td><td style='width:75%' ><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorStyle</code> class has a <code>KimonoCore.KimonoShape</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9510c9a2-d6de-436e-9680-9eb0f7fb932f'>SelectedStyle</a></td><td style='width:75%' class='def'><p>The public <code>SelectedStyle</code> property of the <code>KimonoInspectorStyle</code> class has a <code>KimonoCore.KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91fc210b-4f9f-45ba-92c9-9535e93e3882'>StyleName</a></td><td style='width:75%' ><p>The private read only <code>StyleName</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ff5d736-0a98-4f91-9487-971af2279567'>TypeDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>TypeDropdown</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1db2e5b2-1e57-4bfb-95d4-dc2c6300437b'>ApplyChange</a></td><td style='width:75%' ><p>The private <code>ApplyChange (Foundation.NSObject)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15c2c031-86a0-452c-aabe-328c54a64734'>DeleteStyle</a></td><td style='width:75%' class='def'><p>The private <code>DeleteStyle (Foundation.NSObject)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dee110cb-55c7-44e4-ba51-a5c0f13840bf'>DuplicateStyle</a></td><td style='width:75%' ><p>The private <code>DuplicateStyle (Foundation.NSObject)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41035f45-1499-48f3-b7ec-5ebcbc9d34db'>GoBack</a></td><td style='width:75%' class='def'><p>The private <code>GoBack (Foundation.NSObject)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#716e202a-adcd-4e31-9d0d-eff26004174a'>Initialize</a></td><td style='width:75%' ><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d98039c-550e-466c-bf71-19f65e70a024'>KimonoInspectorStyle</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorStyle (System.IntPtr)</code> constructor for the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4c9c591-814d-48f0-a59f-dc06fa813211'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorStyle</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5d0c9ee-d1bb-440d-bb09-376000f122dd'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p>The  <code>RaiseMakeDuplicate (KimonoCore.KimonoStyle)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7706dc21-0fc3-46a0-8e53-ba3633fbf1f5'>RaiseRemoveStyle</a></td><td style='width:75%' ><p>The  <code>RaiseRemoveStyle (KimonoCore.KimonoStyle)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f1215e2-e97f-4d1e-8fcc-0eb82f836da8'>RaiseReturnToShape</a></td><td style='width:75%' class='def'><p>The  <code>RaiseReturnToShape (KimonoCore.KimonoShape)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbe1ce6f-82fa-42d4-aa4e-d7c98467588d'>RaiseShapeModified</a></td><td style='width:75%' ><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c64ac8a8-3668-4943-bd4e-d39cde27e22b'>RaiseStyleModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseStyleModified ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31f619f3-e639-473a-a398-c77c40734332'>RaiseStyleTypeChanged</a></td><td style='width:75%' ><p>The  <code>RaiseStyleTypeChanged (KimonoCore.KimonoStyle)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4eb28d93-6084-4be6-9891-8a913b1a2c26'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb0670ed-74d9-47d3-9d51-14effcbdd24c'>TypeChanged</a></td><td style='width:75%' ><p>The private <code>TypeChanged (Foundation.NSObject)</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1f7d6a2-e381-4370-9d15-7894b4e85d48'>UpdateInspector</a></td><td style='width:75%' class='def'><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#39684c30-2da5-4c55-b312-a0cebd1433eb'>MakeDuplicate</a></td><td style='width:75%' ><p>The <code>MakeDuplicate</code> event of the <code>KimonoInspectorStyle</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1da9d6df-5b62-40bf-ae31-119605177a2f'>RemoveStyle</a></td><td style='width:75%' class='def'><p>The <code>RemoveStyle</code> event of the <code>KimonoInspectorStyle</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3bb376e-87d9-4127-ae14-b3b7704a7eba'>ReturnToShape</a></td><td style='width:75%' ><p>The <code>ReturnToShape</code> event of the <code>KimonoInspectorStyle</code> class returns a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce6d057a-7722-4a34-ba61-65cac3b049e7'>ShapeModified</a></td><td style='width:75%' class='def'><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorStyle</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12d27566-a8f8-4fdc-9d7c-e48e89793388'>StyleModified</a></td><td style='width:75%' ><p>The <code>StyleModified</code> event of the <code>KimonoInspectorStyle</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61886013-c3ef-4e68-a8d8-0bb88c0eb3f0'>StyleTypeChanged</a></td><td style='width:75%' class='def'><p>The <code>StyleTypeChanged</code> event of the <code>KimonoInspectorStyle</code> class returns a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="520dbfc1-d25b-4528-bb05-f6158e6171d2"></a>
##Public Class KimonoInspectorText

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSView`

###Summary

The public `KimonoInspectorText` class inherits from the `AppKit.NSView` class and is defined in the `KimonoMac` namespace. It defines 5 fields, 3 properties, 15 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a6547545-4aa9-4d2e-b2e6-762d8e3aafb1'>_selectedShape</a></td><td style='width:75%' ><p>The private <code>_selectedShape</code> field of the <code>KimonoInspectorText</code> class holds a <code>KimonoCore.KimonoShapeText</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24cdbd63-27ff-455d-b290-bb145a2ae549'>FirstChange</a></td><td style='width:75%' class='def'><p>The private <code>FirstChange</code> field of the <code>KimonoInspectorText</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b66e3a6-a94a-4103-8cda-3ef4f042627f'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorText</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#839a0eb9-35c2-4ed8-b66b-a724a6f06239'>Contents</a></td><td style='width:75%' ><p>The private read only <code>Contents</code> property of the <code>KimonoInspectorText</code> class has a <code>KimonoMac.KimonoTextView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b66c95f-bc4f-43ff-8a72-8a2c419bc299'>DesignSurface</a></td><td style='width:75%' class='def'><p>The public <code>DesignSurface</code> property of the <code>KimonoInspectorText</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0671636b-6549-4fb3-a342-7e327a5b4847'>SelectedShape</a></td><td style='width:75%' ><p>The public <code>SelectedShape</code> property of the <code>KimonoInspectorText</code> class has a <code>KimonoCore.KimonoShapeText</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#769052d8-2971-4d37-a356-a858116f01a8'>Initialize</a></td><td style='width:75%' ><p>The public <code>Initialize ()</code> member of the <code>KimonoInspectorText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45d44a49-f9e9-4836-ae49-446aecdfb255'>KimonoInspectorText</a></td><td style='width:75%' class='def'><p>The public <code>KimonoInspectorText (System.IntPtr)</code> constructor for the <code>KimonoInspectorText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fee0954c-1993-4d1f-adc3-c7ba77dcc07e'>MoveTo</a></td><td style='width:75%' ><p>The public <code>MoveTo (System.nfloat)</code> member of the <code>KimonoInspectorText</code> class returns a <code>System.nfloat</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#846193bf-1d07-4009-989c-a9818fbcd9dc'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseShapeModified ()</code> member of the <code>KimonoInspectorText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc7290f6-2d36-4ac0-b74b-dc7bc50e251b'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f41eba3-d868-4450-b513-b6ffe9a118bd'>UpdateInspector</a></td><td style='width:75%' class='def'><p>The public <code>UpdateInspector ()</code> member of the <code>KimonoInspectorText</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6be25e11-6131-434a-83d1-3fa67386d047'>ShapeModified</a></td><td style='width:75%' ><p>The <code>ShapeModified</code> event of the <code>KimonoInspectorText</code> class returns a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd"></a>
##Public Class KimonoTextView

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSTextView`

###Summary

The public `KimonoTextView` class inherits from the `AppKit.NSTextView` class and is defined in the `KimonoMac` namespace. It defines one field, no properties, 8 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#628440fc-2411-4dd6-84b9-56ae896e422f'>TextChanged</a></td><td style='width:75%' ><p>The private <code>TextChanged</code> field of the <code>KimonoTextView</code> class holds a <code>KimonoMac.KimonoTextView.TextChangedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f17f45a4-513a-4b98-888f-3b6cbc27492c'>DidChangeText</a></td><td style='width:75%' ><p>The public virtual <code>DidChangeText ()</code> member of the <code>KimonoTextView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c055f316-23b3-48bc-84bb-e29533134b38'>KimonoTextView</a></td><td style='width:75%' class='def'><p>The public <code>KimonoTextView ()</code> constructor for the <code>KimonoTextView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9310ff8-79c4-4bde-868e-853780bb0caf'>KimonoTextView</a></td><td style='width:75%' ><p>The public <code>KimonoTextView (CoreGraphics.CGRect)</code> constructor for the <code>KimonoTextView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8120c08c-b67a-44cb-8f66-9584f9d4b006'>KimonoTextView</a></td><td style='width:75%' class='def'><p>The public <code>KimonoTextView (Foundation.NSCoder)</code> constructor for the <code>KimonoTextView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc43b5d2-38e4-4784-a671-75b28b826ec7'>KimonoTextView</a></td><td style='width:75%' ><p>The public <code>KimonoTextView (System.IntPtr)</code> constructor for the <code>KimonoTextView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0482e1c3-9350-40eb-9033-ca2a4dc4545c'>RaiseTextChanged</a></td><td style='width:75%' class='def'><p>The  <code>RaiseTextChanged (System.String)</code> member of the <code>KimonoTextView</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6da06620-d657-4ab6-ac94-bc50176c39e3'>TextChanged</a></td><td style='width:75%' ><p>The <code>TextChanged</code> event of the <code>KimonoTextView</code> class returns a <code>KimonoMac.KimonoTextView.TextChangedDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="9659011a-32e0-4e33-a1b3-022dcd95c073"></a>
##Private Static Class MainClass

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`System.Object`

###Summary

The private `MainClass` class inherits from the `System.Object` class and is defined in the `KimonoMac` namespace. It defines no fields, no properties, one method and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#40f7a2c8-0a80-4a28-b133-798d51439a99'>Main</a></td><td style='width:75%' ><p>The private static <code>Main (System.String[])</code> member of the <code>MainClass</code> class.</p>
</td></tr></table></p>


---

<a name="35062bb9-5a44-4214-9296-32c4d5467add"></a>
##Public Class MainWindowController

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSWindowController`

###Summary

The public `MainWindowController` class inherits from the `AppKit.NSWindowController` class and is defined in the `KimonoMac` namespace. It defines 13 fields, 14 properties, 35 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#109f5975-5376-406f-b0db-59193c43baae'>AlignBottomTool</a></td><td style='width:75%' ><p>The private read only <code>AlignBottomTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9baba028-e782-4dd6-afa6-9720b255d7c1'>AlignLeftTool</a></td><td style='width:75%' class='def'><p>The private read only <code>AlignLeftTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff7dcb67-441f-4351-bd0e-f388061c4f13'>AlignRightTool</a></td><td style='width:75%' ><p>The private read only <code>AlignRightTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f73a9502-867d-4201-8acf-684213ff5f58'>AlignTopTool</a></td><td style='width:75%' class='def'><p>The private read only <code>AlignTopTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd856b6e-b5f7-4b49-bd68-26e94bf0fa7f'>CenterHorizontalTool</a></td><td style='width:75%' ><p>The private read only <code>CenterHorizontalTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3e97942-9175-4198-8b7e-d381a78e94f4'>CenterTool</a></td><td style='width:75%' class='def'><p>The private read only <code>CenterTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb786982-b9c7-4f57-8b55-f18aebe205c7'>CenterVerticalTool</a></td><td style='width:75%' ><p>The private read only <code>CenterVerticalTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4c0a738-6a71-4ffa-af37-f3cf16c84000'>GroupShapes</a></td><td style='width:75%' class='def'><p>The private read only <code>GroupShapes</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37fcf4d5-74af-45ca-a486-1264d6de0f56'>MainController</a></td><td style='width:75%' ><p>The public read only <code>MainController</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ViewController</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20cf763b-3444-40c9-b679-10d88faba306'>MoveBackwardsTool</a></td><td style='width:75%' class='def'><p>The private read only <code>MoveBackwardsTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8dcda37-1ce6-4dc7-8590-0730546a4612'>MoveBottomTool</a></td><td style='width:75%' ><p>The private read only <code>MoveBottomTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74c67662-1e1b-4301-855d-e455547d947b'>MoveForwardsTool</a></td><td style='width:75%' class='def'><p>The private read only <code>MoveForwardsTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fa4a1c4-c7fd-42d0-9a28-c30aa29e3750'>MoveTopTool</a></td><td style='width:75%' ><p>The private read only <code>MoveTopTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e30bcc84-a695-4bfc-8fa8-7dc1aef01d85'>UngroupShapes</a></td><td style='width:75%' class='def'><p>The private read only <code>UngroupShapes</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f2c33bba-3445-4aaf-9554-c651493050c9'>AddColor</a></td><td style='width:75%' ><p>The public <code>AddColor (Foundation.NSObject)</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebc25d70-aeec-45f9-ae48-6324036efd34'>AddGradient</a></td><td style='width:75%' class='def'><p>The public <code>AddGradient (Foundation.NSObject)</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b9cd5b1-ef64-4b35-bc62-ccac554cffd1'>AddSketch</a></td><td style='width:75%' ><p>The public <code>AddSketch (Foundation.NSObject)</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7307738-ab9c-4b9e-a49e-ba854e4cb140'>AddStyle</a></td><td style='width:75%' class='def'><p>The public <code>AddStyle (Foundation.NSObject)</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4599190c-3ef8-4157-bc11-e82524a1c7c6'>MainWindowController</a></td><td style='width:75%' ><p>The public <code>MainWindowController (System.IntPtr)</code> constructor for the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7c33296-0326-45ee-9583-f200e63cfba9'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fff16b8-b302-4b95-9f73-f27e6fe285b6'>WindowDidLoad</a></td><td style='width:75%' ><p>The public virtual <code>WindowDidLoad ()</code> member of the <code>MainWindowController</code> class.</p>
</td></tr></table></p>


---

<a name="b6363465-6e0a-4cff-a55f-b89a7306f4ec"></a>
##Public Class SourceListDataSource

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSOutlineViewDataSource`

###Summary

The public `SourceListDataSource` class inherits from the `AppKit.NSOutlineViewDataSource` class and is defined in the `KimonoMac` namespace. It defines 2 fields, no properties, 6 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7285ac32-7058-4ed4-ab02-e486b9f08680'>_controller</a></td><td style='width:75%' ><p>The private <code>_controller</code> field of the <code>SourceListDataSource</code> class holds a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72bf9829-9342-4e34-a556-d7fa4628fc5f'>Items</a></td><td style='width:75%' class='def'><p>The public <code>Items</code> field of the <code>SourceListDataSource</code> class holds a <code>System.Collections.Generic.List&lt;KimonoMac.SourceListItem&gt;</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d15579d2-f4df-4310-bd5c-f2015b367067'>GetChild</a></td><td style='width:75%' ><p>The public virtual <code>GetChild (AppKit.NSOutlineView, System.nint, Foundation.NSObject)</code> member of the <code>SourceListDataSource</code> class returns a <code>Foundation.NSObject</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d4fb08b-7dc6-49b0-ba4b-d79bce73c75a'>GetChildrenCount</a></td><td style='width:75%' class='def'><p>The public virtual <code>GetChildrenCount (AppKit.NSOutlineView, Foundation.NSObject)</code> member of the <code>SourceListDataSource</code> class returns a <code>System.nint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f07efdc-847c-49d7-8b5a-5b3e9149c2c8'>GetObjectValue</a></td><td style='width:75%' ><p>The public virtual <code>GetObjectValue (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</code> member of the <code>SourceListDataSource</code> class returns a <code>Foundation.NSObject</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#332dcd93-e6f6-4ecb-8787-00cb774be625'>ItemExpandable</a></td><td style='width:75%' class='def'><p>The public virtual <code>ItemExpandable (AppKit.NSOutlineView, Foundation.NSObject)</code> member of the <code>SourceListDataSource</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91564018-1b3d-4790-a74c-167b620a906d'>ItemForRow</a></td><td style='width:75%' ><p>The  <code>ItemForRow (System.Int32)</code> member of the <code>SourceListDataSource</code> class returns a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a0ebb4d-b214-4dba-9464-4f6b5f54ee03'>SourceListDataSource</a></td><td style='width:75%' class='def'><p>The public <code>SourceListDataSource (KimonoMac.SourceListView)</code> constructor for the <code>SourceListDataSource</code> class.</p>
</td></tr></table></p>


---

<a name="d8ba5633-ee96-4674-bbab-f97c6bf7fae4"></a>
##Public Class SourceListDelegate

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSOutlineViewDelegate`

###Summary

The public `SourceListDelegate` class inherits from the `AppKit.NSOutlineViewDelegate` class and is defined in the `KimonoMac` namespace. It defines one field, no properties, 7 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bd72e506-e888-45e8-910a-d0c2641ce965'>_controller</a></td><td style='width:75%' ><p>The private <code>_controller</code> field of the <code>SourceListDelegate</code> class holds a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8a35e355-91b1-4cdc-a6e3-13e27e67b9e1'>GetCell</a></td><td style='width:75%' ><p>The public virtual <code>GetCell (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</code> member of the <code>SourceListDelegate</code> class returns a <code>AppKit.NSCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4756ec56-b349-4b35-b53b-dc5f2d12cfef'>GetView</a></td><td style='width:75%' class='def'><p>The public virtual <code>GetView (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</code> member of the <code>SourceListDelegate</code> class returns a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17baa0b1-0090-43fc-81b7-c66d717a1d3c'>IsGroupItem</a></td><td style='width:75%' ><p>The public virtual <code>IsGroupItem (AppKit.NSOutlineView, Foundation.NSObject)</code> member of the <code>SourceListDelegate</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e30865da-a53d-4f47-a339-445172fa8a85'>SelectionDidChange</a></td><td style='width:75%' class='def'><p>The public virtual <code>SelectionDidChange (Foundation.NSNotification)</code> member of the <code>SourceListDelegate</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d957ecf-6e00-468f-98f0-f435e7830ad8'>ShouldEditTableColumn</a></td><td style='width:75%' ><p>The public virtual <code>ShouldEditTableColumn (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</code> member of the <code>SourceListDelegate</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a2ab29e-4fa8-4a21-8204-0c34ac14c103'>ShouldSelectItem</a></td><td style='width:75%' class='def'><p>The public virtual <code>ShouldSelectItem (AppKit.NSOutlineView, Foundation.NSObject)</code> member of the <code>SourceListDelegate</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94b5a600-f88d-499d-b5f1-1aacb8f60280'>SourceListDelegate</a></td><td style='width:75%' ><p>The public <code>SourceListDelegate (KimonoMac.SourceListView)</code> constructor for the <code>SourceListDelegate</code> class.</p>
</td></tr></table></p>


---

<a name="9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa"></a>
##Public Class SourceListItem

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`Foundation.NSObject`

###Summary

The public `SourceListItem` class inherits from the `Foundation.NSObject` class and is defined in the `KimonoMac` namespace. It defines 6 fields, 7 properties, 37 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#70f83465-46d5-45ab-8a4d-bf89a58177c4'>_icon</a></td><td style='width:75%' ><p>The private <code>_icon</code> field of the <code>SourceListItem</code> class holds a <code>AppKit.NSImage</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e56cefd-fa16-4720-b1b2-c97361afb5d6'>_items</a></td><td style='width:75%' class='def'><p>The private <code>_items</code> field of the <code>SourceListItem</code> class holds a <code>System.Collections.Generic.List&lt;KimonoMac.SourceListItem&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#051110d9-1591-4044-91c3-380a0abb5da2'>_position</a></td><td style='width:75%' ><p>The private <code>_position</code> field of the <code>SourceListItem</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c90e8ed-ac3f-4728-81c9-71b590e52d88'>_tag</a></td><td style='width:75%' class='def'><p>The private <code>_tag</code> field of the <code>SourceListItem</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6eb20b16-329a-451c-89b7-a41c04daf709'>_title</a></td><td style='width:75%' ><p>The private <code>_title</code> field of the <code>SourceListItem</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfc310b0-16f0-49a2-a7c1-d27873116339'>Clicked</a></td><td style='width:75%' class='def'><p>The private <code>Clicked</code> field of the <code>SourceListItem</code> class holds a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#797710ca-f817-4b59-a6d6-0270511639d3'>Count</a></td><td style='width:75%' ><p>The public read only <code>Count</code> property of the <code>SourceListItem</code> class has a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da3b18d1-5904-4502-aeb7-d43d2855e5d3'>Current</a></td><td style='width:75%' class='def'><p>The public read only virtual <code>Current</code> property of the <code>SourceListItem</code> class has a <code>System.Object</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f9a87b2-5580-4130-8978-7e1e3a928913'>HasChildren</a></td><td style='width:75%' ><p>The public read only <code>HasChildren</code> property of the <code>SourceListItem</code> class has a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96e6ca2b-65a6-4ccb-ba22-c693c6c34c29'>Icon</a></td><td style='width:75%' class='def'><p>The public <code>Icon</code> property of the <code>SourceListItem</code> class has a <code>AppKit.NSImage</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b08c67ae-4aae-4891-a2e6-e2f71593d687'>Item(System.Int32)</a></td><td style='width:75%' ><p>The public <code>Item(System.Int32)</code> property of the <code>SourceListItem</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82de8f70-3d1b-4117-82c6-b4f69ceee712'>Tag</a></td><td style='width:75%' class='def'><p>The public <code>Tag</code> property of the <code>SourceListItem</code> class has a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b9d1a30-4e1d-4bfd-8609-6cdbf90a0dbf'>Title</a></td><td style='width:75%' ><p>The public <code>Title</code> property of the <code>SourceListItem</code> class has a <code>System.String</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#88a45166-8433-43c5-ae84-52f54dbd68a0'>AddItem</a></td><td style='width:75%' ><p>The public <code>AddItem (KimonoMac.SourceListItem)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab1c9c31-0fca-45ee-82fd-9b3111571e40'>AddItem</a></td><td style='width:75%' class='def'><p>The public <code>AddItem (System.String)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ed67555-b410-4114-a081-a0a923ac149e'>AddItem</a></td><td style='width:75%' ><p>The public <code>AddItem (System.String, AppKit.NSImage)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#616f6b64-4033-4e15-a4fe-46cd56b3e1de'>AddItem</a></td><td style='width:75%' class='def'><p>The public <code>AddItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00794a46-99ed-4113-978f-5696f8bbc266'>AddItem</a></td><td style='width:75%' ><p>The public <code>AddItem (System.String, AppKit.NSImage, System.String)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a48f582-7ea5-47e5-882f-48d9f1c5aa49'>AddItem</a></td><td style='width:75%' class='def'><p>The public <code>AddItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b545484-9ee3-4997-ba17-db7b4f3170b0'>AddItem</a></td><td style='width:75%' ><p>The public <code>AddItem (System.String, System.String)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a091a71-7077-4ba1-860f-bd19578e699e'>AddItem</a></td><td style='width:75%' class='def'><p>The public <code>AddItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcd271df-4c4b-4530-9640-de141618ecd5'>Clear</a></td><td style='width:75%' ><p>The public <code>Clear ()</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ae0c373-a49a-4968-8d42-3e1e6f56b313'>GetEnumerator</a></td><td style='width:75%' class='def'><p>The public virtual <code>GetEnumerator ()</code> member of the <code>SourceListItem</code> class returns a <code>System.Collections.IEnumerator</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0fb473b7-edef-4291-a08a-f04e581c5ee2'>Insert</a></td><td style='width:75%' ><p>The public <code>Insert (System.Int32, KimonoMac.SourceListItem)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8b8a755-fc00-4334-9cbc-044bed7d5f81'>MoveNext</a></td><td style='width:75%' class='def'><p>The public virtual <code>MoveNext ()</code> member of the <code>SourceListItem</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb046ae4-f103-4211-bfc4-742ab18380ad'>RaiseClickedEvent</a></td><td style='width:75%' ><p>The  <code>RaiseClickedEvent ()</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e46a876-3527-4ba8-97c3-5285443f87ca'>RemoveItem</a></td><td style='width:75%' class='def'><p>The public <code>RemoveItem (KimonoMac.SourceListItem)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#347d8a38-b006-4f2f-b7e3-8af0daa0549e'>RemoveItem</a></td><td style='width:75%' ><p>The public <code>RemoveItem (System.Int32)</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db69adc2-df57-4bbd-bcd0-fce1be2b6f47'>Reset</a></td><td style='width:75%' class='def'><p>The public virtual <code>Reset ()</code> member of the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41dc9a41-f4a7-45c7-aed4-95cd95679fcd'>SourceListItem</a></td><td style='width:75%' ><p>The public <code>SourceListItem ()</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e807a283-684b-4b36-b2e2-d4e6f883e45d'>SourceListItem</a></td><td style='width:75%' class='def'><p>The public <code>SourceListItem (System.String)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f243ecfc-293a-4b7f-9d83-3a1948dd87a0'>SourceListItem</a></td><td style='width:75%' ><p>The public <code>SourceListItem (System.String, AppKit.NSImage)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a339692d-1c96-4dde-8f3a-d4cb43cac6fc'>SourceListItem</a></td><td style='width:75%' class='def'><p>The public <code>SourceListItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09939415-c8d0-4a2f-89bd-ef7785e0fa9c'>SourceListItem</a></td><td style='width:75%' ><p>The public <code>SourceListItem (System.String, AppKit.NSImage, System.String)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc25f829-fab8-43ff-939b-3a7d03b56c5b'>SourceListItem</a></td><td style='width:75%' class='def'><p>The public <code>SourceListItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ae050b3-2326-4e7c-b43a-047f6e772c3e'>SourceListItem</a></td><td style='width:75%' ><p>The public <code>SourceListItem (System.String, System.String)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ca4a566-01cf-4bbb-be8a-c876480d8c78'>SourceListItem</a></td><td style='width:75%' class='def'><p>The public <code>SourceListItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)</code> constructor for the <code>SourceListItem</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#55a6a106-659f-4751-b6c4-b5c278d672f9'>Clicked</a></td><td style='width:75%' ><p>The <code>Clicked</code> event of the <code>SourceListItem</code> class returns a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="af72ceec-0ee0-4d13-add5-6380ca3fff2f"></a>
##Public Class SourceListView

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSOutlineView`

###Summary

The public `SourceListView` class inherits from the `AppKit.NSOutlineView` class and is defined in the `KimonoMac` namespace. It defines one field, one property, 11 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eea1008a-6ae9-4255-b992-c8d851ff4d40'>ItemSelected</a></td><td style='width:75%' ><p>The private <code>ItemSelected</code> field of the <code>SourceListView</code> class holds a <code>KimonoMac.SourceListView.ItemSelectedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1c702ae8-b163-45ec-9401-4412340e90fd'>Data</a></td><td style='width:75%' ><p>The public read only <code>Data</code> property of the <code>SourceListView</code> class has a <code>KimonoMac.SourceListDataSource</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#044a6c45-9627-4b88-b0e8-e0b5526757d2'>AddItem</a></td><td style='width:75%' ><p>The public <code>AddItem (KimonoMac.SourceListItem)</code> member of the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57472b4b-eb43-4965-bdeb-01c99508980a'>AwakeFromNib</a></td><td style='width:75%' class='def'><p>The public virtual <code>AwakeFromNib ()</code> member of the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd70ace3-c4fb-4505-8fb4-f766b8f200e8'>Initialize</a></td><td style='width:75%' ><p>The public <code>Initialize ()</code> member of the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b28e1ab-7b0f-4c0b-9cab-4ca9767f1436'>RaiseItemSelected</a></td><td style='width:75%' class='def'><p>The  <code>RaiseItemSelected (KimonoMac.SourceListItem)</code> member of the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#813abed2-d9ae-4936-b2da-e03bac736805'>SourceListView</a></td><td style='width:75%' ><p>The public <code>SourceListView ()</code> constructor for the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#808c4dd3-d915-45f4-bce8-c4f66580b5e8'>SourceListView</a></td><td style='width:75%' class='def'><p>The public <code>SourceListView (Foundation.NSCoder)</code> constructor for the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7b04482-5085-4767-a777-a5b0a9941df3'>SourceListView</a></td><td style='width:75%' ><p>The public <code>SourceListView (Foundation.NSObjectFlag)</code> constructor for the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd8ff6c9-087d-40f3-96f2-78390153d91d'>SourceListView</a></td><td style='width:75%' class='def'><p>The public <code>SourceListView (System.IntPtr)</code> constructor for the <code>SourceListView</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1f25b506-a7c1-41c3-a907-3481973a37d3'>ItemSelected</a></td><td style='width:75%' ><p>The <code>ItemSelected</code> event of the <code>SourceListView</code> class returns a <code>KimonoMac.SourceListView.ItemSelectedDelegate</code> value.</p>
</td></tr></table></p>


---

<a name="15ff3f30-cef6-4db2-8e01-d27e95dbcdf8"></a>
##Public Class ViewController

###Namespace

[KimonoMac](#1e257306-8e53-45d6-a2bd-7300974e04be)

###Inherits From

`AppKit.NSViewController`

###Summary

The public `ViewController` class inherits from the `AppKit.NSViewController` class and is defined in the `KimonoMac` namespace. It defines 43 fields, 41 properties, 195 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#27f530d5-cae8-4c16-90f3-b1d2be1a0063'>SketchModified</a></td><td style='width:75%' ><p>The private <code>SketchModified</code> field of the <code>ViewController</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#dae1a719-c8e1-4b54-a14d-711be6909c17'>ArrowInspector</a></td><td style='width:75%' ><p>The private read only <code>ArrowInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorArrow</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14a9e21b-0429-4b16-be7d-fb6ba2cdd9e7'>AttachedStyleInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>AttachedStyleInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorAttachedStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb49b42f-072a-4494-96a7-58a5986d83a0'>BackButton</a></td><td style='width:75%' ><p>The private read only <code>BackButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a576ff5e-0b79-4d3a-a3c8-4205346009e4'>ColorList</a></td><td style='width:75%' class='def'><p>The public <code>ColorList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca6c7aae-f07b-4726-8d92-d81aa59f40ae'>ColorPaletteInspector</a></td><td style='width:75%' ><p>The private read only <code>ColorPaletteInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPaleteColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26f73599-c769-4457-b550-8f37c8520d88'>DesignSurface</a></td><td style='width:75%' class='def'><p>The private read only <code>DesignSurface</code> property of the <code>ViewController</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc7aef0f-99b1-475f-b192-bff379fc672f'>DocumentScrollView</a></td><td style='width:75%' ><p>The private read only <code>DocumentScrollView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSScrollView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#143f27a4-e993-4b64-a59b-318c079375a2'>DocumentView</a></td><td style='width:75%' class='def'><p>The private read only <code>DocumentView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b0b676e-8292-4d60-8c28-373ffe48f170'>DocumentViewHeight</a></td><td style='width:75%' ><p>The private read only <code>DocumentViewHeight</code> property of the <code>ViewController</code> class has a <code>AppKit.NSLayoutConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4c2070a-20bf-41be-bd31-bd52e58864b5'>DocumentViewWidth</a></td><td style='width:75%' class='def'><p>The private read only <code>DocumentViewWidth</code> property of the <code>ViewController</code> class has a <code>AppKit.NSLayoutConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8de72de7-2b42-4018-8182-de132db1e9bb'>FillInspector</a></td><td style='width:75%' ><p>The private read only <code>FillInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFill</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71a06f9d-0c92-4c55-b098-8794209e363e'>FontInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>FontInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFont</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#127de775-651f-40a7-a5fe-de38743593df'>FrameInspector</a></td><td style='width:75%' ><p>The private read only <code>FrameInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFrame</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c605fd0d-f97c-4de0-bec3-82b6f646e16e'>GeneralInfoInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>GeneralInfoInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGeneralInfo</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0524a68e-12d7-4562-b6f9-83cf24e3fc70'>GradientInspector</a></td><td style='width:75%' ><p>The private read only <code>GradientInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24edae64-0bc4-45c0-a5cd-3283fe1cb934'>GradientList</a></td><td style='width:75%' class='def'><p>The public <code>GradientList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82c13a45-346c-4f30-88aa-02adf6e203e2'>InspectorScrollView</a></td><td style='width:75%' ><p>The private read only <code>InspectorScrollView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSScrollView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#933862f9-c5de-4ff0-aad8-f44cec1abcb7'>InspectorView</a></td><td style='width:75%' class='def'><p>The private read only <code>InspectorView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31348faa-6ed3-4737-9fee-6c2b1dc6bfef'>PolygonInspector</a></td><td style='width:75%' ><p>The private read only <code>PolygonInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPolygon</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0ee95f9-fbe4-4f9e-a2a3-e784bc98d80a'>ProjectList</a></td><td style='width:75%' class='def'><p>The public <code>ProjectList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c39d808-3fd5-4d6d-bd1e-9541f940264d'>ShapesList</a></td><td style='width:75%' ><p>The public <code>ShapesList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0e23ed7-aed7-4098-9ab4-be871949c759'>SketchesList</a></td><td style='width:75%' class='def'><p>The public <code>SketchesList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13a67ca6-0f7a-481b-86a9-0e529af2bd70'>SketchInspector</a></td><td style='width:75%' ><p>The private read only <code>SketchInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83b93a0f-d9a9-4274-af0b-0c4486bebf09'>SketchPath</a></td><td style='width:75%' class='def'><p>The private read only <code>SketchPath</code> property of the <code>ViewController</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#301499b8-8567-496d-8583-3fd0bea5dd16'>SourceList</a></td><td style='width:75%' ><p>The private read only <code>SourceList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58477a75-24ca-4d81-b93d-9d04a129094d'>StarInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>StarInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorStar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bff287d-2c6d-4b86-ba8d-98a9a565e07e'>StyleInspector</a></td><td style='width:75%' ><p>The private read only <code>StyleInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c238d919-ab85-4f13-81d6-b2f2b69535c2'>StyleList</a></td><td style='width:75%' class='def'><p>The public <code>StyleList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b67c7f6f-2822-4436-9386-e6a38f8d1e78'>TextInspector</a></td><td style='width:75%' ><p>The private read only <code>TextInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorText</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e9cc101-4b6e-4764-8588-40e3934d64bd'>ToolArrow</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolArrow</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63fd8ad7-5198-458b-b3d7-4c7fe85aca2b'>ToolBezier</a></td><td style='width:75%' ><p>The private read only <code>ToolBezier</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButtonCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fb9ea72-3407-4305-8a5b-ca47e51c968c'>ToolCursor</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolCursor</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButtonCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c87a31a1-6091-49a7-8099-2bb058a107de'>ToolLine</a></td><td style='width:75%' ><p>The private read only <code>ToolLine</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c6943e7-94dd-4416-ab48-7c4f1bfe5ee3'>ToolOval</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolOval</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31142765-c5b4-4a2a-8f40-30c33e9c7176'>ToolPolygon</a></td><td style='width:75%' ><p>The private read only <code>ToolPolygon</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21474725-38de-40b8-a872-909bc7c1a930'>ToolRect</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolRect</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a669a637-1801-4f83-bbd9-6f9ff7bfbe08'>ToolRoundRect</a></td><td style='width:75%' ><p>The private read only <code>ToolRoundRect</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d6358a6-5e0f-4814-90d4-8ee96a29c551'>ToolStar</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolStar</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#002929eb-b290-4c83-a05f-92dc589a0560'>ToolText</a></td><td style='width:75%' ><p>The private read only <code>ToolText</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09b056ba-a54b-49c7-bbe2-192fc4bfb658'>ToolTriangle</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolTriangle</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34cd200f-ce2b-4953-897e-34034d6545f3'>ToolVector</a></td><td style='width:75%' ><p>The private read only <code>ToolVector</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ec90b0d3-211f-4d63-b55c-589bc55d2c89'>AddNewColor</a></td><td style='width:75%' ><p>The public <code>AddNewColor ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bede6cee-75d2-4d10-b881-e2fb16a05f78'>AddNewColor</a></td><td style='width:75%' class='def'><p>The public <code>AddNewColor (SkiaSharp.SKColor)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe7438e7-8e18-45c1-aa81-e9b86d512afc'>AddNewGradient</a></td><td style='width:75%' ><p>The public <code>AddNewGradient ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0172d256-19f8-4a8c-b242-a7eb68e64cad'>AddNewSketch</a></td><td style='width:75%' class='def'><p>The public <code>AddNewSketch ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bf1c984-438b-48ee-a99b-1da50e5e0ce7'>AddNewStyle</a></td><td style='width:75%' ><p>The public <code>AddNewStyle ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b95b6064-4631-4ba0-97b5-73d0268c2f34'>AlignShapeBottom</a></td><td style='width:75%' class='def'><p>The public <code>AlignShapeBottom (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#998803ee-67dd-4cfe-bf33-be8d738a4421'>AlignShapeCenter</a></td><td style='width:75%' ><p>The public <code>AlignShapeCenter (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d83c3664-0b8e-43c3-bd89-c47b918b4dbc'>AlignShapeCenterHorizontal</a></td><td style='width:75%' class='def'><p>The public <code>AlignShapeCenterHorizontal (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#336e50d5-98e2-4b14-8c11-8abe913c2ce0'>AlignShapeCenterVertical</a></td><td style='width:75%' ><p>The public <code>AlignShapeCenterVertical (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14d793f0-9f0a-4211-a7b7-c81334a026b9'>AlignShapeLeft</a></td><td style='width:75%' class='def'><p>The public <code>AlignShapeLeft (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20648a9d-37d3-4a70-8ba2-0d639f308d4c'>AlignShapeRight</a></td><td style='width:75%' ><p>The public <code>AlignShapeRight (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bdf80a0-3d49-46e5-ab72-6ba8cc172c4f'>AlignShapeTop</a></td><td style='width:75%' class='def'><p>The public <code>AlignShapeTop (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bb6fc7f-67ca-4384-8536-cee783188319'>CloseAllInspectors</a></td><td style='width:75%' ><p>The private <code>CloseAllInspectors ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40569b76-9ea9-4cb3-a251-170356aa8db0'>DeleteColor</a></td><td style='width:75%' class='def'><p>The public <code>DeleteColor (KimonoCore.KimonoColor)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9703e641-acc3-42d2-b913-e64fed1723d4'>DeleteGradient</a></td><td style='width:75%' ><p>The public <code>DeleteGradient (KimonoCore.KimonoGradient)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41e44afd-cb4f-4c8e-b0a5-c6af6b8bff75'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>DeleteSelectedShape (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97087257-4ba8-4add-9468-54742299c554'>DeleteStyle</a></td><td style='width:75%' ><p>The public <code>DeleteStyle (KimonoCore.KimonoStyle)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0a49416-b307-42f3-8ea9-83b18d8abfff'>DuplicateColor</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateColor (KimonoCore.KimonoColor)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b91e45f8-19cb-4cb3-a985-fcb9f3181427'>DuplicateGradient</a></td><td style='width:75%' ><p>The public <code>DuplicateGradient (KimonoCore.KimonoGradient)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b28bd26b-2261-4dd1-a5f2-fa733bc3028e'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p>The public <code>DuplicateSelectedShape (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92278148-f308-40c5-b2ef-469cc7aee513'>DuplicateStyle</a></td><td style='width:75%' ><p>The public <code>DuplicateStyle (KimonoCore.KimonoStyle)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b09a5052-f986-4f9b-9f3f-40fd2b5c5a15'>GoBackToSketch</a></td><td style='width:75%' class='def'><p>The private <code>GoBackToSketch (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e13fac0c-1b63-400f-bff4-5a7994ca37b1'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p>The public <code>GroupUngroupSelectedShapes (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7766d89a-83b8-4305-a1f1-3e6645a9bd32'>HighlightTool</a></td><td style='width:75%' class='def'><p>The private <code>HighlightTool (KimonoCore.KimonoTool)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbc53018-57a1-4d0a-84a3-7aca8d4669ed'>InitializeInspectors</a></td><td style='width:75%' ><p>The private <code>InitializeInspectors ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f8a8bcc-54f5-46eb-a79e-b8a3bfe21cd6'>MoveBackwards</a></td><td style='width:75%' class='def'><p>The public <code>MoveBackwards (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae0d2e14-2824-48d0-9bf1-7a76f2cc583c'>MoveForwards</a></td><td style='width:75%' ><p>The public <code>MoveForwards (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d587c39e-ab1a-4b16-8bb6-ff2b9d368bde'>MoveToBottom</a></td><td style='width:75%' class='def'><p>The public <code>MoveToBottom (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c0c9859-fea4-4d3b-977d-248f3bd716a3'>MoveToTop</a></td><td style='width:75%' ><p>The public <code>MoveToTop (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#231af3d5-36ea-4e43-af00-0101eedbde3f'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p>The  <code>RaiseSketchModified (KimonoCore.KimonoSketch)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b379b39-bd12-49ed-84ad-1353830cc6fe'>Redo</a></td><td style='width:75%' ><p>The public <code>Redo (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e260bd7c-7ff0-446f-afca-2ef4610241ef'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a42d11e6-435c-4345-b163-b4d34b15f8ce'>ScrollInspectorsToTop</a></td><td style='width:75%' ><p>The private <code>ScrollInspectorsToTop ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d917ea0-a4c1-4ab6-93d4-9034898b4257'>SetDocumentSize</a></td><td style='width:75%' class='def'><p>The private <code>SetDocumentSize ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93d6449e-0618-4517-81c5-ed3036504262'>ShowGeneralInspectors</a></td><td style='width:75%' ><p>The private <code>ShowGeneralInspectors (KimonoCore.KimonoShape)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#750c785b-776d-4a0a-8435-fb5ae7c2ca81'>ShowGradientInspectors</a></td><td style='width:75%' class='def'><p>The private <code>ShowGradientInspectors (KimonoCore.KimonoGradient)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edeac5eb-aeae-4e45-8499-deedd9bb4726'>ShowGroupShapes</a></td><td style='width:75%' ><p>The private <code>ShowGroupShapes ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d94d3713-7b69-44e9-acef-b74d43477bb3'>ShowPaletteColorInspectors</a></td><td style='width:75%' class='def'><p>The private <code>ShowPaletteColorInspectors (KimonoCore.KimonoColor)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4437ed05-d015-449e-bdfa-fca269e5b79e'>ShowSketchInspectors</a></td><td style='width:75%' ><p>The private <code>ShowSketchInspectors (KimonoCore.KimonoSketch)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#379ee846-c18b-46bf-a3f1-5ec196376178'>ShowSketchShapes</a></td><td style='width:75%' class='def'><p>The private <code>ShowSketchShapes ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d394e5d-9f6d-42b2-ad35-43d922746659'>ShowStyleInspectors</a></td><td style='width:75%' ><p>The private <code>ShowStyleInspectors (KimonoCore.KimonoStyle)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b901426-7c7f-4283-93e1-b382d3c5e790'>ToolArrowSelected</a></td><td style='width:75%' class='def'><p>The private <code>ToolArrowSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2415974-9339-4298-943c-7d3e0ff0c7d1'>ToolBezierSelected</a></td><td style='width:75%' ><p>The private <code>ToolBezierSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1869d28-9fd6-4b51-9a33-04589daeb635'>ToolCursorSelected</a></td><td style='width:75%' class='def'><p>The private <code>ToolCursorSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b242b9ae-d1f9-4f82-ae79-6a1bf8153cc0'>ToolLineSelected</a></td><td style='width:75%' ><p>The private <code>ToolLineSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89c258ea-c93f-4619-994f-db54025336d7'>ToolOvalSelected</a></td><td style='width:75%' class='def'><p>The private <code>ToolOvalSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05629d15-cc9e-4234-b78d-1cdd5ae96bdf'>ToolPolygonSelected</a></td><td style='width:75%' ><p>The private <code>ToolPolygonSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfaeb151-9ea1-4536-850a-67c37aef9a08'>ToolRectSelected</a></td><td style='width:75%' class='def'><p>The private <code>ToolRectSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a6d5f93-a548-472f-9773-8e663cb71ea0'>ToolRoundRectSelected</a></td><td style='width:75%' ><p>The private <code>ToolRoundRectSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab770c46-f9ef-46e8-9fb3-daff90e3a45d'>ToolStarSelected</a></td><td style='width:75%' class='def'><p>The private <code>ToolStarSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f03b149b-d1ed-4ca5-916d-8a01efecb18c'>ToolTextSelected</a></td><td style='width:75%' ><p>The private <code>ToolTextSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2b1fd8d-2e54-4e7f-97b4-72556065b0c0'>ToolTriangleSelected</a></td><td style='width:75%' class='def'><p>The private <code>ToolTriangleSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#188c354a-fe83-4c71-8256-6829c4dc949d'>ToolVectorSelected</a></td><td style='width:75%' ><p>The private <code>ToolVectorSelected (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#681de9b5-31d7-43f3-b6ea-af6bcf523fac'>Undo</a></td><td style='width:75%' class='def'><p>The public <code>Undo (Foundation.NSObject)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74d69163-ce26-4c7b-a067-dfd8b0f3578c'>UpdateColorList</a></td><td style='width:75%' ><p>The private <code>UpdateColorList (System.Boolean)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79cc7d4b-3fce-4e55-aa0c-472b0ac591c9'>UpdateGradientList</a></td><td style='width:75%' class='def'><p>The private <code>UpdateGradientList (System.Boolean)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#630d3f47-99cb-48d6-9b0f-63e5fb4707f4'>UpdatePath</a></td><td style='width:75%' ><p>The private <code>UpdatePath ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#042805a8-70ea-4b78-ba70-87c4715e7c6a'>UpdateProjectList</a></td><td style='width:75%' class='def'><p>The private <code>UpdateProjectList (System.Boolean)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc1d2a1b-9176-4518-b3ba-c6e706fe1ee8'>UpdateShapesList</a></td><td style='width:75%' ><p>The private <code>UpdateShapesList (System.Boolean)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b3213a5-4c08-4572-944a-0532438666db'>UpdateSketchesList</a></td><td style='width:75%' class='def'><p>The private <code>UpdateSketchesList (System.Boolean)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6867aafa-2489-4a03-b5f6-ab0f47dd46b8'>UpdateStyleList</a></td><td style='width:75%' ><p>The private <code>UpdateStyleList (System.Boolean)</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a7cc9cd-b61d-41f2-8d07-bc02b26f8bae'>ValidateMenuItem</a></td><td style='width:75%' class='def'><p>The public <code>ValidateMenuItem (AppKit.NSMenuItem)</code> member of the <code>ViewController</code> class returns a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a10b9f3-a1fe-41c2-8c91-effed3d35f4b'>ViewController</a></td><td style='width:75%' ><p>The public <code>ViewController (System.IntPtr)</code> constructor for the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd1a4560-6b6e-4e2a-abb5-c2205e6b0398'>ViewDidLoad</a></td><td style='width:75%' class='def'><p>The public virtual <code>ViewDidLoad ()</code> member of the <code>ViewController</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9b300758-6940-4930-bfa3-172925197e45'>SketchModified</a></td><td style='width:75%' ><p>The <code>SketchModified</code> event of the <code>ViewController</code> class returns a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr></table></p>

<a name="Fields"></a>
#Fields


---

<a name="7285ac32-7058-4ed4-ab02-e486b9f08680"></a>
##Private _controller

###Value

[KimonoMac.SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The private `_controller` field of the `SourceListDataSource` class holds a `KimonoMac.SourceListView` value.

---

<a name="bd72e506-e888-45e8-910a-d0c2641ce965"></a>
##Private _controller

###Value

[KimonoMac.SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The private `_controller` field of the `SourceListDelegate` class holds a `KimonoMac.SourceListView` value.

---

<a name="70f83465-46d5-45ab-8a4d-bf89a58177c4"></a>
##Private _icon

###Value

`AppKit.NSImage`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The private `_icon` field of the `SourceListItem` class holds a `AppKit.NSImage` value.

---

<a name="7e56cefd-fa16-4720-b1b2-c97361afb5d6"></a>
##Private _items

###Value

`System.Collections.Generic.List<KimonoMac.SourceListItem>`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The private `_items` field of the `SourceListItem` class holds a `System.Collections.Generic.List<KimonoMac.SourceListItem>` value.

---

<a name="051110d9-1591-4044-91c3-380a0abb5da2"></a>
##Private _position

###Value

`System.Int32`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The private `_position` field of the `SourceListItem` class holds a `System.Int32` value.

---

<a name="e08a5438-66f8-425b-9df1-89a8f25bd205"></a>
##Private _selectedColor

###Value

`KimonoCore.KimonoColor`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `_selectedColor` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.KimonoColor` value.

---

<a name="01f186d2-9da1-4a93-9c1a-4d89efb842a1"></a>
##Private _selectedGradient

###Value

`KimonoCore.KimonoGradient`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `_selectedGradient` field of the `KimonoInspectorGradient` class holds a `KimonoCore.KimonoGradient` value.

---

<a name="44e43360-0ff3-4f6a-8172-9150a85cc671"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShapePolygon`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The private `_selectedShape` field of the `KimonoInspectorPolygon` class holds a `KimonoCore.KimonoShapePolygon` value.

---

<a name="754ee023-dfb0-4541-90bf-3c6fe6f177f6"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `_selectedShape` field of the `KimonoInspectorGradient` class holds a `KimonoCore.KimonoShape` value.

---

<a name="fdaba297-81e7-4c68-9997-f9f84bf94869"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShapeStar`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private `_selectedShape` field of the `KimonoInspectorStar` class holds a `KimonoCore.KimonoShapeStar` value.

---

<a name="a6547545-4aa9-4d2e-b2e6-762d8e3aafb1"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShapeText`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The private `_selectedShape` field of the `KimonoInspectorText` class holds a `KimonoCore.KimonoShapeText` value.

---

<a name="226f8bbe-0ac7-41eb-89bf-b318d51f8443"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShapeArrow`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `_selectedShape` field of the `KimonoInspectorArrow` class holds a `KimonoCore.KimonoShapeArrow` value.

---

<a name="c99d67ab-a4f5-449c-9a89-6872e5610007"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `_selectedShape` field of the `KimonoInspectorStyle` class holds a `KimonoCore.KimonoShape` value.

---

<a name="b69f34ca-f456-42ee-adeb-43fb6786e532"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `_selectedShape` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.KimonoShape` value.

---

<a name="61b32667-a800-424b-87cf-c5b233f82cc6"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `_selectedShape` field of the `KimonoInspectorFont` class holds a `KimonoCore.KimonoShape` value.

---

<a name="4ac96772-653f-48ea-9622-0e3f1a6975d0"></a>
##Private _selectedShape

###Value

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `_selectedShape` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.KimonoShape` value.

---

<a name="68d22a83-512d-42dc-8c88-1ae7d4ef0364"></a>
##Private _selectedSketch

###Value

`KimonoCore.KimonoSketch`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `_selectedSketch` field of the `KimonoInspectorSketch` class holds a `KimonoCore.KimonoSketch` value.

---

<a name="9ea55da8-af61-4714-bd49-7e02bfda8a9b"></a>
##Private _selectedStyle

###Value

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `_selectedStyle` field of the `KimonoInspectorStyle` class holds a `KimonoCore.KimonoStyle` value.

---

<a name="0a8893b5-e6a2-415a-8701-a967b2c92a78"></a>
##Private _selectedStyle

###Value

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `_selectedStyle` field of the `KimonoInspectorFrame` class holds a `KimonoCore.KimonoStyle` value.

---

<a name="710cd46c-8cea-4e4e-ad84-738ea252eee2"></a>
##Private _selectedStyle

###Value

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `_selectedStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.KimonoStyle` value.

---

<a name="d32fd6cc-2f0c-44ef-9812-f4f35f9f705f"></a>
##Private _selectedStyle

###Value

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `_selectedStyle` field of the `KimonoInspectorFill` class holds a `KimonoCore.KimonoStyle` value.

---

<a name="004b725b-c4ad-4cf4-b35f-2fd1e3a285fe"></a>
##Private _selectedStyle

###Value

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `_selectedStyle` field of the `KimonoInspectorFont` class holds a `KimonoCore.KimonoStyle` value.

---

<a name="3c90e8ed-ac3f-4728-81c9-71b590e52d88"></a>
##Private _tag

###Value

`System.String`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The private `_tag` field of the `SourceListItem` class holds a `System.String` value.

---

<a name="6eb20b16-329a-451c-89b7-a41c04daf709"></a>
##Private _title

###Value

`System.String`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The private `_title` field of the `SourceListItem` class holds a `System.String` value.

---

<a name="47d1c52f-a93b-420b-b03f-0d6b49687889"></a>
##Private AvailableBaseColors

###Value

`System.Collections.Generic.List<KimonoCore.KimonoColor>`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `AvailableBaseColors` field of the `KimonoInspectorPaleteColor` class holds a `System.Collections.Generic.List<KimonoCore.KimonoColor>` value.

---

<a name="bfc310b0-16f0-49a2-a7c1-d27873116339"></a>
##Private Clicked

###Value

`KimonoMac.SourceListItem.ClickedDelegate`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The private `Clicked` field of the `SourceListItem` class holds a `KimonoMac.SourceListItem.ClickedDelegate` value.

---

<a name="8bb04c8c-7d44-420c-999f-f2b37184759c"></a>
##Private ColorModified

###Value

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `ColorModified` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="4e2f5068-3260-4fc7-9c20-d8aaba1a5b0e"></a>
##Private ConvertToStyle

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `ConvertToStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="7858f562-02eb-4551-9a83-b9031115f782"></a>
##Private EditAttachedStyle

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `EditAttachedStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="24cdbd63-27ff-455d-b290-bb145a2ae549"></a>
##Private FirstChange

###Value

`System.Boolean`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The private `FirstChange` field of the `KimonoInspectorText` class holds a `System.Boolean` value.

---

<a name="8cc7b234-5d5f-47e0-9eb5-9d0beb03a16d"></a>
##Private GradientModified

###Value

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `GradientModified` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="72bf9829-9342-4e34-a556-d7fa4628fc5f"></a>
##Public Items

###Value

`System.Collections.Generic.List<KimonoMac.SourceListItem>`

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The public `Items` field of the `SourceListDataSource` class holds a `System.Collections.Generic.List<KimonoMac.SourceListItem>` value.

---

<a name="eea1008a-6ae9-4255-b992-c8d851ff4d40"></a>
##Private ItemSelected

###Value

`KimonoMac.SourceListView.ItemSelectedDelegate`

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The private `ItemSelected` field of the `SourceListView` class holds a `KimonoMac.SourceListView.ItemSelectedDelegate` value.

---

<a name="6700cee4-a904-45f3-8bb9-982b10f76095"></a>
##Private MakeDuplicate

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="f068d852-531b-477b-8b88-e9aae4b55d30"></a>
##Private MakeDuplicate

###Value

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="3dbec3a5-e104-4609-afd0-f6019af846a5"></a>
##Private MakeDuplicate

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="c8fbfe25-0dbc-4cd6-a3f8-332d9f044cc9"></a>
##Private MakeDuplicate

###Value

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="73364969-594e-4863-b144-8e6b72062c68"></a>
##Private MakeDuplicate

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="a6c7d0f7-46d8-47ca-9268-9c854b9b6e5a"></a>
##Private MakeNewColor

###Value

`KimonoCore.Kimono.SkiaColorEventDelegate`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `MakeNewColor` field of the `KimonoInspectorFill` class holds a `KimonoCore.Kimono.SkiaColorEventDelegate` value.

---

<a name="5bf02d05-b18c-4e40-9d44-3405c2f2dad3"></a>
##Private MakeNewColor

###Value

`KimonoCore.Kimono.SkiaColorEventDelegate`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `MakeNewColor` field of the `KimonoInspectorFrame` class holds a `KimonoCore.Kimono.SkiaColorEventDelegate` value.

---

<a name="e26f0b6f-0cb2-40de-b6c2-945a41ca5fd3"></a>
##Private RemoveColor

###Value

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `RemoveColor` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="2d9ccaff-8127-4dd7-9042-f0d55510986f"></a>
##Private RemoveGradient

###Value

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `RemoveGradient` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="efeedd02-30b8-4c78-9ec5-b54e0ca3d040"></a>
##Private RemoveShape

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `RemoveShape` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="399aca6a-9d75-42d5-bb1d-9926693525cf"></a>
##Private RemoveSketch

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `RemoveSketch` field of the `KimonoInspectorSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="42e7aa8d-a8d0-4e6c-9361-19390c9b4a86"></a>
##Private RemoveStyle

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `RemoveStyle` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="5ed90439-b0a1-4ebe-b176-2588dcb164d7"></a>
##Private RemoveStyle

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `RemoveStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="26f5b764-7b46-4326-8568-364da2295795"></a>
##Private ReturnToShape

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `ReturnToShape` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="5baca6c1-caeb-475d-b765-cba4499446d9"></a>
##Private ReturnToShape

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `ReturnToShape` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="cf327f91-8f0a-458b-a7d7-7d564f4e60af"></a>
##Private ReturnToShape

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `ReturnToShape` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="f9d57952-754b-4030-a9b9-8eb6485c4faf"></a>
##Private SelectionChanged

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `SelectionChanged` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="d2b0b0ca-81a2-4463-847b-6dc4928a3339"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private `ShapeModified` field of the `KimonoInspectorStar` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="04371a5e-b04c-4064-a0b3-527c2e1d05de"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `ShapeModified` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ec737447-aa6a-49d5-9134-46651fa8a908"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The private `ShapeModified` field of the `KimonoInspectorPolygon` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="d102163b-08eb-4d0d-9861-3bcb4a6ba314"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `ShapeModified` field of the `KimonoInspectorFrame` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="a6a048ce-f6cb-4078-a9cf-e8d253514752"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `ShapeModified` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="d5692941-cf17-4084-ba13-7ff6d1a77a48"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `ShapeModified` field of the `KimonoInspectorFont` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="1b66e3a6-a94a-4103-8cda-3ef4f042627f"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The private `ShapeModified` field of the `KimonoInspectorText` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="713de8f5-5111-4d17-9653-7eca8461d3fd"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `ShapeModified` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="02a6cfe7-0c82-4bba-a2a5-bd11ecef5261"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `ShapeModified` field of the `KimonoInspectorArrow` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="9c49ac6c-46b1-493c-afb4-9cb249c34ba6"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `ShapeModified` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="0a2eeb33-c6e1-473c-bdf2-1598ec8634cf"></a>
##Private ShapeModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `ShapeModified` field of the `KimonoInspectorFill` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="147b1d26-e98b-444a-adb4-a06fa1319831"></a>
##Private SketchModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `SketchModified` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="27f530d5-cae8-4c16-90f3-b1d2be1a0063"></a>
##Private SketchModified

###Value

`KimonoCore.Kimono.SketchEventDelegate`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `SketchModified` field of the `ViewController` class holds a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="213968db-fb19-4df7-b512-aab6f6950360"></a>
##Private SketchModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `SketchModified` field of the `KimonoInspectorSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="eb980fc6-9c13-4a48-9943-10bad114d735"></a>
##Private StyleModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `StyleModified` field of the `KimonoInspectorFont` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="a218ff7a-d7ce-4e88-a760-17cde1500eff"></a>
##Private StyleModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `StyleModified` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="4cf2c79b-1ba8-4d9d-947d-e46ea1ac7536"></a>
##Private StyleModified

###Value

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `StyleModified` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="6128e4da-b293-4ba2-afb2-a469838623ac"></a>
##Private StyleTypeChanged

###Value

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `StyleTypeChanged` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="628440fc-2411-4dd6-84b9-56ae896e422f"></a>
##Private TextChanged

###Value

`KimonoMac.KimonoTextView.TextChangedDelegate`

###Member of Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The private `TextChanged` field of the `KimonoTextView` class holds a `KimonoMac.KimonoTextView.TextChangedDelegate` value.
<a name="Properties"></a>
#Properties


---

<a name="1773ea96-3e19-498d-a97c-4dbc70171fa8"></a>
##Public Active

###Return Type

`System.Boolean`

###Member of Type

[ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Summary

The public `Active` property of the `ActivatableItem` class has a `System.Boolean` value.

---

<a name="572ce4f9-dcf0-4d51-a34b-5f637768e5b2"></a>
##Private Read Only AddColorButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `AddColorButton` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="cf44b36f-b9c6-4ae6-a623-dfb4b6dfa39b"></a>
##Private Read Only AddColorButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `AddColorButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="80e19e20-a681-44c5-8151-78d1ed25287d"></a>
##Private Read Only AddColorButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `AddColorButton` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="2554f3ef-46ac-49c5-a049-79ddc74fb135"></a>
##Private Read Only AddPointButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `AddPointButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="8ad2cb31-7d12-423d-a0b5-46e6f56358c3"></a>
##Private Read Only AdjustBrightnessCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `AdjustBrightnessCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="1977a7de-33bc-48fe-bad9-ac0dcfb9ffd7"></a>
##Private Read Only AdjustHueCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `AdjustHueCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="fd85adbe-0aa8-4074-94be-d6cafffd62b8"></a>
##Private Read Only AdjustOpacityCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `AdjustOpacityCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="6e8f0039-84fb-479a-84a6-c2dccd7741e4"></a>
##Private Read Only AdjustSaturationCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `AdjustSaturationCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="109f5975-5376-406f-b0db-59193c43baae"></a>
##Private Read Only AlignBottomTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `AlignBottomTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="9baba028-e782-4dd6-afa6-9720b255d7c1"></a>
##Private Read Only AlignLeftTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `AlignLeftTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="387e7464-a981-4f73-8f09-bfb3f88595d0"></a>
##Private Read Only Alignment

###Return Type

`AppKit.NSSegmentedControl`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `Alignment` property of the `KimonoInspectorFont` class has a `AppKit.NSSegmentedControl` value.

---

<a name="ff7dcb67-441f-4351-bd0e-f388061c4f13"></a>
##Private Read Only AlignRightTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `AlignRightTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="f73a9502-867d-4201-8acf-684213ff5f58"></a>
##Private Read Only AlignTopTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `AlignTopTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="eacec212-0498-4e50-89a3-d18119f68423"></a>
##Private Read Only AntialiasCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `AntialiasCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="4e038aa0-7bfe-4e94-a0fa-3d1a028b80b7"></a>
##Private Read Only AntialiaseCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `AntialiaseCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="3c444bb5-1553-4d32-89ca-0b85078c044b"></a>
##Private Read Only ApplyButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private read only `ApplyButton` property of the `KimonoInspectorStyle` class has a `AppKit.NSButton` value.

---

<a name="dae1a719-c8e1-4b54-a14d-711be6909c17"></a>
##Private Read Only ArrowInspector

###Return Type

[KimonoMac.KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ArrowInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorArrow` value.

---

<a name="14a9e21b-0429-4b16-be7d-fb6ba2cdd9e7"></a>
##Private Read Only AttachedStyleInspector

###Return Type

[KimonoMac.KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `AttachedStyleInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorAttachedStyle` value.

---

<a name="c2aa5300-fce2-4874-84e3-a20895db1935"></a>
##Private Read Only Backbutton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private read only `Backbutton` property of the `KimonoInspectorStyle` class has a `AppKit.NSButton` value.

---

<a name="fb49b42f-072a-4494-96a7-58a5986d83a0"></a>
##Private Read Only BackButton

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `BackButton` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="68ecccf0-8e10-43f6-a7cf-8c6384fb7973"></a>
##Private Read Only BackButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `BackButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="7d88c4b4-1946-4ce1-85db-13f132cdd9fb"></a>
##Private Read Only BaseColorSelector

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `BaseColorSelector` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSPopUpButton` value.

---

<a name="21b8a845-0bf0-4395-a373-1e1bc80109e2"></a>
##Private Read Only BlendMode

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `BlendMode` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="55f2e832-5800-4b04-8df7-42bcb48d2286"></a>
##Private Read Only BlendMode

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `BlendMode` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="8b689ef9-2680-4818-8e7e-7e504cfdc859"></a>
##Private Read Only BlurCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `BlurCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="c8ad7835-3e9c-426a-b301-c747caac3027"></a>
##Private Read Only BlurCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `BlurCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="509086d6-18f7-47f6-a607-3e9ead141d61"></a>
##Private Read Only BrightnessSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `BrightnessSlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="3a033172-a07a-41ef-b553-9babb7d9021c"></a>
##Private Read Only BrightnessValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `BrightnessValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="0d63f107-922d-4342-9e07-166188118703"></a>
##Private Read Only CanvasColor

###Return Type

`AppKit.NSColorWell`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `CanvasColor` property of the `KimonoInspectorSketch` class has a `AppKit.NSColorWell` value.

---

<a name="5e5e6965-d7b0-4564-9eaf-3c0411a4ad31"></a>
##Private Read Only CanvasColorCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `CanvasColorCheckbox` property of the `KimonoInspectorSketch` class has a `AppKit.NSButton` value.

---

<a name="bd856b6e-b5f7-4b49-bd68-26e94bf0fa7f"></a>
##Private Read Only CenterHorizontalTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `CenterHorizontalTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="c3e97942-9175-4198-8b7e-d381a78e94f4"></a>
##Private Read Only CenterTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `CenterTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="eb786982-b9c7-4f57-8b55-f18aebe205c7"></a>
##Private Read Only CenterVerticalTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `CenterVerticalTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="422022c3-375f-4cac-b7fb-6eca54215370"></a>
##Private Read Only Color

###Return Type

`AppKit.NSColorWell`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `Color` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSColorWell` value.

---

<a name="a576ff5e-0b79-4d3a-a3c8-4205346009e4"></a>
##Public ColorList

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `ColorList` property of the `ViewController` class has a `KimonoMac.SourceListItem` value.

---

<a name="ca2cb823-9b31-451a-bf7f-7d55779022ff"></a>
##Private Read Only ColorName

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `ColorName` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="ca6c7aae-f07b-4726-8d92-d81aa59f40ae"></a>
##Private Read Only ColorPaletteInspector

###Return Type

[KimonoMac.KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ColorPaletteInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorPaleteColor` value.

---

<a name="839a0eb9-35c2-4ed8-b66b-a724a6f06239"></a>
##Private Read Only Contents

###Return Type

[KimonoMac.KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The private read only `Contents` property of the `KimonoInspectorText` class has a `KimonoMac.KimonoTextView` value.

---

<a name="797710ca-f817-4b59-a6d6-0270511639d3"></a>
##Public Read Only Count

###Return Type

`System.Int32`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public read only `Count` property of the `SourceListItem` class has a `System.Int32` value.

---

<a name="da3b18d1-5904-4502-aeb7-d43d2855e5d3"></a>
##Public Virtual Read Only Current

###Return Type

`System.Object`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public read only virtual `Current` property of the `SourceListItem` class has a `System.Object` value.

---

<a name="1c187bfd-fc65-44b9-9de6-55358ff1c2bb"></a>
##Private Read Only Dash1

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash1` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="85c2797e-1df5-43ae-baf5-47ba159b25a8"></a>
##Private Read Only Dash10

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash10` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="b45502be-62bd-44bf-bec3-d62e9954d5b1"></a>
##Private Read Only Dash11

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash11` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="9cecab6d-6c32-4dfa-bc4d-4425cc799804"></a>
##Private Read Only Dash12

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash12` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="36432e84-3e2a-4d31-81bf-b7100deb1075"></a>
##Private Read Only Dash13

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash13` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="1fadf8b1-0003-4951-8900-7e935c3eb653"></a>
##Private Read Only Dash14

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash14` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="9a6203aa-dc8b-46c3-850b-0b83c1a5b9c3"></a>
##Private Read Only Dash15

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash15` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="aa99e79d-2128-431f-ad2b-ab946dea4032"></a>
##Private Read Only Dash16

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash16` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="9a60e87a-561c-42ff-8c1c-4947b79c3995"></a>
##Private Read Only Dash2

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash2` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="a64fb513-a323-483e-a11d-862171b169c2"></a>
##Private Read Only Dash3

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash3` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="43cc722f-f563-42f5-b662-91788874e816"></a>
##Private Read Only Dash4

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash4` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="2126ef00-449c-49f6-869d-74f6684d5ae6"></a>
##Private Read Only Dash5

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash5` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="cd44eef5-81c0-45ba-988a-e50c6c47b06c"></a>
##Private Read Only Dash6

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash6` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="addee740-9b9e-48e2-8a66-457eb785e595"></a>
##Private Read Only Dash7

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash7` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="5ad788af-4d2e-4bfb-bde1-898f6991382a"></a>
##Private Read Only Dash8

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash8` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="01555121-3efa-4ecd-92f3-9bd61ccc52ba"></a>
##Private Read Only Dash9

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `Dash9` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="87ad1660-3a7a-4ce5-b27b-890dd86f33f9"></a>
##Private Read Only DashCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `DashCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="1c702ae8-b163-45ec-9401-4412340e90fd"></a>
##Public Read Only Data

###Return Type

[KimonoMac.SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public read only `Data` property of the `SourceListView` class has a `KimonoMac.SourceListDataSource` value.

---

<a name="21d0606c-090d-48d2-be6a-8dd68f222002"></a>
##Private Read Only DeleteButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private read only `DeleteButton` property of the `KimonoInspectorStyle` class has a `AppKit.NSButton` value.

---

<a name="3d6ecdc4-8c78-4baa-8042-464957a43f82"></a>
##Private Read Only DeleteButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `DeleteButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="11566787-ceeb-40fa-a7c3-0c29ac3ac318"></a>
##Private Read Only DeletePointButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `DeletePointButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="051acc14-584f-4f8d-9309-95e3c52bf6e0"></a>
##Private Read Only DepthSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private read only `DepthSlider` property of the `KimonoInspectorStar` class has a `AppKit.NSSlider` value.

---

<a name="220ddfa6-2dd4-4407-ba7a-1aae76f8118c"></a>
##Private Read Only DepthValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private read only `DepthValue` property of the `KimonoInspectorStar` class has a `AppKit.NSTextField` value.

---

<a name="da6d364c-138e-4fd3-b01b-1e70c39c8ec9"></a>
##Private Read Only DesignBar

###Return Type

`KimonoCore.Mac.KimonoGradientDesignBar`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `DesignBar` property of the `KimonoInspectorGradient` class has a `KimonoCore.Mac.KimonoGradientDesignBar` value.

---

<a name="8f0d875d-c310-458b-b181-c49597e72584"></a>
##Private Read Only DesignPreview

###Return Type

`KimonoCore.Mac.KimonoGradientDesignPreview`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `DesignPreview` property of the `KimonoInspectorGradient` class has a `KimonoCore.Mac.KimonoGradientDesignPreview` value.

---

<a name="2777f216-8b39-42ce-9170-141f5afc16a4"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public `DesignSurface` property of the `KimonoInspectorFill` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="e5b76d82-e318-4702-8758-4f01eefa2db9"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `DesignSurface` property of the `KimonoInspectorFont` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="0b66c95f-bc4f-43ff-8a72-8a2c419bc299"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The public `DesignSurface` property of the `KimonoInspectorText` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="26f73599-c769-4457-b550-8f37c8520d88"></a>
##Private Read Only DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `DesignSurface` property of the `ViewController` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="953dd786-dc43-478f-9e18-260f480754bf"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The public `DesignSurface` property of the `KimonoInspectorArrow` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="0d94a2cc-d5c5-4aca-b52b-1219775aa089"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The public `DesignSurface` property of the `KimonoInspectorGeneralInfo` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="25271ad0-88ac-49e7-942f-522d83e524c9"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public `DesignSurface` property of the `KimonoInspectorFrame` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="72338e1e-b338-4fbd-a16e-696854bcb738"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `DesignSurface` property of the `KimonoInspectorAttachedStyle` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="534933cf-6767-4d9f-a940-c749622b12f7"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `DesignSurface` property of the `KimonoInspectorGradient` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="5feaede4-4a05-485f-8369-d3c76c91195f"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The public `DesignSurface` property of the `KimonoInspectorStar` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="e3a9ab20-de99-4f34-93cc-cb7e9cc2ed53"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `DesignSurface` property of the `KimonoInspectorPaleteColor` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="6dd711e7-0e9e-4982-8fd4-b4e19fe65062"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The public `DesignSurface` property of the `KimonoInspectorPolygon` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="d05afe23-49b4-4fc6-81a2-1c379ff2e287"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `DesignSurface` property of the `KimonoInspectorStyle` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="65d562d6-40d8-46bd-98d9-bacbd2a27e73"></a>
##Public DesignSurface

###Return Type

`KimonoCore.Mac.KimonoDesignSurface`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The public `DesignSurface` property of the `KimonoInspectorSketch` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="2de50ca1-1889-4e4a-9261-8d1372c7faa9"></a>
##Private Read Only DeviationSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `DeviationSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="2637a886-25b5-4925-afb4-8160893f509f"></a>
##Private Read Only DeviationSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `DeviationSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="80f8c8ad-eb01-48be-b5de-ddc4f16bd717"></a>
##Private Read Only DeviationValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `DeviationValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="dc521e67-0217-4039-bdac-8f0e262d01eb"></a>
##Private Read Only DeviationValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `DeviationValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="dc7aef0f-99b1-475f-b192-bff379fc672f"></a>
##Private Read Only DocumentScrollView

###Return Type

`AppKit.NSScrollView`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `DocumentScrollView` property of the `ViewController` class has a `AppKit.NSScrollView` value.

---

<a name="143f27a4-e993-4b64-a59b-318c079375a2"></a>
##Private Read Only DocumentView

###Return Type

`AppKit.NSView`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `DocumentView` property of the `ViewController` class has a `AppKit.NSView` value.

---

<a name="9b0b676e-8292-4d60-8c28-373ffe48f170"></a>
##Private Read Only DocumentViewHeight

###Return Type

`AppKit.NSLayoutConstraint`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `DocumentViewHeight` property of the `ViewController` class has a `AppKit.NSLayoutConstraint` value.

---

<a name="a4c2070a-20bf-41be-bd31-bd52e58864b5"></a>
##Private Read Only DocumentViewWidth

###Return Type

`AppKit.NSLayoutConstraint`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `DocumentViewWidth` property of the `ViewController` class has a `AppKit.NSLayoutConstraint` value.

---

<a name="6a7d574f-0c50-4a09-b20d-8073677ebad8"></a>
##Private Read Only DuplicateButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `DuplicateButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="b672e30b-0f9b-4f3e-9b4e-1fb04b25cfa8"></a>
##Private Read Only DuplicatePointButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `DuplicatePointButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="5eb79975-ab88-4c8e-b5ab-090514c39ddb"></a>
##Private Read Only EditButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private read only `EditButton` property of the `KimonoInspectorAttachedStyle` class has a `AppKit.NSButton` value.

---

<a name="31c0f260-bdac-4baf-8d6d-6856bc7b3f82"></a>
##Private Read Only EditButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `EditButton` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSButton` value.

---

<a name="971456eb-1fac-4293-a1be-7320be49b155"></a>
##Private Read Only EndCap

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `EndCap` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="d881d62f-74d5-4e24-8f5f-8855e9e08674"></a>
##Private Read Only FillCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `FillCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="b4b4888f-2776-449b-b3cc-a3b3f4ba7bc0"></a>
##Private Read Only FillColor

###Return Type

`AppKit.NSColorWell`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `FillColor` property of the `KimonoInspectorFill` class has a `AppKit.NSColorWell` value.

---

<a name="8de72de7-2b42-4018-8182-de132db1e9bb"></a>
##Private Read Only FillInspector

###Return Type

[KimonoMac.KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `FillInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorFill` value.

---

<a name="71a06f9d-0c92-4c55-b098-8794209e363e"></a>
##Private Read Only FontInspector

###Return Type

[KimonoMac.KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `FontInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorFont` value.

---

<a name="20fe12de-5c9e-417d-8dec-3c5a9ed835f6"></a>
##Private Read Only FrameCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `FrameCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="40354962-434f-4ab6-bb7c-611fb52d3799"></a>
##Private Read Only FrameColor

###Return Type

`AppKit.NSColorWell`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `FrameColor` property of the `KimonoInspectorFrame` class has a `AppKit.NSColorWell` value.

---

<a name="127de775-651f-40a7-a5fe-de38743593df"></a>
##Private Read Only FrameInspector

###Return Type

[KimonoMac.KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `FrameInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorFrame` value.

---

<a name="c605fd0d-f97c-4de0-bec3-82b6f646e16e"></a>
##Private Read Only GeneralInfoInspector

###Return Type

[KimonoMac.KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `GeneralInfoInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorGeneralInfo` value.

---

<a name="d7ca58e5-6382-408b-9b59-eadc0b471999"></a>
##Private Read Only GoBackButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `GoBackButton` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="7dd7f160-9371-4509-8f8c-75fa936a79ed"></a>
##Private Read Only GradientDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `GradientDropdown` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="90edc16b-e739-48ad-b4d9-dec2db6a5b0f"></a>
##Private Read Only GradientDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `GradientDropdown` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="0524a68e-12d7-4562-b6f9-83cf24e3fc70"></a>
##Private Read Only GradientInspector

###Return Type

[KimonoMac.KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `GradientInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorGradient` value.

---

<a name="24edae64-0bc4-45c0-a5cd-3283fe1cb934"></a>
##Public GradientList

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `GradientList` property of the `ViewController` class has a `KimonoMac.SourceListItem` value.

---

<a name="cfb411ce-a139-43ad-b931-f1e0fa02d3e5"></a>
##Private Read Only GradientName

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `GradientName` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="b4c0a738-6a71-4ffa-af37-f3cf16c84000"></a>
##Private Read Only GroupShapes

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `GroupShapes` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="2085b477-96c2-45a9-b9bc-f8011704cb65"></a>
##Private Read Only GroupUngroupButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `GroupUngroupButton` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSButton` value.

---

<a name="7f9a87b2-5580-4130-8978-7e1e3a928913"></a>
##Public Read Only HasChildren

###Return Type

`System.Boolean`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public read only `HasChildren` property of the `SourceListItem` class has a `System.Boolean` value.

---

<a name="ad396e84-61ee-41e3-96a9-03637c5f2272"></a>
##Private Read Only HeadCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `HeadCheckbox` property of the `KimonoInspectorArrow` class has a `AppKit.NSButton` value.

---

<a name="8726397a-a6d1-42ff-96a9-372ebe03fe20"></a>
##Private Read Only HorizontalBlurSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `HorizontalBlurSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="51cabeed-c7ad-4b5f-a93a-51c04fc83747"></a>
##Private Read Only HorizontalBlurSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `HorizontalBlurSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="01093757-49d3-4848-81b6-146615bf660c"></a>
##Private Read Only HorizontalBlurValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `HorizontalBlurValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="61f570c9-2585-4430-a4af-1372266f2782"></a>
##Private Read Only HorizontalBlurValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `HorizontalBlurValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="0eaf1f34-cb36-420c-a20e-c801b78df74f"></a>
##Private Read Only HueSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `HueSlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="23eca598-d568-48b2-91a2-d2afd7039192"></a>
##Private Read Only HueValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `HueValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="96e6ca2b-65a6-4ccb-ba22-c693c6c34c29"></a>
##Public Icon

###Return Type

`AppKit.NSImage`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `Icon` property of the `SourceListItem` class has a `AppKit.NSImage` value.

---

<a name="bcccbb3d-8135-4b2b-9f5e-80b6159c2c7a"></a>
##Private Read Only InnerSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `InnerSlider` property of the `KimonoInspectorArrow` class has a `AppKit.NSSlider` value.

---

<a name="4c191894-5441-4343-937f-9163bb1873cc"></a>
##Private Read Only InnerValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `InnerValue` property of the `KimonoInspectorArrow` class has a `AppKit.NSTextField` value.

---

<a name="82c13a45-346c-4f30-88aa-02adf6e203e2"></a>
##Private Read Only InspectorScrollView

###Return Type

`AppKit.NSScrollView`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `InspectorScrollView` property of the `ViewController` class has a `AppKit.NSScrollView` value.

---

<a name="933862f9-c5de-4ff0-aad8-f44cec1abcb7"></a>
##Private Read Only InspectorView

###Return Type

`AppKit.NSView`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `InspectorView` property of the `ViewController` class has a `AppKit.NSView` value.

---

<a name="b08c67ae-4aae-4891-a2e6-e2f71593d687"></a>
##Public Item(System.Int32)

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `Item(System.Int32)` property of the `SourceListItem` class has a `KimonoMac.SourceListItem` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p>The <code>index</code> parameter of the Item method takes a <code>System.Int32</code> value. </p>
</td></tr></table></p>


---

<a name="fd34caff-961e-40f0-9106-f13408d4cd5f"></a>
##Private Read Only JitterCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `JitterCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="e781bd26-d95f-4285-a1f2-e85525349186"></a>
##Private Read Only JitterCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `JitterCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="5504504c-6448-4ce8-8dc7-3326d3623c7d"></a>
##Private Read Only JoinType

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `JoinType` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="0e710119-1276-4545-908d-efc6a1038f81"></a>
##Private Read Only LengthSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `LengthSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="20bb2638-c508-42b9-9f98-06dcf8cf8dfe"></a>
##Private Read Only LengthSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `LengthSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="1303a516-05d5-440a-8a82-c41757ad6500"></a>
##Private Read Only LengthValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `LengthValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="4ed84530-b8f6-4db6-93c6-b12a620c5ee8"></a>
##Private Read Only LengthValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `LengthValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="d6183820-0e69-4eda-bb65-5ab4dd2b6e2a"></a>
##Private Read Only LinkedColorDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `LinkedColorDropdown` property of the `KimonoInspectorGradient` class has a `AppKit.NSPopUpButton` value.

---

<a name="33bcf6f4-345d-49bf-b899-4e3b6eebafb0"></a>
##Private Read Only LinkedColorSelector

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `LinkedColorSelector` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="b22b3fcb-5305-4d7e-a74e-0763f806b2b4"></a>
##Private Read Only LinkedColorSelector

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `LinkedColorSelector` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="37fcf4d5-74af-45ca-a486-1264d6de0f56"></a>
##Public Read Only MainController

###Return Type

[KimonoMac.ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public read only `MainController` property of the `MainWindowController` class has a `KimonoMac.ViewController` value.

---

<a name="76442057-ef47-4b48-964d-c173d615fe98"></a>
##Private Read Only MiterSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `MiterSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="57635a91-175e-44f0-933d-f9a896049768"></a>
##Private Read Only MiterValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `MiterValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="20cf763b-3444-40c9-b679-10d88faba306"></a>
##Private Read Only MoveBackwardsTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `MoveBackwardsTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="f8dcda37-1ce6-4dc7-8590-0730546a4612"></a>
##Private Read Only MoveBottomTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `MoveBottomTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="74c67662-1e1b-4301-855d-e455547d947b"></a>
##Private Read Only MoveForwardsTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `MoveForwardsTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="7fa4a1c4-c7fd-42d0-9a28-c30aa29e3750"></a>
##Private Read Only MoveTopTool

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `MoveTopTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="4ab7c4a5-fd88-4639-b981-ebde2f279def"></a>
##Private Read Only OpacitySlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="e144bc17-353b-48bd-8f43-e23a17d17f63"></a>
##Private Read Only OpacitySlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorSketch` class has a `AppKit.NSSlider` value.

---

<a name="71c4a528-77aa-4a5c-b570-35deefbd6729"></a>
##Private Read Only OpacitySlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="2597aec9-f590-4489-960e-1c701ab2f017"></a>
##Private Read Only OpacitySlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorGradient` class has a `AppKit.NSSlider` value.

---

<a name="460a800f-720b-44e7-abc2-1e8d2f2cb691"></a>
##Private Read Only OpacitySlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="ad580012-efbf-46db-bfae-71b6683179ed"></a>
##Private Read Only OpacityValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="6d7c76f4-9cd8-4a63-8afd-f35219378617"></a>
##Private Read Only OpacityValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="930d2ef8-14c2-435e-bb20-3827fbff2f82"></a>
##Private Read Only OpacityValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="b0ac95fc-b37f-40be-93f0-c98533f926d1"></a>
##Private Read Only OpacityValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="6d021a58-2a5e-42cc-a5fb-9da2153f7646"></a>
##Private Read Only OpacityValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="d08ca565-4ba2-43f9-b3a2-46bd230d868c"></a>
##Private Read Only OuterSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `OuterSlider` property of the `KimonoInspectorArrow` class has a `AppKit.NSSlider` value.

---

<a name="1a08046a-fac8-40c8-af40-46be400ed5b7"></a>
##Private Read Only OuterValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `OuterValue` property of the `KimonoInspectorArrow` class has a `AppKit.NSTextField` value.

---

<a name="180e8858-67ae-4881-b18d-9cd5a111f48e"></a>
##Private Read Only PointColor

###Return Type

`AppKit.NSColorWell`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `PointColor` property of the `KimonoInspectorGradient` class has a `AppKit.NSColorWell` value.

---

<a name="02f7716d-0b31-43b9-9487-3346a7bfb9ce"></a>
##Private Read Only PointsSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private read only `PointsSlider` property of the `KimonoInspectorStar` class has a `AppKit.NSSlider` value.

---

<a name="c9f663a2-d7af-4f1e-ba16-ff2b59c6c8aa"></a>
##Private Read Only PointsValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private read only `PointsValue` property of the `KimonoInspectorStar` class has a `AppKit.NSTextField` value.

---

<a name="31348faa-6ed3-4737-9fee-6c2b1dc6bfef"></a>
##Private Read Only PolygonInspector

###Return Type

[KimonoMac.KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `PolygonInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorPolygon` value.

---

<a name="aa7557e4-aa4c-4979-a51f-f63f5ed2a9c0"></a>
##Public Read Only Portfolio

###Return Type

`KimonoCore.KimonoPortfolio`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public read only `Portfolio` property of the `KimonoInspectorAttachedStyle` class has a `KimonoCore.KimonoPortfolio` value.

---

<a name="05ab9939-6c8a-46fd-baeb-280be0ceba83"></a>
##Public Read Only Portfolio

###Return Type

`KimonoCore.KimonoPortfolio`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public read only `Portfolio` property of the `KimonoInspectorGradient` class has a `KimonoCore.KimonoPortfolio` value.

---

<a name="9d06775b-0dfc-44ef-a4e9-65ae8d092c99"></a>
##Public Read Only Portfolio

###Return Type

`KimonoCore.KimonoPortfolio`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public read only `Portfolio` property of the `KimonoInspectorFrame` class has a `KimonoCore.KimonoPortfolio` value.

---

<a name="e2b3f04d-61d5-453a-a5f3-3a85487c9a87"></a>
##Public Read Only Portfolio

###Return Type

`KimonoCore.KimonoPortfolio`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public read only `Portfolio` property of the `KimonoInspectorPaleteColor` class has a `KimonoCore.KimonoPortfolio` value.

---

<a name="ee5abe5f-756c-41c0-9b39-131952d1148b"></a>
##Public Read Only Portfolio

###Return Type

`KimonoCore.KimonoPortfolio`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public read only `Portfolio` property of the `KimonoInspectorFill` class has a `KimonoCore.KimonoPortfolio` value.

---

<a name="f0ee95f9-fbe4-4f9e-a2a3-e784bc98d80a"></a>
##Public ProjectList

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `ProjectList` property of the `ViewController` class has a `KimonoMac.SourceListItem` value.

---

<a name="4d05ea4d-d8be-4553-a806-dd6061a313b7"></a>
##Private Read Only RadiusSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `RadiusSlider` property of the `KimonoInspectorGradient` class has a `AppKit.NSSlider` value.

---

<a name="c3ced308-9970-4766-b94c-696dc9220c0f"></a>
##Private Read Only RadiusValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `RadiusValue` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="4265b61d-8a12-40a5-972c-282723357b89"></a>
##Private Read Only RotationSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `RotationSlider` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSSlider` value.

---

<a name="e4acf2da-20e6-4578-a4b0-9f4b1b6f6173"></a>
##Private Read Only RotationValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `RotationValue` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="ce863677-f9c0-4192-bf4d-4160a104e434"></a>
##Private Read Only SaturationSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `SaturationSlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="c94af99d-13aa-4e31-b779-2ecb8e55f4ef"></a>
##Private Read Only SaturationValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private read only `SaturationValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="0689dc37-a016-4f13-ac97-ac2daaf93e21"></a>
##Private Read Only ScaleSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `ScaleSlider` property of the `KimonoInspectorFont` class has a `AppKit.NSSlider` value.

---

<a name="f9d562ea-512b-405d-9a8d-50e6d077589f"></a>
##Private Read Only ScaleValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `ScaleValue` property of the `KimonoInspectorFont` class has a `AppKit.NSTextField` value.

---

<a name="75d29502-d2d2-4ac8-8364-2a12e077713e"></a>
##Public SelectedColor

###Return Type

`KimonoCore.KimonoColor`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `SelectedColor` property of the `KimonoInspectorPaleteColor` class has a `KimonoCore.KimonoColor` value.

---

<a name="a1dc34a1-39fc-4ff0-bd9d-12c3f727d3d9"></a>
##Private Read Only SelectedColorTitle

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `SelectedColorTitle` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="6b2591fb-d8d6-4ff6-b412-eb606d7d4544"></a>
##Public SelectedGradient

###Return Type

`KimonoCore.KimonoGradient`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `SelectedGradient` property of the `KimonoInspectorGradient` class has a `KimonoCore.KimonoGradient` value.

---

<a name="3ed5ce01-8902-4084-976a-b4068d124837"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `SelectedShape` property of the `KimonoInspectorFont` class has a `KimonoCore.KimonoShape` value.

---

<a name="5e8c164d-8c5b-437c-8754-720eec1925bb"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShapePolygon`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The public `SelectedShape` property of the `KimonoInspectorPolygon` class has a `KimonoCore.KimonoShapePolygon` value.

---

<a name="0671636b-6549-4fb3-a342-7e327a5b4847"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShapeText`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The public `SelectedShape` property of the `KimonoInspectorText` class has a `KimonoCore.KimonoShapeText` value.

---

<a name="62599413-99f1-4c4b-81a8-b78784dd37e1"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `SelectedShape` property of the `KimonoInspectorPaleteColor` class has a `KimonoCore.KimonoShape` value.

---

<a name="44c5e62c-6456-4c06-99f0-7e238ab8011c"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The public `SelectedShape` property of the `KimonoInspectorGeneralInfo` class has a `KimonoCore.KimonoShape` value.

---

<a name="71668770-d809-4ebf-9f77-fb0dd8bbe4dd"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShapeStar`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The public `SelectedShape` property of the `KimonoInspectorStar` class has a `KimonoCore.KimonoShapeStar` value.

---

<a name="e001373c-72dd-43ec-98a0-0f922d56e0fa"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `SelectedShape` property of the `KimonoInspectorGradient` class has a `KimonoCore.KimonoShape` value.

---

<a name="a59caa9c-1974-44ea-a57f-ed742ba05ac3"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `SelectedShape` property of the `KimonoInspectorStyle` class has a `KimonoCore.KimonoShape` value.

---

<a name="56ec58cd-0a09-4976-a9ce-cb5d5d5eeca4"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShape`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `SelectedShape` property of the `KimonoInspectorAttachedStyle` class has a `KimonoCore.KimonoShape` value.

---

<a name="831f559c-e50e-4457-99c8-cd6bcf0aa74d"></a>
##Public SelectedShape

###Return Type

`KimonoCore.KimonoShapeArrow`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The public `SelectedShape` property of the `KimonoInspectorArrow` class has a `KimonoCore.KimonoShapeArrow` value.

---

<a name="9a89d74d-d7c4-4701-92b7-caada6adff91"></a>
##Public SelectedSketch

###Return Type

`KimonoCore.KimonoSketch`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The public `SelectedSketch` property of the `KimonoInspectorSketch` class has a `KimonoCore.KimonoSketch` value.

---

<a name="1ce5f811-eaf4-4afe-8f98-9d7a0c1c1d89"></a>
##Public SelectedStyle

###Return Type

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public `SelectedStyle` property of the `KimonoInspectorFill` class has a `KimonoCore.KimonoStyle` value.

---

<a name="72e59244-57c0-42ea-a343-944d1cc47029"></a>
##Public SelectedStyle

###Return Type

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `SelectedStyle` property of the `KimonoInspectorFont` class has a `KimonoCore.KimonoStyle` value.

---

<a name="b139938a-1073-4333-a2d1-88c193bd89b0"></a>
##Public SelectedStyle

###Return Type

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `SelectedStyle` property of the `KimonoInspectorAttachedStyle` class has a `KimonoCore.KimonoStyle` value.

---

<a name="9510c9a2-d6de-436e-9680-9eb0f7fb932f"></a>
##Public SelectedStyle

###Return Type

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `SelectedStyle` property of the `KimonoInspectorStyle` class has a `KimonoCore.KimonoStyle` value.

---

<a name="41e3e4cc-32b5-4a7d-9037-c62fe25a40d3"></a>
##Public SelectedStyle

###Return Type

`KimonoCore.KimonoStyle`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public `SelectedStyle` property of the `KimonoInspectorFrame` class has a `KimonoCore.KimonoStyle` value.

---

<a name="1d1d2d97-3294-4fa9-b169-3a5e92e0a3da"></a>
##Private Read Only ShapeHeight

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `ShapeHeight` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="1c21ad47-aaf0-4f76-9829-cca073cccda3"></a>
##Private Read Only ShapeName

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `ShapeName` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="9c39d808-3fd5-4d6d-bd1e-9541f940264d"></a>
##Public ShapesList

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `ShapesList` property of the `ViewController` class has a `KimonoMac.SourceListItem` value.

---

<a name="140b1c03-4f34-4f65-a0b4-61d1883ad233"></a>
##Private Read Only ShapeType

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `ShapeType` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="241606ad-5f48-4a21-a0b7-9c08fabd25e8"></a>
##Private Read Only ShapeWidth

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `ShapeWidth` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="815fb56f-e8f2-40c5-a28a-f96b3493d8d7"></a>
##Private Read Only ShapeX

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `ShapeX` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="197f26df-9542-4f91-b863-44338ca2b444"></a>
##Private Read Only ShapeY

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `ShapeY` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="b4f18005-5f65-475f-b715-0c3b73291fc2"></a>
##Private Read Only SidesSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The private read only `SidesSlider` property of the `KimonoInspectorPolygon` class has a `AppKit.NSSlider` value.

---

<a name="ddd1ad82-7012-4dd2-adf9-804e14c3e55e"></a>
##Private Read Only SidesValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The private read only `SidesValue` property of the `KimonoInspectorPolygon` class has a `AppKit.NSTextField` value.

---

<a name="cfca10b6-4bbc-4edf-a470-3ffb508c0f78"></a>
##Private Read Only Size

###Return Type

`AppKit.NSComboBox`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `Size` property of the `KimonoInspectorFont` class has a `AppKit.NSComboBox` value.

---

<a name="a0e23ed7-aed7-4098-9ab4-be871949c759"></a>
##Public SketchesList

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `SketchesList` property of the `ViewController` class has a `KimonoMac.SourceListItem` value.

---

<a name="ebcc08a2-a6a7-4cd3-8fd2-14a150e50de5"></a>
##Private Read Only SketchHeight

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `SketchHeight` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="13a67ca6-0f7a-481b-86a9-0e529af2bd70"></a>
##Private Read Only SketchInspector

###Return Type

[KimonoMac.KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `SketchInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorSketch` value.

---

<a name="70a57e02-f6b0-4276-8228-558782b5f1d7"></a>
##Private Read Only SketchName

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `SketchName` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="83b93a0f-d9a9-4274-af0b-0c4486bebf09"></a>
##Private Read Only SketchPath

###Return Type

`AppKit.NSTextField`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `SketchPath` property of the `ViewController` class has a `AppKit.NSTextField` value.

---

<a name="9c166615-6d9a-4bc9-b4a7-57d8607c9287"></a>
##Private Read Only SketchWidth

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private read only `SketchWidth` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="0f52e6fc-64d4-4760-aa85-b9b76dc806c9"></a>
##Private Read Only SkewSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `SkewSlider` property of the `KimonoInspectorFont` class has a `AppKit.NSSlider` value.

---

<a name="5650b4bd-9480-47f9-9c17-aaba1656e282"></a>
##Private Read Only SkewValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `SkewValue` property of the `KimonoInspectorFont` class has a `AppKit.NSTextField` value.

---

<a name="df388527-aedc-4937-9c62-0f4610eb6a15"></a>
##Private Read Only SkipSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private read only `SkipSlider` property of the `KimonoInspectorStar` class has a `AppKit.NSSlider` value.

---

<a name="92a79205-f2df-4c03-b3ce-f1bcf1cde473"></a>
##Private Read Only SkipValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private read only `SkipValue` property of the `KimonoInspectorStar` class has a `AppKit.NSTextField` value.

---

<a name="301499b8-8567-496d-8583-3fd0bea5dd16"></a>
##Private Read Only SourceList

###Return Type

[KimonoMac.SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `SourceList` property of the `ViewController` class has a `KimonoMac.SourceListView` value.

---

<a name="58477a75-24ca-4d81-b93d-9d04a129094d"></a>
##Private Read Only StarInspector

###Return Type

[KimonoMac.KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `StarInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorStar` value.

---

<a name="1de82342-28a3-4c97-9da1-38989a71d219"></a>
##Private Read Only StreamlinedCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `StreamlinedCheckbox` property of the `KimonoInspectorArrow` class has a `AppKit.NSButton` value.

---

<a name="b31a2a96-0692-4e48-a23c-2353340fef34"></a>
##Private Read Only StrikeThruCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `StrikeThruCheckbox` property of the `KimonoInspectorFont` class has a `AppKit.NSButton` value.

---

<a name="0bff287d-2c6d-4b86-ba8d-98a9a565e07e"></a>
##Private Read Only StyleInspector

###Return Type

[KimonoMac.KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `StyleInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorStyle` value.

---

<a name="c238d919-ab85-4f13-81d6-b2f2b69535c2"></a>
##Public StyleList

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `StyleList` property of the `ViewController` class has a `KimonoMac.SourceListItem` value.

---

<a name="91fc210b-4f9f-45ba-92c9-9535e93e3882"></a>
##Private Read Only StyleName

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private read only `StyleName` property of the `KimonoInspectorStyle` class has a `AppKit.NSTextField` value.

---

<a name="6b8ac11e-140e-437a-b16d-4d5b18420bd8"></a>
##Private Read Only StyleSelector

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private read only `StyleSelector` property of the `KimonoInspectorAttachedStyle` class has a `AppKit.NSPopUpButton` value.

---

<a name="82de8f70-3d1b-4117-82c6-b4f69ceee712"></a>
##Public Tag

###Return Type

`System.String`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `Tag` property of the `SourceListItem` class has a `System.String` value.

---

<a name="efb8257f-69e1-4e2a-ab59-02daf28a1962"></a>
##Private Read Only TailCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private read only `TailCheckbox` property of the `KimonoInspectorArrow` class has a `AppKit.NSButton` value.

---

<a name="b67c7f6f-2822-4436-9386-e6a38f8d1e78"></a>
##Private Read Only TextInspector

###Return Type

[KimonoMac.KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `TextInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorText` value.

---

<a name="113a842d-9293-4cb7-ae7d-d2fff979374d"></a>
##Private Read Only TileDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `TileDropdown` property of the `KimonoInspectorGradient` class has a `AppKit.NSPopUpButton` value.

---

<a name="6b9d1a30-4e1d-4bfd-8609-6cdbf90a0dbf"></a>
##Public Title

###Return Type

`System.String`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `Title` property of the `SourceListItem` class has a `System.String` value.

---

<a name="6e9cc101-4b6e-4764-8588-40e3934d64bd"></a>
##Private Read Only ToolArrow

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolArrow` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="63fd8ad7-5198-458b-b3d7-4c7fe85aca2b"></a>
##Private Read Only ToolBezier

###Return Type

`AppKit.NSButtonCell`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolBezier` property of the `ViewController` class has a `AppKit.NSButtonCell` value.

---

<a name="9fb9ea72-3407-4305-8a5b-ca47e51c968c"></a>
##Private Read Only ToolCursor

###Return Type

`AppKit.NSButtonCell`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolCursor` property of the `ViewController` class has a `AppKit.NSButtonCell` value.

---

<a name="c87a31a1-6091-49a7-8099-2bb058a107de"></a>
##Private Read Only ToolLine

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolLine` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="7c6943e7-94dd-4416-ab48-7c4f1bfe5ee3"></a>
##Private Read Only ToolOval

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolOval` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="31142765-c5b4-4a2a-8f40-30c33e9c7176"></a>
##Private Read Only ToolPolygon

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolPolygon` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="21474725-38de-40b8-a872-909bc7c1a930"></a>
##Private Read Only ToolRect

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolRect` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="a669a637-1801-4f83-bbd9-6f9ff7bfbe08"></a>
##Private Read Only ToolRoundRect

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolRoundRect` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="1d6358a6-5e0f-4814-90d4-8ee96a29c551"></a>
##Private Read Only ToolStar

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolStar` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="002929eb-b290-4c83-a05f-92dc589a0560"></a>
##Private Read Only ToolText

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolText` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="09b056ba-a54b-49c7-bbe2-192fc4bfb658"></a>
##Private Read Only ToolTriangle

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolTriangle` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="34cd200f-ce2b-4953-897e-34034d6545f3"></a>
##Private Read Only ToolVector

###Return Type

`AppKit.NSButton`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private read only `ToolVector` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="4b58600a-8d52-4219-932b-c6cf434cc41e"></a>
##Private Read Only TypeDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private read only `TypeDropdown` property of the `KimonoInspectorGradient` class has a `AppKit.NSPopUpButton` value.

---

<a name="3ff5d736-0a98-4f91-9487-971af2279567"></a>
##Private Read Only TypeDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private read only `TypeDropdown` property of the `KimonoInspectorStyle` class has a `AppKit.NSPopUpButton` value.

---

<a name="4c64b3c7-5a65-472d-9501-101915a65eca"></a>
##Private Read Only TypefaceDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `TypefaceDropdown` property of the `KimonoInspectorFont` class has a `AppKit.NSPopUpButton` value.

---

<a name="7b8ef83f-bd78-4c82-8e50-83713f5f1deb"></a>
##Private Read Only UnderlineCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `UnderlineCheckbox` property of the `KimonoInspectorFont` class has a `AppKit.NSButton` value.

---

<a name="e30bcc84-a695-4bfc-8fa8-7dc1aef01d85"></a>
##Private Read Only UngroupShapes

###Return Type

[KimonoMac.ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private read only `UngroupShapes` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="3dd6be13-a4ce-4670-904b-657cb8868e16"></a>
##Private Read Only VerticalBlurSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `VerticalBlurSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="0e571947-cadc-4d1b-a796-6a2850afd76c"></a>
##Private Read Only VerticalBlurSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `VerticalBlurSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="767037be-a8ae-4513-92d9-0349285e66ff"></a>
##Private Read Only VerticalBlurValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `VerticalBlurValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="a6a8aeea-8521-4b87-9e3e-8a68aff29403"></a>
##Private Read Only VerticalBlurValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private read only `VerticalBlurValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="634dc2e5-8d57-4113-9e8d-3367f647049b"></a>
##Private Read Only VerticalCheckbox

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `VerticalCheckbox` property of the `KimonoInspectorFont` class has a `AppKit.NSButton` value.

---

<a name="d0e067f0-1094-4370-aadb-2438d2115608"></a>
##Private Read Only VisibleButton

###Return Type

`AppKit.NSButton`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private read only `VisibleButton` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSButton` value.

---

<a name="56fe9e76-150a-48e9-af25-331d360c828c"></a>
##Private Read Only WeightDropdown

###Return Type

`AppKit.NSPopUpButton`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private read only `WeightDropdown` property of the `KimonoInspectorFont` class has a `AppKit.NSPopUpButton` value.

---

<a name="0b4658f5-4d78-489a-8678-9f7caa570355"></a>
##Private Read Only WidthSlider

###Return Type

`AppKit.NSSlider`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `WidthSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="7592c6b0-bab8-4755-ba9b-4c7267e60a29"></a>
##Private Read Only WidthValue

###Return Type

`AppKit.NSTextField`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private read only `WidthValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.
<a name="Methods"></a>
#Methods


---

<a name="0c580caf-a22a-47f4-b080-4b42523e94e5"></a>
##Public Void ActivatableItem ()

###Constructor for Type

[ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Summary

The public `ActivatableItem ()` constructor for the `ActivatableItem` class.

---

<a name="4d590ef4-4cad-4865-9a8d-2290490dd372"></a>
##Public Void ActivatableItem (Foundation.NSObjectFlag)

###Constructor for Type

[ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Summary

The public `ActivatableItem (Foundation.NSObjectFlag)` constructor for the `ActivatableItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>t</td><td style='width:75%' ><p>The <code>t</code> parameter of the ActivatableItem method takes a <code>Foundation.NSObjectFlag</code> value. </p>
</td></tr></table></p>


---

<a name="18af9f6d-a738-4d4a-9dfd-73f15f7910eb"></a>
##Public Void ActivatableItem (System.IntPtr)

###Constructor for Type

[ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Summary

The public `ActivatableItem (System.IntPtr)` constructor for the `ActivatableItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the ActivatableItem method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="dc9b5617-6357-4892-ab54-885bb35948a1"></a>
##Public Void ActivatableItem (System.String)

###Constructor for Type

[ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Summary

The public `ActivatableItem (System.String)` constructor for the `ActivatableItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the ActivatableItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="f2c33bba-3445-4aaf-9554-c651493050c9"></a>
##Public Void AddColor (Foundation.NSObject)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public `AddColor (Foundation.NSObject)` member of the `MainWindowController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddColor method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="7addaa15-137d-4b78-8991-88377dd40fb2"></a>
##Private Void AddColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `AddColor (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddColor method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2b7a5b0e-2df7-46e1-8ebb-3a09807ffd63"></a>
##Private Void AddColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `AddColor (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddColor method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="44ab1148-e098-4e3a-9c94-1ee8dc91fb14"></a>
##Private Void AddColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `AddColor (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddColor method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ebc25d70-aeec-45f9-ae48-6324036efd34"></a>
##Public Void AddGradient (Foundation.NSObject)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public `AddGradient (Foundation.NSObject)` member of the `MainWindowController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddGradient method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="044a6c45-9627-4b88-b0e8-e0b5526757d2"></a>
##Public Void AddItem (KimonoMac.SourceListItem)

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public `AddItem (KimonoMac.SourceListItem)` member of the `SourceListView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the AddItem method takes a <code>KimonoMac.SourceListItem</code> value. </p>
</td></tr></table></p>


---

<a name="88a45166-8433-43c5-ae84-52f54dbd68a0"></a>
##Public Void AddItem (KimonoMac.SourceListItem)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (KimonoMac.SourceListItem)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the AddItem method takes a <code>KimonoMac.SourceListItem</code> value. </p>
</td></tr></table></p>


---

<a name="ab1c9c31-0fca-45ee-82fd-9b3111571e40"></a>
##Public Void AddItem (System.String)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="3ed67555-b410-4114-a081-a0a923ac149e"></a>
##Public Void AddItem (System.String, AppKit.NSImage)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String, AppKit.NSImage)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the AddItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr></table></p>


---

<a name="616f6b64-4033-4e15-a4fe-46cd56b3e1de"></a>
##Public Void AddItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the AddItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p>The <code>clicked</code> parameter of the AddItem method takes a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value. </p>
</td></tr></table></p>


---

<a name="00794a46-99ed-4113-978f-5696f8bbc266"></a>
##Public Void AddItem (System.String, AppKit.NSImage, System.String)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String, AppKit.NSImage, System.String)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the AddItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p>The <code>tag</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="5a48f582-7ea5-47e5-882f-48d9f1c5aa49"></a>
##Public Void AddItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the AddItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p>The <code>tag</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' class='def'><p>The <code>clicked</code> parameter of the AddItem method takes a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value. </p>
</td></tr></table></p>


---

<a name="8b545484-9ee3-4997-ba17-db7b4f3170b0"></a>
##Public Void AddItem (System.String, System.String)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String, System.String)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="6a091a71-7077-4ba1-860f-bd19578e699e"></a>
##Public Void AddItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `AddItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the AddItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p>The <code>clicked</code> parameter of the AddItem method takes a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value. </p>
</td></tr></table></p>


---

<a name="ec90b0d3-211f-4d63-b55c-589bc55d2c89"></a>
##Public Void AddNewColor ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AddNewColor ()` member of the `ViewController` class.

---

<a name="bede6cee-75d2-4d10-b881-e2fb16a05f78"></a>
##Public Void AddNewColor (SkiaSharp.SKColor)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AddNewColor (SkiaSharp.SKColor)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p>The <code>baseColor</code> parameter of the AddNewColor method takes a <code>SkiaSharp.SKColor</code> value. </p>
</td></tr></table></p>


---

<a name="fe7438e7-8e18-45c1-aa81-e9b86d512afc"></a>
##Public Void AddNewGradient ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AddNewGradient ()` member of the `ViewController` class.

---

<a name="0172d256-19f8-4a8c-b242-a7eb68e64cad"></a>
##Public Void AddNewSketch ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AddNewSketch ()` member of the `ViewController` class.

---

<a name="7bf1c984-438b-48ee-a99b-1da50e5e0ce7"></a>
##Public Void AddNewStyle ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AddNewStyle ()` member of the `ViewController` class.

---

<a name="3c91e199-d929-4940-9820-d945b9e208e6"></a>
##Private Void AddPoint (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `AddPoint (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddPoint method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="9b9cd5b1-ef64-4b35-bc62-ccac554cffd1"></a>
##Public Void AddSketch (Foundation.NSObject)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public `AddSketch (Foundation.NSObject)` member of the `MainWindowController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddSketch method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="c7307738-ab9c-4b9e-a49e-ba854e4cb140"></a>
##Public Void AddStyle (Foundation.NSObject)

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public `AddStyle (Foundation.NSObject)` member of the `MainWindowController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AddStyle method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="226111da-2bac-404e-bd3f-2b104a464c30"></a>
##Private Void AdjustBrightnessChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `AdjustBrightnessChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AdjustBrightnessChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2f37f94b-de60-4fea-b19b-6f8496c29faf"></a>
##Private Void AdjustHueChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `AdjustHueChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AdjustHueChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="1cbfd4b7-a0ba-459a-92b1-a966bd566637"></a>
##Private Void AdjustOpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `AdjustOpacityChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AdjustOpacityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e544aaa1-b051-43eb-930f-6df3e5dc7149"></a>
##Private Void AdjustSaturationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `AdjustSaturationChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AdjustSaturationChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0e1ba524-1155-41d1-aa76-6ed54ae1f752"></a>
##Private Void AlignmentChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `AlignmentChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignmentChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b95b6064-4631-4ba0-97b5-73d0268c2f34"></a>
##Public Void AlignShapeBottom (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeBottom (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeBottom method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="998803ee-67dd-4cfe-bf33-be8d738a4421"></a>
##Public Void AlignShapeCenter (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeCenter (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeCenter method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="d83c3664-0b8e-43c3-bd89-c47b918b4dbc"></a>
##Public Void AlignShapeCenterHorizontal (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeCenterHorizontal (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeCenterHorizontal method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="336e50d5-98e2-4b14-8c11-8abe913c2ce0"></a>
##Public Void AlignShapeCenterVertical (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeCenterVertical (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeCenterVertical method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="14d793f0-9f0a-4211-a7b7-c81334a026b9"></a>
##Public Void AlignShapeLeft (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeLeft (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeLeft method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="20648a9d-37d3-4a70-8ba2-0d639f308d4c"></a>
##Public Void AlignShapeRight (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeRight (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeRight method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2bdf80a0-3d49-46e5-ab72-6ba8cc172c4f"></a>
##Public Void AlignShapeTop (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `AlignShapeTop (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AlignShapeTop method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a386448f-cf4c-444e-a044-de22df3a519e"></a>
##Private Void AntialiasChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `AntialiasChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AntialiasChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a71efa7d-b167-4fd6-93df-f548af89c17b"></a>
##Private Void AntialiaseChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `AntialiaseChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the AntialiaseChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0793d88b-57ca-4fd7-bf2d-4ab1c25fd876"></a>
##Public Void AppDelegate ()

###Constructor for Type

[AppDelegate](#85c5cfff-5452-46bd-a635-bc6028026976)

###Summary

The public `AppDelegate ()` constructor for the `AppDelegate` class.

---

<a name="1db2e5b2-1e57-4bfb-95d4-dc2c6300437b"></a>
##Private Void ApplyChange (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `ApplyChange (Foundation.NSObject)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ApplyChange method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="57472b4b-eb43-4965-bdeb-01c99508980a"></a>
##Public Virtual Void AwakeFromNib ()

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public virtual `AwakeFromNib ()` member of the `SourceListView` class.

---

<a name="d2ffbb18-5fb3-4b11-9fd4-0f7fc358a4fb"></a>
##Private Void BaseColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `BaseColorChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the BaseColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="3d0a8b28-9d9b-4158-a5cd-d6342a9cbee1"></a>
##Private Void BlendModeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `BlendModeChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the BlendModeChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="942d410a-c885-4b86-a19f-4a2bf675d46a"></a>
##Private Void BlendModeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `BlendModeChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the BlendModeChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="bb44032c-230f-4c0d-9b8d-4f090e63e584"></a>
##Private Void BlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `BlurChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the BlurChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="aecc211e-3994-4838-a903-a25b8669a77e"></a>
##Private Void BlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `BlurChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the BlurChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="c048b136-98e2-4dce-87c1-25768902c9e5"></a>
##Private Void BrightnessChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `BrightnessChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the BrightnessChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="661b0ea1-38eb-4d60-ad02-42aa40e19f5b"></a>
##Private Void CanvasColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `CanvasColorChanged (Foundation.NSObject)` member of the `KimonoInspectorSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the CanvasColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="1b2e0790-2354-45fe-a094-f0551e08b088"></a>
##Public Void CenteringClipView ()

###Constructor for Type

[CenteringClipView](#1c9586fd-9c41-46bf-8bdd-8416188a35a4)

###Summary

The public `CenteringClipView ()` constructor for the `CenteringClipView` class.

---

<a name="d740894a-2b50-4e8a-9839-575319554fbe"></a>
##Public Void CenteringClipView (System.IntPtr)

###Constructor for Type

[CenteringClipView](#1c9586fd-9c41-46bf-8bdd-8416188a35a4)

###Summary

The public `CenteringClipView (System.IntPtr)` constructor for the `CenteringClipView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the CenteringClipView method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="bcd271df-4c4b-4530-9640-de141618ecd5"></a>
##Public Void Clear ()

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `Clear ()` member of the `SourceListItem` class.

---

<a name="8bb6fc7f-67ca-4384-8536-cee783188319"></a>
##Private Void CloseAllInspectors ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `CloseAllInspectors ()` member of the `ViewController` class.

---

<a name="90106296-13dc-4e35-ac66-328dbe049146"></a>
##Private Void ColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `ColorChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2e82f924-91e9-45b0-991e-e2c5efa8e511"></a>
##Private Void ColorNameChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `ColorNameChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ColorNameChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0011f38f-dc2f-458f-bef1-02c6ed32c637"></a>
##Public Virtual ConstrainBoundsRect (CoreGraphics.CGRect)

###Return Type

`CoreGraphics.CGRect`

###Member of Type

[CenteringClipView](#1c9586fd-9c41-46bf-8bdd-8416188a35a4)

###Summary

The public virtual `ConstrainBoundsRect (CoreGraphics.CGRect)` member of the `CenteringClipView` class returns a `CoreGraphics.CGRect` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>proposedBounds</td><td style='width:75%' ><p>The <code>proposedBounds</code> parameter of the ConstrainBoundsRect method takes a <code>CoreGraphics.CGRect</code> value. </p>
</td></tr></table></p>


---

<a name="b8eb34a3-a92a-4e2b-92fc-d1a42cda7bdf"></a>
##Private ConvertContentInsetsToProposedBoundsSize (CoreGraphics.CGSize)

###Return Type

`AppKit.NSEdgeInsets`

###Member of Type

[CenteringClipView](#1c9586fd-9c41-46bf-8bdd-8416188a35a4)

###Summary

The private `ConvertContentInsetsToProposedBoundsSize (CoreGraphics.CGSize)` member of the `CenteringClipView` class returns a `AppKit.NSEdgeInsets` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>proposedBoundsSize</td><td style='width:75%' ><p>The <code>proposedBoundsSize</code> parameter of the ConvertContentInsetsToProposedBoundsSize method takes a <code>CoreGraphics.CGSize</code> value. </p>
</td></tr></table></p>


---

<a name="aff9cce3-3ad8-43cc-9a77-2cb25a6df2f0"></a>
##Private Void Dash10Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash10Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash10Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2a1ea685-0db4-4759-81ee-7bdca200d8e6"></a>
##Private Void Dash11Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash11Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash11Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="98281119-0b10-4555-a211-f21062415b85"></a>
##Private Void Dash12Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash12Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash12Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a45ab55a-7a69-402d-8d43-e66b4b20d534"></a>
##Private Void Dash13Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash13Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash13Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ad2ca0c1-ae4b-40ff-b4ed-646c32ece25e"></a>
##Private Void Dash14Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash14Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash14Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e02f1fa1-acf0-436e-a326-6250eebbd75d"></a>
##Private Void Dash15Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash15Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash15Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b383d78a-ed2b-4fc5-b0ce-d522c1f500d7"></a>
##Private Void Dash16Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash16Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash16Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0dfba120-ccba-4d15-a418-c779cc51ead1"></a>
##Private Void Dash1Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash1Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash1Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b171ba37-51a2-4d51-ae78-56df4acac28e"></a>
##Private Void Dash2Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash2Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash2Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="1cd75468-0070-4578-8867-1ab14ac948aa"></a>
##Private Void Dash3Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash3Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash3Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="4ba45669-4e05-4b84-a2b0-5ffb2e4861b1"></a>
##Private Void Dash4Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash4Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash4Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e993e072-d5e9-4437-bcf8-e5c1a0f53298"></a>
##Private Void Dash5Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash5Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash5Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="19db634c-19ea-47bb-a1bc-f7a145ad99b0"></a>
##Private Void Dash6Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash6Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash6Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ea77ff5c-1515-4830-8c14-0da6ff73fd2e"></a>
##Private Void Dash7Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash7Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash7Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e3ad1eee-4f24-4b32-ad7c-234a08375a88"></a>
##Private Void Dash8Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash8Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash8Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="83b02f4d-88d1-432e-8129-72bd50a1f18e"></a>
##Private Void Dash9Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `Dash9Changed (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Dash9Changed method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="93263d95-4ca5-46e4-8964-776e676fea1b"></a>
##Private Void DashChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `DashChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DashChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="cba47685-6d7b-4f5c-985e-03fda59cdb0d"></a>
##Private Void DeleteColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `DeleteColor (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeleteColor method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="40569b76-9ea9-4cb3-a251-170356aa8db0"></a>
##Public Void DeleteColor (KimonoCore.KimonoColor)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DeleteColor (KimonoCore.KimonoColor)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the DeleteColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="9b50d174-630d-4a7a-a69e-9717d31f1acd"></a>
##Private Void DeleteGradient (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `DeleteGradient (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeleteGradient method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="9703e641-acc3-42d2-b913-e64fed1723d4"></a>
##Public Void DeleteGradient (KimonoCore.KimonoGradient)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DeleteGradient (KimonoCore.KimonoGradient)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the DeleteGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="566826d0-ed6c-40d8-99f8-1562da503753"></a>
##Private Void DeletePoint (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `DeletePoint (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeletePoint method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="41e44afd-cb4f-4c8e-b0a5-c6af6b8bff75"></a>
##Public Void DeleteSelectedShape (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DeleteSelectedShape (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeleteSelectedShape method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="cede4770-a452-45f8-8f9a-2d80e40d76fc"></a>
##Private Void DeleteShape (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `DeleteShape (Foundation.NSObject)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeleteShape method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="c51e59c1-47bb-432e-b135-1a57186f45f1"></a>
##Private Void DeleteSketch (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `DeleteSketch (Foundation.NSObject)` member of the `KimonoInspectorSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeleteSketch method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="15c2c031-86a0-452c-aabe-328c54a64734"></a>
##Private Void DeleteStyle (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `DeleteStyle (Foundation.NSObject)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeleteStyle method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="97087257-4ba8-4add-9468-54742299c554"></a>
##Public Void DeleteStyle (KimonoCore.KimonoStyle)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DeleteStyle (KimonoCore.KimonoStyle)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the DeleteStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="7937463d-2881-4ab1-a0ed-78b39746c562"></a>
##Private Void DepthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private `DepthChanged (Foundation.NSObject)` member of the `KimonoInspectorStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DepthChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a9effdea-6499-41a3-ab5a-550b235c7268"></a>
##Private Void DeviationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `DeviationChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeviationChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="6a780034-3c5c-4b32-8886-ef6443f13cef"></a>
##Private Void DeviationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `DeviationChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DeviationChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f17f45a4-513a-4b98-888f-3b6cbc27492c"></a>
##Public Virtual Void DidChangeText ()

###Member of Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The public virtual `DidChangeText ()` member of the `KimonoTextView` class.

---

<a name="51fa7000-a265-42b6-853d-13fd8360f83e"></a>
##Public Virtual Void DidFinishLaunching (Foundation.NSNotification)

###Member of Type

[AppDelegate](#85c5cfff-5452-46bd-a635-bc6028026976)

###Summary

The public virtual `DidFinishLaunching (Foundation.NSNotification)` member of the `AppDelegate` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p>The <code>notification</code> parameter of the DidFinishLaunching method takes a <code>Foundation.NSNotification</code> value. </p>
</td></tr></table></p>


---

<a name="3ae8f9b9-007a-4924-891b-8ed4dcc565bd"></a>
##Private Void DisplayCurrentColor ()

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `DisplayCurrentColor ()` member of the `KimonoInspectorPaleteColor` class.

---

<a name="d89f94db-eacc-4cf6-aab0-3c91a6b88ba4"></a>
##Private Void DuplicateColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `DuplicateColor (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicateColor method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a0a49416-b307-42f3-8ea9-83b18d8abfff"></a>
##Public Void DuplicateColor (KimonoCore.KimonoColor)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DuplicateColor (KimonoCore.KimonoColor)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the DuplicateColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="6d6aa38b-f954-41aa-af7e-7abce0f38808"></a>
##Private Void DuplicateGradient (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `DuplicateGradient (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicateGradient method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b91e45f8-19cb-4cb3-a985-fcb9f3181427"></a>
##Public Void DuplicateGradient (KimonoCore.KimonoGradient)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DuplicateGradient (KimonoCore.KimonoGradient)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the DuplicateGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="5a4a6591-8092-4c09-b278-6484261f3270"></a>
##Private Void DuplicatePoint (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `DuplicatePoint (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicatePoint method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b28bd26b-2261-4dd1-a5f2-fa733bc3028e"></a>
##Public Void DuplicateSelectedShape (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DuplicateSelectedShape (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicateSelectedShape method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="11798e99-13f0-40a0-bf99-ca900ab2bbe0"></a>
##Private Void DuplicateShape (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `DuplicateShape (Foundation.NSObject)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicateShape method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a1aaec07-612f-4fd2-be9d-573bfabbbd30"></a>
##Private Void DuplicateSketch (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `DuplicateSketch (Foundation.NSObject)` member of the `KimonoInspectorSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicateSketch method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="dee110cb-55c7-44e4-ba51-a5c0f13840bf"></a>
##Private Void DuplicateStyle (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `DuplicateStyle (Foundation.NSObject)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the DuplicateStyle method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="92278148-f308-40c5-b2ef-469cc7aee513"></a>
##Public Void DuplicateStyle (KimonoCore.KimonoStyle)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `DuplicateStyle (KimonoCore.KimonoStyle)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the DuplicateStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="6eaa6ce2-1cf8-4c4a-9aa4-30ba5ce50799"></a>
##Private Void EditOrFinalizeShape (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `EditOrFinalizeShape (Foundation.NSObject)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the EditOrFinalizeShape method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="3f72237a-9145-4bba-a273-aa972897b85e"></a>
##Private Void EditStyle (Foundation.NSObject)

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `EditStyle (Foundation.NSObject)` member of the `KimonoInspectorAttachedStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the EditStyle method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="89f35bad-4982-4ad5-84a1-bdef4e4366ab"></a>
##Private Void EndCapChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `EndCapChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the EndCapChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0adc62da-9b8a-46f6-8af2-eb568d6c61d1"></a>
##Private Void FillChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `FillChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the FillChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f9c84c66-5879-4974-96bf-dcc3d3931a77"></a>
##Private Void FillColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `FillColorChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the FillColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="6648015a-4f72-4613-8590-7a0e55a6d808"></a>
##Private Void FrameChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `FrameChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the FrameChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="05ebbbed-e9a9-406b-b1bf-e375bc189caf"></a>
##Private Void FrameColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `FrameColorChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the FrameColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="8a35e355-91b1-4cdc-a6e3-13e27e67b9e1"></a>
##Public Virtual GetCell (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Return Type

`AppKit.NSCell`

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public virtual `GetCell (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)` member of the `SourceListDelegate` class returns a `AppKit.NSCell` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the GetCell method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p>The <code>tableColumn</code> parameter of the GetCell method takes a <code>AppKit.NSTableColumn</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the GetCell method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="d15579d2-f4df-4310-bd5c-f2015b367067"></a>
##Public Virtual GetChild (AppKit.NSOutlineView, System.nint, Foundation.NSObject)

###Return Type

`Foundation.NSObject`

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The public virtual `GetChild (AppKit.NSOutlineView, System.nint, Foundation.NSObject)` member of the `SourceListDataSource` class returns a `Foundation.NSObject` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the GetChild method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>childIndex</td><td style='width:75%' class='def'><p>The <code>childIndex</code> parameter of the GetChild method takes a <code>System.nint</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the GetChild method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2d4fb08b-7dc6-49b0-ba4b-d79bce73c75a"></a>
##Public Virtual GetChildrenCount (AppKit.NSOutlineView, Foundation.NSObject)

###Return Type

`System.nint`

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The public virtual `GetChildrenCount (AppKit.NSOutlineView, Foundation.NSObject)` member of the `SourceListDataSource` class returns a `System.nint` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the GetChildrenCount method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p>The <code>item</code> parameter of the GetChildrenCount method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="7ae0c373-a49a-4968-8d42-3e1e6f56b313"></a>
##Public Virtual GetEnumerator ()

###Return Type

`System.Collections.IEnumerator`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public virtual `GetEnumerator ()` member of the `SourceListItem` class returns a `System.Collections.IEnumerator` value.

---

<a name="6f07efdc-847c-49d7-8b5a-5b3e9149c2c8"></a>
##Public Virtual GetObjectValue (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Return Type

`Foundation.NSObject`

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The public virtual `GetObjectValue (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)` member of the `SourceListDataSource` class returns a `Foundation.NSObject` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the GetObjectValue method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p>The <code>tableColumn</code> parameter of the GetObjectValue method takes a <code>AppKit.NSTableColumn</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the GetObjectValue method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="4756ec56-b349-4b35-b53b-dc5f2d12cfef"></a>
##Public Virtual GetView (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Return Type

`AppKit.NSView`

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public virtual `GetView (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)` member of the `SourceListDelegate` class returns a `AppKit.NSView` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the GetView method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p>The <code>tableColumn</code> parameter of the GetView method takes a <code>AppKit.NSTableColumn</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the GetView method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="71bf05ef-d331-45f0-9dc2-6e93a47d1980"></a>
##Private Void GoBack (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `GoBack (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GoBack method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="41035f45-1499-48f3-b7ec-5ebcbc9d34db"></a>
##Private Void GoBack (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `GoBack (Foundation.NSObject)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GoBack method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="6954e03b-993d-4476-bab9-8515b0260cb9"></a>
##Private Void GoBack (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `GoBack (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GoBack method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b09a5052-f986-4f9b-9f3f-40fd2b5c5a15"></a>
##Private Void GoBackToSketch (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `GoBackToSketch (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GoBackToSketch method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="fe8b9927-3203-41f2-8c0f-4fe910f738df"></a>
##Private Void GradientChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `GradientChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GradientChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ce7fd85f-bd66-45ef-932b-7a0c93a1bdf9"></a>
##Private Void GradientChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `GradientChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GradientChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e13fac0c-1b63-400f-bff4-5a7994ca37b1"></a>
##Public Void GroupUngroupSelectedShapes (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `GroupUngroupSelectedShapes (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GroupUngroupSelectedShapes method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f6847a4a-6a46-4564-a88c-cea6c8612efb"></a>
##Private Void GroupUngroupShapes (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `GroupUngroupShapes (Foundation.NSObject)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the GroupUngroupShapes method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="015fc021-5031-4645-b09b-16fb024c1f75"></a>
##Private Void HasCanvasColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `HasCanvasColorChanged (Foundation.NSObject)` member of the `KimonoInspectorSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the HasCanvasColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ead0d64b-1db1-47b1-a745-6277e847aa1d"></a>
##Private Void HeadChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `HeadChanged (Foundation.NSObject)` member of the `KimonoInspectorArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the HeadChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="7766d89a-83b8-4305-a1f1-3e6645a9bd32"></a>
##Private Void HighlightTool (KimonoCore.KimonoTool)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `HighlightTool (KimonoCore.KimonoTool)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p>The <code>tool</code> parameter of the HighlightTool method takes a <code>KimonoCore.KimonoTool</code> value. </p>
</td></tr></table></p>


---

<a name="3f0702a3-9085-4c9e-b6a9-1b4f6d8ffb1f"></a>
##Private Void HorizontalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `HorizontalBlurChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the HorizontalBlurChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="76a623ae-d883-4490-b505-a7fc6428b34a"></a>
##Private Void HorizontalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `HorizontalBlurChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the HorizontalBlurChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="11ed0e36-e40e-4fbb-9335-f5af77050160"></a>
##Private Void HueChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `HueChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the HueChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="716e202a-adcd-4e31-9d0d-eff26004174a"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `Initialize ()` member of the `KimonoInspectorStyle` class.

---

<a name="5120a60e-11bf-450c-9154-e738ae87585d"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public `Initialize ()` member of the `KimonoInspectorFrame` class.

---

<a name="d1fb6a83-dcd5-4011-bf7e-0ff4361934e8"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The public `Initialize ()` member of the `KimonoInspectorPolygon` class.

---

<a name="77a7318f-747c-48d9-8b19-494a64441222"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public `Initialize ()` member of the `KimonoInspectorFill` class.

---

<a name="55e2a9fa-3b7b-4fd9-a968-ca6d8555f3b2"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `Initialize ()` member of the `KimonoInspectorGradient` class.

---

<a name="14011427-2a4b-4ce8-bac8-62a93c24dfe0"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `Initialize ()` member of the `KimonoInspectorAttachedStyle` class.

---

<a name="0eb991ff-343a-4f44-b274-26c4e7a6984b"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The public `Initialize ()` member of the `KimonoInspectorArrow` class.

---

<a name="2466b190-5248-4e46-9348-368e288749fa"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The public `Initialize ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="e9722831-7f20-4f83-948b-691fdcd6512e"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `Initialize ()` member of the `KimonoInspectorFont` class.

---

<a name="769052d8-2971-4d37-a356-a858116f01a8"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The public `Initialize ()` member of the `KimonoInspectorText` class.

---

<a name="648e407f-c2a3-417c-b759-f0bc0ad59107"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `Initialize ()` member of the `KimonoInspectorPaleteColor` class.

---

<a name="fd70ace3-c4fb-4505-8fb4-f766b8f200e8"></a>
##Public Void Initialize ()

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public `Initialize ()` member of the `SourceListView` class.

---

<a name="4d18ce89-1c5e-4a5a-b55f-5c22c2335900"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The public `Initialize ()` member of the `KimonoInspectorSketch` class.

---

<a name="b09fcc5f-cbf9-40b3-a962-511535e50b12"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The public `Initialize ()` member of the `KimonoInspectorStar` class.

---

<a name="fbc53018-57a1-4d0a-84a3-7aca8d4669ed"></a>
##Private Void InitializeInspectors ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `InitializeInspectors ()` member of the `ViewController` class.

---

<a name="d12e6b5c-6c8b-4dc3-a93b-2343401fa263"></a>
##Private Void InnerChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `InnerChanged (Foundation.NSObject)` member of the `KimonoInspectorArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the InnerChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0fb473b7-edef-4291-a08a-f04e581c5ee2"></a>
##Public Void Insert (System.Int32, KimonoMac.SourceListItem)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `Insert (System.Int32, KimonoMac.SourceListItem)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p>The <code>n</code> parameter of the Insert method takes a <code>System.Int32</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p>The <code>item</code> parameter of the Insert method takes a <code>KimonoMac.SourceListItem</code> value. </p>
</td></tr></table></p>


---

<a name="17baa0b1-0090-43fc-81b7-c66d717a1d3c"></a>
##Public Virtual IsGroupItem (AppKit.NSOutlineView, Foundation.NSObject)

###Return Type

`System.Boolean`

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public virtual `IsGroupItem (AppKit.NSOutlineView, Foundation.NSObject)` member of the `SourceListDelegate` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the IsGroupItem method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p>The <code>item</code> parameter of the IsGroupItem method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="332dcd93-e6f6-4ecb-8787-00cb774be625"></a>
##Public Virtual ItemExpandable (AppKit.NSOutlineView, Foundation.NSObject)

###Return Type

`System.Boolean`

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The public virtual `ItemExpandable (AppKit.NSOutlineView, Foundation.NSObject)` member of the `SourceListDataSource` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the ItemExpandable method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p>The <code>item</code> parameter of the ItemExpandable method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="91564018-1b3d-4790-a74c-167b620a906d"></a>
##ItemForRow (System.Int32)

###Return Type

[KimonoMac.SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Member of Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The  `ItemForRow (System.Int32)` member of the `SourceListDataSource` class returns a `KimonoMac.SourceListItem` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>row</td><td style='width:75%' ><p>The <code>row</code> parameter of the ItemForRow method takes a <code>System.Int32</code> value. </p>
</td></tr></table></p>


---

<a name="1f1aac23-260f-42aa-a07e-a47d5ceee6de"></a>
##Private Void JitterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `JitterChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the JitterChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="8621ab32-823e-454a-a1d8-517df3c4293e"></a>
##Private Void JitterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `JitterChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the JitterChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f87e7635-40c9-4ed6-b801-1396d8511a2c"></a>
##Private Void JoinTypeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `JoinTypeChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the JoinTypeChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="feedc03b-34a0-488d-b895-a2f5253fd5fd"></a>
##Public Void KimonoInspectorArrow (System.IntPtr)

###Constructor for Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The public `KimonoInspectorArrow (System.IntPtr)` constructor for the `KimonoInspectorArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorArrow method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="11b5bddc-a8cc-45ba-9694-ca58127b8136"></a>
##Public Void KimonoInspectorAttachedStyle (System.IntPtr)

###Constructor for Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `KimonoInspectorAttachedStyle (System.IntPtr)` constructor for the `KimonoInspectorAttachedStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorAttachedStyle method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="41b51610-a48f-4b39-b598-b5f5e5e76fa1"></a>
##Public Void KimonoInspectorFill (System.IntPtr)

###Constructor for Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public `KimonoInspectorFill (System.IntPtr)` constructor for the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorFill method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="b3c9d1d7-bae1-4954-9263-0b96874d59f1"></a>
##Public Void KimonoInspectorFont (System.IntPtr)

###Constructor for Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `KimonoInspectorFont (System.IntPtr)` constructor for the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorFont method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="2f0d4693-0ded-453f-86fb-7560197e5871"></a>
##Public Void KimonoInspectorFrame (System.IntPtr)

###Constructor for Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public `KimonoInspectorFrame (System.IntPtr)` constructor for the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorFrame method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="e22b7786-4bb7-464a-96ac-9c96d7204433"></a>
##Public Void KimonoInspectorGeneralInfo (System.IntPtr)

###Constructor for Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The public `KimonoInspectorGeneralInfo (System.IntPtr)` constructor for the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorGeneralInfo method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="7b857853-a65d-480d-8293-e73b1486780f"></a>
##Public Void KimonoInspectorGradient (System.IntPtr)

###Constructor for Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `KimonoInspectorGradient (System.IntPtr)` constructor for the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorGradient method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="69bfa4dc-b428-4095-bc92-843848eba2aa"></a>
##Public Void KimonoInspectorPaleteColor (System.IntPtr)

###Constructor for Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `KimonoInspectorPaleteColor (System.IntPtr)` constructor for the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorPaleteColor method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="1f0a41ad-630a-404a-83c4-5d5cbd8e5d7b"></a>
##Public Void KimonoInspectorPolygon (System.IntPtr)

###Constructor for Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The public `KimonoInspectorPolygon (System.IntPtr)` constructor for the `KimonoInspectorPolygon` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorPolygon method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="85433aed-9251-441a-a5f9-d99c8abe7a3a"></a>
##Public Void KimonoInspectorSketch (System.IntPtr)

###Constructor for Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The public `KimonoInspectorSketch (System.IntPtr)` constructor for the `KimonoInspectorSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorSketch method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="7f89ad76-46f5-43bb-a3bb-6a77412105a3"></a>
##Public Void KimonoInspectorStar (System.IntPtr)

###Constructor for Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The public `KimonoInspectorStar (System.IntPtr)` constructor for the `KimonoInspectorStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorStar method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="8d98039c-550e-466c-bf71-19f65e70a024"></a>
##Public Void KimonoInspectorStyle (System.IntPtr)

###Constructor for Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `KimonoInspectorStyle (System.IntPtr)` constructor for the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorStyle method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="45d44a49-f9e9-4836-ae49-446aecdfb255"></a>
##Public Void KimonoInspectorText (System.IntPtr)

###Constructor for Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The public `KimonoInspectorText (System.IntPtr)` constructor for the `KimonoInspectorText` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoInspectorText method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="c055f316-23b3-48bc-84bb-e29533134b38"></a>
##Public Void KimonoTextView ()

###Constructor for Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The public `KimonoTextView ()` constructor for the `KimonoTextView` class.

---

<a name="c9310ff8-79c4-4bde-868e-853780bb0caf"></a>
##Public Void KimonoTextView (CoreGraphics.CGRect)

###Constructor for Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The public `KimonoTextView (CoreGraphics.CGRect)` constructor for the `KimonoTextView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p>The <code>frameRect</code> parameter of the KimonoTextView method takes a <code>CoreGraphics.CGRect</code> value. </p>
</td></tr></table></p>


---

<a name="8120c08c-b67a-44cb-8f66-9584f9d4b006"></a>
##Public Void KimonoTextView (Foundation.NSCoder)

###Constructor for Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The public `KimonoTextView (Foundation.NSCoder)` constructor for the `KimonoTextView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p>The <code>coder</code> parameter of the KimonoTextView method takes a <code>Foundation.NSCoder</code> value. </p>
</td></tr></table></p>


---

<a name="cc43b5d2-38e4-4784-a671-75b28b826ec7"></a>
##Public Void KimonoTextView (System.IntPtr)

###Constructor for Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The public `KimonoTextView (System.IntPtr)` constructor for the `KimonoTextView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the KimonoTextView method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="e36922ec-93fc-47f8-b1dd-24f96d3ed079"></a>
##Private Void LengthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `LengthChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the LengthChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="912b30e3-5aea-45a7-928e-aecd07cf2402"></a>
##Private Void LengthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `LengthChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the LengthChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="395eb0a2-de9a-46b7-a07f-49d22a8a2c88"></a>
##Private Void LinkedColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `LinkedColorChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the LinkedColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="d5ff76bd-6439-4488-abc9-cbec0b3e91c4"></a>
##Private Void LinkedColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `LinkedColorChanged (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the LinkedColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b82b09a0-3f34-49fe-8226-3baa293d0d23"></a>
##Private Void LinkedColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `LinkedColorChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the LinkedColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="40f7a2c8-0a80-4a28-b133-798d51439a99"></a>
##Private Static Void Main (System.String[])

###Member of Type

[MainClass](#9659011a-32e0-4e33-a1b3-022dcd95c073)

###Summary

The private static `Main (System.String[])` member of the `MainClass` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>args</td><td style='width:75%' ><p>The <code>args</code> parameter of the Main method takes a <code>System.String[]</code> value. </p>
</td></tr></table></p>


---

<a name="4599190c-3ef8-4157-bc11-e82524a1c7c6"></a>
##Public Void MainWindowController (System.IntPtr)

###Constructor for Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public `MainWindowController (System.IntPtr)` constructor for the `MainWindowController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the MainWindowController method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="46b840af-7134-44ae-9697-d8cf71b02bce"></a>
##Private Void MiterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `MiterChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the MiterChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="6f8a8bcc-54f5-46eb-a79e-b8a3bfe21cd6"></a>
##Public Void MoveBackwards (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `MoveBackwards (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the MoveBackwards method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ae0d2e14-2824-48d0-9bf1-7a76f2cc583c"></a>
##Public Void MoveForwards (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `MoveForwards (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the MoveForwards method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e8b8a755-fc00-4334-9cbc-044bed7d5f81"></a>
##Public Virtual MoveNext ()

###Return Type

`System.Boolean`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public virtual `MoveNext ()` member of the `SourceListItem` class returns a `System.Boolean` value.

---

<a name="eb213250-8567-4803-a285-2cc37e8b9ab6"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorSketch` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="439f45d2-295d-46eb-880e-091543f40a55"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorStar` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="e8d6bbeb-5fa1-46c3-a3de-e938706efb03"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorPaleteColor` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="9797f19c-8b87-496b-8e3c-a040a52a307b"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorGradient` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="5a41a6dd-9c8c-4c89-93f5-833c8591e775"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorAttachedStyle` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="ea137135-ea88-47c0-8d78-d40a1cba5de2"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorFill` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="35634afb-e1ca-4ad2-a722-84eb969c88d4"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorArrow` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="d47f57a4-1401-44a6-a6a7-10d048adf541"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorGeneralInfo` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="fe5005cd-da19-4ddc-b87a-490824aa5121"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorPolygon` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="fee0954c-1993-4d1f-adc3-c7ba77dcc07e"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorText` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="d4c9c591-814d-48f0-a59f-dc06fa813211"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorStyle` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="6a9e31ca-433c-4535-a500-4e7c84b64121"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorFrame` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="454ef24b-e41e-44bd-8938-98c2e77e7523"></a>
##Public MoveTo (System.nfloat)

###Return Type

`System.nfloat`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `MoveTo (System.nfloat)` member of the `KimonoInspectorFont` class returns a `System.nfloat` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p>The <code>y</code> parameter of the MoveTo method takes a <code>System.nfloat</code> value. </p>
</td></tr></table></p>


---

<a name="d587c39e-ab1a-4b16-8bb6-ff2b9d368bde"></a>
##Public Void MoveToBottom (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `MoveToBottom (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the MoveToBottom method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0c0c9859-fea4-4d3b-977d-248f3bd716a3"></a>
##Public Void MoveToTop (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `MoveToTop (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the MoveToTop method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="51278f0e-7212-42e1-abff-67bae981860d"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `OpacityChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the OpacityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="3415957a-4c98-4e98-9a50-86208ef9727c"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `OpacityChanged (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the OpacityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="7b571795-55f9-433f-8f66-67fb364770be"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `OpacityChanged (Foundation.NSObject)` member of the `KimonoInspectorSketch` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the OpacityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="56cbd23e-e688-4a43-8233-7c807d164193"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `OpacityChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the OpacityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="cf46ec25-d706-4cc3-a096-4bc3a2428d76"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `OpacityChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the OpacityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e962dc63-6920-4bc5-8e46-b899f543e033"></a>
##Private Void OuterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `OuterChanged (Foundation.NSObject)` member of the `KimonoInspectorArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the OuterChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a4f0cfa6-89dd-4614-947d-32a15af747bd"></a>
##Private Void PointColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `PointColorChanged (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the PointColorChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="32900929-2399-49d2-914c-deee3ae537ac"></a>
##Private Void PointsChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private `PointsChanged (Foundation.NSObject)` member of the `KimonoInspectorStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the PointsChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="836564b6-c542-4671-941b-3d8daff6f019"></a>
##Private Void RadiusChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `RadiusChanged (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the RadiusChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="fb046ae4-f103-4211-bfc4-742ab18380ad"></a>
##Void RaiseClickedEvent ()

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The  `RaiseClickedEvent ()` member of the `SourceListItem` class.

---

<a name="2714d098-1f9c-4859-aa26-59dd6bcab246"></a>
##Void RaiseColorModified (KimonoCore.KimonoColor)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The  `RaiseColorModified (KimonoCore.KimonoColor)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseColorModified method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="4677cf5e-e27b-4bad-be03-b474cf3ad31e"></a>
##Void RaiseConvertToStyle ()

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The  `RaiseConvertToStyle ()` member of the `KimonoInspectorAttachedStyle` class.

---

<a name="7e1276fa-599a-4de6-8c48-3120c4071058"></a>
##Void RaiseEditAttachedStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The  `RaiseEditAttachedStyle (KimonoCore.KimonoStyle)` member of the `KimonoInspectorAttachedStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseEditAttachedStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="5dd0f709-fb75-4a51-bb13-6911fd83f257"></a>
##Void RaiseGradientModified (KimonoCore.KimonoGradient)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The  `RaiseGradientModified (KimonoCore.KimonoGradient)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the RaiseGradientModified method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="4b28e1ab-7b0f-4c0b-9cab-4ca9767f1436"></a>
##Void RaiseItemSelected (KimonoMac.SourceListItem)

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The  `RaiseItemSelected (KimonoMac.SourceListItem)` member of the `SourceListView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the RaiseItemSelected method takes a <code>KimonoMac.SourceListItem</code> value. </p>
</td></tr></table></p>


---

<a name="9bae93c9-8689-4683-832a-9c25aa4f86dd"></a>
##Void RaiseMakeDuplicate ()

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The  `RaiseMakeDuplicate ()` member of the `KimonoInspectorSketch` class.

---

<a name="6c86939f-2501-4a0f-bf28-47409df72606"></a>
##Void RaiseMakeDuplicate ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The  `RaiseMakeDuplicate ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="42238f62-e041-40af-887f-02a6667f11c4"></a>
##Void RaiseMakeDuplicate (KimonoCore.KimonoColor)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The  `RaiseMakeDuplicate (KimonoCore.KimonoColor)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseMakeDuplicate method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="3b1a0aee-1aa2-4a25-9091-ed7077a25fb9"></a>
##Void RaiseMakeDuplicate (KimonoCore.KimonoGradient)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The  `RaiseMakeDuplicate (KimonoCore.KimonoGradient)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the RaiseMakeDuplicate method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="e5d0c9ee-d1bb-440d-bb09-376000f122dd"></a>
##Void RaiseMakeDuplicate (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The  `RaiseMakeDuplicate (KimonoCore.KimonoStyle)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseMakeDuplicate method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="aa3fa108-1e54-4063-b5c6-073bd9636d84"></a>
##Void RaiseMakeNewColor (SkiaSharp.SKColor)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The  `RaiseMakeNewColor (SkiaSharp.SKColor)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseMakeNewColor method takes a <code>SkiaSharp.SKColor</code> value. </p>
</td></tr></table></p>


---

<a name="f9293983-fcf0-42f3-9745-09088bd21500"></a>
##Void RaiseMakeNewColor (SkiaSharp.SKColor)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The  `RaiseMakeNewColor (SkiaSharp.SKColor)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseMakeNewColor method takes a <code>SkiaSharp.SKColor</code> value. </p>
</td></tr></table></p>


---

<a name="e092934e-abf7-4edd-98a1-037e24efe646"></a>
##Void RaiseRemoveColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The  `RaiseRemoveColor (KimonoCore.KimonoColor)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the RaiseRemoveColor method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="240d1d3c-0d52-48af-a574-f7599d641177"></a>
##Void RaiseRemoveGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The  `RaiseRemoveGradient (KimonoCore.KimonoGradient)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the RaiseRemoveGradient method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="4272a9d9-82c8-41b0-b9aa-e23cfa84c8ce"></a>
##Void RaiseRemoveShape ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The  `RaiseRemoveShape ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="76e1adee-9f1c-4dc1-ba89-10e681de80b4"></a>
##Void RaiseRemoveSketch ()

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The  `RaiseRemoveSketch ()` member of the `KimonoInspectorSketch` class.

---

<a name="8e1111d9-5896-4df2-8446-a7855d7e510c"></a>
##Void RaiseRemoveStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The  `RaiseRemoveStyle (KimonoCore.KimonoStyle)` member of the `KimonoInspectorAttachedStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseRemoveStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="7706dc21-0fc3-46a0-8e53-ba3633fbf1f5"></a>
##Void RaiseRemoveStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The  `RaiseRemoveStyle (KimonoCore.KimonoStyle)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseRemoveStyle method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="6fad22e0-54cf-4e93-994a-90f052eca1e2"></a>
##Void RaiseReturnToShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The  `RaiseReturnToShape (KimonoCore.KimonoShape)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RaiseReturnToShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="1f1215e2-e97f-4d1e-8fcc-0eb82f836da8"></a>
##Void RaiseReturnToShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The  `RaiseReturnToShape (KimonoCore.KimonoShape)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RaiseReturnToShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="f31fcca3-7b61-4ef9-8a05-36534592194e"></a>
##Void RaiseReturnToShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The  `RaiseReturnToShape (KimonoCore.KimonoShape)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RaiseReturnToShape method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="7fe3601d-70b2-4b94-899e-f16e69841d24"></a>
##Void RaiseSelectionChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The  `RaiseSelectionChanged (KimonoCore.KimonoShape)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p>The <code>selected</code> parameter of the RaiseSelectionChanged method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="5cadee3e-f886-4909-804c-f9f4fe33cc65"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="846193bf-1d07-4009-989c-a9818fbcd9dc"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorText` class.

---

<a name="c497619b-6628-4ef8-8f39-81f4cdbee289"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorFont` class.

---

<a name="6cf5e3d0-8c3b-49ff-972f-7ff721e7ae16"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorPolygon` class.

---

<a name="52cd4e29-9a72-4ec6-88a9-1bc0bd6a2320"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorStar` class.

---

<a name="d4ecf91b-dfd9-4f97-a345-cf13939d045a"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorArrow` class.

---

<a name="a0b31d0b-8540-4e5e-8cde-62df6bdc1b58"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorFrame` class.

---

<a name="864d461b-9843-4c99-a9b5-8745bb60d188"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorFill` class.

---

<a name="f3619f1b-d17d-4071-9983-dc0a85b90a47"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorGradient` class.

---

<a name="dbe1ce6f-82fa-42d4-aa4e-d7c98467588d"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The  `RaiseShapeModified ()` member of the `KimonoInspectorStyle` class.

---

<a name="20a6fa45-aec8-4fbe-8498-9e346064ca6b"></a>
##Void RaiseShapeModified (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The  `RaiseShapeModified (KimonoCore.KimonoShape)` member of the `KimonoInspectorAttachedStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the RaiseShapeModified method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="e754f581-1c73-4f62-843a-91971c20bb24"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The  `RaiseSketchModified ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="1508d627-4883-4f1c-bd14-3e9ccd392c0a"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The  `RaiseSketchModified ()` member of the `KimonoInspectorSketch` class.

---

<a name="231af3d5-36ea-4e43-af00-0101eedbde3f"></a>
##Void RaiseSketchModified (KimonoCore.KimonoSketch)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The  `RaiseSketchModified (KimonoCore.KimonoSketch)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the RaiseSketchModified method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="7ff1647f-76eb-435e-9a64-4cd226fe7093"></a>
##Void RaiseStyleModified ()

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The  `RaiseStyleModified ()` member of the `KimonoInspectorAttachedStyle` class.

---

<a name="70220db1-881d-4efe-9870-4d2742f3a183"></a>
##Void RaiseStyleModified ()

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The  `RaiseStyleModified ()` member of the `KimonoInspectorFont` class.

---

<a name="c64ac8a8-3668-4943-bd4e-d39cde27e22b"></a>
##Void RaiseStyleModified ()

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The  `RaiseStyleModified ()` member of the `KimonoInspectorStyle` class.

---

<a name="31f619f3-e639-473a-a398-c77c40734332"></a>
##Void RaiseStyleTypeChanged (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The  `RaiseStyleTypeChanged (KimonoCore.KimonoStyle)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the RaiseStyleTypeChanged method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="0482e1c3-9350-40eb-9033-ca2a4dc4545c"></a>
##Void RaiseTextChanged (System.String)

###Member of Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The  `RaiseTextChanged (System.String)` member of the `KimonoTextView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p>The <code>text</code> parameter of the RaiseTextChanged method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="4b379b39-bd12-49ed-84ad-1353830cc6fe"></a>
##Public Void Redo (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `Redo (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Redo method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="98591941-0fe3-480c-b20a-38bdf1b3164b"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorArrow` class.

---

<a name="356cdfd3-8bce-4c0f-b173-786a8831a957"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorFont` class.

---

<a name="c114c9bd-faef-4cca-aa94-c2da77ebeb3e"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorGradient` class.

---

<a name="cc7290f6-2d36-4ac0-b74b-dc7bc50e251b"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorText` class.

---

<a name="e260bd7c-7ff0-446f-afca-2ef4610241ef"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `ViewController` class.

---

<a name="b927e1e4-63c7-4645-b321-203925a13678"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorSketch` class.

---

<a name="f5e9f841-7786-4f5f-bb20-a0896bb10450"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorPaleteColor` class.

---

<a name="9d4baacc-03f5-4a27-ba8d-20262e4c3aec"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorFrame` class.

---

<a name="3dd45148-13ba-4d94-ad6f-be2d0c2a4dcb"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorAttachedStyle` class.

---

<a name="4eb28d93-6084-4be6-9891-8a913b1a2c26"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorStyle` class.

---

<a name="62f0fa2a-8a4f-4ccd-a082-6b7276d84403"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorFill` class.

---

<a name="f7c33296-0326-45ee-9583-f200e63cfba9"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `MainWindowController` class.

---

<a name="ded2329f-9d65-4be3-ae95-a3dd54c33486"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorStar` class.

---

<a name="685bbec7-d253-4885-ac90-8a8d32abbe40"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorPolygon` class.

---

<a name="08798a82-8e85-4842-8282-a8d9c623d119"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="4e46a876-3527-4ba8-97c3-5285443f87ca"></a>
##Public Void RemoveItem (KimonoMac.SourceListItem)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `RemoveItem (KimonoMac.SourceListItem)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the RemoveItem method takes a <code>KimonoMac.SourceListItem</code> value. </p>
</td></tr></table></p>


---

<a name="347d8a38-b006-4f2f-b7e3-8af0daa0549e"></a>
##Public Void RemoveItem (System.Int32)

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `RemoveItem (System.Int32)` member of the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p>The <code>n</code> parameter of the RemoveItem method takes a <code>System.Int32</code> value. </p>
</td></tr></table></p>


---

<a name="db69adc2-df57-4bbd-bcd0-fce1be2b6f47"></a>
##Public Virtual Void Reset ()

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public virtual `Reset ()` member of the `SourceListItem` class.

---

<a name="b4086c06-cb4b-46aa-944f-899a8a923e54"></a>
##Private Void RotationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `RotationChanged (Foundation.NSObject)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the RotationChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="742d0e8e-25fe-4095-876f-a65138a7c730"></a>
##Private Void SaturationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `SaturationChanged (Foundation.NSObject)` member of the `KimonoInspectorPaleteColor` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the SaturationChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a2ac416b-e920-4f17-b43e-65cd280e57ed"></a>
##Private Void ScaleChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `ScaleChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ScaleChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="a42d11e6-435c-4345-b163-b4d34b15f8ce"></a>
##Private Void ScrollInspectorsToTop ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ScrollInspectorsToTop ()` member of the `ViewController` class.

---

<a name="cfdc0851-730e-48f3-bec0-9a45fde3e5fa"></a>
##Private Void SelectFontFamily (System.String)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `SelectFontFamily (System.String)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>family</td><td style='width:75%' ><p>The <code>family</code> parameter of the SelectFontFamily method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="e30865da-a53d-4f47-a339-445172fa8a85"></a>
##Public Virtual Void SelectionDidChange (Foundation.NSNotification)

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public virtual `SelectionDidChange (Foundation.NSNotification)` member of the `SourceListDelegate` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p>The <code>notification</code> parameter of the SelectionDidChange method takes a <code>Foundation.NSNotification</code> value. </p>
</td></tr></table></p>


---

<a name="d8ea5cdd-dcdf-42d0-b6df-950fc5b2eaa9"></a>
##Private Void SetColorValues ()

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The private `SetColorValues ()` member of the `KimonoInspectorPaleteColor` class.

---

<a name="3d917ea0-a4c1-4ab6-93d4-9034898b4257"></a>
##Private Void SetDocumentSize ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `SetDocumentSize ()` member of the `ViewController` class.

---

<a name="1d957ecf-6e00-468f-98f0-f435e7830ad8"></a>
##Public Virtual ShouldEditTableColumn (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Return Type

`System.Boolean`

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public virtual `ShouldEditTableColumn (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)` member of the `SourceListDelegate` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the ShouldEditTableColumn method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p>The <code>tableColumn</code> parameter of the ShouldEditTableColumn method takes a <code>AppKit.NSTableColumn</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the ShouldEditTableColumn method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="5a2ab29e-4fa8-4a21-8204-0c34ac14c103"></a>
##Public Virtual ShouldSelectItem (AppKit.NSOutlineView, Foundation.NSObject)

###Return Type

`System.Boolean`

###Member of Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public virtual `ShouldSelectItem (AppKit.NSOutlineView, Foundation.NSObject)` member of the `SourceListDelegate` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p>The <code>outlineView</code> parameter of the ShouldSelectItem method takes a <code>AppKit.NSOutlineView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p>The <code>item</code> parameter of the ShouldSelectItem method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="12d90d09-0e5d-4073-89f2-5d2b15eae5d1"></a>
##Private Void ShowCurrentColor ()

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `ShowCurrentColor ()` member of the `KimonoInspectorFrame` class.

---

<a name="f5db5594-3961-47e7-b4e0-f39b46a088df"></a>
##Private Void ShowCurrentColor ()

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `ShowCurrentColor ()` member of the `KimonoInspectorGradient` class.

---

<a name="3c8a4343-8a8b-43e3-802f-b24a6b80837c"></a>
##Private Void ShowCurrentColor ()

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `ShowCurrentColor ()` member of the `KimonoInspectorFill` class.

---

<a name="5d5558a4-6586-4a57-8de2-1ae90cf0457b"></a>
##Private Void ShowDashEditor ()

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `ShowDashEditor ()` member of the `KimonoInspectorFrame` class.

---

<a name="93d6449e-0618-4517-81c5-ed3036504262"></a>
##Private Void ShowGeneralInspectors (KimonoCore.KimonoShape)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowGeneralInspectors (KimonoCore.KimonoShape)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p>The <code>shape</code> parameter of the ShowGeneralInspectors method takes a <code>KimonoCore.KimonoShape</code> value. </p>
</td></tr></table></p>


---

<a name="750c785b-776d-4a0a-8435-fb5ae7c2ca81"></a>
##Private Void ShowGradientInspectors (KimonoCore.KimonoGradient)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowGradientInspectors (KimonoCore.KimonoGradient)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p>The <code>gradient</code> parameter of the ShowGradientInspectors method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr></table></p>


---

<a name="edeac5eb-aeae-4e45-8499-deedd9bb4726"></a>
##Private Void ShowGroupShapes ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowGroupShapes ()` member of the `ViewController` class.

---

<a name="d94d3713-7b69-44e9-acef-b74d43477bb3"></a>
##Private Void ShowPaletteColorInspectors (KimonoCore.KimonoColor)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowPaletteColorInspectors (KimonoCore.KimonoColor)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p>The <code>color</code> parameter of the ShowPaletteColorInspectors method takes a <code>KimonoCore.KimonoColor</code> value. </p>
</td></tr></table></p>


---

<a name="4437ed05-d015-449e-bdfa-fca269e5b79e"></a>
##Private Void ShowSketchInspectors (KimonoCore.KimonoSketch)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowSketchInspectors (KimonoCore.KimonoSketch)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p>The <code>sketch</code> parameter of the ShowSketchInspectors method takes a <code>KimonoCore.KimonoSketch</code> value. </p>
</td></tr></table></p>


---

<a name="379ee846-c18b-46bf-a3f1-5ec196376178"></a>
##Private Void ShowSketchShapes ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowSketchShapes ()` member of the `ViewController` class.

---

<a name="0d394e5d-9f6d-42b2-ad35-43d922746659"></a>
##Private Void ShowStyleInspectors (KimonoCore.KimonoStyle)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ShowStyleInspectors (KimonoCore.KimonoStyle)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p>The <code>style</code> parameter of the ShowStyleInspectors method takes a <code>KimonoCore.KimonoStyle</code> value. </p>
</td></tr></table></p>


---

<a name="36f189f7-9b23-4c53-9474-2c4904d5fde7"></a>
##Private Void SidesChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The private `SidesChanged (Foundation.NSObject)` member of the `KimonoInspectorPolygon` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the SidesChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="fc1b4dd6-5566-4431-9e25-b69f63d68ed3"></a>
##Private Void SizeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `SizeChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the SizeChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ddfb04ec-8f31-434e-afa1-03923debe223"></a>
##Private Void SkewChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `SkewChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the SkewChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b97fcac3-afb7-41fe-be3c-798b86cdb5f2"></a>
##Private Void SkipChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The private `SkipChanged (Foundation.NSObject)` member of the `KimonoInspectorStar` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the SkipChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="9a0ebb4d-b214-4dba-9464-4f6b5f54ee03"></a>
##Public Void SourceListDataSource (KimonoMac.SourceListView)

###Constructor for Type

[SourceListDataSource](#b6363465-6e0a-4cff-a55f-b89a7306f4ec)

###Summary

The public `SourceListDataSource (KimonoMac.SourceListView)` constructor for the `SourceListDataSource` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controller</td><td style='width:75%' ><p>The <code>controller</code> parameter of the SourceListDataSource method takes a <code>KimonoMac.SourceListView</code> value. </p>
</td></tr></table></p>


---

<a name="94b5a600-f88d-499d-b5f1-1aacb8f60280"></a>
##Public Void SourceListDelegate (KimonoMac.SourceListView)

###Constructor for Type

[SourceListDelegate](#d8ba5633-ee96-4674-bbab-f97c6bf7fae4)

###Summary

The public `SourceListDelegate (KimonoMac.SourceListView)` constructor for the `SourceListDelegate` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controller</td><td style='width:75%' ><p>The <code>controller</code> parameter of the SourceListDelegate method takes a <code>KimonoMac.SourceListView</code> value. </p>
</td></tr></table></p>


---

<a name="41dc9a41-f4a7-45c7-aed4-95cd95679fcd"></a>
##Public Void SourceListItem ()

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem ()` constructor for the `SourceListItem` class.

---

<a name="e807a283-684b-4b36-b2e2-d4e6f883e45d"></a>
##Public Void SourceListItem (System.String)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="f243ecfc-293a-4b7f-9d83-3a1948dd87a0"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String, AppKit.NSImage)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the SourceListItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr></table></p>


---

<a name="a339692d-1c96-4dde-8f3a-d4cb43cac6fc"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the SourceListItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p>The <code>clicked</code> parameter of the SourceListItem method takes a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value. </p>
</td></tr></table></p>


---

<a name="09939415-c8d0-4a2f-89bd-ef7785e0fa9c"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage, System.String)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String, AppKit.NSImage, System.String)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the SourceListItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p>The <code>tag</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="cc25f829-fab8-43ff-939b-3a7d03b56c5b"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the SourceListItem method takes a <code>AppKit.NSImage</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p>The <code>tag</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' class='def'><p>The <code>clicked</code> parameter of the SourceListItem method takes a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value. </p>
</td></tr></table></p>


---

<a name="6ae050b3-2326-4e7c-b43a-047f6e772c3e"></a>
##Public Void SourceListItem (System.String, System.String)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String, System.String)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="2ca4a566-01cf-4bbb-be8a-c876480d8c78"></a>
##Public Void SourceListItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Constructor for Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The public `SourceListItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)` constructor for the `SourceListItem` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p>The <code>title</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p>The <code>icon</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p>The <code>clicked</code> parameter of the SourceListItem method takes a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value. </p>
</td></tr></table></p>


---

<a name="813abed2-d9ae-4936-b2da-e03bac736805"></a>
##Public Void SourceListView ()

###Constructor for Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public `SourceListView ()` constructor for the `SourceListView` class.

---

<a name="808c4dd3-d915-45f4-bce8-c4f66580b5e8"></a>
##Public Void SourceListView (Foundation.NSCoder)

###Constructor for Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public `SourceListView (Foundation.NSCoder)` constructor for the `SourceListView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p>The <code>coder</code> parameter of the SourceListView method takes a <code>Foundation.NSCoder</code> value. </p>
</td></tr></table></p>


---

<a name="d7b04482-5085-4767-a777-a5b0a9941df3"></a>
##Public Void SourceListView (Foundation.NSObjectFlag)

###Constructor for Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public `SourceListView (Foundation.NSObjectFlag)` constructor for the `SourceListView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>t</td><td style='width:75%' ><p>The <code>t</code> parameter of the SourceListView method takes a <code>Foundation.NSObjectFlag</code> value. </p>
</td></tr></table></p>


---

<a name="bd8ff6c9-087d-40f3-96f2-78390153d91d"></a>
##Public Void SourceListView (System.IntPtr)

###Constructor for Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The public `SourceListView (System.IntPtr)` constructor for the `SourceListView` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the SourceListView method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="44d41b41-9042-4d08-9771-b5293519af87"></a>
##Private Void StreamlinedChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `StreamlinedChanged (Foundation.NSObject)` member of the `KimonoInspectorArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the StreamlinedChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="fa423925-cd13-4363-bad6-9c881048ea70"></a>
##Private Void StrikeThruChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `StrikeThruChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the StrikeThruChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f1a45b81-c5d9-417d-9c1e-2524b2b9c373"></a>
##Private Void StyleChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The private `StyleChanged (Foundation.NSObject)` member of the `KimonoInspectorAttachedStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the StyleChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2191478e-1a96-494b-b867-daab20792fc1"></a>
##Private Void TailChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The private `TailChanged (Foundation.NSObject)` member of the `KimonoInspectorArrow` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the TailChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f7f9ae94-deda-43f5-ae65-8690415e6d56"></a>
##Private Void TileChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `TileChanged (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the TileChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="1b901426-7c7f-4283-93e1-b382d3c5e790"></a>
##Private Void ToolArrowSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolArrowSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolArrowSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="e2415974-9339-4298-943c-7d3e0ff0c7d1"></a>
##Private Void ToolBezierSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolBezierSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolBezierSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="d1869d28-9fd6-4b51-9a33-04589daeb635"></a>
##Private Void ToolCursorSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolCursorSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolCursorSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b242b9ae-d1f9-4f82-ae79-6a1bf8153cc0"></a>
##Private Void ToolLineSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolLineSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolLineSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="89c258ea-c93f-4619-994f-db54025336d7"></a>
##Private Void ToolOvalSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolOvalSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolOvalSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="05629d15-cc9e-4234-b78d-1cdd5ae96bdf"></a>
##Private Void ToolPolygonSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolPolygonSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolPolygonSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="bfaeb151-9ea1-4536-850a-67c37aef9a08"></a>
##Private Void ToolRectSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolRectSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolRectSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="9a6d5f93-a548-472f-9773-8e663cb71ea0"></a>
##Private Void ToolRoundRectSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolRoundRectSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolRoundRectSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="ab770c46-f9ef-46e8-9fb3-daff90e3a45d"></a>
##Private Void ToolStarSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolStarSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolStarSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="f03b149b-d1ed-4ca5-916d-8a01efecb18c"></a>
##Private Void ToolTextSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolTextSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolTextSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="b2b1fd8d-2e54-4e7f-97b4-72556065b0c0"></a>
##Private Void ToolTriangleSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolTriangleSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolTriangleSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="188c354a-fe83-4c71-8256-6829c4dc949d"></a>
##Private Void ToolVectorSelected (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `ToolVectorSelected (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the ToolVectorSelected method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="d84791c0-00e6-42c0-8ddd-176e2d70c230"></a>
##Private Void TypeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The private `TypeChanged (Foundation.NSObject)` member of the `KimonoInspectorGradient` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the TypeChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="bb0670ed-74d9-47d3-9d51-14effcbdd24c"></a>
##Private Void TypeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The private `TypeChanged (Foundation.NSObject)` member of the `KimonoInspectorStyle` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the TypeChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="97a8c814-5a79-42a3-8ad4-e0fb6400583d"></a>
##Private Void TypefaceChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `TypefaceChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the TypefaceChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="879a3f6f-26ac-47b8-9eb7-1a91022aca57"></a>
##Private Void UnderlineChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `UnderlineChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the UnderlineChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="681de9b5-31d7-43f3-b6ea-af6bcf523fac"></a>
##Public Void Undo (Foundation.NSObject)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `Undo (Foundation.NSObject)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the Undo method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="74d69163-ce26-4c7b-a067-dfd8b0f3578c"></a>
##Private Void UpdateColorList (System.Boolean)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdateColorList (System.Boolean)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p>The <code>refreshList</code> parameter of the UpdateColorList method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="79cc7d4b-3fce-4e55-aa0c-472b0ac591c9"></a>
##Private Void UpdateGradientList (System.Boolean)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdateGradientList (System.Boolean)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p>The <code>refreshList</code> parameter of the UpdateGradientList method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="c9447178-4c28-4fa3-96c7-16dd49ec5ef5"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="2745e845-a081-44cf-b28a-f7f747436ffe"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorFont` class.

---

<a name="d92dcd16-5a16-4cf5-9bd8-9f960ac9e853"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorFrame` class.

---

<a name="05313bc2-2908-40c4-8e30-c52366831c47"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorGradient` class.

---

<a name="9a9e37be-11a1-4574-b07e-755d2c6cd3e7"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorArrow` class.

---

<a name="75453952-f414-40d4-942b-cea2cf684d3b"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorAttachedStyle` class.

---

<a name="5c215568-c500-4a4e-a364-8081c28a2c65"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorPaleteColor` class.

---

<a name="6ad07805-8ca3-4d0c-be47-d0800c666512"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorPolygon` class.

---

<a name="8f41eba3-d868-4450-b513-b6ffe9a118bd"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorText` class.

---

<a name="f1f7d6a2-e381-4370-9d15-7894b4e85d48"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorStyle` class.

---

<a name="fd894f46-f0c8-4d1f-9501-c9e14ab4bf73"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorStar` class.

---

<a name="f333b337-e96c-4da1-b5bf-5ab74ba7b9dc"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorSketch` class.

---

<a name="3fb006cd-be77-4ffa-b7df-9997fbf4235a"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The public `UpdateInspector ()` member of the `KimonoInspectorFill` class.

---

<a name="630d3f47-99cb-48d6-9b0f-63e5fb4707f4"></a>
##Private Void UpdatePath ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdatePath ()` member of the `ViewController` class.

---

<a name="042805a8-70ea-4b78-ba70-87c4715e7c6a"></a>
##Private Void UpdateProjectList (System.Boolean)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdateProjectList (System.Boolean)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p>The <code>refreshList</code> parameter of the UpdateProjectList method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="dc1d2a1b-9176-4518-b3ba-c6e706fe1ee8"></a>
##Private Void UpdateShapesList (System.Boolean)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdateShapesList (System.Boolean)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p>The <code>refreshList</code> parameter of the UpdateShapesList method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="7b3213a5-4c08-4572-944a-0532438666db"></a>
##Private Void UpdateSketchesList (System.Boolean)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdateSketchesList (System.Boolean)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p>The <code>refreshList</code> parameter of the UpdateSketchesList method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="6867aafa-2489-4a03-b5f6-ab0f47dd46b8"></a>
##Private Void UpdateStyleList (System.Boolean)

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The private `UpdateStyleList (System.Boolean)` member of the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p>The <code>refreshList</code> parameter of the UpdateStyleList method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>


---

<a name="5cd47c06-fbe6-44a7-bbb7-32ba9396b79a"></a>
##Public Virtual Void Validate ()

###Member of Type

[ActivatableItem](#6b183c9a-bfbf-4b36-aba5-4113a11c9413)

###Summary

The public virtual `Validate ()` member of the `ActivatableItem` class.

---

<a name="0a7cc9cd-b61d-41f2-8d07-bc02b26f8bae"></a>
##Public ValidateMenuItem (AppKit.NSMenuItem)

###Return Type

`System.Boolean`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `ValidateMenuItem (AppKit.NSMenuItem)` member of the `ViewController` class returns a `System.Boolean` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p>The <code>item</code> parameter of the ValidateMenuItem method takes a <code>AppKit.NSMenuItem</code> value. </p>
</td></tr></table></p>


---

<a name="bc706412-9eac-4049-803c-4f947150a7d5"></a>
##Private Void VerticalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `VerticalBlurChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the VerticalBlurChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="0f17c626-bf44-40e0-8909-dc673492fead"></a>
##Private Void VerticalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The private `VerticalBlurChanged (Foundation.NSObject)` member of the `KimonoInspectorFill` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the VerticalBlurChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="68c859c4-11b6-4e2a-957d-b408e63aa32d"></a>
##Private Void VerticalChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `VerticalChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the VerticalChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2a10b9f3-a1fe-41c2-8c91-effed3d35f4b"></a>
##Public Void ViewController (System.IntPtr)

###Constructor for Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public `ViewController (System.IntPtr)` constructor for the `ViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p>The <code>handle</code> parameter of the ViewController method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="fd1a4560-6b6e-4e2a-abb5-c2205e6b0398"></a>
##Public Virtual Void ViewDidLoad ()

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The public virtual `ViewDidLoad ()` member of the `ViewController` class.

---

<a name="869b4f91-67b8-4b4c-8eb4-2147b1538226"></a>
##Private Void VisibilityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The private `VisibilityChanged (Foundation.NSObject)` member of the `KimonoInspectorGeneralInfo` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the VisibilityChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="fcbaf200-b137-45d9-b84a-d945b0721ed8"></a>
##Private Void WeightChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The private `WeightChanged (Foundation.NSObject)` member of the `KimonoInspectorFont` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the WeightChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="2194aa4e-c361-4ca4-8559-db7d56ce1a09"></a>
##Private Void WidthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The private `WidthChanged (Foundation.NSObject)` member of the `KimonoInspectorFrame` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p>The <code>sender</code> parameter of the WidthChanged method takes a <code>Foundation.NSObject</code> value. </p>
</td></tr></table></p>


---

<a name="7b3d4d22-870c-4e50-a488-93256c17bbba"></a>
##Public Virtual Void WillTerminate (Foundation.NSNotification)

###Member of Type

[AppDelegate](#85c5cfff-5452-46bd-a635-bc6028026976)

###Summary

The public virtual `WillTerminate (Foundation.NSNotification)` member of the `AppDelegate` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p>The <code>notification</code> parameter of the WillTerminate method takes a <code>Foundation.NSNotification</code> value. </p>
</td></tr></table></p>


---

<a name="1fff16b8-b302-4b95-9f73-f27e6fe285b6"></a>
##Public Virtual Void WindowDidLoad ()

###Member of Type

[MainWindowController](#35062bb9-5a44-4214-9296-32c4d5467add)

###Summary

The public virtual `WindowDidLoad ()` member of the `MainWindowController` class.
<a name="Events"></a>
#Events


---

<a name="55a6a106-659f-4751-b6c4-b5c278d672f9"></a>
##Clicked

###Return Type

`KimonoMac.SourceListItem.ClickedDelegate`

###Member of Type

[SourceListItem](#9c3b9a0f-036c-4cc4-9c60-b42b5e1379aa)

###Summary

The `Clicked` event of the `SourceListItem` class returns a `KimonoMac.SourceListItem.ClickedDelegate` value.

---

<a name="0ce08c7b-98f0-4609-965b-36dd7a476543"></a>
##ColorModified

###Return Type

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The `ColorModified` event of the `KimonoInspectorPaleteColor` class returns a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="65aced65-6fca-460a-bb69-ef4afb7d169d"></a>
##ConvertToStyle

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The `ConvertToStyle` event of the `KimonoInspectorAttachedStyle` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="b3382dab-82cd-4b1c-84cc-2fa774bd2361"></a>
##EditAttachedStyle

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The `EditAttachedStyle` event of the `KimonoInspectorAttachedStyle` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="744dd5e7-9e5e-48f0-b229-6bf3c18076b6"></a>
##GradientModified

###Return Type

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The `GradientModified` event of the `KimonoInspectorGradient` class returns a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="1f25b506-a7c1-41c3-a907-3481973a37d3"></a>
##ItemSelected

###Return Type

`KimonoMac.SourceListView.ItemSelectedDelegate`

###Member of Type

[SourceListView](#af72ceec-0ee0-4d13-add5-6380ca3fff2f)

###Summary

The `ItemSelected` event of the `SourceListView` class returns a `KimonoMac.SourceListView.ItemSelectedDelegate` value.

---

<a name="eefc7b73-2a7a-4622-bcf9-afe785b50a0c"></a>
##MakeDuplicate

###Return Type

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The `MakeDuplicate` event of the `KimonoInspectorGradient` class returns a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="39684c30-2da5-4c55-b312-a0cebd1433eb"></a>
##MakeDuplicate

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The `MakeDuplicate` event of the `KimonoInspectorStyle` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="5d9d5f0b-d866-4afc-93fa-6eec041d3d50"></a>
##MakeDuplicate

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The `MakeDuplicate` event of the `KimonoInspectorSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="84f1ff7c-ccf2-4e3b-b9c9-127646fcb844"></a>
##MakeDuplicate

###Return Type

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The `MakeDuplicate` event of the `KimonoInspectorPaleteColor` class returns a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="3551ae81-5eae-4faf-9360-6a7b8c20fab8"></a>
##MakeDuplicate

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The `MakeDuplicate` event of the `KimonoInspectorGeneralInfo` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="5df7b27e-5466-40ff-8bb0-148efac8cad0"></a>
##MakeNewColor

###Return Type

`KimonoCore.Kimono.SkiaColorEventDelegate`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The `MakeNewColor` event of the `KimonoInspectorFrame` class returns a `KimonoCore.Kimono.SkiaColorEventDelegate` value.

---

<a name="5a428823-ce86-4382-8b07-ff4af196583a"></a>
##MakeNewColor

###Return Type

`KimonoCore.Kimono.SkiaColorEventDelegate`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The `MakeNewColor` event of the `KimonoInspectorFill` class returns a `KimonoCore.Kimono.SkiaColorEventDelegate` value.

---

<a name="5db0cc62-db6c-46bc-9617-1197532c3ee3"></a>
##RemoveColor

###Return Type

`KimonoCore.Kimono.ColorEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The `RemoveColor` event of the `KimonoInspectorPaleteColor` class returns a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="04e141d2-bb3f-4fc1-919d-b15df892ed09"></a>
##RemoveGradient

###Return Type

`KimonoCore.Kimono.GradientEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The `RemoveGradient` event of the `KimonoInspectorGradient` class returns a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="2c9eaed2-6c4d-4725-b2e3-338a0ab42466"></a>
##RemoveShape

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The `RemoveShape` event of the `KimonoInspectorGeneralInfo` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="cc8f9693-bcde-42f2-b1e5-f836b59e730d"></a>
##RemoveSketch

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The `RemoveSketch` event of the `KimonoInspectorSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="69c5857d-3689-4598-a95e-997e356c86a5"></a>
##RemoveStyle

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The `RemoveStyle` event of the `KimonoInspectorAttachedStyle` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="1da9d6df-5b62-40bf-ae31-119605177a2f"></a>
##RemoveStyle

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The `RemoveStyle` event of the `KimonoInspectorStyle` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="f3bb376e-87d9-4127-ae14-b3b7704a7eba"></a>
##ReturnToShape

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The `ReturnToShape` event of the `KimonoInspectorStyle` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="5539355f-5803-47b0-a38c-fadb53c2a6dc"></a>
##ReturnToShape

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The `ReturnToShape` event of the `KimonoInspectorGradient` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="52b87f08-7238-40f1-a536-9b46074c22d1"></a>
##ReturnToShape

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorPaleteColor](#5b963c8f-344b-43de-a7a0-bc6c6f206d9d)

###Summary

The `ReturnToShape` event of the `KimonoInspectorPaleteColor` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="30575d99-1407-43de-bbf0-10eaeaffd3a2"></a>
##SelectionChanged

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The `SelectionChanged` event of the `KimonoInspectorGeneralInfo` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="04e2952e-7e0b-46c1-b64a-d2782ca41aa0"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The `ShapeModified` event of the `KimonoInspectorFont` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="6be25e11-6131-434a-83d1-3fa67386d047"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorText](#520dbfc1-d25b-4528-bb05-f6158e6171d2)

###Summary

The `ShapeModified` event of the `KimonoInspectorText` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="c794eff4-0e1f-4ab3-89e9-eb23f9f05951"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The `ShapeModified` event of the `KimonoInspectorGeneralInfo` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="86f16778-c8e4-4079-ba8a-b8e426d00193"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFrame](#df0cadf3-a029-444e-a899-d6857919e56f)

###Summary

The `ShapeModified` event of the `KimonoInspectorFrame` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="152e4aee-6544-40d6-9dc6-cea28a7462c3"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorPolygon](#f7fbdce9-839e-40fc-a6d1-72b34f837de0)

###Summary

The `ShapeModified` event of the `KimonoInspectorPolygon` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ce6d057a-7722-4a34-ba61-65cac3b049e7"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The `ShapeModified` event of the `KimonoInspectorStyle` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="56add2de-09c1-4757-86bb-6281fab95eb0"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorStar](#b64e1740-fcf6-4e2e-9154-2ef3efb5e43f)

###Summary

The `ShapeModified` event of the `KimonoInspectorStar` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="66eee82c-87d3-47d5-8d73-4e65ccb430c0"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGradient](#e50f6195-392c-42de-9b13-7433a22ed099)

###Summary

The `ShapeModified` event of the `KimonoInspectorGradient` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="26f4d650-a572-4934-988c-05ed5c4c9907"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFill](#5a3f4354-d1b2-4fb1-a0bd-4ca279c42022)

###Summary

The `ShapeModified` event of the `KimonoInspectorFill` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="d9929e95-406c-424d-b406-451d13ea49f4"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorArrow](#ec2d093d-ce8c-40d5-b0cc-1640e6614119)

###Summary

The `ShapeModified` event of the `KimonoInspectorArrow` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ad0c6d43-8015-448b-a7e4-9685c80b2658"></a>
##ShapeModified

###Return Type

`KimonoCore.Kimono.ShapeEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The `ShapeModified` event of the `KimonoInspectorAttachedStyle` class returns a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="0228cf20-4e2d-4b13-bdcd-d5c2ccd6f6ac"></a>
##SketchModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorGeneralInfo](#e36b0e08-8c34-452a-ae2f-60578ed14dcd)

###Summary

The `SketchModified` event of the `KimonoInspectorGeneralInfo` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="9b300758-6940-4930-bfa3-172925197e45"></a>
##SketchModified

###Return Type

`KimonoCore.Kimono.SketchEventDelegate`

###Member of Type

[ViewController](#15ff3f30-cef6-4db2-8e01-d27e95dbcdf8)

###Summary

The `SketchModified` event of the `ViewController` class returns a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="8a1d8f45-1320-4c0c-baa6-8f220dc17ed1"></a>
##SketchModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorSketch](#49df7770-93d5-42c4-9a0a-efeef5a8cf12)

###Summary

The `SketchModified` event of the `KimonoInspectorSketch` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="eb35d18c-69be-43e3-87ac-5c573328cd42"></a>
##StyleModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorFont](#a50ac7b7-6b94-4bc1-9316-853d036a6761)

###Summary

The `StyleModified` event of the `KimonoInspectorFont` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="12d27566-a8f8-4fdc-9d7c-e48e89793388"></a>
##StyleModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The `StyleModified` event of the `KimonoInspectorStyle` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="6cf158a9-1eed-4115-83b7-5ba21fade856"></a>
##StyleModified

###Return Type

`KimonoCore.Kimono.PortfolioEventDelegate`

###Member of Type

[KimonoInspectorAttachedStyle](#ff84e343-fa58-40cb-b6b6-106a85c91868)

###Summary

The `StyleModified` event of the `KimonoInspectorAttachedStyle` class returns a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="61886013-c3ef-4e68-a8d8-0bb88c0eb3f0"></a>
##StyleTypeChanged

###Return Type

`KimonoCore.Kimono.StyleEventDelegate`

###Member of Type

[KimonoInspectorStyle](#d966c642-1886-482d-a924-0dc9c962accb)

###Summary

The `StyleTypeChanged` event of the `KimonoInspectorStyle` class returns a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="6da06620-d657-4ab6-ac94-bc50176c39e3"></a>
##TextChanged

###Return Type

`KimonoMac.KimonoTextView.TextChangedDelegate`

###Member of Type

[KimonoTextView](#e8d0e288-9ba7-4ff1-8803-7bfd25c1e1bd)

###Summary

The `TextChanged` event of the `KimonoTextView` class returns a `KimonoMac.KimonoTextView.TextChangedDelegate` value.
