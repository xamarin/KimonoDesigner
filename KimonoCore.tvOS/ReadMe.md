#API Documentation

####Version 01.00.00

##Table of Contents

* [Summary](#Summary)
* [Remarks](#Remarks)
* [Namespaces](#Namespaces)
* [Types](#Types)

<a name="Summary"></a>
##Summary

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can can be converted to code and included in any cross-platform language and OS that SkiaSharp supports. Kimono.Mac is the Xamarin.Mac specific of the Kimono cross-platform library that provides a helper interface to SkiaSharp.

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

<a name="b8318743-3687-4197-8745-edf08a8b10f2"></a>
##KimonoCore

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e9f19b7a-3d98-40a5-9521-e3141b121e49'>KimonoSketch</a></td><td style='width:75%' ><p>Holds a collection of <code>KimonoShapes</code> that are used to create a given image using Skia.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#284654eb-3139-48b3-80fb-bb05173130b0'>KimonoTool</a></td><td style='width:75%' class='def'><p>Defines the current tool that is active in a <code>KimonoSketch</code> that the user can use to create or modify a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#369f26bb-132a-44de-ac3a-456938da3ec6'>Kimono</a></td><td style='width:75%' ><p>Holds a set of shared utilities that are used across the Kimono classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecbba92e-b462-49ac-ab96-64ed167264be'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>A Kimono Portfolio holds a collection of <code>KimonoSketches</code>, <code>KimonoStyles</code> and <code>KimonoColors</code> that define a given Kimono Designer project.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83854443-b690-4644-be64-899248d0c626'>KimonoUndoHandler</a></td><td style='width:75%' ><p>Handles the undo/redo state for a <code>KimonoDesignSurface</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f377bd2-8962-4de7-a4f3-fd29bb80d9cf'>KimonoShape</a></td><td style='width:75%' class='def'><p>Defines the based shape that all other Kimono Shape types will inherit from.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2'>KimonoShapeArrow</a></td><td style='width:75%' ><p>Draws either an outlined or single line arrow with heads on one or both ends.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5bec955-533b-4294-a2f8-d2c1471fc4b8'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p>A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f23ef71d-24e2-4f80-9edf-d289d5f55f3f'>KimonoShapeGroup</a></td><td style='width:75%' ><p>A <code>KimonoShapeGroup</code> holds a collection of <code>KimonoShapes</code> that can be acted upon as a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c44a9f63-7795-44b2-bfbc-da20007d32cf'>KimonoShapeGroupType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4a85662-e7b6-4677-8b4d-0a099b4eb968'>KimonoShapeLine</a></td><td style='width:75%' ><p>Draws a line on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0a8590d-dbcc-44ed-9457-0768a50c3be2'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>Draws an oval into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe16fc49-2f43-4764-9c66-909a8f47383c'>KimonoShapePolygon</a></td><td style='width:75%' ><p>Draws a multi-sided polygon into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82ab6a30-c5a7-44d6-a04e-1039d1e319b8'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>Draws a rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34d1d429-4b88-4c3c-840c-05bd2ec8c8e8'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>Draws a rounded rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af653d27-3655-47dd-9ef5-5a1f3f5d58d5'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>Draws a multi-sided star shape into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c901b401-346b-419f-9138-2dbc1061e7af'>KimonoShapeState</a></td><td style='width:75%' ><p>Holds the current state of a <code>KimonoShape</code> while it is being edited by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0176715e-dc10-43bc-ae04-98aba16b3647'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>Draws a block of text into the Design Surface within the specifid bounds of this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b70177a0-ed3a-4958-98bf-77aa48d58232'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>Draws a triangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7ae8aff-214d-44d5-9cd8-efc56483c9c0'>KimonoProperty</a></td><td style='width:75%' ><p>Defines a property that can be attached to another Kimono object (such as a <code>KimonoColor</code>, <code>KimonoStyle</code> or <code>KimonoShape</code>) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66d39ff0-f7a8-4244-92df-432427b23341'>KimonoPropertyUsage</a></td><td style='width:75%' class='def'><p>Defines how a <code>KimonoProperty</code> is used when it is attached to a <code>KimonoShape</code>, <code>KimonoSketch</code> or <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5326511f-40f1-4106-a05b-4fd702e264f4'>KimonoPropertyConnectionPoint</a></td><td style='width:75%' ><p>Defines the point that a <code>KimonoProperty</code> value can be connected to another Kimono object such as the <code>Top</code> coordinate of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f9b2b1a-b792-46bd-8c6d-79ae3e6ce1ee'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p>Defines a connection between a given Kimono Object and a <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fa8c182-e507-422e-b805-7348335c0b5b'>ObiScriptResult</a></td><td style='width:75%' ><p>Defines the result of attempting to execute an Obi Script on a <code>KimonoProperty</code></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7918b823-8e79-45ac-86c0-0912d87dcd78'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p>Holds the control and end point for a <code>KimonoShapeBezier</code> that define a quad section of the Bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae73d413-e603-4d6c-abd3-d19e4199634e'>KimonoBounds</a></td><td style='width:75%' ><p>Defines the outter bounding box for a <code>KimonoShape</code> and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e3a3c18-1e19-4928-8110-331ea0733920'>KimonoHandle</a></td><td style='width:75%' class='def'><p>Defines an edit handle that the user manipulates to edit the bounds of a <code>KimonoShape</code> or the control points of a Bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#687ff59f-90ea-4a8b-b656-7237bfa92a92'>KimonoHandleConstraint</a></td><td style='width:75%' ><p>Constrains the movement of a <code>KimonoHandle</code> when it is being moved by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aab43a89-2c9c-4987-a125-a415ef2ae5dc'>KimonoHandleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoHandle</code> that can be used as a general purpose control point to adjust the bounds of a <code>KimonoShape</code> or as a point for a vector or bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6b07a58-043d-4087-9d74-1674aef6433a'>KimonoBlur</a></td><td style='width:75%' ><p>Defines a blur effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4db2b92f-1223-4630-a172-98e79c99b08d'>KimonoShadow</a></td><td style='width:75%' class='def'><p>Defines a shadow effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfd88ccd-b3f1-4bb7-b410-48c8070cf065'>KimonoGradient</a></td><td style='width:75%' ><p>Defines a gradient as a collection of either <code>SKColor</code> or linked <code>KimonoColors</code> that can be applied to a <code>KimonoStyle</code> and used when drawing a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adbb20c5-5898-44d7-b942-4b0e1c1ed617'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>Kimono gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b'>KimonoStyle</a></td><td style='width:75%' ><p>Defines as style that can be applied to a <code>KimonoShape</code> to control its appearance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3d62b63-5d16-4a04-8356-a6401566d330'>KimonoStyleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoStyle</code> that will be used to draw a given <code>KimonoShape</code> in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b2fd87b-d669-4dc9-b5a8-d393edd3f6a0'>KimonoPropertyRect</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>SKRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b351915-9a8c-4f6a-a034-c594077b78c6'>KimonoPropertyNumber</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>float</code> or <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cf6c2e1-3ecf-43a4-9d6f-8e20f44a094f'>KimonoPropertyStyle</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8b9dadd-9839-4378-9718-4aa7101840ab'>KimonoPropertyBoolean</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55c76016-a926-4910-8acd-0fc46afade25'>KimonoPropertyText</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab469ab5-feba-4a5c-924b-8bf91b1080f4'>KimonoPropertyColor</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cd19f95-eb5f-4e29-8a3e-122a8ab9e517'>KimonoPropertyGradient</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f0ea220-0c6f-4b56-8b74-01edf59503cf'>CodeOutputOS</a></td><td style='width:75%' class='def'><p>Defines the OS that code will be generated for</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f0bcae2-4212-43c8-bd18-ef370d210953'>CodeOutputLanguage</a></td><td style='width:75%' ><p>Defines the language that code will be output in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db8121f3-0156-4db5-a8f7-6e09acf33d15'>CodeOutputLibrary</a></td><td style='width:75%' class='def'><p>Code output library.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45d46f25-df9a-4bf8-86b0-d1e3f8543285'>KimonoCodeGenerator</a></td><td style='width:75%' ><p>The Kimono Code Generator has routine to assist in the generation of output source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2967a95-491a-485d-9978-154eea72528a'>IKimonoCodeGeneration</a></td><td style='width:75%' class='def'><p>Interface for any Kimono Object that support source code generation.</p>
</td></tr></table></p>


---

<a name="7fccc05c-362e-4a7f-a653-dacaa896d627"></a>
##KimonoCore.Kimono

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#45274f98-41a0-4d87-83d6-39c6015172aa'>PortfolioEventDelegate</a></td><td style='width:75%' ><p>Portfolio event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc80c6f4-8e40-457e-9bf3-bc2d54d3745b'>SketchEventDelegate</a></td><td style='width:75%' class='def'><p>Sketch event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2348428d-ff22-4457-b73d-ad47c7c634e4'>StyleEventDelegate</a></td><td style='width:75%' ><p>Style event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1635637-a87c-49d6-97f8-5511c32090e1'>ShapeEventDelegate</a></td><td style='width:75%' class='def'><p>Shape event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51fc0191-a6fa-4204-9c7a-07d4ef78346c'>ToolEventDelegate</a></td><td style='width:75%' ><p>Tool event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#277c2732-d343-47ac-b003-1a664779ea4f'>SkiaPointEventDelegate</a></td><td style='width:75%' class='def'><p>Skia point event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b928ecbd-5a59-41b0-b5fb-af6b97e60ef4'>GroupEventDelegate</a></td><td style='width:75%' ><p>Group event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca8428db-1518-4597-9e41-fc484c6dc272'>ColorEventDelegate</a></td><td style='width:75%' class='def'><p>Color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b4ed685-c690-4cb6-837f-dcb63649c752'>SkiaColorEventDelegate</a></td><td style='width:75%' ><p>Skia color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65ba507b-e650-41e8-9c5a-937d9a66b0be'>GradientEventDelegate</a></td><td style='width:75%' class='def'><p>Gradient event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e3e6fea-b6c4-4720-831d-c02c60128652'>HandleEventDelegate</a></td><td style='width:75%' ><p>Handle event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9856e1a-814d-4ebf-a70d-ef55044e3b54'>PropertyEventDelegate</a></td><td style='width:75%' class='def'><p>Property event delegate.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="e9f19b7a-3d98-40a5-9521-e3141b121e49"></a>
##KimonoSketch

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Holds a collection of `KimonoShapes` that are used to create a given image using Skia.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fc9c5060-1eb6-4a6a-bd68-221bf8e418e2'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="fc9c5060-1eb6-4a6a-bd68-221bf8e418e2"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed03596c-da28-4ab9-923e-dc19a8b846f7'>PreviousSize</a></td><td style='width:75%' class='def'><p><a name="ed03596c-da28-4ab9-923e-dc19a8b846f7"></a>
<b>PreviousSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the previous of a sketch for a rezise operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa3c0175-fed2-4491-b35c-fcf414f7214e'>Size</a></td><td style='width:75%' ><p><a name="aa3c0175-fed2-4491-b35c-fcf414f7214e"></a>
<b>Size</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The current size of the sketch</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96c2864a-cf92-4a17-aeeb-2f4f1ff64f6d'>_tool</a></td><td style='width:75%' class='def'><p><a name="96c2864a-cf92-4a17-aeeb-2f4f1ff64f6d"></a>
<b>_tool</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently <code>KimonoTool</code> that will be used to edit the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#570984d9-5ba5-4cd3-ad73-3680ae226dfe'>_canvasColor</a></td><td style='width:75%' ><p><a name="570984d9-5ba5-4cd3-ad73-3680ae226dfe"></a>
<b>_canvasColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#954008fa-7cf2-453d-9370-ee9450b2e1f2'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="954008fa-7cf2-453d-9370-ee9450b2e1f2"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05a1c61a-ad9e-4fa2-b744-d69df063a85a'>IgnoreDrag</a></td><td style='width:75%' ><p><a name="05a1c61a-ad9e-4fa2-b744-d69df063a85a"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2641f64f-0aea-4c54-ab8b-9e1e016d81ae'>PerformingDrag</a></td><td style='width:75%' class='def'><p><a name="2641f64f-0aea-4c54-ab8b-9e1e016d81ae"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6eb6de4-7d7e-42b9-bc2d-00da398399ba'>ToolDownAt</a></td><td style='width:75%' ><p><a name="b6eb6de4-7d7e-42b9-bc2d-00da398399ba"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#660e286e-cded-4870-8f31-ef1b5edc2051'>UniqueID</a></td><td style='width:75%' ><p><a name="660e286e-cded-4870-8f31-ef1b5edc2051"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87e46c0b-eee2-425f-8426-2c554675864b'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="87e46c0b-eee2-425f-8426-2c554675864b"></a></p>

<h3>Portfolio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the portfolio that this sketch belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46044b72-b73b-42d3-9b9c-182c54ab0584'>ElementName</a></td><td style='width:75%' ><p><a name="46044b72-b73b-42d3-9b9c-182c54ab0584"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26d7cef1-d2a1-4464-ba81-7ec21df5a126'>Name</a></td><td style='width:75%' class='def'><p><a name="26d7cef1-d2a1-4464-ba81-7ec21df5a126"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6318c398-e7e1-4b26-b481-b31f9a3c4eca'>GenerateCodeToOuputToCanvas</a></td><td style='width:75%' ><p><a name="6318c398-e7e1-4b26-b481-b31f9a3c4eca"></a></p>

<h3>GenerateCodeToOuputToCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, ouput a method that draws into the given SkiaSharp Canvas.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#813b9b37-4b28-45de-a833-0f25be3ebf55'>GenerateCodeToOuputSkiaData</a></td><td style='width:75%' class='def'><p><a name="813b9b37-4b28-45de-a833-0f25be3ebf55"></a></p>

<h3>GenerateCodeToOuputSkiaData</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the SkiaSharp Data (<code>SKData[]</code>) representing the Sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput skia data; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5051edf4-5be1-4135-98b6-0511e709b6d8'>GenerateCodeToOuputBitmapImage</a></td><td style='width:75%' ><p><a name="5051edf4-5be1-4135-98b6-0511e709b6d8"></a></p>

<h3>GenerateCodeToOuputBitmapImage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as a OS specific bitmap image.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput bitmap image; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89f9db98-c404-45c4-b1c5-9fca50e061c8'>GenerateCodeToOuputToSkiaSharpViews</a></td><td style='width:75%' class='def'><p><a name="89f9db98-c404-45c4-b1c5-9fca50e061c8"></a></p>

<h3>GenerateCodeToOuputToSkiaSharpViews</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as class based on the <code>SkiaSharp.Views</code> extension library.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to skia sharp views; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d1ea138-8ac1-4f8d-889a-29c2e2752e62'>Width</a></td><td style='width:75%' ><p><a name="6d1ea138-8ac1-4f8d-889a-29c2e2752e62"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c249b0c0-88cc-46fc-bf22-4da9d78e3127'>Height</a></td><td style='width:75%' class='def'><p><a name="c249b0c0-88cc-46fc-bf22-4da9d78e3127"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a4bcb88-af98-44b0-be00-d2f827f7f964'>CanvasColor</a></td><td style='width:75%' ><p><a name="8a4bcb88-af98-44b0-be00-d2f827f7f964"></a></p>

<h3>CanvasColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the canvas.</p>

<h4>Return Value</h4>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e3675c0-9ac5-4e1a-b4d5-97d02dc0943d'>DrawCanvas</a></td><td style='width:75%' class='def'><p><a name="7e3675c0-9ac5-4e1a-b4d5-97d02dc0943d"></a></p>

<h3>DrawCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#e9f19b7a-3d98-40a5-9521-e3141b121e49">KimonoSketch</a> should draw  the canvas when it is included in another sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if draw canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16ade24e-1c23-49ae-a88e-a35dd5bc7e90'>Shapes</a></td><td style='width:75%' ><p><a name="16ade24e-1c23-49ae-a88e-a35dd5bc7e90"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a0c75ac-cbd0-4e2e-8965-2a55b97dc301'>Tool</a></td><td style='width:75%' class='def'><p><a name="8a0c75ac-cbd0-4e2e-8965-2a55b97dc301"></a></p>

<h3>Tool</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tool.</p>

<h4>Return Value</h4>

<p>The tool.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f24ac7e-2097-42dd-9282-b2b8f9a5eeef'>SelectedShape</a></td><td style='width:75%' ><p><a name="2f24ac7e-2097-42dd-9282-b2b8f9a5eeef"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f876b3fc-5428-42d4-97d4-b4b5b2400c97'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="f876b3fc-5428-42d4-97d4-b4b5b2400c97"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc96143f-7e35-47e7-977f-9385712132a5'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="cc96143f-7e35-47e7-977f-9385712132a5"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#450b7434-0b31-4322-9f15-2274b1d5181b'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="450b7434-0b31-4322-9f15-2274b1d5181b"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e59728e-602b-43c9-b861-dea1ec114a1b'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="5e59728e-602b-43c9-b861-dea1ec114a1b"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd919226-47a4-44d6-9197-e88b02a28085'>CanAlignShapes</a></td><td style='width:75%' class='def'><p><a name="fd919226-47a4-44d6-9197-e88b02a28085"></a></p>

<h3>CanAlignShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether alignment can be applied on a set of shapes.</p>

<h4>Return Value</h4>

<p><code>true</code> if can align shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e33d821a-ac66-4f67-a210-5dd5599c83b6'>CanGroupShapes</a></td><td style='width:75%' ><p><a name="e33d821a-ac66-4f67-a210-5dd5599c83b6"></a></p>

<h3>CanGroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be grouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65b21501-4a4e-41ca-a7b2-be8fd00db54a'>CanUngroupShapes</a></td><td style='width:75%' class='def'><p><a name="65b21501-4a4e-41ca-a7b2-be8fd00db54a"></a></p>

<h3>CanUngroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be ungrouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b92a1dae-3f8e-416f-8820-fb90cbb58bd8'>ToImage</a></td><td style='width:75%' ><p><a name="b92a1dae-3f8e-416f-8820-fb90cbb58bd8"></a></p>

<h3>ToImage ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the sketch to a bitmap image.</p>

<h4>Returns</h4>

<p>The <code>UIImage</code> representation of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca4cf41e-ba3c-44fe-b962-b1f89a0a3689'>KimonoSketch</a></td><td style='width:75%' class='def'><p><a name="ca4cf41e-ba3c-44fe-b962-b1f89a0a3689"></a></p>

<h3>KimonoSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e9f19b7a-3d98-40a5-9521-e3141b121e49">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a9f8252-cab2-446a-9cb9-6609a6d11459'>KimonoSketch</a></td><td style='width:75%' ><p><a name="7a9f8252-cab2-446a-9cb9-6609a6d11459"></a></p>

<h3>KimonoSketch (System.String, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e9f19b7a-3d98-40a5-9521-e3141b121e49">KimonoSketch</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="aa143ee8-221a-4cf5-aa4b-d82f922f8261"></a>
Name.</p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p><a name="c7ec69d0-ce39-4ecd-ad14-c7223db2362a"></a>
Width.</p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p><a name="63b0d34a-1426-4787-b45e-86dc2273d0af"></a>
Height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a46e5d88-db3b-455a-938f-d77a87126389'>Initialize</a></td><td style='width:75%' class='def'><p><a name="a46e5d88-db3b-455a-938f-d77a87126389"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5836a67c-281e-4369-8d11-12304ea5020c'>SavePreviousSize</a></td><td style='width:75%' ><p><a name="5836a67c-281e-4369-8d11-12304ea5020c"></a></p>

<h3>SavePreviousSize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous size of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a73e01fa-a74f-4fd0-bf13-d3c141db2978'>ApplySizeChange</a></td><td style='width:75%' class='def'><p><a name="a73e01fa-a74f-4fd0-bf13-d3c141db2978"></a></p>

<h3>ApplySizeChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the size change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2102038-d461-4e78-8d9d-bca9801152cb'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="e2102038-d461-4e78-8d9d-bca9801152cb"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="65bb54a9-b0c6-407b-9a9e-0ad7a0e34b6b"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccdafb37-df2d-4bec-b917-1ce92e96ac00'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="ccdafb37-df2d-4bec-b917-1ce92e96ac00"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="3cd521e8-dc02-4ed5-8f11-d291653e709b"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c86560b3-e820-4475-b595-9dd3fb943fbe'>FindShape</a></td><td style='width:75%' ><p><a name="c86560b3-e820-4475-b595-9dd3fb943fbe"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the shape specified by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="2561732a-3d65-4999-8526-16111cc5ec3e"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>If found, the <code>KimonoShape</code> will be returned, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8600d016-787e-41f5-9b09-308cf0823374'>Draw</a></td><td style='width:75%' class='def'><p><a name="8600d016-787e-41f5-9b09-308cf0823374"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw this sketch into the give SkiaSharp canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="ba9da880-7985-4485-b86c-4ea7dd02845c"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a81720b-f7a0-49ff-b0b0-ac682c5fa5cf'>MoveSelectedShapeToBottom</a></td><td style='width:75%' ><p><a name="5a81720b-f7a0-49ff-b0b0-ac682c5fa5cf"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9ef85f2-761c-479a-890c-e06aec16d8f7'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p><a name="f9ef85f2-761c-479a-890c-e06aec16d8f7"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61e69cc8-9597-4e1c-bf10-d83cfb4e3df0'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p><a name="61e69cc8-9597-4e1c-bf10-d83cfb4e3df0"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a9bd299-6276-4a63-8c15-af6adb5f4f8c'>MoveSelectedShapeForwards</a></td><td style='width:75%' class='def'><p><a name="6a9bd299-6276-4a63-8c15-af6adb5f4f8c"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c94fb0c9-075e-412e-9ecc-3a19361e9513'>AddShape</a></td><td style='width:75%' ><p><a name="c94fb0c9-075e-412e-9ecc-3a19361e9513"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="d9eac6ca-b3f1-47a2-b51c-cf7258a8a6aa"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6dee06e-3fca-49b1-84d7-23d004c46356'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p><a name="f6dee06e-3fca-49b1-84d7-23d004c46356"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#125b403f-4eaf-47f5-8fc9-27db43f1142f'>DuplicateSelectedShape</a></td><td style='width:75%' ><p><a name="125b403f-4eaf-47f5-8fc9-27db43f1142f"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99311a04-9dfa-4540-9457-088f9546e510'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="99311a04-9dfa-4540-9457-088f9546e510"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#203377ca-6e4b-4713-88c9-2a1c4b953497'>SelectShape</a></td><td style='width:75%' ><p><a name="203377ca-6e4b-4713-88c9-2a1c4b953497"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="4ea5876c-fa4b-415b-9129-a79abe230b33"></a>
The <code>KimonoShape</code> to select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b79094b-4f94-41e1-84f5-f740f154e7d1'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="9b79094b-4f94-41e1-84f5-f740f154e7d1"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7d358bd-7ce4-4053-a8f4-d7f80f827fbf'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p><a name="d7d358bd-7ce4-4053-a8f4-d7f80f827fbf"></a></p>

<h3>GroupUngroupSelectedShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d70a431e-85e9-4549-a09f-7f8611ece388'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="d70a431e-85e9-4549-a09f-7f8611ece388"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d25f21c-dd4b-4851-9d37-156fe6b2bcb4'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="2d25f21c-dd4b-4851-9d37-156fe6b2bcb4"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fe7b312-c23f-4684-8539-2de56a96637c'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="6fe7b312-c23f-4684-8539-2de56a96637c"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4b158ea-b399-4e49-b59e-1c0860e06eba'>BuildCsharpToCanvasMethod</a></td><td style='width:75%' ><p><a name="f4b158ea-b399-4e49-b59e-1c0860e06eba"></a></p>

<h3>BuildCsharpToCanvasMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Build the method to draw into a specific SkiaSharp Canvas in C# source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="929c4308-0d83-455c-a0c3-d9f6d96cd89e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the method.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5e38848-2c24-4422-9cb8-9989592b8c6c'>BuildCsharpToSkiaDataMethod</a></td><td style='width:75%' class='def'><p><a name="b5e38848-2c24-4422-9cb8-9989592b8c6c"></a></p>

<h3>BuildCsharpToSkiaDataMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to SkiaSharp data (<code>SKData</code>).</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e7a22c2c-ad10-4570-99aa-2dbbf8807d31"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Sketch as <code>SKData</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9070f560-f01a-43ed-b6a4-62438655324d'>BuildCsharpToBitmapImage</a></td><td style='width:75%' ><p><a name="9070f560-f01a-43ed-b6a4-62438655324d"></a></p>

<h3>BuildCsharpToBitmapImage (KimonoCore.CodeOutputOS)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to OS specific bitmap image format.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="692245a8-3d6d-41ff-ac1a-cc687c9a3ec0"></a>
Output os.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Sketch as a platform specific image.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#436c8e11-b684-4d50-b92a-ef07a1ee87fe'>BuildCSharpCrossPlatformToImage</a></td><td style='width:75%' class='def'><p><a name="436c8e11-b684-4d50-b92a-ef07a1ee87fe"></a></p>

<h3>BuildCSharpCrossPlatformToImage (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# ToImage method for Cross Platform image support.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f237b2ec-6791-40bd-86ee-a78a5ef4db60"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Conditionally compiled code to support all of the different image types.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c532a3e9-fcf5-40d2-889f-d75b889896f0'>ToCSharp</a></td><td style='width:75%' ><p><a name="c532a3e9-fcf5-40d2-889f-d75b889896f0"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2e7e8ea2-04f5-4ba0-bc51-7ac0d31a614a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08fdc96b-97af-422c-b7a2-ebc369988d08'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="08fdc96b-97af-422c-b7a2-ebc369988d08"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="c05e7e69-f8f7-49b4-bb43-dcf7a3eb4080"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="fa5ab0f8-4ec9-4971-868f-4bd61c36ccab"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a09476c2-cf7f-4f0d-b5fc-1254e04661e3'>PortfolioSketchMethods</a></td><td style='width:75%' ><p><a name="a09476c2-cf7f-4f0d-b5fc-1254e04661e3"></a></p>

<h3>PortfolioSketchMethods (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary, System.String@, System.String@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the methods that a portfolio will use to draw the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="fd5fcc90-2e6a-41c5-93c9-f7a52e88ab2a"></a>
The <code>CodeOutputOS</code> to generate code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="377dc925-983f-4d33-942b-b2063b0a650a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>privateMethodsCode</td><td style='width:75%' ><p><a name="51411f24-2fcd-4231-8a87-5ab554980620"></a>
The private methods required by this sketch.</p>
</td></tr><tr><td style='width:25%' class='term'>publicMethodsCode</td><td style='width:75%' class='def'><p><a name="644d6c65-86b7-45a3-8c7f-0acf7d063ae3"></a>
The public methods required by this sketch.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#597188ac-362b-4a0d-8170-486ec5682b6a'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="597188ac-362b-4a0d-8170-486ec5682b6a"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c99f239d-f103-4cb0-8700-fb695e9b7b93"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16aa7861-e931-4b03-b972-484a572737fa'>ToCSharpKimono</a></td><td style='width:75%' ><p><a name="16aa7861-e931-4b03-b972-484a572737fa"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="df3f4c6b-c5dc-4b37-b441-0d10a6d6e5b1"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="ea0b97e6-ea63-4d61-9614-bf6ce3439ba4"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2693e4a0-9db6-4735-ab55-929b7ba55372"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#531a94c9-acde-4cd2-a165-b32dcf5a18da'>ToCode</a></td><td style='width:75%' class='def'><p><a name="531a94c9-acde-4cd2-a165-b32dcf5a18da"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="eaeb344a-9a94-4795-aa72-23372b339ee3"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="db158377-0afc-415d-826f-a4d1f3e88e2c"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b88a0ca9-178c-4f28-8610-6dba0a741192"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5c18738-d69b-4b3b-a8e3-4991577a00a7'>RelinkShape</a></td><td style='width:75%' ><p><a name="f5c18738-d69b-4b3b-a8e3-4991577a00a7"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="f721b1a6-b55a-4d2f-bfbb-99553898f946"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59992835-18a1-4ec5-ac5d-787bed88daca'>Clone</a></td><td style='width:75%' class='def'><p><a name="59992835-18a1-4ec5-ac5d-787bed88daca"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c6e7c2f-1953-47e4-9e48-4b878783fc0c'>ToolDown</a></td><td style='width:75%' ><p><a name="6c6e7c2f-1953-47e4-9e48-4b878783fc0c"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9fdeb684-469b-4f47-8783-acb76f947307"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="66171048-ed4f-42cb-822d-55aebf72d7d9"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="f5da13cf-54f0-4473-8339-df78d9c88126"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43752675-be6f-4d2a-b8fa-5abe259f0f9d'>ToolDrag</a></td><td style='width:75%' class='def'><p><a name="43752675-be6f-4d2a-b8fa-5abe259f0f9d"></a></p>

<h3>ToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handle the user dragging the selected <code>KimonoTool</code> on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="0de8505a-fd91-4255-9e60-e16196fc894b"></a>
The <code>SKPoint</code> representing the new tool position on the Design Surface.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c438c32a-7f5a-4c4e-a160-6f4ebdd4451d'>ToolUp</a></td><td style='width:75%' ><p><a name="c438c32a-7f5a-4c4e-a160-6f4ebdd4451d"></a></p>

<h3>ToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user lifting the current <code>KimonoTool</code> off of the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8efdfeb1-8d2e-42f5-83fc-2593f11ee14a"></a>
The <code>SKPoint</code> where the user lifted up the tool.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4b80a01-5bd1-49a7-9293-c153864f51bd'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="a4b80a01-5bd1-49a7-9293-c153864f51bd"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9246b82a-3208-4432-a6c6-eb291786baab'>RaiseSketchSizeChanged</a></td><td style='width:75%' ><p><a name="9246b82a-3208-4432-a6c6-eb291786baab"></a></p>

<h3>RaiseSketchSizeChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aefd3f4-ae63-4132-9193-e3bff4619747'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p><a name="3aefd3f4-ae63-4132-9193-e3bff4619747"></a></p>

<h3>RaiseSketchModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da6a5853-f3bc-4218-9b6c-8feebd5e2718'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' ><p><a name="da6a5853-f3bc-4218-9b6c-8feebd5e2718"></a></p>

<h3>RaiseImageBufferNeedsRefresh ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the image buffer needs refresh event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9888dcce-58fa-4551-9b83-67b212190c95'>RaiseSelectedShapeModified</a></td><td style='width:75%' class='def'><p><a name="9888dcce-58fa-4551-9b83-67b212190c95"></a></p>

<h3>RaiseSelectedShapeModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e71bc06-0fd6-4a8e-a1fd-8d987c5932d2'>RaiseSelectionChanged</a></td><td style='width:75%' ><p><a name="3e71bc06-0fd6-4a8e-a1fd-8d987c5932d2"></a></p>

<h3>RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="0e9a7910-499c-483a-b9d1-f2f0efdd8ee0"></a>
Selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e4adcb5-4e16-4d74-8e23-e74a0596c738'>RaiseToolChanged</a></td><td style='width:75%' class='def'><p><a name="9e4adcb5-4e16-4d74-8e23-e74a0596c738"></a></p>

<h3>RaiseToolChanged (KimonoCore.KimonoTool)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the tool changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="98d0b9ec-ec83-4652-a8e6-8abd33f966b7"></a>
The new <code>KimonoTool</code> that has been selected.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ddc6f1fc-817e-4a43-acd1-edaba801c383'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="ddc6f1fc-817e-4a43-acd1-edaba801c383"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41a822d1-130e-4c2f-b7da-89c17d631f88'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="41a822d1-130e-4c2f-b7da-89c17d631f88"></a></p>

<h3>SketchSizeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c79c845-9e99-41e8-bd8c-98b8748065fb'>SketchModified</a></td><td style='width:75%' ><p><a name="1c79c845-9e99-41e8-bd8c-98b8748065fb"></a></p>

<h3>SketchModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1dbfdc3e-fe09-4333-b5a7-f0b292db83c2'>ImageBufferNeedsRefresh</a></td><td style='width:75%' class='def'><p><a name="1dbfdc3e-fe09-4333-b5a7-f0b292db83c2"></a></p>

<h3>ImageBufferNeedsRefresh</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when image buffer needs refresh.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a58ab4d3-471e-4cc3-aea0-4f2ec8730d46'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="a58ab4d3-471e-4cc3-aea0-4f2ec8730d46"></a></p>

<h3>SelectedShapeModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18f426aa-0761-4b77-a3cb-628b54f1060e'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="18f426aa-0761-4b77-a3cb-628b54f1060e"></a></p>

<h3>SelectionChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#119f4323-7fb5-4cd7-b25b-1393ea931aac'>ToolChanged</a></td><td style='width:75%' ><p><a name="119f4323-7fb5-4cd7-b25b-1393ea931aac"></a></p>

<h3>ToolChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when tool changed.</p>
</td></tr></table></p>


---

<a name="284654eb-3139-48b3-80fb-bb05173130b0"></a>
##KimonoTool

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the current tool that is active in a `KimonoSketch` that the user can use to create or modify a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#322d9986-083e-43a6-988e-2a1cdbe1a68e'>Cursor</a></td><td style='width:75%' ><p><a name="322d9986-083e-43a6-988e-2a1cdbe1a68e"></a>
<b>Cursor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Cursor tool to modify an existing <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bad1818-7bcc-4b51-93c3-81c3ce80e301'>Line</a></td><td style='width:75%' class='def'><p><a name="7bad1818-7bcc-4b51-93c3-81c3ce80e301"></a>
<b>Line</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Line tool to add a new <code>KimonoShapeLine</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb90d4cf-a8c2-49a8-88b9-877341bd4026'>Arrow</a></td><td style='width:75%' ><p><a name="fb90d4cf-a8c2-49a8-88b9-877341bd4026"></a>
<b>Arrow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Arrow tool to add a new <code>KimonoShapeArrow</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8328756-f6bd-43d6-8158-722e1ce38d9b'>Rectangle</a></td><td style='width:75%' class='def'><p><a name="f8328756-f6bd-43d6-8158-722e1ce38d9b"></a>
<b>Rectangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Rectangle tool to add a new <code>KimonoShapeRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f579841-fae5-4ddd-bd07-cfd7a5e88c91'>Oval</a></td><td style='width:75%' ><p><a name="2f579841-fae5-4ddd-bd07-cfd7a5e88c91"></a>
<b>Oval</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Oval tool to add a new <code>KimonoShapeOval</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97965c1d-de54-4378-b321-3d9dca679540'>RoundRect</a></td><td style='width:75%' class='def'><p><a name="97965c1d-de54-4378-b321-3d9dca679540"></a>
<b>RoundRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Round Rect tool to add a new <code>KimonoShapeRoundRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33317850-3a5b-4598-bb58-d26c6a44e4b7'>Star</a></td><td style='width:75%' ><p><a name="33317850-3a5b-4598-bb58-d26c6a44e4b7"></a>
<b>Star</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Star tool to add a new <code>KimonoShapeStar</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cc91ee5-702f-428a-965f-0a74603932a7'>Polygon</a></td><td style='width:75%' class='def'><p><a name="5cc91ee5-702f-428a-965f-0a74603932a7"></a>
<b>Polygon</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Polygon tool to add a new <code>KimonoShapePolygon</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65973f88-1dfc-44ca-9c96-2992eb1957d8'>Triangle</a></td><td style='width:75%' ><p><a name="65973f88-1dfc-44ca-9c96-2992eb1957d8"></a>
<b>Triangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Triangle tool to add a new <code>KimonoShapeTriangle</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f708e8c-71bf-4cb1-b572-6311bc7d056f'>Vector</a></td><td style='width:75%' class='def'><p><a name="8f708e8c-71bf-4cb1-b572-6311bc7d056f"></a>
<b>Vector</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Vector tool to add a new <code>KimonoShapeVector</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3627ed59-1ab3-42c9-aec8-3d0e40ad2b0e'>Bezier</a></td><td style='width:75%' ><p><a name="3627ed59-1ab3-42c9-aec8-3d0e40ad2b0e"></a>
<b>Bezier</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Bezier tool to add a new <code>KimonoShapeBezier</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43ad2065-e0af-41ec-9d0b-1948d169c98a'>Text</a></td><td style='width:75%' class='def'><p><a name="43ad2065-e0af-41ec-9d0b-1948d169c98a"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Text tool to add a new <code>KimonoShapeText</code> to the sketch.</p>
</td></tr></table></p>


---

<a name="369f26bb-132a-44de-ac3a-456938da3ec6"></a>
##Kimono

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Holds a set of shared utilities that are used across the Kimono classes.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#db0d2949-e725-4901-b90d-65a0c13feba9'>CharIsNumber</a></td><td style='width:75%' ><p><a name="db0d2949-e725-4901-b90d-65a0c13feba9"></a></p>

<h3>CharIsNumber (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a number character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="d84b532b-de70-4c1f-8e52-67786040cec1"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is character is a number, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#866c757a-9a2f-481a-8d1e-e02ba9b20c43'>CharIsLetter</a></td><td style='width:75%' class='def'><p><a name="866c757a-9a2f-481a-8d1e-e02ba9b20c43"></a></p>

<h3>CharIsLetter (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a letter character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="723362df-58bb-46f7-9b2a-0bcb2c916064"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is letter was chared, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9784d091-209c-494c-8c76-70f367d85f4a'>IncrementName</a></td><td style='width:75%' ><p><a name="9784d091-209c-494c-8c76-70f367d85f4a"></a></p>

<h3>IncrementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increments the name by appending a number to the end or incrementing an existing number count.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="8323bf2b-b2bc-4756-b1a6-8b21323df66d"></a>
Name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8d31eb9-e28c-4dd9-b97f-b3f5a7633111'>CloneSKPoint</a></td><td style='width:75%' class='def'><p><a name="d8d31eb9-e28c-4dd9-b97f-b3f5a7633111"></a></p>

<h3>CloneSKPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPoint</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3239cd32-b68b-4d9c-8bc3-9a8355007995"></a>
The <code>SKPoint</code> to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A clone of the given point.</p>
</td></tr></table></p>


---

<a name="45274f98-41a0-4d87-83d6-39c6015172aa"></a>
##PortfolioEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Portfolio event delegate.

---

<a name="bc80c6f4-8e40-457e-9bf3-bc2d54d3745b"></a>
##SketchEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Sketch event delegate.

---

<a name="2348428d-ff22-4457-b73d-ad47c7c634e4"></a>
##StyleEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Style event delegate.

---

<a name="e1635637-a87c-49d6-97f8-5511c32090e1"></a>
##ShapeEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Shape event delegate.

---

<a name="51fc0191-a6fa-4204-9c7a-07d4ef78346c"></a>
##ToolEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Tool event delegate.

---

<a name="277c2732-d343-47ac-b003-1a664779ea4f"></a>
##SkiaPointEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Skia point event delegate.

---

<a name="b928ecbd-5a59-41b0-b5fb-af6b97e60ef4"></a>
##GroupEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Group event delegate.

---

<a name="ca8428db-1518-4597-9e41-fc484c6dc272"></a>
##ColorEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Color event delegate.

---

<a name="1b4ed685-c690-4cb6-837f-dcb63649c752"></a>
##SkiaColorEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Skia color event delegate.

---

<a name="65ba507b-e650-41e8-9c5a-937d9a66b0be"></a>
##GradientEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Gradient event delegate.

---

<a name="7e3e6fea-b6c4-4720-831d-c02c60128652"></a>
##HandleEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Handle event delegate.

---

<a name="b9856e1a-814d-4ebf-a70d-ef55044e3b54"></a>
##PropertyEventDelegate

###Namespace

[KimonoCore.Kimono](#7fccc05c-362e-4a7f-a653-dacaa896d627)

###Added In API Version

01.00.00

###Summary

Property event delegate.

---

<a name="ecbba92e-b462-49ac-ab96-64ed167264be"></a>
##KimonoPortfolio

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

A Kimono Portfolio holds a collection of `KimonoSketches`, `KimonoStyles` and `KimonoColors` that define a given Kimono Designer project.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#734c1868-ccc0-4fdc-9484-a00420fc2bc7'>_selectedSketch</a></td><td style='width:75%' ><p><a name="734c1868-ccc0-4fdc-9484-a00420fc2bc7"></a>
<b>_selectedSketch</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adfd548b-1b3b-49da-ba5e-57bc12f2f3ca'>NewSketchNumber</a></td><td style='width:75%' class='def'><p><a name="adfd548b-1b3b-49da-ba5e-57bc12f2f3ca"></a>
<b>NewSketchNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the number that will be assigned to the next new <code>KimonoSketch</code> created in this portfolio.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7f9dde7a-fd7d-4c2c-a305-bd5cb80f5c7a'>UniqueID</a></td><td style='width:75%' ><p><a name="7f9dde7a-fd7d-4c2c-a305-bd5cb80f5c7a"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf861059-54f4-437b-955e-da8d5c557e7f'>ElementName</a></td><td style='width:75%' class='def'><p><a name="bf861059-54f4-437b-955e-da8d5c557e7f"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f90cbe64-c4f5-4e47-a3df-af3530940ba1'>Name</a></td><td style='width:75%' ><p><a name="f90cbe64-c4f5-4e47-a3df-af3530940ba1"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04af47e1-fff8-4a18-8817-9425f53b9656'>Namespace</a></td><td style='width:75%' class='def'><p><a name="04af47e1-fff8-4a18-8817-9425f53b9656"></a></p>

<h3>Namespace</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the namespace.</p>

<h4>Return Value</h4>

<p>The namespace.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55d14521-c797-4645-8de1-3a08d0865780'>Author</a></td><td style='width:75%' ><p><a name="55d14521-c797-4645-8de1-3a08d0865780"></a></p>

<h3>Author</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the author.</p>

<h4>Return Value</h4>

<p>The author.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60cb2271-9c38-418d-9f32-372856906ebd'>Copyright</a></td><td style='width:75%' class='def'><p><a name="60cb2271-9c38-418d-9f32-372856906ebd"></a></p>

<h3>Copyright</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the copyright.</p>

<h4>Return Value</h4>

<p>The copyright.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e718156b-6649-4d40-94e4-c7f74567f898'>Sketches</a></td><td style='width:75%' ><p><a name="e718156b-6649-4d40-94e4-c7f74567f898"></a></p>

<h3>Sketches</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the sketches.</p>

<h4>Return Value</h4>

<p>The sketches.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4aec5945-87c2-4433-b6d4-adad5bbd6569'>Styles</a></td><td style='width:75%' class='def'><p><a name="4aec5945-87c2-4433-b6d4-adad5bbd6569"></a></p>

<h3>Styles</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the styles.</p>

<h4>Return Value</h4>

<p>The styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fb6a173-f44b-4113-bcf7-03e631f84831'>Colors</a></td><td style='width:75%' ><p><a name="4fb6a173-f44b-4113-bcf7-03e631f84831"></a></p>

<h3>Colors</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the colors.</p>

<h4>Return Value</h4>

<p>The colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f932b34-3da6-44bd-b0b0-541d1eae2d5f'>Gradients</a></td><td style='width:75%' class='def'><p><a name="9f932b34-3da6-44bd-b0b0-541d1eae2d5f"></a></p>

<h3>Gradients</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the gradients.</p>

<h4>Return Value</h4>

<p>The gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18119294-667f-4c9b-b2a3-37ab97b618de'>Properties</a></td><td style='width:75%' ><p><a name="18119294-667f-4c9b-b2a3-37ab97b618de"></a></p>

<h3>Properties</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the properties.</p>

<h4>Return Value</h4>

<p>The properties.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#875ebbd5-2d25-47b3-85d2-794b1cbc02f1'>SelectedSketch</a></td><td style='width:75%' class='def'><p><a name="875ebbd5-2d25-47b3-85d2-794b1cbc02f1"></a></p>

<h3>SelectedSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected sketch.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#312d40f5-5980-4bf4-9a43-d781a7e6e189'>KimonoPortfolio</a></td><td style='width:75%' ><p><a name="312d40f5-5980-4bf4-9a43-d781a7e6e189"></a></p>

<h3>KimonoPortfolio (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ecbba92e-b462-49ac-ab96-64ed167264be">KimonoPortfolio</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p><a name="0f264383-a932-4622-bb0b-921d62e14717"></a>
If <code>true</code>, the new instance will be initialized with the default values.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><code>initialize</code> is set to <code>false</code> when a clone is being made of given <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a046adc9-5ea0-49af-980f-84fdd6b55293'>Initialize</a></td><td style='width:75%' class='def'><p><a name="a046adc9-5ea0-49af-980f-84fdd6b55293"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f88efca-e57a-4c48-b07e-ba46dd82da4f'>FindSketch</a></td><td style='width:75%' ><p><a name="2f88efca-e57a-4c48-b07e-ba46dd82da4f"></a></p>

<h3>FindSketch (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoSketch</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="81e66ec1-eddf-4a0b-809a-3ce33913d07a"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoSketch</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3eee7252-881c-47de-b5f2-a607f9b914a1'>FindColor</a></td><td style='width:75%' class='def'><p><a name="3eee7252-881c-47de-b5f2-a607f9b914a1"></a></p>

<h3>FindColor (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoColor</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="663046dc-6be4-42e8-a846-bc9f759bc3db"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoColor</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e8e61f7-a498-4fa2-9923-1dbe9015805d'>FindProperty</a></td><td style='width:75%' ><p><a name="5e8e61f7-a498-4fa2-9923-1dbe9015805d"></a></p>

<h3>FindProperty (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoProperty</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="d7115332-8bd2-46c6-87dd-32a6150caf71"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoProperty</code> if founs, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e39c9209-1515-45c1-b907-ade6f6591aef'>FindGradient</a></td><td style='width:75%' class='def'><p><a name="e39c9209-1515-45c1-b907-ade6f6591aef"></a></p>

<h3>FindGradient (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the gradient by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="78b5119c-f0b9-4bbb-bf91-606aecf6a05d"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoGradient</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a51529c-7f52-4579-aa5a-200dfb25d6ea'>FindStyle</a></td><td style='width:75%' ><p><a name="7a51529c-7f52-4579-aa5a-200dfb25d6ea"></a></p>

<h3>FindStyle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoStyle</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="145a2aae-4ee0-4411-9142-a99819a046a7"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38cde85c-07c9-40d6-99e5-f56e4ddc069a'>AddNewSketch</a></td><td style='width:75%' class='def'><p><a name="38cde85c-07c9-40d6-99e5-f56e4ddc069a"></a></p>

<h3>AddNewSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoSketch</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23adfc55-492a-4528-be0b-20786a2b5c90'>DuplicateSelectedSketch</a></td><td style='width:75%' ><p><a name="23adfc55-492a-4528-be0b-20786a2b5c90"></a></p>

<h3>DuplicateSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d3ad767-de4f-4c28-a1e3-b304299d6374'>DeleteSelectedSketch</a></td><td style='width:75%' class='def'><p><a name="6d3ad767-de4f-4c28-a1e3-b304299d6374"></a></p>

<h3>DeleteSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc880190-bc2f-40cf-b327-6f6ea79ea868'>AddNewGradient</a></td><td style='width:75%' ><p><a name="dc880190-bc2f-40cf-b327-6f6ea79ea868"></a></p>

<h3>AddNewGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the new gradient.</p>

<h4>Returns</h4>

<p>The new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fefb1d5-8ca0-4d8c-9f03-b18199a03b11'>AddNewColor</a></td><td style='width:75%' class='def'><p><a name="5fefb1d5-8ca0-4d8c-9f03-b18199a03b11"></a></p>

<h3>AddNewColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio.</p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48555d4b-50d7-4f78-9951-5d447f6f5702'>AddNewColor</a></td><td style='width:75%' ><p><a name="48555d4b-50d7-4f78-9951-5d447f6f5702"></a></p>

<h3>AddNewColor (SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio based off of a given <code>SKColor</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="89c2e81c-24b9-4a18-9ae2-9e0f28b43745"></a>
Base color.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c19a2010-8aae-411c-ade4-3743b05ed6de'>AddPropertyBoolean</a></td><td style='width:75%' class='def'><p><a name="c19a2010-8aae-411c-ade4-3743b05ed6de"></a></p>

<h3>AddPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new boolean property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyBoolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f36d8369-6005-4534-a192-a61d237376cb'>AddPropertyColor</a></td><td style='width:75%' ><p><a name="f36d8369-6005-4534-a192-a61d237376cb"></a></p>

<h3>AddPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new color property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db309b4f-bbca-4868-a18a-8b50be4b7bb1'>AddPropertyGradient</a></td><td style='width:75%' class='def'><p><a name="db309b4f-bbca-4868-a18a-8b50be4b7bb1"></a></p>

<h3>AddPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new gradient property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07d2c1c5-4836-495f-9f17-b06b3224f3c8'>AddPropertyNumber</a></td><td style='width:75%' ><p><a name="07d2c1c5-4836-495f-9f17-b06b3224f3c8"></a></p>

<h3>AddPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new number property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyNumber</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14df7b85-ded5-447c-a013-9f723a8faaeb'>AddPropertyRect</a></td><td style='width:75%' class='def'><p><a name="14df7b85-ded5-447c-a013-9f723a8faaeb"></a></p>

<h3>AddPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new rect property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04dd9ff7-0fd6-4c14-a209-476511f01acb'>AddPropertyStyle</a></td><td style='width:75%' ><p><a name="04dd9ff7-0fd6-4c14-a209-476511f01acb"></a></p>

<h3>AddPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new style property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9ec49bb-8ec1-4547-a4ac-6c50c6074e75'>AddPropertyText</a></td><td style='width:75%' class='def'><p><a name="c9ec49bb-8ec1-4547-a4ac-6c50c6074e75"></a></p>

<h3>AddPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new text property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a59ff908-2e94-4363-b235-3ccb5613e983'>AddNewProperty</a></td><td style='width:75%' ><p><a name="a59ff908-2e94-4363-b235-3ccb5613e983"></a></p>

<h3>AddNewProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoProperty</code> to this portfolio</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="f8ab962f-cf85-4293-b519-46b7cac03bff"></a>
The <code>KimonoProperty</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2265d71-fac4-4ba0-8d9f-8c961f33c8a7'>DuplicateColor</a></td><td style='width:75%' class='def'><p><a name="f2265d71-fac4-4ba0-8d9f-8c961f33c8a7"></a></p>

<h3>DuplicateColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoColor</code> and adds it to the portfolio's collection of colors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="117e4b5f-4bef-460b-ae4c-3de1e6707af9"></a>
The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ac13ae1-482f-4da6-9299-74b9dcbfe466'>DuplicateProperty</a></td><td style='width:75%' ><p><a name="5ac13ae1-482f-4da6-9299-74b9dcbfe466"></a></p>

<h3>DuplicateProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="08808c41-9f63-43af-b9d2-6ff2eb57bce7"></a>
The <code>KimonoProperty</code> to duplicate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ca0908c-cf33-4230-850d-26ccc45565df'>DuplicateGradient</a></td><td style='width:75%' class='def'><p><a name="3ca0908c-cf33-4230-850d-26ccc45565df"></a></p>

<h3>DuplicateGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="b48c686c-feba-4f84-adb9-56cee1d424d8"></a>
The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49af625b-5338-42c2-a553-c6be8f314ce9'>DeleteColor</a></td><td style='width:75%' ><p><a name="49af625b-5338-42c2-a553-c6be8f314ce9"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="a074017d-a67f-4c36-91c2-e9307c0379d4"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d76abcd5-e647-4e3e-ab70-2a7f331d9a39'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="d76abcd5-e647-4e3e-ab70-2a7f331d9a39"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="4136a185-35f1-4281-bfa5-32739545dec5"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efe0daaf-eca2-4cfa-aaae-273004afd97c'>DeleteProperty</a></td><td style='width:75%' ><p><a name="efe0daaf-eca2-4cfa-aaae-273004afd97c"></a></p>

<h3>DeleteProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="b344ed64-a35a-4b73-9da0-b6467ff7c66c"></a>
The <code>KimonoProperty</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbb45a5d-f761-4b5c-af50-eb7bb5886a50'>AddNewStyle</a></td><td style='width:75%' class='def'><p><a name="cbb45a5d-f761-4b5c-af50-eb7bb5886a50"></a></p>

<h3>AddNewStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoStyle</code> to the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71ec7dca-d602-4e50-93e3-dc0611117f99'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="71ec7dca-d602-4e50-93e3-dc0611117f99"></a></p>

<h3>DuplicateStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoStyle</code> adding it to the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="652c2529-4991-4813-85a6-8febea79707e"></a>
The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c776ef40-368a-42f2-87f3-e2e4bc1c8071'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' class='def'><p><a name="c776ef40-368a-42f2-87f3-e2e4bc1c8071"></a></p>

<h3>ConvertSelectedShapeToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Takes the custom <code>KimonoStyle</code> of the currently selected <code>KimonoShape</code>, converts it to a named, shared style and adds it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48429591-fd35-452c-a335-fded8fec2f05'>DeleteStyle</a></td><td style='width:75%' ><p><a name="48429591-fd35-452c-a335-fded8fec2f05"></a></p>

<h3>DeleteStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoStyle</code> from the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="3f40088a-27c8-487a-9a7c-0f5003a705d7"></a>
Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7daaff8f-3fd6-4ed8-8ec6-8d86070e1e01'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="7daaff8f-3fd6-4ed8-8ec6-8d86070e1e01"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#123c0ef3-b261-445b-bea1-281b79db4740'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="123c0ef3-b261-445b-bea1-281b79db4740"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd4b99c9-1c87-48e7-a5bd-791bbf9e340f'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="dd4b99c9-1c87-48e7-a5bd-791bbf9e340f"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83b75df5-01f2-42ab-9192-d2ea63a88946'>ToCSharp</a></td><td style='width:75%' ><p><a name="83b75df5-01f2-42ab-9192-d2ea63a88946"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a02d1005-9257-4595-8228-5022f95f7cee"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdbac359-2369-41d2-8eed-25cfe80f0dea'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="cdbac359-2369-41d2-8eed-25cfe80f0dea"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d6117885-c295-41a9-b6f8-6cda0f963c7c"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="cf1532af-5829-4125-97c7-f5d10eb3fd62"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d66769-67f6-4f30-9736-18860927cb79'>ToCSharp</a></td><td style='width:75%' ><p><a name="a7d66769-67f6-4f30-9736-18860927cb79"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="3ce3b6e9-2e14-4e0b-a696-216a2f6e34fa"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6a7eb39-4bc8-447a-bc2b-f360dd909d08'>ToCSharpKimono</a></td><td style='width:75%' class='def'><p><a name="e6a7eb39-4bc8-447a-bc2b-f360dd909d08"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="aaedd8bf-b553-49e6-bf92-338d1d266af2"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8e7b8997-40ce-4abb-9a16-d03207871dd6"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d09ba044-a998-48bd-b818-be03645210dd"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64d5e65b-b7a0-4890-8b89-f7a82f9d9030'>ToCode</a></td><td style='width:75%' ><p><a name="64d5e65b-b7a0-4890-8b89-f7a82f9d9030"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="990ec56d-0607-4b7d-b11c-fe189a7ed0a0"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="2cc78190-7a95-43d2-8dd4-ff2998ad7962"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a7d28f24-abd7-45f5-8483-38e544cbb15f"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e086379f-5804-4656-9dcf-6c2af1e28092'>RelinkColors</a></td><td style='width:75%' class='def'><p><a name="e086379f-5804-4656-9dcf-6c2af1e28092"></a></p>

<h3>RelinkColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the colors after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c167a478-4c1b-4301-9e2a-8ea94631395c'>RelinkGradient</a></td><td style='width:75%' ><p><a name="c167a478-4c1b-4301-9e2a-8ea94631395c"></a></p>

<h3>RelinkGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the gradient after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="f41e8fd2-b6d9-4988-98cc-67347109771c"></a>
The <code>KimonoGradient</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ffad78b-9036-46f8-ba05-a6716662cf0a'>RelinkStyle</a></td><td style='width:75%' class='def'><p><a name="5ffad78b-9036-46f8-ba05-a6716662cf0a"></a></p>

<h3>RelinkStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoStyle</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="7153d1bf-3dd7-4c11-891e-776609a831fd"></a>
The <code>KimonoStyle</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b33f3002-1632-47f8-98c3-2bd9e8b2bb4c'>RelinkShape</a></td><td style='width:75%' ><p><a name="b33f3002-1632-47f8-98c3-2bd9e8b2bb4c"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoShape</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="002e52f8-0995-4ff9-9fb9-da7122244dc1"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c56b1d91-be9d-4746-aa8e-f0314f2a72b6'>RelinkSketch</a></td><td style='width:75%' class='def'><p><a name="c56b1d91-be9d-4746-aa8e-f0314f2a72b6"></a></p>

<h3>RelinkSketch (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoSketch</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="038221a3-1850-4631-841f-8ffaadf7edf7"></a>
The <code>KimonoSketch</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54581c17-24f7-4d56-b0e6-c95f872f82fd'>Clone</a></td><td style='width:75%' ><p><a name="54581c17-24f7-4d56-b0e6-c95f872f82fd"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2821e6c9-9f7d-448b-9de3-6d01cf32df3b'>RaisePropertyModified</a></td><td style='width:75%' class='def'><p><a name="2821e6c9-9f7d-448b-9de3-6d01cf32df3b"></a></p>

<h3>RaisePropertyModified (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the property modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="137e6dae-8498-4fbb-88f6-62a1ffe9de23"></a>
The <code>KimonoProperty</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb15080b-100d-4eb1-8f8b-9608cef16cff'>RaiseGradientsModified</a></td><td style='width:75%' ><p><a name="fb15080b-100d-4eb1-8f8b-9608cef16cff"></a></p>

<h3>RaiseGradientsModified (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradients modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="d8a6cb72-8fb3-4e70-9143-2279fc9c43f4"></a>
The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#496dd3e0-dc9a-4e48-984b-b8df72cef856'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="496dd3e0-dc9a-4e48-984b-b8df72cef856"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e43d7bae-0705-4f36-a092-8f0cb41d3973'>RaiseSketchesModified</a></td><td style='width:75%' ><p><a name="e43d7bae-0705-4f36-a092-8f0cb41d3973"></a></p>

<h3>RaiseSketchesModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce5365ac-74a5-4808-a84a-c3e9679fa056'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' class='def'><p><a name="ce5365ac-74a5-4808-a84a-c3e9679fa056"></a></p>

<h3>RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch will change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="9f87fad6-ea1f-487e-b714-512a8dea97ba"></a>
The <code>KimonoSketch</code> that will change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aea494c5-bce1-49bf-808e-fbb22cb8e044'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' ><p><a name="aea494c5-bce1-49bf-808e-fbb22cb8e044"></a></p>

<h3>RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch did change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="b0b4101d-f1ea-4977-85f6-b09e112def2f"></a>
The <code>KimonoSketch</code> that did change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cabbc092-742c-42dd-92cb-0eb2528b0518'>RaiseStylesModified</a></td><td style='width:75%' class='def'><p><a name="cabbc092-742c-42dd-92cb-0eb2528b0518"></a></p>

<h3>RaiseStylesModified (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the styles modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="5a0df8e9-fc6d-44de-9ab8-725767958828"></a>
The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5331304f-c7f1-437a-a22f-601ab07e284c'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p><a name="5331304f-c7f1-437a-a22f-601ab07e284c"></a></p>

<h3>RaiseSelectedShapeChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="e144c84f-076a-478d-81cb-474ba1120f37"></a>
The new <code>KimonoShape</code> that was selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f416f95a-9a3f-41fe-a59b-547506e3664d'>RaiseColorsModified</a></td><td style='width:75%' class='def'><p><a name="f416f95a-9a3f-41fe-a59b-547506e3664d"></a></p>

<h3>RaiseColorsModified (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the colors modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="5924fe55-d9e6-4c63-9951-c9a29d711995"></a>
The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e8582c0e-ac3b-47a1-ab62-890f48bdb01e'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="e8582c0e-ac3b-47a1-ab62-890f48bdb01e"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59a912a2-44a5-40f8-8c1d-0acd294ca12f'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="59a912a2-44a5-40f8-8c1d-0acd294ca12f"></a></p>

<h3>SketchesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9927f36f-c379-4c09-aea3-9b96f0e4057f'>SelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="9927f36f-c379-4c09-aea3-9b96f0e4057f"></a></p>

<h3>SelectedSketchWillChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch will change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#095e74a6-0043-40bb-92e8-904d0491c450'>SelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="095e74a6-0043-40bb-92e8-904d0491c450"></a></p>

<h3>SelectedSketchDidChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa8e43d5-f961-4b8b-b323-825a9e76274e'>StylesModified</a></td><td style='width:75%' ><p><a name="fa8e43d5-f961-4b8b-b323-825a9e76274e"></a></p>

<h3>StylesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when styles collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#508fa604-1655-416c-bcee-7f4121f71c83'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p><a name="508fa604-1655-416c-bcee-7f4121f71c83"></a></p>

<h3>SelectedShapeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e88d6d8-ebb7-4fae-9b38-dfbe70a4a313'>ColorsModified</a></td><td style='width:75%' ><p><a name="6e88d6d8-ebb7-4fae-9b38-dfbe70a4a313"></a></p>

<h3>ColorsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c37526a-fb21-429b-afc4-04f78e7ec8cd'>GradientsModified</a></td><td style='width:75%' class='def'><p><a name="4c37526a-fb21-429b-afc4-04f78e7ec8cd"></a></p>

<h3>GradientsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aba57be-9cd6-4456-bb5c-2296e089f085'>PropertyModified</a></td><td style='width:75%' ><p><a name="3aba57be-9cd6-4456-bb5c-2296e089f085"></a></p>

<h3>PropertyModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when property collection is modified.</p>
</td></tr></table></p>


---

<a name="83854443-b690-4644-be64-899248d0c626"></a>
##KimonoUndoHandler

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Handles the undo/redo state for a `KimonoDesignSurface`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e781da90-9b99-401e-8ae4-01b91df1bf7e'>MaximumUndoPoints</a></td><td style='width:75%' ><p><a name="e781da90-9b99-401e-8ae4-01b91df1bf7e"></a></p>

<h3>MaximumUndoPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the maximum undo points.</p>

<h4>Return Value</h4>

<p>The maximum undo points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64038057-b7a2-4dcc-9361-b4326a137d42'>UndoStack</a></td><td style='width:75%' class='def'><p><a name="64038057-b7a2-4dcc-9361-b4326a137d42"></a></p>

<h3>UndoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the undo stack.</p>

<h4>Return Value</h4>

<p>The undo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#431cdd27-13ff-463f-a5a7-ac985b34a80d'>RedoStack</a></td><td style='width:75%' ><p><a name="431cdd27-13ff-463f-a5a7-ac985b34a80d"></a></p>

<h3>RedoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the redo stack.</p>

<h4>Return Value</h4>

<p>The redo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5890a880-5988-4bd1-8eef-1679d7e493a0'>CanUndo</a></td><td style='width:75%' class='def'><p><a name="5890a880-5988-4bd1-8eef-1679d7e493a0"></a></p>

<h3>CanUndo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can undo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can undo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45aed9dc-75b7-4777-a5b4-5ba8258afecd'>CanRedo</a></td><td style='width:75%' ><p><a name="45aed9dc-75b7-4777-a5b4-5ba8258afecd"></a></p>

<h3>CanRedo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can redo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can redo; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e0c8b402-d25e-46a1-b6de-6e0dfb79ef70'>KimonoUndoHandler</a></td><td style='width:75%' ><p><a name="e0c8b402-d25e-46a1-b6de-6e0dfb79ef70"></a></p>

<h3>KimonoUndoHandler ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#83854443-b690-4644-be64-899248d0c626">KimonoUndoHandler</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54fec2f2-5ff8-4fd6-a008-c8bbd908223d'>PushUndoPoint</a></td><td style='width:75%' class='def'><p><a name="54fec2f2-5ff8-4fd6-a008-c8bbd908223d"></a></p>

<h3>PushUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pushes the undo point onto the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="de187730-2597-48f0-a442-6834e187af29"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05cdad35-3155-46e9-a5b4-cb3a39dacb00'>ReplaceLastUndoPoint</a></td><td style='width:75%' ><p><a name="05cdad35-3155-46e9-a5b4-cb3a39dacb00"></a></p>

<h3>ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Replaces the last undo point with the one being passed in.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="32d14404-c24d-42fd-b675-11f297eada93"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfc43473-f452-409a-ab0f-635567ecd105'>PopUndoPoint</a></td><td style='width:75%' class='def'><p><a name="bfc43473-f452-409a-ab0f-635567ecd105"></a></p>

<h3>PopUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the undo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="9f3e8178-7218-4f61-acfa-e5b7c5d48d8c"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The prior state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f7cc6bd-9b51-43d7-a820-cd167c876dc2'>PopRedoPoint</a></td><td style='width:75%' ><p><a name="0f7cc6bd-9b51-43d7-a820-cd167c876dc2"></a></p>

<h3>PopRedoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the redo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="11ada3a3-fcd6-4109-9855-fdf678b27812"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The previous state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17fc20a7-f386-4f47-a599-fb7ff6006ff5'>RaiseUndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="17fc20a7-f386-4f47-a599-fb7ff6006ff5"></a></p>

<h3>RaiseUndoStateChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the undo state changed event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c77702ef-d31e-48e3-85b0-d09289872e71'>UndoStateChanged</a></td><td style='width:75%' ><p><a name="c77702ef-d31e-48e3-85b0-d09289872e71"></a></p>

<h3>UndoStateChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="8f377bd2-8962-4de7-a4f3-fd29bb80d9cf"></a>
##KimonoShape

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the based shape that all other Kimono Shape types will inherit from.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f3db2677-66c7-497d-971b-6bc47ff9b267'>_name</a></td><td style='width:75%' ><p><a name="f3db2677-66c7-497d-971b-6bc47ff9b267"></a>
<b>_name</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default name of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc79dc8a-45d6-4219-8f59-9984f5762bfa'>_style</a></td><td style='width:75%' class='def'><p><a name="dc79dc8a-45d6-4219-8f59-9984f5762bfa"></a>
<b>_style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default, custom <code>KimonoStyle</code> that is attached to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c04f777-691e-4dcd-934c-0528c97b58a3'>_visible</a></td><td style='width:75%' ><p><a name="1c04f777-691e-4dcd-934c-0528c97b58a3"></a>
<b>_visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8a21171e-9f17-46b8-8f12-04d9963874e8'>Name</a></td><td style='width:75%' ><p><a name="8a21171e-9f17-46b8-8f12-04d9963874e8"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4310501-6b4a-4dc8-a3d3-a27559bbdc13'>ElementName</a></td><td style='width:75%' class='def'><p><a name="a4310501-6b4a-4dc8-a3d3-a27559bbdc13"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df4a8a76-35e8-4d9d-89ec-e6345a100f33'>Style</a></td><td style='width:75%' ><p><a name="df4a8a76-35e8-4d9d-89ec-e6345a100f33"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> that will be used to draw this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c65dbe2-75dd-4b97-8ecf-6a6ff3071560'>ControlPoints</a></td><td style='width:75%' class='def'><p><a name="9c65dbe2-75dd-4b97-8ecf-6a6ff3071560"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the path of the shape.</p>

<h4>Return Value</h4>

<p>A collection of <code>KimonoHandle</code> objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16a4a89a-eef7-4ffc-90ee-38175f8f2c01'>Visible</a></td><td style='width:75%' ><p><a name="16a4a89a-eef7-4ffc-90ee-38175f8f2c01"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8f377bd2-8962-4de7-a4f3-fd29bb80d9cf">KimonoShape</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1f76d68-f214-4b81-8f4c-f31a891a9dfc'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="e1f76d68-f214-4b81-8f4c-f31a891a9dfc"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#8f377bd2-8962-4de7-a4f3-fd29bb80d9cf">KimonoShape</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>An "Editable Shape" is one that is composed of a set of data points (such as <code>KimonoVector</code> or <code>KimonoBezier</code>) or a group of objects (such as <code>KimonoShapeGroup</code>).</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12b21838-c945-47e0-a764-5a864d783151'>LayerDepth</a></td><td style='width:75%' ><p><a name="12b21838-c945-47e0-a764-5a864d783151"></a></p>

<h3>LayerDepth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.</p>

<h4>Return Value</h4>

<p>The layer depth.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6081325d-838d-45f9-bdf8-1739db745c5a'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="6081325d-838d-45f9-bdf8-1739db745c5a"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c158038-bf17-4055-b9d6-65e8d2fd7757'>PropertyConnections</a></td><td style='width:75%' ><p><a name="4c158038-bf17-4055-b9d6-65e8d2fd7757"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ef1c41db-1d87-45ec-8496-eef801caee57'>KimonoShape</a></td><td style='width:75%' ><p><a name="ef1c41db-1d87-45ec-8496-eef801caee57"></a></p>

<h3>KimonoShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8f377bd2-8962-4de7-a4f3-fd29bb80d9cf">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c9908f7-dbd2-470b-98eb-2481fee8818f'>KimonoShape</a></td><td style='width:75%' class='def'><p><a name="0c9908f7-dbd2-470b-98eb-2481fee8818f"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8f377bd2-8962-4de7-a4f3-fd29bb80d9cf">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="a199db1c-bda6-4199-a516-f04464928e11"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="5293d046-f79a-4ea4-868e-843187be313d"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="095b3439-2a66-4850-88e5-2786ae6c3508"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="4f7a3acd-4cbf-4746-98d4-c561cb3a12a1"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6394e731-cd83-4904-9cb1-981c0d6c3dd4'>KimonoShape</a></td><td style='width:75%' ><p><a name="6394e731-cd83-4904-9cb1-981c0d6c3dd4"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8f377bd2-8962-4de7-a4f3-fd29bb80d9cf">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="96f78f56-6534-464b-a514-73030779df16"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="35224577-b1fe-414f-bcbe-e55e292a0562"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="54b15699-d148-42bf-bc88-e568008bb6d1"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="9c368578-0c13-4ca6-909f-1b967e7232d4"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="9d4b5191-6b55-4ef8-95f1-88cddb498659"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34cef2df-3a73-4b50-a2c7-0b7b5cd126ab'>Initialize</a></td><td style='width:75%' class='def'><p><a name="34cef2df-3a73-4b50-a2c7-0b7b5cd126ab"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43637c62-4959-4ba5-94b1-dd1e4506e86a'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="43637c62-4959-4ba5-94b1-dd1e4506e86a"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="114d6825-d5f7-4d70-ae0e-c5bce7500eea"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="65f8a80a-b647-4eea-bcaa-445742674c86"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c72eb537-b45f-4d9e-9e33-5a32435a7aaa'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="c72eb537-b45f-4d9e-9e33-5a32435a7aaa"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="635e3c0e-4589-4e9b-b1b5-f753694a5ff1"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fb9aaaa-271a-4848-8bb7-b5b1d4fb5d7d'>RemoveProperty</a></td><td style='width:75%' ><p><a name="2fb9aaaa-271a-4848-8bb7-b5b1d4fb5d7d"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="a9450e94-bb5e-45b3-a1fa-5d4e81723fc8"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d682240d-063d-4241-94b6-f7b2b3a9c166'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="d682240d-063d-4241-94b6-f7b2b3a9c166"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoShape</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa5ee356-28f2-43db-b837-b2d79afec27c'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="aa5ee356-28f2-43db-b837-b2d79afec27c"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="bcce667b-11ac-4341-824c-34e0f620af27"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d922a36b-ba33-4e55-9900-3a141bf29b56'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="d922a36b-ba33-4e55-9900-3a141bf29b56"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape in the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#579a7b4c-337e-458c-b2d7-a71a196be08f'>EndEditing</a></td><td style='width:75%' ><p><a name="579a7b4c-337e-458c-b2d7-a71a196be08f"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d472bf62-c1b9-43db-8ae3-94253b7bd4b3'>UncoupleDeletedStyle</a></td><td style='width:75%' class='def'><p><a name="d472bf62-c1b9-43db-8ae3-94253b7bd4b3"></a></p>

<h3>UncoupleDeletedStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Uncouples the deleted style from the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p><a name="375e3c16-328d-45c4-80f8-f5da8bc3ddfa"></a>
The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2cc11b9-b5f7-4af3-b108-31cb4fbe0ac3'>ConformGradientToShape</a></td><td style='width:75%' ><p><a name="a2cc11b9-b5f7-4af3-b108-31cb4fbe0ac3"></a></p>

<h3>ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the gradient to shape by fitting it to the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="d52e1432-5051-4b0b-8dfa-d48e6f2c5b15"></a>
The <code>KimonoGradient</code> to conform.</p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p><a name="c2d14b6d-ac13-4276-8d79-6ede0289d01b"></a>
The <code>SKPaint</code> that the gradient is being attached to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b02d5fa3-3c77-4000-b80e-7ffca321ab0a'>ToVector</a></td><td style='width:75%' class='def'><p><a name="b02d5fa3-3c77-4000-b80e-7ffca321ab0a"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a vector.</p>

<h4>Returns</h4>

<p>The shape as a <code>KimonoVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07e83789-ae8d-43cd-88bb-614258d68fcd'>ToPath</a></td><td style='width:75%' ><p><a name="07e83789-ae8d-43cd-88bb-614258d68fcd"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f2e5786-84e9-48f9-9e7a-2629f3a0a29e'>StyleFillPaintForCode</a></td><td style='width:75%' class='def'><p><a name="8f2e5786-84e9-48f9-9e7a-2629f3a0a29e"></a></p>

<h3>StyleFillPaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style fill paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f5db998-c9d2-4a0b-9e60-2f3bf8c8ef07'>StyleFramePaintForCode</a></td><td style='width:75%' ><p><a name="3f5db998-c9d2-4a0b-9e60-2f3bf8c8ef07"></a></p>

<h3>StyleFramePaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style frame paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#954bc2ad-1089-46dc-ae86-b56f44732664'>ConformedFillGradientCode</a></td><td style='width:75%' class='def'><p><a name="954bc2ad-1089-46dc-ae86-b56f44732664"></a></p>

<h3>ConformedFillGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9ed1c9c5-ddde-4f89-ad1e-49fcca16b7b9"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The fill gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23d3580b-2c88-46e4-a569-a0c7826e418a'>ConformedFrameGradientCode</a></td><td style='width:75%' ><p><a name="23d3580b-2c88-46e4-a569-a0c7826e418a"></a></p>

<h3>ConformedFrameGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="19000ad8-dd35-428f-8d6e-046d2441761a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The frame gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#524ca1e5-6ac0-4608-abfc-2d373ca35c55'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="524ca1e5-6ac0-4608-abfc-2d373ca35c55"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2df68d9e-373f-4475-ae2e-deb4e9ef5d4a'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="2df68d9e-373f-4475-ae2e-deb4e9ef5d4a"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e738e985-7336-42b5-bae8-9007a4ba31cb'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="e738e985-7336-42b5-bae8-9007a4ba31cb"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da7e3af9-d2b7-4394-a2d2-b1e6abf90539'>ToCSharp</a></td><td style='width:75%' ><p><a name="da7e3af9-d2b7-4394-a2d2-b1e6abf90539"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b3192a00-fc9b-4c35-b211-d31592e4b246"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b84ec230-ddfd-4d36-b933-e5e0111c964d'>ToCode</a></td><td style='width:75%' class='def'><p><a name="b84ec230-ddfd-4d36-b933-e5e0111c964d"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="4d3fcf9d-8088-4c19-aa78-9a50636e92ba"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5023c422-c9ca-4d28-9947-ed2fbc70b6c6"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2f846f1c-946d-45a2-8c7f-c57751e118e6"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08cce8ae-7e94-4244-887e-aab9de5b6ff4'>CloneAttachedStyle</a></td><td style='width:75%' ><p><a name="08cce8ae-7e94-4244-887e-aab9de5b6ff4"></a></p>

<h3>CloneAttachedStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the attached style.</p>

<h4>Returns</h4>

<p>A duplicate <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71247315-5a26-473e-ac8a-a19f6ea22a09'>Clone</a></td><td style='width:75%' class='def'><p><a name="71247315-5a26-473e-ac8a-a19f6ea22a09"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of this shape as a base <code>KimonoBounds</code>.</p>
</td></tr></table></p>


---

<a name="ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2"></a>
##KimonoShapeArrow

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws either an outlined or single line arrow with heads on one or both ends.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#76327305-47fe-4e51-9c15-7fc285249efa'>HasStartHead</a></td><td style='width:75%' ><p><a name="76327305-47fe-4e51-9c15-7fc285249efa"></a></p>

<h3>HasStartHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2">KimonoShapeArrow</a> has start head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has start head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3130d00-baa3-4474-93eb-79ed6b795296'>HasEndHead</a></td><td style='width:75%' class='def'><p><a name="e3130d00-baa3-4474-93eb-79ed6b795296"></a></p>

<h3>HasEndHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2">KimonoShapeArrow</a> has end head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has end head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fddc86ce-48e4-47ed-8ea1-642174047c4c'>HeadInnerRatio</a></td><td style='width:75%' ><p><a name="fddc86ce-48e4-47ed-8ea1-642174047c4c"></a></p>

<h3>HeadInnerRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head inner ratio.</p>

<h4>Return Value</h4>

<p>The head inner ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80dac4ee-7bb2-42b7-863f-871b06061ec8'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p><a name="80dac4ee-7bb2-42b7-863f-871b06061ec8"></a></p>

<h3>HeadOuterRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head outer ratio.</p>

<h4>Return Value</h4>

<p>The head outer ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8946163c-4b6d-45bc-8b2d-d7c0c69866f9'>IsStreamlined</a></td><td style='width:75%' ><p><a name="8946163c-4b6d-45bc-8b2d-d7c0c69866f9"></a></p>

<h3>IsStreamlined</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2">KimonoShapeArrow</a> is streamlined.</p>

<h4>Return Value</h4>

<p><code>true</code> if is streamlined; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>A Streamlined Arrow, is drawn as a single line.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#001c52a8-dda8-43a3-91a9-2d157c881319'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="001c52a8-dda8-43a3-91a9-2d157c881319"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ddee9c3b-455a-4b84-8065-541ed55d4826'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="ddee9c3b-455a-4b84-8065-541ed55d4826"></a></p>

<h3>KimonoShapeArrow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ff36be9-add7-4af0-a1ff-57298fd8944e'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p><a name="7ff36be9-add7-4af0-a1ff-57298fd8944e"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="99ec22b0-1a75-467e-8d17-853e2c98c10d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a5c3e247-b403-41ba-a6e7-b61f498d3e14"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="0db0f87d-bdba-423a-b53a-56d260bf2770"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b22a9534-504c-4739-bd1f-4ea8129da21b"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a788dae-853a-4d51-86ee-018a742e4303'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="9a788dae-853a-4d51-86ee-018a742e4303"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ce34dfb2-8357-4f4c-bb00-3a5ecff67ae2">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8828be55-d28b-4a41-ab0c-64b421a33ade"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="0e9a605e-76ad-4938-acc5-408f821716bb"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="832147a7-f2df-4de7-8edd-045028dad5f0"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="05506684-746d-487d-af8d-9baeb6c66747"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="0c523c7e-bd72-4d3a-841b-fa7a84d82618"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#678a8cca-2eac-432b-bfd4-b5a699709fc6'>Initialize</a></td><td style='width:75%' class='def'><p><a name="678a8cca-2eac-432b-bfd4-b5a699709fc6"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ba90386-2ad6-477b-93c1-1b6a2cacba39'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="0ba90386-2ad6-477b-93c1-1b6a2cacba39"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="2a8b1c22-621e-47f7-bc2c-7a4ef73c7c56"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf3e486d-182b-4727-b766-8c752ab03d08'>ToPath</a></td><td style='width:75%' class='def'><p><a name="cf3e486d-182b-4727-b766-8c752ab03d08"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the arrow to a path.</p>

<h4>Returns</h4>

<p>The the arrow as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#351e5875-7cae-4cb1-801a-12f689e38c28'>Draw</a></td><td style='width:75%' ><p><a name="351e5875-7cae-4cb1-801a-12f689e38c28"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the arrow into the specified Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="b4cb09b6-9549-42de-8a34-31e24f70f53a"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f030693-26ec-4700-92c4-b327b3911265'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="9f030693-26ec-4700-92c4-b327b3911265"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the arrow.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="44f4970a-3967-4baa-b218-4215168c4756"></a>
The <code>SKPoint</code> containing the bounds adjustment.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce31922d-537c-4f9a-9132-4353a42089a1'>DragBounds</a></td><td style='width:75%' ><p><a name="ce31922d-537c-4f9a-9132-4353a42089a1"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the arrow to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3092776d-a3f0-4a99-9fdb-c75cc70da294"></a>
The <code>SKPoint</code> specifying the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d2311c1-2779-4062-85d2-3063e7893dde'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="0d2311c1-2779-4062-85d2-3063e7893dde"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e078fb8f-89c2-4715-a933-c7972ede5063'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="e078fb8f-89c2-4715-a933-c7972ede5063"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7edc771d-3b6c-472d-9211-1c05ea8659fe'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="7edc771d-3b6c-472d-9211-1c05ea8659fe"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2af5453f-5164-456d-b224-b158819ab7a1'>ToCSharp</a></td><td style='width:75%' ><p><a name="2af5453f-5164-456d-b224-b158819ab7a1"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9fb1c7b0-da2d-4ec3-9724-1d3573a52443"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a847c48-6f04-4d8b-90b0-e61e3fb2fe75'>ToCode</a></td><td style='width:75%' class='def'><p><a name="3a847c48-6f04-4d8b-90b0-e61e3fb2fe75"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="99d533c5-a48e-4083-8fcd-ed20295a1e53"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="1eebdbce-1929-4d69-aff5-911f4438e14f"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a9fdad0e-0238-45aa-9361-79d1887da290"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b5e4de7-3660-4d48-9d6f-c4be67bde8c1'>Clone</a></td><td style='width:75%' ><p><a name="2b5e4de7-3660-4d48-9d6f-c4be67bde8c1"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoArrow</code>.</p>
</td></tr></table></p>


---

<a name="a5bec955-533b-4294-a2f8-d2c1471fc4b8"></a>
##KimonoShapeBezier

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#08ad22a8-7a8c-4b60-948d-cc76b6d8144c'>Points</a></td><td style='width:75%' ><p><a name="08ad22a8-7a8c-4b60-948d-cc76b6d8144c"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a8691a4-96d1-4cf0-a70b-49fb27815e00'>Closed</a></td><td style='width:75%' class='def'><p><a name="8a8691a4-96d1-4cf0-a70b-49fb27815e00"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5c6c074-fc26-4c93-a3a8-23c1202e5ff9'>IsEditable</a></td><td style='width:75%' ><p><a name="b5c6c074-fc26-4c93-a3a8-23c1202e5ff9"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6db02e80-0038-4e9c-b4ae-e564d416df10'>LastPoint</a></td><td style='width:75%' class='def'><p><a name="6db02e80-0038-4e9c-b4ae-e564d416df10"></a></p>

<h3>LastPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the last point in the collection of control points.</p>

<h4>Return Value</h4>

<p>The last point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#41a56b17-ded5-450d-a052-e00ed9cbf3d7'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="41a56b17-ded5-450d-a052-e00ed9cbf3d7"></a></p>

<h3>KimonoShapeBezier ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a5bec955-533b-4294-a2f8-d2c1471fc4b8">KimonoShapeBezier</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d09acb31-3b61-4bc0-861c-c69d9d50c7bd'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p><a name="d09acb31-3b61-4bc0-861c-c69d9d50c7bd"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a5bec955-533b-4294-a2f8-d2c1471fc4b8">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="90c9b0ea-628c-472d-8d72-812cb83e66bb"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a34bd650-75ee-447d-9d78-2825f01501cf"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="fb3aa4c6-9f24-4ff4-bae9-2640426f0bef"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="90b36e0a-a25b-4fd6-8e19-e1facdea743c"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#309767a9-0ebd-42d6-9096-c237013b7fb0'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="309767a9-0ebd-42d6-9096-c237013b7fb0"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a5bec955-533b-4294-a2f8-d2c1471fc4b8">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6c82ae91-9424-42b3-aab9-cd7943c30730"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a7ce90de-8c1e-42b3-8cb5-990fcbb2caa1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f1f09382-9f47-4944-93be-4347d4c0aca6"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="90057a1b-fa94-42bc-8aac-ee0edbb5c201"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="3c442514-f82e-4c85-8a14-ab4db75f605c"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a4f1529-61f3-4c00-91f9-31adca40f8ac'>Initialize</a></td><td style='width:75%' class='def'><p><a name="4a4f1529-61f3-4c00-91f9-31adca40f8ac"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3342ca2-8031-4b4c-9860-527ea07b7368'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="e3342ca2-8031-4b4c-9860-527ea07b7368"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89101e22-6662-408c-845d-2369cde353e0'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="89101e22-6662-408c-845d-2369cde353e0"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="fa2d15be-a73c-480e-9082-6d827a819ef4"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="2c9bcf6b-33e5-4898-bc0b-243fd6a58eee"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8889161-9466-4134-9a25-eb06c12d4341'>AddPoint</a></td><td style='width:75%' ><p><a name="b8889161-9466-4134-9a25-eb06c12d4341"></a></p>

<h3>AddPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="2fd9ae49-59b4-4eb7-83eb-d3e3df81b6cd"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="7fdac772-4347-43bb-8088-968244fc9500"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="58f09d9b-0085-4e6d-8714-295441f60772"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="c44cc04a-2512-43a6-9afa-a37b1d18e7f8"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f9a5df8-fe43-4922-9c5a-65c20c4c8632'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="5f9a5df8-fe43-4922-9c5a-65c20c4c8632"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9445669b-ec4a-48f9-ab97-bf24f7084914"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afb6723b-c2bb-48a4-a03a-7c01b4808223'>AddHandlesForPoint</a></td><td style='width:75%' ><p><a name="afb6723b-c2bb-48a4-a03a-7c01b4808223"></a></p>

<h3>AddHandlesForPoint (System.Int32, KimonoCore.KimonoBezierPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the handles for the given bezier point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="80d47354-6d7f-4b9b-9088-09a668146b53"></a>
The index of the <code>KimonoBezierPoint</code> that handles are being created for.</p>
</td></tr><tr><td style='width:25%' class='term'>bezierPoint</td><td style='width:75%' class='def'><p><a name="f543948c-bf6b-489a-91f1-eca66f8a271b"></a>
The <code>KimonoBezierPoint</code> that is getting handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ff795a0-9aac-44f9-9762-f0a514e27e8e'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="8ff795a0-9aac-44f9-9762-f0a514e27e8e"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="5451e604-e5c1-4ceb-b259-093a88d2ecd9"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6de7a30-8a31-4832-a58d-1587689ff798'>RemovePoint</a></td><td style='width:75%' ><p><a name="e6de7a30-8a31-4832-a58d-1587689ff798"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="8e3dea1c-6209-43e6-9744-45d2c2318743"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5a78d4b-11c8-417d-80b6-aaf51241895a'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="d5a78d4b-11c8-417d-80b6-aaf51241895a"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1c5c515-d2a7-46f7-9bf8-5edb59776396'>ToPath</a></td><td style='width:75%' ><p><a name="b1c5c515-d2a7-46f7-9bf8-5edb59776396"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#967aaf9e-810e-4616-bf98-adc5cc43fa50'>Draw</a></td><td style='width:75%' class='def'><p><a name="967aaf9e-810e-4616-bf98-adc5cc43fa50"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="5c9104bd-cb58-47fd-a651-5ad7f97bed97"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cd5832e-70cd-4783-b0f0-e9a7d3eb4154'>PointInBound</a></td><td style='width:75%' ><p><a name="3cd5832e-70cd-4783-b0f0-e9a7d3eb4154"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="454edabd-83c7-4c3e-bfbd-f783df3cf1f6"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#479a1a0e-0c0d-488e-9b17-a1382b67f97c'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="479a1a0e-0c0d-488e-9b17-a1382b67f97c"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="11a9dca6-c493-46c3-ae78-f7b6f35543b5"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f6b4f91-174d-4481-8599-87d6a34038a7'>BoundsChanged</a></td><td style='width:75%' ><p><a name="0f6b4f91-174d-4481-8599-87d6a34038a7"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e829951e-f330-447e-8166-1595d430c358'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="e829951e-f330-447e-8166-1595d430c358"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e57f36bd-832b-4865-9f2d-2a650b4d327b'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="e57f36bd-832b-4865-9f2d-2a650b4d327b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#169fb0ba-40a9-4fea-be9f-9f6848c4b4b0'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="169fb0ba-40a9-4fea-be9f-9f6848c4b4b0"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1663955a-f753-472b-b01b-dd5a6c66aab1'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="1663955a-f753-472b-b01b-dd5a6c66aab1"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9457f522-fb4a-44da-9142-feb834c32dc7'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="9457f522-fb4a-44da-9142-feb834c32dc7"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9b1a3996-5210-4356-837b-771ef7196282"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2363043b-59fc-47b9-9d7c-16f674373e4b'>ToCode</a></td><td style='width:75%' ><p><a name="2363043b-59fc-47b9-9d7c-16f674373e4b"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="93c60dc0-ca5e-4edc-85f5-0179cea821b1"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="1a2df168-fed9-4591-84dd-a7986a2ad08b"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="af54b943-f932-4ddd-a64b-c8e5c1a9cfcc"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32865e8e-8bbf-4539-9eee-de5aa12c24a7'>Clone</a></td><td style='width:75%' class='def'><p><a name="32865e8e-8bbf-4539-9eee-de5aa12c24a7"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="f23ef71d-24e2-4f80-9edf-d289d5f55f3f"></a>
##KimonoShapeGroup

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

A `KimonoShapeGroup` holds a collection of `KimonoShapes` that can be acted upon as a group.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#876ed134-601c-4b93-a6f8-5a2ed72b5c46'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="876ed134-601c-4b93-a6f8-5a2ed72b5c46"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4eec2488-6f1a-444e-97e6-115b910d7626'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="4eec2488-6f1a-444e-97e6-115b910d7626"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0fb1e124-21ce-45dc-9b7b-5aa0071ba759'>Dragging</a></td><td style='width:75%' ><p><a name="0fb1e124-21ce-45dc-9b7b-5aa0071ba759"></a>
<b>Dragging</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Marks if the group itself is being moved be the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#976a91ed-7a42-4fb0-b3c2-be404f1c7522'>IgnoreDrag</a></td><td style='width:75%' class='def'><p><a name="976a91ed-7a42-4fb0-b3c2-be404f1c7522"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27341d51-8c28-408c-a003-be6f6d6b59cb'>PerformingDrag</a></td><td style='width:75%' ><p><a name="27341d51-8c28-408c-a003-be6f6d6b59cb"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c8091ea-fbe3-4af0-b87b-624fec5ded65'>ToolDownAt</a></td><td style='width:75%' class='def'><p><a name="2c8091ea-fbe3-4af0-b87b-624fec5ded65"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#addfba48-341e-49ba-b61e-32a0f52196ef'>_isMaskedGroup</a></td><td style='width:75%' ><p><a name="addfba48-341e-49ba-b61e-32a0f52196ef"></a>
<b>_isMaskedGroup</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the top most shape in the group will act as a mask for the shapes below it.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ce5027bc-edd8-4173-80db-3d68d46dda9e'>Parent</a></td><td style='width:75%' ><p><a name="ce5027bc-edd8-4173-80db-3d68d46dda9e"></a></p>

<h3>Parent</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code> that this <code>KimonoShapeGroup</code> belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da0b827a-e67c-4b01-88b3-522f3d80f9b8'>ParentSketch</a></td><td style='width:75%' class='def'><p><a name="da0b827a-e67c-4b01-88b3-522f3d80f9b8"></a></p>

<h3>ParentSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the parent sketch by scanning backwards through the chain of parent objects until a <code>KimonoSketch</code> is reached.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#465faf13-9f9c-4bdc-9a22-b1c8db01b8d3'>Path</a></td><td style='width:75%' ><p><a name="465faf13-9f9c-4bdc-9a22-b1c8db01b8d3"></a></p>

<h3>Path</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the full path from this group back to the parent <code>KimonoSketch</code>.</p>

<h4>Return Value</h4>

<p>The path representing the nesting level of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7f0d82b-b92a-40a1-9b3a-344a95b75dd8'>Shapes</a></td><td style='width:75%' class='def'><p><a name="c7f0d82b-b92a-40a1-9b3a-344a95b75dd8"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dc943c3-a9b4-48c3-b6fc-c659b3e1fd59'>SelectedShape</a></td><td style='width:75%' ><p><a name="9dc943c3-a9b4-48c3-b6fc-c659b3e1fd59"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4676474b-5857-4cfc-ba70-5d441402c558'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="4676474b-5857-4cfc-ba70-5d441402c558"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6675c240-084b-480d-93c6-72d6ae04188c'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="6675c240-084b-480d-93c6-72d6ae04188c"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56110dc3-2236-4cdb-94dd-3ae6340e4440'>GroupType</a></td><td style='width:75%' class='def'><p><a name="56110dc3-2236-4cdb-94dd-3ae6340e4440"></a></p>

<h3>GroupType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the group.</p>

<h4>Return Value</h4>

<p>The type of the group as a <code>KimonoShapeGroupType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a0f5332-e536-4323-be20-171aeba1b6db'>Style</a></td><td style='width:75%' ><p><a name="4a0f5332-e536-4323-be20-171aeba1b6db"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style of this group.</p>

<h4>Return Value</h4>

<p>The style as a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f036fd4-1c94-4d32-b003-86144402edca'>Visible</a></td><td style='width:75%' class='def'><p><a name="6f036fd4-1c94-4d32-b003-86144402edca"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f35b6e7-2235-499c-afcf-46163f3d4ead'>IsEditable</a></td><td style='width:75%' ><p><a name="4f35b6e7-2235-499c-afcf-46163f3d4ead"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01597e09-a796-4821-8d85-228b76ec07f4'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="01597e09-a796-4821-8d85-228b76ec07f4"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#722b1a3d-13d7-4a7c-837d-07f711330ee8'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="722b1a3d-13d7-4a7c-837d-07f711330ee8"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ba38c87-1c8d-4377-9ee4-728316ab9dee'>IsBooleanConstruct</a></td><td style='width:75%' class='def'><p><a name="6ba38c87-1c8d-4377-9ee4-728316ab9dee"></a></p>

<h3>IsBooleanConstruct</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> is a boolean construct.</p>

<h4>Return Value</h4>

<p><code>true</code> if is boolean construct; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca7f651c-7f18-451f-aefb-8eb4f8f752f1'>BooleanOperation</a></td><td style='width:75%' ><p><a name="ca7f651c-7f18-451f-aefb-8eb4f8f752f1"></a></p>

<h3>BooleanOperation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the boolean operation that will be applied to this group of objects.</p>

<h4>Return Value</h4>

<p>The boolean operation as a <code>SKPathOp</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecba0c6f-e9dd-4980-8aab-f1bca10b6597'>Mask</a></td><td style='width:75%' class='def'><p><a name="ecba0c6f-e9dd-4980-8aab-f1bca10b6597"></a></p>

<h3>Mask</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoShape</code> that is acting as a mask for this group.</p>

<h4>Return Value</h4>

<p>The mask as a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a048e33-fe71-4bd5-946e-0f06c9725be4'>IsMaskedGroup</a></td><td style='width:75%' ><p><a name="0a048e33-fe71-4bd5-946e-0f06c9725be4"></a></p>

<h3>IsMaskedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> is masked group.</p>

<h4>Return Value</h4>

<p><code>true</code> if is masked group; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e7d46139-985e-4230-902a-1e969c9771c4'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="e7d46139-985e-4230-902a-1e969c9771c4"></a></p>

<h3>KimonoShapeGroup (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="6fcdb73b-63f6-4d14-b379-1c0837b89145"></a>
The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a569d0d3-8fac-41c6-b162-69eb8937111b'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p><a name="a569d0d3-8fac-41c6-b162-69eb8937111b"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="d844b02d-d48c-4e02-96fd-b446b3a800ec"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="5580e917-1e6a-488c-9572-fcffc6b1f1eb"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="97c2bdfe-3734-4006-a468-b447b4929fb1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="5423c6e7-985f-4bf3-a564-1cad6c3ebb76"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="4f23db93-72dd-4240-961b-b9dda4deef5c"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b1cdce3-5d1e-406b-af65-ff5f87763262'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="9b1cdce3-5d1e-406b-af65-ff5f87763262"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f23ef71d-24e2-4f80-9edf-d289d5f55f3f">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="9a34208d-69c6-4ad6-8586-bdf69f8550f4"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="01338fd5-a79e-4f25-b6ba-399e41945182"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="7c379d5f-ea50-430b-a775-1af8cf565d7c"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="77d9b2a1-0065-487e-b669-2a2b907a5216"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="52c80750-20dd-4ef3-9a17-cd21b389bcaa"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="2bb86a63-683b-4d6b-aaea-67bb640dd016"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebfc65c3-9bd9-4daa-9eb2-07e449dc16b8'>Initialize</a></td><td style='width:75%' class='def'><p><a name="ebfc65c3-9bd9-4daa-9eb2-07e449dc16b8"></a></p>

<h3>Initialize (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize the specified parent.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="e2f34f67-f88b-48cb-b7fd-9ce60d69dfeb"></a>
Parent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The initialize.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35d9e266-d505-4a46-8a5f-c8da3bf94aad'>FindShape</a></td><td style='width:75%' ><p><a name="35d9e266-d505-4a46-8a5f-c8da3bf94aad"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds a given shape by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="1d6a2eec-68e4-4096-9673-3a94c0b2a559"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoShape</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6592cae3-559c-4444-918b-8f017f18c20b'>RecalculateGroupBounds</a></td><td style='width:75%' class='def'><p><a name="6592cae3-559c-4444-918b-8f017f18c20b"></a></p>

<h3>RecalculateGroupBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the group bounds to encompass every <code>KimonoShape</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a83c4dbf-a64a-4b7d-9d03-9e2b92ef5b05'>ReturnToSketch</a></td><td style='width:75%' ><p><a name="a83c4dbf-a64a-4b7d-9d03-9e2b92ef5b05"></a></p>

<h3>ReturnToSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns to base parent <code>KimonoSketch</code> for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c5ddf9a-369e-4a91-8d35-4627b36933e8'>SelectShape</a></td><td style='width:75%' class='def'><p><a name="8c5ddf9a-369e-4a91-8d35-4627b36933e8"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="0d136583-0ac6-4a74-8d19-5678cea26f1d"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bde01c6c-a0e1-4cb7-b334-ee8f79ee162c'>RecalculateLayerDepths</a></td><td style='width:75%' ><p><a name="bde01c6c-a0e1-4cb7-b334-ee8f79ee162c"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eeb87240-bb2b-4894-9a7e-eacb9e9f67c3'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="eeb87240-bb2b-4894-9a7e-eacb9e9f67c3"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8caee804-63c9-466b-b645-5649d47088fd'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p><a name="8caee804-63c9-466b-b645-5649d47088fd"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69ed581d-2460-477e-8705-830aa22d456e'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p><a name="69ed581d-2460-477e-8705-830aa22d456e"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#573a4da9-0d0d-4e8b-81ee-f749b8588a16'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="573a4da9-0d0d-4e8b-81ee-f749b8588a16"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d6aaabb-11ca-4792-82c4-509f944b9d91'>AlignAllTop</a></td><td style='width:75%' class='def'><p><a name="7d6aaabb-11ca-4792-82c4-509f944b9d91"></a></p>

<h3>AlignAllTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#280ee94f-2381-4764-93b1-be9be9379773'>AlignAllBottom</a></td><td style='width:75%' ><p><a name="280ee94f-2381-4764-93b1-be9be9379773"></a></p>

<h3>AlignAllBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45e560cb-526a-4ac7-8b21-c71eeb954fdf'>AlignAllLeft</a></td><td style='width:75%' class='def'><p><a name="45e560cb-526a-4ac7-8b21-c71eeb954fdf"></a></p>

<h3>AlignAllLeft ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1d991a9-1c78-484e-9c00-410b56ddae57'>AlignAllRight</a></td><td style='width:75%' ><p><a name="a1d991a9-1c78-484e-9c00-410b56ddae57"></a></p>

<h3>AlignAllRight ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd218797-a792-418c-8730-76f2177cfb87'>AlignAllCenter</a></td><td style='width:75%' class='def'><p><a name="bd218797-a792-418c-8730-76f2177cfb87"></a></p>

<h3>AlignAllCenter ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Centers all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b6939b1-01b8-4071-adf1-4081db513de3'>AlignAllCenterHorizontal</a></td><td style='width:75%' ><p><a name="3b6939b1-01b8-4071-adf1-4081db513de3"></a></p>

<h3>AlignAllCenterHorizontal ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center horizontal all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87f50101-2684-4bdc-856b-9b8323abde25'>AlignAllCenterVertical</a></td><td style='width:75%' class='def'><p><a name="87f50101-2684-4bdc-856b-9b8323abde25"></a></p>

<h3>AlignAllCenterVertical ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center vertical all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5de72ab0-03f8-48dc-912d-84096ec327ac'>DeleteColor</a></td><td style='width:75%' ><p><a name="5de72ab0-03f8-48dc-912d-84096ec327ac"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="3cd4fe9b-cf69-4c39-b62b-212353ae3710"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15498102-7926-4a27-a362-42568a9621b5'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="15498102-7926-4a27-a362-42568a9621b5"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="19c7fa48-5eb4-4abd-93ca-a7f0cc0e9d2b"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46b11614-8f43-4890-9a50-b4dee403b072'>AddShape</a></td><td style='width:75%' ><p><a name="46b11614-8f43-4890-9a50-b4dee403b072"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoShape</code> to the group if it isn't already a part of the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="36ea25f6-0b11-4830-93e8-25f491a7cea0"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10cb0dda-8239-4c66-8904-32db52c6e45f'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="10cb0dda-8239-4c66-8904-32db52c6e45f"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e8caa65-1f0c-4e56-a1ec-1c745e1e446c'>RemoveShape</a></td><td style='width:75%' ><p><a name="4e8caa65-1f0c-4e56-a1ec-1c745e1e446c"></a></p>

<h3>RemoveShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given <code>KimonoShape</code> from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="1f93b4c0-6edd-4c99-9bc8-34f018b04e28"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#351f9227-b7da-422f-9c78-e1704380b09b'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="351f9227-b7da-422f-9c78-e1704380b09b"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcc50d40-2da6-4824-b392-76f6933617e3'>ShapeInGroup</a></td><td style='width:75%' ><p><a name="bcc50d40-2da6-4824-b392-76f6933617e3"></a></p>

<h3>ShapeInGroup (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given <code>KimonoShape</code> is a part of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="32b1a26f-e5b9-480b-9d71-24052add53e7"></a>
The <code>KimonoShape</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in shape is in the group, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cf8aeb9-8d54-49bf-a709-c3ebe35fa74b'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="7cf8aeb9-8d54-49bf-a709-c3ebe35fa74b"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ad50b5e-062c-45ba-b6c7-595072085108'>GroupShapes</a></td><td style='width:75%' ><p><a name="0ad50b5e-062c-45ba-b6c7-595072085108"></a></p>

<h3>GroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00c2fe43-53da-45e5-bc2d-a42d7c4a0bb7'>GroupShapes</a></td><td style='width:75%' class='def'><p><a name="00c2fe43-53da-45e5-bc2d-a42d7c4a0bb7"></a></p>

<h3>GroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="56b0ea96-2e39-4bf2-9acc-1c2b55c8bd07"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f420235d-2d82-495a-8e0f-88075ce9ef61'>GroupShapes</a></td><td style='width:75%' ><p><a name="f420235d-2d82-495a-8e0f-88075ce9ef61"></a></p>

<h3>GroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="6a7cb366-36fe-4faa-b4f6-f3f933f5a4fc"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76a7f477-05ee-447a-b938-d179af28f8e4'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="76a7f477-05ee-447a-b938-d179af28f8e4"></a></p>

<h3>UngroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80d2450b-3b2f-428a-ba3e-641ffcaca0fc'>UngroupShapes</a></td><td style='width:75%' ><p><a name="80d2450b-3b2f-428a-ba3e-641ffcaca0fc"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="acfa7b0c-1a4d-4dfa-8c30-bdbfe0169aaa"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f300954-b6d7-4494-b8ff-f2bf5e0938b3'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="4f300954-b6d7-4494-b8ff-f2bf5e0938b3"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="92f18bb6-b495-4af8-add6-0a2a3231c420"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67372e40-f244-409c-a76b-fea0baea5531'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="67372e40-f244-409c-a76b-fea0baea5531"></a></p>

<h3>DuplicateShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in a selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75df0ac8-7639-4210-b96f-d9df1afd5410'>DuplicateShapes</a></td><td style='width:75%' class='def'><p><a name="75df0ac8-7639-4210-b96f-d9df1afd5410"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="b4303fb6-ccd6-4b67-969f-af1b7e434bf1"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#771916dc-2612-4947-bc8c-cf37e52da205'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="771916dc-2612-4947-bc8c-cf37e52da205"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="0830df73-0c2e-4a19-8248-4b6089c74da4"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c620380d-9dbb-450d-9277-1ec3e77736ac'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="c620380d-9dbb-450d-9277-1ec3e77736ac"></a></p>

<h3>DeleteShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b44e9a2-e37d-473f-9b89-56fa21645365'>DeleteShapes</a></td><td style='width:75%' ><p><a name="0b44e9a2-e37d-473f-9b89-56fa21645365"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="c77ff7a9-2a7e-4ce6-b1d5-f37d5530d498"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0cc6d4a-1f4c-4a38-8086-15898b95a763'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="d0cc6d4a-1f4c-4a38-8086-15898b95a763"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="6297830f-106d-4187-8fdc-e5b501777f00"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80cc375f-c712-4b73-950d-ea30b8676ca5'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="80cc375f-c712-4b73-950d-ea30b8676ca5"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale adjustments to all <code>KimonoShapes</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88ac3360-2e91-4df1-af5f-c654c4ee4a31'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="88ac3360-2e91-4df1-af5f-c654c4ee4a31"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="da93e266-f195-4477-a1de-a9516c8f1c11"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76fea1df-b6f4-4cd4-95af-a8a343af7bed'>RemoveProperty</a></td><td style='width:75%' ><p><a name="76fea1df-b6f4-4cd4-95af-a8a343af7bed"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="b8ae3aa0-f9f2-448a-8805-021310ed2d11"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5390a490-36cc-4c00-9ac3-827251cd25ae'>ToPath</a></td><td style='width:75%' class='def'><p><a name="5390a490-36cc-4c00-9ac3-827251cd25ae"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the group of shapes to a path.</p>

<h4>Returns</h4>

<p>The group of shapes as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95693645-c1f4-4c5e-9c89-26d96f65a313'>Draw</a></td><td style='width:75%' ><p><a name="95693645-c1f4-4c5e-9c89-26d96f65a313"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw all the <code>KimonoShapes</code> that are part of this group into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="01a59bdf-efc7-4244-9561-951f50f24c3b"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a89b896-67d8-4d8c-bebc-9f5ac58177b7'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="1a89b896-67d8-4d8c-bebc-9f5ac58177b7"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9663d2a1-691f-4c41-bfe3-99856a53531d'>EndEditing</a></td><td style='width:75%' ><p><a name="9663d2a1-691f-4c41-bfe3-99856a53531d"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5496c555-fd1e-4c36-96dd-a2e023e2f242'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="5496c555-fd1e-4c36-96dd-a2e023e2f242"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="36c66c01-c13f-4338-8a4f-cba61bec6595"></a>
The <code>SKPoint</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the point was in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#413d65ec-4a37-46bb-8f7b-7ddefc7784ce'>DragBounds</a></td><td style='width:75%' ><p><a name="413d65ec-4a37-46bb-8f7b-7ddefc7784ce"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="7a97edc4-a82d-416c-9eeb-f4269fbffc0a"></a>
The new location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#309552eb-6506-449f-84c1-71d50d0e56a8'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="309552eb-6506-449f-84c1-71d50d0e56a8"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Update the bouds of this group when they have changed from either a move or a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bede60de-2b9c-485c-8fba-fe49f5ea0cf9'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="bede60de-2b9c-485c-8fba-fe49f5ea0cf9"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57672845-059f-47f6-bd62-d15778d2d0a8'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="57672845-059f-47f6-bd62-d15778d2d0a8"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bda27aa0-81b6-4d4d-8587-b459d0058d6e'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="bda27aa0-81b6-4d4d-8587-b459d0058d6e"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#849a0cf8-8c09-40e1-88d2-7f3cac8bc44c'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="849a0cf8-8c09-40e1-88d2-7f3cac8bc44c"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8054ba25-c25d-475f-a0bb-a1d863a24543"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12a682f9-3f69-446e-9115-f86ace7958f9'>ToCode</a></td><td style='width:75%' ><p><a name="12a682f9-3f69-446e-9115-f86ace7958f9"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="1043ee48-2240-49f1-abf7-a9bdfaefff28"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="81a1b6c1-0224-45b5-90de-b7f738100570"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="719a48ba-065d-456a-b648-1f9999b3f530"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3781946-bd63-4f5a-8060-bef1d9105650'>RelinkShape</a></td><td style='width:75%' class='def'><p><a name="b3781946-bd63-4f5a-8060-bef1d9105650"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="20047cec-1316-4e4c-aa15-319d23e8911b"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79c74dad-7b54-447e-8ff3-d6400a006c1a'>Clone</a></td><td style='width:75%' ><p><a name="79c74dad-7b54-447e-8ff3-d6400a006c1a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4a5ad10-e2ae-4d80-a4ff-69d3df76d09c'>ToolDown</a></td><td style='width:75%' class='def'><p><a name="d4a5ad10-e2ae-4d80-a4ff-69d3df76d09c"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the group's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="563dea39-58f4-478e-b4a5-e626a5334f74"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="8aa53799-4e68-4a90-82c5-693f0adad2a0"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="4ef87f66-426b-4077-96ea-c61cf739139c"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="c44a9f63-7795-44b2-bfbc-da20007d32cf"></a>
##KimonoShapeGroupType

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#231b88a4-e540-4e6f-8d34-5af50c45377f'>Selection</a></td><td style='width:75%' ><p><a name="231b88a4-e540-4e6f-8d34-5af50c45377f"></a>
<b>Selection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a current active selection.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3e8eb71-84b4-4102-8222-a0d241e21d9b'>DragSelect</a></td><td style='width:75%' class='def'><p><a name="e3e8eb71-84b4-4102-8222-a0d241e21d9b"></a>
<b>DragSelect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a drag to select selection that is underway.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d28d2c0b-2d78-4326-bdba-89e8cae91260'>Collection</a></td><td style='width:75%' ><p><a name="d28d2c0b-2d78-4326-bdba-89e8cae91260"></a>
<b>Collection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a collection of shape that have been grouped together and are treated as a single object in the editor.</p>
</td></tr></table></p>


---

<a name="c4a85662-e7b6-4677-8b4d-0a099b4eb968"></a>
##KimonoShapeLine

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a line on the design surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#594b0654-0d13-47b9-901c-4b4bfe405a0b'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="594b0654-0d13-47b9-901c-4b4bfe405a0b"></a></p>

<h3>KimonoShapeLine ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#c4a85662-e7b6-4677-8b4d-0a099b4eb968">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05360bff-b062-4e1b-8787-20c64837df17'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p><a name="05360bff-b062-4e1b-8787-20c64837df17"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#c4a85662-e7b6-4677-8b4d-0a099b4eb968">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="55eccf27-3f0e-4f7e-8485-f02d7941fdda"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="11444d43-8a41-4fcc-9c2d-c06d0341ba67"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="901c5ac6-a20c-470d-a0ec-204e76c63c7c"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="13ee8382-3807-46b1-9315-275c5d1963fd"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70a5ad37-107b-4096-b320-e4910a02db1a'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="70a5ad37-107b-4096-b320-e4910a02db1a"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#c4a85662-e7b6-4677-8b4d-0a099b4eb968">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="725dd02b-0264-4517-abf7-ad7bcb9b4e5f"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="1e98132f-9372-4be8-b454-fbc0496b428c"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b2b8d47a-a1fe-46b9-8a5f-3356e0e4622c"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a0f11942-241b-45e5-8da4-69dbe595153c"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="d75af4d9-3b93-4460-b0d9-ef3879058b37"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c7b28ca-c2b3-4ca8-bc0c-b0cda7f7d4d2'>Initialize</a></td><td style='width:75%' class='def'><p><a name="4c7b28ca-c2b3-4ca8-bc0c-b0cda7f7d4d2"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b9a2dde-61c4-4cc1-8659-3d2795c983ea'>ToPath</a></td><td style='width:75%' ><p><a name="5b9a2dde-61c4-4cc1-8659-3d2795c983ea"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b846aa4-1e84-49ef-a130-25ba76e31c81'>Draw</a></td><td style='width:75%' class='def'><p><a name="7b846aa4-1e84-49ef-a130-25ba76e31c81"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the line into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="310d22b2-7d53-400e-8145-cb7470bc6ffb"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbaa4f70-48ca-46e0-99cc-738875f81826'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="cbaa4f70-48ca-46e0-99cc-738875f81826"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ac50f17-9fe5-43cd-9663-6b00be4cd9c3'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="8ac50f17-9fe5-43cd-9663-6b00be4cd9c3"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea96dd11-07f0-4734-9b90-349aa271a13f'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="ea96dd11-07f0-4734-9b90-349aa271a13f"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe2ace69-84cc-4280-a286-35e2287b749d'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="fe2ace69-84cc-4280-a286-35e2287b749d"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8461cdf2-aad7-4fb7-8ef0-2302f88ab5ef"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47a3a7c3-b051-404b-8f34-613f38e96709'>ToCode</a></td><td style='width:75%' ><p><a name="47a3a7c3-b051-404b-8f34-613f38e96709"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="38cd4faa-36e9-4150-b9d9-4e3fe3678102"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="592cf759-135c-4f86-ac22-383f8daecf53"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f4c29c21-60fe-4da4-8dd6-727a8be76f5c"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eda41c59-363a-4c79-8115-0a696db1efe2'>Clone</a></td><td style='width:75%' class='def'><p><a name="eda41c59-363a-4c79-8115-0a696db1efe2"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoLine</code>.</p>
</td></tr></table></p>


---

<a name="b0a8590d-dbcc-44ed-9457-0768a50c3be2"></a>
##KimonoShapeOval

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws an oval into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e959bbfe-167c-41f6-8593-2df270bc44f8'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="e959bbfe-167c-41f6-8593-2df270bc44f8"></a></p>

<h3>KimonoShapeOval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b0a8590d-dbcc-44ed-9457-0768a50c3be2">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2206a5bb-d8a3-4aca-a86c-597392de3739'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p><a name="2206a5bb-d8a3-4aca-a86c-597392de3739"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b0a8590d-dbcc-44ed-9457-0768a50c3be2">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f506ef87-16d7-433d-a2a2-6ad84056b692"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e3efd962-02cf-494d-ad7f-c407d6fd7e1a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="81b871c1-bd3b-4e95-af8d-03a70eaed033"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="77c2b3b3-0b34-4146-8245-76e9d983daee"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4bfe08de-751d-464e-946e-2e05383cc7c4'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="4bfe08de-751d-464e-946e-2e05383cc7c4"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b0a8590d-dbcc-44ed-9457-0768a50c3be2">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ed2fc68d-4a51-4518-847c-88690f2284e7"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a2e41fb3-5bae-4516-9308-fcf3f5060d5f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="a1d4fbf8-2ad5-4106-877c-5a7ecd869baa"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e2d8cb39-86d0-4196-afc2-aafe9ce3c0f6"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="f38a7ea8-220a-4bdd-8fe1-d95eada1dac7"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa39bb80-7fff-40c0-bb59-fa6316c9e254'>Initialize</a></td><td style='width:75%' class='def'><p><a name="aa39bb80-7fff-40c0-bb59-fa6316c9e254"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67a1d6f0-94fc-49ba-8cff-7bf80ad38008'>ToPath</a></td><td style='width:75%' ><p><a name="67a1d6f0-94fc-49ba-8cff-7bf80ad38008"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e24f499-35dc-45b9-93ef-93e7a1867d05'>Draw</a></td><td style='width:75%' class='def'><p><a name="7e24f499-35dc-45b9-93ef-93e7a1867d05"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw the oval into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="be5cb7f0-82f5-4c4b-9d9f-b0c6d9b97554"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edec706c-7dbd-4601-ba43-8483b83b8510'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="edec706c-7dbd-4601-ba43-8483b83b8510"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b433277-94b9-436c-95d7-a8e569b0f99d'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="2b433277-94b9-436c-95d7-a8e569b0f99d"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8687ec52-cb27-4a47-917e-31cbf8b0c978'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="8687ec52-cb27-4a47-917e-31cbf8b0c978"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a908ccac-84ff-4ad4-988d-1055247753ed'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="a908ccac-84ff-4ad4-988d-1055247753ed"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e760fa0e-e725-40cd-90ff-0d061e129d56"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34177359-7d7c-4441-9b18-02a8e74a6835'>ToCode</a></td><td style='width:75%' ><p><a name="34177359-7d7c-4441-9b18-02a8e74a6835"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="4aa14a7c-0ef3-4a14-8bbd-953dcb64fb3f"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="80dc6308-216b-4838-a9b7-8de69ca64cce"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="80772498-ba21-4f14-8084-ce594daf0e77"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#089a9c71-0cc9-4bff-b238-69076bd2025e'>Clone</a></td><td style='width:75%' class='def'><p><a name="089a9c71-0cc9-4bff-b238-69076bd2025e"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoOval</code>.</p>
</td></tr></table></p>


---

<a name="fe16fc49-2f43-4764-9c66-909a8f47383c"></a>
##KimonoShapePolygon

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a multi-sided polygon into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1b78545b-6c07-4c28-a554-2cf1bc0fd711'>NumberOfSides</a></td><td style='width:75%' ><p><a name="1b78545b-6c07-4c28-a554-2cf1bc0fd711"></a></p>

<h3>NumberOfSides</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of sides.</p>

<h4>Return Value</h4>

<p>The number of sides.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c5a2d6d-84ba-4a68-9bc3-63e25c928927'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="1c5a2d6d-84ba-4a68-9bc3-63e25c928927"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a96e6636-3e44-4cce-a558-50b44fd01211'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="a96e6636-3e44-4cce-a558-50b44fd01211"></a></p>

<h3>KimonoShapePolygon ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fe16fc49-2f43-4764-9c66-909a8f47383c">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c61c4b5f-4598-4f10-b3fe-d65c072a1076'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p><a name="c61c4b5f-4598-4f10-b3fe-d65c072a1076"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fe16fc49-2f43-4764-9c66-909a8f47383c">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="cfc7fec2-4afc-46f4-8e63-0a72cdc9e352"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="41d55a67-d05d-44d5-a5b1-38336a0627c0"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="905e64fb-c4e1-4292-bf70-7618cac78afa"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="fc77eb52-22c9-41cd-93b8-833f766548e5"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e33a3596-8379-4aee-a566-415c0b67ac20'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="e33a3596-8379-4aee-a566-415c0b67ac20"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fe16fc49-2f43-4764-9c66-909a8f47383c">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="2bed6a37-9d78-499f-9198-fd2e456dd34d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="271af54c-f2d4-4cb0-81c3-fea8d4331e9a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="4e745427-fc88-4b55-9641-193eca3a4a4e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="c753c4d2-b97f-45a4-9e25-409d9293eb61"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="264907ce-4192-4a73-a07d-56c980ccbd55"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68b605fd-d39a-4cff-b6ce-66c5af8ac2bf'>Initialize</a></td><td style='width:75%' class='def'><p><a name="68b605fd-d39a-4cff-b6ce-66c5af8ac2bf"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94e44d65-e2a0-49eb-80cf-6b3931b373ab'>MakeSidePoints</a></td><td style='width:75%' ><p><a name="94e44d65-e2a0-49eb-80cf-6b3931b373ab"></a></p>

<h3>MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="65174f9a-6898-4c25-8e60-202a294217de"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="e539955d-20e5-403b-bba0-6a1f6c5bb2a8"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="73a24b7d-efe4-442e-a26e-e61f5aaef5ba"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="0f6aebf2-c434-401e-9d1a-719af4e06002"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93a0b16f-ef1e-4312-ba3d-50b770aab99b'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="93a0b16f-ef1e-4312-ba3d-50b770aab99b"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="e4dba535-6d37-420f-a2e1-545e5d372930"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adaff9a9-f269-478c-b4a9-b3aa4c767bb2'>ToPath</a></td><td style='width:75%' ><p><a name="adaff9a9-f269-478c-b4a9-b3aa4c767bb2"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af042ebd-9105-404e-8c6b-e49806c256b0'>Draw</a></td><td style='width:75%' class='def'><p><a name="af042ebd-9105-404e-8c6b-e49806c256b0"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the polygon into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="caaae54e-3957-44f3-813d-449d5d2051ae"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30636e65-0277-400c-90e2-a1e50544cfc5'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="30636e65-0277-400c-90e2-a1e50544cfc5"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51528bb7-45fe-428b-bac5-63351078643f'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="51528bb7-45fe-428b-bac5-63351078643f"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#502dc561-850e-423c-8a9b-ae3bb91051d7'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="502dc561-850e-423c-8a9b-ae3bb91051d7"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1daf785d-e1a0-404b-a57b-b665d3dc08d2'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="1daf785d-e1a0-404b-a57b-b665d3dc08d2"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0911a2ab-0ed3-44ba-a8cd-249ba0b51e83"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f21eb27d-1e74-4653-9be4-ac6c4de8306d'>ToCode</a></td><td style='width:75%' ><p><a name="f21eb27d-1e74-4653-9be4-ac6c4de8306d"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="de61b1f0-2aef-460a-a09a-af0152809e07"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="42852467-975d-4e85-80b1-c1bb8d599601"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6e854c46-81ef-42a9-b0eb-26e0ce7aba9d"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a8dab19-668b-41b7-8346-ebe4a68df43f'>Clone</a></td><td style='width:75%' class='def'><p><a name="7a8dab19-668b-41b7-8346-ebe4a68df43f"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoPloygon</code>.</p>
</td></tr></table></p>


---

<a name="82ab6a30-c5a7-44d6-a04e-1039d1e319b8"></a>
##KimonoShapeRect

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#49e04965-0635-48af-b27f-d8c86112c0d4'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="49e04965-0635-48af-b27f-d8c86112c0d4"></a></p>

<h3>KimonoShapeRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82ab6a30-c5a7-44d6-a04e-1039d1e319b8">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b023c5c0-15ba-4f75-ba67-079cb2938996'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p><a name="b023c5c0-15ba-4f75-ba67-079cb2938996"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82ab6a30-c5a7-44d6-a04e-1039d1e319b8">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ca40fad6-c314-4731-a379-f7c4d77691eb"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="5d449990-2cb0-4294-af96-395fe786a7cc"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b4ecebdf-e304-41e4-9e4e-599b459ebe21"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b5f4f851-de60-4a50-9a31-dffc7d610c94"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#010a8308-e6a5-4b49-80f5-bacce1188c64'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="010a8308-e6a5-4b49-80f5-bacce1188c64"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82ab6a30-c5a7-44d6-a04e-1039d1e319b8">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="89a56bea-0747-4c77-83e0-b09deac25ab8"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a395df1d-20e2-4ae1-be30-3b534bb7543f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d97d5537-03d2-40e1-b14c-85ded4204482"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bacbf47a-d28c-4a8a-af04-49a7a33f5ef5"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="d09b2e07-0448-4339-beb9-dde193f98378"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25512fa4-650c-44d7-9e0a-c4ea3eaca6ef'>Initialize</a></td><td style='width:75%' class='def'><p><a name="25512fa4-650c-44d7-9e0a-c4ea3eaca6ef"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#374786f6-eb59-4a4f-9d4d-063408685919'>ToPath</a></td><td style='width:75%' ><p><a name="374786f6-eb59-4a4f-9d4d-063408685919"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94c18604-aa9c-41d4-b829-1b0e988d215a'>Draw</a></td><td style='width:75%' class='def'><p><a name="94c18604-aa9c-41d4-b829-1b0e988d215a"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="0ddb5517-1dcd-4bd2-9e93-5f4b000863c0"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d6429ef-ee09-42ab-a13e-0bcfb0d046ad'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="6d6429ef-ee09-42ab-a13e-0bcfb0d046ad"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cba0b3b-6b43-4f95-b03c-7de9f2033a53'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="2cba0b3b-6b43-4f95-b03c-7de9f2033a53"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47701301-3096-40e8-bd91-4cff11aec096'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="47701301-3096-40e8-bd91-4cff11aec096"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a5e9d69-5d84-44bf-8cae-636e0dc11984'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="5a5e9d69-5d84-44bf-8cae-636e0dc11984"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="cbf0f16a-888b-44b2-bcfb-542f6d1fc5bf"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d7b2bb4-6d00-4b4b-b8f9-8f0b5fcf4bed'>ToCode</a></td><td style='width:75%' ><p><a name="6d7b2bb4-6d00-4b4b-b8f9-8f0b5fcf4bed"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="0478f4cc-f474-4e62-a0a8-d7e88cce79ac"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="4d7fb877-1bd6-444a-9a42-de4dbaa3e1a7"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="841d9a8e-4eab-4977-9765-71884e878bf8"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd9c1f79-10a1-4910-9d13-0fd083091a1d'>Clone</a></td><td style='width:75%' class='def'><p><a name="cd9c1f79-10a1-4910-9d13-0fd083091a1d"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="34d1d429-4b88-4c3c-840c-05bd2ec8c8e8"></a>
##KimonoShapeRoundRect

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a rounded rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e2f03dcf-873d-45a8-93aa-5e52c3c42e92'>CornerRadius</a></td><td style='width:75%' ><p><a name="e2f03dcf-873d-45a8-93aa-5e52c3c42e92"></a></p>

<h3>CornerRadius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the corner radius.</p>

<h4>Return Value</h4>

<p>The corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d98733da-caac-421f-9b68-6d76c5c9d1e0'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="d98733da-caac-421f-9b68-6d76c5c9d1e0"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a2a0a4b2-5aa7-430b-af93-ef8244ca69ea'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="a2a0a4b2-5aa7-430b-af93-ef8244ca69ea"></a></p>

<h3>KimonoShapeRoundRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#34d1d429-4b88-4c3c-840c-05bd2ec8c8e8">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ced549a-ff2d-4362-ac6a-1fb732bb0c0d'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="6ced549a-ff2d-4362-ac6a-1fb732bb0c0d"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#34d1d429-4b88-4c3c-840c-05bd2ec8c8e8">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="175f58aa-727d-4f26-ad66-351fa1b0debb"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="31f0bbec-1872-4ec3-9d1c-666af2ceea37"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="e4853e20-d54e-44d9-81dc-e3c749ce8ca0"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="59ee08c9-de9e-4640-ad5c-75152ff7dc35"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dd086eb-2078-4f96-a725-727e7d8c666c'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="9dd086eb-2078-4f96-a725-727e7d8c666c"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#34d1d429-4b88-4c3c-840c-05bd2ec8c8e8">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="cd5d39af-2d3d-425a-8e4e-783241e4ab26"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="103dc65d-502d-4201-847f-615ea18764a1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2653d69b-8017-4eba-9546-98afe5b6e804"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1db617fe-0c7e-4022-8837-6c8d57105cce"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="7acd2f2b-7f7e-497b-a53f-13fb7a0eb000"></a>
Corner radius.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#860b71cb-dcad-4507-a327-f4136cfc7539'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="860b71cb-dcad-4507-a327-f4136cfc7539"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#34d1d429-4b88-4c3c-840c-05bd2ec8c8e8">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="e7da6150-cc46-42ec-aa23-43d125532a2a"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="47cd79f6-30db-41ab-8bc4-be20e7246705"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="55186eaa-d234-40a3-bda2-c5c8fd5de81a"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="8e1aeb83-340f-4d2e-812b-e8fa3e74c771"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="cb938d05-6d6c-4f2f-82a6-c3d7fbac0637"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98b0d871-fea8-4878-8bbf-d8c829de9fa6'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="98b0d871-fea8-4878-8bbf-d8c829de9fa6"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#34d1d429-4b88-4c3c-840c-05bd2ec8c8e8">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="5ceaa926-a257-45ba-8163-28f0c6d18af1"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="0d9bcc75-1c1a-4cb2-b583-d92a1ed445f9"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="dd205689-13ac-4c5d-be41-09fe5fd692ed"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="16432dbf-1e78-47ac-9915-7bedbcc90934"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="99990c17-499e-48ac-b65e-cfc6d8f7424e"></a>
Corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="486cc0e8-0ee4-469f-8133-f9bcd7b747bb"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a5c874f-2802-49b9-9410-f35dfeb77a26'>Initialize</a></td><td style='width:75%' class='def'><p><a name="1a5c874f-2802-49b9-9410-f35dfeb77a26"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76f53b7c-2e39-4042-abe0-73f1f6eb7126'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="76f53b7c-2e39-4042-abe0-73f1f6eb7126"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="efc224be-1a27-4ac6-839b-038a65ad81c7"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce8656fb-661b-4f4f-ade1-617e00e19989'>ToPath</a></td><td style='width:75%' class='def'><p><a name="ce8656fb-661b-4f4f-ade1-617e00e19989"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e9f5cba-d13e-41b6-98c7-a9405fafeec1'>Draw</a></td><td style='width:75%' ><p><a name="0e9f5cba-d13e-41b6-98c7-a9405fafeec1"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the round rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="6bd19836-7b8f-4a1c-895f-8d86dcc432ab"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fdc3431-a82e-4392-b3a1-532df2aff31a'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="9fdc3431-a82e-4392-b3a1-532df2aff31a"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#682caa86-321a-4bc5-9ad7-b18f9eaee295'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="682caa86-321a-4bc5-9ad7-b18f9eaee295"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68bf21b2-2b37-4bab-83b2-2addb924ab6d'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="68bf21b2-2b37-4bab-83b2-2addb924ab6d"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86d2a3f0-dad4-4f17-98f0-ed6f582fb183'>ToCSharp</a></td><td style='width:75%' ><p><a name="86d2a3f0-dad4-4f17-98f0-ed6f582fb183"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="49b35831-1ea4-48bb-80ec-d4f1c674e976"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47cf1f3e-0f29-4fa8-a632-d2a316ae9b49'>ToCode</a></td><td style='width:75%' class='def'><p><a name="47cf1f3e-0f29-4fa8-a632-d2a316ae9b49"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="22e7ae64-c08a-4941-97bf-f23e5e2c5deb"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="a82f93ee-6ed6-40f9-8574-13faa2f2b973"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c1b73daa-784e-42a2-bd45-f3b6ccae4994"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fe38a3c-66f2-4e39-bf80-45345d49e6f9'>Clone</a></td><td style='width:75%' ><p><a name="3fe38a3c-66f2-4e39-bf80-45345d49e6f9"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeRoundRect</code>.</p>
</td></tr></table></p>


---

<a name="af653d27-3655-47dd-9ef5-5a1f3f5d58d5"></a>
##KimonoShapeStar

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a multi-sided star shape into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4d5dfd82-e3a4-4b1f-8c84-75d4c41f3f64'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="4d5dfd82-e3a4-4b1f-8c84-75d4c41f3f64"></a></p>

<h3>NumberOfPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of points.</p>

<h4>Return Value</h4>

<p>The number of points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b753d9a1-7c0e-4b3a-b167-f8fd1a5a69cb'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="b753d9a1-7c0e-4b3a-b167-f8fd1a5a69cb"></a></p>

<h3>SkipPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the skip points.</p>

<h4>Return Value</h4>

<p>The skip points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad8a4dc5-ebae-4468-8842-41d704a2e5dc'>DepthOffset</a></td><td style='width:75%' ><p><a name="ad8a4dc5-ebae-4468-8842-41d704a2e5dc"></a></p>

<h3>DepthOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the depth offset for the individual points.</p>

<h4>Return Value</h4>

<p>The depth offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#408e42c6-cc39-4479-9afe-485c6ac772ba'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="408e42c6-cc39-4479-9afe-485c6ac772ba"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e21c36bc-4346-4736-adc3-1af38eba9888'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="e21c36bc-4346-4736-adc3-1af38eba9888"></a></p>

<h3>KimonoShapeStar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af653d27-3655-47dd-9ef5-5a1f3f5d58d5">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b9375e6-1bf6-4c67-ad97-15f4eca1e8ef'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p><a name="7b9375e6-1bf6-4c67-ad97-15f4eca1e8ef"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af653d27-3655-47dd-9ef5-5a1f3f5d58d5">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="4ef3b41a-6970-4231-b508-d3e6070bc8d2"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="8d784bd2-6582-42dd-b6a1-42343a47c591"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="fedee5a5-01dd-41f4-9fb6-6b5c18c60bd2"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="97c01e12-47f2-4b2a-a781-52f550fdc60e"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efd8b3c2-6fc4-4acd-a4e3-2bee7842f562'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="efd8b3c2-6fc4-4acd-a4e3-2bee7842f562"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af653d27-3655-47dd-9ef5-5a1f3f5d58d5">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="4931282c-ff6b-45e1-a5cf-8ca11e15ca66"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="499751f4-b25c-440e-b81b-1836b2be7541"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="de3fbf95-3e65-4bbf-9cfb-d1cd228162eb"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="d7e938e5-87eb-4dcf-bd31-93463179d3af"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="5f1e6901-1fb8-4e35-a230-10212eeec91e"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ce0a210-7168-4c3e-8490-3fcc8b447279'>Initialize</a></td><td style='width:75%' class='def'><p><a name="9ce0a210-7168-4c3e-8490-3fcc8b447279"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d33bb4d-1ef4-48a9-b17c-2ac4e240ade5'>MakeStarPoints</a></td><td style='width:75%' ><p><a name="3d33bb4d-1ef4-48a9-b17c-2ac4e240ade5"></a></p>

<h3>MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="50d67857-d4e5-4b06-9ada-a693286839d0"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="3912cd1b-6117-4d44-9fb4-1804d5940c76"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="7a650fab-4798-4ab9-b70c-7d4b220ccbcb"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="68d71bda-ea16-483f-ac7a-f1a9b3ef9108"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d9867d5-5116-4055-beb1-66fda31bb9eb'>CalculateConcaveRadius</a></td><td style='width:75%' class='def'><p><a name="3d9867d5-5116-4055-beb1-66fda31bb9eb"></a></p>

<h3>CalculateConcaveRadius (System.Int32, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Calculates the concave radius.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p><a name="d5596aca-df54-48cf-9113-4818a4d139b7"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p><a name="86ee880b-08dc-48c9-a40d-c1ac0d6d439a"></a>
Skip.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The concave radius.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dffad0d-af89-4f2e-b3ad-a53dc7ad8022'>FindIntersection</a></td><td style='width:75%' ><p><a name="0dffad0d-af89-4f2e-b3ad-a53dc7ad8022"></a></p>

<h3>FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean@, System.Boolean@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the intersection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p><a name="8d4b70b2-8e5c-4997-a740-9c679f59d79b"></a>
P1.</p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p><a name="73d1c46d-eeb7-4ab6-b66f-301131384e67"></a>
P2.</p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p><a name="1274db34-71e4-4493-a9da-9b732c0898a8"></a>
P3.</p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p><a name="92b3124c-cc84-4dc8-bd13-0e99aced27a6"></a>
P4.</p>
</td></tr><tr><td style='width:25%' class='term'>lines_intersect</td><td style='width:75%' ><p><a name="a1d1d89d-dcae-4010-9af5-06bcfaf5a6c3"></a>
If set to <code>true</code> lines intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>segments_intersect</td><td style='width:75%' class='def'><p><a name="e2dcb710-263e-4e33-aec2-289221b5165c"></a>
If set to <code>true</code> segments intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>intersection</td><td style='width:75%' ><p><a name="32819e8f-bf62-4a16-ac75-6f9d62a608aa"></a>
Intersection.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p1</td><td style='width:75%' class='def'><p><a name="284be5a4-896e-495d-a70f-853706fb9f42"></a>
Close p1.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p2</td><td style='width:75%' ><p><a name="3f981ef4-5268-4596-ade7-d5ccf22a838e"></a>
Close p2.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67e2c037-02a7-46a8-8b6d-b9d2a722f5de'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="67e2c037-02a7-46a8-8b6d-b9d2a722f5de"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="0616cec2-7941-40f0-a2f7-be5021002f0a"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be7d10ff-5326-4543-86a8-0788096e8f43'>ToPath</a></td><td style='width:75%' ><p><a name="be7d10ff-5326-4543-86a8-0788096e8f43"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81fbfc01-0d89-4830-bcdf-d15af405ee9a'>Draw</a></td><td style='width:75%' class='def'><p><a name="81fbfc01-0d89-4830-bcdf-d15af405ee9a"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the star into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="72a76fae-7967-453c-a45f-5e282c6d6a41"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb96cca5-c7b0-459c-a3df-cdaa59dfba5c'>ToVector</a></td><td style='width:75%' ><p><a name="bb96cca5-c7b0-459c-a3df-cdaa59dfba5c"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the star into a vector.</p>

<h4>Returns</h4>

<p>The <code>KimonoShapeVector</code> version of the star.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67274fe2-6263-4c79-9d3d-41fb3faef7be'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="67274fe2-6263-4c79-9d3d-41fb3faef7be"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6108cdc3-9f90-444b-b7e2-7b7ff844ad05'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="6108cdc3-9f90-444b-b7e2-7b7ff844ad05"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3596785e-4e55-4c38-abc7-05432406c3b4'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="3596785e-4e55-4c38-abc7-05432406c3b4"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8c61ee6-a0ff-4282-83ad-ef44b53a5b10'>ToCSharp</a></td><td style='width:75%' ><p><a name="d8c61ee6-a0ff-4282-83ad-ef44b53a5b10"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ee648ed9-0275-4c2d-b271-3be7e6bc31cc"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3749de8f-3e67-4fc6-b32e-7b669fa3eebf'>ToCode</a></td><td style='width:75%' class='def'><p><a name="3749de8f-3e67-4fc6-b32e-7b669fa3eebf"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="37d96e03-ac59-411e-8831-a4a8769c8592"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="b9d2d46b-f424-4de9-bf1c-96199e2cb4f8"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7025ad6d-9f0c-4ba5-8ba3-20df12410b9f"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ff99a5c-04b4-4a3f-ba86-9ade1f020a86'>Clone</a></td><td style='width:75%' ><p><a name="9ff99a5c-04b4-4a3f-ba86-9ade1f020a86"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeStar</code>.</p>
</td></tr></table></p>


---

<a name="c901b401-346b-419f-9138-2dbc1061e7af"></a>
##KimonoShapeState

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Holds the current state of a `KimonoShape` while it is being edited by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#01af1fb9-b9a5-49d7-baee-6af7e62e2a53'>Unselected</a></td><td style='width:75%' ><p><a name="01af1fb9-b9a5-49d7-baee-6af7e62e2a53"></a>
<b>Unselected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is unselected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a470451-93a9-4a29-b653-d72fc43b871e'>Selected</a></td><td style='width:75%' class='def'><p><a name="5a470451-93a9-4a29-b653-d72fc43b871e"></a>
<b>Selected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6f0d3b3-96ef-4a23-a447-d4b1a4a1ce07'>Editing</a></td><td style='width:75%' ><p><a name="d6f0d3b3-96ef-4a23-a447-d4b1a4a1ce07"></a>
<b>Editing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83af0b56-280f-4c98-9e64-5d2701c08a6c'>Finalizing</a></td><td style='width:75%' class='def'><p><a name="83af0b56-280f-4c98-9e64-5d2701c08a6c"></a>
<b>Finalizing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is leaving the edit mode and needs to be completed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5a94e83-7a2e-433c-98c2-fcc93032d5a0'>Constructing</a></td><td style='width:75%' ><p><a name="c5a94e83-7a2e-433c-98c2-fcc93032d5a0"></a>
<b>Constructing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the process of being built. For example, a set of shapes being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b925ab24-75d5-434e-89ce-44d86f257b29'>Grouping</a></td><td style='width:75%' class='def'><p><a name="b925ab24-75d5-434e-89ce-44d86f257b29"></a>
<b>Grouping</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being added to a group.</p>
</td></tr></table></p>


---

<a name="0176715e-dc10-43bc-ae04-98aba16b3647"></a>
##KimonoShapeText

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a block of text into the Design Surface within the specifid bounds of this shape.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#96ba2470-a95e-4354-ae16-8da8d2b4d7a9'>Text</a></td><td style='width:75%' ><p><a name="96ba2470-a95e-4354-ae16-8da8d2b4d7a9"></a></p>

<h3>Text</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text.</p>

<h4>Return Value</h4>

<p>The text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#103f1c6a-32a6-4997-863d-84294dd723d8'>FontMetrics</a></td><td style='width:75%' class='def'><p><a name="103f1c6a-32a6-4997-863d-84294dd723d8"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#374f4ee0-f3b6-4ba7-8e5e-263836bb1beb'>IsLinearText</a></td><td style='width:75%' ><p><a name="374f4ee0-f3b6-4ba7-8e5e-263836bb1beb"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07fe87bf-3d5b-4cdb-b7e6-24f242e91171'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="07fe87bf-3d5b-4cdb-b7e6-24f242e91171"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f42b1584-260b-41d1-babf-9a30a359b6d9'>StrikeThruText</a></td><td style='width:75%' ><p><a name="f42b1584-260b-41d1-babf-9a30a359b6d9"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edb5241c-456d-4c1f-a62b-1f12615f4530'>TextAlign</a></td><td style='width:75%' class='def'><p><a name="edb5241c-456d-4c1f-a62b-1f12615f4530"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad92979e-68be-4c1e-a7dc-f847167f1056'>TextEncoding</a></td><td style='width:75%' ><p><a name="ad92979e-68be-4c1e-a7dc-f847167f1056"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9abd8fd2-b2c7-4b28-8c1d-c39bfc588d74'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="9abd8fd2-b2c7-4b28-8c1d-c39bfc588d74"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96ef2b34-b81f-47ed-8686-bd5d1566398a'>TextSize</a></td><td style='width:75%' ><p><a name="96ef2b34-b81f-47ed-8686-bd5d1566398a"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#955511a8-fd4d-40fd-a37e-285c7123c318'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="955511a8-fd4d-40fd-a37e-285c7123c318"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d4a838a-fae3-4516-b1a1-614aea900cd4'>Typeface</a></td><td style='width:75%' ><p><a name="9d4a838a-fae3-4516-b1a1-614aea900cd4"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a30ebcec-2400-45bc-a85d-71ca65856c8f'>FontFamilyName</a></td><td style='width:75%' class='def'><p><a name="a30ebcec-2400-45bc-a85d-71ca65856c8f"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd25ef57-0dc1-465a-a6a1-a426dc0f4945'>TypefaceStyle</a></td><td style='width:75%' ><p><a name="fd25ef57-0dc1-465a-a6a1-a426dc0f4945"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f86727f-4c4c-46b8-a6d6-c40d2c5cca3f'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="7f86727f-4c4c-46b8-a6d6-c40d2c5cca3f"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5061116a-b656-49c7-85a1-bb9d9ebb201a'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="5061116a-b656-49c7-85a1-bb9d9ebb201a"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#17aeb14f-e4d1-40fe-912c-73d43e54038f'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="17aeb14f-e4d1-40fe-912c-73d43e54038f"></a></p>

<h3>KimonoShapeText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fd88aa1-aac0-4198-acdc-bef4f2eb2561'>KimonoShapeText</a></td><td style='width:75%' class='def'><p><a name="8fd88aa1-aac0-4198-acdc-bef4f2eb2561"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9e0f8b6a-87e3-4822-8c41-2335f5e569b6"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="aa9b3b54-4b4c-44a9-9f51-11f734c57377"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="de904c65-713a-4401-a53c-1dd65a99bd29"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e6594988-5582-4a08-8061-04bd7c61d04c"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22e90a11-acc6-4da1-95a8-c76d0bb63c08'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="22e90a11-acc6-4da1-95a8-c76d0bb63c08"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0176715e-dc10-43bc-ae04-98aba16b3647">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="763d3ce0-fa12-4ddf-8dab-df0ab9227001"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f15d247b-844c-419a-887b-b2c2657694b1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8a124280-7209-4d88-ae78-9b2a502ff868"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="ff4ace68-84ab-477a-baef-c5fe35d7518b"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="fe86481b-432b-4787-b31b-ac3170c1a761"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9cb761f-25d0-4bb0-b580-ae4be3140da1'>Initialize</a></td><td style='width:75%' class='def'><p><a name="d9cb761f-25d0-4bb0-b580-ae4be3140da1"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67876cf7-861c-4074-9fdf-89e6a9dc01a3'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="67876cf7-861c-4074-9fdf-89e6a9dc01a3"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="82cf8df1-1fd4-4810-b82f-6368e54bee29"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f2e3e5e-03d6-4ef9-b519-7131ebcbe24d'>ToPath</a></td><td style='width:75%' class='def'><p><a name="1f2e3e5e-03d6-4ef9-b519-7131ebcbe24d"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a174e9b-1cd3-49aa-9f10-8dd4da162772'>Draw</a></td><td style='width:75%' ><p><a name="5a174e9b-1cd3-49aa-9f10-8dd4da162772"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the text block into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="4b786c82-2d41-4edc-a87c-fc44f114139d"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7de71faf-5a6c-47cd-ab47-610c7bc2882f'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="7de71faf-5a6c-47cd-ab47-610c7bc2882f"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e40af9ee-51e4-443a-b45c-3c268ebbcadd"></a>
The <code>SKPoint</code> to adjust the bounds by.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: Changing the bounds of a text box should optionally scale the size of the text within.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6ff8fb4-6e5e-4171-9d5c-d3561602ace4'>DragBounds</a></td><td style='width:75%' ><p><a name="f6ff8fb4-6e5e-4171-9d5c-d3561602ace4"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a3eb0c5e-2b45-4dfc-87e6-9981f85f05b4"></a>
The <code>SKPoint</code> with the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#501bf442-3b13-4ee8-bb9f-6c0b129124ee'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="501bf442-3b13-4ee8-bb9f-6c0b129124ee"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#316f167f-0139-4d1b-8229-e0f64a4c5a0b'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="316f167f-0139-4d1b-8229-e0f64a4c5a0b"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b28a3afa-06c4-4d1a-9135-5572732c6763'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="b28a3afa-06c4-4d1a-9135-5572732c6763"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#727073b9-45d0-4ec9-ba46-42c62fece965'>ToCSharp</a></td><td style='width:75%' ><p><a name="727073b9-45d0-4ec9-ba46-42c62fece965"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a28512eb-c760-4f5f-8a38-d9efd50101d5"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#245a13d5-817e-4705-b11f-9b61d122d516'>ToCode</a></td><td style='width:75%' class='def'><p><a name="245a13d5-817e-4705-b11f-9b61d122d516"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="308e96ff-ccfb-4956-be09-06b64de4f16d"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="de547b26-8d78-4e5f-9b14-27d46ce733f0"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="73efb73b-fdb2-4f72-bf72-aab3cd8a68e7"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d1cff9-1811-4e44-a5eb-95e942713768'>Clone</a></td><td style='width:75%' ><p><a name="a7d1cff9-1811-4e44-a5eb-95e942713768"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeText</code>.</p>
</td></tr></table></p>


---

<a name="b70177a0-ed3a-4958-98bf-77aa48d58232"></a>
##KimonoShapeTriangle

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Draws a triangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5e870a6b-6abf-4111-be8f-d2a783f61d80'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="5e870a6b-6abf-4111-be8f-d2a783f61d80"></a></p>

<h3>KimonoShapeTriangle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b70177a0-ed3a-4958-98bf-77aa48d58232">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bde7576-52a4-4e53-9a8d-6d8ac26a3e39'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p><a name="2bde7576-52a4-4e53-9a8d-6d8ac26a3e39"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b70177a0-ed3a-4958-98bf-77aa48d58232">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="1aa80665-a4c4-4bb3-953c-35d9f00bcb0d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="41481e1f-effe-4ee6-801b-61e4f6f57f58"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="5eb38a8f-37c6-4205-951e-b10aac6e732b"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="37b2f665-5d9c-47fb-97d5-ab48890614f8"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d60953ec-dab7-43b1-b12a-95be8485427c'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="d60953ec-dab7-43b1-b12a-95be8485427c"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b70177a0-ed3a-4958-98bf-77aa48d58232">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="7cd0319f-dbad-41bd-8458-66d2c2308a5d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="de681076-2e62-489a-8b51-c72a21ef0079"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="207235a8-7c97-4297-8e14-d238b8e652bd"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="69c91764-4b9d-41e1-9a93-2c798f20980a"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="08718af9-8845-456c-bad6-d5cfb3cbd8ca"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3526b1d4-020a-4790-b145-1eff39a8c6a9'>Initialize</a></td><td style='width:75%' class='def'><p><a name="3526b1d4-020a-4790-b145-1eff39a8c6a9"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e99ccdd5-6b61-429c-a935-be9f9cbf8496'>ToPath</a></td><td style='width:75%' ><p><a name="e99ccdd5-6b61-429c-a935-be9f9cbf8496"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1e950b1-4567-4dc1-9fb4-be1c32746f7f'>Draw</a></td><td style='width:75%' class='def'><p><a name="c1e950b1-4567-4dc1-9fb4-be1c32746f7f"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the triangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="735f2176-a6cf-4a32-85df-0baec8e8d3de"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3eafa275-7074-4744-8c00-b794be20d92d'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="3eafa275-7074-4744-8c00-b794be20d92d"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1432ff0c-ce3f-4964-b2ec-18289f1f7c98'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="1432ff0c-ce3f-4964-b2ec-18289f1f7c98"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72fc97fe-45ea-4f96-847d-7bb2c9df34ce'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="72fc97fe-45ea-4f96-847d-7bb2c9df34ce"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1c3759b-c04a-40f3-80e5-ec8cef10a6c5'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="d1c3759b-c04a-40f3-80e5-ec8cef10a6c5"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="4f2f23b6-0417-4c38-974e-24efd08732d1"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a299315-5e68-489a-b1bb-1d6f47f5c35e'>ToCode</a></td><td style='width:75%' ><p><a name="6a299315-5e68-489a-b1bb-1d6f47f5c35e"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="c66ff296-4d52-4037-b142-9ec1844d57b4"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="fdf185a2-f5d4-4500-af6a-86ae7b552596"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b2d43d9b-7cc1-4662-8de2-36818aab0550"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96a4f89f-fa04-450d-99b5-adf42252f2b0'>Clone</a></td><td style='width:75%' class='def'><p><a name="96a4f89f-fa04-450d-99b5-adf42252f2b0"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeTriangle</code>.</p>
</td></tr></table></p>


---

<a name="017045b1-ba2c-4c75-b2b3-50cb8a6a13f9"></a>
##KimonoShapeVector

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8b8cc4b1-7df0-4244-8397-bcf20305c439'>Points</a></td><td style='width:75%' ><p><a name="8b8cc4b1-7df0-4244-8397-bcf20305c439"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ef7990a-f781-4799-ba69-621f52ce1c28'>Closed</a></td><td style='width:75%' class='def'><p><a name="6ef7990a-f781-4799-ba69-621f52ce1c28"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93b6abb5-dd55-4aa5-b8be-98a2ab28dd0a'>IsEditable</a></td><td style='width:75%' ><p><a name="93b6abb5-dd55-4aa5-b8be-98a2ab28dd0a"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2199bae0-9a0c-4d75-ab79-3490ca1069eb'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="2199bae0-9a0c-4d75-ab79-3490ca1069eb"></a></p>

<h3>KimonoShapeVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db95bac2-e952-4ca9-9184-6f6f781dcf56'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p><a name="db95bac2-e952-4ca9-9184-6f6f781dcf56"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="d40b526f-ff97-4ce5-987f-0923614f1d0f"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="4e8c82e1-4f9f-427d-93c9-33848460e976"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="0be394de-33a0-442e-8a17-2d7a33fbe63f"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="12e57f6d-dde9-4b72-91f3-3c895b53db50"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e23f73d-afb9-498a-bb1b-029dec8f76b2'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="7e23f73d-afb9-498a-bb1b-029dec8f76b2"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#017045b1-ba2c-4c75-b2b3-50cb8a6a13f9">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="c79615c7-b769-4fd0-aacd-f16f6c42ff0e"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c30b62e1-4742-42be-b8d0-c678d9da9d92"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="c7ece9b3-a6ba-4529-ae82-40f1edbc88e7"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="d715841b-539f-4d0f-8e7a-f7d2594403da"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="6d696ebc-970c-4682-a13c-acfaf6e9dbca"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eabb4662-a643-4ca3-a1d2-71373fefab4a'>Initialize</a></td><td style='width:75%' class='def'><p><a name="eabb4662-a643-4ca3-a1d2-71373fefab4a"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3af4419b-47bd-4186-b42d-3a75870e33f9'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="3af4419b-47bd-4186-b42d-3a75870e33f9"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e1fbbcc-5973-4c84-bb41-3a8b23adc2de'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="2e1fbbcc-5973-4c84-bb41-3a8b23adc2de"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="b72b435d-0374-493f-80a8-b758c7433d2e"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="ef2aff44-70cf-4777-8e87-77686b64ea0f"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9280230-1422-4d7a-9aa3-c6d931b68a6a'>AddPoint</a></td><td style='width:75%' ><p><a name="f9280230-1422-4d7a-9aa3-c6d931b68a6a"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="248889ac-f16e-4ac0-8af7-50f0418abea7"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9684fbfe-3ae3-49d6-bfa5-2fa5e9453034'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="9684fbfe-3ae3-49d6-bfa5-2fa5e9453034"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="fd8df276-3133-4c70-a1d4-17a9a893cfe3"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#629c641a-5bde-45da-967e-65e1876f5789'>RemovePoint</a></td><td style='width:75%' ><p><a name="629c641a-5bde-45da-967e-65e1876f5789"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="505ec676-149e-4a3c-84d7-4d27a603e023"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da141977-7af4-4569-b370-ba22aca216a6'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="da141977-7af4-4569-b370-ba22aca216a6"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f9f514d-ff2e-403d-afed-85543578ecb1'>ToPath</a></td><td style='width:75%' ><p><a name="7f9f514d-ff2e-403d-afed-85543578ecb1"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f156b568-5d92-4241-a537-34c63c754965'>Draw</a></td><td style='width:75%' class='def'><p><a name="f156b568-5d92-4241-a537-34c63c754965"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="576dcd4d-fc3f-41aa-a7b0-c136acbaf0de"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#561fd1c6-0150-42e5-9803-40ca0b2cae7e'>PointInBound</a></td><td style='width:75%' ><p><a name="561fd1c6-0150-42e5-9803-40ca0b2cae7e"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="fecece18-975f-4ffd-a4d5-ba975928ad44"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37f28ae7-cc2b-469e-ab03-22dd34bd339d'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="37f28ae7-cc2b-469e-ab03-22dd34bd339d"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="59b37cf6-4e50-4725-852f-b3d1ce5b09df"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b16aefbd-076c-451b-ad1c-c86edfe93bdb'>BoundsChanged</a></td><td style='width:75%' ><p><a name="b16aefbd-076c-451b-ad1c-c86edfe93bdb"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#187520b3-77a8-469d-8f32-d3d1017036a8'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="187520b3-77a8-469d-8f32-d3d1017036a8"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a4a84ad-9ea2-449a-b31e-0f7404d76dc6'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="5a4a84ad-9ea2-449a-b31e-0f7404d76dc6"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18dc55fe-0529-42d8-b63a-8083ad3b3ad1'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="18dc55fe-0529-42d8-b63a-8083ad3b3ad1"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#857ce1f8-3280-4337-b043-75df2d493522'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="857ce1f8-3280-4337-b043-75df2d493522"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5873e6b9-3463-4520-8347-728e41632ba0'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="5873e6b9-3463-4520-8347-728e41632ba0"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8593a9fb-4656-40f2-b242-ad6033b4dca6"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#422072ab-66dc-41da-b0c6-b0868d80fd79'>ToCode</a></td><td style='width:75%' ><p><a name="422072ab-66dc-41da-b0c6-b0868d80fd79"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="a8a6dc1e-ab0a-45ae-b775-f09e121e7781"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="d66155fa-e1f7-4eb1-9372-0be1871634b9"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="373305c4-aeeb-44d1-a0b2-7423c582d788"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49de824f-fc7e-4dca-a8e6-97afd7fe4dfb'>Clone</a></td><td style='width:75%' class='def'><p><a name="49de824f-fc7e-4dca-a8e6-97afd7fe4dfb"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="a7ae8aff-214d-44d5-9cd8-efc56483c9c0"></a>
##KimonoProperty

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a property that can be attached to another Kimono object (such as a `KimonoColor`, `KimonoStyle` or `KimonoShape`) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8e715da1-7edf-4cb4-9cab-383eeb0582f3'>UniqueID</a></td><td style='width:75%' ><p><a name="8e715da1-7edf-4cb4-9cab-383eeb0582f3"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#716b3485-7e8a-44d2-99a5-2311a869a712'>Name</a></td><td style='width:75%' class='def'><p><a name="716b3485-7e8a-44d2-99a5-2311a869a712"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name as a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3514b4b-1531-44b1-b569-ebbf1dde0734'>Usage</a></td><td style='width:75%' ><p><a name="b3514b4b-1531-44b1-b569-ebbf1dde0734"></a></p>

<h3>Usage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the usage of this property.</p>

<h4>Return Value</h4>

<p>The <code>KimonoPropertyUsage</code> of this <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69dbba1a-39b7-4817-adc9-8f347edb9ed7'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="69dbba1a-39b7-4817-adc9-8f347edb9ed7"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a7ae8aff-214d-44d5-9cd8-efc56483c9c0">KimonoProperty</a> is the result of an Obi Script.</p>

<h4>Return Value</h4>

<p><code>true</code> if is Obi Script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1534a2b-f946-4fec-97c9-8ff959320a8c'>ObiScript</a></td><td style='width:75%' ><p><a name="f1534a2b-f946-4fec-97c9-8ff959320a8c"></a></p>

<h3>ObiScript</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the obi script that will be used to calculate the value of this <code>KimonoProperty</code>.</p>

<h4>Return Value</h4>

<p>The obi script.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fff32e73-3ee2-4ca7-89c1-5f8cb93c97f0'>KimonoProperty</a></td><td style='width:75%' ><p><a name="fff32e73-3ee2-4ca7-89c1-5f8cb93c97f0"></a></p>

<h3>KimonoProperty ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a7ae8aff-214d-44d5-9cd8-efc56483c9c0">KimonoProperty</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77187db9-f75e-4e69-9181-3c4ad57d61c7'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="77187db9-f75e-4e69-9181-3c4ad57d61c7"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4bab2213-5afc-4f80-83bc-1d5b78fe7889'>ToRect</a></td><td style='width:75%' ><p><a name="4bab2213-5afc-4f80-83bc-1d5b78fe7889"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#862e35f5-c44d-4970-91af-e988725ba45a'>ToFloat</a></td><td style='width:75%' class='def'><p><a name="862e35f5-c44d-4970-91af-e988725ba45a"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fd6f4f9-0e7d-48eb-bf7e-7cce600512ad'>ToInt</a></td><td style='width:75%' ><p><a name="7fd6f4f9-0e7d-48eb-bf7e-7cce600512ad"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07dc11cb-8517-4df8-a0e0-16d7fe109ab6'>ToStyle</a></td><td style='width:75%' class='def'><p><a name="07dc11cb-8517-4df8-a0e0-16d7fe109ab6"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2735e2d4-dd3e-4662-95d1-97d1ddb225f5'>ToBool</a></td><td style='width:75%' ><p><a name="2735e2d4-dd3e-4662-95d1-97d1ddb225f5"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p>The <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fdc67de-8974-4bbf-8b2d-964ba2365f3a'>ToColor</a></td><td style='width:75%' class='def'><p><a name="5fdc67de-8974-4bbf-8b2d-964ba2365f3a"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cd96e69-7650-4398-9ae0-4d8435d1ac3d'>ToGradient</a></td><td style='width:75%' ><p><a name="8cd96e69-7650-4398-9ae0-4d8435d1ac3d"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73480ed7-e828-4faa-8c0a-891d07946969'>Clone</a></td><td style='width:75%' class='def'><p><a name="73480ed7-e828-4faa-8c0a-891d07946969"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="66d39ff0-f7a8-4244-92df-432427b23341"></a>
##KimonoPropertyUsage

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines how a `KimonoProperty` is used when it is attached to a `KimonoShape`, `KimonoSketch` or `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b05a81a0-6ef8-4db1-a577-e95b75c8afad'>LocalVariable</a></td><td style='width:75%' ><p><a name="b05a81a0-6ef8-4db1-a577-e95b75c8afad"></a>
<b>LocalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a local variable in the  generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b55247d3-5742-455a-a38f-bc38e1d5d034'>GlobalVariable</a></td><td style='width:75%' class='def'><p><a name="b55247d3-5742-455a-a38f-bc38e1d5d034"></a>
<b>GlobalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a global variable in the generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a95069c3-97bf-4d75-9ad3-9478061933fd'>Parameter</a></td><td style='width:75%' ><p><a name="a95069c3-97bf-4d75-9ad3-9478061933fd"></a>
<b>Parameter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a passed parameter in the generated code for a Kimono object.</p>
</td></tr></table></p>


---

<a name="5326511f-40f1-4106-a05b-4fd702e264f4"></a>
##KimonoPropertyConnectionPoint

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the point that a `KimonoProperty` value can be connected to another Kimono object such as the `Top` coordinate of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0f51abda-28d4-464f-a30a-f1db34b0cb3b'>Undefined</a></td><td style='width:75%' ><p><a name="0f51abda-28d4-464f-a30a-f1db34b0cb3b"></a>
<b>Undefined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The connection point hasn't been defined.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c63466e-e914-4656-a23b-fa260e81d15f'>Rect</a></td><td style='width:75%' class='def'><p><a name="1c63466e-e914-4656-a23b-fa260e81d15f"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The rectangle that defines the <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc11022d-0755-483a-82fe-d56ce8251329'>Top</a></td><td style='width:75%' ><p><a name="bc11022d-0755-483a-82fe-d56ce8251329"></a>
<b>Top</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Top coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1641434-cb70-49b7-a26a-f38307713b63'>Left</a></td><td style='width:75%' class='def'><p><a name="d1641434-cb70-49b7-a26a-f38307713b63"></a>
<b>Left</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Left coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6508007d-374a-4ef4-b3f6-b13f65532802'>Bottom</a></td><td style='width:75%' ><p><a name="6508007d-374a-4ef4-b3f6-b13f65532802"></a>
<b>Bottom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Bottom coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#deee243c-6eb1-4fd8-a14d-2735a06fb5b1'>Right</a></td><td style='width:75%' class='def'><p><a name="deee243c-6eb1-4fd8-a14d-2735a06fb5b1"></a>
<b>Right</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Right coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ca212ac-d420-4fd5-afe5-57744465ede8'>Width</a></td><td style='width:75%' ><p><a name="1ca212ac-d420-4fd5-afe5-57744465ede8"></a>
<b>Width</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Widht of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8529419d-0850-4693-a03b-0a3c6b696787'>Height</a></td><td style='width:75%' class='def'><p><a name="8529419d-0850-4693-a03b-0a3c6b696787"></a>
<b>Height</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Height of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#027b2960-fe0c-4017-a222-8b44f10f3c3e'>RotationDegrees</a></td><td style='width:75%' ><p><a name="027b2960-fe0c-4017-a222-8b44f10f3c3e"></a>
<b>RotationDegrees</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Rotational Degrees of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfc4c636-c5e1-4341-bb0a-7df655042c4e'>Style</a></td><td style='width:75%' class='def'><p><a name="bfc4c636-c5e1-4341-bb0a-7df655042c4e"></a>
<b>Style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The <code>KimonoStyle</code> of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96b7e51f-2c5f-4a74-9af2-1edf26587b1c'>Visible</a></td><td style='width:75%' ><p><a name="96b7e51f-2c5f-4a74-9af2-1edf26587b1c"></a>
<b>Visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93076be0-4859-43d0-9a58-181bf75ff9c7'>HasStartHead</a></td><td style='width:75%' class='def'><p><a name="93076be0-4859-43d0-9a58-181bf75ff9c7"></a>
<b>HasStartHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has start head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de548431-9136-40d9-9b06-05b40afffab3'>HasEndHead</a></td><td style='width:75%' ><p><a name="de548431-9136-40d9-9b06-05b40afffab3"></a>
<b>HasEndHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has end head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5fbae8a-57af-40db-b413-9e1811717126'>HeadInnerRatio</a></td><td style='width:75%' class='def'><p><a name="b5fbae8a-57af-40db-b413-9e1811717126"></a>
<b>HeadInnerRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head inner ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3038915-52d7-4066-a257-c70393d53019'>HeadOuterRatio</a></td><td style='width:75%' ><p><a name="c3038915-52d7-4066-a257-c70393d53019"></a>
<b>HeadOuterRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head outer ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1020e5b2-7ccb-40ee-be56-ed4e6385de05'>IsStreamlined</a></td><td style='width:75%' class='def'><p><a name="1020e5b2-7ccb-40ee-be56-ed4e6385de05"></a>
<b>IsStreamlined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is streamlined of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e4de215-a948-40ab-aaff-17afc785f928'>NumberOfSides</a></td><td style='width:75%' ><p><a name="6e4de215-a948-40ab-aaff-17afc785f928"></a>
<b>NumberOfSides</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of sides of a <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9ad609b-92d9-4d64-92dc-af2f83d33039'>CornerRadius</a></td><td style='width:75%' class='def'><p><a name="e9ad609b-92d9-4d64-92dc-af2f83d33039"></a>
<b>CornerRadius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The corner radius of a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4236de54-cb12-4c0e-a823-cc6bcff7bba5'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="4236de54-cb12-4c0e-a823-cc6bcff7bba5"></a>
<b>NumberOfPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba4b5881-384a-45fe-86b4-843e80d0a96e'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="ba4b5881-384a-45fe-86b4-843e80d0a96e"></a>
<b>SkipPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The skip points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#227b3534-ed77-4139-bba0-a0ca0c8d8f85'>DepthOffset</a></td><td style='width:75%' ><p><a name="227b3534-ed77-4139-bba0-a0ca0c8d8f85"></a>
<b>DepthOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The depth offset of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc4db133-7c2b-4e75-8499-0f23aae0a9ff'>Text</a></td><td style='width:75%' class='def'><p><a name="bc4db133-7c2b-4e75-8499-0f23aae0a9ff"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text of a <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#402fb56e-0d4e-4f42-b422-0c4a0403f9a9'>BaseColor</a></td><td style='width:75%' ><p><a name="402fb56e-0d4e-4f42-b422-0c4a0403f9a9"></a>
<b>BaseColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base color of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62214567-9954-4417-87ca-500274287c74'>AdjustsHue</a></td><td style='width:75%' class='def'><p><a name="62214567-9954-4417-87ca-500274287c74"></a>
<b>AdjustsHue</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts hue of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c0e017a-99b3-45af-aedc-1313c59f7386'>HueAdjustment</a></td><td style='width:75%' ><p><a name="5c0e017a-99b3-45af-aedc-1313c59f7386"></a>
<b>HueAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The hue adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#026cbb97-f173-4de6-86d3-8ebe08606df7'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p><a name="026cbb97-f173-4de6-86d3-8ebe08606df7"></a>
<b>AdjustsSaturation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts saturation of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1f6cfdc-1408-48ff-9625-f08ea4624d78'>SaturationAdjustment</a></td><td style='width:75%' ><p><a name="d1f6cfdc-1408-48ff-9625-f08ea4624d78"></a>
<b>SaturationAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The saturation adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae9fa141-46a8-4cac-9577-126def3e2588'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p><a name="ae9fa141-46a8-4cac-9577-126def3e2588"></a>
<b>AdjustsBrightness</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts brightness of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#658f3815-71ac-480c-a8d8-46c9f35d298d'>BrightnessAdjustment</a></td><td style='width:75%' ><p><a name="658f3815-71ac-480c-a8d8-46c9f35d298d"></a>
<b>BrightnessAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The brightness adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24ea3512-f860-479f-9d72-ff8cdf5f3b71'>AdjustsAlpha</a></td><td style='width:75%' class='def'><p><a name="24ea3512-f860-479f-9d72-ff8cdf5f3b71"></a>
<b>AdjustsAlpha</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts alpha of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74fe0273-f07b-4f18-9fdc-e173e5ea01f1'>AlphaAdjustment</a></td><td style='width:75%' ><p><a name="74fe0273-f07b-4f18-9fdc-e173e5ea01f1"></a>
<b>AlphaAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The alpha adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce807d65-f0b0-4362-9aae-12d04d1c2157'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="ce807d65-f0b0-4362-9aae-12d04d1c2157"></a>
<b>HasFrame</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bccb5146-eb82-47ec-80d6-27f2861aee4e'>HasFrameBlur</a></td><td style='width:75%' ><p><a name="bccb5146-eb82-47ec-80d6-27f2861aee4e"></a>
<b>HasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57812302-7a65-4795-8526-04d7a068ff2f'>FrameHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="57812302-7a65-4795-8526-04d7a068ff2f"></a>
<b>FrameHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a707eb4b-70fc-4c51-802a-0eb53b839be7'>FrameVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="a707eb4b-70fc-4c51-802a-0eb53b839be7"></a>
<b>FrameVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd0baec7-7393-4a34-a6d7-4804668aa319'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="bd0baec7-7393-4a34-a6d7-4804668aa319"></a>
<b>HasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46556dba-f260-4c02-a892-33176e12d12e'>FrameShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="46556dba-f260-4c02-a892-33176e12d12e"></a>
<b>FrameShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f62820dd-488b-4a7b-ad49-3efdf51455b7'>FrameShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="f62820dd-488b-4a7b-ad49-3efdf51455b7"></a>
<b>FrameShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#392cbeef-464c-4967-88bb-8bde7b5c94bb'>FrameShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="392cbeef-464c-4967-88bb-8bde7b5c94bb"></a>
<b>FrameShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow horizontal blur amount of a `KimonoStyle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ebfe09c-b636-4edc-b994-82a107d82ecd'>FrameShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="2ebfe09c-b636-4edc-b994-82a107d82ecd"></a>
<b>FrameShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d15bb38-8f63-47e3-80fc-04ff8ecd176a'>FrameShadowLinkedColor</a></td><td style='width:75%' ><p><a name="4d15bb38-8f63-47e3-80fc-04ff8ecd176a"></a>
<b>FrameShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31b46e52-4170-43f7-87fa-83006011ae8d'>HasFill</a></td><td style='width:75%' class='def'><p><a name="31b46e52-4170-43f7-87fa-83006011ae8d"></a>
<b>HasFill</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06dc9556-04bf-49c4-998d-0bcab0205de0'>HasFillBlur</a></td><td style='width:75%' ><p><a name="06dc9556-04bf-49c4-998d-0bcab0205de0"></a>
<b>HasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f62e38e-c841-4267-8701-de1072569941'>FillHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="7f62e38e-c841-4267-8701-de1072569941"></a>
<b>FillHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e90b62c-39f6-4755-956f-afec7847e2e4'>FillVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="7e90b62c-39f6-4755-956f-afec7847e2e4"></a>
<b>FillVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4397e92-99a6-4f7f-a079-9bcb548412fa'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="b4397e92-99a6-4f7f-a079-9bcb548412fa"></a>
<b>HasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29755d5e-a2e7-47db-b386-d55da82a9b54'>FillShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="29755d5e-a2e7-47db-b386-d55da82a9b54"></a>
<b>FillShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0cffa10-5872-499e-aaa4-ab803565a9a9'>FillShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="e0cffa10-5872-499e-aaa4-ab803565a9a9"></a>
<b>FillShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b33326f0-f4d9-4907-8b25-7c2db9f47753'>FillShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="b33326f0-f4d9-4907-8b25-7c2db9f47753"></a>
<b>FillShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18f4bd51-5d0d-41f7-a91f-604c21b0f7aa'>FillShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="18f4bd51-5d0d-41f7-a91f-604c21b0f7aa"></a>
<b>FillShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#895851c7-7abe-4141-af36-702a849ea3d4'>FillShadowLinkedColor</a></td><td style='width:75%' ><p><a name="895851c7-7abe-4141-af36-702a849ea3d4"></a>
<b>FillShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f503faff-c1a8-446d-ba28-e2960b283d4f'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="f503faff-c1a8-446d-ba28-e2960b283d4f"></a>
<b>FrameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0d84bd2-9eb2-423c-8da5-de5ad70a83e6'>FrameGradient</a></td><td style='width:75%' ><p><a name="e0d84bd2-9eb2-423c-8da5-de5ad70a83e6"></a>
<b>FrameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0e41d4e-f9f1-42a6-8a0b-09e8c7c94b36'>FillColor</a></td><td style='width:75%' class='def'><p><a name="a0e41d4e-f9f1-42a6-8a0b-09e8c7c94b36"></a>
<b>FillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#704df65a-b1ec-450d-b777-bc6b27f7e4b0'>FillGradient</a></td><td style='width:75%' ><p><a name="704df65a-b1ec-450d-b777-bc6b27f7e4b0"></a>
<b>FillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d615c38b-f284-4586-9141-c3baf1ebc613'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="d615c38b-f284-4586-9141-c3baf1ebc613"></a>
<b>IsVerticalText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is vertical text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8b38478-0453-40b9-89ed-41dac9d69f09'>StrikeThruText</a></td><td style='width:75%' ><p><a name="d8b38478-0453-40b9-89ed-41dac9d69f09"></a>
<b>StrikeThruText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The strike thru text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8578b7cf-7f29-48e6-976d-20ca1cdc7797'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="8578b7cf-7f29-48e6-976d-20ca1cdc7797"></a>
<b>TextScaleX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text scale x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aad83575-8b6f-45a4-b5be-eeea2e50dca6'>TextSize</a></td><td style='width:75%' ><p><a name="aad83575-8b6f-45a4-b5be-eeea2e50dca6"></a>
<b>TextSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70c1754a-528e-473a-ad8e-848116eaaef0'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="70c1754a-528e-473a-ad8e-848116eaaef0"></a>
<b>TextSkewX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text skew x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f3e43c7-bbf3-40e8-8840-e9f4fa52e64f'>FontFamilyName</a></td><td style='width:75%' ><p><a name="3f3e43c7-bbf3-40e8-8840-e9f4fa52e64f"></a>
<b>FontFamilyName</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The name of the font family of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#054a06ab-2c9b-4092-8d87-e383961c42a1'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="054a06ab-2c9b-4092-8d87-e383961c42a1"></a>
<b>UnderlineText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The underline text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e848e65-d041-47c7-b752-63a3436aeb02'>HasFrameJitter</a></td><td style='width:75%' ><p><a name="9e848e65-d041-47c7-b752-63a3436aeb02"></a>
<b>HasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#472c9505-43fb-468e-b32a-aaae5f59c257'>FrameJitterLength</a></td><td style='width:75%' class='def'><p><a name="472c9505-43fb-468e-b32a-aaae5f59c257"></a>
<b>FrameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#479e1ead-5af1-4a41-a377-187935c25ecd'>FrameJitterDeviation</a></td><td style='width:75%' ><p><a name="479e1ead-5af1-4a41-a377-187935c25ecd"></a>
<b>FrameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d0104e0-7858-4968-9f4b-c58bd165cf26'>HasFillJitter</a></td><td style='width:75%' class='def'><p><a name="3d0104e0-7858-4968-9f4b-c58bd165cf26"></a>
<b>HasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17738514-c241-4dd9-a9c9-cdeaeec1809a'>FillJitterLength</a></td><td style='width:75%' ><p><a name="17738514-c241-4dd9-a9c9-cdeaeec1809a"></a>
<b>FillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3e60484-0b09-48d9-8b95-52ac5b402540'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="e3e60484-0b09-48d9-8b95-52ac5b402540"></a>
<b>FillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94317ddc-999f-427b-9997-0b1a6de7e5a6'>HasFrameDash</a></td><td style='width:75%' ><p><a name="94317ddc-999f-427b-9997-0b1a6de7e5a6"></a>
<b>HasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame dash of a <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="7f9b2b1a-b792-46bd-8c6d-79ae3e6ce1ee"></a>
##KimonoPropertyConnection

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a connection between a given Kimono Object and a `KimonoProperty`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aa239068-46ed-49c9-ad68-da39806fa1ae'>UniqueID</a></td><td style='width:75%' ><p><a name="aa239068-46ed-49c9-ad68-da39806fa1ae"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60e42100-416f-4aec-9a80-bf51dc800664'>ConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="60e42100-416f-4aec-9a80-bf51dc800664"></a></p>

<h3>ConnectionPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the point that a given <code>KimonoProperty</code> is connected to another Kimono Object.</p>

<h4>Return Value</h4>

<p>The connection point as a <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd2802ee-165e-4380-b6a0-a0dda0591a88'>ConnectedProperty</a></td><td style='width:75%' ><p><a name="dd2802ee-165e-4380-b6a0-a0dda0591a88"></a></p>

<h3>ConnectedProperty</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the connected property.</p>

<h4>Return Value</h4>

<p>The connected <code>KimonoProperty</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4df5c497-8814-4b01-9481-43f733d4bfc4'>KimonoPropertyConnection</a></td><td style='width:75%' ><p><a name="4df5c497-8814-4b01-9481-43f733d4bfc4"></a></p>

<h3>KimonoPropertyConnection ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7f9b2b1a-b792-46bd-8c6d-79ae3e6ce1ee">KimonoPropertyConnection</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6aeb0536-e861-4f21-826b-77ad759a9975'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p><a name="6aeb0536-e861-4f21-826b-77ad759a9975"></a></p>

<h3>KimonoPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7f9b2b1a-b792-46bd-8c6d-79ae3e6ce1ee">KimonoPropertyConnection</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="edbbfb8e-7617-47ec-adbd-a6719c8d8145"></a>
Connection point.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="f64463b0-85e1-45f0-b2f0-aa243840362e"></a>
Property.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f1c1aec-b401-4365-b85d-bb874501c90c'>Clone</a></td><td style='width:75%' ><p><a name="3f1c1aec-b401-4365-b85d-bb874501c90c"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="8fa8c182-e507-422e-b805-7348335c0b5b"></a>
##ObiScriptResult

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the result of attempting to execute an Obi Script on a `KimonoProperty`
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#66b3098f-f77d-4305-9ef6-a84cd3599aa8'>Successful</a></td><td style='width:75%' ><p><a name="66b3098f-f77d-4305-9ef6-a84cd3599aa8"></a></p>

<h3>Successful</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the Obi Script ran successfully.</p>

<h4>Return Value</h4>

<p><code>true</code> if successful; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d736081e-0180-49b3-b0bd-f741f119868c'>ErrorMessage</a></td><td style='width:75%' class='def'><p><a name="d736081e-0180-49b3-b0bd-f741f119868c"></a></p>

<h3>ErrorMessage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the error message if the Obi Script execution failed.</p>

<h4>Return Value</h4>

<p>The error message or "" if the script ran successfully.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ab16e197-c44d-4516-a373-6358309e5f91'>ObiScriptResult</a></td><td style='width:75%' ><p><a name="ab16e197-c44d-4516-a373-6358309e5f91"></a></p>

<h3>ObiScriptResult ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8fa8c182-e507-422e-b805-7348335c0b5b">ObiScriptResult</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fe2d3ca-4b58-40ba-af1b-d82976f051f5'>ObiScriptResult</a></td><td style='width:75%' class='def'><p><a name="7fe2d3ca-4b58-40ba-af1b-d82976f051f5"></a></p>

<h3>ObiScriptResult (System.Boolean, System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8fa8c182-e507-422e-b805-7348335c0b5b">ObiScriptResult</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>isSuccessful</td><td style='width:75%' ><p><a name="195d86f4-3b36-4b49-9eb8-23bfb2543bf6"></a>
If set to <code>true</code> is successful.</p>
</td></tr><tr><td style='width:25%' class='term'>errorMessage</td><td style='width:75%' class='def'><p><a name="84abd32b-5b0b-47a0-a55b-5fd92fe33f6e"></a>
Error message.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="7918b823-8e79-45ac-86c0-0912d87dcd78"></a>
##KimonoBezierPoint

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Holds the control and end point for a `KimonoShapeBezier` that define a quad section of the Bezier.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#77cbede5-1d0e-419e-b680-5ee8b137f17c'>ControlPoint</a></td><td style='width:75%' ><p><a name="77cbede5-1d0e-419e-b680-5ee8b137f17c"></a></p>

<h3>ControlPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control point.</p>

<h4>Return Value</h4>

<p>The control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8ff1b65-efc2-420d-b9f4-534a6a312195'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="f8ff1b65-efc2-420d-b9f4-534a6a312195"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#813f5cc2-c3a1-42f5-90ec-da03a681818c'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="813f5cc2-c3a1-42f5-90ec-da03a681818c"></a></p>

<h3>KimonoBezierPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7918b823-8e79-45ac-86c0-0912d87dcd78">KimonoBezierPoint</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#885cd955-be8e-42df-a970-c9c4346fa3ea'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p><a name="885cd955-be8e-42df-a970-c9c4346fa3ea"></a></p>

<h3>KimonoBezierPoint (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7918b823-8e79-45ac-86c0-0912d87dcd78">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlPoint</td><td style='width:75%' ><p><a name="656f2ad1-f0cf-4b92-9099-f7f83bf354ca"></a>
Control point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="726e4a8e-ea25-4745-83be-4893707170b6"></a>
End point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4512ebe-b76f-443a-b5cb-febd32057c48'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="d4512ebe-b76f-443a-b5cb-febd32057c48"></a></p>

<h3>KimonoBezierPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7918b823-8e79-45ac-86c0-0912d87dcd78">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="f9b3c630-f0e6-4918-ba0a-e71d52b23ef6"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="416debbe-70fa-412a-a9d9-2cf63b5da5de"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="fa6d00dc-c358-4098-b603-4ef21177a54d"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="08056272-5c63-4cd6-9783-a634f41d6b4b"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8177909-8190-4f99-be61-d0f1e42abaf3'>Clone</a></td><td style='width:75%' class='def'><p><a name="f8177909-8190-4f99-be61-d0f1e42abaf3"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="ae73d413-e603-4d6c-abd3-d19e4199634e"></a>
##KimonoBounds

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the outter bounding box for a `KimonoShape` and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2ac40186-e9a7-4040-9103-20f5c560e3a0'>Rect</a></td><td style='width:75%' ><p><a name="2ac40186-e9a7-4040-9103-20f5c560e3a0"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base <code>SkRect</code> that holds the internal bounds of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2da406a-c3d1-4590-92ea-e3f57c26ae00'>PreviousCenter</a></td><td style='width:75%' class='def'><p><a name="c2da406a-c3d1-4590-92ea-e3f57c26ae00"></a>
<b>PreviousCenter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous center used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83ddb8d8-a0c1-4700-b4fa-cf6137b4da34'>PreviousRect</a></td><td style='width:75%' ><p><a name="83ddb8d8-a0c1-4700-b4fa-cf6137b4da34"></a>
<b>PreviousRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous rect used in scaling operations.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#33ea607a-cb62-426c-ab4b-21bd338db318'>State</a></td><td style='width:75%' ><p><a name="33ea607a-cb62-426c-ab4b-21bd338db318"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the current edit state of the <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe675623-1d7b-4a6f-b4c3-a760989bd9ac'>Name</a></td><td style='width:75%' class='def'><p><a name="fe675623-1d7b-4a6f-b4c3-a760989bd9ac"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ef78550-4fa1-43ad-b559-6b13c0507382'>UniqueID</a></td><td style='width:75%' ><p><a name="7ef78550-4fa1-43ad-b559-6b13c0507382"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc75bbfa-5ca2-46e2-9e15-f2718a0cbe32'>Top</a></td><td style='width:75%' class='def'><p><a name="cc75bbfa-5ca2-46e2-9e15-f2718a0cbe32"></a></p>

<h3>Top</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top.</p>

<h4>Return Value</h4>

<p>The top coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52e9c5b0-3fe9-4adf-9906-054e3ef16616'>Left</a></td><td style='width:75%' ><p><a name="52e9c5b0-3fe9-4adf-9906-054e3ef16616"></a></p>

<h3>Left</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left.</p>

<h4>Return Value</h4>

<p>The left coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f94f248-d269-45db-b52c-f7a3cb813ef2'>Bottom</a></td><td style='width:75%' class='def'><p><a name="0f94f248-d269-45db-b52c-f7a3cb813ef2"></a></p>

<h3>Bottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom.</p>

<h4>Return Value</h4>

<p>The bottom coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee84926b-d380-4339-a973-da34e2f4b62e'>Right</a></td><td style='width:75%' ><p><a name="ee84926b-d380-4339-a973-da34e2f4b62e"></a></p>

<h3>Right</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right.</p>

<h4>Return Value</h4>

<p>The right coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1bf3a17-6a0d-4141-a090-f9eddf8a10f5'>Width</a></td><td style='width:75%' class='def'><p><a name="f1bf3a17-6a0d-4141-a090-f9eddf8a10f5"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#020fa71e-e3c1-449d-9e6f-509fe0ca0d07'>Height</a></td><td style='width:75%' ><p><a name="020fa71e-e3c1-449d-9e6f-509fe0ca0d07"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ddf76a1-ad47-47f4-8680-f041cc70d531'>HorizontalCenter</a></td><td style='width:75%' class='def'><p><a name="0ddf76a1-ad47-47f4-8680-f041cc70d531"></a></p>

<h3>HorizontalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the horizontal center.</p>

<h4>Return Value</h4>

<p>The horizontal center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1eb05e3a-32df-4f98-9629-e5acb88878d5'>VerticalCenter</a></td><td style='width:75%' ><p><a name="1eb05e3a-32df-4f98-9629-e5acb88878d5"></a></p>

<h3>VerticalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the vertical center.</p>

<h4>Return Value</h4>

<p>The vertical center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#caadf4ca-06dc-4ad3-b936-54833dc497ab'>Center</a></td><td style='width:75%' class='def'><p><a name="caadf4ca-06dc-4ad3-b936-54833dc497ab"></a></p>

<h3>Center</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the center.</p>

<h4>Return Value</h4>

<p>The center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52b8bbf0-bc33-41a0-ac91-52981dcdb593'>RotationDegrees</a></td><td style='width:75%' ><p><a name="52b8bbf0-bc33-41a0-ac91-52981dcdb593"></a></p>

<h3>RotationDegrees</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the rotation degrees.</p>

<h4>Return Value</h4>

<p>The rotation degrees.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63432007-17e3-4c10-9441-7656e64deaf4'>TopLeftHandle</a></td><td style='width:75%' class='def'><p><a name="63432007-17e3-4c10-9441-7656e64deaf4"></a></p>

<h3>TopLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top left handle.</p>

<h4>Return Value</h4>

<p>The top left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2404c0d-3d55-438f-bc4f-325b8170996a'>TopHandle</a></td><td style='width:75%' ><p><a name="a2404c0d-3d55-438f-bc4f-325b8170996a"></a></p>

<h3>TopHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top handle.</p>

<h4>Return Value</h4>

<p>The top handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a3190d1-5d45-4fbf-8b90-c5b2e1bfba0d'>TopRightHandle</a></td><td style='width:75%' class='def'><p><a name="1a3190d1-5d45-4fbf-8b90-c5b2e1bfba0d"></a></p>

<h3>TopRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top right handle.</p>

<h4>Return Value</h4>

<p>The top right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2196961c-1417-48a2-af0f-99308a2e5cfd'>RightHandle</a></td><td style='width:75%' ><p><a name="2196961c-1417-48a2-af0f-99308a2e5cfd"></a></p>

<h3>RightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right handle.</p>

<h4>Return Value</h4>

<p>The right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6ff3c10-83aa-4b25-8641-2adcd8d5f891'>BottomRightHandle</a></td><td style='width:75%' class='def'><p><a name="e6ff3c10-83aa-4b25-8641-2adcd8d5f891"></a></p>

<h3>BottomRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom right handle.</p>

<h4>Return Value</h4>

<p>The bottom right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#444fe4c5-c406-4c87-9782-85013483e3d4'>BottomHandle</a></td><td style='width:75%' ><p><a name="444fe4c5-c406-4c87-9782-85013483e3d4"></a></p>

<h3>BottomHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom handle.</p>

<h4>Return Value</h4>

<p>The bottom handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be4e7d49-cb37-48c2-8a00-65081441605e'>BottomLeftHandle</a></td><td style='width:75%' class='def'><p><a name="be4e7d49-cb37-48c2-8a00-65081441605e"></a></p>

<h3>BottomLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom left handle.</p>

<h4>Return Value</h4>

<p>The bottom left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a2edef4-9000-45d3-ae6d-17d0c5ecaebd'>LeftHandle</a></td><td style='width:75%' ><p><a name="7a2edef4-9000-45d3-ae6d-17d0c5ecaebd"></a></p>

<h3>LeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left handle.</p>

<h4>Return Value</h4>

<p>The left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e2724f1-192b-457e-bc83-e107b770d474'>HitOffset</a></td><td style='width:75%' class='def'><p><a name="6e2724f1-192b-457e-bc83-e107b770d474"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef8c5f31-3b53-4a3f-a984-6781a4b1de33'>HitHandle</a></td><td style='width:75%' ><p><a name="ef8c5f31-3b53-4a3f-a984-6781a4b1de33"></a></p>

<h3>HitHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit handle.</p>

<h4>Return Value</h4>

<p>The hit handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1b975c3c-68b8-41c7-af5f-51e4f7ef13ab'>KimonoBounds</a></td><td style='width:75%' ><p><a name="1b975c3c-68b8-41c7-af5f-51e4f7ef13ab"></a></p>

<h3>KimonoBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae73d413-e603-4d6c-abd3-d19e4199634e">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#476ed427-b141-4588-acf9-ccd44246c729'>KimonoBounds</a></td><td style='width:75%' class='def'><p><a name="476ed427-b141-4588-acf9-ccd44246c729"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae73d413-e603-4d6c-abd3-d19e4199634e">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="ee297c81-3bbf-4bfb-b55b-9288bf888094"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="18e972f2-edfb-4357-a407-081b0b1dd916"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ff59e70f-b235-4ed4-9627-0a6730d52e08"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="10d7b63d-7040-46d0-976a-67bf3f972a9e"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd4605f3-6822-46d8-a245-ff14400bb1d3'>KimonoBounds</a></td><td style='width:75%' ><p><a name="fd4605f3-6822-46d8-a245-ff14400bb1d3"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae73d413-e603-4d6c-abd3-d19e4199634e">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9c37f2f3-be33-45a8-8195-81a35d3934b3"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6f274caf-f4c9-466b-8779-8ad1c4f91eed"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="553a2f6e-6bf9-4300-8b36-998fd7611729"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="d79be9a7-24ce-401c-8303-48cd9bad8a93"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="4886e96b-159b-42db-a6c5-bda42aace93b"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c49ec19-0807-40a1-b8ac-ea71ec0ea039'>SavePreviousBounds</a></td><td style='width:75%' class='def'><p><a name="6c49ec19-0807-40a1-b8ac-ea71ec0ea039"></a></p>

<h3>SavePreviousBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6be8450-2a08-417e-b35e-b83c1f5d7db0'>ValueBetween</a></td><td style='width:75%' ><p><a name="d6be8450-2a08-417e-b35e-b83c1f5d7db0"></a></p>

<h3>ValueBetween (System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Checks to see if the given value is between the two given points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="9f0833c9-2e02-4196-a610-34c58ac6bcf0"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p><a name="426e7377-65ad-47bc-9190-893540157cf9"></a>
The alpha component.</p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p><a name="3f328d44-1aa3-4fae-a143-4dfb70986474"></a>
The blue component.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>Boolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75431c5a-9f54-4818-a1b1-f3a8518c9d17'>AddHandles</a></td><td style='width:75%' class='def'><p><a name="75431c5a-9f54-4818-a1b1-f3a8518c9d17"></a></p>

<h3>AddHandles (KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the control handles to the bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#758aa8da-ac3c-4df2-915f-e8d49ea1a7a2'>RemoveHandles</a></td><td style='width:75%' ><p><a name="758aa8da-ac3c-4df2-915f-e8d49ea1a7a2"></a></p>

<h3>RemoveHandles ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the control handles from the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#629436f8-bcd9-4186-89df-468cfcf4c925'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="629436f8-bcd9-4186-89df-468cfcf4c925"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates the location of the edit handles when the bounds has been relocated or resized.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5785bedf-b16f-44f9-811b-a2fba8e1f830'>Draw</a></td><td style='width:75%' ><p><a name="5785bedf-b16f-44f9-811b-a2fba8e1f830"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bounding box and its edit handles into the given canvas</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="829d33db-8b59-4588-a257-3fffbef944f1"></a>
Canvas.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#154c09b8-d69c-422a-b54d-d2bfa25e28bc'>Select</a></td><td style='width:75%' class='def'><p><a name="154c09b8-d69c-422a-b54d-d2bfa25e28bc"></a></p>

<h3>Select ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Puts the <code>KimonoShape</code> into the edit mode and creates the edit handles as required.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#648a3d96-9aaf-4a2b-a96f-efb397d9d10b'>PlaceUnderConstruction</a></td><td style='width:75%' ><p><a name="648a3d96-9aaf-4a2b-a96f-efb397d9d10b"></a></p>

<h3>PlaceUnderConstruction (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the bounds under construction.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p><a name="f07ddfa4-f22e-4855-81bd-d8d9a891082f"></a>
If set to <code>true</code> needs handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abdbaa7a-38b4-477a-afaa-be9fb3784ede'>StartGrouping</a></td><td style='width:75%' class='def'><p><a name="abdbaa7a-38b4-477a-afaa-be9fb3784ede"></a></p>

<h3>StartGrouping ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts the bounds grouping.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9b9fa6f-3de3-4a5f-925d-73043a700007'>Unselect</a></td><td style='width:75%' ><p><a name="a9b9fa6f-3de3-4a5f-925d-73043a700007"></a></p>

<h3>Unselect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Unselects the <code>KimonoShape</code> as the current edit target and removes any edit handles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6dfad39c-12ea-49d1-acab-85639f48bd96'>ChangeBounds</a></td><td style='width:75%' class='def'><p><a name="6dfad39c-12ea-49d1-acab-85639f48bd96"></a></p>

<h3>ChangeBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Changes the bounds to match the given values.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8cabc2f6-eeaf-4090-92c5-19ad5e608253"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="34a6a00e-f8a0-4475-992a-705c6c25ea9f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="555a8a0e-b6d2-477b-944b-3ba8c9e2103c"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="98d804a0-d19a-411d-996b-9f7ebacebd1b"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15bbc0b2-2e9f-4244-a254-9f458d6a6e78'>GrowBounds</a></td><td style='width:75%' ><p><a name="15bbc0b2-2e9f-4244-a254-9f458d6a6e78"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adjusts the size of the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="576d6f82-2e04-4015-8569-8bb0fa933356"></a>
The new size as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58b1f82e-013d-4574-9b26-b88e46ce1c19'>MoveBounds</a></td><td style='width:75%' class='def'><p><a name="58b1f82e-013d-4574-9b26-b88e46ce1c19"></a></p>

<h3>MoveBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the bounds to the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="859f582e-ce58-47d0-8daf-28beec3b0250"></a>
The new top, left location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec4cb96c-4d7e-4138-98c8-5303ee14aa01'>DragBounds</a></td><td style='width:75%' ><p><a name="ec4cb96c-4d7e-4138-98c8-5303ee14aa01"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="f1bb93f3-bf6f-4599-bc86-d332fbc05ee7"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#216a7f53-6dba-459f-9a8f-f84883ad0d1b'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="216a7f53-6dba-459f-9a8f-f84883ad0d1b"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="2189a553-ce3d-4d6a-b027-54e7b144fc3f"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#835c679e-a7e1-47ca-b190-2e74ca9372ac'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="835c679e-a7e1-47ca-b190-2e74ca9372ac"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#228e02c7-f72b-4800-ad1d-f6ec96d7eb41'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="228e02c7-f72b-4800-ad1d-f6ec96d7eb41"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e71d444-da3b-40e1-967f-d24c31778108'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="0e71d444-da3b-40e1-967f-d24c31778108"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#434ca3ef-666b-45a5-b315-88b8aa17eaa4'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="434ca3ef-666b-45a5-b315-88b8aa17eaa4"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="40151577-abab-458b-b5b4-1f45da8aad39"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#683386b0-eaf5-4834-8c3d-75da51a71709'>ToCode</a></td><td style='width:75%' ><p><a name="683386b0-eaf5-4834-8c3d-75da51a71709"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="343f3d12-b5e0-4b20-97f2-7b8c6df33fb7"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e653af34-76d0-49f1-a049-69a92664329f"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f6c98827-9a04-44f4-8d86-e5af204b52e4"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ca6fc96-b76a-4a51-8829-7d2d69eb9772'>Clone</a></td><td style='width:75%' class='def'><p><a name="2ca6fc96-b76a-4a51-8829-7d2d69eb9772"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="7e3a3c18-1e19-4928-8110-331ea0733920"></a>
##KimonoHandle

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines an edit handle that the user manipulates to edit the bounds of a `KimonoShape` or the control points of a Bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5dff0dda-212f-4af7-9005-b933290f3119'>DrawWidth</a></td><td style='width:75%' ><p><a name="5dff0dda-212f-4af7-9005-b933290f3119"></a>
<b>DrawWidth</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The width of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bcc3f77f-e4de-4e26-8792-44e9856295e4'>DrawOffset</a></td><td style='width:75%' class='def'><p><a name="bcc3f77f-e4de-4e26-8792-44e9856295e4"></a>
<b>DrawOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The draw offset of the drag handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2332c824-4cf8-4448-bd13-936658a05e1e'>Index</a></td><td style='width:75%' ><p><a name="2332c824-4cf8-4448-bd13-936658a05e1e"></a></p>

<h3>Index</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the index.</p>

<h4>Return Value</h4>

<p>The index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bfec355-9064-4c48-b2da-73e29e1fdfca'>HandleType</a></td><td style='width:75%' class='def'><p><a name="5bfec355-9064-4c48-b2da-73e29e1fdfca"></a></p>

<h3>HandleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the handle.</p>

<h4>Return Value</h4>

<p>The type of the handle as a <code>KimonoHandleType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ab2d96a-697a-4319-85e8-cea68abc1669'>UniqueID</a></td><td style='width:75%' ><p><a name="7ab2d96a-697a-4319-85e8-cea68abc1669"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84e0b2f2-2844-4627-947c-a35adf7ba083'>State</a></td><td style='width:75%' class='def'><p><a name="84e0b2f2-2844-4627-947c-a35adf7ba083"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the edit state of the <code>KimonoHandle</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f18b974e-2ab5-46a2-8c25-6299fcf6a266'>X</a></td><td style='width:75%' ><p><a name="f18b974e-2ab5-46a2-8c25-6299fcf6a266"></a></p>

<h3>X</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the x value.</p>

<h4>Return Value</h4>

<p>The x coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d6e4d43-80ed-4673-b4b4-1878b113dab2'>Y</a></td><td style='width:75%' class='def'><p><a name="0d6e4d43-80ed-4673-b4b4-1878b113dab2"></a></p>

<h3>Y</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the y value.</p>

<h4>Return Value</h4>

<p>The y coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12e97e31-db5d-4f7a-a097-22779508962d'>Rect</a></td><td style='width:75%' ><p><a name="12e97e31-db5d-4f7a-a097-22779508962d"></a></p>

<h3>Rect</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the rect.</p>

<h4>Return Value</h4>

<p>The rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8b75bc6-50f2-4ae7-b4e5-99ed906a78ef'>Constraint</a></td><td style='width:75%' class='def'><p><a name="b8b75bc6-50f2-4ae7-b4e5-99ed906a78ef"></a></p>

<h3>Constraint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the edit constraint.</p>

<h4>Return Value</h4>

<p>The edit constraint as a <code>KimonoHandleConstraint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2eaae8a6-5ef5-430d-9ad3-d4a99e90fd26'>HitOffset</a></td><td style='width:75%' ><p><a name="2eaae8a6-5ef5-430d-9ad3-d4a99e90fd26"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db01b09a-c3ea-441a-96f8-71e7de562925'>Color</a></td><td style='width:75%' class='def'><p><a name="db01b09a-c3ea-441a-96f8-71e7de562925"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, this color will be used.</p>

<h4>Return Value</h4>

<p>The <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df2d80e8-6396-41f1-884a-1936da54bf86'>LinkedColor</a></td><td style='width:75%' ><p><a name="df2d80e8-6396-41f1-884a-1936da54bf86"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, the <code>Color</code> property will  be used instead.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5140c233-9efc-4399-ab90-90f5a24d8c24'>RepresentedColor</a></td><td style='width:75%' class='def'><p><a name="5140c233-9efc-4399-ab90-90f5a24d8c24"></a></p>

<h3>RepresentedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color that this handle represents.</p>

<h4>Return Value</h4>

<p>The color as a <code>SKColor</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b7ece862-a5ba-4795-b70c-72a960ec6978'>KimonoHandle</a></td><td style='width:75%' ><p><a name="b7ece862-a5ba-4795-b70c-72a960ec6978"></a></p>

<h3>KimonoHandle (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7e3a3c18-1e19-4928-8110-331ea0733920">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="76e10dbb-33fe-4164-8854-62a3cf3f31e6"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="2d1329e4-747a-4d3d-bf05-3eb3c044e100"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d76b4266-8583-4fd4-b63b-2760cea0ea23'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="d76b4266-8583-4fd4-b63b-2760cea0ea23"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7e3a3c18-1e19-4928-8110-331ea0733920">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="4c27c950-67af-47cd-aecf-ed5ba67299fe"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="22ed9760-4c93-45f9-9853-bc8283baa1a9"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="236dedd2-f114-45b0-9116-47fad52014a4"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a1f1b3c-fcd5-489d-a5dd-643c3deae297'>KimonoHandle</a></td><td style='width:75%' ><p><a name="1a1f1b3c-fcd5-489d-a5dd-643c3deae297"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7e3a3c18-1e19-4928-8110-331ea0733920">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="b14b8756-245d-4a32-8ab2-e753f39909e7"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="4b88b0b0-0413-451c-ba59-136979ad50ea"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="5ee5e2c0-1966-4c93-b9dc-87bd504fb001"></a>
Constraint.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3069d09-fb5f-49bd-9bfe-249d2692c0a6'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="a3069d09-fb5f-49bd-9bfe-249d2692c0a6"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7e3a3c18-1e19-4928-8110-331ea0733920">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="b073df6c-ac3b-4e8f-9793-93face2f881e"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="2f717c6a-c07e-44ab-aadf-9e4d626772c5"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="74ff8fac-940e-4f1a-8de5-a863c86ac5b5"></a>
Constraint.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="073ffa25-da01-46ae-9b05-50e86f43d45b"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eb1a068-f07e-477a-84e7-78e3412a855d'>Draw</a></td><td style='width:75%' ><p><a name="8eb1a068-f07e-477a-84e7-78e3412a855d"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the hanled into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="12d03565-150a-4ca5-a314-5ce3aa0b0af3"></a>
The <code>SKCanvas</code> to draw the hanled into.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The draw.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64fefd27-24eb-496a-96bc-c1cfe16f3a26'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="64fefd27-24eb-496a-96bc-c1cfe16f3a26"></a></p>

<h3>MoveTo (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the handle to the given coordinates.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="363b11fe-2804-4471-9d70-f65ad643036b"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="c8120c90-ef39-4519-b8f6-dd73b0ce3ca6"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1e88198-1d6d-4db0-9c3d-e2e979b2bcd2'>PointInBound</a></td><td style='width:75%' ><p><a name="e1e88198-1d6d-4db0-9c3d-e2e979b2bcd2"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="37ce5981-ceb4-471d-99a8-2db138d1d613"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d2adf5-0ab5-4f35-b9b9-534a93e41bf1'>DragHandle</a></td><td style='width:75%' class='def'><p><a name="a7d2adf5-0ab5-4f35-b9b9-534a93e41bf1"></a></p>

<h3>DragHandle (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the handle.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="4e71fcba-c9cf-4265-8e1c-22980ff45ccd"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3119665-01e3-4c4d-9ab3-992a4d84f33a'>ToPoint</a></td><td style='width:75%' ><p><a name="b3119665-01e3-4c4d-9ab3-992a4d84f33a"></a></p>

<h3>ToPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoHandle</code> to a Skia Point.</p>

<h4>Returns</h4>

<p>The <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64983583-d7c8-40ca-82db-c9a45c428ade'>Clone</a></td><td style='width:75%' class='def'><p><a name="64983583-d7c8-40ca-82db-c9a45c428ade"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86160358-174c-4ed1-89bf-d09742f4363d'>RaiseMoved</a></td><td style='width:75%' ><p><a name="86160358-174c-4ed1-89bf-d09742f4363d"></a></p>

<h3>RaiseMoved (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the moved event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="814ef769-4334-47dc-a1c6-2bf963578e52"></a>
Point.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b6e67f1e-53cc-4831-853e-57ee04ee6325'>Moved</a></td><td style='width:75%' ><p><a name="b6e67f1e-53cc-4831-853e-57ee04ee6325"></a></p>

<h3>Moved</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when moved.</p>
</td></tr></table></p>


---

<a name="687ff59f-90ea-4a8b-b656-7237bfa92a92"></a>
##KimonoHandleConstraint

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Constrains the movement of a `KimonoHandle` when it is being moved by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cc18248d-63fb-4110-949f-4275a96f4187'>None</a></td><td style='width:75%' ><p><a name="cc18248d-63fb-4110-949f-4275a96f4187"></a>
<b>None</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>No movement constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed14fb3e-1e01-43bf-a98d-9d268eae82c0'>Horizontal</a></td><td style='width:75%' class='def'><p><a name="ed14fb3e-1e01-43bf-a98d-9d268eae82c0"></a>
<b>Horizontal</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5499229-0703-48b7-8336-32dd3c2913c9'>Vertical</a></td><td style='width:75%' ><p><a name="c5499229-0703-48b7-8336-32dd3c2913c9"></a>
<b>Vertical</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved vertically.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaea0880-85c8-4b12-b4cd-5d88376a549c'>Locked</a></td><td style='width:75%' class='def'><p><a name="eaea0880-85c8-4b12-b4cd-5d88376a549c"></a>
<b>Locked</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle is locked in place and cannot be moved.</p>
</td></tr></table></p>


---

<a name="aab43a89-2c9c-4987-a125-a415ef2ae5dc"></a>
##KimonoHandleType

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoHandle` that can be used as a general purpose control point to adjust the bounds of a `KimonoShape` or as a point for a vector or bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fea16cfe-6a43-4869-b595-ef379ca2dad0'>ControlPoint</a></td><td style='width:75%' ><p><a name="fea16cfe-6a43-4869-b595-ef379ca2dad0"></a>
<b>ControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A general purpose handle for a shape's bound or a control point on a  vector or bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2300958d-4c09-4cac-9150-a26fc178f747'>GradientColor</a></td><td style='width:75%' class='def'><p><a name="2300958d-4c09-4cac-9150-a26fc178f747"></a>
<b>GradientColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines a color inside of a gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d48b643-89a0-4d97-ac04-03e423e81048'>GradientPosition</a></td><td style='width:75%' ><p><a name="2d48b643-89a0-4d97-ac04-03e423e81048"></a>
<b>GradientPosition</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the position of a gradient in a shape object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01b90201-75cb-468b-afe0-58a8b9dd9980'>BezierControlPoint</a></td><td style='width:75%' class='def'><p><a name="01b90201-75cb-468b-afe0-58a8b9dd9980"></a>
<b>BezierControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the control point for a <code>KimonoShapeBezier</code> end point used to adjust the curve of a bezier quad section.</p>
</td></tr></table></p>


---

<a name="f6b07a58-043d-4087-9d74-1674aef6433a"></a>
##KimonoBlur

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a blur effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f5f53e80-0c14-46bf-acd6-57f21c03da49'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="f5f53e80-0c14-46bf-acd6-57f21c03da49"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee987cf1-134b-47d2-a209-0351158ba0d3'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="ee987cf1-134b-47d2-a209-0351158ba0d3"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7ca73d86-171d-4a16-a7df-50e5057a385c'>Name</a></td><td style='width:75%' ><p><a name="7ca73d86-171d-4a16-a7df-50e5057a385c"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b7732d8-3d0c-41ba-8740-869bc2820a9b'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="0b7732d8-3d0c-41ba-8740-869bc2820a9b"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f5a5f49-a459-498c-ba78-9d287eea3658'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="0f5a5f49-a459-498c-ba78-9d287eea3658"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24eccc5e-f9bd-4a5a-a82c-86a1432c75e8'>BlurFilter</a></td><td style='width:75%' class='def'><p><a name="24eccc5e-f9bd-4a5a-a82c-86a1432c75e8"></a></p>

<h3>BlurFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the blur filter represented by this blur effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#64263f09-141e-4d7c-bd6f-a17ca3f38b7c'>KimonoBlur</a></td><td style='width:75%' ><p><a name="64263f09-141e-4d7c-bd6f-a17ca3f38b7c"></a></p>

<h3>KimonoBlur ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f6b07a58-043d-4087-9d74-1674aef6433a">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad2b7c48-f1b7-49f0-8207-b2d516361187'>KimonoBlur</a></td><td style='width:75%' class='def'><p><a name="ad2b7c48-f1b7-49f0-8207-b2d516361187"></a></p>

<h3>KimonoBlur (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f6b07a58-043d-4087-9d74-1674aef6433a">KimonoBlur</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p><a name="c7c7d69c-3013-4e88-9f85-ea5202150e60"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="10fe612d-0786-4aa9-9a55-0edb70e88167"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b0e3471-dc14-4279-a7e1-b2860186973e'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="2b0e3471-dc14-4279-a7e1-b2860186973e"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#015f93dd-e015-4473-bf40-6ea471b2315b'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="015f93dd-e015-4473-bf40-6ea471b2315b"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d1ef79dd-3b64-4d0b-ab37-23c5fb91716f"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37329f93-47c1-47cd-8dd3-802da39ad762'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="37329f93-47c1-47cd-8dd3-802da39ad762"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the Skia library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e22f3c1f-6bf4-4ff8-a4df-dd9a41caf242'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="e22f3c1f-6bf4-4ff8-a4df-dd9a41caf242"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d5f70e1-5fca-42a1-85ef-3eb1b2ae6056'>ToCode</a></td><td style='width:75%' ><p><a name="6d5f70e1-5fca-42a1-85ef-3eb1b2ae6056"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="8ad9ed49-ab11-4f50-a090-ccfa1220996a"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5f1ee569-d52d-4b18-8a6f-1bab4804b99a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="aa2f26eb-f475-43f8-88e8-c79c025f3327"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32774925-d1cc-4782-a9ce-2070a8afcc0e'>Clone</a></td><td style='width:75%' class='def'><p><a name="32774925-d1cc-4782-a9ce-2070a8afcc0e"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92e16df2-4b04-4bb5-af09-2cf964cf0f0b'>RaiseBlurModified</a></td><td style='width:75%' ><p><a name="92e16df2-4b04-4bb5-af09-2cf964cf0f0b"></a></p>

<h3>RaiseBlurModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the blur modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bc8982d7-a853-4415-9106-fb06836edf6d'>BlurModified</a></td><td style='width:75%' ><p><a name="bc8982d7-a853-4415-9106-fb06836edf6d"></a></p>

<h3>BlurModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the blur is modified.</p>
</td></tr></table></p>


---

<a name="4db2b92f-1223-4630-a172-98e79c99b08d"></a>
##KimonoShadow

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a shadow effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b7d8d9ab-4ce8-402f-8876-295f41702e90'>_horizontalOffset</a></td><td style='width:75%' ><p><a name="b7d8d9ab-4ce8-402f-8876-295f41702e90"></a>
<b>_horizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d64d52d4-2df5-4351-a3d4-b96de96c0c4c'>_verticalOffset</a></td><td style='width:75%' class='def'><p><a name="d64d52d4-2df5-4351-a3d4-b96de96c0c4c"></a>
<b>_verticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d3a2c4d-af4e-4371-a44d-833b0f2323d2'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="0d3a2c4d-af4e-4371-a44d-833b0f2323d2"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c44f6f64-74e3-4307-8c1e-49192d832609'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="c44f6f64-74e3-4307-8c1e-49192d832609"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9d63688-705b-410b-8ea1-df71dd80d27a'>_color</a></td><td style='width:75%' ><p><a name="e9d63688-705b-410b-8ea1-df71dd80d27a"></a>
<b>_color</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a6dcc5c-a6a2-4b85-a93e-94fb27455491'>_linkedColor</a></td><td style='width:75%' class='def'><p><a name="2a6dcc5c-a6a2-4b85-a93e-94fb27455491"></a>
<b>_linkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A linked <code>KimonoColor</code> to use as the shadow color.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#108c07a6-6cda-4727-8df4-b4585ba2026b'>Name</a></td><td style='width:75%' ><p><a name="108c07a6-6cda-4727-8df4-b4585ba2026b"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ba00757-e34e-44b2-887f-460ce15987e6'>HorizontalOffset</a></td><td style='width:75%' class='def'><p><a name="7ba00757-e34e-44b2-887f-460ce15987e6"></a></p>

<h3>HorizontalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal offset.</p>

<h4>Return Value</h4>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48a5866c-3a71-4e5f-a13c-e315da55e7fa'>VerticalOffset</a></td><td style='width:75%' ><p><a name="48a5866c-3a71-4e5f-a13c-e315da55e7fa"></a></p>

<h3>VerticalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical offset.</p>

<h4>Return Value</h4>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b0f997d-5482-4be4-bcd0-5ea8ec3f6521'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="1b0f997d-5482-4be4-bcd0-5ea8ec3f6521"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a6c8a04-05b9-4712-8e9c-dc6ba81bcae3'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="0a6c8a04-05b9-4712-8e9c-dc6ba81bcae3"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f54d6ca-c71a-4f43-bd5e-335025de0ad0'>Color</a></td><td style='width:75%' class='def'><p><a name="2f54d6ca-c71a-4f43-bd5e-335025de0ad0"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8f05da5-eecd-4699-a8fc-36bad30b07d3'>LinkedColor</a></td><td style='width:75%' ><p><a name="a8f05da5-eecd-4699-a8fc-36bad30b07d3"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the linked.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04ce24fa-f7ff-4322-b3b8-b8d8604524ca'>ShadowColor</a></td><td style='width:75%' class='def'><p><a name="04ce24fa-f7ff-4322-b3b8-b8d8604524ca"></a></p>

<h3>ShadowColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color of the shadow as a <code>SKColor</code>.</p>

<h4>Remarks</h4>

<p>Returns either the custom color attached to this shadow or a linked color if it is being used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c7e779b-1bda-404d-98a4-a852f5ad68c7'>ShadowFilter</a></td><td style='width:75%' ><p><a name="9c7e779b-1bda-404d-98a4-a852f5ad68c7"></a></p>

<h3>ShadowFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the shadoe filter represented by this shadow effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#802c604f-e54e-4a74-a967-b228c561dc24'>KimonoShadow</a></td><td style='width:75%' ><p><a name="802c604f-e54e-4a74-a967-b228c561dc24"></a></p>

<h3>KimonoShadow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4db2b92f-1223-4630-a172-98e79c99b08d">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8c68cb7-fb37-413c-ad45-d91ec2e63581'>KimonoShadow</a></td><td style='width:75%' class='def'><p><a name="c8c68cb7-fb37-413c-ad45-d91ec2e63581"></a></p>

<h3>KimonoShadow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4db2b92f-1223-4630-a172-98e79c99b08d">KimonoShadow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalOffset</td><td style='width:75%' ><p><a name="04e812e3-0504-453c-b7d1-d58c1fada35b"></a>
Horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' class='def'><p><a name="4d47765e-974a-4df8-8876-4ffb08936f75"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalOffset</td><td style='width:75%' ><p><a name="b30e124e-2b83-4077-b8ab-dbf885f9229b"></a>
Vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="aa5dfe94-21c5-4ef9-acd0-bf8602af1816"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b76effae-1b83-4282-b80d-5004524cc4e4'>HandleLinkedColorChanged</a></td><td style='width:75%' ><p><a name="b76effae-1b83-4282-b80d-5004524cc4e4"></a></p>

<h3>HandleLinkedColorChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the linked color changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42b1c96a-a5a8-4ce6-aa47-58893c778d40'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="42b1c96a-a5a8-4ce6-aa47-58893c778d40"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4f26f7d-aa75-4a19-b8f6-5d521e2fa06c'>ToCSharp</a></td><td style='width:75%' ><p><a name="a4f26f7d-aa75-4a19-b8f6-5d521e2fa06c"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f965abb0-b65a-47a1-9231-f9b58802d47d"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3e2c2bf-dbfa-4ad0-9283-233d11720f42'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="f3e2c2bf-dbfa-4ad0-9283-233d11720f42"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83adcaf7-3fe3-4bc8-b1e4-b9bd9b894fe9'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="83adcaf7-3fe3-4bc8-b1e4-b9bd9b894fe9"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58e113f1-4913-414b-84e6-0a5a30721788'>ToCode</a></td><td style='width:75%' class='def'><p><a name="58e113f1-4913-414b-84e6-0a5a30721788"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="fd0839d1-ab5f-49d9-9920-d9620768e12d"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="cba6a29a-eb37-4137-aecb-2e4ef9af5344"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="77f96344-8fa6-4cc4-a5ef-026a74d741b3"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae27fbfe-6e85-40d0-8bc3-5858f33f4041'>Clone</a></td><td style='width:75%' ><p><a name="ae27fbfe-6e85-40d0-8bc3-5858f33f4041"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4164bb3b-58be-4900-94b6-03557be77e87'>RaiseShadowModified</a></td><td style='width:75%' class='def'><p><a name="4164bb3b-58be-4900-94b6-03557be77e87"></a></p>

<h3>RaiseShadowModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the shadow modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#608b7e44-8bc4-46e1-a544-5e8f87a02e7a'>ShadowModified</a></td><td style='width:75%' ><p><a name="608b7e44-8bc4-46e1-a544-5e8f87a02e7a"></a></p>

<h3>ShadowModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the shadow is modified.</p>
</td></tr></table></p>


---

<a name="cfd88ccd-b3f1-4bb7-b410-48c8070cf065"></a>
##KimonoGradient

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a gradient as a collection of either `SKColor` or linked `KimonoColors` that can be applied to a `KimonoStyle` and used when drawing a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8d6ffaba-efca-474b-b481-0756eec87fa6'>_gradientType</a></td><td style='width:75%' ><p><a name="8d6ffaba-efca-474b-b481-0756eec87fa6"></a>
<b>_gradientType</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#531ca9a0-38e7-454a-b6ba-e6d8759787e5'>_startPoint</a></td><td style='width:75%' class='def'><p><a name="531ca9a0-38e7-454a-b6ba-e6d8759787e5"></a>
<b>_startPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#504eea4e-8681-453e-a04e-5beb2ca91424'>_endPoint</a></td><td style='width:75%' ><p><a name="504eea4e-8681-453e-a04e-5beb2ca91424"></a>
<b>_endPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9e9280b-f38b-466e-8689-b1d102ad38f8'>_radius</a></td><td style='width:75%' class='def'><p><a name="d9e9280b-f38b-466e-8689-b1d102ad38f8"></a>
<b>_radius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radius for radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45681d31-be86-4783-9a22-770f99f6367d'>_tileMode</a></td><td style='width:75%' ><p><a name="45681d31-be86-4783-9a22-770f99f6367d"></a>
<b>_tileMode</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The gradient tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04d2b0bc-3227-4436-b472-fbb11bd9bd11'>_selectedHandle</a></td><td style='width:75%' class='def'><p><a name="04d2b0bc-3227-4436-b472-fbb11bd9bd11"></a>
<b>_selectedHandle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#999c5332-a1ba-4c59-9248-b8d880b4ac02'>PerformingDrag</a></td><td style='width:75%' ><p><a name="999c5332-a1ba-4c59-9248-b8d880b4ac02"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Is the user performing a drag operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#75109496-4ac9-4a53-b0c5-90124949e9bd'>GradientType</a></td><td style='width:75%' ><p><a name="75109496-4ac9-4a53-b0c5-90124949e9bd"></a></p>

<h3>GradientType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the gradient.</p>

<h4>Return Value</h4>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9436a50-7185-40ab-bbf9-10fd7de2261f'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="f9436a50-7185-40ab-bbf9-10fd7de2261f"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b297d4f6-72ee-44ea-8703-d000fba68f13'>ElementName</a></td><td style='width:75%' ><p><a name="b297d4f6-72ee-44ea-8703-d000fba68f13"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d4db0be-3fe2-46d2-ae30-5a0d5f96f571'>Name</a></td><td style='width:75%' class='def'><p><a name="7d4db0be-3fe2-46d2-ae30-5a0d5f96f571"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c23c599c-af2d-4f96-b700-b0efc7947188'>BarWidth</a></td><td style='width:75%' ><p><a name="c23c599c-af2d-4f96-b700-b0efc7947188"></a></p>

<h3>BarWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the bar.</p>

<h4>Return Value</h4>

<p>The width of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90b27fb7-17cf-442f-a535-3653dd3d0d42'>BarHeight</a></td><td style='width:75%' class='def'><p><a name="90b27fb7-17cf-442f-a535-3653dd3d0d42"></a></p>

<h3>BarHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the bar.</p>

<h4>Return Value</h4>

<p>The height of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ea904b0-6f7e-4726-a64e-8ca34f02fe8a'>PreviewWidth</a></td><td style='width:75%' ><p><a name="0ea904b0-6f7e-4726-a64e-8ca34f02fe8a"></a></p>

<h3>PreviewWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the preview.</p>

<h4>Return Value</h4>

<p>The width of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99197323-a0a9-4021-9a02-31e62f2b9f10'>PreviewHeight</a></td><td style='width:75%' class='def'><p><a name="99197323-a0a9-4021-9a02-31e62f2b9f10"></a></p>

<h3>PreviewHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the preview.</p>

<h4>Return Value</h4>

<p>The height of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cba0ae6-fbbb-4a76-8cb5-cc7cb8f00977'>StartPoint</a></td><td style='width:75%' ><p><a name="7cba0ae6-fbbb-4a76-8cb5-cc7cb8f00977"></a></p>

<h3>StartPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the start point.</p>

<h4>Return Value</h4>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#acfe03da-66ed-4225-95f7-3d91432454d2'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="acfe03da-66ed-4225-95f7-3d91432454d2"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a94e18d3-73ae-4758-b187-a4555cba3e32'>Radius</a></td><td style='width:75%' ><p><a name="a94e18d3-73ae-4758-b187-a4555cba3e32"></a></p>

<h3>Radius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the radius used by radial and conical gradients.</p>

<h4>Return Value</h4>

<p>The radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ef1664f-a5f1-49d6-8072-63c7aacc31c3'>TileMode</a></td><td style='width:75%' class='def'><p><a name="0ef1664f-a5f1-49d6-8072-63c7aacc31c3"></a></p>

<h3>TileMode</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tile mode.</p>

<h4>Return Value</h4>

<p>The tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05fc230e-1193-4a25-8739-43308d67982e'>ControlPoints</a></td><td style='width:75%' ><p><a name="05fc230e-1193-4a25-8739-43308d67982e"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the color.</p>

<h4>Return Value</h4>

<p>The control points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70df2fe3-5245-4e56-af6a-a630cd103b7a'>SelectedHandle</a></td><td style='width:75%' class='def'><p><a name="70df2fe3-5245-4e56-af6a-a630cd103b7a"></a></p>

<h3>SelectedHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected handle.</p>

<h4>Return Value</h4>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3570ab57-c1ff-487b-90fd-c4499bafd9a3'>SelectedColor</a></td><td style='width:75%' ><p><a name="3570ab57-c1ff-487b-90fd-c4499bafd9a3"></a></p>

<h3>SelectedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the selected handle.</p>

<h4>Return Value</h4>

<p>The color of the selected handle or black if no handle is selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bcb1a36-48a8-4170-ab9e-168385067218'>Shader</a></td><td style='width:75%' class='def'><p><a name="7bcb1a36-48a8-4170-ab9e-168385067218"></a></p>

<h3>Shader</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the Skia Shader that represents this gradient.</p>

<h4>Return Value</h4>

<p>The <code>SKShader</code> for this gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e989b375-dbde-4386-a9a6-914291842add'>KimonoGradient</a></td><td style='width:75%' ><p><a name="e989b375-dbde-4386-a9a6-914291842add"></a></p>

<h3>KimonoGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cfd88ccd-b3f1-4bb7-b410-48c8070cf065">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5eb0e64e-cb0a-431e-994b-ed751c6a5a70'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="5eb0e64e-cb0a-431e-994b-ed751c6a5a70"></a></p>

<h3>KimonoGradient (KimonoCore.KimonoGradientType, KimonoCore.KimonoHandle, KimonoCore.KimonoHandle, System.Single, SkiaSharp.SKShaderTileMode, SkiaSharp.SKColor[], System.Single[])</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cfd88ccd-b3f1-4bb7-b410-48c8070cf065">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradientType</td><td style='width:75%' ><p><a name="39b73f04-3eef-4adf-9131-d782687c8a5e"></a>
Gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="956f12dc-4d24-405f-b4ae-5fcee489d78f"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="4483d594-f09a-485c-8a85-a33a67d79602"></a>
End point.</p>
</td></tr><tr><td style='width:25%' class='term'>radius</td><td style='width:75%' class='def'><p><a name="23867420-b64e-4b04-9ae0-9e7b37dcf03e"></a>
Radius.</p>
</td></tr><tr><td style='width:25%' class='term'>tileMode</td><td style='width:75%' ><p><a name="0e1d0d88-7e10-467c-9778-052fae1ba6fd"></a>
Tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'>colors</td><td style='width:75%' class='def'><p><a name="d03248c3-a04f-4890-a50d-b8fd8c84c2fb"></a>
Colors.</p>
</td></tr><tr><td style='width:25%' class='term'>weights</td><td style='width:75%' ><p><a name="a37c1c1e-5ae7-4efe-978a-6e1ca4f85252"></a>
Weights.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d568ecd4-5bb5-4f39-9536-d7b0fb9bc8f0'>KimonoGradient</a></td><td style='width:75%' ><p><a name="d568ecd4-5bb5-4f39-9536-d7b0fb9bc8f0"></a></p>

<h3>KimonoGradient (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cfd88ccd-b3f1-4bb7-b410-48c8070cf065">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="4e233635-205d-4a82-8b7c-500e4d7f6b87"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="7dec0400-51e3-469e-9743-ef8288448cbb"></a>
Bar height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69c30e57-631b-471d-af37-ff3d003f3d60'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="69c30e57-631b-471d-af37-ff3d003f3d60"></a></p>

<h3>KimonoGradient (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cfd88ccd-b3f1-4bb7-b410-48c8070cf065">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="308d99e5-f4b8-4521-8428-83a215d40eba"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="3db2a040-9197-4190-b833-631e72fcad16"></a>
Bar height.</p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p><a name="59ff752d-d4a6-4e39-922b-b5a0b7e2bef5"></a>
Preview width.</p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p><a name="e81e0675-0093-45d5-8e10-5db56caa20b0"></a>
Preview height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c846284-a404-484c-a5a0-1c01273f66a0'>Initialize</a></td><td style='width:75%' ><p><a name="5c846284-a404-484c-a5a0-1c01273f66a0"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54fa5230-7e0a-42e7-b248-25bfa9f04233'>SortedColors</a></td><td style='width:75%' class='def'><p><a name="54fa5230-7e0a-42e7-b248-25bfa9f04233"></a></p>

<h3>SortedColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list of sorted colors by their "X" location inside the gradient.</p>

<h4>Returns</h4>

<p>The sorted colors arrays.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ba1bf30-b246-4c88-a5ad-60a954a01600'>SortedWeights</a></td><td style='width:75%' ><p><a name="0ba1bf30-b246-4c88-a5ad-60a954a01600"></a></p>

<h3>SortedWeights ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list a color weights by their "X" location in the gradient.</p>

<h4>Returns</h4>

<p>The sorted weights.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69b91a2d-d684-49cc-a72d-45a40f954265'>ConformingShader</a></td><td style='width:75%' class='def'><p><a name="69b91a2d-d684-49cc-a72d-45a40f954265"></a></p>

<h3>ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Generates a shader that conforms to a given start and end point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="95145b2f-108e-4380-96c2-8f7133eae0b5"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="8f71314f-9c76-4f39-baf9-6c59095cc33d"></a>
End point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>SKShader</code> for the gradient bound to a given shape's dimentions.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4dd773dc-d4a5-42a1-b9b1-dde15beb7f8a'>AddControlPoint</a></td><td style='width:75%' ><p><a name="4dd773dc-d4a5-42a1-b9b1-dde15beb7f8a"></a></p>

<h3>AddControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new control point to the gradients collection and makes it the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06a0b1da-b626-47b7-a0fa-2ed2dff1cd97'>DeleteSelectedControlPoint</a></td><td style='width:75%' class='def'><p><a name="06a0b1da-b626-47b7-a0fa-2ed2dff1cd97"></a></p>

<h3>DeleteSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09199e43-fba2-4b9e-836e-68ae1169f62a'>DuplicateSelectedControlPoint</a></td><td style='width:75%' ><p><a name="09199e43-fba2-4b9e-836e-68ae1169f62a"></a></p>

<h3>DuplicateSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a33e3777-b380-4cec-b365-2329c58f20b9'>FindHandle</a></td><td style='width:75%' class='def'><p><a name="a33e3777-b380-4cec-b365-2329c58f20b9"></a></p>

<h3>FindHandle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the handle matching the given unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="a83530e2-61f3-4f7f-93ec-38f59db6fd42"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The matching <code>KimonoHandle</code> or <code>null</code> if not found.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abfeb6c9-6c6e-415f-8552-1c6a85b46ad4'>DrawBar</a></td><td style='width:75%' ><p><a name="abfeb6c9-6c6e-415f-8552-1c6a85b46ad4"></a></p>

<h3>DrawBar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bar.</p>

<h4>Returns</h4>

<p>The bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd412757-e00a-4a96-98ea-95dbe4656888'>DrawPreview</a></td><td style='width:75%' class='def'><p><a name="cd412757-e00a-4a96-98ea-95dbe4656888"></a></p>

<h3>DrawPreview ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the preview.</p>

<h4>Returns</h4>

<p>The preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d749833-45a9-49b9-86f0-e46da57b88c7'>BarToolDown</a></td><td style='width:75%' ><p><a name="5d749833-45a9-49b9-86f0-e46da57b88c7"></a></p>

<h3>BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e97b621f-137c-4a2f-90c1-cbf27af8b6bc"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="de277741-0e2f-40a7-8816-406de31299ed"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="9b3dbba3-1c9a-44e1-abfa-58a51c29cf4b"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f912b916-a4ef-499b-aca2-fafe68207670'>BarToolDrag</a></td><td style='width:75%' class='def'><p><a name="f912b916-a4ef-499b-aca2-fafe68207670"></a></p>

<h3>BarToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient design bar. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ef44b6b4-33aa-4170-9ee0-52f90cee3c5f"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1764359-15a9-40e1-9b3f-beb9c537c7c3'>BarToolUp</a></td><td style='width:75%' ><p><a name="c1764359-15a9-40e1-9b3f-beb9c537c7c3"></a></p>

<h3>BarToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="616a1c0e-d092-4f94-bc0c-3a4958bdfa5b"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64897622-2c39-4a36-a6b6-06fa2383a641'>PreviewToolDown</a></td><td style='width:75%' class='def'><p><a name="64897622-2c39-4a36-a6b6-06fa2383a641"></a></p>

<h3>PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ae28249e-de14-4fab-af43-43ab91809b9c"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="f20b3150-2a26-4ebc-827a-832d0b8f3cd8"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="3062e3d8-7faa-450a-b4af-029cdb4fad57"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d0e94e9-7533-489c-b20b-fbafe4de03ee'>PreviewToolDrag</a></td><td style='width:75%' ><p><a name="3d0e94e9-7533-489c-b20b-fbafe4de03ee"></a></p>

<h3>PreviewToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient preview. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="fb0ed83b-1ae1-4909-a4b7-8df4346fca17"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34205c3c-b061-4779-ace3-fa175ae0cebb'>PreviewToolUp</a></td><td style='width:75%' class='def'><p><a name="34205c3c-b061-4779-ace3-fa175ae0cebb"></a></p>

<h3>PreviewToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="b90fd133-6875-4cec-8097-825d9eb2ccd4"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f535d47-0baf-412f-87aa-2ef875481f26'>ToObiScript</a></td><td style='width:75%' ><p><a name="1f535d47-0baf-412f-87aa-2ef875481f26"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97bc67ce-1979-43e7-81fe-fdfa372050d7'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="97bc67ce-1979-43e7-81fe-fdfa372050d7"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d093142-a03f-4509-a4c6-d50f0efd219d'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="4d093142-a03f-4509-a4c6-d50f0efd219d"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d68d6fc8-d1cb-478b-a24e-1136cce906fc'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="d68d6fc8-d1cb-478b-a24e-1136cce906fc"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e38a1613-53ac-442a-a7f2-009c6dc7fff0'>ColorsToCode</a></td><td style='width:75%' ><p><a name="e38a1613-53ac-442a-a7f2-009c6dc7fff0"></a></p>

<h3>ColorsToCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9d1df5e-d14f-4cc8-9143-55bb3e26e97b'>ColorsToInitializer</a></td><td style='width:75%' class='def'><p><a name="b9d1df5e-d14f-4cc8-9143-55bb3e26e97b"></a></p>

<h3>ColorsToInitializer (KimonoCore.CodeOutputLibrary, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29d3f27c-66e6-466f-895a-22ef5fdcba96'>WeightsToSkiaCode</a></td><td style='width:75%' ><p><a name="29d3f27c-66e6-466f-895a-22ef5fdcba96"></a></p>

<h3>WeightsToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e331956-1642-4b2a-8cfd-0f0affde00b1'>WeightsToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="1e331956-1642-4b2a-8cfd-0f0affde00b1"></a></p>

<h3>WeightsToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cdf0c8d-0c38-48f4-a273-d6583e626833'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="6cdf0c8d-0c38-48f4-a273-d6583e626833"></a></p>

<h3>ToCSharpSkia ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#561dc76e-405e-4a7d-966d-367afa6fa4d3'>ToCSharpSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="561dc76e-405e-4a7d-966d-367afa6fa4d3"></a></p>

<h3>ToCSharpSkiaInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ca75451-6809-4796-a824-86924f65e552'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="6ca75451-6809-4796-a824-86924f65e552"></a></p>

<h3>ToCSharpSkia (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="265318d5-beac-422e-b89e-8f0a504b7ee6"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="e846c2cc-96a2-4324-b86e-610428bd97c9"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#861b8db2-b91c-427d-8d51-2fdbe2ecfbc4'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="861b8db2-b91c-427d-8d51-2fdbe2ecfbc4"></a></p>

<h3>ToCSharpKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b8218a8-e258-4ebf-a5d6-12b945e22c84'>ToCSharpKimonoCoreInitializer</a></td><td style='width:75%' ><p><a name="8b8218a8-e258-4ebf-a5d6-12b945e22c84"></a></p>

<h3>ToCSharpKimonoCoreInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb27c67e-cf81-4c8e-9c5f-a4e33af305fa'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="cb27c67e-cf81-4c8e-9c5f-a4e33af305fa"></a></p>

<h3>ToCSharpKimonoCore (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="c267c440-cffa-4f6d-beaa-a22dede9fc58"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="ec8e0071-fb15-400d-9fe8-b03d169f1282"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb861a2a-beef-49e5-9aab-a452ba0d9bf5'>ToCSharp</a></td><td style='width:75%' ><p><a name="eb861a2a-beef-49e5-9aab-a452ba0d9bf5"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="166dd4bc-cda8-496c-a710-8c02b171feeb"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16ab6973-bdd5-472a-a557-0411da09fba0'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="16ab6973-bdd5-472a-a557-0411da09fba0"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6361377f-909a-4733-a986-0616e05efd6e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26a52042-9cbb-4bfd-b94d-c090bbba8301'>ToCSharp</a></td><td style='width:75%' ><p><a name="26a52042-9cbb-4bfd-b94d-c090bbba8301"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="81828fd8-be91-411d-a454-a92be7a8588b"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="9436b19d-fe91-433a-8265-5db069b7f826"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="68130831-0a2e-46cf-bd07-d2b4e23bad7f"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cbb838c-46da-4f54-87e6-658757a50b76'>ToCode</a></td><td style='width:75%' class='def'><p><a name="3cbb838c-46da-4f54-87e6-658757a50b76"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="e75e5206-190d-4d48-b4a0-49737edca191"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="f142c036-41e4-4113-bfb2-c8bd570a3525"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="29370fe7-3415-4b24-a0e6-e1e0aa2dd8af"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a00bfd2e-96dd-48c8-ac2d-99791b102510'>Clone</a></td><td style='width:75%' ><p><a name="a00bfd2e-96dd-48c8-ac2d-99791b102510"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#852fcd63-89e5-4be1-a29e-097816411d4f'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p><a name="852fcd63-89e5-4be1-a29e-097816411d4f"></a></p>

<h3>RaiseGradientModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fa42a5d-6382-45d0-9a3c-4843af860c94'>RaiseHandleSelected</a></td><td style='width:75%' ><p><a name="8fa42a5d-6382-45d0-9a3c-4843af860c94"></a></p>

<h3>RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="3d04edc9-111f-441a-8c9f-ff7b9d4c73f5"></a>
Handle.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9cdc6baf-1e19-43d7-8dd8-91cc1a1a6b18'>GradientModified</a></td><td style='width:75%' ><p><a name="9cdc6baf-1e19-43d7-8dd8-91cc1a1a6b18"></a></p>

<h3>GradientModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e14d2f1-2ccf-49f1-822c-08e701deaecb'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="6e14d2f1-2ccf-49f1-822c-08e701deaecb"></a></p>

<h3>HandleSelected</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="adbb20c5-5898-44d7-b942-4b0e1c1ed617"></a>
##KimonoGradientType

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Kimono gradient type.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#de859563-2053-4480-8cdc-96ea63ef151b'>LinearGradient</a></td><td style='width:75%' ><p><a name="de859563-2053-4480-8cdc-96ea63ef151b"></a>
<b>LinearGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The linear gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e8e53f7-48ad-4e8d-8437-078ffbef3029'>RadialGradient</a></td><td style='width:75%' class='def'><p><a name="5e8e53f7-48ad-4e8d-8437-078ffbef3029"></a>
<b>RadialGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radial gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4d7bafa-4cd9-4143-b456-9304fbbc5985'>SweepGradient</a></td><td style='width:75%' ><p><a name="d4d7bafa-4cd9-4143-b456-9304fbbc5985"></a>
<b>SweepGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The sweep gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#678b58b7-3dd6-4af3-a1fc-087f9dddbd38'>ConicalGradient</a></td><td style='width:75%' class='def'><p><a name="678b58b7-3dd6-4af3-a1fc-087f9dddbd38"></a>
<b>ConicalGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The conical gradient.</p>
</td></tr></table></p>


---

<a name="8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b"></a>
##KimonoStyle

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines as style that can be applied to a `KimonoShape` to control its appearance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#954dba43-5241-4e13-8ad2-e52e2358a22d'>_frameColor</a></td><td style='width:75%' ><p><a name="954dba43-5241-4e13-8ad2-e52e2358a22d"></a>
<b>_frameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's frame color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3741b62-f8fd-4b43-bb1d-7c0d17f1ad21'>_fillColor</a></td><td style='width:75%' class='def'><p><a name="e3741b62-f8fd-4b43-bb1d-7c0d17f1ad21"></a>
<b>_fillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's fill color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5245568a-c85e-4183-ae93-f57600f93de9'>_frameGradient</a></td><td style='width:75%' ><p><a name="5245568a-c85e-4183-ae93-f57600f93de9"></a>
<b>_frameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95e0cd00-92ee-4ed4-a05a-f2e83b395fd9'>_fillGradient</a></td><td style='width:75%' class='def'><p><a name="95e0cd00-92ee-4ed4-a05a-f2e83b395fd9"></a>
<b>_fillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0e1eba3-63a2-46bf-8e93-8698e9cb200d'>_hasFrameJitter</a></td><td style='width:75%' ><p><a name="e0e1eba3-63a2-46bf-8e93-8698e9cb200d"></a>
<b>_hasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9ab76f4-18ca-4b73-8c1b-3378415ec72d'>_frameJitterLength</a></td><td style='width:75%' class='def'><p><a name="d9ab76f4-18ca-4b73-8c1b-3378415ec72d"></a>
<b>_frameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68bf0633-75de-4f4a-bad3-100b42a350d8'>_frameJitterDeviation</a></td><td style='width:75%' ><p><a name="68bf0633-75de-4f4a-bad3-100b42a350d8"></a>
<b>_frameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e523998-bb08-4fe1-8af2-d005d7a2e257'>_hasFillJitter</a></td><td style='width:75%' class='def'><p><a name="8e523998-bb08-4fe1-8af2-d005d7a2e257"></a>
<b>_hasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the fill uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bf3b2d0-bfba-4bb8-8706-32a39a1ba2ec'>_fillJitterLength</a></td><td style='width:75%' ><p><a name="0bf3b2d0-bfba-4bb8-8706-32a39a1ba2ec"></a>
<b>_fillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70e1d35e-f2d7-4ed3-850a-cceda06a41fc'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="70e1d35e-f2d7-4ed3-850a-cceda06a41fc"></a>
<b>_fillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d9f3e59-d096-4a0f-8b96-cfbcdbe24d44'>_hasFrameDash</a></td><td style='width:75%' ><p><a name="7d9f3e59-d096-4a0f-8b96-cfbcdbe24d44"></a>
<b>_hasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame has a dash effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c6002cc-0bac-4178-82d3-de70a2181ef4'>_hasFillBlur</a></td><td style='width:75%' class='def'><p><a name="9c6002cc-0bac-4178-82d3-de70a2181ef4"></a>
<b>_hasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a0d0dde-3570-4cd5-b94c-bdd116456a6a'>_fillBlur</a></td><td style='width:75%' ><p><a name="5a0d0dde-3570-4cd5-b94c-bdd116456a6a"></a>
<b>_fillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77b9ed6b-82cf-41d4-b7cc-3deb5886a925'>_hasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="77b9ed6b-82cf-41d4-b7cc-3deb5886a925"></a>
<b>_hasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7af76e27-b162-498f-bad4-9816946557f1'>_frameBlur</a></td><td style='width:75%' ><p><a name="7af76e27-b162-498f-bad4-9816946557f1"></a>
<b>_frameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abda8d2a-586c-4676-a073-a1b7940ae93f'>_hasFillShadow</a></td><td style='width:75%' class='def'><p><a name="abda8d2a-586c-4676-a073-a1b7940ae93f"></a>
<b>_hasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f7fba6c-4982-407b-bc21-e9d8df846f64'>_fillShadow</a></td><td style='width:75%' ><p><a name="9f7fba6c-4982-407b-bc21-e9d8df846f64"></a>
<b>_fillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1866553e-2d27-4be9-8eeb-a2f0c8ac3a63'>_hasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="1866553e-2d27-4be9-8eeb-a2f0c8ac3a63"></a>
<b>_hasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#107197be-e2c4-4d52-90b1-9bee0ca7c26f'>_frameShadow</a></td><td style='width:75%' ><p><a name="107197be-e2c4-4d52-90b1-9bee0ca7c26f"></a>
<b>_frameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#de73d4f5-f84a-41ee-a70c-c8138047862c'>UniqueID</a></td><td style='width:75%' ><p><a name="de73d4f5-f84a-41ee-a70c-c8138047862c"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09deb9af-a090-4470-a27b-75155fdcc37e'>ElementName</a></td><td style='width:75%' class='def'><p><a name="09deb9af-a090-4470-a27b-75155fdcc37e"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbe14659-05af-47dd-86be-561f825c5ff7'>Name</a></td><td style='width:75%' ><p><a name="fbe14659-05af-47dd-86be-561f825c5ff7"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0503935-a17f-4797-b0ca-9b75b7108897'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="f0503935-a17f-4797-b0ca-9b75b7108897"></a></p>

<h3>HasFrame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> has a frame.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a446cec1-9f6b-4620-b27f-81cf87d0eed2'>Frame</a></td><td style='width:75%' ><p><a name="a446cec1-9f6b-4620-b27f-81cf87d0eed2"></a></p>

<h3>Frame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#331c4fee-8e1c-495f-b588-e80a74294c2f'>HasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="331c4fee-8e1c-495f-b588-e80a74294c2f"></a></p>

<h3>HasFrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> has frame blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8c77e6c-3fd9-4edc-bf0a-923c56ef2bf9'>FrameBlur</a></td><td style='width:75%' ><p><a name="f8c77e6c-3fd9-4edc-bf0a-923c56ef2bf9"></a></p>

<h3>FrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29c03269-fd52-4041-9901-5628718a2066'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="29c03269-fd52-4041-9901-5628718a2066"></a></p>

<h3>HasFrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> has frame shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c88448fe-7d00-4a98-ac54-55e8abc6a08e'>FrameShadow</a></td><td style='width:75%' ><p><a name="c88448fe-7d00-4a98-ac54-55e8abc6a08e"></a></p>

<h3>FrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame shadow.</p>

<h4>Return Value</h4>

<p>The frame shadow as a <code>KimonoShadow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f068ba9b-22db-4147-bc27-36357c4624a7'>HasFillBlur</a></td><td style='width:75%' class='def'><p><a name="f068ba9b-22db-4147-bc27-36357c4624a7"></a></p>

<h3>HasFillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> has fill blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8591f6d8-1bb7-4f28-82b3-833f93df3daf'>FillBlur</a></td><td style='width:75%' ><p><a name="8591f6d8-1bb7-4f28-82b3-833f93df3daf"></a></p>

<h3>FillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de62a69e-cb58-4d6a-8a26-d89213fdc535'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="de62a69e-cb58-4d6a-8a26-d89213fdc535"></a></p>

<h3>HasFillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> has fill shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d48b7f0-9780-4577-8a0e-0b3539e0ed64'>FillShadow</a></td><td style='width:75%' ><p><a name="7d48b7f0-9780-4577-8a0e-0b3539e0ed64"></a></p>

<h3>FillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill shadow.</p>

<h4>Return Value</h4>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed57a0a8-7c29-4fe9-9248-e0a044eb1ac2'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="ed57a0a8-7c29-4fe9-9248-e0a044eb1ac2"></a></p>

<h3>FrameColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the frame as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d68426d-1c67-41e3-a681-911b17f35d76'>FrameGradient</a></td><td style='width:75%' ><p><a name="7d68426d-1c67-41e3-a681-911b17f35d76"></a></p>

<h3>FrameGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame gradient.</p>

<h4>Return Value</h4>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#988ff931-b491-487c-ab33-ed18f1ec3c45'>HasFill</a></td><td style='width:75%' class='def'><p><a name="988ff931-b491-487c-ab33-ed18f1ec3c45"></a></p>

<h3>HasFill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> has fill.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#998340ac-885d-48cd-a48c-0bc00f5df619'>Fill</a></td><td style='width:75%' ><p><a name="998340ac-885d-48cd-a48c-0bc00f5df619"></a></p>

<h3>Fill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a953314-12dc-4717-86f5-75f639571e7a'>FillColor</a></td><td style='width:75%' class='def'><p><a name="6a953314-12dc-4717-86f5-75f639571e7a"></a></p>

<h3>FillColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the fill as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd87b146-4409-4635-9007-113d950b7760'>FillGradient</a></td><td style='width:75%' ><p><a name="bd87b146-4409-4635-9007-113d950b7760"></a></p>

<h3>FillGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill gradient.</p>

<h4>Return Value</h4>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0d83ed3-a9e7-47ed-a6b6-fbb31bf6bb3a'>StyleType</a></td><td style='width:75%' class='def'><p><a name="a0d83ed3-a9e7-47ed-a6b6-fbb31bf6bb3a"></a></p>

<h3>StyleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the style.</p>

<h4>Return Value</h4>

<p>The type of the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f61206d6-1fb3-4927-93a9-c70583b1de0e'>FontMetrics</a></td><td style='width:75%' ><p><a name="f61206d6-1fb3-4927-93a9-c70583b1de0e"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#670bebed-ff7f-4fed-b947-53f7d49a88a7'>IsLinearText</a></td><td style='width:75%' class='def'><p><a name="670bebed-ff7f-4fed-b947-53f7d49a88a7"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e558a59-654d-49a8-ad9d-aab3667556d1'>IsVerticalText</a></td><td style='width:75%' ><p><a name="5e558a59-654d-49a8-ad9d-aab3667556d1"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4eab36e9-8c58-4cd7-8a56-5fc3915da625'>StrikeThruText</a></td><td style='width:75%' class='def'><p><a name="4eab36e9-8c58-4cd7-8a56-5fc3915da625"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f50bc853-beeb-41ce-aecc-fa2295728b3e'>TextAlign</a></td><td style='width:75%' ><p><a name="f50bc853-beeb-41ce-aecc-fa2295728b3e"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4e43881-9d3c-4d23-8d34-7b8a06d36e3c'>TextEncoding</a></td><td style='width:75%' class='def'><p><a name="d4e43881-9d3c-4d23-8d34-7b8a06d36e3c"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16549a83-0309-4c97-a629-a6e2d59b8ccb'>TextScaleX</a></td><td style='width:75%' ><p><a name="16549a83-0309-4c97-a629-a6e2d59b8ccb"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c51c784-a7b1-45f0-a939-24b6efe8b4c1'>TextSize</a></td><td style='width:75%' class='def'><p><a name="8c51c784-a7b1-45f0-a939-24b6efe8b4c1"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca9f77b8-91c8-43e3-9450-f081954fb5d9'>TextSkewX</a></td><td style='width:75%' ><p><a name="ca9f77b8-91c8-43e3-9450-f081954fb5d9"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e60185c-5b73-49f5-aa38-7a697450198b'>Typeface</a></td><td style='width:75%' class='def'><p><a name="0e60185c-5b73-49f5-aa38-7a697450198b"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#daf1644c-d9b3-41ee-aed3-75a7bd33d6b4'>FontFamilyName</a></td><td style='width:75%' ><p><a name="daf1644c-d9b3-41ee-aed3-75a7bd33d6b4"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbd48b96-f211-406a-a5d2-d758ed0d5ec8'>TypefaceStyle</a></td><td style='width:75%' class='def'><p><a name="dbd48b96-f211-406a-a5d2-d758ed0d5ec8"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a5e5017-0b14-4082-aedb-fc2edb7186cf'>UnderlineText</a></td><td style='width:75%' ><p><a name="4a5e5017-0b14-4082-aedb-fc2edb7186cf"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#890ad023-2bb5-4bb9-aca9-d52f0dc97fee'>HasFrameJitter</a></td><td style='width:75%' class='def'><p><a name="890ad023-2bb5-4bb9-aca9-d52f0dc97fee"></a></p>

<h3>HasFrameJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d8047b5-59a6-4c2c-8e80-00b39db74819'>FrameJitterLength</a></td><td style='width:75%' ><p><a name="1d8047b5-59a6-4c2c-8e80-00b39db74819"></a></p>

<h3>FrameJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the frame jitter.</p>

<h4>Return Value</h4>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c445655-925f-4b83-b582-e5595729973b'>FrameJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="9c445655-925f-4b83-b582-e5595729973b"></a></p>

<h3>FrameJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame jitter deviation.</p>

<h4>Return Value</h4>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52f94ef2-234b-4460-8836-be4d7b4727d0'>HasFillJitter</a></td><td style='width:75%' ><p><a name="52f94ef2-234b-4460-8836-be4d7b4727d0"></a></p>

<h3>HasFillJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the fill jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93ec122f-2bb4-40e8-bb18-639484b648ae'>FillJitterLength</a></td><td style='width:75%' class='def'><p><a name="93ec122f-2bb4-40e8-bb18-639484b648ae"></a></p>

<h3>FillJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the fill jitter.</p>

<h4>Return Value</h4>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bce67460-b6f5-442b-9dc6-13e6de944474'>FillJitterDeviation</a></td><td style='width:75%' ><p><a name="bce67460-b6f5-442b-9dc6-13e6de944474"></a></p>

<h3>FillJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill jitter deviation.</p>

<h4>Return Value</h4>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f2c5a5e-c842-4549-a5f7-c0ee4028d2cb'>HasFrameDash</a></td><td style='width:75%' class='def'><p><a name="7f2c5a5e-c842-4549-a5f7-c0ee4028d2cb"></a></p>

<h3>HasFrameDash</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame has a dash.</p>

<h4>Return Value</h4>

<p><code>true</code> if the frame has a dash; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19b221e0-343b-44ec-ad70-752d1ce51354'>DashPattern</a></td><td style='width:75%' ><p><a name="19b221e0-343b-44ec-ad70-752d1ce51354"></a></p>

<h3>DashPattern</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the dash pattern.</p>

<h4>Return Value</h4>

<p>The dash pattern.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e5fb3ca-5fdb-4450-af8b-c1961faade7d'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="9e5fb3ca-5fdb-4450-af8b-c1961faade7d"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoStyle</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#673e43b7-919d-408e-8ebc-af3ee7cc076b'>PropertyConnections</a></td><td style='width:75%' ><p><a name="673e43b7-919d-408e-8ebc-af3ee7cc076b"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d431c977-8c83-419e-b9d6-f72a251a41b4'>ClonePaint</a></td><td style='width:75%' ><p><a name="d431c977-8c83-419e-b9d6-f72a251a41b4"></a></p>

<h3>ClonePaint (SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPaint</code> object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p><a name="0a784b8c-bd3e-4c4e-ab5e-4a6fd7dc8ded"></a>
The <code>SKPaint</code> object to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>SKPaint</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab2bb9e5-3093-418e-b93c-995a9e492aed'>KimonoStyle</a></td><td style='width:75%' class='def'><p><a name="ab2bb9e5-3093-418e-b93c-995a9e492aed"></a></p>

<h3>KimonoStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8da3632c-c9e1-4f2c-9f7a-ff3f5b0da67b">KimonoStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39315141-ca7f-4664-b5df-ddfb66598ef5'>Initialize</a></td><td style='width:75%' ><p><a name="39315141-ca7f-4664-b5df-ddfb66598ef5"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27e685db-9267-4521-a6b6-c735b2161061'>HandleFrameBlurOrShadowChange</a></td><td style='width:75%' class='def'><p><a name="27e685db-9267-4521-a6b6-c735b2161061"></a></p>

<h3>HandleFrameBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22f233f6-1117-4e34-aead-a57bf806b3f3'>HandleFillBlurOrShadowChange</a></td><td style='width:75%' ><p><a name="22f233f6-1117-4e34-aead-a57bf806b3f3"></a></p>

<h3>HandleFillBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#326f3310-8532-48c9-b6e8-234aceade921'>HandleFrameColorChange</a></td><td style='width:75%' class='def'><p><a name="326f3310-8532-48c9-b6e8-234aceade921"></a></p>

<h3>HandleFrameColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd259511-51de-4780-a57a-edfc4eba87d1'>HandleFillColorChange</a></td><td style='width:75%' ><p><a name="bd259511-51de-4780-a57a-edfc4eba87d1"></a></p>

<h3>HandleFillColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65d0e989-ff59-4542-8eb5-250655f2f8ce'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p><a name="65d0e989-ff59-4542-8eb5-250655f2f8ce"></a></p>

<h3>HandleFrameGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c4f15f1-634e-4ec3-88a1-f15841b8fccd'>HandleFillGradientChange</a></td><td style='width:75%' ><p><a name="8c4f15f1-634e-4ec3-88a1-f15841b8fccd"></a></p>

<h3>HandleFillGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c77f90ce-fe87-4b20-8066-7e8e6ba6b5c0'>MakeDashInterval</a></td><td style='width:75%' class='def'><p><a name="c77f90ce-fe87-4b20-8066-7e8e6ba6b5c0"></a></p>

<h3>MakeDashInterval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the dash interval from the dash pattern.</p>

<h4>Returns</h4>

<p>The dash interval.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3bc5bb4-c5d9-4e91-baa1-fb9f03bca739'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="c3bc5bb4-c5d9-4e91-baa1-fb9f03bca739"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="75e0d6dd-3b0b-4d23-b675-4c80a22dfe0f"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="b880604b-92bf-4c1b-b3b0-10d55cb95f1b"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76c1a48b-ce80-4c9e-bc9f-04bf51777cdf'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="76c1a48b-ce80-4c9e-bc9f-04bf51777cdf"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="f971854f-3ce9-43bc-bda5-82c66f2060fc"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a0f05df-dd97-4798-a9cb-730a50b9bd61'>RemoveProperty</a></td><td style='width:75%' ><p><a name="6a0f05df-dd97-4798-a9cb-730a50b9bd61"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="2ea01ab7-5d53-4c96-b12f-549a5751e560"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc26dba-50f9-43d7-9f33-f3bf8ba1d140'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="2fc26dba-50f9-43d7-9f33-f3bf8ba1d140"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoStyle</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b94b03a1-aa48-410b-828c-2b84cd90d38a'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="b94b03a1-aa48-410b-828c-2b84cd90d38a"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="234b3e8c-a143-404e-bb27-f182ff856caa"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff49825d-55f9-4c49-bf43-df31e047c6ca'>ApplyFrameEffects</a></td><td style='width:75%' class='def'><p><a name="ff49825d-55f9-4c49-bf43-df31e047c6ca"></a></p>

<h3>ApplyFrameEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the frame effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#798698c9-adb9-4b21-92e5-bd01bf28f4af'>ApplyFillEffects</a></td><td style='width:75%' ><p><a name="798698c9-adb9-4b21-92e5-bd01bf28f4af"></a></p>

<h3>ApplyFillEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the fill effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d641813e-810f-4f4e-8323-28972011d0b9'>ToObiScript</a></td><td style='width:75%' class='def'><p><a name="d641813e-810f-4f4e-8323-28972011d0b9"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a459c94d-ef2e-4c1d-bba2-95cf81de06e1'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="a459c94d-ef2e-4c1d-bba2-95cf81de06e1"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3647d457-0d75-4f54-929a-024a6682a9f2'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="3647d457-0d75-4f54-929a-024a6682a9f2"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a145a29f-3eb2-4e0e-8bed-eda32705ba3e'>FillToSkiaCode</a></td><td style='width:75%' ><p><a name="a145a29f-3eb2-4e0e-8bed-eda32705ba3e"></a></p>

<h3>FillToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#795fc28d-8aaa-4c86-bb78-2c9750fc2f1b'>FillToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="795fc28d-8aaa-4c86-bb78-2c9750fc2f1b"></a></p>

<h3>FillToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c303ccc-103b-42d9-ba80-091b0dc9ad9b'>FrameToSkiaCode</a></td><td style='width:75%' ><p><a name="0c303ccc-103b-42d9-ba80-091b0dc9ad9b"></a></p>

<h3>FrameToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95278486-26ea-4ea0-9e4f-3d3dba2a2fc9'>FrameToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="95278486-26ea-4ea0-9e4f-3d3dba2a2fc9"></a></p>

<h3>FrameToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0517725f-5347-41bd-a668-902eb026096e'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="0517725f-5347-41bd-a668-902eb026096e"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c572c90a-be96-44de-b758-b61ce8b2a4d0'>ToKimonoCoreInitializer</a></td><td style='width:75%' class='def'><p><a name="c572c90a-be96-44de-b758-b61ce8b2a4d0"></a></p>

<h3>ToKimonoCoreInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#acd2862b-0d88-4f3a-953d-e38a8dd60dc6'>ToCSharp</a></td><td style='width:75%' ><p><a name="acd2862b-0d88-4f3a-953d-e38a8dd60dc6"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="64ba23c1-67a7-4629-a6e1-d09b95b0f8c9"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52db59ac-8e2c-4027-a593-659fa1c0dce6'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="52db59ac-8e2c-4027-a593-659fa1c0dce6"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b33e5286-edcb-4c5e-9e12-1def0e8232a3"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66d97b0b-1148-4c33-b8b2-b5bf48482227'>ToCode</a></td><td style='width:75%' ><p><a name="66d97b0b-1148-4c33-b8b2-b5bf48482227"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="077945fc-7e77-4c5b-92f3-042c1048afac"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="b3120d4e-1a3f-43c1-aa4e-b90ac3c71732"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d2c25a8b-2077-43f4-9cf9-d3e3a71c5d58"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97acadde-19e8-49c8-a21c-ac756dccd24a'>Clone</a></td><td style='width:75%' class='def'><p><a name="97acadde-19e8-49c8-a21c-ac756dccd24a"></a></p>

<h3>Clone (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p><a name="8ca02141-61b3-4a12-b422-ca714b5e83ef"></a>
If set to <code>true</code>, a deep clone of the style is made.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The a clone of the <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="b3d62b63-5d16-4a04-8356-a6401566d330"></a>
##KimonoStyleType

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoStyle` that will be used to draw a given `KimonoShape` in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#74220ce6-1a98-4ccc-87eb-57dd81bafec7'>Default</a></td><td style='width:75%' ><p><a name="74220ce6-1a98-4ccc-87eb-57dd81bafec7"></a>
<b>Default</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default style for new shapes. This style cannot be deleted or renamed by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d46265d0-e2c5-4f11-a3ae-801bbe8c32ce'>Custom</a></td><td style='width:75%' class='def'><p><a name="d46265d0-e2c5-4f11-a3ae-801bbe8c32ce"></a>
<b>Custom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom style that belongs only to an individual shape instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88533fcb-2f64-4da6-ac52-c7d4287538e2'>CustomText</a></td><td style='width:75%' ><p><a name="88533fcb-2f64-4da6-ac52-c7d4287538e2"></a>
<b>CustomText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom text style that belongs only to an individual <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9eaee8fe-6d8f-4b23-848a-ef142fe829ff'>Standard</a></td><td style='width:75%' class='def'><p><a name="9eaee8fe-6d8f-4b23-848a-ef142fe829ff"></a>
<b>Standard</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared style that can be applied to multiple <code>Kimonoshape</code> instances.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f12033be-2aff-45f3-a592-43a1ddaecea1'>Text</a></td><td style='width:75%' ><p><a name="f12033be-2aff-45f3-a592-43a1ddaecea1"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared text style that can be applied to multiple <code>KimonoShapeText</code> instances.</p>
</td></tr></table></p>


---

<a name="7b2fd87b-d669-4dc9-b5a8-d393edd3f6a0"></a>
##KimonoPropertyRect

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `SKRect`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3bba5178-810c-49ae-b0c9-d20c3a877665'>Value</a></td><td style='width:75%' ><p><a name="3bba5178-810c-49ae-b0c9-d20c3a877665"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value as a <code>SKRect</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3a8a0dfe-2eec-46fa-aabf-1b5a97258544'>KimonoPropertyRect</a></td><td style='width:75%' ><p><a name="3a8a0dfe-2eec-46fa-aabf-1b5a97258544"></a></p>

<h3>KimonoPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7b2fd87b-d669-4dc9-b5a8-d393edd3f6a0">KimonoPropertyRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3af2b17-aafe-4bec-abbd-bcd1b4660172'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="b3af2b17-aafe-4bec-abbd-bcd1b4660172"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a559aa14-1754-4b49-b609-bd52f0ec535c'>ToRect</a></td><td style='width:75%' ><p><a name="a559aa14-1754-4b49-b609-bd52f0ec535c"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bce41503-3d45-4c6f-a79e-4f2bb6a61f4a'>Clone</a></td><td style='width:75%' class='def'><p><a name="bce41503-3d45-4c6f-a79e-4f2bb6a61f4a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="3b351915-9a8c-4f6a-a034-c594077b78c6"></a>
##KimonoPropertyNumber

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `float` or `int` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#888f6029-1a05-48b8-a374-74438d180e33'>Value</a></td><td style='width:75%' ><p><a name="888f6029-1a05-48b8-a374-74438d180e33"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>float</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#740bcc88-208f-4b7c-8124-9beb7cccf7b3'>KimonoPropertyNumber</a></td><td style='width:75%' ><p><a name="740bcc88-208f-4b7c-8124-9beb7cccf7b3"></a></p>

<h3>KimonoPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#3b351915-9a8c-4f6a-a034-c594077b78c6">KimonoPropertyNumber</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9425ff84-cb31-47ce-8aef-4ad2a56b187c'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="9425ff84-cb31-47ce-8aef-4ad2a56b187c"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48cefc5c-ebed-4c09-8c90-702e4ff01516'>ToFloat</a></td><td style='width:75%' ><p><a name="48cefc5c-ebed-4c09-8c90-702e4ff01516"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f62fd49-7e44-4535-adc8-62f74bb7b428'>ToInt</a></td><td style='width:75%' class='def'><p><a name="4f62fd49-7e44-4535-adc8-62f74bb7b428"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d261b6f3-5e9b-4f25-988d-c527bc4d172a'>Clone</a></td><td style='width:75%' ><p><a name="d261b6f3-5e9b-4f25-988d-c527bc4d172a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="0cf6c2e1-3ecf-43a4-9d6f-8e20f44a094f"></a>
##KimonoPropertyStyle

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4485e80f-8e71-451f-8653-7e0a94f76c6c'>Value</a></td><td style='width:75%' ><p><a name="4485e80f-8e71-451f-8653-7e0a94f76c6c"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef26053d-cce5-4391-9211-489f4ea5f590'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="ef26053d-cce5-4391-9211-489f4ea5f590"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#ab469ab5-feba-4a5c-924b-8bf91b1080f4">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#006f7b75-e0c1-40f3-875e-209d9d8c0aed'>KimonoPropertyStyle</a></td><td style='width:75%' ><p><a name="006f7b75-e0c1-40f3-875e-209d9d8c0aed"></a></p>

<h3>KimonoPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0cf6c2e1-3ecf-43a4-9d6f-8e20f44a094f">KimonoPropertyStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70b28494-09d5-4b3a-af0c-5b3fd94f9b20'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="70b28494-09d5-4b3a-af0c-5b3fd94f9b20"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12cc0515-0fa7-46ce-8c4e-ea15f2805d4e'>ToStyle</a></td><td style='width:75%' ><p><a name="12cc0515-0fa7-46ce-8c4e-ea15f2805d4e"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f8fe77d-577e-41ae-a175-38dbbde98145'>Clone</a></td><td style='width:75%' class='def'><p><a name="0f8fe77d-577e-41ae-a175-38dbbde98145"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="b8b9dadd-9839-4378-9718-4aa7101840ab"></a>
##KimonoPropertyBoolean

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `bool` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5b3298a5-66c0-43b2-80f7-4c193aa26ed9'>Value</a></td><td style='width:75%' ><p><a name="5b3298a5-66c0-43b2-80f7-4c193aa26ed9"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>bool</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b6a71e73-f15d-4718-9d58-23a19b9f1c55'>KimonoPropertyBoolean</a></td><td style='width:75%' ><p><a name="b6a71e73-f15d-4718-9d58-23a19b9f1c55"></a></p>

<h3>KimonoPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b8b9dadd-9839-4378-9718-4aa7101840ab">KimonoPropertyBoolean</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#132c4631-e041-45e4-a2f4-b03fd5ea6aa4'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="132c4631-e041-45e4-a2f4-b03fd5ea6aa4"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4099d162-bc07-4c19-8192-6be15d9bf75d'>ToBool</a></td><td style='width:75%' ><p><a name="4099d162-bc07-4c19-8192-6be15d9bf75d"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p><code>true</code>, if bool was toed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f29523a-e8e6-4258-9cf8-52035a6ab5d9'>Clone</a></td><td style='width:75%' class='def'><p><a name="5f29523a-e8e6-4258-9cf8-52035a6ab5d9"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="55c76016-a926-4910-8acd-0fc46afade25"></a>
##KimonoPropertyText

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `string` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#93ef708c-2286-4f34-ad2e-cf6020e5ce67'>Value</a></td><td style='width:75%' ><p><a name="93ef708c-2286-4f34-ad2e-cf6020e5ce67"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#01c2731c-4eb0-4bed-acb4-21add51ccc9f'>KimonoPropertyText</a></td><td style='width:75%' ><p><a name="01c2731c-4eb0-4bed-acb4-21add51ccc9f"></a></p>

<h3>KimonoPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#55c76016-a926-4910-8acd-0fc46afade25">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65db95ab-5b59-47b4-8bb0-54279e8cd77a'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="65db95ab-5b59-47b4-8bb0-54279e8cd77a"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ffc82ac-8a07-473c-822e-8c3796405af6'>ToString</a></td><td style='width:75%' ><p><a name="7ffc82ac-8a07-473c-822e-8c3796405af6"></a></p>

<h3>ToString ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>string</code>.</p>

<h4>Returns</h4>

<p>The <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc473ef1-0494-492d-9509-203dc680b5a7'>Clone</a></td><td style='width:75%' class='def'><p><a name="cc473ef1-0494-492d-9509-203dc680b5a7"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="ab469ab5-feba-4a5c-924b-8bf91b1080f4"></a>
##KimonoPropertyColor

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2e94677a-df80-4bca-a623-a1bc308f5ac1'>Value</a></td><td style='width:75%' ><p><a name="2e94677a-df80-4bca-a623-a1bc308f5ac1"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88824db2-98f2-4cdc-9eab-f2a973b72458'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="88824db2-98f2-4cdc-9eab-f2a973b72458"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#ab469ab5-feba-4a5c-924b-8bf91b1080f4">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1f5a7437-9b6c-4fc3-985b-5080a1e62908'>KimonoPropertyColor</a></td><td style='width:75%' ><p><a name="1f5a7437-9b6c-4fc3-985b-5080a1e62908"></a></p>

<h3>KimonoPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#55c76016-a926-4910-8acd-0fc46afade25">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#995e2d90-3322-4a6b-aa19-08f127956cb8'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="995e2d90-3322-4a6b-aa19-08f127956cb8"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c075ee27-21b5-46d4-8e04-bf73a489a05b'>ToColor</a></td><td style='width:75%' ><p><a name="c075ee27-21b5-46d4-8e04-bf73a489a05b"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a91601d-b8c9-4ef7-a5f6-f6351c2114a7'>Clone</a></td><td style='width:75%' class='def'><p><a name="6a91601d-b8c9-4ef7-a5f6-f6351c2114a7"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="1cd19f95-eb5f-4e29-8a3e-122a8ab9e517"></a>
##KimonoPropertyGradient

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoGradient` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7579b7b9-c8b0-48a9-89cf-23747956dcff'>Value</a></td><td style='width:75%' ><p><a name="7579b7b9-c8b0-48a9-89cf-23747956dcff"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ec43d06-b627-40e8-914d-1cf2c9fdf8e7'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="9ec43d06-b627-40e8-914d-1cf2c9fdf8e7"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#ab469ab5-feba-4a5c-924b-8bf91b1080f4">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4ad88705-be9b-4df9-8226-903069abca9c'>KimonoPropertyGradient</a></td><td style='width:75%' ><p><a name="4ad88705-be9b-4df9-8226-903069abca9c"></a></p>

<h3>KimonoPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#55c76016-a926-4910-8acd-0fc46afade25">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#557b9887-ef46-4d3a-aa43-a7f038508cdc'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="557b9887-ef46-4d3a-aa43-a7f038508cdc"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#732e03dd-e126-48c0-95d7-972c45ff1380'>ToGradient</a></td><td style='width:75%' ><p><a name="732e03dd-e126-48c0-95d7-972c45ff1380"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9a777c4-3097-4bd4-a171-28bc8b5ec2fb'>Clone</a></td><td style='width:75%' class='def'><p><a name="d9a777c4-3097-4bd4-a171-28bc8b5ec2fb"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="3f0ea220-0c6f-4b56-8b74-01edf59503cf"></a>
##CodeOutputOS

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the OS that code will be generated for
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2f19e17d-44a1-412a-a6df-a72ff11ff841'>Windows</a></td><td style='width:75%' ><p><a name="2f19e17d-44a1-412a-a6df-a72ff11ff841"></a>
<b>Windows</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdd9a1fc-7dd6-40ab-a37d-e41309e17881'>WindowsUWP</a></td><td style='width:75%' class='def'><p><a name="cdd9a1fc-7dd6-40ab-a37d-e41309e17881"></a>
<b>WindowsUWP</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Universal Windows Platform.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ce9fabb-d5cd-4cbb-8484-a067d3ce9ad6'>WindowsWPF</a></td><td style='width:75%' ><p><a name="4ce9fabb-d5cd-4cbb-8484-a067d3ce9ad6"></a>
<b>WindowsWPF</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Windows Presentation Foundation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#877013e0-5003-4546-9055-82291af72d0d'>Android</a></td><td style='width:75%' class='def'><p><a name="877013e0-5003-4546-9055-82291af72d0d"></a>
<b>Android</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Android OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44bc39b1-d7e9-49fc-9edf-51bbdbada8f4'>iOS</a></td><td style='width:75%' ><p><a name="44bc39b1-d7e9-49fc-9edf-51bbdbada8f4"></a>
<b>iOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For iOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b616d2f-6eac-402f-ab79-09687dbb4c74'>tvOS</a></td><td style='width:75%' class='def'><p><a name="8b616d2f-6eac-402f-ab79-09687dbb4c74"></a>
<b>tvOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For tvOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1852ffb-4cab-467d-ab37-3e558815f3b7'>macOS</a></td><td style='width:75%' ><p><a name="d1852ffb-4cab-467d-ab37-3e558815f3b7"></a>
<b>macOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For macOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4893187b-19a8-43c7-b307-59e13f5f762c'>CrossPlatform</a></td><td style='width:75%' class='def'><p><a name="4893187b-19a8-43c7-b307-59e13f5f762c"></a>
<b>CrossPlatform</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Cross-platform code.</p>
</td></tr></table></p>


---

<a name="9f0bcae2-4212-43c8-bd18-ef370d210953"></a>
##CodeOutputLanguage

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Defines the language that code will be output in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b962e0bb-14c8-4c3c-b353-b5d487bf3236'>CSharp</a></td><td style='width:75%' ><p><a name="b962e0bb-14c8-4c3c-b353-b5d487bf3236"></a>
<b>CSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for C#.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cad26b05-0367-475a-bc90-976a9487050f'>ObiScript</a></td><td style='width:75%' class='def'><p><a name="cad26b05-0367-475a-bc90-976a9487050f"></a>
<b>ObiScript</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for the internal ObiScript scripting language.</p>
</td></tr></table></p>


---

<a name="db8121f3-0156-4db5-a8f7-6e09acf33d15"></a>
##CodeOutputLibrary

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Code output library.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#00af9d85-c7af-4974-98da-ff3c58d9311b'>SkiaSharp</a></td><td style='width:75%' ><p><a name="00af9d85-c7af-4974-98da-ff3c58d9311b"></a>
<b>SkiaSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output pure SkiaSharp code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37c4667d-9100-45d0-8c0c-3959f6e18904'>KimonoCore</a></td><td style='width:75%' class='def'><p><a name="37c4667d-9100-45d0-8c0c-3959f6e18904"></a>
<b>KimonoCore</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output code using the helper <code>KimonoCore</code> classes.</p>
</td></tr></table></p>


---

<a name="45d46f25-df9a-4bf8-86b0-d1e3f8543285"></a>
##KimonoCodeGenerator

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

The Kimono Code Generator has routine to assist in the generation of output source code.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#177560a0-7073-478e-8e46-e1fd44e27d51'>NextElementNumber</a></td><td style='width:75%' ><p><a name="177560a0-7073-478e-8e46-e1fd44e27d51"></a>
<b>NextElementNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The next element number.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7326d5f-eada-41ea-9dce-0c29c1558084'>AddNumberToElementNames</a></td><td style='width:75%' class='def'><p><a name="a7326d5f-eada-41ea-9dce-0c29c1558084"></a>
<b>AddNumberToElementNames</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Add number to element names when generating.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bf1d965-b445-4f08-8a3d-27198c84c750'>SupportingColors</a></td><td style='width:75%' ><p><a name="2bf1d965-b445-4f08-8a3d-27198c84c750"></a>
<b>SupportingColors</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting colors that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3555cdb7-2dac-42af-93f6-daa73caaf45f'>SupportingGradients</a></td><td style='width:75%' class='def'><p><a name="3555cdb7-2dac-42af-93f6-daa73caaf45f"></a>
<b>SupportingGradients</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting gradients that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8a9bbca-ffd5-415b-ab82-6a59b5df8e94'>SupportingStyles</a></td><td style='width:75%' ><p><a name="b8a9bbca-ffd5-415b-ab82-6a59b5df8e94"></a>
<b>SupportingStyles</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting styles that are required for the object being converted to source code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2226d39f-757e-480d-9fc0-2c59b674cb15'>ResetCodeGeneration</a></td><td style='width:75%' ><p><a name="2226d39f-757e-480d-9fc0-2c59b674cb15"></a></p>

<h3>ResetCodeGeneration ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Resets the code generation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cb70bd8-6284-40dc-917f-1315197a22d4'>AddSupportingColor</a></td><td style='width:75%' class='def'><p><a name="8cb70bd8-6284-40dc-917f-1315197a22d4"></a></p>

<h3>AddSupportingColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given color to the collection of named colors that are used in the generation of other Kimono Objects. If a color is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="fd782d88-f44a-4100-afe6-c818c202f89a"></a>
The <code>KimonoColor</code> to add to the collection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#919d0edc-ad30-41f4-ad95-837cf9e05fe8'>CodeForSupportingColors</a></td><td style='width:75%' ><p><a name="919d0edc-ad30-41f4-ad95-837cf9e05fe8"></a></p>

<h3>CodeForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="158c3198-935b-448c-b203-f5c276b699ba"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="a8864f47-2d4c-44d5-833d-5ac5869c2833"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b4d0cbf-6f38-47b3-9e42-8c33140342a5'>PropertyForSupportingColors</a></td><td style='width:75%' class='def'><p><a name="5b4d0cbf-6f38-47b3-9e42-8c33140342a5"></a></p>

<h3>PropertyForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="c8259cb0-0d61-46dc-a25b-3a5e3bab6efd"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="0e3c623d-987c-425f-afa7-858f581c8ebc"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0eeece2-3398-4ad6-89e7-7314b0ec3036'>AddSupportingGradient</a></td><td style='width:75%' ><p><a name="d0eeece2-3398-4ad6-89e7-7314b0ec3036"></a></p>

<h3>AddSupportingGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given gradient to the collection of named gradients that are used in the generation of other Kimono Objects. If a gradient is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="1e79a26d-9efa-488d-9dc9-8422b8440af6"></a>
The <code>KimonoGradient</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e58b979-fae5-4b16-9261-d258947515c7'>CodeForSupportGradients</a></td><td style='width:75%' class='def'><p><a name="4e58b979-fae5-4b16-9261-d258947515c7"></a></p>

<h3>CodeForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="a80c3736-9430-46b2-a06d-9f3faaa409d6"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="7501cb47-63b8-4f3f-8a01-1cb817496902"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90e0af3c-1582-4030-aa03-16dd1fa86b81'>PrivateVariablesForSupportingGradients</a></td><td style='width:75%' ><p><a name="90e0af3c-1582-4030-aa03-16dd1fa86b81"></a></p>

<h3>PrivateVariablesForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="00f1c5ad-8a81-48a4-a4f6-d7b4c8445a7e"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="934644c0-7869-47c9-80d4-de1a78c899a1"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d172481b-e85c-4eaa-ba29-726c92aef3e2'>PropertyForSupportingGradients</a></td><td style='width:75%' class='def'><p><a name="d172481b-e85c-4eaa-ba29-726c92aef3e2"></a></p>

<h3>PropertyForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="b05554bc-0a57-46f6-8ae2-e7b1470048a6"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="c6adb79a-740e-4c33-8b4d-2711262a3b82"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3b7c1a5-5f34-4b16-914b-5a012620aaec'>InitializerForSupportGradients</a></td><td style='width:75%' ><p><a name="a3b7c1a5-5f34-4b16-914b-5a012620aaec"></a></p>

<h3>InitializerForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="62abfef8-7dbb-472a-9431-08af132919cf"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="c3a487f5-cd0c-4ec5-a5d2-480e165a7ab3"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e77f8bed-7189-4429-9de4-d2a4ddaba8ce'>AddSupportingStyle</a></td><td style='width:75%' class='def'><p><a name="e77f8bed-7189-4429-9de4-d2a4ddaba8ce"></a></p>

<h3>AddSupportingStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given style to the collection of named styles that are used in the generation of other Kimono Objects. If a style is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="cbde4595-17ee-4300-bd1d-35953a3cd899"></a>
The <code>KimonoStyle</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9334730-39b2-421a-b3a1-860faedb1ea0'>CodeForSupportStyles</a></td><td style='width:75%' ><p><a name="a9334730-39b2-421a-b3a1-860faedb1ea0"></a></p>

<h3>CodeForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="6e91c8f0-34dd-4830-a3b5-79b13e314d10"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="82142443-8899-418f-80d4-c7b139d38c2a"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8afe0e5-a01a-46be-81d3-5203bc7d46d5'>PropertyForSupportingStyles</a></td><td style='width:75%' class='def'><p><a name="c8afe0e5-a01a-46be-81d3-5203bc7d46d5"></a></p>

<h3>PropertyForSupportingStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="24646a9f-f48e-4f63-968c-9b1768b85e91"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="e34c1785-82b9-408d-8b47-5da1b42bbab4"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf817c23-26bd-47d0-982a-d545b1e065df'>InitializerForSupportStyles</a></td><td style='width:75%' ><p><a name="cf817c23-26bd-47d0-982a-d545b1e065df"></a></p>

<h3>InitializerForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="94bcbc3a-8129-46ba-a371-442998b4b1ec"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="686abcba-3373-4f7b-b1d7-360b3bc275ff"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc937bff-c66f-4174-8f83-4e5beef7dfe9'>MakeElementName</a></td><td style='width:75%' class='def'><p><a name="cc937bff-c66f-4174-8f83-4e5beef7dfe9"></a></p>

<h3>MakeElementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes a valid source code name for the name of a given Kimono Object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="3ec6a103-e365-4040-823f-a99e2b487214"></a>
The source Kimono Object name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The element name valid for use in source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5ea7db2-2256-4259-88fc-5898d28ca211'>IncreaseIndentLevel</a></td><td style='width:75%' ><p><a name="f5ea7db2-2256-4259-88fc-5898d28ca211"></a></p>

<h3>IncreaseIndentLevel (System.String, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code by the given number of levels</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="3dbeb9db-85c6-4ee4-b726-b0adf507a6d0"></a>
Source code.</p>
</td></tr><tr><td style='width:25%' class='term'>levels</td><td style='width:75%' class='def'><p><a name="6d4dc647-c062-473b-b8ed-34ae33d90f0c"></a>
Levels.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The indent level.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f186154-0db9-473f-a9b2-f48043f64b51'>IncreaseIndentLevel</a></td><td style='width:75%' class='def'><p><a name="2f186154-0db9-473f-a9b2-f48043f64b51"></a></p>

<h3>IncreaseIndentLevel (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="2186bab8-c748-40af-ae56-77c4f52514db"></a>
The source code to indent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code indented by one tab.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ac548dc-33cb-410d-82bf-b2054fe89fbc'>ColorToCode</a></td><td style='width:75%' ><p><a name="0ac548dc-33cb-410d-82bf-b2054fe89fbc"></a></p>

<h3>ColorToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given color to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="1345a658-8cf7-4684-82b4-fbcddff25d8a"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="44bd9c83-7862-42d9-8aa8-6ed7013d9a1c"></a>
The <code>SKColor</code> to create code for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#973be78e-d653-4501-9bdf-6d4bab0a2d81'>PointToCode</a></td><td style='width:75%' class='def'><p><a name="973be78e-d653-4501-9bdf-6d4bab0a2d81"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0799b6b0-b2bf-46ac-8289-2a283b64ead3"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="98106aba-ce2f-471a-9522-98875325e605"></a>
The <code>SKPoint</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10dc8831-db68-4f5c-8519-81fbd3c16985'>PointToCode</a></td><td style='width:75%' ><p><a name="10dc8831-db68-4f5c-8519-81fbd3c16985"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c2777b5d-91b8-4ec6-a831-2e906cc36ad7"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="096f0106-abbd-4956-8cab-c8c9d2f92cd3"></a>
The <code>KimonoHandle</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr></table></p>


---

<a name="a2967a95-491a-485d-9978-154eea72528a"></a>
##IKimonoCodeGeneration

###Namespace

[KimonoCore](#b8318743-3687-4197-8745-edf08a8b10f2)

###Added In API Version

01.00.00

###Summary

Interface for any Kimono Object that support source code generation.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d00d809e-6937-441e-9fac-a648b230909d'>Name</a></td><td style='width:75%' ><p><a name="d00d809e-6937-441e-9fac-a648b230909d"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the name.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#617a43a8-1c50-4fae-9d8a-032f4df4da6b'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="617a43a8-1c50-4fae-9d8a-032f4df4da6b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23cd070c-7c19-4bf6-bdb6-e70d2ae5ea69'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="23cd070c-7c19-4bf6-bdb6-e70d2ae5ea69"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82275e42-ec3b-4da4-b340-ce19418e2937'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="82275e42-ec3b-4da4-b340-ce19418e2937"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45acab57-0a28-4e30-a1a0-b152654cfbba'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="45acab57-0a28-4e30-a1a0-b152654cfbba"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="1f810a1d-0e2a-4665-84c0-0bbb198f3ed6"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#442dadd0-acf3-4e1e-b176-431e3647dbe7'>ToCode</a></td><td style='width:75%' ><p><a name="442dadd0-acf3-4e1e-b176-431e3647dbe7"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d465d385-703a-46b3-b928-7aa36b0aa521"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="27744b51-29e5-4886-b0a4-5bdc34b78096"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="cb44fc20-0e79-40c4-9a0f-801dff48882e"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr></table></p>

