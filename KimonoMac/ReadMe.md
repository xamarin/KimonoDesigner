#Kimono Designer Mac API Documentation

####Version 01.01.00

##Table of Contents

* [Summary](#Summary)
* [Remarks](#Remarks)
* [Namespaces](#Namespaces)
* [Types](#Types)

<a name="Summary"></a>
##Summary

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can can be converted to code and included in any cross-platform language and OS that SkiaSharp supports.

<a name="Remarks"></a>
##Remarks

Kimono Designer and the KimonoCore libraries were created by Microsoft, Inc. and released under the MIT License.

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

<a name="d2ccd6a5-8517-4fc5-aa3f-333f7d181085"></a>
##AppKit.TextKit.Formatter

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8e5eb700-a9ce-4234-b397-6054b6a1c028'>CSharpDescriptor</a></td><td style='width:75%' ><p>Defines how C# should be colorized using a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2695704-db23-4679-939f-9f0f65cee076'>FormatDescriptor</a></td><td style='width:75%' class='def'><p>The <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> defines a language formmating instruction that can be used by a <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> to define syntax highlighting to a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61a7d985-5834-4f1a-8f00-04b08c6d9093'>FormatDescriptorType</a></td><td style='width:75%' ><p>Defines the type of a <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac971230-5eb9-4a27-9317-dc6de370d8be'>HTMLDescriptor</a></td><td style='width:75%' class='def'><p>Defines how HTML should be colorized using a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56094def-ccde-45a2-987f-18730526fdc6'>KeywordDescriptor</a></td><td style='width:75%' ><p>The <a href="#56094def-ccde-45a2-987f-18730526fdc6">KeywordDescriptor</a> class defines a keyword that will be set to a specific color when used with a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> to do syntax highlighting in a <code>NSTextView</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c'>KeywordType</a></td><td style='width:75%' class='def'><p>Defines the type of a <a href="#56094def-ccde-45a2-987f-18730526fdc6">KeywordDescriptor</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c87a77f-96ce-412f-9e16-3d1ffdb11694'>LanguageClosure</a></td><td style='width:75%' ><p>The <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> class holds information about a closure such as  (), [], "" or '' that can be used to define a section of text in a <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>. The Language Closure is used by auto complete in a <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bf38b97-3aff-4262-8b73-5ec35d7e9daf'>LanguageDescriptor</a></td><td style='width:75%' class='def'><p>The <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> class defines how a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> should syntax highlight text for a given language such as C#, JavaScript or Visual Basic.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61eaefa9-223e-4d6c-9055-f3fda225f940'>LanguageFormatCommand</a></td><td style='width:75%' ><p>The <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> defines a formatting command that can be added to a <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>. When a document editor is using the given <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>, the <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> s it defines will be added to the Formatting Menu.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13e07d7b-7947-4461-812d-5c2aafa2ebee'>LanguageFormatter</a></td><td style='width:75%' class='def'><p>The <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> class uses a <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> to provide syntax highlighting of a  <code>NSTextField</code> based on a set of <a href="#56094def-ccde-45a2-987f-18730526fdc6">KeywordDescriptor</a> and<a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> objects..</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b84628e6-41f4-49c0-a81f-7daf16e5e7b8'>MarkDownDescriptor</a></td><td style='width:75%' ><p>Defines how MarkDown should be colorized using a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61291048-c4cc-483a-9cb7-114faf6713dc'>ObiScriptDescriptor</a></td><td style='width:75%' class='def'><p>Defines how C# should be colorized using a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#693e63b3-83a6-43a9-ac2a-7b8fc3474e13'>SourceTextView</a></td><td style='width:75%' ><p>This is a customized <code>NSTextView</code> that provides specialized input handling for the editing of source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#185a6024-f8d8-4ead-ac13-12a6721fb8ce'>SourceTextViewDelegate</a></td><td style='width:75%' class='def'><p>The <a href="#185a6024-f8d8-4ead-ac13-12a6721fb8ce">SourceTextViewDelegate</a> is used to respond to events that occur on a <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a883458f-5a65-4dd2-82de-99ba116904af'>XMLDescriptor</a></td><td style='width:75%' ><p>Defines how XML should be colorized using a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr></table></p>


---

<a name="eb5d4371-bdff-4aa2-b712-8cda2c473520"></a>
##KimonoMac

###Summary

The main namespace for the MacOS version of the Kimono Designer Interface.
<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#def484e3-0345-4e02-b51c-13512214c745'>AboutViewController</a></td><td style='width:75%' ><p>Handles the About Box for Kimono Designer.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6001a55-19e6-4020-9180-16fe091e8600'>ActivatableItem</a></td><td style='width:75%' class='def'><p>A type of <code>NSToolbarItem</code> that the developer can enable/disable by adjusting the  <code>Active</code> property.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4a5fd3a-500e-4d49-a5be-aac2002d9a82'>AppDelegate</a></td><td style='width:75%' ><p>App delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#766cb93d-7bda-4a96-8b54-8b98a9e207fa'>AppPreferences</a></td><td style='width:75%' class='def'><p>This class handles all of the user's preferences for the app. The values are  persisted using the system-wide <code>NSUserDefaults.StandardUserDefaults</code> object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4dcbb271-b786-4581-94ef-25b12aaca68d'>CenteringClipView</a></td><td style='width:75%' ><p>Centering clip view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c44d4017-143a-4222-a7ea-515fa98aa272'>InspectorViewMode</a></td><td style='width:75%' class='def'><p>Used to set the current inspectors type being shown in the inspector sidebar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbd844de-247a-4e17-9ab5-e5cda997b4a0'>KimonoInspectorArrow</a></td><td style='width:75%' ><p>Handles the inspector view for a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb950e5f-f53b-47ee-a68f-7bcb0d06a262'>KimonoInspectorAttachedStyle</a></td><td style='width:75%' class='def'><p>Displays the inspector for a <code>KimonoStyle</code> attached to a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27afbed2-1709-4abb-84f6-c68238b78cd4'>KimonoInspectorFill</a></td><td style='width:75%' ><p>Handles the inspector view for the Fill properties of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6607c64-f369-46da-b148-c5162d80ca70'>KimonoInspectorFont</a></td><td style='width:75%' class='def'><p>Handles the inspector view for the Font section of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d13d593-a78a-46f8-bd30-1f88ffbbc239'>KimonoInspectorFrame</a></td><td style='width:75%' ><p>Handles the inspector view for the Frame section of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a11c2de0-ef79-4a59-ae37-0c8806453775'>KimonoInspectorGeneralInfo</a></td><td style='width:75%' class='def'><p>Handles the general <code>KimonoShape</code> inspector view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5064eca-591d-4f74-bf35-da5f7fbdbb3b'>KimonoInspectorGradient</a></td><td style='width:75%' ><p>Handles the inspector view for a <code>KimonoGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89f7f09f-b964-460f-befa-9ffb6694b7ea'>KimonoInspectorGroup</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a given <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfdcb93f-6d98-4469-848e-4ed5b1fa6162'>KimonoInspectorPaleteColor</a></td><td style='width:75%' ><p>Handles the inspector view for a named <code>KimonoColor</code> that can be attached to other<code>KimonoShapes</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c3f18a9-b56a-4496-9b51-819aca1bd975'>KimonoInspectorPolygon</a></td><td style='width:75%' class='def'><p>Handles the inspector view for the <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7de844b6-6c5e-493c-b1f4-f105188b1fcb'>KimonoInspectorPortfolio</a></td><td style='width:75%' ><p>Handles the inspector view for a <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14cd9500-d1e0-481d-a895-2ffb36c33290'>KimonoInspectorProperty</a></td><td style='width:75%' class='def'><p>Handles the general property inspector for <code>KimonoProperty</code> objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a76afe10-8f40-4938-8f3c-dd0362d71d1f'>KimonoInspectorRoundRect</a></td><td style='width:75%' ><p>Handles the inspector view for a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29b077d2-fa1f-4b59-b9c3-22ef34f57c59'>KimonoInspectorSketch</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a given <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#344b8c16-cdc9-4606-af9b-9b672d043928'>KimonoInspectorStar</a></td><td style='width:75%' ><p>Handles the inspector view for a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c'>KimonoInspectorStyle</a></td><td style='width:75%' class='def'><p>Handles the inspector view for a given <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6667936-a83f-4ed0-b092-62db0b6cab71'>KimonoInspectorText</a></td><td style='width:75%' ><p>Handles the inspector view for a given <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da5fed64-0411-45d7-bec7-b60d9c3ca60a'>KimonoTextView</a></td><td style='width:75%' class='def'><p>A type of <code>NSTextView</code> that provides a <code>TextChanged</code> event to monitor when the user adjust the text of the <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b3b76dc-f0d8-4cb3-afbe-ff8ac08ca432'>MainClass</a></td><td style='width:75%' ><p>Main class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9881a15-c33c-4bf5-8606-4829f8293008'>MainWindowController</a></td><td style='width:75%' class='def'><p>Handles the main window for the Kimono Designer app.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6838f10-2ca9-4324-90ca-7822754a9d0d'>SourceListDataSource</a></td><td style='width:75%' ><p>Source list data source.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87ea1989-9a98-4fa5-bd46-da2e4a742528'>SourceListDelegate</a></td><td style='width:75%' class='def'><p>Source list delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20b849ed-e963-46fd-ac47-3fdd0ee424fa'>SourceListItem</a></td><td style='width:75%' ><p>Source list item.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ba0f8fa-3462-4142-9024-c68716903b8f'>SourceListView</a></td><td style='width:75%' class='def'><p>Source list view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc'>ViewController</a></td><td style='width:75%' ><p>Handles the master view for the Kimono Designer.</p>
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


---

<a name="f189ef65-04ab-41ae-9966-babd6bca16b0"></a>
##MarkdownSharp

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ff737229-6209-452e-95db-a35b8db5e43d'>Markdown</a></td><td style='width:75%' ><p>Markdown is a text-to-HTML conversion tool for web writers.  Markdown allows you to write using an easy-to-read, easy-to-write plain text format,  then convert it to structurally valid XHTML (or HTML).</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7213c9b5-1045-489f-bd22-e12e2c11234c'>MarkdownOptions</a></td><td style='width:75%' class='def'><p>The public <code>MarkdownOptions</code> class inherits from the <code>System.Object</code> class and is defined in the <code>MarkdownSharp</code> namespace. It defines 6 fields, 6 properties, 13 methods and no events.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="def484e3-0345-4e02-b51c-13512214c745"></a>
##Public Class AboutViewController

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSViewController`

###Summary

Handles the About Box for Kimono Designer.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f7ab0340-97a8-467a-b97c-668ef8956a45'>AboutViewController</a></td><td style='width:75%' ><p><a name="f7ab0340-97a8-467a-b97c-668ef8956a45"></a></p>

<h3>Public Void AboutViewController (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#def484e3-0345-4e02-b51c-13512214c745">AboutViewController</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="5dfde53a-0c15-4346-9769-484b2ca67b27"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#548383ad-5a45-4774-a6ba-41fb901ab30b'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="548383ad-5a45-4774-a6ba-41fb901ab30b"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>AboutViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbe5a433-063e-4fee-a54a-61c3574371cf'>ShowIcons8License</a></td><td style='width:75%' ><p><a name="bbe5a433-063e-4fee-a54a-61c3574371cf"></a></p>

<h3>Private Void ShowIcons8License (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Shows the icons8 license.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="614f6091-6fcd-4d75-a09c-284dc3407d0b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="b6001a55-19e6-4020-9180-16fe091e8600"></a>
##Public Class ActivatableItem

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSToolbarItem`

###Summary

A type of `NSToolbarItem` that the developer can enable/disable by adjusting the  `Active` property.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b7280246-b977-439b-9511-5acc6ad23396'>Active</a></td><td style='width:75%' ><p><a name="b7280246-b977-439b-9511-5acc6ad23396"></a></p>

<h3>Public <code>System.Boolean</code> Active</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> is active.</p>

<h4>Return Value</h4>

<p><code>true</code> if active; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c221ebf9-4d44-4f2f-9e20-990ff6197b2d'>ActivatableItem</a></td><td style='width:75%' ><p><a name="c221ebf9-4d44-4f2f-9e20-990ff6197b2d"></a></p>

<h3>Public Void ActivatableItem ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5567a0f-c68f-4704-9214-b53977b810c3'>ActivatableItem</a></td><td style='width:75%' class='def'><p><a name="b5567a0f-c68f-4704-9214-b53977b810c3"></a></p>

<h3>Public Void ActivatableItem (Foundation.NSObjectFlag)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>t</td><td style='width:75%' ><p><a name="4a2d1d74-8a96-48a6-a1c8-16dd33a7aa3f"></a>
<b>Foundation.NSObjectFlag t</b></p>

<p>T.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76f7c1fb-f6ea-45c8-aa53-fa21c1f30a91'>ActivatableItem</a></td><td style='width:75%' ><p><a name="76f7c1fb-f6ea-45c8-aa53-fa21c1f30a91"></a></p>

<h3>Public Void ActivatableItem (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="8f83949e-9866-42b1-a80d-c2c6a1f7bf4b"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a9b3f3a-bb52-4b46-a2c7-e4ebc2955d08'>ActivatableItem</a></td><td style='width:75%' class='def'><p><a name="1a9b3f3a-bb52-4b46-a2c7-e4ebc2955d08"></a></p>

<h3>Public Void ActivatableItem (System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b6001a55-19e6-4020-9180-16fe091e8600">ActivatableItem</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="4a0dcb9a-6981-4f39-a424-60887cc2ff47"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5ea2488-1fa2-47f7-ae57-0a4102fb105c'>Validate</a></td><td style='width:75%' ><p><a name="b5ea2488-1fa2-47f7-ae57-0a4102fb105c"></a></p>

<h3>Public Virtual Void Validate ()</h3>

<h4>Summary</h4>

<p>Validate this instance.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#853e93ea-04d0-40a6-842f-a804c4c6f14d'>NewWindowNumber</a></td><td style='width:75%' ><p><a name="853e93ea-04d0-40a6-842f-a804c4c6f14d"></a></p>

<h3>Public <code>System.Int32</code> NewWindowNumber</h3>

<h4>Summary</h4>

<p>Gets or sets the number of the next new editor window created.</p>

<h4>Return Value</h4>

<p>The new window number.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92ae2328-e334-4a06-8ea9-6619d8d783be'>Preferences</a></td><td style='width:75%' class='def'><p><a name="92ae2328-e334-4a06-8ea9-6619d8d783be"></a></p>

<h3>Public <a href="#766cb93d-7bda-4a96-8b54-8b98a9e207fa">KimonoMac.AppPreferences</a> Preferences</h3>

<h4>Summary</h4>

<p>Gets or sets the preferences for the app.</p>

<h4>Return Value</h4>

<p>The <a href="#766cb93d-7bda-4a96-8b54-8b98a9e207fa">AppPreferences</a> for the app.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bcce0027-ab09-4367-a5c3-b82d4b99d482'>AppDelegate</a></td><td style='width:75%' ><p><a name="bcce0027-ab09-4367-a5c3-b82d4b99d482"></a></p>

<h3>Public Void AppDelegate ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b4a5fd3a-500e-4d49-a5be-aac2002d9a82">AppDelegate</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8772dee3-f8bf-46db-abdd-603fa9733f10'>DidFinishLaunching</a></td><td style='width:75%' class='def'><p><a name="8772dee3-f8bf-46db-abdd-603fa9733f10"></a></p>

<h3>Public Virtual Void DidFinishLaunching (Foundation.NSNotification)</h3>

<h4>Summary</h4>

<p>Did finish launching.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="dcc9695e-6bde-409e-841b-6513b63b4aa8"></a>
<b>Foundation.NSNotification notification</b></p>

<p>Notification.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80c20d54-37b6-4b81-bbfa-7c697c40eda0'>WillTerminate</a></td><td style='width:75%' ><p><a name="80c20d54-37b6-4b81-bbfa-7c697c40eda0"></a></p>

<h3>Public Virtual Void WillTerminate (Foundation.NSNotification)</h3>

<h4>Summary</h4>

<p>Will terminate.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="daf89b4e-9bcc-470d-a604-c00a70978659"></a>
<b>Foundation.NSNotification notification</b></p>

<p>Notification.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="766cb93d-7bda-4a96-8b54-8b98a9e207fa"></a>
##Public Class AppPreferences

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`Foundation.NSObject`

###Summary

This class handles all of the user's preferences for the app. The values are  persisted using the system-wide `NSUserDefaults.StandardUserDefaults` object.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d085eb14-09e5-4446-b50d-432e5f3bc17f'>AllowAutoComplete</a></td><td style='width:75%' ><p><a name="d085eb14-09e5-4446-b50d-432e5f3bc17f"></a></p>

<h3>Public <code>System.Boolean</code> AllowAutoComplete</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor window allows for auto complete.</p>

<h4>Return Value</h4>

<p><code>true</code> if allow auto complete; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98e23785-35f5-4d74-9719-d579a4dafa65'>AllowBackgroundColor</a></td><td style='width:75%' class='def'><p><a name="98e23785-35f5-4d74-9719-d579a4dafa65"></a></p>

<h3>Public <code>System.Boolean</code> AllowBackgroundColor</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor allows for the background color of the text to be changed.</p>

<h4>Return Value</h4>

<p><code>true</code> if allow background color; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f87f7d9-9d17-4c32-84b6-eff7fe6884e6'>AllowGraphics</a></td><td style='width:75%' ><p><a name="4f87f7d9-9d17-4c32-84b6-eff7fe6884e6"></a></p>

<h3>Public <code>System.Boolean</code> AllowGraphics</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor allows the insertion of pictures into the document text.</p>

<h4>Return Value</h4>

<p><code>true</code> if allow graphics; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28e9c1d2-186e-4836-bae4-a86e32afcce1'>AllowImageEditing</a></td><td style='width:75%' class='def'><p><a name="28e9c1d2-186e-4836-bae4-a86e32afcce1"></a></p>

<h3>Public <code>System.Boolean</code> AllowImageEditing</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor allows the user to edit images inserted into the document's text.</p>

<h4>Return Value</h4>

<p><code>true</code> if allow image editing; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#395628f2-7918-40cf-8c9e-9469e5f79e27'>AutoCompleteDefaultWords</a></td><td style='width:75%' ><p><a name="395628f2-7918-40cf-8c9e-9469e5f79e27"></a></p>

<h3>Public <code>System.Boolean</code> AutoCompleteDefaultWords</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will add the default, OS provided auto complete words.</p>

<h4>Return Value</h4>

<p><code>true</code> if auto complete default words; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b18bed2b-f304-48d4-a7dc-718a39b779c9'>AutoCompleteKeywords</a></td><td style='width:75%' class='def'><p><a name="b18bed2b-f304-48d4-a7dc-718a39b779c9"></a></p>

<h3>Public <code>System.Boolean</code> AutoCompleteKeywords</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document window will auto complete <code>Keywords</code> as defined in the document's <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>.</p>

<h4>Return Value</h4>

<p><code>true</code> if auto complete keywords; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e00704c5-7ac5-4b61-881d-5eb6e67e03bc'>AutoCorrect</a></td><td style='width:75%' ><p><a name="e00704c5-7ac5-4b61-881d-5eb6e67e03bc"></a></p>

<h3>Public <code>System.Boolean</code> AutoCorrect</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will automatically correct spelling while editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if auto correct; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdb9ad67-64d7-47f3-a66b-0a3fbe840b00'>CompleteClosures</a></td><td style='width:75%' class='def'><p><a name="bdb9ad67-64d7-47f3-a66b-0a3fbe840b00"></a></p>

<h3>Public <code>System.Boolean</code> CompleteClosures</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will automatically complete<a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> as defined in the <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> .</p>

<h4>Return Value</h4>

<p><code>true</code> if complete closures; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bec2ab4e-f4bc-4867-bbf2-8c0238dc1c26'>DataDetectors</a></td><td style='width:75%' ><p><a name="bec2ab4e-f4bc-4867-bbf2-8c0238dc1c26"></a></p>

<h3>Public <code>System.Boolean</code> DataDetectors</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will automatically detect data entered by the user shuch as phone numbers and dates.</p>

<h4>Return Value</h4>

<p><code>true</code> if data detectors; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a54f65ac-c39c-4e87-80d8-cafe10cbfcf9'>DefaultLanguage</a></td><td style='width:75%' class='def'><p><a name="a54f65ac-c39c-4e87-80d8-cafe10cbfcf9"></a></p>

<h3>Public <code>System.Int32</code> DefaultLanguage</h3>

<h4>Summary</h4>

<p>Gets or sets the default language that will be automatically selected when creating a new document.</p>

<h4>Return Value</h4>

<p>The default <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c7dd5ad-19d8-4b9a-be2d-94af5aaaec8c'>DefaultWordsOnlyIfKeywordsEmpty</a></td><td style='width:75%' ><p><a name="8c7dd5ad-19d8-4b9a-be2d-94af5aaaec8c"></a></p>

<h3>Public <code>System.Boolean</code> DefaultWordsOnlyIfKeywordsEmpty</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will only use the default, OS provided auto complete keywords in the editor's <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> return no <code>Keywords</code>.</p>

<h4>Return Value</h4>

<p><code>true</code> if default words only if keywords empty; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72ef06c0-2138-4293-81d9-86ad39c82439'>EditorBackgroundColor</a></td><td style='width:75%' class='def'><p><a name="72ef06c0-2138-4293-81d9-86ad39c82439"></a></p>

<h3>Public <code>AppKit.NSColor</code> EditorBackgroundColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the editor background of the document editor.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the editor background.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f5b8aa0-255c-4e12-ba72-99ee8d1c52e6'>GrammarChecking</a></td><td style='width:75%' ><p><a name="1f5b8aa0-255c-4e12-ba72-99ee8d1c52e6"></a></p>

<h3>Public <code>System.Boolean</code> GrammarChecking</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will check grammar while editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if grammar checking; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9194e05-fd84-499b-8598-186c1863e392'>IncrementalSearch</a></td><td style='width:75%' class='def'><p><a name="a9194e05-fd84-499b-8598-186c1863e392"></a></p>

<h3>Public <code>System.Boolean</code> IncrementalSearch</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor allows for incremental search.</p>

<h4>Return Value</h4>

<p><code>true</code> if incremental search; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3207eacf-c06c-4d5b-ac12-038491aaa86a'>LivePreviewChanges</a></td><td style='width:75%' ><p><a name="3207eacf-c06c-4d5b-ac12-038491aaa86a"></a></p>

<h3>Public <code>System.Boolean</code> LivePreviewChanges</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the Preview Window live updates as the user types.</p>

<h4>Return Value</h4>

<p><code>true</code> if live preview changes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1504a95-6760-4b27-befa-fd2d5b673b3c'>NonContinousLayout</a></td><td style='width:75%' class='def'><p><a name="b1504a95-6760-4b27-befa-fd2d5b673b3c"></a></p>

<h3>Public <code>System.Boolean</code> NonContinousLayout</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor allows for non-continous layout of the text it is editing.</p>

<h4>Return Value</h4>

<p><code>true</code> if non continous layout; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9c28b75-3526-46b4-a161-b0c901ebf456'>OnlyRomanChars</a></td><td style='width:75%' ><p><a name="d9c28b75-3526-46b4-a161-b0c901ebf456"></a></p>

<h3>Public <code>System.Boolean</code> OnlyRomanChars</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor only allows for Roman characters in the text.</p>

<h4>Return Value</h4>

<p><code>true</code> if only roman chars; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50b13271-f9e5-4907-b85b-6257a1f992f5'>RichText</a></td><td style='width:75%' class='def'><p><a name="50b13271-f9e5-4907-b85b-6257a1f992f5"></a></p>

<h3>Public <code>System.Boolean</code> RichText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will allow for rich text documents.</p>

<h4>Return Value</h4>

<p><code>true</code> if rich text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86089174-c308-409a-b915-270e94a78610'>SearchType</a></td><td style='width:75%' ><p><a name="86089174-c308-409a-b915-270e94a78610"></a></p>

<h3>Public <code>System.Int32</code> SearchType</h3>

<h4>Summary</h4>

<p>Gets or sets the type of the search the document editor uses</p>

<h4>Return Value</h4>

<p>The type of the search.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b518b9a-d212-4dc9-bdba-4c8bb54a341a'>SelectAfterWrap</a></td><td style='width:75%' class='def'><p><a name="8b518b9a-d212-4dc9-bdba-4c8bb54a341a"></a></p>

<h3>Public <code>System.Boolean</code> SelectAfterWrap</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will select all of the text that was just wrapped in a <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a>.</p>

<h4>Return Value</h4>

<p><code>true</code> if select after wrap; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac5fd496-ca78-43f3-ba75-e513ccb042b6'>SmartDashes</a></td><td style='width:75%' ><p><a name="ac5fd496-ca78-43f3-ba75-e513ccb042b6"></a></p>

<h3>Public <code>System.Boolean</code> SmartDashes</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether document editor will automatically insert dashes while editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if smart dashes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4787186c-b0af-4ef5-b7f0-d6e6047d6780'>SmartInsertDelete</a></td><td style='width:75%' class='def'><p><a name="4787186c-b0af-4ef5-b7f0-d6e6047d6780"></a></p>

<h3>Public <code>System.Boolean</code> SmartInsertDelete</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will use smart insert and delete logic while editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if smart insert delete; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f30649c-a916-495a-a96f-fabe097b3ccd'>SmartLinks</a></td><td style='width:75%' ><p><a name="0f30649c-a916-495a-a96f-fabe097b3ccd"></a></p>

<h3>Public <code>System.Boolean</code> SmartLinks</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will automatically detect links in the text.</p>

<h4>Return Value</h4>

<p><code>true</code> if smart links; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f0721ea-15bf-4927-a77e-fd09598c6a44'>SmartQuotes</a></td><td style='width:75%' class='def'><p><a name="7f0721ea-15bf-4927-a77e-fd09598c6a44"></a></p>

<h3>Public <code>System.Boolean</code> SmartQuotes</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will use typographic quotation marks when editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if smart quotes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e829245c-680f-4f5b-a998-f0a2fa3fb55d'>SpellChecking</a></td><td style='width:75%' ><p><a name="e829245c-680f-4f5b-a998-f0a2fa3fb55d"></a></p>

<h3>Public <code>System.Boolean</code> SpellChecking</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will check spelling while editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if spell checking; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a4253be-9fe0-41a4-90dc-8f31bc761406'>TextReplacement</a></td><td style='width:75%' class='def'><p><a name="5a4253be-9fe0-41a4-90dc-8f31bc761406"></a></p>

<h3>Public <code>System.Boolean</code> TextReplacement</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor will automatically perform know text replacement while editing text.</p>

<h4>Return Value</h4>

<p><code>true</code> if text replacement; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9573f1c4-7eed-4f17-a1cd-cf7dad3adab4'>UseFontPanel</a></td><td style='width:75%' ><p><a name="9573f1c4-7eed-4f17-a1cd-cf7dad3adab4"></a></p>

<h3>Public <code>System.Boolean</code> UseFontPanel</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor uses font panel.</p>

<h4>Return Value</h4>

<p><code>true</code> if use font panel; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b7c42ac-cbe9-480d-9bc7-537709a2f5ba'>UseInspectorBar</a></td><td style='width:75%' class='def'><p><a name="2b7c42ac-cbe9-480d-9bc7-537709a2f5ba"></a></p>

<h3>Public <code>System.Boolean</code> UseInspectorBar</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor uses inspector bar.</p>

<h4>Return Value</h4>

<p><code>true</code> if use inspector bar; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df4ff838-251f-446b-8261-34607b3c80a9'>UseRuler</a></td><td style='width:75%' ><p><a name="df4ff838-251f-446b-8261-34607b3c80a9"></a></p>

<h3>Public <code>System.Boolean</code> UseRuler</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the document editor uses ruler.</p>

<h4>Return Value</h4>

<p><code>true</code> if use ruler; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e10f11d-09b0-4ba6-ac88-b40b04dd06ee'>WrapClosures</a></td><td style='width:75%' class='def'><p><a name="3e10f11d-09b0-4ba6-ac88-b40b04dd06ee"></a></p>

<h3>Public <code>System.Boolean</code> WrapClosures</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the editor will wrap <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> around the selected text in the document editor.</p>

<h4>Return Value</h4>

<p><code>true</code> if wrap closures; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#09d27b14-9b27-4a07-9cd0-8e24732936f1'>AppPreferences</a></td><td style='width:75%' ><p><a name="09d27b14-9b27-4a07-9cd0-8e24732936f1"></a></p>

<h3>Public Void AppPreferences ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#766cb93d-7bda-4a96-8b54-8b98a9e207fa">AppPreferences</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8ac2256-6202-414b-9b51-3385e4376967'>LoadBool</a></td><td style='width:75%' class='def'><p><a name="f8ac2256-6202-414b-9b51-3385e4376967"></a></p>

<h3>Public <code>System.Boolean</code> LoadBool (System.String, System.Boolean)</h3>

<h4>Summary</h4>

<p>Loads the bool value from the system-wide user defaults.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' ><p><a name="e073a89f-025a-4483-847b-64e61aa8200c"></a>
<b>System.String key</b></p>

<p>The key to load the value for.</p>
</td></tr><tr><td style='width:25%' class='term'>defaultValue</td><td style='width:75%' class='def'><p><a name="f8f47538-cbf3-4799-a192-de02c7ab3d3f"></a>
<b>System.Boolean defaultValue</b></p>

<p>The default value if not found.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The value of the key or the default value if not found.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#186c42db-e300-4076-aad0-b3904ad9afcc'>LoadColor</a></td><td style='width:75%' ><p><a name="186c42db-e300-4076-aad0-b3904ad9afcc"></a></p>

<h3>Public <code>AppKit.NSColor</code> LoadColor (System.String, AppKit.NSColor)</h3>

<h4>Summary</h4>

<p>Loads the requested color from system-wide user defaults.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' ><p><a name="dca71d3d-f5fa-4c9d-9656-96bdc897851d"></a>
<b>System.String key</b></p>

<p>The user default key for the color.</p>
</td></tr><tr><td style='width:25%' class='term'>defaultValue</td><td style='width:75%' class='def'><p><a name="cc0d8714-afe7-4d83-96a8-8f212f04d22d"></a>
<b>AppKit.NSColor defaultValue</b></p>

<p>The default <code>NSColor</code> value.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>NSColor</code> for the given key or the default value if the key cannot be found in the user defaults.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a98028c-f6d3-4292-a34b-ee774e3240a6'>LoadInt</a></td><td style='width:75%' class='def'><p><a name="5a98028c-f6d3-4292-a34b-ee774e3240a6"></a></p>

<h3>Public <code>System.Int32</code> LoadInt (System.String, System.Int32)</h3>

<h4>Summary</h4>

<p>Loads the given integer value for the specified key. If the key is not found, the default value is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' ><p><a name="0feaf79e-4fa9-426c-a3ec-e2a57bb7775f"></a>
<b>System.String key</b></p>

<p>Key.</p>
</td></tr><tr><td style='width:25%' class='term'>defaultValue</td><td style='width:75%' class='def'><p><a name="41ef1206-ba37-42ae-bafc-ea570ab18994"></a>
<b>System.Int32 defaultValue</b></p>

<p>Default value.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The int.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ce389a3-fba4-4995-a9cf-7e0bf105f721'>NSColorFromHexString</a></td><td style='width:75%' ><p><a name="6ce389a3-fba4-4995-a9cf-7e0bf105f721"></a></p>

<h3>Public <code>AppKit.NSColor</code> NSColorFromHexString (System.String)</h3>

<h4>Summary</h4>

<p>Converts a web formatted hex string in the form #RRGGBB or #RRGGBBAA into a color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>hexValue</td><td style='width:75%' ><p><a name="006ae2c4-136a-4752-aec5-a0b972e211fa"></a>
<b>System.String hexValue</b></p>

<p>The web formatted hex string in the form #RRGGBB or #RRGGBBAA.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>NSColor</code> represented by the hex string.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df5e0996-c242-4b19-a24c-015119612fd3'>NSColorToHexString</a></td><td style='width:75%' class='def'><p><a name="df5e0996-c242-4b19-a24c-015119612fd3"></a></p>

<h3>Public <code>System.String</code> NSColorToHexString (AppKit.NSColor, System.Boolean)</h3>

<h4>Summary</h4>

<p>Converts the given color into a web style hex string in the form #RRBBGG or optionally #RRBBGGAA.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="00e93af2-eb23-4137-9796-2c59480e1ad7"></a>
<b>AppKit.NSColor color</b></p>

<p>The <code>NSColor</code> to convert.</p>
</td></tr><tr><td style='width:25%' class='term'>withAlpha</td><td style='width:75%' class='def'><p><a name="695303ea-4b2c-43b9-a488-23e87929628d"></a>
<b>System.Boolean withAlpha</b></p>

<p>If set to <code>true</code> with the alpha (transparency) of the color will be included.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The web hex string representing the given color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1127820-56f4-460d-8955-e9b3fd01d61a'>SaveBool</a></td><td style='width:75%' ><p><a name="d1127820-56f4-460d-8955-e9b3fd01d61a"></a></p>

<h3>Public Void SaveBool (System.String, System.Boolean, System.Boolean)</h3>

<h4>Summary</h4>

<p>Saves the bool value to the system-wide user defaults.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' ><p><a name="727e43ae-7a60-4d43-90dc-622e75911648"></a>
<b>System.String key</b></p>

<p>The key to save the value to.</p>
</td></tr><tr><td style='width:25%' class='term'>value</td><td style='width:75%' class='def'><p><a name="783a41ea-a52b-4362-8eea-0ace2e603e4b"></a>
<b>System.Boolean value</b></p>

<p>The value to save.</p>
</td></tr><tr><td style='width:25%' class='term'>sync</td><td style='width:75%' ><p><a name="5e9ffbe5-125d-4fa7-9312-6daa07326607"></a>
<b>System.Boolean sync</b></p>

<p>If set to <code>true</code> sync.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f440aa9e-bed9-4385-8203-a2ef33a219a7'>SaveColor</a></td><td style='width:75%' class='def'><p><a name="f440aa9e-bed9-4385-8203-a2ef33a219a7"></a></p>

<h3>Public Void SaveColor (System.String, AppKit.NSColor, System.Boolean)</h3>

<h4>Summary</h4>

<p>Saves the given color to the systwm-wide user defaults with the give keyword.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="6a47ec98-b640-43f1-8eb1-541f0c33bdb3"></a>
<b>AppKit.NSColor color</b></p>

<p>The <code>NSColor</code> to save to the user defaults.</p>
</td></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' class='def'><p><a name="e00abbbd-d7c7-42b2-851e-b3b6163d4fd9"></a>
<b>System.String key</b></p>

<p>The user default key to assign the color to.</p>
</td></tr><tr><td style='width:25%' class='term'>sync</td><td style='width:75%' ><p><a name="69ec85cc-9a13-44f6-91e0-eeae4deed429"></a>
<b>System.Boolean sync</b></p>

<p>If set to <code>true</code> sync changes to preferences.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e94c6288-3959-4f93-8fe3-d20e83a53ae0'>SaveInt</a></td><td style='width:75%' ><p><a name="e94c6288-3959-4f93-8fe3-d20e83a53ae0"></a></p>

<h3>Public Void SaveInt (System.String, System.Int32, System.Boolean)</h3>

<h4>Summary</h4>

<p>Saves the given integer value to the system-wide user defaults.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' ><p><a name="6b0f107b-31a1-40a5-899c-37c8e0e6fd58"></a>
<b>System.String key</b></p>

<p>The key for the integer to load.</p>
</td></tr><tr><td style='width:25%' class='term'>value</td><td style='width:75%' class='def'><p><a name="3db847d1-9e02-4290-8aa7-da1b192d8078"></a>
<b>System.Int32 value</b></p>

<p>The value of the key.</p>
</td></tr><tr><td style='width:25%' class='term'>sync</td><td style='width:75%' ><p><a name="02906135-17dc-40e9-8f8d-67f61b5f4a6b"></a>
<b>System.Boolean sync</b></p>

<p>If set to <code>true</code> sync changes to preferences.</p>
</td></tr></table></p>
</td></tr></table></p>

###Remarks

This section uses Data Binding and Key-Value Coding to bind preference values to UI Controls on the Storyboard. For more information see: http://developer.xamarin.com/guides/mac/application_fundamentals/databinding/

---

<a name="4dcbb271-b786-4581-94ef-25b12aaca68d"></a>
##Public Class CenteringClipView

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSClipView`

###Summary

Centering clip view.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c886de3f-186e-408f-b5db-150311f4dff0'>CenteringClipView</a></td><td style='width:75%' ><p><a name="c886de3f-186e-408f-b5db-150311f4dff0"></a></p>

<h3>Public Void CenteringClipView ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4dcbb271-b786-4581-94ef-25b12aaca68d">CenteringClipView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30825a5f-0b15-4dcb-b0b8-da15ee5a25a9'>CenteringClipView</a></td><td style='width:75%' class='def'><p><a name="30825a5f-0b15-4dcb-b0b8-da15ee5a25a9"></a></p>

<h3>Public Void CenteringClipView (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4dcbb271-b786-4581-94ef-25b12aaca68d">CenteringClipView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="89a7cb8c-7257-40d2-bff8-0820e0dfede5"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2848da1-31b9-4c54-9ab3-2795b21bfc9e'>ConstrainBoundsRect</a></td><td style='width:75%' ><p><a name="e2848da1-31b9-4c54-9ab3-2795b21bfc9e"></a></p>

<h3>Public Virtual <code>CoreGraphics.CGRect</code> ConstrainBoundsRect (CoreGraphics.CGRect)</h3>

<h4>Summary</h4>

<p>Constrains the bounds rect.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>proposedBounds</td><td style='width:75%' ><p><a name="673f7364-864c-4f28-ad36-f6e759897f22"></a>
<b>CoreGraphics.CGRect proposedBounds</b></p>

<p>Proposed bounds.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The bounds rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4dba180-9d42-4d6c-9b4c-2f956b8d33be'>ConvertContentInsetsToProposedBoundsSize</a></td><td style='width:75%' class='def'><p><a name="d4dba180-9d42-4d6c-9b4c-2f956b8d33be"></a></p>

<h3>Private <code>AppKit.NSEdgeInsets</code> ConvertContentInsetsToProposedBoundsSize (CoreGraphics.CGSize)</h3>

<h4>Summary</h4>

<p>Converts the size of the content insets to proposed bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>proposedBoundsSize</td><td style='width:75%' ><p><a name="5ae4e5d3-caa8-4f69-acbb-b453829ab771"></a>
<b>CoreGraphics.CGSize proposedBoundsSize</b></p>

<p>Proposed bounds size.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The content insets to proposed bounds size.</p>
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

<a name="8e5eb700-a9ce-4234-b397-6054b6a1c028"></a>
##Public Class CSharpDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

[AppKit.TextKit.Formatter.LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf)

###Summary

Defines how C# should be colorized using a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8c9fae9c-e0a0-4f5c-bd52-cc4fe9a3770e'>LanguageIdentifier</a></td><td style='width:75%' ><p><a name="8c9fae9c-e0a0-4f5c-bd52-cc4fe9a3770e"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> LanguageIdentifier</h3>

<h4>Summary</h4>

<p>Gets the language identifier.</p>

<h4>Return Value</h4>

<p>The language identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af447cef-3356-4162-8408-161360f8daa0'>LanguageSeparators</a></td><td style='width:75%' class='def'><p><a name="af447cef-3356-4162-8408-161360f8daa0"></a></p>

<h3>Public Virtual <code>System.Char[]</code> LanguageSeparators</h3>

<h4>Summary</h4>

<p>Gets or sets the language separators for C#</p>

<h4>Return Value</h4>

<p>The language separators.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2b96af8f-dd89-4f2a-8fe6-b86ce0e71bd5'>CSharpDescriptor</a></td><td style='width:75%' ><p><a name="2b96af8f-dd89-4f2a-8fe6-b86ce0e71bd5"></a></p>

<h3>Public Void CSharpDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8e5eb700-a9ce-4234-b397-6054b6a1c028">CSharpDescriptor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d6fc886-1b68-4714-9244-c0a4c099c091'>Define</a></td><td style='width:75%' class='def'><p><a name="8d6fc886-1b68-4714-9244-c0a4c099c091"></a></p>

<h3>Public Virtual Void Define ()</h3>

<h4>Summary</h4>

<p>Define this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b3c6b31-5212-41dc-8287-30a2cd8dbb1e'>FormatForPreview</a></td><td style='width:75%' ><p><a name="3b3c6b31-5212-41dc-8287-30a2cd8dbb1e"></a></p>

<h3>Public Virtual <code>System.String</code> FormatForPreview (System.String)</h3>

<h4>Summary</h4>

<p>Formats the passed in string of text for previewing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="e3dc6c68-e55f-4869-8b22-4f8e03582d0d"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The string formatted for preview.</p>
</td></tr></table></p>


---

<a name="f2695704-db23-4679-939f-9f0f65cee076"></a>
##Public Class FormatDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`Foundation.NSObject`

###Summary

The [FormatDescriptor](#f2695704-db23-4679-939f-9f0f65cee076) defines a language formmating instruction that can be used by a [LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf) to define syntax highlighting to a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#dcc037aa-357b-478b-94bb-5fda19dd20dd'>Active</a></td><td style='width:75%' ><p><a name="dcc037aa-357b-478b-94bb-5fda19dd20dd"></a></p>

<h3>Public <code>System.Boolean</code> Active</h3>

<h4>Summary</h4>

<p>Gets or sets if this format has been "activated" (if the matching <code>StartsWith</code> character sequence has been found).</p>

<h4>Return Value</h4>

<p><code>true</code> if the matching <code>StartsWith</code> character sequence has been found; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>This value should ONLY be changed by the <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3a43ab4-11ea-4111-b746-0ec55a2a8e0c'>CharIndex</a></td><td style='width:75%' class='def'><p><a name="b3a43ab4-11ea-4111-b746-0ec55a2a8e0c"></a></p>

<h3>Public <code>System.Int32</code> CharIndex</h3>

<h4>Summary</h4>

<p>Gets or sets the index of the last matching character within either the <code>StartsWith</code> or <code>EndsWith</code> based on the state of the <code>Active</code> property.</p>

<h4>Return Value</h4>

<p>The index of the char.</p>

<h4>Remarks</h4>

<p>This value should ONLY be changed by the <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bff2686-6984-4919-822b-dc9bbb8bb58c'>Color</a></td><td style='width:75%' ><p><a name="3bff2686-6984-4919-822b-dc9bbb8bb58c"></a></p>

<h3>Public <code>AppKit.NSColor</code> Color</h3>

<h4>Summary</h4>

<p>Gets or sets the forground color that text matching this format will be set to.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05648bd7-fe9c-4a82-981c-4bc97932adf1'>EndsWith</a></td><td style='width:75%' class='def'><p><a name="05648bd7-fe9c-4a82-981c-4bc97932adf1"></a></p>

<h3>Public <code>System.String</code> EndsWith</h3>

<h4>Summary</h4>

<p>Gets or sets the character sequence that text matching this format ends with.</p>

<h4>Return Value</h4>

<p>The ending <code>string</code> sequence.</p>

<h4>Remarks</h4>

<p>This value will be an empty string ("") if the <code>Type</code> is a <code>Prefix</code> format.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#687bcdcd-e102-44cb-bcb1-afcece7adb68'>StartsWith</a></td><td style='width:75%' ><p><a name="687bcdcd-e102-44cb-bcb1-afcece7adb68"></a></p>

<h3>Public <code>System.String</code> StartsWith</h3>

<h4>Summary</h4>

<p>Gets or sets the character sequence that this format starts with.</p>

<h4>Return Value</h4>

<p>The starting <code>string</code> sequence.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7ccba95-bb1f-4f74-b639-f6da9be19e65'>Triggered</a></td><td style='width:75%' class='def'><p><a name="a7ccba95-bb1f-4f74-b639-f6da9be19e65"></a></p>

<h3>Public Read Only <code>System.Boolean</code> Triggered</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> is "triggered" (all of the <code>StartsWith</code> or <code>EndsWith</code> characters have been found based on the <code>Active</code> property).</p>

<h4>Return Value</h4>

<p><code>true</code> if triggered; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc0641f3-c6d3-4813-9a7c-0a0c5ab67331'>Type</a></td><td style='width:75%' ><p><a name="cc0641f3-c6d3-4813-9a7c-0a0c5ab67331"></a></p>

<h3>Public <a href="#61a7d985-5834-4f1a-8f00-04b08c6d9093">AppKit.TextKit.Formatter.FormatDescriptorType</a> Type</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>FormatDescriptorType</code> for this format descriptor.</p>

<h4>Return Value</h4>

<p>The <code>FormatDescriptorType</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#83f042a3-d423-4d50-80b6-53dc8d9754c8'>FormatDescriptor</a></td><td style='width:75%' ><p><a name="83f042a3-d423-4d50-80b6-53dc8d9754c8"></a></p>

<h3>Public Void FormatDescriptor (System.String, AppKit.NSColor)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startsWith</td><td style='width:75%' ><p><a name="f1dd8907-8e05-4a35-be9a-a10f2a69f8de"></a>
<b>System.String startsWith</b></p>

<p>The starting character sequence for this format.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="536c9e59-9e1c-426d-9d35-5eda0d2cd1d3"></a>
<b>AppKit.NSColor color</b></p>

<p>The <code>NSColor</code> that text in this sequence will be set too.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>The <code>type</code> will automatically be set to <code>Prefix</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8726933-f1bd-470a-870c-0b84f4c9d855'>FormatDescriptor</a></td><td style='width:75%' class='def'><p><a name="a8726933-f1bd-470a-870c-0b84f4c9d855"></a></p>

<h3>Public Void FormatDescriptor (System.String, System.String, AppKit.NSColor)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startsWith</td><td style='width:75%' ><p><a name="84ace51e-7f81-443b-aaf6-78e5a63c8119"></a>
<b>System.String startsWith</b></p>

<p>The starting character sequence for this format.</p>
</td></tr><tr><td style='width:25%' class='term'>endsWith</td><td style='width:75%' class='def'><p><a name="8e8a4c30-c75d-436a-af8a-467e0b64a99f"></a>
<b>System.String endsWith</b></p>

<p>The ending character sequence for this format.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="d9059981-f732-482b-bdff-90d0fda3a4c8"></a>
<b>AppKit.NSColor color</b></p>

<p>The <code>NSColor</code> that text in this sequence will be set too.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>The <code>type</code> will automatically be set to <code>Enclosure</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07ba9f0f-0a19-45e3-ada3-ebfc2a12598c'>MatchesCharacter</a></td><td style='width:75%' ><p><a name="07ba9f0f-0a19-45e3-ada3-ebfc2a12598c"></a></p>

<h3>Public <code>System.Boolean</code> MatchesCharacter (System.Char)</h3>

<h4>Summary</h4>

<p>Tests to see if the passed in character matches the character at <code>CharIndex</code> of either the <code>StartsWith</code> or <code>EndsWith</code> character sequence based on the state of the <code>Active</code> property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="19efbee9-024c-4a79-bc4a-dfe896bdbd0e"></a>
<b>System.Char c</b></p>

<p>The character being tested.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if character was matched, <code>false</code> otherwise.</p>
</td></tr></table></p>


---

<a name="61a7d985-5834-4f1a-8f00-04b08c6d9093"></a>
##Public Enum FormatDescriptorType

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`System.Enum`

###Summary

Defines the type of a [FormatDescriptor](#f2695704-db23-4679-939f-9f0f65cee076).
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a97259ed-3f13-423d-a966-0068a2949648'>Enclosure</a></td><td style='width:75%' ><p><a name="a97259ed-3f13-423d-a966-0068a2949648"></a>
<b>Public Static Constant <a href="#61a7d985-5834-4f1a-8f00-04b08c6d9093">AppKit.TextKit.Formatter.FormatDescriptorType</a> Enclosure = <code>1</code></b></p>

<p>Defines a format that is enclosed between a starting and ending character sequence.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90fb9a3f-6384-4071-bf23-3b9d8c273135'>Prefix</a></td><td style='width:75%' class='def'><p><a name="90fb9a3f-6384-4071-bf23-3b9d8c273135"></a>
<b>Public Static Constant <a href="#61a7d985-5834-4f1a-8f00-04b08c6d9093">AppKit.TextKit.Formatter.FormatDescriptorType</a> Prefix = <code>0</code></b></p>

<p>Defines a format that starts with a given character sequence and runs to the end of the line.</p>
</td></tr></table></p>


---

<a name="ac971230-5eb9-4a27-9317-dc6de370d8be"></a>
##Public Class HTMLDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

[AppKit.TextKit.Formatter.LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf)

###Summary

Defines how HTML should be colorized using a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ea0fb1c6-ca6b-4b3b-b7fb-72707aeaeb7c'>LanguageIdentifier</a></td><td style='width:75%' ><p><a name="ea0fb1c6-ca6b-4b3b-b7fb-72707aeaeb7c"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> LanguageIdentifier</h3>

<h4>Summary</h4>

<p>Gets the language identifier.</p>

<h4>Return Value</h4>

<p>The language identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddcf5e8f-4270-4413-a051-1ee8fab3d16b'>LanguageSeparators</a></td><td style='width:75%' class='def'><p><a name="ddcf5e8f-4270-4413-a051-1ee8fab3d16b"></a></p>

<h3>Public Virtual <code>System.Char[]</code> LanguageSeparators</h3>

<h4>Summary</h4>

<p>Gets or sets the language separators for HTML.</p>

<h4>Return Value</h4>

<p>The language separators.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1fe98883-1839-4f8e-b214-789723e0a896'>Define</a></td><td style='width:75%' ><p><a name="1fe98883-1839-4f8e-b214-789723e0a896"></a></p>

<h3>Public Virtual Void Define ()</h3>

<h4>Summary</h4>

<p>Define this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#055e21b0-9563-4965-b5d8-d366e04dd8f6'>HTMLDescriptor</a></td><td style='width:75%' class='def'><p><a name="055e21b0-9563-4965-b5d8-d366e04dd8f6"></a></p>

<h3>Public Void HTMLDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ac971230-5eb9-4a27-9317-dc6de370d8be">HTMLDescriptor</a> class.</p>
</td></tr></table></p>

###Remarks

This is a simplified, sample format provided as an example only. The `HighlightSyntaxRegion` method of the [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee) would need to be modified to properly format HTML Keywords as the current version was designed for languages like C#, JavaScript or Visual Basic.

---

<a name="c44d4017-143a-4222-a7ea-515fa98aa272"></a>
##Public Enum InspectorViewMode

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`System.Enum`

###Summary

Used to set the current inspectors type being shown in the inspector sidebar.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#13f3c659-4171-4073-b180-868b34cc25bc'>BorderStyleView</a></td><td style='width:75%' ><p><a name="13f3c659-4171-4073-b180-868b34cc25bc"></a>
<b>Public Static Constant <a href="#c44d4017-143a-4222-a7ea-515fa98aa272">KimonoMac.InspectorViewMode</a> BorderStyleView = <code>2</code></b></p>

<p>The border style view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d790b10d-ba92-447c-bcb5-add48346c98f'>ConnectionView</a></td><td style='width:75%' class='def'><p><a name="d790b10d-ba92-447c-bcb5-add48346c98f"></a>
<b>Public Static Constant <a href="#c44d4017-143a-4222-a7ea-515fa98aa272">KimonoMac.InspectorViewMode</a> ConnectionView = <code>3</code></b></p>

<p>The connection view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e2f0931-8259-438c-b161-1a73fb971bca'>DetailsView</a></td><td style='width:75%' ><p><a name="0e2f0931-8259-438c-b161-1a73fb971bca"></a>
<b>Public Static Constant <a href="#c44d4017-143a-4222-a7ea-515fa98aa272">KimonoMac.InspectorViewMode</a> DetailsView = <code>0</code></b></p>

<p>The general details view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7008537-d174-47f3-b208-d7c00dccbbce'>FillStyleView</a></td><td style='width:75%' class='def'><p><a name="b7008537-d174-47f3-b208-d7c00dccbbce"></a>
<b>Public Static Constant <a href="#c44d4017-143a-4222-a7ea-515fa98aa272">KimonoMac.InspectorViewMode</a> FillStyleView = <code>1</code></b></p>

<p>The fill style view.</p>
</td></tr></table></p>


---

<a name="9146e8cc-76d1-4777-bbdd-3912a5209854"></a>
##ItemSelectedDelegate

###Namespace

[KimonoMac.SourceListView](#beadeded-5081-43aa-bf9a-5df81248d624)

###Summary

Item selected delegate.

---

<a name="56094def-ccde-45a2-987f-18730526fdc6"></a>
##Public Class KeywordDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`System.Object`

###Summary

The [KeywordDescriptor](#56094def-ccde-45a2-987f-18730526fdc6) class defines a keyword that will be set to a specific color when used with a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee) to do syntax highlighting in a `NSTextView`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#54d090c3-1c67-493a-ac24-8c0065daf511'>Color</a></td><td style='width:75%' ><p><a name="54d090c3-1c67-493a-ac24-8c0065daf511"></a></p>

<h3>Public <code>AppKit.NSColor</code> Color</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>NSColor</code> that the <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> will set this keyword to.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1686d46-bfff-42a4-ae09-bd02c7190153'>Tooltip</a></td><td style='width:75%' class='def'><p><a name="a1686d46-bfff-42a4-ae09-bd02c7190153"></a></p>

<h3>Public <code>System.String</code> Tooltip</h3>

<h4>Summary</h4>

<p>Gets or sets the tooltip used to define this keyword.</p>

<h4>Return Value</h4>

<p>The tooltip.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8932ba5-52ff-48c9-b8d7-aa016d9bec2e'>Type</a></td><td style='width:75%' ><p><a name="a8932ba5-52ff-48c9-b8d7-aa016d9bec2e"></a></p>

<h3>Public <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> Type</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>KeywordType</code>.</p>

<h4>Return Value</h4>

<p>The type.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eedb64a4-1207-4a7a-9736-84ed2784a49a'>KeywordDescriptor</a></td><td style='width:75%' ><p><a name="eedb64a4-1207-4a7a-9736-84ed2784a49a"></a></p>

<h3>Public Void KeywordDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#56094def-ccde-45a2-987f-18730526fdc6">KeywordDescriptor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd796615-3632-4486-86b3-148adc48d1f0'>KeywordDescriptor</a></td><td style='width:75%' class='def'><p><a name="dd796615-3632-4486-86b3-148adc48d1f0"></a></p>

<h3>Public Void KeywordDescriptor (AppKit.TextKit.Formatter.KeywordType, AppKit.NSColor, System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#56094def-ccde-45a2-987f-18730526fdc6">KeywordDescriptor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>type</td><td style='width:75%' ><p><a name="a04149e1-9c54-4c52-9155-22862df159c9"></a>
<b>AppKit.TextKit.Formatter.KeywordType type</b></p>

<p>Specifies the <code>KeywordType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="4d0713f8-8833-4b36-ac47-2367d0daaf87"></a>
<b>AppKit.NSColor color</b></p>

<p>Specifies the <code>NSColor</code> that this keyword will be set to.</p>
</td></tr><tr><td style='width:25%' class='term'>toolTip</td><td style='width:75%' ><p><a name="352fa111-806c-4cea-9f48-40dfc7976f1b"></a>
<b>System.String toolTip</b></p>

<p>Defines the tool tip for this keyword.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="4de5caf8-60e5-4fc7-9ee4-dd0231bf804c"></a>
##Public Enum KeywordType

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`System.Enum`

###Summary

Defines the type of a [KeywordDescriptor](#56094def-ccde-45a2-987f-18730526fdc6).
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0f0d88b9-5221-4dfc-8549-0879550d2fbf'>AccessKeywords</a></td><td style='width:75%' ><p><a name="0f0d88b9-5221-4dfc-8549-0879550d2fbf"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> AccessKeywords = <code>15</code></b></p>

<p>An access keyword such as <code>this</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e826d347-2bd4-4e2f-b0c0-9710c71a8ddb'>AccessModifier</a></td><td style='width:75%' class='def'><p><a name="e826d347-2bd4-4e2f-b0c0-9710c71a8ddb"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> AccessModifier = <code>4</code></b></p>

<p>An access modifier keyword such as <code>public</code> or <code>private</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3e1a37a-60fb-4166-b2ca-a193cfb06cea'>ContextualKeywords</a></td><td style='width:75%' ><p><a name="f3e1a37a-60fb-4166-b2ca-a193cfb06cea"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> ContextualKeywords = <code>17</code></b></p>

<p>A contextual keyword such as <code>get</code> or <code>set</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dbcb3d2-96aa-4049-b8b6-c9adaba6ecf2'>ConversionKeyword</a></td><td style='width:75%' class='def'><p><a name="3dbcb3d2-96aa-4049-b8b6-c9adaba6ecf2"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> ConversionKeyword = <code>14</code></b></p>

<p>A conversion keyword such as <code>explicit</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28b481b8-6dd9-4bfb-870e-e62c114d610f'>ExceptionHandlingStatement</a></td><td style='width:75%' ><p><a name="28b481b8-6dd9-4bfb-870e-e62c114d610f"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> ExceptionHandlingStatement = <code>9</code></b></p>

<p>A exception handling statement keyword such as <code>try</code> or <code>catch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4261c14-767e-468b-b479-5918beeb53e8'>IterationStatement</a></td><td style='width:75%' class='def'><p><a name="f4261c14-767e-468b-b479-5918beeb53e8"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> IterationStatement = <code>7</code></b></p>

<p>An iteration statement keyword such as <code>for</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#775c05d0-8590-45b5-a878-c96574f74e09'>JumpStatement</a></td><td style='width:75%' ><p><a name="775c05d0-8590-45b5-a878-c96574f74e09"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> JumpStatement = <code>8</code></b></p>

<p>A jump statement keyword such as <code>break</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d5db475-915e-4815-bd9c-191963f1f47a'>Keyword</a></td><td style='width:75%' class='def'><p><a name="3d5db475-915e-4815-bd9c-191963f1f47a"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> Keyword = <code>0</code></b></p>

<p>A generic keyword that doesn't fall under one of the other types.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d28a8f1-411a-4ca3-96b4-4c4befa67ce5'>LiteralKeywords</a></td><td style='width:75%' ><p><a name="6d28a8f1-411a-4ca3-96b4-4c4befa67ce5"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> LiteralKeywords = <code>16</code></b></p>

<p>A literal keyword such as <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3888066e-f717-4012-94dc-c647709ecab7'>MethodParameters</a></td><td style='width:75%' class='def'><p><a name="3888066e-f717-4012-94dc-c647709ecab7"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> MethodParameters = <code>11</code></b></p>

<p>A method parameters ketword such as <code>out</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72de3d63-a817-487b-b754-8becdb5ce50e'>Modifier</a></td><td style='width:75%' ><p><a name="72de3d63-a817-487b-b754-8becdb5ce50e"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> Modifier = <code>5</code></b></p>

<p>A geeneric modifier type of keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b796318-b744-4016-9e90-a06a3002288d'>NamespaceKeyword</a></td><td style='width:75%' class='def'><p><a name="0b796318-b744-4016-9e90-a06a3002288d"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> NamespaceKeyword = <code>12</code></b></p>

<p>A namespace keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6000826b-527d-4cb9-816d-fcc74b9b3956'>OperatorKeyword</a></td><td style='width:75%' ><p><a name="6000826b-527d-4cb9-816d-fcc74b9b3956"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> OperatorKeyword = <code>13</code></b></p>

<p>An operator keyword such as <code>sizeof</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45dbc521-c198-4871-9964-a24c86d59c3b'>PreprocessorDirective</a></td><td style='width:75%' class='def'><p><a name="45dbc521-c198-4871-9964-a24c86d59c3b"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> PreprocessorDirective = <code>19</code></b></p>

<p>A preprocessor directive keyword like <code>#if</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#974290dd-83d8-40e5-8dba-5ce0c88622e5'>QueryKeywords</a></td><td style='width:75%' ><p><a name="974290dd-83d8-40e5-8dba-5ce0c88622e5"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> QueryKeywords = <code>18</code></b></p>

<p>A query keywords such as <code>select</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c447d830-74e6-4ca9-b02e-8fe23cf9a5eb'>ReferenceType</a></td><td style='width:75%' class='def'><p><a name="c447d830-74e6-4ca9-b02e-8fe23cf9a5eb"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> ReferenceType = <code>3</code></b></p>

<p>A reference variable type such as <code>object</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a654f31a-79af-49d2-a242-cbde6bde1bed'>SelectionStatement</a></td><td style='width:75%' ><p><a name="a654f31a-79af-49d2-a242-cbde6bde1bed"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> SelectionStatement = <code>6</code></b></p>

<p>A selection statement keyword such as <code>if</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9386f37e-a6e6-4562-9314-6f62c943e606'>Statement</a></td><td style='width:75%' class='def'><p><a name="9386f37e-a6e6-4562-9314-6f62c943e606"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> Statement = <code>10</code></b></p>

<p>A generic statement keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5c20c01-229f-4b53-bd00-53cb53cae1d0'>Type</a></td><td style='width:75%' ><p><a name="e5c20c01-229f-4b53-bd00-53cb53cae1d0"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> Type = <code>1</code></b></p>

<p>The generic variable type keyword such as <code>var</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e895c7e2-642c-4720-a9b8-bc3e0ddc50f9'>ValueType</a></td><td style='width:75%' class='def'><p><a name="e895c7e2-642c-4720-a9b8-bc3e0ddc50f9"></a>
<b>Public Static Constant <a href="#4de5caf8-60e5-4fc7-9ee4-dd0231bf804c">AppKit.TextKit.Formatter.KeywordType</a> ValueType = <code>2</code></b></p>

<p>A variable type keyword such as <code>string</code> or <code>int</code>.</p>
</td></tr></table></p>


---

<a name="fbd844de-247a-4e17-9ab5-e5cda997b4a0"></a>
##Public Class KimonoInspectorArrow

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a `KimonoShapeArrow`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ab2f6b30-4a83-4b01-acd1-881fde96be1c'>_selectedShape</a></td><td style='width:75%' ><p><a name="ab2f6b30-4a83-4b01-acd1-881fde96be1c"></a>
<b>Private <code>KimonoCore.KimonoShapeArrow</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#393f177d-9017-4abc-9b3c-61d03333167d'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="393f177d-9017-4abc-9b3c-61d03333167d"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorArrow</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3a7c8365-a956-44cb-a3c9-4c5367f3d54e'>DesignSurface</a></td><td style='width:75%' ><p><a name="3a7c8365-a956-44cb-a3c9-4c5367f3d54e"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e7e449c-49cc-4a66-84e6-5581ea345e2d'>HeadCheckbox</a></td><td style='width:75%' class='def'><p><a name="4e7e449c-49cc-4a66-84e6-5581ea345e2d"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> HeadCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>HeadCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7628436f-98ed-41e2-bb74-1a4617dce35e'>InnerSlider</a></td><td style='width:75%' ><p><a name="7628436f-98ed-41e2-bb74-1a4617dce35e"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> InnerSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>InnerSlider</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93bef69c-28d6-4290-b58a-483fb58fcad8'>InnerValue</a></td><td style='width:75%' class='def'><p><a name="93bef69c-28d6-4290-b58a-483fb58fcad8"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> InnerValue</h3>

<h4>Summary</h4>

<p>The private read only <code>InnerValue</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7909b796-d8b2-4ecb-994d-f08af2484966'>OuterSlider</a></td><td style='width:75%' ><p><a name="7909b796-d8b2-4ecb-994d-f08af2484966"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> OuterSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>OuterSlider</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df19f284-d80a-4def-b46a-a8ff938fcd19'>OuterValue</a></td><td style='width:75%' class='def'><p><a name="df19f284-d80a-4def-b46a-a8ff938fcd19"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> OuterValue</h3>

<h4>Summary</h4>

<p>The private read only <code>OuterValue</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8ad04e7-8c6e-4ef7-a10e-de14e8d0a83d'>SelectedShape</a></td><td style='width:75%' ><p><a name="e8ad04e7-8c6e-4ef7-a10e-de14e8d0a83d"></a></p>

<h3>Public <code>KimonoCore.KimonoShapeArrow</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ea283b7-9914-42bb-8262-0c354bd6838b'>StreamlinedCheckbox</a></td><td style='width:75%' class='def'><p><a name="4ea283b7-9914-42bb-8262-0c354bd6838b"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> StreamlinedCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>StreamlinedCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77f16d54-a28a-4bd2-a1e2-0ebb5f8cc673'>TailCheckbox</a></td><td style='width:75%' ><p><a name="77f16d54-a28a-4bd2-a1e2-0ebb5f8cc673"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> TailCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>TailCheckbox</code> property of the <code>KimonoInspectorArrow</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5d3a4d36-06ca-410f-ab29-edf02030fc8c'>HeadChanged</a></td><td style='width:75%' ><p><a name="5d3a4d36-06ca-410f-ab29-edf02030fc8c"></a></p>

<h3>Private Void HeadChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the has head value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c807ab7f-ee96-4c1d-89d9-1697b3cd5789"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1e027a0-272d-4300-a50c-43eeca9816c4'>Initialize</a></td><td style='width:75%' class='def'><p><a name="e1e027a0-272d-4300-a50c-43eeca9816c4"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c576d990-9445-44b1-b610-e9f2c9e31d98'>InnerChanged</a></td><td style='width:75%' ><p><a name="c576d990-9445-44b1-b610-e9f2c9e31d98"></a></p>

<h3>Private Void InnerChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the inner value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="bde69cb5-9507-43a9-a237-379b4d37a194"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41679892-5680-4898-85d4-c30cc76601b0'>KimonoInspectorArrow</a></td><td style='width:75%' class='def'><p><a name="41679892-5680-4898-85d4-c30cc76601b0"></a></p>

<h3>Public Void KimonoInspectorArrow (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fbd844de-247a-4e17-9ab5-e5cda997b4a0">KimonoInspectorArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="2f5e878c-67f3-45e0-8791-eb0e8600dd13"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0e55171-0180-4f89-82ff-9fb8ebe1bf78'>MoveTo</a></td><td style='width:75%' ><p><a name="c0e55171-0180-4f89-82ff-9fb8ebe1bf78"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the give location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="3906b1cd-d9fc-466d-97dc-5f76bc848f27"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c72c563-d225-444a-997c-1957f132bfaa'>OuterChanged</a></td><td style='width:75%' class='def'><p><a name="2c72c563-d225-444a-997c-1957f132bfaa"></a></p>

<h3>Private Void OuterChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the outer value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a444677a-51da-484a-8247-d8338cd9deeb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcf996f2-3839-47a6-88d9-fe45fdb922c4'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="dcf996f2-3839-47a6-88d9-fe45fdb922c4"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e31e5936-0b10-4485-bc91-7a1093893fdb'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="e31e5936-0b10-4485-bc91-7a1093893fdb"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorArrow</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c5bcde1-7ad3-4a6b-a860-f1e143f1dfb5'>StreamlinedChanged</a></td><td style='width:75%' ><p><a name="6c5bcde1-7ad3-4a6b-a860-f1e143f1dfb5"></a></p>

<h3>Private Void StreamlinedChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the streamline value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a6440cc8-45af-4b50-bd54-2ee6121f755b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94a82a98-3a6c-4330-9292-22aa77ed5b34'>TailChanged</a></td><td style='width:75%' class='def'><p><a name="94a82a98-3a6c-4330-9292-22aa77ed5b34"></a></p>

<h3>Private Void TailChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the has tail value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c248c3f8-094a-40a9-90fe-afe2e1d2fe7e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3356573-c5bd-4c0e-9ffb-a5b56ec11c51'>UpdateInspector</a></td><td style='width:75%' ><p><a name="f3356573-c5bd-4c0e-9ffb-a5b56ec11c51"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b644d2ec-fe09-40f8-8ad7-7681be6edd9e'>ShapeModified</a></td><td style='width:75%' ><p><a name="b644d2ec-fe09-40f8-8ad7-7681be6edd9e"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#52fe96aa-3b61-4985-9a0b-3178d35ded6a'>_selectedShape</a></td><td style='width:75%' ><p><a name="52fe96aa-3b61-4985-9a0b-3178d35ded6a"></a>
<b>Private <code>KimonoCore.KimonoShape</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38c03433-59c8-484e-a694-23e12175beb5'>_selectedStyle</a></td><td style='width:75%' class='def'><p><a name="38c03433-59c8-484e-a694-23e12175beb5"></a>
<b>Private <code>KimonoCore.KimonoStyle</code> _selectedStyle</b></p>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ac4dafd-6c98-47b2-affe-7f32afbcc550'>ConvertToStyle</a></td><td style='width:75%' ><p><a name="0ac4dafd-6c98-47b2-affe-7f32afbcc550"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ConvertToStyle</b></p>

<p>The private <code>ConvertToStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#685b68df-f61a-4a69-ad63-fa79c6f46905'>EditAttachedStyle</a></td><td style='width:75%' class='def'><p><a name="685b68df-f61a-4a69-ad63-fa79c6f46905"></a>
<b>Private <code>KimonoCore.Kimono.StyleEventDelegate</code> EditAttachedStyle</b></p>

<p>The private <code>EditAttachedStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41b44da8-9ccd-42a2-806a-f7a8c4ff4f15'>RemoveStyle</a></td><td style='width:75%' ><p><a name="41b44da8-9ccd-42a2-806a-f7a8c4ff4f15"></a>
<b>Private <code>KimonoCore.Kimono.StyleEventDelegate</code> RemoveStyle</b></p>

<p>The private <code>RemoveStyle</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce8725ca-f6e0-4ccc-ab86-fcc929e6493c'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="ce8725ca-f6e0-4ccc-ab86-fcc929e6493c"></a>
<b>Private <code>KimonoCore.Kimono.ShapeEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eba0229-bf86-441c-a4d3-da268bed30eb'>StyleModified</a></td><td style='width:75%' ><p><a name="0eba0229-bf86-441c-a4d3-da268bed30eb"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> StyleModified</b></p>

<p>The private <code>StyleModified</code> field of the <code>KimonoInspectorAttachedStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5221982d-8379-45ba-92c0-c2e29c407a5d'>DesignSurface</a></td><td style='width:75%' ><p><a name="5221982d-8379-45ba-92c0-c2e29c407a5d"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ecdd2f5-8c48-4e62-aeac-91951c2226f8'>EditButton</a></td><td style='width:75%' class='def'><p><a name="4ecdd2f5-8c48-4e62-aeac-91951c2226f8"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> EditButton</h3>

<h4>Summary</h4>

<p>The private read only <code>EditButton</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4634a080-3c65-4de2-8897-f92c717bf669'>Portfolio</a></td><td style='width:75%' ><p><a name="4634a080-3c65-4de2-8897-f92c717bf669"></a></p>

<h3>Public Read Only <code>KimonoCore.KimonoPortfolio</code> Portfolio</h3>

<h4>Summary</h4>

<p>Gets the portfolio.</p>

<h4>Return Value</h4>

<p>The portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca2315ca-587a-4e14-a2cd-c6d84046994d'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="ca2315ca-587a-4e14-a2cd-c6d84046994d"></a></p>

<h3>Public <code>KimonoCore.KimonoShape</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8c61467-0691-40c1-90e1-94fa5945b0ea'>SelectedStyle</a></td><td style='width:75%' ><p><a name="b8c61467-0691-40c1-90e1-94fa5945b0ea"></a></p>

<h3>Public <code>KimonoCore.KimonoStyle</code> SelectedStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the selected style.</p>

<h4>Return Value</h4>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab67efaa-95ef-407e-a124-67f7d4d2f2b4'>StyleSelector</a></td><td style='width:75%' class='def'><p><a name="ab67efaa-95ef-407e-a124-67f7d4d2f2b4"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> StyleSelector</h3>

<h4>Summary</h4>

<p>The private read only <code>StyleSelector</code> property of the <code>KimonoInspectorAttachedStyle</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e829ac2e-b4de-4023-bc38-af2bdf020e3c'>EditStyle</a></td><td style='width:75%' ><p><a name="e829ac2e-b4de-4023-bc38-af2bdf020e3c"></a></p>

<h3>Private Void EditStyle (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Calls the editor for the given style.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1cb3ffc7-1a4d-4ea0-be24-815851b5e4ef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90b5d8a7-f9b6-4ca5-a395-74f8f31e6339'>Initialize</a></td><td style='width:75%' class='def'><p><a name="90b5d8a7-f9b6-4ca5-a395-74f8f31e6339"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ce72cea-43f5-4e96-8451-7c8f85fbf818'>KimonoInspectorAttachedStyle</a></td><td style='width:75%' ><p><a name="4ce72cea-43f5-4e96-8451-7c8f85fbf818"></a></p>

<h3>Public Void KimonoInspectorAttachedStyle (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#eb950e5f-f53b-47ee-a68f-7bcb0d06a262">KimonoInspectorAttachedStyle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="0e70e07d-a860-4a28-9a4c-476c735162b2"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af12c474-b69d-492f-828c-6457e7d6057a'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="af12c474-b69d-492f-828c-6457e7d6057a"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="f4e229a6-6cba-41be-baf7-466589528b11"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the size of the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58906b73-602b-470c-aac1-de4408abf845'>RaiseConvertToStyle</a></td><td style='width:75%' ><p><a name="58906b73-602b-470c-aac1-de4408abf845"></a></p>

<h3>Void RaiseConvertToStyle ()</h3>

<h4>Summary</h4>

<p>Raises the convert to style event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47004845-c3fe-4830-8f7e-0bc145fffd63'>RaiseEditAttachedStyle</a></td><td style='width:75%' class='def'><p><a name="47004845-c3fe-4830-8f7e-0bc145fffd63"></a></p>

<h3>Void RaiseEditAttachedStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the edit attached style event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="2186cfdb-a5f0-47be-8c43-1aaeff63217f"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f27ce31c-39f3-4dcc-9a94-d695d880d5e1'>RaiseRemoveStyle</a></td><td style='width:75%' ><p><a name="f27ce31c-39f3-4dcc-9a94-d695d880d5e1"></a></p>

<h3>Void RaiseRemoveStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the remove style event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="7e06bbf0-f7b7-4342-aa03-7b18ef934d49"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed8480ac-bf5c-4bad-8cec-661dbca95408'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p><a name="ed8480ac-bf5c-4bad-8cec-661dbca95408"></a></p>

<h3>Void RaiseShapeModified (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="5a4f6374-380e-4462-9f30-806ae99bdda8"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a6ae254-de2f-43f0-ab8a-49ec53af6ca1'>RaiseStyleModified</a></td><td style='width:75%' ><p><a name="2a6ae254-de2f-43f0-ab8a-49ec53af6ca1"></a></p>

<h3>Void RaiseStyleModified ()</h3>

<h4>Summary</h4>

<p>Raises the style modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5f8e242-76ea-43b2-8aed-db44774bc09a'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="a5f8e242-76ea-43b2-8aed-db44774bc09a"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorAttachedStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f1c1ffc-58d3-40a5-88f6-0440f4b94768'>StyleChanged</a></td><td style='width:75%' ><p><a name="6f1c1ffc-58d3-40a5-88f6-0440f4b94768"></a></p>

<h3>Private Void StyleChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Hnadles the style changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a25d485e-9124-4be6-81ff-8e711d1ca797"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9de1da6e-ca2b-487b-b143-7b881fe0ab80'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="9de1da6e-ca2b-487b-b143-7b881fe0ab80"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a0ff07ea-6091-4897-b8e0-50e50ad3a91c'>ConvertToStyle</a></td><td style='width:75%' ><p><a name="a0ff07ea-6091-4897-b8e0-50e50ad3a91c"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ConvertToStyle</h3>

<h4>Summary</h4>

<p>Occurs when convert to style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1482993f-e4d3-4593-a7da-cce7a67d151e'>EditAttachedStyle</a></td><td style='width:75%' class='def'><p><a name="1482993f-e4d3-4593-a7da-cce7a67d151e"></a></p>

<h3><code>KimonoCore.Kimono.StyleEventDelegate</code> EditAttachedStyle</h3>

<h4>Summary</h4>

<p>Occurs when edit attached style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6d09678-7e11-422f-b6d3-e28327abaa4d'>RemoveStyle</a></td><td style='width:75%' ><p><a name="f6d09678-7e11-422f-b6d3-e28327abaa4d"></a></p>

<h3><code>KimonoCore.Kimono.StyleEventDelegate</code> RemoveStyle</h3>

<h4>Summary</h4>

<p>Occurs when remove style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d2ec37e-143d-482e-98ad-b687388f8db9'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="2d2ec37e-143d-482e-98ad-b687388f8db9"></a></p>

<h3><code>KimonoCore.Kimono.ShapeEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57b4dd85-d60c-419b-af79-9c0419842422'>StyleModified</a></td><td style='width:75%' ><p><a name="57b4dd85-d60c-419b-af79-9c0419842422"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> StyleModified</h3>

<h4>Summary</h4>

<p>Occurs when style modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8a1186be-50dc-422b-9a1f-1a7efb6ef994'>_selectedStyle</a></td><td style='width:75%' ><p><a name="8a1186be-50dc-422b-9a1f-1a7efb6ef994"></a>
<b>Private <code>KimonoCore.KimonoStyle</code> _selectedStyle</b></p>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d3e25b5-8a2e-4bdb-8f17-560f72410c6f'>MakeNewColor</a></td><td style='width:75%' class='def'><p><a name="4d3e25b5-8a2e-4bdb-8f17-560f72410c6f"></a>
<b>Private <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> MakeNewColor</b></p>

<p>The private <code>MakeNewColor</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#060cd192-e1b6-4a50-b445-42bfde86ccf3'>ShapeModified</a></td><td style='width:75%' ><p><a name="060cd192-e1b6-4a50-b445-42bfde86ccf3"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFill</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6a064e14-1ce2-4d3d-898c-4a21abb6f23c'>AddColorButton</a></td><td style='width:75%' ><p><a name="6a064e14-1ce2-4d3d-898c-4a21abb6f23c"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AddColorButton</h3>

<h4>Summary</h4>

<p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d277869-5b5d-4147-980a-1c6fd5a86f5b'>AntialiaseCheckbox</a></td><td style='width:75%' class='def'><p><a name="3d277869-5b5d-4147-980a-1c6fd5a86f5b"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AntialiaseCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>AntialiaseCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9bdb770-1faf-4c0d-a0ad-7f7db3f329f3'>BlendMode</a></td><td style='width:75%' ><p><a name="b9bdb770-1faf-4c0d-a0ad-7f7db3f329f3"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> BlendMode</h3>

<h4>Summary</h4>

<p>The private read only <code>BlendMode</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1bb4ca1-0b1a-4887-9631-ba64adcb3eb3'>BlurCheckbox</a></td><td style='width:75%' class='def'><p><a name="c1bb4ca1-0b1a-4887-9631-ba64adcb3eb3"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> BlurCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>BlurCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f43cb8ff-4982-4bb9-904c-0990910ba74f'>DesignSurface</a></td><td style='width:75%' ><p><a name="f43cb8ff-4982-4bb9-904c-0990910ba74f"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0c2f60a-6b65-45df-ae12-5366aa74c64d'>DeviationSlider</a></td><td style='width:75%' class='def'><p><a name="a0c2f60a-6b65-45df-ae12-5366aa74c64d"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> DeviationSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>DeviationSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c69ac80-281b-4645-8154-64b3d628cba3'>DeviationValue</a></td><td style='width:75%' ><p><a name="7c69ac80-281b-4645-8154-64b3d628cba3"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> DeviationValue</h3>

<h4>Summary</h4>

<p>The private read only <code>DeviationValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#518a1daf-771b-4279-a765-03f6cb6efe43'>FillCheckbox</a></td><td style='width:75%' class='def'><p><a name="518a1daf-771b-4279-a765-03f6cb6efe43"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> FillCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>FillCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b31175e6-b44d-44d3-aa5d-17ecff793242'>FillColor</a></td><td style='width:75%' ><p><a name="b31175e6-b44d-44d3-aa5d-17ecff793242"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> FillColor</h3>

<h4>Summary</h4>

<p>The private read only <code>FillColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bccb5845-67b2-48e0-9ea4-218450065429'>GradientDropdown</a></td><td style='width:75%' class='def'><p><a name="bccb5845-67b2-48e0-9ea4-218450065429"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> GradientDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>GradientDropdown</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6268770-ec7f-4424-a8c4-d06b5aaf3f46'>HorizontalBlurSlider</a></td><td style='width:75%' ><p><a name="e6268770-ec7f-4424-a8c4-d06b5aaf3f46"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HorizontalBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c9fc52e-2965-4429-9eff-9655ca26b632'>HorizontalBlurValue</a></td><td style='width:75%' class='def'><p><a name="6c9fc52e-2965-4429-9eff-9655ca26b632"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HorizontalBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6367a91b-f07d-4c0a-b932-4fb09f8e67eb'>HorizontalShadowBlurSlider</a></td><td style='width:75%' ><p><a name="6367a91b-f07d-4c0a-b932-4fb09f8e67eb"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HorizontalShadowBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c3b31a8-0086-46e1-b183-ec533db38eab'>HorizontalShadowBlurValue</a></td><td style='width:75%' class='def'><p><a name="3c3b31a8-0086-46e1-b183-ec533db38eab"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HorizontalShadowBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#143fe5da-1586-4a56-bf98-a518ffeeacee'>HorizontalShadowOffsetSlider</a></td><td style='width:75%' ><p><a name="143fe5da-1586-4a56-bf98-a518ffeeacee"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HorizontalShadowOffsetSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowOffsetSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9ee0770-cf08-4fa7-9f20-0a89392993f1'>HorizontalShadowOffsetValue</a></td><td style='width:75%' class='def'><p><a name="a9ee0770-cf08-4fa7-9f20-0a89392993f1"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HorizontalShadowOffsetValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowOffsetValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f779faf-ce07-4033-b560-0e8d0dc8d467'>JitterCheckbox</a></td><td style='width:75%' ><p><a name="7f779faf-ce07-4033-b560-0e8d0dc8d467"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> JitterCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>JitterCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f27bb190-57f9-40fa-b0c1-e6e7fca42cb7'>LengthSlider</a></td><td style='width:75%' class='def'><p><a name="f27bb190-57f9-40fa-b0c1-e6e7fca42cb7"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> LengthSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>LengthSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1760404-e66c-413c-913c-34b3b41f2475'>LengthValue</a></td><td style='width:75%' ><p><a name="b1760404-e66c-413c-913c-34b3b41f2475"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> LengthValue</h3>

<h4>Summary</h4>

<p>The private read only <code>LengthValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#699182ce-584f-4c8c-ac04-7f6a647c4f8a'>LinkedColorSelector</a></td><td style='width:75%' class='def'><p><a name="699182ce-584f-4c8c-ac04-7f6a647c4f8a"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LinkedColorSelector</h3>

<h4>Summary</h4>

<p>The private read only <code>LinkedColorSelector</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#740252cf-c0fe-4c4d-97a8-fffaf2279fdb'>LinkedShadowColor</a></td><td style='width:75%' ><p><a name="740252cf-c0fe-4c4d-97a8-fffaf2279fdb"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LinkedShadowColor</h3>

<h4>Summary</h4>

<p>The private read only <code>LinkedShadowColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4820ab6-40b6-4514-a5aa-d022dd0e19bb'>OpacitySlider</a></td><td style='width:75%' class='def'><p><a name="f4820ab6-40b6-4514-a5aa-d022dd0e19bb"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> OpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aea341c4-b3c4-4dff-bee5-288c33bf0013'>OpacityValue</a></td><td style='width:75%' ><p><a name="aea341c4-b3c4-4dff-bee5-288c33bf0013"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> OpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bedc1a62-27f0-4df7-84cf-f6f16a1756e4'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="bedc1a62-27f0-4df7-84cf-f6f16a1756e4"></a></p>

<h3>Public Read Only <code>KimonoCore.KimonoPortfolio</code> Portfolio</h3>

<h4>Summary</h4>

<p>Gets the portfolio.</p>

<h4>Return Value</h4>

<p>The portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64e13514-9de7-40b8-be67-672e1811f8ba'>SelectedStyle</a></td><td style='width:75%' ><p><a name="64e13514-9de7-40b8-be67-672e1811f8ba"></a></p>

<h3>Public <code>KimonoCore.KimonoStyle</code> SelectedStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the selected style.</p>

<h4>Return Value</h4>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95f00b46-c36c-4568-a5de-3d01739f4dba'>ShadowCheckbox</a></td><td style='width:75%' class='def'><p><a name="95f00b46-c36c-4568-a5de-3d01739f4dba"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ShadowCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowCheckbox</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#950449c6-2ed3-49f3-b6a7-791151821776'>ShadowColor</a></td><td style='width:75%' ><p><a name="950449c6-2ed3-49f3-b6a7-791151821776"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> ShadowColor</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowColor</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6ea9c10-85fa-4f81-aed0-8aa913caadac'>ShadowOpacitySlider</a></td><td style='width:75%' class='def'><p><a name="c6ea9c10-85fa-4f81-aed0-8aa913caadac"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> ShadowOpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowOpacitySlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed2d4236-59dd-434e-b3b1-8358d07f3289'>ShadowOpacityValue</a></td><td style='width:75%' ><p><a name="ed2d4236-59dd-434e-b3b1-8358d07f3289"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShadowOpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowOpacityValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f59b2e9c-e185-4da8-99f1-88ed0280d8eb'>VerticalBlurSlider</a></td><td style='width:75%' class='def'><p><a name="f59b2e9c-e185-4da8-99f1-88ed0280d8eb"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> VerticalBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8798eae-6ed5-4c0f-a241-6dfa800b95e6'>VerticalBlurValue</a></td><td style='width:75%' ><p><a name="d8798eae-6ed5-4c0f-a241-6dfa800b95e6"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> VerticalBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1688672-f35e-443d-8624-06db2a90e7ca'>VerticalShadowBlurSlider</a></td><td style='width:75%' class='def'><p><a name="b1688672-f35e-443d-8624-06db2a90e7ca"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> VerticalShadowBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowBlurSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ab7671c-71a1-4af0-8a53-907e1a82e81f'>VerticalShadowBlurValue</a></td><td style='width:75%' ><p><a name="7ab7671c-71a1-4af0-8a53-907e1a82e81f"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> VerticalShadowBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowBlurValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e258cf91-35b6-484b-86ae-5f9f0b8f40a6'>VerticalShadowOffsetSlider</a></td><td style='width:75%' class='def'><p><a name="e258cf91-35b6-484b-86ae-5f9f0b8f40a6"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> VerticalShadowOffsetSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowOffsetSlider</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c414a064-0e0a-431a-8957-11192d581cb7'>VerticalShadowOffsetValue</a></td><td style='width:75%' ><p><a name="c414a064-0e0a-431a-8957-11192d581cb7"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> VerticalShadowOffsetValue</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowOffsetValue</code> property of the <code>KimonoInspectorFill</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#55a1b7b4-3017-4221-84e0-ca9e0ce7afcc'>AddColor</a></td><td style='width:75%' ><p><a name="55a1b7b4-3017-4221-84e0-ca9e0ce7afcc"></a></p>

<h3>Private Void AddColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="36ea7bf4-6ae0-4c64-b44f-0b7f48c93752"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8693bb6-ba2d-4133-be10-acf2d8355e49'>AntialiaseChanged</a></td><td style='width:75%' class='def'><p><a name="a8693bb6-ba2d-4133-be10-acf2d8355e49"></a></p>

<h3>Private Void AntialiaseChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the antialias value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="bfe0189f-480e-47c4-b0f7-863d43964b90"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94778152-77a0-4121-a38e-e0d7f14254f7'>BlendModeChanged</a></td><td style='width:75%' ><p><a name="94778152-77a0-4121-a38e-e0d7f14254f7"></a></p>

<h3>Private Void BlendModeChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the blend mode changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b8d6af8d-4c46-4b28-941b-99664aff5061"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7b7ebb5-b8e2-4ad1-9855-6ebed3a1076b'>BlurChanged</a></td><td style='width:75%' class='def'><p><a name="a7b7ebb5-b8e2-4ad1-9855-6ebed3a1076b"></a></p>

<h3>Private Void BlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the blur effect changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8d012625-0468-4bad-864e-843204e751e1"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3542628b-49b1-49a9-ae3d-0baa788f7558'>DeviationChanged</a></td><td style='width:75%' ><p><a name="3542628b-49b1-49a9-ae3d-0baa788f7558"></a></p>

<h3>Private Void DeviationChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the jitter deviation changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ae484ae7-adfe-4544-a5de-9a95b670b8b9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dc9daff-5d6c-44b5-bb2a-facb68160758'>FillChanged</a></td><td style='width:75%' class='def'><p><a name="0dc9daff-5d6c-44b5-bb2a-facb68160758"></a></p>

<h3>Private Void FillChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the fill changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f102a0f9-18c3-4c3d-8b97-2e4ec2681b1f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb26109d-7ad7-4e4d-b74f-787a038cac0e'>FillColorChanged</a></td><td style='width:75%' ><p><a name="cb26109d-7ad7-4e4d-b74f-787a038cac0e"></a></p>

<h3>Private Void FillColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the fill color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5af1953f-623c-40ec-9657-1e13b9d515f2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34361e13-1804-45f6-ba28-c50ee0016675'>GradientChanged</a></td><td style='width:75%' class='def'><p><a name="34361e13-1804-45f6-ba28-c50ee0016675"></a></p>

<h3>Private Void GradientChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the <code>KimonoGradient</code> changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a4ec110f-455a-40ae-beca-aaf5551388af"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6827a964-7c2c-4153-b012-7637d0edb8d0'>HorizontalBlurChanged</a></td><td style='width:75%' ><p><a name="6827a964-7c2c-4153-b012-7637d0edb8d0"></a></p>

<h3>Private Void HorizontalBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the horizontal blur amount changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3b002f47-f5b9-4aa7-b544-fd8a9d872d73"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf2b11fa-e6aa-443d-aed1-dca9d8e0a566'>HorizontalShadowBlurChanged</a></td><td style='width:75%' class='def'><p><a name="cf2b11fa-e6aa-443d-aed1-dca9d8e0a566"></a></p>

<h3>Private Void HorizontalShadowBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the horizontal shadow blur changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="44710855-adde-48a6-9199-172f84d49cbe"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53b48146-6d83-471e-9f19-a99e83e2751b'>HorizontalShadowOffsetChanged</a></td><td style='width:75%' ><p><a name="53b48146-6d83-471e-9f19-a99e83e2751b"></a></p>

<h3>Private Void HorizontalShadowOffsetChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the horizontal shadow offset changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="743b47c8-e3c8-4003-a5e9-0afa6f1d2907"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0732f40e-7ced-4503-a95e-4eba8d16d3e0'>Initialize</a></td><td style='width:75%' class='def'><p><a name="0732f40e-7ced-4503-a95e-4eba8d16d3e0"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d131bed-02e1-4741-8475-0ebd552f0396'>JitterChanged</a></td><td style='width:75%' ><p><a name="7d131bed-02e1-4741-8475-0ebd552f0396"></a></p>

<h3>Private Void JitterChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the jitter effect changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="94d3981d-20a8-4e9d-a965-87c2e63e02ef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bf56ce0-df16-42a1-ab52-448e7d94ac63'>KimonoInspectorFill</a></td><td style='width:75%' class='def'><p><a name="2bf56ce0-df16-42a1-ab52-448e7d94ac63"></a></p>

<h3>Public Void KimonoInspectorFill (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#27afbed2-1709-4abb-84f6-c68238b78cd4">KimonoInspectorFill</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="33036967-a417-43ba-a112-a84813f0224d"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#946f2d6c-ccdc-4cc7-81e1-ba45cfefdf99'>LengthChanged</a></td><td style='width:75%' ><p><a name="946f2d6c-ccdc-4cc7-81e1-ba45cfefdf99"></a></p>

<h3>Private Void LengthChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the jitter length changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="885a2f92-3ce1-44ea-b6f2-6bfc01c52343"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#640df050-03dd-42be-8992-49fe9659a9bb'>LinkedColorChanged</a></td><td style='width:75%' class='def'><p><a name="640df050-03dd-42be-8992-49fe9659a9bb"></a></p>

<h3>Private Void LinkedColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the linked <code>KimonoColor</code> changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e5715840-0781-4087-9399-90ab3c067154"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bd79141-81a7-490b-b2f2-ca104064ddb3'>LinkedShadowColorChanged</a></td><td style='width:75%' ><p><a name="0bd79141-81a7-490b-b2f2-ca104064ddb3"></a></p>

<h3>Private Void LinkedShadowColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the linked shadow color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="36b7cd56-cd4e-4ecf-8e2f-d55f61567f5d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e91fb4c-f25e-42fb-a605-314a21788332'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="7e91fb4c-f25e-42fb-a605-314a21788332"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="78299074-8cf9-4fba-b84f-e55b7a8c5beb"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7483198f-4a37-4c7e-bd4b-01d54b2d4b39'>OpacityChanged</a></td><td style='width:75%' ><p><a name="7483198f-4a37-4c7e-bd4b-01d54b2d4b39"></a></p>

<h3>Private Void OpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the opacity value changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7acd1c3d-f6dc-48fd-a076-7bda788c1252"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7a31d37-22d4-41b5-9212-1290e936d074'>RaiseMakeNewColor</a></td><td style='width:75%' class='def'><p><a name="b7a31d37-22d4-41b5-9212-1290e936d074"></a></p>

<h3>Void RaiseMakeNewColor (SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Raises the color of the make new event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="bfedffdd-cdd7-4b6a-8c8b-e8f61cd37ed8"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2186761-407c-4086-8e1e-b05a9b863c22'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="a2186761-407c-4086-8e1e-b05a9b863c22"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66cbdd1b-7d76-4109-b5cb-98313941e3cc'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="66cbdd1b-7d76-4109-b5cb-98313941e3cc"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFill</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73f7a7ed-5fed-4c1b-9055-19149c326050'>ShadowChanged</a></td><td style='width:75%' ><p><a name="73f7a7ed-5fed-4c1b-9055-19149c326050"></a></p>

<h3>Private Void ShadowChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shadow changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="49d7e6b3-db50-48a4-bb18-1fd3b21d2494"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b846a9e-3f3a-4780-b3c1-703bb4d72eae'>ShadowColorChanged</a></td><td style='width:75%' class='def'><p><a name="0b846a9e-3f3a-4780-b3c1-703bb4d72eae"></a></p>

<h3>Private Void ShadowColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shadow color chainging.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b767d31e-50f3-4b7b-b5c9-c3e2c23add3f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29a699ff-13ba-4649-8140-cb231dd311db'>ShadowOpacityChanged</a></td><td style='width:75%' ><p><a name="29a699ff-13ba-4649-8140-cb231dd311db"></a></p>

<h3>Private Void ShadowOpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shadow's opacity changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="582d38c9-d019-4065-8d4b-b57e7df41dbc"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#518d1713-0e51-4a4d-96b4-14fcfab86f0e'>ShowCurrentColor</a></td><td style='width:75%' class='def'><p><a name="518d1713-0e51-4a4d-96b4-14fcfab86f0e"></a></p>

<h3>Private Void ShowCurrentColor ()</h3>

<h4>Summary</h4>

<p>Shows the values for the current color selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46ebe8ff-709d-49b3-aaec-dbb5124a056c'>ShowCurrentShadowColor</a></td><td style='width:75%' ><p><a name="46ebe8ff-709d-49b3-aaec-dbb5124a056c"></a></p>

<h3>Private Void ShowCurrentShadowColor ()</h3>

<h4>Summary</h4>

<p>Shows the color of the current shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59932f78-6162-4965-ad27-9464bf07bce4'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="59932f78-6162-4965-ad27-9464bf07bce4"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cc9c6dd-fb22-4209-9e91-21ceefb3b1b0'>VerticalBlurChanged</a></td><td style='width:75%' ><p><a name="1cc9c6dd-fb22-4209-9e91-21ceefb3b1b0"></a></p>

<h3>Private Void VerticalBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical blur amount changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="faa21aad-e675-4856-8982-291a9c0e851c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4416e94-68e1-4b54-a6c3-1a936dfe64bc'>VerticalShadowBlurChanged</a></td><td style='width:75%' class='def'><p><a name="f4416e94-68e1-4b54-a6c3-1a936dfe64bc"></a></p>

<h3>Private Void VerticalShadowBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical shadow blur changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="12669097-14f5-41e0-98d7-f4d4881980ab"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df22ebe7-5fdd-473e-a52b-02ec981110e0'>VerticalShadowOffsetChanged</a></td><td style='width:75%' ><p><a name="df22ebe7-5fdd-473e-a52b-02ec981110e0"></a></p>

<h3>Private Void VerticalShadowOffsetChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical shadow offset changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0b4fa0ef-4f09-487d-8ac8-abbe6246784d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5c44579a-3cf6-48ed-a3a4-8e2f7fc055e6'>MakeNewColor</a></td><td style='width:75%' ><p><a name="5c44579a-3cf6-48ed-a3a4-8e2f7fc055e6"></a></p>

<h3><code>KimonoCore.Kimono.SkiaColorEventDelegate</code> MakeNewColor</h3>

<h4>Summary</h4>

<p>Occurs when make new color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd1b073c-a4ca-4c45-a8b2-27bdcf3683ea'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="bd1b073c-a4ca-4c45-a8b2-27bdcf3683ea"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a0f3f0a4-2c76-48cf-bad9-4e65ca1d4871'>_selectedShape</a></td><td style='width:75%' ><p><a name="a0f3f0a4-2c76-48cf-bad9-4e65ca1d4871"></a>
<b>Private <code>KimonoCore.KimonoShape</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dfcd5ae-c3c2-40c1-a30b-9bd522c4f362'>_selectedStyle</a></td><td style='width:75%' class='def'><p><a name="9dfcd5ae-c3c2-40c1-a30b-9bd522c4f362"></a>
<b>Private <code>KimonoCore.KimonoStyle</code> _selectedStyle</b></p>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30a10410-d614-45bc-9cbd-15ea65a809dd'>ShapeModified</a></td><td style='width:75%' ><p><a name="30a10410-d614-45bc-9cbd-15ea65a809dd"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c52738c0-5d90-444a-bf3c-ce5aa69d7984'>StyleModified</a></td><td style='width:75%' class='def'><p><a name="c52738c0-5d90-444a-bf3c-ce5aa69d7984"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> StyleModified</b></p>

<p>The private <code>StyleModified</code> field of the <code>KimonoInspectorFont</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4972d867-fcc4-46be-a270-debc2b62980e'>Alignment</a></td><td style='width:75%' ><p><a name="4972d867-fcc4-46be-a270-debc2b62980e"></a></p>

<h3>Private Read Only <code>AppKit.NSSegmentedControl</code> Alignment</h3>

<h4>Summary</h4>

<p>The private read only <code>Alignment</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSegmentedControl</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33288ac0-0cfe-4779-a626-0ecbd16262e9'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="33288ac0-0cfe-4779-a626-0ecbd16262e9"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1bd107ae-f932-4c99-b3f0-ad3c12ff4caf'>ScaleSlider</a></td><td style='width:75%' ><p><a name="1bd107ae-f932-4c99-b3f0-ad3c12ff4caf"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> ScaleSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>ScaleSlider</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca5b3221-877a-4107-a04e-cf632f8e71c3'>ScaleValue</a></td><td style='width:75%' class='def'><p><a name="ca5b3221-877a-4107-a04e-cf632f8e71c3"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ScaleValue</h3>

<h4>Summary</h4>

<p>The private read only <code>ScaleValue</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aabd16b5-ba6b-4ac4-8bce-ae70f23eb20d'>SelectedShape</a></td><td style='width:75%' ><p><a name="aabd16b5-ba6b-4ac4-8bce-ae70f23eb20d"></a></p>

<h3>Public <code>KimonoCore.KimonoShape</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36654f89-2ca0-456c-b3d0-49601abc8fc6'>SelectedStyle</a></td><td style='width:75%' class='def'><p><a name="36654f89-2ca0-456c-b3d0-49601abc8fc6"></a></p>

<h3>Public <code>KimonoCore.KimonoStyle</code> SelectedStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the selected style.</p>

<h4>Return Value</h4>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04c609f1-626d-45e2-9e9d-85603455a9fe'>Size</a></td><td style='width:75%' ><p><a name="04c609f1-626d-45e2-9e9d-85603455a9fe"></a></p>

<h3>Private Read Only <code>AppKit.NSComboBox</code> Size</h3>

<h4>Summary</h4>

<p>The private read only <code>Size</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSComboBox</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70eab1a8-5bfe-4522-8e6e-6bb39c1b3596'>SkewSlider</a></td><td style='width:75%' class='def'><p><a name="70eab1a8-5bfe-4522-8e6e-6bb39c1b3596"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> SkewSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>SkewSlider</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3937ebb8-05dc-4f35-b7e0-b52470b6b391'>SkewValue</a></td><td style='width:75%' ><p><a name="3937ebb8-05dc-4f35-b7e0-b52470b6b391"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SkewValue</h3>

<h4>Summary</h4>

<p>The private read only <code>SkewValue</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef9e3d74-937c-44fb-921e-2963611ec845'>StrikeThruCheckbox</a></td><td style='width:75%' class='def'><p><a name="ef9e3d74-937c-44fb-921e-2963611ec845"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> StrikeThruCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>StrikeThruCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d333668f-0ab6-46e1-9523-4c14a32b2ee3'>TypefaceDropdown</a></td><td style='width:75%' ><p><a name="d333668f-0ab6-46e1-9523-4c14a32b2ee3"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> TypefaceDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>TypefaceDropdown</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e423217-37b7-48a7-af13-0245986ec377'>UnderlineCheckbox</a></td><td style='width:75%' class='def'><p><a name="6e423217-37b7-48a7-af13-0245986ec377"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> UnderlineCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>UnderlineCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a010ccf8-aac7-47bd-a53f-0c049b32e367'>VerticalCheckbox</a></td><td style='width:75%' ><p><a name="a010ccf8-aac7-47bd-a53f-0c049b32e367"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> VerticalCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalCheckbox</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28d775e1-8f68-4866-b0f4-2508cd9c65f1'>WeightDropdown</a></td><td style='width:75%' class='def'><p><a name="28d775e1-8f68-4866-b0f4-2508cd9c65f1"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> WeightDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>WeightDropdown</code> property of the <code>KimonoInspectorFont</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b14590d2-2399-4015-bcff-c8f1c4df6088'>AlignmentChanged</a></td><td style='width:75%' ><p><a name="b14590d2-2399-4015-bcff-c8f1c4df6088"></a></p>

<h3>Private Void AlignmentChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the alignmen changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9fb97055-59b3-40d8-8d03-a7e81ca71e26"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#264dbe06-4fe0-4e23-b88e-8688d36da078'>Initialize</a></td><td style='width:75%' class='def'><p><a name="264dbe06-4fe0-4e23-b88e-8688d36da078"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6766a08e-640a-4357-82a0-03c5b0dd7613'>KimonoInspectorFont</a></td><td style='width:75%' ><p><a name="6766a08e-640a-4357-82a0-03c5b0dd7613"></a></p>

<h3>Public Void KimonoInspectorFont (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e6607c64-f369-46da-b148-c5162d80ca70">KimonoInspectorFont</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="f65557bf-36fc-46db-b777-ab5adf076ec6"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12bdafce-ce50-4e27-a013-0c6d262694be'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="12bdafce-ce50-4e27-a013-0c6d262694be"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="0fd6633e-63a4-47f3-9590-fcd1a6e0715b"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34223e08-8ff6-4617-897c-f7fe0bfc17e0'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="34223e08-8ff6-4617-897c-f7fe0bfc17e0"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e998bf2b-13a9-4b52-b5f4-083e211f1aa7'>RaiseStyleModified</a></td><td style='width:75%' class='def'><p><a name="e998bf2b-13a9-4b52-b5f4-083e211f1aa7"></a></p>

<h3>Void RaiseStyleModified ()</h3>

<h4>Summary</h4>

<p>Raises the style modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d2185b4-e688-43dd-aba7-6f21a1db0317'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="2d2185b4-e688-43dd-aba7-6f21a1db0317"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFont</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a04f128-81b9-4fc7-820e-8786d24a861d'>ScaleChanged</a></td><td style='width:75%' class='def'><p><a name="8a04f128-81b9-4fc7-820e-8786d24a861d"></a></p>

<h3>Private Void ScaleChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the scale changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="22a806d8-bd10-4097-a601-dbe04f371c88"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43b1618f-ae29-4b63-9fd7-30967da7a1ad'>SelectFontFamily</a></td><td style='width:75%' ><p><a name="43b1618f-ae29-4b63-9fd7-30967da7a1ad"></a></p>

<h3>Private Void SelectFontFamily (System.String)</h3>

<h4>Summary</h4>

<p>Selects the font family.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>family</td><td style='width:75%' ><p><a name="716ad9e2-f18a-421a-80f0-c2c6b5da7abe"></a>
<b>System.String family</b></p>

<p>Family.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32667df8-d8fa-4ce7-9df1-4820440cd231'>SizeChanged</a></td><td style='width:75%' class='def'><p><a name="32667df8-d8fa-4ce7-9df1-4820440cd231"></a></p>

<h3>Private Void SizeChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the size changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0805a84c-2dfa-44b6-bcbf-f0da6fa63eb5"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a29b7fa8-77db-4d40-878a-05bba1a18c96'>SkewChanged</a></td><td style='width:75%' ><p><a name="a29b7fa8-77db-4d40-878a-05bba1a18c96"></a></p>

<h3>Private Void SkewChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the skew changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e7dce5a1-bd32-45d4-b29c-51b8decc824a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21952e3b-27e2-4a30-a7cd-fe86a37b860b'>StrikeThruChanged</a></td><td style='width:75%' class='def'><p><a name="21952e3b-27e2-4a30-a7cd-fe86a37b860b"></a></p>

<h3>Private Void StrikeThruChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the strikethru changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="48b73e09-dc9a-4e6c-84e1-37f596950037"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c2c10a0-d0ce-4d04-99eb-f3726114adce'>TypefaceChanged</a></td><td style='width:75%' ><p><a name="8c2c10a0-d0ce-4d04-99eb-f3726114adce"></a></p>

<h3>Private Void TypefaceChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the typeface changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c8370724-8bb1-4cef-9de1-e59a29c0c452"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b2f0343-36fd-4442-b604-36966583cea6'>UnderlineChanged</a></td><td style='width:75%' class='def'><p><a name="8b2f0343-36fd-4442-b604-36966583cea6"></a></p>

<h3>Private Void UnderlineChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the underline changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2e45c8c9-eac2-47b3-ae93-7e531ed3b2d4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10087e47-84d8-4f51-bd70-ce29e8e5a8d0'>UpdateInspector</a></td><td style='width:75%' ><p><a name="10087e47-84d8-4f51-bd70-ce29e8e5a8d0"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46578c2e-226e-4a47-99c3-5d9c4267c5c9'>VerticalChanged</a></td><td style='width:75%' class='def'><p><a name="46578c2e-226e-4a47-99c3-5d9c4267c5c9"></a></p>

<h3>Private Void VerticalChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical text changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9633bea3-4f87-4c48-9d7f-b8593b1a99a0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#377a481e-37f9-4cb1-8c04-ccbb089474b6'>WeightChanged</a></td><td style='width:75%' ><p><a name="377a481e-37f9-4cb1-8c04-ccbb089474b6"></a></p>

<h3>Private Void WeightChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the font weight changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="29700142-57ca-48d3-baf8-1f3bc2eb3199"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5947283b-9b0d-414e-83b1-6fa0d0cf86d8'>ShapeModified</a></td><td style='width:75%' ><p><a name="5947283b-9b0d-414e-83b1-6fa0d0cf86d8"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf197174-d0b4-4f3d-8b53-07f6e2e55e72'>StyleModified</a></td><td style='width:75%' class='def'><p><a name="cf197174-d0b4-4f3d-8b53-07f6e2e55e72"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> StyleModified</h3>

<h4>Summary</h4>

<p>Occurs when style modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2bb7ecbe-e272-47df-a05c-c1a37e41dc67'>_selectedStyle</a></td><td style='width:75%' ><p><a name="2bb7ecbe-e272-47df-a05c-c1a37e41dc67"></a>
<b>Private <code>KimonoCore.KimonoStyle</code> _selectedStyle</b></p>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e239047-98bf-47f6-a38c-9b50af6cc12c'>MakeNewColor</a></td><td style='width:75%' class='def'><p><a name="0e239047-98bf-47f6-a38c-9b50af6cc12c"></a>
<b>Private <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> MakeNewColor</b></p>

<p>The private <code>MakeNewColor</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.Kimono.SkiaColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b65a5b5-8125-44d5-8cce-8c1c7fcc0517'>ShapeModified</a></td><td style='width:75%' ><p><a name="8b65a5b5-8125-44d5-8cce-8c1c7fcc0517"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorFrame</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f91ffe79-a470-454a-9210-58aa6f4fbafe'>AddColorButton</a></td><td style='width:75%' ><p><a name="f91ffe79-a470-454a-9210-58aa6f4fbafe"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AddColorButton</h3>

<h4>Summary</h4>

<p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebc4522d-b194-4a03-a191-1553f94f3ea9'>AntialiasCheckbox</a></td><td style='width:75%' class='def'><p><a name="ebc4522d-b194-4a03-a191-1553f94f3ea9"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AntialiasCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>AntialiasCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aa777c7-7fd6-485f-a1a0-7765e396e7cf'>BlendMode</a></td><td style='width:75%' ><p><a name="3aa777c7-7fd6-485f-a1a0-7765e396e7cf"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> BlendMode</h3>

<h4>Summary</h4>

<p>The private read only <code>BlendMode</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41e5041d-3461-46ae-afb0-9ccadbf37e16'>BlurCheckbox</a></td><td style='width:75%' class='def'><p><a name="41e5041d-3461-46ae-afb0-9ccadbf37e16"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> BlurCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>BlurCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d9d21c5-7e4c-4535-b774-7f5908551774'>Dash1</a></td><td style='width:75%' ><p><a name="6d9d21c5-7e4c-4535-b774-7f5908551774"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash1</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash1</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86e13a9e-a81f-4b79-8103-efaa5c27469f'>Dash10</a></td><td style='width:75%' class='def'><p><a name="86e13a9e-a81f-4b79-8103-efaa5c27469f"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash10</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash10</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1aeda0f-7350-44e0-85a9-156442499bf1'>Dash11</a></td><td style='width:75%' ><p><a name="a1aeda0f-7350-44e0-85a9-156442499bf1"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash11</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash11</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce243665-e6f4-4544-a2f2-d0dbfbd7d86d'>Dash12</a></td><td style='width:75%' class='def'><p><a name="ce243665-e6f4-4544-a2f2-d0dbfbd7d86d"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash12</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash12</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc3949f4-8448-4785-83c2-d4c873abc686'>Dash13</a></td><td style='width:75%' ><p><a name="cc3949f4-8448-4785-83c2-d4c873abc686"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash13</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash13</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b98a1d5e-98e2-41a5-9dbe-9082a53e81d1'>Dash14</a></td><td style='width:75%' class='def'><p><a name="b98a1d5e-98e2-41a5-9dbe-9082a53e81d1"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash14</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash14</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf1499d5-72f0-4df1-b4f9-b19eba93ae9b'>Dash15</a></td><td style='width:75%' ><p><a name="cf1499d5-72f0-4df1-b4f9-b19eba93ae9b"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash15</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash15</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3680c059-7e79-4b93-a0ed-d26bef796ad2'>Dash16</a></td><td style='width:75%' class='def'><p><a name="3680c059-7e79-4b93-a0ed-d26bef796ad2"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash16</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash16</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5bdc8ec-7f6f-4d08-968d-f53de4cff001'>Dash2</a></td><td style='width:75%' ><p><a name="f5bdc8ec-7f6f-4d08-968d-f53de4cff001"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash2</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash2</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b582009-850a-42ba-aaf6-693db85e4feb'>Dash3</a></td><td style='width:75%' class='def'><p><a name="2b582009-850a-42ba-aaf6-693db85e4feb"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash3</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash3</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1e3afd2-619b-4027-bcfa-8565da28300b'>Dash4</a></td><td style='width:75%' ><p><a name="d1e3afd2-619b-4027-bcfa-8565da28300b"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash4</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash4</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45a25d15-f3ad-4b5d-9192-73f26eea66ab'>Dash5</a></td><td style='width:75%' class='def'><p><a name="45a25d15-f3ad-4b5d-9192-73f26eea66ab"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash5</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash5</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#575c45de-b4d3-4eb5-a50e-ec5f66b59792'>Dash6</a></td><td style='width:75%' ><p><a name="575c45de-b4d3-4eb5-a50e-ec5f66b59792"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash6</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash6</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5580f9b-6e11-4e17-bc96-6b6d0255faa6'>Dash7</a></td><td style='width:75%' class='def'><p><a name="f5580f9b-6e11-4e17-bc96-6b6d0255faa6"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash7</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash7</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5009eb0-b3ea-4a67-ab6c-8bcfc450ee45'>Dash8</a></td><td style='width:75%' ><p><a name="c5009eb0-b3ea-4a67-ab6c-8bcfc450ee45"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash8</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash8</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0083b522-901e-4580-a508-ec1182cbb69c'>Dash9</a></td><td style='width:75%' class='def'><p><a name="0083b522-901e-4580-a508-ec1182cbb69c"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Dash9</h3>

<h4>Summary</h4>

<p>The private read only <code>Dash9</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#621ddb15-c4a2-4f2a-a29f-85570b6d4009'>DashCheckbox</a></td><td style='width:75%' ><p><a name="621ddb15-c4a2-4f2a-a29f-85570b6d4009"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DashCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>DashCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ed9bb51-287e-4130-9dc7-2431e83586cf'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="9ed9bb51-287e-4130-9dc7-2431e83586cf"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21708bc2-c8aa-46fa-bd2a-d1d199c4f5f5'>DeviationSlider</a></td><td style='width:75%' ><p><a name="21708bc2-c8aa-46fa-bd2a-d1d199c4f5f5"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> DeviationSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>DeviationSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f034ca32-b93b-4e44-beae-047a8a371008'>DeviationValue</a></td><td style='width:75%' class='def'><p><a name="f034ca32-b93b-4e44-beae-047a8a371008"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> DeviationValue</h3>

<h4>Summary</h4>

<p>The private read only <code>DeviationValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cac9490-1969-40c7-8053-ff650dbd3a9b'>EndCap</a></td><td style='width:75%' ><p><a name="4cac9490-1969-40c7-8053-ff650dbd3a9b"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> EndCap</h3>

<h4>Summary</h4>

<p>The private read only <code>EndCap</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f9ddd31-9e8e-4352-ab47-7271f1f99b46'>FrameCheckbox</a></td><td style='width:75%' class='def'><p><a name="8f9ddd31-9e8e-4352-ab47-7271f1f99b46"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> FrameCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>FrameCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6dc0bcd3-278b-48ce-a9db-12abcabec02a'>FrameColor</a></td><td style='width:75%' ><p><a name="6dc0bcd3-278b-48ce-a9db-12abcabec02a"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> FrameColor</h3>

<h4>Summary</h4>

<p>The private read only <code>FrameColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f61812bd-ebe5-45ea-849b-ee23fea782a1'>GradientDropdown</a></td><td style='width:75%' class='def'><p><a name="f61812bd-ebe5-45ea-849b-ee23fea782a1"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> GradientDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>GradientDropdown</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d96b4037-d2e4-4c02-a7d4-7026f6206c5a'>HorizontalBlurSlider</a></td><td style='width:75%' ><p><a name="d96b4037-d2e4-4c02-a7d4-7026f6206c5a"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HorizontalBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48682bd1-c028-4b82-9c99-e74ecfc0d407'>HorizontalBlurValue</a></td><td style='width:75%' class='def'><p><a name="48682bd1-c028-4b82-9c99-e74ecfc0d407"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HorizontalBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f230ac8f-0df0-447e-bf4a-a20c057806a5'>HorizontalShadowBlurSlider</a></td><td style='width:75%' ><p><a name="f230ac8f-0df0-447e-bf4a-a20c057806a5"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HorizontalShadowBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7eb3712-7f70-4afc-a70e-15f01f15d70d'>HorizontalShadowBlurValue</a></td><td style='width:75%' class='def'><p><a name="c7eb3712-7f70-4afc-a70e-15f01f15d70d"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HorizontalShadowBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc6dd59d-7a29-45a4-b38d-4559566831c8'>HorizontalShadowOffsetSlider</a></td><td style='width:75%' ><p><a name="bc6dd59d-7a29-45a4-b38d-4559566831c8"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HorizontalShadowOffsetSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowOffsetSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b123d152-cb33-4eb5-a72a-5f77c831c720'>HorizontalShadowOffsetValue</a></td><td style='width:75%' class='def'><p><a name="b123d152-cb33-4eb5-a72a-5f77c831c720"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HorizontalShadowOffsetValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HorizontalShadowOffsetValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58721db3-75c8-4c99-9da3-89e7225e538b'>JitterCheckbox</a></td><td style='width:75%' ><p><a name="58721db3-75c8-4c99-9da3-89e7225e538b"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> JitterCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>JitterCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d26b12f-e072-4ebd-ab92-44a79ef527d2'>JoinType</a></td><td style='width:75%' class='def'><p><a name="2d26b12f-e072-4ebd-ab92-44a79ef527d2"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> JoinType</h3>

<h4>Summary</h4>

<p>The private read only <code>JoinType</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d13f501b-1a5f-4485-9a4c-2c7f8fcb0ce4'>LengthSlider</a></td><td style='width:75%' ><p><a name="d13f501b-1a5f-4485-9a4c-2c7f8fcb0ce4"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> LengthSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>LengthSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#083f2015-d7b1-4f9b-be9b-34a660cf31a0'>LengthValue</a></td><td style='width:75%' class='def'><p><a name="083f2015-d7b1-4f9b-be9b-34a660cf31a0"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> LengthValue</h3>

<h4>Summary</h4>

<p>The private read only <code>LengthValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef241b11-187a-4e3a-9ec4-8a3fd4c279ea'>LinkedColorSelector</a></td><td style='width:75%' ><p><a name="ef241b11-187a-4e3a-9ec4-8a3fd4c279ea"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LinkedColorSelector</h3>

<h4>Summary</h4>

<p>The private read only <code>LinkedColorSelector</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbf49a1d-5f4f-4dc6-92bc-611494f29402'>LinkedShadowColor</a></td><td style='width:75%' class='def'><p><a name="cbf49a1d-5f4f-4dc6-92bc-611494f29402"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LinkedShadowColor</h3>

<h4>Summary</h4>

<p>The private read only <code>LinkedShadowColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5052b23a-51ae-4c8e-9c57-36545b9199b1'>MiterSlider</a></td><td style='width:75%' ><p><a name="5052b23a-51ae-4c8e-9c57-36545b9199b1"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> MiterSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>MiterSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a6af29f-dc50-40c5-aefc-cf00e39346d8'>MiterValue</a></td><td style='width:75%' class='def'><p><a name="1a6af29f-dc50-40c5-aefc-cf00e39346d8"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> MiterValue</h3>

<h4>Summary</h4>

<p>The private read only <code>MiterValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4cfded7-a3b8-44fe-a18c-74f58162ccde'>OpacitySlider</a></td><td style='width:75%' ><p><a name="b4cfded7-a3b8-44fe-a18c-74f58162ccde"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> OpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2f9a546-7a8a-4c4f-933c-9f199a769c28'>OpacityValue</a></td><td style='width:75%' class='def'><p><a name="d2f9a546-7a8a-4c4f-933c-9f199a769c28"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> OpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e87c40d-fb06-4d41-872d-ecee44194f52'>Portfolio</a></td><td style='width:75%' ><p><a name="2e87c40d-fb06-4d41-872d-ecee44194f52"></a></p>

<h3>Public Read Only <code>KimonoCore.KimonoPortfolio</code> Portfolio</h3>

<h4>Summary</h4>

<p>Gets the portfolio.</p>

<h4>Return Value</h4>

<p>The portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d61578f-2019-42ec-b558-ba04140da24f'>SelectedStyle</a></td><td style='width:75%' class='def'><p><a name="9d61578f-2019-42ec-b558-ba04140da24f"></a></p>

<h3>Public <code>KimonoCore.KimonoStyle</code> SelectedStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the selected style.</p>

<h4>Return Value</h4>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#135372f7-2a0f-4833-b5fe-7c42423e6129'>ShadowCheckbox</a></td><td style='width:75%' ><p><a name="135372f7-2a0f-4833-b5fe-7c42423e6129"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ShadowCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowCheckbox</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52904d35-e3a6-4657-a821-56a5987c6c60'>ShadowColor</a></td><td style='width:75%' class='def'><p><a name="52904d35-e3a6-4657-a821-56a5987c6c60"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> ShadowColor</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowColor</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18e304a0-9334-4047-a53e-caed8e4b25dd'>ShadowOpacitySlider</a></td><td style='width:75%' ><p><a name="18e304a0-9334-4047-a53e-caed8e4b25dd"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> ShadowOpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowOpacitySlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5f2b312-1177-4e19-a1f2-254fad4e043f'>ShadowOpacityValue</a></td><td style='width:75%' class='def'><p><a name="c5f2b312-1177-4e19-a1f2-254fad4e043f"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShadowOpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>ShadowOpacityValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#229e9bb1-83b5-4b0b-8b39-8afdee6201a2'>VerticalBlurSlider</a></td><td style='width:75%' ><p><a name="229e9bb1-83b5-4b0b-8b39-8afdee6201a2"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> VerticalBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bc5f1e4-1c1d-4d21-a52b-266d7bd3dcc1'>VerticalBlurValue</a></td><td style='width:75%' class='def'><p><a name="8bc5f1e4-1c1d-4d21-a52b-266d7bd3dcc1"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> VerticalBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7c3213a-ac34-4255-ba30-39d83ba3d7e7'>VerticalShadowBlurSlider</a></td><td style='width:75%' ><p><a name="d7c3213a-ac34-4255-ba30-39d83ba3d7e7"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> VerticalShadowBlurSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowBlurSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cf2d8e2-5211-4a11-9a64-a1c01bfc8d1c'>VerticalShadowBlurValue</a></td><td style='width:75%' class='def'><p><a name="8cf2d8e2-5211-4a11-9a64-a1c01bfc8d1c"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> VerticalShadowBlurValue</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowBlurValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b92560d-87b4-4d8d-977c-7e09112819b6'>VerticalShadowOffsetSlider</a></td><td style='width:75%' ><p><a name="8b92560d-87b4-4d8d-977c-7e09112819b6"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> VerticalShadowOffsetSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowOffsetSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9d490b2-aa1e-429c-85d0-1f4cd205103b'>VerticalShadowOffsetValue</a></td><td style='width:75%' class='def'><p><a name="f9d490b2-aa1e-429c-85d0-1f4cd205103b"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> VerticalShadowOffsetValue</h3>

<h4>Summary</h4>

<p>The private read only <code>VerticalShadowOffsetValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ba13164-d412-4acc-8e7e-b1b6c2646545'>WidthSlider</a></td><td style='width:75%' ><p><a name="5ba13164-d412-4acc-8e7e-b1b6c2646545"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> WidthSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>WidthSlider</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#431e0ecc-c373-40b1-a66a-eb2e6eda3c5c'>WidthValue</a></td><td style='width:75%' class='def'><p><a name="431e0ecc-c373-40b1-a66a-eb2e6eda3c5c"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> WidthValue</h3>

<h4>Summary</h4>

<p>The private read only <code>WidthValue</code> property of the <code>KimonoInspectorFrame</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#36533599-edbe-40f7-8bb9-42742ec44e5a'>AddColor</a></td><td style='width:75%' ><p><a name="36533599-edbe-40f7-8bb9-42742ec44e5a"></a></p>

<h3>Private Void AddColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="073268e0-c087-4d48-9010-1d09cffa8b04"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb8af19c-3c20-4ae8-b696-5c57d58bc107'>AntialiasChanged</a></td><td style='width:75%' class='def'><p><a name="fb8af19c-3c20-4ae8-b696-5c57d58bc107"></a></p>

<h3>Private Void AntialiasChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the antialias changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ef72d02b-5004-4118-bf7b-c7db2b599214"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#902e13bb-a0b3-484c-9193-fd79235dbae3'>BlendModeChanged</a></td><td style='width:75%' ><p><a name="902e13bb-a0b3-484c-9193-fd79235dbae3"></a></p>

<h3>Private Void BlendModeChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the blend mode changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2d8f730d-93e0-4090-8c6c-67c6a8a5b726"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cfc3172-8545-4b95-a156-2df309d56e7d'>BlurChanged</a></td><td style='width:75%' class='def'><p><a name="0cfc3172-8545-4b95-a156-2df309d56e7d"></a></p>

<h3>Private Void BlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the blur effect changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="23d22184-9bfd-41cd-bf36-c99f625e9b3d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d50d2b1-f864-4841-b57a-1eb26abedef6'>Dash10Changed</a></td><td style='width:75%' ><p><a name="9d50d2b1-f864-4841-b57a-1eb26abedef6"></a></p>

<h3>Private Void Dash10Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="92ded0d9-6ef0-49ec-9c4a-f11ffe2e37b7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9e654c9-6e08-49c2-bd1b-2c25b14b7e57'>Dash11Changed</a></td><td style='width:75%' class='def'><p><a name="c9e654c9-6e08-49c2-bd1b-2c25b14b7e57"></a></p>

<h3>Private Void Dash11Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="93682085-707b-480d-a4be-990ac1a0a49a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac9aff44-d5f9-4e90-a304-7c52954d2082'>Dash12Changed</a></td><td style='width:75%' ><p><a name="ac9aff44-d5f9-4e90-a304-7c52954d2082"></a></p>

<h3>Private Void Dash12Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ee129093-586b-4168-8029-ca84cd62dc52"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#312bc019-6649-484a-a988-51de48ecd557'>Dash13Changed</a></td><td style='width:75%' class='def'><p><a name="312bc019-6649-484a-a988-51de48ecd557"></a></p>

<h3>Private Void Dash13Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="eebad594-26d2-41be-8133-544bdce25590"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3de8bdad-2240-45d0-a666-786fe6e2b0f6'>Dash14Changed</a></td><td style='width:75%' ><p><a name="3de8bdad-2240-45d0-a666-786fe6e2b0f6"></a></p>

<h3>Private Void Dash14Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="decec990-5bf8-4004-b4b7-47e4735088d2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d13120b-f733-4085-8a1e-0ced1957e503'>Dash15Changed</a></td><td style='width:75%' class='def'><p><a name="5d13120b-f733-4085-8a1e-0ced1957e503"></a></p>

<h3>Private Void Dash15Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a4e64a83-e495-47fa-b370-0d8477ac82fd"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#376f6232-80f2-48b8-aea5-38a1bbc0b316'>Dash16Changed</a></td><td style='width:75%' ><p><a name="376f6232-80f2-48b8-aea5-38a1bbc0b316"></a></p>

<h3>Private Void Dash16Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="207d1238-d3d5-4d92-b7ef-d0e8475c6e1e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45a4ded9-e673-4a8e-a575-77ac8d5d56e6'>Dash1Changed</a></td><td style='width:75%' class='def'><p><a name="45a4ded9-e673-4a8e-a575-77ac8d5d56e6"></a></p>

<h3>Private Void Dash1Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="931a64b7-5ea2-4970-b1bb-90a13b3b71ab"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07325247-86f7-4e58-9741-b0f4f9206ab7'>Dash2Changed</a></td><td style='width:75%' ><p><a name="07325247-86f7-4e58-9741-b0f4f9206ab7"></a></p>

<h3>Private Void Dash2Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c0604d74-3cd6-479d-baf9-0caddbd8676e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6172e1a5-df1a-4fc6-a230-ba7a62d886ed'>Dash3Changed</a></td><td style='width:75%' class='def'><p><a name="6172e1a5-df1a-4fc6-a230-ba7a62d886ed"></a></p>

<h3>Private Void Dash3Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ef2d49d8-961c-4958-839e-e863d0269072"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#663c2d80-c8df-472f-a169-26ceb073a794'>Dash4Changed</a></td><td style='width:75%' ><p><a name="663c2d80-c8df-472f-a169-26ceb073a794"></a></p>

<h3>Private Void Dash4Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e1266874-6cf7-41d2-bb0b-22056710ec47"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30f68754-10b3-4a11-99db-8aa229cf5011'>Dash5Changed</a></td><td style='width:75%' class='def'><p><a name="30f68754-10b3-4a11-99db-8aa229cf5011"></a></p>

<h3>Private Void Dash5Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="49d84314-4341-4dc6-a53c-0ed24943325c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f963d99-b561-4d6a-ba0f-ab6edc4d1fa5'>Dash6Changed</a></td><td style='width:75%' ><p><a name="6f963d99-b561-4d6a-ba0f-ab6edc4d1fa5"></a></p>

<h3>Private Void Dash6Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3e350b96-92c1-487e-8254-e3818d60c390"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#448eb247-7b9b-4505-9fa0-973b375c61f2'>Dash7Changed</a></td><td style='width:75%' class='def'><p><a name="448eb247-7b9b-4505-9fa0-973b375c61f2"></a></p>

<h3>Private Void Dash7Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2cc88539-768b-42e6-9cff-970719797b7e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f636873f-7162-484d-a71d-3a115d094eb1'>Dash8Changed</a></td><td style='width:75%' ><p><a name="f636873f-7162-484d-a71d-3a115d094eb1"></a></p>

<h3>Private Void Dash8Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="70492823-493f-45d7-bd70-e6d59d98cc6c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#348accc4-aed8-45f5-b8a7-0a3468146497'>Dash9Changed</a></td><td style='width:75%' class='def'><p><a name="348accc4-aed8-45f5-b8a7-0a3468146497"></a></p>

<h3>Private Void Dash9Changed (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c1c77059-f7f0-4307-917d-07d2471fdb53"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#940ee816-5971-4c31-a5b0-111cf520d539'>DashChanged</a></td><td style='width:75%' ><p><a name="940ee816-5971-4c31-a5b0-111cf520d539"></a></p>

<h3>Private Void DashChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a dash point changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6066b1be-d998-4b02-8041-ba9d972c6c7b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84b1aa1b-8b09-4805-8e31-b2fdf336f79f'>DeviationChanged</a></td><td style='width:75%' class='def'><p><a name="84b1aa1b-8b09-4805-8e31-b2fdf336f79f"></a></p>

<h3>Private Void DeviationChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the jitter deviation changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4c8deff2-de8d-441e-aa8d-5533ce8e2a5b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9f2f75d-b95e-4199-a7ec-48184b5e04c5'>EndCapChanged</a></td><td style='width:75%' ><p><a name="d9f2f75d-b95e-4199-a7ec-48184b5e04c5"></a></p>

<h3>Private Void EndCapChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the end cap chainging.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5eb4bc8f-f356-44e6-9e7c-fa4d53e4a48d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0846f28f-0258-4c58-a6ab-92c64295ee27'>FrameChanged</a></td><td style='width:75%' class='def'><p><a name="0846f28f-0258-4c58-a6ab-92c64295ee27"></a></p>

<h3>Private Void FrameChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the frame changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="875328e0-27cf-42fd-863e-a95fab15ce4a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e19e917-4081-4560-97e4-b80accecf1af'>FrameColorChanged</a></td><td style='width:75%' ><p><a name="8e19e917-4081-4560-97e4-b80accecf1af"></a></p>

<h3>Private Void FrameColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the frame color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7e5485a6-1e4f-4a74-ad46-f8890a070bef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3537330b-bed0-428a-bcb4-faf3827cb863'>GradientChanged</a></td><td style='width:75%' class='def'><p><a name="3537330b-bed0-428a-bcb4-faf3827cb863"></a></p>

<h3>Private Void GradientChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the gradient changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1ea1e5f5-d4cc-45d7-9b44-fef9aa73eea3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b87c6560-02d2-437a-bb9b-871ed8637875'>HorizontalBlurChanged</a></td><td style='width:75%' ><p><a name="b87c6560-02d2-437a-bb9b-871ed8637875"></a></p>

<h3>Private Void HorizontalBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the horizontal blur amount changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="346ed58c-0d1a-4ee1-b8a2-bba69d129053"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4961338e-30ce-43b6-80f4-11aac9f1312e'>HorizontalShadowBlurChanged</a></td><td style='width:75%' class='def'><p><a name="4961338e-30ce-43b6-80f4-11aac9f1312e"></a></p>

<h3>Private Void HorizontalShadowBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the horizontal shadow blur changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f15b1e02-cb49-422a-989f-59d0677fcdd0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#730428ea-0576-4179-9a07-562dfb017389'>HorizontalShadowOffsetChanged</a></td><td style='width:75%' ><p><a name="730428ea-0576-4179-9a07-562dfb017389"></a></p>

<h3>Private Void HorizontalShadowOffsetChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the horizontal shadow offset changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="227fde84-ab4e-4ab0-a103-e88daabba5b2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccbca707-39d7-4560-b303-70d1f1711d7c'>Initialize</a></td><td style='width:75%' class='def'><p><a name="ccbca707-39d7-4560-b303-70d1f1711d7c"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f592f3f-794a-4c89-b5ba-a1665b4cd947'>JitterChanged</a></td><td style='width:75%' ><p><a name="3f592f3f-794a-4c89-b5ba-a1665b4cd947"></a></p>

<h3>Private Void JitterChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the jitter effect changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c892f0b4-a5b4-43cc-b66f-5a3840ac7bf0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abf4e476-5a68-405d-8c46-c72d24ccb818'>JoinTypeChanged</a></td><td style='width:75%' class='def'><p><a name="abf4e476-5a68-405d-8c46-c72d24ccb818"></a></p>

<h3>Private Void JoinTypeChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the join type changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ab56d810-0317-4b80-9672-00c95c9a8563"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3aabd88-b004-4861-9823-39ff1c39742a'>KimonoInspectorFrame</a></td><td style='width:75%' ><p><a name="c3aabd88-b004-4861-9823-39ff1c39742a"></a></p>

<h3>Public Void KimonoInspectorFrame (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#3d13d593-a78a-46f8-bd30-1f88ffbbc239">KimonoInspectorFrame</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="29c8d96e-2915-4aef-956f-7da9c147d111"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2106422-b54d-43a0-bc78-0d324305cb42'>LengthChanged</a></td><td style='width:75%' class='def'><p><a name="e2106422-b54d-43a0-bc78-0d324305cb42"></a></p>

<h3>Private Void LengthChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the jitter lenght changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="58ebcf27-5f6e-48dc-8385-ad732ad006ae"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#235ed9fa-4552-4587-8ba8-088f6522fcda'>LinkedColorChanged</a></td><td style='width:75%' ><p><a name="235ed9fa-4552-4587-8ba8-088f6522fcda"></a></p>

<h3>Private Void LinkedColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the linked color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3a5549c0-60dd-43b2-a886-5142755f1046"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cad3f518-9882-4833-ac16-4a8a8cc19ca1'>LinkedShadowColorChanged</a></td><td style='width:75%' class='def'><p><a name="cad3f518-9882-4833-ac16-4a8a8cc19ca1"></a></p>

<h3>Private Void LinkedShadowColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the linked shadow color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="27442bdf-d3ab-4cc6-9a8b-513a3eaedf6b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51783589-80a4-4e92-8d72-d8e14467023b'>MiterChanged</a></td><td style='width:75%' ><p><a name="51783589-80a4-4e92-8d72-d8e14467023b"></a></p>

<h3>Private Void MiterChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the Miter changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1a0256ac-dd03-443f-9681-634f0c9bf1d4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50aa2ca8-afb7-4d2b-88fb-7806a3b4c721'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="50aa2ca8-afb7-4d2b-88fb-7806a3b4c721"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the give location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="5619c7c0-d247-484d-b944-da1bb68ca7c7"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48edc711-8c09-4e60-b2a2-5a311b9cb7d1'>OpacityChanged</a></td><td style='width:75%' ><p><a name="48edc711-8c09-4e60-b2a2-5a311b9cb7d1"></a></p>

<h3>Private Void OpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the opacity changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6e3b1092-4479-44d5-ac7f-8b6d56bff963"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60fe2c23-5a2b-45b2-b0fd-7d2c951ac580'>RaiseMakeNewColor</a></td><td style='width:75%' class='def'><p><a name="60fe2c23-5a2b-45b2-b0fd-7d2c951ac580"></a></p>

<h3>Void RaiseMakeNewColor (SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Raises the color of the make new event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="7cfea08c-4400-47b4-8d95-a79d8c07b35a"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0a6f211-e908-4a49-a0bd-af8fc98010c3'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="a0a6f211-e908-4a49-a0bd-af8fc98010c3"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efc6b899-c3bf-446d-abc9-81274fd7955e'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="efc6b899-c3bf-446d-abc9-81274fd7955e"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorFrame</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47f12b81-253b-4746-a65b-e00181fe6883'>ShadowChanged</a></td><td style='width:75%' ><p><a name="47f12b81-253b-4746-a65b-e00181fe6883"></a></p>

<h3>Private Void ShadowChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shadow changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5e0bdc39-8343-4db4-937f-7a04fbdd0889"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3df7b56c-1166-48d0-bc68-0d9893cad488'>ShadowColorChanged</a></td><td style='width:75%' class='def'><p><a name="3df7b56c-1166-48d0-bc68-0d9893cad488"></a></p>

<h3>Private Void ShadowColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shadow color chainging.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2a2ad2a2-4ebf-4822-921c-88f632d4027c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fde3be3c-a13d-410e-b929-1134b87a2e9d'>ShadowOpacityChanged</a></td><td style='width:75%' ><p><a name="fde3be3c-a13d-410e-b929-1134b87a2e9d"></a></p>

<h3>Private Void ShadowOpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shadow's opacity changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="edb78b69-25ce-469b-85b0-abc58d498759"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9abbd4f-7c9d-44eb-808b-1082ac5aa5be'>ShowCurrentColor</a></td><td style='width:75%' class='def'><p><a name="a9abbd4f-7c9d-44eb-808b-1082ac5aa5be"></a></p>

<h3>Private Void ShowCurrentColor ()</h3>

<h4>Summary</h4>

<p>Shows the color of the current.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25861717-4381-4ab3-a480-e03bae50ae11'>ShowCurrentShadowColor</a></td><td style='width:75%' ><p><a name="25861717-4381-4ab3-a480-e03bae50ae11"></a></p>

<h3>Private Void ShowCurrentShadowColor ()</h3>

<h4>Summary</h4>

<p>Shows the color of the current shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b345782b-247e-4cbe-872c-3dadcb94a227'>ShowDashEditor</a></td><td style='width:75%' class='def'><p><a name="b345782b-247e-4cbe-872c-3dadcb94a227"></a></p>

<h3>Private Void ShowDashEditor ()</h3>

<h4>Summary</h4>

<p>Shows the dash editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#caa56b91-692f-47e3-a695-f4310601d2bd'>UpdateInspector</a></td><td style='width:75%' ><p><a name="caa56b91-692f-47e3-a695-f4310601d2bd"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6ef88b1-3d3c-4dd4-82f1-81463142c398'>VerticalBlurChanged</a></td><td style='width:75%' class='def'><p><a name="e6ef88b1-3d3c-4dd4-82f1-81463142c398"></a></p>

<h3>Private Void VerticalBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical blur amount changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9808e301-8bea-4e8f-8b6d-5beacafef8b6"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4b71b0c-8c57-4295-b71c-e0bf7742694e'>VerticalShadowBlurChanged</a></td><td style='width:75%' ><p><a name="d4b71b0c-8c57-4295-b71c-e0bf7742694e"></a></p>

<h3>Private Void VerticalShadowBlurChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical shadow blur changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="450d4fea-e69a-4508-a6ca-1818944953df"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa0bb3e5-bca9-4d11-9241-8782f8c9748f'>VerticalShadowOffsetChanged</a></td><td style='width:75%' class='def'><p><a name="aa0bb3e5-bca9-4d11-9241-8782f8c9748f"></a></p>

<h3>Private Void VerticalShadowOffsetChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the vertical shadow offset changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2e0931c4-467b-4f3d-8109-99d398f1b8ea"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e82358c5-7e7c-4ee9-9339-cffc370f2312'>WidthChanged</a></td><td style='width:75%' ><p><a name="e82358c5-7e7c-4ee9-9339-cffc370f2312"></a></p>

<h3>Private Void WidthChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the width changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5d8ffce2-1253-4e93-8c14-1ffbf40afbc3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7dc50b16-fecd-439f-8abe-963d7a50d60d'>MakeNewColor</a></td><td style='width:75%' ><p><a name="7dc50b16-fecd-439f-8abe-963d7a50d60d"></a></p>

<h3><code>KimonoCore.Kimono.SkiaColorEventDelegate</code> MakeNewColor</h3>

<h4>Summary</h4>

<p>Occurs when make new color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5de0b9b-01ed-4aeb-8209-a40b07980b7a'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="e5de0b9b-01ed-4aeb-8209-a40b07980b7a"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ef2bf91e-18d0-4486-b03c-5acf7710a260'>_selectedShape</a></td><td style='width:75%' ><p><a name="ef2bf91e-18d0-4486-b03c-5acf7710a260"></a>
<b>Private <code>KimonoCore.KimonoShape</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c588836-6102-4bb4-b6f5-769562d3c49b'>MakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="5c588836-6102-4bb4-b6f5-769562d3c49b"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> MakeDuplicate</b></p>

<p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#014eee28-fe81-4f6a-ac52-893bd0bc086a'>RemoveShape</a></td><td style='width:75%' ><p><a name="014eee28-fe81-4f6a-ac52-893bd0bc086a"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> RemoveShape</b></p>

<p>The private <code>RemoveShape</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9195f982-35de-4241-a6db-1e42409bf4d3'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="9195f982-35de-4241-a6db-1e42409bf4d3"></a>
<b>Private <code>KimonoCore.Kimono.ShapeEventDelegate</code> SelectionChanged</b></p>

<p>The private <code>SelectionChanged</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#829dc66b-60ed-47d6-8539-0bc04e8211c0'>ShapeModified</a></td><td style='width:75%' ><p><a name="829dc66b-60ed-47d6-8539-0bc04e8211c0"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07723358-ccc9-454b-9559-95cbacc47cb0'>SketchModified</a></td><td style='width:75%' class='def'><p><a name="07723358-ccc9-454b-9559-95cbacc47cb0"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> SketchModified</b></p>

<p>The private <code>SketchModified</code> field of the <code>KimonoInspectorGeneralInfo</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f2ec1d53-4ee0-4610-93fe-92ad36f3d96e'>DesignSurface</a></td><td style='width:75%' ><p><a name="f2ec1d53-4ee0-4610-93fe-92ad36f3d96e"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de54d0b0-1ef1-4844-adfe-494878e98e4e'>EditButton</a></td><td style='width:75%' class='def'><p><a name="de54d0b0-1ef1-4844-adfe-494878e98e4e"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> EditButton</h3>

<h4>Summary</h4>

<p>The private read only <code>EditButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ece068d5-62d5-42ef-b15a-b0716109862d'>GroupUngroupButton</a></td><td style='width:75%' ><p><a name="ece068d5-62d5-42ef-b15a-b0716109862d"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> GroupUngroupButton</h3>

<h4>Summary</h4>

<p>The private read only <code>GroupUngroupButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65343cc5-204f-4308-90f5-7d9ec54f9018'>RotationSlider</a></td><td style='width:75%' class='def'><p><a name="65343cc5-204f-4308-90f5-7d9ec54f9018"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> RotationSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>RotationSlider</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eeabe786-4dc7-4b15-8b32-d309dba22cbc'>RotationValue</a></td><td style='width:75%' ><p><a name="eeabe786-4dc7-4b15-8b32-d309dba22cbc"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> RotationValue</h3>

<h4>Summary</h4>

<p>The private read only <code>RotationValue</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e78c2923-5065-4beb-960a-21f134742748'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="e78c2923-5065-4beb-960a-21f134742748"></a></p>

<h3>Public <code>KimonoCore.KimonoShape</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#add385ba-c5e1-476f-bb21-f51c409662d6'>ShapeHeight</a></td><td style='width:75%' ><p><a name="add385ba-c5e1-476f-bb21-f51c409662d6"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShapeHeight</h3>

<h4>Summary</h4>

<p>The private read only <code>ShapeHeight</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fde4da1e-2d18-4fa8-8852-77d4c79873e5'>ShapeName</a></td><td style='width:75%' class='def'><p><a name="fde4da1e-2d18-4fa8-8852-77d4c79873e5"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShapeName</h3>

<h4>Summary</h4>

<p>The private read only <code>ShapeName</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23c038d3-b45e-435e-9b9b-697ceef2bfb8'>ShapeType</a></td><td style='width:75%' ><p><a name="23c038d3-b45e-435e-9b9b-697ceef2bfb8"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShapeType</h3>

<h4>Summary</h4>

<p>The private read only <code>ShapeType</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36c14aa4-e4d6-49ae-8f6e-b9fad5e90831'>ShapeWidth</a></td><td style='width:75%' class='def'><p><a name="36c14aa4-e4d6-49ae-8f6e-b9fad5e90831"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShapeWidth</h3>

<h4>Summary</h4>

<p>The private read only <code>ShapeWidth</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b2c06ab-5ab9-47ab-88da-293f4d17ab7e'>ShapeX</a></td><td style='width:75%' ><p><a name="9b2c06ab-5ab9-47ab-88da-293f4d17ab7e"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShapeX</h3>

<h4>Summary</h4>

<p>The private read only <code>ShapeX</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#975bafff-819e-43c9-992a-28912f94da2b'>ShapeY</a></td><td style='width:75%' class='def'><p><a name="975bafff-819e-43c9-992a-28912f94da2b"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ShapeY</h3>

<h4>Summary</h4>

<p>The private read only <code>ShapeY</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e617ed7-e560-4780-9e24-eb2ce4260d92'>VisibleButton</a></td><td style='width:75%' ><p><a name="6e617ed7-e560-4780-9e24-eb2ce4260d92"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> VisibleButton</h3>

<h4>Summary</h4>

<p>The private read only <code>VisibleButton</code> property of the <code>KimonoInspectorGeneralInfo</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4e8e921a-1efa-42da-a9a7-74340af13b3f'>DeleteShape</a></td><td style='width:75%' ><p><a name="4e8e921a-1efa-42da-a9a7-74340af13b3f"></a></p>

<h3>Private Void DeleteShape (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shape being deleted.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="69379849-e52b-4abe-a6a7-b9933652605c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed4e2f50-12d3-4d86-808b-88fb974caf19'>DuplicateShape</a></td><td style='width:75%' class='def'><p><a name="ed4e2f50-12d3-4d86-808b-88fb974caf19"></a></p>

<h3>Private Void DuplicateShape (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the shape being duplicated.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d5da6a38-7774-4b00-9607-cc1187250ca2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#859f466a-fa99-4da4-9bed-228fd04cb5f2'>EditOrFinalizeShape</a></td><td style='width:75%' ><p><a name="859f466a-fa99-4da4-9bed-228fd04cb5f2"></a></p>

<h3>Private Void EditOrFinalizeShape (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Edits the or finalize and editable shape such as a <code>KimonoShapeGroup</code> or <code>KimonoShapeVector</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="40eeec16-10c0-4f31-b53b-1d4441437a35"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2893c216-f87e-49aa-acae-6c84adfd15d9'>GroupUngroupShapes</a></td><td style='width:75%' class='def'><p><a name="2893c216-f87e-49aa-acae-6c84adfd15d9"></a></p>

<h3>Private Void GroupUngroupShapes (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a collection of <code>KimonoShapes</code> being grouped and ungrouped.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="29c3009d-7ab0-4d02-8fbb-2df8cdd4c230"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ec720e7-3992-4b78-a005-0ce32d4dd8bd'>Initialize</a></td><td style='width:75%' ><p><a name="0ec720e7-3992-4b78-a005-0ce32d4dd8bd"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5306c7f8-bff5-4deb-bbf0-4468b472f950'>KimonoInspectorGeneralInfo</a></td><td style='width:75%' class='def'><p><a name="5306c7f8-bff5-4deb-bbf0-4468b472f950"></a></p>

<h3>Public Void KimonoInspectorGeneralInfo (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a11c2de0-ef79-4a59-ae37-0c8806453775">KimonoInspectorGeneralInfo</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="74ce72da-0ba3-4b0b-8a4c-8d5a35d5f696"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fadbf45-cca5-44da-b48d-2f0a593bd8a4'>MoveTo</a></td><td style='width:75%' ><p><a name="1fadbf45-cca5-44da-b48d-2f0a593bd8a4"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="b9986ee8-717e-40fa-a248-78bd92d6bd7d"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01c79d9d-e5bd-4e35-9d83-7baabe3be5bc'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="01c79d9d-e5bd-4e35-9d83-7baabe3be5bc"></a></p>

<h3>Void RaiseMakeDuplicate ()</h3>

<h4>Summary</h4>

<p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2f01093-1676-4633-8f85-97daaa4913de'>RaiseRemoveShape</a></td><td style='width:75%' ><p><a name="c2f01093-1676-4633-8f85-97daaa4913de"></a></p>

<h3>Void RaiseRemoveShape ()</h3>

<h4>Summary</h4>

<p>Raises the remove shape event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28becaf2-dc38-4031-bcd7-21852844cfbb'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="28becaf2-dc38-4031-bcd7-21852844cfbb"></a></p>

<h3>Void RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="761e2a49-7ea4-44b7-8ee7-457c8e5c4ddf"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>Selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cec311dc-6153-473d-84f6-9fc1dabf9b33'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="cec311dc-6153-473d-84f6-9fc1dabf9b33"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae959ac4-7e0b-471d-82c8-ed0a4e309085'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p><a name="ae959ac4-7e0b-471d-82c8-ed0a4e309085"></a></p>

<h3>Void RaiseSketchModified ()</h3>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d536f10-c1bd-414c-8aca-110035f99f0f'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="6d536f10-c1bd-414c-8aca-110035f99f0f"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGeneralInfo</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e47c8538-fa36-4c11-9e4a-9445391a80e7'>RotationChanged</a></td><td style='width:75%' class='def'><p><a name="e47c8538-fa36-4c11-9e4a-9445391a80e7"></a></p>

<h3>Private Void RotationChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the rotation being changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1e59edb5-7243-4c02-af90-e6d1ef119002"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b792479d-fbed-4465-8499-e4d689b40831'>UpdateInspector</a></td><td style='width:75%' ><p><a name="b792479d-fbed-4465-8499-e4d689b40831"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49b38202-cf4a-4b4b-b630-37e88b271ebb'>VisibilityChanged</a></td><td style='width:75%' class='def'><p><a name="49b38202-cf4a-4b4b-b630-37e88b271ebb"></a></p>

<h3>Private Void VisibilityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the visibility changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4024f492-0d8a-444f-8c1f-f475a7c35541"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5c87c8eb-3894-4527-9f29-2f1754c3936f'>MakeDuplicate</a></td><td style='width:75%' ><p><a name="5c87c8eb-3894-4527-9f29-2f1754c3936f"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> MakeDuplicate</h3>

<h4>Summary</h4>

<p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#249c726b-f2a6-416b-81fd-3c9506b6adc2'>RemoveShape</a></td><td style='width:75%' class='def'><p><a name="249c726b-f2a6-416b-81fd-3c9506b6adc2"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> RemoveShape</h3>

<h4>Summary</h4>

<p>Occurs when remove shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fd75de8-b6d9-4d3b-af6e-77f1ab7d6eac'>SelectionChanged</a></td><td style='width:75%' ><p><a name="1fd75de8-b6d9-4d3b-af6e-77f1ab7d6eac"></a></p>

<h3><code>KimonoCore.Kimono.ShapeEventDelegate</code> SelectionChanged</h3>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57a2bb32-97c0-4aa3-8363-d52a4515bc46'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="57a2bb32-97c0-4aa3-8363-d52a4515bc46"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bea68a2-450b-474a-bf0a-5ba3af35e566'>SketchModified</a></td><td style='width:75%' ><p><a name="2bea68a2-450b-474a-bf0a-5ba3af35e566"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> SketchModified</h3>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#46284a9a-dbb7-4d59-84bb-684bcad47742'>_selectedGradient</a></td><td style='width:75%' ><p><a name="46284a9a-dbb7-4d59-84bb-684bcad47742"></a>
<b>Private <code>KimonoCore.KimonoGradient</code> _selectedGradient</b></p>

<p>The selected gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2192a6ba-9c8e-4b4c-b527-60eb4338b126'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="2192a6ba-9c8e-4b4c-b527-60eb4338b126"></a>
<b>Private <code>KimonoCore.KimonoShape</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75fffb72-3ee7-45fb-925b-f716b9eb9393'>GradientModified</a></td><td style='width:75%' ><p><a name="75fffb72-3ee7-45fb-925b-f716b9eb9393"></a>
<b>Private <code>KimonoCore.Kimono.GradientEventDelegate</code> GradientModified</b></p>

<p>The private <code>GradientModified</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d79eaa15-4685-4664-89ed-a58e642651a9'>MakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="d79eaa15-4685-4664-89ed-a58e642651a9"></a>
<b>Private <code>KimonoCore.Kimono.GradientEventDelegate</code> MakeDuplicate</b></p>

<p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#749e491c-8423-4df8-bdd2-fc7d45aa3a3c'>RemoveGradient</a></td><td style='width:75%' ><p><a name="749e491c-8423-4df8-bdd2-fc7d45aa3a3c"></a>
<b>Private <code>KimonoCore.Kimono.GradientEventDelegate</code> RemoveGradient</b></p>

<p>The private <code>RemoveGradient</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3387906-9ee6-48ae-aba9-0db0c253458b'>ReturnToShape</a></td><td style='width:75%' class='def'><p><a name="b3387906-9ee6-48ae-aba9-0db0c253458b"></a>
<b>Private <code>KimonoCore.Kimono.ShapeEventDelegate</code> ReturnToShape</b></p>

<p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#494fe256-b025-402d-8d4f-73186ac8406e'>ShapeModified</a></td><td style='width:75%' ><p><a name="494fe256-b025-402d-8d4f-73186ac8406e"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorGradient</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1fcb9710-2d5c-412b-a3d9-0fc2d406c7b4'>AddColorButton</a></td><td style='width:75%' ><p><a name="1fcb9710-2d5c-412b-a3d9-0fc2d406c7b4"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AddColorButton</h3>

<h4>Summary</h4>

<p>The private read only <code>AddColorButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b340ef5d-8208-4800-a4c3-d1a3e18a6825'>AddPointButton</a></td><td style='width:75%' class='def'><p><a name="b340ef5d-8208-4800-a4c3-d1a3e18a6825"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AddPointButton</h3>

<h4>Summary</h4>

<p>The private read only <code>AddPointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90cbb551-2857-46a4-94a0-1eb0b0685428'>BackButton</a></td><td style='width:75%' ><p><a name="90cbb551-2857-46a4-94a0-1eb0b0685428"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> BackButton</h3>

<h4>Summary</h4>

<p>The private read only <code>BackButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6571e8fb-ace7-4437-8736-3cd365e1ab77'>DeleteButton</a></td><td style='width:75%' class='def'><p><a name="6571e8fb-ace7-4437-8736-3cd365e1ab77"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DeleteButton</h3>

<h4>Summary</h4>

<p>The private read only <code>DeleteButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#718ecde4-977e-458b-8311-989c48fdb911'>DeletePointButton</a></td><td style='width:75%' ><p><a name="718ecde4-977e-458b-8311-989c48fdb911"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DeletePointButton</h3>

<h4>Summary</h4>

<p>The private read only <code>DeletePointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2a78c24-ba36-4de0-a0e4-4b7101064b69'>DesignBar</a></td><td style='width:75%' class='def'><p><a name="a2a78c24-ba36-4de0-a0e4-4b7101064b69"></a></p>

<h3>Private Read Only <code>KimonoCore.Mac.KimonoGradientDesignBar</code> DesignBar</h3>

<h4>Summary</h4>

<p>The private read only <code>DesignBar</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoGradientDesignBar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3f0aaf4-7862-493f-85ce-eac57236f184'>DesignPreview</a></td><td style='width:75%' ><p><a name="d3f0aaf4-7862-493f-85ce-eac57236f184"></a></p>

<h3>Private Read Only <code>KimonoCore.Mac.KimonoGradientDesignPreview</code> DesignPreview</h3>

<h4>Summary</h4>

<p>The private read only <code>DesignPreview</code> property of the <code>KimonoInspectorGradient</code> class has a <code>KimonoCore.Mac.KimonoGradientDesignPreview</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6289028f-c2b0-4e8a-bc3c-44360a4abf24'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="6289028f-c2b0-4e8a-bc3c-44360a4abf24"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54f4e868-2144-4a4f-a7f1-dddaee6091e0'>DuplicateButton</a></td><td style='width:75%' ><p><a name="54f4e868-2144-4a4f-a7f1-dddaee6091e0"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DuplicateButton</h3>

<h4>Summary</h4>

<p>The private read only <code>DuplicateButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#751c9ca8-f05b-4a68-99d9-a6b77bdc157f'>DuplicatePointButton</a></td><td style='width:75%' class='def'><p><a name="751c9ca8-f05b-4a68-99d9-a6b77bdc157f"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DuplicatePointButton</h3>

<h4>Summary</h4>

<p>The private read only <code>DuplicatePointButton</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#522734b3-a054-492e-a11a-5d3e968628bd'>GradientName</a></td><td style='width:75%' ><p><a name="522734b3-a054-492e-a11a-5d3e968628bd"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> GradientName</h3>

<h4>Summary</h4>

<p>The private read only <code>GradientName</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e51bdef5-dbf1-4e3a-a15e-f20e53caf8da'>LinkedColorDropdown</a></td><td style='width:75%' class='def'><p><a name="e51bdef5-dbf1-4e3a-a15e-f20e53caf8da"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LinkedColorDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>LinkedColorDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93d5b223-8a71-43f7-ad22-1b417d6cadeb'>OpacitySlider</a></td><td style='width:75%' ><p><a name="93d5b223-8a71-43f7-ad22-1b417d6cadeb"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> OpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2755692a-6483-4a2b-9c26-79fce5417bf9'>OpacityValue</a></td><td style='width:75%' class='def'><p><a name="2755692a-6483-4a2b-9c26-79fce5417bf9"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> OpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d78c094-488c-4cae-809d-0c45d4ab9c17'>PointColor</a></td><td style='width:75%' ><p><a name="7d78c094-488c-4cae-809d-0c45d4ab9c17"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> PointColor</h3>

<h4>Summary</h4>

<p>The private read only <code>PointColor</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23f3674b-d7e8-4971-9a78-724590d6f076'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="23f3674b-d7e8-4971-9a78-724590d6f076"></a></p>

<h3>Public Read Only <code>KimonoCore.KimonoPortfolio</code> Portfolio</h3>

<h4>Summary</h4>

<p>Gets the portfolio.</p>

<h4>Return Value</h4>

<p>The portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ced2cd5-1659-400e-b6d7-d9e8884a697a'>RadiusSlider</a></td><td style='width:75%' ><p><a name="5ced2cd5-1659-400e-b6d7-d9e8884a697a"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> RadiusSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>RadiusSlider</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96cd3eb4-daee-4219-a6e6-32df8a9aa871'>RadiusValue</a></td><td style='width:75%' class='def'><p><a name="96cd3eb4-daee-4219-a6e6-32df8a9aa871"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> RadiusValue</h3>

<h4>Summary</h4>

<p>The private read only <code>RadiusValue</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2340f2b-6819-491e-8908-bab7262169bf'>SelectedColorTitle</a></td><td style='width:75%' ><p><a name="f2340f2b-6819-491e-8908-bab7262169bf"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SelectedColorTitle</h3>

<h4>Summary</h4>

<p>The private read only <code>SelectedColorTitle</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#427ee58c-7851-4ea0-bfd6-d2083dd646ac'>SelectedGradient</a></td><td style='width:75%' class='def'><p><a name="427ee58c-7851-4ea0-bfd6-d2083dd646ac"></a></p>

<h3>Public <code>KimonoCore.KimonoGradient</code> SelectedGradient</h3>

<h4>Summary</h4>

<p>Gets or sets the selected gradient.</p>

<h4>Return Value</h4>

<p>The selected gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69c4d8e0-a0f6-4bf4-8d9f-37f318fba79c'>SelectedShape</a></td><td style='width:75%' ><p><a name="69c4d8e0-a0f6-4bf4-8d9f-37f318fba79c"></a></p>

<h3>Public <code>KimonoCore.KimonoShape</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a2e4849-99bc-48a2-a985-1119c3f1fd79'>TileDropdown</a></td><td style='width:75%' class='def'><p><a name="6a2e4849-99bc-48a2-a985-1119c3f1fd79"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> TileDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>TileDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0ba6d05-afbf-47a3-bc67-6eda3f404789'>TypeDropdown</a></td><td style='width:75%' ><p><a name="d0ba6d05-afbf-47a3-bc67-6eda3f404789"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> TypeDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>TypeDropdown</code> property of the <code>KimonoInspectorGradient</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c1f558b9-c392-46c5-a648-649e1015f0ab'>AddColor</a></td><td style='width:75%' ><p><a name="c1f558b9-c392-46c5-a648-649e1015f0ab"></a></p>

<h3>Private Void AddColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="80014d57-cd0e-4d80-9064-7e45e2f5b1fa"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c32a7d98-f587-4446-8abf-73731da73634'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="c32a7d98-f587-4446-8abf-73731da73634"></a></p>

<h3>Private Void AddPoint (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e247b3b3-ed74-44b2-ab21-468318d9a97f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dbd5c19-c428-41ac-b42f-1d150e0dfa50'>DeleteGradient</a></td><td style='width:75%' ><p><a name="0dbd5c19-c428-41ac-b42f-1d150e0dfa50"></a></p>

<h3>Private Void DeleteGradient (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Deletes the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2d6f3408-c364-4954-8fa8-93066ccb8ccf"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9f51163-1686-4f3a-9e21-5e86ca7618a9'>DeletePoint</a></td><td style='width:75%' class='def'><p><a name="b9f51163-1686-4f3a-9e21-5e86ca7618a9"></a></p>

<h3>Private Void DeletePoint (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Deletes the point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d0efeff6-6121-47c0-95b0-d96728f4ae8f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2012ba90-0490-4028-8cfa-5ea65c7d03d0'>DuplicateGradient</a></td><td style='width:75%' ><p><a name="2012ba90-0490-4028-8cfa-5ea65c7d03d0"></a></p>

<h3>Private Void DuplicateGradient (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0facb665-8363-4c93-9ca7-f342ebbb09c0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#259a4b1e-6f72-4799-b292-14922eeb6ff4'>DuplicatePoint</a></td><td style='width:75%' class='def'><p><a name="259a4b1e-6f72-4799-b292-14922eeb6ff4"></a></p>

<h3>Private Void DuplicatePoint (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="415aa150-ec85-48c3-bef7-553f04bff788"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19b44bc3-a9b5-4d3f-a75e-e9af9512b54b'>GoBack</a></td><td style='width:75%' ><p><a name="19b44bc3-a9b5-4d3f-a75e-e9af9512b54b"></a></p>

<h3>Private Void GoBack (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Sends the user back to the selected shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="fb386f28-f64f-4722-8286-913065c0335d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7e2739d-dfb9-4ace-8cc2-c807783b18be'>Initialize</a></td><td style='width:75%' class='def'><p><a name="a7e2739d-dfb9-4ace-8cc2-c807783b18be"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c73d3339-779f-4ca3-a3a6-58bb0c548d33'>KimonoInspectorGradient</a></td><td style='width:75%' ><p><a name="c73d3339-779f-4ca3-a3a6-58bb0c548d33"></a></p>

<h3>Public Void KimonoInspectorGradient (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d5064eca-591d-4f74-bf35-da5f7fbdbb3b">KimonoInspectorGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="cce9e2c3-df0e-4c92-8004-08ed1c04e8c9"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13755d78-bde3-425a-b551-596f36f9d73a'>LinkedColorChanged</a></td><td style='width:75%' class='def'><p><a name="13755d78-bde3-425a-b551-596f36f9d73a"></a></p>

<h3>Private Void LinkedColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the linked color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7d4e8ad2-75d2-46bc-a533-58c5a25d4c2a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a791af13-f53c-4d28-91e4-52bf7c808fbf'>MoveTo</a></td><td style='width:75%' ><p><a name="a791af13-f53c-4d28-91e4-52bf7c808fbf"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="c45f0a66-d5c5-4e6d-9343-bbfaa2857694"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8dd74a9-88b6-4dd6-8b43-08631ac74534'>OpacityChanged</a></td><td style='width:75%' class='def'><p><a name="c8dd74a9-88b6-4dd6-8b43-08631ac74534"></a></p>

<h3>Private Void OpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the opacity changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b47c51b9-ce35-44dc-a457-62e4e9dc3529"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f26cc320-7838-481e-bc8e-630acfcff56b'>PointColorChanged</a></td><td style='width:75%' ><p><a name="f26cc320-7838-481e-bc8e-630acfcff56b"></a></p>

<h3>Private Void PointColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles a point color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="41982acf-1b43-495d-a347-abc5bb4feef0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c6bd050-5b12-435e-93ec-fc6217ad47ff'>RadiusChanged</a></td><td style='width:75%' class='def'><p><a name="9c6bd050-5b12-435e-93ec-fc6217ad47ff"></a></p>

<h3>Private Void RadiusChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the radius changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4c986dba-9cc2-4461-9033-c2c52699d2f6"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#337c1f06-6908-41df-a345-97a2c6744f69'>RaiseGradientModified</a></td><td style='width:75%' ><p><a name="337c1f06-6908-41df-a345-97a2c6744f69"></a></p>

<h3>Void RaiseGradientModified (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="0b8644e5-4a33-41a5-8503-0070dc36b8af"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>Gradient.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcd84338-edf3-4d3a-ac0f-79dc96c870e8'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="fcd84338-edf3-4d3a-ac0f-79dc96c870e8"></a></p>

<h3>Void RaiseMakeDuplicate (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Raises the make duplicate event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="1ba9ca43-3441-463b-8cad-279bc47295f8"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>Gradient.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3102e9fb-6764-4cb9-ab4c-15123aa034ed'>RaiseRemoveGradient</a></td><td style='width:75%' ><p><a name="3102e9fb-6764-4cb9-ab4c-15123aa034ed"></a></p>

<h3>Void RaiseRemoveGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Raises the remove gradient event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="7c44e5ba-8107-421d-8826-17ad11711cbd"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>Gradient.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b2e7082-124c-42ba-a5be-cb7f52ab16eb'>RaiseReturnToShape</a></td><td style='width:75%' class='def'><p><a name="7b2e7082-124c-42ba-a5be-cb7f52ab16eb"></a></p>

<h3>Void RaiseReturnToShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the return to shape event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="46948def-3287-4a25-a409-62a8abb90711"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14e4ae60-10aa-4e2d-847e-fe70a772a6c2'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="14e4ae60-10aa-4e2d-847e-fe70a772a6c2"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#652eede7-41e0-48ae-9a31-7d13506e2a7b'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="652eede7-41e0-48ae-9a31-7d13506e2a7b"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGradient</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32b201e3-6b83-4397-96ec-eb9aac371b7b'>ShowCurrentColor</a></td><td style='width:75%' ><p><a name="32b201e3-6b83-4397-96ec-eb9aac371b7b"></a></p>

<h3>Private Void ShowCurrentColor ()</h3>

<h4>Summary</h4>

<p>Shows current color values.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa4c53f3-27b3-4635-8707-ac7ec1226309'>TileChanged</a></td><td style='width:75%' class='def'><p><a name="fa4c53f3-27b3-4635-8707-ac7ec1226309"></a></p>

<h3>Private Void TileChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the tile mode changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="367c317d-0315-421a-9d24-a2c2ec716317"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aebcd537-c1be-45b6-8181-75fa283fd4ce'>TypeChanged</a></td><td style='width:75%' ><p><a name="aebcd537-c1be-45b6-8181-75fa283fd4ce"></a></p>

<h3>Private Void TypeChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the gradient's type changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7511bb7e-f1c9-4987-9ca7-6c76f8099e39"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c24e72c-002b-4093-b3af-71b9f1bb5425'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="0c24e72c-002b-4093-b3af-71b9f1bb5425"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cce4b870-fd18-4f70-9207-b272a10e430e'>GradientModified</a></td><td style='width:75%' ><p><a name="cce4b870-fd18-4f70-9207-b272a10e430e"></a></p>

<h3><code>KimonoCore.Kimono.GradientEventDelegate</code> GradientModified</h3>

<h4>Summary</h4>

<p>Occurs when gradient modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#094a8955-f7ce-4a1e-8433-884f7a7414e9'>MakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="094a8955-f7ce-4a1e-8433-884f7a7414e9"></a></p>

<h3><code>KimonoCore.Kimono.GradientEventDelegate</code> MakeDuplicate</h3>

<h4>Summary</h4>

<p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3159239-bf48-4341-a3ca-fc2e8f7c05b5'>RemoveGradient</a></td><td style='width:75%' ><p><a name="b3159239-bf48-4341-a3ca-fc2e8f7c05b5"></a></p>

<h3><code>KimonoCore.Kimono.GradientEventDelegate</code> RemoveGradient</h3>

<h4>Summary</h4>

<p>Occurs when remove gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e16f479-0a81-452d-bad5-c6a38d404e0b'>ReturnToShape</a></td><td style='width:75%' class='def'><p><a name="9e16f479-0a81-452d-bad5-c6a38d404e0b"></a></p>

<h3><code>KimonoCore.Kimono.ShapeEventDelegate</code> ReturnToShape</h3>

<h4>Summary</h4>

<p>Occurs when return to shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b228f7ff-31cf-4605-a3bf-e462b6772c63'>ShapeModified</a></td><td style='width:75%' ><p><a name="b228f7ff-31cf-4605-a3bf-e462b6772c63"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6eccc142-a975-4438-918f-60492413470d'>_selectedGroup</a></td><td style='width:75%' ><p><a name="6eccc142-a975-4438-918f-60492413470d"></a>
<b>Private <code>KimonoCore.KimonoShapeGroup</code> _selectedGroup</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d671a73-d8c5-428e-aeea-fc9017603a86'>GroupModified</a></td><td style='width:75%' class='def'><p><a name="1d671a73-d8c5-428e-aeea-fc9017603a86"></a>
<b>Private <code>KimonoCore.Kimono.GroupEventDelegate</code> GroupModified</b></p>

<p>The private <code>GroupModified</code> field of the <code>KimonoInspectorGroup</code> class holds a <code>KimonoCore.Kimono.GroupEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#762558d6-345f-47fd-b087-edafc64bca77'>BooleanCheckbox</a></td><td style='width:75%' ><p><a name="762558d6-345f-47fd-b087-edafc64bca77"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> BooleanCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>BooleanCheckbox</code> property of the <code>KimonoInspectorGroup</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc610313-82b2-4f32-8f42-064f2f9e0c8c'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="fc610313-82b2-4f32-8f42-064f2f9e0c8c"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a51f57e0-944c-47cc-a66a-245d11c1fee3'>MaskCheckbox</a></td><td style='width:75%' ><p><a name="a51f57e0-944c-47cc-a66a-245d11c1fee3"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> MaskCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>MaskCheckbox</code> property of the <code>KimonoInspectorGroup</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d08838-bf19-4745-8aa7-7577eed411fc'>Operation</a></td><td style='width:75%' class='def'><p><a name="a7d08838-bf19-4745-8aa7-7577eed411fc"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> Operation</h3>

<h4>Summary</h4>

<p>The private read only <code>Operation</code> property of the <code>KimonoInspectorGroup</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42210762-382f-4ba2-a05e-b5831de790eb'>SelectedGroup</a></td><td style='width:75%' ><p><a name="42210762-382f-4ba2-a05e-b5831de790eb"></a></p>

<h3>Public <code>KimonoCore.KimonoShapeGroup</code> SelectedGroup</h3>

<h4>Summary</h4>

<p>Gets or sets the selected group.</p>

<h4>Return Value</h4>

<p>The selected group.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#35a7e370-6663-4d2a-8c7b-0058ce2f0ac8'>BooleanChanged</a></td><td style='width:75%' ><p><a name="35a7e370-6663-4d2a-8c7b-0058ce2f0ac8"></a></p>

<h3>Private Void BooleanChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the boolean operation being changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4c817f4a-47e0-4643-a8c9-8996f427a71a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd640416-5ca0-4e07-aecb-8e72c725deaf'>Initialize</a></td><td style='width:75%' class='def'><p><a name="dd640416-5ca0-4e07-aecb-8e72c725deaf"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#390c0760-348b-4a79-bf92-038fbe874306'>KimonoInspectorGroup</a></td><td style='width:75%' ><p><a name="390c0760-348b-4a79-bf92-038fbe874306"></a></p>

<h3>Public Void KimonoInspectorGroup (System.IntPtr)</h3>

<h4>Summary</h4>

<p>The public <code>KimonoInspectorGroup (System.IntPtr)</code> constructor for the <code>KimonoInspectorGroup</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="d51a24f3-be54-4881-9904-a6f9b491bdb6"></a>
<b>System.IntPtr handle</b></p>

<p>The <code>handle</code> parameter of the KimonoInspectorGroup method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33ee589c-f455-4b24-8b58-27912faa6541'>MaskChanged</a></td><td style='width:75%' class='def'><p><a name="33ee589c-f455-4b24-8b58-27912faa6541"></a></p>

<h3>Private Void MaskChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the mask changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="adf10298-2183-4eee-852b-e9f47cee9571"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f349fdb-f93e-4aae-9369-ee93a98da6d6'>MoveTo</a></td><td style='width:75%' ><p><a name="6f349fdb-f93e-4aae-9369-ee93a98da6d6"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="5b1631a6-3d34-483b-a5cb-8f744bec4046"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84fbdea3-9142-451c-8ebe-250d25438f61'>OperationChanged</a></td><td style='width:75%' class='def'><p><a name="84fbdea3-9142-451c-8ebe-250d25438f61"></a></p>

<h3>Private Void OperationChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the boolean operation changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="62a76110-15a9-4422-8ecf-7ad61ebdfe5a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2dbeb14-ed07-4d17-9836-ab95aa325467'>RaiseGroupModified</a></td><td style='width:75%' ><p><a name="c2dbeb14-ed07-4d17-9836-ab95aa325467"></a></p>

<h3>Void RaiseGroupModified (KimonoCore.KimonoShapeGroup)</h3>

<h4>Summary</h4>

<p>Raises the group modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="904af602-315c-42d4-b93e-2043af7e57d2"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The <code>KimonoShapeGroup</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6477545f-61fb-4cce-9e49-5733e5d70100'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="6477545f-61fb-4cce-9e49-5733e5d70100"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorGroup</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b39cc18-5d2a-49c4-a839-d460a4689225'>UpdateInspector</a></td><td style='width:75%' ><p><a name="0b39cc18-5d2a-49c4-a839-d460a4689225"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#abe8414e-4eee-4807-9823-0b6d03170c48'>GroupModified</a></td><td style='width:75%' ><p><a name="abe8414e-4eee-4807-9823-0b6d03170c48"></a></p>

<h3><code>KimonoCore.Kimono.GroupEventDelegate</code> GroupModified</h3>

<h4>Summary</h4>

<p>Occurs when group modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d555f566-d260-4ca9-b91c-255000a0b9c8'>_selectedColor</a></td><td style='width:75%' ><p><a name="d555f566-d260-4ca9-b91c-255000a0b9c8"></a>
<b>Private <code>KimonoCore.KimonoColor</code> _selectedColor</b></p>

<p>The color of the selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ff98fd7-8274-4ef1-af29-af364e4201dc'>AvailableBaseColors</a></td><td style='width:75%' class='def'><p><a name="1ff98fd7-8274-4ef1-af29-af364e4201dc"></a>
<b>Private <code>System.Collections.Generic.List&lt;KimonoCore.KimonoColor&gt;</code> AvailableBaseColors</b></p>

<p>The available base colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f2475ef-1671-4bd7-a922-fad2b2c68422'>ColorModified</a></td><td style='width:75%' ><p><a name="0f2475ef-1671-4bd7-a922-fad2b2c68422"></a>
<b>Private <code>KimonoCore.Kimono.ColorEventDelegate</code> ColorModified</b></p>

<p>The private <code>ColorModified</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22ec56c1-842b-430a-9f08-1281c6fd6899'>MakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="22ec56c1-842b-430a-9f08-1281c6fd6899"></a>
<b>Private <code>KimonoCore.Kimono.ColorEventDelegate</code> MakeDuplicate</b></p>

<p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8af2ccc6-20be-4978-af29-26e05d0cf65e'>RemoveColor</a></td><td style='width:75%' ><p><a name="8af2ccc6-20be-4978-af29-26e05d0cf65e"></a>
<b>Private <code>KimonoCore.Kimono.ColorEventDelegate</code> RemoveColor</b></p>

<p>The private <code>RemoveColor</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bbe80c5-435f-48ee-96a1-e0c2d98e3e96'>ReturnToShape</a></td><td style='width:75%' class='def'><p><a name="9bbe80c5-435f-48ee-96a1-e0c2d98e3e96"></a>
<b>Private <code>KimonoCore.Kimono.ShapeEventDelegate</code> ReturnToShape</b></p>

<p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorPaleteColor</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cce07664-29f6-47ed-ab8f-8bb1dfc83dd6'>AdjustBrightnessCheckbox</a></td><td style='width:75%' ><p><a name="cce07664-29f6-47ed-ab8f-8bb1dfc83dd6"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AdjustBrightnessCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>AdjustBrightnessCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30f0e440-1fb2-4ba8-ac72-ce881a21d298'>AdjustHueCheckbox</a></td><td style='width:75%' class='def'><p><a name="30f0e440-1fb2-4ba8-ac72-ce881a21d298"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AdjustHueCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>AdjustHueCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f20fc5d-6da3-4e3e-a9f0-b61cfcd732d4'>AdjustOpacityCheckbox</a></td><td style='width:75%' ><p><a name="3f20fc5d-6da3-4e3e-a9f0-b61cfcd732d4"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AdjustOpacityCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>AdjustOpacityCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#920b0f88-8397-457d-af9d-a1f13bef55d9'>AdjustSaturationCheckbox</a></td><td style='width:75%' class='def'><p><a name="920b0f88-8397-457d-af9d-a1f13bef55d9"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> AdjustSaturationCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>AdjustSaturationCheckbox</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8950e181-038a-47ed-8b3c-eaaaed856b7d'>BaseColorSelector</a></td><td style='width:75%' ><p><a name="8950e181-038a-47ed-8b3c-eaaaed856b7d"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> BaseColorSelector</h3>

<h4>Summary</h4>

<p>The private read only <code>BaseColorSelector</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad21d3fb-be47-467b-a46e-65e0fce8b7a3'>BrightnessSlider</a></td><td style='width:75%' class='def'><p><a name="ad21d3fb-be47-467b-a46e-65e0fce8b7a3"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> BrightnessSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>BrightnessSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22d8e88d-9edd-4b68-963a-473903d06edd'>BrightnessValue</a></td><td style='width:75%' ><p><a name="22d8e88d-9edd-4b68-963a-473903d06edd"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> BrightnessValue</h3>

<h4>Summary</h4>

<p>The private read only <code>BrightnessValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b4ca751-9599-4636-a1a8-8972b1c4662e'>Color</a></td><td style='width:75%' class='def'><p><a name="6b4ca751-9599-4636-a1a8-8972b1c4662e"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> Color</h3>

<h4>Summary</h4>

<p>The private read only <code>Color</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3b0509f-ab53-4e28-b28a-1f8f8fd12489'>ColorName</a></td><td style='width:75%' ><p><a name="e3b0509f-ab53-4e28-b28a-1f8f8fd12489"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> ColorName</h3>

<h4>Summary</h4>

<p>The private read only <code>ColorName</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d620f443-109b-4ade-a164-3c74e835244f'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="d620f443-109b-4ade-a164-3c74e835244f"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6602baf7-5852-47b9-931e-65e9c60589ae'>GoBackButton</a></td><td style='width:75%' ><p><a name="6602baf7-5852-47b9-931e-65e9c60589ae"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> GoBackButton</h3>

<h4>Summary</h4>

<p>The private read only <code>GoBackButton</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6d29735-b60a-4ba3-ac00-0ab1caff0841'>HueSlider</a></td><td style='width:75%' class='def'><p><a name="f6d29735-b60a-4ba3-ac00-0ab1caff0841"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> HueSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>HueSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8ea57c5-2206-41a0-bf16-d889cb18f552'>HueValue</a></td><td style='width:75%' ><p><a name="a8ea57c5-2206-41a0-bf16-d889cb18f552"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> HueValue</h3>

<h4>Summary</h4>

<p>The private read only <code>HueValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e4d9e14-f649-4a0c-8ec6-9e6c0325b04e'>OpacitySlider</a></td><td style='width:75%' class='def'><p><a name="6e4d9e14-f649-4a0c-8ec6-9e6c0325b04e"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> OpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d872b37-b446-421c-8a88-9e8275edfa2b'>OpacityValue</a></td><td style='width:75%' ><p><a name="6d872b37-b446-421c-8a88-9e8275edfa2b"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> OpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05ac4f05-107a-4d74-a50b-7ef6a11c49f6'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="05ac4f05-107a-4d74-a50b-7ef6a11c49f6"></a></p>

<h3>Public Read Only <code>KimonoCore.KimonoPortfolio</code> Portfolio</h3>

<h4>Summary</h4>

<p>Gets the portfolio.</p>

<h4>Return Value</h4>

<p>The portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9d37a50-ce58-431e-966b-a389099b36be'>SaturationSlider</a></td><td style='width:75%' ><p><a name="d9d37a50-ce58-431e-966b-a389099b36be"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> SaturationSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>SaturationSlider</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca3e7176-e8dd-40ff-9c03-0fa1e13e198b'>SaturationValue</a></td><td style='width:75%' class='def'><p><a name="ca3e7176-e8dd-40ff-9c03-0fa1e13e198b"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SaturationValue</h3>

<h4>Summary</h4>

<p>The private read only <code>SaturationValue</code> property of the <code>KimonoInspectorPaleteColor</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19e96e79-f6fb-45c4-a1b5-58092ddf6dc1'>SelectedColor</a></td><td style='width:75%' ><p><a name="19e96e79-f6fb-45c4-a1b5-58092ddf6dc1"></a></p>

<h3>Public <code>KimonoCore.KimonoColor</code> SelectedColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the selected.</p>

<h4>Return Value</h4>

<p>The color of the selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49391691-1c53-4ea9-9016-ff652ee26cc1'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="49391691-1c53-4ea9-9016-ff652ee26cc1"></a></p>

<h3>Public <code>KimonoCore.KimonoShape</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fb69ac06-ab5b-4699-8be5-ccf484628f2c'>AdjustBrightnessChanged</a></td><td style='width:75%' ><p><a name="fb69ac06-ab5b-4699-8be5-ccf484628f2c"></a></p>

<h3>Private Void AdjustBrightnessChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adjusts the brightness changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1998ec80-d2da-492e-9149-23e2efb9d9f9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80b68dfd-1c32-488f-bd9b-787dc09a6e94'>AdjustHueChanged</a></td><td style='width:75%' class='def'><p><a name="80b68dfd-1c32-488f-bd9b-787dc09a6e94"></a></p>

<h3>Private Void AdjustHueChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adjusts the hue changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6e9052e3-f309-435f-83b0-2cce2f447542"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fee2913-5640-4967-bca8-d700c2c79eac'>AdjustOpacityChanged</a></td><td style='width:75%' ><p><a name="4fee2913-5640-4967-bca8-d700c2c79eac"></a></p>

<h3>Private Void AdjustOpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adjusts the opacity changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2b149ad2-62f0-4ce0-a0f2-d3adffb4935f"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92e5d963-0dfb-45f1-b63c-65f88f0cdd84'>AdjustSaturationChanged</a></td><td style='width:75%' class='def'><p><a name="92e5d963-0dfb-45f1-b63c-65f88f0cdd84"></a></p>

<h3>Private Void AdjustSaturationChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adjusts the saturation changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2e6290b0-b62e-40bb-8191-dd1a4e633de7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3025a0b-3038-4fb3-b3f4-449320b26792'>BaseColorChanged</a></td><td style='width:75%' ><p><a name="e3025a0b-3038-4fb3-b3f4-449320b26792"></a></p>

<h3>Private Void BaseColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the base color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="609aa29b-1ca3-453a-ab3f-ff0cfc7862ca"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4565ce52-408f-4978-bd58-a67266ad63e1'>BrightnessChanged</a></td><td style='width:75%' class='def'><p><a name="4565ce52-408f-4978-bd58-a67266ad63e1"></a></p>

<h3>Private Void BrightnessChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the brightness chanigng.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4e7fcd45-b70a-48a7-9138-3127b072cb1c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15bb806c-e8a9-4799-867a-ed5d37d35517'>ColorChanged</a></td><td style='width:75%' ><p><a name="15bb806c-e8a9-4799-867a-ed5d37d35517"></a></p>

<h3>Private Void ColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5bb01fdd-aace-4f05-ad92-52cd032103de"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ad92054-a9b3-40fe-8e6f-4e102d2f4a3e'>ColorNameChanged</a></td><td style='width:75%' class='def'><p><a name="8ad92054-a9b3-40fe-8e6f-4e102d2f4a3e"></a></p>

<h3>Private Void ColorNameChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the color name changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a53f5a37-1d0c-4926-bb65-5149c6cbaf20"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35e9d812-d66d-426f-b601-4593e27dce6c'>DeleteColor</a></td><td style='width:75%' ><p><a name="35e9d812-d66d-426f-b601-4593e27dce6c"></a></p>

<h3>Private Void DeleteColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Deletes the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8cf7e71d-f192-4787-ba74-6c0ce6fa89eb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72eb8d95-6481-45ee-812e-e16e88fcf82b'>DisplayCurrentColor</a></td><td style='width:75%' class='def'><p><a name="72eb8d95-6481-45ee-812e-e16e88fcf82b"></a></p>

<h3>Private Void DisplayCurrentColor ()</h3>

<h4>Summary</h4>

<p>Displays the current color</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#683c3959-35e1-43a8-b708-a12dce5f8a6c'>DuplicateColor</a></td><td style='width:75%' ><p><a name="683c3959-35e1-43a8-b708-a12dce5f8a6c"></a></p>

<h3>Private Void DuplicateColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4fba1ab7-9b6c-4dfd-a80e-f8f540608c07"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba639195-2421-4f39-b33e-f9c4eb46461d'>GoBack</a></td><td style='width:75%' class='def'><p><a name="ba639195-2421-4f39-b33e-f9c4eb46461d"></a></p>

<h3>Private Void GoBack (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Returns the to the selected shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="fc0d4800-69a1-41b5-9403-44f898dd6242"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc0b0554-18fd-4305-ba13-d8b7bce1b5aa'>HueChanged</a></td><td style='width:75%' ><p><a name="bc0b0554-18fd-4305-ba13-d8b7bce1b5aa"></a></p>

<h3>Private Void HueChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the hue changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7c6c4dc5-9a7e-4076-9da6-7147a55ae788"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2f65e3a-3f36-4ee1-8dd3-c6f920f40058'>Initialize</a></td><td style='width:75%' class='def'><p><a name="d2f65e3a-3f36-4ee1-8dd3-c6f920f40058"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7179eece-9d4d-451e-82f1-2b15db92eb37'>KimonoInspectorPaleteColor</a></td><td style='width:75%' ><p><a name="7179eece-9d4d-451e-82f1-2b15db92eb37"></a></p>

<h3>Public Void KimonoInspectorPaleteColor (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#dfdcb93f-6d98-4469-848e-4ed5b1fa6162">KimonoInspectorPaleteColor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="ae2acf13-b4e0-4456-a191-6a9b76f7d5d1"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e59b8643-6b6c-429a-951b-cd55e8eae50c'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="e59b8643-6b6c-429a-951b-cd55e8eae50c"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="b4ce7a56-44c2-428d-ab27-64854284a05a"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcc1f044-4ba4-4eaf-9c49-7056b0242c5f'>OpacityChanged</a></td><td style='width:75%' ><p><a name="dcc1f044-4ba4-4eaf-9c49-7056b0242c5f"></a></p>

<h3>Private Void OpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the opacity changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2ea20db0-a9e4-4183-a006-d0441c78ec7c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b66e5ec-fdbf-4d06-b34d-9ba88ebc7314'>RaiseColorModified</a></td><td style='width:75%' class='def'><p><a name="0b66e5ec-fdbf-4d06-b34d-9ba88ebc7314"></a></p>

<h3>Void RaiseColorModified (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Raises the color modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="67281ac7-b9ee-41e6-9fd7-0a66f55564ca"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>Color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3013ba98-7a24-457d-aa9c-ae04d9e931d2'>RaiseMakeDuplicate</a></td><td style='width:75%' ><p><a name="3013ba98-7a24-457d-aa9c-ae04d9e931d2"></a></p>

<h3>Void RaiseMakeDuplicate (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Raises the make duplicate event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="907d085b-dd65-446c-9915-ed48a0363440"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>Color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#894dfa83-5b0b-4986-b476-c00da144787d'>RaiseRemoveColor</a></td><td style='width:75%' class='def'><p><a name="894dfa83-5b0b-4986-b476-c00da144787d"></a></p>

<h3>Void RaiseRemoveColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Raises the color of the remove event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="02d5ee55-02c2-47ab-9c35-033a9a17dd84"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>Color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7caf19f5-4372-436a-b95a-75e0421aef7b'>RaiseReturnToShape</a></td><td style='width:75%' ><p><a name="7caf19f5-4372-436a-b95a-75e0421aef7b"></a></p>

<h3>Void RaiseReturnToShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the return to shape event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="c2566a23-8ee4-4989-b86a-903bc83f39c7"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5e41080-bbc3-422a-917d-172639266ae6'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="b5e41080-bbc3-422a-917d-172639266ae6"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPaleteColor</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b600b46-c091-4ce6-8ad7-68f74551c779'>SaturationChanged</a></td><td style='width:75%' ><p><a name="6b600b46-c091-4ce6-8ad7-68f74551c779"></a></p>

<h3>Private Void SaturationChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the saturation changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="44e230f5-3a6d-42aa-b8f4-b4f19e4f9b2e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84881654-880d-4826-9196-7e9abea98c72'>SetColorValues</a></td><td style='width:75%' class='def'><p><a name="84881654-880d-4826-9196-7e9abea98c72"></a></p>

<h3>Private Void SetColorValues ()</h3>

<h4>Summary</h4>

<p>Sets the color values.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fa4c739-4af8-41fa-9b18-f69aed3705ea'>UpdateInspector</a></td><td style='width:75%' ><p><a name="9fa4c739-4af8-41fa-9b18-f69aed3705ea"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f315eeb3-3789-4432-a458-44fc2e558c77'>ColorModified</a></td><td style='width:75%' ><p><a name="f315eeb3-3789-4432-a458-44fc2e558c77"></a></p>

<h3><code>KimonoCore.Kimono.ColorEventDelegate</code> ColorModified</h3>

<h4>Summary</h4>

<p>Occurs when color modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a70d751-6bf9-4974-906f-3bc45b8ebee0'>MakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="4a70d751-6bf9-4974-906f-3bc45b8ebee0"></a></p>

<h3><code>KimonoCore.Kimono.ColorEventDelegate</code> MakeDuplicate</h3>

<h4>Summary</h4>

<p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d431820-b46d-497b-a864-8837728de3eb'>RemoveColor</a></td><td style='width:75%' ><p><a name="1d431820-b46d-497b-a864-8837728de3eb"></a></p>

<h3><code>KimonoCore.Kimono.ColorEventDelegate</code> RemoveColor</h3>

<h4>Summary</h4>

<p>Occurs when remove color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed54d6be-d06f-4c97-bf74-b5a68084c831'>ReturnToShape</a></td><td style='width:75%' class='def'><p><a name="ed54d6be-d06f-4c97-bf74-b5a68084c831"></a></p>

<h3><code>KimonoCore.Kimono.ShapeEventDelegate</code> ReturnToShape</h3>

<h4>Summary</h4>

<p>Occurs when return to shape.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5191599c-7d52-405c-b6a4-61192c1bd28a'>_selectedShape</a></td><td style='width:75%' ><p><a name="5191599c-7d52-405c-b6a4-61192c1bd28a"></a>
<b>Private <code>KimonoCore.KimonoShapePolygon</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ca27ea4-5339-4ec6-8c78-98ba70f46f85'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="0ca27ea4-5339-4ec6-8c78-98ba70f46f85"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorPolygon</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#da9a059d-2466-463e-a6ef-7e973f8a6f2e'>DesignSurface</a></td><td style='width:75%' ><p><a name="da9a059d-2466-463e-a6ef-7e973f8a6f2e"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74663f67-611c-4d46-908b-5aee5d0bb0bc'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="74663f67-611c-4d46-908b-5aee5d0bb0bc"></a></p>

<h3>Public <code>KimonoCore.KimonoShapePolygon</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21d025c9-2e7e-4c25-9337-4e207d99ddfa'>SidesSlider</a></td><td style='width:75%' ><p><a name="21d025c9-2e7e-4c25-9337-4e207d99ddfa"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> SidesSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>SidesSlider</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d2dc103-78c2-4dff-9433-1da06af4a464'>SidesValue</a></td><td style='width:75%' class='def'><p><a name="4d2dc103-78c2-4dff-9433-1da06af4a464"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SidesValue</h3>

<h4>Summary</h4>

<p>The private read only <code>SidesValue</code> property of the <code>KimonoInspectorPolygon</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#203d0615-323b-4cad-9487-5f51db1e3f61'>Initialize</a></td><td style='width:75%' ><p><a name="203d0615-323b-4cad-9487-5f51db1e3f61"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edb52bee-18e2-449c-a068-48d4792a3f1b'>KimonoInspectorPolygon</a></td><td style='width:75%' class='def'><p><a name="edb52bee-18e2-449c-a068-48d4792a3f1b"></a></p>

<h3>Public Void KimonoInspectorPolygon (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9c3f18a9-b56a-4496-9b51-819aca1bd975">KimonoInspectorPolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="d69ee9fd-dcb1-42c1-a6e3-cd8dc9ae81a8"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaf2399d-ccd3-4bdd-bf5f-70f606c4a64b'>MoveTo</a></td><td style='width:75%' ><p><a name="eaf2399d-ccd3-4bdd-bf5f-70f606c4a64b"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="69486071-a21d-44ad-96af-4350f6d96e87"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bd113af-b921-4d1c-8db4-d8040a772e2a'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p><a name="2bd113af-b921-4d1c-8db4-d8040a772e2a"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa876e70-95a8-4c51-90f8-8125f464ea25'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="fa876e70-95a8-4c51-90f8-8125f464ea25"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPolygon</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2735e1d3-401d-4e7b-bc7b-2778f1d9215a'>SidesChanged</a></td><td style='width:75%' class='def'><p><a name="2735e1d3-401d-4e7b-bc7b-2778f1d9215a"></a></p>

<h3>Private Void SidesChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the number of sides changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2cde3cf5-fe88-4ea7-8a2d-fc9b75395412"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca672a76-73f4-41cb-95c3-5c8b9fa09542'>UpdateInspector</a></td><td style='width:75%' ><p><a name="ca672a76-73f4-41cb-95c3-5c8b9fa09542"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f43a6c61-c083-4358-a08f-a32b329526c7'>ShapeModified</a></td><td style='width:75%' ><p><a name="f43a6c61-c083-4358-a08f-a32b329526c7"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
</td></tr></table></p>


---

<a name="7de844b6-6c5e-493c-b1f4-f105188b1fcb"></a>
##Public Class KimonoInspectorPortfolio

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the inspector view for a `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#94cbc3f2-2906-48a8-927f-0c5bf6eb96be'>_selectedPortfolio</a></td><td style='width:75%' ><p><a name="94cbc3f2-2906-48a8-927f-0c5bf6eb96be"></a>
<b>Private <code>KimonoCore.KimonoPortfolio</code> _selectedPortfolio</b></p>

<p>The selected portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beef9c47-6bbe-4e50-a112-4a559b624a37'>FirstChange</a></td><td style='width:75%' class='def'><p><a name="beef9c47-6bbe-4e50-a112-4a559b624a37"></a>
<b>Private <code>System.Boolean</code> FirstChange</b></p>

<p>Indicates of the first change has been made to a textbox. This is used to keep from creating an undo point on every character that the user chages in the textbox's text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#495d03b9-6f70-414e-9ce3-5ec90ed35488'>PortfolioModified</a></td><td style='width:75%' ><p><a name="495d03b9-6f70-414e-9ce3-5ec90ed35488"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> PortfolioModified</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>PortfolioModified</code> field of the <code>KimonoInspectorPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b2186e42-c5c3-4137-bcc4-52c354050326'>AuthorField</a></td><td style='width:75%' ><p><a name="b2186e42-c5c3-4137-bcc4-52c354050326"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> AuthorField</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>AuthorField</code> property of the <code>KimonoInspectorPortfolio</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45118a53-c7fc-4dd6-a350-ece03e5bf60b'>CopyrightField</a></td><td style='width:75%' class='def'><p><a name="45118a53-c7fc-4dd6-a350-ece03e5bf60b"></a></p>

<h3>Private Read Only <a href="#11a4f065-81b1-4138-8e90-61d1bafcb9e4">KimonoMac.KimonoTextView</a> CopyrightField</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>CopyrightField</code> property of the <code>KimonoInspectorPortfolio</code> class has a <code>KimonoMac.KimonoTextView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4d85d62-9ffa-46a4-be2f-aa10bc71cbf6'>DesignSurface</a></td><td style='width:75%' ><p><a name="e4d85d62-9ffa-46a4-be2f-aa10bc71cbf6"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad032a7b-b0a7-48d6-9d71-96afdd733dc2'>NameField</a></td><td style='width:75%' class='def'><p><a name="ad032a7b-b0a7-48d6-9d71-96afdd733dc2"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> NameField</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>NameField</code> property of the <code>KimonoInspectorPortfolio</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0e821d6-4974-4407-a3ca-c38c58416ac4'>NamespaceField</a></td><td style='width:75%' ><p><a name="c0e821d6-4974-4407-a3ca-c38c58416ac4"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> NamespaceField</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>NamespaceField</code> property of the <code>KimonoInspectorPortfolio</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8004a54-a301-4fdb-9862-a8c8acb6c493'>SelectedPortfolio</a></td><td style='width:75%' class='def'><p><a name="f8004a54-a301-4fdb-9862-a8c8acb6c493"></a></p>

<h3>Public <code>KimonoCore.KimonoPortfolio</code> SelectedPortfolio</h3>

<h4>Summary</h4>

<p>Gets or sets the selected portfolio.</p>

<h4>Return Value</h4>

<p>The selected portfolio.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0f4eeaa3-df1d-4e50-b2f5-9f443d774389'>Initialize</a></td><td style='width:75%' ><p><a name="0f4eeaa3-df1d-4e50-b2f5-9f443d774389"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70c5bc2c-0f87-41d6-89e9-fff1b5947d1b'>KimonoInspectorPortfolio</a></td><td style='width:75%' class='def'><p><a name="70c5bc2c-0f87-41d6-89e9-fff1b5947d1b"></a></p>

<h3>Public Void KimonoInspectorPortfolio (System.IntPtr)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The public <code>KimonoInspectorPortfolio (System.IntPtr)</code> constructor for the <code>KimonoInspectorPortfolio</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="56b38fe9-be1f-4484-aa58-98aa35c06de8"></a>
<b>System.IntPtr handle</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>handle</code> parameter of the KimonoInspectorPortfolio method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09a45541-8dd5-469a-91ba-b3783ebce578'>MoveTo</a></td><td style='width:75%' ><p><a name="09a45541-8dd5-469a-91ba-b3783ebce578"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="f01ba913-9f3d-42c6-83ad-015cbfa8782c"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b2b0f27-40eb-47d4-9125-0f42b210b39b'>RaisePortfolioModified</a></td><td style='width:75%' class='def'><p><a name="5b2b0f27-40eb-47d4-9125-0f42b210b39b"></a></p>

<h3>Void RaisePortfolioModified ()</h3>

<h4>Summary</h4>

<p>Raises the portfolio modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35d76cf1-f338-4d69-9dbb-66916a0ae50d'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="35d76cf1-f338-4d69-9dbb-66916a0ae50d"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorPortfolio</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cda9096-1cfe-4806-8021-ea12a7a47f49'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="0cda9096-1cfe-4806-8021-ea12a7a47f49"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aab12995-fb8f-49bb-b42f-03d82bc0ed30'>PortfolioModified</a></td><td style='width:75%' ><p><a name="aab12995-fb8f-49bb-b42f-03d82bc0ed30"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> PortfolioModified</h3>

<h4>Summary</h4>

<p>Occurs when portfolio modified.</p>
</td></tr></table></p>


---

<a name="14cd9500-d1e0-481d-a895-2ffb36c33290"></a>
##Public Class KimonoInspectorProperty

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`AppKit.NSView`

###Summary

Handles the general property inspector for `KimonoProperty` objects.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#36675ead-2674-4dc9-8a8b-d152c725fef0'>_selectedProperty</a></td><td style='width:75%' ><p><a name="36675ead-2674-4dc9-8a8b-d152c725fef0"></a>
<b>Private <code>KimonoCore.KimonoProperty</code> _selectedProperty</b></p>

<p>The selected property.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54ee5a33-1e46-4e8c-88ca-197f72a6e559'>PropertyModified</a></td><td style='width:75%' class='def'><p><a name="54ee5a33-1e46-4e8c-88ca-197f72a6e559"></a>
<b>Private <code>KimonoCore.Kimono.PropertyEventDelegate</code> PropertyModified</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>PropertyModified</code> field of the <code>KimonoInspectorProperty</code> class holds a <code>KimonoCore.Kimono.PropertyEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e019b580-319a-4d07-99e0-9e7fd3379e97'>RequestDeleteProperty</a></td><td style='width:75%' ><p><a name="e019b580-319a-4d07-99e0-9e7fd3379e97"></a>
<b>Private <code>KimonoCore.Kimono.PropertyEventDelegate</code> RequestDeleteProperty</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>RequestDeleteProperty</code> field of the <code>KimonoInspectorProperty</code> class holds a <code>KimonoCore.Kimono.PropertyEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#291a867f-df41-4822-83fa-a4501bf05776'>RequestDuplicateProperty</a></td><td style='width:75%' class='def'><p><a name="291a867f-df41-4822-83fa-a4501bf05776"></a>
<b>Private <code>KimonoCore.Kimono.PropertyEventDelegate</code> RequestDuplicateProperty</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>RequestDuplicateProperty</code> field of the <code>KimonoInspectorProperty</code> class holds a <code>KimonoCore.Kimono.PropertyEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a4a74cd8-d1b8-442f-9fec-36a42d1596c8'>DesignSurface</a></td><td style='width:75%' ><p><a name="a4a74cd8-d1b8-442f-9fec-36a42d1596c8"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cdb0f5b-d267-47c7-95d0-31846910c083'>PropertyName</a></td><td style='width:75%' class='def'><p><a name="7cdb0f5b-d267-47c7-95d0-31846910c083"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> PropertyName</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>PropertyName</code> property of the <code>KimonoInspectorProperty</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59d3f2da-38e6-40fe-a0de-7d6a6651a0ba'>PropertyType</a></td><td style='width:75%' ><p><a name="59d3f2da-38e6-40fe-a0de-7d6a6651a0ba"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> PropertyType</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>PropertyType</code> property of the <code>KimonoInspectorProperty</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28715c11-626a-40ea-adf1-afb58eeb7d6b'>PropertyUsage</a></td><td style='width:75%' class='def'><p><a name="28715c11-626a-40ea-adf1-afb58eeb7d6b"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> PropertyUsage</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>PropertyUsage</code> property of the <code>KimonoInspectorProperty</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#023defe3-418c-43df-a605-f38babea5ee1'>SelectedProperty</a></td><td style='width:75%' ><p><a name="023defe3-418c-43df-a605-f38babea5ee1"></a></p>

<h3>Public <code>KimonoCore.KimonoProperty</code> SelectedProperty</h3>

<h4>Summary</h4>

<p>Gets or sets the selected property.</p>

<h4>Return Value</h4>

<p>The selected property.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4dad6cfe-257b-4ebf-b97a-e763b7460411'>DeleteProperty</a></td><td style='width:75%' ><p><a name="4dad6cfe-257b-4ebf-b97a-e763b7460411"></a></p>

<h3>Private Void DeleteProperty (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Requests the property be deleted.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4885eb1e-eb61-4c8d-82a4-deec11694a47"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd96a958-4a81-4372-9761-e0726ff492d4'>DuplicateProperty</a></td><td style='width:75%' class='def'><p><a name="cd96a958-4a81-4372-9761-e0726ff492d4"></a></p>

<h3>Private Void DuplicateProperty (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="21efcc01-d448-4849-a608-4b2f3414ac43"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03401e36-0af3-4807-839e-373b763a6102'>Initialize</a></td><td style='width:75%' ><p><a name="03401e36-0af3-4807-839e-373b763a6102"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e15466be-9fa8-4df0-9dd3-0fa714aa99e6'>KimonoInspectorProperty</a></td><td style='width:75%' class='def'><p><a name="e15466be-9fa8-4df0-9dd3-0fa714aa99e6"></a></p>

<h3>Public Void KimonoInspectorProperty (System.IntPtr)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The public <code>KimonoInspectorProperty (System.IntPtr)</code> constructor for the <code>KimonoInspectorProperty</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="cef91653-004a-45ae-b87f-b9b3ed54587a"></a>
<b>System.IntPtr handle</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>handle</code> parameter of the KimonoInspectorProperty method takes a <code>System.IntPtr</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d0fa910-beb8-42d0-ada5-3c72ceaa6a09'>MoveTo</a></td><td style='width:75%' ><p><a name="2d0fa910-beb8-42d0-ada5-3c72ceaa6a09"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="0cb178b7-0d4f-4a2a-a65a-09d836e2f0cb"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#460dfdbd-ea46-449c-a627-869213755f30'>RaisePropertyModified</a></td><td style='width:75%' class='def'><p><a name="460dfdbd-ea46-449c-a627-869213755f30"></a></p>

<h3>Void RaisePropertyModified ()</h3>

<h4>Summary</h4>

<p>Raises the property modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96c0765a-2b66-4bf5-b4b6-abfc8715b904'>RaiseRequestDeleteProperty</a></td><td style='width:75%' ><p><a name="96c0765a-2b66-4bf5-b4b6-abfc8715b904"></a></p>

<h3>Void RaiseRequestDeleteProperty ()</h3>

<h4>Summary</h4>

<p>Raises the request delete property event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#796104c7-5ba8-4946-bd17-c90c734857b7'>RaiseRequestDuplicateProperty</a></td><td style='width:75%' class='def'><p><a name="796104c7-5ba8-4946-bd17-c90c734857b7"></a></p>

<h3>Void RaiseRequestDuplicateProperty ()</h3>

<h4>Summary</h4>

<p>Raises the request duplicate property event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cf6bf75-ec9e-4040-aaca-ee3ba6206d30'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="1cf6bf75-ec9e-4040-aaca-ee3ba6206d30"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorProperty</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#047ec225-c302-4270-a329-16282dc07c71'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="047ec225-c302-4270-a329-16282dc07c71"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dae78d9-c5fa-490a-a8db-b6c71dd659ce'>UsageChanged</a></td><td style='width:75%' ><p><a name="0dae78d9-c5fa-490a-a8db-b6c71dd659ce"></a></p>

<h3>Private Void UsageChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Usage the changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a6022195-cf2b-4e27-a210-9881fdbdedec"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2e2b901f-1fff-4124-ae86-801d5b5ee18c'>PropertyModified</a></td><td style='width:75%' ><p><a name="2e2b901f-1fff-4124-ae86-801d5b5ee18c"></a></p>

<h3><code>KimonoCore.Kimono.PropertyEventDelegate</code> PropertyModified</h3>

<h4>Summary</h4>

<p>Occurs when property modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f680b90b-e088-4778-a093-7d5d248c1ed6'>RequestDeleteProperty</a></td><td style='width:75%' class='def'><p><a name="f680b90b-e088-4778-a093-7d5d248c1ed6"></a></p>

<h3><code>KimonoCore.Kimono.PropertyEventDelegate</code> RequestDeleteProperty</h3>

<h4>Summary</h4>

<p>Occurs when delete property.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f92f01af-7278-4ec5-8e60-e19b1bc7c588'>RequestDuplicateProperty</a></td><td style='width:75%' ><p><a name="f92f01af-7278-4ec5-8e60-e19b1bc7c588"></a></p>

<h3><code>KimonoCore.Kimono.PropertyEventDelegate</code> RequestDuplicateProperty</h3>

<h4>Summary</h4>

<p>Occurs when duplicate property.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4036363d-933f-48cb-b999-4b9d3a24d5af'>_selectedRoundRect</a></td><td style='width:75%' ><p><a name="4036363d-933f-48cb-b999-4b9d3a24d5af"></a>
<b>Private <code>KimonoCore.KimonoShapeRoundRect</code> _selectedRoundRect</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae79ad7c-cda7-4b0c-9b67-c92cc163f858'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="ae79ad7c-cda7-4b0c-9b67-c92cc163f858"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorRoundRect</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e1915c15-8f7b-4d8e-9a02-4813f73744c7'>DesignSurface</a></td><td style='width:75%' ><p><a name="e1915c15-8f7b-4d8e-9a02-4813f73744c7"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#840d886b-3758-4571-a50f-3ff0ddd1c49b'>RadiusSlider</a></td><td style='width:75%' class='def'><p><a name="840d886b-3758-4571-a50f-3ff0ddd1c49b"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> RadiusSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>RadiusSlider</code> property of the <code>KimonoInspectorRoundRect</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9fd6f92-c0e8-446c-8f99-efa14bb42702'>RadiusValue</a></td><td style='width:75%' ><p><a name="c9fd6f92-c0e8-446c-8f99-efa14bb42702"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> RadiusValue</h3>

<h4>Summary</h4>

<p>The private read only <code>RadiusValue</code> property of the <code>KimonoInspectorRoundRect</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#401bb4cd-99db-46fb-b423-08c049c45e99'>SelectedRoundRect</a></td><td style='width:75%' class='def'><p><a name="401bb4cd-99db-46fb-b423-08c049c45e99"></a></p>

<h3>Public <code>KimonoCore.KimonoShapeRoundRect</code> SelectedRoundRect</h3>

<h4>Summary</h4>

<p>Gets or sets the selected round rectangle.</p>

<h4>Return Value</h4>

<p>The selected round rectangle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#335ae8ee-7ba7-4b25-be59-a68b136e7bef'>Initialize</a></td><td style='width:75%' ><p><a name="335ae8ee-7ba7-4b25-be59-a68b136e7bef"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df6ba86f-3a91-431d-8ff7-0fbea95b48bc'>KimonoInspectorRoundRect</a></td><td style='width:75%' class='def'><p><a name="df6ba86f-3a91-431d-8ff7-0fbea95b48bc"></a></p>

<h3>Public Void KimonoInspectorRoundRect (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a76afe10-8f40-4938-8f3c-dd0362d71d1f">KimonoInspectorRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="b5167f1a-b34d-4235-a78a-aa4024106ccf"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5019fd7f-a2ed-4920-a3fa-9633d9120c54'>MoveTo</a></td><td style='width:75%' ><p><a name="5019fd7f-a2ed-4920-a3fa-9633d9120c54"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="4fd3ade4-21c7-4abd-9780-d661347dbeb5"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2706d61-bdc5-4697-a1db-3ad003c04fc3'>RadiusChanged</a></td><td style='width:75%' class='def'><p><a name="d2706d61-bdc5-4697-a1db-3ad003c04fc3"></a></p>

<h3>Private Void RadiusChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the radius changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="25550b34-9ac5-4267-938f-763bbc7c466c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72f6c55f-94b1-4dae-8b4d-c5d1ea877c69'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="72f6c55f-94b1-4dae-8b4d-c5d1ea877c69"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#971c5928-ad47-4e31-886e-b9396ac98d57'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="971c5928-ad47-4e31-886e-b9396ac98d57"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorRoundRect</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2680716-45c8-4d7f-8ee2-2d9041acb64e'>UpdateInspector</a></td><td style='width:75%' ><p><a name="e2680716-45c8-4d7f-8ee2-2d9041acb64e"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3d297f4b-0384-4adf-8460-a368fde7ff11'>ShapeModified</a></td><td style='width:75%' ><p><a name="3d297f4b-0384-4adf-8460-a368fde7ff11"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b69d3276-4693-4d8f-82de-b96270c8494a'>_selectedSketch</a></td><td style='width:75%' ><p><a name="b69d3276-4693-4d8f-82de-b96270c8494a"></a>
<b>Private <code>KimonoCore.KimonoSketch</code> _selectedSketch</b></p>

<p>The selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e74cd337-f174-444e-b0c2-f1a38066fecd'>MakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="e74cd337-f174-444e-b0c2-f1a38066fecd"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> MakeDuplicate</b></p>

<p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#744e7594-4fb9-41e5-9c66-75d72e127dca'>RemoveSketch</a></td><td style='width:75%' ><p><a name="744e7594-4fb9-41e5-9c66-75d72e127dca"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> RemoveSketch</b></p>

<p>The private <code>RemoveSketch</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d1ed4ad-ca86-4b8d-8995-d15b4aa9ed67'>SketchModified</a></td><td style='width:75%' class='def'><p><a name="4d1ed4ad-ca86-4b8d-8995-d15b4aa9ed67"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> SketchModified</b></p>

<p>The private <code>SketchModified</code> field of the <code>KimonoInspectorSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c50dc14f-1e8e-499b-ae3d-4909992711be'>CanvasColor</a></td><td style='width:75%' ><p><a name="c50dc14f-1e8e-499b-ae3d-4909992711be"></a></p>

<h3>Private Read Only <code>AppKit.NSColorWell</code> CanvasColor</h3>

<h4>Summary</h4>

<p>The private read only <code>CanvasColor</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSColorWell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e9d6b14-e968-4e0e-ae21-be215eb00d3c'>CanvasColorCheckbox</a></td><td style='width:75%' class='def'><p><a name="0e9d6b14-e968-4e0e-ae21-be215eb00d3c"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> CanvasColorCheckbox</h3>

<h4>Summary</h4>

<p>The private read only <code>CanvasColorCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1f4b714-723d-425b-bd1b-89d1aeaeafe6'>DesignSurface</a></td><td style='width:75%' ><p><a name="f1f4b714-723d-425b-bd1b-89d1aeaeafe6"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c25ac713-4e73-4ddc-80e5-8072f8d11389'>OpacitySlider</a></td><td style='width:75%' class='def'><p><a name="c25ac713-4e73-4ddc-80e5-8072f8d11389"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> OpacitySlider</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacitySlider</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3b8df95-4349-49da-90fa-5543d1e3e991'>OpacityValue</a></td><td style='width:75%' ><p><a name="f3b8df95-4349-49da-90fa-5543d1e3e991"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> OpacityValue</h3>

<h4>Summary</h4>

<p>The private read only <code>OpacityValue</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d43b995a-1253-4156-a8bd-7fd1da061ff6'>SelectedSketch</a></td><td style='width:75%' class='def'><p><a name="d43b995a-1253-4156-a8bd-7fd1da061ff6"></a></p>

<h3>Public <code>KimonoCore.KimonoSketch</code> SelectedSketch</h3>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#483fe7a1-5ffa-4ea4-b0f1-d2865440256a'>SketchHeight</a></td><td style='width:75%' ><p><a name="483fe7a1-5ffa-4ea4-b0f1-d2865440256a"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SketchHeight</h3>

<h4>Summary</h4>

<p>The private read only <code>SketchHeight</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12e4691d-f44a-4dd0-859e-de5469846ffa'>SketchName</a></td><td style='width:75%' class='def'><p><a name="12e4691d-f44a-4dd0-859e-de5469846ffa"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SketchName</h3>

<h4>Summary</h4>

<p>The private read only <code>SketchName</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19cc2ece-2b82-402f-b9f3-7d0601ec71b7'>SketchWidth</a></td><td style='width:75%' ><p><a name="19cc2ece-2b82-402f-b9f3-7d0601ec71b7"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SketchWidth</h3>

<h4>Summary</h4>

<p>The private read only <code>SketchWidth</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35652a2d-b4c7-414a-b825-d977dc695490'>ToBitmapCheckbox</a></td><td style='width:75%' class='def'><p><a name="35652a2d-b4c7-414a-b825-d977dc695490"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToBitmapCheckbox</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>ToBitmapCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#749cf852-ff1e-4086-9ab4-a78e27baadae'>ToCanvasCheckbox</a></td><td style='width:75%' ><p><a name="749cf852-ff1e-4086-9ab4-a78e27baadae"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToCanvasCheckbox</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>ToCanvasCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5a12f16-11e0-4132-ae3d-833d2bdec130'>ToDataCheckbox</a></td><td style='width:75%' class='def'><p><a name="f5a12f16-11e0-4132-ae3d-833d2bdec130"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToDataCheckbox</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>ToDataCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5017d9dd-77a1-4127-a549-fd322e63dca8'>UseSkiaSharpViewsCheckbox</a></td><td style='width:75%' ><p><a name="5017d9dd-77a1-4127-a549-fd322e63dca8"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> UseSkiaSharpViewsCheckbox</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>UseSkiaSharpViewsCheckbox</code> property of the <code>KimonoInspectorSketch</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#33af043f-b8b5-4b44-ae85-4185c1335e95'>CanvasColorChanged</a></td><td style='width:75%' ><p><a name="33af043f-b8b5-4b44-ae85-4185c1335e95"></a></p>

<h3>Private Void CanvasColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the canvas color changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="00a02c61-6ab9-4bd8-99a7-e074ca97b37d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ca2ca72-09f4-4903-8fbb-383e59462edf'>DeleteSketch</a></td><td style='width:75%' class='def'><p><a name="9ca2ca72-09f4-4903-8fbb-383e59462edf"></a></p>

<h3>Private Void DeleteSketch (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Deletes the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="67bd0976-615b-43e3-ad47-8163d66f465e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de459dfc-e6f9-46d1-a1bf-18d1ae3990a1'>DuplicateSketch</a></td><td style='width:75%' ><p><a name="de459dfc-e6f9-46d1-a1bf-18d1ae3990a1"></a></p>

<h3>Private Void DuplicateSketch (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="72033b08-6de0-4b50-9074-c7cd50208727"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3f4f2b7-62cb-4cb1-b517-a5383233a286'>HasCanvasColorChanged</a></td><td style='width:75%' class='def'><p><a name="f3f4f2b7-62cb-4cb1-b517-a5383233a286"></a></p>

<h3>Private Void HasCanvasColorChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Does the canvas include a colored background?</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9a4ae4da-fab1-4e2e-b5ac-cf13276717d7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae938876-4fb3-4ff0-8b9c-21a0d53f4cc6'>Initialize</a></td><td style='width:75%' ><p><a name="ae938876-4fb3-4ff0-8b9c-21a0d53f4cc6"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a644f44e-6486-4dd6-9db6-a4d2adf373b2'>KimonoInspectorSketch</a></td><td style='width:75%' class='def'><p><a name="a644f44e-6486-4dd6-9db6-a4d2adf373b2"></a></p>

<h3>Public Void KimonoInspectorSketch (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#29b077d2-fa1f-4b59-b9c3-22ef34f57c59">KimonoInspectorSketch</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="a585227f-ba65-44dd-85ff-40d1b43b82af"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf5426af-ef28-4adc-93d3-ec00d276498b'>MoveTo</a></td><td style='width:75%' ><p><a name="cf5426af-ef28-4adc-93d3-ec00d276498b"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="7bc291c7-d22a-46e0-871e-122329584b04"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ac9bb3c-13a0-4d4f-b723-64c08c2eb066'>OpacityChanged</a></td><td style='width:75%' class='def'><p><a name="3ac9bb3c-13a0-4d4f-b723-64c08c2eb066"></a></p>

<h3>Private Void OpacityChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the opacity changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d97e41c7-2f90-4c59-a54c-2cdf0f76cdca"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce5e8eee-5195-4e85-9b79-96ec48fea560'>RaiseMakeDuplicate</a></td><td style='width:75%' ><p><a name="ce5e8eee-5195-4e85-9b79-96ec48fea560"></a></p>

<h3>Void RaiseMakeDuplicate ()</h3>

<h4>Summary</h4>

<p>Raises the make duplicate event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77f5fe04-165f-4ec0-89c0-d602c1665e92'>RaiseRemoveSketch</a></td><td style='width:75%' class='def'><p><a name="77f5fe04-165f-4ec0-89c0-d602c1665e92"></a></p>

<h3>Void RaiseRemoveSketch ()</h3>

<h4>Summary</h4>

<p>Raises the remove sketch event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b2e1b87-8b06-4015-838c-e63cd01bc5b0'>RaiseSketchModified</a></td><td style='width:75%' ><p><a name="7b2e1b87-8b06-4015-838c-e63cd01bc5b0"></a></p>

<h3>Void RaiseSketchModified ()</h3>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89672c76-28c4-46eb-aaf5-b890a692149a'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="89672c76-28c4-46eb-aaf5-b890a692149a"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorSketch</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c735246-f58b-40bd-8b13-24f4ac44e159'>ToBitmapChanged</a></td><td style='width:75%' ><p><a name="9c735246-f58b-40bd-8b13-24f4ac44e159"></a></p>

<h3>Private Void ToBitmapChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the to bitmap checkbox changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6fb68998-3742-453c-a2db-536850b19514"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95554907-96ff-4ac3-9d76-3c3d66703343'>ToCanvasChanged</a></td><td style='width:75%' class='def'><p><a name="95554907-96ff-4ac3-9d76-3c3d66703343"></a></p>

<h3>Private Void ToCanvasChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the to canvas checkboc changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="dc19cc7e-30d5-48d4-9147-41ddac59eb51"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bab7976-407e-4f4a-8536-4dd45d346476'>ToDataChanged</a></td><td style='width:75%' ><p><a name="5bab7976-407e-4f4a-8536-4dd45d346476"></a></p>

<h3>Private Void ToDataChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the to data checkbox changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="825476ca-ebb3-4cbf-91e3-dea3333f3494"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cab7a01f-1e07-441a-871c-e722ff3bb50a'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="cab7a01f-1e07-441a-871c-e722ff3bb50a"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#369e65ff-95a0-4bf8-9a9d-00a69958f3d0'>UseSkiaSharpViewsChanged</a></td><td style='width:75%' ><p><a name="369e65ff-95a0-4bf8-9a9d-00a69958f3d0"></a></p>

<h3>Private Void UseSkiaSharpViewsChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the use SkiaSharp views checkbox changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="109d08d2-e309-4257-a757-eba8ff3f9f56"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7c70e8a5-7a95-461f-b828-a31dbaa2ad5b'>MakeDuplicate</a></td><td style='width:75%' ><p><a name="7c70e8a5-7a95-461f-b828-a31dbaa2ad5b"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> MakeDuplicate</h3>

<h4>Summary</h4>

<p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffdb73b1-29ba-4bc4-ad16-b40583801189'>RemoveSketch</a></td><td style='width:75%' class='def'><p><a name="ffdb73b1-29ba-4bc4-ad16-b40583801189"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> RemoveSketch</h3>

<h4>Summary</h4>

<p>Occurs when remove sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb452cf7-31ae-4353-b2dd-df24c3f018c1'>SketchModified</a></td><td style='width:75%' ><p><a name="eb452cf7-31ae-4353-b2dd-df24c3f018c1"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> SketchModified</h3>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#03ff10b8-9e84-46bb-8ac5-fb935613b574'>_selectedShape</a></td><td style='width:75%' ><p><a name="03ff10b8-9e84-46bb-8ac5-fb935613b574"></a>
<b>Private <code>KimonoCore.KimonoShapeStar</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20da3c51-e5d7-44f0-a5bd-b7cf93bdda96'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="20da3c51-e5d7-44f0-a5bd-b7cf93bdda96"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorStar</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#34f30f02-e1a8-4ca8-9f9f-085bc5b74c58'>DepthSlider</a></td><td style='width:75%' ><p><a name="34f30f02-e1a8-4ca8-9f9f-085bc5b74c58"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> DepthSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>DepthSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6c84844-6423-44f7-83e1-392ce0896064'>DepthValue</a></td><td style='width:75%' class='def'><p><a name="d6c84844-6423-44f7-83e1-392ce0896064"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> DepthValue</h3>

<h4>Summary</h4>

<p>The private read only <code>DepthValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4781b301-878c-4bc4-8b00-44c3b462b794'>DesignSurface</a></td><td style='width:75%' ><p><a name="4781b301-878c-4bc4-8b00-44c3b462b794"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9a7578a-4073-4ab1-87e8-b505273b832d'>PointsSlider</a></td><td style='width:75%' class='def'><p><a name="d9a7578a-4073-4ab1-87e8-b505273b832d"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> PointsSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>PointsSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7016a10-9f5b-455b-be11-847958031f4b'>PointsValue</a></td><td style='width:75%' ><p><a name="d7016a10-9f5b-455b-be11-847958031f4b"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> PointsValue</h3>

<h4>Summary</h4>

<p>The private read only <code>PointsValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd4d4e16-f52c-42ce-9ccd-633c5ab5971b'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="cd4d4e16-f52c-42ce-9ccd-633c5ab5971b"></a></p>

<h3>Public <code>KimonoCore.KimonoShapeStar</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#767182d7-f230-4a20-bd01-221e163ce0c5'>SkipSlider</a></td><td style='width:75%' ><p><a name="767182d7-f230-4a20-bd01-221e163ce0c5"></a></p>

<h3>Private Read Only <code>AppKit.NSSlider</code> SkipSlider</h3>

<h4>Summary</h4>

<p>The private read only <code>SkipSlider</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSSlider</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77ed4bb0-4e0e-44e9-a9d4-b906f7f5ecfd'>SkipValue</a></td><td style='width:75%' class='def'><p><a name="77ed4bb0-4e0e-44e9-a9d4-b906f7f5ecfd"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SkipValue</h3>

<h4>Summary</h4>

<p>The private read only <code>SkipValue</code> property of the <code>KimonoInspectorStar</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c22e665b-2877-4df8-906a-735e3b40c669'>DepthChanged</a></td><td style='width:75%' ><p><a name="c22e665b-2877-4df8-906a-735e3b40c669"></a></p>

<h3>Private Void DepthChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the point depth value chainging.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7a3b95ad-cc15-45b2-9bbb-582739086fef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea3fad8f-cb2a-4cb2-97cb-fdafc5a39c8c'>Initialize</a></td><td style='width:75%' class='def'><p><a name="ea3fad8f-cb2a-4cb2-97cb-fdafc5a39c8c"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20e2f993-d8ce-412d-b766-69feae4f6b60'>KimonoInspectorStar</a></td><td style='width:75%' ><p><a name="20e2f993-d8ce-412d-b766-69feae4f6b60"></a></p>

<h3>Public Void KimonoInspectorStar (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#344b8c16-cdc9-4606-af9b-9b672d043928">KimonoInspectorStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="1a285420-6deb-4a14-a413-3260ed6708e9"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7e548dd-e8ce-4809-a64c-8458bd55c41e'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="d7e548dd-e8ce-4809-a64c-8458bd55c41e"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="6fc44bdc-70fa-46b4-9e8f-df00e5fb38b6"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c0af7fe-b523-437d-b394-6e4874d92d14'>PointsChanged</a></td><td style='width:75%' ><p><a name="1c0af7fe-b523-437d-b394-6e4874d92d14"></a></p>

<h3>Private Void PointsChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the number of points changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d024e082-51a4-4796-8a26-c9f4949ee9b3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f310dae2-489c-426c-919e-6900e830191a'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p><a name="f310dae2-489c-426c-919e-6900e830191a"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#777ff121-212e-4038-8745-fd81c00468b6'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="777ff121-212e-4038-8745-fd81c00468b6"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorStar</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4256fc70-3014-4ac0-b5f3-f0022306da20'>SkipChanged</a></td><td style='width:75%' class='def'><p><a name="4256fc70-3014-4ac0-b5f3-f0022306da20"></a></p>

<h3>Private Void SkipChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the skip points number changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="6daf6c6e-a462-4a20-b4cc-45a490a01bd4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd9152f1-8ac2-4785-92d7-a88373ddea91'>UpdateInspector</a></td><td style='width:75%' ><p><a name="fd9152f1-8ac2-4785-92d7-a88373ddea91"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4c1af845-1c66-43c8-a3c1-4ab12bf91f7a'>ShapeModified</a></td><td style='width:75%' ><p><a name="4c1af845-1c66-43c8-a3c1-4ab12bf91f7a"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3354fee1-4227-4b89-8a32-133efd7333dd'>_selectedShape</a></td><td style='width:75%' ><p><a name="3354fee1-4227-4b89-8a32-133efd7333dd"></a>
<b>Private <code>KimonoCore.KimonoShape</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a566bfa-60e0-44ea-a4a1-aa28d546aa16'>_selectedStyle</a></td><td style='width:75%' class='def'><p><a name="4a566bfa-60e0-44ea-a4a1-aa28d546aa16"></a>
<b>Private <code>KimonoCore.KimonoStyle</code> _selectedStyle</b></p>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1721961-2820-482e-963b-cceadc4d9349'>MakeDuplicate</a></td><td style='width:75%' ><p><a name="a1721961-2820-482e-963b-cceadc4d9349"></a>
<b>Private <code>KimonoCore.Kimono.StyleEventDelegate</code> MakeDuplicate</b></p>

<p>The private <code>MakeDuplicate</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f982d87-eb0a-49b9-99e5-af2a9e4454cb'>RemoveStyle</a></td><td style='width:75%' class='def'><p><a name="5f982d87-eb0a-49b9-99e5-af2a9e4454cb"></a>
<b>Private <code>KimonoCore.Kimono.StyleEventDelegate</code> RemoveStyle</b></p>

<p>The private <code>RemoveStyle</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4b8679e-6e27-4a11-bec1-03f719845639'>ReturnToShape</a></td><td style='width:75%' ><p><a name="f4b8679e-6e27-4a11-bec1-03f719845639"></a>
<b>Private <code>KimonoCore.Kimono.ShapeEventDelegate</code> ReturnToShape</b></p>

<p>The private <code>ReturnToShape</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aeaeddcf-160b-43d0-913b-e4759d464240'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="aeaeddcf-160b-43d0-913b-e4759d464240"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5df697d2-5d3b-4e14-a9dd-2595d18e71e7'>StyleModified</a></td><td style='width:75%' ><p><a name="5df697d2-5d3b-4e14-a9dd-2595d18e71e7"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> StyleModified</b></p>

<p>The private <code>StyleModified</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18aee7ea-6770-40c4-811e-6e2089ed48d3'>StyleTypeChanged</a></td><td style='width:75%' class='def'><p><a name="18aee7ea-6770-40c4-811e-6e2089ed48d3"></a>
<b>Private <code>KimonoCore.Kimono.StyleEventDelegate</code> StyleTypeChanged</b></p>

<p>The private <code>StyleTypeChanged</code> field of the <code>KimonoInspectorStyle</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#02bb46e3-c792-4023-98e0-9edc1299d892'>ApplyButton</a></td><td style='width:75%' ><p><a name="02bb46e3-c792-4023-98e0-9edc1299d892"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ApplyButton</h3>

<h4>Summary</h4>

<p>The private read only <code>ApplyButton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d402e176-5001-4526-b1d2-e42ec7dbb33d'>Backbutton</a></td><td style='width:75%' class='def'><p><a name="d402e176-5001-4526-b1d2-e42ec7dbb33d"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> Backbutton</h3>

<h4>Summary</h4>

<p>The private read only <code>Backbutton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39c2868f-fc80-4303-8a49-addbe4487123'>DeleteButton</a></td><td style='width:75%' ><p><a name="39c2868f-fc80-4303-8a49-addbe4487123"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DeleteButton</h3>

<h4>Summary</h4>

<p>The private read only <code>DeleteButton</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d77324bb-d3cc-4046-b8dc-f22e8fe958b3'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="d77324bb-d3cc-4046-b8dc-f22e8fe958b3"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18b77b1b-9222-4d23-9794-0697e977ffd9'>SelectedShape</a></td><td style='width:75%' ><p><a name="18b77b1b-9222-4d23-9794-0697e977ffd9"></a></p>

<h3>Public <code>KimonoCore.KimonoShape</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a68465dc-22e7-4080-be8a-343e5268b8a3'>SelectedStyle</a></td><td style='width:75%' class='def'><p><a name="a68465dc-22e7-4080-be8a-343e5268b8a3"></a></p>

<h3>Public <code>KimonoCore.KimonoStyle</code> SelectedStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the selected style.</p>

<h4>Return Value</h4>

<p>The selected style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e08276ea-a3a0-43b7-93b5-c2f800c0ab06'>StyleName</a></td><td style='width:75%' ><p><a name="e08276ea-a3a0-43b7-93b5-c2f800c0ab06"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> StyleName</h3>

<h4>Summary</h4>

<p>The private read only <code>StyleName</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa45ed68-81f6-4fe9-9fba-7419ac1b3e61'>TypeDropdown</a></td><td style='width:75%' class='def'><p><a name="aa45ed68-81f6-4fe9-9fba-7419ac1b3e61"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> TypeDropdown</h3>

<h4>Summary</h4>

<p>The private read only <code>TypeDropdown</code> property of the <code>KimonoInspectorStyle</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5d086961-3acf-4461-a099-498de71d3a54'>ApplyChange</a></td><td style='width:75%' ><p><a name="5d086961-3acf-4461-a099-498de71d3a54"></a></p>

<h3>Private Void ApplyChange (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Applies the change to the currently selected <code>KimonShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="707bf621-6420-4005-b38c-aba4148bb8ae"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0532dbd-7489-490b-90ab-01fa8db78696'>DeleteStyle</a></td><td style='width:75%' class='def'><p><a name="b0532dbd-7489-490b-90ab-01fa8db78696"></a></p>

<h3>Private Void DeleteStyle (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Deletes the style.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="fb5f757e-cd65-47be-8a50-8ae5d01eb3b9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e5f5fc1-3b19-4bba-852b-82a85a72f8d0'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="0e5f5fc1-3b19-4bba-852b-82a85a72f8d0"></a></p>

<h3>Private Void DuplicateStyle (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the style.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8efa2f63-e90d-4e4c-90af-133229419dd9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09870f43-af06-474c-b779-9dff9b88935f'>GoBack</a></td><td style='width:75%' class='def'><p><a name="09870f43-af06-474c-b779-9dff9b88935f"></a></p>

<h3>Private Void GoBack (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Returns to the currently selected shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="453d6cb5-db75-4208-9e9a-6f646a261a08"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90edc352-5ec1-4865-9c9f-506d111f65c1'>Initialize</a></td><td style='width:75%' ><p><a name="90edc352-5ec1-4865-9c9f-506d111f65c1"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29717289-9eda-4048-8570-2b86492b86b8'>KimonoInspectorStyle</a></td><td style='width:75%' class='def'><p><a name="29717289-9eda-4048-8570-2b86492b86b8"></a></p>

<h3>Public Void KimonoInspectorStyle (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c">KimonoInspectorStyle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="b0015409-9308-42f7-a589-391fe08b08a8"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f985aaa2-7a91-4b97-ac50-33d356802e17'>MoveTo</a></td><td style='width:75%' ><p><a name="f985aaa2-7a91-4b97-ac50-33d356802e17"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="eb313cea-56bb-4008-b790-380863a60eb3"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcc3a384-c8df-4e72-857d-1373b3372e5f'>RaiseMakeDuplicate</a></td><td style='width:75%' class='def'><p><a name="bcc3a384-c8df-4e72-857d-1373b3372e5f"></a></p>

<h3>Void RaiseMakeDuplicate (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the make duplicate event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="e5e0d793-9cfa-440d-b4e2-4b053b04a637"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9ee3504-8691-4a54-8728-bfefd6e05818'>RaiseRemoveStyle</a></td><td style='width:75%' ><p><a name="d9ee3504-8691-4a54-8728-bfefd6e05818"></a></p>

<h3>Void RaiseRemoveStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the remove style event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="8e5de36c-368c-41f5-8a42-71108b00483e"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a36a34ba-0ab3-47b0-9826-47e4068de8f9'>RaiseReturnToShape</a></td><td style='width:75%' class='def'><p><a name="a36a34ba-0ab3-47b0-9826-47e4068de8f9"></a></p>

<h3>Void RaiseReturnToShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the return to shape event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="67b9e07e-a24e-4f03-932b-cdc5fdc8b572"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2be6dc43-d26b-4d53-91e7-cb0f9cd6059a'>RaiseShapeModified</a></td><td style='width:75%' ><p><a name="2be6dc43-d26b-4d53-91e7-cb0f9cd6059a"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#176b8998-7584-4b33-ae32-fef7db54cac4'>RaiseStyleModified</a></td><td style='width:75%' class='def'><p><a name="176b8998-7584-4b33-ae32-fef7db54cac4"></a></p>

<h3>Void RaiseStyleModified ()</h3>

<h4>Summary</h4>

<p>Raises the style modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#962bfdb0-d703-4e8d-98e7-37ca2f95354d'>RaiseStyleTypeChanged</a></td><td style='width:75%' ><p><a name="962bfdb0-d703-4e8d-98e7-37ca2f95354d"></a></p>

<h3>Void RaiseStyleTypeChanged (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the style type changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="c7188691-ded0-4ef1-aebe-728f5eeabfa9"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#937ea23d-9ab1-41ae-b99b-dc09e46f6c16'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="937ea23d-9ab1-41ae-b99b-dc09e46f6c16"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorStyle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6a2f878-a240-49b6-aaf3-37c08ba5b325'>TypeChanged</a></td><td style='width:75%' ><p><a name="d6a2f878-a240-49b6-aaf3-37c08ba5b325"></a></p>

<h3>Private Void TypeChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the <code>KimonoStyle</code>'s type changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="91ba8a50-8143-454f-8311-4532669d3029"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83a4df75-1490-4415-80e0-53f98c99318c'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="83a4df75-1490-4415-80e0-53f98c99318c"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e0a0b9a1-8a1b-4e01-9579-ef97372616b1'>MakeDuplicate</a></td><td style='width:75%' ><p><a name="e0a0b9a1-8a1b-4e01-9579-ef97372616b1"></a></p>

<h3><code>KimonoCore.Kimono.StyleEventDelegate</code> MakeDuplicate</h3>

<h4>Summary</h4>

<p>Occurs when make duplicate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8b6a877-2ba1-403e-bfa7-e0be65c111f6'>RemoveStyle</a></td><td style='width:75%' class='def'><p><a name="c8b6a877-2ba1-403e-bfa7-e0be65c111f6"></a></p>

<h3><code>KimonoCore.Kimono.StyleEventDelegate</code> RemoveStyle</h3>

<h4>Summary</h4>

<p>Occurs when remove style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a8d84fd-4674-487d-bbc8-8ecaca127e6f'>ReturnToShape</a></td><td style='width:75%' ><p><a name="1a8d84fd-4674-487d-bbc8-8ecaca127e6f"></a></p>

<h3><code>KimonoCore.Kimono.ShapeEventDelegate</code> ReturnToShape</h3>

<h4>Summary</h4>

<p>Occurs when return to shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c08b9b8a-fbcf-4c64-a36e-f49a643aa521'>ShapeModified</a></td><td style='width:75%' class='def'><p><a name="c08b9b8a-fbcf-4c64-a36e-f49a643aa521"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f2e1c72-a31f-43b4-b790-f83d6abd7900'>StyleModified</a></td><td style='width:75%' ><p><a name="9f2e1c72-a31f-43b4-b790-f83d6abd7900"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> StyleModified</h3>

<h4>Summary</h4>

<p>Occurs when style modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e4e9d24-0405-457a-a7a7-dbba746c5ec2'>StyleTypeChanged</a></td><td style='width:75%' class='def'><p><a name="2e4e9d24-0405-457a-a7a7-dbba746c5ec2"></a></p>

<h3><code>KimonoCore.Kimono.StyleEventDelegate</code> StyleTypeChanged</h3>

<h4>Summary</h4>

<p>Occurs when style type changed.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d620a87e-6fb9-4760-a794-94a8f2e8b357'>_selectedShape</a></td><td style='width:75%' ><p><a name="d620a87e-6fb9-4760-a794-94a8f2e8b357"></a>
<b>Private <code>KimonoCore.KimonoShapeText</code> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4408627-f5cd-4c14-93e4-e6a81d39ca13'>FirstChange</a></td><td style='width:75%' class='def'><p><a name="b4408627-f5cd-4c14-93e4-e6a81d39ca13"></a>
<b>Private <code>System.Boolean</code> FirstChange</b></p>

<p>Indicates of the first change has been made to a textbox. This is used to keep from creating an undo point on every character that the user chages in the textbox's text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad9f346c-adba-487f-80b3-9216621cba96'>ShapeModified</a></td><td style='width:75%' ><p><a name="ad9f346c-adba-487f-80b3-9216621cba96"></a>
<b>Private <code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</b></p>

<p>The private <code>ShapeModified</code> field of the <code>KimonoInspectorText</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#55b89353-6012-4ac0-ad05-0b3e3b005b48'>Contents</a></td><td style='width:75%' ><p><a name="55b89353-6012-4ac0-ad05-0b3e3b005b48"></a></p>

<h3>Private Read Only <a href="#11a4f065-81b1-4138-8e90-61d1bafcb9e4">KimonoMac.KimonoTextView</a> Contents</h3>

<h4>Summary</h4>

<p>The private read only <code>Contents</code> property of the <code>KimonoInspectorText</code> class has a <code>KimonoMac.KimonoTextView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2ef7ad2-a451-40d2-8c89-9ac19dd84fbb'>DesignSurface</a></td><td style='width:75%' class='def'><p><a name="c2ef7ad2-a451-40d2-8c89-9ac19dd84fbb"></a></p>

<h3>Public <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>Gets or sets the design surface.</p>

<h4>Return Value</h4>

<p>The design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#699971d2-3f0f-4417-abb3-12095cba54ac'>SelectedShape</a></td><td style='width:75%' ><p><a name="699971d2-3f0f-4417-abb3-12095cba54ac"></a></p>

<h3>Public <code>KimonoCore.KimonoShapeText</code> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e7bcd8a2-1d28-4711-972e-6ae67bba82b1'>Initialize</a></td><td style='width:75%' ><p><a name="e7bcd8a2-1d28-4711-972e-6ae67bba82b1"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93b732f9-644d-431e-a51d-987f96c5795d'>KimonoInspectorText</a></td><td style='width:75%' class='def'><p><a name="93b732f9-644d-431e-a51d-987f96c5795d"></a></p>

<h3>Public Void KimonoInspectorText (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d6667936-a83f-4ed0-b092-62db0b6cab71">KimonoInspectorText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="1c4ed338-7b77-438d-a0e7-81cd75c39d4a"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f471255e-c85c-41ac-9632-cac5a46483e9'>MoveTo</a></td><td style='width:75%' ><p><a name="f471255e-c85c-41ac-9632-cac5a46483e9"></a></p>

<h3>Public <code>System.nfloat</code> MoveTo (System.nfloat)</h3>

<h4>Summary</h4>

<p>Moves the inspector to the given location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' ><p><a name="f83b543e-c77b-4195-b1b1-8c3e2dfff1e6"></a>
<b>System.nfloat y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The next location based on the inspector's size.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f14232a-5c2f-4bde-b9b2-3a6422a68726'>RaiseShapeModified</a></td><td style='width:75%' class='def'><p><a name="2f14232a-5c2f-4bde-b9b2-3a6422a68726"></a></p>

<h3>Void RaiseShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29eb1f32-bb82-4a7b-8079-fbab78263633'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="29eb1f32-bb82-4a7b-8079-fbab78263633"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>KimonoInspectorText</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#603dd6bb-98e2-4d1c-a751-2c284514b7d4'>UpdateInspector</a></td><td style='width:75%' class='def'><p><a name="603dd6bb-98e2-4d1c-a751-2c284514b7d4"></a></p>

<h3>Public Void UpdateInspector ()</h3>

<h4>Summary</h4>

<p>Updates the inspector.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7ff2ae4b-ab35-474e-8710-2884b23144bc'>ShapeModified</a></td><td style='width:75%' ><p><a name="7ff2ae4b-ab35-474e-8710-2884b23144bc"></a></p>

<h3><code>KimonoCore.Kimono.PortfolioEventDelegate</code> ShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when shape modified.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6cc36fd5-0f97-4ca7-bc0a-70abd3969afb'>TextChanged</a></td><td style='width:75%' ><p><a name="6cc36fd5-0f97-4ca7-bc0a-70abd3969afb"></a>
<b>Private <a href="#34258cd9-f194-4032-90e7-90700902ba3d">KimonoMac.KimonoTextView.TextChangedDelegate</a> TextChanged</b></p>

<p>The private <code>TextChanged</code> field of the <code>KimonoTextView</code> class holds a <code>KimonoMac.KimonoTextView.TextChangedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c980b616-0a32-4044-ae53-8820a3402831'>DidChangeText</a></td><td style='width:75%' ><p><a name="c980b616-0a32-4044-ae53-8820a3402831"></a></p>

<h3>Public Virtual Void DidChangeText ()</h3>

<h4>Summary</h4>

<p>Handles the value of the text field changing </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bad9a51-7e92-4266-bdc4-0c4e47a6f173'>KimonoTextView</a></td><td style='width:75%' class='def'><p><a name="5bad9a51-7e92-4266-bdc4-0c4e47a6f173"></a></p>

<h3>Public Void KimonoTextView ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc6bb70e-0eb1-44f6-8979-309d9e8c1a44'>KimonoTextView</a></td><td style='width:75%' ><p><a name="fc6bb70e-0eb1-44f6-8979-309d9e8c1a44"></a></p>

<h3>Public Void KimonoTextView (CoreGraphics.CGRect)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="5cbc558c-fa4f-476d-b740-46de81eb23ca"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#392d996a-e447-4919-a5ad-808d0ff287c4'>KimonoTextView</a></td><td style='width:75%' class='def'><p><a name="392d996a-e447-4919-a5ad-808d0ff287c4"></a></p>

<h3>Public Void KimonoTextView (Foundation.NSCoder)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="f0f6de9b-3ce0-4d69-8ced-924647ed9a07"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#288071f7-48f9-4c85-a450-bc0ef8dea613'>KimonoTextView</a></td><td style='width:75%' ><p><a name="288071f7-48f9-4c85-a450-bc0ef8dea613"></a></p>

<h3>Public Void KimonoTextView (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#da5fed64-0411-45d7-bec7-b60d9c3ca60a">KimonoTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="45e962c5-8ca3-4551-b358-d1320f6d44ab"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27ce8643-ad32-4fcf-bddf-7475ef08f614'>RaiseTextChanged</a></td><td style='width:75%' class='def'><p><a name="27ce8643-ad32-4fcf-bddf-7475ef08f614"></a></p>

<h3>Void RaiseTextChanged (System.String)</h3>

<h4>Summary</h4>

<p>Raises the text changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="b01b0b9b-6ae2-47c4-99cc-bdb835937e5a"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f5a58777-8ce9-4cea-8f9e-4afa4a1c6533'>TextChanged</a></td><td style='width:75%' ><p><a name="f5a58777-8ce9-4cea-8f9e-4afa4a1c6533"></a></p>

<h3><a href="#34258cd9-f194-4032-90e7-90700902ba3d">KimonoMac.KimonoTextView.TextChangedDelegate</a> TextChanged</h3>

<h4>Summary</h4>

<p>Occurs when text changed.</p>
</td></tr></table></p>


---

<a name="8c87a77f-96ce-412f-9e16-3d1ffdb11694"></a>
##Public Class LanguageClosure

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`Foundation.NSObject`

###Summary

The [LanguageClosure](#8c87a77f-96ce-412f-9e16-3d1ffdb11694) class holds information about a closure such as  (), [], "" or '' that can be used to define a section of text in a [LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf). The Language Closure is used by auto complete in a [SourceTextView](#693e63b3-83a6-43a9-ac2a-7b8fc3474e13).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0db74717-ce09-4d97-bae0-e252dcb6d1af'>EndingCharacter</a></td><td style='width:75%' ><p><a name="0db74717-ce09-4d97-bae0-e252dcb6d1af"></a></p>

<h3>Public <code>System.Char</code> EndingCharacter</h3>

<h4>Summary</h4>

<p>Gets or sets the ending character for this closure.</p>

<h4>Return Value</h4>

<p>The ending character.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a92ec7c2-2887-4f85-a37a-2e764fadb138'>StartingCharacter</a></td><td style='width:75%' class='def'><p><a name="a92ec7c2-2887-4f85-a37a-2e764fadb138"></a></p>

<h3>Public <code>System.Char</code> StartingCharacter</h3>

<h4>Summary</h4>

<p>Gets or sets the starting character for this closure.</p>

<h4>Return Value</h4>

<p>The starting character.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0812e323-6d0d-40e1-97f8-1aab354131bc'>LanguageClosure</a></td><td style='width:75%' ><p><a name="0812e323-6d0d-40e1-97f8-1aab354131bc"></a></p>

<h3>Public Void LanguageClosure ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f65a3b97-c894-4fa4-92b6-963630ed95af'>LanguageClosure</a></td><td style='width:75%' class='def'><p><a name="f65a3b97-c894-4fa4-92b6-963630ed95af"></a></p>

<h3>Public Void LanguageClosure (System.Char)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>character</td><td style='width:75%' ><p><a name="6d850752-e758-46f7-81c2-4987be416d60"></a>
<b>System.Char character</b></p>

<p>The character that both starts and ends this closure.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6797ffa5-4e83-4144-9448-76575d3dd46e'>LanguageClosure</a></td><td style='width:75%' ><p><a name="6797ffa5-4e83-4144-9448-76575d3dd46e"></a></p>

<h3>Public Void LanguageClosure (System.Char, System.Char)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startingCharacter</td><td style='width:75%' ><p><a name="f08dd896-ed0f-4a86-9a7c-125f6be0e930"></a>
<b>System.Char startingCharacter</b></p>

<p>The character that starts the closure.</p>
</td></tr><tr><td style='width:25%' class='term'>endingCharacter</td><td style='width:75%' class='def'><p><a name="666bc877-32c0-412d-8f2b-2cff929cb0b7"></a>
<b>System.Char endingCharacter</b></p>

<p>The character that ends the closure.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="5bf38b97-3aff-4262-8b73-5ec35d7e9daf"></a>
##Public Class LanguageDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`Foundation.NSObject`

###Summary

The [LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf) class defines how a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee) should syntax highlight text for a given language such as C#, JavaScript or Visual Basic.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#693fdc86-9c3b-4912-b968-d9f852d163c4'>AccessKeywordColor</a></td><td style='width:75%' ><p><a name="693fdc86-9c3b-4912-b968-d9f852d163c4"></a></p>

<h3>Public <code>AppKit.NSColor</code> AccessKeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a access keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the access keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56d26e14-c043-4fbf-8d20-c53dc274d733'>AccessModifierColor</a></td><td style='width:75%' class='def'><p><a name="56d26e14-c043-4fbf-8d20-c53dc274d733"></a></p>

<h3>Public <code>AppKit.NSColor</code> AccessModifierColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a access modifier keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the access modifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2fa9a48-f41e-469b-ae2d-63cec4634591'>Closures</a></td><td style='width:75%' ><p><a name="e2fa9a48-f41e-469b-ae2d-63cec4634591"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;AppKit.TextKit.Formatter.LanguageClosure&gt;</code> Closures</h3>

<h4>Summary</h4>

<p>Gets or sets the collection of <a href="#8c87a77f-96ce-412f-9e16-3d1ffdb11694">LanguageClosure</a> used to auto complete to closure of text such as (), [], "" or ''.</p>

<h4>Return Value</h4>

<p>The closures.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2fcff67-dfae-4dc7-8b42-a3aeb38f02d0'>CommentColor</a></td><td style='width:75%' class='def'><p><a name="b2fcff67-dfae-4dc7-8b42-a3aeb38f02d0"></a></p>

<h3>Public <code>AppKit.NSColor</code> CommentColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a comment.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the comment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21c40620-d58d-4372-bf3e-5538da442571'>ContextualKeywordColor</a></td><td style='width:75%' ><p><a name="21c40620-d58d-4372-bf3e-5538da442571"></a></p>

<h3>Public <code>AppKit.NSColor</code> ContextualKeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a contextual keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the contextual keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99c472ce-0c0c-4828-bf99-1eb0c4d8fead'>ConversionKeywordColor</a></td><td style='width:75%' class='def'><p><a name="99c472ce-0c0c-4828-bf99-1eb0c4d8fead"></a></p>

<h3>Public <code>AppKit.NSColor</code> ConversionKeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a conversion keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the conversion keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beb5b674-f97c-4781-81e4-882ba5768f64'>EscapeCharacter</a></td><td style='width:75%' ><p><a name="beb5b674-f97c-4781-81e4-882ba5768f64"></a></p>

<h3>Public Virtual Read Only <code>System.Char</code> EscapeCharacter</h3>

<h4>Summary</h4>

<p>Gets the escape character for the given language.</p>

<h4>Return Value</h4>

<p>The escape character.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6a02d40-6d50-43d6-9930-fd18c1fc5d4c'>ExceptionHandlingColor</a></td><td style='width:75%' class='def'><p><a name="d6a02d40-6d50-43d6-9930-fd18c1fc5d4c"></a></p>

<h3>Public <code>AppKit.NSColor</code> ExceptionHandlingColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a exception handling keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the exception handling.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3d46a9e-c921-4094-b1d1-4cce27c9c349'>Formats</a></td><td style='width:75%' ><p><a name="f3d46a9e-c921-4094-b1d1-4cce27c9c349"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;AppKit.TextKit.Formatter.FormatDescriptor&gt;</code> Formats</h3>

<h4>Summary</h4>

<p>Gets or sets the collection of <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> formats used to syntax highlight this language.</p>

<h4>Return Value</h4>

<p>The formats.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2db3a312-19c9-4f96-bf35-f0b08812de22'>FormattingCommands</a></td><td style='width:75%' class='def'><p><a name="2db3a312-19c9-4f96-bf35-f0b08812de22"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;AppKit.TextKit.Formatter.LanguageFormatCommand&gt;</code> FormattingCommands</h3>

<h4>Summary</h4>

<p>Gets or sets the formatting commands that can be added to the user interface for the  user to select and apply to a selection of text in the editor.</p>

<h4>Return Value</h4>

<p>The <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> items.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57cb6768-4638-4bbd-87d9-4b4c3a251f9e'>IterationStatementColor</a></td><td style='width:75%' ><p><a name="57cb6768-4638-4bbd-87d9-4b4c3a251f9e"></a></p>

<h3>Public <code>AppKit.NSColor</code> IterationStatementColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a iteration statement keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the iteration statement.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f439012d-7077-4eed-9b0b-ba2695fde349'>JumpStatementColor</a></td><td style='width:75%' class='def'><p><a name="f439012d-7077-4eed-9b0b-ba2695fde349"></a></p>

<h3>Public <code>AppKit.NSColor</code> JumpStatementColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a jump statement keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the jump statement.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#354aeede-da47-4370-8d9f-8b7aab042460'>KeywordColor</a></td><td style='width:75%' ><p><a name="354aeede-da47-4370-8d9f-8b7aab042460"></a></p>

<h3>Public <code>AppKit.NSColor</code> KeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of generic keywords.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c008bbdb-bc93-4538-9508-479ae3bd2a12'>Keywords</a></td><td style='width:75%' class='def'><p><a name="c008bbdb-bc93-4538-9508-479ae3bd2a12"></a></p>

<h3>Public <code>System.Collections.Generic.Dictionary&lt;System.String,AppKit.TextKit.Formatter.KeywordDescriptor&gt;</code> Keywords</h3>

<h4>Summary</h4>

<p>Gets or sets the collection of <a href="#56094def-ccde-45a2-987f-18730526fdc6">KeywordDescriptor</a> used to define the keywords for this language.</p>

<h4>Return Value</h4>

<p>The keywords.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4a54653-f8e3-4edc-92da-8e99cb17ca13'>LanguageIdentifier</a></td><td style='width:75%' ><p><a name="b4a54653-f8e3-4edc-92da-8e99cb17ca13"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> LanguageIdentifier</h3>

<h4>Summary</h4>

<p>Gets the language identifier.</p>

<h4>Return Value</h4>

<p>The language identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a06cc28-7ed4-4efa-9305-f9ae3eef4eb6'>LanguageSeparators</a></td><td style='width:75%' class='def'><p><a name="2a06cc28-7ed4-4efa-9305-f9ae3eef4eb6"></a></p>

<h3>Public Virtual <code>System.Char[]</code> LanguageSeparators</h3>

<h4>Summary</h4>

<p>Gets or sets the language separators that can be used to define a "word" in the given language.</p>

<h4>Return Value</h4>

<p>The language separators.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14d72700-b0fb-4792-bbcd-7d5fc7aff621'>LiteralKeywordColor</a></td><td style='width:75%' ><p><a name="14d72700-b0fb-4792-bbcd-7d5fc7aff621"></a></p>

<h3>Public <code>AppKit.NSColor</code> LiteralKeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a literal keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the literal keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b45ba88-448c-4504-adc9-8211a6591713'>MethodParameterColor</a></td><td style='width:75%' class='def'><p><a name="3b45ba88-448c-4504-adc9-8211a6591713"></a></p>

<h3>Public <code>AppKit.NSColor</code> MethodParameterColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a method parameter keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the method parameter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bd44604-3b66-47eb-b7fb-256f8c699333'>ModifierColor</a></td><td style='width:75%' ><p><a name="8bd44604-3b66-47eb-b7fb-256f8c699333"></a></p>

<h3>Public <code>AppKit.NSColor</code> ModifierColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a generic modifier keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the modifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bea5687-329d-40b8-a423-0e2c2d7fb0de'>NamespaceColor</a></td><td style='width:75%' class='def'><p><a name="9bea5687-329d-40b8-a423-0e2c2d7fb0de"></a></p>

<h3>Public <code>AppKit.NSColor</code> NamespaceColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a namespace keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the namespace.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e034ecc-2819-4808-8891-9c679d7cff62'>OperatorKeywordColor</a></td><td style='width:75%' ><p><a name="8e034ecc-2819-4808-8891-9c679d7cff62"></a></p>

<h3>Public <code>AppKit.NSColor</code> OperatorKeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a operator keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the operator keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c3880b8-af9c-4e69-9de6-8f5087a0a0f5'>PreprocessorDirectiveColor</a></td><td style='width:75%' class='def'><p><a name="8c3880b8-af9c-4e69-9de6-8f5087a0a0f5"></a></p>

<h3>Public <code>AppKit.NSColor</code> PreprocessorDirectiveColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a preprocessor directive keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the preprocessor directive.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eadb7e8c-ac6a-441b-ab58-e1d39abcd4ea'>QueryKeywordColor</a></td><td style='width:75%' ><p><a name="eadb7e8c-ac6a-441b-ab58-e1d39abcd4ea"></a></p>

<h3>Public <code>AppKit.NSColor</code> QueryKeywordColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a query keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the query keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71c6c9cb-8d32-4831-b9f5-320904a15ee2'>ReferenceTypeColor</a></td><td style='width:75%' class='def'><p><a name="71c6c9cb-8d32-4831-b9f5-320904a15ee2"></a></p>

<h3>Public <code>AppKit.NSColor</code> ReferenceTypeColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a reference type keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the reference type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6ad7196-d650-4daf-a7c1-414b3f0da01e'>SelectionStatementColor</a></td><td style='width:75%' ><p><a name="d6ad7196-d650-4daf-a7c1-414b3f0da01e"></a></p>

<h3>Public <code>AppKit.NSColor</code> SelectionStatementColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a selection statement keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the selection statement.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#395e7f6a-7ac6-48a6-9578-e28412e44f5c'>StatementColor</a></td><td style='width:75%' class='def'><p><a name="395e7f6a-7ac6-48a6-9578-e28412e44f5c"></a></p>

<h3>Public <code>AppKit.NSColor</code> StatementColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a generic statement keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the statement.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d718218d-ddc6-4f3c-a0ff-150e8a392338'>StringLiteralColor</a></td><td style='width:75%' ><p><a name="d718218d-ddc6-4f3c-a0ff-150e8a392338"></a></p>

<h3>Public <code>AppKit.NSColor</code> StringLiteralColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a string literal.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the string literal.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f904d17-9324-41a2-bef6-c8dcefd15635'>TypeColor</a></td><td style='width:75%' class='def'><p><a name="0f904d17-9324-41a2-bef6-c8dcefd15635"></a></p>

<h3>Public <code>AppKit.NSColor</code> TypeColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of generic keyword type.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b917fe9-8d8d-48f1-a6ea-9ca2cf6d96b1'>ValueTypeColor</a></td><td style='width:75%' ><p><a name="4b917fe9-8d8d-48f1-a6ea-9ca2cf6d96b1"></a></p>

<h3>Public <code>AppKit.NSColor</code> ValueTypeColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of a value type keyword.</p>

<h4>Return Value</h4>

<p>The <code>NSColor</code> of the value type.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c6b2f4e9-4e81-40f3-961e-5e910bc3300a'>ClearFormats</a></td><td style='width:75%' ><p><a name="c6b2f4e9-4e81-40f3-961e-5e910bc3300a"></a></p>

<h3>Public Virtual Void ClearFormats ()</h3>

<h4>Summary</h4>

<p>Resets all of the <a href="#f2695704-db23-4679-939f-9f0f65cee076">FormatDescriptor</a> for this language to their default states of unmacthed and inactive.</p>

<h4>Remarks</h4>

<p>This should only be called ba a <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0fbe8fd8-b1b2-4814-af22-b03bb15f637e'>Define</a></td><td style='width:75%' class='def'><p><a name="0fbe8fd8-b1b2-4814-af22-b03bb15f637e"></a></p>

<h3>Public Virtual Void Define ()</h3>

<h4>Summary</h4>

<p>Define this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49682322-d261-45a8-906c-06d6b3eb1d78'>FormatForPreview</a></td><td style='width:75%' ><p><a name="49682322-d261-45a8-906c-06d6b3eb1d78"></a></p>

<h3>Public Virtual <code>System.String</code> FormatForPreview (System.String)</h3>

<h4>Summary</h4>

<p>Formats the passed in string of text for previewing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="cb4ade05-9aea-4c8c-9bf0-f0e5aa132c6b"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The string formatted for preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4571b124-8cbd-47e4-9b05-08ec914ff8da'>LanguageDescriptor</a></td><td style='width:75%' class='def'><p><a name="4571b124-8cbd-47e4-9b05-08ec914ff8da"></a></p>

<h3>Public Void LanguageDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c0aba79-6844-4cba-bcf0-3c11dda2ca30'>LoadColor</a></td><td style='width:75%' ><p><a name="0c0aba79-6844-4cba-bcf0-3c11dda2ca30"></a></p>

<h3>Public <code>AppKit.NSColor</code> LoadColor (System.String, AppKit.NSColor)</h3>

<h4>Summary</h4>

<p>Loads the requested color from system-wide user defaults.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' ><p><a name="18deca0a-298f-4b56-a27a-8cb94f23714a"></a>
<b>System.String key</b></p>

<p>The user default key for the color.</p>
</td></tr><tr><td style='width:25%' class='term'>defaultValue</td><td style='width:75%' class='def'><p><a name="2092465d-d39c-46be-8475-c28815de2eda"></a>
<b>AppKit.NSColor defaultValue</b></p>

<p>The default <code>NSColor</code> value.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>NSColor</code> for the given key or the default value if the key cannot be found in the user defaults.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de60c201-5e94-4599-89ee-1e4ca29d65a3'>NSColorFromHexString</a></td><td style='width:75%' class='def'><p><a name="de60c201-5e94-4599-89ee-1e4ca29d65a3"></a></p>

<h3>Public <code>AppKit.NSColor</code> NSColorFromHexString (System.String)</h3>

<h4>Summary</h4>

<p>Converts a web formatted hex string in the form #RRGGBB or #RRGGBBAA into a color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>hexValue</td><td style='width:75%' ><p><a name="9812defb-f872-493d-8748-b243398fb2e0"></a>
<b>System.String hexValue</b></p>

<p>The web formatted hex string in the form #RRGGBB or #RRGGBBAA.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>NSColor</code> represented by the hex string.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#917ecc63-a5ab-47a4-9017-b14f654fae90'>NSColorToHexString</a></td><td style='width:75%' ><p><a name="917ecc63-a5ab-47a4-9017-b14f654fae90"></a></p>

<h3>Public <code>System.String</code> NSColorToHexString (AppKit.NSColor, System.Boolean)</h3>

<h4>Summary</h4>

<p>Converts the given color into a web style hex string in the form #RRBBGG or optionally #RRBBGGAA.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="437c5ced-4132-41b6-acbe-6e7657f7493a"></a>
<b>AppKit.NSColor color</b></p>

<p>The <code>NSColor</code> to convert.</p>
</td></tr><tr><td style='width:25%' class='term'>withAlpha</td><td style='width:75%' class='def'><p><a name="156e253b-88fc-4db4-bea5-8dde7b9f8472"></a>
<b>System.Boolean withAlpha</b></p>

<p>If set to <code>true</code> with the alpha (transparency) of the color will be included.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The web hex string representing the given color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf870d61-b594-4e88-9b16-c168fb714b08'>SaveColor</a></td><td style='width:75%' class='def'><p><a name="cf870d61-b594-4e88-9b16-c168fb714b08"></a></p>

<h3>Public Void SaveColor (System.String, AppKit.NSColor, System.Boolean)</h3>

<h4>Summary</h4>

<p>Saves the given color to the systwm-wide user defaults with the give keyword.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="d6c905ce-35ce-473d-8c06-e879de59fb88"></a>
<b>AppKit.NSColor color</b></p>

<p>The <code>NSColor</code> to save to the user defaults.</p>
</td></tr><tr><td style='width:25%' class='term'>key</td><td style='width:75%' class='def'><p><a name="0db33294-f5a2-406f-a1fe-572c3fd4164e"></a>
<b>System.String key</b></p>

<p>The user default key to assign the color to.</p>
</td></tr><tr><td style='width:25%' class='term'>sync</td><td style='width:75%' ><p><a name="eb463839-8af1-4790-ab0b-a35ed6f902f1"></a>
<b>System.Boolean sync</b></p>

<p>If set to <code>true</code> sync changes to preferences.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="61eaefa9-223e-4d6c-9055-f3fda225f940"></a>
##Public Class LanguageFormatCommand

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`Foundation.NSObject`

###Summary

The [LanguageFormatCommand](#61eaefa9-223e-4d6c-9055-f3fda225f940) defines a formatting command that can be added to a [LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf). When a document editor is using the given [LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf), the [LanguageFormatCommand](#61eaefa9-223e-4d6c-9055-f3fda225f940) s it defines will be added to the Formatting Menu.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#63e64e81-c69e-41f1-855c-69078cc5a926'>Postfix</a></td><td style='width:75%' ><p><a name="63e64e81-c69e-41f1-855c-69078cc5a926"></a></p>

<h3>Public <code>System.String</code> Postfix</h3>

<h4>Summary</h4>

<p>Gets or sets the postfix that will added to the end of the selected text in the document editor. If empty (""), the <code>Prefix</code> will be inserted at the start of the line that the cursor is on.</p>

<h4>Return Value</h4>

<p>The postfix.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cde40ffd-48e6-4a63-9bbd-2da8256dc812'>Prefix</a></td><td style='width:75%' class='def'><p><a name="cde40ffd-48e6-4a63-9bbd-2da8256dc812"></a></p>

<h3>Public <code>System.String</code> Prefix</h3>

<h4>Summary</h4>

<p>Gets or sets the prefix that will be added to the start of the line (if no <code>Postfix</code> has been defines), or that will be inserted to the start of the current selected text in the document editor.</p>

<h4>Return Value</h4>

<p>The prefix.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8747cc30-1d77-401b-8e4a-d22cce1dc269'>SubCommands</a></td><td style='width:75%' ><p><a name="8747cc30-1d77-401b-8e4a-d22cce1dc269"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;AppKit.TextKit.Formatter.LanguageFormatCommand&gt;</code> SubCommands</h3>

<h4>Summary</h4>

<p>Gets or sets the sub <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> commands that will be displayed under this item in the Formatting Menu.</p>

<h4>Return Value</h4>

<p>The sub commands.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b0c2fb0-0454-440e-a722-2b28353364e8'>Title</a></td><td style='width:75%' class='def'><p><a name="4b0c2fb0-0454-440e-a722-2b28353364e8"></a></p>

<h3>Public <code>System.String</code> Title</h3>

<h4>Summary</h4>

<p>Gets or sets the title that will appear in the Formatting Menu.</p>

<h4>Return Value</h4>

<p>The title.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f387a8fb-2f00-4cad-841e-f4b0e63da01f'>LanguageFormatCommand</a></td><td style='width:75%' ><p><a name="f387a8fb-2f00-4cad-841e-f4b0e63da01f"></a></p>

<h3>Public Void LanguageFormatCommand ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0039ecc-7142-4517-a123-8ba35dfac4f1'>LanguageFormatCommand</a></td><td style='width:75%' class='def'><p><a name="a0039ecc-7142-4517-a123-8ba35dfac4f1"></a></p>

<h3>Public Void LanguageFormatCommand (System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="3897833c-fe07-4537-9e40-7193b3ed621b"></a>
<b>System.String title</b></p>

<p>The title for the menu item.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d610a046-f079-4cf3-9d44-1b4d6b24e862'>LanguageFormatCommand</a></td><td style='width:75%' ><p><a name="d610a046-f079-4cf3-9d44-1b4d6b24e862"></a></p>

<h3>Public Void LanguageFormatCommand (System.String, System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="f9465111-f766-47e1-a449-5b2a0346766f"></a>
<b>System.String title</b></p>

<p>The title for the menu item.</p>
</td></tr><tr><td style='width:25%' class='term'>prefix</td><td style='width:75%' class='def'><p><a name="902cd225-5bfa-4940-8b1b-20847a0d0787"></a>
<b>System.String prefix</b></p>

<p>The prefix to insert.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebe0df8b-073b-4c96-ba96-6debd18a4aa5'>LanguageFormatCommand</a></td><td style='width:75%' class='def'><p><a name="ebe0df8b-073b-4c96-ba96-6debd18a4aa5"></a></p>

<h3>Public Void LanguageFormatCommand (System.String, System.String, System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="b94cd3bb-1f42-4fc4-ba71-6aff2d288525"></a>
<b>System.String title</b></p>

<p>The title for the menu item.</p>
</td></tr><tr><td style='width:25%' class='term'>prefix</td><td style='width:75%' class='def'><p><a name="e5029b8c-9360-414b-98a0-fb16fb35ad9b"></a>
<b>System.String prefix</b></p>

<p>The prefix to insert.</p>
</td></tr><tr><td style='width:25%' class='term'>postfix</td><td style='width:75%' ><p><a name="5d9ad5c8-5261-46a9-ab54-5a3ec31ba2b3"></a>
<b>System.String postfix</b></p>

<p>The postfix to insert.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="13e07d7b-7947-4461-812d-5c2aafa2ebee"></a>
##Public Class LanguageFormatter

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`Foundation.NSObject`

###Summary

The [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee) class uses a [LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf) to provide syntax highlighting of a  `NSTextField` based on a set of [KeywordDescriptor](#56094def-ccde-45a2-987f-18730526fdc6) and[FormatDescriptor](#f2695704-db23-4679-939f-9f0f65cee076) objects..
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bc666294-da0c-4006-9f06-71258a56c6c6'>_language</a></td><td style='width:75%' ><p><a name="bc666294-da0c-4006-9f06-71258a56c6c6"></a>
<b>Private <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">AppKit.TextKit.Formatter.LanguageDescriptor</a> _language</b></p>

<p>The current language syntax highlighting descriptor.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5cb15453-c3cb-4fa6-b09e-56dd7191d820'>Language</a></td><td style='width:75%' ><p><a name="5cb15453-c3cb-4fa6-b09e-56dd7191d820"></a></p>

<h3>Public <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">AppKit.TextKit.Formatter.LanguageDescriptor</a> Language</h3>

<h4>Summary</h4>

<p>Gets or sets the descriptor used to define the syntax highlighting rules for a given language.</p>

<h4>Return Value</h4>

<p>The <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> to syntax highlight.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51e44d01-8ee1-46dd-9eef-9de2ea3a6d46'>LineSeparator</a></td><td style='width:75%' class='def'><p><a name="51e44d01-8ee1-46dd-9eef-9de2ea3a6d46"></a></p>

<h3>Public <code>System.Char</code> LineSeparator</h3>

<h4>Summary</h4>

<p>Gets or sets the Unitext line separator used to define a given line of text.</p>

<h4>Return Value</h4>

<p>The line separator.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#785c4cc6-7006-44d5-b6ed-0e8c038e0d76'>Newline</a></td><td style='width:75%' ><p><a name="785c4cc6-7006-44d5-b6ed-0e8c038e0d76"></a></p>

<h3>Public <code>System.Char</code> Newline</h3>

<h4>Summary</h4>

<p>Gets or sets the newline character used to define a given line of text.</p>

<h4>Return Value</h4>

<p>The newline character.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd0716e1-9ebd-4e52-917b-1fc566050405'>ParagraphSeparator</a></td><td style='width:75%' class='def'><p><a name="bd0716e1-9ebd-4e52-917b-1fc566050405"></a></p>

<h3>Public <code>System.Char</code> ParagraphSeparator</h3>

<h4>Summary</h4>

<p>Gets or sets the Unitext paragraph separator used to define a given paragraph of text.</p>

<h4>Return Value</h4>

<p>The paragraph separator.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15599dd4-a4ea-4092-ba6a-36819c3d8e42'>TextEditor</a></td><td style='width:75%' ><p><a name="15599dd4-a4ea-4092-ba6a-36819c3d8e42"></a></p>

<h3>Public <code>AppKit.NSTextView</code> TextEditor</h3>

<h4>Summary</h4>

<p>Gets or sets the text view that this language formatter will be performing syntax highlighting on.</p>

<h4>Return Value</h4>

<p>The <code>NSTextView</code> to syntax highlight.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b4078a16-29c2-4f73-837d-650be5d87d73'>FindEndOfLine</a></td><td style='width:75%' ><p><a name="b4078a16-29c2-4f73-837d-650be5d87d73"></a></p>

<h3>Public Virtual <code>Foundation.NSRange</code> FindEndOfLine (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Finds the start of end for the given location in the text as defined by the <code>NewLine</code>, <code>LineSeparator</code> and <code>ParagraphSeparator</code> characters.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="306c07a9-5cc3-4d60-9e07-bc5ff5f9775e"></a>
<b>System.String text</b></p>

<p>The text to find the end of the line in.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="ff91ec35-1ae8-4976-9420-92e142e7c5f2"></a>
<b>Foundation.NSRange position</b></p>

<p>The current location of the cursor in the text and possible selection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A <code>NSRange</code> containing the end of the line from the current cursor position.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c156677-cf41-4a63-b19b-326bbc35e387'>FindLineBoundries</a></td><td style='width:75%' class='def'><p><a name="8c156677-cf41-4a63-b19b-326bbc35e387"></a></p>

<h3>Public Virtual <code>Foundation.NSRange</code> FindLineBoundries (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Finds the line boundries as defined by the <code>NewLine</code>, <code>LineSeparator</code> and <code>ParagraphSeparator</code> characters.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="2f1943cc-1e70-4e33-ac21-1b3b2c50de42"></a>
<b>System.String text</b></p>

<p>The string to be searched.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="8d43a7e8-8629-437e-b65a-b674b4fa3c35"></a>
<b>Foundation.NSRange position</b></p>

<p>The <code>NSRange</code> specifying the starting location of a possible  line of text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>An <code>NSRange</code> containing the starting and ending character locations of the current line of text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08d77d42-b313-46f8-bf59-7ec88f6f4890'>FindStartOfLine</a></td><td style='width:75%' ><p><a name="08d77d42-b313-46f8-bf59-7ec88f6f4890"></a></p>

<h3>Public Virtual <code>Foundation.NSRange</code> FindStartOfLine (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Finds the start of line for the given location in the text as defined by the <code>NewLine</code>, <code>LineSeparator</code> and <code>ParagraphSeparator</code> characters.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="2a7402bc-617d-4eb9-badb-4ebb1413eec4"></a>
<b>System.String text</b></p>

<p>The text to find the start of the line in.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="02ff616f-a4a4-42fb-ad4b-5d9b348473cf"></a>
<b>Foundation.NSRange position</b></p>

<p>The current location of the cursor in the text and possible selection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A <code>NSRange</code> containing the start of the line to the current cursor position.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e87f31c8-e416-40ca-a7c0-d6ba59c2df8c'>FindWordBoundries</a></td><td style='width:75%' class='def'><p><a name="e87f31c8-e416-40ca-a7c0-d6ba59c2df8c"></a></p>

<h3>Public Virtual <code>Foundation.NSRange</code> FindWordBoundries (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Finds the word boundries as defined by the <code>LanguageSeparators</code> in the<a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> that is currently being syntax highlighted.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="d0181e20-2376-4312-857d-e63ee4efda2b"></a>
<b>System.String text</b></p>

<p>The string to be searched.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="7b3c8e8e-fdc4-4f4c-9640-a8bd8e66c478"></a>
<b>Foundation.NSRange position</b></p>

<p>The <code>NSRange</code> specifying the starting location of a possible word.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>An <code>NSRange</code> containing the starting and ending character locations of the current word.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20c03e52-614f-47c2-9133-38e73aa2f744'>HighlightSyntax</a></td><td style='width:75%' ><p><a name="20c03e52-614f-47c2-9133-38e73aa2f744"></a></p>

<h3>Public Virtual Void HighlightSyntax (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Uses the current <code>Language</code> (<a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>) to syntax highlight the given word in the attached <code>TextEditor</code> (<code>NSTextView</code>) at the given character locations.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>word</td><td style='width:75%' ><p><a name="c4f22d2a-0f4d-4464-b7c5-63d18c001ae6"></a>
<b>System.String word</b></p>

<p>The possible keyword to highlight.</p>
</td></tr><tr><td style='width:25%' class='term'>range</td><td style='width:75%' class='def'><p><a name="37d8d9d2-b399-4661-a365-ceb1078cf539"></a>
<b>Foundation.NSRange range</b></p>

<p>An <code>NSRange</code> specifying the starting and ending character locations for the word to highlight.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: The Text Kit <code>SetTemporaryAttributes</code> routines are handiling the format of character strings such as HTML or XML tag incorrectly.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9ed95d7-8b66-48b4-9157-0c3977660170'>HighlightSyntaxRegion</a></td><td style='width:75%' class='def'><p><a name="f9ed95d7-8b66-48b4-9157-0c3977660170"></a></p>

<h3>Public Virtual Void HighlightSyntaxRegion (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Based on the current <code>Language</code> (<a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a>), highlight the syntax of the given character region.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="bc0e83fa-0656-408e-bcb3-86850b9c397b"></a>
<b>System.String text</b></p>

<p>The string value to be syntax highlighted.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="9f771153-e004-4d63-afbf-18a9fd081cdc"></a>
<b>Foundation.NSRange position</b></p>

<p>The starting location of the text to be highlighted.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0aac1cb-b7f1-47ef-a9c2-356eb820c738'>IsLanguageSeparator</a></td><td style='width:75%' ><p><a name="a0aac1cb-b7f1-47ef-a9c2-356eb820c738"></a></p>

<h3>Public Virtual <code>System.Boolean</code> IsLanguageSeparator (System.Char)</h3>

<h4>Summary</h4>

<p>Determines whether the passed in character is a language separator.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="d514cba8-4ff6-436f-bbee-3ae63b14932d"></a>
<b>System.Char c</b></p>

<p>The character being tested.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code> if the character is a language separator; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54eef626-664f-4803-bb87-9135c10b0b06'>LanguageFormatter</a></td><td style='width:75%' class='def'><p><a name="54eef626-664f-4803-bb87-9135c10b0b06"></a></p>

<h3>Public Void LanguageFormatter (AppKit.NSTextView, AppKit.TextKit.Formatter.LanguageDescriptor)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>textEditor</td><td style='width:75%' ><p><a name="b8363de2-628c-4f09-9f76-4aa64340ec33"></a>
<b>AppKit.NSTextView textEditor</b></p>

<p>The <code>NSTextView</code> that this language formatter will syntax highlight.</p>
</td></tr><tr><td style='width:25%' class='term'>language</td><td style='width:75%' class='def'><p><a name="c7c75084-5a7a-4620-b6e6-91358c84a7b4"></a>
<b>AppKit.TextKit.Formatter.LanguageDescriptor language</b></p>

<p>The <a href="#5bf38b97-3aff-4262-8b73-5ec35d7e9daf">LanguageDescriptor</a> defining the  language syntax highlighting rules.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a9df9bf-23e2-4b7c-ada8-c8d144ba18dd'>PreceedingCharacterIsWhitespaceOrTerminator</a></td><td style='width:75%' ><p><a name="9a9df9bf-23e2-4b7c-ada8-c8d144ba18dd"></a></p>

<h3>Public Virtual <code>System.Boolean</code> PreceedingCharacterIsWhitespaceOrTerminator (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Tests to see if the preceeding character is whitespace or terminator.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="3a3cebb1-d64d-4df8-8f2e-6ba7119cc77f"></a>
<b>System.String text</b></p>

<p>The text to test.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="7b45d39e-ba50-4d89-abdb-9cdc28c81e1b"></a>
<b>Foundation.NSRange position</b></p>

<p>The current cursor position inside the text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if character is whitespace or terminator, <code>false</code> otherwise.</p>

<h4>Remarks</h4>

<p>Returns <code>true</code> if at start of line.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38fb9a74-4670-4b9e-854f-b6308b9d6a10'>Reformat</a></td><td style='width:75%' class='def'><p><a name="38fb9a74-4670-4b9e-854f-b6308b9d6a10"></a></p>

<h3>Public Virtual Void Reformat ()</h3>

<h4>Summary</h4>

<p>Forces all of the text in the attached <code>NSTextView</code> (the <code>TextEditor</code> property) to have its syntax rehighlighted by re-running the formatter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e1367ec-65a6-4912-9f51-3586995c46f0'>TrailingCharacterIsWhitespaceOrTerminator</a></td><td style='width:75%' ><p><a name="5e1367ec-65a6-4912-9f51-3586995c46f0"></a></p>

<h3>Public Virtual <code>System.Boolean</code> TrailingCharacterIsWhitespaceOrTerminator (System.String, Foundation.NSRange)</h3>

<h4>Summary</h4>

<p>Tests to see if the trailing character is whitespace or terminator.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="c37d87ac-3b18-4256-8b78-e06f0dc3df4a"></a>
<b>System.String text</b></p>

<p>The text to test.</p>
</td></tr><tr><td style='width:25%' class='term'>position</td><td style='width:75%' class='def'><p><a name="b98fd1be-843b-45d1-b758-0ad70deea04f"></a>
<b>Foundation.NSRange position</b></p>

<p>The current cursor position inside the text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if character is whitespace or terminator, <code>false</code> otherwise.</p>

<h4>Remarks</h4>

<p>Returns <code>true</code> if at end of line.</p>
</td></tr></table></p>

###Remarks

Please see our Working with Text Controls Docs for more details: https://developer.xamarin.com/guides/mac/user-interface/standard-controls/#Working_with_Text_Controls

---

<a name="7b3b76dc-f0d8-4cb3-afbe-ff8ac08ca432"></a>
##Private Static Class MainClass

###Namespace

[KimonoMac](#eb5d4371-bdff-4aa2-b712-8cda2c473520)

###Inherits From

`System.Object`

###Summary

Main class.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6935ec10-e1d6-4210-b52a-82d4934e6c39'>Main</a></td><td style='width:75%' ><p><a name="6935ec10-e1d6-4210-b52a-82d4934e6c39"></a></p>

<h3>Private Static Void Main (System.String[])</h3>

<h4>Summary</h4>

<p>The entry point of the program, where the program control starts and ends.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>args</td><td style='width:75%' ><p><a name="d977ee3e-f28a-42a0-8144-49abb1a04d9b"></a>
<b>System.String[] args</b></p>

<p>The command-line arguments.</p>
</td></tr></table></p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d2bc1c3-e10b-4eee-9ab9-c5fb6d31a053'>AlignBottomTool</a></td><td style='width:75%' ><p><a name="0d2bc1c3-e10b-4eee-9ab9-c5fb6d31a053"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> AlignBottomTool</h3>

<h4>Summary</h4>

<p>The private read only <code>AlignBottomTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1b7e331-7dbe-4f2e-97f3-3fc43882dcdf'>AlignLeftTool</a></td><td style='width:75%' class='def'><p><a name="f1b7e331-7dbe-4f2e-97f3-3fc43882dcdf"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> AlignLeftTool</h3>

<h4>Summary</h4>

<p>The private read only <code>AlignLeftTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc8c882b-2969-44f5-a280-8bfaa621f4f6'>AlignRightTool</a></td><td style='width:75%' ><p><a name="dc8c882b-2969-44f5-a280-8bfaa621f4f6"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> AlignRightTool</h3>

<h4>Summary</h4>

<p>The private read only <code>AlignRightTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18abf085-2ff9-4bbf-96bf-74288a5fc1f8'>AlignTopTool</a></td><td style='width:75%' class='def'><p><a name="18abf085-2ff9-4bbf-96bf-74288a5fc1f8"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> AlignTopTool</h3>

<h4>Summary</h4>

<p>The private read only <code>AlignTopTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35240f2c-6a2f-438c-81fd-65c02375b498'>CenterHorizontalTool</a></td><td style='width:75%' ><p><a name="35240f2c-6a2f-438c-81fd-65c02375b498"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> CenterHorizontalTool</h3>

<h4>Summary</h4>

<p>The private read only <code>CenterHorizontalTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a816dc9c-5922-4666-8fe5-be2d1f23c89e'>CenterTool</a></td><td style='width:75%' class='def'><p><a name="a816dc9c-5922-4666-8fe5-be2d1f23c89e"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> CenterTool</h3>

<h4>Summary</h4>

<p>The private read only <code>CenterTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbd9eff7-ebf6-4930-8905-45d7ba312773'>CenterVerticalTool</a></td><td style='width:75%' ><p><a name="dbd9eff7-ebf6-4930-8905-45d7ba312773"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> CenterVerticalTool</h3>

<h4>Summary</h4>

<p>The private read only <code>CenterVerticalTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7148eb7b-22a5-46c5-bf0c-8066b1454736'>GroupShapes</a></td><td style='width:75%' class='def'><p><a name="7148eb7b-22a5-46c5-bf0c-8066b1454736"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> GroupShapes</h3>

<h4>Summary</h4>

<p>The private read only <code>GroupShapes</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#974570ad-172e-4b05-ad8f-61823151abb8'>MainController</a></td><td style='width:75%' ><p><a name="974570ad-172e-4b05-ad8f-61823151abb8"></a></p>

<h3>Public Read Only <a href="#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc">KimonoMac.ViewController</a> MainController</h3>

<h4>Summary</h4>

<p>Gets the main controller.</p>

<h4>Return Value</h4>

<p>The main controller.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04d66ee3-7631-409c-9a84-236e1193b2f4'>MoveBackwardsTool</a></td><td style='width:75%' class='def'><p><a name="04d66ee3-7631-409c-9a84-236e1193b2f4"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> MoveBackwardsTool</h3>

<h4>Summary</h4>

<p>The private read only <code>MoveBackwardsTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6325c3fc-15ff-4711-b76b-7817131471be'>MoveBottomTool</a></td><td style='width:75%' ><p><a name="6325c3fc-15ff-4711-b76b-7817131471be"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> MoveBottomTool</h3>

<h4>Summary</h4>

<p>The private read only <code>MoveBottomTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb74227f-e108-40cc-9af2-933661e21ef9'>MoveForwardsTool</a></td><td style='width:75%' class='def'><p><a name="cb74227f-e108-40cc-9af2-933661e21ef9"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> MoveForwardsTool</h3>

<h4>Summary</h4>

<p>The private read only <code>MoveForwardsTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36fd5321-e72b-4c3b-8a1c-a8b64b99dbcb'>MoveTopTool</a></td><td style='width:75%' ><p><a name="36fd5321-e72b-4c3b-8a1c-a8b64b99dbcb"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> MoveTopTool</h3>

<h4>Summary</h4>

<p>The private read only <code>MoveTopTool</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f95fcd1-d8f2-4066-b9ac-91fac390070f'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="8f95fcd1-d8f2-4066-b9ac-91fac390070f"></a></p>

<h3>Private Read Only <a href="#b6001a55-19e6-4020-9180-16fe091e8600">KimonoMac.ActivatableItem</a> UngroupShapes</h3>

<h4>Summary</h4>

<p>The private read only <code>UngroupShapes</code> property of the <code>MainWindowController</code> class has a <code>KimonoMac.ActivatableItem</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#03fcc951-0a25-4a61-b8e1-301809ee0ac4'>AddColor</a></td><td style='width:75%' ><p><a name="03fcc951-0a25-4a61-b8e1-301809ee0ac4"></a></p>

<h3>Public Void AddColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e0609455-050b-45d1-9e0a-b2ec3712cb1c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb26af53-71e2-4bd5-8e9b-af750a84a8f2'>AddGradient</a></td><td style='width:75%' class='def'><p><a name="fb26af53-71e2-4bd5-8e9b-af750a84a8f2"></a></p>

<h3>Public Void AddGradient (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f0cce5be-b7ba-41db-aa9e-70133fe24e30"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a08f275-c045-4123-913b-84ebc4512ea8'>AddSketch</a></td><td style='width:75%' ><p><a name="3a08f275-c045-4123-913b-84ebc4512ea8"></a></p>

<h3>Public Void AddSketch (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="a35811d6-69d2-4bc3-9f41-7473d95eea8b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8adb8adf-0ef8-4543-8c91-f45fd849b7e3'>AddStyle</a></td><td style='width:75%' class='def'><p><a name="8adb8adf-0ef8-4543-8c91-f45fd849b7e3"></a></p>

<h3>Public Void AddStyle (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the style.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="56b27696-97c1-4fc9-ab14-57a27b5944b2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be0b1b65-b2a3-496f-955f-bd9ea4b380ea'>MainWindowController</a></td><td style='width:75%' ><p><a name="be0b1b65-b2a3-496f-955f-bd9ea4b380ea"></a></p>

<h3>Public Void MainWindowController (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b9881a15-c33c-4bf5-8606-4829f8293008">MainWindowController</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="90352865-634e-410c-900d-ee2ac13d857f"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69472ce8-9887-46e0-be21-10010b7955f6'>ReleaseDesignerOutlets</a></td><td style='width:75%' class='def'><p><a name="69472ce8-9887-46e0-be21-10010b7955f6"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>MainWindowController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff364d13-ce25-47e3-959b-538e0e4c274d'>WindowDidLoad</a></td><td style='width:75%' ><p><a name="ff364d13-ce25-47e3-959b-538e0e4c274d"></a></p>

<h3>Public Virtual Void WindowDidLoad ()</h3>

<h4>Summary</h4>

<p>Handles the window loading and configures any user interface elements based on the stateof the <code>KimonoPortfolio</code> being edited.</p>
</td></tr></table></p>


---

<a name="ff737229-6209-452e-95db-a35b8db5e43d"></a>
##Public Class Markdown

###Namespace

[MarkdownSharp](#f189ef65-04ab-41ae-9966-babd6bca16b0)

###Inherits From

`System.Object`

###Summary

Markdown is a text-to-HTML conversion tool for web writers.  Markdown allows you to write using an easy-to-read, easy-to-write plain text format,  then convert it to structurally valid XHTML (or HTML).
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#53f086f3-f283-42e0-bfcf-b19ce2e119b3'>_amps</a></td><td style='width:75%' ><p><a name="53f086f3-f283-42e0-bfcf-b19ce2e119b3"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _amps</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_amps</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f73c038-f624-4989-aa3e-5deb3607dbf6'>_anchorInline</a></td><td style='width:75%' class='def'><p><a name="1f73c038-f624-4989-aa3e-5deb3607dbf6"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _anchorInline</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_anchorInline</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8673e9d1-5152-4f8d-9b4b-c4e6f2f5f1ce'>_anchorRef</a></td><td style='width:75%' ><p><a name="8673e9d1-5152-4f8d-9b4b-c4e6f2f5f1ce"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _anchorRef</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_anchorRef</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f06db30b-9d4a-4860-9b86-e0adfff24db9'>_anchorRefShortcut</a></td><td style='width:75%' class='def'><p><a name="f06db30b-9d4a-4860-9b86-e0adfff24db9"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _anchorRefShortcut</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_anchorRefShortcut</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#500165d8-e25f-46ae-965a-b7fdfb52f609'>_angles</a></td><td style='width:75%' ><p><a name="500165d8-e25f-46ae-965a-b7fdfb52f609"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _angles</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_angles</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39c58fde-2b31-43d0-b9cc-ac27a67ea570'>_autoHyperlink</a></td><td style='width:75%' class='def'><p><a name="39c58fde-2b31-43d0-b9cc-ac27a67ea570"></a>
<b>Private <code>System.Boolean</code> _autoHyperlink</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_autoHyperlink</code> field of the <code>Markdown</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1c6f16d-29d5-4e54-930c-32a8471f904e'>_autolinkBare</a></td><td style='width:75%' ><p><a name="f1c6f16d-29d5-4e54-930c-32a8471f904e"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _autolinkBare</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_autolinkBare</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#714ecb1f-4b6a-436d-8f6e-764c65eb96d3'>_autoNewlines</a></td><td style='width:75%' class='def'><p><a name="714ecb1f-4b6a-436d-8f6e-764c65eb96d3"></a>
<b>Private <code>System.Boolean</code> _autoNewlines</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_autoNewlines</code> field of the <code>Markdown</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03db44c7-d0fa-4f50-8e0d-72c46a958419'>_backslashEscapes</a></td><td style='width:75%' ><p><a name="03db44c7-d0fa-4f50-8e0d-72c46a958419"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _backslashEscapes</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_backslashEscapes</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f275737b-7890-4720-82f9-02ad46c3a371'>_backslashEscapeTable</a></td><td style='width:75%' class='def'><p><a name="f275737b-7890-4720-82f9-02ad46c3a371"></a>
<b>Private Static <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> _backslashEscapeTable</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_backslashEscapeTable</code> field of the <code>Markdown</code> class holds a <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e8abe7b-f2ef-4091-bbc7-ccf75346e308'>_blockquote</a></td><td style='width:75%' ><p><a name="0e8abe7b-f2ef-4091-bbc7-ccf75346e308"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _blockquote</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_blockquote</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b422ace4-ed99-49f3-ab04-ef47be6b4236'>_blocksHtml</a></td><td style='width:75%' class='def'><p><a name="b422ace4-ed99-49f3-ab04-ef47be6b4236"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _blocksHtml</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_blocksHtml</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94932c33-7910-4fe1-87f0-ec1b0fb6b9b8'>_bold</a></td><td style='width:75%' ><p><a name="94932c33-7910-4fe1-87f0-ec1b0fb6b9b8"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _bold</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_bold</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98e2a1b9-0853-4efa-be9d-aedcc4276e2b'>_charEndingUrl</a></td><td style='width:75%' class='def'><p><a name="98e2a1b9-0853-4efa-be9d-aedcc4276e2b"></a>
<b>Private Static Constant <code>System.String</code> _charEndingUrl = <code>[-A-Z0-9+&amp;@#/%=~_|\[\])]</code></b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static constant <code>_charEndingUrl</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value of <code>[-A-Z0-9+&amp;@#/%=~_|\[\])]</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a2becc3-c63f-4981-838b-b13cacdd76e7'>_charInsideUrl</a></td><td style='width:75%' ><p><a name="7a2becc3-c63f-4981-838b-b13cacdd76e7"></a>
<b>Private Static Constant <code>System.String</code> _charInsideUrl = <code>[-A-Z0-9+&amp;@#/%?=~_|\[\]\(\)!:,\.;]</code></b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static constant <code>_charInsideUrl</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value of <code>[-A-Z0-9+&amp;@#/%?=~_|\[\]\(\)!:,\.;]</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66361a25-3501-4c7d-aa1c-32a63e85d740'>_codeBlock</a></td><td style='width:75%' class='def'><p><a name="66361a25-3501-4c7d-aa1c-32a63e85d740"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _codeBlock</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_codeBlock</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c0701cb-9936-4881-98cd-2cf2ee8a3739'>_codeEncoder</a></td><td style='width:75%' ><p><a name="5c0701cb-9936-4881-98cd-2cf2ee8a3739"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _codeEncoder</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_codeEncoder</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad062e69-2e2b-4b12-86a7-d529f054ca5c'>_codeSpan</a></td><td style='width:75%' class='def'><p><a name="ad062e69-2e2b-4b12-86a7-d529f054ca5c"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _codeSpan</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_codeSpan</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15d7dc3a-0d07-49c5-8950-1dbbd247766b'>_emptyElementSuffix</a></td><td style='width:75%' ><p><a name="15d7dc3a-0d07-49c5-8950-1dbbd247766b"></a>
<b>Private <code>System.String</code> _emptyElementSuffix</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_emptyElementSuffix</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d6dd2fd-bada-4e6a-b18d-22db8976480e'>_encodeProblemUrlCharacters</a></td><td style='width:75%' class='def'><p><a name="3d6dd2fd-bada-4e6a-b18d-22db8976480e"></a>
<b>Private <code>System.Boolean</code> _encodeProblemUrlCharacters</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_encodeProblemUrlCharacters</code> field of the <code>Markdown</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c2d0e21-7e3c-45f6-b05f-627c8c791df5'>_endCharRegex</a></td><td style='width:75%' ><p><a name="4c2d0e21-7e3c-45f6-b05f-627c8c791df5"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _endCharRegex</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_endCharRegex</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3bdfab2-bdb8-4056-821e-f8aebb47757e'>_escapeTable</a></td><td style='width:75%' class='def'><p><a name="f3bdfab2-bdb8-4056-821e-f8aebb47757e"></a>
<b>Private Static <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> _escapeTable</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_escapeTable</code> field of the <code>Markdown</code> class holds a <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41130647-6f12-4f58-80fa-c24a7f631171'>_headerAtx</a></td><td style='width:75%' ><p><a name="41130647-6f12-4f58-80fa-c24a7f631171"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _headerAtx</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_headerAtx</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfe7f1fc-3eb0-4422-858e-9cf6b98845fc'>_headerSetext</a></td><td style='width:75%' class='def'><p><a name="cfe7f1fc-3eb0-4422-858e-9cf6b98845fc"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _headerSetext</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_headerSetext</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc0e1bba-ea9c-433e-8457-d4d13806268d'>_horizontalRules</a></td><td style='width:75%' ><p><a name="fc0e1bba-ea9c-433e-8457-d4d13806268d"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _horizontalRules</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_horizontalRules</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c383ae8a-a72d-4632-a04c-4c6399cc0bd5'>_htmlBlockHash</a></td><td style='width:75%' class='def'><p><a name="c383ae8a-a72d-4632-a04c-4c6399cc0bd5"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _htmlBlockHash</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_htmlBlockHash</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82c09d56-8dfb-46fa-8cad-506d1a2c7cad'>_htmlBlocks</a></td><td style='width:75%' ><p><a name="82c09d56-8dfb-46fa-8cad-506d1a2c7cad"></a>
<b>Private <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> _htmlBlocks</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_htmlBlocks</code> field of the <code>Markdown</code> class holds a <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe47baf9-dd96-4e64-bf0a-c59d8fa9a99b'>_htmlTokens</a></td><td style='width:75%' class='def'><p><a name="fe47baf9-dd96-4e64-bf0a-c59d8fa9a99b"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _htmlTokens</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_htmlTokens</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11775230-3486-460d-b2ce-88324d4e47de'>_imagesInline</a></td><td style='width:75%' ><p><a name="11775230-3486-460d-b2ce-88324d4e47de"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _imagesInline</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_imagesInline</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98f098d3-08e5-49d4-bb0c-2ee64b040fb4'>_imagesRef</a></td><td style='width:75%' class='def'><p><a name="98f098d3-08e5-49d4-bb0c-2ee64b040fb4"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _imagesRef</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_imagesRef</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3c5f8a7-9e2a-48cd-87e3-57517396f6eb'>_invertedEscapeTable</a></td><td style='width:75%' ><p><a name="a3c5f8a7-9e2a-48cd-87e3-57517396f6eb"></a>
<b>Private Static <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> _invertedEscapeTable</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_invertedEscapeTable</code> field of the <code>Markdown</code> class holds a <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#901876c3-7353-449a-9c07-18261ec1c4a2'>_italic</a></td><td style='width:75%' class='def'><p><a name="901876c3-7353-449a-9c07-18261ec1c4a2"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _italic</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_italic</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55e35771-6b88-452c-aef1-1715b725ffa4'>_leadingWhitespace</a></td><td style='width:75%' ><p><a name="55e35771-6b88-452c-aef1-1715b725ffa4"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _leadingWhitespace</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_leadingWhitespace</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28891c62-f087-4da3-b713-9a4c3fb433e3'>_linkDef</a></td><td style='width:75%' class='def'><p><a name="28891c62-f087-4da3-b713-9a4c3fb433e3"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _linkDef</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_linkDef</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36e2c679-d8bb-4659-9252-5e5ab72b97e2'>_linkEmails</a></td><td style='width:75%' ><p><a name="36e2c679-d8bb-4659-9252-5e5ab72b97e2"></a>
<b>Private <code>System.Boolean</code> _linkEmails</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_linkEmails</code> field of the <code>Markdown</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4b08f33-bb7a-4e59-9a8c-43878df24860'>_listLevel</a></td><td style='width:75%' class='def'><p><a name="d4b08f33-bb7a-4e59-9a8c-43878df24860"></a>
<b>Private <code>System.Int32</code> _listLevel</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_listLevel</code> field of the <code>Markdown</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#681fd6f6-9a3a-440f-b378-2854c1453ca7'>_listNested</a></td><td style='width:75%' ><p><a name="681fd6f6-9a3a-440f-b378-2854c1453ca7"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _listNested</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_listNested</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e99ca45f-82ad-47af-a8cb-92799d2450bf'>_listTopLevel</a></td><td style='width:75%' class='def'><p><a name="e99ca45f-82ad-47af-a8cb-92799d2450bf"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _listTopLevel</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_listTopLevel</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f44aea8-6f65-4f07-b8e5-4f14419f0c7e'>_markerOL</a></td><td style='width:75%' ><p><a name="8f44aea8-6f65-4f07-b8e5-4f14419f0c7e"></a>
<b>Private Static Constant <code>System.String</code> _markerOL = <code>\d+[.]</code></b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static constant <code>_markerOL</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value of <code>\d+[.]</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64fd71e7-b5f5-421e-9578-d82f9fc7dbef'>_markerUL</a></td><td style='width:75%' class='def'><p><a name="64fd71e7-b5f5-421e-9578-d82f9fc7dbef"></a>
<b>Private Static Constant <code>System.String</code> _markerUL = <code>[*+-]</code></b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static constant <code>_markerUL</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value of <code>[*+-]</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#baf77d7e-2413-43e7-9de4-982d592e262a'>_nestDepth</a></td><td style='width:75%' ><p><a name="baf77d7e-2413-43e7-9de4-982d592e262a"></a>
<b>Private Static Constant <code>System.Int32</code> _nestDepth = <code>6</code></b></p>

<p>maximum nested depth of [] and () supported by the transform; implementation detail</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bb2d8fa-b4a6-4936-897f-856ebebee1dd'>_nestedBracketsPattern</a></td><td style='width:75%' class='def'><p><a name="2bb2d8fa-b4a6-4936-897f-856ebebee1dd"></a>
<b>Private Static <code>System.String</code> _nestedBracketsPattern</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_nestedBracketsPattern</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c11b07bd-8009-44a0-9743-d99726af47d2'>_nestedParensPattern</a></td><td style='width:75%' ><p><a name="c11b07bd-8009-44a0-9743-d99726af47d2"></a>
<b>Private Static <code>System.String</code> _nestedParensPattern</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_nestedParensPattern</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5403771-abd7-4ee5-9118-eaa2f896ab2f'>_newlinesLeadingTrailing</a></td><td style='width:75%' class='def'><p><a name="b5403771-abd7-4ee5-9118-eaa2f896ab2f"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _newlinesLeadingTrailing</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_newlinesLeadingTrailing</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6a2b67c-0466-4851-9220-de9cfc13a2bc'>_newlinesMultiple</a></td><td style='width:75%' ><p><a name="f6a2b67c-0466-4851-9220-de9cfc13a2bc"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _newlinesMultiple</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_newlinesMultiple</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1a05d36-3e67-4470-8910-7779c6cb36d0'>_outDent</a></td><td style='width:75%' class='def'><p><a name="e1a05d36-3e67-4470-8910-7779c6cb36d0"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _outDent</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_outDent</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76996e28-00e9-46cb-8e3e-8ac0bc2c56fd'>_problemUrlChars</a></td><td style='width:75%' ><p><a name="76996e28-00e9-46cb-8e3e-8ac0bc2c56fd"></a>
<b>Private Static <code>System.Char[]</code> _problemUrlChars</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_problemUrlChars</code> field of the <code>Markdown</code> class holds a <code>System.Char[]</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#266bbb75-9ec9-48a7-a896-648f7d657465'>_strictBold</a></td><td style='width:75%' class='def'><p><a name="266bbb75-9ec9-48a7-a896-648f7d657465"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _strictBold</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_strictBold</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94ee1848-bcc2-40a5-92b6-e07875ff516e'>_strictBoldItalic</a></td><td style='width:75%' ><p><a name="94ee1848-bcc2-40a5-92b6-e07875ff516e"></a>
<b>Private <code>System.Boolean</code> _strictBoldItalic</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_strictBoldItalic</code> field of the <code>Markdown</code> class holds a <code>System.Boolean</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af3020d2-71ad-4c7d-bdb9-47ada30f2413'>_strictItalic</a></td><td style='width:75%' class='def'><p><a name="af3020d2-71ad-4c7d-bdb9-47ada30f2413"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _strictItalic</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_strictItalic</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ef8a097-ab01-48f5-9df2-798238a01327'>_tabWidth</a></td><td style='width:75%' ><p><a name="9ef8a097-ab01-48f5-9df2-798238a01327"></a>
<b>Private Static Constant <code>System.Int32</code> _tabWidth = <code>4</code></b></p>

<p>Tabs are automatically converted to spaces as part of the transform   this constant determines how "wide" those tabs become in spaces  </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1da0834f-131e-462b-af0e-cbb1df500529'>_titles</a></td><td style='width:75%' class='def'><p><a name="1da0834f-131e-462b-af0e-cbb1df500529"></a>
<b>Private <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> _titles</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_titles</code> field of the <code>Markdown</code> class holds a <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d67216ab-0b1d-4f1c-ae0f-9ce7a173ec70'>_unescapes</a></td><td style='width:75%' ><p><a name="d67216ab-0b1d-4f1c-ae0f-9ce7a173ec70"></a>
<b>Private Static <code>System.Text.RegularExpressions.Regex</code> _unescapes</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_unescapes</code> field of the <code>Markdown</code> class holds a <code>System.Text.RegularExpressions.Regex</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6297d5c1-48e6-45db-b324-8b0cb5e89ec9'>_urls</a></td><td style='width:75%' class='def'><p><a name="6297d5c1-48e6-45db-b324-8b0cb5e89ec9"></a>
<b>Private <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> _urls</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>_urls</code> field of the <code>Markdown</code> class holds a <code>System.Collections.Generic.Dictionary&lt;System.String,System.String&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8212ab32-f962-4888-96fe-9bc402671cb7'>_version</a></td><td style='width:75%' ><p><a name="8212ab32-f962-4888-96fe-9bc402671cb7"></a>
<b>Private Static Constant <code>System.String</code> _version = <code>1.13</code></b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static constant <code>_version</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value of <code>1.13</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3026cab0-b487-42a8-86a7-6147632a9a58'>_wholeList</a></td><td style='width:75%' class='def'><p><a name="3026cab0-b487-42a8-86a7-6147632a9a58"></a>
<b>Private Static <code>System.String</code> _wholeList</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>_wholeList</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea036bb9-df66-42ce-8225-63bf4667e275'>AutoLinkPreventionMarker</a></td><td style='width:75%' ><p><a name="ea036bb9-df66-42ce-8225-63bf4667e275"></a>
<b>Private Static <code>System.String</code> AutoLinkPreventionMarker</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private static <code>AutoLinkPreventionMarker</code> field of the <code>Markdown</code> class holds a <code>System.String</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c009a9ef-080f-4cb5-8c0d-2cb5ecb97e0f'>AutoHyperlink</a></td><td style='width:75%' ><p><a name="c009a9ef-080f-4cb5-8c0d-2cb5ecb97e0f"></a></p>

<h3>Public <code>System.Boolean</code> AutoHyperlink</h3>

<h4>Summary</h4>

<p>when true, (most) bare plain URLs are auto-hyperlinked   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21982ae6-3bcc-4138-a0e6-dadcaeb3cdd4'>AutoNewLines</a></td><td style='width:75%' class='def'><p><a name="21982ae6-3bcc-4138-a0e6-dadcaeb3cdd4"></a></p>

<h3>Public <code>System.Boolean</code> AutoNewLines</h3>

<h4>Summary</h4>

<p>when true, RETURN becomes a literal newline   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaa9b676-726b-4071-87e0-ce24f8f93618'>EmptyElementSuffix</a></td><td style='width:75%' ><p><a name="eaa9b676-726b-4071-87e0-ce24f8f93618"></a></p>

<h3>Public <code>System.String</code> EmptyElementSuffix</h3>

<h4>Summary</h4>

<p>use "&gt;" for HTML output, or " /&gt;" for XHTML output</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b91420e-a0a8-456f-8f3a-26147c74a295'>EncodeProblemUrlCharacters</a></td><td style='width:75%' class='def'><p><a name="6b91420e-a0a8-456f-8f3a-26147c74a295"></a></p>

<h3>Public <code>System.Boolean</code> EncodeProblemUrlCharacters</h3>

<h4>Summary</h4>

<p>when true, problematic URL characters like [, ], (, and so forth will be encoded  WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#617ed009-4a84-4cbd-9c49-1be881987ec0'>LinkEmails</a></td><td style='width:75%' ><p><a name="617ed009-4a84-4cbd-9c49-1be881987ec0"></a></p>

<h3>Public <code>System.Boolean</code> LinkEmails</h3>

<h4>Summary</h4>

<p>when false, email addresses will never be auto-linked   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd8546ff-b5d5-4b09-9fb7-bb1053a0b30a'>StrictBoldItalic</a></td><td style='width:75%' class='def'><p><a name="dd8546ff-b5d5-4b09-9fb7-bb1053a0b30a"></a></p>

<h3>Public <code>System.Boolean</code> StrictBoldItalic</h3>

<h4>Summary</h4>

<p>when true, bold and italic require non-word characters on either side   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a88297e-fc70-4b70-a60f-bee5335536d3'>Version</a></td><td style='width:75%' ><p><a name="4a88297e-fc70-4b70-a60f-bee5335536d3"></a></p>

<h3>Public Read Only <code>System.String</code> Version</h3>

<h4>Summary</h4>

<p>current version of MarkdownSharp;   see http://code.google.com/p/markdownsharp/ for the latest code or to contribute</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4c296883-a0f2-4a62-954a-fa0d930b388e'>AnchorInlineEvaluator</a></td><td style='width:75%' ><p><a name="4c296883-a0f2-4a62-954a-fa0d930b388e"></a></p>

<h3>Private <code>System.String</code> AnchorInlineEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>AnchorInlineEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="4836f879-5e55-4ee1-8619-345093c3abab"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the AnchorInlineEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b752a18-0084-43cf-a2e1-4271479a82d0'>AnchorRefEvaluator</a></td><td style='width:75%' class='def'><p><a name="7b752a18-0084-43cf-a2e1-4271479a82d0"></a></p>

<h3>Private <code>System.String</code> AnchorRefEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>AnchorRefEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="d9fed50f-7e7b-45d2-8c86-a543389bdcfe"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the AnchorRefEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c17b581-427a-41a8-9b71-7a627961681a'>AnchorRefShortcutEvaluator</a></td><td style='width:75%' ><p><a name="4c17b581-427a-41a8-9b71-7a627961681a"></a></p>

<h3>Private <code>System.String</code> AnchorRefShortcutEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>AnchorRefShortcutEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="5a0fe212-c813-403a-b4ac-3f403c48a5fc"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the AnchorRefShortcutEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e48dba7-1830-4157-acfc-6b2df7ee9370'>AttributeEncode</a></td><td style='width:75%' class='def'><p><a name="1e48dba7-1830-4157-acfc-6b2df7ee9370"></a></p>

<h3>Private Static <code>System.String</code> AttributeEncode (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private static <code>AttributeEncode (System.String)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="3fc85e85-83a9-464a-a6de-f30b1ba90d0a"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the AttributeEncode method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74607c8b-d458-47de-84e4-1886f4313c65'>AtxHeaderEvaluator</a></td><td style='width:75%' ><p><a name="74607c8b-d458-47de-84e4-1886f4313c65"></a></p>

<h3>Private <code>System.String</code> AtxHeaderEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>AtxHeaderEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="45290e02-5237-4cad-a785-aea105e01f2a"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the AtxHeaderEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44d0d1e3-e096-4257-99ef-b847e31a8526'>BlockQuoteEvaluator</a></td><td style='width:75%' class='def'><p><a name="44d0d1e3-e096-4257-99ef-b847e31a8526"></a></p>

<h3>Private <code>System.String</code> BlockQuoteEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>BlockQuoteEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="6ce934c1-0d11-4def-afbb-1c9da2e8054d"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the BlockQuoteEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17b53356-6922-45e1-8438-793daca38ed1'>BlockQuoteEvaluator2</a></td><td style='width:75%' ><p><a name="17b53356-6922-45e1-8438-793daca38ed1"></a></p>

<h3>Private <code>System.String</code> BlockQuoteEvaluator2 (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>BlockQuoteEvaluator2 (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="b473335f-b294-4579-a226-8fdeec47455b"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the BlockQuoteEvaluator2 method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f823074-ce98-4433-8064-b2ec20f74fa8'>Cleanup</a></td><td style='width:75%' class='def'><p><a name="3f823074-ce98-4433-8064-b2ec20f74fa8"></a></p>

<h3>Private Void Cleanup ()</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>Cleanup ()</code> member of the <code>Markdown</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#195e0084-1404-4167-a78f-16f86725300c'>CodeBlockEvaluator</a></td><td style='width:75%' ><p><a name="195e0084-1404-4167-a78f-16f86725300c"></a></p>

<h3>Private <code>System.String</code> CodeBlockEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>CodeBlockEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="99555386-530b-4e37-ac43-f31856cddff0"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the CodeBlockEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f533908-bfb9-45ff-8499-478e3b53c75f'>CodeSpanEvaluator</a></td><td style='width:75%' class='def'><p><a name="8f533908-bfb9-45ff-8499-478e3b53c75f"></a></p>

<h3>Private <code>System.String</code> CodeSpanEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>CodeSpanEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="128e3e8a-ff46-4cd1-b76a-631eb23c15c7"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the CodeSpanEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#907058cf-b32c-441f-8ff3-0db87364faaf'>DoAnchors</a></td><td style='width:75%' ><p><a name="907058cf-b32c-441f-8ff3-0db87364faaf"></a></p>

<h3>Private <code>System.String</code> DoAnchors (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown link shortcuts into HTML anchor tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="c983a907-40b6-4890-a7f6-9414bea0681a"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoAnchors method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><a href="url" title="title">link text</a>  [link text][id]  [id] </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ba58f3d-afda-425c-bcfb-bdb42c5ef565'>DoAutoLinks</a></td><td style='width:75%' class='def'><p><a name="6ba58f3d-afda-425c-bcfb-bdb42c5ef565"></a></p>

<h3>Private <code>System.String</code> DoAutoLinks (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn angle-delimited URLs into HTML anchor tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="fea729b8-e910-4a15-a8bb-801eebec865e"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoAutoLinks method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>&lt; http://www.example.com&gt;</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7e0af42-83d5-4f45-a4fe-c08bf56c0a3c'>DoBlockQuotes</a></td><td style='width:75%' ><p><a name="f7e0af42-83d5-4f45-a4fe-c08bf56c0a3c"></a></p>

<h3>Private <code>System.String</code> DoBlockQuotes (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown &gt; quoted blocks into HTML blockquote blocks</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="5e176593-e658-4915-96b5-8b69524dcebf"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoBlockQuotes method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7773d1e-89dd-4885-a181-79d1cbd05456'>DoCodeBlocks</a></td><td style='width:75%' class='def'><p><a name="b7773d1e-89dd-4885-a181-79d1cbd05456"></a></p>

<h3>Private <code>System.String</code> DoCodeBlocks (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>/// Turn Markdown 4-space indented code into HTML pre code blocks</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="5e108522-0bf3-4a20-b923-86cd9ef2a0ed"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoCodeBlocks method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e44fc4c8-137c-40a9-9483-2b94f2e4bfee'>DoCodeSpans</a></td><td style='width:75%' ><p><a name="e44fc4c8-137c-40a9-9483-2b94f2e4bfee"></a></p>

<h3>Private <code>System.String</code> DoCodeSpans (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown <code>code spans</code> into HTML code tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="7cfeb398-7bfe-40fe-9dc2-1c48698cf612"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoCodeSpans method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da87006b-3efb-428c-bd6c-2187a9c78d5a'>DoHardBreaks</a></td><td style='width:75%' class='def'><p><a name="da87006b-3efb-428c-bd6c-2187a9c78d5a"></a></p>

<h3>Private <code>System.String</code> DoHardBreaks (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn markdown line breaks (two space at end of line) into HTML break tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="2aef75d4-a7cc-4589-80b4-bcb90eec9efb"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoHardBreaks method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41690ebc-1db5-4719-ba89-cb0f3efdc214'>DoHeaders</a></td><td style='width:75%' ><p><a name="41690ebc-1db5-4719-ba89-cb0f3efdc214"></a></p>

<h3>Private <code>System.String</code> DoHeaders (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown headers into HTML header tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="36696c10-1e74-4305-9487-92cbe08c4dfe"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoHeaders method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>Header 1   ========   Header 2   --------   # Header 1   ## Header 2   ## Header 2 with closing hashes ##   ...   ###### Header 6  </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a24560b-70a2-4a19-8d61-70b6e1591b3c'>DoHorizontalRules</a></td><td style='width:75%' class='def'><p><a name="8a24560b-70a2-4a19-8d61-70b6e1591b3c"></a></p>

<h3>Private <code>System.String</code> DoHorizontalRules (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown horizontal rules into HTML hr tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="d7dc3078-b149-4a0c-a122-66d547d14f66"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoHorizontalRules method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><em>*</em>   * * *   --- - - -</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d516265-6b50-4ce0-b6a2-c15e487c4699'>DoImages</a></td><td style='width:75%' ><p><a name="7d516265-6b50-4ce0-b6a2-c15e487c4699"></a></p>

<h3>Private <code>System.String</code> DoImages (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown image shortcuts into HTML img tags. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="4c9b56a6-3409-49ce-87bf-3c06217b6f86"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoImages method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><img src="url" alt="alt text][id] ![alt text" title="optional title" /></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33e961b8-cf42-45cd-964e-c33da193f5ef'>DoItalicsAndBold</a></td><td style='width:75%' class='def'><p><a name="33e961b8-cf42-45cd-964e-c33da193f5ef"></a></p>

<h3>Private <code>System.String</code> DoItalicsAndBold (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown <em>italics</em> and <strong>bold</strong> into HTML strong and em tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="c5a125db-f59c-4e7d-9b2c-cba6808c4936"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoItalicsAndBold method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f1a86a1-095d-4d25-954e-21af0e8d02ec'>DoLists</a></td><td style='width:75%' ><p><a name="1f1a86a1-095d-4d25-954e-21af0e8d02ec"></a></p>

<h3>Private <code>System.String</code> DoLists (System.String, System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Turn Markdown lists into HTML ul and ol and li tags</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="abf4d86a-0ae1-44c4-8d24-f85246ea3f11"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the DoLists method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>isInsideParagraphlessListItem</td><td style='width:75%' class='def'><p><a name="a060f9a2-263b-4db2-a7e9-0c774efd5e5a"></a>
<b>System.Boolean isInsideParagraphlessListItem</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>isInsideParagraphlessListItem</code> parameter of the DoLists method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ebcb864-e11c-4990-81a5-abff52bd165d'>EmailEvaluator</a></td><td style='width:75%' class='def'><p><a name="7ebcb864-e11c-4990-81a5-abff52bd165d"></a></p>

<h3>Private <code>System.String</code> EmailEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>EmailEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="75ab5e4d-1bd9-474b-afde-bab35f1a195e"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the EmailEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b637e25-fecd-4d7c-bd2a-9cc234bca212'>EncodeAmpsAndAngles</a></td><td style='width:75%' ><p><a name="8b637e25-fecd-4d7c-bd2a-9cc234bca212"></a></p>

<h3>Private <code>System.String</code> EncodeAmpsAndAngles (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Encode any ampersands (that aren't part of an HTML entity) and left or right angle brackets</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="d3808bd4-ade1-45c1-8b78-6ec1a3b2e3be"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the EncodeAmpsAndAngles method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d01f51c7-f392-4557-9937-feb176f2832b'>EncodeCode</a></td><td style='width:75%' class='def'><p><a name="d01f51c7-f392-4557-9937-feb176f2832b"></a></p>

<h3>Private <code>System.String</code> EncodeCode (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Encode/escape certain Markdown characters inside code blocks and spans where they are literals</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>code</td><td style='width:75%' ><p><a name="09e28b8f-125c-41c2-8f01-88fad95e634c"></a>
<b>System.String code</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>code</code> parameter of the EncodeCode method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a37177e7-b60b-4150-9fdb-f8495ea1d1f0'>EncodeCodeEvaluator</a></td><td style='width:75%' ><p><a name="a37177e7-b60b-4150-9fdb-f8495ea1d1f0"></a></p>

<h3>Private <code>System.String</code> EncodeCodeEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>EncodeCodeEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="3ee52de3-8ca3-491c-96b0-d93b85226e6e"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the EncodeCodeEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcfa7403-d34f-4339-994d-e3006bf54a84'>EncodeEmailAddress</a></td><td style='width:75%' class='def'><p><a name="fcfa7403-d34f-4339-994d-e3006bf54a84"></a></p>

<h3>Private <code>System.String</code> EncodeEmailAddress (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>encodes email address randomly   roughly 10% raw, 45% hex, 45% dec  note that @ is always encoded and : never is</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>addr</td><td style='width:75%' ><p><a name="8375ab0b-53f9-47a2-a363-97ab61fc9903"></a>
<b>System.String addr</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>addr</code> parameter of the EncodeEmailAddress method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eced931-0e02-4c43-8ef0-e8c23066df9f'>EncodeProblemUrlChars</a></td><td style='width:75%' ><p><a name="0eced931-0e02-4c43-8ef0-e8c23066df9f"></a></p>

<h3>Private <code>System.String</code> EncodeProblemUrlChars (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>hex-encodes some unusual "problem" chars in URLs to avoid URL detection problems </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>url</td><td style='width:75%' ><p><a name="963c65d2-d524-486d-9db3-cf8d736ca725"></a>
<b>System.String url</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>url</code> parameter of the EncodeProblemUrlChars method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06911379-37f3-4b7f-8bce-4131fbf23ec2'>EscapeBackslashes</a></td><td style='width:75%' class='def'><p><a name="06911379-37f3-4b7f-8bce-4131fbf23ec2"></a></p>

<h3>Private <code>System.String</code> EscapeBackslashes (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Encodes any escaped characters such as `, *, [ etc</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="6f92384b-6507-4be5-a638-72b8d1db0ab0"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the EscapeBackslashes method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a09089d-9ed7-4702-9b2c-d28f0f444bba'>EscapeBackslashesEvaluator</a></td><td style='width:75%' ><p><a name="2a09089d-9ed7-4702-9b2c-d28f0f444bba"></a></p>

<h3>Private <code>System.String</code> EscapeBackslashesEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>EscapeBackslashesEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="99f5e7fc-c7c6-42c5-b990-cda87aa177d7"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the EscapeBackslashesEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d613e6e8-4940-4db3-b538-67d9e45542b2'>EscapeBoldItalic</a></td><td style='width:75%' class='def'><p><a name="d613e6e8-4940-4db3-b538-67d9e45542b2"></a></p>

<h3>Private <code>System.String</code> EscapeBoldItalic (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>escapes Bold [ * ] and Italic [ _ ] characters</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="4f5d0439-6d92-47eb-93ac-53ccb476c5d1"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the EscapeBoldItalic method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0e9e912-c880-462c-9e8e-da565a58baaf'>EscapeImageAltText</a></td><td style='width:75%' ><p><a name="a0e9e912-c880-462c-9e8e-da565a58baaf"></a></p>

<h3>Private <code>System.String</code> EscapeImageAltText (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>EscapeImageAltText (System.String)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="593e5bcf-655f-454b-98aa-7c1d19a071cc"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the EscapeImageAltText method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ba3a391-03a4-401b-baea-c80a4aec6609'>EscapeSpecialCharsWithinTagAttributes</a></td><td style='width:75%' class='def'><p><a name="8ba3a391-03a4-401b-baea-c80a4aec6609"></a></p>

<h3>Private <code>System.String</code> EscapeSpecialCharsWithinTagAttributes (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Within tags -- meaning between &lt; and &gt; -- encode [\ ` * _] so they  don't conflict with their use in Markdown for code, italics and strong.  We're replacing each such character with its corresponding hash  value; this is likely overkill, but it should prevent us from colliding  with the escape values by accident.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="22fe5154-9ad2-40fb-842b-50cf9df0804b"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the EscapeSpecialCharsWithinTagAttributes method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#857966bd-3495-40af-ac7b-3da634bf410c'>FormParagraphs</a></td><td style='width:75%' ><p><a name="857966bd-3495-40af-ac7b-3da634bf410c"></a></p>

<h3>Private <code>System.String</code> FormParagraphs (System.String, System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>splits on two or more newlines, to form "paragraphs";     each paragraph is then unhashed (if it is a hash and unhashing isn't turned off) or wrapped in HTML p tag</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="b2148162-3acd-4055-a430-0345209517d9"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the FormParagraphs method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>unhash</td><td style='width:75%' class='def'><p><a name="cdcff852-c17b-49ff-a2e5-789cc27b5e12"></a>
<b>System.Boolean unhash</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>unhash</code> parameter of the FormParagraphs method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bff420ec-8883-4628-9da6-f709b0364adb'>GetBlockPattern</a></td><td style='width:75%' class='def'><p><a name="bff420ec-8883-4628-9da6-f709b0364adb"></a></p>

<h3>Private Static <code>System.String</code> GetBlockPattern ()</h3>

<h4>Summary</h4>

<p>derived pretty much verbatim from PHP Markdown</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74f01d22-e592-4182-b973-bebf5d85d08c'>GetHashKey</a></td><td style='width:75%' ><p><a name="74f01d22-e592-4182-b973-bebf5d85d08c"></a></p>

<h3>Private Static <code>System.String</code> GetHashKey (System.String, System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private static <code>GetHashKey (System.String, System.Boolean)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="e7fcc4b4-6a47-48c0-9ea5-f1c15714ba49"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the GetHashKey method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>isHtmlBlock</td><td style='width:75%' class='def'><p><a name="569187b9-561d-4a24-97ce-52c10d018ec6"></a>
<b>System.Boolean isHtmlBlock</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>isHtmlBlock</code> parameter of the GetHashKey method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5d954aa-2c14-4c21-93f0-5c1e78dded80'>GetListEvaluator</a></td><td style='width:75%' class='def'><p><a name="a5d954aa-2c14-4c21-93f0-5c1e78dded80"></a></p>

<h3>Private <code>System.Text.RegularExpressions.MatchEvaluator</code> GetListEvaluator (System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>GetListEvaluator (System.Boolean)</code> member of the <code>Markdown</code> class returns a <code>System.Text.RegularExpressions.MatchEvaluator</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>isInsideParagraphlessListItem</td><td style='width:75%' ><p><a name="31feb2c1-4797-4497-a58b-8ee216d290c8"></a>
<b>System.Boolean isInsideParagraphlessListItem</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>isInsideParagraphlessListItem</code> parameter of the GetListEvaluator method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62a621f7-9d00-4c55-90da-ff980df11f67'>GetNestedBracketsPattern</a></td><td style='width:75%' ><p><a name="62a621f7-9d00-4c55-90da-ff980df11f67"></a></p>

<h3>Private Static <code>System.String</code> GetNestedBracketsPattern ()</h3>

<h4>Summary</h4>

<p>Reusable pattern to match balanced [brackets]. See Friedl's  "Mastering Regular Expressions", 2nd Ed., pp. 328-331.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#208ee4ea-567e-4d2d-b931-c8634d9d797a'>GetNestedParensPattern</a></td><td style='width:75%' class='def'><p><a name="208ee4ea-567e-4d2d-b931-c8634d9d797a"></a></p>

<h3>Private Static <code>System.String</code> GetNestedParensPattern ()</h3>

<h4>Summary</h4>

<p>Reusable pattern to match balanced (parens). See Friedl's  "Mastering Regular Expressions", 2nd Ed., pp. 328-331.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29ffa080-f715-4c22-997e-ff496cf4794d'>handleTrailingParens</a></td><td style='width:75%' ><p><a name="29ffa080-f715-4c22-997e-ff496cf4794d"></a></p>

<h3>Private Static <code>System.String</code> handleTrailingParens (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private static <code>handleTrailingParens (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="5d409d3a-3a77-401d-b416-ad020c106a9e"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the handleTrailingParens method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33695028-b01a-493f-94cb-a0803ade876c'>HashHTMLBlocks</a></td><td style='width:75%' class='def'><p><a name="33695028-b01a-493f-94cb-a0803ade876c"></a></p>

<h3>Private <code>System.String</code> HashHTMLBlocks (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>replaces any block-level HTML blocks with hash entries</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="083efe66-6fea-4edf-8bc3-2884430b3561"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the HashHTMLBlocks method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57c893b9-164a-4175-b755-ec8ee60c70eb'>HtmlEvaluator</a></td><td style='width:75%' ><p><a name="57c893b9-164a-4175-b755-ec8ee60c70eb"></a></p>

<h3>Private <code>System.String</code> HtmlEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>HtmlEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="0c7c0e95-5db5-429a-b233-2d2a99e5ce2f"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the HtmlEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#927a70fd-4b0a-4376-a42a-1ef48d1ce065'>HyperlinkEvaluator</a></td><td style='width:75%' class='def'><p><a name="927a70fd-4b0a-4376-a42a-1ef48d1ce065"></a></p>

<h3>Private <code>System.String</code> HyperlinkEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>HyperlinkEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="98c783bc-e34b-471f-94d7-d6b07ab4b832"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the HyperlinkEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f88d117e-da35-4ad8-b025-92be90f2a2c5'>ImageInlineEvaluator</a></td><td style='width:75%' ><p><a name="f88d117e-da35-4ad8-b025-92be90f2a2c5"></a></p>

<h3>Private <code>System.String</code> ImageInlineEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>ImageInlineEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="39a99547-bf05-4550-a9c4-5f936619d99d"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the ImageInlineEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f5cab27-1bb9-4dd4-b1ae-98920690dccc'>ImageReferenceEvaluator</a></td><td style='width:75%' class='def'><p><a name="6f5cab27-1bb9-4dd4-b1ae-98920690dccc"></a></p>

<h3>Private <code>System.String</code> ImageReferenceEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>ImageReferenceEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="151d8a5e-3b65-49b8-8211-332233acbe67"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the ImageReferenceEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e1448f7-7438-4d8d-8cd2-1cb0d1f151be'>ImageTag</a></td><td style='width:75%' ><p><a name="9e1448f7-7438-4d8d-8cd2-1cb0d1f151be"></a></p>

<h3>Private <code>System.String</code> ImageTag (System.String, System.String, System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>ImageTag (System.String, System.String, System.String)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>url</td><td style='width:75%' ><p><a name="dcf05dff-0740-470d-b38e-319fd11f98eb"></a>
<b>System.String url</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>url</code> parameter of the ImageTag method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>altText</td><td style='width:75%' class='def'><p><a name="1e3ee2bc-5c1d-457e-8515-05a2c2fba2e3"></a>
<b>System.String altText</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>altText</code> parameter of the ImageTag method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="e10cbb2d-39c6-47d6-9b70-44da071ba84d"></a>
<b>System.String title</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>title</code> parameter of the ImageTag method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2f3a252-7f2a-485c-924d-b8e10a19b767'>LinkEvaluator</a></td><td style='width:75%' class='def'><p><a name="e2f3a252-7f2a-485c-924d-b8e10a19b767"></a></p>

<h3>Private <code>System.String</code> LinkEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>LinkEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="89cc369c-69fc-4b4a-9a79-699ff32f3753"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the LinkEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c2f5eb4-cfc4-4c65-b9fd-f45b7ec4ac3e'>Markdown</a></td><td style='width:75%' ><p><a name="7c2f5eb4-cfc4-4c65-b9fd-f45b7ec4ac3e"></a></p>

<h3>Private Static Void Markdown ()</h3>

<h4>Summary</h4>

<p>In the static constuctor we'll initialize what stays the same across all transforms.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aaf105da-2c7a-4d49-b0ed-036be4c86726'>Markdown</a></td><td style='width:75%' class='def'><p><a name="aaf105da-2c7a-4d49-b0ed-036be4c86726"></a></p>

<h3>Public Void Markdown (MarkdownSharp.MarkdownOptions)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Create a new Markdown instance and set the options from the MarkdownOptions object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>options</td><td style='width:75%' ><p><a name="04327c13-c15e-4f2d-a901-dcc59e934e50"></a>
<b>MarkdownSharp.MarkdownOptions options</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>options</code> parameter of the Markdown method takes a <code>MarkdownSharp.MarkdownOptions</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9328ed24-908e-4b38-9a6d-1f96dd370e92'>Markdown</a></td><td style='width:75%' ><p><a name="9328ed24-908e-4b38-9a6d-1f96dd370e92"></a></p>

<h3>Public Void Markdown (System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Create a new Markdown instance and optionally load options from a configuration file. There they should be stored in the appSettings section, available options are: Markdown.StrictBoldItalic (true/false) Markdown.EmptyElementSuffix ("&gt;" or " /&gt;" without the quotes) Markdown.LinkEmails (true/false) Markdown.AutoNewLines (true/false) Markdown.AutoHyperlink (true/false) Markdown.EncodeProblemUrlCharacters (true/false) </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>loadOptionsFromConfigFile</td><td style='width:75%' ><p><a name="bc9afb6d-0df7-434f-84dc-c4fd9e5fda6b"></a>
<b>System.Boolean loadOptionsFromConfigFile</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>loadOptionsFromConfigFile</code> parameter of the Markdown method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#013e8de4-ab2d-418c-9790-c0fa7827e780'>Normalize</a></td><td style='width:75%' class='def'><p><a name="013e8de4-ab2d-418c-9790-c0fa7827e780"></a></p>

<h3>Private <code>System.String</code> Normalize (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>convert all tabs to _tabWidth spaces;  standardizes line endings from DOS (CR LF) or Mac (CR) to UNIX (LF);  makes sure text ends with a couple of newlines;  removes any blank lines (only spaces) in the text</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="a23e1e7d-4a33-44f1-8f4a-0269adbb701c"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the Normalize method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e677fab-70ff-4a2c-8813-738d808b772d'>Outdent</a></td><td style='width:75%' ><p><a name="2e677fab-70ff-4a2c-8813-738d808b772d"></a></p>

<h3>Private <code>System.String</code> Outdent (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Remove one level of line-leading spaces</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>block</td><td style='width:75%' ><p><a name="92a04f59-cd91-4c3b-9d72-5819076a4e53"></a>
<b>System.String block</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>block</code> parameter of the Outdent method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#803cfd24-25ac-45fc-b447-2361c74c69e9'>ProcessListItems</a></td><td style='width:75%' class='def'><p><a name="803cfd24-25ac-45fc-b447-2361c74c69e9"></a></p>

<h3>Private <code>System.String</code> ProcessListItems (System.String, System.String, System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Process the contents of a single ordered or unordered list, splitting it into individual list items.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>list</td><td style='width:75%' ><p><a name="32173449-55f4-4cd7-b449-945d3aae4fa9"></a>
<b>System.String list</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>list</code> parameter of the ProcessListItems method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>marker</td><td style='width:75%' class='def'><p><a name="4550a845-9990-4d41-afcc-49eb039bc1f1"></a>
<b>System.String marker</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>marker</code> parameter of the ProcessListItems method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>isInsideParagraphlessListItem</td><td style='width:75%' ><p><a name="f7d01602-82e1-4d93-8ad0-82ae454557e5"></a>
<b>System.Boolean isInsideParagraphlessListItem</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>isInsideParagraphlessListItem</code> parameter of the ProcessListItems method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8412e740-9eb1-4568-b987-ea533030a5a2'>RepeatString</a></td><td style='width:75%' ><p><a name="8412e740-9eb1-4568-b987-ea533030a5a2"></a></p>

<h3>Private Static <code>System.String</code> RepeatString (System.String, System.Int32)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>this is to emulate what's evailable in PHP</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="0e1146ba-0b52-47a2-bfb6-3f0a92918554"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the RepeatString method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>count</td><td style='width:75%' class='def'><p><a name="4b6c8cd0-993a-46af-9a52-b904497552a1"></a>
<b>System.Int32 count</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>count</code> parameter of the RepeatString method takes a <code>System.Int32</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebc96ed7-6681-4786-a3ce-b450b6138a5a'>RunBlockGamut</a></td><td style='width:75%' class='def'><p><a name="ebc96ed7-6681-4786-a3ce-b450b6138a5a"></a></p>

<h3>Private <code>System.String</code> RunBlockGamut (System.String, System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Perform transformations that form block-level tags like paragraphs, headers, and list items.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="225b9c83-e2ea-453f-91f7-d1dd6663d351"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the RunBlockGamut method takes a <code>System.String</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>unhash</td><td style='width:75%' class='def'><p><a name="362eefe3-b2ed-4524-a1ad-50422c82dcd2"></a>
<b>System.Boolean unhash</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>unhash</code> parameter of the RunBlockGamut method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8f9a449-828c-4752-bd6b-02f0259b15b3'>RunSpanGamut</a></td><td style='width:75%' ><p><a name="d8f9a449-828c-4752-bd6b-02f0259b15b3"></a></p>

<h3>Private <code>System.String</code> RunSpanGamut (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Perform transformations that occur <em>within</em> block-level tags like paragraphs, headers, and list items.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="5efeea86-f993-4295-a99a-815611ddbef8"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the RunSpanGamut method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#589be927-8c6d-4844-bb1c-0056efc331ee'>SaveFromAutoLinking</a></td><td style='width:75%' class='def'><p><a name="589be927-8c6d-4844-bb1c-0056efc331ee"></a></p>

<h3>Private <code>System.String</code> SaveFromAutoLinking (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>SaveFromAutoLinking (System.String)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="7ca2e605-93dd-41c7-aebe-45ebb07eb14f"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the SaveFromAutoLinking method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a311b4e2-3697-4d87-a693-301814a2f8fb'>SetextHeaderEvaluator</a></td><td style='width:75%' ><p><a name="a311b4e2-3697-4d87-a693-301814a2f8fb"></a></p>

<h3>Private <code>System.String</code> SetextHeaderEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>SetextHeaderEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="c2395ef8-e820-400a-996f-17c740a5f79e"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the SetextHeaderEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b025d5a3-cc42-4e35-9b77-633c357788a7'>Setup</a></td><td style='width:75%' class='def'><p><a name="b025d5a3-cc42-4e35-9b77-633c357788a7"></a></p>

<h3>Private Void Setup ()</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>Setup ()</code> member of the <code>Markdown</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ec24fc3-1d3b-442d-8e0a-a8a920165a4f'>StripLinkDefinitions</a></td><td style='width:75%' ><p><a name="8ec24fc3-1d3b-442d-8e0a-a8a920165a4f"></a></p>

<h3>Private <code>System.String</code> StripLinkDefinitions (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Strips link definitions from text, stores the URLs and titles in hash references.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="8d3b268f-9afa-402c-b191-9cb83a604a1a"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the StripLinkDefinitions method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>^[id]: url "optional title"</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b51ffc3f-b47e-4260-8b86-4a9fbffc7cd9'>TokenizeHTML</a></td><td style='width:75%' class='def'><p><a name="b51ffc3f-b47e-4260-8b86-4a9fbffc7cd9"></a></p>

<h3>Private <code>System.Collections.Generic.List&lt;MarkdownSharp.Markdown.Token&gt;</code> TokenizeHTML (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>returns an array of HTML tokens comprising the input string. Each token is  either a tag (possibly with nested, tags contained therein, such  as &lt;a href="&lt;MTFoo&gt;"&gt;, or a run of text between tags. Each element of the  array is a two-element array; the first is either 'tag' or 'text'; the second is  the actual value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="12cfb3ad-f4c3-4224-9264-4c71d8b88498"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the TokenizeHTML method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ed0d263-88cf-4cc9-9efb-b337fc5c2f4e'>Transform</a></td><td style='width:75%' ><p><a name="0ed0d263-88cf-4cc9-9efb-b337fc5c2f4e"></a></p>

<h3>Public <code>System.String</code> Transform (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Transforms the provided Markdown-formatted text to HTML;   see http://en.wikipedia.org/wiki/Markdown</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="88d8f905-9c9b-4bee-bd5b-672b51336efb"></a>
<b>System.String text</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>text</code> parameter of the Transform method takes a <code>System.String</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>The order in which other subs are called here is essential. Link and image substitutions need to happen before EscapeSpecialChars(), so that any *'s or _'s in the a and img tags get encoded.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd515e87-dd21-4b06-ae16-1dd022a522e2'>Unescape</a></td><td style='width:75%' class='def'><p><a name="cd515e87-dd21-4b06-ae16-1dd022a522e2"></a></p>

<h3>Private <code>System.String</code> Unescape (System.String)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>swap back in all the special characters we've hidden</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>s</td><td style='width:75%' ><p><a name="0506b112-4cfe-499c-a22b-4ebe598b4a7d"></a>
<b>System.String s</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>s</code> parameter of the Unescape method takes a <code>System.String</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1954cc40-8439-4ae0-ab6e-3e3540bbe006'>UnescapeEvaluator</a></td><td style='width:75%' ><p><a name="1954cc40-8439-4ae0-ab6e-3e3540bbe006"></a></p>

<h3>Private <code>System.String</code> UnescapeEvaluator (System.Text.RegularExpressions.Match)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private <code>UnescapeEvaluator (System.Text.RegularExpressions.Match)</code> member of the <code>Markdown</code> class returns a <code>System.String</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>match</td><td style='width:75%' ><p><a name="5b3c4382-01f3-48b5-95ab-cf5386382ad2"></a>
<b>System.Text.RegularExpressions.Match match</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>match</code> parameter of the UnescapeEvaluator method takes a <code>System.Text.RegularExpressions.Match</code> value. </p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="b84628e6-41f4-49c0-a81f-7daf16e5e7b8"></a>
##Public Class MarkDownDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

[AppKit.TextKit.Formatter.LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf)

###Summary

Defines how MarkDown should be colorized using a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee).
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#35e552bf-6818-44fc-b261-29ea740eed98'>md</a></td><td style='width:75%' ><p><a name="35e552bf-6818-44fc-b261-29ea740eed98"></a>
<b>Private <a href="#ff737229-6209-452e-95db-a35b8db5e43d">MarkdownSharp.Markdown</a> md</b></p>

<p>A private instance of the MarkDown Processor.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#279a99c7-45f1-4612-97a9-5b6426756820'>LanguageIdentifier</a></td><td style='width:75%' ><p><a name="279a99c7-45f1-4612-97a9-5b6426756820"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> LanguageIdentifier</h3>

<h4>Summary</h4>

<p>Gets the language identifier.</p>

<h4>Return Value</h4>

<p>The language identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#254cbee5-8b6e-4c3f-b615-ed6666846ba8'>LanguageSeparators</a></td><td style='width:75%' class='def'><p><a name="254cbee5-8b6e-4c3f-b615-ed6666846ba8"></a></p>

<h3>Public Virtual <code>System.Char[]</code> LanguageSeparators</h3>

<h4>Summary</h4>

<p>Gets or sets the language separators for MarkDown.</p>

<h4>Return Value</h4>

<p>The language separators.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#16f6a7d8-9b83-4c63-a1a3-2419e06faeac'>Define</a></td><td style='width:75%' ><p><a name="16f6a7d8-9b83-4c63-a1a3-2419e06faeac"></a></p>

<h3>Public Virtual Void Define ()</h3>

<h4>Summary</h4>

<p>Define this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8c3c104-40aa-49fc-8c64-7e3abfd2fb70'>FormatForPreview</a></td><td style='width:75%' class='def'><p><a name="c8c3c104-40aa-49fc-8c64-7e3abfd2fb70"></a></p>

<h3>Public Virtual <code>System.String</code> FormatForPreview (System.String)</h3>

<h4>Summary</h4>

<p>Formats the passed in string of text for previewing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="557312dc-c744-4ce7-96b5-82b03a39ed5b"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The string formatted for preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53cad0e2-711b-403c-8a5d-18e93f6f8ac6'>MarkDownDescriptor</a></td><td style='width:75%' ><p><a name="53cad0e2-711b-403c-8a5d-18e93f6f8ac6"></a></p>

<h3>Public Void MarkDownDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b84628e6-41f4-49c0-a81f-7daf16e5e7b8">MarkDownDescriptor</a> class.</p>
</td></tr></table></p>

###Remarks

This is a simplified, sample format provided as an example only. The `HighlightSyntaxRegion` method of the [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee) would need to be modified to properly format MarkDown Keywords as the current version was designed for languages like C#, JavaScript or Visual Basic.

---

<a name="7213c9b5-1045-489f-bd22-e12e2c11234c"></a>
##Public Class MarkdownOptions

###Namespace

[MarkdownSharp](#f189ef65-04ab-41ae-9966-babd6bca16b0)

###Inherits From

`System.Object`

###Added In API Version

01.01.00

###Summary

The public `MarkdownOptions` class inherits from the `System.Object` class and is defined in the `MarkdownSharp` namespace. It defines 6 fields, 6 properties, 13 methods and no events.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cbdf7a88-4fcf-493d-9343-b66abbe4c5c5'>AutoHyperlink</a></td><td style='width:75%' ><p><a name="cbdf7a88-4fcf-493d-9343-b66abbe4c5c5"></a></p>

<h3>Public <code>System.Boolean</code> AutoHyperlink</h3>

<h4>Summary</h4>

<p>when true, (most) bare plain URLs are auto-hyperlinked   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#080412da-07a1-4964-8062-a702dc64f817'>AutoNewlines</a></td><td style='width:75%' class='def'><p><a name="080412da-07a1-4964-8062-a702dc64f817"></a></p>

<h3>Public <code>System.Boolean</code> AutoNewlines</h3>

<h4>Summary</h4>

<p>when true, RETURN becomes a literal newline   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b32d1d6-6f12-4465-9834-29b6f6b1ae72'>EmptyElementSuffix</a></td><td style='width:75%' ><p><a name="0b32d1d6-6f12-4465-9834-29b6f6b1ae72"></a></p>

<h3>Public <code>System.String</code> EmptyElementSuffix</h3>

<h4>Summary</h4>

<p>use "&gt;" for HTML output, or " /&gt;" for XHTML output</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4003dd4b-21ad-4146-8171-1271fa0e9830'>EncodeProblemUrlCharacters</a></td><td style='width:75%' class='def'><p><a name="4003dd4b-21ad-4146-8171-1271fa0e9830"></a></p>

<h3>Public <code>System.Boolean</code> EncodeProblemUrlCharacters</h3>

<h4>Summary</h4>

<p>when true, problematic URL characters like [, ], (, and so forth will be encoded  WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f9bbd5a-08ca-47a5-b3b8-a018e00c594c'>LinkEmails</a></td><td style='width:75%' ><p><a name="5f9bbd5a-08ca-47a5-b3b8-a018e00c594c"></a></p>

<h3>Public <code>System.Boolean</code> LinkEmails</h3>

<h4>Summary</h4>

<p>when false, email addresses will never be auto-linked   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27246a9b-842b-4b75-8a81-bcef7bf7f832'>StrictBoldItalic</a></td><td style='width:75%' class='def'><p><a name="27246a9b-842b-4b75-8a81-bcef7bf7f832"></a></p>

<h3>Public <code>System.Boolean</code> StrictBoldItalic</h3>

<h4>Summary</h4>

<p>when true, bold and italic require non-word characters on either side   WARNING: this is a significant deviation from the markdown spec</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9752dde0-e12b-4bb4-a6e1-143d39120dc3'>MarkdownOptions</a></td><td style='width:75%' ><p><a name="9752dde0-e12b-4bb4-a6e1-143d39120dc3"></a></p>

<h3>Public Void MarkdownOptions ()</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The public <code>MarkdownOptions ()</code> constructor for the <code>MarkdownOptions</code> class.</p>
</td></tr></table></p>


---

<a name="61291048-c4cc-483a-9cb7-114faf6713dc"></a>
##Public Class ObiScriptDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

[AppKit.TextKit.Formatter.LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf)

###Summary

Defines how C# should be colorized using a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#32b6dcec-989a-4cc1-ab92-1874de3830d1'>LanguageIdentifier</a></td><td style='width:75%' ><p><a name="32b6dcec-989a-4cc1-ab92-1874de3830d1"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> LanguageIdentifier</h3>

<h4>Summary</h4>

<p>Gets the language identifier.</p>

<h4>Return Value</h4>

<p>The language identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d001b1cc-3f8d-45f8-aa06-20b03b4f342b'>LanguageSeparators</a></td><td style='width:75%' class='def'><p><a name="d001b1cc-3f8d-45f8-aa06-20b03b4f342b"></a></p>

<h3>Public Virtual <code>System.Char[]</code> LanguageSeparators</h3>

<h4>Summary</h4>

<p>Gets or sets the language separators for C#</p>

<h4>Return Value</h4>

<p>The language separators.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ebd28cf4-aef0-4bf7-a6f9-b3c4459856c1'>Define</a></td><td style='width:75%' ><p><a name="ebd28cf4-aef0-4bf7-a6f9-b3c4459856c1"></a></p>

<h3>Public Virtual Void Define ()</h3>

<h4>Summary</h4>

<p>Define this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70ddee4f-45f2-4e88-bd47-714f889923ba'>FormatForPreview</a></td><td style='width:75%' class='def'><p><a name="70ddee4f-45f2-4e88-bd47-714f889923ba"></a></p>

<h3>Public Virtual <code>System.String</code> FormatForPreview (System.String)</h3>

<h4>Summary</h4>

<p>Formats the passed in string of text for previewing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="a0054edb-4061-40d3-b829-e51968303434"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The string formatted for preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01c7cf57-6e08-4e8c-b3c8-d880435c2324'>ObiScriptDescriptor</a></td><td style='width:75%' ><p><a name="01c7cf57-6e08-4e8c-b3c8-d880435c2324"></a></p>

<h3>Public Void ObiScriptDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8e5eb700-a9ce-4234-b397-6054b6a1c028">CSharpDescriptor</a> class.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a229a256-e5b8-4da2-8c9e-f1b448869a54'>_controller</a></td><td style='width:75%' ><p><a name="a229a256-e5b8-4da2-8c9e-f1b448869a54"></a>
<b>Private <a href="#beadeded-5081-43aa-bf9a-5df81248d624">KimonoMac.SourceListView</a> _controller</b></p>

<p>The private <code>_controller</code> field of the <code>SourceListDataSource</code> class holds a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52f2c9c9-1f9d-4382-a05a-cfe2885624dd'>Items</a></td><td style='width:75%' class='def'><p><a name="52f2c9c9-1f9d-4382-a05a-cfe2885624dd"></a>
<b>Public <code>System.Collections.Generic.List&lt;KimonoMac.SourceListItem&gt;</code> Items</b></p>

<p>The collection of <code>SourceListGroup</code> that are being displayed.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8843adc8-5dfa-49f9-b8a2-6aac98c03539'>GetChild</a></td><td style='width:75%' ><p><a name="8843adc8-5dfa-49f9-b8a2-6aac98c03539"></a></p>

<h3>Public Virtual <code>Foundation.NSObject</code> GetChild (AppKit.NSOutlineView, System.nint, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Gets the child.</p>

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

<h4>Returns</h4>

<p>The child.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#277452ef-5605-4029-8c52-7046697e7c29'>GetChildrenCount</a></td><td style='width:75%' class='def'><p><a name="277452ef-5605-4029-8c52-7046697e7c29"></a></p>

<h3>Public Virtual <code>System.nint</code> GetChildrenCount (AppKit.NSOutlineView, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Gets the children count.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="25b92d62-38a1-4ddd-8296-58d037f1ad55"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="dcff4160-c268-4d0c-89c6-09c5b1342e21"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The children count.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72dd8ec6-033d-4a50-ad1a-d4a68c8d59e3'>GetObjectValue</a></td><td style='width:75%' ><p><a name="72dd8ec6-033d-4a50-ad1a-d4a68c8d59e3"></a></p>

<h3>Public Virtual <code>Foundation.NSObject</code> GetObjectValue (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Gets the object value.</p>

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

<h4>Returns</h4>

<p>The object value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#846235a8-834a-4ed9-91f6-0aa129d6c065'>ItemExpandable</a></td><td style='width:75%' class='def'><p><a name="846235a8-834a-4ed9-91f6-0aa129d6c065"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ItemExpandable (AppKit.NSOutlineView, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Items the expandable.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="b7921270-bc48-4cab-a273-7f4d7f4135c6"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="b80f878e-cec1-4482-ad0e-1d528f69b7c8"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if expandable was itemed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6ad9943-3b88-4b9d-85ef-f409c3522c03'>ItemForRow</a></td><td style='width:75%' ><p><a name="f6ad9943-3b88-4b9d-85ef-f409c3522c03"></a></p>

<h3><a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> ItemForRow (System.Int32)</h3>

<h4>Summary</h4>

<p>Items for row.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>row</td><td style='width:75%' ><p><a name="8c957d49-60aa-4577-9fcb-5bae518d03b1"></a>
<b>System.Int32 row</b></p>

<p>Row.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The for row.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b88c0507-420f-45e0-8082-335db86898e1'>SourceListDataSource</a></td><td style='width:75%' class='def'><p><a name="b88c0507-420f-45e0-8082-335db86898e1"></a></p>

<h3>Public Void SourceListDataSource (KimonoMac.SourceListView)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <code>OutlineDataSource</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controller</td><td style='width:75%' ><p><a name="f7d94384-88c9-4355-be36-f7b873d85c10"></a>
<b>KimonoMac.SourceListView controller</b></p>

<p>Controller.</p>
</td></tr></table></p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#91168943-b770-4bdd-938b-daac4314c202'>_controller</a></td><td style='width:75%' ><p><a name="91168943-b770-4bdd-938b-daac4314c202"></a>
<b>Private <a href="#beadeded-5081-43aa-bf9a-5df81248d624">KimonoMac.SourceListView</a> _controller</b></p>

<p>The private <code>_controller</code> field of the <code>SourceListDelegate</code> class holds a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f0499732-33df-4158-aff2-49783d826d4a'>GetCell</a></td><td style='width:75%' ><p><a name="f0499732-33df-4158-aff2-49783d826d4a"></a></p>

<h3>Public Virtual <code>AppKit.NSCell</code> GetCell (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Gets the cell.</p>

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

<h4>Returns</h4>

<p>The cell.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6d89e11-5565-40e7-bd57-2c9f032d8761'>GetView</a></td><td style='width:75%' class='def'><p><a name="d6d89e11-5565-40e7-bd57-2c9f032d8761"></a></p>

<h3>Public Virtual <code>AppKit.NSView</code> GetView (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Views for table column.</p>

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

<h4>Returns</h4>

<p>The for table column.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d51bcea-a44d-4379-ba07-fee55c75cfd7'>IsGroupItem</a></td><td style='width:75%' ><p><a name="4d51bcea-a44d-4379-ba07-fee55c75cfd7"></a></p>

<h3>Public Virtual <code>System.Boolean</code> IsGroupItem (AppKit.NSOutlineView, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Determines whether this instance is group item the specified outlineView item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="de28bae5-f981-4162-a382-3f999517669c"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="ccbc47d9-d9c2-466e-83be-c0ca4045cac3"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code> if this instance is group item the specified outlineView item; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bc67887-bee9-443a-996e-b22d1610e2c4'>SelectionDidChange</a></td><td style='width:75%' class='def'><p><a name="5bc67887-bee9-443a-996e-b22d1610e2c4"></a></p>

<h3>Public Virtual Void SelectionDidChange (Foundation.NSNotification)</h3>

<h4>Summary</h4>

<p>Selections the did change.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="f71ee60e-8912-4b04-ad96-8736f71d56b9"></a>
<b>Foundation.NSNotification notification</b></p>

<p>Notification.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9813cf33-92d4-40cd-b9fc-49a702a89e19'>ShouldEditTableColumn</a></td><td style='width:75%' ><p><a name="9813cf33-92d4-40cd-b9fc-49a702a89e19"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ShouldEditTableColumn (AppKit.NSOutlineView, AppKit.NSTableColumn, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Shoulds the edit table column.</p>

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

<h4>Returns</h4>

<p><code>true</code>, if edit table column was shoulded, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a527b9f4-3c81-41de-ac30-8d0a254eb062'>ShouldSelectItem</a></td><td style='width:75%' class='def'><p><a name="a527b9f4-3c81-41de-ac30-8d0a254eb062"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ShouldSelectItem (AppKit.NSOutlineView, Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Shoulds the select item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outlineView</td><td style='width:75%' ><p><a name="ecaa1f8b-4916-47c3-acbc-f7b292e8d59d"></a>
<b>AppKit.NSOutlineView outlineView</b></p>

<p>Outline view.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="73cafea6-ab44-4816-bcd6-48b15054ae7e"></a>
<b>Foundation.NSObject item</b></p>

<p>Item.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if select item was shoulded, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc90e87e-5162-4709-8965-f7d3957be1e3'>SourceListDelegate</a></td><td style='width:75%' ><p><a name="fc90e87e-5162-4709-8965-f7d3957be1e3"></a></p>

<h3>Public Void SourceListDelegate (KimonoMac.SourceListView)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <code>OutlineViewDelegate</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controller</td><td style='width:75%' ><p><a name="5d104284-e834-44f2-906d-fef9da0325e4"></a>
<b>KimonoMac.SourceListView controller</b></p>

<p>Controller.</p>
</td></tr></table></p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8829417f-5adb-49aa-b818-07c46eb85b09'>_icon</a></td><td style='width:75%' ><p><a name="8829417f-5adb-49aa-b818-07c46eb85b09"></a>
<b>Private <code>AppKit.NSImage</code> _icon</b></p>

<p>The private <code>_icon</code> field of the <code>SourceListItem</code> class holds a <code>AppKit.NSImage</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcee49bb-1612-4047-b9ea-b34cf4311a0c'>_items</a></td><td style='width:75%' class='def'><p><a name="fcee49bb-1612-4047-b9ea-b34cf4311a0c"></a>
<b>Private <code>System.Collections.Generic.List&lt;KimonoMac.SourceListItem&gt;</code> _items</b></p>

<p>The private <code>_items</code> field of the <code>SourceListItem</code> class holds a <code>System.Collections.Generic.List&lt;KimonoMac.SourceListItem&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27d4dfcf-1cd1-4f9f-b11e-21ea5a2e66a3'>_position</a></td><td style='width:75%' ><p><a name="27d4dfcf-1cd1-4f9f-b11e-21ea5a2e66a3"></a>
<b>Private <code>System.Int32</code> _position</b></p>

<p>The private <code>_position</code> field of the <code>SourceListItem</code> class holds a <code>System.Int32</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c97754e-e5be-4aab-98c2-a4d6b4cbf5fe'>_tag</a></td><td style='width:75%' class='def'><p><a name="1c97754e-e5be-4aab-98c2-a4d6b4cbf5fe"></a>
<b>Private <code>System.String</code> _tag</b></p>

<p>The private <code>_tag</code> field of the <code>SourceListItem</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42b880bd-4a46-4abe-8c38-e103605dd951'>_title</a></td><td style='width:75%' ><p><a name="42b880bd-4a46-4abe-8c38-e103605dd951"></a>
<b>Private <code>System.String</code> _title</b></p>

<p>The private <code>_title</code> field of the <code>SourceListItem</code> class holds a <code>System.String</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1b155db-34cc-4d9e-80f9-bd2de1e74f41'>Clicked</a></td><td style='width:75%' class='def'><p><a name="e1b155db-34cc-4d9e-80f9-bd2de1e74f41"></a>
<b>Private <a href="#7895a845-abf1-402c-a040-0a2bc4e4ac64">KimonoMac.SourceListItem.ClickedDelegate</a> Clicked</b></p>

<p>The private <code>Clicked</code> field of the <code>SourceListItem</code> class holds a <code>KimonoMac.SourceListItem.ClickedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#257c2324-41f5-4a7e-add9-2a1ceef1767c'>Count</a></td><td style='width:75%' ><p><a name="257c2324-41f5-4a7e-add9-2a1ceef1767c"></a></p>

<h3>Public Read Only <code>System.Int32</code> Count</h3>

<h4>Summary</h4>

<p>Gets the count.</p>

<h4>Return Value</h4>

<p>The count.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7053e766-ee89-4e01-a0b0-0f40a0a07d9e'>Current</a></td><td style='width:75%' class='def'><p><a name="7053e766-ee89-4e01-a0b0-0f40a0a07d9e"></a></p>

<h3>Public Virtual Read Only <code>System.Object</code> Current</h3>

<h4>Summary</h4>

<p>Gets the current.</p>

<h4>Return Value</h4>

<p>The current.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95032640-2aa0-4f53-98e9-3433d6d66361'>HasChildren</a></td><td style='width:75%' ><p><a name="95032640-2aa0-4f53-98e9-3433d6d66361"></a></p>

<h3>Public Read Only <code>System.Boolean</code> HasChildren</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this instance has children.</p>

<h4>Return Value</h4>

<p><code>true</code> if this instance has children; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cb47192-248c-4856-b0f5-c2d51cab8cb2'>Icon</a></td><td style='width:75%' class='def'><p><a name="6cb47192-248c-4856-b0f5-c2d51cab8cb2"></a></p>

<h3>Public <code>AppKit.NSImage</code> Icon</h3>

<h4>Summary</h4>

<p>Gets or sets the icon.</p>

<h4>Return Value</h4>

<p>The icon.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b0eee16-f0cb-488e-a77b-1fd273b572ed'>Item(System.Int32)</a></td><td style='width:75%' ><p><a name="8b0eee16-f0cb-488e-a77b-1fd273b572ed"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> Item(System.Int32)</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>SourceListGroup</code> at the specified index.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="70ff1fbf-8a97-4edc-8d1c-43fd4ec4af2e"></a>
<b>System.Int32 index</b></p>

<p>Index.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72f197a7-99a1-431d-a6d0-cc2a03899044'>Tag</a></td><td style='width:75%' class='def'><p><a name="72f197a7-99a1-431d-a6d0-cc2a03899044"></a></p>

<h3>Public <code>System.String</code> Tag</h3>

<h4>Summary</h4>

<p>Gets or sets the tag.</p>

<h4>Return Value</h4>

<p>The tag.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f133a7be-4f0a-47a1-b6f7-9ebc4aadb43e'>Title</a></td><td style='width:75%' ><p><a name="f133a7be-4f0a-47a1-b6f7-9ebc4aadb43e"></a></p>

<h3>Public <code>System.String</code> Title</h3>

<h4>Summary</h4>

<p>Gets or sets the title.</p>

<h4>Return Value</h4>

<p>The title.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#53ea5645-4646-4f98-9553-d9296d83fb51'>AddItem</a></td><td style='width:75%' ><p><a name="53ea5645-4646-4f98-9553-d9296d83fb51"></a></p>

<h3>Public Void AddItem (KimonoMac.SourceListItem)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="c72a15b3-9658-42f0-a915-fcd4514c5358"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e791763e-2d20-4c6b-a8f5-4102949550e2'>AddItem</a></td><td style='width:75%' class='def'><p><a name="e791763e-2d20-4c6b-a8f5-4102949550e2"></a></p>

<h3>Public Void AddItem (System.String)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="33984797-e913-43aa-8447-9103e9887d5e"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab5671ab-96c3-4904-b48f-d2cce0ff90fc'>AddItem</a></td><td style='width:75%' ><p><a name="ab5671ab-96c3-4904-b48f-d2cce0ff90fc"></a></p>

<h3>Public Void AddItem (System.String, AppKit.NSImage)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="becd895c-0a89-42b2-8a16-46029c1f5081"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="0a26f156-bb22-4271-bf09-527d976691fd"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8313e85-be87-4368-ae72-5986095a784d'>AddItem</a></td><td style='width:75%' class='def'><p><a name="a8313e85-be87-4368-ae72-5986095a784d"></a></p>

<h3>Public Void AddItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#1d959c8b-a275-478f-be5c-65ea4ba646a4'>AddItem</a></td><td style='width:75%' ><p><a name="1d959c8b-a275-478f-be5c-65ea4ba646a4"></a></p>

<h3>Public Void AddItem (System.String, AppKit.NSImage, System.String)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#d46d274e-2b07-466b-bbd1-f7f5c30cf3bd'>AddItem</a></td><td style='width:75%' class='def'><p><a name="d46d274e-2b07-466b-bbd1-f7f5c30cf3bd"></a></p>

<h3>Public Void AddItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#9d8cc8b1-2fc4-4bf2-8f91-7e5a277605fa'>AddItem</a></td><td style='width:75%' ><p><a name="9d8cc8b1-2fc4-4bf2-8f91-7e5a277605fa"></a></p>

<h3>Public Void AddItem (System.String, System.String)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="e7769d22-7eef-4579-9f92-e9e88c666702"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="c916eef8-295a-49fe-a59c-782c96f4d696"></a>
<b>System.String icon</b></p>

<p>Icon.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b22ef3a-2566-4ece-9907-5c359716bfbd'>AddItem</a></td><td style='width:75%' class='def'><p><a name="6b22ef3a-2566-4ece-9907-5c359716bfbd"></a></p>

<h3>Public Void AddItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#6cbf5d7e-f38b-487a-a8c3-228c8e98c8a0'>Clear</a></td><td style='width:75%' ><p><a name="6cbf5d7e-f38b-487a-a8c3-228c8e98c8a0"></a></p>

<h3>Public Void Clear ()</h3>

<h4>Summary</h4>

<p>Clear this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3471e04-983a-4b2e-bd1f-0367595cb0f7'>GetEnumerator</a></td><td style='width:75%' class='def'><p><a name="f3471e04-983a-4b2e-bd1f-0367595cb0f7"></a></p>

<h3>Public Virtual <code>System.Collections.IEnumerator</code> GetEnumerator ()</h3>

<h4>Summary</h4>

<p>Gets the enumerator.</p>

<h4>Returns</h4>

<p>The enumerator.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e565c77-8248-4dcb-ac86-46e2c4fa1593'>Insert</a></td><td style='width:75%' ><p><a name="8e565c77-8248-4dcb-ac86-46e2c4fa1593"></a></p>

<h3>Public Void Insert (System.Int32, KimonoMac.SourceListItem)</h3>

<h4>Summary</h4>

<p>Insert the specified n and item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="d4a96f19-6a35-47ee-a369-83e8d29a546b"></a>
<b>System.Int32 n</b></p>

<p>N.</p>
</td></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' class='def'><p><a name="c0cf2cc5-8bdc-4bd0-84c2-4959822e596a"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4038978-d37e-4124-a3c5-3a096a26f414'>MoveNext</a></td><td style='width:75%' class='def'><p><a name="d4038978-d37e-4124-a3c5-3a096a26f414"></a></p>

<h3>Public Virtual <code>System.Boolean</code> MoveNext ()</h3>

<h4>Summary</h4>

<p>Moves the next.</p>

<h4>Returns</h4>

<p><code>true</code>, if next was moved, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34bd9077-6dcf-4bdc-a887-0e64b5e27c43'>RaiseClickedEvent</a></td><td style='width:75%' ><p><a name="34bd9077-6dcf-4bdc-a887-0e64b5e27c43"></a></p>

<h3>Void RaiseClickedEvent ()</h3>

<h4>Summary</h4>

<p>Raises the clicked event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a19e63d5-479c-4e4d-863a-a68db62687d1'>RemoveItem</a></td><td style='width:75%' class='def'><p><a name="a19e63d5-479c-4e4d-863a-a68db62687d1"></a></p>

<h3>Public Void RemoveItem (KimonoMac.SourceListItem)</h3>

<h4>Summary</h4>

<p>Removes the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="f043f82b-9435-4b47-8322-cab116eef178"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51e25c10-8d53-4ba4-a3c7-6a154deb4490'>RemoveItem</a></td><td style='width:75%' ><p><a name="51e25c10-8d53-4ba4-a3c7-6a154deb4490"></a></p>

<h3>Public Void RemoveItem (System.Int32)</h3>

<h4>Summary</h4>

<p>Removes the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="61bfe027-3e95-437d-9afa-9745fc3e3783"></a>
<b>System.Int32 n</b></p>

<p>N.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a70d25a8-e81d-4a5a-a19e-9a255bcb5f18'>Reset</a></td><td style='width:75%' class='def'><p><a name="a70d25a8-e81d-4a5a-a19e-9a255bcb5f18"></a></p>

<h3>Public Virtual Void Reset ()</h3>

<h4>Summary</h4>

<p>Reset this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a49fe55a-3cfe-45fb-aa01-71e773829112'>SourceListItem</a></td><td style='width:75%' ><p><a name="a49fe55a-3cfe-45fb-aa01-71e773829112"></a></p>

<h3>Public Void SourceListItem ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#173189d6-4df7-427a-a837-12a76c879c0f'>SourceListItem</a></td><td style='width:75%' class='def'><p><a name="173189d6-4df7-427a-a837-12a76c879c0f"></a></p>

<h3>Public Void SourceListItem (System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="a66afda3-7de1-49fb-b51c-1dad7b330605"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96566ebc-7489-49df-bbac-b58b2ab68288'>SourceListItem</a></td><td style='width:75%' ><p><a name="96566ebc-7489-49df-bbac-b58b2ab68288"></a></p>

<h3>Public Void SourceListItem (System.String, AppKit.NSImage)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="41149db7-47a6-49c2-8cc2-60be167412e1"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="7f1499c5-c68c-48ca-b942-d39f10dfc587"></a>
<b>AppKit.NSImage icon</b></p>

<p>Icon.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0164b2e4-199a-461d-b5c6-7380fe611382'>SourceListItem</a></td><td style='width:75%' class='def'><p><a name="0164b2e4-199a-461d-b5c6-7380fe611382"></a></p>

<h3>Public Void SourceListItem (System.String, AppKit.NSImage, KimonoMac.SourceListItem.ClickedDelegate)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#0dc4a960-7886-48d2-86e8-9f210fa44509'>SourceListItem</a></td><td style='width:75%' ><p><a name="0dc4a960-7886-48d2-86e8-9f210fa44509"></a></p>

<h3>Public Void SourceListItem (System.String, AppKit.NSImage, System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#5ef50103-0248-489c-a321-6ac9880a4ffb'>SourceListItem</a></td><td style='width:75%' class='def'><p><a name="5ef50103-0248-489c-a321-6ac9880a4ffb"></a></p>

<h3>Public Void SourceListItem (System.String, AppKit.NSImage, System.String, KimonoMac.SourceListItem.ClickedDelegate)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

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
</td></tr><tr><td style='width:25%' class='term'><a href='#bb6dc3f7-dea3-4292-aece-4251977374a5'>SourceListItem</a></td><td style='width:75%' ><p><a name="bb6dc3f7-dea3-4292-aece-4251977374a5"></a></p>

<h3>Public Void SourceListItem (System.String, System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>title</td><td style='width:75%' ><p><a name="1b4acc4a-cf12-4e57-83cd-f980f2c8d092"></a>
<b>System.String title</b></p>

<p>Title.</p>
</td></tr><tr><td style='width:25%' class='term'>icon</td><td style='width:75%' class='def'><p><a name="07c22482-a333-4f9a-8201-c596eab575aa"></a>
<b>System.String icon</b></p>

<p>Icon.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6548fc78-a1b8-45be-9d6a-53b9e5602f7b'>SourceListItem</a></td><td style='width:75%' class='def'><p><a name="6548fc78-a1b8-45be-9d6a-53b9e5602f7b"></a></p>

<h3>Public Void SourceListItem (System.String, System.String, KimonoMac.SourceListItem.ClickedDelegate)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#20b849ed-e963-46fd-ac47-3fdd0ee424fa">SourceListItem</a> class.</p>

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
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2df6d1fb-94d5-4a4f-993c-9b020efdbb79'>Clicked</a></td><td style='width:75%' ><p><a name="2df6d1fb-94d5-4a4f-993c-9b020efdbb79"></a></p>

<h3><a href="#7895a845-abf1-402c-a040-0a2bc4e4ac64">KimonoMac.SourceListItem.ClickedDelegate</a> Clicked</h3>

<h4>Summary</h4>

<p>Occurs when clicked.</p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8eafcffa-0716-48f6-954a-4922630627fd'>ItemSelected</a></td><td style='width:75%' ><p><a name="8eafcffa-0716-48f6-954a-4922630627fd"></a>
<b>Private <a href="#9146e8cc-76d1-4777-bbdd-3912a5209854">KimonoMac.SourceListView.ItemSelectedDelegate</a> ItemSelected</b></p>

<p>The private <code>ItemSelected</code> field of the <code>SourceListView</code> class holds a <code>KimonoMac.SourceListView.ItemSelectedDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ed751902-1cf6-4f4c-af5f-a29e1b9abb44'>Data</a></td><td style='width:75%' ><p><a name="ed751902-1cf6-4f4c-af5f-a29e1b9abb44"></a></p>

<h3>Public Read Only <a href="#c6838f10-2ca9-4324-90ca-7822754a9d0d">KimonoMac.SourceListDataSource</a> Data</h3>

<h4>Summary</h4>

<p>Gets the data.</p>

<h4>Return Value</h4>

<p>The data.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5a0ac51a-65bf-48c6-9fd4-91651702a4bb'>AddItem</a></td><td style='width:75%' ><p><a name="5a0ac51a-65bf-48c6-9fd4-91651702a4bb"></a></p>

<h3>Public Void AddItem (KimonoMac.SourceListItem)</h3>

<h4>Summary</h4>

<p>Adds the item.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="cb385133-225d-4c18-a952-bee31ac8e0b3"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2fdbe9c-1ac1-4a07-ae5e-f936bb80ff4b'>AwakeFromNib</a></td><td style='width:75%' class='def'><p><a name="d2fdbe9c-1ac1-4a07-ae5e-f936bb80ff4b"></a></p>

<h3>Public Virtual Void AwakeFromNib ()</h3>

<h4>Summary</h4>

<p>The public virtual <code>AwakeFromNib ()</code> member of the <code>SourceListView</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#843e05cc-e313-4c54-9a6d-f68cdd766368'>Initialize</a></td><td style='width:75%' ><p><a name="843e05cc-e313-4c54-9a6d-f68cdd766368"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f19a0fde-bac3-4090-a442-483ef9ce1fab'>RaiseItemSelected</a></td><td style='width:75%' class='def'><p><a name="f19a0fde-bac3-4090-a442-483ef9ce1fab"></a></p>

<h3>Void RaiseItemSelected (KimonoMac.SourceListItem)</h3>

<h4>Summary</h4>

<p>Raises the item selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="ec712219-6e8c-4a76-90ce-abd3220c28d9"></a>
<b>KimonoMac.SourceListItem item</b></p>

<p>Item.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3471d8b-87b1-42c8-8104-3ad52bbfe834'>SourceListView</a></td><td style='width:75%' ><p><a name="e3471d8b-87b1-42c8-8104-3ad52bbfe834"></a></p>

<h3>Public Void SourceListView ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b30e1ea-2609-4957-ae61-e1ac50112efc'>SourceListView</a></td><td style='width:75%' class='def'><p><a name="6b30e1ea-2609-4957-ae61-e1ac50112efc"></a></p>

<h3>Public Void SourceListView (Foundation.NSCoder)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="9d93ff3a-a06e-4628-9f6e-bded30d81832"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a88eda64-31ab-4acc-a92c-3669cb1fc35b'>SourceListView</a></td><td style='width:75%' ><p><a name="a88eda64-31ab-4acc-a92c-3669cb1fc35b"></a></p>

<h3>Public Void SourceListView (Foundation.NSObjectFlag)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>t</td><td style='width:75%' ><p><a name="e72f529b-a111-479f-9614-7e6739d3ed05"></a>
<b>Foundation.NSObjectFlag t</b></p>

<p>T.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab6cb6da-78e0-48bf-ac29-58438616c44e'>SourceListView</a></td><td style='width:75%' class='def'><p><a name="ab6cb6da-78e0-48bf-ac29-58438616c44e"></a></p>

<h3>Public Void SourceListView (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <code>OutlineViewController</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="890a3867-0914-405e-8182-852fd0bfcfec"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#864cf2b8-3f69-44a3-935f-ef90189c94b4'>ItemSelected</a></td><td style='width:75%' ><p><a name="864cf2b8-3f69-44a3-935f-ef90189c94b4"></a></p>

<h3><a href="#9146e8cc-76d1-4777-bbdd-3912a5209854">KimonoMac.SourceListView.ItemSelectedDelegate</a> ItemSelected</h3>

<h4>Summary</h4>

<p>Occurs when item selected.</p>
</td></tr></table></p>


---

<a name="693e63b3-83a6-43a9-ac2a-7b8fc3474e13"></a>
##Public Class SourceTextView

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`AppKit.NSTextView`

###Summary

This is a customized `NSTextView` that provides specialized input handling for the editing of source code.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ee1862b0-0a55-4108-915c-c66479fc9d3c'>_allowAutoComplete</a></td><td style='width:75%' ><p><a name="ee1862b0-0a55-4108-915c-c66479fc9d3c"></a>
<b>Private <code>System.Boolean</code> _allowAutoComplete</b></p>

<p>Should the editor provide auto completion of partial words.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bd340e2-6dfe-4563-a8ae-ad959d793a50'>_autoCompleteDefaultWords</a></td><td style='width:75%' class='def'><p><a name="9bd340e2-6dfe-4563-a8ae-ad959d793a50"></a>
<b>Private <code>System.Boolean</code> _autoCompleteDefaultWords</b></p>

<p>Should the editor use the default words list for auto complete.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f52f0a8f-3567-48de-b0d2-a5a48f378d24'>_autoCompleteKeywords</a></td><td style='width:75%' ><p><a name="f52f0a8f-3567-48de-b0d2-a5a48f378d24"></a>
<b>Private <code>System.Boolean</code> _autoCompleteKeywords</b></p>

<p>Should the editor auto complete keywords as defined in the current langauge.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84bb3a40-bcd1-465a-b1d9-1d127590de71'>_completeClosures</a></td><td style='width:75%' class='def'><p><a name="84bb3a40-bcd1-465a-b1d9-1d127590de71"></a>
<b>Private <code>System.Boolean</code> _completeClosures</b></p>

<p>Should the editor auto complete closures.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecce3f99-600b-4cf8-a609-e3394f1f2e18'>_defaultWordsOnlyIfKeywordsEmpty</a></td><td style='width:75%' ><p><a name="ecce3f99-600b-4cf8-a609-e3394f1f2e18"></a>
<b>Private <code>System.Boolean</code> _defaultWordsOnlyIfKeywordsEmpty</b></p>

<p>Should the editor only use default words if the keyword list is empty.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc599549-5382-4544-8be3-e669fcbec60f'>_formatter</a></td><td style='width:75%' class='def'><p><a name="cc599549-5382-4544-8be3-e669fcbec60f"></a>
<b>Private <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">AppKit.TextKit.Formatter.LanguageFormatter</a> _formatter</b></p>

<p>The current language formatter used to highlight syntax.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#973a0bd9-7130-43be-90d0-ea557a0f4339'>_selectAfterWrap</a></td><td style='width:75%' ><p><a name="973a0bd9-7130-43be-90d0-ea557a0f4339"></a>
<b>Private <code>System.Boolean</code> _selectAfterWrap</b></p>

<p>Should the edit select the section of text that has just been wrapped in a closure.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9734cd46-a7fb-4fba-b9db-9145d073a08d'>_wrapClosures</a></td><td style='width:75%' class='def'><p><a name="9734cd46-a7fb-4fba-b9db-9145d073a08d"></a>
<b>Private <code>System.Boolean</code> _wrapClosures</b></p>

<p>Should the editor auto wrap selected text in. </p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45ae32cb-24fe-45d8-b172-f4c4676d38d4'>EnterKey</a></td><td style='width:75%' ><p><a name="45ae32cb-24fe-45d8-b172-f4c4676d38d4"></a>
<b>Public Static Constant <code>System.Int32</code> EnterKey = <code>13</code></b></p>

<p>Defines the constant Unicode value of the enter key.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd182f77-d03e-44fe-8339-a0294780fe0b'>ShiftTabKey</a></td><td style='width:75%' class='def'><p><a name="dd182f77-d03e-44fe-8339-a0294780fe0b"></a>
<b>Public Static Constant <code>System.Int32</code> ShiftTabKey = <code>25</code></b></p>

<p>Defines the constant Unicode value of the shift-tab key.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dd5ab6e-8a95-42f6-afb1-a1d988b9733b'>SourceCellClicked</a></td><td style='width:75%' ><p><a name="0dd5ab6e-8a95-42f6-afb1-a1d988b9733b"></a>
<b>Private <code>System.EventHandler&lt;AppKit.NSTextViewClickedEventArgs&gt;</code> SourceCellClicked</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>SourceCellClicked</code> field of the <code>SourceTextView</code> class holds a <code>System.EventHandler&lt;AppKit.NSTextViewClickedEventArgs&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86fe299f-ea05-43c9-aff5-35ff56ad8f4b'>SourceCellDoubleClicked</a></td><td style='width:75%' class='def'><p><a name="86fe299f-ea05-43c9-aff5-35ff56ad8f4b"></a>
<b>Private <code>System.EventHandler&lt;AppKit.NSTextViewDoubleClickEventArgs&gt;</code> SourceCellDoubleClicked</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>SourceCellDoubleClicked</code> field of the <code>SourceTextView</code> class holds a <code>System.EventHandler&lt;AppKit.NSTextViewDoubleClickEventArgs&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#798c6253-7e22-441a-845d-8c7157a49d45'>SourceCellDragged</a></td><td style='width:75%' ><p><a name="798c6253-7e22-441a-845d-8c7157a49d45"></a>
<b>Private <code>System.EventHandler&lt;AppKit.NSTextViewDraggedCellEventArgs&gt;</code> SourceCellDragged</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>SourceCellDragged</code> field of the <code>SourceTextView</code> class holds a <code>System.EventHandler&lt;AppKit.NSTextViewDraggedCellEventArgs&gt;</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f6bf656-65dc-4d52-b243-45da5f2a5d73'>SourceSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="6f6bf656-65dc-4d52-b243-45da5f2a5d73"></a>
<b>Private <code>System.EventHandler</code> SourceSelectionChanged</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>SourceSelectionChanged</code> field of the <code>SourceTextView</code> class holds a <code>System.EventHandler</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10e85454-328d-4615-9c97-70a472f1211c'>SourceTypingAttributesChanged</a></td><td style='width:75%' ><p><a name="10e85454-328d-4615-9c97-70a472f1211c"></a>
<b>Private <code>System.EventHandler</code> SourceTypingAttributesChanged</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The private <code>SourceTypingAttributesChanged</code> field of the <code>SourceTextView</code> class holds a <code>System.EventHandler</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6945272c-8c2d-4c8e-b750-7daa71ab0bcf'>TabKey</a></td><td style='width:75%' class='def'><p><a name="6945272c-8c2d-4c8e-b750-7daa71ab0bcf"></a>
<b>Public Static Constant <code>System.Int32</code> TabKey = <code>9</code></b></p>

<p>Defines the constant Unicode value of the tab key.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#06858350-07b3-407b-bc05-65a0b3d002f1'>AllowAutoComplete</a></td><td style='width:75%' ><p><a name="06858350-07b3-407b-bc05-65a0b3d002f1"></a></p>

<h3>Public <code>System.Boolean</code> AllowAutoComplete</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> allows auto complete of partial words.</p>

<h4>Return Value</h4>

<p><code>true</code> if allows auto complete; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a8f17f9-dd0b-49b5-8393-7cc54e57a3b7'>AutoCompleteDefaultWords</a></td><td style='width:75%' class='def'><p><a name="2a8f17f9-dd0b-49b5-8393-7cc54e57a3b7"></a></p>

<h3>Public <code>System.Boolean</code> AutoCompleteDefaultWords</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> auto completes default words.</p>

<h4>Return Value</h4>

<p><code>true</code> if auto complete default words; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f11dc45-dcc8-47ca-b10b-c385a05ddb3c'>AutoCompleteKeywords</a></td><td style='width:75%' ><p><a name="1f11dc45-dcc8-47ca-b10b-c385a05ddb3c"></a></p>

<h3>Public <code>System.Boolean</code> AutoCompleteKeywords</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> auto completes keywords.</p>

<h4>Return Value</h4>

<p><code>true</code> if auto completes keywords; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d56f887a-d950-4029-acd8-ee0c6950e1ba'>CompleteClosures</a></td><td style='width:75%' class='def'><p><a name="d56f887a-d950-4029-acd8-ee0c6950e1ba"></a></p>

<h3>Public <code>System.Boolean</code> CompleteClosures</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> complete closures.</p>

<h4>Return Value</h4>

<p><code>true</code> if complete closures; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01d3a752-a971-4135-bcff-8abc5f211888'>DefaultWordsOnlyIfKeywordsEmpty</a></td><td style='width:75%' ><p><a name="01d3a752-a971-4135-bcff-8abc5f211888"></a></p>

<h3>Public <code>System.Boolean</code> DefaultWordsOnlyIfKeywordsEmpty</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>  uses the default words (provided by OS X) only if keywords empty.</p>

<h4>Return Value</h4>

<p><code>true</code> if use the default words only if keywords empty; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ff21713-2745-44e9-a8e9-5652f1f16cff'>Formatter</a></td><td style='width:75%' class='def'><p><a name="4ff21713-2745-44e9-a8e9-5652f1f16cff"></a></p>

<h3>Public <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">AppKit.TextKit.Formatter.LanguageFormatter</a> Formatter</h3>

<h4>Summary</h4>

<p>Gets or sets the <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> used to perform syntax highlighting on this <code>NSTextView</code> containing the contents of the document being edited.</p>

<h4>Return Value</h4>

<p>The <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> for the selected language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ca5adf6-00ce-4595-8b31-69ba532ceb58'>SelectAfterWrap</a></td><td style='width:75%' ><p><a name="4ca5adf6-00ce-4595-8b31-69ba532ceb58"></a></p>

<h3>Public <code>System.Boolean</code> SelectAfterWrap</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> selects the text that has just been wrapped in a closure.</p>

<h4>Return Value</h4>

<p><code>true</code> if select after wrap; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afd702f7-bc41-4902-826e-0d55ae06e819'>WrapClosures</a></td><td style='width:75%' class='def'><p><a name="afd702f7-bc41-4902-826e-0d55ae06e819"></a></p>

<h3>Public <code>System.Boolean</code> WrapClosures</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> wrap closures.</p>

<h4>Return Value</h4>

<p><code>true</code> if wrap closures; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d9e1ce4b-e07c-4cde-ba15-b4e0d684c0e6'>CalculateIndentLevel</a></td><td style='width:75%' ><p><a name="d9e1ce4b-e07c-4cde-ba15-b4e0d684c0e6"></a></p>

<h3>Private <code>System.Int32</code> CalculateIndentLevel (System.String)</h3>

<h4>Summary</h4>

<p>Calculates the indent level by counting the number of tab characters at the start of the current line.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>line</td><td style='width:75%' ><p><a name="ac805580-d5bf-4ed5-a1e1-761efc70b022"></a>
<b>System.String line</b></p>

<p>The line of text being processed.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The indent level as the number of tabs.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a702326d-8b0a-4937-8cc4-5af62e3dee5c'>DecreaseTabIndent</a></td><td style='width:75%' class='def'><p><a name="a702326d-8b0a-4937-8cc4-5af62e3dee5c"></a></p>

<h3>Private <code>System.String</code> DecreaseTabIndent (System.String)</h3>

<h4>Summary</h4>

<p>Decreases the tab indent for the given text</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="fd18e9b5-b397-49b8-bb37-a9096d83326d"></a>
<b>System.String text</b></p>

<p>The text to outdent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The text with the tab indent decreased by one.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76e8eb85-3b24-49d7-b763-87563c5e9805'>DraggingEntered</a></td><td style='width:75%' ><p><a name="76e8eb85-3b24-49d7-b763-87563c5e9805"></a></p>

<h3>Public Virtual <code>AppKit.NSDragOperation</code> DraggingEntered (AppKit.NSDraggingInfo)</h3>

<h4>Summary</h4>

<p>Called when a drag operation is started for this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5cab6a61-44de-46a8-bf46-960b7c3410b9"></a>
<b>AppKit.NSDraggingInfo sender</b></p>

<p>Sender.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The entered.</p>

<h4>Remarks</h4>

<p>See Apple's drag and drop docs for more details (https://developer.apple.com/library/mac/documentation/Cocoa/Conceptual/DragandDrop/DragandDrop.html)</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#175dbe56-b56c-4361-8096-8313d0230805'>IncreaseTabIndent</a></td><td style='width:75%' class='def'><p><a name="175dbe56-b56c-4361-8096-8313d0230805"></a></p>

<h3>Private <code>System.String</code> IncreaseTabIndent (System.String)</h3>

<h4>Summary</h4>

<p>Increases the tab indent on the given section of text.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="10656b27-c328-4128-91d0-2292c828c17c"></a>
<b>System.String text</b></p>

<p>The text to indent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The text with the tab indent increased by one.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cfc8e76-d402-4ea4-a040-950802d7a286'>IndentText</a></td><td style='width:75%' ><p><a name="1cfc8e76-d402-4ea4-a040-950802d7a286"></a></p>

<h3>Public Void IndentText ()</h3>

<h4>Summary</h4>

<p>Indents the currently selected text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edd8d352-00b7-4bd3-9924-94131691c0a5'>Initialize</a></td><td style='width:75%' class='def'><p><a name="edd8d352-00b7-4bd3-9924-94131691c0a5"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b87c074-5898-4044-90b2-8de9617f3f0f'>KeyDown</a></td><td style='width:75%' ><p><a name="5b87c074-5898-4044-90b2-8de9617f3f0f"></a></p>

<h3>Public Virtual Void KeyDown (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Look for special keys being pressed and does specific processing based on the key.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="f8efcddc-8c5a-4f85-8226-b715b33b437a"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The event.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23cc4993-f2aa-4a0e-824e-3b0ffd799ea5'>OutdentText</a></td><td style='width:75%' class='def'><p><a name="23cc4993-f2aa-4a0e-824e-3b0ffd799ea5"></a></p>

<h3>Public Void OutdentText ()</h3>

<h4>Summary</h4>

<p>Outdents the currently selected text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f2642e2-daf8-4950-9dab-76d498bff920'>PerformDragOperation</a></td><td style='width:75%' ><p><a name="7f2642e2-daf8-4950-9dab-76d498bff920"></a></p>

<h3>Public Virtual <code>System.Boolean</code> PerformDragOperation (AppKit.NSDraggingInfo)</h3>

<h4>Summary</h4>

<p>Process any drag operations initialized by the user to this <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>. If one or more files have dragged in, the contents of those files will be copied into the document at the  current cursor location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1c988ffd-aae9-4c05-9d1a-c51dc93e0c00"></a>
<b>AppKit.NSDraggingInfo sender</b></p>

<p>The caller that initiated the drag operation.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if drag operation was performed, <code>false</code> otherwise.</p>

<h4>Remarks</h4>

<p>See Apple's drag and drop docs for more details (https://developer.apple.com/library/mac/documentation/Cocoa/Conceptual/DragandDrop/DragandDrop.html)</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be8f633d-4e05-49cf-a89a-e5938fc6b9ff'>PerformFormattingCommand</a></td><td style='width:75%' class='def'><p><a name="be8f633d-4e05-49cf-a89a-e5938fc6b9ff"></a></p>

<h3>Public Void PerformFormattingCommand (AppKit.TextKit.Formatter.LanguageFormatCommand)</h3>

<h4>Summary</h4>

<p>Performs the formatting command on the currectly selected range of text.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>command</td><td style='width:75%' ><p><a name="cf64ac8f-c0ea-4880-b3a0-69ee86f3848a"></a>
<b>AppKit.TextKit.Formatter.LanguageFormatCommand command</b></p>

<p>The <a href="#61eaefa9-223e-4d6c-9055-f3fda225f940">LanguageFormatCommand</a> to apply.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#445084ac-4223-4ef3-8c27-5a69760d9b80'>RaiseSourceCellClicked</a></td><td style='width:75%' ><p><a name="445084ac-4223-4ef3-8c27-5a69760d9b80"></a></p>

<h3>Void RaiseSourceCellClicked (System.Object, AppKit.NSTextViewClickedEventArgs)</h3>

<h4>Summary</h4>

<p>Raises the source cell clicked event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="62b19538-d253-48ec-aabe-b5145b665eff"></a>
<b>System.Object sender</b></p>

<p>The controller raising the event.</p>
</td></tr><tr><td style='width:25%' class='term'>e</td><td style='width:75%' class='def'><p><a name="3fc9508b-f3b4-432b-ae07-e168b4574cae"></a>
<b>AppKit.NSTextViewClickedEventArgs e</b></p>

<p>Arguments defining the event.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e5990e5-2dcc-4e96-8c9c-83a8b02dc69a'>RaiseSourceCellDoubleClicked</a></td><td style='width:75%' class='def'><p><a name="0e5990e5-2dcc-4e96-8c9c-83a8b02dc69a"></a></p>

<h3>Void RaiseSourceCellDoubleClicked (System.Object, AppKit.NSTextViewDoubleClickEventArgs)</h3>

<h4>Summary</h4>

<p>Raises the source cell double clicked event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="54501a88-f576-4500-b919-8d33209cd666"></a>
<b>System.Object sender</b></p>

<p>The controller raising the event.</p>
</td></tr><tr><td style='width:25%' class='term'>e</td><td style='width:75%' class='def'><p><a name="5719d8d5-dac7-43c0-bf8d-42a727958726"></a>
<b>AppKit.NSTextViewDoubleClickEventArgs e</b></p>

<p>Arguments defining the event.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e0f2915-54b2-402d-bfb2-50e2fc197798'>RaiseSourceCellDragged</a></td><td style='width:75%' ><p><a name="8e0f2915-54b2-402d-bfb2-50e2fc197798"></a></p>

<h3>Void RaiseSourceCellDragged (System.Object, AppKit.NSTextViewDraggedCellEventArgs)</h3>

<h4>Summary</h4>

<p>Raises the source cell dragged event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="55432a75-2877-408b-9de1-c6c178cc030b"></a>
<b>System.Object sender</b></p>

<p>The controller raising the event.</p>
</td></tr><tr><td style='width:25%' class='term'>e</td><td style='width:75%' class='def'><p><a name="d82b17a9-dd6d-4aaf-8b1a-b53e755d9768"></a>
<b>AppKit.NSTextViewDraggedCellEventArgs e</b></p>

<p>Arguments defining the event.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#184a3adf-8e61-400b-96dc-442c6a5bea25'>RaiseSourceSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="184a3adf-8e61-400b-96dc-442c6a5bea25"></a></p>

<h3>Void RaiseSourceSelectionChanged (System.Object, System.EventArgs)</h3>

<h4>Summary</h4>

<p>Raises the source selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2f0d89ae-63c7-42bf-aaf9-8fcccc3f4c03"></a>
<b>System.Object sender</b></p>

<p>The controller raising the event.</p>
</td></tr><tr><td style='width:25%' class='term'>e</td><td style='width:75%' class='def'><p><a name="b59aab7d-1ea1-4c96-9a9f-e1a7721d8629"></a>
<b>System.EventArgs e</b></p>

<p>Arguments defining the event.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#518fdfa4-3316-4538-8828-dc02922f6d2e'>RaiseSourceTypingAttributesChanged</a></td><td style='width:75%' ><p><a name="518fdfa4-3316-4538-8828-dc02922f6d2e"></a></p>

<h3>Void RaiseSourceTypingAttributesChanged (System.Object, System.EventArgs)</h3>

<h4>Summary</h4>

<p>Raises the source typing attributes changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e2ea9ae5-9e5a-4eaa-8a3b-89a7e6ca779a"></a>
<b>System.Object sender</b></p>

<p>The controller raising the event.</p>
</td></tr><tr><td style='width:25%' class='term'>e</td><td style='width:75%' class='def'><p><a name="be84818a-64f5-4be9-9d97-66f904f70aee"></a>
<b>System.EventArgs e</b></p>

<p>Arguments defining the event.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fb4638c-9c36-456f-ac2b-16c0964af8a1'>ReadSelectionFromPasteboard</a></td><td style='width:75%' class='def'><p><a name="9fb4638c-9c36-456f-ac2b-16c0964af8a1"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ReadSelectionFromPasteboard (AppKit.NSPasteboard)</h3>

<h4>Summary</h4>

<p>Reads the selection from pasteboard.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>pboard</td><td style='width:75%' ><p><a name="b294a3f7-551c-4d76-98ec-e20bf33a0884"></a>
<b>AppKit.NSPasteboard pboard</b></p>

<p>The pasteboard being read.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the selection was read from the pasteboard, <code>false</code> otherwise.</p>

<h4>Remarks</h4>

<p>This method is overridden to update the formatting after the user pastes text into the view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0f86f92-44f4-4a6d-87af-dff3d53c45f8'>ReadSelectionFromPasteboard</a></td><td style='width:75%' ><p><a name="a0f86f92-44f4-4a6d-87af-dff3d53c45f8"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ReadSelectionFromPasteboard (AppKit.NSPasteboard, System.String)</h3>

<h4>Summary</h4>

<p>Reads the selection from pasteboard.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>pboard</td><td style='width:75%' ><p><a name="34e5d211-9f7b-47d0-8d15-142d54bec7a0"></a>
<b>AppKit.NSPasteboard pboard</b></p>

<p>The pasteboard being read.</p>
</td></tr><tr><td style='width:25%' class='term'>type</td><td style='width:75%' class='def'><p><a name="f5551337-3c9e-4246-9004-c4c78779f2ed"></a>
<b>System.String type</b></p>

<p>The type of data being read from the pasteboard.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the selection was read from the pasteboard, <code>false</code> otherwise.</p>

<h4>Remarks</h4>

<p>This method is overridden to update the formatting after the user pastes text into the view.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#964a07f8-8b05-4ea6-9f07-d0a23578c2a7'>SourceTextView</a></td><td style='width:75%' class='def'><p><a name="964a07f8-8b05-4ea6-9f07-d0a23578c2a7"></a></p>

<h3>Public Void SourceTextView ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c62d7e5d-ad83-45b4-92cd-758b16098d69'>SourceTextView</a></td><td style='width:75%' ><p><a name="c62d7e5d-ad83-45b4-92cd-758b16098d69"></a></p>

<h3>Public Void SourceTextView (CoreGraphics.CGRect)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="db46a903-cc7d-4fcc-ad27-7a7c015d35c7"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eed2c2e9-3e9e-4879-b63b-4eac0bb38f1e'>SourceTextView</a></td><td style='width:75%' class='def'><p><a name="eed2c2e9-3e9e-4879-b63b-4eac0bb38f1e"></a></p>

<h3>Public Void SourceTextView (CoreGraphics.CGRect, AppKit.NSTextContainer)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="f693e6cd-3bd3-49bb-94e4-bdbf1fa8c0e2"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr><tr><td style='width:25%' class='term'>container</td><td style='width:75%' class='def'><p><a name="9b5212d1-75f8-478f-a794-4a7c5368d903"></a>
<b>AppKit.NSTextContainer container</b></p>

<p>Container.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2d3d4e0-84f7-479c-ace5-fa8a382abfc3'>SourceTextView</a></td><td style='width:75%' ><p><a name="e2d3d4e0-84f7-479c-ace5-fa8a382abfc3"></a></p>

<h3>Public Void SourceTextView (Foundation.NSCoder)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="f60d80ae-1ac2-404f-90ae-a6c46a8c6572"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75cb55f5-0bcf-438f-9d74-5fc386e1ec41'>SourceTextView</a></td><td style='width:75%' class='def'><p><a name="75cb55f5-0bcf-438f-9d74-5fc386e1ec41"></a></p>

<h3>Public Void SourceTextView (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="b9345ea1-013d-4ef9-ac91-55f688733410"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9012b5cf-aea9-4881-8edc-37ff93a8d4dc'>TabIndent</a></td><td style='width:75%' ><p><a name="9012b5cf-aea9-4881-8edc-37ff93a8d4dc"></a></p>

<h3>Private <code>System.String</code> TabIndent (System.Int32)</h3>

<h4>Summary</h4>

<p>Creates a string of n number of tab characters that will be used to keep the tab level of the current line of text.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>indentLevel</td><td style='width:75%' ><p><a name="2961f53a-0727-4af7-add9-ad0b9aef964e"></a>
<b>System.Int32 indentLevel</b></p>

<p>The number of tab characters to insert in the string.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A string of n tab characters.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#69ae0faa-0442-451c-962b-d5732b8fe55e'>SourceCellClicked</a></td><td style='width:75%' ><p><a name="69ae0faa-0442-451c-962b-d5732b8fe55e"></a></p>

<h3><code>System.EventHandler&lt;AppKit.NSTextViewClickedEventArgs&gt;</code> SourceCellClicked</h3>

<h4>Summary</h4>

<p>Occurs when source cell clicked. </p>

<h4>Remarks</h4>

<p>NOTE: This replaces the built-in <code>CellClicked</code> event because we are providing a custom <code>NSTextViewDelegate</code> and it is unavialable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e1dae40-d3ef-4288-9a78-7cf575a84a24'>SourceCellDoubleClicked</a></td><td style='width:75%' class='def'><p><a name="4e1dae40-d3ef-4288-9a78-7cf575a84a24"></a></p>

<h3><code>System.EventHandler&lt;AppKit.NSTextViewDoubleClickEventArgs&gt;</code> SourceCellDoubleClicked</h3>

<h4>Summary</h4>

<p>Occurs when source cell double clicked.</p>

<h4>Remarks</h4>

<p>NOTE: This replaces the built-in <code>CellDoubleClicked</code> event because we are providing a custom <code>NSTextViewDelegate</code> and it is unavialable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb4ccb24-348d-4ba4-8196-88aaa034fe29'>SourceCellDragged</a></td><td style='width:75%' ><p><a name="eb4ccb24-348d-4ba4-8196-88aaa034fe29"></a></p>

<h3><code>System.EventHandler&lt;AppKit.NSTextViewDraggedCellEventArgs&gt;</code> SourceCellDragged</h3>

<h4>Summary</h4>

<p>Occurs when source cell dragged.</p>

<h4>Remarks</h4>

<p>NOTE: This replaces the built-in <code>DragCell</code> event because we are providing a custom <code>NSTextViewDelegate</code> and it is unavialable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d8e0975-6b99-43f9-afd5-884f51d15057'>SourceSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="0d8e0975-6b99-43f9-afd5-884f51d15057"></a></p>

<h3><code>System.EventHandler</code> SourceSelectionChanged</h3>

<h4>Summary</h4>

<p>Occurs when source selection changed.</p>

<h4>Remarks</h4>

<p>NOTE: This replaces the built-in <code>DidChangeSelection</code> event because we are providing a custom <code>NSTextViewDelegate</code> and it is unavialable.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31962709-7720-4034-bae7-5bad8f31cb9a'>SourceTypingAttributesChanged</a></td><td style='width:75%' ><p><a name="31962709-7720-4034-bae7-5bad8f31cb9a"></a></p>

<h3><code>System.EventHandler</code> SourceTypingAttributesChanged</h3>

<h4>Summary</h4>

<p>Occurs when source typing attributes changed.</p>

<h4>Remarks</h4>

<p>NOTE: This replaces the built-in <code>DidChangeTypingAttributes</code> event because we are providing a custom <code>NSTextViewDelegate</code> and it is unavialable.</p>
</td></tr></table></p>

###Remarks

See Apple's documentation of the Cocoa Text Architecture:  https://developer.apple.com/library/mac/documentation/TextFonts/Conceptual/CocoaTextArchitecture/TextEditing/TextEditing.html#//apple_ref/doc/uid/TP40009459-CH3-SW16 https://developer.apple.com/library/mac/documentation/Cocoa/Reference/ApplicationKit/Classes/NSTextView_Class/

---

<a name="185a6024-f8d8-4ead-ac13-12a6721fb8ce"></a>
##Public Class SourceTextViewDelegate

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

`AppKit.NSTextViewDelegate`

###Summary

The [SourceTextViewDelegate](#185a6024-f8d8-4ead-ac13-12a6721fb8ce) is used to respond to events that occur on a [SourceTextView](#693e63b3-83a6-43a9-ac2a-7b8fc3474e13).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2750419a-0303-4f89-a339-54da16bb267b'>TextEditor</a></td><td style='width:75%' ><p><a name="2750419a-0303-4f89-a339-54da16bb267b"></a></p>

<h3>Public <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">AppKit.TextKit.Formatter.SourceTextView</a> TextEditor</h3>

<h4>Summary</h4>

<p>Gets or sets the text editor.</p>

<h4>Return Value</h4>

<p>The <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> this delegate is attached to.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#91c65443-34f7-4b7c-a572-f570d41e5601'>CellClicked</a></td><td style='width:75%' ><p><a name="91c65443-34f7-4b7c-a572-f570d41e5601"></a></p>

<h3>Public Virtual Void CellClicked (AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint)</h3>

<h4>Summary</h4>

<p>Called when the cell is clicked.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>textView</td><td style='width:75%' ><p><a name="7b93c6c1-4fde-40d5-aedf-81218c4e5524"></a>
<b>AppKit.NSTextView textView</b></p>

<p>The <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>
</td></tr><tr><td style='width:25%' class='term'>cell</td><td style='width:75%' class='def'><p><a name="842086c8-b174-4980-95f9-7d63389b2cb9"></a>
<b>AppKit.NSTextAttachmentCell cell</b></p>

<p>The cell being acted upon.</p>
</td></tr><tr><td style='width:25%' class='term'>cellFrame</td><td style='width:75%' ><p><a name="63aaac38-0663-4d57-bd0d-07092f35e2f3"></a>
<b>CoreGraphics.CGRect cellFrame</b></p>

<p>The onscreen frame of the cell.</p>
</td></tr><tr><td style='width:25%' class='term'>charIndex</td><td style='width:75%' class='def'><p><a name="e831fb2f-5887-44fa-8a67-d718f2b77d33"></a>
<b>System.nuint charIndex</b></p>

<p>The index of the character clicked.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>Because a custom <code>Delegate</code> has been attached to the <code>NSTextView</code>, the normal events will not work so we are using this method to call custom <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> events instead.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1276585-19b6-4518-91cf-3b2ec1a307a5'>CellDoubleClicked</a></td><td style='width:75%' class='def'><p><a name="d1276585-19b6-4518-91cf-3b2ec1a307a5"></a></p>

<h3>Public Virtual Void CellDoubleClicked (AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint)</h3>

<h4>Summary</h4>

<p>Called when the cell is double-clicked.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>textView</td><td style='width:75%' ><p><a name="57235421-d0cb-4073-b2ee-0cde893e5c74"></a>
<b>AppKit.NSTextView textView</b></p>

<p>The <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>
</td></tr><tr><td style='width:25%' class='term'>cell</td><td style='width:75%' class='def'><p><a name="0efa3e7b-fa97-451d-9196-f314e2f014e5"></a>
<b>AppKit.NSTextAttachmentCell cell</b></p>

<p>The cell being acted upon.</p>
</td></tr><tr><td style='width:25%' class='term'>cellFrame</td><td style='width:75%' ><p><a name="bcb251d7-de5c-4cc9-a450-3446c0f6ccf5"></a>
<b>CoreGraphics.CGRect cellFrame</b></p>

<p>The onscreen frame of the cell.</p>
</td></tr><tr><td style='width:25%' class='term'>charIndex</td><td style='width:75%' class='def'><p><a name="933e16f5-eef6-4a2a-82ac-c97fda615d17"></a>
<b>System.nuint charIndex</b></p>

<p>The index of the character clicked.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>Because a custom <code>Delegate</code> has been attached to the <code>NSTextView</code>, the normal events will not work so we are using this method to call custom <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> events instead.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84f96df3-3267-47d2-96d9-68f4acf08fcf'>DidChangeSelection</a></td><td style='width:75%' ><p><a name="84f96df3-3267-47d2-96d9-68f4acf08fcf"></a></p>

<h3>Public Virtual Void DidChangeSelection (Foundation.NSNotification)</h3>

<h4>Summary</h4>

<p>Called when the text selection has changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="7fb69ab6-d662-4a37-beb8-fb9c0c527bf3"></a>
<b>Foundation.NSNotification notification</b></p>

<p>A notification defining the change.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>Because a custom <code>Delegate</code> has been attached to the <code>NSTextView</code>, the normal events will not work so we are using this method to call custom <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> events instead.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ffe0482-7ed9-4ed8-985d-89d8ab889423'>DidChangeTypingAttributes</a></td><td style='width:75%' class='def'><p><a name="9ffe0482-7ed9-4ed8-985d-89d8ab889423"></a></p>

<h3>Public Virtual Void DidChangeTypingAttributes (Foundation.NSNotification)</h3>

<h4>Summary</h4>

<p>Called when the typing attributes has changed.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>notification</td><td style='width:75%' ><p><a name="c182703e-a9b7-473b-ad9a-257feda366b9"></a>
<b>Foundation.NSNotification notification</b></p>

<p>A notification defining the change.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>Because a custom <code>Delegate</code> has been attached to the <code>NSTextView</code>, the normal events will not work so we are using this method to call custom <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> events instead.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba28b7a0-531c-4138-ab3c-de7326af2022'>DraggedCell</a></td><td style='width:75%' ><p><a name="ba28b7a0-531c-4138-ab3c-de7326af2022"></a></p>

<h3>Public Virtual Void DraggedCell (AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, AppKit.NSEvent)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Called when the cell is dragged.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>textView</td><td style='width:75%' ><p><a name="ac575bf5-565e-46c8-99d6-a4332070511f"></a>
<b>Deleted In API Version 01.00.00</b></p>

<p>The <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>
</td></tr><tr><td style='width:25%' class='term'>cell</td><td style='width:75%' class='def'><p><a name="b5c83e6e-b361-40f7-bba3-a648e4fb75c9"></a>
<b>AppKit.NSTextAttachmentCell cell</b></p>

<p>The cell being acted upon.</p>
</td></tr><tr><td style='width:25%' class='term'>cellFrame</td><td style='width:75%' ><p><a name="a09e2a04-9c3c-47e2-95de-10a6cbce07b9"></a>
<b>Deleted In API Version 01.00.00</b></p>

<p>The onscreen frame of the cell.</p>
</td></tr><tr><td style='width:25%' class='term'>theevent</td><td style='width:75%' class='def'><p><a name="f6f6d3f9-bd3f-4a60-a9f8-9da52dd84cb4"></a>
<b>AppKit.NSEvent theevent</b></p>

<p>An event defining the drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'>view</td><td style='width:75%' ><p><a name="129b4df4-35cb-4708-af16-c10cdd96245b"></a>
<b>AppKit.NSTextView view</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>view</code> parameter of the DraggedCell method takes a <code>AppKit.NSTextView</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="6daa7a61-e4d7-4112-93b5-782d04ea7196"></a>
<b>CoreGraphics.CGRect rect</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>rect</code> parameter of the DraggedCell method takes a <code>CoreGraphics.CGRect</code> value. </p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>Because a custom <code>Delegate</code> has been attached to the <code>NSTextView</code>, the normal events will not work so we are using this method to call custom <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> events instead.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0199ba66-f232-4d6f-9aa9-9c33743bd232'>GetCompletions</a></td><td style='width:75%' class='def'><p><a name="0199ba66-f232-4d6f-9aa9-9c33743bd232"></a></p>

<h3>Public Virtual <code>System.String[]</code> GetCompletions (AppKit.NSTextView, System.String[], Foundation.NSRange, System.nint@)</h3>

<h4>Summary</h4>

<p>Based on the user preferences set on the parent <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>, this method returns the available list of partial word completions.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>textView</td><td style='width:75%' ><p><a name="34c72ef3-89af-443f-b9d5-f0692b6da0d7"></a>
<b>AppKit.NSTextView textView</b></p>

<p>The source <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a>.</p>
</td></tr><tr><td style='width:25%' class='term'>words</td><td style='width:75%' class='def'><p><a name="3a29bc64-97ae-41d6-bf5f-d81f03729eaf"></a>
<b>System.String[] words</b></p>

<p>A list of default words automatically provided by OS X in the user's language.</p>
</td></tr><tr><td style='width:25%' class='term'>charRange</td><td style='width:75%' ><p><a name="95069efa-2f57-485f-970d-426c8925ee1d"></a>
<b>Foundation.NSRange charRange</b></p>

<p>The cursor location where the partial word exists.</p>
</td></tr><tr><td style='width:25%' class='term'>Ref index</td><td style='width:75%' class='def'><p><a name="57f3f095-4cdc-4c54-b872-1e7ac9ad3b70"></a>
<b>System.nint Ref index</b></p>

<p>The word that should be selected when the list is displayed (usually 0 meaning the first item in the list). Pass -1 for no selected items.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The list of word completions that will be presented to the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b112ba74-0f4a-48e9-8d3d-672a16fdef37'>SourceTextViewDelegate</a></td><td style='width:75%' ><p><a name="b112ba74-0f4a-48e9-8d3d-672a16fdef37"></a></p>

<h3>Public Void SourceTextViewDelegate (AppKit.TextKit.Formatter.SourceTextView)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#185a6024-f8d8-4ead-ac13-12a6721fb8ce">SourceTextViewDelegate</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>textEditor</td><td style='width:75%' ><p><a name="6270eb52-8949-4653-982f-8606a0a977ea"></a>
<b>AppKit.TextKit.Formatter.SourceTextView textEditor</b></p>

<p>Text editor.</p>
</td></tr></table></p>
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
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7b7baf93-c450-405f-94f1-6fcfcc979493'>_currentInspectorMode</a></td><td style='width:75%' ><p><a name="7b7baf93-c450-405f-94f1-6fcfcc979493"></a>
<b>Private <a href="#c44d4017-143a-4222-a7ea-515fa98aa272">KimonoMac.InspectorViewMode</a> _currentInspectorMode</b></p>

<p>Holds the current inspector view that is being displayed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a9cad01-12e4-4c3d-b2a6-9b599205ae95'>_keywordInfo</a></td><td style='width:75%' class='def'><p><a name="1a9cad01-12e4-4c3d-b2a6-9b599205ae95"></a>
<b>Private <a href="#56094def-ccde-45a2-987f-18730526fdc6">AppKit.TextKit.Formatter.KeywordDescriptor</a> _keywordInfo</b></p>

<p>The information on the currently highlighted keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d46d8c6b-f77b-4ef6-88b6-69302e073d94'>InspectingElement</a></td><td style='width:75%' ><p><a name="d46d8c6b-f77b-4ef6-88b6-69302e073d94"></a>
<b>Private <code>System.Object</code> InspectingElement</b></p>

<p>The Kimono element that is currently being inspected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d96a21ea-2884-426b-8ab4-77c0f5cf7f18'>SketchModified</a></td><td style='width:75%' class='def'><p><a name="d96a21ea-2884-426b-8ab4-77c0f5cf7f18"></a>
<b>Private <code>KimonoCore.Kimono.SketchEventDelegate</code> SketchModified</b></p>

<p>The private <code>SketchModified</code> field of the <code>ViewController</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6837ad53-ecc1-4baa-a26f-482f32f8dd56'>App</a></td><td style='width:75%' ><p><a name="6837ad53-ecc1-4baa-a26f-482f32f8dd56"></a></p>

<h3>Public Static Read Only <a href="#b4a5fd3a-500e-4d49-a5be-aac2002d9a82">KimonoMac.AppDelegate</a> App</h3>

<h4>Summary</h4>

<p>A helper shortcut to the app delegate.</p>

<h4>Return Value</h4>

<p>The app.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#139425ef-a8d3-4538-8f4c-326f3c948c30'>ArrowInspector</a></td><td style='width:75%' class='def'><p><a name="139425ef-a8d3-4538-8f4c-326f3c948c30"></a></p>

<h3>Private Read Only <a href="#fbd844de-247a-4e17-9ab5-e5cda997b4a0">KimonoMac.KimonoInspectorArrow</a> ArrowInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>ArrowInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorArrow</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b8c86da-218f-47ef-9a66-1efdee4fd37b'>AttachedStyleInspector</a></td><td style='width:75%' ><p><a name="3b8c86da-218f-47ef-9a66-1efdee4fd37b"></a></p>

<h3>Private Read Only <a href="#eb950e5f-f53b-47ee-a68f-7bcb0d06a262">KimonoMac.KimonoInspectorAttachedStyle</a> AttachedStyleInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>AttachedStyleInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorAttachedStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55e168d1-e454-4894-89cf-b66c7f18412e'>BackButton</a></td><td style='width:75%' class='def'><p><a name="55e168d1-e454-4894-89cf-b66c7f18412e"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> BackButton</h3>

<h4>Summary</h4>

<p>The private read only <code>BackButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7197641-e87f-41b9-b014-9484ddac3152'>BorderInspectorsButton</a></td><td style='width:75%' ><p><a name="e7197641-e87f-41b9-b014-9484ddac3152"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> BorderInspectorsButton</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>BorderInspectorsButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5220edf-09e2-45a5-8dbc-4cb297b42501'>ColorList</a></td><td style='width:75%' class='def'><p><a name="d5220edf-09e2-45a5-8dbc-4cb297b42501"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> ColorList</h3>

<h4>Summary</h4>

<p>Gets or sets the sidebar color list.</p>

<h4>Return Value</h4>

<p>The color list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a435205a-2814-4c55-8181-44e51b965f84'>ColorPaletteInspector</a></td><td style='width:75%' ><p><a name="a435205a-2814-4c55-8181-44e51b965f84"></a></p>

<h3>Private Read Only <a href="#dfdcb93f-6d98-4469-848e-4ed5b1fa6162">KimonoMac.KimonoInspectorPaleteColor</a> ColorPaletteInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>ColorPaletteInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPaleteColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75776113-9855-48c0-bebc-fa84722843f0'>ConnectionInspectorsButton</a></td><td style='width:75%' class='def'><p><a name="75776113-9855-48c0-bebc-fa84722843f0"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ConnectionInspectorsButton</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>ConnectionInspectorsButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98ddea49-14a1-458b-8976-59af4e4bb566'>CurrentInspectorMode</a></td><td style='width:75%' ><p><a name="98ddea49-14a1-458b-8976-59af4e4bb566"></a></p>

<h3>Public <a href="#c44d4017-143a-4222-a7ea-515fa98aa272">KimonoMac.InspectorViewMode</a> CurrentInspectorMode</h3>

<h4>Summary</h4>

<p>Gets or sets the inspector view mode.</p>

<h4>Return Value</h4>

<p>The <code>InspectorViewMode</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9674a12a-9ee6-4323-a857-52cf14de5ada'>DefaultLanguage</a></td><td style='width:75%' class='def'><p><a name="9674a12a-9ee6-4323-a857-52cf14de5ada"></a></p>

<h3>Public <code>System.Int32</code> DefaultLanguage</h3>

<h4>Summary</h4>

<p>Gets or sets the default language that this <code>ViewController</code> will be editing.</p>

<h4>Return Value</h4>

<p>An integer representing the default language as: 0 - C#, 1 - HTML, 2 - MarkDown, 3 - XML.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#265cf0b6-4a00-4e2e-b4a1-5dc4bc1a54d4'>DesignSurface</a></td><td style='width:75%' ><p><a name="265cf0b6-4a00-4e2e-b4a1-5dc4bc1a54d4"></a></p>

<h3>Private Read Only <code>KimonoCore.Mac.KimonoDesignSurface</code> DesignSurface</h3>

<h4>Summary</h4>

<p>The private read only <code>DesignSurface</code> property of the <code>ViewController</code> class has a <code>KimonoCore.Mac.KimonoDesignSurface</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ce1ec02-3003-40e7-beab-9cf9028d20fe'>DetailsInspectorButton</a></td><td style='width:75%' class='def'><p><a name="2ce1ec02-3003-40e7-beab-9cf9028d20fe"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> DetailsInspectorButton</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>DetailsInspectorButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d48a842c-402b-4b3e-baa8-c63da9d2e6e4'>DocumentEdited</a></td><td style='width:75%' ><p><a name="d48a842c-402b-4b3e-baa8-c63da9d2e6e4"></a></p>

<h3>Public <code>System.Boolean</code> DocumentEdited</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <code>ViewController</code> document  has been edited.</p>

<h4>Return Value</h4>

<p><code>true</code> if document has been edited; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16e43712-a279-48b6-8087-c8342dd6c5a1'>DocumentScrollView</a></td><td style='width:75%' class='def'><p><a name="16e43712-a279-48b6-8087-c8342dd6c5a1"></a></p>

<h3>Private Read Only <code>AppKit.NSScrollView</code> DocumentScrollView</h3>

<h4>Summary</h4>

<p>The private read only <code>DocumentScrollView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSScrollView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2da6d0da-7415-4c8a-a4e7-9ecf412d0945'>DocumentView</a></td><td style='width:75%' ><p><a name="2da6d0da-7415-4c8a-a4e7-9ecf412d0945"></a></p>

<h3>Private Read Only <code>AppKit.NSView</code> DocumentView</h3>

<h4>Summary</h4>

<p>The private read only <code>DocumentView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3994fa23-21e7-4956-b1fa-6fe95883a7fe'>DocumentViewHeight</a></td><td style='width:75%' class='def'><p><a name="3994fa23-21e7-4956-b1fa-6fe95883a7fe"></a></p>

<h3>Private Read Only <code>AppKit.NSLayoutConstraint</code> DocumentViewHeight</h3>

<h4>Summary</h4>

<p>The private read only <code>DocumentViewHeight</code> property of the <code>ViewController</code> class has a <code>AppKit.NSLayoutConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f934d600-b016-4c51-9ba5-a4cd22b87d42'>DocumentViewWidth</a></td><td style='width:75%' ><p><a name="f934d600-b016-4c51-9ba5-a4cd22b87d42"></a></p>

<h3>Private Read Only <code>AppKit.NSLayoutConstraint</code> DocumentViewWidth</h3>

<h4>Summary</h4>

<p>The private read only <code>DocumentViewWidth</code> property of the <code>ViewController</code> class has a <code>AppKit.NSLayoutConstraint</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23d8532e-5b0a-4054-9bd3-d2c6b1ced39b'>EditingProperty</a></td><td style='width:75%' class='def'><p><a name="23d8532e-5b0a-4054-9bd3-d2c6b1ced39b"></a></p>

<h3>Public <code>KimonoCore.KimonoProperty</code> EditingProperty</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoProperty</code> currently being edited.</p>

<h4>Return Value</h4>

<p>The editing property.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39ebe9c8-c5c9-4cde-ac70-81d5713dc66c'>Editor</a></td><td style='width:75%' ><p><a name="39ebe9c8-c5c9-4cde-ac70-81d5713dc66c"></a></p>

<h3>Public Read Only <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">AppKit.TextKit.Formatter.SourceTextView</a> Editor</h3>

<h4>Summary</h4>

<p>Gets the <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> attached to this view.</p>

<h4>Return Value</h4>

<p>The <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">SourceTextView</a> used to edit source.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f854206e-9f74-4428-a8c1-50b10bd2dfb7'>FilePath</a></td><td style='width:75%' class='def'><p><a name="f854206e-9f74-4428-a8c1-50b10bd2dfb7"></a></p>

<h3>Public <code>System.String</code> FilePath</h3>

<h4>Summary</h4>

<p>Gets or sets the full file path where this document was last loaded from or saved to.</p>

<h4>Return Value</h4>

<p>The file path.</p>

<h4>Remarks</h4>

<p>&gt;The path will be the empty string ("") if the document has never been saved to a file.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#333554ec-11e8-4646-b0c8-913596f0d696'>FillInspector</a></td><td style='width:75%' ><p><a name="333554ec-11e8-4646-b0c8-913596f0d696"></a></p>

<h3>Private Read Only <a href="#27afbed2-1709-4abb-84f6-c68238b78cd4">KimonoMac.KimonoInspectorFill</a> FillInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>FillInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFill</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7685f9cf-91c7-44cb-ba98-6350192f8a9c'>FillInspectorsButton</a></td><td style='width:75%' class='def'><p><a name="7685f9cf-91c7-44cb-ba98-6350192f8a9c"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> FillInspectorsButton</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>FillInspectorsButton</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8591355d-0aef-43eb-b349-e140226c813e'>FontInspector</a></td><td style='width:75%' ><p><a name="8591355d-0aef-43eb-b349-e140226c813e"></a></p>

<h3>Private Read Only <a href="#e6607c64-f369-46da-b148-c5162d80ca70">KimonoMac.KimonoInspectorFont</a> FontInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>FontInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFont</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe0321c5-88a3-4744-828f-6cfa157ad483'>Formatter</a></td><td style='width:75%' class='def'><p><a name="fe0321c5-88a3-4744-828f-6cfa157ad483"></a></p>

<h3>Public <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">AppKit.TextKit.Formatter.LanguageFormatter</a> Formatter</h3>

<h4>Summary</h4>

<p>Gets or sets the <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> used to perform syntax highlighting on the <code>NSTextView</code> containing the contents of the document being edited.</p>

<h4>Return Value</h4>

<p>The <a href="#13e07d7b-7947-4461-812d-5c2aafa2ebee">LanguageFormatter</a> for the selected language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c68b8cdb-6083-48a1-b5f5-187b4c4e4cb6'>FrameInspector</a></td><td style='width:75%' ><p><a name="c68b8cdb-6083-48a1-b5f5-187b4c4e4cb6"></a></p>

<h3>Private Read Only <a href="#3d13d593-a78a-46f8-bd30-1f88ffbbc239">KimonoMac.KimonoInspectorFrame</a> FrameInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>FrameInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorFrame</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d9d415a-f027-4364-8695-786d472e96ba'>GeneralInfoInspector</a></td><td style='width:75%' class='def'><p><a name="0d9d415a-f027-4364-8695-786d472e96ba"></a></p>

<h3>Private Read Only <a href="#a11c2de0-ef79-4a59-ae37-0c8806453775">KimonoMac.KimonoInspectorGeneralInfo</a> GeneralInfoInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>GeneralInfoInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGeneralInfo</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00683239-1aa6-48c3-94ee-dd6b8386083e'>GenerateLanguageCode</a></td><td style='width:75%' ><p><a name="00683239-1aa6-48c3-94ee-dd6b8386083e"></a></p>

<h3>Public <code>KimonoCore.CodeOutputLanguage</code> GenerateLanguageCode</h3>

<h4>Summary</h4>

<p>Gets or sets the language code will be generated in.</p>

<h4>Return Value</h4>

<p>The code language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c11a42a3-314f-448e-998f-7b60ee2f3384'>GenerateLibraryCode</a></td><td style='width:75%' class='def'><p><a name="c11a42a3-314f-448e-998f-7b60ee2f3384"></a></p>

<h3>Public <code>KimonoCore.CodeOutputLibrary</code> GenerateLibraryCode</h3>

<h4>Summary</h4>

<p>Gets or sets the library the generated code will use.</p>

<h4>Return Value</h4>

<p>The library to use in the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd36df43-7bde-413a-b0b7-736c03ac28d9'>GenerateOSCode</a></td><td style='width:75%' ><p><a name="fd36df43-7bde-413a-b0b7-736c03ac28d9"></a></p>

<h3>Public <code>KimonoCore.CodeOutputOS</code> GenerateOSCode</h3>

<h4>Summary</h4>

<p>Gets or sets the OS that code will be generated for.</p>

<h4>Return Value</h4>

<p>The OS code type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e681c3c-a78c-4b26-8b2d-b986b533c936'>GradientInspector</a></td><td style='width:75%' class='def'><p><a name="9e681c3c-a78c-4b26-8b2d-b986b533c936"></a></p>

<h3>Private Read Only <a href="#d5064eca-591d-4f74-bf35-da5f7fbdbb3b">KimonoMac.KimonoInspectorGradient</a> GradientInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>GradientInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0be3e68-a34f-4aa0-899e-3e22751ba028'>GradientList</a></td><td style='width:75%' ><p><a name="d0be3e68-a34f-4aa0-899e-3e22751ba028"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> GradientList</h3>

<h4>Summary</h4>

<p>Gets or sets the gradient list.</p>

<h4>Return Value</h4>

<p>The gradient list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb2cf70e-397d-4810-885d-3e2688ccc97f'>GroupInspector</a></td><td style='width:75%' class='def'><p><a name="bb2cf70e-397d-4810-885d-3e2688ccc97f"></a></p>

<h3>Private Read Only <a href="#89f7f09f-b964-460f-befa-9ffb6694b7ea">KimonoMac.KimonoInspectorGroup</a> GroupInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>GroupInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorGroup</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a9b91ad-fd4c-4451-9e41-80834256dc1c'>InspectorScrollView</a></td><td style='width:75%' ><p><a name="9a9b91ad-fd4c-4451-9e41-80834256dc1c"></a></p>

<h3>Private Read Only <code>AppKit.NSScrollView</code> InspectorScrollView</h3>

<h4>Summary</h4>

<p>The private read only <code>InspectorScrollView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSScrollView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a37197b8-57ac-4d00-b8f4-06d5ad962abc'>InspectorView</a></td><td style='width:75%' class='def'><p><a name="a37197b8-57ac-4d00-b8f4-06d5ad962abc"></a></p>

<h3>Private Read Only <code>AppKit.NSView</code> InspectorView</h3>

<h4>Summary</h4>

<p>The private read only <code>InspectorView</code> property of the <code>ViewController</code> class has a <code>AppKit.NSView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddfccd8b-e5b0-419f-81d1-6564423bb551'>Keyword</a></td><td style='width:75%' ><p><a name="ddfccd8b-e5b0-419f-81d1-6564423bb551"></a></p>

<h3>Public <code>System.String</code> Keyword</h3>

<h4>Summary</h4>

<p>Gets or sets the keyword that is currently selected.</p>

<h4>Return Value</h4>

<p>The keyword.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#852b3ab0-0579-40dd-a3ea-7501549f40ee'>KeywordInfo</a></td><td style='width:75%' class='def'><p><a name="852b3ab0-0579-40dd-a3ea-7501549f40ee"></a></p>

<h3>Public <a href="#56094def-ccde-45a2-987f-18730526fdc6">AppKit.TextKit.Formatter.KeywordDescriptor</a> KeywordInfo</h3>

<h4>Summary</h4>

<p>Gets or sets the info about the currently selected keyword.</p>

<h4>Return Value</h4>

<p>The keyword info.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1a07a75-216c-492c-b470-b21a69e72b34'>KimonoPreviewElement</a></td><td style='width:75%' ><p><a name="a1a07a75-216c-492c-b470-b21a69e72b34"></a></p>

<h3>Public <code>KimonoCore.IKimonoCodeGeneration</code> KimonoPreviewElement</h3>

<h4>Summary</h4>

<p>Gets or sets the Kimono object that preview code is currently being generated for.</p>

<h4>Return Value</h4>

<p>The kimono preview element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebf7e603-8f3b-4ddc-8814-5848b55a9b3d'>LanguageSelector</a></td><td style='width:75%' class='def'><p><a name="ebf7e603-8f3b-4ddc-8814-5848b55a9b3d"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LanguageSelector</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>LanguageSelector</code> property of the <code>ViewController</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#043d474a-efc3-4018-a971-38d813eacb41'>LibrarySelector</a></td><td style='width:75%' ><p><a name="043d474a-efc3-4018-a971-38d813eacb41"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> LibrarySelector</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>LibrarySelector</code> property of the <code>ViewController</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a789cc48-3230-4828-afda-a344c7c950f7'>OSSelector</a></td><td style='width:75%' class='def'><p><a name="a789cc48-3230-4828-afda-a344c7c950f7"></a></p>

<h3>Private Read Only <code>AppKit.NSPopUpButton</code> OSSelector</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>OSSelector</code> property of the <code>ViewController</code> class has a <code>AppKit.NSPopUpButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dfe7760-02f6-4118-bccb-6e1fc54c3565'>PolygonInspector</a></td><td style='width:75%' ><p><a name="5dfe7760-02f6-4118-bccb-6e1fc54c3565"></a></p>

<h3>Private Read Only <a href="#9c3f18a9-b56a-4496-9b51-819aca1bd975">KimonoMac.KimonoInspectorPolygon</a> PolygonInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>PolygonInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPolygon</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8979e0ab-6b8d-4b5e-b010-f269ccfe2e5a'>PortfolioInspector</a></td><td style='width:75%' class='def'><p><a name="8979e0ab-6b8d-4b5e-b010-f269ccfe2e5a"></a></p>

<h3>Private Read Only <a href="#7de844b6-6c5e-493c-b1f4-f105188b1fcb">KimonoMac.KimonoInspectorPortfolio</a> PortfolioInspector</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>PortfolioInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorPortfolio</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74160260-5fc8-456e-975f-4bc2cb03e6a4'>ProjectList</a></td><td style='width:75%' ><p><a name="74160260-5fc8-456e-975f-4bc2cb03e6a4"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> ProjectList</h3>

<h4>Summary</h4>

<p>Gets or sets the sidebar project list.</p>

<h4>Return Value</h4>

<p>The project list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#533eb706-c61d-4f5a-93a5-b7107c4211c4'>PropertyInspector</a></td><td style='width:75%' class='def'><p><a name="533eb706-c61d-4f5a-93a5-b7107c4211c4"></a></p>

<h3>Private Read Only <a href="#14cd9500-d1e0-481d-a895-2ffb36c33290">KimonoMac.KimonoInspectorProperty</a> PropertyInspector</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>PropertyInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorProperty</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5c3bd34-e32d-4987-a61f-09b581b9edb9'>PropertyList</a></td><td style='width:75%' ><p><a name="f5c3bd34-e32d-4987-a61f-09b581b9edb9"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> PropertyList</h3>

<h4>Summary</h4>

<p>Gets or sets the property list.</p>

<h4>Return Value</h4>

<p>The property list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#537ce53e-b014-4712-9d29-f092f9ee00c2'>RoundRectInspector</a></td><td style='width:75%' class='def'><p><a name="537ce53e-b014-4712-9d29-f092f9ee00c2"></a></p>

<h3>Private Read Only <a href="#a76afe10-8f40-4938-8f3c-dd0362d71d1f">KimonoMac.KimonoInspectorRoundRect</a> RoundRectInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>RoundRectInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorRoundRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b058af1f-3a66-4cad-ac6c-cd323329de82'>ShapesList</a></td><td style='width:75%' ><p><a name="b058af1f-3a66-4cad-ac6c-cd323329de82"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> ShapesList</h3>

<h4>Summary</h4>

<p>Gets or sets the sidebar shapes list.</p>

<h4>Return Value</h4>

<p>The shapes list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdbc9d0d-a841-4037-af07-804e2e01386f'>SketchesList</a></td><td style='width:75%' class='def'><p><a name="bdbc9d0d-a841-4037-af07-804e2e01386f"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> SketchesList</h3>

<h4>Summary</h4>

<p>Gets or sets the sidebar sketches list.</p>

<h4>Return Value</h4>

<p>The sketches list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f5567c9-33ba-4c16-b318-fba2f761506d'>SketchInspector</a></td><td style='width:75%' ><p><a name="8f5567c9-33ba-4c16-b318-fba2f761506d"></a></p>

<h3>Private Read Only <a href="#29b077d2-fa1f-4b59-b9c3-22ef34f57c59">KimonoMac.KimonoInspectorSketch</a> SketchInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>SketchInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorSketch</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12149a66-758e-4946-9061-1f7ed1000eac'>SketchPath</a></td><td style='width:75%' class='def'><p><a name="12149a66-758e-4946-9061-1f7ed1000eac"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> SketchPath</h3>

<h4>Summary</h4>

<p>The private read only <code>SketchPath</code> property of the <code>ViewController</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db064f6b-e295-4757-9db0-a2653f01f23d'>SourceList</a></td><td style='width:75%' ><p><a name="db064f6b-e295-4757-9db0-a2653f01f23d"></a></p>

<h3>Private Read Only <a href="#beadeded-5081-43aa-bf9a-5df81248d624">KimonoMac.SourceListView</a> SourceList</h3>

<h4>Summary</h4>

<p>The private read only <code>SourceList</code> property of the <code>ViewController</code> class has a <code>KimonoMac.SourceListView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d82eaa6-0c82-4b15-838e-e1b19f06ea55'>StarInspector</a></td><td style='width:75%' class='def'><p><a name="3d82eaa6-0c82-4b15-838e-e1b19f06ea55"></a></p>

<h3>Private Read Only <a href="#344b8c16-cdc9-4606-af9b-9b672d043928">KimonoMac.KimonoInspectorStar</a> StarInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>StarInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorStar</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e6aa787-7c9c-4a82-a021-94119e394fb8'>StyleInspector</a></td><td style='width:75%' ><p><a name="2e6aa787-7c9c-4a82-a021-94119e394fb8"></a></p>

<h3>Private Read Only <a href="#37b475d3-ffd4-4d9e-a559-3bad08bf9b0c">KimonoMac.KimonoInspectorStyle</a> StyleInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>StyleInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c53bb142-9f15-4b8c-bfc7-e7eba1138d32'>StyleList</a></td><td style='width:75%' class='def'><p><a name="c53bb142-9f15-4b8c-bfc7-e7eba1138d32"></a></p>

<h3>Public <a href="#1b5b42ef-47c3-4693-8ecf-e4323efed742">KimonoMac.SourceListItem</a> StyleList</h3>

<h4>Summary</h4>

<p>Gets or sets the sidebar style list.</p>

<h4>Return Value</h4>

<p>The style list.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50ed1c61-190b-43a1-a016-229d4b78d55a'>Text</a></td><td style='width:75%' ><p><a name="50ed1c61-190b-43a1-a016-229d4b78d55a"></a></p>

<h3>Public <code>System.String</code> Text</h3>

<h4>Summary</h4>

<p>Gets or sets the text for the <code>NSTextView</code> being used as a text editor</p>

<h4>Return Value</h4>

<p>The string content of the <code>NSTextView</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d05af14-7be7-4cc2-986f-d30a8a76dbd5'>TextEditor</a></td><td style='width:75%' class='def'><p><a name="6d05af14-7be7-4cc2-986f-d30a8a76dbd5"></a></p>

<h3>Private Read Only <a href="#693e63b3-83a6-43a9-ac2a-7b8fc3474e13">AppKit.TextKit.Formatter.SourceTextView</a> TextEditor</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>TextEditor</code> property of the <code>ViewController</code> class has a <code>AppKit.TextKit.Formatter.SourceTextView</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3f5ae16-c3c5-4acf-bcde-6887e087acb3'>TextEditorMode</a></td><td style='width:75%' ><p><a name="c3f5ae16-c3c5-4acf-bcde-6887e087acb3"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> TextEditorMode</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>TextEditorMode</code> property of the <code>ViewController</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bd3d044-3af4-4f92-bd3c-91851f3fd77e'>TextEditorTitle</a></td><td style='width:75%' class='def'><p><a name="8bd3d044-3af4-4f92-bd3c-91851f3fd77e"></a></p>

<h3>Private Read Only <code>AppKit.NSTextField</code> TextEditorTitle</h3>

<h4>Added In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>The private read only <code>TextEditorTitle</code> property of the <code>ViewController</code> class has a <code>AppKit.NSTextField</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e93f3643-ead8-4fbf-8ecf-54fc4236bf32'>TextInspector</a></td><td style='width:75%' ><p><a name="e93f3643-ead8-4fbf-8ecf-54fc4236bf32"></a></p>

<h3>Private Read Only <a href="#d6667936-a83f-4ed0-b092-62db0b6cab71">KimonoMac.KimonoInspectorText</a> TextInspector</h3>

<h4>Summary</h4>

<p>The private read only <code>TextInspector</code> property of the <code>ViewController</code> class has a <code>KimonoMac.KimonoInspectorText</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78a1831f-86a2-48a4-be50-0318acf327d8'>ToolArrow</a></td><td style='width:75%' class='def'><p><a name="78a1831f-86a2-48a4-be50-0318acf327d8"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolArrow</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolArrow</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b37447c5-bcae-4633-a6a2-d8a14930eea0'>ToolBezier</a></td><td style='width:75%' ><p><a name="b37447c5-bcae-4633-a6a2-d8a14930eea0"></a></p>

<h3>Private Read Only <code>AppKit.NSButtonCell</code> ToolBezier</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolBezier</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButtonCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a3d16d8-88cd-4580-821c-1da503069b4e'>ToolCursor</a></td><td style='width:75%' class='def'><p><a name="1a3d16d8-88cd-4580-821c-1da503069b4e"></a></p>

<h3>Private Read Only <code>AppKit.NSButtonCell</code> ToolCursor</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolCursor</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButtonCell</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9133b98b-5fe9-4bf8-89df-4d0b7bcea7f4'>ToolLine</a></td><td style='width:75%' ><p><a name="9133b98b-5fe9-4bf8-89df-4d0b7bcea7f4"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolLine</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolLine</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97029ec0-25c1-4216-a5b6-4dde2e353b30'>ToolOval</a></td><td style='width:75%' class='def'><p><a name="97029ec0-25c1-4216-a5b6-4dde2e353b30"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolOval</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolOval</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc2a3fc9-8661-46f9-8838-1ec06a6c7e9c'>ToolPolygon</a></td><td style='width:75%' ><p><a name="cc2a3fc9-8661-46f9-8838-1ec06a6c7e9c"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolPolygon</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolPolygon</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e5e08f5-74c9-4c5f-8356-d56fa942a760'>ToolRect</a></td><td style='width:75%' class='def'><p><a name="0e5e08f5-74c9-4c5f-8356-d56fa942a760"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolRect</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolRect</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c753b97-c557-4724-9969-bf9fc88cac32'>ToolRoundRect</a></td><td style='width:75%' ><p><a name="4c753b97-c557-4724-9969-bf9fc88cac32"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolRoundRect</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolRoundRect</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25273c6e-0561-4b17-97c1-f4b78e993002'>ToolStar</a></td><td style='width:75%' class='def'><p><a name="25273c6e-0561-4b17-97c1-f4b78e993002"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolStar</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolStar</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#785f6670-a5e1-4e2e-87e0-eead3aa93350'>ToolText</a></td><td style='width:75%' ><p><a name="785f6670-a5e1-4e2e-87e0-eead3aa93350"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolText</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolText</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb631388-15cd-4189-ab53-17e824ee27e0'>ToolTriangle</a></td><td style='width:75%' class='def'><p><a name="fb631388-15cd-4189-ab53-17e824ee27e0"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolTriangle</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolTriangle</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a613e30c-ae3a-4616-9ef1-f35e70984e5a'>ToolVector</a></td><td style='width:75%' ><p><a name="a613e30c-ae3a-4616-9ef1-f35e70984e5a"></a></p>

<h3>Private Read Only <code>AppKit.NSButton</code> ToolVector</h3>

<h4>Summary</h4>

<p>The private read only <code>ToolVector</code> property of the <code>ViewController</code> class has a <code>AppKit.NSButton</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12c27b4b-524c-4ef5-a456-511c209434db'>WindowController</a></td><td style='width:75%' class='def'><p><a name="12c27b4b-524c-4ef5-a456-511c209434db"></a></p>

<h3>Public Read Only <a href="#b9881a15-c33c-4bf5-8606-4829f8293008">KimonoMac.MainWindowController</a> WindowController</h3>

<h4>Summary</h4>

<p>Gets the window controller.</p>

<h4>Return Value</h4>

<p>The window controller.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c9ef3160-32c4-4c03-bdfb-6426463454f3'>AddNewColor</a></td><td style='width:75%' ><p><a name="c9ef3160-32c4-4c03-bdfb-6426463454f3"></a></p>

<h3>Public Void AddNewColor ()</h3>

<h4>Summary</h4>

<p>Adds a new <code>KimonoSketch</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eee5d46-1d72-412c-97bc-0bf02e735b27'>AddNewColor</a></td><td style='width:75%' class='def'><p><a name="8eee5d46-1d72-412c-97bc-0bf02e735b27"></a></p>

<h3>Public Void AddNewColor (SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> based off of the given <code>SKColor</code> to the <code>KimonoPortfolio</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="f6961ebe-824e-422c-b94c-a832274c828c"></a>
<b>SkiaSharp.SKColor baseColor</b></p>

<p>The base <code>SKColor</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#261752d7-3f77-46de-9af7-7b531a02bf97'>AddNewGradient</a></td><td style='width:75%' ><p><a name="261752d7-3f77-46de-9af7-7b531a02bf97"></a></p>

<h3>Public Void AddNewGradient ()</h3>

<h4>Summary</h4>

<p>Adds the new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2b9952b-3af5-45ad-b413-0138c77fe79f'>AddNewSketch</a></td><td style='width:75%' class='def'><p><a name="d2b9952b-3af5-45ad-b413-0138c77fe79f"></a></p>

<h3>Public Void AddNewSketch ()</h3>

<h4>Summary</h4>

<p>Adds a new <code>KimonoSketch</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbde146b-85b2-4192-aff2-079698a258ce'>AddNewStyle</a></td><td style='width:75%' ><p><a name="cbde146b-85b2-4192-aff2-079698a258ce"></a></p>

<h3>Public Void AddNewStyle ()</h3>

<h4>Summary</h4>

<p>Adds a new <code>KimonoStyle</code> to the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ff2bc91-fd6c-4ef3-af42-39694d5f9435'>AddPropertyBoolean</a></td><td style='width:75%' class='def'><p><a name="4ff2bc91-fd6c-4ef3-af42-39694d5f9435"></a></p>

<h3>Public Void AddPropertyBoolean (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the property boolean.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="c6f189fa-48d4-4c32-a8aa-864a882d6845"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfdd0e7f-985d-470b-8e4d-47fd9692b506'>AddPropertyColor</a></td><td style='width:75%' ><p><a name="dfdd0e7f-985d-470b-8e4d-47fd9692b506"></a></p>

<h3>Public Void AddPropertyColor (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the color of the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b9e63928-fb44-4825-93cd-b2569dbaaef7"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44000ab8-6be4-4187-8a6a-6ae01f2be1a4'>AddPropertyGradient</a></td><td style='width:75%' class='def'><p><a name="44000ab8-6be4-4187-8a6a-6ae01f2be1a4"></a></p>

<h3>Public Void AddPropertyGradient (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the property gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="39471d03-5b52-45ff-95fa-826c8b16a058"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21cde4e0-e33a-43c4-97ad-75ab257cd1a0'>AddPropertyNumber</a></td><td style='width:75%' ><p><a name="21cde4e0-e33a-43c4-97ad-75ab257cd1a0"></a></p>

<h3>Public Void AddPropertyNumber (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the property number.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0d25e4e5-3839-4097-bdec-294da2ec4b45"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7419ea8-d40e-4a34-bcfc-08b83239a226'>AddPropertyRect</a></td><td style='width:75%' class='def'><p><a name="e7419ea8-d40e-4a34-bcfc-08b83239a226"></a></p>

<h3>Public Void AddPropertyRect (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the property rect.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3fe83759-77c5-40b9-abc0-c4a9708e97f0"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac12d169-9df1-4885-aa80-5ee18ca98f80'>AddPropertyStyle</a></td><td style='width:75%' ><p><a name="ac12d169-9df1-4885-aa80-5ee18ca98f80"></a></p>

<h3>Public Void AddPropertyStyle (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the property style.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e68ed92c-b444-4847-9d88-eb6fd783cecb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6de6db41-5f12-4567-9e00-745422163577'>AddPropertyText</a></td><td style='width:75%' class='def'><p><a name="6de6db41-5f12-4567-9e00-745422163577"></a></p>

<h3>Public Void AddPropertyText (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Adds the property text.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e012ebc1-c65e-4a6d-85e4-19e4f56ae52b"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46f2a2c6-11e0-47e3-9e3e-ae55a322983f'>AlignShapeBottom</a></td><td style='width:75%' ><p><a name="46f2a2c6-11e0-47e3-9e3e-ae55a322983f"></a></p>

<h3>Public Void AlignShapeBottom (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape bottoms.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9cbe3b90-a5e9-4951-893f-476c85ee2ee4"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23b379a4-7538-4356-8ae9-690c7d4059ba'>AlignShapeCenter</a></td><td style='width:75%' class='def'><p><a name="23b379a4-7538-4356-8ae9-690c7d4059ba"></a></p>

<h3>Public Void AlignShapeCenter (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape centers.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="310738a0-dd36-4a92-97c8-551d0fa4ecd1"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96b6a5e2-03fa-4bb0-84c3-3460a68c905b'>AlignShapeCenterHorizontal</a></td><td style='width:75%' ><p><a name="96b6a5e2-03fa-4bb0-84c3-3460a68c905b"></a></p>

<h3>Public Void AlignShapeCenterHorizontal (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape centers horizontally.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9e49ca5c-84a6-49cd-9162-85501d795b9a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7392e52b-6d80-42b8-a8d9-cb9e1d0d1cfa'>AlignShapeCenterVertical</a></td><td style='width:75%' class='def'><p><a name="7392e52b-6d80-42b8-a8d9-cb9e1d0d1cfa"></a></p>

<h3>Public Void AlignShapeCenterVertical (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape centers vertically.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="f0126e47-7de3-4a94-9000-796ee3e08420"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ecaf28c-d69b-44b4-b028-c4bb4b84d5ba'>AlignShapeLeft</a></td><td style='width:75%' ><p><a name="0ecaf28c-d69b-44b4-b028-c4bb4b84d5ba"></a></p>

<h3>Public Void AlignShapeLeft (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape left sides.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="064b20f2-8cbc-4793-b1b2-9671b17e3c38"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f7e20de-f8b5-4e8f-a595-36a8da527653'>AlignShapeRight</a></td><td style='width:75%' class='def'><p><a name="1f7e20de-f8b5-4e8f-a595-36a8da527653"></a></p>

<h3>Public Void AlignShapeRight (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape right sides.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="5102b5c7-09f1-47ae-96f4-70cd5e9d184c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e6b246f-dd56-44fc-b6b5-49f8d5e6d746'>AlignShapeTop</a></td><td style='width:75%' ><p><a name="0e6b246f-dd56-44fc-b6b5-49f8d5e6d746"></a></p>

<h3>Public Void AlignShapeTop (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Aligns the shape tops.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2d42d775-ed1c-4d31-8d06-784c9b5a550d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98f2a2f7-9fe7-49b6-90ce-1d8344bbcd7f'>CloseAllInspectors</a></td><td style='width:75%' class='def'><p><a name="98f2a2f7-9fe7-49b6-90ce-1d8344bbcd7f"></a></p>

<h3>Private Void CloseAllInspectors ()</h3>

<h4>Summary</h4>

<p>Closes all open inspectors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80a4f18b-2b0e-4094-beb9-1e03c5a8392c'>ConfigureEditor</a></td><td style='width:75%' ><p><a name="80a4f18b-2b0e-4094-beb9-1e03c5a8392c"></a></p>

<h3>Public Void ConfigureEditor ()</h3>

<h4>Summary</h4>

<p>Configures the editor with the current user preferences.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a8b7f0e-d92c-4df8-9863-bf6256fb5dbe'>DeleteColor</a></td><td style='width:75%' class='def'><p><a name="1a8b7f0e-d92c-4df8-9863-bf6256fb5dbe"></a></p>

<h3>Public Void DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from the <code>KimonoPortfolio</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="e6273f06-b9f7-4631-907f-4c76500cfe0a"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfd6c215-00a2-4646-a979-927b90d8f1e4'>DeleteGradient</a></td><td style='width:75%' ><p><a name="cfd6c215-00a2-4646-a979-927b90d8f1e4"></a></p>

<h3>Public Void DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Deletes the given gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="c186dbe8-288c-4dac-9fbb-e0442e9ed3ff"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37158f78-77d1-4fc9-ab08-fb96e730026e'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="37158f78-77d1-4fc9-ab08-fb96e730026e"></a></p>

<h3>Public Void DeleteSelectedShape (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="182517c1-de7a-410e-88dc-346e7c1e9f3a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf7f144b-3270-4590-b3b7-9325d93a1078'>DeleteStyle</a></td><td style='width:75%' ><p><a name="bf7f144b-3270-4590-b3b7-9325d93a1078"></a></p>

<h3>Public Void DeleteStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoStyle</code> from the <code>KimonoPortfolio</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="2bc5300a-82fc-4e67-b4db-2fd417841190"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fccc204-770f-4c8c-b1e6-ea0ec8a61b4e'>DuplicateColor</a></td><td style='width:75%' class='def'><p><a name="1fccc204-770f-4c8c-b1e6-ea0ec8a61b4e"></a></p>

<h3>Public Void DuplicateColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoColor</code> and adds it to <code>KimonoPortfolio</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="bc42494e-5a9b-4b31-8c56-abc3cdfe26a0"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7d5838b-424c-48b0-a215-1f4a7ef80406'>DuplicateGradient</a></td><td style='width:75%' ><p><a name="e7d5838b-424c-48b0-a215-1f4a7ef80406"></a></p>

<h3>Public Void DuplicateGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Duplicates the given gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="52ad5856-28c4-4e99-8cb6-78ab8860b4ab"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69b6abe0-f7d2-4e1d-8134-5f17b9c233ee'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="69b6abe0-f7d2-4e1d-8134-5f17b9c233ee"></a></p>

<h3>Public Void DuplicateSelectedShape (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ee054af5-56d3-4eb1-a1af-caefcf2a005c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ea05891-58b2-4d35-868c-e80f2a8731c1'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="8ea05891-58b2-4d35-868c-e80f2a8731c1"></a></p>

<h3>Public Void DuplicateStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoStyle</code> in the <code>KimonoPortfolio</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="1f7146b0-1f2a-4deb-b52a-1b4f030c2821"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba2609a3-660c-4440-aa20-42d954db4d23'>GoBackToSketch</a></td><td style='width:75%' class='def'><p><a name="ba2609a3-660c-4440-aa20-42d954db4d23"></a></p>

<h3>Private Void GoBackToSketch (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Goes the back to sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7897788e-40e1-4909-a23e-0d560c84a7b2"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a0409bb-0f81-4b15-86d3-da9ad6cd0426'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p><a name="0a0409bb-0f81-4b15-86d3-da9ad6cd0426"></a></p>

<h3>Public Void GroupUngroupSelectedShapes (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0d6342f8-9f6d-429f-8341-7b7671a477a9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#329d7b91-0a51-41d6-8a02-ac2d0b5cf751'>HighlightTool</a></td><td style='width:75%' class='def'><p><a name="329d7b91-0a51-41d6-8a02-ac2d0b5cf751"></a></p>

<h3>Private Void HighlightTool (KimonoCore.KimonoTool)</h3>

<h4>Summary</h4>

<p>Highlights the currently selected <code>KimonoTool</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="5a442630-75bc-482b-a1b7-f7eafe9940aa"></a>
<b>KimonoCore.KimonoTool tool</b></p>

<p>The <code>KimonoTool</code> to highlight.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ca47852-2ff9-4616-8279-54da34a90caa'>InitializeInspectors</a></td><td style='width:75%' ><p><a name="7ca47852-2ff9-4616-8279-54da34a90caa"></a></p>

<h3>Private Void InitializeInspectors ()</h3>

<h4>Summary</h4>

<p>Initializes the inspectors that allow the user to configure all of the elements in the <code>KimonoPortfolio</code> that is currently being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cce9385c-ef7e-4fff-b822-f025267e6a75'>LanguageSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="cce9385c-ef7e-4fff-b822-f025267e6a75"></a></p>

<h3>Private Void LanguageSelectionChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handle the language selection changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="85e9cd9d-5d33-4ac2-a8bc-c21b08ace0ef"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c84692a8-310b-4c44-97cc-20916e2d51a1'>LibrarySelectionChanged</a></td><td style='width:75%' ><p><a name="c84692a8-310b-4c44-97cc-20916e2d51a1"></a></p>

<h3>Private Void LibrarySelectionChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handles the library selection changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ea6065c5-cab2-4727-bc16-8fe91a277d04"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3934b0c5-51ed-4179-9d24-1b22b6cbaf2d'>MoveBackwards</a></td><td style='width:75%' class='def'><p><a name="3934b0c5-51ed-4179-9d24-1b22b6cbaf2d"></a></p>

<h3>Public Void MoveBackwards (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="56be8aa2-a7d0-4508-aee2-5c1f419a4e6c"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea892458-c25f-4153-8a8b-d7d5077e6d03'>MoveForwards</a></td><td style='width:75%' ><p><a name="ea892458-c25f-4153-8a8b-d7d5077e6d03"></a></p>

<h3>Public Void MoveForwards (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0e7f1665-8fa0-4581-ab8d-edebed9f61ba"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d3202b3-bf4a-4988-93c2-74b1c0003446'>MoveToBottom</a></td><td style='width:75%' class='def'><p><a name="4d3202b3-bf4a-4988-93c2-74b1c0003446"></a></p>

<h3>Public Void MoveToBottom (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="b3644bb3-8acb-42d2-8a5d-8dc35dd355e3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcfad951-c165-4291-99a0-db6dfb485e20'>MoveToTop</a></td><td style='width:75%' ><p><a name="bcfad951-c165-4291-99a0-db6dfb485e20"></a></p>

<h3>Public Void MoveToTop (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="50ffb485-200f-4b75-89dd-29ecbb04a1fd"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#daf40d57-8497-4f66-bee4-ed8b9939699c'>OSSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="daf40d57-8497-4f66-bee4-ed8b9939699c"></a></p>

<h3>Private Void OSSelectionChanged (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Handle the OS selection changing</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e2668c21-9706-4bcc-9b22-9a72ea3cfd94"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7df0116-fe40-418e-a10c-23ec894a9cf7'>RaiseSketchModified</a></td><td style='width:75%' ><p><a name="a7df0116-fe40-418e-a10c-23ec894a9cf7"></a></p>

<h3>Void RaiseSketchModified (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="370cde36-b343-47ff-b16b-510f6c9d2c00"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>Sketch.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a05b863-0ea9-425c-a8b4-16b57b1b0f8e'>Redo</a></td><td style='width:75%' class='def'><p><a name="6a05b863-0ea9-425c-a8b4-16b57b1b0f8e"></a></p>

<h3>Public Void Redo (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Redoes the last change.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="2044df8b-e812-4c5b-88df-eee5abe23a79"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce3abf09-e6c7-4b7b-8b20-f4bf94727842'>ReleaseDesignerOutlets</a></td><td style='width:75%' ><p><a name="ce3abf09-e6c7-4b7b-8b20-f4bf94727842"></a></p>

<h3>Private Void ReleaseDesignerOutlets ()</h3>

<h4>Summary</h4>

<p>The private <code>ReleaseDesignerOutlets ()</code> member of the <code>ViewController</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc0ee6ec-96a5-479e-91aa-dd00034621d2'>ScrollInspectorsToTop</a></td><td style='width:75%' class='def'><p><a name="fc0ee6ec-96a5-479e-91aa-dd00034621d2"></a></p>

<h3>Private Void ScrollInspectorsToTop ()</h3>

<h4>Summary</h4>

<p>Scrolls the inspector list to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9eb0d47b-097e-45e8-8dc4-d6e52ec604c8'>SetDocumentSize</a></td><td style='width:75%' ><p><a name="9eb0d47b-097e-45e8-8dc4-d6e52ec604c8"></a></p>

<h3>Private Void SetDocumentSize ()</h3>

<h4>Summary</h4>

<p>Adjusts the visible representation of the Design Surface to the dimentions of current <code>KimonoSketch</code> being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51169c6e-5d5d-4fad-96cf-8c74e087763f'>ShowCodePreview</a></td><td style='width:75%' class='def'><p><a name="51169c6e-5d5d-4fad-96cf-8c74e087763f"></a></p>

<h3>Private Void ShowCodePreview (KimonoCore.IKimonoCodeGeneration)</h3>

<h4>Summary</h4>

<p>Shows the code preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>kimonoElement</td><td style='width:75%' ><p><a name="850e8771-02b1-42c0-90d2-ab86cc736c35"></a>
<b>KimonoCore.IKimonoCodeGeneration kimonoElement</b></p>

<p>Kimono element.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2340b207-bd46-4e75-8989-51f35c47686c'>ShowGeneralInspectors</a></td><td style='width:75%' ><p><a name="2340b207-bd46-4e75-8989-51f35c47686c"></a></p>

<h3>Private Void ShowGeneralInspectors (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Shows the general information inspectors for the given shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="36773183-bd6e-472a-81dc-8d31f8dacdbf"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to show the inspectors for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1930a40-3e48-47bc-ba40-7175d7b945a1'>ShowGradientInspectors</a></td><td style='width:75%' class='def'><p><a name="e1930a40-3e48-47bc-ba40-7175d7b945a1"></a></p>

<h3>Private Void ShowGradientInspectors (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Shows the gradient inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="e2272ab2-a8bd-402f-9c87-5404608c8d43"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to show the inspector for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ffbe6ed-fe20-437b-a3ec-e3e856b965d8'>ShowGroupShapes</a></td><td style='width:75%' ><p><a name="7ffbe6ed-fe20-437b-a3ec-e3e856b965d8"></a></p>

<h3>Private Void ShowGroupShapes ()</h3>

<h4>Summary</h4>

<p>Populates the Shapes sidebar with all of the <code>KimonoShapes</code> in the currently selected <code>KimonoSHapeGroup</code> that is being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fd85707-3837-4cfe-89b6-71db11d3ad8b'>ShowPaletteColorInspectors</a></td><td style='width:75%' class='def'><p><a name="5fd85707-3837-4cfe-89b6-71db11d3ad8b"></a></p>

<h3>Private Void ShowPaletteColorInspectors (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Shows the palette color inspectors for the given color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="6d9b49f4-b93b-4cbc-a540-5aa4a5221cdd"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to show the inspectors for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84e50eb4-42d5-4c9c-b4a3-d75cae1d5d2e'>ShowPortfolioInspectors</a></td><td style='width:75%' ><p><a name="84e50eb4-42d5-4c9c-b4a3-d75cae1d5d2e"></a></p>

<h3>Private Void ShowPortfolioInspectors (KimonoCore.KimonoPortfolio)</h3>

<h4>Summary</h4>

<p>Shows the portfolio inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="64a684b9-aa73-4ad0-8d7a-b04fc32ed5c8"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The <code>KimonoPortfolio</code> to show the inspectors for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e97592d2-c7bc-42b8-8e6e-ca0b1a17b13b'>ShowPropertyInspectors</a></td><td style='width:75%' class='def'><p><a name="e97592d2-c7bc-42b8-8e6e-ca0b1a17b13b"></a></p>

<h3>Private Void ShowPropertyInspectors (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Shows the property inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="9e19768e-b11d-4061-a9ea-a48b588d8c82"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to show the inspectors for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b8eefa8-0e92-48e3-97b3-02b3ab59856a'>ShowPropertyObiScript</a></td><td style='width:75%' ><p><a name="1b8eefa8-0e92-48e3-97b3-02b3ab59856a"></a></p>

<h3>Private Void ShowPropertyObiScript (KimonoCore.KimonoProperty)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Shows the property obi script.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="58800bcc-b810-4362-956f-2b7c3f0ed26d"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>property</code> parameter of the ShowPropertyObiScript method takes a <code>KimonoCore.KimonoProperty</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e27ed3b4-0ae5-4545-b678-0970fbc90471'>ShowSketchInspectors</a></td><td style='width:75%' class='def'><p><a name="e27ed3b4-0ae5-4545-b678-0970fbc90471"></a></p>

<h3>Private Void ShowSketchInspectors (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Shows the sketch inspectors for the given sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="4005609d-aa31-400f-b506-c58fc3207e57"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> to show the inspectors for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f03b9d6-6986-46a3-8cbf-c19309e38da1'>ShowSketchShapes</a></td><td style='width:75%' ><p><a name="8f03b9d6-6986-46a3-8cbf-c19309e38da1"></a></p>

<h3>Private Void ShowSketchShapes ()</h3>

<h4>Summary</h4>

<p>Populates the Shapes sidbar with all of the <code>KimonoShapes</code> in the currently selected <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d389341-58eb-4d64-b499-4dfff29d4d33'>ShowStyleInspectors</a></td><td style='width:75%' class='def'><p><a name="8d389341-58eb-4d64-b499-4dfff29d4d33"></a></p>

<h3>Private Void ShowStyleInspectors (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Shows the style inspectors for the given style.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="cc08a8f5-f6a0-4461-913f-c11749478235"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to show the inspectors for.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25367a72-6e4f-41f2-9232-2aa63ddff035'>SwitchToBorderInspectors</a></td><td style='width:75%' ><p><a name="25367a72-6e4f-41f2-9232-2aa63ddff035"></a></p>

<h3>Private Void SwitchToBorderInspectors (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Switch to border inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="dee9d415-831e-4b76-8e33-23396af5af9e"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d0f10f7-63ab-43a5-9cef-95020c1a7940'>SwitchToConnectionInspectors</a></td><td style='width:75%' class='def'><p><a name="4d0f10f7-63ab-43a5-9cef-95020c1a7940"></a></p>

<h3>Private Void SwitchToConnectionInspectors (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Switch to connection inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="3b84c706-af6a-4071-8940-6113636b9abc"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecbcdb7c-11b2-4a7a-93dc-5d915ae36527'>SwitchToDetailsInspectors</a></td><td style='width:75%' ><p><a name="ecbcdb7c-11b2-4a7a-93dc-5d915ae36527"></a></p>

<h3>Private Void SwitchToDetailsInspectors (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Switch to details inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ff773d12-6934-4e78-bb5a-f431bf5d2e93"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b6264ac-4965-4041-b8c7-84669720edb8'>SwitchToFillInspectors</a></td><td style='width:75%' class='def'><p><a name="4b6264ac-4965-4041-b8c7-84669720edb8"></a></p>

<h3>Private Void SwitchToFillInspectors (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Switch to fill inspectors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1a8f1500-2ac6-48b8-a4cd-157ff2ab6be5"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c978d1f2-0b03-4faa-a65f-97515995cd20'>ToolArrowSelected</a></td><td style='width:75%' ><p><a name="c978d1f2-0b03-4faa-a65f-97515995cd20"></a></p>

<h3>Private Void ToolArrowSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool arrow selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="1002411c-8e88-4eeb-8865-b6a30fc9d38d"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99bad351-4478-45e3-a507-a0725332b113'>ToolBezierSelected</a></td><td style='width:75%' class='def'><p><a name="99bad351-4478-45e3-a507-a0725332b113"></a></p>

<h3>Private Void ToolBezierSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool bezier selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="dec4e7da-da67-434f-b3b8-644623849673"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c402eaab-07ad-4c0e-a5a9-f410677e2764'>ToolCursorSelected</a></td><td style='width:75%' ><p><a name="c402eaab-07ad-4c0e-a5a9-f410677e2764"></a></p>

<h3>Private Void ToolCursorSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool cursor selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="031df588-392c-4402-a7fd-4d72f2b5bc84"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34fed293-b981-43cc-9186-3b4e9e48e897'>ToolLineSelected</a></td><td style='width:75%' class='def'><p><a name="34fed293-b981-43cc-9186-3b4e9e48e897"></a></p>

<h3>Private Void ToolLineSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool line selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="40e77829-99d3-4adf-a1b3-97db45132242"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb65abe6-0e15-492b-a294-e3f74d26356b'>ToolOvalSelected</a></td><td style='width:75%' ><p><a name="eb65abe6-0e15-492b-a294-e3f74d26356b"></a></p>

<h3>Private Void ToolOvalSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool oval selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="eb43edd1-1fb1-4d35-9618-c882b9292536"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a070fbb-7da6-4ea1-8361-1810d2ee4550'>ToolPolygonSelected</a></td><td style='width:75%' class='def'><p><a name="9a070fbb-7da6-4ea1-8361-1810d2ee4550"></a></p>

<h3>Private Void ToolPolygonSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool polygon selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ddf3629c-79cf-4f77-98d4-5af5e6088822"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d492678-6f7b-425b-b21b-98dceb3bb02e'>ToolRectSelected</a></td><td style='width:75%' ><p><a name="8d492678-6f7b-425b-b21b-98dceb3bb02e"></a></p>

<h3>Private Void ToolRectSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool rect selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="d9f72c72-29e9-4ae6-933c-bb4208b2c449"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d260fdd-e028-4328-a619-3c81a189bc99'>ToolRoundRectSelected</a></td><td style='width:75%' class='def'><p><a name="4d260fdd-e028-4328-a619-3c81a189bc99"></a></p>

<h3>Private Void ToolRoundRectSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool round rect selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="ebdf02c6-7794-4ca8-a016-be5b741706eb"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0847c01d-3a44-4756-b2ec-dcaae2188384'>ToolStarSelected</a></td><td style='width:75%' ><p><a name="0847c01d-3a44-4756-b2ec-dcaae2188384"></a></p>

<h3>Private Void ToolStarSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool star selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="7b20b48f-3bff-48e0-8a59-91cc5ed7e8ad"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3735ada-4fb0-4db1-adbd-43ceeaf194a9'>ToolTextSelected</a></td><td style='width:75%' class='def'><p><a name="a3735ada-4fb0-4db1-adbd-43ceeaf194a9"></a></p>

<h3>Private Void ToolTextSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool text selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="8bf0be6b-e5b9-4a6e-b4c0-0a739ec3eed6"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13e1b5ec-17f7-40e8-b93e-30a3f6fbb1c5'>ToolTriangleSelected</a></td><td style='width:75%' ><p><a name="13e1b5ec-17f7-40e8-b93e-30a3f6fbb1c5"></a></p>

<h3>Private Void ToolTriangleSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool triangle selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="38fc2468-8387-470b-9022-0623370c2af9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaae9c5f-0b91-4d83-99a1-db9df52b7c0a'>ToolVectorSelected</a></td><td style='width:75%' class='def'><p><a name="eaae9c5f-0b91-4d83-99a1-db9df52b7c0a"></a></p>

<h3>Private Void ToolVectorSelected (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Tool vector selected.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="4fe20770-bf3b-4227-b7a4-87252b50d5f9"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d676f62-3430-47c2-9298-c6e6557607a2'>Undo</a></td><td style='width:75%' ><p><a name="2d676f62-3430-47c2-9298-c6e6557607a2"></a></p>

<h3>Public Void Undo (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Udoes the last change.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="0443ca65-4e81-4a6a-a6a7-90edee3f4e81"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#577ab352-a5a9-431e-a9bd-bd1b1f8ac5c2'>UpdateColorList</a></td><td style='width:75%' class='def'><p><a name="577ab352-a5a9-431e-a9bd-bd1b1f8ac5c2"></a></p>

<h3>Private Void UpdateColorList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the color list in the sidebar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="b1c1f8dc-0624-4a7b-a380-900faa4c76f1"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d61333c6-d254-4ff5-abe4-dedbaf05a631'>UpdateGradientList</a></td><td style='width:75%' ><p><a name="d61333c6-d254-4ff5-abe4-dedbaf05a631"></a></p>

<h3>Private Void UpdateGradientList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the gradient list.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="7a8cb391-b066-44e5-b367-6ef60079ac30"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc541c97-f590-4b79-9ddf-4675282567b0'>UpdateInspectorsView</a></td><td style='width:75%' class='def'><p><a name="fc541c97-f590-4b79-9ddf-4675282567b0"></a></p>

<h3>Private Void UpdateInspectorsView ()</h3>

<h4>Summary</h4>

<p>Updates the inspectors view based on the Kimono element currently being inspected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#873b2222-f09e-472a-9f72-233bcba2acd3'>UpdatePath</a></td><td style='width:75%' ><p><a name="873b2222-f09e-472a-9f72-233bcba2acd3"></a></p>

<h3>Private Void UpdatePath ()</h3>

<h4>Summary</h4>

<p>Updates the path display at the top of the Design Surface showing the full path to the shape currently being edited.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cbbdc85-72a0-412d-83e7-f6a577e61ce2'>UpdateProjectList</a></td><td style='width:75%' class='def'><p><a name="0cbbdc85-72a0-412d-83e7-f6a577e61ce2"></a></p>

<h3>Private Void UpdateProjectList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the project list in the sidebar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="62bd3d2a-77cb-42a3-abb5-8340dcbb2223"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43bb499e-df67-44c8-848b-91cf4cdcdfc1'>UpdatePropertyList</a></td><td style='width:75%' ><p><a name="43bb499e-df67-44c8-848b-91cf4cdcdfc1"></a></p>

<h3>Private Void UpdatePropertyList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the property list.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="8a430350-2004-4309-b772-7250b2e37a94"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bbe8793-3dbb-4e9e-ae41-1d224ee8079f'>UpdateShapesList</a></td><td style='width:75%' class='def'><p><a name="3bbe8793-3dbb-4e9e-ae41-1d224ee8079f"></a></p>

<h3>Private Void UpdateShapesList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the shapes list in the sidebar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="c8fa1ec1-f683-403e-8fcf-479154ea1d97"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a82525a-0b72-4f5f-8b64-0e44f30eb952'>UpdateSketchesList</a></td><td style='width:75%' ><p><a name="6a82525a-0b72-4f5f-8b64-0e44f30eb952"></a></p>

<h3>Private Void UpdateSketchesList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the sketches list in the sidebar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="1299f899-120b-4a39-8f99-20ff6bb2dae4"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c24d733-23f3-423a-86e3-c9c54f229dbb'>UpdateStyleList</a></td><td style='width:75%' class='def'><p><a name="1c24d733-23f3-423a-86e3-c9c54f229dbb"></a></p>

<h3>Private Void UpdateStyleList (System.Boolean)</h3>

<h4>Summary</h4>

<p>Updates the style list in the sidebar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>refreshList</td><td style='width:75%' ><p><a name="e4433272-8957-48ee-9008-ac42000a432a"></a>
<b>System.Boolean refreshList</b></p>

<p>If set to <code>true</code> refresh list.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b991a90-39a4-4e7d-9c91-6cc8ce84b354'>UpdateTextEditor</a></td><td style='width:75%' ><p><a name="6b991a90-39a4-4e7d-9c91-6cc8ce84b354"></a></p>

<h3>Private Void UpdateTextEditor ()</h3>

<h4>Summary</h4>

<p>Updates the text editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0ab0a77-c795-4f47-9be4-e38dae85c98b'>ValidateMenuItem</a></td><td style='width:75%' class='def'><p><a name="e0ab0a77-c795-4f47-9be4-e38dae85c98b"></a></p>

<h3>Public <code>System.Boolean</code> ValidateMenuItem (AppKit.NSMenuItem)</h3>

<h4>Summary</h4>

<p>Validates any menu item attached to actions on this view controller based on its assigned <code>Tag</code> value.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>item</td><td style='width:75%' ><p><a name="3e858ec4-ca1e-4c87-8fa5-b7269800f35c"></a>
<b>AppKit.NSMenuItem item</b></p>

<p>The <code>NSMenuItem</code> being tested.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if menu item was validated, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b6900d7-80fd-4abc-b9fc-ee6bb4b76117'>ViewController</a></td><td style='width:75%' ><p><a name="1b6900d7-80fd-4abc-b9fc-ee6bb4b76117"></a></p>

<h3>Public Void ViewController (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cd6ee1dc-8f34-4be4-afe9-22bf3c5b0fcc">ViewController</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="c8c5f615-90a5-4131-a4c0-cb562342de6c"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f9432a3-d931-4763-b216-f51e42b603f2'>ViewDidAppear</a></td><td style='width:75%' class='def'><p><a name="8f9432a3-d931-4763-b216-f51e42b603f2"></a></p>

<h3>Public Virtual Void ViewDidAppear ()</h3>

<h4>Summary</h4>

<p>This method is called after the View being handled by this View Controller has been displayed on screen.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2aeceaa3-ee67-45e3-ab56-4ca7b86c6d23'>ViewDidLoad</a></td><td style='width:75%' ><p><a name="2aeceaa3-ee67-45e3-ab56-4ca7b86c6d23"></a></p>

<h3>Public Virtual Void ViewDidLoad ()</h3>

<h4>Summary</h4>

<p>Handles the view being sucessfully loaded.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82d1a0d8-4fa9-4bf4-82dc-8219678b569d'>ViewWillAppear</a></td><td style='width:75%' class='def'><p><a name="82d1a0d8-4fa9-4bf4-82dc-8219678b569d"></a></p>

<h3>Public Virtual Void ViewWillAppear ()</h3>

<h4>Summary</h4>

<p>Called before the view is displayed</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d051725a-d1ae-4ccb-beb5-003beb788621'>SketchModified</a></td><td style='width:75%' ><p><a name="d051725a-d1ae-4ccb-beb5-003beb788621"></a></p>

<h3><code>KimonoCore.Kimono.SketchEventDelegate</code> SketchModified</h3>

<h4>Summary</h4>

<p>Occurs when the sketch is modified.</p>
</td></tr></table></p>


---

<a name="a883458f-5a65-4dd2-82de-99ba116904af"></a>
##Public Class XMLDescriptor

###Namespace

[AppKit.TextKit.Formatter](#d2ccd6a5-8517-4fc5-aa3f-333f7d181085)

###Inherits From

[AppKit.TextKit.Formatter.LanguageDescriptor](#5bf38b97-3aff-4262-8b73-5ec35d7e9daf)

###Summary

Defines how XML should be colorized using a [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee).
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#dee094f9-9959-40e5-a21c-593a2721d747'>LanguageIdentifier</a></td><td style='width:75%' ><p><a name="dee094f9-9959-40e5-a21c-593a2721d747"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> LanguageIdentifier</h3>

<h4>Summary</h4>

<p>Gets the language identifier.</p>

<h4>Return Value</h4>

<p>The language identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c3cc8f7-9e7d-4173-90c5-f32bbcdac1ee'>LanguageSeparators</a></td><td style='width:75%' class='def'><p><a name="0c3cc8f7-9e7d-4173-90c5-f32bbcdac1ee"></a></p>

<h3>Public Virtual <code>System.Char[]</code> LanguageSeparators</h3>

<h4>Summary</h4>

<p>Gets or sets the language separators for XML.</p>

<h4>Return Value</h4>

<p>The language separators.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8bd9785a-fe88-4055-8c9c-baaba9653315'>Define</a></td><td style='width:75%' ><p><a name="8bd9785a-fe88-4055-8c9c-baaba9653315"></a></p>

<h3>Public Virtual Void Define ()</h3>

<h4>Summary</h4>

<p>Define this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f19c1ee-55d6-418d-919b-a366fd28860c'>FormatForPreview</a></td><td style='width:75%' class='def'><p><a name="3f19c1ee-55d6-418d-919b-a366fd28860c"></a></p>

<h3>Public Virtual <code>System.String</code> FormatForPreview (System.String)</h3>

<h4>Summary</h4>

<p>Formats the passed in string of text for previewing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>text</td><td style='width:75%' ><p><a name="d39015f8-bc09-4106-9b8d-94a8f241dbc5"></a>
<b>System.String text</b></p>

<p>Text.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The string formatted for preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fb58b69-9d2f-4b8e-af2b-3559df2bade4'>XMLDescriptor</a></td><td style='width:75%' ><p><a name="1fb58b69-9d2f-4b8e-af2b-3559df2bade4"></a></p>

<h3>Public Void XMLDescriptor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a883458f-5a65-4dd2-82de-99ba116904af">XMLDescriptor</a> class.</p>
</td></tr></table></p>

###Remarks

This is a simplified, sample format provided as an example only. The `HighlightSyntaxRegion` method of the [LanguageFormatter](#13e07d7b-7947-4461-812d-5c2aafa2ebee) would need to be modified to properly format XML Keywords as the current version was designed for languages like C#, JavaScript or Visual Basic.
