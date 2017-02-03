#Kimono Designer Mac API Documentation

####Version 01.00.00

##Table of Contents

* [Summary](#Summary)
* [Remarks](#Remarks)
* [Namespaces](#Namespaces)
* [Types](#Types)
* [Fields](#Fields)
* [Properties](#Properties)
* [Methods](#Methods)
* [Events](#Events)

<a name="Summary"></a>
##Summary

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can can be converted to code and included in any cross-platform language and OS that SkiaSharp supports.

<a name="Remarks"></a>
##Remarks

Kimono Designer, KimonoCore and KimonoCore.Mac were created by Kevin Mullins for Microsoft, Inc.

### License

**The MIT License (MIT)<br/>
Copyright (c) 2017 Microsoft, Inc.**

Permission is hereby granted, free of charge, to any person obtaining a 
copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation 
the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the 
Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included 
in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR 
OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
OTHER DEALINGS IN THE SOFTWARE.

<a name="Namespaces"></a>
#Namespaces


---

<a name="eb5d4371-bdff-4aa2-b712-8cda2c473520"></a>
##KimonoMac

###Summary

The main namespace for the MacOS version of the Kimono Designer Interface.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b6001a55-19e6-4020-9180-16fe091e8600'>ActivatableItem</a></td><td style='width:75%' ><p>A type of <code>NSToolbarItem</code> that the developer can enable/disable by adjusting the  <code>Active</code> property.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4a5fd3a-500e-4d49-a5be-aac2002d9a82'>AppDelegate</a></td><td style='width:75%' class='def'><p>App delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4dcbb271-b786-4581-94ef-25b12aaca68d'>CenteringClipView</a></td><td style='width:75%' ><p>Centering clip view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbd844de-247a-4e17-9ab5-e5cda997b4a0'>KimonoInspectorArrow</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb950e5f-f53b-47ee-a68f-7bcb0d06a262'>KimonoInspectorAttachedStyle</a></td><td style='width:75%' ><p>Displays the inspector for a <code>KimonoStyle</code> attached to a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27afbed2-1709-4abb-84f6-c68238b78cd4'>KimonoInspectorFill</a></td><td style='width:75%' class='def'><p>Handles the inspector view for the Fill properties of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6607c64-f369-46da-b148-c5162d80ca70'>KimonoInspectorFont</a></td><td style='width:75%' ><p>Handles the inspector view for the Font section of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d13d593-a78a-46f8-bd30-1f88ffbbc239'>KimonoInspectorFrame</a></td><td style='width:75%' class='def'><p>Handles the inspector view for the Frame section of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a11c2de0-ef79-4a59-ae37-0c8806453775'>KimonoInspectorGeneralInfo</a></td><td style='width:75%' ><p>Handles the general <code>KimonoShape</code> inspector view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5064eca-591d-4f74-bf35-da5f7fbdbb3b'>KimonoInspectorGradient</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a <code>KimonoGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89f7f09f-b964-460f-befa-9ffb6694b7ea'>KimonoInspectorGroup</a></td><td style='width:75%' ><p>Handles the inspector view for a given <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfdcb93f-6d98-4469-848e-4ed5b1fa6162'>KimonoInspectorPaleteColor</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a named <code>KimonoColor</code> that can be attached to other<code>KimonoShapes</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c3f18a9-b56a-4496-9b51-819aca1bd975'>KimonoInspectorPolygon</a></td><td style='width:75%' ><p>Handles the inspector view for the <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a76afe10-8f40-4938-8f3c-dd0362d71d1f'>KimonoInspectorRoundRect</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29b077d2-fa1f-4b59-b9c3-22ef34f57c59'>KimonoInspectorSketch</a></td><td style='width:75%' ><p>Handles the inspector view for a given <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#344b8c16-cdc9-4606-af9b-9b672d043928'>KimonoInspectorStar</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c'>KimonoInspectorStyle</a></td><td style='width:75%' ><p>Handles the inspector view for a given <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6667936-a83f-4ed0-b092-62db0b6cab71'>KimonoInspectorText</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a given <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da5fed64-0411-45d7-bec7-b60d9c3ca60a'>KimonoTextView</a></td><td style='width:75%' ><p>A type of <code>NSTextView</code> that provides a <code>TextChanged</code> event to monitor when the user adjust the text of the <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b3b76dc-f0d8-4cb3-afbe-ff8ac08ca432'>MainClass</a></td><td style='width:75%' class='def'><p>Main class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9881a15-c33c-4bf5-8606-4829f8293008'>MainWindowController</a></td><td style='width:75%' ><p>Handles the main window for the Kimono Designer app.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6838f10-2ca9-4324-90ca-7822754a9d0d'>SourceListDataSource</a></td><td style='width:75%' class='def'><p>Source list data source.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87ea1989-9a98-4fa5-bd46-da2e4a742528'>SourceListDelegate</a></td><td style='width:75%' ><p>Source list delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20b849ed-e963-46fd-ac47-3fdd0ee424fa'>SourceListItem</a></td><td style='width:75%' class='def'><p>Source list item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ba0f8fa-3462-4142-9024-c68716903b8f'>SourceListView</a></td><td style='width:75%' ><p>Source list view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc'>ViewController</a></td><td style='width:75%' class='def'><p>Handles the master view for the Kimono Designer.</p>
</td></tr></table></p>


---

<a name="11a4f065-81b1-4138-8e90-61d1bafcb9e4"></a>
##KimonoMac.KimonoTextView

###Summary

Provides a special type of `NSTextView` that includes a `TextChanged` event to monitor when the contents of the Text View has changed.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#34258cd9-f194-4032-90e7-90700902ba3d'>TextChangedDelegate</a></td><td style='width:75%' ><p>Text changed delegate.</p>
</td></tr></table></p>


---

<a name="1b5b42ef-47c3-4693-8ecf-e4323efed742"></a>
##KimonoMac.SourceListItem

###Summary

Contains a given item in a Source List.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7895a845-abf1-402c-a040-0a2bc4e4ac64'>ClickedDelegate</a></td><td style='width:75%' ><p>Clicked delegate.</p>
</td></tr></table></p>


---

<a name="beadeded-5081-43aa-bf9a-5df81248d624"></a>
##KimonoMac.SourceListView

###Summary

Provides set of helper classes making it easier to work with source lists in a Xamarin.Mac application.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9146e8cc-76d1-4777-bbdd-3912a5209854'>ItemSelectedDelegate</a></td><td style='width:75%' ><p>Item selected delegate.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="b6001a55-19e6-4020-9180-16fe091e8600"></a>
##Public Class ActivatableItem

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSToolbarItem`

###Summary

A type of `NSToolbarItem` that the developer can enable/disable by adjusting the  `Active` property.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b7280246-b977-439b-9511-5acc6ad23396'>Active</a></td><td style='width:75%' ><p>Gets or sets a value indicating whether this <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> is active.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c221ebf9-4d44-4f2f-9e20-990ff6197b2d'>ActivatableItem</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5567a0f-c68f-4704-9214-b53977b810c3'>ActivatableItem</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76f7c1fb-f6ea-45c8-aa53-fa21c1f30a91'>ActivatableItem</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a9b3f3a-bb52-4b46-a2c7-e4ebc2955d08'>ActivatableItem</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5ea2488-1fa2-47f7-ae57-0a4102fb105c'>Validate</a></td><td style='width:75%' ><p>Validate this instance.</p>
</td></tr></table></p>


---

<a name="b4a5fd3a-500e-4d49-a5be-aac2002d9a82"></a>
##Public Class AppDelegate

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSApplicationDelegate`

###Summary

App delegate.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bcce0027-ab09-4367-a5c3-b82d4b99d482'>AppDelegate</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#b4a5fd3a-500e-4d49-a5be-aac2002d9a82">AppDelegate</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8772dee3-f8bf-46db-abdd-603fa9733f10'>DidFinishLaunching</a></td><td style='width:75%' class='def'><p>Did finish launching.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80c20d54-37b6-4b81-bbfa-7c697c40eda0'>WillTerminate</a></td><td style='width:75%' ><p>Will terminate.</p>
</td></tr></table></p>


---

<a name="4dcbb271-b786-4581-94ef-25b12aaca68d"></a>
##Public Class CenteringClipView

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSClipView`

###Summary

Centering clip view.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c886de3f-186e-408f-b5db-150311f4dff0'>CenteringClipView</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#4dcbb271-b786-4581-94ef-25b12aaca68d">CenteringClipView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30825a5f-0b15-4dcb-b0b8-da15ee5a25a9'>CenteringClipView</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#4dcbb271-b786-4581-94ef-25b12aaca68d">CenteringClipView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2848da1-31b9-4c54-9ab3-2795b21bfc9e'>ConstrainBoundsRect</a></td><td style='width:75%' ><p>Constrains the bounds rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4dba180-9d42-4d6c-9b4c-2f956b8d33be'>ConvertContentInsetsToProposedBoundsSize</a></td><td style='width:75%' class='def'><p>Converts the size of the content insets to proposed bounds.</p>
</td></tr></table></p>

###Remarks

Adapted from this blog post:  http://phoenixtoews.net/blog/2016/3/25/centering-a-resizable-content-view-within-a-nsscrollview-with-swift-22-and-xcode-73

---

<a name="7895a845-abf1-402c-a040-0a2bc4e4ac64"></a>
##ClickedDelegate

###Namespace

[KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742)

###Summary

Clicked delegate.

---

<a name="9146e8cc-76d1-4777-bbdd-3912a5209854"></a>
##ItemSelectedDelegate

###Namespace

[KimonoMac.SourceListView](#beadeded-5081-43aa-bf9a-5df81248d624)

###Summary

Item selected delegate.

---

<a name="fbd844de-247a-4e17-9ab5-e5cda997b4a0"></a>
##Public Class KimonoInspectorArrow

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a `KimonoShapeArrow`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ab2f6b30-4a83-4b01-acd1-881fde96be1c'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#393f177d-9017-4abc-9b3c-61d03333167d'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorArrow</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3a7c8365-a956-44cb-a3c9-4c5367f3d54e'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e7e449c-49cc-4a66-84e6-5581ea345e2d'>HeadCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>HeadCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7628436f-98ed-41e2-bb74-1a4617dce35e'>InnerSlider</a></td><td style='width:75%' ><p>The private read only <code>InnerSlider</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93bef69c-28d6-4290-b58a-483fb58fcad8'>InnerValue</a></td><td style='width:75%' class='def'><p>The private read only <code>InnerValue</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7909b796-d8b2-4ecb-994d-f08af2484966'>OuterSlider</a></td><td style='width:75%' ><p>The private read only <code>OuterSlider</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df19f284-d80a-4def-b46a-a8ff938fcd19'>OuterValue</a></td><td style='width:75%' class='def'><p>The private read only <code>OuterValue</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8ad04e7-8c6e-4ef7-a10e-de14e8d0a83d'>SelectedShape</a></td><td style='width:75%' ><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ea283b7-9914-42bb-8262-0c354bd6838b'>StreamlinedCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>StreamlinedCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77f16d54-a28a-4bd2-a1e2-0ebb5f8cc673'>TailCheckbox</a></td><td style='width:75%' ><p>The private read only <code>TailCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5d3a4d36-06ca-410f-ab29-edf02030fc8c'>HeadChanged</a></td><td style='width:75%' ><p>Handles the has head value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1e027a0-272d-4300-a50c-43eeca9816c4'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c576d990-9445-44b1-b610-e9f2c9e31d98'>InnerChanged</a></td><td style='width:75%' ><p>Handles the inner value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41679892-5680-4898-85d4-c30cc76601b0'>KimonoInspectorArrow</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#fbd844de-247a-4e17-9ab5-e5cda997b4a0">KimonoInspectorArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0e55171-0180-4f89-82ff-9fb8ebe1bf78'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the give location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c72c563-d225-444a-997c-1957f132bfaa'>OuterChanged</a></td><td style='width:75%' class='def'><p>Handles the outer value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcf996f2-3839-47a6-88d9-fe45fdb922c4'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e31e5936-0b10-4485-bc91-7a1093893fdb'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c5bcde1-7ad3-4a6b-a860-f1e143f1dfb5'>StreamlinedChanged</a></td><td style='width:75%' ><p>Handles the streamline value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94a82a98-3a6c-4330-9292-22aa77ed5b34'>TailChanged</a></td><td style='width:75%' class='def'><p>Handles the has tail value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3356573-c5bd-4c0e-9ffb-a5b56ec11c51'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b644d2ec-fe09-40f8-8ad7-7681be6edd9e'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="eb950e5f-f53b-47ee-a68f-7bcb0d06a262"></a>
##Public Class KimonoInspectorAttachedStyle

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Displays the inspector for a `KimonoStyle` attached to a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#52fe96aa-3b61-4985-9a0b-3178d35ded6a'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38c03433-59c8-484e-a694-23e12175beb5'>_selectedStyle</a></td><td style='width:75%' class='def'><p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ac4dafd-6c98-47b2-affe-7f32afbcc550'>ConvertToStyle</a></td><td style='width:75%' ><p>The private <code>ConvertToStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#685b68df-f61a-4a69-ad63-fa79c6f46905'>EditAttachedStyle</a></td><td style='width:75%' class='def'><p>The private <code>EditAttachedStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41b44da8-9ccd-42a2-806a-f7a8c4ff4f15'>RemoveStyle</a></td><td style='width:75%' ><p>The private <code>RemoveStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce8725ca-f6e0-4ccc-ab86-fcc929e6493c'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eba0229-bf86-441c-a4d3-da268bed30eb'>StyleModified</a></td><td style='width:75%' ><p>The private <code>StyleModified</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5221982d-8379-45ba-92c0-c2e29c407a5d'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ecdd2f5-8c48-4e62-aeac-91951c2226f8'>EditButton</a></td><td style='width:75%' class='def'><p>The private read only <code>EditButton</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4634a080-3c65-4de2-8897-f92c717bf669'>Portfolio</a></td><td style='width:75%' ><p>Gets the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca2315ca-587a-4e14-a2cd-c6d84046994d'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8c61467-0691-40c1-90e1-94fa5945b0ea'>SelectedStyle</a></td><td style='width:75%' ><p>Gets or sets the selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab67efaa-95ef-407e-a124-67f7d4d2f2b4'>StyleSelector</a></td><td style='width:75%' class='def'><p>The private read only <code>StyleSelector</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e829ac2e-b4de-4023-bc38-af2bdf020e3c'>EditStyle</a></td><td style='width:75%' ><p>Calls the editor for the given style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90b5d8a7-f9b6-4ca5-a395-74f8f31e6339'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ce72cea-43f5-4e96-8451-7c8f85fbf818'>KimonoInspectorAttachedStyle</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#eb950e5f-f53b-47ee-a68f-7bcb0d06a262">KimonoInspectorAttachedStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af12c474-b69d-492f-828c-6457e7d6057a'>MoveTo</a></td><td style='width:75%' class='def'><p>Moves the inspector to the given location</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58906b73-602b-470c-aac1-de4408abf845'>RaiseConvertToStyle</a></td><td style='width:75%' ><p>Raises the convert to style event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47004845-c3fe-4830-8f7e-0bc145fffd63'>RaiseEditAttachedStyle</a></td><td style='width:75%' class='def'><p>Raises the edit attached style event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f27ce31c-39f3-4dcc-9a94-d695d880d5e1'>RaiseRemoveStyle</a></td><td style='width:75%' ><p>Raises the remove style event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed8480ac-bf5c-4bad-8cec-661dbca95408'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a6ae254-de2f-43f0-ab8a-49ec53af6ca1'>RaiseStyleModified</a></td><td style='width:75%' ><p>Raises the style modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5f8e242-76ea-43b2-8aed-db44774bc09a'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f1c1ffc-58d3-40a5-88f6-0440f4b94768'>StyleChanged</a></td><td style='width:75%' ><p>Hnadles the style changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9de1da6e-ca2b-487b-b143-7b881fe0ab80'>UpdateInspector</a></td><td style='width:75%' class='def'><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a0ff07ea-6091-4897-b8e0-50e50ad3a91c'>ConvertToStyle</a></td><td style='width:75%' ><p>Occurs when convert to style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1482993f-e4d3-4593-a7da-cce7a67d151e'>EditAttachedStyle</a></td><td style='width:75%' class='def'><p>Occurs when edit attached style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6d09678-7e11-422f-b6d3-e28327abaa4d'>RemoveStyle</a></td><td style='width:75%' ><p>Occurs when remove style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d2ec37e-143d-482e-98ad-b687388f8db9'>ShapeModified</a></td><td style='width:75%' class='def'><p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57b4dd85-d60c-419b-af79-9c0419842422'>StyleModified</a></td><td style='width:75%' ><p>Occurs when style modified.</p>
</td></tr></table></p>


---

<a name="27afbed2-1709-4abb-84f6-c68238b78cd4"></a>
##Public Class KimonoInspectorFill

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for the Fill properties of a `KimonoStyle`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8a1186be-50dc-422b-9a1f-1a7efb6ef994'>_selectedStyle</a></td><td style='width:75%' ><p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d3e25b5-8a2e-4bdb-8f17-560f72410c6f'>MakeNewColor</a></td><td style='width:75%' class='def'><p>The private <code>MakeNewColor</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#060cd192-e1b6-4a50-b445-42bfde86ccf3'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6a064e14-1ce2-4d3d-898c-4a21abb6f23c'>AddColorButton</a></td><td style='width:75%' ><p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d277869-5b5d-4147-980a-1c6fd5a86f5b'>AntialiaseCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AntialiaseCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9bdb770-1faf-4c0d-a0ad-7f7db3f329f3'>BlendMode</a></td><td style='width:75%' ><p>The private read only <code>BlendMode</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1bb4ca1-0b1a-4887-9631-ba64adcb3eb3'>BlurCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>BlurCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f43cb8ff-4982-4bb9-904c-0990910ba74f'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0c2f60a-6b65-45df-ae12-5366aa74c64d'>DeviationSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>DeviationSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c69ac80-281b-4645-8154-64b3d628cba3'>DeviationValue</a></td><td style='width:75%' ><p>The private read only <code>DeviationValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#518a1daf-771b-4279-a765-03f6cb6efe43'>FillCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>FillCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b31175e6-b44d-44d3-aa5d-17ecff793242'>FillColor</a></td><td style='width:75%' ><p>The private read only <code>FillColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bccb5845-67b2-48e0-9ea4-218450065429'>GradientDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>GradientDropdown</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6268770-ec7f-4424-a8c4-d06b5aaf3f46'>HorizontalBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c9fc52e-2965-4429-9eff-9655ca26b632'>HorizontalBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6367a91b-f07d-4c0a-b932-4fb09f8e67eb'>HorizontalShadowBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalShadowBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c3b31a8-0086-46e1-b183-ec533db38eab'>HorizontalShadowBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalShadowBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#143fe5da-1586-4a56-bf98-a518ffeeacee'>HorizontalShadowOffsetSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalShadowOffsetSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9ee0770-cf08-4fa7-9f20-0a89392993f1'>HorizontalShadowOffsetValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalShadowOffsetValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f779faf-ce07-4033-b560-0e8d0dc8d467'>JitterCheckbox</a></td><td style='width:75%' ><p>The private read only <code>JitterCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f27bb190-57f9-40fa-b0c1-e6e7fca42cb7'>LengthSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>LengthSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1760404-e66c-413c-913c-34b3b41f2475'>LengthValue</a></td><td style='width:75%' ><p>The private read only <code>LengthValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#699182ce-584f-4c8c-ac04-7f6a647c4f8a'>LinkedColorSelector</a></td><td style='width:75%' class='def'><p>The private read only <code>LinkedColorSelector</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#740252cf-c0fe-4c4d-97a8-fffaf2279fdb'>LinkedShadowColor</a></td><td style='width:75%' ><p>The private read only <code>LinkedShadowColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4820ab6-40b6-4514-a5aa-d022dd0e19bb'>OpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aea341c4-b3c4-4dff-bee5-288c33bf0013'>OpacityValue</a></td><td style='width:75%' ><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bedc1a62-27f0-4df7-84cf-f6f16a1756e4'>Portfolio</a></td><td style='width:75%' class='def'><p>Gets the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64e13514-9de7-40b8-be67-672e1811f8ba'>SelectedStyle</a></td><td style='width:75%' ><p>Gets or sets the selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95f00b46-c36c-4568-a5de-3d01739f4dba'>ShadowCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>ShadowCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#950449c6-2ed3-49f3-b6a7-791151821776'>ShadowColor</a></td><td style='width:75%' ><p>The private read only <code>ShadowColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6ea9c10-85fa-4f81-aed0-8aa913caadac'>ShadowOpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>ShadowOpacitySlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed2d4236-59dd-434e-b3b1-8358d07f3289'>ShadowOpacityValue</a></td><td style='width:75%' ><p>The private read only <code>ShadowOpacityValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f59b2e9c-e185-4da8-99f1-88ed0280d8eb'>VerticalBlurSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8798eae-6ed5-4c0f-a241-6dfa800b95e6'>VerticalBlurValue</a></td><td style='width:75%' ><p>The private read only <code>VerticalBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1688672-f35e-443d-8624-06db2a90e7ca'>VerticalShadowBlurSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalShadowBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ab7671c-71a1-4af0-8a53-907e1a82e81f'>VerticalShadowBlurValue</a></td><td style='width:75%' ><p>The private read only <code>VerticalShadowBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e258cf91-35b6-484b-86ae-5f9f0b8f40a6'>VerticalShadowOffsetSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalShadowOffsetSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c414a064-0e0a-431a-8957-11192d581cb7'>VerticalShadowOffsetValue</a></td><td style='width:75%' ><p>The private read only <code>VerticalShadowOffsetValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#55a1b7b4-3017-4221-84e0-ca9e0ce7afcc'>AddColor</a></td><td style='width:75%' ><p>Adds the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8693bb6-ba2d-4133-be10-acf2d8355e49'>AntialiaseChanged</a></td><td style='width:75%' class='def'><p>Handles the antialias value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94778152-77a0-4121-a38e-e0d7f14254f7'>BlendModeChanged</a></td><td style='width:75%' ><p>Handles the blend mode changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7b7ebb5-b8e2-4ad1-9855-6ebed3a1076b'>BlurChanged</a></td><td style='width:75%' class='def'><p>Handles the blur effect changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3542628b-49b1-49a9-ae3d-0baa788f7558'>DeviationChanged</a></td><td style='width:75%' ><p>Handles the jitter deviation changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dc9daff-5d6c-44b5-bb2a-facb68160758'>FillChanged</a></td><td style='width:75%' class='def'><p>Handles the fill changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb26109d-7ad7-4e4d-b74f-787a038cac0e'>FillColorChanged</a></td><td style='width:75%' ><p>Handles the fill color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34361e13-1804-45f6-ba28-c50ee0016675'>GradientChanged</a></td><td style='width:75%' class='def'><p>Handles the <code>KimonoGradient</code> changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6827a964-7c2c-4153-b012-7637d0edb8d0'>HorizontalBlurChanged</a></td><td style='width:75%' ><p>Handles the horizontal blur amount changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf2b11fa-e6aa-443d-aed1-dca9d8e0a566'>HorizontalShadowBlurChanged</a></td><td style='width:75%' class='def'><p>Handles the horizontal shadow blur changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53b48146-6d83-471e-9f19-a99e83e2751b'>HorizontalShadowOffsetChanged</a></td><td style='width:75%' ><p>Handles the horizontal shadow offset changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0732f40e-7ced-4503-a95e-4eba8d16d3e0'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d131bed-02e1-4741-8475-0ebd552f0396'>JitterChanged</a></td><td style='width:75%' ><p>Handles the jitter effect changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bf56ce0-df16-42a1-ab52-448e7d94ac63'>KimonoInspectorFill</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#27afbed2-1709-4abb-84f6-c68238b78cd4">KimonoInspectorFill</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#946f2d6c-ccdc-4cc7-81e1-ba45cfefdf99'>LengthChanged</a></td><td style='width:75%' ><p>Handles the jitter length changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#640df050-03dd-42be-8992-49fe9659a9bb'>LinkedColorChanged</a></td><td style='width:75%' class='def'><p>Handles the linked <code>KimonoColor</code> changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bd79141-81a7-490b-b2f2-ca104064ddb3'>LinkedShadowColorChanged</a></td><td style='width:75%' ><p>Handles the linked shadow color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e91fb4c-f25e-42fb-a605-314a21788332'>MoveTo</a></td><td style='width:75%' class='def'><p>Moves the inspector to the given location</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7483198f-4a37-4c7e-bd4b-01d54b2d4b39'>OpacityChanged</a></td><td style='width:75%' ><p>Handles the opacity value changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7a31d37-22d4-41b5-9212-1290e936d074'>RaiseMakeNewColor</a></td><td style='width:75%' class='def'><p>Raises the color of the make new event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2186761-407c-4086-8e1e-b05a9b863c22'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66cbdd1b-7d76-4109-b5cb-98313941e3cc'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73f7a7ed-5fed-4c1b-9055-19149c326050'>ShadowChanged</a></td><td style='width:75%' ><p>Handles the shadow changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b846a9e-3f3a-4780-b3c1-703bb4d72eae'>ShadowColorChanged</a></td><td style='width:75%' class='def'><p>Handles the shadow color chainging.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29a699ff-13ba-4649-8140-cb231dd311db'>ShadowOpacityChanged</a></td><td style='width:75%' ><p>Handles the shadow's opacity changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#518d1713-0e51-4a4d-96b4-14fcfab86f0e'>ShowCurrentColor</a></td><td style='width:75%' class='def'><p>Shows the values for the current color selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46ebe8ff-709d-49b3-aaec-dbb5124a056c'>ShowCurrentShadowColor</a></td><td style='width:75%' ><p>Shows the color of the current shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59932f78-6162-4965-ad27-9464bf07bce4'>UpdateInspector</a></td><td style='width:75%' class='def'><p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cc9c6dd-fb22-4209-9e91-21ceefb3b1b0'>VerticalBlurChanged</a></td><td style='width:75%' ><p>Handles the vertical blur amount changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4416e94-68e1-4b54-a6c3-1a936dfe64bc'>VerticalShadowBlurChanged</a></td><td style='width:75%' class='def'><p>Handles the vertical shadow blur changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df22ebe7-5fdd-473e-a52b-02ec981110e0'>VerticalShadowOffsetChanged</a></td><td style='width:75%' ><p>Handles the vertical shadow offset changing.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5c44579a-3cf6-48ed-a3a4-8e2f7fc055e6'>MakeNewColor</a></td><td style='width:75%' ><p>Occurs when make new color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd1b073c-a4ca-4c45-a8b2-27bdcf3683ea'>ShapeModified</a></td><td style='width:75%' class='def'><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="e6607c64-f369-46da-b148-c5162d80ca70"></a>
##Public Class KimonoInspectorFont

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for the Font section of a `KimonoStyle`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a0f3f0a4-2c76-48cf-bad9-4e65ca1d4871'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dfcd5ae-c3c2-40c1-a30b-9bd522c4f362'>_selectedStyle</a></td><td style='width:75%' class='def'><p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30a10410-d614-45bc-9cbd-15ea65a809dd'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c52738c0-5d90-444a-bf3c-ce5aa69d7984'>StyleModified</a></td><td style='width:75%' class='def'><p>The private <code>StyleModified</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4972d867-fcc4-46be-a270-debc2b62980e'>Alignment</a></td><td style='width:75%' ><p>The private read only <code>Alignment</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSegmentedControl</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33288ac0-0cfe-4779-a626-0ecbd16262e9'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1bd107ae-f932-4c99-b3f0-ad3c12ff4caf'>ScaleSlider</a></td><td style='width:75%' ><p>The private read only <code>ScaleSlider</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca5b3221-877a-4107-a04e-cf632f8e71c3'>ScaleValue</a></td><td style='width:75%' class='def'><p>The private read only <code>ScaleValue</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aabd16b5-ba6b-4ac4-8bce-ae70f23eb20d'>SelectedShape</a></td><td style='width:75%' ><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36654f89-2ca0-456c-b3d0-49601abc8fc6'>SelectedStyle</a></td><td style='width:75%' class='def'><p>Gets or sets the selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04c609f1-626d-45e2-9e9d-85603455a9fe'>Size</a></td><td style='width:75%' ><p>The private read only <code>Size</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSComboBox</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70eab1a8-5bfe-4522-8e6e-6bb39c1b3596'>SkewSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>SkewSlider</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3937ebb8-05dc-4f35-b7e0-b52470b6b391'>SkewValue</a></td><td style='width:75%' ><p>The private read only <code>SkewValue</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef9e3d74-937c-44fb-921e-2963611ec845'>StrikeThruCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>StrikeThruCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d333668f-0ab6-46e1-9523-4c14a32b2ee3'>TypefaceDropdown</a></td><td style='width:75%' ><p>The private read only <code>TypefaceDropdown</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e423217-37b7-48a7-af13-0245986ec377'>UnderlineCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>UnderlineCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a010ccf8-aac7-47bd-a53f-0c049b32e367'>VerticalCheckbox</a></td><td style='width:75%' ><p>The private read only <code>VerticalCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28d775e1-8f68-4866-b0f4-2508cd9c65f1'>WeightDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>WeightDropdown</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b14590d2-2399-4015-bcff-c8f1c4df6088'>AlignmentChanged</a></td><td style='width:75%' ><p>Handles the alignmen changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#264dbe06-4fe0-4e23-b88e-8688d36da078'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6766a08e-640a-4357-82a0-03c5b0dd7613'>KimonoInspectorFont</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#e6607c64-f369-46da-b148-c5162d80ca70">KimonoInspectorFont</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12bdafce-ce50-4e27-a013-0c6d262694be'>MoveTo</a></td><td style='width:75%' class='def'><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34223e08-8ff6-4617-897c-f7fe0bfc17e0'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e998bf2b-13a9-4b52-b5f4-083e211f1aa7'>RaiseStyleModified</a></td><td style='width:75%' class='def'><p>Raises the style modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d2185b4-e688-43dd-aba7-6f21a1db0317'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a04f128-81b9-4fc7-820e-8786d24a861d'>ScaleChanged</a></td><td style='width:75%' class='def'><p>Handles the scale changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43b1618f-ae29-4b63-9fd7-30967da7a1ad'>SelectFontFamily</a></td><td style='width:75%' ><p>Selects the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32667df8-d8fa-4ce7-9df1-4820440cd231'>SizeChanged</a></td><td style='width:75%' class='def'><p>Handles the size changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a29b7fa8-77db-4d40-878a-05bba1a18c96'>SkewChanged</a></td><td style='width:75%' ><p>Handles the skew changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21952e3b-27e2-4a30-a7cd-fe86a37b860b'>StrikeThruChanged</a></td><td style='width:75%' class='def'><p>Handles the strikethru changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c2c10a0-d0ce-4d04-99eb-f3726114adce'>TypefaceChanged</a></td><td style='width:75%' ><p>Handles the typeface changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b2f0343-36fd-4442-b604-36966583cea6'>UnderlineChanged</a></td><td style='width:75%' class='def'><p>Handles the underline changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10087e47-84d8-4f51-bd70-ce29e8e5a8d0'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46578c2e-226e-4a47-99c3-5d9c4267c5c9'>VerticalChanged</a></td><td style='width:75%' class='def'><p>Handles the vertical text changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#377a481e-37f9-4cb1-8c04-ccbb089474b6'>WeightChanged</a></td><td style='width:75%' ><p>Handles the font weight changing.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5947283b-9b0d-414e-83b1-6fa0d0cf86d8'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf197174-d0b4-4f3d-8b53-07f6e2e55e72'>StyleModified</a></td><td style='width:75%' class='def'><p>Occurs when style modified.</p>
</td></tr></table></p>


---

<a name="3d13d593-a78a-46f8-bd30-1f88ffbbc239"></a>
##Public Class KimonoInspectorFrame

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for the Frame section of a `KimonoStyle`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2bb7ecbe-e272-47df-a05c-c1a37e41dc67'>_selectedStyle</a></td><td style='width:75%' ><p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e239047-98bf-47f6-a38c-9b50af6cc12c'>MakeNewColor</a></td><td style='width:75%' class='def'><p>The private <code>MakeNewColor</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b65a5b5-8125-44d5-8cce-8c1c7fcc0517'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f91ffe79-a470-454a-9210-58aa6f4fbafe'>AddColorButton</a></td><td style='width:75%' ><p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebc4522d-b194-4a03-a191-1553f94f3ea9'>AntialiasCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AntialiasCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aa777c7-7fd6-485f-a1a0-7765e396e7cf'>BlendMode</a></td><td style='width:75%' ><p>The private read only <code>BlendMode</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41e5041d-3461-46ae-afb0-9ccadbf37e16'>BlurCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>BlurCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d9d21c5-7e4c-4535-b774-7f5908551774'>Dash1</a></td><td style='width:75%' ><p>The private read only <code>Dash1</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86e13a9e-a81f-4b79-8103-efaa5c27469f'>Dash10</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash10</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1aeda0f-7350-44e0-85a9-156442499bf1'>Dash11</a></td><td style='width:75%' ><p>The private read only <code>Dash11</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce243665-e6f4-4544-a2f2-d0dbfbd7d86d'>Dash12</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash12</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc3949f4-8448-4785-83c2-d4c873abc686'>Dash13</a></td><td style='width:75%' ><p>The private read only <code>Dash13</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b98a1d5e-98e2-41a5-9dbe-9082a53e81d1'>Dash14</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash14</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf1499d5-72f0-4df1-b4f9-b19eba93ae9b'>Dash15</a></td><td style='width:75%' ><p>The private read only <code>Dash15</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3680c059-7e79-4b93-a0ed-d26bef796ad2'>Dash16</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash16</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5bdc8ec-7f6f-4d08-968d-f53de4cff001'>Dash2</a></td><td style='width:75%' ><p>The private read only <code>Dash2</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b582009-850a-42ba-aaf6-693db85e4feb'>Dash3</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash3</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1e3afd2-619b-4027-bcfa-8565da28300b'>Dash4</a></td><td style='width:75%' ><p>The private read only <code>Dash4</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45a25d15-f3ad-4b5d-9192-73f26eea66ab'>Dash5</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash5</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#575c45de-b4d3-4eb5-a50e-ec5f66b59792'>Dash6</a></td><td style='width:75%' ><p>The private read only <code>Dash6</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5580f9b-6e11-4e17-bc96-6b6d0255faa6'>Dash7</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash7</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5009eb0-b3ea-4a67-ab6c-8bcfc450ee45'>Dash8</a></td><td style='width:75%' ><p>The private read only <code>Dash8</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0083b522-901e-4580-a508-ec1182cbb69c'>Dash9</a></td><td style='width:75%' class='def'><p>The private read only <code>Dash9</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#621ddb15-c4a2-4f2a-a29f-85570b6d4009'>DashCheckbox</a></td><td style='width:75%' ><p>The private read only <code>DashCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ed9bb51-287e-4130-9dc7-2431e83586cf'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21708bc2-c8aa-46fa-bd2a-d1d199c4f5f5'>DeviationSlider</a></td><td style='width:75%' ><p>The private read only <code>DeviationSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f034ca32-b93b-4e44-beae-047a8a371008'>DeviationValue</a></td><td style='width:75%' class='def'><p>The private read only <code>DeviationValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cac9490-1969-40c7-8053-ff650dbd3a9b'>EndCap</a></td><td style='width:75%' ><p>The private read only <code>EndCap</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f9ddd31-9e8e-4352-ab47-7271f1f99b46'>FrameCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>FrameCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6dc0bcd3-278b-48ce-a9db-12abcabec02a'>FrameColor</a></td><td style='width:75%' ><p>The private read only <code>FrameColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f61812bd-ebe5-45ea-849b-ee23fea782a1'>GradientDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>GradientDropdown</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d96b4037-d2e4-4c02-a7d4-7026f6206c5a'>HorizontalBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48682bd1-c028-4b82-9c99-e74ecfc0d407'>HorizontalBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f230ac8f-0df0-447e-bf4a-a20c057806a5'>HorizontalShadowBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalShadowBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7eb3712-7f70-4afc-a70e-15f01f15d70d'>HorizontalShadowBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalShadowBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc6dd59d-7a29-45a4-b38d-4559566831c8'>HorizontalShadowOffsetSlider</a></td><td style='width:75%' ><p>The private read only <code>HorizontalShadowOffsetSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b123d152-cb33-4eb5-a72a-5f77c831c720'>HorizontalShadowOffsetValue</a></td><td style='width:75%' class='def'><p>The private read only <code>HorizontalShadowOffsetValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58721db3-75c8-4c99-9da3-89e7225e538b'>JitterCheckbox</a></td><td style='width:75%' ><p>The private read only <code>JitterCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d26b12f-e072-4ebd-ab92-44a79ef527d2'>JoinType</a></td><td style='width:75%' class='def'><p>The private read only <code>JoinType</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d13f501b-1a5f-4485-9a4c-2c7f8fcb0ce4'>LengthSlider</a></td><td style='width:75%' ><p>The private read only <code>LengthSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#083f2015-d7b1-4f9b-be9b-34a660cf31a0'>LengthValue</a></td><td style='width:75%' class='def'><p>The private read only <code>LengthValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef241b11-187a-4e3a-9ec4-8a3fd4c279ea'>LinkedColorSelector</a></td><td style='width:75%' ><p>The private read only <code>LinkedColorSelector</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbf49a1d-5f4f-4dc6-92bc-611494f29402'>LinkedShadowColor</a></td><td style='width:75%' class='def'><p>The private read only <code>LinkedShadowColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5052b23a-51ae-4c8e-9c57-36545b9199b1'>MiterSlider</a></td><td style='width:75%' ><p>The private read only <code>MiterSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a6af29f-dc50-40c5-aefc-cf00e39346d8'>MiterValue</a></td><td style='width:75%' class='def'><p>The private read only <code>MiterValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4cfded7-a3b8-44fe-a18c-74f58162ccde'>OpacitySlider</a></td><td style='width:75%' ><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2f9a546-7a8a-4c4f-933c-9f199a769c28'>OpacityValue</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e87c40d-fb06-4d41-872d-ecee44194f52'>Portfolio</a></td><td style='width:75%' ><p>Gets the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d61578f-2019-42ec-b558-ba04140da24f'>SelectedStyle</a></td><td style='width:75%' class='def'><p>Gets or sets the selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#135372f7-2a0f-4833-b5fe-7c42423e6129'>ShadowCheckbox</a></td><td style='width:75%' ><p>The private read only <code>ShadowCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52904d35-e3a6-4657-a821-56a5987c6c60'>ShadowColor</a></td><td style='width:75%' class='def'><p>The private read only <code>ShadowColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18e304a0-9334-4047-a53e-caed8e4b25dd'>ShadowOpacitySlider</a></td><td style='width:75%' ><p>The private read only <code>ShadowOpacitySlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5f2b312-1177-4e19-a1f2-254fad4e043f'>ShadowOpacityValue</a></td><td style='width:75%' class='def'><p>The private read only <code>ShadowOpacityValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#229e9bb1-83b5-4b0b-8b39-8afdee6201a2'>VerticalBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>VerticalBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bc5f1e4-1c1d-4d21-a52b-266d7bd3dcc1'>VerticalBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7c3213a-ac34-4255-ba30-39d83ba3d7e7'>VerticalShadowBlurSlider</a></td><td style='width:75%' ><p>The private read only <code>VerticalShadowBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cf2d8e2-5211-4a11-9a64-a1c01bfc8d1c'>VerticalShadowBlurValue</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalShadowBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b92560d-87b4-4d8d-977c-7e09112819b6'>VerticalShadowOffsetSlider</a></td><td style='width:75%' ><p>The private read only <code>VerticalShadowOffsetSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9d490b2-aa1e-429c-85d0-1f4cd205103b'>VerticalShadowOffsetValue</a></td><td style='width:75%' class='def'><p>The private read only <code>VerticalShadowOffsetValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ba13164-d412-4acc-8e7e-b1b6c2646545'>WidthSlider</a></td><td style='width:75%' ><p>The private read only <code>WidthSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#431e0ecc-c373-40b1-a66a-eb2e6eda3c5c'>WidthValue</a></td><td style='width:75%' class='def'><p>The private read only <code>WidthValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#36533599-edbe-40f7-8bb9-42742ec44e5a'>AddColor</a></td><td style='width:75%' ><p>Adds the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb8af19c-3c20-4ae8-b696-5c57d58bc107'>AntialiasChanged</a></td><td style='width:75%' class='def'><p>Handles the antialias changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#902e13bb-a0b3-484c-9193-fd79235dbae3'>BlendModeChanged</a></td><td style='width:75%' ><p>Handles the blend mode changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cfc3172-8545-4b95-a156-2df309d56e7d'>BlurChanged</a></td><td style='width:75%' class='def'><p>Handles the blur effect changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d50d2b1-f864-4841-b57a-1eb26abedef6'>Dash10Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9e654c9-6e08-49c2-bd1b-2c25b14b7e57'>Dash11Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac9aff44-d5f9-4e90-a304-7c52954d2082'>Dash12Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#312bc019-6649-484a-a988-51de48ecd557'>Dash13Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3de8bdad-2240-45d0-a666-786fe6e2b0f6'>Dash14Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d13120b-f733-4085-8a1e-0ced1957e503'>Dash15Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#376f6232-80f2-48b8-aea5-38a1bbc0b316'>Dash16Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45a4ded9-e673-4a8e-a575-77ac8d5d56e6'>Dash1Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07325247-86f7-4e58-9741-b0f4f9206ab7'>Dash2Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6172e1a5-df1a-4fc6-a230-ba7a62d886ed'>Dash3Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#663c2d80-c8df-472f-a169-26ceb073a794'>Dash4Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30f68754-10b3-4a11-99db-8aa229cf5011'>Dash5Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f963d99-b561-4d6a-ba0f-ab6edc4d1fa5'>Dash6Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#448eb247-7b9b-4505-9fa0-973b375c61f2'>Dash7Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f636873f-7162-484d-a71d-3a115d094eb1'>Dash8Changed</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#348accc4-aed8-45f5-b8a7-0a3468146497'>Dash9Changed</a></td><td style='width:75%' class='def'><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#940ee816-5971-4c31-a5b0-111cf520d539'>DashChanged</a></td><td style='width:75%' ><p>Handles a dash point changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84b1aa1b-8b09-4805-8e31-b2fdf336f79f'>DeviationChanged</a></td><td style='width:75%' class='def'><p>Handles the jitter deviation changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9f2f75d-b95e-4199-a7ec-48184b5e04c5'>EndCapChanged</a></td><td style='width:75%' ><p>Handles the end cap chainging.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0846f28f-0258-4c58-a6ab-92c64295ee27'>FrameChanged</a></td><td style='width:75%' class='def'><p>Handles the frame changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e19e917-4081-4560-97e4-b80accecf1af'>FrameColorChanged</a></td><td style='width:75%' ><p>Handles the frame color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3537330b-bed0-428a-bcb4-faf3827cb863'>GradientChanged</a></td><td style='width:75%' class='def'><p>Handles the gradient changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b87c6560-02d2-437a-bb9b-871ed8637875'>HorizontalBlurChanged</a></td><td style='width:75%' ><p>Handles the horizontal blur amount changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4961338e-30ce-43b6-80f4-11aac9f1312e'>HorizontalShadowBlurChanged</a></td><td style='width:75%' class='def'><p>Handles the horizontal shadow blur changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#730428ea-0576-4179-9a07-562dfb017389'>HorizontalShadowOffsetChanged</a></td><td style='width:75%' ><p>Handles the horizontal shadow offset changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccbca707-39d7-4560-b303-70d1f1711d7c'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f592f3f-794a-4c89-b5ba-a1665b4cd947'>JitterChanged</a></td><td style='width:75%' ><p>Handles the jitter effect changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abf4e476-5a68-405d-8c46-c72d24ccb818'>JoinTypeChanged</a></td><td style='width:75%' class='def'><p>Handles the join type changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3aabd88-b004-4861-9823-39ff1c39742a'>KimonoInspectorFrame</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#3d13d593-a78a-46f8-bd30-1f88ffbbc239">KimonoInspectorFrame</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2106422-b54d-43a0-bc78-0d324305cb42'>LengthChanged</a></td><td style='width:75%' class='def'><p>Handles the jitter lenght changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#235ed9fa-4552-4587-8ba8-088f6522fcda'>LinkedColorChanged</a></td><td style='width:75%' ><p>Handles the linked color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cad3f518-9882-4833-ac16-4a8a8cc19ca1'>LinkedShadowColorChanged</a></td><td style='width:75%' class='def'><p>Handles the linked shadow color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51783589-80a4-4e92-8d72-d8e14467023b'>MiterChanged</a></td><td style='width:75%' ><p>Handles the Miter changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50aa2ca8-afb7-4d2b-88fb-7806a3b4c721'>MoveTo</a></td><td style='width:75%' class='def'><p>Moves the inspector to the give location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48edc711-8c09-4e60-b2a2-5a311b9cb7d1'>OpacityChanged</a></td><td style='width:75%' ><p>Handles the opacity changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60fe2c23-5a2b-45b2-b0fd-7d2c951ac580'>RaiseMakeNewColor</a></td><td style='width:75%' class='def'><p>Raises the color of the make new event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0a6f211-e908-4a49-a0bd-af8fc98010c3'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efc6b899-c3bf-446d-abc9-81274fd7955e'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47f12b81-253b-4746-a65b-e00181fe6883'>ShadowChanged</a></td><td style='width:75%' ><p>Handles the shadow changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3df7b56c-1166-48d0-bc68-0d9893cad488'>ShadowColorChanged</a></td><td style='width:75%' class='def'><p>Handles the shadow color chainging.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fde3be3c-a13d-410e-b929-1134b87a2e9d'>ShadowOpacityChanged</a></td><td style='width:75%' ><p>Handles the shadow's opacity changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9abbd4f-7c9d-44eb-808b-1082ac5aa5be'>ShowCurrentColor</a></td><td style='width:75%' class='def'><p>Shows the color of the current.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25861717-4381-4ab3-a480-e03bae50ae11'>ShowCurrentShadowColor</a></td><td style='width:75%' ><p>Shows the color of the current shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b345782b-247e-4cbe-872c-3dadcb94a227'>ShowDashEditor</a></td><td style='width:75%' class='def'><p>Shows the dash editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#caa56b91-692f-47e3-a695-f4310601d2bd'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6ef88b1-3d3c-4dd4-82f1-81463142c398'>VerticalBlurChanged</a></td><td style='width:75%' class='def'><p>Handles the vertical blur amount changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4b71b0c-8c57-4295-b71c-e0bf7742694e'>VerticalShadowBlurChanged</a></td><td style='width:75%' ><p>Handles the vertical shadow blur changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa0bb3e5-bca9-4d11-9241-8782f8c9748f'>VerticalShadowOffsetChanged</a></td><td style='width:75%' class='def'><p>Handles the vertical shadow offset changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e82358c5-7e7c-4ee9-9339-cffc370f2312'>WidthChanged</a></td><td style='width:75%' ><p>Handles the width changing.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7dc50b16-fecd-439f-8abe-963d7a50d60d'>MakeNewColor</a></td><td style='width:75%' ><p>Occurs when make new color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5de0b9b-01ed-4aeb-8209-a40b07980b7a'>ShapeModified</a></td><td style='width:75%' class='def'><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="a11c2de0-ef79-4a59-ae37-0c8806453775"></a>
##Public Class KimonoInspectorGeneralInfo

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the general `KimonoShape` inspector view.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ef2bf91e-18d0-4486-b03c-5acf7710a260'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c588836-6102-4bb4-b6f5-769562d3c49b'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#014eee28-fe81-4f6a-ac52-893bd0bc086a'>RemoveShape</a></td><td style='width:75%' ><p>The private <code>RemoveShape</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9195f982-35de-4241-a6db-1e42409bf4d3'>SelectionChanged</a></td><td style='width:75%' class='def'><p>The private <code>SelectionChanged</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#829dc66b-60ed-47d6-8539-0bc04e8211c0'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07723358-ccc9-454b-9559-95cbacc47cb0'>SketchModified</a></td><td style='width:75%' class='def'><p>The private <code>SketchModified</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f2ec1d53-4ee0-4610-93fe-92ad36f3d96e'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de54d0b0-1ef1-4844-adfe-494878e98e4e'>EditButton</a></td><td style='width:75%' class='def'><p>The private read only <code>EditButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ece068d5-62d5-42ef-b15a-b0716109862d'>GroupUngroupButton</a></td><td style='width:75%' ><p>The private read only <code>GroupUngroupButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65343cc5-204f-4308-90f5-7d9ec54f9018'>RotationSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>RotationSlider</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eeabe786-4dc7-4b15-8b32-d309dba22cbc'>RotationValue</a></td><td style='width:75%' ><p>The private read only <code>RotationValue</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e78c2923-5065-4beb-960a-21f134742748'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#add385ba-c5e1-476f-bb21-f51c409662d6'>ShapeHeight</a></td><td style='width:75%' ><p>The private read only <code>ShapeHeight</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fde4da1e-2d18-4fa8-8852-77d4c79873e5'>ShapeName</a></td><td style='width:75%' class='def'><p>The private read only <code>ShapeName</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23c038d3-b45e-435e-9b9b-697ceef2bfb8'>ShapeType</a></td><td style='width:75%' ><p>The private read only <code>ShapeType</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36c14aa4-e4d6-49ae-8f6e-b9fad5e90831'>ShapeWidth</a></td><td style='width:75%' class='def'><p>The private read only <code>ShapeWidth</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b2c06ab-5ab9-47ab-88da-293f4d17ab7e'>ShapeX</a></td><td style='width:75%' ><p>The private read only <code>ShapeX</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#975bafff-819e-43c9-992a-28912f94da2b'>ShapeY</a></td><td style='width:75%' class='def'><p>The private read only <code>ShapeY</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e617ed7-e560-4780-9e24-eb2ce4260d92'>VisibleButton</a></td><td style='width:75%' ><p>The private read only <code>VisibleButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4e8e921a-1efa-42da-a9a7-74340af13b3f'>DeleteShape</a></td><td style='width:75%' ><p>Handles the shape being deleted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed4e2f50-12d3-4d86-808b-88fb974caf19'>DuplicateShape</a></td><td style='width:75%' class='def'><p>Handles the shape being duplicated.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#859f466a-fa99-4da4-9bed-228fd04cb5f2'>EditOrFinalizeShape</a></td><td style='width:75%' ><p>Edits the or finalize and editable shape such as a <code>KimonoShapeGroup</code> or <code>KimonoShapeVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2893c216-f87e-49aa-acae-6c84adfd15d9'>GroupUngroupShapes</a></td><td style='width:75%' class='def'><p>Handles a collection of <code>KimonoShapes</code> being grouped and ungrouped.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ec720e7-3992-4b78-a005-0ce32d4dd8bd'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5306c7f8-bff5-4deb-bbf0-4468b472f950'>KimonoInspectorGeneralInfo</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#a11c2de0-ef79-4a59-ae37-0c8806453775">KimonoInspectorGeneralInfo</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fadbf45-cca5-44da-b48d-2f0a593bd8a4'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01c79d9d-e5bd-4e35-9d83-7baabe3be5bc'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2f01093-1676-4633-8f85-97daaa4913de'>RaiseRemoveShape</a></td><td style='width:75%' ><p>Raises the remove shape event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28becaf2-dc38-4031-bcd7-21852844cfbb'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p>Raises the selection changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cec311dc-6153-473d-84f6-9fc1dabf9b33'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae959ac4-7e0b-471d-82c8-ed0a4e309085'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d536f10-c1bd-414c-8aca-110035f99f0f'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e47c8538-fa36-4c11-9e4a-9445391a80e7'>RotationChanged</a></td><td style='width:75%' class='def'><p>Handles the rotation being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b792479d-fbed-4465-8499-e4d689b40831'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49b38202-cf4a-4b4b-b630-37e88b271ebb'>VisibilityChanged</a></td><td style='width:75%' class='def'><p>Handles the visibility changing.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5c87c8eb-3894-4527-9f29-2f1754c3936f'>MakeDuplicate</a></td><td style='width:75%' ><p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#249c726b-f2a6-416b-81fd-3c9506b6adc2'>RemoveShape</a></td><td style='width:75%' class='def'><p>Occurs when remove shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fd75de8-b6d9-4d3b-af6e-77f1ab7d6eac'>SelectionChanged</a></td><td style='width:75%' ><p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57a2bb32-97c0-4aa3-8363-d52a4515bc46'>ShapeModified</a></td><td style='width:75%' class='def'><p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bea68a2-450b-474a-bf0a-5ba3af35e566'>SketchModified</a></td><td style='width:75%' ><p>Occurs when sketch modified.</p>
</td></tr></table></p>


---

<a name="d5064eca-591d-4f74-bf35-da5f7fbdbb3b"></a>
##Public Class KimonoInspectorGradient

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a `KimonoGradient`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#46284a9a-dbb7-4d59-84bb-684bcad47742'>_selectedGradient</a></td><td style='width:75%' ><p>The selected gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2192a6ba-9c8e-4b4c-b527-60eb4338b126'>_selectedShape</a></td><td style='width:75%' class='def'><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75fffb72-3ee7-45fb-925b-f716b9eb9393'>GradientModified</a></td><td style='width:75%' ><p>The private <code>GradientModified</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d79eaa15-4685-4664-89ed-a58e642651a9'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#749e491c-8423-4df8-bdd2-fc7d45aa3a3c'>RemoveGradient</a></td><td style='width:75%' ><p>The private <code>RemoveGradient</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3387906-9ee6-48ae-aba9-0db0c253458b'>ReturnToShape</a></td><td style='width:75%' class='def'><p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#494fe256-b025-402d-8d4f-73186ac8406e'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1fcb9710-2d5c-412b-a3d9-0fc2d406c7b4'>AddColorButton</a></td><td style='width:75%' ><p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b340ef5d-8208-4800-a4c3-d1a3e18a6825'>AddPointButton</a></td><td style='width:75%' class='def'><p>The private read only <code>AddPointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90cbb551-2857-46a4-94a0-1eb0b0685428'>BackButton</a></td><td style='width:75%' ><p>The private read only <code>BackButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6571e8fb-ace7-4437-8736-3cd365e1ab77'>DeleteButton</a></td><td style='width:75%' class='def'><p>The private read only <code>DeleteButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#718ecde4-977e-458b-8311-989c48fdb911'>DeletePointButton</a></td><td style='width:75%' ><p>The private read only <code>DeletePointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2a78c24-ba36-4de0-a0e4-4b7101064b69'>DesignBar</a></td><td style='width:75%' class='def'><p>The private read only <code>DesignBar</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoGradientDesignBar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3f0aaf4-7862-493f-85ce-eac57236f184'>DesignPreview</a></td><td style='width:75%' ><p>The private read only <code>DesignPreview</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoGradientDesignPreview</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6289028f-c2b0-4e8a-bc3c-44360a4abf24'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54f4e868-2144-4a4f-a7f1-dddaee6091e0'>DuplicateButton</a></td><td style='width:75%' ><p>The private read only <code>DuplicateButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#751c9ca8-f05b-4a68-99d9-a6b77bdc157f'>DuplicatePointButton</a></td><td style='width:75%' class='def'><p>The private read only <code>DuplicatePointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#522734b3-a054-492e-a11a-5d3e968628bd'>GradientName</a></td><td style='width:75%' ><p>The private read only <code>GradientName</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e51bdef5-dbf1-4e3a-a15e-f20e53caf8da'>LinkedColorDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>LinkedColorDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93d5b223-8a71-43f7-ad22-1b417d6cadeb'>OpacitySlider</a></td><td style='width:75%' ><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2755692a-6483-4a2b-9c26-79fce5417bf9'>OpacityValue</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d78c094-488c-4cae-809d-0c45d4ab9c17'>PointColor</a></td><td style='width:75%' ><p>The private read only <code>PointColor</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23f3674b-d7e8-4971-9a78-724590d6f076'>Portfolio</a></td><td style='width:75%' class='def'><p>Gets the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ced2cd5-1659-400e-b6d7-d9e8884a697a'>RadiusSlider</a></td><td style='width:75%' ><p>The private read only <code>RadiusSlider</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96cd3eb4-daee-4219-a6e6-32df8a9aa871'>RadiusValue</a></td><td style='width:75%' class='def'><p>The private read only <code>RadiusValue</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2340f2b-6819-491e-8908-bab7262169bf'>SelectedColorTitle</a></td><td style='width:75%' ><p>The private read only <code>SelectedColorTitle</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#427ee58c-7851-4ea0-bfd6-d2083dd646ac'>SelectedGradient</a></td><td style='width:75%' class='def'><p>Gets or sets the selected gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69c4d8e0-a0f6-4bf4-8d9f-37f318fba79c'>SelectedShape</a></td><td style='width:75%' ><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a2e4849-99bc-48a2-a985-1119c3f1fd79'>TileDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>TileDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0ba6d05-afbf-47a3-bc67-6eda3f404789'>TypeDropdown</a></td><td style='width:75%' ><p>The private read only <code>TypeDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c1f558b9-c392-46c5-a648-649e1015f0ab'>AddColor</a></td><td style='width:75%' ><p>Adds the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c32a7d98-f587-4446-8abf-73731da73634'>AddPoint</a></td><td style='width:75%' class='def'><p>Adds the point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dbd5c19-c428-41ac-b42f-1d150e0dfa50'>DeleteGradient</a></td><td style='width:75%' ><p>Deletes the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9f51163-1686-4f3a-9e21-5e86ca7618a9'>DeletePoint</a></td><td style='width:75%' class='def'><p>Deletes the point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2012ba90-0490-4028-8cfa-5ea65c7d03d0'>DuplicateGradient</a></td><td style='width:75%' ><p>Duplicates the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#259a4b1e-6f72-4799-b292-14922eeb6ff4'>DuplicatePoint</a></td><td style='width:75%' class='def'><p>Duplicates the point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19b44bc3-a9b5-4d3f-a75e-e9af9512b54b'>GoBack</a></td><td style='width:75%' ><p>Sends the user back to the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7e2739d-dfb9-4ace-8cc2-c807783b18be'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c73d3339-779f-4ca3-a3a6-58bb0c548d33'>KimonoInspectorGradient</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#d5064eca-591d-4f74-bf35-da5f7fbdbb3b">KimonoInspectorGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13755d78-bde3-425a-b551-596f36f9d73a'>LinkedColorChanged</a></td><td style='width:75%' class='def'><p>Handles the linked color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a791af13-f53c-4d28-91e4-52bf7c808fbf'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8dd74a9-88b6-4dd6-8b43-08631ac74534'>OpacityChanged</a></td><td style='width:75%' class='def'><p>Handles the opacity changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f26cc320-7838-481e-bc8e-630acfcff56b'>PointColorChanged</a></td><td style='width:75%' ><p>Handles a point color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c6bd050-5b12-435e-93ec-fc6217ad47ff'>RadiusChanged</a></td><td style='width:75%' class='def'><p>Handles the radius changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#337c1f06-6908-41df-a345-97a2c6744f69'>RaiseGradientModified</a></td><td style='width:75%' ><p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcd84338-edf3-4d3a-ac0f-79dc96c870e8'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3102e9fb-6764-4cb9-ab4c-15123aa034ed'>RaiseRemoveGradient</a></td><td style='width:75%' ><p>Raises the remove gradient event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b2e7082-124c-42ba-a5be-cb7f52ab16eb'>RaiseReturnToShape</a></td><td style='width:75%' class='def'><p>Raises the return to shape event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14e4ae60-10aa-4e2d-847e-fe70a772a6c2'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#652eede7-41e0-48ae-9a31-7d13506e2a7b'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32b201e3-6b83-4397-96ec-eb9aac371b7b'>ShowCurrentColor</a></td><td style='width:75%' ><p>Shows current color values.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa4c53f3-27b3-4635-8707-ac7ec1226309'>TileChanged</a></td><td style='width:75%' class='def'><p>Handles the tile mode changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aebcd537-c1be-45b6-8181-75fa283fd4ce'>TypeChanged</a></td><td style='width:75%' ><p>Handles the gradient's type changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c24e72c-002b-4093-b3af-71b9f1bb5425'>UpdateInspector</a></td><td style='width:75%' class='def'><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cce4b870-fd18-4f70-9207-b272a10e430e'>GradientModified</a></td><td style='width:75%' ><p>Occurs when gradient modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#094a8955-f7ce-4a1e-8433-884f7a7414e9'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3159239-bf48-4341-a3ca-fc2e8f7c05b5'>RemoveGradient</a></td><td style='width:75%' ><p>Occurs when remove gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e16f479-0a81-452d-bad5-c6a38d404e0b'>ReturnToShape</a></td><td style='width:75%' class='def'><p>Occurs when return to shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b228f7ff-31cf-4605-a3bf-e462b6772c63'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="89f7f09f-b964-460f-befa-9ffb6694b7ea"></a>
##Public Class KimonoInspectorGroup

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a given `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6eccc142-a975-4438-918f-60492413470d'>_selectedGroup</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d671a73-d8c5-428e-aeea-fc9017603a86'>GroupModified</a></td><td style='width:75%' class='def'><p>The private <code>GroupModified</code> field of the <code>KimonoInspectorGroup</code> class holds a <code>KimonoCore.Kimono.GroupEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#762558d6-345f-47fd-b087-edafc64bca77'>BooleanCheckbox</a></td><td style='width:75%' ><p>The private read only <code>BooleanCheckbox</code> property of the <code>KimonoInspectorGroup</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc610313-82b2-4f32-8f42-064f2f9e0c8c'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a51f57e0-944c-47cc-a66a-245d11c1fee3'>MaskCheckbox</a></td><td style='width:75%' ><p>The private read only <code>MaskCheckbox</code> property of the <code>KimonoInspectorGroup</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d08838-bf19-4745-8aa7-7577eed411fc'>Operation</a></td><td style='width:75%' class='def'><p>The private read only <code>Operation</code> property of the <code>KimonoInspectorGroup</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42210762-382f-4ba2-a05e-b5831de790eb'>SelectedGroup</a></td><td style='width:75%' ><p>Gets or sets the selected group.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#35a7e370-6663-4d2a-8c7b-0058ce2f0ac8'>BooleanChanged</a></td><td style='width:75%' ><p>Handles the boolean operation being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd640416-5ca0-4e07-aecb-8e72c725deaf'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#390c0760-348b-4a79-bf92-038fbe874306'>KimonoInspectorGroup</a></td><td style='width:75%' ><p>The public <code>KimonoInspectorGroup (System.IntPtr)</code> constructor for the <code>KimonoInspectorGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33ee589c-f455-4b24-8b58-27912faa6541'>MaskChanged</a></td><td style='width:75%' class='def'><p>Handles the mask changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f349fdb-f93e-4aae-9369-ee93a98da6d6'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84fbdea3-9142-451c-8ebe-250d25438f61'>OperationChanged</a></td><td style='width:75%' class='def'><p>Handles the boolean operation changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2dbeb14-ed07-4d17-9836-ab95aa325467'>RaiseGroupModified</a></td><td style='width:75%' ><p>Raises the group modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6477545f-61fb-4cce-9e49-5733e5d70100'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b39cc18-5d2a-49c4-a839-d460a4689225'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#abe8414e-4eee-4807-9823-0b6d03170c48'>GroupModified</a></td><td style='width:75%' ><p>Occurs when group modified.</p>
</td></tr></table></p>


---

<a name="dfdcb93f-6d98-4469-848e-4ed5b1fa6162"></a>
##Public Class KimonoInspectorPaleteColor

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a named `KimonoColor` that can be attached to other`KimonoShapes`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d555f566-d260-4ca9-b91c-255000a0b9c8'>_selectedColor</a></td><td style='width:75%' ><p>The color of the selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ff98fd7-8274-4ef1-af29-af364e4201dc'>AvailableBaseColors</a></td><td style='width:75%' class='def'><p>The available base colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f2475ef-1671-4bd7-a922-fad2b2c68422'>ColorModified</a></td><td style='width:75%' ><p>The private <code>ColorModified</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22ec56c1-842b-430a-9f08-1281c6fd6899'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8af2ccc6-20be-4978-af29-26e05d0cf65e'>RemoveColor</a></td><td style='width:75%' ><p>The private <code>RemoveColor</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bbe80c5-435f-48ee-96a1-e0c2d98e3e96'>ReturnToShape</a></td><td style='width:75%' class='def'><p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cce07664-29f6-47ed-ab8f-8bb1dfc83dd6'>AdjustBrightnessCheckbox</a></td><td style='width:75%' ><p>The private read only <code>AdjustBrightnessCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30f0e440-1fb2-4ba8-ac72-ce881a21d298'>AdjustHueCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AdjustHueCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f20fc5d-6da3-4e3e-a9f0-b61cfcd732d4'>AdjustOpacityCheckbox</a></td><td style='width:75%' ><p>The private read only <code>AdjustOpacityCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#920b0f88-8397-457d-af9d-a1f13bef55d9'>AdjustSaturationCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>AdjustSaturationCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8950e181-038a-47ed-8b3c-eaaaed856b7d'>BaseColorSelector</a></td><td style='width:75%' ><p>The private read only <code>BaseColorSelector</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad21d3fb-be47-467b-a46e-65e0fce8b7a3'>BrightnessSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>BrightnessSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22d8e88d-9edd-4b68-963a-473903d06edd'>BrightnessValue</a></td><td style='width:75%' ><p>The private read only <code>BrightnessValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b4ca751-9599-4636-a1a8-8972b1c4662e'>Color</a></td><td style='width:75%' class='def'><p>The private read only <code>Color</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3b0509f-ab53-4e28-b28a-1f8f8fd12489'>ColorName</a></td><td style='width:75%' ><p>The private read only <code>ColorName</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d620f443-109b-4ade-a164-3c74e835244f'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6602baf7-5852-47b9-931e-65e9c60589ae'>GoBackButton</a></td><td style='width:75%' ><p>The private read only <code>GoBackButton</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6d29735-b60a-4ba3-ac00-0ab1caff0841'>HueSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>HueSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8ea57c5-2206-41a0-bf16-d889cb18f552'>HueValue</a></td><td style='width:75%' ><p>The private read only <code>HueValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e4d9e14-f649-4a0c-8ec6-9e6c0325b04e'>OpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d872b37-b446-421c-8a88-9e8275edfa2b'>OpacityValue</a></td><td style='width:75%' ><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05ac4f05-107a-4d74-a50b-7ef6a11c49f6'>Portfolio</a></td><td style='width:75%' class='def'><p>Gets the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9d37a50-ce58-431e-966b-a389099b36be'>SaturationSlider</a></td><td style='width:75%' ><p>The private read only <code>SaturationSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca3e7176-e8dd-40ff-9c03-0fa1e13e198b'>SaturationValue</a></td><td style='width:75%' class='def'><p>The private read only <code>SaturationValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19e96e79-f6fb-45c4-a1b5-58092ddf6dc1'>SelectedColor</a></td><td style='width:75%' ><p>Gets or sets the color of the selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49391691-1c53-4ea9-9016-ff652ee26cc1'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fb69ac06-ab5b-4699-8be5-ccf484628f2c'>AdjustBrightnessChanged</a></td><td style='width:75%' ><p>Adjusts the brightness changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80b68dfd-1c32-488f-bd9b-787dc09a6e94'>AdjustHueChanged</a></td><td style='width:75%' class='def'><p>Adjusts the hue changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fee2913-5640-4967-bca8-d700c2c79eac'>AdjustOpacityChanged</a></td><td style='width:75%' ><p>Adjusts the opacity changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92e5d963-0dfb-45f1-b63c-65f88f0cdd84'>AdjustSaturationChanged</a></td><td style='width:75%' class='def'><p>Adjusts the saturation changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3025a0b-3038-4fb3-b3f4-449320b26792'>BaseColorChanged</a></td><td style='width:75%' ><p>Handles the base color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4565ce52-408f-4978-bd58-a67266ad63e1'>BrightnessChanged</a></td><td style='width:75%' class='def'><p>Handles the brightness chanigng.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15bb806c-e8a9-4799-867a-ed5d37d35517'>ColorChanged</a></td><td style='width:75%' ><p>Handles the color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ad92054-a9b3-40fe-8e6f-4e102d2f4a3e'>ColorNameChanged</a></td><td style='width:75%' class='def'><p>Handles the color name changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35e9d812-d66d-426f-b601-4593e27dce6c'>DeleteColor</a></td><td style='width:75%' ><p>Deletes the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72eb8d95-6481-45ee-812e-e16e88fcf82b'>DisplayCurrentColor</a></td><td style='width:75%' class='def'><p>Displays the current color</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#683c3959-35e1-43a8-b708-a12dce5f8a6c'>DuplicateColor</a></td><td style='width:75%' ><p>Duplicates the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba639195-2421-4f39-b33e-f9c4eb46461d'>GoBack</a></td><td style='width:75%' class='def'><p>Returns the to the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc0b0554-18fd-4305-ba13-d8b7bce1b5aa'>HueChanged</a></td><td style='width:75%' ><p>Handles the hue changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2f65e3a-3f36-4ee1-8dd3-c6f920f40058'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7179eece-9d4d-451e-82f1-2b15db92eb37'>KimonoInspectorPaleteColor</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#dfdcb93f-6d98-4469-848e-4ed5b1fa6162">KimonoInspectorPaleteColor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e59b8643-6b6c-429a-951b-cd55e8eae50c'>MoveTo</a></td><td style='width:75%' class='def'><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcc1f044-4ba4-4eaf-9c49-7056b0242c5f'>OpacityChanged</a></td><td style='width:75%' ><p>Handles the opacity changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b66e5ec-fdbf-4d06-b34d-9ba88ebc7314'>RaiseColorModified</a></td><td style='width:75%' class='def'><p>Raises the color modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3013ba98-7a24-457d-aa9c-ae04d9e931d2'>RaiseMakeDuplicate</a></td><td style='width:75%' ><p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#894dfa83-5b0b-4986-b476-c00da144787d'>RaiseRemoveColor</a></td><td style='width:75%' class='def'><p>Raises the color of the remove event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7caf19f5-4372-436a-b95a-75e0421aef7b'>RaiseReturnToShape</a></td><td style='width:75%' ><p>Raises the return to shape event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5e41080-bbc3-422a-917d-172639266ae6'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b600b46-c091-4ce6-8ad7-68f74551c779'>SaturationChanged</a></td><td style='width:75%' ><p>Handles the saturation changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84881654-880d-4826-9196-7e9abea98c72'>SetColorValues</a></td><td style='width:75%' class='def'><p>Sets the color values.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fa4c739-4af8-41fa-9b18-f69aed3705ea'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f315eeb3-3789-4432-a458-44fc2e558c77'>ColorModified</a></td><td style='width:75%' ><p>Occurs when color modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a70d751-6bf9-4974-906f-3bc45b8ebee0'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d431820-b46d-497b-a864-8837728de3eb'>RemoveColor</a></td><td style='width:75%' ><p>Occurs when remove color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed54d6be-d06f-4c97-bf74-b5a68084c831'>ReturnToShape</a></td><td style='width:75%' class='def'><p>Occurs when return to shape.</p>
</td></tr></table></p>


---

<a name="9c3f18a9-b56a-4496-9b51-819aca1bd975"></a>
##Public Class KimonoInspectorPolygon

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for the `KimonoShapePolygon`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5191599c-7d52-405c-b6a4-61192c1bd28a'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ca27ea4-5339-4ec6-8c78-98ba70f46f85'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorPolygon</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#da9a059d-2466-463e-a6ef-7e973f8a6f2e'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74663f67-611c-4d46-908b-5aee5d0bb0bc'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21d025c9-2e7e-4c25-9337-4e207d99ddfa'>SidesSlider</a></td><td style='width:75%' ><p>The private read only <code>SidesSlider</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d2dc103-78c2-4dff-9433-1da06af4a464'>SidesValue</a></td><td style='width:75%' class='def'><p>The private read only <code>SidesValue</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#203d0615-323b-4cad-9487-5f51db1e3f61'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edb52bee-18e2-449c-a068-48d4792a3f1b'>KimonoInspectorPolygon</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#9c3f18a9-b56a-4496-9b51-819aca1bd975">KimonoInspectorPolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaf2399d-ccd3-4bdd-bf5f-70f606c4a64b'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bd113af-b921-4d1c-8db4-d8040a772e2a'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa876e70-95a8-4c51-90f8-8125f464ea25'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2735e1d3-401d-4e7b-bc7b-2778f1d9215a'>SidesChanged</a></td><td style='width:75%' class='def'><p>Handles the number of sides changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca672a76-73f4-41cb-95c3-5c8b9fa09542'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f43a6c61-c083-4358-a08f-a32b329526c7'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="a76afe10-8f40-4938-8f3c-dd0362d71d1f"></a>
##Public Class KimonoInspectorRoundRect

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a `KimonoShapeRoundRect`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4036363d-933f-48cb-b999-4b9d3a24d5af'>_selectedRoundRect</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae79ad7c-cda7-4b0c-9b67-c92cc163f858'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorRoundRect</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e1915c15-8f7b-4d8e-9a02-4813f73744c7'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#840d886b-3758-4571-a50f-3ff0ddd1c49b'>RadiusSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>RadiusSlider</code> property of the <code>KimonoInspectorRoundRect</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9fd6f92-c0e8-446c-8f99-efa14bb42702'>RadiusValue</a></td><td style='width:75%' ><p>The private read only <code>RadiusValue</code> property of the <code>KimonoInspectorRoundRect</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#401bb4cd-99db-46fb-b423-08c049c45e99'>SelectedRoundRect</a></td><td style='width:75%' class='def'><p>Gets or sets the selected round rectangle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#335ae8ee-7ba7-4b25-be59-a68b136e7bef'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df6ba86f-3a91-431d-8ff7-0fbea95b48bc'>KimonoInspectorRoundRect</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#a76afe10-8f40-4938-8f3c-dd0362d71d1f">KimonoInspectorRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5019fd7f-a2ed-4920-a3fa-9633d9120c54'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2706d61-bdc5-4697-a1db-3ad003c04fc3'>RadiusChanged</a></td><td style='width:75%' class='def'><p>Handles the radius changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72f6c55f-94b1-4dae-8b4d-c5d1ea877c69'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#971c5928-ad47-4e31-886e-b9396ac98d57'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2680716-45c8-4d7f-8ee2-2d9041acb64e'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3d297f4b-0384-4adf-8460-a368fde7ff11'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="29b077d2-fa1f-4b59-b9c3-22ef34f57c59"></a>
##Public Class KimonoInspectorSketch

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a given `KimonoSketch`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b69d3276-4693-4d8f-82de-b96270c8494a'>_selectedSketch</a></td><td style='width:75%' ><p>The selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e74cd337-f174-444e-b0c2-f1a38066fecd'>MakeDuplicate</a></td><td style='width:75%' class='def'><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#744e7594-4fb9-41e5-9c66-75d72e127dca'>RemoveSketch</a></td><td style='width:75%' ><p>The private <code>RemoveSketch</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d1ed4ad-ca86-4b8d-8995-d15b4aa9ed67'>SketchModified</a></td><td style='width:75%' class='def'><p>The private <code>SketchModified</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c50dc14f-1e8e-499b-ae3d-4909992711be'>CanvasColor</a></td><td style='width:75%' ><p>The private read only <code>CanvasColor</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e9d6b14-e968-4e0e-ae21-be215eb00d3c'>CanvasColorCheckbox</a></td><td style='width:75%' class='def'><p>The private read only <code>CanvasColorCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1f4b714-723d-425b-bd1b-89d1aeaeafe6'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c25ac713-4e73-4ddc-80e5-8072f8d11389'>OpacitySlider</a></td><td style='width:75%' class='def'><p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3b8df95-4349-49da-90fa-5543d1e3e991'>OpacityValue</a></td><td style='width:75%' ><p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d43b995a-1253-4156-a8bd-7fd1da061ff6'>SelectedSketch</a></td><td style='width:75%' class='def'><p>Gets or sets the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#483fe7a1-5ffa-4ea4-b0f1-d2865440256a'>SketchHeight</a></td><td style='width:75%' ><p>The private read only <code>SketchHeight</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12e4691d-f44a-4dd0-859e-de5469846ffa'>SketchName</a></td><td style='width:75%' class='def'><p>The private read only <code>SketchName</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19cc2ece-2b82-402f-b9f3-7d0601ec71b7'>SketchWidth</a></td><td style='width:75%' ><p>The private read only <code>SketchWidth</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#33af043f-b8b5-4b44-ae85-4185c1335e95'>CanvasColorChanged</a></td><td style='width:75%' ><p>Handles the canvas color changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ca2ca72-09f4-4903-8fbb-383e59462edf'>DeleteSketch</a></td><td style='width:75%' class='def'><p>Deletes the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de459dfc-e6f9-46d1-a1bf-18d1ae3990a1'>DuplicateSketch</a></td><td style='width:75%' ><p>Duplicates the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3f4f2b7-62cb-4cb1-b517-a5383233a286'>HasCanvasColorChanged</a></td><td style='width:75%' class='def'><p>Does the canvas include a colored background?</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae938876-4fb3-4ff0-8b9c-21a0d53f4cc6'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a644f44e-6486-4dd6-9db6-a4d2adf373b2'>KimonoInspectorSketch</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#29b077d2-fa1f-4b59-b9c3-22ef34f57c59">KimonoInspectorSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf5426af-ef28-4adc-93d3-ec00d276498b'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ac9bb3c-13a0-4d4f-b723-64c08c2eb066'>OpacityChanged</a></td><td style='width:75%' class='def'><p>Handles the opacity changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce5e8eee-5195-4e85-9b79-96ec48fea560'>RaiseMakeDuplicate</a></td><td style='width:75%' ><p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77f5fe04-165f-4ec0-89c0-d602c1665e92'>RaiseRemoveSketch</a></td><td style='width:75%' class='def'><p>Raises the remove sketch event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b2e1b87-8b06-4015-838c-e63cd01bc5b0'>RaiseSketchModified</a></td><td style='width:75%' ><p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89672c76-28c4-46eb-aaf5-b890a692149a'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cab7a01f-1e07-441a-871c-e722ff3bb50a'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7c70e8a5-7a95-461f-b828-a31dbaa2ad5b'>MakeDuplicate</a></td><td style='width:75%' ><p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffdb73b1-29ba-4bc4-ad16-b40583801189'>RemoveSketch</a></td><td style='width:75%' class='def'><p>Occurs when remove sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb452cf7-31ae-4353-b2dd-df24c3f018c1'>SketchModified</a></td><td style='width:75%' ><p>Occurs when sketch modified.</p>
</td></tr></table></p>


---

<a name="344b8c16-cdc9-4606-af9b-9b672d043928"></a>
##Public Class KimonoInspectorStar

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a `KimonoShapeStar`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#03ff10b8-9e84-46bb-8ac5-fb935613b574'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20da3c51-e5d7-44f0-a5bd-b7cf93bdda96'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorStar</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#34f30f02-e1a8-4ca8-9f9f-085bc5b74c58'>DepthSlider</a></td><td style='width:75%' ><p>The private read only <code>DepthSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6c84844-6423-44f7-83e1-392ce0896064'>DepthValue</a></td><td style='width:75%' class='def'><p>The private read only <code>DepthValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4781b301-878c-4bc4-8b00-44c3b462b794'>DesignSurface</a></td><td style='width:75%' ><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9a7578a-4073-4ab1-87e8-b505273b832d'>PointsSlider</a></td><td style='width:75%' class='def'><p>The private read only <code>PointsSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7016a10-9f5b-455b-be11-847958031f4b'>PointsValue</a></td><td style='width:75%' ><p>The private read only <code>PointsValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd4d4e16-f52c-42ce-9ccd-633c5ab5971b'>SelectedShape</a></td><td style='width:75%' class='def'><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#767182d7-f230-4a20-bd01-221e163ce0c5'>SkipSlider</a></td><td style='width:75%' ><p>The private read only <code>SkipSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77ed4bb0-4e0e-44e9-a9d4-b906f7f5ecfd'>SkipValue</a></td><td style='width:75%' class='def'><p>The private read only <code>SkipValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c22e665b-2877-4df8-906a-735e3b40c669'>DepthChanged</a></td><td style='width:75%' ><p>Handles the point depth value chainging.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea3fad8f-cb2a-4cb2-97cb-fdafc5a39c8c'>Initialize</a></td><td style='width:75%' class='def'><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20e2f993-d8ce-412d-b766-69feae4f6b60'>KimonoInspectorStar</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#344b8c16-cdc9-4606-af9b-9b672d043928">KimonoInspectorStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7e548dd-e8ce-4809-a64c-8458bd55c41e'>MoveTo</a></td><td style='width:75%' class='def'><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c0af7fe-b523-437d-b394-6e4874d92d14'>PointsChanged</a></td><td style='width:75%' ><p>Handles the number of points changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f310dae2-489c-426c-919e-6900e830191a'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#777ff121-212e-4038-8745-fd81c00468b6'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4256fc70-3014-4ac0-b5f3-f0022306da20'>SkipChanged</a></td><td style='width:75%' class='def'><p>Handles the skip points number changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd9152f1-8ac2-4785-92d7-a88373ddea91'>UpdateInspector</a></td><td style='width:75%' ><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4c1af845-1c66-43c8-a3c1-4ab12bf91f7a'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="37b475d3-ffd4-4d9e-a559-3bad08bf9b0c"></a>
##Public Class KimonoInspectorStyle

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a given `KimonoStyle`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3354fee1-4227-4b89-8a32-133efd7333dd'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a566bfa-60e0-44ea-a4a1-aa28d546aa16'>_selectedStyle</a></td><td style='width:75%' class='def'><p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1721961-2820-482e-963b-cceadc4d9349'>MakeDuplicate</a></td><td style='width:75%' ><p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f982d87-eb0a-49b9-99e5-af2a9e4454cb'>RemoveStyle</a></td><td style='width:75%' class='def'><p>The private <code>RemoveStyle</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4b8679e-6e27-4a11-bec1-03f719845639'>ReturnToShape</a></td><td style='width:75%' ><p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aeaeddcf-160b-43d0-913b-e4759d464240'>ShapeModified</a></td><td style='width:75%' class='def'><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5df697d2-5d3b-4e14-a9dd-2595d18e71e7'>StyleModified</a></td><td style='width:75%' ><p>The private <code>StyleModified</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18aee7ea-6770-40c4-811e-6e2089ed48d3'>StyleTypeChanged</a></td><td style='width:75%' class='def'><p>The private <code>StyleTypeChanged</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#02bb46e3-c792-4023-98e0-9edc1299d892'>ApplyButton</a></td><td style='width:75%' ><p>The private read only <code>ApplyButton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d402e176-5001-4526-b1d2-e42ec7dbb33d'>Backbutton</a></td><td style='width:75%' class='def'><p>The private read only <code>Backbutton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39c2868f-fc80-4303-8a49-addbe4487123'>DeleteButton</a></td><td style='width:75%' ><p>The private read only <code>DeleteButton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d77324bb-d3cc-4046-b8dc-f22e8fe958b3'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18b77b1b-9222-4d23-9794-0697e977ffd9'>SelectedShape</a></td><td style='width:75%' ><p>Gets or sets the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a68465dc-22e7-4080-be8a-343e5268b8a3'>SelectedStyle</a></td><td style='width:75%' class='def'><p>Gets or sets the selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e08276ea-a3a0-43b7-93b5-c2f800c0ab06'>StyleName</a></td><td style='width:75%' ><p>The private read only <code>StyleName</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa45ed68-81f6-4fe9-9fba-7419ac1b3e61'>TypeDropdown</a></td><td style='width:75%' class='def'><p>The private read only <code>TypeDropdown</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5d086961-3acf-4461-a099-498de71d3a54'>ApplyChange</a></td><td style='width:75%' ><p>Applies the change to the currently selected <code>KimonShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0532dbd-7489-490b-90ab-01fa8db78696'>DeleteStyle</a></td><td style='width:75%' class='def'><p>Deletes the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e5f5fc1-3b19-4bba-852b-82a85a72f8d0'>DuplicateStyle</a></td><td style='width:75%' ><p>Duplicates the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09870f43-af06-474c-b779-9dff9b88935f'>GoBack</a></td><td style='width:75%' class='def'><p>Returns to the currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90edc352-5ec1-4865-9c9f-506d111f65c1'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29717289-9eda-4048-8570-2b86492b86b8'>KimonoInspectorStyle</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c">KimonoInspectorStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f985aaa2-7a91-4b97-ac50-33d356802e17'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcc3a384-c8df-4e72-857d-1373b3372e5f'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9ee3504-8691-4a54-8728-bfefd6e05818'>RaiseRemoveStyle</a></td><td style='width:75%' ><p>Raises the remove style event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a36a34ba-0ab3-47b0-9826-47e4068de8f9'>RaiseReturnToShape</a></td><td style='width:75%' class='def'><p>Raises the return to shape event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2be6dc43-d26b-4d53-91e7-cb0f9cd6059a'>RaiseShapeModified</a></td><td style='width:75%' ><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#176b8998-7584-4b33-ae32-fef7db54cac4'>RaiseStyleModified</a></td><td style='width:75%' class='def'><p>Raises the style modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#962bfdb0-d703-4e8d-98e7-37ca2f95354d'>RaiseStyleTypeChanged</a></td><td style='width:75%' ><p>Raises the style type changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#937ea23d-9ab1-41ae-b99b-dc09e46f6c16'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6a2f878-a240-49b6-aaf3-37c08ba5b325'>TypeChanged</a></td><td style='width:75%' ><p>Handles the <code>KimonoStyle</code>'s type changing.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83a4df75-1490-4415-80e0-53f98c99318c'>UpdateInspector</a></td><td style='width:75%' class='def'><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e0a0b9a1-8a1b-4e01-9579-ef97372616b1'>MakeDuplicate</a></td><td style='width:75%' ><p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8b6a877-2ba1-403e-bfa7-e0be65c111f6'>RemoveStyle</a></td><td style='width:75%' class='def'><p>Occurs when remove style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a8d84fd-4674-487d-bbc8-8ecaca127e6f'>ReturnToShape</a></td><td style='width:75%' ><p>Occurs when return to shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c08b9b8a-fbcf-4c64-a36e-f49a643aa521'>ShapeModified</a></td><td style='width:75%' class='def'><p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f2e1c72-a31f-43b4-b790-f83d6abd7900'>StyleModified</a></td><td style='width:75%' ><p>Occurs when style modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e4e9d24-0405-457a-a7a7-dbba746c5ec2'>StyleTypeChanged</a></td><td style='width:75%' class='def'><p>Occurs when style type changed.</p>
</td></tr></table></p>


---

<a name="d6667936-a83f-4ed0-b092-62db0b6cab71"></a>
##Public Class KimonoInspectorText

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a given `KimonoShapeText`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d620a87e-6fb9-4760-a794-94a8f2e8b357'>_selectedShape</a></td><td style='width:75%' ><p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4408627-f5cd-4c14-93e4-e6a81d39ca13'>FirstChange</a></td><td style='width:75%' class='def'><p>Indicates of the first change has been made to a textbox. This is used to keep from creating an undo point on every character that the user chages in the textbox's text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad9f346c-adba-487f-80b3-9216621cba96'>ShapeModified</a></td><td style='width:75%' ><p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorText</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#55b89353-6012-4ac0-ad05-0b3e3b005b48'>Contents</a></td><td style='width:75%' ><p>The private read only <code>Contents</code> property of the <code>KimonoInspectorText</code> class has a <code>KimonoMac.KimonoTextView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2ef7ad2-a451-40d2-8c89-9ac19dd84fbb'>DesignSurface</a></td><td style='width:75%' class='def'><p>Gets or sets the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#699971d2-3f0f-4417-abb3-12095cba54ac'>SelectedShape</a></td><td style='width:75%' ><p>Gets or sets the selected shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e7bcd8a2-1d28-4711-972e-6ae67bba82b1'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93b732f9-644d-431e-a51d-987f96c5795d'>KimonoInspectorText</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#d6667936-a83f-4ed0-b092-62db0b6cab71">KimonoInspectorText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f471255e-c85c-41ac-9632-cac5a46483e9'>MoveTo</a></td><td style='width:75%' ><p>Moves the inspector to the given location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f14232a-5c2f-4bde-b9b2-3a6422a68726'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29eb1f32-bb82-4a7b-8079-fbab78263633'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#603dd6bb-98e2-4d1c-a751-2c284514b7d4'>UpdateInspector</a></td><td style='width:75%' class='def'><p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7ff2ae4b-ab35-474e-8710-2884b23144bc'>ShapeModified</a></td><td style='width:75%' ><p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="da5fed64-0411-45d7-bec7-b60d9c3ca60a"></a>
##Public Class KimonoTextView

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSTextView`

###Summary

A type of `NSTextView` that provides a `TextChanged` event to monitor when the user adjust the text of the `KimonoShapeText` instance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6cc36fd5-0f97-4ca7-bc0a-70abd3969afb'>TextChanged</a></td><td style='width:75%' ><p>The private <code>TextChanged</code> field of the <code>KimonoTextView</code> class holds a <code>KimonoMac.KimonoTextView.TextChangedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c980b616-0a32-4044-ae53-8820a3402831'>DidChangeText</a></td><td style='width:75%' ><p>Handles the value of the text field changing </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bad9a51-7e92-4266-bdc4-0c4e47a6f173'>KimonoTextView</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc6bb70e-0eb1-44f6-8979-309d9e8c1a44'>KimonoTextView</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#392d996a-e447-4919-a5ad-808d0ff287c4'>KimonoTextView</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#288071f7-48f9-4c85-a450-bc0ef8dea613'>KimonoTextView</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27ce8643-ad32-4fcf-bddf-7475ef08f614'>RaiseTextChanged</a></td><td style='width:75%' class='def'><p>Raises the text changed event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f5a58777-8ce9-4cea-8f9e-4afa4a1c6533'>TextChanged</a></td><td style='width:75%' ><p>Occurs when text changed.</p>
</td></tr></table></p>


---

<a name="7b3b76dc-f0d8-4cb3-afbe-ff8ac08ca432"></a>
##Private Static Class MainClass

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`System.Object`

###Summary

Main class.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6935ec10-e1d6-4210-b52a-82d4934e6c39'>Main</a></td><td style='width:75%' ><p>The entry point of the program, where the program control starts and ends.</p>
</td></tr></table></p>


---

<a name="b9881a15-c33c-4bf5-8606-4829f8293008"></a>
##Public Class MainWindowController

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSWindowController`

###Summary

Handles the main window for the Kimono Designer app.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d2bc1c3-e10b-4eee-9ab9-c5fb6d31a053'>AlignBottomTool</a></td><td style='width:75%' ><p>The private read only <code>AlignBottomTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1b7e331-7dbe-4f2e-97f3-3fc43882dcdf'>AlignLeftTool</a></td><td style='width:75%' class='def'><p>The private read only <code>AlignLeftTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc8c882b-2969-44f5-a280-8bfaa621f4f6'>AlignRightTool</a></td><td style='width:75%' ><p>The private read only <code>AlignRightTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18abf085-2ff9-4bbf-96bf-74288a5fc1f8'>AlignTopTool</a></td><td style='width:75%' class='def'><p>The private read only <code>AlignTopTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35240f2c-6a2f-438c-81fd-65c02375b498'>CenterHorizontalTool</a></td><td style='width:75%' ><p>The private read only <code>CenterHorizontalTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a816dc9c-5922-4666-8fe5-be2d1f23c89e'>CenterTool</a></td><td style='width:75%' class='def'><p>The private read only <code>CenterTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbd9eff7-ebf6-4930-8905-45d7ba312773'>CenterVerticalTool</a></td><td style='width:75%' ><p>The private read only <code>CenterVerticalTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7148eb7b-22a5-46c5-bf0c-8066b1454736'>GroupShapes</a></td><td style='width:75%' class='def'><p>The private read only <code>GroupShapes</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#974570ad-172e-4b05-ad8f-61823151abb8'>MainController</a></td><td style='width:75%' ><p>Gets the main controller.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04d66ee3-7631-409c-9a84-236e1193b2f4'>MoveBackwardsTool</a></td><td style='width:75%' class='def'><p>The private read only <code>MoveBackwardsTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6325c3fc-15ff-4711-b76b-7817131471be'>MoveBottomTool</a></td><td style='width:75%' ><p>The private read only <code>MoveBottomTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb74227f-e108-40cc-9af2-933661e21ef9'>MoveForwardsTool</a></td><td style='width:75%' class='def'><p>The private read only <code>MoveForwardsTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36fd5321-e72b-4c3b-8a1c-a8b64b99dbcb'>MoveTopTool</a></td><td style='width:75%' ><p>The private read only <code>MoveTopTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f95fcd1-d8f2-4066-b9ac-91fac390070f'>UngroupShapes</a></td><td style='width:75%' class='def'><p>The private read only <code>UngroupShapes</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#03fcc951-0a25-4a61-b8e1-301809ee0ac4'>AddColor</a></td><td style='width:75%' ><p>Adds the color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb26af53-71e2-4bd5-8e9b-af750a84a8f2'>AddGradient</a></td><td style='width:75%' class='def'><p>Adds the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a08f275-c045-4123-913b-84ebc4512ea8'>AddSketch</a></td><td style='width:75%' ><p>Adds the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8adb8adf-0ef8-4543-8c91-f45fd849b7e3'>AddStyle</a></td><td style='width:75%' class='def'><p>Adds the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be0b1b65-b2a3-496f-955f-bd9ea4b380ea'>MainWindowController</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#b9881a15-c33c-4bf5-8606-4829f8293008">MainWindowController</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69472ce8-9887-46e0-be21-10010b7955f6'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff364d13-ce25-47e3-959b-538e0e4c274d'>WindowDidLoad</a></td><td style='width:75%' ><p>Handles the window loading and configures any user interface elements based on the stateof the <code>KimonoPortfolio</code> being edited.</p>
</td></tr></table></p>


---

<a name="c6838f10-2ca9-4324-90ca-7822754a9d0d"></a>
##Public Class SourceListDataSource

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSOutlineViewDataSource`

###Summary

Source list data source.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a229a256-e5b8-4da2-8c9e-f1b448869a54'>_controller</a></td><td style='width:75%' ><p>The private <code>_controller</code> field of the <code>SourceListDataSource</code> class holds a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52f2c9c9-1f9d-4382-a05a-cfe2885624dd'>Items</a></td><td style='width:75%' class='def'><p>The collection of <code>SourceListGroup</code> that are being displayed.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8843adc8-5dfa-49f9-b8a2-6aac98c03539'>GetChild</a></td><td style='width:75%' ><p>Gets the child.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#277452ef-5605-4029-8c52-7046697e7c29'>GetChildrenCount</a></td><td style='width:75%' class='def'><p>Gets the children count.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72dd8ec6-033d-4a50-ad1a-d4a68c8d59e3'>GetObjectValue</a></td><td style='width:75%' ><p>Gets the object value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#846235a8-834a-4ed9-91f6-0aa129d6c065'>ItemExpandable</a></td><td style='width:75%' class='def'><p>Items the expandable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6ad9943-3b88-4b9d-85ef-f409c3522c03'>ItemForRow</a></td><td style='width:75%' ><p>Items for row.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b88c0507-420f-45e0-8082-335db86898e1'>SourceListDataSource</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <code>OutlineDataSource</code> class.</p>
</td></tr></table></p>


---

<a name="87ea1989-9a98-4fa5-bd46-da2e4a742528"></a>
##Public Class SourceListDelegate

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSOutlineViewDelegate`

###Summary

Source list delegate.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#91168943-b770-4bdd-938b-daac4314c202'>_controller</a></td><td style='width:75%' ><p>The private <code>_controller</code> field of the <code>SourceListDelegate</code> class holds a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f0499732-33df-4158-aff2-49783d826d4a'>GetCell</a></td><td style='width:75%' ><p>Gets the cell.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6d89e11-5565-40e7-bd57-2c9f032d8761'>GetView</a></td><td style='width:75%' class='def'><p>Views for table column.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d51bcea-a44d-4379-ba07-fee55c75cfd7'>IsGroupItem</a></td><td style='width:75%' ><p>Determines whether this instance is group item the specified outlineView item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bc67887-bee9-443a-996e-b22d1610e2c4'>SelectionDidChange</a></td><td style='width:75%' class='def'><p>Selections the did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9813cf33-92d4-40cd-b9fc-49a702a89e19'>ShouldEditTableColumn</a></td><td style='width:75%' ><p>Shoulds the edit table column.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a527b9f4-3c81-41de-ac30-8d0a254eb062'>ShouldSelectItem</a></td><td style='width:75%' class='def'><p>Shoulds the select item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc90e87e-5162-4709-8965-f7d3957be1e3'>SourceListDelegate</a></td><td style='width:75%' ><p>Initializes a new instance of the <code>OutlineViewDelegate</code> class.</p>
</td></tr></table></p>


---

<a name="20b849ed-e963-46fd-ac47-3fdd0ee424fa"></a>
##Public Class SourceListItem

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`Foundation.NSObject`

###Summary

Source list item.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8829417f-5adb-49aa-b818-07c46eb85b09'>_icon</a></td><td style='width:75%' ><p>The private <code>_icon</code> field of the <code>SourceListItem</code> class holds a <code>AppKit.NSImage</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcee49bb-1612-4047-b9ea-b34cf4311a0c'>_items</a></td><td style='width:75%' class='def'><p>The private <code>_items</code> field of the <code>SourceListItem</code> class holds a <code>System.Collections.Generic.List&lt;KimonoMac.SourceListItem&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27d4dfcf-1cd1-4f9f-b11e-21ea5a2e66a3'>_position</a></td><td style='width:75%' ><p>The private <code>_position</code> field of the <code>SourceListItem</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c97754e-e5be-4aab-98c2-a4d6b4cbf5fe'>_tag</a></td><td style='width:75%' class='def'><p>The private <code>_tag</code> field of the <code>SourceListItem</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42b880bd-4a46-4abe-8c38-e103605dd951'>_title</a></td><td style='width:75%' ><p>The private <code>_title</code> field of the <code>SourceListItem</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1b155db-34cc-4d9e-80f9-bd2de1e74f41'>Clicked</a></td><td style='width:75%' class='def'><p>The private <code>Clicked</code> field of the <code>SourceListItem</code> class holds a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#257c2324-41f5-4a7e-add9-2a1ceef1767c'>Count</a></td><td style='width:75%' ><p>Gets the count.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7053e766-ee89-4e01-a0b0-0f40a0a07d9e'>Current</a></td><td style='width:75%' class='def'><p>Gets the current.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95032640-2aa0-4f53-98e9-3433d6d66361'>HasChildren</a></td><td style='width:75%' ><p>Gets a value indicating whether this instance has children.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cb47192-248c-4856-b0f5-c2d51cab8cb2'>Icon</a></td><td style='width:75%' class='def'><p>Gets or sets the icon.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b0eee16-f0cb-488e-a77b-1fd273b572ed'>Item(System.Int32)</a></td><td style='width:75%' ><p>Gets or sets the <code>SourceListGroup</code> at the specified index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72f197a7-99a1-431d-a6d0-cc2a03899044'>Tag</a></td><td style='width:75%' class='def'><p>Gets or sets the tag.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f133a7be-4f0a-47a1-b6f7-9ebc4aadb43e'>Title</a></td><td style='width:75%' ><p>Gets or sets the title.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#53ea5645-4646-4f98-9553-d9296d83fb51'>AddItem</a></td><td style='width:75%' ><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e791763e-2d20-4c6b-a8f5-4102949550e2'>AddItem</a></td><td style='width:75%' class='def'><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab5671ab-96c3-4904-b48f-d2cce0ff90fc'>AddItem</a></td><td style='width:75%' ><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8313e85-be87-4368-ae72-5986095a784d'>AddItem</a></td><td style='width:75%' class='def'><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d959c8b-a275-478f-be5c-65ea4ba646a4'>AddItem</a></td><td style='width:75%' ><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d46d274e-2b07-466b-bbd1-f7f5c30cf3bd'>AddItem</a></td><td style='width:75%' class='def'><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d8cc8b1-2fc4-4bf2-8f91-7e5a277605fa'>AddItem</a></td><td style='width:75%' ><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b22ef3a-2566-4ece-9907-5c359716bfbd'>AddItem</a></td><td style='width:75%' class='def'><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cbf5d7e-f38b-487a-a8c3-228c8e98c8a0'>Clear</a></td><td style='width:75%' ><p>Clear this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3471e04-983a-4b2e-bd1f-0367595cb0f7'>GetEnumerator</a></td><td style='width:75%' class='def'><p>Gets the enumerator.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e565c77-8248-4dcb-ac86-46e2c4fa1593'>Insert</a></td><td style='width:75%' ><p>Insert the specified n and item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4038978-d37e-4124-a3c5-3a096a26f414'>MoveNext</a></td><td style='width:75%' class='def'><p>Moves the next.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34bd9077-6dcf-4bdc-a887-0e64b5e27c43'>RaiseClickedEvent</a></td><td style='width:75%' ><p>Raises the clicked event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a19e63d5-479c-4e4d-863a-a68db62687d1'>RemoveItem</a></td><td style='width:75%' class='def'><p>Removes the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51e25c10-8d53-4ba4-a3c7-6a154deb4490'>RemoveItem</a></td><td style='width:75%' ><p>Removes the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a70d25a8-e81d-4a5a-a19e-9a255bcb5f18'>Reset</a></td><td style='width:75%' class='def'><p>Reset this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a49fe55a-3cfe-45fb-aa01-71e773829112'>SourceListItem</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#173189d6-4df7-427a-a837-12a76c879c0f'>SourceListItem</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96566ebc-7489-49df-bbac-b58b2ab68288'>SourceListItem</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0164b2e4-199a-461d-b5c6-7380fe611382'>SourceListItem</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dc4a960-7886-48d2-86e8-9f210fa44509'>SourceListItem</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ef50103-0248-489c-a321-6ac9880a4ffb'>SourceListItem</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb6dc3f7-dea3-4292-aece-4251977374a5'>SourceListItem</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6548fc78-a1b8-45be-9d6a-53b9e5602f7b'>SourceListItem</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2df6d1fb-94d5-4a4f-993c-9b020efdbb79'>Clicked</a></td><td style='width:75%' ><p>Occurs when clicked.</p>
</td></tr></table></p>


---

<a name="5ba0f8fa-3462-4142-9024-c68716903b8f"></a>
##Public Class SourceListView

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSOutlineView`

###Summary

Source list view.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8eafcffa-0716-48f6-954a-4922630627fd'>ItemSelected</a></td><td style='width:75%' ><p>The private <code>ItemSelected</code> field of the <code>SourceListView</code> class holds a <code>KimonoMac.SourceListView.ItemSelectedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ed751902-1cf6-4f4c-af5f-a29e1b9abb44'>Data</a></td><td style='width:75%' ><p>Gets the data.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5a0ac51a-65bf-48c6-9fd4-91651702a4bb'>AddItem</a></td><td style='width:75%' ><p>Adds the item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2fdbe9c-1ac1-4a07-ae5e-f936bb80ff4b'>AwakeFromNib</a></td><td style='width:75%' class='def'><p>The public virtual <code>AwakeFromNib ()</code> member of the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#843e05cc-e313-4c54-9a6d-f68cdd766368'>Initialize</a></td><td style='width:75%' ><p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f19a0fde-bac3-4090-a442-483ef9ce1fab'>RaiseItemSelected</a></td><td style='width:75%' class='def'><p>Raises the item selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3471d8b-87b1-42c8-8104-3ad52bbfe834'>SourceListView</a></td><td style='width:75%' ><p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b30e1ea-2609-4957-ae61-e1ac50112efc'>SourceListView</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a88eda64-31ab-4acc-a92c-3669cb1fc35b'>SourceListView</a></td><td style='width:75%' ><p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab6cb6da-78e0-48bf-ac29-58438616c44e'>SourceListView</a></td><td style='width:75%' class='def'><p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#864cf2b8-3f69-44a3-935f-ef90189c94b4'>ItemSelected</a></td><td style='width:75%' ><p>Occurs when item selected.</p>
</td></tr></table></p>


---

<a name="34258cd9-f194-4032-90e7-90700902ba3d"></a>
##TextChangedDelegate

###Namespace

[KimonoMac.KimonoTextView](#11a4f065-81b1-4138-8e90-61d1bafcb9e4)

###Summary

Text changed delegate.

---

<a name="cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc"></a>
##Public Class ViewController

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSViewController`

###Summary

Handles the master view for the Kimono Designer.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d96a21ea-2884-426b-8ab4-77c0f5cf7f18'>SketchModified</a></td><td style='width:75%' ><p>The private <code>SketchModified</code> field of the <code>ViewController</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#139425ef-a8d3-4538-8f4c-326f3c948c30'>ArrowInspector</a></td><td style='width:75%' ><p>The private read only <code>ArrowInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorArrow</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b8c86da-218f-47ef-9a66-1efdee4fd37b'>AttachedStyleInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>AttachedStyleInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorAttachedStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55e168d1-e454-4894-89cf-b66c7f18412e'>BackButton</a></td><td style='width:75%' ><p>The private read only <code>BackButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5220edf-09e2-45a5-8dbc-4cb297b42501'>ColorList</a></td><td style='width:75%' class='def'><p>Gets or sets the sidebar color list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a435205a-2814-4c55-8181-44e51b965f84'>ColorPaletteInspector</a></td><td style='width:75%' ><p>The private read only <code>ColorPaletteInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPaleteColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#265cf0b6-4a00-4e2e-b4a1-5dc4bc1a54d4'>DesignSurface</a></td><td style='width:75%' class='def'><p>The private read only <code>DesignSurface</code> property of the <code>ViewController</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16e43712-a279-48b6-8087-c8342dd6c5a1'>DocumentScrollView</a></td><td style='width:75%' ><p>The private read only <code>DocumentScrollView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSScrollView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2da6d0da-7415-4c8a-a4e7-9ecf412d0945'>DocumentView</a></td><td style='width:75%' class='def'><p>The private read only <code>DocumentView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3994fa23-21e7-4956-b1fa-6fe95883a7fe'>DocumentViewHeight</a></td><td style='width:75%' ><p>The private read only <code>DocumentViewHeight</code> property of the <code>ViewController</code> class has a <code>AppKit.NSLayoutConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f934d600-b016-4c51-9ba5-a4cd22b87d42'>DocumentViewWidth</a></td><td style='width:75%' class='def'><p>The private read only <code>DocumentViewWidth</code> property of the <code>ViewController</code> class has a <code>AppKit.NSLayoutConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#333554ec-11e8-4646-b0c8-913596f0d696'>FillInspector</a></td><td style='width:75%' ><p>The private read only <code>FillInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFill</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8591355d-0aef-43eb-b349-e140226c813e'>FontInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>FontInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFont</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c68b8cdb-6083-48a1-b5f5-187b4c4e4cb6'>FrameInspector</a></td><td style='width:75%' ><p>The private read only <code>FrameInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFrame</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d9d415a-f027-4364-8695-786d472e96ba'>GeneralInfoInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>GeneralInfoInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGeneralInfo</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e681c3c-a78c-4b26-8b2d-b986b533c936'>GradientInspector</a></td><td style='width:75%' ><p>The private read only <code>GradientInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0be3e68-a34f-4aa0-899e-3e22751ba028'>GradientList</a></td><td style='width:75%' class='def'><p>Gets or sets the gradient list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb2cf70e-397d-4810-885d-3e2688ccc97f'>GroupInspector</a></td><td style='width:75%' ><p>The private read only <code>GroupInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGroup</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a9b91ad-fd4c-4451-9e41-80834256dc1c'>InspectorScrollView</a></td><td style='width:75%' class='def'><p>The private read only <code>InspectorScrollView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSScrollView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a37197b8-57ac-4d00-b8f4-06d5ad962abc'>InspectorView</a></td><td style='width:75%' ><p>The private read only <code>InspectorView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dfe7760-02f6-4118-bccb-6e1fc54c3565'>PolygonInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>PolygonInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPolygon</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74160260-5fc8-456e-975f-4bc2cb03e6a4'>ProjectList</a></td><td style='width:75%' ><p>Gets or sets the sidebar project list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#537ce53e-b014-4712-9d29-f092f9ee00c2'>RoundRectInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>RoundRectInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorRoundRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b058af1f-3a66-4cad-ac6c-cd323329de82'>ShapesList</a></td><td style='width:75%' ><p>Gets or sets the sidebar shapes list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdbc9d0d-a841-4037-af07-804e2e01386f'>SketchesList</a></td><td style='width:75%' class='def'><p>Gets or sets the sidebar sketches list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f5567c9-33ba-4c16-b318-fba2f761506d'>SketchInspector</a></td><td style='width:75%' ><p>The private read only <code>SketchInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12149a66-758e-4946-9061-1f7ed1000eac'>SketchPath</a></td><td style='width:75%' class='def'><p>The private read only <code>SketchPath</code> property of the <code>ViewController</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db064f6b-e295-4757-9db0-a2653f01f23d'>SourceList</a></td><td style='width:75%' ><p>The private read only <code>SourceList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d82eaa6-0c82-4b15-838e-e1b19f06ea55'>StarInspector</a></td><td style='width:75%' class='def'><p>The private read only <code>StarInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorStar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e6aa787-7c9c-4a82-a021-94119e394fb8'>StyleInspector</a></td><td style='width:75%' ><p>The private read only <code>StyleInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c53bb142-9f15-4b8c-bfc7-e7eba1138d32'>StyleList</a></td><td style='width:75%' class='def'><p>Gets or sets the sidebar style list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e93f3643-ead8-4fbf-8ecf-54fc4236bf32'>TextInspector</a></td><td style='width:75%' ><p>The private read only <code>TextInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorText</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78a1831f-86a2-48a4-be50-0318acf327d8'>ToolArrow</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolArrow</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b37447c5-bcae-4633-a6a2-d8a14930eea0'>ToolBezier</a></td><td style='width:75%' ><p>The private read only <code>ToolBezier</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButtonCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a3d16d8-88cd-4580-821c-1da503069b4e'>ToolCursor</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolCursor</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButtonCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9133b98b-5fe9-4bf8-89df-4d0b7bcea7f4'>ToolLine</a></td><td style='width:75%' ><p>The private read only <code>ToolLine</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97029ec0-25c1-4216-a5b6-4dde2e353b30'>ToolOval</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolOval</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc2a3fc9-8661-46f9-8838-1ec06a6c7e9c'>ToolPolygon</a></td><td style='width:75%' ><p>The private read only <code>ToolPolygon</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e5e08f5-74c9-4c5f-8356-d56fa942a760'>ToolRect</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolRect</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c753b97-c557-4724-9969-bf9fc88cac32'>ToolRoundRect</a></td><td style='width:75%' ><p>The private read only <code>ToolRoundRect</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25273c6e-0561-4b17-97c1-f4b78e993002'>ToolStar</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolStar</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#785f6670-a5e1-4e2e-87e0-eead3aa93350'>ToolText</a></td><td style='width:75%' ><p>The private read only <code>ToolText</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb631388-15cd-4189-ab53-17e824ee27e0'>ToolTriangle</a></td><td style='width:75%' class='def'><p>The private read only <code>ToolTriangle</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a613e30c-ae3a-4616-9ef1-f35e70984e5a'>ToolVector</a></td><td style='width:75%' ><p>The private read only <code>ToolVector</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c9ef3160-32c4-4c03-bdfb-6426463454f3'>AddNewColor</a></td><td style='width:75%' ><p>Adds a new <code>KimonoSketch</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eee5d46-1d72-412c-97bc-0bf02e735b27'>AddNewColor</a></td><td style='width:75%' class='def'><p>Adds a new <code>KimonoColor</code> based off of the given <code>SKColor</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#261752d7-3f77-46de-9af7-7b531a02bf97'>AddNewGradient</a></td><td style='width:75%' ><p>Adds the new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2b9952b-3af5-45ad-b413-0138c77fe79f'>AddNewSketch</a></td><td style='width:75%' class='def'><p>Adds a new <code>KimonoSketch</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbde146b-85b2-4192-aff2-079698a258ce'>AddNewStyle</a></td><td style='width:75%' ><p>Adds a new <code>KimonoStyle</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46f2a2c6-11e0-47e3-9e3e-ae55a322983f'>AlignShapeBottom</a></td><td style='width:75%' class='def'><p>Aligns the shape bottoms.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23b379a4-7538-4356-8ae9-690c7d4059ba'>AlignShapeCenter</a></td><td style='width:75%' ><p>Aligns the shape centers.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96b6a5e2-03fa-4bb0-84c3-3460a68c905b'>AlignShapeCenterHorizontal</a></td><td style='width:75%' class='def'><p>Aligns the shape centers horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7392e52b-6d80-42b8-a8d9-cb9e1d0d1cfa'>AlignShapeCenterVertical</a></td><td style='width:75%' ><p>Aligns the shape centers vertically.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ecaf28c-d69b-44b4-b028-c4bb4b84d5ba'>AlignShapeLeft</a></td><td style='width:75%' class='def'><p>Aligns the shape left sides.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f7e20de-f8b5-4e8f-a595-36a8da527653'>AlignShapeRight</a></td><td style='width:75%' ><p>Aligns the shape right sides.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e6b246f-dd56-44fc-b6b5-49f8d5e6d746'>AlignShapeTop</a></td><td style='width:75%' class='def'><p>Aligns the shape tops.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98f2a2f7-9fe7-49b6-90ce-1d8344bbcd7f'>CloseAllInspectors</a></td><td style='width:75%' ><p>Closes all open inspectors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a8b7f0e-d92c-4df8-9863-bf6256fb5dbe'>DeleteColor</a></td><td style='width:75%' class='def'><p>Deletes the given <code>KimonoColor</code> from the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfd6c215-00a2-4646-a979-927b90d8f1e4'>DeleteGradient</a></td><td style='width:75%' ><p>Deletes the given gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37158f78-77d1-4fc9-ab08-fb96e730026e'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf7f144b-3270-4590-b3b7-9325d93a1078'>DeleteStyle</a></td><td style='width:75%' ><p>Deletes the given <code>KimonoStyle</code> from the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fccc204-770f-4c8c-b1e6-ea0ec8a61b4e'>DuplicateColor</a></td><td style='width:75%' class='def'><p>Duplicates the given <code>KimonoColor</code> and adds it to <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7d5838b-424c-48b0-a215-1f4a7ef80406'>DuplicateGradient</a></td><td style='width:75%' ><p>Duplicates the given gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69b6abe0-f7d2-4e1d-8134-5f17b9c233ee'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ea05891-58b2-4d35-868c-e80f2a8731c1'>DuplicateStyle</a></td><td style='width:75%' ><p>Duplicates the given <code>KimonoStyle</code> in the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba2609a3-660c-4440-aa20-42d954db4d23'>GoBackToSketch</a></td><td style='width:75%' class='def'><p>Goes the back to sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a0409bb-0f81-4b15-86d3-da9ad6cd0426'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#329d7b91-0a51-41d6-8a02-ac2d0b5cf751'>HighlightTool</a></td><td style='width:75%' class='def'><p>Highlights the currently selected <code>KimonoTool</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ca47852-2ff9-4616-8279-54da34a90caa'>InitializeInspectors</a></td><td style='width:75%' ><p>Initializes the inspectors that allow the user to configure all of the elements in the <code>KimonoPortfolio</code> that is currently being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3934b0c5-51ed-4179-9d24-1b22b6cbaf2d'>MoveBackwards</a></td><td style='width:75%' class='def'><p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea892458-c25f-4153-8a8b-d7d5077e6d03'>MoveForwards</a></td><td style='width:75%' ><p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d3202b3-bf4a-4988-93c2-74b1c0003446'>MoveToBottom</a></td><td style='width:75%' class='def'><p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcfad951-c165-4291-99a0-db6dfb485e20'>MoveToTop</a></td><td style='width:75%' ><p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7df0116-fe40-418e-a10c-23ec894a9cf7'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a05b863-0ea9-425c-a8b4-16b57b1b0f8e'>Redo</a></td><td style='width:75%' ><p>Redoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce3abf09-e6c7-4b7b-8b20-f4bf94727842'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc0ee6ec-96a5-479e-91aa-dd00034621d2'>ScrollInspectorsToTop</a></td><td style='width:75%' ><p>Scrolls the inspector list to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9eb0d47b-097e-45e8-8dc4-d6e52ec604c8'>SetDocumentSize</a></td><td style='width:75%' class='def'><p>Adjusts the visible representation of the Design Surface to the dimentions of current <code>KimonoSketch</code> being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2340b207-bd46-4e75-8989-51f35c47686c'>ShowGeneralInspectors</a></td><td style='width:75%' ><p>Shows the general information inspectors for the given shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1930a40-3e48-47bc-ba40-7175d7b945a1'>ShowGradientInspectors</a></td><td style='width:75%' class='def'><p>Shows the gradient inspectors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ffbe6ed-fe20-437b-a3ec-e3e856b965d8'>ShowGroupShapes</a></td><td style='width:75%' ><p>Populates the Shapes sidebar with all of the <code>KimonoShapes</code> in the currently selected <code>KimonoSHapeGroup</code> that is being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fd85707-3837-4cfe-89b6-71db11d3ad8b'>ShowPaletteColorInspectors</a></td><td style='width:75%' class='def'><p>Shows the palette color inspectors for the given color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e27ed3b4-0ae5-4545-b678-0970fbc90471'>ShowSketchInspectors</a></td><td style='width:75%' ><p>Shows the sketch inspectors for the given sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f03b9d6-6986-46a3-8cbf-c19309e38da1'>ShowSketchShapes</a></td><td style='width:75%' class='def'><p>Populates the Shapes sidbar with all of the <code>KimonoShapes</code> in the currently selected <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d389341-58eb-4d64-b499-4dfff29d4d33'>ShowStyleInspectors</a></td><td style='width:75%' ><p>Shows the style inspectors for the given style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c978d1f2-0b03-4faa-a65f-97515995cd20'>ToolArrowSelected</a></td><td style='width:75%' class='def'><p>Tool arrow selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99bad351-4478-45e3-a507-a0725332b113'>ToolBezierSelected</a></td><td style='width:75%' ><p>Tool bezier selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c402eaab-07ad-4c0e-a5a9-f410677e2764'>ToolCursorSelected</a></td><td style='width:75%' class='def'><p>Tool cursor selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34fed293-b981-43cc-9186-3b4e9e48e897'>ToolLineSelected</a></td><td style='width:75%' ><p>Tool line selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb65abe6-0e15-492b-a294-e3f74d26356b'>ToolOvalSelected</a></td><td style='width:75%' class='def'><p>Tool oval selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a070fbb-7da6-4ea1-8361-1810d2ee4550'>ToolPolygonSelected</a></td><td style='width:75%' ><p>Tool polygon selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d492678-6f7b-425b-b21b-98dceb3bb02e'>ToolRectSelected</a></td><td style='width:75%' class='def'><p>Tool rect selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d260fdd-e028-4328-a619-3c81a189bc99'>ToolRoundRectSelected</a></td><td style='width:75%' ><p>Tool round rect selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0847c01d-3a44-4756-b2ec-dcaae2188384'>ToolStarSelected</a></td><td style='width:75%' class='def'><p>Tool star selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3735ada-4fb0-4db1-adbd-43ceeaf194a9'>ToolTextSelected</a></td><td style='width:75%' ><p>Tool text selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13e1b5ec-17f7-40e8-b93e-30a3f6fbb1c5'>ToolTriangleSelected</a></td><td style='width:75%' class='def'><p>Tool triangle selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaae9c5f-0b91-4d83-99a1-db9df52b7c0a'>ToolVectorSelected</a></td><td style='width:75%' ><p>Tool vector selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d676f62-3430-47c2-9298-c6e6557607a2'>Undo</a></td><td style='width:75%' class='def'><p>Udoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#577ab352-a5a9-431e-a9bd-bd1b1f8ac5c2'>UpdateColorList</a></td><td style='width:75%' ><p>Updates the color list in the sidebar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d61333c6-d254-4ff5-abe4-dedbaf05a631'>UpdateGradientList</a></td><td style='width:75%' class='def'><p>Updates the gradient list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#873b2222-f09e-472a-9f72-233bcba2acd3'>UpdatePath</a></td><td style='width:75%' ><p>Updates the path display at the top of the Design Surface showing the full path to the shape currently being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cbbdc85-72a0-412d-83e7-f6a577e61ce2'>UpdateProjectList</a></td><td style='width:75%' class='def'><p>Updates the project list in the sidebar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bbe8793-3dbb-4e9e-ae41-1d224ee8079f'>UpdateShapesList</a></td><td style='width:75%' ><p>Updates the shapes list in the sidebar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a82525a-0b72-4f5f-8b64-0e44f30eb952'>UpdateSketchesList</a></td><td style='width:75%' class='def'><p>Updates the sketches list in the sidebar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c24d733-23f3-423a-86e3-c9c54f229dbb'>UpdateStyleList</a></td><td style='width:75%' ><p>Updates the style list in the sidebar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0ab0a77-c795-4f47-9be4-e38dae85c98b'>ValidateMenuItem</a></td><td style='width:75%' class='def'><p>Validates any menu item attached to actions on this view controller based on its assigned <code>Tag</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b6900d7-80fd-4abc-b9fc-ee6bb4b76117'>ViewController</a></td><td style='width:75%' ><p>Initializes a new instance of the <a href="#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc">ViewController</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2aeceaa3-ee67-45e3-ab56-4ca7b86c6d23'>ViewDidLoad</a></td><td style='width:75%' class='def'><p>Handles the view being sucessfully loaded.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d051725a-d1ae-4ccb-beb5-003beb788621'>SketchModified</a></td><td style='width:75%' ><p>Occurs when the sketch is modified.</p>
</td></tr></table></p>

<a name="Fields"></a>
#Fields


---

<a name="a229a256-e5b8-4da2-8c9e-f1b448869a54"></a>
##Private [KimonoMac.SourceListView](#beadeded-5081-43aa-bf9a-5df81248d624) _controller

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

The private `_controller` field of the `SourceListDataSource` class holds a `KimonoMac.SourceListView` value.

---

<a name="91168943-b770-4bdd-938b-daac4314c202"></a>
##Private [KimonoMac.SourceListView](#beadeded-5081-43aa-bf9a-5df81248d624) _controller

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

The private `_controller` field of the `SourceListDelegate` class holds a `KimonoMac.SourceListView` value.

---

<a name="8829417f-5adb-49aa-b818-07c46eb85b09"></a>
##Private `AppKit.NSImage` _icon

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

The private `_icon` field of the `SourceListItem` class holds a `AppKit.NSImage` value.

---

<a name="fcee49bb-1612-4047-b9ea-b34cf4311a0c"></a>
##Private `System.Collections.Generic.List<KimonoMac.SourceListItem>` _items

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

The private `_items` field of the `SourceListItem` class holds a `System.Collections.Generic.List<KimonoMac.SourceListItem>` value.

---

<a name="27d4dfcf-1cd1-4f9f-b11e-21ea5a2e66a3"></a>
##Private `System.Int32` _position

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

The private `_position` field of the `SourceListItem` class holds a `System.Int32` value.

---

<a name="d555f566-d260-4ca9-b91c-255000a0b9c8"></a>
##Private `KimonoCore.KimonoColor` _selectedColor

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The color of the selected.

---

<a name="46284a9a-dbb7-4d59-84bb-684bcad47742"></a>
##Private `KimonoCore.KimonoGradient` _selectedGradient

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The selected gradient.

---

<a name="6eccc142-a975-4438-918f-60492413470d"></a>
##Private `KimonoCore.KimonoShapeGroup` _selectedGroup

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The selected shape.

---

<a name="4036363d-933f-48cb-b999-4b9d3a24d5af"></a>
##Private `KimonoCore.KimonoShapeRoundRect` _selectedRoundRect

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

The selected shape.

---

<a name="52fe96aa-3b61-4985-9a0b-3178d35ded6a"></a>
##Private `KimonoCore.KimonoShape` _selectedShape

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The selected shape.

---

<a name="5191599c-7d52-405c-b6a4-61192c1bd28a"></a>
##Private `KimonoCore.KimonoShapePolygon` _selectedShape

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

The selected shape.

---

<a name="ef2bf91e-18d0-4486-b03c-5acf7710a260"></a>
##Private `KimonoCore.KimonoShape` _selectedShape

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The selected shape.

---

<a name="03ff10b8-9e84-46bb-8ac5-fb935613b574"></a>
##Private `KimonoCore.KimonoShapeStar` _selectedShape

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The selected shape.

---

<a name="ab2f6b30-4a83-4b01-acd1-881fde96be1c"></a>
##Private `KimonoCore.KimonoShapeArrow` _selectedShape

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The selected shape.

---

<a name="a0f3f0a4-2c76-48cf-bad9-4e65ca1d4871"></a>
##Private `KimonoCore.KimonoShape` _selectedShape

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The selected shape.

---

<a name="2192a6ba-9c8e-4b4c-b527-60eb4338b126"></a>
##Private `KimonoCore.KimonoShape` _selectedShape

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The selected shape.

---

<a name="d620a87e-6fb9-4760-a794-94a8f2e8b357"></a>
##Private `KimonoCore.KimonoShapeText` _selectedShape

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

The selected shape.

---

<a name="3354fee1-4227-4b89-8a32-133efd7333dd"></a>
##Private `KimonoCore.KimonoShape` _selectedShape

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The selected shape.

---

<a name="b69d3276-4693-4d8f-82de-b96270c8494a"></a>
##Private `KimonoCore.KimonoSketch` _selectedSketch

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The selected sketch.

---

<a name="38c03433-59c8-484e-a694-23e12175beb5"></a>
##Private `KimonoCore.KimonoStyle` _selectedStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The selected style.

---

<a name="9dfcd5ae-c3c2-40c1-a30b-9bd522c4f362"></a>
##Private `KimonoCore.KimonoStyle` _selectedStyle

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The selected style.

---

<a name="4a566bfa-60e0-44ea-a4a1-aa28d546aa16"></a>
##Private `KimonoCore.KimonoStyle` _selectedStyle

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The selected style.

---

<a name="8a1186be-50dc-422b-9a1f-1a7efb6ef994"></a>
##Private `KimonoCore.KimonoStyle` _selectedStyle

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The selected style.

---

<a name="2bb7ecbe-e272-47df-a05c-c1a37e41dc67"></a>
##Private `KimonoCore.KimonoStyle` _selectedStyle

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The selected style.

---

<a name="1c97754e-e5be-4aab-98c2-a4d6b4cbf5fe"></a>
##Private `System.String` _tag

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

The private `_tag` field of the `SourceListItem` class holds a `System.String` value.

---

<a name="42b880bd-4a46-4abe-8c38-e103605dd951"></a>
##Private `System.String` _title

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

The private `_title` field of the `SourceListItem` class holds a `System.String` value.

---

<a name="1ff98fd7-8274-4ef1-af29-af364e4201dc"></a>
##Private `System.Collections.Generic.List<KimonoCore.KimonoColor>` AvailableBaseColors

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The available base colors.

---

<a name="e1b155db-34cc-4d9e-80f9-bd2de1e74f41"></a>
##Private [KimonoMac.SourceListItem.ClickedDelegate](#7895a845-abf1-402c-a040-0a2bc4e4ac64) Clicked

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

The private `Clicked` field of the `SourceListItem` class holds a `KimonoMac.SourceListItem.ClickedDelegate` value.

---

<a name="0f2475ef-1671-4bd7-a922-fad2b2c68422"></a>
##Private `KimonoCore.Kimono.ColorEventDelegate` ColorModified

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private `ColorModified` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="0ac4dafd-6c98-47b2-affe-7f32afbcc550"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ConvertToStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private `ConvertToStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="685b68df-f61a-4a69-ad63-fa79c6f46905"></a>
##Private `KimonoCore.Kimono.StyleEventDelegate` EditAttachedStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private `EditAttachedStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="b4408627-f5cd-4c14-93e4-e6a81d39ca13"></a>
##Private `System.Boolean` FirstChange

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Indicates of the first change has been made to a textbox. This is used to keep from creating an undo point on every character that the user chages in the textbox's text.

---

<a name="75fffb72-3ee7-45fb-925b-f716b9eb9393"></a>
##Private `KimonoCore.Kimono.GradientEventDelegate` GradientModified

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private `GradientModified` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="1d671a73-d8c5-428e-aeea-fc9017603a86"></a>
##Private `KimonoCore.Kimono.GroupEventDelegate` GroupModified

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The private `GroupModified` field of the `KimonoInspectorGroup` class holds a `KimonoCore.Kimono.GroupEventDelegate` value.

---

<a name="52f2c9c9-1f9d-4382-a05a-cfe2885624dd"></a>
##Public `System.Collections.Generic.List<KimonoMac.SourceListItem>` Items

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

The collection of `SourceListGroup` that are being displayed.

---

<a name="8eafcffa-0716-48f6-954a-4922630627fd"></a>
##Private [KimonoMac.SourceListView.ItemSelectedDelegate](#9146e8cc-76d1-4777-bbdd-3912a5209854) ItemSelected

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

The private `ItemSelected` field of the `SourceListView` class holds a `KimonoMac.SourceListView.ItemSelectedDelegate` value.

---

<a name="d79eaa15-4685-4664-89ed-a58e642651a9"></a>
##Private `KimonoCore.Kimono.GradientEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="5c588836-6102-4bb4-b6f5-769562d3c49b"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="22ec56c1-842b-430a-9f08-1281c6fd6899"></a>
##Private `KimonoCore.Kimono.ColorEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="a1721961-2820-482e-963b-cceadc4d9349"></a>
##Private `KimonoCore.Kimono.StyleEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="e74cd337-f174-444e-b0c2-f1a38066fecd"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private `MakeDuplicate` field of the `KimonoInspectorSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="0e239047-98bf-47f6-a38c-9b50af6cc12c"></a>
##Private `KimonoCore.Kimono.SkiaColorEventDelegate` MakeNewColor

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private `MakeNewColor` field of the `KimonoInspectorFrame` class holds a `KimonoCore.Kimono.SkiaColorEventDelegate` value.

---

<a name="4d3e25b5-8a2e-4bdb-8f17-560f72410c6f"></a>
##Private `KimonoCore.Kimono.SkiaColorEventDelegate` MakeNewColor

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private `MakeNewColor` field of the `KimonoInspectorFill` class holds a `KimonoCore.Kimono.SkiaColorEventDelegate` value.

---

<a name="8af2ccc6-20be-4978-af29-26e05d0cf65e"></a>
##Private `KimonoCore.Kimono.ColorEventDelegate` RemoveColor

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private `RemoveColor` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ColorEventDelegate` value.

---

<a name="749e491c-8423-4df8-bdd2-fc7d45aa3a3c"></a>
##Private `KimonoCore.Kimono.GradientEventDelegate` RemoveGradient

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private `RemoveGradient` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.GradientEventDelegate` value.

---

<a name="014eee28-fe81-4f6a-ac52-893bd0bc086a"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` RemoveShape

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private `RemoveShape` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="744e7594-4fb9-41e5-9c66-75d72e127dca"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` RemoveSketch

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private `RemoveSketch` field of the `KimonoInspectorSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="5f982d87-eb0a-49b9-99e5-af2a9e4454cb"></a>
##Private `KimonoCore.Kimono.StyleEventDelegate` RemoveStyle

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `RemoveStyle` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="41b44da8-9ccd-42a2-806a-f7a8c4ff4f15"></a>
##Private `KimonoCore.Kimono.StyleEventDelegate` RemoveStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private `RemoveStyle` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="9bbe80c5-435f-48ee-96a1-e0c2d98e3e96"></a>
##Private `KimonoCore.Kimono.ShapeEventDelegate` ReturnToShape

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private `ReturnToShape` field of the `KimonoInspectorPaleteColor` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="f4b8679e-6e27-4a11-bec1-03f719845639"></a>
##Private `KimonoCore.Kimono.ShapeEventDelegate` ReturnToShape

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `ReturnToShape` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="b3387906-9ee6-48ae-aba9-0db0c253458b"></a>
##Private `KimonoCore.Kimono.ShapeEventDelegate` ReturnToShape

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private `ReturnToShape` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="9195f982-35de-4241-a6db-1e42409bf4d3"></a>
##Private `KimonoCore.Kimono.ShapeEventDelegate` SelectionChanged

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private `SelectionChanged` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="ad9f346c-adba-487f-80b3-9216621cba96"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

The private `ShapeModified` field of the `KimonoInspectorText` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="30a10410-d614-45bc-9cbd-15ea65a809dd"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private `ShapeModified` field of the `KimonoInspectorFont` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ce8725ca-f6e0-4ccc-ab86-fcc929e6493c"></a>
##Private `KimonoCore.Kimono.ShapeEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private `ShapeModified` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.ShapeEventDelegate` value.

---

<a name="393f177d-9017-4abc-9b3c-61d03333167d"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private `ShapeModified` field of the `KimonoInspectorArrow` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="ae79ad7c-cda7-4b0c-9b67-c92cc163f858"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

The private `ShapeModified` field of the `KimonoInspectorRoundRect` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="829dc66b-60ed-47d6-8539-0bc04e8211c0"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private `ShapeModified` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="aeaeddcf-160b-43d0-913b-e4759d464240"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `ShapeModified` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="8b65a5b5-8125-44d5-8cce-8c1c7fcc0517"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private `ShapeModified` field of the `KimonoInspectorFrame` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="060cd192-e1b6-4a50-b445-42bfde86ccf3"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private `ShapeModified` field of the `KimonoInspectorFill` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="0ca27ea4-5339-4ec6-8c78-98ba70f46f85"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

The private `ShapeModified` field of the `KimonoInspectorPolygon` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="20da3c51-e5d7-44f0-a5bd-b7cf93bdda96"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private `ShapeModified` field of the `KimonoInspectorStar` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="494fe256-b025-402d-8d4f-73186ac8406e"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private `ShapeModified` field of the `KimonoInspectorGradient` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="4d1ed4ad-ca86-4b8d-8995-d15b4aa9ed67"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` SketchModified

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private `SketchModified` field of the `KimonoInspectorSketch` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="d96a21ea-2884-426b-8ab4-77c0f5cf7f18"></a>
##Private `KimonoCore.Kimono.SketchEventDelegate` SketchModified

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private `SketchModified` field of the `ViewController` class holds a `KimonoCore.Kimono.SketchEventDelegate` value.

---

<a name="07723358-ccc9-454b-9559-95cbacc47cb0"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` SketchModified

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private `SketchModified` field of the `KimonoInspectorGeneralInfo` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="0eba0229-bf86-441c-a4d3-da268bed30eb"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` StyleModified

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private `StyleModified` field of the `KimonoInspectorAttachedStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="c52738c0-5d90-444a-bf3c-ce5aa69d7984"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` StyleModified

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private `StyleModified` field of the `KimonoInspectorFont` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="5df697d2-5d3b-4e14-a9dd-2595d18e71e7"></a>
##Private `KimonoCore.Kimono.PortfolioEventDelegate` StyleModified

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `StyleModified` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.PortfolioEventDelegate` value.

---

<a name="18aee7ea-6770-40c4-811e-6e2089ed48d3"></a>
##Private `KimonoCore.Kimono.StyleEventDelegate` StyleTypeChanged

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `StyleTypeChanged` field of the `KimonoInspectorStyle` class holds a `KimonoCore.Kimono.StyleEventDelegate` value.

---

<a name="6cc36fd5-0f97-4ca7-bc0a-70abd3969afb"></a>
##Private [KimonoMac.KimonoTextView.TextChangedDelegate](#34258cd9-f194-4032-90e7-90700902ba3d) TextChanged

###Member of Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

The private `TextChanged` field of the `KimonoTextView` class holds a `KimonoMac.KimonoTextView.TextChangedDelegate` value.
<a name="Properties"></a>
#Properties


---

<a name="b7280246-b977-439b-9511-5acc6ad23396"></a>
##Public `System.Boolean` Active

###Member of Type

[ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600)

###Summary

Gets or sets a value indicating whether this [ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) is active.
###Return Value

`true` if active; otherwise, `false`.

---

<a name="f91ffe79-a470-454a-9210-58aa6f4fbafe"></a>
##Private Read Only `AppKit.NSButton` AddColorButton

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `AddColorButton` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="1fcb9710-2d5c-412b-a3d9-0fc2d406c7b4"></a>
##Private Read Only `AppKit.NSButton` AddColorButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `AddColorButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="6a064e14-1ce2-4d3d-898c-4a21abb6f23c"></a>
##Private Read Only `AppKit.NSButton` AddColorButton

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `AddColorButton` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="b340ef5d-8208-4800-a4c3-d1a3e18a6825"></a>
##Private Read Only `AppKit.NSButton` AddPointButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `AddPointButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="cce07664-29f6-47ed-ab8f-8bb1dfc83dd6"></a>
##Private Read Only `AppKit.NSButton` AdjustBrightnessCheckbox

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `AdjustBrightnessCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="30f0e440-1fb2-4ba8-ac72-ce881a21d298"></a>
##Private Read Only `AppKit.NSButton` AdjustHueCheckbox

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `AdjustHueCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="3f20fc5d-6da3-4e3e-a9f0-b61cfcd732d4"></a>
##Private Read Only `AppKit.NSButton` AdjustOpacityCheckbox

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `AdjustOpacityCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="920b0f88-8397-457d-af9d-a1f13bef55d9"></a>
##Private Read Only `AppKit.NSButton` AdjustSaturationCheckbox

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `AdjustSaturationCheckbox` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="0d2bc1c3-e10b-4eee-9ab9-c5fb6d31a053"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) AlignBottomTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `AlignBottomTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="f1b7e331-7dbe-4f2e-97f3-3fc43882dcdf"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) AlignLeftTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `AlignLeftTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="4972d867-fcc4-46be-a270-debc2b62980e"></a>
##Private Read Only `AppKit.NSSegmentedControl` Alignment

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `Alignment` property of the `KimonoInspectorFont` class has a `AppKit.NSSegmentedControl` value.

---

<a name="dc8c882b-2969-44f5-a280-8bfaa621f4f6"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) AlignRightTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `AlignRightTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="18abf085-2ff9-4bbf-96bf-74288a5fc1f8"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) AlignTopTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `AlignTopTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="ebc4522d-b194-4a03-a191-1553f94f3ea9"></a>
##Private Read Only `AppKit.NSButton` AntialiasCheckbox

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `AntialiasCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="3d277869-5b5d-4147-980a-1c6fd5a86f5b"></a>
##Private Read Only `AppKit.NSButton` AntialiaseCheckbox

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `AntialiaseCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="02bb46e3-c792-4023-98e0-9edc1299d892"></a>
##Private Read Only `AppKit.NSButton` ApplyButton

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private read only `ApplyButton` property of the `KimonoInspectorStyle` class has a `AppKit.NSButton` value.

---

<a name="139425ef-a8d3-4538-8f4c-326f3c948c30"></a>
##Private Read Only [KimonoMac.KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0) ArrowInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ArrowInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorArrow` value.

---

<a name="3b8c86da-218f-47ef-9a66-1efdee4fd37b"></a>
##Private Read Only [KimonoMac.KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262) AttachedStyleInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `AttachedStyleInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorAttachedStyle` value.

---

<a name="d402e176-5001-4526-b1d2-e42ec7dbb33d"></a>
##Private Read Only `AppKit.NSButton` Backbutton

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private read only `Backbutton` property of the `KimonoInspectorStyle` class has a `AppKit.NSButton` value.

---

<a name="55e168d1-e454-4894-89cf-b66c7f18412e"></a>
##Private Read Only `AppKit.NSButton` BackButton

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `BackButton` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="90cbb551-2857-46a4-94a0-1eb0b0685428"></a>
##Private Read Only `AppKit.NSButton` BackButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `BackButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="8950e181-038a-47ed-8b3c-eaaaed856b7d"></a>
##Private Read Only `AppKit.NSPopUpButton` BaseColorSelector

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `BaseColorSelector` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSPopUpButton` value.

---

<a name="b9bdb770-1faf-4c0d-a0ad-7f7db3f329f3"></a>
##Private Read Only `AppKit.NSPopUpButton` BlendMode

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `BlendMode` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="3aa777c7-7fd6-485f-a1a0-7765e396e7cf"></a>
##Private Read Only `AppKit.NSPopUpButton` BlendMode

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `BlendMode` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="c1bb4ca1-0b1a-4887-9631-ba64adcb3eb3"></a>
##Private Read Only `AppKit.NSButton` BlurCheckbox

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `BlurCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="41e5041d-3461-46ae-afb0-9ccadbf37e16"></a>
##Private Read Only `AppKit.NSButton` BlurCheckbox

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `BlurCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="762558d6-345f-47fd-b087-edafc64bca77"></a>
##Private Read Only `AppKit.NSButton` BooleanCheckbox

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The private read only `BooleanCheckbox` property of the `KimonoInspectorGroup` class has a `AppKit.NSButton` value.

---

<a name="ad21d3fb-be47-467b-a46e-65e0fce8b7a3"></a>
##Private Read Only `AppKit.NSSlider` BrightnessSlider

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `BrightnessSlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="22d8e88d-9edd-4b68-963a-473903d06edd"></a>
##Private Read Only `AppKit.NSTextField` BrightnessValue

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `BrightnessValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="c50dc14f-1e8e-499b-ae3d-4909992711be"></a>
##Private Read Only `AppKit.NSColorWell` CanvasColor

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `CanvasColor` property of the `KimonoInspectorSketch` class has a `AppKit.NSColorWell` value.

---

<a name="0e9d6b14-e968-4e0e-ae21-be215eb00d3c"></a>
##Private Read Only `AppKit.NSButton` CanvasColorCheckbox

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `CanvasColorCheckbox` property of the `KimonoInspectorSketch` class has a `AppKit.NSButton` value.

---

<a name="35240f2c-6a2f-438c-81fd-65c02375b498"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) CenterHorizontalTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `CenterHorizontalTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="a816dc9c-5922-4666-8fe5-be2d1f23c89e"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) CenterTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `CenterTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="dbd9eff7-ebf6-4930-8905-45d7ba312773"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) CenterVerticalTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `CenterVerticalTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="6b4ca751-9599-4636-a1a8-8972b1c4662e"></a>
##Private Read Only `AppKit.NSColorWell` Color

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `Color` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSColorWell` value.

---

<a name="d5220edf-09e2-45a5-8dbc-4cb297b42501"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) ColorList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Gets or sets the sidebar color list.
###Return Value

The color list.

---

<a name="e3b0509f-ab53-4e28-b28a-1f8f8fd12489"></a>
##Private Read Only `AppKit.NSTextField` ColorName

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `ColorName` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="a435205a-2814-4c55-8181-44e51b965f84"></a>
##Private Read Only [KimonoMac.KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162) ColorPaletteInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ColorPaletteInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorPaleteColor` value.

---

<a name="55b89353-6012-4ac0-ad05-0b3e3b005b48"></a>
##Private Read Only [KimonoMac.KimonoTextView](#11a4f065-81b1-4138-8e90-61d1bafcb9e4) Contents

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

The private read only `Contents` property of the `KimonoInspectorText` class has a `KimonoMac.KimonoTextView` value.

---

<a name="257c2324-41f5-4a7e-add9-2a1ceef1767c"></a>
##Public Read Only `System.Int32` Count

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets the count.
###Return Value

The count.

---

<a name="7053e766-ee89-4e01-a0b0-0f40a0a07d9e"></a>
##Public Virtual Read Only `System.Object` Current

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets the current.
###Return Value

The current.

---

<a name="6d9d21c5-7e4c-4535-b774-7f5908551774"></a>
##Private Read Only `AppKit.NSButton` Dash1

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash1` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="86e13a9e-a81f-4b79-8103-efaa5c27469f"></a>
##Private Read Only `AppKit.NSButton` Dash10

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash10` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="a1aeda0f-7350-44e0-85a9-156442499bf1"></a>
##Private Read Only `AppKit.NSButton` Dash11

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash11` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="ce243665-e6f4-4544-a2f2-d0dbfbd7d86d"></a>
##Private Read Only `AppKit.NSButton` Dash12

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash12` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="cc3949f4-8448-4785-83c2-d4c873abc686"></a>
##Private Read Only `AppKit.NSButton` Dash13

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash13` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="b98a1d5e-98e2-41a5-9dbe-9082a53e81d1"></a>
##Private Read Only `AppKit.NSButton` Dash14

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash14` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="cf1499d5-72f0-4df1-b4f9-b19eba93ae9b"></a>
##Private Read Only `AppKit.NSButton` Dash15

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash15` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="3680c059-7e79-4b93-a0ed-d26bef796ad2"></a>
##Private Read Only `AppKit.NSButton` Dash16

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash16` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="f5bdc8ec-7f6f-4d08-968d-f53de4cff001"></a>
##Private Read Only `AppKit.NSButton` Dash2

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash2` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="2b582009-850a-42ba-aaf6-693db85e4feb"></a>
##Private Read Only `AppKit.NSButton` Dash3

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash3` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="d1e3afd2-619b-4027-bcfa-8565da28300b"></a>
##Private Read Only `AppKit.NSButton` Dash4

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash4` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="45a25d15-f3ad-4b5d-9192-73f26eea66ab"></a>
##Private Read Only `AppKit.NSButton` Dash5

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash5` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="575c45de-b4d3-4eb5-a50e-ec5f66b59792"></a>
##Private Read Only `AppKit.NSButton` Dash6

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash6` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="f5580f9b-6e11-4e17-bc96-6b6d0255faa6"></a>
##Private Read Only `AppKit.NSButton` Dash7

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash7` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="c5009eb0-b3ea-4a67-ab6c-8bcfc450ee45"></a>
##Private Read Only `AppKit.NSButton` Dash8

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash8` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="0083b522-901e-4580-a508-ec1182cbb69c"></a>
##Private Read Only `AppKit.NSButton` Dash9

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `Dash9` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="621ddb15-c4a2-4f2a-a29f-85570b6d4009"></a>
##Private Read Only `AppKit.NSButton` DashCheckbox

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `DashCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="ed751902-1cf6-4f4c-af5f-a29e1b9abb44"></a>
##Public Read Only [KimonoMac.SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d) Data

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Gets the data.
###Return Value

The data.

---

<a name="39c2868f-fc80-4303-8a49-addbe4487123"></a>
##Private Read Only `AppKit.NSButton` DeleteButton

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private read only `DeleteButton` property of the `KimonoInspectorStyle` class has a `AppKit.NSButton` value.

---

<a name="6571e8fb-ace7-4437-8736-3cd365e1ab77"></a>
##Private Read Only `AppKit.NSButton` DeleteButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `DeleteButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="718ecde4-977e-458b-8311-989c48fdb911"></a>
##Private Read Only `AppKit.NSButton` DeletePointButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `DeletePointButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="34f30f02-e1a8-4ca8-9f9f-085bc5b74c58"></a>
##Private Read Only `AppKit.NSSlider` DepthSlider

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private read only `DepthSlider` property of the `KimonoInspectorStar` class has a `AppKit.NSSlider` value.

---

<a name="d6c84844-6423-44f7-83e1-392ce0896064"></a>
##Private Read Only `AppKit.NSTextField` DepthValue

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private read only `DepthValue` property of the `KimonoInspectorStar` class has a `AppKit.NSTextField` value.

---

<a name="a2a78c24-ba36-4de0-a0e4-4b7101064b69"></a>
##Private Read Only `KimonoCore.Mac.KimonoGradientDesignBar` DesignBar

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `DesignBar` property of the `KimonoInspectorGradient` class has a `KimonoCore.Mac.KimonoGradientDesignBar` value.

---

<a name="d3f0aaf4-7862-493f-85ce-eac57236f184"></a>
##Private Read Only `KimonoCore.Mac.KimonoGradientDesignPreview` DesignPreview

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `DesignPreview` property of the `KimonoInspectorGradient` class has a `KimonoCore.Mac.KimonoGradientDesignPreview` value.

---

<a name="265cf0b6-4a00-4e2e-b4a1-5dc4bc1a54d4"></a>
##Private Read Only `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `DesignSurface` property of the `ViewController` class has a `KimonoCore.Mac.KimonoDesignSurface` value.

---

<a name="c2ef7ad2-a451-40d2-8c89-9ac19dd84fbb"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="e1915c15-8f7b-4d8e-9a02-4813f73744c7"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="f2ec1d53-4ee0-4610-93fe-92ad36f3d96e"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="5221982d-8379-45ba-92c0-c2e29c407a5d"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="6289028f-c2b0-4e8a-bc3c-44360a4abf24"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="fc610313-82b2-4f32-8f42-064f2f9e0c8c"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="f43cb8ff-4982-4bb9-904c-0990910ba74f"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="3a7c8365-a956-44cb-a3c9-4c5367f3d54e"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="d620f443-109b-4ade-a164-3c74e835244f"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="33288ac0-0cfe-4779-a626-0ecbd16262e9"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="9ed9bb51-287e-4130-9dc7-2431e83586cf"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="da9a059d-2466-463e-a6ef-7e973f8a6f2e"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="d77324bb-d3cc-4046-b8dc-f22e8fe958b3"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="4781b301-878c-4bc4-8b00-44c3b462b794"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="f1f4b714-723d-425b-bd1b-89d1aeaeafe6"></a>
##Public `KimonoCore.Mac.KimonoDesignSurface` DesignSurface

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Gets or sets the design surface.
###Return Value

The design surface.

---

<a name="a0c2f60a-6b65-45df-ae12-5366aa74c64d"></a>
##Private Read Only `AppKit.NSSlider` DeviationSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `DeviationSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="21708bc2-c8aa-46fa-bd2a-d1d199c4f5f5"></a>
##Private Read Only `AppKit.NSSlider` DeviationSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `DeviationSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="f034ca32-b93b-4e44-beae-047a8a371008"></a>
##Private Read Only `AppKit.NSTextField` DeviationValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `DeviationValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="7c69ac80-281b-4645-8154-64b3d628cba3"></a>
##Private Read Only `AppKit.NSTextField` DeviationValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `DeviationValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="16e43712-a279-48b6-8087-c8342dd6c5a1"></a>
##Private Read Only `AppKit.NSScrollView` DocumentScrollView

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `DocumentScrollView` property of the `ViewController` class has a `AppKit.NSScrollView` value.

---

<a name="2da6d0da-7415-4c8a-a4e7-9ecf412d0945"></a>
##Private Read Only `AppKit.NSView` DocumentView

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `DocumentView` property of the `ViewController` class has a `AppKit.NSView` value.

---

<a name="3994fa23-21e7-4956-b1fa-6fe95883a7fe"></a>
##Private Read Only `AppKit.NSLayoutConstraint` DocumentViewHeight

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `DocumentViewHeight` property of the `ViewController` class has a `AppKit.NSLayoutConstraint` value.

---

<a name="f934d600-b016-4c51-9ba5-a4cd22b87d42"></a>
##Private Read Only `AppKit.NSLayoutConstraint` DocumentViewWidth

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `DocumentViewWidth` property of the `ViewController` class has a `AppKit.NSLayoutConstraint` value.

---

<a name="54f4e868-2144-4a4f-a7f1-dddaee6091e0"></a>
##Private Read Only `AppKit.NSButton` DuplicateButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `DuplicateButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="751c9ca8-f05b-4a68-99d9-a6b77bdc157f"></a>
##Private Read Only `AppKit.NSButton` DuplicatePointButton

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `DuplicatePointButton` property of the `KimonoInspectorGradient` class has a `AppKit.NSButton` value.

---

<a name="de54d0b0-1ef1-4844-adfe-494878e98e4e"></a>
##Private Read Only `AppKit.NSButton` EditButton

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `EditButton` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSButton` value.

---

<a name="4ecdd2f5-8c48-4e62-aeac-91951c2226f8"></a>
##Private Read Only `AppKit.NSButton` EditButton

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private read only `EditButton` property of the `KimonoInspectorAttachedStyle` class has a `AppKit.NSButton` value.

---

<a name="4cac9490-1969-40c7-8053-ff650dbd3a9b"></a>
##Private Read Only `AppKit.NSPopUpButton` EndCap

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `EndCap` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="518a1daf-771b-4279-a765-03f6cb6efe43"></a>
##Private Read Only `AppKit.NSButton` FillCheckbox

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `FillCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="b31175e6-b44d-44d3-aa5d-17ecff793242"></a>
##Private Read Only `AppKit.NSColorWell` FillColor

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `FillColor` property of the `KimonoInspectorFill` class has a `AppKit.NSColorWell` value.

---

<a name="333554ec-11e8-4646-b0c8-913596f0d696"></a>
##Private Read Only [KimonoMac.KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4) FillInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `FillInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorFill` value.

---

<a name="8591355d-0aef-43eb-b349-e140226c813e"></a>
##Private Read Only [KimonoMac.KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70) FontInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `FontInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorFont` value.

---

<a name="8f9ddd31-9e8e-4352-ab47-7271f1f99b46"></a>
##Private Read Only `AppKit.NSButton` FrameCheckbox

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `FrameCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="6dc0bcd3-278b-48ce-a9db-12abcabec02a"></a>
##Private Read Only `AppKit.NSColorWell` FrameColor

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `FrameColor` property of the `KimonoInspectorFrame` class has a `AppKit.NSColorWell` value.

---

<a name="c68b8cdb-6083-48a1-b5f5-187b4c4e4cb6"></a>
##Private Read Only [KimonoMac.KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239) FrameInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `FrameInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorFrame` value.

---

<a name="0d9d415a-f027-4364-8695-786d472e96ba"></a>
##Private Read Only [KimonoMac.KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775) GeneralInfoInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `GeneralInfoInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorGeneralInfo` value.

---

<a name="6602baf7-5852-47b9-931e-65e9c60589ae"></a>
##Private Read Only `AppKit.NSButton` GoBackButton

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `GoBackButton` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSButton` value.

---

<a name="f61812bd-ebe5-45ea-849b-ee23fea782a1"></a>
##Private Read Only `AppKit.NSPopUpButton` GradientDropdown

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `GradientDropdown` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="bccb5845-67b2-48e0-9ea4-218450065429"></a>
##Private Read Only `AppKit.NSPopUpButton` GradientDropdown

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `GradientDropdown` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="9e681c3c-a78c-4b26-8b2d-b986b533c936"></a>
##Private Read Only [KimonoMac.KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b) GradientInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `GradientInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorGradient` value.

---

<a name="d0be3e68-a34f-4aa0-899e-3e22751ba028"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) GradientList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Gets or sets the gradient list.
###Return Value

The gradient list.

---

<a name="522734b3-a054-492e-a11a-5d3e968628bd"></a>
##Private Read Only `AppKit.NSTextField` GradientName

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `GradientName` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="bb2cf70e-397d-4810-885d-3e2688ccc97f"></a>
##Private Read Only [KimonoMac.KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea) GroupInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `GroupInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorGroup` value.

---

<a name="7148eb7b-22a5-46c5-bf0c-8066b1454736"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) GroupShapes

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `GroupShapes` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="ece068d5-62d5-42ef-b15a-b0716109862d"></a>
##Private Read Only `AppKit.NSButton` GroupUngroupButton

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `GroupUngroupButton` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSButton` value.

---

<a name="95032640-2aa0-4f53-98e9-3433d6d66361"></a>
##Public Read Only `System.Boolean` HasChildren

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets a value indicating whether this instance has children.
###Return Value

`true` if this instance has children; otherwise, `false`.

---

<a name="4e7e449c-49cc-4a66-84e6-5581ea345e2d"></a>
##Private Read Only `AppKit.NSButton` HeadCheckbox

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `HeadCheckbox` property of the `KimonoInspectorArrow` class has a `AppKit.NSButton` value.

---

<a name="d96b4037-d2e4-4c02-a7d4-7026f6206c5a"></a>
##Private Read Only `AppKit.NSSlider` HorizontalBlurSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `HorizontalBlurSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="e6268770-ec7f-4424-a8c4-d06b5aaf3f46"></a>
##Private Read Only `AppKit.NSSlider` HorizontalBlurSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `HorizontalBlurSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="48682bd1-c028-4b82-9c99-e74ecfc0d407"></a>
##Private Read Only `AppKit.NSTextField` HorizontalBlurValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `HorizontalBlurValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="6c9fc52e-2965-4429-9eff-9655ca26b632"></a>
##Private Read Only `AppKit.NSTextField` HorizontalBlurValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `HorizontalBlurValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="f230ac8f-0df0-447e-bf4a-a20c057806a5"></a>
##Private Read Only `AppKit.NSSlider` HorizontalShadowBlurSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `HorizontalShadowBlurSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="6367a91b-f07d-4c0a-b932-4fb09f8e67eb"></a>
##Private Read Only `AppKit.NSSlider` HorizontalShadowBlurSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `HorizontalShadowBlurSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="3c3b31a8-0086-46e1-b183-ec533db38eab"></a>
##Private Read Only `AppKit.NSTextField` HorizontalShadowBlurValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `HorizontalShadowBlurValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="c7eb3712-7f70-4afc-a70e-15f01f15d70d"></a>
##Private Read Only `AppKit.NSTextField` HorizontalShadowBlurValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `HorizontalShadowBlurValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="bc6dd59d-7a29-45a4-b38d-4559566831c8"></a>
##Private Read Only `AppKit.NSSlider` HorizontalShadowOffsetSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `HorizontalShadowOffsetSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="143fe5da-1586-4a56-bf98-a518ffeeacee"></a>
##Private Read Only `AppKit.NSSlider` HorizontalShadowOffsetSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `HorizontalShadowOffsetSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="a9ee0770-cf08-4fa7-9f20-0a89392993f1"></a>
##Private Read Only `AppKit.NSTextField` HorizontalShadowOffsetValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `HorizontalShadowOffsetValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="b123d152-cb33-4eb5-a72a-5f77c831c720"></a>
##Private Read Only `AppKit.NSTextField` HorizontalShadowOffsetValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `HorizontalShadowOffsetValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="f6d29735-b60a-4ba3-ac00-0ab1caff0841"></a>
##Private Read Only `AppKit.NSSlider` HueSlider

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `HueSlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="a8ea57c5-2206-41a0-bf16-d889cb18f552"></a>
##Private Read Only `AppKit.NSTextField` HueValue

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `HueValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="6cb47192-248c-4856-b0f5-c2d51cab8cb2"></a>
##Public `AppKit.NSImage` Icon

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets or sets the icon.
###Return Value

The icon.

---

<a name="7628436f-98ed-41e2-bb74-1a4617dce35e"></a>
##Private Read Only `AppKit.NSSlider` InnerSlider

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `InnerSlider` property of the `KimonoInspectorArrow` class has a `AppKit.NSSlider` value.

---

<a name="93bef69c-28d6-4290-b58a-483fb58fcad8"></a>
##Private Read Only `AppKit.NSTextField` InnerValue

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `InnerValue` property of the `KimonoInspectorArrow` class has a `AppKit.NSTextField` value.

---

<a name="9a9b91ad-fd4c-4451-9e41-80834256dc1c"></a>
##Private Read Only `AppKit.NSScrollView` InspectorScrollView

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `InspectorScrollView` property of the `ViewController` class has a `AppKit.NSScrollView` value.

---

<a name="a37197b8-57ac-4d00-b8f4-06d5ad962abc"></a>
##Private Read Only `AppKit.NSView` InspectorView

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `InspectorView` property of the `ViewController` class has a `AppKit.NSView` value.

---

<a name="8b0eee16-f0cb-488e-a77b-1fd273b572ed"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) Item(System.Int32)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets or sets the `SourceListGroup` at the specified index.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="563504b6-89ea-4795-8b62-d1e65a898567"></a>
<b>System.Int32 index</b></p>

<p>Index.</p>
</td></tr></table></p>


---

<a name="58721db3-75c8-4c99-9da3-89e7225e538b"></a>
##Private Read Only `AppKit.NSButton` JitterCheckbox

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `JitterCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="7f779faf-ce07-4033-b560-0e8d0dc8d467"></a>
##Private Read Only `AppKit.NSButton` JitterCheckbox

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `JitterCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="2d26b12f-e072-4ebd-ab92-44a79ef527d2"></a>
##Private Read Only `AppKit.NSPopUpButton` JoinType

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `JoinType` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="d13f501b-1a5f-4485-9a4c-2c7f8fcb0ce4"></a>
##Private Read Only `AppKit.NSSlider` LengthSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `LengthSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="f27bb190-57f9-40fa-b0c1-e6e7fca42cb7"></a>
##Private Read Only `AppKit.NSSlider` LengthSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `LengthSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="b1760404-e66c-413c-913c-34b3b41f2475"></a>
##Private Read Only `AppKit.NSTextField` LengthValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `LengthValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="083f2015-d7b1-4f9b-be9b-34a660cf31a0"></a>
##Private Read Only `AppKit.NSTextField` LengthValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `LengthValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="e51bdef5-dbf1-4e3a-a15e-f20e53caf8da"></a>
##Private Read Only `AppKit.NSPopUpButton` LinkedColorDropdown

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `LinkedColorDropdown` property of the `KimonoInspectorGradient` class has a `AppKit.NSPopUpButton` value.

---

<a name="699182ce-584f-4c8c-ac04-7f6a647c4f8a"></a>
##Private Read Only `AppKit.NSPopUpButton` LinkedColorSelector

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `LinkedColorSelector` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="ef241b11-187a-4e3a-9ec4-8a3fd4c279ea"></a>
##Private Read Only `AppKit.NSPopUpButton` LinkedColorSelector

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `LinkedColorSelector` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="740252cf-c0fe-4c4d-97a8-fffaf2279fdb"></a>
##Private Read Only `AppKit.NSPopUpButton` LinkedShadowColor

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `LinkedShadowColor` property of the `KimonoInspectorFill` class has a `AppKit.NSPopUpButton` value.

---

<a name="cbf49a1d-5f4f-4dc6-92bc-611494f29402"></a>
##Private Read Only `AppKit.NSPopUpButton` LinkedShadowColor

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `LinkedShadowColor` property of the `KimonoInspectorFrame` class has a `AppKit.NSPopUpButton` value.

---

<a name="974570ad-172e-4b05-ad8f-61823151abb8"></a>
##Public Read Only [KimonoMac.ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc) MainController

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Gets the main controller.
###Return Value

The main controller.

---

<a name="a51f57e0-944c-47cc-a66a-245d11c1fee3"></a>
##Private Read Only `AppKit.NSButton` MaskCheckbox

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The private read only `MaskCheckbox` property of the `KimonoInspectorGroup` class has a `AppKit.NSButton` value.

---

<a name="5052b23a-51ae-4c8e-9c57-36545b9199b1"></a>
##Private Read Only `AppKit.NSSlider` MiterSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `MiterSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="1a6af29f-dc50-40c5-aefc-cf00e39346d8"></a>
##Private Read Only `AppKit.NSTextField` MiterValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `MiterValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="04d66ee3-7631-409c-9a84-236e1193b2f4"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) MoveBackwardsTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `MoveBackwardsTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="6325c3fc-15ff-4711-b76b-7817131471be"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) MoveBottomTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `MoveBottomTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="cb74227f-e108-40cc-9af2-933661e21ef9"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) MoveForwardsTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `MoveForwardsTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="36fd5321-e72b-4c3b-8a1c-a8b64b99dbcb"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) MoveTopTool

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `MoveTopTool` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="6e4d9e14-f649-4a0c-8ec6-9e6c0325b04e"></a>
##Private Read Only `AppKit.NSSlider` OpacitySlider

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="93d5b223-8a71-43f7-ad22-1b417d6cadeb"></a>
##Private Read Only `AppKit.NSSlider` OpacitySlider

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorGradient` class has a `AppKit.NSSlider` value.

---

<a name="f4820ab6-40b6-4514-a5aa-d022dd0e19bb"></a>
##Private Read Only `AppKit.NSSlider` OpacitySlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="b4cfded7-a3b8-44fe-a18c-74f58162ccde"></a>
##Private Read Only `AppKit.NSSlider` OpacitySlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="c25ac713-4e73-4ddc-80e5-8072f8d11389"></a>
##Private Read Only `AppKit.NSSlider` OpacitySlider

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `OpacitySlider` property of the `KimonoInspectorSketch` class has a `AppKit.NSSlider` value.

---

<a name="f3b8df95-4349-49da-90fa-5543d1e3e991"></a>
##Private Read Only `AppKit.NSTextField` OpacityValue

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="aea341c4-b3c4-4dff-bee5-288c33bf0013"></a>
##Private Read Only `AppKit.NSTextField` OpacityValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="d2f9a546-7a8a-4c4f-933c-9f199a769c28"></a>
##Private Read Only `AppKit.NSTextField` OpacityValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="6d872b37-b446-421c-8a88-9e8275edfa2b"></a>
##Private Read Only `AppKit.NSTextField` OpacityValue

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="2755692a-6483-4a2b-9c26-79fce5417bf9"></a>
##Private Read Only `AppKit.NSTextField` OpacityValue

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `OpacityValue` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="a7d08838-bf19-4745-8aa7-7577eed411fc"></a>
##Private Read Only `AppKit.NSPopUpButton` Operation

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The private read only `Operation` property of the `KimonoInspectorGroup` class has a `AppKit.NSPopUpButton` value.

---

<a name="7909b796-d8b2-4ecb-994d-f08af2484966"></a>
##Private Read Only `AppKit.NSSlider` OuterSlider

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `OuterSlider` property of the `KimonoInspectorArrow` class has a `AppKit.NSSlider` value.

---

<a name="df19f284-d80a-4def-b46a-a8ff938fcd19"></a>
##Private Read Only `AppKit.NSTextField` OuterValue

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `OuterValue` property of the `KimonoInspectorArrow` class has a `AppKit.NSTextField` value.

---

<a name="7d78c094-488c-4cae-809d-0c45d4ab9c17"></a>
##Private Read Only `AppKit.NSColorWell` PointColor

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `PointColor` property of the `KimonoInspectorGradient` class has a `AppKit.NSColorWell` value.

---

<a name="d9a7578a-4073-4ab1-87e8-b505273b832d"></a>
##Private Read Only `AppKit.NSSlider` PointsSlider

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private read only `PointsSlider` property of the `KimonoInspectorStar` class has a `AppKit.NSSlider` value.

---

<a name="d7016a10-9f5b-455b-be11-847958031f4b"></a>
##Private Read Only `AppKit.NSTextField` PointsValue

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private read only `PointsValue` property of the `KimonoInspectorStar` class has a `AppKit.NSTextField` value.

---

<a name="5dfe7760-02f6-4118-bccb-6e1fc54c3565"></a>
##Private Read Only [KimonoMac.KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975) PolygonInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `PolygonInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorPolygon` value.

---

<a name="2e87c40d-fb06-4d41-872d-ecee44194f52"></a>
##Public Read Only `KimonoCore.KimonoPortfolio` Portfolio

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Gets the portfolio.
###Return Value

The portfolio.

---

<a name="bedc1a62-27f0-4df7-84cf-f6f16a1756e4"></a>
##Public Read Only `KimonoCore.KimonoPortfolio` Portfolio

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Gets the portfolio.
###Return Value

The portfolio.

---

<a name="4634a080-3c65-4de2-8897-f92c717bf669"></a>
##Public Read Only `KimonoCore.KimonoPortfolio` Portfolio

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Gets the portfolio.
###Return Value

The portfolio.

---

<a name="05ac4f05-107a-4d74-a50b-7ef6a11c49f6"></a>
##Public Read Only `KimonoCore.KimonoPortfolio` Portfolio

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Gets the portfolio.
###Return Value

The portfolio.

---

<a name="23f3674b-d7e8-4971-9a78-724590d6f076"></a>
##Public Read Only `KimonoCore.KimonoPortfolio` Portfolio

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Gets the portfolio.
###Return Value

The portfolio.

---

<a name="74160260-5fc8-456e-975f-4bc2cb03e6a4"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) ProjectList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Gets or sets the sidebar project list.
###Return Value

The project list.

---

<a name="5ced2cd5-1659-400e-b6d7-d9e8884a697a"></a>
##Private Read Only `AppKit.NSSlider` RadiusSlider

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `RadiusSlider` property of the `KimonoInspectorGradient` class has a `AppKit.NSSlider` value.

---

<a name="840d886b-3758-4571-a50f-3ff0ddd1c49b"></a>
##Private Read Only `AppKit.NSSlider` RadiusSlider

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

The private read only `RadiusSlider` property of the `KimonoInspectorRoundRect` class has a `AppKit.NSSlider` value.

---

<a name="96cd3eb4-daee-4219-a6e6-32df8a9aa871"></a>
##Private Read Only `AppKit.NSTextField` RadiusValue

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `RadiusValue` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="c9fd6f92-c0e8-446c-8f99-efa14bb42702"></a>
##Private Read Only `AppKit.NSTextField` RadiusValue

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

The private read only `RadiusValue` property of the `KimonoInspectorRoundRect` class has a `AppKit.NSTextField` value.

---

<a name="65343cc5-204f-4308-90f5-7d9ec54f9018"></a>
##Private Read Only `AppKit.NSSlider` RotationSlider

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `RotationSlider` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSSlider` value.

---

<a name="eeabe786-4dc7-4b15-8b32-d309dba22cbc"></a>
##Private Read Only `AppKit.NSTextField` RotationValue

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `RotationValue` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="537ce53e-b014-4712-9d29-f092f9ee00c2"></a>
##Private Read Only [KimonoMac.KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f) RoundRectInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `RoundRectInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorRoundRect` value.

---

<a name="d9d37a50-ce58-431e-966b-a389099b36be"></a>
##Private Read Only `AppKit.NSSlider` SaturationSlider

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `SaturationSlider` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSSlider` value.

---

<a name="ca3e7176-e8dd-40ff-9c03-0fa1e13e198b"></a>
##Private Read Only `AppKit.NSTextField` SaturationValue

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private read only `SaturationValue` property of the `KimonoInspectorPaleteColor` class has a `AppKit.NSTextField` value.

---

<a name="1bd107ae-f932-4c99-b3f0-ad3c12ff4caf"></a>
##Private Read Only `AppKit.NSSlider` ScaleSlider

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `ScaleSlider` property of the `KimonoInspectorFont` class has a `AppKit.NSSlider` value.

---

<a name="ca5b3221-877a-4107-a04e-cf632f8e71c3"></a>
##Private Read Only `AppKit.NSTextField` ScaleValue

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `ScaleValue` property of the `KimonoInspectorFont` class has a `AppKit.NSTextField` value.

---

<a name="19e96e79-f6fb-45c4-a1b5-58092ddf6dc1"></a>
##Public `KimonoCore.KimonoColor` SelectedColor

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Gets or sets the color of the selected.
###Return Value

The color of the selected.

---

<a name="f2340f2b-6819-491e-8908-bab7262169bf"></a>
##Private Read Only `AppKit.NSTextField` SelectedColorTitle

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `SelectedColorTitle` property of the `KimonoInspectorGradient` class has a `AppKit.NSTextField` value.

---

<a name="427ee58c-7851-4ea0-bfd6-d2083dd646ac"></a>
##Public `KimonoCore.KimonoGradient` SelectedGradient

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Gets or sets the selected gradient.
###Return Value

The selected gradient.

---

<a name="42210762-382f-4ba2-a05e-b5831de790eb"></a>
##Public `KimonoCore.KimonoShapeGroup` SelectedGroup

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Gets or sets the selected group.
###Return Value

The selected group.

---

<a name="401bb4cd-99db-46fb-b423-08c049c45e99"></a>
##Public `KimonoCore.KimonoShapeRoundRect` SelectedRoundRect

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Gets or sets the selected round rectangle.
###Return Value

The selected round rectangle.

---

<a name="699971d2-3f0f-4417-abb3-12095cba54ac"></a>
##Public `KimonoCore.KimonoShapeText` SelectedShape

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="74663f67-611c-4d46-908b-5aee5d0bb0bc"></a>
##Public `KimonoCore.KimonoShapePolygon` SelectedShape

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="ca2315ca-587a-4e14-a2cd-c6d84046994d"></a>
##Public `KimonoCore.KimonoShape` SelectedShape

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="cd4d4e16-f52c-42ce-9ccd-633c5ab5971b"></a>
##Public `KimonoCore.KimonoShapeStar` SelectedShape

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="e78c2923-5065-4beb-960a-21f134742748"></a>
##Public `KimonoCore.KimonoShape` SelectedShape

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="aabd16b5-ba6b-4ac4-8bce-ae70f23eb20d"></a>
##Public `KimonoCore.KimonoShape` SelectedShape

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="18b77b1b-9222-4d23-9794-0697e977ffd9"></a>
##Public `KimonoCore.KimonoShape` SelectedShape

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="69c4d8e0-a0f6-4bf4-8d9f-37f318fba79c"></a>
##Public `KimonoCore.KimonoShape` SelectedShape

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="49391691-1c53-4ea9-9016-ff652ee26cc1"></a>
##Public `KimonoCore.KimonoShape` SelectedShape

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="e8ad04e7-8c6e-4ef7-a10e-de14e8d0a83d"></a>
##Public `KimonoCore.KimonoShapeArrow` SelectedShape

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Gets or sets the selected shape.
###Return Value

The selected shape.

---

<a name="d43b995a-1253-4156-a8bd-7fd1da061ff6"></a>
##Public `KimonoCore.KimonoSketch` SelectedSketch

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Gets or sets the selected sketch.
###Return Value

The selected sketch.

---

<a name="b8c61467-0691-40c1-90e1-94fa5945b0ea"></a>
##Public `KimonoCore.KimonoStyle` SelectedStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Gets or sets the selected style.
###Return Value

The selected style.

---

<a name="64e13514-9de7-40b8-be67-672e1811f8ba"></a>
##Public `KimonoCore.KimonoStyle` SelectedStyle

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Gets or sets the selected style.
###Return Value

The selected style.

---

<a name="9d61578f-2019-42ec-b558-ba04140da24f"></a>
##Public `KimonoCore.KimonoStyle` SelectedStyle

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Gets or sets the selected style.
###Return Value

The selected style.

---

<a name="36654f89-2ca0-456c-b3d0-49601abc8fc6"></a>
##Public `KimonoCore.KimonoStyle` SelectedStyle

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Gets or sets the selected style.
###Return Value

The selected style.

---

<a name="a68465dc-22e7-4080-be8a-343e5268b8a3"></a>
##Public `KimonoCore.KimonoStyle` SelectedStyle

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Gets or sets the selected style.
###Return Value

The selected style.

---

<a name="135372f7-2a0f-4833-b5fe-7c42423e6129"></a>
##Private Read Only `AppKit.NSButton` ShadowCheckbox

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `ShadowCheckbox` property of the `KimonoInspectorFrame` class has a `AppKit.NSButton` value.

---

<a name="95f00b46-c36c-4568-a5de-3d01739f4dba"></a>
##Private Read Only `AppKit.NSButton` ShadowCheckbox

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `ShadowCheckbox` property of the `KimonoInspectorFill` class has a `AppKit.NSButton` value.

---

<a name="52904d35-e3a6-4657-a821-56a5987c6c60"></a>
##Private Read Only `AppKit.NSColorWell` ShadowColor

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `ShadowColor` property of the `KimonoInspectorFrame` class has a `AppKit.NSColorWell` value.

---

<a name="950449c6-2ed3-49f3-b6a7-791151821776"></a>
##Private Read Only `AppKit.NSColorWell` ShadowColor

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `ShadowColor` property of the `KimonoInspectorFill` class has a `AppKit.NSColorWell` value.

---

<a name="18e304a0-9334-4047-a53e-caed8e4b25dd"></a>
##Private Read Only `AppKit.NSSlider` ShadowOpacitySlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `ShadowOpacitySlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="c6ea9c10-85fa-4f81-aed0-8aa913caadac"></a>
##Private Read Only `AppKit.NSSlider` ShadowOpacitySlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `ShadowOpacitySlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="ed2d4236-59dd-434e-b3b1-8358d07f3289"></a>
##Private Read Only `AppKit.NSTextField` ShadowOpacityValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `ShadowOpacityValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="c5f2b312-1177-4e19-a1f2-254fad4e043f"></a>
##Private Read Only `AppKit.NSTextField` ShadowOpacityValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `ShadowOpacityValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="add385ba-c5e1-476f-bb21-f51c409662d6"></a>
##Private Read Only `AppKit.NSTextField` ShapeHeight

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `ShapeHeight` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="fde4da1e-2d18-4fa8-8852-77d4c79873e5"></a>
##Private Read Only `AppKit.NSTextField` ShapeName

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `ShapeName` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="b058af1f-3a66-4cad-ac6c-cd323329de82"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) ShapesList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Gets or sets the sidebar shapes list.
###Return Value

The shapes list.

---

<a name="23c038d3-b45e-435e-9b9b-697ceef2bfb8"></a>
##Private Read Only `AppKit.NSTextField` ShapeType

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `ShapeType` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="36c14aa4-e4d6-49ae-8f6e-b9fad5e90831"></a>
##Private Read Only `AppKit.NSTextField` ShapeWidth

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `ShapeWidth` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="9b2c06ab-5ab9-47ab-88da-293f4d17ab7e"></a>
##Private Read Only `AppKit.NSTextField` ShapeX

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `ShapeX` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="975bafff-819e-43c9-992a-28912f94da2b"></a>
##Private Read Only `AppKit.NSTextField` ShapeY

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `ShapeY` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSTextField` value.

---

<a name="21d025c9-2e7e-4c25-9337-4e207d99ddfa"></a>
##Private Read Only `AppKit.NSSlider` SidesSlider

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

The private read only `SidesSlider` property of the `KimonoInspectorPolygon` class has a `AppKit.NSSlider` value.

---

<a name="4d2dc103-78c2-4dff-9433-1da06af4a464"></a>
##Private Read Only `AppKit.NSTextField` SidesValue

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

The private read only `SidesValue` property of the `KimonoInspectorPolygon` class has a `AppKit.NSTextField` value.

---

<a name="04c609f1-626d-45e2-9e9d-85603455a9fe"></a>
##Private Read Only `AppKit.NSComboBox` Size

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `Size` property of the `KimonoInspectorFont` class has a `AppKit.NSComboBox` value.

---

<a name="bdbc9d0d-a841-4037-af07-804e2e01386f"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) SketchesList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Gets or sets the sidebar sketches list.
###Return Value

The sketches list.

---

<a name="483fe7a1-5ffa-4ea4-b0f1-d2865440256a"></a>
##Private Read Only `AppKit.NSTextField` SketchHeight

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `SketchHeight` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="8f5567c9-33ba-4c16-b318-fba2f761506d"></a>
##Private Read Only [KimonoMac.KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59) SketchInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `SketchInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorSketch` value.

---

<a name="12e4691d-f44a-4dd0-859e-de5469846ffa"></a>
##Private Read Only `AppKit.NSTextField` SketchName

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `SketchName` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="12149a66-758e-4946-9061-1f7ed1000eac"></a>
##Private Read Only `AppKit.NSTextField` SketchPath

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `SketchPath` property of the `ViewController` class has a `AppKit.NSTextField` value.

---

<a name="19cc2ece-2b82-402f-b9f3-7d0601ec71b7"></a>
##Private Read Only `AppKit.NSTextField` SketchWidth

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private read only `SketchWidth` property of the `KimonoInspectorSketch` class has a `AppKit.NSTextField` value.

---

<a name="70eab1a8-5bfe-4522-8e6e-6bb39c1b3596"></a>
##Private Read Only `AppKit.NSSlider` SkewSlider

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `SkewSlider` property of the `KimonoInspectorFont` class has a `AppKit.NSSlider` value.

---

<a name="3937ebb8-05dc-4f35-b7e0-b52470b6b391"></a>
##Private Read Only `AppKit.NSTextField` SkewValue

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `SkewValue` property of the `KimonoInspectorFont` class has a `AppKit.NSTextField` value.

---

<a name="767182d7-f230-4a20-bd01-221e163ce0c5"></a>
##Private Read Only `AppKit.NSSlider` SkipSlider

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private read only `SkipSlider` property of the `KimonoInspectorStar` class has a `AppKit.NSSlider` value.

---

<a name="77ed4bb0-4e0e-44e9-a9d4-b906f7f5ecfd"></a>
##Private Read Only `AppKit.NSTextField` SkipValue

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private read only `SkipValue` property of the `KimonoInspectorStar` class has a `AppKit.NSTextField` value.

---

<a name="db064f6b-e295-4757-9db0-a2653f01f23d"></a>
##Private Read Only [KimonoMac.SourceListView](#beadeded-5081-43aa-bf9a-5df81248d624) SourceList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `SourceList` property of the `ViewController` class has a `KimonoMac.SourceListView` value.

---

<a name="3d82eaa6-0c82-4b15-838e-e1b19f06ea55"></a>
##Private Read Only [KimonoMac.KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928) StarInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `StarInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorStar` value.

---

<a name="4ea283b7-9914-42bb-8262-0c354bd6838b"></a>
##Private Read Only `AppKit.NSButton` StreamlinedCheckbox

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `StreamlinedCheckbox` property of the `KimonoInspectorArrow` class has a `AppKit.NSButton` value.

---

<a name="ef9e3d74-937c-44fb-921e-2963611ec845"></a>
##Private Read Only `AppKit.NSButton` StrikeThruCheckbox

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `StrikeThruCheckbox` property of the `KimonoInspectorFont` class has a `AppKit.NSButton` value.

---

<a name="2e6aa787-7c9c-4a82-a021-94119e394fb8"></a>
##Private Read Only [KimonoMac.KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c) StyleInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `StyleInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorStyle` value.

---

<a name="c53bb142-9f15-4b8c-bfc7-e7eba1138d32"></a>
##Public [KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) StyleList

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Gets or sets the sidebar style list.
###Return Value

The style list.

---

<a name="e08276ea-a3a0-43b7-93b5-c2f800c0ab06"></a>
##Private Read Only `AppKit.NSTextField` StyleName

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private read only `StyleName` property of the `KimonoInspectorStyle` class has a `AppKit.NSTextField` value.

---

<a name="ab67efaa-95ef-407e-a124-67f7d4d2f2b4"></a>
##Private Read Only `AppKit.NSPopUpButton` StyleSelector

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private read only `StyleSelector` property of the `KimonoInspectorAttachedStyle` class has a `AppKit.NSPopUpButton` value.

---

<a name="72f197a7-99a1-431d-a6d0-cc2a03899044"></a>
##Public `System.String` Tag

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets or sets the tag.
###Return Value

The tag.

---

<a name="77f16d54-a28a-4bd2-a1e2-0ebb5f8cc673"></a>
##Private Read Only `AppKit.NSButton` TailCheckbox

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private read only `TailCheckbox` property of the `KimonoInspectorArrow` class has a `AppKit.NSButton` value.

---

<a name="e93f3643-ead8-4fbf-8ecf-54fc4236bf32"></a>
##Private Read Only [KimonoMac.KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71) TextInspector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `TextInspector` property of the `ViewController` class has a `KimonoMac.KimonoInspectorText` value.

---

<a name="6a2e4849-99bc-48a2-a985-1119c3f1fd79"></a>
##Private Read Only `AppKit.NSPopUpButton` TileDropdown

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `TileDropdown` property of the `KimonoInspectorGradient` class has a `AppKit.NSPopUpButton` value.

---

<a name="f133a7be-4f0a-47a1-b6f7-9ebc4aadb43e"></a>
##Public `System.String` Title

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets or sets the title.
###Return Value

The title.

---

<a name="78a1831f-86a2-48a4-be50-0318acf327d8"></a>
##Private Read Only `AppKit.NSButton` ToolArrow

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolArrow` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="b37447c5-bcae-4633-a6a2-d8a14930eea0"></a>
##Private Read Only `AppKit.NSButtonCell` ToolBezier

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolBezier` property of the `ViewController` class has a `AppKit.NSButtonCell` value.

---

<a name="1a3d16d8-88cd-4580-821c-1da503069b4e"></a>
##Private Read Only `AppKit.NSButtonCell` ToolCursor

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolCursor` property of the `ViewController` class has a `AppKit.NSButtonCell` value.

---

<a name="9133b98b-5fe9-4bf8-89df-4d0b7bcea7f4"></a>
##Private Read Only `AppKit.NSButton` ToolLine

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolLine` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="97029ec0-25c1-4216-a5b6-4dde2e353b30"></a>
##Private Read Only `AppKit.NSButton` ToolOval

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolOval` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="cc2a3fc9-8661-46f9-8838-1ec06a6c7e9c"></a>
##Private Read Only `AppKit.NSButton` ToolPolygon

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolPolygon` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="0e5e08f5-74c9-4c5f-8356-d56fa942a760"></a>
##Private Read Only `AppKit.NSButton` ToolRect

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolRect` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="4c753b97-c557-4724-9969-bf9fc88cac32"></a>
##Private Read Only `AppKit.NSButton` ToolRoundRect

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolRoundRect` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="25273c6e-0561-4b17-97c1-f4b78e993002"></a>
##Private Read Only `AppKit.NSButton` ToolStar

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolStar` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="785f6670-a5e1-4e2e-87e0-eead3aa93350"></a>
##Private Read Only `AppKit.NSButton` ToolText

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolText` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="fb631388-15cd-4189-ab53-17e824ee27e0"></a>
##Private Read Only `AppKit.NSButton` ToolTriangle

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolTriangle` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="a613e30c-ae3a-4616-9ef1-f35e70984e5a"></a>
##Private Read Only `AppKit.NSButton` ToolVector

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private read only `ToolVector` property of the `ViewController` class has a `AppKit.NSButton` value.

---

<a name="d0ba6d05-afbf-47a3-bc67-6eda3f404789"></a>
##Private Read Only `AppKit.NSPopUpButton` TypeDropdown

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private read only `TypeDropdown` property of the `KimonoInspectorGradient` class has a `AppKit.NSPopUpButton` value.

---

<a name="aa45ed68-81f6-4fe9-9fba-7419ac1b3e61"></a>
##Private Read Only `AppKit.NSPopUpButton` TypeDropdown

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private read only `TypeDropdown` property of the `KimonoInspectorStyle` class has a `AppKit.NSPopUpButton` value.

---

<a name="d333668f-0ab6-46e1-9523-4c14a32b2ee3"></a>
##Private Read Only `AppKit.NSPopUpButton` TypefaceDropdown

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `TypefaceDropdown` property of the `KimonoInspectorFont` class has a `AppKit.NSPopUpButton` value.

---

<a name="6e423217-37b7-48a7-af13-0245986ec377"></a>
##Private Read Only `AppKit.NSButton` UnderlineCheckbox

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `UnderlineCheckbox` property of the `KimonoInspectorFont` class has a `AppKit.NSButton` value.

---

<a name="8f95fcd1-d8f2-4066-b9ac-91fac390070f"></a>
##Private Read Only [KimonoMac.ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) UngroupShapes

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private read only `UngroupShapes` property of the `MainWindowController` class has a `KimonoMac.ActivatableItem` value.

---

<a name="f59b2e9c-e185-4da8-99f1-88ed0280d8eb"></a>
##Private Read Only `AppKit.NSSlider` VerticalBlurSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `VerticalBlurSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="229e9bb1-83b5-4b0b-8b39-8afdee6201a2"></a>
##Private Read Only `AppKit.NSSlider` VerticalBlurSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `VerticalBlurSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="8bc5f1e4-1c1d-4d21-a52b-266d7bd3dcc1"></a>
##Private Read Only `AppKit.NSTextField` VerticalBlurValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `VerticalBlurValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="d8798eae-6ed5-4c0f-a241-6dfa800b95e6"></a>
##Private Read Only `AppKit.NSTextField` VerticalBlurValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `VerticalBlurValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="a010ccf8-aac7-47bd-a53f-0c049b32e367"></a>
##Private Read Only `AppKit.NSButton` VerticalCheckbox

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `VerticalCheckbox` property of the `KimonoInspectorFont` class has a `AppKit.NSButton` value.

---

<a name="d7c3213a-ac34-4255-ba30-39d83ba3d7e7"></a>
##Private Read Only `AppKit.NSSlider` VerticalShadowBlurSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `VerticalShadowBlurSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="b1688672-f35e-443d-8624-06db2a90e7ca"></a>
##Private Read Only `AppKit.NSSlider` VerticalShadowBlurSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `VerticalShadowBlurSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="7ab7671c-71a1-4af0-8a53-907e1a82e81f"></a>
##Private Read Only `AppKit.NSTextField` VerticalShadowBlurValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `VerticalShadowBlurValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="8cf2d8e2-5211-4a11-9a64-a1c01bfc8d1c"></a>
##Private Read Only `AppKit.NSTextField` VerticalShadowBlurValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `VerticalShadowBlurValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="e258cf91-35b6-484b-86ae-5f9f0b8f40a6"></a>
##Private Read Only `AppKit.NSSlider` VerticalShadowOffsetSlider

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `VerticalShadowOffsetSlider` property of the `KimonoInspectorFill` class has a `AppKit.NSSlider` value.

---

<a name="8b92560d-87b4-4d8d-977c-7e09112819b6"></a>
##Private Read Only `AppKit.NSSlider` VerticalShadowOffsetSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `VerticalShadowOffsetSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="c414a064-0e0a-431a-8957-11192d581cb7"></a>
##Private Read Only `AppKit.NSTextField` VerticalShadowOffsetValue

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private read only `VerticalShadowOffsetValue` property of the `KimonoInspectorFill` class has a `AppKit.NSTextField` value.

---

<a name="f9d490b2-aa1e-429c-85d0-1f4cd205103b"></a>
##Private Read Only `AppKit.NSTextField` VerticalShadowOffsetValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `VerticalShadowOffsetValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.

---

<a name="6e617ed7-e560-4780-9e24-eb2ce4260d92"></a>
##Private Read Only `AppKit.NSButton` VisibleButton

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private read only `VisibleButton` property of the `KimonoInspectorGeneralInfo` class has a `AppKit.NSButton` value.

---

<a name="28d775e1-8f68-4866-b0f4-2508cd9c65f1"></a>
##Private Read Only `AppKit.NSPopUpButton` WeightDropdown

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private read only `WeightDropdown` property of the `KimonoInspectorFont` class has a `AppKit.NSPopUpButton` value.

---

<a name="5ba13164-d412-4acc-8e7e-b1b6c2646545"></a>
##Private Read Only `AppKit.NSSlider` WidthSlider

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `WidthSlider` property of the `KimonoInspectorFrame` class has a `AppKit.NSSlider` value.

---

<a name="431e0ecc-c373-40b1-a66a-eb2e6eda3c5c"></a>
##Private Read Only `AppKit.NSTextField` WidthValue

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private read only `WidthValue` property of the `KimonoInspectorFrame` class has a `AppKit.NSTextField` value.
<a name="Methods"></a>
#Methods


---

<a name="c221ebf9-4d44-4f2f-9e20-990ff6197b2d"></a>
##Public Void ActivatableItem ()

###Constructor for Type

[ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600)

###Summary

Initializes a new instance of the [ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) class.

---

<a name="b5567a0f-c68f-4704-9214-b53977b810c3"></a>
##Public Void ActivatableItem (Foundation.NSObjectFlag)

###Constructor for Type

[ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600)

###Summary

Initializes a new instance of the [ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>t</td><td style='width:75%' ><p><a name="4a2d1d74-8a96-48a6-a1c8-16dd33a7aa3f"></a>
<b>Foundation.NSObjectFlag t</b></p>

<p>T.</p>
</td></tr></table></p>


---

<a name="76f7c1fb-f6ea-45c8-aa53-fa21c1f30a91"></a>
##Public Void ActivatableItem (System.IntPtr)

###Constructor for Type

[ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600)

###Summary

Initializes a new instance of the [ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="8f83949e-9866-42b1-a80d-c2c6a1f7bf4b"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="1a9b3f3a-bb52-4b46-a2c7-e4ebc2955d08"></a>
##Public Void ActivatableItem (System.String)

###Constructor for Type

[ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600)

###Summary

Initializes a new instance of the [ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="4a0dcb9a-6981-4f39-a424-60887cc2ff47"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr></table></p>


---

<a name="c1f558b9-c392-46c5-a648-649e1015f0ab"></a>
##Private Void AddColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Adds the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="80014d57-cd0e-4d80-9064-7e45e2f5b1fa"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="36533599-edbe-40f7-8bb9-42742ec44e5a"></a>
##Private Void AddColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Adds the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="073268e0-c087-4d48-9010-1d09cffa8b04"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="55a1b7b4-3017-4221-84e0-ca9e0ce7afcc"></a>
##Private Void AddColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Adds the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="36ea7bf4-6ae0-4c64-b44f-0b7f48c93752"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="03fcc951-0a25-4a61-b8e1-301809ee0ac4"></a>
##Public Void AddColor (Foundation.NSObject)

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Adds the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e0609455-050b-45d1-9e0a-b2ec3712cb1c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="fb26af53-71e2-4bd5-8e9b-af750a84a8f2"></a>
##Public Void AddGradient (Foundation.NSObject)

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Adds the gradient.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f0cce5be-b7ba-41db-aa9e-70133fe24e30"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="53ea5645-4646-4f98-9553-d9296d83fb51"></a>
##Public Void AddItem (KimonoMac.SourceListItem)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="c72a15b3-9658-42f0-a915-fcd4514c5358"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>


---

<a name="5a0ac51a-65bf-48c6-9fd4-91651702a4bb"></a>
##Public Void AddItem (KimonoMac.SourceListItem)

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="cb385133-225d-4c18-a952-bee31ac8e0b3"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>


---

<a name="e791763e-2d20-4c6b-a8f5-4102949550e2"></a>
##Public Void AddItem (System.String)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="33984797-e913-43aa-8447-9103e9887d5e"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr></table></p>


---

<a name="ab5671ab-96c3-4904-b48f-d2cce0ff90fc"></a>
##Public Void AddItem (System.String, AppKit.NSImage)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="becd895c-0a89-42b2-8a16-46029c1f5081"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="0a26f156-bb22-4271-bf09-527d976691fd"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr></table></p>


---

<a name="a8313e85-be87-4368-ae72-5986095a784d"></a>
##Public Void AddItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="056fa30c-de83-4acc-aa30-99ed2eb03ccd"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="5b6d6654-909e-455d-9ec2-fef0701769a3"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p><a name="19090032-d697-415f-b049-f573b1539053"></a>
<b>KimonoMac.SourceListItem.ClickedDelegate clicked</b></p>

<p>Clicked.</p>
</td></tr></table></p>


---

<a name="1d959c8b-a275-478f-be5c-65ea4ba646a4"></a>
##Public Void AddItem (System.String, AppKit.NSImage, System.String)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="209d6983-ecda-4114-a208-ee6c0ed158fc"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="29b4d072-3952-402d-a544-38d5966c03b4"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p><a name="6776d007-9707-4542-8076-5938c0544532"></a>
<b>System.String tag</b></p>

<p>Tag.</p>
</td></tr></table></p>


---

<a name="d46d274e-2b07-466b-bbd1-f7f5c30cf3bd"></a>
##Public Void AddItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="93edbbb5-e208-4680-b2a7-9d4223697299"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="e7dda6e2-ac49-4b43-897b-37437243816e"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p><a name="814d5c56-3921-48f8-b903-21229d7e1771"></a>
<b>System.String tag</b></p>

<p>Tag.</p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' class='def'><p><a name="6539f91e-328f-4f7f-bd78-2c2db7d5cf7d"></a>
<b>KimonoMac.SourceListItem.ClickedDelegate clicked</b></p>

<p>Clicked.</p>
</td></tr></table></p>


---

<a name="9d8cc8b1-2fc4-4bf2-8f91-7e5a277605fa"></a>
##Public Void AddItem (System.String, System.String)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="e7769d22-7eef-4579-9f92-e9e88c666702"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="c916eef8-295a-49fe-a59c-782c96f4d696"></a>
<b>System.String icon</b></p>

<p>Icon.</p>
</td></tr></table></p>


---

<a name="6b22ef3a-2566-4ece-9907-5c359716bfbd"></a>
##Public Void AddItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Adds the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="768122e6-b379-4465-aa06-ce2af10c02bd"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="fe06a3f5-ade0-4df8-83ca-133382eed5ae"></a>
<b>System.String icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p><a name="6d504843-9955-4e44-bac2-0a7b65913ff7"></a>
<b>KimonoMac.SourceListItem.ClickedDelegate clicked</b></p>

<p>Clicked.</p>
</td></tr></table></p>


---

<a name="c9ef3160-32c4-4c03-bdfb-6426463454f3"></a>
##Public Void AddNewColor ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Adds a new `KimonoSketch` to the `KimonoPortfolio`.

---

<a name="8eee5d46-1d72-412c-97bc-0bf02e735b27"></a>
##Public Void AddNewColor (SkiaSharp.SKColor)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Adds a new `KimonoColor` based off of the given `SKColor` to the `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="f6961ebe-824e-422c-b94c-a832274c828c"></a>
<b>SkiaSharp.SKColor baseColor</b></p>

<p>The base <code>SKColor</code>.</p>
</td></tr></table></p>


---

<a name="261752d7-3f77-46de-9af7-7b531a02bf97"></a>
##Public Void AddNewGradient ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Adds the new gradient.

---

<a name="d2b9952b-3af5-45ad-b413-0138c77fe79f"></a>
##Public Void AddNewSketch ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Adds a new `KimonoSketch` to the `KimonoPortfolio`.

---

<a name="cbde146b-85b2-4192-aff2-079698a258ce"></a>
##Public Void AddNewStyle ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Adds a new `KimonoStyle` to the `KimonoPortfolio`.

---

<a name="c32a7d98-f587-4446-8abf-73731da73634"></a>
##Private Void AddPoint (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Adds the point.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e247b3b3-ed74-44b2-ab21-468318d9a97f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3a08f275-c045-4123-913b-84ebc4512ea8"></a>
##Public Void AddSketch (Foundation.NSObject)

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Adds the sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a35811d6-69d2-4bc3-9f41-7473d95eea8b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8adb8adf-0ef8-4543-8c91-f45fd849b7e3"></a>
##Public Void AddStyle (Foundation.NSObject)

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Adds the style.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="56b27696-97c1-4fc9-ab14-57a27b5944b2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="fb69ac06-ab5b-4699-8be5-ccf484628f2c"></a>
##Private Void AdjustBrightnessChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Adjusts the brightness changed.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1998ec80-d2da-492e-9149-23e2efb9d9f9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="80b68dfd-1c32-488f-bd9b-787dc09a6e94"></a>
##Private Void AdjustHueChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Adjusts the hue changed.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6e9052e3-f309-435f-83b0-2cce2f447542"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="4fee2913-5640-4967-bca8-d700c2c79eac"></a>
##Private Void AdjustOpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Adjusts the opacity changed.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2b149ad2-62f0-4ce0-a0f2-d3adffb4935f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="92e5d963-0dfb-45f1-b63c-65f88f0cdd84"></a>
##Private Void AdjustSaturationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Adjusts the saturation changed.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2e6290b0-b62e-40bb-8191-dd1a4e633de7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="b14590d2-2399-4015-bcff-c8f1c4df6088"></a>
##Private Void AlignmentChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the alignmen changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9fb97055-59b3-40d8-8d03-a7e81ca71e26"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="46f2a2c6-11e0-47e3-9e3e-ae55a322983f"></a>
##Public Void AlignShapeBottom (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape bottoms.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9cbe3b90-a5e9-4951-893f-476c85ee2ee4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="23b379a4-7538-4356-8ae9-690c7d4059ba"></a>
##Public Void AlignShapeCenter (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape centers.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="310738a0-dd36-4a92-97c8-551d0fa4ecd1"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="96b6a5e2-03fa-4bb0-84c3-3460a68c905b"></a>
##Public Void AlignShapeCenterHorizontal (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape centers horizontally.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9e49ca5c-84a6-49cd-9162-85501d795b9a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="7392e52b-6d80-42b8-a8d9-cb9e1d0d1cfa"></a>
##Public Void AlignShapeCenterVertical (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape centers vertically.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f0126e47-7de3-4a94-9000-796ee3e08420"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0ecaf28c-d69b-44b4-b028-c4bb4b84d5ba"></a>
##Public Void AlignShapeLeft (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape left sides.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="064b20f2-8cbc-4793-b1b2-9671b17e3c38"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="1f7e20de-f8b5-4e8f-a595-36a8da527653"></a>
##Public Void AlignShapeRight (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape right sides.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5102b5c7-09f1-47ae-96f4-70cd5e9d184c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0e6b246f-dd56-44fc-b6b5-49f8d5e6d746"></a>
##Public Void AlignShapeTop (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Aligns the shape tops.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2d42d775-ed1c-4d31-8d06-784c9b5a550d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="fb8af19c-3c20-4ae8-b696-5c57d58bc107"></a>
##Private Void AntialiasChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the antialias changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ef72d02b-5004-4118-bf7b-c7db2b599214"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="a8693bb6-ba2d-4133-be10-acf2d8355e49"></a>
##Private Void AntialiaseChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the antialias value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="bfe0189f-480e-47c4-b0f7-863d43964b90"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="bcce0027-ab09-4367-a5c3-b82d4b99d482"></a>
##Public Void AppDelegate ()

###Constructor for Type

[AppDelegate](#b4a5fd3a-500e-4d49-a5be-aac2002d9a82)

###Summary

Initializes a new instance of the [AppDelegate](#b4a5fd3a-500e-4d49-a5be-aac2002d9a82) class.

---

<a name="5d086961-3acf-4461-a099-498de71d3a54"></a>
##Private Void ApplyChange (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Applies the change to the currently selected `KimonShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="707bf621-6420-4005-b38c-aba4148bb8ae"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="d2fdbe9c-1ac1-4a07-ae5e-f936bb80ff4b"></a>
##Public Virtual Void AwakeFromNib ()

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

The public virtual `AwakeFromNib ()` member of the `SourceListView` class.

---

<a name="e3025a0b-3038-4fb3-b3f4-449320b26792"></a>
##Private Void BaseColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the base color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="609aa29b-1ca3-453a-ab3f-ff0cfc7862ca"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="94778152-77a0-4121-a38e-e0d7f14254f7"></a>
##Private Void BlendModeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the blend mode changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b8d6af8d-4c46-4b28-941b-99664aff5061"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="902e13bb-a0b3-484c-9193-fd79235dbae3"></a>
##Private Void BlendModeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the blend mode changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2d8f730d-93e0-4090-8c6c-67c6a8a5b726"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0cfc3172-8545-4b95-a156-2df309d56e7d"></a>
##Private Void BlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the blur effect changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="23d22184-9bfd-41cd-bf36-c99f625e9b3d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="a7b7ebb5-b8e2-4ad1-9855-6ebed3a1076b"></a>
##Private Void BlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the blur effect changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8d012625-0468-4bad-864e-843204e751e1"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="35a7e370-6663-4d2a-8c7b-0058ce2f0ac8"></a>
##Private Void BooleanChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Handles the boolean operation being changed.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4c817f4a-47e0-4643-a8c9-8996f427a71a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="4565ce52-408f-4978-bd58-a67266ad63e1"></a>
##Private Void BrightnessChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the brightness chanigng.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4e7fcd45-b70a-48a7-9138-3127b072cb1c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="33af043f-b8b5-4b44-ae85-4185c1335e95"></a>
##Private Void CanvasColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Handles the canvas color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="00a02c61-6ab9-4bd8-99a7-e074ca97b37d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c886de3f-186e-408f-b5db-150311f4dff0"></a>
##Public Void CenteringClipView ()

###Constructor for Type

[CenteringClipView](#4dcbb271-b786-4581-94ef-25b12aaca68d)

###Summary

Initializes a new instance of the [CenteringClipView](#4dcbb271-b786-4581-94ef-25b12aaca68d) class.

---

<a name="30825a5f-0b15-4dcb-b0b8-da15ee5a25a9"></a>
##Public Void CenteringClipView (System.IntPtr)

###Constructor for Type

[CenteringClipView](#4dcbb271-b786-4581-94ef-25b12aaca68d)

###Summary

Initializes a new instance of the [CenteringClipView](#4dcbb271-b786-4581-94ef-25b12aaca68d) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="89a7cb8c-7257-40d2-bff8-0820e0dfede5"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="6cbf5d7e-f38b-487a-a8c3-228c8e98c8a0"></a>
##Public Void Clear ()

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Clear this instance.

---

<a name="98f2a2f7-9fe7-49b6-90ce-1d8344bbcd7f"></a>
##Private Void CloseAllInspectors ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Closes all open inspectors.

---

<a name="15bb806c-e8a9-4799-867a-ed5d37d35517"></a>
##Private Void ColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5bb01fdd-aace-4f05-ad92-52cd032103de"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8ad92054-a9b3-40fe-8e6f-4e102d2f4a3e"></a>
##Private Void ColorNameChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the color name changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a53f5a37-1d0c-4926-bb65-5149c6cbaf20"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="e2848da1-31b9-4c54-9ab3-2795b21bfc9e"></a>
##Public Virtual `CoreGraphics.CGRect` ConstrainBoundsRect (CoreGraphics.CGRect)

###Member of Type

[CenteringClipView](#4dcbb271-b786-4581-94ef-25b12aaca68d)

###Summary

Constrains the bounds rect.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>proposedBounds</td><td style='width:75%' ><p><a name="673f7364-864c-4f28-ad36-f6e759897f22"></a>
<b>CoreGraphics.CGRect proposedBounds</b></p>

<p>Proposed bounds.</p>
</td></tr></table></p>

###Returns

The bounds rect.

---

<a name="d4dba180-9d42-4d6c-9b4c-2f956b8d33be"></a>
##Private `AppKit.NSEdgeInsets` ConvertContentInsetsToProposedBoundsSize (CoreGraphics.CGSize)

###Member of Type

[CenteringClipView](#4dcbb271-b786-4581-94ef-25b12aaca68d)

###Summary

Converts the size of the content insets to proposed bounds.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>proposedBoundsSize</td><td style='width:75%' ><p><a name="5ae4e5d3-caa8-4f69-acbb-b453829ab771"></a>
<b>CoreGraphics.CGSize proposedBoundsSize</b></p>

<p>Proposed bounds size.</p>
</td></tr></table></p>

###Returns

The content insets to proposed bounds size.

---

<a name="9d50d2b1-f864-4841-b57a-1eb26abedef6"></a>
##Private Void Dash10Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="92ded0d9-6ef0-49ec-9c4a-f11ffe2e37b7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c9e654c9-6e08-49c2-bd1b-2c25b14b7e57"></a>
##Private Void Dash11Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="93682085-707b-480d-a4be-990ac1a0a49a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="ac9aff44-d5f9-4e90-a304-7c52954d2082"></a>
##Private Void Dash12Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ee129093-586b-4168-8029-ca84cd62dc52"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="312bc019-6649-484a-a988-51de48ecd557"></a>
##Private Void Dash13Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="eebad594-26d2-41be-8133-544bdce25590"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3de8bdad-2240-45d0-a666-786fe6e2b0f6"></a>
##Private Void Dash14Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="decec990-5bf8-4004-b4b7-47e4735088d2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="5d13120b-f733-4085-8a1e-0ced1957e503"></a>
##Private Void Dash15Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a4e64a83-e495-47fa-b370-0d8477ac82fd"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="376f6232-80f2-48b8-aea5-38a1bbc0b316"></a>
##Private Void Dash16Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="207d1238-d3d5-4d92-b7ef-d0e8475c6e1e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="45a4ded9-e673-4a8e-a575-77ac8d5d56e6"></a>
##Private Void Dash1Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="931a64b7-5ea2-4970-b1bb-90a13b3b71ab"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="07325247-86f7-4e58-9741-b0f4f9206ab7"></a>
##Private Void Dash2Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c0604d74-3cd6-479d-baf9-0caddbd8676e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="6172e1a5-df1a-4fc6-a230-ba7a62d886ed"></a>
##Private Void Dash3Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ef2d49d8-961c-4958-839e-e863d0269072"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="663c2d80-c8df-472f-a169-26ceb073a794"></a>
##Private Void Dash4Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e1266874-6cf7-41d2-bb0b-22056710ec47"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="30f68754-10b3-4a11-99db-8aa229cf5011"></a>
##Private Void Dash5Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="49d84314-4341-4dc6-a53c-0ed24943325c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="6f963d99-b561-4d6a-ba0f-ab6edc4d1fa5"></a>
##Private Void Dash6Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3e350b96-92c1-487e-8254-e3818d60c390"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="448eb247-7b9b-4505-9fa0-973b375c61f2"></a>
##Private Void Dash7Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2cc88539-768b-42e6-9cff-970719797b7e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="f636873f-7162-484d-a71d-3a115d094eb1"></a>
##Private Void Dash8Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="70492823-493f-45d7-bd70-e6d59d98cc6c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="348accc4-aed8-45f5-b8a7-0a3468146497"></a>
##Private Void Dash9Changed (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c1c77059-f7f0-4307-917d-07d2471fdb53"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="940ee816-5971-4c31-a5b0-111cf520d539"></a>
##Private Void DashChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles a dash point changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6066b1be-d998-4b02-8041-ba9d972c6c7b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="35e9d812-d66d-426f-b601-4593e27dce6c"></a>
##Private Void DeleteColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Deletes the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8cf7e71d-f192-4787-ba74-6c0ce6fa89eb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="1a8b7f0e-d92c-4df8-9863-bf6256fb5dbe"></a>
##Public Void DeleteColor (KimonoCore.KimonoColor)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Deletes the given `KimonoColor` from the `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="e6273f06-b9f7-4631-907f-4c76500cfe0a"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>


---

<a name="0dbd5c19-c428-41ac-b42f-1d150e0dfa50"></a>
##Private Void DeleteGradient (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Deletes the gradient.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2d6f3408-c364-4954-8fa8-93066ccb8ccf"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="cfd6c215-00a2-4646-a979-927b90d8f1e4"></a>
##Public Void DeleteGradient (KimonoCore.KimonoGradient)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Deletes the given gradient.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="c186dbe8-288c-4dac-9fbb-e0442e9ed3ff"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>


---

<a name="b9f51163-1686-4f3a-9e21-5e86ca7618a9"></a>
##Private Void DeletePoint (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Deletes the point.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d0efeff6-6121-47c0-95b0-d96728f4ae8f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="37158f78-77d1-4fc9-ab08-fb96e730026e"></a>
##Public Void DeleteSelectedShape (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Deletes the selected shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="182517c1-de7a-410e-88dc-346e7c1e9f3a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="4e8e921a-1efa-42da-a9a7-74340af13b3f"></a>
##Private Void DeleteShape (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Handles the shape being deleted.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="69379849-e52b-4abe-a6a7-b9933652605c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="9ca2ca72-09f4-4903-8fbb-383e59462edf"></a>
##Private Void DeleteSketch (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Deletes the sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="67bd0976-615b-43e3-ad47-8163d66f465e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="b0532dbd-7489-490b-90ab-01fa8db78696"></a>
##Private Void DeleteStyle (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Deletes the style.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="fb5f757e-cd65-47be-8a50-8ae5d01eb3b9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="bf7f144b-3270-4590-b3b7-9325d93a1078"></a>
##Public Void DeleteStyle (KimonoCore.KimonoStyle)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Deletes the given `KimonoStyle` from the `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="2bc5300a-82fc-4e67-b4db-2fd417841190"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>


---

<a name="c22e665b-2877-4df8-906a-735e3b40c669"></a>
##Private Void DepthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Handles the point depth value chainging.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7a3b95ad-cc15-45b2-9bbb-582739086fef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="84b1aa1b-8b09-4805-8e31-b2fdf336f79f"></a>
##Private Void DeviationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the jitter deviation changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4c8deff2-de8d-441e-aa8d-5533ce8e2a5b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3542628b-49b1-49a9-ae3d-0baa788f7558"></a>
##Private Void DeviationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the jitter deviation changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ae484ae7-adfe-4544-a5de-9a95b670b8b9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c980b616-0a32-4044-ae53-8820a3402831"></a>
##Public Virtual Void DidChangeText ()

###Member of Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Handles the value of the text field changing 

---

<a name="8772dee3-f8bf-46db-abdd-603fa9733f10"></a>
##Public Virtual Void DidFinishLaunching (Foundation.NSNotification)

###Member of Type

[AppDelegate](#b4a5fd3a-500e-4d49-a5be-aac2002d9a82)

###Summary

Did finish launching.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="dcc9695e-6bde-409e-841b-6513b63b4aa8"></a>
<b>Foundation.NSNotification notification</b></p>

<p>Notification.</p>
</td></tr></table></p>


---

<a name="72eb8d95-6481-45ee-812e-e16e88fcf82b"></a>
##Private Void DisplayCurrentColor ()

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Displays the current color

---

<a name="683c3959-35e1-43a8-b708-a12dce5f8a6c"></a>
##Private Void DuplicateColor (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Duplicates the color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4fba1ab7-9b6c-4dfd-a80e-f8f540608c07"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="1fccc204-770f-4c8c-b1e6-ea0ec8a61b4e"></a>
##Public Void DuplicateColor (KimonoCore.KimonoColor)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Duplicates the given `KimonoColor` and adds it to `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="bc42494e-5a9b-4b31-8c56-abc3cdfe26a0"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>


---

<a name="2012ba90-0490-4028-8cfa-5ea65c7d03d0"></a>
##Private Void DuplicateGradient (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Duplicates the gradient.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0facb665-8363-4c93-9ca7-f342ebbb09c0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="e7d5838b-424c-48b0-a215-1f4a7ef80406"></a>
##Public Void DuplicateGradient (KimonoCore.KimonoGradient)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Duplicates the given gradient.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="52ad5856-28c4-4e99-8cb6-78ab8860b4ab"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>


---

<a name="259a4b1e-6f72-4799-b292-14922eeb6ff4"></a>
##Private Void DuplicatePoint (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Duplicates the point.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="415aa150-ec85-48c3-bef7-553f04bff788"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="69b6abe0-f7d2-4e1d-8134-5f17b9c233ee"></a>
##Public Void DuplicateSelectedShape (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Duplicates the selected shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ee054af5-56d3-4eb1-a1af-caefcf2a005c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="ed4e2f50-12d3-4d86-808b-88fb974caf19"></a>
##Private Void DuplicateShape (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Handles the shape being duplicated.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d5da6a38-7774-4b00-9607-cc1187250ca2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="de459dfc-e6f9-46d1-a1bf-18d1ae3990a1"></a>
##Private Void DuplicateSketch (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Duplicates the sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="72033b08-6de0-4b50-9074-c7cd50208727"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0e5f5fc1-3b19-4bba-852b-82a85a72f8d0"></a>
##Private Void DuplicateStyle (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Duplicates the style.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8efa2f63-e90d-4e4c-90af-133229419dd9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8ea05891-58b2-4d35-868c-e80f2a8731c1"></a>
##Public Void DuplicateStyle (KimonoCore.KimonoStyle)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Duplicates the given `KimonoStyle` in the `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="1f7146b0-1f2a-4deb-b52a-1b4f030c2821"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>


---

<a name="859f466a-fa99-4da4-9bed-228fd04cb5f2"></a>
##Private Void EditOrFinalizeShape (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Edits the or finalize and editable shape such as a `KimonoShapeGroup` or `KimonoShapeVector`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="40eeec16-10c0-4f31-b53b-1d4441437a35"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="e829ac2e-b4de-4023-bc38-af2bdf020e3c"></a>
##Private Void EditStyle (Foundation.NSObject)

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Calls the editor for the given style.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1cb3ffc7-1a4d-4ea0-be24-815851b5e4ef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="d9f2f75d-b95e-4199-a7ec-48184b5e04c5"></a>
##Private Void EndCapChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the end cap chainging.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5eb4bc8f-f356-44e6-9e7c-fa4d53e4a48d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0dc9daff-5d6c-44b5-bb2a-facb68160758"></a>
##Private Void FillChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the fill changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f102a0f9-18c3-4c3d-8b97-2e4ec2681b1f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="cb26109d-7ad7-4e4d-b74f-787a038cac0e"></a>
##Private Void FillColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the fill color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5af1953f-623c-40ec-9657-1e13b9d515f2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0846f28f-0258-4c58-a6ab-92c64295ee27"></a>
##Private Void FrameChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the frame changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="875328e0-27cf-42fd-863e-a95fab15ce4a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8e19e917-4081-4560-97e4-b80accecf1af"></a>
##Private Void FrameColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the frame color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7e5485a6-1e4f-4a74-ad46-f8890a070bef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="f0499732-33df-4158-aff2-49783d826d4a"></a>
##Public Virtual `AppKit.NSCell` GetCell (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Gets the cell.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="52653c6f-e0e9-488d-a19e-167c9f350823"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p><a name="8e0be41d-eb1d-40a6-984e-f9b79cdd4d3a"></a>
<b>AppKit.NSTableColumn tableColumn</b></p>

<p>Table column.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="e94134a3-484d-4573-bda5-69fdd353bc6a"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

The cell.

---

<a name="8843adc8-5dfa-49f9-b8a2-6aac98c03539"></a>
##Public Virtual `Foundation.NSObject` GetChild (AppKit.NSOutlineView, System.nint, Foundation.NSObject)

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

Gets the child.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="82b8e6d5-7e80-47dd-8d10-76cde439b031"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>childIndex</td><td style='width:75%' class='def'><p><a name="bcaf95e4-e9c8-44f3-9ca9-bcac13bea3c0"></a>
<b>System.nint childIndex</b></p>

<p>Child index.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="b75049b6-e83c-4092-873e-facb8ddc610f"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

The child.

---

<a name="277452ef-5605-4029-8c52-7046697e7c29"></a>
##Public Virtual `System.nint` GetChildrenCount (AppKit.NSOutlineView, Foundation.NSObject)

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

Gets the children count.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="25b92d62-38a1-4ddd-8296-58d037f1ad55"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="dcff4160-c268-4d0c-89c6-09c5b1342e21"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

The children count.

---

<a name="f3471e04-983a-4b2e-bd1f-0367595cb0f7"></a>
##Public Virtual `System.Collections.IEnumerator` GetEnumerator ()

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Gets the enumerator.
###Returns

The enumerator.

---

<a name="72dd8ec6-033d-4a50-ad1a-d4a68c8d59e3"></a>
##Public Virtual `Foundation.NSObject` GetObjectValue (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

Gets the object value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="530059de-e2ac-448c-a3f0-ac808c4f9710"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p><a name="e427d484-e98f-4d86-8e6e-f1ea37f13027"></a>
<b>AppKit.NSTableColumn tableColumn</b></p>

<p>Table column.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="5f915be6-0176-4e74-9e0e-42bdca84c412"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

The object value.

---

<a name="d6d89e11-5565-40e7-bd57-2c9f032d8761"></a>
##Public Virtual `AppKit.NSView` GetView (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Views for table column.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="47aebef8-d663-444d-8a87-d6862ffb48aa"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p><a name="0b4e1bdc-fca7-4b3d-aa7c-cb8628555c0d"></a>
<b>AppKit.NSTableColumn tableColumn</b></p>

<p>Table column.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="e7ac5602-a683-4d42-9cab-611c5bc1eed3"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

The for table column.

---

<a name="19b44bc3-a9b5-4d3f-a75e-e9af9512b54b"></a>
##Private Void GoBack (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Sends the user back to the selected shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="fb386f28-f64f-4722-8286-913065c0335d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="ba639195-2421-4f39-b33e-f9c4eb46461d"></a>
##Private Void GoBack (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Returns the to the selected shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="fc0d4800-69a1-41b5-9403-44f898dd6242"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="09870f43-af06-474c-b779-9dff9b88935f"></a>
##Private Void GoBack (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Returns to the currently selected shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="453d6cb5-db75-4208-9e9a-6f646a261a08"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="ba2609a3-660c-4440-aa20-42d954db4d23"></a>
##Private Void GoBackToSketch (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Goes the back to sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7897788e-40e1-4909-a23e-0d560c84a7b2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="34361e13-1804-45f6-ba28-c50ee0016675"></a>
##Private Void GradientChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the `KimonoGradient` changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a4ec110f-455a-40ae-beca-aaf5551388af"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3537330b-bed0-428a-bcb4-faf3827cb863"></a>
##Private Void GradientChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the gradient changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1ea1e5f5-d4cc-45d7-9b44-fef9aa73eea3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0a0409bb-0f81-4b15-86d3-da9ad6cd0426"></a>
##Public Void GroupUngroupSelectedShapes (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Groups or ungroups the currently selected group of shapes based on the current selection type.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0d6342f8-9f6d-429f-8341-7b7671a477a9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="2893c216-f87e-49aa-acae-6c84adfd15d9"></a>
##Private Void GroupUngroupShapes (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Handles a collection of `KimonoShapes` being grouped and ungrouped.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="29c3009d-7ab0-4d02-8fbb-2df8cdd4c230"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="f3f4f2b7-62cb-4cb1-b517-a5383233a286"></a>
##Private Void HasCanvasColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Does the canvas include a colored background?
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9a4ae4da-fab1-4e2e-b5ac-cf13276717d7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="5d3a4d36-06ca-410f-ab29-edf02030fc8c"></a>
##Private Void HeadChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Handles the has head value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c807ab7f-ee96-4c1d-89d9-1697b3cd5789"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="329d7b91-0a51-41d6-8a02-ac2d0b5cf751"></a>
##Private Void HighlightTool (KimonoCore.KimonoTool)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Highlights the currently selected `KimonoTool`.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="5a442630-75bc-482b-a1b7-f7eafe9940aa"></a>
<b>KimonoCore.KimonoTool tool</b></p>

<p>The <code>KimonoTool</code> to highlight.</p>
</td></tr></table></p>


---

<a name="b87c6560-02d2-437a-bb9b-871ed8637875"></a>
##Private Void HorizontalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the horizontal blur amount changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="346ed58c-0d1a-4ee1-b8a2-bba69d129053"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="6827a964-7c2c-4153-b012-7637d0edb8d0"></a>
##Private Void HorizontalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the horizontal blur amount changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3b002f47-f5b9-4aa7-b544-fd8a9d872d73"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="cf2b11fa-e6aa-443d-aed1-dca9d8e0a566"></a>
##Private Void HorizontalShadowBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the horizontal shadow blur changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="44710855-adde-48a6-9199-172f84d49cbe"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="4961338e-30ce-43b6-80f4-11aac9f1312e"></a>
##Private Void HorizontalShadowBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the horizontal shadow blur changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f15b1e02-cb49-422a-989f-59d0677fcdd0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="730428ea-0576-4179-9a07-562dfb017389"></a>
##Private Void HorizontalShadowOffsetChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the horizontal shadow offset changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="227fde84-ab4e-4ab0-a103-e88daabba5b2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="53b48146-6d83-471e-9f19-a99e83e2751b"></a>
##Private Void HorizontalShadowOffsetChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the horizontal shadow offset changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="743b47c8-e3c8-4003-a5e9-0afa6f1d2907"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="bc0b0554-18fd-4305-ba13-d8b7bce1b5aa"></a>
##Private Void HueChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the hue changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7c6c4dc5-9a7e-4076-9da6-7147a55ae788"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="ccbca707-39d7-4560-b303-70d1f1711d7c"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Initialize this instance.

---

<a name="335ae8ee-7ba7-4b25-be59-a68b136e7bef"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Initialize this instance.

---

<a name="203d0615-323b-4cad-9487-5f51db1e3f61"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Initialize this instance.

---

<a name="90b5d8a7-f9b6-4ca5-a395-74f8f31e6339"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Initialize this instance.

---

<a name="0ec720e7-3992-4b78-a005-0ce32d4dd8bd"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Initialize this instance.

---

<a name="dd640416-5ca0-4e07-aecb-8e72c725deaf"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Initialize this instance.

---

<a name="90edc352-5ec1-4865-9c9f-506d111f65c1"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Initialize this instance.

---

<a name="0732f40e-7ced-4503-a95e-4eba8d16d3e0"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Initialize this instance.

---

<a name="ea3fad8f-cb2a-4cb2-97cb-fdafc5a39c8c"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Initialize this instance.

---

<a name="d2f65e3a-3f36-4ee1-8dd3-c6f920f40058"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Initialize this instance.

---

<a name="e1e027a0-272d-4300-a50c-43eeca9816c4"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Initialize this instance.

---

<a name="ae938876-4fb3-4ff0-8b9c-21a0d53f4cc6"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Initialize this instance.

---

<a name="843e05cc-e313-4c54-9a6d-f68cdd766368"></a>
##Public Void Initialize ()

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Initialize this instance.

---

<a name="e7bcd8a2-1d28-4711-972e-6ae67bba82b1"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Initialize this instance.

---

<a name="a7e2739d-dfb9-4ace-8cc2-c807783b18be"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Initialize this instance.

---

<a name="264dbe06-4fe0-4e23-b88e-8688d36da078"></a>
##Public Void Initialize ()

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Initialize this instance.

---

<a name="7ca47852-2ff9-4616-8279-54da34a90caa"></a>
##Private Void InitializeInspectors ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Initializes the inspectors that allow the user to configure all of the elements in the `KimonoPortfolio` that is currently being edited.

---

<a name="c576d990-9445-44b1-b610-e9f2c9e31d98"></a>
##Private Void InnerChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Handles the inner value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="bde69cb5-9507-43a9-a237-379b4d37a194"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8e565c77-8248-4dcb-ac86-46e2c4fa1593"></a>
##Public Void Insert (System.Int32, KimonoMac.SourceListItem)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Insert the specified n and item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="d4a96f19-6a35-47ee-a369-83e8d29a546b"></a>
<b>System.Int32 n</b></p>

<p>N.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="c0cf2cc5-8bdc-4bd0-84c2-4959822e596a"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>


---

<a name="4d51bcea-a44d-4379-ba07-fee55c75cfd7"></a>
##Public Virtual `System.Boolean` IsGroupItem (AppKit.NSOutlineView, Foundation.NSObject)

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Determines whether this instance is group item the specified outlineView item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="de28bae5-f981-4162-a382-3f999517669c"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="ccbc47d9-d9c2-466e-83be-c0ca4045cac3"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

`true` if this instance is group item the specified outlineView item; otherwise, `false`.

---

<a name="846235a8-834a-4ed9-91f6-0aa129d6c065"></a>
##Public Virtual `System.Boolean` ItemExpandable (AppKit.NSOutlineView, Foundation.NSObject)

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

Items the expandable.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="b7921270-bc48-4cab-a273-7f4d7f4135c6"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="b80f878e-cec1-4482-ad0e-1d528f69b7c8"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

`true`, if expandable was itemed, `false` otherwise.

---

<a name="f6ad9943-3b88-4b9d-85ef-f409c3522c03"></a>
##[KimonoMac.SourceListItem](#1b5b42ef-47c3-4693-8ecf-e4323efed742) ItemForRow (System.Int32)

###Member of Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

Items for row.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>row</td><td style='width:75%' ><p><a name="8c957d49-60aa-4577-9fcb-5bae518d03b1"></a>
<b>System.Int32 row</b></p>

<p>Row.</p>
</td></tr></table></p>

###Returns

The for row.

---

<a name="7d131bed-02e1-4741-8475-0ebd552f0396"></a>
##Private Void JitterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the jitter effect changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="94d3981d-20a8-4e9d-a965-87c2e63e02ef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3f592f3f-794a-4c89-b5ba-a1665b4cd947"></a>
##Private Void JitterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the jitter effect changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c892f0b4-a5b4-43cc-b66f-5a3840ac7bf0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="abf4e476-5a68-405d-8c46-c72d24ccb818"></a>
##Private Void JoinTypeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the join type changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ab56d810-0317-4b80-9672-00c95c9a8563"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="41679892-5680-4898-85d4-c30cc76601b0"></a>
##Public Void KimonoInspectorArrow (System.IntPtr)

###Constructor for Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Initializes a new instance of the [KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="2f5e878c-67f3-45e0-8791-eb0e8600dd13"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="4ce72cea-43f5-4e96-8451-7c8f85fbf818"></a>
##Public Void KimonoInspectorAttachedStyle (System.IntPtr)

###Constructor for Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Initializes a new instance of the [KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="0e70e07d-a860-4a28-9a4c-476c735162b2"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="2bf56ce0-df16-42a1-ab52-448e7d94ac63"></a>
##Public Void KimonoInspectorFill (System.IntPtr)

###Constructor for Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Initializes a new instance of the [KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="33036967-a417-43ba-a112-a84813f0224d"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="6766a08e-640a-4357-82a0-03c5b0dd7613"></a>
##Public Void KimonoInspectorFont (System.IntPtr)

###Constructor for Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Initializes a new instance of the [KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="f65557bf-36fc-46db-b777-ab5adf076ec6"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="c3aabd88-b004-4861-9823-39ff1c39742a"></a>
##Public Void KimonoInspectorFrame (System.IntPtr)

###Constructor for Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Initializes a new instance of the [KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="29c8d96e-2915-4aef-956f-7da9c147d111"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="5306c7f8-bff5-4deb-bbf0-4468b472f950"></a>
##Public Void KimonoInspectorGeneralInfo (System.IntPtr)

###Constructor for Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Initializes a new instance of the [KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="74ce72da-0ba3-4b0b-8a4c-8d5a35d5f696"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="c73d3339-779f-4ca3-a3a6-58bb0c548d33"></a>
##Public Void KimonoInspectorGradient (System.IntPtr)

###Constructor for Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Initializes a new instance of the [KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="cce9e2c3-df0e-4c92-8004-08ed1c04e8c9"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="390c0760-348b-4a79-bf92-038fbe874306"></a>
##Public Void KimonoInspectorGroup (System.IntPtr)

###Constructor for Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The public `KimonoInspectorGroup (System.IntPtr)` constructor for the `KimonoInspectorGroup` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="d51a24f3-be54-4881-9904-a6f9b491bdb6"></a>
<b>System.IntPtr handle</b></p>

<p>The <code>handle</code> parameter of the KimonoInspectorGroup method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>


---

<a name="7179eece-9d4d-451e-82f1-2b15db92eb37"></a>
##Public Void KimonoInspectorPaleteColor (System.IntPtr)

###Constructor for Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Initializes a new instance of the [KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="ae2acf13-b4e0-4456-a191-6a9b76f7d5d1"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="edb52bee-18e2-449c-a068-48d4792a3f1b"></a>
##Public Void KimonoInspectorPolygon (System.IntPtr)

###Constructor for Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Initializes a new instance of the [KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="d69ee9fd-dcb1-42c1-a6e3-cd8dc9ae81a8"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="df6ba86f-3a91-431d-8ff7-0fbea95b48bc"></a>
##Public Void KimonoInspectorRoundRect (System.IntPtr)

###Constructor for Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Initializes a new instance of the [KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="b5167f1a-b34d-4235-a78a-aa4024106ccf"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="a644f44e-6486-4dd6-9db6-a4d2adf373b2"></a>
##Public Void KimonoInspectorSketch (System.IntPtr)

###Constructor for Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Initializes a new instance of the [KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="a585227f-ba65-44dd-85ff-40d1b43b82af"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="20e2f993-d8ce-412d-b766-69feae4f6b60"></a>
##Public Void KimonoInspectorStar (System.IntPtr)

###Constructor for Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Initializes a new instance of the [KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="1a285420-6deb-4a14-a413-3260ed6708e9"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="29717289-9eda-4048-8570-2b86492b86b8"></a>
##Public Void KimonoInspectorStyle (System.IntPtr)

###Constructor for Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Initializes a new instance of the [KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="b0015409-9308-42f7-a589-391fe08b08a8"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="93b732f9-644d-431e-a51d-987f96c5795d"></a>
##Public Void KimonoInspectorText (System.IntPtr)

###Constructor for Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Initializes a new instance of the [KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="1c4ed338-7b77-438d-a0e7-81cd75c39d4a"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="5bad9a51-7e92-4266-bdc4-0c4e47a6f173"></a>
##Public Void KimonoTextView ()

###Constructor for Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Initializes a new instance of the [KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a) class.

---

<a name="fc6bb70e-0eb1-44f6-8979-309d9e8c1a44"></a>
##Public Void KimonoTextView (CoreGraphics.CGRect)

###Constructor for Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Initializes a new instance of the [KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="5cbc558c-fa4f-476d-b740-46de81eb23ca"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>


---

<a name="392d996a-e447-4919-a5ad-808d0ff287c4"></a>
##Public Void KimonoTextView (Foundation.NSCoder)

###Constructor for Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Initializes a new instance of the [KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="f0f6de9b-3ce0-4d69-8ced-924647ed9a07"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>


---

<a name="288071f7-48f9-4c85-a450-bc0ef8dea613"></a>
##Public Void KimonoTextView (System.IntPtr)

###Constructor for Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Initializes a new instance of the [KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="45e962c5-8ca3-4551-b358-d1320f6d44ab"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="946f2d6c-ccdc-4cc7-81e1-ba45cfefdf99"></a>
##Private Void LengthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the jitter length changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="885a2f92-3ce1-44ea-b6f2-6bfc01c52343"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="e2106422-b54d-43a0-bc78-0d324305cb42"></a>
##Private Void LengthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the jitter lenght changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="58ebcf27-5f6e-48dc-8385-ad732ad006ae"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="235ed9fa-4552-4587-8ba8-088f6522fcda"></a>
##Private Void LinkedColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the linked color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3a5549c0-60dd-43b2-a886-5142755f1046"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="640df050-03dd-42be-8992-49fe9659a9bb"></a>
##Private Void LinkedColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the linked `KimonoColor` changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e5715840-0781-4087-9399-90ab3c067154"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="13755d78-bde3-425a-b551-596f36f9d73a"></a>
##Private Void LinkedColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Handles the linked color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7d4e8ad2-75d2-46bc-a533-58c5a25d4c2a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="cad3f518-9882-4833-ac16-4a8a8cc19ca1"></a>
##Private Void LinkedShadowColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the linked shadow color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="27442bdf-d3ab-4cc6-9a8b-513a3eaedf6b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0bd79141-81a7-490b-b2f2-ca104064ddb3"></a>
##Private Void LinkedShadowColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the linked shadow color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="36b7cd56-cd4e-4ecf-8e2f-d55f61567f5d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="6935ec10-e1d6-4210-b52a-82d4934e6c39"></a>
##Private Static Void Main (System.String[])

###Member of Type

[MainClass](#7b3b76dc-f0d8-4cb3-afbe-ff8ac08ca432)

###Summary

The entry point of the program, where the program control starts and ends.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>args</td><td style='width:75%' ><p><a name="d977ee3e-f28a-42a0-8144-49abb1a04d9b"></a>
<b>System.String[] args</b></p>

<p>The command-line arguments.</p>
</td></tr></table></p>


---

<a name="be0b1b65-b2a3-496f-955f-bd9ea4b380ea"></a>
##Public Void MainWindowController (System.IntPtr)

###Constructor for Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Initializes a new instance of the [MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="90352865-634e-410c-900d-ee2ac13d857f"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="33ee589c-f455-4b24-8b58-27912faa6541"></a>
##Private Void MaskChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Handles the mask changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="adf10298-2183-4eee-852b-e9f47cee9571"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="51783589-80a4-4e92-8d72-d8e14467023b"></a>
##Private Void MiterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the Miter changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1a0256ac-dd03-443f-9681-634f0c9bf1d4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3934b0c5-51ed-4179-9d24-1b22b6cbaf2d"></a>
##Public Void MoveBackwards (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Moves the selected shape backwards.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="56be8aa2-a7d0-4508-aee2-5c1f419a4e6c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="ea892458-c25f-4153-8a8b-d7d5077e6d03"></a>
##Public Void MoveForwards (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Moves the selected shape forwards.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0e7f1665-8fa0-4581-ab8d-edebed9f61ba"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="d4038978-d37e-4124-a3c5-3a096a26f414"></a>
##Public Virtual `System.Boolean` MoveNext ()

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Moves the next.
###Returns

`true`, if next was moved, `false` otherwise.

---

<a name="7e91fb4c-f25e-42fb-a605-314a21788332"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Moves the inspector to the given location
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="78299074-8cf9-4fba-b84f-e55b7a8c5beb"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="6f349fdb-f93e-4aae-9369-ee93a98da6d6"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="5b1631a6-3d34-483b-a5cb-8f744bec4046"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="f985aaa2-7a91-4b97-ac50-33d356802e17"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="eb313cea-56bb-4008-b790-380863a60eb3"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="1fadbf45-cca5-44da-b48d-2f0a593bd8a4"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="b9986ee8-717e-40fa-a248-78bd92d6bd7d"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="c0e55171-0180-4f89-82ff-9fb8ebe1bf78"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Moves the inspector to the give location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="3906b1cd-d9fc-466d-97dc-5f76bc848f27"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="12bdafce-ce50-4e27-a013-0c6d262694be"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="0fd6633e-63a4-47f3-9590-fcd1a6e0715b"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="d7e548dd-e8ce-4809-a64c-8458bd55c41e"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="6fc44bdc-70fa-46b4-9e8f-df00e5fb38b6"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="e59b8643-6b6c-429a-951b-cd55e8eae50c"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="b4ce7a56-44c2-428d-ab27-64854284a05a"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="f471255e-c85c-41ac-9632-cac5a46483e9"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="f83b543e-c77b-4195-b1b1-8c3e2dfff1e6"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="50aa2ca8-afb7-4d2b-88fb-7806a3b4c721"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Moves the inspector to the give location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="5619c7c0-d247-484d-b944-da1bb68ca7c7"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="5019fd7f-a2ed-4920-a3fa-9633d9120c54"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="4fd3ade4-21c7-4abd-9780-d661347dbeb5"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="cf5426af-ef28-4adc-93d3-ec00d276498b"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="7bc291c7-d22a-46e0-871e-122329584b04"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="a791af13-f53c-4d28-91e4-52bf7c808fbf"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="c45f0a66-d5c5-4e6d-9343-bbfaa2857694"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="af12c474-b69d-492f-828c-6457e7d6057a"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Moves the inspector to the given location
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="f4e229a6-6cba-41be-baf7-466589528b11"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the size of the inspector.

---

<a name="eaf2399d-ccd3-4bdd-bf5f-70f606c4a64b"></a>
##Public `System.nfloat` MoveTo (System.nfloat)

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Moves the inspector to the given location.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="69486071-a21d-44ad-96af-4350f6d96e87"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

###Returns

The next location based on the inspector's size.

---

<a name="4d3202b3-bf4a-4988-93c2-74b1c0003446"></a>
##Public Void MoveToBottom (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Moves the selected shape to bottom.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b3644bb3-8acb-42d2-8a5d-8dc35dd355e3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="bcfad951-c165-4291-99a0-db6dfb485e20"></a>
##Public Void MoveToTop (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Moves the selected shape to top.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="50ffb485-200f-4b75-89dd-29ecbb04a1fd"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="dcc1f044-4ba4-4eaf-9c49-7056b0242c5f"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the opacity changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2ea20db0-a9e4-4183-a006-d0441c78ec7c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3ac9bb3c-13a0-4d4f-b723-64c08c2eb066"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Handles the opacity changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d97e41c7-2f90-4c59-a54c-2cdf0f76cdca"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="7483198f-4a37-4c7e-bd4b-01d54b2d4b39"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the opacity value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7acd1c3d-f6dc-48fd-a076-7bda788c1252"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c8dd74a9-88b6-4dd6-8b43-08631ac74534"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Handles the opacity changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b47c51b9-ce35-44dc-a457-62e4e9dc3529"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="48edc711-8c09-4e60-b2a2-5a311b9cb7d1"></a>
##Private Void OpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the opacity changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6e3b1092-4479-44d5-ac7f-8b6d56bff963"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="84fbdea3-9142-451c-8ebe-250d25438f61"></a>
##Private Void OperationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Handles the boolean operation changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="62a76110-15a9-4422-8ecf-7ad61ebdfe5a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="2c72c563-d225-444a-997c-1957f132bfaa"></a>
##Private Void OuterChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Handles the outer value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a444677a-51da-484a-8247-d8338cd9deeb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="f26cc320-7838-481e-bc8e-630acfcff56b"></a>
##Private Void PointColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Handles a point color changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="41982acf-1b43-495d-a347-abc5bb4feef0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="1c0af7fe-b523-437d-b394-6e4874d92d14"></a>
##Private Void PointsChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Handles the number of points changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d024e082-51a4-4796-8a26-c9f4949ee9b3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="d2706d61-bdc5-4697-a1db-3ad003c04fc3"></a>
##Private Void RadiusChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Handles the radius changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="25550b34-9ac5-4267-938f-763bbc7c466c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="9c6bd050-5b12-435e-93ec-fc6217ad47ff"></a>
##Private Void RadiusChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Handles the radius changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4c986dba-9cc2-4461-9033-c2c52699d2f6"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="34bd9077-6dcf-4bdc-a887-0e64b5e27c43"></a>
##Void RaiseClickedEvent ()

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Raises the clicked event.

---

<a name="0b66e5ec-fdbf-4d06-b34d-9ba88ebc7314"></a>
##Void RaiseColorModified (KimonoCore.KimonoColor)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Raises the color modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="67281ac7-b9ee-41e6-9fd7-0a66f55564ca"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>Color.</p>
</td></tr></table></p>


---

<a name="58906b73-602b-470c-aac1-de4408abf845"></a>
##Void RaiseConvertToStyle ()

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Raises the convert to style event.

---

<a name="47004845-c3fe-4830-8f7e-0bc145fffd63"></a>
##Void RaiseEditAttachedStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Raises the edit attached style event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="2186cfdb-a5f0-47be-8c43-1aaeff63217f"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>


---

<a name="337c1f06-6908-41df-a345-97a2c6744f69"></a>
##Void RaiseGradientModified (KimonoCore.KimonoGradient)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Raises the gradient modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="0b8644e5-4a33-41a5-8503-0070dc36b8af"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>Gradient.</p>
</td></tr></table></p>


---

<a name="c2dbeb14-ed07-4d17-9836-ab95aa325467"></a>
##Void RaiseGroupModified (KimonoCore.KimonoShapeGroup)

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Raises the group modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="904af602-315c-42d4-b93e-2043af7e57d2"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The <code>KimonoShapeGroup</code> that was modified.</p>
</td></tr></table></p>


---

<a name="f19a0fde-bac3-4090-a442-483ef9ce1fab"></a>
##Void RaiseItemSelected (KimonoMac.SourceListItem)

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Raises the item selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="ec712219-6e8c-4a76-90ce-abd3220c28d9"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>


---

<a name="01c79d9d-e5bd-4e35-9d83-7baabe3be5bc"></a>
##Void RaiseMakeDuplicate ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Raises the make duplicate event.

---

<a name="ce5e8eee-5195-4e85-9b79-96ec48fea560"></a>
##Void RaiseMakeDuplicate ()

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Raises the make duplicate event.

---

<a name="3013ba98-7a24-457d-aa9c-ae04d9e931d2"></a>
##Void RaiseMakeDuplicate (KimonoCore.KimonoColor)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Raises the make duplicate event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="907d085b-dd65-446c-9915-ed48a0363440"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>Color.</p>
</td></tr></table></p>


---

<a name="fcd84338-edf3-4d3a-ac0f-79dc96c870e8"></a>
##Void RaiseMakeDuplicate (KimonoCore.KimonoGradient)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Raises the make duplicate event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="1ba9ca43-3441-463b-8cad-279bc47295f8"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>Gradient.</p>
</td></tr></table></p>


---

<a name="bcc3a384-c8df-4e72-857d-1373b3372e5f"></a>
##Void RaiseMakeDuplicate (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Raises the make duplicate event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="e5e0d793-9cfa-440d-b4e2-4b053b04a637"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>


---

<a name="60fe2c23-5a2b-45b2-b0fd-7d2c951ac580"></a>
##Void RaiseMakeNewColor (SkiaSharp.SKColor)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Raises the color of the make new event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="7cfea08c-4400-47b4-8d95-a79d8c07b35a"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>


---

<a name="b7a31d37-22d4-41b5-9212-1290e936d074"></a>
##Void RaiseMakeNewColor (SkiaSharp.SKColor)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Raises the color of the make new event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="bfedffdd-cdd7-4b6a-8c8b-e8f61cd37ed8"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>


---

<a name="894dfa83-5b0b-4986-b476-c00da144787d"></a>
##Void RaiseRemoveColor (KimonoCore.KimonoColor)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Raises the color of the remove event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="02d5ee55-02c2-47ab-9c35-033a9a17dd84"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>Color.</p>
</td></tr></table></p>


---

<a name="3102e9fb-6764-4cb9-ab4c-15123aa034ed"></a>
##Void RaiseRemoveGradient (KimonoCore.KimonoGradient)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Raises the remove gradient event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="7c44e5ba-8107-421d-8826-17ad11711cbd"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>Gradient.</p>
</td></tr></table></p>


---

<a name="c2f01093-1676-4633-8f85-97daaa4913de"></a>
##Void RaiseRemoveShape ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Raises the remove shape event.

---

<a name="77f5fe04-165f-4ec0-89c0-d602c1665e92"></a>
##Void RaiseRemoveSketch ()

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Raises the remove sketch event.

---

<a name="f27ce31c-39f3-4dcc-9a94-d695d880d5e1"></a>
##Void RaiseRemoveStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Raises the remove style event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="7e06bbf0-f7b7-4342-aa03-7b18ef934d49"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>


---

<a name="d9ee3504-8691-4a54-8728-bfefd6e05818"></a>
##Void RaiseRemoveStyle (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Raises the remove style event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="8e5de36c-368c-41f5-8a42-71108b00483e"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>


---

<a name="a36a34ba-0ab3-47b0-9826-47e4068de8f9"></a>
##Void RaiseReturnToShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Raises the return to shape event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="67b9e07e-a24e-4f03-932b-cdc5fdc8b572"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>


---

<a name="7caf19f5-4372-436a-b95a-75e0421aef7b"></a>
##Void RaiseReturnToShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Raises the return to shape event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="c2566a23-8ee4-4989-b86a-903bc83f39c7"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>


---

<a name="7b2e7082-124c-42ba-a5be-cb7f52ab16eb"></a>
##Void RaiseReturnToShape (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Raises the return to shape event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="46948def-3287-4a25-a409-62a8abb90711"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>


---

<a name="28becaf2-dc38-4031-bcd7-21852844cfbb"></a>
##Void RaiseSelectionChanged (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Raises the selection changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="761e2a49-7ea4-44b7-8ee7-457c8e5c4ddf"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>Selected.</p>
</td></tr></table></p>


---

<a name="2f14232a-5c2f-4bde-b9b2-3a6422a68726"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Raises the shape modified event.

---

<a name="dcf996f2-3839-47a6-88d9-fe45fdb922c4"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Raises the shape modified event.

---

<a name="cec311dc-6153-473d-84f6-9fc1dabf9b33"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Raises the shape modified event.

---

<a name="2be6dc43-d26b-4d53-91e7-cb0f9cd6059a"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Raises the shape modified event.

---

<a name="72f6c55f-94b1-4dae-8b4d-c5d1ea877c69"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Raises the shape modified event.

---

<a name="34223e08-8ff6-4617-897c-f7fe0bfc17e0"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Raises the shape modified event.

---

<a name="14e4ae60-10aa-4e2d-847e-fe70a772a6c2"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Raises the shape modified event.

---

<a name="a0a6f211-e908-4a49-a0bd-af8fc98010c3"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Raises the shape modified event.

---

<a name="f310dae2-489c-426c-919e-6900e830191a"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Raises the shape modified event.

---

<a name="a2186761-407c-4086-8e1e-b05a9b863c22"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Raises the shape modified event.

---

<a name="2bd113af-b921-4d1c-8db4-d8040a772e2a"></a>
##Void RaiseShapeModified ()

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Raises the shape modified event.

---

<a name="ed8480ac-bf5c-4bad-8cec-661dbca95408"></a>
##Void RaiseShapeModified (KimonoCore.KimonoShape)

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Raises the shape modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="5a4f6374-380e-4462-9f30-806ae99bdda8"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>


---

<a name="7b2e1b87-8b06-4015-838c-e63cd01bc5b0"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Raises the sketch modified event.

---

<a name="ae959ac4-7e0b-471d-82c8-ed0a4e309085"></a>
##Void RaiseSketchModified ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Raises the sketch modified event.

---

<a name="a7df0116-fe40-418e-a10c-23ec894a9cf7"></a>
##Void RaiseSketchModified (KimonoCore.KimonoSketch)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Raises the sketch modified event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="370cde36-b343-47ff-b16b-510f6c9d2c00"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>Sketch.</p>
</td></tr></table></p>


---

<a name="e998bf2b-13a9-4b52-b5f4-083e211f1aa7"></a>
##Void RaiseStyleModified ()

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Raises the style modified event.

---

<a name="2a6ae254-de2f-43f0-ab8a-49ec53af6ca1"></a>
##Void RaiseStyleModified ()

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Raises the style modified event.

---

<a name="176b8998-7584-4b33-ae32-fef7db54cac4"></a>
##Void RaiseStyleModified ()

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Raises the style modified event.

---

<a name="962bfdb0-d703-4e8d-98e7-37ca2f95354d"></a>
##Void RaiseStyleTypeChanged (KimonoCore.KimonoStyle)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Raises the style type changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="c7188691-ded0-4ef1-aebe-728f5eeabfa9"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>


---

<a name="27ce8643-ad32-4fcf-bddf-7475ef08f614"></a>
##Void RaiseTextChanged (System.String)

###Member of Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Raises the text changed event.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="b01b0b9b-6ae2-47c4-99cc-bdb835937e5a"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>


---

<a name="6a05b863-0ea9-425c-a8b4-16b57b1b0f8e"></a>
##Public Void Redo (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Redoes the last change.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2044df8b-e812-4c5b-88df-eee5abe23a79"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="652eede7-41e0-48ae-9a31-7d13506e2a7b"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorGradient` class.

---

<a name="b5e41080-bbc3-422a-917d-172639266ae6"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorPaleteColor` class.

---

<a name="89672c76-28c4-46eb-aaf5-b890a692149a"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorSketch` class.

---

<a name="29eb1f32-bb82-4a7b-8079-fbab78263633"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorText` class.

---

<a name="2d2185b4-e688-43dd-aba7-6f21a1db0317"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorFont` class.

---

<a name="e31e5936-0b10-4485-bc91-7a1093893fdb"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorArrow` class.

---

<a name="a5f8e242-76ea-43b2-8aed-db44774bc09a"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorAttachedStyle` class.

---

<a name="937ea23d-9ab1-41ae-b99b-dc09e46f6c16"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorStyle` class.

---

<a name="69472ce8-9887-46e0-be21-10010b7955f6"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `MainWindowController` class.

---

<a name="6477545f-61fb-4cce-9e49-5733e5d70100"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorGroup` class.

---

<a name="efc6b899-c3bf-446d-abc9-81274fd7955e"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorFrame` class.

---

<a name="66cbdd1b-7d76-4109-b5cb-98313941e3cc"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorFill` class.

---

<a name="fa876e70-95a8-4c51-90f8-8125f464ea25"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorPolygon` class.

---

<a name="971c5928-ad47-4e31-886e-b9396ac98d57"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorRoundRect` class.

---

<a name="ce3abf09-e6c7-4b7b-8b20-f4bf94727842"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `ViewController` class.

---

<a name="6d536f10-c1bd-414c-8aca-110035f99f0f"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorGeneralInfo` class.

---

<a name="777ff121-212e-4038-8745-fd81c00468b6"></a>
##Private Void ReleaseDesignerOutlets ()

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

The private `ReleaseDesignerOutlets ()` member of the `KimonoInspectorStar` class.

---

<a name="a19e63d5-479c-4e4d-863a-a68db62687d1"></a>
##Public Void RemoveItem (KimonoMac.SourceListItem)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Removes the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="f043f82b-9435-4b47-8322-cab116eef178"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>


---

<a name="51e25c10-8d53-4ba4-a3c7-6a154deb4490"></a>
##Public Void RemoveItem (System.Int32)

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Removes the item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="61bfe027-3e95-437d-9afa-9745fc3e3783"></a>
<b>System.Int32 n</b></p>

<p>N.</p>
</td></tr></table></p>


---

<a name="a70d25a8-e81d-4a5a-a19e-9a255bcb5f18"></a>
##Public Virtual Void Reset ()

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Reset this instance.

---

<a name="e47c8538-fa36-4c11-9e4a-9445391a80e7"></a>
##Private Void RotationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Handles the rotation being changed.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1e59edb5-7243-4c02-af90-e6d1ef119002"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="6b600b46-c091-4ce6-8ad7-68f74551c779"></a>
##Private Void SaturationChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Handles the saturation changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="44e230f5-3a6d-42aa-b8f4-b4f19e4f9b2e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8a04f128-81b9-4fc7-820e-8786d24a861d"></a>
##Private Void ScaleChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the scale changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="22a806d8-bd10-4097-a601-dbe04f371c88"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="fc0ee6ec-96a5-479e-91aa-dd00034621d2"></a>
##Private Void ScrollInspectorsToTop ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Scrolls the inspector list to top.

---

<a name="43b1618f-ae29-4b63-9fd7-30967da7a1ad"></a>
##Private Void SelectFontFamily (System.String)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Selects the font family.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>family</td><td style='width:75%' ><p><a name="716ad9e2-f18a-421a-80f0-c2c6b5da7abe"></a>
<b>System.String family</b></p>

<p>Family.</p>
</td></tr></table></p>


---

<a name="5bc67887-bee9-443a-996e-b22d1610e2c4"></a>
##Public Virtual Void SelectionDidChange (Foundation.NSNotification)

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Selections the did change.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="f71ee60e-8912-4b04-ad96-8736f71d56b9"></a>
<b>Foundation.NSNotification notification</b></p>

<p>Notification.</p>
</td></tr></table></p>


---

<a name="84881654-880d-4826-9196-7e9abea98c72"></a>
##Private Void SetColorValues ()

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Sets the color values.

---

<a name="9eb0d47b-097e-45e8-8dc4-d6e52ec604c8"></a>
##Private Void SetDocumentSize ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Adjusts the visible representation of the Design Surface to the dimentions of current `KimonoSketch` being edited.

---

<a name="47f12b81-253b-4746-a65b-e00181fe6883"></a>
##Private Void ShadowChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the shadow changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5e0bdc39-8343-4db4-937f-7a04fbdd0889"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="73f7a7ed-5fed-4c1b-9055-19149c326050"></a>
##Private Void ShadowChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the shadow changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="49d7e6b3-db50-48a4-bb18-1fd3b21d2494"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="3df7b56c-1166-48d0-bc68-0d9893cad488"></a>
##Private Void ShadowColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the shadow color chainging.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2a2ad2a2-4ebf-4822-921c-88f632d4027c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0b846a9e-3f3a-4780-b3c1-703bb4d72eae"></a>
##Private Void ShadowColorChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the shadow color chainging.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b767d31e-50f3-4b7b-b5c9-c3e2c23add3f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="29a699ff-13ba-4649-8140-cb231dd311db"></a>
##Private Void ShadowOpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the shadow's opacity changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="582d38c9-d019-4065-8d4b-b57e7df41dbc"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="fde3be3c-a13d-410e-b929-1134b87a2e9d"></a>
##Private Void ShadowOpacityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the shadow's opacity changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="edb78b69-25ce-469b-85b0-abc58d498759"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="9813cf33-92d4-40cd-b9fc-49a702a89e19"></a>
##Public Virtual `System.Boolean` ShouldEditTableColumn (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Shoulds the edit table column.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="4989693d-48f4-422a-a391-55e7f1ab0470"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>tableColumn</td><td style='width:75%' class='def'><p><a name="75a3d734-ca60-4f42-a5cc-50ae25e81fff"></a>
<b>AppKit.NSTableColumn tableColumn</b></p>

<p>Table column.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="6f50a6b7-72b5-4f2e-b0b8-47d7bb19d8ca"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

`true`, if edit table column was shoulded, `false` otherwise.

---

<a name="a527b9f4-3c81-41de-ac30-8d0a254eb062"></a>
##Public Virtual `System.Boolean` ShouldSelectItem (AppKit.NSOutlineView, Foundation.NSObject)

###Member of Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Shoulds the select item.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="ecaa1f8b-4916-47c3-acbc-f7b292e8d59d"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="73cafea6-ab44-4816-bcd6-48b15054ae7e"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

###Returns

`true`, if select item was shoulded, `false` otherwise.

---

<a name="518d1713-0e51-4a4d-96b4-14fcfab86f0e"></a>
##Private Void ShowCurrentColor ()

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Shows the values for the current color selected.

---

<a name="a9abbd4f-7c9d-44eb-808b-1082ac5aa5be"></a>
##Private Void ShowCurrentColor ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Shows the color of the current.

---

<a name="32b201e3-6b83-4397-96ec-eb9aac371b7b"></a>
##Private Void ShowCurrentColor ()

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Shows current color values.

---

<a name="46ebe8ff-709d-49b3-aaec-dbb5124a056c"></a>
##Private Void ShowCurrentShadowColor ()

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Shows the color of the current shadow.

---

<a name="25861717-4381-4ab3-a480-e03bae50ae11"></a>
##Private Void ShowCurrentShadowColor ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Shows the color of the current shadow.

---

<a name="b345782b-247e-4cbe-872c-3dadcb94a227"></a>
##Private Void ShowDashEditor ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Shows the dash editor.

---

<a name="2340b207-bd46-4e75-8989-51f35c47686c"></a>
##Private Void ShowGeneralInspectors (KimonoCore.KimonoShape)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Shows the general information inspectors for the given shape.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="36773183-bd6e-472a-81dc-8d31f8dacdbf"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to show the inspectors for.</p>
</td></tr></table></p>


---

<a name="e1930a40-3e48-47bc-ba40-7175d7b945a1"></a>
##Private Void ShowGradientInspectors (KimonoCore.KimonoGradient)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Shows the gradient inspectors.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="e2272ab2-a8bd-402f-9c87-5404608c8d43"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to show the inspector for.</p>
</td></tr></table></p>


---

<a name="7ffbe6ed-fe20-437b-a3ec-e3e856b965d8"></a>
##Private Void ShowGroupShapes ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Populates the Shapes sidebar with all of the `KimonoShapes` in the currently selected `KimonoSHapeGroup` that is being edited.

---

<a name="5fd85707-3837-4cfe-89b6-71db11d3ad8b"></a>
##Private Void ShowPaletteColorInspectors (KimonoCore.KimonoColor)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Shows the palette color inspectors for the given color.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="6d9b49f4-b93b-4cbc-a540-5aa4a5221cdd"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to show the inspectors for.</p>
</td></tr></table></p>


---

<a name="e27ed3b4-0ae5-4545-b678-0970fbc90471"></a>
##Private Void ShowSketchInspectors (KimonoCore.KimonoSketch)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Shows the sketch inspectors for the given sketch.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="4005609d-aa31-400f-b506-c58fc3207e57"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> to show the inspectors for.</p>
</td></tr></table></p>


---

<a name="8f03b9d6-6986-46a3-8cbf-c19309e38da1"></a>
##Private Void ShowSketchShapes ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Populates the Shapes sidbar with all of the `KimonoShapes` in the currently selected `KimonoSketch`.

---

<a name="8d389341-58eb-4d64-b499-4dfff29d4d33"></a>
##Private Void ShowStyleInspectors (KimonoCore.KimonoStyle)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Shows the style inspectors for the given style.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="cc08a8f5-f6a0-4461-913f-c11749478235"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to show the inspectors for.</p>
</td></tr></table></p>


---

<a name="2735e1d3-401d-4e7b-bc7b-2778f1d9215a"></a>
##Private Void SidesChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Handles the number of sides changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2cde3cf5-fe88-4ea7-8a2d-fc9b75395412"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="32667df8-d8fa-4ce7-9df1-4820440cd231"></a>
##Private Void SizeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the size changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0805a84c-2dfa-44b6-bcbf-f0da6fa63eb5"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="a29b7fa8-77db-4d40-878a-05bba1a18c96"></a>
##Private Void SkewChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the skew changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e7dce5a1-bd32-45d4-b29c-51b8decc824a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="4256fc70-3014-4ac0-b5f3-f0022306da20"></a>
##Private Void SkipChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Handles the skip points number changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6daf6c6e-a462-4a20-b4cc-45a490a01bd4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="b88c0507-420f-45e0-8082-335db86898e1"></a>
##Public Void SourceListDataSource (KimonoMac.SourceListView)

###Constructor for Type

[SourceListDataSource](#c6838f10-2ca9-4324-90ca-7822754a9d0d)

###Summary

Initializes a new instance of the `OutlineDataSource` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controller</td><td style='width:75%' ><p><a name="f7d94384-88c9-4355-be36-f7b873d85c10"></a>
<b>KimonoMac.SourceListView controller</b></p>

<p>Controller.</p>
</td></tr></table></p>


---

<a name="fc90e87e-5162-4709-8965-f7d3957be1e3"></a>
##Public Void SourceListDelegate (KimonoMac.SourceListView)

###Constructor for Type

[SourceListDelegate](#87ea1989-9a98-4fa5-bd46-da2e4a742528)

###Summary

Initializes a new instance of the `OutlineViewDelegate` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controller</td><td style='width:75%' ><p><a name="5d104284-e834-44f2-906d-fef9da0325e4"></a>
<b>KimonoMac.SourceListView controller</b></p>

<p>Controller.</p>
</td></tr></table></p>


---

<a name="a49fe55a-3cfe-45fb-aa01-71e773829112"></a>
##Public Void SourceListItem ()

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.

---

<a name="173189d6-4df7-427a-a837-12a76c879c0f"></a>
##Public Void SourceListItem (System.String)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="a66afda3-7de1-49fb-b51c-1dad7b330605"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr></table></p>


---

<a name="96566ebc-7489-49df-bbac-b58b2ab68288"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="41149db7-47a6-49c2-8cc2-60be167412e1"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="7f1499c5-c68c-48ca-b942-d39f10dfc587"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr></table></p>


---

<a name="0164b2e4-199a-461d-b5c6-7380fe611382"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="dbbaaa3c-e078-470c-9046-bcf00c9dac8f"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="b580a688-f5fa-4dad-a66e-107c6ee8da53"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p><a name="b7f222bd-5a34-45f8-b3fc-6a0ac4762b28"></a>
<b>KimonoMac.SourceListItem.ClickedDelegate clicked</b></p>

<p>Clicked.</p>
</td></tr></table></p>


---

<a name="0dc4a960-7886-48d2-86e8-9f210fa44509"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage, System.String)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="51363b4f-5052-40be-9cf4-e7db4d96e29f"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="e030e898-9f3b-469f-935e-bf92eb211d92"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p><a name="d33ddcf6-87d4-45d2-9e86-ad90fe4c4385"></a>
<b>System.String tag</b></p>

<p>The <code>tag</code> parameter of the SourceListItem method takes a <code>System.String</code> value. </p>
</td></tr></table></p>


---

<a name="5ef50103-0248-489c-a321-6ac9880a4ffb"></a>
##Public Void SourceListItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="b2a35e16-2846-4a9c-8a78-d0bad0cfae49"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="d06ac464-bd55-4307-9676-f12710f264e9"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>tag</td><td style='width:75%' ><p><a name="7f6a7648-6e46-40f7-b7a3-e22a68568374"></a>
<b>System.String tag</b></p>

<p>Tag.</p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' class='def'><p><a name="e05c6031-f4c8-4692-99e7-1302970ed267"></a>
<b>KimonoMac.SourceListItem.ClickedDelegate clicked</b></p>

<p>Clicked.</p>
</td></tr></table></p>


---

<a name="bb6dc3f7-dea3-4292-aece-4251977374a5"></a>
##Public Void SourceListItem (System.String, System.String)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="1b4acc4a-cf12-4e57-83cd-f980f2c8d092"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="07c22482-a333-4f9a-8201-c596eab575aa"></a>
<b>System.String icon</b></p>

<p>Icon.</p>
</td></tr></table></p>


---

<a name="6548fc78-a1b8-45be-9d6a-53b9e5602f7b"></a>
##Public Void SourceListItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)

###Constructor for Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Initializes a new instance of the [SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="e4293a4c-99de-4ac5-919b-11ec553cddd3"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="526e948f-5199-4d65-890c-63dbbd810841"></a>
<b>System.String icon</b></p>

<p>Icon.</p>
</td></tr><tr><td style='width:25%' class='term'>clicked</td><td style='width:75%' ><p><a name="3fdded35-5369-43d5-a2cc-ea18765f4d4a"></a>
<b>KimonoMac.SourceListItem.ClickedDelegate clicked</b></p>

<p>Clicked.</p>
</td></tr></table></p>


---

<a name="e3471d8b-87b1-42c8-8104-3ad52bbfe834"></a>
##Public Void SourceListView ()

###Constructor for Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Initializes a new instance of the `OutlineViewController` class.

---

<a name="6b30e1ea-2609-4957-ae61-e1ac50112efc"></a>
##Public Void SourceListView (Foundation.NSCoder)

###Constructor for Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Initializes a new instance of the `OutlineViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="9d93ff3a-a06e-4628-9f6e-bded30d81832"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>


---

<a name="a88eda64-31ab-4acc-a92c-3669cb1fc35b"></a>
##Public Void SourceListView (Foundation.NSObjectFlag)

###Constructor for Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Initializes a new instance of the `OutlineViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>t</td><td style='width:75%' ><p><a name="e72f529b-a111-479f-9614-7e6739d3ed05"></a>
<b>Foundation.NSObjectFlag t</b></p>

<p>T.</p>
</td></tr></table></p>


---

<a name="ab6cb6da-78e0-48bf-ac29-58438616c44e"></a>
##Public Void SourceListView (System.IntPtr)

###Constructor for Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Initializes a new instance of the `OutlineViewController` class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="890a3867-0914-405e-8182-852fd0bfcfec"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="6c5bcde1-7ad3-4a6b-a860-f1e143f1dfb5"></a>
##Private Void StreamlinedChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Handles the streamline value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a6440cc8-45af-4b50-bd54-2ee6121f755b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="21952e3b-27e2-4a30-a7cd-fe86a37b860b"></a>
##Private Void StrikeThruChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the strikethru changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="48b73e09-dc9a-4e6c-84e1-37f596950037"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="6f1c1ffc-58d3-40a5-88f6-0440f4b94768"></a>
##Private Void StyleChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Hnadles the style changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a25d485e-9124-4be6-81ff-8e711d1ca797"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="94a82a98-3a6c-4330-9292-22aa77ed5b34"></a>
##Private Void TailChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Handles the has tail value changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c248c3f8-094a-40a9-90fe-afe2e1d2fe7e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="fa4c53f3-27b3-4635-8707-ac7ec1226309"></a>
##Private Void TileChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Handles the tile mode changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="367c317d-0315-421a-9d24-a2c2ec716317"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c978d1f2-0b03-4faa-a65f-97515995cd20"></a>
##Private Void ToolArrowSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool arrow selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1002411c-8e88-4eeb-8865-b6a30fc9d38d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="99bad351-4478-45e3-a507-a0725332b113"></a>
##Private Void ToolBezierSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool bezier selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="dec4e7da-da67-434f-b3b8-644623849673"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="c402eaab-07ad-4c0e-a5a9-f410677e2764"></a>
##Private Void ToolCursorSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool cursor selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="031df588-392c-4402-a7fd-4d72f2b5bc84"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="34fed293-b981-43cc-9186-3b4e9e48e897"></a>
##Private Void ToolLineSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool line selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="40e77829-99d3-4adf-a1b3-97db45132242"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="eb65abe6-0e15-492b-a294-e3f74d26356b"></a>
##Private Void ToolOvalSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool oval selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="eb43edd1-1fb1-4d35-9618-c882b9292536"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="9a070fbb-7da6-4ea1-8361-1810d2ee4550"></a>
##Private Void ToolPolygonSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool polygon selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ddf3629c-79cf-4f77-98d4-5af5e6088822"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8d492678-6f7b-425b-b21b-98dceb3bb02e"></a>
##Private Void ToolRectSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool rect selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d9f72c72-29e9-4ae6-933c-bb4208b2c449"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="4d260fdd-e028-4328-a619-3c81a189bc99"></a>
##Private Void ToolRoundRectSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool round rect selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ebdf02c6-7794-4ca8-a016-be5b741706eb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="0847c01d-3a44-4756-b2ec-dcaae2188384"></a>
##Private Void ToolStarSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool star selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7b20b48f-3bff-48e0-8a59-91cc5ed7e8ad"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="a3735ada-4fb0-4db1-adbd-43ceeaf194a9"></a>
##Private Void ToolTextSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool text selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8bf0be6b-e5b9-4a6e-b4c0-0a739ec3eed6"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="13e1b5ec-17f7-40e8-b93e-30a3f6fbb1c5"></a>
##Private Void ToolTriangleSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool triangle selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="38fc2468-8387-470b-9022-0623370c2af9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="eaae9c5f-0b91-4d83-99a1-db9df52b7c0a"></a>
##Private Void ToolVectorSelected (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Tool vector selected.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4fe20770-bf3b-4227-b7a4-87252b50d5f9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="aebcd537-c1be-45b6-8181-75fa283fd4ce"></a>
##Private Void TypeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Handles the gradient's type changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7511bb7e-f1c9-4987-9ca7-6c76f8099e39"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="d6a2f878-a240-49b6-aaf3-37c08ba5b325"></a>
##Private Void TypeChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Handles the `KimonoStyle`'s type changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="91ba8a50-8143-454f-8311-4532669d3029"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8c2c10a0-d0ce-4d04-99eb-f3726114adce"></a>
##Private Void TypefaceChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the typeface changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c8370724-8bb1-4cef-9de1-e59a29c0c452"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="8b2f0343-36fd-4442-b604-36966583cea6"></a>
##Private Void UnderlineChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the underline changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2e45c8c9-eac2-47b3-ae93-7e531ed3b2d4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="2d676f62-3430-47c2-9298-c6e6557607a2"></a>
##Public Void Undo (Foundation.NSObject)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Udoes the last change.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0443ca65-4e81-4a6a-a6a7-90edee3f4e81"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="577ab352-a5a9-431e-a9bd-bd1b1f8ac5c2"></a>
##Private Void UpdateColorList (System.Boolean)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the color list in the sidebar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="b1c1f8dc-0624-4a7b-a380-900faa4c76f1"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>


---

<a name="d61333c6-d254-4ff5-abe4-dedbaf05a631"></a>
##Private Void UpdateGradientList (System.Boolean)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the gradient list.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="7a8cb391-b066-44e5-b367-6ef60079ac30"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>


---

<a name="b792479d-fbed-4465-8499-e4d689b40831"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Updates the inspector.

---

<a name="ca672a76-73f4-41cb-95c3-5c8b9fa09542"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Updates the inspector.

---

<a name="fd9152f1-8ac2-4785-92d7-a88373ddea91"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Updates the inspector.

---

<a name="9fa4c739-4af8-41fa-9b18-f69aed3705ea"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Updates the inspector.

---

<a name="cab7a01f-1e07-441a-871c-e722ff3bb50a"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Updates the inspector.

---

<a name="10087e47-84d8-4f51-bd70-ce29e8e5a8d0"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Updates the inspector.

---

<a name="0c24e72c-002b-4093-b3af-71b9f1bb5425"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Updates the inspector.

---

<a name="83a4df75-1490-4415-80e0-53f98c99318c"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Updates the inspector.

---

<a name="caa56b91-692f-47e3-a695-f4310601d2bd"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Updates the inspector.

---

<a name="59932f78-6162-4965-ad27-9464bf07bce4"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Updates the inspector.

---

<a name="f3356573-c5bd-4c0e-9ffb-a5b56ec11c51"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Updates the inspector.

---

<a name="9de1da6e-ca2b-487b-b143-7b881fe0ab80"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Updates the inspector.

---

<a name="0b39cc18-5d2a-49c4-a839-d460a4689225"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Updates the inspector.

---

<a name="603dd6bb-98e2-4d1c-a751-2c284514b7d4"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Updates the inspector.

---

<a name="e2680716-45c8-4d7f-8ee2-2d9041acb64e"></a>
##Public Void UpdateInspector ()

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Updates the inspector.

---

<a name="873b2222-f09e-472a-9f72-233bcba2acd3"></a>
##Private Void UpdatePath ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the path display at the top of the Design Surface showing the full path to the shape currently being edited.

---

<a name="0cbbdc85-72a0-412d-83e7-f6a577e61ce2"></a>
##Private Void UpdateProjectList (System.Boolean)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the project list in the sidebar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="62bd3d2a-77cb-42a3-abb5-8340dcbb2223"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>


---

<a name="3bbe8793-3dbb-4e9e-ae41-1d224ee8079f"></a>
##Private Void UpdateShapesList (System.Boolean)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the shapes list in the sidebar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="c8fa1ec1-f683-403e-8fcf-479154ea1d97"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>


---

<a name="6a82525a-0b72-4f5f-8b64-0e44f30eb952"></a>
##Private Void UpdateSketchesList (System.Boolean)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the sketches list in the sidebar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="1299f899-120b-4a39-8f99-20ff6bb2dae4"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>


---

<a name="1c24d733-23f3-423a-86e3-c9c54f229dbb"></a>
##Private Void UpdateStyleList (System.Boolean)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Updates the style list in the sidebar.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="e4433272-8957-48ee-9008-ac42000a432a"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>


---

<a name="b5ea2488-1fa2-47f7-ae57-0a4102fb105c"></a>
##Public Virtual Void Validate ()

###Member of Type

[ActivatableItem](#b6001a55-19e6-4020-9180-16fe091e8600)

###Summary

Validate this instance.

---

<a name="e0ab0a77-c795-4f47-9be4-e38dae85c98b"></a>
##Public `System.Boolean` ValidateMenuItem (AppKit.NSMenuItem)

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Validates any menu item attached to actions on this view controller based on its assigned `Tag` value.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="3e858ec4-ca1e-4c87-8fa5-b7269800f35c"></a>
<b>AppKit.NSMenuItem item</b></p>

<p>The <code>NSMenuItem</code> being tested.</p>
</td></tr></table></p>

###Returns

`true`, if menu item was validated, `false` otherwise.

---

<a name="1cc9c6dd-fb22-4209-9e91-21ceefb3b1b0"></a>
##Private Void VerticalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the vertical blur amount changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="faa21aad-e675-4856-8982-291a9c0e851c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="e6ef88b1-3d3c-4dd4-82f1-81463142c398"></a>
##Private Void VerticalBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the vertical blur amount changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9808e301-8bea-4e8f-8b6d-5beacafef8b6"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="46578c2e-226e-4a47-99c3-5d9c4267c5c9"></a>
##Private Void VerticalChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the vertical text changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9633bea3-4f87-4c48-9d7f-b8593b1a99a0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="f4416e94-68e1-4b54-a6c3-1a936dfe64bc"></a>
##Private Void VerticalShadowBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the vertical shadow blur changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="12669097-14f5-41e0-98d7-f4d4881980ab"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="d4b71b0c-8c57-4295-b71c-e0bf7742694e"></a>
##Private Void VerticalShadowBlurChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the vertical shadow blur changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="450d4fea-e69a-4508-a6ca-1818944953df"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="df22ebe7-5fdd-473e-a52b-02ec981110e0"></a>
##Private Void VerticalShadowOffsetChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Handles the vertical shadow offset changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0b4fa0ef-4f09-487d-8ac8-abbe6246784d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="aa0bb3e5-bca9-4d11-9241-8782f8c9748f"></a>
##Private Void VerticalShadowOffsetChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the vertical shadow offset changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2e0931c4-467b-4f3d-8109-99d398f1b8ea"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="1b6900d7-80fd-4abc-b9fc-ee6bb4b76117"></a>
##Public Void ViewController (System.IntPtr)

###Constructor for Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Initializes a new instance of the [ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc) class.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="c8c5f615-90a5-4131-a4c0-cb562342de6c"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>


---

<a name="2aeceaa3-ee67-45e3-ab56-4ca7b86c6d23"></a>
##Public Virtual Void ViewDidLoad ()

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Handles the view being sucessfully loaded.

---

<a name="49b38202-cf4a-4b4b-b630-37e88b271ebb"></a>
##Private Void VisibilityChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Handles the visibility changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4024f492-0d8a-444f-8c1f-f475a7c35541"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="377a481e-37f9-4cb1-8c04-ccbb089474b6"></a>
##Private Void WeightChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Handles the font weight changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="29700142-57ca-48d3-baf8-1f3bc2eb3199"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="e82358c5-7e7c-4ee9-9339-cffc370f2312"></a>
##Private Void WidthChanged (Foundation.NSObject)

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Handles the width changing.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5d8ffce2-1253-4e93-8c14-1ffbf40afbc3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>


---

<a name="80c20d54-37b6-4b81-bbfa-7c697c40eda0"></a>
##Public Virtual Void WillTerminate (Foundation.NSNotification)

###Member of Type

[AppDelegate](#b4a5fd3a-500e-4d49-a5be-aac2002d9a82)

###Summary

Will terminate.
<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="daf89b4e-9bcc-470d-a604-c00a70978659"></a>
<b>Foundation.NSNotification notification</b></p>

<p>Notification.</p>
</td></tr></table></p>


---

<a name="ff364d13-ce25-47e3-959b-538e0e4c274d"></a>
##Public Virtual Void WindowDidLoad ()

###Member of Type

[MainWindowController](#b9881a15-c33c-4bf5-8606-4829f8293008)

###Summary

Handles the window loading and configures any user interface elements based on the stateof the `KimonoPortfolio` being edited.
<a name="Events"></a>
#Events


---

<a name="2df6d1fb-94d5-4a4f-993c-9b020efdbb79"></a>
##[KimonoMac.SourceListItem.ClickedDelegate](#7895a845-abf1-402c-a040-0a2bc4e4ac64) Clicked

###Member of Type

[SourceListItem](#20b849ed-e963-46fd-ac47-3fdd0ee424fa)

###Summary

Occurs when clicked.

---

<a name="f315eeb3-3789-4432-a458-44fc2e558c77"></a>
##`KimonoCore.Kimono.ColorEventDelegate` ColorModified

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Occurs when color modified.

---

<a name="a0ff07ea-6091-4897-b8e0-50e50ad3a91c"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ConvertToStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Occurs when convert to style.

---

<a name="1482993f-e4d3-4593-a7da-cce7a67d151e"></a>
##`KimonoCore.Kimono.StyleEventDelegate` EditAttachedStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Occurs when edit attached style.

---

<a name="cce4b870-fd18-4f70-9207-b272a10e430e"></a>
##`KimonoCore.Kimono.GradientEventDelegate` GradientModified

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Occurs when gradient modified.

---

<a name="abe8414e-4eee-4807-9823-0b6d03170c48"></a>
##`KimonoCore.Kimono.GroupEventDelegate` GroupModified

###Member of Type

[KimonoInspectorGroup](#89f7f09f-b964-460f-befa-9ffb6694b7ea)

###Summary

Occurs when group modified.

---

<a name="864cf2b8-3f69-44a3-935f-ef90189c94b4"></a>
##[KimonoMac.SourceListView.ItemSelectedDelegate](#9146e8cc-76d1-4777-bbdd-3912a5209854) ItemSelected

###Member of Type

[SourceListView](#5ba0f8fa-3462-4142-9024-c68716903b8f)

###Summary

Occurs when item selected.

---

<a name="5c87c8eb-3894-4527-9f29-2f1754c3936f"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Occurs when make duplicate.

---

<a name="e0a0b9a1-8a1b-4e01-9579-ef97372616b1"></a>
##`KimonoCore.Kimono.StyleEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Occurs when make duplicate.

---

<a name="094a8955-f7ce-4a1e-8433-884f7a7414e9"></a>
##`KimonoCore.Kimono.GradientEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Occurs when make duplicate.

---

<a name="4a70d751-6bf9-4974-906f-3bc45b8ebee0"></a>
##`KimonoCore.Kimono.ColorEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Occurs when make duplicate.

---

<a name="7c70e8a5-7a95-461f-b828-a31dbaa2ad5b"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` MakeDuplicate

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Occurs when make duplicate.

---

<a name="7dc50b16-fecd-439f-8abe-963d7a50d60d"></a>
##`KimonoCore.Kimono.SkiaColorEventDelegate` MakeNewColor

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Occurs when make new color.

---

<a name="5c44579a-3cf6-48ed-a3a4-8e2f7fc055e6"></a>
##`KimonoCore.Kimono.SkiaColorEventDelegate` MakeNewColor

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Occurs when make new color.

---

<a name="1d431820-b46d-497b-a864-8837728de3eb"></a>
##`KimonoCore.Kimono.ColorEventDelegate` RemoveColor

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Occurs when remove color.

---

<a name="b3159239-bf48-4341-a3ca-fc2e8f7c05b5"></a>
##`KimonoCore.Kimono.GradientEventDelegate` RemoveGradient

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Occurs when remove gradient.

---

<a name="249c726b-f2a6-416b-81fd-3c9506b6adc2"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` RemoveShape

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Occurs when remove shape.

---

<a name="ffdb73b1-29ba-4bc4-ad16-b40583801189"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` RemoveSketch

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Occurs when remove sketch.

---

<a name="c8b6a877-2ba1-403e-bfa7-e0be65c111f6"></a>
##`KimonoCore.Kimono.StyleEventDelegate` RemoveStyle

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Occurs when remove style.

---

<a name="f6d09678-7e11-422f-b6d3-e28327abaa4d"></a>
##`KimonoCore.Kimono.StyleEventDelegate` RemoveStyle

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Occurs when remove style.

---

<a name="ed54d6be-d06f-4c97-bf74-b5a68084c831"></a>
##`KimonoCore.Kimono.ShapeEventDelegate` ReturnToShape

###Member of Type

[KimonoInspectorPaleteColor](#dfdcb93f-6d98-4469-848e-4ed5b1fa6162)

###Summary

Occurs when return to shape.

---

<a name="9e16f479-0a81-452d-bad5-c6a38d404e0b"></a>
##`KimonoCore.Kimono.ShapeEventDelegate` ReturnToShape

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Occurs when return to shape.

---

<a name="1a8d84fd-4674-487d-bbc8-8ecaca127e6f"></a>
##`KimonoCore.Kimono.ShapeEventDelegate` ReturnToShape

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Occurs when return to shape.

---

<a name="1fd75de8-b6d9-4d3b-af6e-77f1ab7d6eac"></a>
##`KimonoCore.Kimono.ShapeEventDelegate` SelectionChanged

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Occurs when selection changed.

---

<a name="2d2ec37e-143d-482e-98ad-b687388f8db9"></a>
##`KimonoCore.Kimono.ShapeEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Occurs when shape modified.

---

<a name="b228f7ff-31cf-4605-a3bf-e462b6772c63"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorGradient](#d5064eca-591d-4f74-bf35-da5f7fbdbb3b)

###Summary

Occurs when shape modified.

---

<a name="5947283b-9b0d-414e-83b1-6fa0d0cf86d8"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Occurs when shape modified.

---

<a name="c08b9b8a-fbcf-4c64-a36e-f49a643aa521"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Occurs when shape modified.

---

<a name="e5de0b9b-01ed-4aeb-8209-a40b07980b7a"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorFrame](#3d13d593-a78a-46f8-bd30-1f88ffbbc239)

###Summary

Occurs when shape modified.

---

<a name="7ff2ae4b-ab35-474e-8710-2884b23144bc"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorText](#d6667936-a83f-4ed0-b092-62db0b6cab71)

###Summary

Occurs when shape modified.

---

<a name="f43a6c61-c083-4358-a08f-a32b329526c7"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorPolygon](#9c3f18a9-b56a-4496-9b51-819aca1bd975)

###Summary

Occurs when shape modified.

---

<a name="4c1af845-1c66-43c8-a3c1-4ab12bf91f7a"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorStar](#344b8c16-cdc9-4606-af9b-9b672d043928)

###Summary

Occurs when shape modified.

---

<a name="57a2bb32-97c0-4aa3-8363-d52a4515bc46"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Occurs when shape modified.

---

<a name="b644d2ec-fe09-40f8-8ad7-7681be6edd9e"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorArrow](#fbd844de-247a-4e17-9ab5-e5cda997b4a0)

###Summary

Occurs when shape modified.

---

<a name="3d297f4b-0384-4adf-8460-a368fde7ff11"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorRoundRect](#a76afe10-8f40-4938-8f3c-dd0362d71d1f)

###Summary

Occurs when shape modified.

---

<a name="bd1b073c-a4ca-4c45-a8b2-27bdcf3683ea"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` ShapeModified

###Member of Type

[KimonoInspectorFill](#27afbed2-1709-4abb-84f6-c68238b78cd4)

###Summary

Occurs when shape modified.

---

<a name="2bea68a2-450b-474a-bf0a-5ba3af35e566"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` SketchModified

###Member of Type

[KimonoInspectorGeneralInfo](#a11c2de0-ef79-4a59-ae37-0c8806453775)

###Summary

Occurs when sketch modified.

---

<a name="eb452cf7-31ae-4353-b2dd-df24c3f018c1"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` SketchModified

###Member of Type

[KimonoInspectorSketch](#29b077d2-fa1f-4b59-b9c3-22ef34f57c59)

###Summary

Occurs when sketch modified.

---

<a name="d051725a-d1ae-4ccb-beb5-003beb788621"></a>
##`KimonoCore.Kimono.SketchEventDelegate` SketchModified

###Member of Type

[ViewController](#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc)

###Summary

Occurs when the sketch is modified.

---

<a name="9f2e1c72-a31f-43b4-b790-f83d6abd7900"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` StyleModified

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Occurs when style modified.

---

<a name="cf197174-d0b4-4f3d-8b53-07f6e2e55e72"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` StyleModified

###Member of Type

[KimonoInspectorFont](#e6607c64-f369-46da-b148-c5162d80ca70)

###Summary

Occurs when style modified.

---

<a name="57b4dd85-d60c-419b-af79-9c0419842422"></a>
##`KimonoCore.Kimono.PortfolioEventDelegate` StyleModified

###Member of Type

[KimonoInspectorAttachedStyle](#eb950e5f-f53b-47ee-a68f-7bcb0d06a262)

###Summary

Occurs when style modified.

---

<a name="2e4e9d24-0405-457a-a7a7-dbba746c5ec2"></a>
##`KimonoCore.Kimono.StyleEventDelegate` StyleTypeChanged

###Member of Type

[KimonoInspectorStyle](#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c)

###Summary

Occurs when style type changed.

---

<a name="f5a58777-8ce9-4cea-8f9e-4afa4a1c6533"></a>
##[KimonoMac.KimonoTextView.TextChangedDelegate](#34258cd9-f194-4032-90e7-90700902ba3d) TextChanged

###Member of Type

[KimonoTextView](#da5fed64-0411-45d7-bec7-b60d9c3ca60a)

###Summary

Occurs when text changed.
