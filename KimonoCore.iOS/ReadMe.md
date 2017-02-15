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

Kimono Designer, KimonoCore and KimonoCore.iOS were created by Kevin Mullins for Microsoft, Inc.

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

<a name="29d4123d-03e1-4b22-bd09-3e39148c25cd"></a>
##KimonoCore

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9e2f270a-fbf0-4398-b1ed-6181e53728a5'>KimonoSketch</a></td><td style='width:75%' ><p>Holds a collection of <code>KimonoShapes</code> that are used to create a given image using Skia.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13f774fa-411f-4ba9-9782-4fc905cb27cf'>KimonoTool</a></td><td style='width:75%' class='def'><p>Defines the current tool that is active in a <code>KimonoSketch</code> that the user can use to create or modify a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58d8d244-c066-474a-83b1-9e33c5ed0ef4'>Kimono</a></td><td style='width:75%' ><p>Holds a set of shared utilities that are used across the Kimono classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbbde974-6690-4319-8de7-59f9612c1414'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>A Kimono Portfolio holds a collection of <code>KimonoSketches</code>, <code>KimonoStyles</code> and <code>KimonoColors</code> that define a given Kimono Designer project.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b87073a6-0f83-4b21-9071-fc4db608db5a'>KimonoUndoHandler</a></td><td style='width:75%' ><p>Handles the undo/redo state for a <code>KimonoDesignSurface</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc8d1729-30d8-4f99-abd6-2508271c15ad'>KimonoShape</a></td><td style='width:75%' class='def'><p>Defines the based shape that all other Kimono Shape types will inherit from.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59daaea7-48bd-410a-9d38-0f55b79ceb2d'>KimonoShapeArrow</a></td><td style='width:75%' ><p>Draws either an outlined or single line arrow with heads on one or both ends.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61c4c394-866e-4d62-9040-316d86f8bcc3'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p>A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99029195-ed89-4ee7-bbbe-a81b4f4acc15'>KimonoShapeGroup</a></td><td style='width:75%' ><p>A <code>KimonoShapeGroup</code> holds a collection of <code>KimonoShapes</code> that can be acted upon as a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98ff3cb4-e031-4c17-9338-ab73499d892d'>KimonoShapeGroupType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa8aeb6b-e55b-4117-9f22-9f0f795e101e'>KimonoShapeLine</a></td><td style='width:75%' ><p>Draws a line on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d42c82a-e030-4f74-8062-783172a33d0e'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>Draws an oval into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#302d607b-fa7d-4b05-9978-dc5018edd7d2'>KimonoShapePolygon</a></td><td style='width:75%' ><p>Draws a multi-sided polygon into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca0b823a-f127-4fba-b432-471416e39668'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>Draws a rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#629909ad-04aa-4750-84ca-c8faa6b0a5ce'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>Draws a rounded rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f92fcb7d-1cc7-48aa-9a7c-65539304d244'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>Draws a multi-sided star shape into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd3dcbc2-9a02-46b8-81db-cc253fd53092'>KimonoShapeState</a></td><td style='width:75%' ><p>Holds the current state of a <code>KimonoShape</code> while it is being edited by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a045ad92-135c-4664-9850-30e018da9a53'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>Draws a block of text into the Design Surface within the specifid bounds of this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b323c416-06ca-44f1-830a-97d66fe8b496'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>Draws a triangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15bc4b30-d930-446d-be78-e8a76ae846b7'>KimonoProperty</a></td><td style='width:75%' ><p>Defines a property that can be attached to another Kimono object (such as a <code>KimonoColor</code>, <code>KimonoStyle</code> or <code>KimonoShape</code>) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a02f778-2f02-4752-b64a-d384a80d05f8'>KimonoPropertyUsage</a></td><td style='width:75%' class='def'><p>Defines how a <code>KimonoProperty</code> is used when it is attached to a <code>KimonoShape</code>, <code>KimonoSketch</code> or <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6eff130f-7847-461a-938d-4398ec2ab268'>KimonoPropertyConnectionPoint</a></td><td style='width:75%' ><p>Defines the point that a <code>KimonoProperty</code> value can be connected to another Kimono object such as the <code>Top</code> coordinate of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b208800f-6027-4ded-b45a-a4131c60a043'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p>Defines a connection between a given Kimono Object and a <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75063490-184b-469b-ad0b-738f456a6918'>ObiScriptResult</a></td><td style='width:75%' ><p>Defines the result of attempting to execute an Obi Script on a <code>KimonoProperty</code></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1240a485-ca04-49c6-95b1-a16edc8d8ac2'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p>Holds the control and end point for a <code>KimonoShapeBezier</code> that define a quad section of the Bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10a5423f-991f-43f1-82db-00e8c2cf52ba'>KimonoBounds</a></td><td style='width:75%' ><p>Defines the outter bounding box for a <code>KimonoShape</code> and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6acde3a1-1a2b-4971-bb44-a8eab78d5f36'>KimonoHandle</a></td><td style='width:75%' class='def'><p>Defines an edit handle that the user manipulates to edit the bounds of a <code>KimonoShape</code> or the control points of a Bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b763a01e-3cfe-4327-b919-09d62d7e7db7'>KimonoHandleConstraint</a></td><td style='width:75%' ><p>Constrains the movement of a <code>KimonoHandle</code> when it is being moved by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5df34b9c-5bc0-4e10-9592-2fa27a7d09d7'>KimonoHandleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoHandle</code> that can be used as a general purpose control point to adjust the bounds of a <code>KimonoShape</code> or as a point for a vector or bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8323798b-4b54-45cc-8cc0-932c3f4f7dcf'>KimonoBlur</a></td><td style='width:75%' ><p>Defines a blur effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da41d5f6-0962-495f-9bde-c435d34bd286'>KimonoShadow</a></td><td style='width:75%' class='def'><p>Defines a shadow effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a5a2509-cb91-4b01-b5e9-111349587eb1'>KimonoGradient</a></td><td style='width:75%' ><p>Defines a gradient as a collection of either <code>SKColor</code> or linked <code>KimonoColors</code> that can be applied to a <code>KimonoStyle</code> and used when drawing a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e698df07-aee0-4f0b-80de-f6dfafdc63a8'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>Kimono gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d460dc02-2b42-47ca-86fd-eb637f258ef6'>KimonoStyle</a></td><td style='width:75%' ><p>Defines as style that can be applied to a <code>KimonoShape</code> to control its appearance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d46f18a-8e5a-45c4-b61d-08b40d68c61f'>KimonoStyleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoStyle</code> that will be used to draw a given <code>KimonoShape</code> in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#019dcf5a-79c3-4301-9ab7-43774ca8c2e1'>KimonoPropertyRect</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>SKRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#834c51a0-25f8-4673-bef6-7957d4cc45e1'>KimonoPropertyNumber</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>float</code> or <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17855e00-4772-4f25-a9a8-9cbb07eb0c52'>KimonoPropertyStyle</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b09ad7ae-b4e6-4374-879c-c4e072ce4272'>KimonoPropertyBoolean</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0953fd99-bf88-435f-9824-c4d25a2980c9'>KimonoPropertyText</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e7df6a4-e527-4fd3-a523-dfdbd3141fc9'>KimonoPropertyColor</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2feeb79-abc3-47df-a1da-f55d81481fee'>KimonoPropertyGradient</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81709ecf-b192-4221-928d-69268a79bf31'>CodeOutputOS</a></td><td style='width:75%' class='def'><p>Defines the OS that code will be generated for</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e7cd931-32a6-4ca4-9cc4-acb5d2df030f'>CodeOutputLanguage</a></td><td style='width:75%' ><p>Defines the language that code will be output in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#add24dce-0b9a-46c4-a407-3207833d873b'>CodeOutputLibrary</a></td><td style='width:75%' class='def'><p>Code output library.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d8617a9-bebf-448e-bf54-3866da7dbbe3'>KimonoCodeGenerator</a></td><td style='width:75%' ><p>The Kimono Code Generator has routine to assist in the generation of output source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c945e1b9-aa73-4792-b941-4296ad13d953'>IKimonoCodeGeneration</a></td><td style='width:75%' class='def'><p>Interface for any Kimono Object that support source code generation.</p>
</td></tr></table></p>


---

<a name="c0d3413a-22e0-4adb-b101-cb672184488c"></a>
##KimonoCore.Kimono

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#53365d40-e064-46c0-8d20-da5a77494e91'>PortfolioEventDelegate</a></td><td style='width:75%' ><p>Portfolio event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20667756-501c-4610-afcd-5cc7c8227952'>SketchEventDelegate</a></td><td style='width:75%' class='def'><p>Sketch event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7814593-3999-4096-8716-d1f25a235129'>StyleEventDelegate</a></td><td style='width:75%' ><p>Style event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df52ba84-b540-495a-888c-acd50217eef4'>ShapeEventDelegate</a></td><td style='width:75%' class='def'><p>Shape event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d42307cb-79b8-4e88-9325-31a17e3753bb'>ToolEventDelegate</a></td><td style='width:75%' ><p>Tool event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fcbe298-8d42-4b20-899d-361fb024e55c'>SkiaPointEventDelegate</a></td><td style='width:75%' class='def'><p>Skia point event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c38c8af-3498-4f0c-8dad-086392ca9a59'>GroupEventDelegate</a></td><td style='width:75%' ><p>Group event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5475946d-eac7-4f96-bf74-ce5351b3e2ac'>ColorEventDelegate</a></td><td style='width:75%' class='def'><p>Color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#229b6149-4e0b-450b-b4a1-3d25dcb0ce61'>SkiaColorEventDelegate</a></td><td style='width:75%' ><p>Skia color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec1e98a5-60fa-41bf-8ff2-88defa2c79d3'>GradientEventDelegate</a></td><td style='width:75%' class='def'><p>Gradient event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39881353-ac83-470e-b6a2-4fc0746e4b92'>HandleEventDelegate</a></td><td style='width:75%' ><p>Handle event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5fa5658-2f3a-46f2-901a-929498c86cfe'>PropertyEventDelegate</a></td><td style='width:75%' class='def'><p>Property event delegate.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="9e2f270a-fbf0-4398-b1ed-6181e53728a5"></a>
##KimonoSketch

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Holds a collection of `KimonoShapes` that are used to create a given image using Skia.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#636c4ff3-41e6-4c51-82a0-b3ac8000c4a2'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="636c4ff3-41e6-4c51-82a0-b3ac8000c4a2"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3e9c539-09ca-41f2-a5e9-ab14008f86c2'>PreviousSize</a></td><td style='width:75%' class='def'><p><a name="e3e9c539-09ca-41f2-a5e9-ab14008f86c2"></a>
<b>PreviousSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the previous of a sketch for a rezise operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64180598-1141-438d-b1dd-026320db55e3'>Size</a></td><td style='width:75%' ><p><a name="64180598-1141-438d-b1dd-026320db55e3"></a>
<b>Size</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The current size of the sketch</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d55a8c1-8552-4df8-b97b-6df60273394b'>_tool</a></td><td style='width:75%' class='def'><p><a name="1d55a8c1-8552-4df8-b97b-6df60273394b"></a>
<b>_tool</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently <code>KimonoTool</code> that will be used to edit the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a8f32df-70f9-494e-8205-f55ab25992df'>_canvasColor</a></td><td style='width:75%' ><p><a name="9a8f32df-70f9-494e-8205-f55ab25992df"></a>
<b>_canvasColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00435add-1d03-40af-ab8b-d59ceaf51dbb'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="00435add-1d03-40af-ab8b-d59ceaf51dbb"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fe9fa29-1890-47d1-8e44-f5e8fb4093bb'>IgnoreDrag</a></td><td style='width:75%' ><p><a name="8fe9fa29-1890-47d1-8e44-f5e8fb4093bb"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65d7a8f1-fb2e-4bde-a604-906b2d7d717f'>PerformingDrag</a></td><td style='width:75%' class='def'><p><a name="65d7a8f1-fb2e-4bde-a604-906b2d7d717f"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c3b74f7-3b15-4569-9395-1614d2cf38cd'>ToolDownAt</a></td><td style='width:75%' ><p><a name="7c3b74f7-3b15-4569-9395-1614d2cf38cd"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ec838b45-64a2-4835-92b0-ad317c93c259'>UniqueID</a></td><td style='width:75%' ><p><a name="ec838b45-64a2-4835-92b0-ad317c93c259"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74ca8ff5-5b5b-43d7-b0ba-2670c458709d'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="74ca8ff5-5b5b-43d7-b0ba-2670c458709d"></a></p>

<h3>Portfolio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the portfolio that this sketch belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#037b2ace-2d24-4390-9c32-c5bc13f79915'>ElementName</a></td><td style='width:75%' ><p><a name="037b2ace-2d24-4390-9c32-c5bc13f79915"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8130f111-6979-4d2b-8f26-43f2584488c4'>Name</a></td><td style='width:75%' class='def'><p><a name="8130f111-6979-4d2b-8f26-43f2584488c4"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9c651af-5f23-432e-88c3-f5690187999b'>GenerateCodeToOuputToCanvas</a></td><td style='width:75%' ><p><a name="d9c651af-5f23-432e-88c3-f5690187999b"></a></p>

<h3>GenerateCodeToOuputToCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, ouput a method that draws into the given SkiaSharp Canvas.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91679820-a3f5-42f2-9162-d904e790f378'>GenerateCodeToOuputSkiaData</a></td><td style='width:75%' class='def'><p><a name="91679820-a3f5-42f2-9162-d904e790f378"></a></p>

<h3>GenerateCodeToOuputSkiaData</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the SkiaSharp Data (<code>SKData[]</code>) representing the Sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput skia data; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b891decc-ade3-4ba0-b8d9-3858e9005fbc'>GenerateCodeToOuputBitmapImage</a></td><td style='width:75%' ><p><a name="b891decc-ade3-4ba0-b8d9-3858e9005fbc"></a></p>

<h3>GenerateCodeToOuputBitmapImage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as a OS specific bitmap image.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput bitmap image; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d8639f9-169a-43ef-87eb-47f57c4be63f'>GenerateCodeToOuputToSkiaSharpViews</a></td><td style='width:75%' class='def'><p><a name="4d8639f9-169a-43ef-87eb-47f57c4be63f"></a></p>

<h3>GenerateCodeToOuputToSkiaSharpViews</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as class based on the <code>SkiaSharp.Views</code> extension library.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to skia sharp views; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b917d91b-9aca-420f-86e3-288913cebe6d'>Width</a></td><td style='width:75%' ><p><a name="b917d91b-9aca-420f-86e3-288913cebe6d"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6af8cc05-5b87-4e8e-bfca-0a6afacb0538'>Height</a></td><td style='width:75%' class='def'><p><a name="6af8cc05-5b87-4e8e-bfca-0a6afacb0538"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fb70409-3a83-4898-a39c-e7152a3b2bc6'>CanvasColor</a></td><td style='width:75%' ><p><a name="7fb70409-3a83-4898-a39c-e7152a3b2bc6"></a></p>

<h3>CanvasColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the canvas.</p>

<h4>Return Value</h4>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96624f7f-904d-4229-aaa7-bf1e7d803a15'>DrawCanvas</a></td><td style='width:75%' class='def'><p><a name="96624f7f-904d-4229-aaa7-bf1e7d803a15"></a></p>

<h3>DrawCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#9e2f270a-fbf0-4398-b1ed-6181e53728a5">KimonoSketch</a> should draw  the canvas when it is included in another sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if draw canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#527e5125-447e-4f46-bdb6-28957a34e500'>Shapes</a></td><td style='width:75%' ><p><a name="527e5125-447e-4f46-bdb6-28957a34e500"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e362b69f-a14c-4a57-b364-be1f38b8dcd1'>Tool</a></td><td style='width:75%' class='def'><p><a name="e362b69f-a14c-4a57-b364-be1f38b8dcd1"></a></p>

<h3>Tool</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tool.</p>

<h4>Return Value</h4>

<p>The tool.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fef40c80-f151-4660-ba1a-be8e1349cb9c'>SelectedShape</a></td><td style='width:75%' ><p><a name="fef40c80-f151-4660-ba1a-be8e1349cb9c"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dee8567b-a7ac-47d9-84fc-9ec71550888f'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="dee8567b-a7ac-47d9-84fc-9ec71550888f"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dff5b0cf-26c6-4eb4-943c-1c6b33e88d78'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="dff5b0cf-26c6-4eb4-943c-1c6b33e88d78"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a99f936e-67b4-4059-a65f-0667bdc95087'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="a99f936e-67b4-4059-a65f-0667bdc95087"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03450cb1-01d2-4774-a876-56539d0b2ade'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="03450cb1-01d2-4774-a876-56539d0b2ade"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9f9b24c-76af-40bd-9d1e-f19d1b552e8f'>CanAlignShapes</a></td><td style='width:75%' class='def'><p><a name="b9f9b24c-76af-40bd-9d1e-f19d1b552e8f"></a></p>

<h3>CanAlignShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether alignment can be applied on a set of shapes.</p>

<h4>Return Value</h4>

<p><code>true</code> if can align shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdb68b49-2173-4518-9eee-a6cf8492f7e1'>CanGroupShapes</a></td><td style='width:75%' ><p><a name="bdb68b49-2173-4518-9eee-a6cf8492f7e1"></a></p>

<h3>CanGroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be grouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce16a3ea-c10d-4e7d-88fd-075a3cfe90af'>CanUngroupShapes</a></td><td style='width:75%' class='def'><p><a name="ce16a3ea-c10d-4e7d-88fd-075a3cfe90af"></a></p>

<h3>CanUngroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be ungrouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8879ef30-e91c-413f-8adf-890807a90dcb'>ToImage</a></td><td style='width:75%' ><p><a name="8879ef30-e91c-413f-8adf-890807a90dcb"></a></p>

<h3>ToImage ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the sketch to a bitmap image.</p>

<h4>Returns</h4>

<p>The <code>UIImage</code> representation of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8594caa5-8544-47cf-8cda-d1d4ed51130d'>KimonoSketch</a></td><td style='width:75%' class='def'><p><a name="8594caa5-8544-47cf-8cda-d1d4ed51130d"></a></p>

<h3>KimonoSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9e2f270a-fbf0-4398-b1ed-6181e53728a5">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84864479-7ca3-47de-adfd-f8b175377626'>KimonoSketch</a></td><td style='width:75%' ><p><a name="84864479-7ca3-47de-adfd-f8b175377626"></a></p>

<h3>KimonoSketch (System.String, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9e2f270a-fbf0-4398-b1ed-6181e53728a5">KimonoSketch</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="ba4d0a27-589b-4834-bbf3-6b9f13d84e6c"></a>
Name.</p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p><a name="88531c4b-fb11-4442-a97b-ae1b2ad44b61"></a>
Width.</p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p><a name="37419697-a09d-4fe7-8ce1-a9a2259969d5"></a>
Height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41e719ce-bca6-4246-b8c7-ef3f2293de4b'>Initialize</a></td><td style='width:75%' class='def'><p><a name="41e719ce-bca6-4246-b8c7-ef3f2293de4b"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cfe8714-4063-4610-bb95-fd524eb62323'>SavePreviousSize</a></td><td style='width:75%' ><p><a name="3cfe8714-4063-4610-bb95-fd524eb62323"></a></p>

<h3>SavePreviousSize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous size of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7c3929a-3ed8-41ea-8942-756007ffbbf3'>ApplySizeChange</a></td><td style='width:75%' class='def'><p><a name="f7c3929a-3ed8-41ea-8942-756007ffbbf3"></a></p>

<h3>ApplySizeChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the size change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1afa1d1-a282-440d-83e7-368b21e9bb62'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="c1afa1d1-a282-440d-83e7-368b21e9bb62"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="2905900c-bbf6-446b-bf44-00911ec5d780"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6e402a1-bcc5-4abb-b3bd-06f35aceb330'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="c6e402a1-bcc5-4abb-b3bd-06f35aceb330"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="f2568ab1-4dd2-4397-9c73-4e3e0d27b4b8"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17d3ee2d-d7d4-4cf6-80c6-3319210287b6'>FindShape</a></td><td style='width:75%' ><p><a name="17d3ee2d-d7d4-4cf6-80c6-3319210287b6"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the shape specified by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="1d7206f6-d682-4d1d-be4f-314f4af993f9"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>If found, the <code>KimonoShape</code> will be returned, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#484f47ba-1a1b-496f-ba9d-7cfd5e61143e'>Draw</a></td><td style='width:75%' class='def'><p><a name="484f47ba-1a1b-496f-ba9d-7cfd5e61143e"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw this sketch into the give SkiaSharp canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="1d2a479b-ed9b-44bf-a400-d19677f8ec19"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc980696-2005-45fa-9bb5-32987821d046'>MoveSelectedShapeToBottom</a></td><td style='width:75%' ><p><a name="dc980696-2005-45fa-9bb5-32987821d046"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c94df473-cd53-4e15-853e-153640d36e5e'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p><a name="c94df473-cd53-4e15-853e-153640d36e5e"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56bbce0d-e11c-42fd-9398-4f504450beb8'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p><a name="56bbce0d-e11c-42fd-9398-4f504450beb8"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4ec21c4-5124-46db-8aa8-7173a42db00f'>MoveSelectedShapeForwards</a></td><td style='width:75%' class='def'><p><a name="e4ec21c4-5124-46db-8aa8-7173a42db00f"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5425f5e-b555-413b-a168-154c95fab896'>AddShape</a></td><td style='width:75%' ><p><a name="d5425f5e-b555-413b-a168-154c95fab896"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="a457eba1-4702-475e-a57b-1336bf2800c1"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32b2389c-27c5-4755-b2c5-3553919b5b54'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p><a name="32b2389c-27c5-4755-b2c5-3553919b5b54"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5351baf-c317-4967-a78c-6e56943d4ecf'>DuplicateSelectedShape</a></td><td style='width:75%' ><p><a name="d5351baf-c317-4967-a78c-6e56943d4ecf"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28f83a20-7adc-4219-88e6-8768d6414071'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="28f83a20-7adc-4219-88e6-8768d6414071"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e5775cd-a666-4a9f-961c-38f01b8f5819'>SelectShape</a></td><td style='width:75%' ><p><a name="7e5775cd-a666-4a9f-961c-38f01b8f5819"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="91083ed3-7e3e-475c-8f46-6b015f9b3407"></a>
The <code>KimonoShape</code> to select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a44f5496-c5af-4f2f-ba5a-b75922081ea1'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="a44f5496-c5af-4f2f-ba5a-b75922081ea1"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80c60915-3bfc-4e6a-b1e9-78bca5610dda'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p><a name="80c60915-3bfc-4e6a-b1e9-78bca5610dda"></a></p>

<h3>GroupUngroupSelectedShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd2c40f7-932e-4a9f-b813-06e538fc36fc'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="fd2c40f7-932e-4a9f-b813-06e538fc36fc"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3314139-6e41-4231-9b7a-736337297d2c'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="e3314139-6e41-4231-9b7a-736337297d2c"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#197f913e-4ea0-414a-be11-b7a5f0ad4d3f'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="197f913e-4ea0-414a-be11-b7a5f0ad4d3f"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4899a8e5-ca5f-4232-abd1-83be97a95485'>BuildCsharpToCanvasMethod</a></td><td style='width:75%' ><p><a name="4899a8e5-ca5f-4232-abd1-83be97a95485"></a></p>

<h3>BuildCsharpToCanvasMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Build the method to draw into a specific SkiaSharp Canvas in C# source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d92202f2-53f7-4c70-866b-ae0e5d71e7e4"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the method.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4816ce7c-79dd-4c88-8dcc-d3d11440de55'>BuildCsharpToSkiaDataMethod</a></td><td style='width:75%' class='def'><p><a name="4816ce7c-79dd-4c88-8dcc-d3d11440de55"></a></p>

<h3>BuildCsharpToSkiaDataMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to SkiaSharp data (<code>SKData</code>).</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e7707e65-98d8-454d-9274-22e9edf14bc4"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Sketch as <code>SKData</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6160d696-7ce9-4384-8690-9a4d3a397b4d'>BuildCsharpToBitmapImage</a></td><td style='width:75%' ><p><a name="6160d696-7ce9-4384-8690-9a4d3a397b4d"></a></p>

<h3>BuildCsharpToBitmapImage (KimonoCore.CodeOutputOS)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to OS specific bitmap image format.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="3f3d4156-77a0-47bf-ae9d-43ed5b3a013e"></a>
Output os.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Sketch as a platform specific image.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#298fc57b-2f63-4996-8691-05ecf70672aa'>BuildCSharpCrossPlatformToImage</a></td><td style='width:75%' class='def'><p><a name="298fc57b-2f63-4996-8691-05ecf70672aa"></a></p>

<h3>BuildCSharpCrossPlatformToImage (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# ToImage method for Cross Platform image support.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="38adefc0-edd1-49a7-83aa-68cd4e6a72f1"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Conditionally compiled code to support all of the different image types.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dbba232-a0d4-4ccb-a4fd-63e1b11b6179'>ToCSharp</a></td><td style='width:75%' ><p><a name="2dbba232-a0d4-4ccb-a4fd-63e1b11b6179"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="4d777796-8539-4946-b8ce-75136544c5bf"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c805ed0b-f4c4-411b-925a-d34802fc425f'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="c805ed0b-f4c4-411b-925a-d34802fc425f"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="15e27ecf-edd4-4dd4-b7ea-bc3f1b8942b9"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="d7cf0e7f-ad0a-4e92-8d77-1755dea459e8"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0566c92-faf0-4043-b818-ade95dcb104e'>PortfolioSketchMethods</a></td><td style='width:75%' ><p><a name="b0566c92-faf0-4043-b818-ade95dcb104e"></a></p>

<h3>PortfolioSketchMethods (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary, System.String@, System.String@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the methods that a portfolio will use to draw the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="be7332f1-24e1-4542-b5f1-dc795f06db8f"></a>
The <code>CodeOutputOS</code> to generate code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="d24948c7-7aca-4c2b-8476-842461d94dc0"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>privateMethodsCode</td><td style='width:75%' ><p><a name="82e4e171-9306-4784-9d90-d66862cce077"></a>
The private methods required by this sketch.</p>
</td></tr><tr><td style='width:25%' class='term'>publicMethodsCode</td><td style='width:75%' class='def'><p><a name="0cfe32dd-6376-486e-bedf-dd2308b88a7f"></a>
The public methods required by this sketch.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e7b8533-b5e4-4daf-b6c2-4e81f5737bf3'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="6e7b8533-b5e4-4daf-b6c2-4e81f5737bf3"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0faf8094-917a-41f8-82b8-b40480ef6767"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#822b103e-64e1-4dfb-96cb-2b862058a200'>ToCSharpKimono</a></td><td style='width:75%' ><p><a name="822b103e-64e1-4dfb-96cb-2b862058a200"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="e9c9e905-c17d-4b33-98b3-4f0eb7fef3bd"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="3c0b7217-ea26-475a-b137-9cb63e0702cd"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="eac1acb7-8e67-497d-82e6-288f7486b796"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83e7176c-c8ce-428a-b690-ac05c5df2846'>ToCode</a></td><td style='width:75%' class='def'><p><a name="83e7176c-c8ce-428a-b690-ac05c5df2846"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d9c893a4-fe21-45af-bb65-7bc48803466c"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="279b10e2-4f70-4ce9-bad7-f53d90776629"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9281614e-d37f-4d28-af55-1ed0ac90afef"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#623d5a44-3721-41fa-b003-1da3558ac3ae'>RelinkShape</a></td><td style='width:75%' ><p><a name="623d5a44-3721-41fa-b003-1da3558ac3ae"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="7f188962-e362-4769-96c5-a2fc4840d199"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75cf27b3-cab8-46a0-955d-67d717c66cfe'>Clone</a></td><td style='width:75%' class='def'><p><a name="75cf27b3-cab8-46a0-955d-67d717c66cfe"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f52b5b21-768a-4113-95d4-b5c484245d6e'>ToolDown</a></td><td style='width:75%' ><p><a name="f52b5b21-768a-4113-95d4-b5c484245d6e"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9a96dacf-ce0e-47a2-aad4-0bd16285ff99"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="ff5f610f-0825-40bf-899c-6982cb63df7f"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="0a46c07f-ed3c-4030-9ac1-0b8a3584c7a3"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b18e93c1-a4f8-4e1b-9a9a-34a7a4f755c5'>ToolDrag</a></td><td style='width:75%' class='def'><p><a name="b18e93c1-a4f8-4e1b-9a9a-34a7a4f755c5"></a></p>

<h3>ToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handle the user dragging the selected <code>KimonoTool</code> on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="86daa8bd-6bbd-4a9d-88c2-377b6ff38bf8"></a>
The <code>SKPoint</code> representing the new tool position on the Design Surface.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c730056-d0c8-4ce1-9937-a7a30a7f3463'>ToolUp</a></td><td style='width:75%' ><p><a name="2c730056-d0c8-4ce1-9937-a7a30a7f3463"></a></p>

<h3>ToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user lifting the current <code>KimonoTool</code> off of the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e16302fd-32a3-4d58-8681-e24df66c6dc1"></a>
The <code>SKPoint</code> where the user lifted up the tool.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3766cb4a-ce5e-491a-a702-b064b717c8f0'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="3766cb4a-ce5e-491a-a702-b064b717c8f0"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78a73739-a38b-4a62-bdc5-b3ab11b9ba70'>RaiseSketchSizeChanged</a></td><td style='width:75%' ><p><a name="78a73739-a38b-4a62-bdc5-b3ab11b9ba70"></a></p>

<h3>RaiseSketchSizeChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a4f5cc3-fe43-4bfd-8eff-a22628550b1f'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p><a name="2a4f5cc3-fe43-4bfd-8eff-a22628550b1f"></a></p>

<h3>RaiseSketchModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0e77337-7534-4676-884c-295446d7721c'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' ><p><a name="a0e77337-7534-4676-884c-295446d7721c"></a></p>

<h3>RaiseImageBufferNeedsRefresh ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the image buffer needs refresh event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81f6497b-94a1-41c4-aebc-808ca1b5c7c4'>RaiseSelectedShapeModified</a></td><td style='width:75%' class='def'><p><a name="81f6497b-94a1-41c4-aebc-808ca1b5c7c4"></a></p>

<h3>RaiseSelectedShapeModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d13e3563-6420-4555-a93c-2bedff9ddcb4'>RaiseSelectionChanged</a></td><td style='width:75%' ><p><a name="d13e3563-6420-4555-a93c-2bedff9ddcb4"></a></p>

<h3>RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="7b19b980-fa26-42a4-a4d0-c6b06de52463"></a>
Selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf42b5a9-69ba-45ba-a6a4-e0fb0e909616'>RaiseToolChanged</a></td><td style='width:75%' class='def'><p><a name="cf42b5a9-69ba-45ba-a6a4-e0fb0e909616"></a></p>

<h3>RaiseToolChanged (KimonoCore.KimonoTool)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the tool changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="c085d75d-bdf3-4e47-a0c4-6a91952949ed"></a>
The new <code>KimonoTool</code> that has been selected.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#55d49c99-3784-4664-aff1-cd85e6d6025c'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="55d49c99-3784-4664-aff1-cd85e6d6025c"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66bc57ce-bafd-46cc-996b-dbbb9597e7f1'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="66bc57ce-bafd-46cc-996b-dbbb9597e7f1"></a></p>

<h3>SketchSizeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#840fc870-f272-4194-9fcd-2f2466766c91'>SketchModified</a></td><td style='width:75%' ><p><a name="840fc870-f272-4194-9fcd-2f2466766c91"></a></p>

<h3>SketchModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#588d438a-1e78-472d-9c23-d53172d842aa'>ImageBufferNeedsRefresh</a></td><td style='width:75%' class='def'><p><a name="588d438a-1e78-472d-9c23-d53172d842aa"></a></p>

<h3>ImageBufferNeedsRefresh</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when image buffer needs refresh.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be529ca2-02b3-4014-933f-4f4436c70d74'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="be529ca2-02b3-4014-933f-4f4436c70d74"></a></p>

<h3>SelectedShapeModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ebaa54e-9ffe-4406-8471-4656d9e62b5a'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="5ebaa54e-9ffe-4406-8471-4656d9e62b5a"></a></p>

<h3>SelectionChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7691cdd3-bfaf-4bdc-867d-dba59e8fcbeb'>ToolChanged</a></td><td style='width:75%' ><p><a name="7691cdd3-bfaf-4bdc-867d-dba59e8fcbeb"></a></p>

<h3>ToolChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when tool changed.</p>
</td></tr></table></p>


---

<a name="13f774fa-411f-4ba9-9782-4fc905cb27cf"></a>
##KimonoTool

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the current tool that is active in a `KimonoSketch` that the user can use to create or modify a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0d97af44-b1e1-456b-adc9-ba7c19e4bd7e'>Cursor</a></td><td style='width:75%' ><p><a name="0d97af44-b1e1-456b-adc9-ba7c19e4bd7e"></a>
<b>Cursor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Cursor tool to modify an existing <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f65ecef-bce8-4585-b0aa-9fca42af6b58'>Line</a></td><td style='width:75%' class='def'><p><a name="2f65ecef-bce8-4585-b0aa-9fca42af6b58"></a>
<b>Line</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Line tool to add a new <code>KimonoShapeLine</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd004946-4b8c-4b45-a03f-d13e689ded99'>Arrow</a></td><td style='width:75%' ><p><a name="fd004946-4b8c-4b45-a03f-d13e689ded99"></a>
<b>Arrow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Arrow tool to add a new <code>KimonoShapeArrow</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#628fd09f-f280-4f11-ad9c-5dc3d84ad419'>Rectangle</a></td><td style='width:75%' class='def'><p><a name="628fd09f-f280-4f11-ad9c-5dc3d84ad419"></a>
<b>Rectangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Rectangle tool to add a new <code>KimonoShapeRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f57081db-0d3e-40de-b4de-bacb0f72b6ad'>Oval</a></td><td style='width:75%' ><p><a name="f57081db-0d3e-40de-b4de-bacb0f72b6ad"></a>
<b>Oval</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Oval tool to add a new <code>KimonoShapeOval</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc8c8d35-09d0-40f9-a945-2ca0f8390ec2'>RoundRect</a></td><td style='width:75%' class='def'><p><a name="fc8c8d35-09d0-40f9-a945-2ca0f8390ec2"></a>
<b>RoundRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Round Rect tool to add a new <code>KimonoShapeRoundRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#705517ca-9a63-49e7-80a8-4af35dc2d738'>Star</a></td><td style='width:75%' ><p><a name="705517ca-9a63-49e7-80a8-4af35dc2d738"></a>
<b>Star</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Star tool to add a new <code>KimonoShapeStar</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d83f822-76fe-4cb5-855c-b8438cc26e21'>Polygon</a></td><td style='width:75%' class='def'><p><a name="3d83f822-76fe-4cb5-855c-b8438cc26e21"></a>
<b>Polygon</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Polygon tool to add a new <code>KimonoShapePolygon</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d6e76a4-2e63-4f94-a9f6-e6a15712205a'>Triangle</a></td><td style='width:75%' ><p><a name="3d6e76a4-2e63-4f94-a9f6-e6a15712205a"></a>
<b>Triangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Triangle tool to add a new <code>KimonoShapeTriangle</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#415ac2e2-9e8f-45c1-9f32-6906654f6dc0'>Vector</a></td><td style='width:75%' class='def'><p><a name="415ac2e2-9e8f-45c1-9f32-6906654f6dc0"></a>
<b>Vector</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Vector tool to add a new <code>KimonoShapeVector</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b90d856c-9341-4b3a-becb-40e8ee169ef3'>Bezier</a></td><td style='width:75%' ><p><a name="b90d856c-9341-4b3a-becb-40e8ee169ef3"></a>
<b>Bezier</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Bezier tool to add a new <code>KimonoShapeBezier</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#669c01ce-e9a3-4e4d-9e27-fc3fa4574baa'>Text</a></td><td style='width:75%' class='def'><p><a name="669c01ce-e9a3-4e4d-9e27-fc3fa4574baa"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Text tool to add a new <code>KimonoShapeText</code> to the sketch.</p>
</td></tr></table></p>


---

<a name="58d8d244-c066-474a-83b1-9e33c5ed0ef4"></a>
##Kimono

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Holds a set of shared utilities that are used across the Kimono classes.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b7683fc6-0755-48db-84e3-31e534990434'>CharIsNumber</a></td><td style='width:75%' ><p><a name="b7683fc6-0755-48db-84e3-31e534990434"></a></p>

<h3>CharIsNumber (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a number character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="8448d483-3611-49a9-8e5d-85a9ebba6e11"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is character is a number, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26c8bbc2-6bff-4545-9eac-33a7ccfbf1ab'>CharIsLetter</a></td><td style='width:75%' class='def'><p><a name="26c8bbc2-6bff-4545-9eac-33a7ccfbf1ab"></a></p>

<h3>CharIsLetter (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a letter character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="fb0afe85-791c-440e-868d-e0289922916f"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is letter was chared, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b95a382e-c786-4423-922c-39b71f4a57b5'>IncrementName</a></td><td style='width:75%' ><p><a name="b95a382e-c786-4423-922c-39b71f4a57b5"></a></p>

<h3>IncrementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increments the name by appending a number to the end or incrementing an existing number count.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="fda944dd-86b5-499e-9d78-0439b479a748"></a>
Name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbd9f5c8-29a7-409c-b49f-dbec1c0d6fe8'>CloneSKPoint</a></td><td style='width:75%' class='def'><p><a name="dbd9f5c8-29a7-409c-b49f-dbec1c0d6fe8"></a></p>

<h3>CloneSKPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPoint</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="164aeaf6-a87c-4651-8466-4601ed62d9b2"></a>
The <code>SKPoint</code> to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A clone of the given point.</p>
</td></tr></table></p>


---

<a name="53365d40-e064-46c0-8d20-da5a77494e91"></a>
##PortfolioEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Portfolio event delegate.

---

<a name="20667756-501c-4610-afcd-5cc7c8227952"></a>
##SketchEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Sketch event delegate.

---

<a name="d7814593-3999-4096-8716-d1f25a235129"></a>
##StyleEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Style event delegate.

---

<a name="df52ba84-b540-495a-888c-acd50217eef4"></a>
##ShapeEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Shape event delegate.

---

<a name="d42307cb-79b8-4e88-9325-31a17e3753bb"></a>
##ToolEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Tool event delegate.

---

<a name="8fcbe298-8d42-4b20-899d-361fb024e55c"></a>
##SkiaPointEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Skia point event delegate.

---

<a name="7c38c8af-3498-4f0c-8dad-086392ca9a59"></a>
##GroupEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Group event delegate.

---

<a name="5475946d-eac7-4f96-bf74-ce5351b3e2ac"></a>
##ColorEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Color event delegate.

---

<a name="229b6149-4e0b-450b-b4a1-3d25dcb0ce61"></a>
##SkiaColorEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Skia color event delegate.

---

<a name="ec1e98a5-60fa-41bf-8ff2-88defa2c79d3"></a>
##GradientEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Gradient event delegate.

---

<a name="39881353-ac83-470e-b6a2-4fc0746e4b92"></a>
##HandleEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Handle event delegate.

---

<a name="a5fa5658-2f3a-46f2-901a-929498c86cfe"></a>
##PropertyEventDelegate

###Namespace

[KimonoCore.Kimono](#c0d3413a-22e0-4adb-b101-cb672184488c)

###Added In API Version

01.00.00

###Summary

Property event delegate.

---

<a name="cbbde974-6690-4319-8de7-59f9612c1414"></a>
##KimonoPortfolio

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

A Kimono Portfolio holds a collection of `KimonoSketches`, `KimonoStyles` and `KimonoColors` that define a given Kimono Designer project.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6e8c58a0-6e5f-4000-a9a8-bc7a985f052f'>_selectedSketch</a></td><td style='width:75%' ><p><a name="6e8c58a0-6e5f-4000-a9a8-bc7a985f052f"></a>
<b>_selectedSketch</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61fefa27-7e56-41c5-a6a2-660a4fd384cc'>NewSketchNumber</a></td><td style='width:75%' class='def'><p><a name="61fefa27-7e56-41c5-a6a2-660a4fd384cc"></a>
<b>NewSketchNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the number that will be assigned to the next new <code>KimonoSketch</code> created in this portfolio.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b7f194f3-1d1b-4058-84f4-472f657cad6e'>UniqueID</a></td><td style='width:75%' ><p><a name="b7f194f3-1d1b-4058-84f4-472f657cad6e"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07f75339-83b0-482b-9f42-6b9f7a4b064c'>ElementName</a></td><td style='width:75%' class='def'><p><a name="07f75339-83b0-482b-9f42-6b9f7a4b064c"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39a2858c-f9e9-4527-aeb4-a535340f0a3e'>Name</a></td><td style='width:75%' ><p><a name="39a2858c-f9e9-4527-aeb4-a535340f0a3e"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0043056-23f7-41e4-899c-335c4036eff1'>Namespace</a></td><td style='width:75%' class='def'><p><a name="c0043056-23f7-41e4-899c-335c4036eff1"></a></p>

<h3>Namespace</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the namespace.</p>

<h4>Return Value</h4>

<p>The namespace.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31c9787f-faac-4e9e-acd8-1da6628da7e0'>Author</a></td><td style='width:75%' ><p><a name="31c9787f-faac-4e9e-acd8-1da6628da7e0"></a></p>

<h3>Author</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the author.</p>

<h4>Return Value</h4>

<p>The author.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fdc419f3-d9bd-40b9-9371-6edc6ae11fd7'>Copyright</a></td><td style='width:75%' class='def'><p><a name="fdc419f3-d9bd-40b9-9371-6edc6ae11fd7"></a></p>

<h3>Copyright</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the copyright.</p>

<h4>Return Value</h4>

<p>The copyright.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4252e64d-0552-43e3-a643-0eb397643f90'>Sketches</a></td><td style='width:75%' ><p><a name="4252e64d-0552-43e3-a643-0eb397643f90"></a></p>

<h3>Sketches</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the sketches.</p>

<h4>Return Value</h4>

<p>The sketches.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfa5382d-5522-4d7c-9aa4-e87888fe95b8'>Styles</a></td><td style='width:75%' class='def'><p><a name="bfa5382d-5522-4d7c-9aa4-e87888fe95b8"></a></p>

<h3>Styles</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the styles.</p>

<h4>Return Value</h4>

<p>The styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f01a5a00-d00f-4158-b202-e5850f8bc125'>Colors</a></td><td style='width:75%' ><p><a name="f01a5a00-d00f-4158-b202-e5850f8bc125"></a></p>

<h3>Colors</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the colors.</p>

<h4>Return Value</h4>

<p>The colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42d5cf47-fa86-4b98-9163-357c1ce92ca7'>Gradients</a></td><td style='width:75%' class='def'><p><a name="42d5cf47-fa86-4b98-9163-357c1ce92ca7"></a></p>

<h3>Gradients</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the gradients.</p>

<h4>Return Value</h4>

<p>The gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52f625a0-5352-4e53-8f26-fbd32364845b'>Properties</a></td><td style='width:75%' ><p><a name="52f625a0-5352-4e53-8f26-fbd32364845b"></a></p>

<h3>Properties</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the properties.</p>

<h4>Return Value</h4>

<p>The properties.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c0e1be1-f876-4a24-9bdf-3db96dfcbde9'>SelectedSketch</a></td><td style='width:75%' class='def'><p><a name="3c0e1be1-f876-4a24-9bdf-3db96dfcbde9"></a></p>

<h3>SelectedSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected sketch.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eecd1889-5754-4e1e-851c-022103e562e6'>KimonoPortfolio</a></td><td style='width:75%' ><p><a name="eecd1889-5754-4e1e-851c-022103e562e6"></a></p>

<h3>KimonoPortfolio (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cbbde974-6690-4319-8de7-59f9612c1414">KimonoPortfolio</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p><a name="13f21034-719b-4c20-b509-fac2d7db6282"></a>
If <code>true</code>, the new instance will be initialized with the default values.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><code>initialize</code> is set to <code>false</code> when a clone is being made of given <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a891e182-aab1-41c0-9faa-5cbaaa29dd0b'>Initialize</a></td><td style='width:75%' class='def'><p><a name="a891e182-aab1-41c0-9faa-5cbaaa29dd0b"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2e1bce4-1db3-4745-b3e8-3b4e80209b0c'>FindSketch</a></td><td style='width:75%' ><p><a name="c2e1bce4-1db3-4745-b3e8-3b4e80209b0c"></a></p>

<h3>FindSketch (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoSketch</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="ec95e2f5-8c49-44c9-bc09-b12d4fc1a359"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoSketch</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c30becc2-adfc-4ca5-8866-b7d6fbd72cc1'>FindColor</a></td><td style='width:75%' class='def'><p><a name="c30becc2-adfc-4ca5-8866-b7d6fbd72cc1"></a></p>

<h3>FindColor (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoColor</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="e0c53a2a-e9c7-4f5f-9cac-a7b06b3e9417"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoColor</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9e91223-98c8-4748-99cd-82063374eb09'>FindProperty</a></td><td style='width:75%' ><p><a name="b9e91223-98c8-4748-99cd-82063374eb09"></a></p>

<h3>FindProperty (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoProperty</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="f858f81c-4af4-4052-9fd0-7be87461dbf7"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoProperty</code> if founs, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf995a34-946f-4dad-94e9-e9ef7b627380'>FindGradient</a></td><td style='width:75%' class='def'><p><a name="cf995a34-946f-4dad-94e9-e9ef7b627380"></a></p>

<h3>FindGradient (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the gradient by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="d26f2a50-10a8-42fb-b8ba-e57547b59566"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoGradient</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#435f2ce9-e473-4085-bbd5-5a51ef14f953'>FindStyle</a></td><td style='width:75%' ><p><a name="435f2ce9-e473-4085-bbd5-5a51ef14f953"></a></p>

<h3>FindStyle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoStyle</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="7d04ea91-ebac-4924-9c7a-ea01a48d0cc8"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e9e93cf-99ee-4ff8-be59-da3e88632a23'>AddNewSketch</a></td><td style='width:75%' class='def'><p><a name="9e9e93cf-99ee-4ff8-be59-da3e88632a23"></a></p>

<h3>AddNewSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoSketch</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d2b621a-9d1c-4888-bdd2-a81c5778d3f1'>DuplicateSelectedSketch</a></td><td style='width:75%' ><p><a name="9d2b621a-9d1c-4888-bdd2-a81c5778d3f1"></a></p>

<h3>DuplicateSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af6b8326-b0db-4615-a387-d247fc3085ba'>DeleteSelectedSketch</a></td><td style='width:75%' class='def'><p><a name="af6b8326-b0db-4615-a387-d247fc3085ba"></a></p>

<h3>DeleteSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd0beebc-a3bf-44c6-b461-aef078358633'>AddNewGradient</a></td><td style='width:75%' ><p><a name="dd0beebc-a3bf-44c6-b461-aef078358633"></a></p>

<h3>AddNewGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the new gradient.</p>

<h4>Returns</h4>

<p>The new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16a29676-b137-4827-bf76-f628dbe7bb0f'>AddNewColor</a></td><td style='width:75%' class='def'><p><a name="16a29676-b137-4827-bf76-f628dbe7bb0f"></a></p>

<h3>AddNewColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio.</p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6de734f0-d9a5-4fbc-b2fb-a1f89829f12b'>AddNewColor</a></td><td style='width:75%' ><p><a name="6de734f0-d9a5-4fbc-b2fb-a1f89829f12b"></a></p>

<h3>AddNewColor (SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio based off of a given <code>SKColor</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="df7bcd78-9668-4b89-a4b5-c6ee845722a1"></a>
Base color.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afa98df0-d343-4ef5-8905-51948264574c'>AddPropertyBoolean</a></td><td style='width:75%' class='def'><p><a name="afa98df0-d343-4ef5-8905-51948264574c"></a></p>

<h3>AddPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new boolean property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyBoolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5845ecf-546f-419e-858e-b2ab1431ca1f'>AddPropertyColor</a></td><td style='width:75%' ><p><a name="f5845ecf-546f-419e-858e-b2ab1431ca1f"></a></p>

<h3>AddPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new color property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e895625d-3473-4aba-9deb-b2d4c9085ea4'>AddPropertyGradient</a></td><td style='width:75%' class='def'><p><a name="e895625d-3473-4aba-9deb-b2d4c9085ea4"></a></p>

<h3>AddPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new gradient property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66c63c3f-a36d-419b-abe7-299c8cec43d7'>AddPropertyNumber</a></td><td style='width:75%' ><p><a name="66c63c3f-a36d-419b-abe7-299c8cec43d7"></a></p>

<h3>AddPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new number property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyNumber</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34fb2765-3d33-4a33-b92b-ac2ac3c4831b'>AddPropertyRect</a></td><td style='width:75%' class='def'><p><a name="34fb2765-3d33-4a33-b92b-ac2ac3c4831b"></a></p>

<h3>AddPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new rect property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2eeb58ac-91c8-47ae-87cf-a318bce7c6f5'>AddPropertyStyle</a></td><td style='width:75%' ><p><a name="2eeb58ac-91c8-47ae-87cf-a318bce7c6f5"></a></p>

<h3>AddPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new style property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdd55631-273f-4446-9a18-84db36341a59'>AddPropertyText</a></td><td style='width:75%' class='def'><p><a name="cdd55631-273f-4446-9a18-84db36341a59"></a></p>

<h3>AddPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new text property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfe18996-d2c1-4285-a978-cecfe462fb2c'>AddNewProperty</a></td><td style='width:75%' ><p><a name="dfe18996-d2c1-4285-a978-cecfe462fb2c"></a></p>

<h3>AddNewProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoProperty</code> to this portfolio</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="9d3a9317-db3b-41d6-a19f-b285af4aadf0"></a>
The <code>KimonoProperty</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5254e98c-a1e6-4abf-bda7-ee4e6f238880'>DuplicateColor</a></td><td style='width:75%' class='def'><p><a name="5254e98c-a1e6-4abf-bda7-ee4e6f238880"></a></p>

<h3>DuplicateColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoColor</code> and adds it to the portfolio's collection of colors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="c11bdd60-ceb4-440f-affd-7f966993008b"></a>
The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62fbab0b-8c88-4ace-9145-b0bde7164361'>DuplicateProperty</a></td><td style='width:75%' ><p><a name="62fbab0b-8c88-4ace-9145-b0bde7164361"></a></p>

<h3>DuplicateProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="2a3b6c85-77fa-4fa8-a1d8-363eb865fb78"></a>
The <code>KimonoProperty</code> to duplicate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aab96bd3-d352-454e-845a-a656bfbc70e1'>DuplicateGradient</a></td><td style='width:75%' class='def'><p><a name="aab96bd3-d352-454e-845a-a656bfbc70e1"></a></p>

<h3>DuplicateGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="ced25e24-639e-4643-96c9-4e25332cb4f9"></a>
The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e74eb9c7-bbd6-495c-9173-eb260043bab8'>DeleteColor</a></td><td style='width:75%' ><p><a name="e74eb9c7-bbd6-495c-9173-eb260043bab8"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="5558fc0e-8867-40ef-a7f9-29062aeb7ff1"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa34e838-c38f-47fa-97f9-33dcdde9b16a'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="fa34e838-c38f-47fa-97f9-33dcdde9b16a"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="49727d84-aaba-4ef3-98e8-1f5ec2b8281a"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f44922a7-5ee4-4f37-84be-c15ac5901869'>DeleteProperty</a></td><td style='width:75%' ><p><a name="f44922a7-5ee4-4f37-84be-c15ac5901869"></a></p>

<h3>DeleteProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="b65d5ce4-976f-473f-8551-d50c4deeb8b8"></a>
The <code>KimonoProperty</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd482d2a-565d-4e66-9168-bcdde53a5e6f'>AddNewStyle</a></td><td style='width:75%' class='def'><p><a name="fd482d2a-565d-4e66-9168-bcdde53a5e6f"></a></p>

<h3>AddNewStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoStyle</code> to the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdb4880e-52d3-490c-a94b-38fb87e04eee'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="bdb4880e-52d3-490c-a94b-38fb87e04eee"></a></p>

<h3>DuplicateStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoStyle</code> adding it to the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="1dfbec5e-cc8b-49c0-8a79-272fde110862"></a>
The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#432bc640-7e59-4b59-bb95-9394762e924a'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' class='def'><p><a name="432bc640-7e59-4b59-bb95-9394762e924a"></a></p>

<h3>ConvertSelectedShapeToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Takes the custom <code>KimonoStyle</code> of the currently selected <code>KimonoShape</code>, converts it to a named, shared style and adds it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#271763c7-9b0a-4bba-95bd-b52061d8e4a7'>DeleteStyle</a></td><td style='width:75%' ><p><a name="271763c7-9b0a-4bba-95bd-b52061d8e4a7"></a></p>

<h3>DeleteStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoStyle</code> from the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="d87c8ec2-d527-4c09-9e17-2f8da7c8a1b3"></a>
Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83aad7a3-d3fc-4004-bc57-4856509ce2b5'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="83aad7a3-d3fc-4004-bc57-4856509ce2b5"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e24be3f1-b1e0-411a-988c-520d6e12f353'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="e24be3f1-b1e0-411a-988c-520d6e12f353"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#171eb25b-3458-458c-9146-ccdcd54f8a42'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="171eb25b-3458-458c-9146-ccdcd54f8a42"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f71fd26-4c9a-4e19-96ce-21d576dd851c'>ToCSharp</a></td><td style='width:75%' ><p><a name="5f71fd26-4c9a-4e19-96ce-21d576dd851c"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2b98b413-61bf-4bc5-82fb-93dbab2d0fdf"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13caafa6-edbd-4ab5-80dd-13f18d6a0e43'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="13caafa6-edbd-4ab5-80dd-13f18d6a0e43"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="6e6006c2-2192-4668-8d20-492d9add4188"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="f13894de-63d5-4d31-9b0a-d6c55c645960"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9cccf77b-c4d0-4df8-9fe4-826d6c00316e'>ToCSharp</a></td><td style='width:75%' ><p><a name="9cccf77b-c4d0-4df8-9fe4-826d6c00316e"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="16e6faab-e27c-4523-9f57-2b8ededdb305"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae77503f-8c59-4a00-ac57-8e22de0d8216'>ToCSharpKimono</a></td><td style='width:75%' class='def'><p><a name="ae77503f-8c59-4a00-ac57-8e22de0d8216"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="204e8557-2523-441b-b972-9e739f6c9820"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="81e16f59-fefe-4065-9000-38268c652e14"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="09a63d79-0bad-41df-81db-5dbed45401d8"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17c7864e-ef29-4cf2-929e-2abe827672fa'>ToCode</a></td><td style='width:75%' ><p><a name="17c7864e-ef29-4cf2-929e-2abe827672fa"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="23d2030d-ffe4-4857-893c-d84761b905ff"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="7230e81c-9b94-45f8-b120-b20134f51f3a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c29adc78-310c-4c9f-b24b-e61a2a75728e"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc8323e5-f19f-4842-a93d-6aab7417ceca'>RelinkColors</a></td><td style='width:75%' class='def'><p><a name="dc8323e5-f19f-4842-a93d-6aab7417ceca"></a></p>

<h3>RelinkColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the colors after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42f3b331-2625-4aee-a47c-0e0581042a18'>RelinkGradient</a></td><td style='width:75%' ><p><a name="42f3b331-2625-4aee-a47c-0e0581042a18"></a></p>

<h3>RelinkGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the gradient after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="2a0321a0-6bbe-4745-bae5-e57c28a5ca14"></a>
The <code>KimonoGradient</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f802482f-3bce-42f9-9b8a-f928a8e30d93'>RelinkStyle</a></td><td style='width:75%' class='def'><p><a name="f802482f-3bce-42f9-9b8a-f928a8e30d93"></a></p>

<h3>RelinkStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoStyle</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="46aa02f0-18ea-444e-bea0-a0ab1b4932a3"></a>
The <code>KimonoStyle</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65027778-3ec9-4380-a1e2-93be4a79f2c5'>RelinkShape</a></td><td style='width:75%' ><p><a name="65027778-3ec9-4380-a1e2-93be4a79f2c5"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoShape</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="d8eb57dc-7151-445a-853c-3e3890d909a9"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f83f610a-2235-40b6-b02a-1bc803483139'>RelinkSketch</a></td><td style='width:75%' class='def'><p><a name="f83f610a-2235-40b6-b02a-1bc803483139"></a></p>

<h3>RelinkSketch (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoSketch</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="4894b58c-0c9e-4e96-83cb-e3fda55b30ab"></a>
The <code>KimonoSketch</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fced440-6b95-4df2-a383-0b5f19069b37'>Clone</a></td><td style='width:75%' ><p><a name="5fced440-6b95-4df2-a383-0b5f19069b37"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6b9171e-601a-47b0-bfd5-652e24ec46c7'>RaisePropertyModified</a></td><td style='width:75%' class='def'><p><a name="e6b9171e-601a-47b0-bfd5-652e24ec46c7"></a></p>

<h3>RaisePropertyModified (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the property modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="4d785897-8586-466e-b9fb-e45402dbaf50"></a>
The <code>KimonoProperty</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b209c0d-510b-4571-bcd3-fda5f2aa9d42'>RaiseGradientsModified</a></td><td style='width:75%' ><p><a name="6b209c0d-510b-4571-bcd3-fda5f2aa9d42"></a></p>

<h3>RaiseGradientsModified (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradients modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="5253a2d4-e6f2-4fd4-a6bb-e8f883959d2f"></a>
The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc01b919-6c7b-417f-99ff-3f1a9d0644cc'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="dc01b919-6c7b-417f-99ff-3f1a9d0644cc"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac8ccef8-7466-45f3-b253-782970e5df97'>RaiseSketchesModified</a></td><td style='width:75%' ><p><a name="ac8ccef8-7466-45f3-b253-782970e5df97"></a></p>

<h3>RaiseSketchesModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e5baa30-fd9b-4090-97b6-0409a0b2bb64'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' class='def'><p><a name="9e5baa30-fd9b-4090-97b6-0409a0b2bb64"></a></p>

<h3>RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch will change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="3d9e9ad1-22d1-4a28-a008-2eb00e9718b1"></a>
The <code>KimonoSketch</code> that will change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a76ec79-8c19-4c54-bf27-0ecffac13621'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' ><p><a name="3a76ec79-8c19-4c54-bf27-0ecffac13621"></a></p>

<h3>RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch did change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="85cffea7-79b0-4b85-bdb1-cdfe4cce935b"></a>
The <code>KimonoSketch</code> that did change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01145e26-9cfa-4f57-97cd-72dac61bd468'>RaiseStylesModified</a></td><td style='width:75%' class='def'><p><a name="01145e26-9cfa-4f57-97cd-72dac61bd468"></a></p>

<h3>RaiseStylesModified (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the styles modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="a8ca6784-7d82-48b4-8f68-b3904ec9514b"></a>
The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1814a6d4-b1ca-43e1-9b31-7c71678f75c6'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p><a name="1814a6d4-b1ca-43e1-9b31-7c71678f75c6"></a></p>

<h3>RaiseSelectedShapeChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="5fd50854-7fb4-4e4a-948c-64083afb438e"></a>
The new <code>KimonoShape</code> that was selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01c39cd0-19a3-4f6b-9455-1ca2e8703887'>RaiseColorsModified</a></td><td style='width:75%' class='def'><p><a name="01c39cd0-19a3-4f6b-9455-1ca2e8703887"></a></p>

<h3>RaiseColorsModified (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the colors modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="63bcf2c7-beb1-4904-88e4-b423c21f1379"></a>
The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#081ff666-71ea-41b2-94df-fb8acdaa6c0c'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="081ff666-71ea-41b2-94df-fb8acdaa6c0c"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dad0a94a-1cbe-4c47-b9d3-f64913c128ca'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="dad0a94a-1cbe-4c47-b9d3-f64913c128ca"></a></p>

<h3>SketchesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbd846fa-e7ef-49ca-a677-11b6a22f48b0'>SelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="fbd846fa-e7ef-49ca-a677-11b6a22f48b0"></a></p>

<h3>SelectedSketchWillChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch will change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b33231ac-ae6c-4fe2-bb15-325c4b657c10'>SelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="b33231ac-ae6c-4fe2-bb15-325c4b657c10"></a></p>

<h3>SelectedSketchDidChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4676e237-8f6b-44c5-9032-004e4fea6f4f'>StylesModified</a></td><td style='width:75%' ><p><a name="4676e237-8f6b-44c5-9032-004e4fea6f4f"></a></p>

<h3>StylesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when styles collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6740ad0f-9168-4d41-a937-0bd88e055ff7'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p><a name="6740ad0f-9168-4d41-a937-0bd88e055ff7"></a></p>

<h3>SelectedShapeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dacf0db-ca21-4757-8678-ac89be8ba11a'>ColorsModified</a></td><td style='width:75%' ><p><a name="0dacf0db-ca21-4757-8678-ac89be8ba11a"></a></p>

<h3>ColorsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#542edb28-2c0d-44d1-a45e-c27a263bd402'>GradientsModified</a></td><td style='width:75%' class='def'><p><a name="542edb28-2c0d-44d1-a45e-c27a263bd402"></a></p>

<h3>GradientsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abbb9e87-490f-4c48-b958-1b30afc4c98c'>PropertyModified</a></td><td style='width:75%' ><p><a name="abbb9e87-490f-4c48-b958-1b30afc4c98c"></a></p>

<h3>PropertyModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when property collection is modified.</p>
</td></tr></table></p>


---

<a name="b87073a6-0f83-4b21-9071-fc4db608db5a"></a>
##KimonoUndoHandler

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Handles the undo/redo state for a `KimonoDesignSurface`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e3f05c3e-cfa7-4573-b614-06daa4ffb49a'>MaximumUndoPoints</a></td><td style='width:75%' ><p><a name="e3f05c3e-cfa7-4573-b614-06daa4ffb49a"></a></p>

<h3>MaximumUndoPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the maximum undo points.</p>

<h4>Return Value</h4>

<p>The maximum undo points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e26eca26-cd29-4812-9915-0495454f0415'>UndoStack</a></td><td style='width:75%' class='def'><p><a name="e26eca26-cd29-4812-9915-0495454f0415"></a></p>

<h3>UndoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the undo stack.</p>

<h4>Return Value</h4>

<p>The undo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebc5363c-16e2-4393-8027-3b300d89b4e8'>RedoStack</a></td><td style='width:75%' ><p><a name="ebc5363c-16e2-4393-8027-3b300d89b4e8"></a></p>

<h3>RedoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the redo stack.</p>

<h4>Return Value</h4>

<p>The redo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#345db01a-fcfa-4969-83db-a7468c377f4c'>CanUndo</a></td><td style='width:75%' class='def'><p><a name="345db01a-fcfa-4969-83db-a7468c377f4c"></a></p>

<h3>CanUndo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can undo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can undo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#986b4e7f-87b7-4e6a-b190-529816b8bdf9'>CanRedo</a></td><td style='width:75%' ><p><a name="986b4e7f-87b7-4e6a-b190-529816b8bdf9"></a></p>

<h3>CanRedo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can redo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can redo; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a062eecd-5c91-4bcc-aff2-20bb7c06df3e'>KimonoUndoHandler</a></td><td style='width:75%' ><p><a name="a062eecd-5c91-4bcc-aff2-20bb7c06df3e"></a></p>

<h3>KimonoUndoHandler ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b87073a6-0f83-4b21-9071-fc4db608db5a">KimonoUndoHandler</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7dcf8248-3128-4f87-89d0-dfc5c6d442c1'>PushUndoPoint</a></td><td style='width:75%' class='def'><p><a name="7dcf8248-3128-4f87-89d0-dfc5c6d442c1"></a></p>

<h3>PushUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pushes the undo point onto the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="e605dcdb-c7ff-4bcc-b8e9-c8ad3383c636"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#859c3ecd-f194-4e34-8ffc-6368803decdc'>ReplaceLastUndoPoint</a></td><td style='width:75%' ><p><a name="859c3ecd-f194-4e34-8ffc-6368803decdc"></a></p>

<h3>ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Replaces the last undo point with the one being passed in.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="9873728a-452d-4426-ab3b-7ffe9d93c017"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#033d6c78-e260-4859-96e3-db59c1dcd8e9'>PopUndoPoint</a></td><td style='width:75%' class='def'><p><a name="033d6c78-e260-4859-96e3-db59c1dcd8e9"></a></p>

<h3>PopUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the undo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="5813b3e1-c27f-4a0e-b330-72d16d0969f1"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The prior state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70335c8c-39d1-415d-b38f-8ca32dcfe4c4'>PopRedoPoint</a></td><td style='width:75%' ><p><a name="70335c8c-39d1-415d-b38f-8ca32dcfe4c4"></a></p>

<h3>PopRedoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the redo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="fc8b8a27-d9a5-4e4f-9e2c-f7976ec4ca13"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The previous state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4da1f03a-f214-4215-97a6-ea23f6bddbf1'>RaiseUndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="4da1f03a-f214-4215-97a6-ea23f6bddbf1"></a></p>

<h3>RaiseUndoStateChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the undo state changed event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3ba7074d-34f9-4331-9737-826e21af19e4'>UndoStateChanged</a></td><td style='width:75%' ><p><a name="3ba7074d-34f9-4331-9737-826e21af19e4"></a></p>

<h3>UndoStateChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="fc8d1729-30d8-4f99-abd6-2508271c15ad"></a>
##KimonoShape

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the based shape that all other Kimono Shape types will inherit from.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#62609484-5225-4f63-a43a-60d218b75309'>_name</a></td><td style='width:75%' ><p><a name="62609484-5225-4f63-a43a-60d218b75309"></a>
<b>_name</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default name of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7160eed-1485-4e35-8cb3-624877a06d8f'>_style</a></td><td style='width:75%' class='def'><p><a name="e7160eed-1485-4e35-8cb3-624877a06d8f"></a>
<b>_style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default, custom <code>KimonoStyle</code> that is attached to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d518df2e-40b2-4be5-8925-9929689cb3aa'>_visible</a></td><td style='width:75%' ><p><a name="d518df2e-40b2-4be5-8925-9929689cb3aa"></a>
<b>_visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0248a1b7-f721-4fe5-8cf7-8c3610da4c46'>Name</a></td><td style='width:75%' ><p><a name="0248a1b7-f721-4fe5-8cf7-8c3610da4c46"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#901b2c89-170c-4306-8ec8-f456354bd931'>ElementName</a></td><td style='width:75%' class='def'><p><a name="901b2c89-170c-4306-8ec8-f456354bd931"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c82e8e95-a1b5-4909-8536-8fdf0545f0ba'>Style</a></td><td style='width:75%' ><p><a name="c82e8e95-a1b5-4909-8536-8fdf0545f0ba"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> that will be used to draw this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#915a7805-037c-4921-941c-a47cc554b49c'>ControlPoints</a></td><td style='width:75%' class='def'><p><a name="915a7805-037c-4921-941c-a47cc554b49c"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the path of the shape.</p>

<h4>Return Value</h4>

<p>A collection of <code>KimonoHandle</code> objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfdcbd9b-7ddd-44c6-ab47-b3738c70268c'>Visible</a></td><td style='width:75%' ><p><a name="bfdcbd9b-7ddd-44c6-ab47-b3738c70268c"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#fc8d1729-30d8-4f99-abd6-2508271c15ad">KimonoShape</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78539d0b-f68f-40ec-965e-d257fccc8aed'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="78539d0b-f68f-40ec-965e-d257fccc8aed"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#fc8d1729-30d8-4f99-abd6-2508271c15ad">KimonoShape</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>An "Editable Shape" is one that is composed of a set of data points (such as <code>KimonoVector</code> or <code>KimonoBezier</code>) or a group of objects (such as <code>KimonoShapeGroup</code>).</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63bccc34-2762-4244-9dae-0df743eaf32f'>LayerDepth</a></td><td style='width:75%' ><p><a name="63bccc34-2762-4244-9dae-0df743eaf32f"></a></p>

<h3>LayerDepth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.</p>

<h4>Return Value</h4>

<p>The layer depth.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a25efa7d-3529-40a1-8e33-64784a5ce58d'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="a25efa7d-3529-40a1-8e33-64784a5ce58d"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#576285e6-d850-4077-b222-8b11645b7d48'>PropertyConnections</a></td><td style='width:75%' ><p><a name="576285e6-d850-4077-b222-8b11645b7d48"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#20c5a78a-3535-40bd-af75-051645a741f5'>KimonoShape</a></td><td style='width:75%' ><p><a name="20c5a78a-3535-40bd-af75-051645a741f5"></a></p>

<h3>KimonoShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fc8d1729-30d8-4f99-abd6-2508271c15ad">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc735324-d7f1-4850-9de1-b25c93a4b95b'>KimonoShape</a></td><td style='width:75%' class='def'><p><a name="cc735324-d7f1-4850-9de1-b25c93a4b95b"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fc8d1729-30d8-4f99-abd6-2508271c15ad">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="a8e49408-514c-439b-8173-49b96677b50b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="79c7df02-8f52-4f3e-9d8d-02ec4e87e823"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="0472fb54-22f5-434f-a9bf-321653fe66e6"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="930b6257-5382-45d6-9bbb-f809b771fefb"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bcbcdb0-43cd-4e9c-a486-7c7500a7518e'>KimonoShape</a></td><td style='width:75%' ><p><a name="0bcbcdb0-43cd-4e9c-a486-7c7500a7518e"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fc8d1729-30d8-4f99-abd6-2508271c15ad">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="fa3f4abb-d3d0-480e-a480-68156a1188c3"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="dda9959b-22e3-418d-98e1-befd7dcd6078"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="dd97e6ac-faa0-4b7d-96c0-56bdf751f2f6"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="414da069-0096-4ee3-a2ae-411e270a016a"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="98c7cb96-0fab-4228-83cc-cec059502736"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6728cc33-7eab-47ef-a3fd-e8a02152ac58'>Initialize</a></td><td style='width:75%' class='def'><p><a name="6728cc33-7eab-47ef-a3fd-e8a02152ac58"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef2ef719-b9b3-417d-9aa9-8e9245cefc54'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="ef2ef719-b9b3-417d-9aa9-8e9245cefc54"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="84746a22-5d10-4cc7-bf29-058237314f8d"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="886cc062-bf45-436e-a1bc-0f560ad7a176"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0756be1d-3b07-4cf2-825f-7f7d091ebfa1'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="0756be1d-3b07-4cf2-825f-7f7d091ebfa1"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="1f0a4c5e-5b26-4c97-8e08-3d93e47affee"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#743b8521-1c37-44d2-921c-7e6ac81c56ba'>RemoveProperty</a></td><td style='width:75%' ><p><a name="743b8521-1c37-44d2-921c-7e6ac81c56ba"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="66c26cce-6abe-4337-91b0-5d48eb7e9308"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#581065a6-b553-4e3c-a300-2d7876d7a4a6'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="581065a6-b553-4e3c-a300-2d7876d7a4a6"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoShape</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc5a43c8-75f4-4215-ae54-98549bc8de1a'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="fc5a43c8-75f4-4215-ae54-98549bc8de1a"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="1db64e96-f57e-4747-af55-4dbaed4cbc06"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d77a7c9-0c75-4d7c-97b9-406fd50681e3'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="4d77a7c9-0c75-4d7c-97b9-406fd50681e3"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape in the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e81e7b16-629c-465e-bfb8-43314d4a43ba'>EndEditing</a></td><td style='width:75%' ><p><a name="e81e7b16-629c-465e-bfb8-43314d4a43ba"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2c98ae2-35a2-47ae-9501-ec2c1b1c424d'>UncoupleDeletedStyle</a></td><td style='width:75%' class='def'><p><a name="e2c98ae2-35a2-47ae-9501-ec2c1b1c424d"></a></p>

<h3>UncoupleDeletedStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Uncouples the deleted style from the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p><a name="3bdcb620-1013-493b-8fec-490b60e8dc0e"></a>
The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#731f851d-7061-44c9-a8e6-0ee43d3c2885'>ConformGradientToShape</a></td><td style='width:75%' ><p><a name="731f851d-7061-44c9-a8e6-0ee43d3c2885"></a></p>

<h3>ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the gradient to shape by fitting it to the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="d26aad1d-9b80-40d9-a36b-ad8a2b9bfb54"></a>
The <code>KimonoGradient</code> to conform.</p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p><a name="f7793919-a9ee-4f0b-a420-d89da2525f6c"></a>
The <code>SKPaint</code> that the gradient is being attached to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a908ce3-02be-4d61-a299-54cdac8ab29b'>ToVector</a></td><td style='width:75%' class='def'><p><a name="9a908ce3-02be-4d61-a299-54cdac8ab29b"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a vector.</p>

<h4>Returns</h4>

<p>The shape as a <code>KimonoVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39ed4ead-bdf3-4fc9-9c23-8f5bff6c9883'>ToPath</a></td><td style='width:75%' ><p><a name="39ed4ead-bdf3-4fc9-9c23-8f5bff6c9883"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee1a7502-79d6-43f4-95cd-6b4d8aac3a66'>StyleFillPaintForCode</a></td><td style='width:75%' class='def'><p><a name="ee1a7502-79d6-43f4-95cd-6b4d8aac3a66"></a></p>

<h3>StyleFillPaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style fill paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f42fe5e9-160a-4eaf-86fd-b42832accca3'>StyleFramePaintForCode</a></td><td style='width:75%' ><p><a name="f42fe5e9-160a-4eaf-86fd-b42832accca3"></a></p>

<h3>StyleFramePaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style frame paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30a648a6-5837-4bd2-bd7d-0e2144ac2967'>ConformedFillGradientCode</a></td><td style='width:75%' class='def'><p><a name="30a648a6-5837-4bd2-bd7d-0e2144ac2967"></a></p>

<h3>ConformedFillGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5c165052-3a94-402d-9206-6dd7d1b01f94"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The fill gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b15ac9b-16a3-4e85-b571-5371a7392ec0'>ConformedFrameGradientCode</a></td><td style='width:75%' ><p><a name="7b15ac9b-16a3-4e85-b571-5371a7392ec0"></a></p>

<h3>ConformedFrameGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f71af757-5ffa-46c5-a10e-6f93cc7e7546"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The frame gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eef28645-7df8-4f02-a661-54b3d8cb980b'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="eef28645-7df8-4f02-a661-54b3d8cb980b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaa71786-0cb1-48a3-9229-c70e9d9b8343'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="eaa71786-0cb1-48a3-9229-c70e9d9b8343"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24be00a9-f2de-4d0b-b9a7-8c12d4a0b2bd'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="24be00a9-f2de-4d0b-b9a7-8c12d4a0b2bd"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08a20bd4-95a4-4f38-a330-411f2c8f1e41'>ToCSharp</a></td><td style='width:75%' ><p><a name="08a20bd4-95a4-4f38-a330-411f2c8f1e41"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="40257ab4-666a-4a09-bbba-58fb2d6ac6b4"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2255e067-b1a0-41c3-bca7-99114fda2cf1'>ToCode</a></td><td style='width:75%' class='def'><p><a name="2255e067-b1a0-41c3-bca7-99114fda2cf1"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d7cae607-1a5d-4954-bdb7-9dc5ac8d4062"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="6405167e-e7d4-4c59-b514-1316527715c8"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="24c0246b-6692-4122-8970-f61f1fad048b"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ba8fde2-2237-4f9e-b590-2123ec08edb1'>CloneAttachedStyle</a></td><td style='width:75%' ><p><a name="9ba8fde2-2237-4f9e-b590-2123ec08edb1"></a></p>

<h3>CloneAttachedStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the attached style.</p>

<h4>Returns</h4>

<p>A duplicate <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b572e5d-6696-4861-bca3-961b052bded7'>Clone</a></td><td style='width:75%' class='def'><p><a name="9b572e5d-6696-4861-bca3-961b052bded7"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of this shape as a base <code>KimonoBounds</code>.</p>
</td></tr></table></p>


---

<a name="59daaea7-48bd-410a-9d38-0f55b79ceb2d"></a>
##KimonoShapeArrow

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws either an outlined or single line arrow with heads on one or both ends.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f6f4a554-a49d-42a3-b73b-6fbbb29a20aa'>HasStartHead</a></td><td style='width:75%' ><p><a name="f6f4a554-a49d-42a3-b73b-6fbbb29a20aa"></a></p>

<h3>HasStartHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#59daaea7-48bd-410a-9d38-0f55b79ceb2d">KimonoShapeArrow</a> has start head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has start head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab663d69-686b-4401-88a8-d6fc35be8b06'>HasEndHead</a></td><td style='width:75%' class='def'><p><a name="ab663d69-686b-4401-88a8-d6fc35be8b06"></a></p>

<h3>HasEndHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#59daaea7-48bd-410a-9d38-0f55b79ceb2d">KimonoShapeArrow</a> has end head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has end head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b07b353-d5cc-4b57-866f-cba4c08fc223'>HeadInnerRatio</a></td><td style='width:75%' ><p><a name="3b07b353-d5cc-4b57-866f-cba4c08fc223"></a></p>

<h3>HeadInnerRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head inner ratio.</p>

<h4>Return Value</h4>

<p>The head inner ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45b4eb21-086b-4e31-a55f-3fa9a1263804'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p><a name="45b4eb21-086b-4e31-a55f-3fa9a1263804"></a></p>

<h3>HeadOuterRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head outer ratio.</p>

<h4>Return Value</h4>

<p>The head outer ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#833e04ff-6d3f-48f6-aec2-f31e2e41562c'>IsStreamlined</a></td><td style='width:75%' ><p><a name="833e04ff-6d3f-48f6-aec2-f31e2e41562c"></a></p>

<h3>IsStreamlined</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#59daaea7-48bd-410a-9d38-0f55b79ceb2d">KimonoShapeArrow</a> is streamlined.</p>

<h4>Return Value</h4>

<p><code>true</code> if is streamlined; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>A Streamlined Arrow, is drawn as a single line.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b0fbf17-3f2d-443d-a534-c5726218e390'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="2b0fbf17-3f2d-443d-a534-c5726218e390"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0e4e6124-3762-4114-bb3d-425374cca0d0'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="0e4e6124-3762-4114-bb3d-425374cca0d0"></a></p>

<h3>KimonoShapeArrow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#59daaea7-48bd-410a-9d38-0f55b79ceb2d">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b33e18e-369a-4d37-a8da-a5a1f85e6866'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p><a name="7b33e18e-369a-4d37-a8da-a5a1f85e6866"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#59daaea7-48bd-410a-9d38-0f55b79ceb2d">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6d8db74a-28ca-4230-ab3f-c51e008863b6"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="16d57704-445a-4774-a068-e3c77399e79f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="65e3d7ba-73ca-47e3-ba7c-fc0ae866e3b6"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a99e0ea9-4bea-4f9b-8e80-a909f672960b"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0a9cdad-6de7-440d-abea-caa3a6e294c9'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="d0a9cdad-6de7-440d-abea-caa3a6e294c9"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#59daaea7-48bd-410a-9d38-0f55b79ceb2d">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="659d64d7-2a3e-4ca6-8f15-13c5bb2253bf"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="af7317ce-1e3d-4ff9-9a45-965942c10f38"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f1a11f70-0943-4e04-841e-6ad4ace7df13"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="9527af7d-173e-4380-be62-1a8b144b03b3"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="5c75e859-ac2c-4561-8c7b-96c325b63529"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a65fbb7-416c-4a6f-adb7-c21e6f2e8065'>Initialize</a></td><td style='width:75%' class='def'><p><a name="4a65fbb7-416c-4a6f-adb7-c21e6f2e8065"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e0dcce7-2ddf-4063-818b-b43775b847d1'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="1e0dcce7-2ddf-4063-818b-b43775b847d1"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="caf8b7b7-ae4c-426f-8a37-bc81666052b6"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52be0c60-1eb7-4162-8780-7a018000cbaa'>ToPath</a></td><td style='width:75%' class='def'><p><a name="52be0c60-1eb7-4162-8780-7a018000cbaa"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the arrow to a path.</p>

<h4>Returns</h4>

<p>The the arrow as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#493e5a3f-5eac-4370-a219-7c0b202d0e28'>Draw</a></td><td style='width:75%' ><p><a name="493e5a3f-5eac-4370-a219-7c0b202d0e28"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the arrow into the specified Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="ccd33169-ed4e-427f-90b7-1bd70c36e006"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11b6751b-5dd3-44d9-ac00-baf063e56e95'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="11b6751b-5dd3-44d9-ac00-baf063e56e95"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the arrow.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a3b161ee-5859-483e-bd07-f454bd450e05"></a>
The <code>SKPoint</code> containing the bounds adjustment.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c41f862-ed3f-4d23-9e9d-deecd8654db6'>DragBounds</a></td><td style='width:75%' ><p><a name="5c41f862-ed3f-4d23-9e9d-deecd8654db6"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the arrow to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="c2321226-1e4f-4548-9deb-bebef049a3f6"></a>
The <code>SKPoint</code> specifying the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0106e5f8-a9a2-4c5b-9a28-6f8e8ce11ad4'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="0106e5f8-a9a2-4c5b-9a28-6f8e8ce11ad4"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bac3fec1-8e43-4794-996d-c70891c6fbff'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="bac3fec1-8e43-4794-996d-c70891c6fbff"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#094fca6f-c6b4-46c7-9f05-c9953cd923f7'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="094fca6f-c6b4-46c7-9f05-c9953cd923f7"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7a7eda6-b0b7-4e12-98d8-46746a0d8e5a'>ToCSharp</a></td><td style='width:75%' ><p><a name="d7a7eda6-b0b7-4e12-98d8-46746a0d8e5a"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="36dfaa6b-9fc7-4e01-81be-e2379bff0a6e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dac6a087-fbd2-48ae-8cc4-877e88a0f5fc'>ToCode</a></td><td style='width:75%' class='def'><p><a name="dac6a087-fbd2-48ae-8cc4-877e88a0f5fc"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="308a9042-7c28-4887-b305-792820aa8703"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="b4fd4c2b-7689-44f1-8ff7-40cc20efd4d6"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="45c18331-55c6-44fe-b4ec-b1debc10017b"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebda635b-f060-4c25-9cdd-87fe946177b6'>Clone</a></td><td style='width:75%' ><p><a name="ebda635b-f060-4c25-9cdd-87fe946177b6"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoArrow</code>.</p>
</td></tr></table></p>


---

<a name="61c4c394-866e-4d62-9040-316d86f8bcc3"></a>
##KimonoShapeBezier

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#14d8cb85-5e80-4f4c-92e6-6bed9274f44f'>Points</a></td><td style='width:75%' ><p><a name="14d8cb85-5e80-4f4c-92e6-6bed9274f44f"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#befc0f19-ecd1-4a1f-98c9-69ab803e363c'>Closed</a></td><td style='width:75%' class='def'><p><a name="befc0f19-ecd1-4a1f-98c9-69ab803e363c"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cfc0726-73c9-4402-a524-47de5978bce5'>IsEditable</a></td><td style='width:75%' ><p><a name="3cfc0726-73c9-4402-a524-47de5978bce5"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c12d279a-c7f6-44e5-99e1-42d94aa3cd24'>LastPoint</a></td><td style='width:75%' class='def'><p><a name="c12d279a-c7f6-44e5-99e1-42d94aa3cd24"></a></p>

<h3>LastPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the last point in the collection of control points.</p>

<h4>Return Value</h4>

<p>The last point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0b692a59-c5b7-4a3a-ba7f-cf465fe4e5b8'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="0b692a59-c5b7-4a3a-ba7f-cf465fe4e5b8"></a></p>

<h3>KimonoShapeBezier ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61c4c394-866e-4d62-9040-316d86f8bcc3">KimonoShapeBezier</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ee6301d-5ef2-42ec-b530-04af49b14461'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p><a name="1ee6301d-5ef2-42ec-b530-04af49b14461"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61c4c394-866e-4d62-9040-316d86f8bcc3">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="3b23556e-4e31-45d9-b493-5e87c2b259e5"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e368098e-f2f3-4e8d-977f-dabca218906d"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="6f8d4b3d-3526-4316-b9fd-8e5d9f4c663d"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a3a9a38a-2a24-4fe4-b166-b7677b632400"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d53ec2aa-89c7-4866-aa35-3541a0cd2a91'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="d53ec2aa-89c7-4866-aa35-3541a0cd2a91"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#61c4c394-866e-4d62-9040-316d86f8bcc3">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="679830d1-f210-40d3-8512-8aa3f35bac6a"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="02e1e6f9-7c1b-4067-b333-46ee9e225930"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="7a0b33ad-d82e-4489-b938-1be1fff5a026"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="ba1b0783-f949-4101-af0e-13074015cd62"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="ad46be26-480e-4d8b-98e0-fc304b98c91e"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84ba6b10-ae76-4289-bb96-f287f17b7bd3'>Initialize</a></td><td style='width:75%' class='def'><p><a name="84ba6b10-ae76-4289-bb96-f287f17b7bd3"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d15de20-9bac-4796-bf87-aadce1fb60cc'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="5d15de20-9bac-4796-bf87-aadce1fb60cc"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9193f26-b243-4dd9-9db7-e03caf6fac3c'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="a9193f26-b243-4dd9-9db7-e03caf6fac3c"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="cfd4bcbf-5f95-457c-a866-789fd1bd2cc8"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="29298ac2-6339-4ed3-aae0-46ce40186e84"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e7a1323-1c08-4048-8595-b87b716ff264'>AddPoint</a></td><td style='width:75%' ><p><a name="5e7a1323-1c08-4048-8595-b87b716ff264"></a></p>

<h3>AddPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="85df0434-8faf-4e74-a347-592afb722c73"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="afc24c5b-f9ad-43f9-af32-13d524ce429e"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="5377c442-7d08-4f8c-a795-a4245d04664a"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="6129213e-8d13-4a17-b255-fd19008fb74e"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f12a5445-60f2-4528-a5ed-d4bda20e62b6'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="f12a5445-60f2-4528-a5ed-d4bda20e62b6"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="931391da-ab3f-4506-b74a-234112deae53"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc03fce0-3a12-4b73-9350-e8e10818378c'>AddHandlesForPoint</a></td><td style='width:75%' ><p><a name="cc03fce0-3a12-4b73-9350-e8e10818378c"></a></p>

<h3>AddHandlesForPoint (System.Int32, KimonoCore.KimonoBezierPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the handles for the given bezier point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="e419ba65-92f8-4e8a-bebe-13bb068b96c5"></a>
The index of the <code>KimonoBezierPoint</code> that handles are being created for.</p>
</td></tr><tr><td style='width:25%' class='term'>bezierPoint</td><td style='width:75%' class='def'><p><a name="a903b247-279b-4ba0-9615-69e5f9324297"></a>
The <code>KimonoBezierPoint</code> that is getting handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a787d93e-6084-4443-9785-af913f9064b9'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="a787d93e-6084-4443-9785-af913f9064b9"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d405dbe8-1c22-41dd-b5d5-49973d1d32f5"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#105f2822-3d63-40dc-8c3c-a9e9ce450215'>RemovePoint</a></td><td style='width:75%' ><p><a name="105f2822-3d63-40dc-8c3c-a9e9ce450215"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="f573fd91-755e-44d7-b259-d4fb353a92c2"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ad91491-b02a-4c3c-9760-edb7f4499536'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="8ad91491-b02a-4c3c-9760-edb7f4499536"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebdb423f-eb28-42d8-a955-9670b57d9f52'>ToPath</a></td><td style='width:75%' ><p><a name="ebdb423f-eb28-42d8-a955-9670b57d9f52"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cdecde7-f01e-40ee-ae5e-693eff5e3b70'>Draw</a></td><td style='width:75%' class='def'><p><a name="6cdecde7-f01e-40ee-ae5e-693eff5e3b70"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="624d9024-8197-4f43-b9ac-6a7c05b9c51e"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#332a7b48-24c1-4b0c-84c4-716d53c8fedf'>PointInBound</a></td><td style='width:75%' ><p><a name="332a7b48-24c1-4b0c-84c4-716d53c8fedf"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="517be735-aa4c-4ba7-a3e4-ef998164ed5a"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b62c73df-df4a-4d34-9905-6e0b6f34b695'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="b62c73df-df4a-4d34-9905-6e0b6f34b695"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ada66851-2b87-40bd-9cee-15e71f715c63"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75a29f1f-0a4c-48df-a49c-ae82b236f0fb'>BoundsChanged</a></td><td style='width:75%' ><p><a name="75a29f1f-0a4c-48df-a49c-ae82b236f0fb"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42bebf09-f48e-4117-9af9-5def772a7183'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="42bebf09-f48e-4117-9af9-5def772a7183"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6436c36e-537e-4769-9143-048e59292974'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="6436c36e-537e-4769-9143-048e59292974"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25d4ada7-5fab-4c04-8384-cf33961fddbf'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="25d4ada7-5fab-4c04-8384-cf33961fddbf"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76606fb4-2323-47e2-9fad-3647d2c6343a'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="76606fb4-2323-47e2-9fad-3647d2c6343a"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e00225fb-acdf-45c3-ac61-ea9be36fe3ee'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="e00225fb-acdf-45c3-ac61-ea9be36fe3ee"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="daabc53d-7c2d-44b8-ada2-0a6ba8813c1a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99b87ac8-f008-4350-a084-bdb2df82fdb6'>ToCode</a></td><td style='width:75%' ><p><a name="99b87ac8-f008-4350-a084-bdb2df82fdb6"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="76cc3e64-1e1d-4240-9df6-267a27d455eb"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e8eddc3c-60ac-47ed-a8f3-fe1ec4c33293"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="63e072c8-bfcd-412e-a84d-ef1740edb041"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94ed9b61-41f3-4ebc-81e9-ce7ad1f8e958'>Clone</a></td><td style='width:75%' class='def'><p><a name="94ed9b61-41f3-4ebc-81e9-ce7ad1f8e958"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="99029195-ed89-4ee7-bbbe-a81b4f4acc15"></a>
##KimonoShapeGroup

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

A `KimonoShapeGroup` holds a collection of `KimonoShapes` that can be acted upon as a group.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7bfc9e80-c834-44c3-9798-8b5736b5c351'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="7bfc9e80-c834-44c3-9798-8b5736b5c351"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4eff9964-544a-4a77-b29a-78e807b05948'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="4eff9964-544a-4a77-b29a-78e807b05948"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47e9d01d-dc09-4923-a04c-1a91e72ee352'>Dragging</a></td><td style='width:75%' ><p><a name="47e9d01d-dc09-4923-a04c-1a91e72ee352"></a>
<b>Dragging</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Marks if the group itself is being moved be the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2bb0195-0de6-4b99-b5cd-26e5ded2233a'>IgnoreDrag</a></td><td style='width:75%' class='def'><p><a name="b2bb0195-0de6-4b99-b5cd-26e5ded2233a"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#465e8dbd-2be5-4da9-84a9-9223f695ec51'>PerformingDrag</a></td><td style='width:75%' ><p><a name="465e8dbd-2be5-4da9-84a9-9223f695ec51"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4c605db-73f2-4fbe-95fb-b1eec4bc9205'>ToolDownAt</a></td><td style='width:75%' class='def'><p><a name="f4c605db-73f2-4fbe-95fb-b1eec4bc9205"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea5592c7-998d-45a9-a84d-8d2051e7aa31'>_isMaskedGroup</a></td><td style='width:75%' ><p><a name="ea5592c7-998d-45a9-a84d-8d2051e7aa31"></a>
<b>_isMaskedGroup</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the top most shape in the group will act as a mask for the shapes below it.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d973564c-7a03-4196-bd81-1ecd5801c440'>Parent</a></td><td style='width:75%' ><p><a name="d973564c-7a03-4196-bd81-1ecd5801c440"></a></p>

<h3>Parent</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code> that this <code>KimonoShapeGroup</code> belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a396027e-d3f1-47e7-abb1-68a2ccd4cba8'>ParentSketch</a></td><td style='width:75%' class='def'><p><a name="a396027e-d3f1-47e7-abb1-68a2ccd4cba8"></a></p>

<h3>ParentSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the parent sketch by scanning backwards through the chain of parent objects until a <code>KimonoSketch</code> is reached.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c246947-ff9b-4dfa-bf3e-fbee842eba39'>Path</a></td><td style='width:75%' ><p><a name="5c246947-ff9b-4dfa-bf3e-fbee842eba39"></a></p>

<h3>Path</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the full path from this group back to the parent <code>KimonoSketch</code>.</p>

<h4>Return Value</h4>

<p>The path representing the nesting level of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2c4c136-c057-4d86-baef-ec2e4ee387e2'>Shapes</a></td><td style='width:75%' class='def'><p><a name="e2c4c136-c057-4d86-baef-ec2e4ee387e2"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93d8dad4-b2af-407b-925c-2db232187644'>SelectedShape</a></td><td style='width:75%' ><p><a name="93d8dad4-b2af-407b-925c-2db232187644"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f3c68ed-2169-4606-97b2-0f60638d8bb6'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="9f3c68ed-2169-4606-97b2-0f60638d8bb6"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df6526d2-630b-4d4a-84b9-e8570dcabbc2'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="df6526d2-630b-4d4a-84b9-e8570dcabbc2"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86601b7a-5702-4e6b-8499-d64f3b1817b5'>GroupType</a></td><td style='width:75%' class='def'><p><a name="86601b7a-5702-4e6b-8499-d64f3b1817b5"></a></p>

<h3>GroupType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the group.</p>

<h4>Return Value</h4>

<p>The type of the group as a <code>KimonoShapeGroupType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#436140a4-52f7-4011-865e-998af9ed031a'>Style</a></td><td style='width:75%' ><p><a name="436140a4-52f7-4011-865e-998af9ed031a"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style of this group.</p>

<h4>Return Value</h4>

<p>The style as a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#974df9fb-4ad6-4cb1-b366-d09191d1c39f'>Visible</a></td><td style='width:75%' class='def'><p><a name="974df9fb-4ad6-4cb1-b366-d09191d1c39f"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cffe6dcc-fa87-4403-90bd-08a749c0f9b3'>IsEditable</a></td><td style='width:75%' ><p><a name="cffe6dcc-fa87-4403-90bd-08a749c0f9b3"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4563189-8088-4289-8b2b-c4051a2d05c7'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="e4563189-8088-4289-8b2b-c4051a2d05c7"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79fc5802-398f-4054-97f2-ee586298fbf0'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="79fc5802-398f-4054-97f2-ee586298fbf0"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d44ab6ac-8cd1-4b17-918e-b86ab20ff99c'>IsBooleanConstruct</a></td><td style='width:75%' class='def'><p><a name="d44ab6ac-8cd1-4b17-918e-b86ab20ff99c"></a></p>

<h3>IsBooleanConstruct</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> is a boolean construct.</p>

<h4>Return Value</h4>

<p><code>true</code> if is boolean construct; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#517cec10-c14c-4fac-b89c-29d8dd08d7c3'>BooleanOperation</a></td><td style='width:75%' ><p><a name="517cec10-c14c-4fac-b89c-29d8dd08d7c3"></a></p>

<h3>BooleanOperation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the boolean operation that will be applied to this group of objects.</p>

<h4>Return Value</h4>

<p>The boolean operation as a <code>SKPathOp</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14a7705d-2b4a-4b1a-8224-5df005d645af'>Mask</a></td><td style='width:75%' class='def'><p><a name="14a7705d-2b4a-4b1a-8224-5df005d645af"></a></p>

<h3>Mask</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoShape</code> that is acting as a mask for this group.</p>

<h4>Return Value</h4>

<p>The mask as a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00d15292-acf3-4578-8dac-d12b1007b024'>IsMaskedGroup</a></td><td style='width:75%' ><p><a name="00d15292-acf3-4578-8dac-d12b1007b024"></a></p>

<h3>IsMaskedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> is masked group.</p>

<h4>Return Value</h4>

<p><code>true</code> if is masked group; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3b5376b6-f001-4670-a37d-ff7f28e21a20'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="3b5376b6-f001-4670-a37d-ff7f28e21a20"></a></p>

<h3>KimonoShapeGroup (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="4eb5c279-8b3a-498b-8c4d-ce8e57435163"></a>
The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3627f8c6-aec8-4abb-8598-4087e11d31e7'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p><a name="3627f8c6-aec8-4abb-8598-4087e11d31e7"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="34388c01-100e-4104-a43c-f6b4e914b3c1"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="f170ba16-e7cc-4535-8f88-5a3e714ee598"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="40f695b4-c64e-4c38-93b9-517a10a6ae47"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="597c9b53-220a-4e50-a035-386bf84bd12b"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="cc24ea34-b8cc-43ea-b62b-d641cf261b5b"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8554792d-a226-4134-985b-489fee90206d'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="8554792d-a226-4134-985b-489fee90206d"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#99029195-ed89-4ee7-bbbe-a81b4f4acc15">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="f554733f-5cc5-47fc-9d92-33f831dd1968"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="003a439d-9100-472e-a4c0-06cfd7d27dea"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="4dd4f216-e8cc-4b14-b0aa-27813f603202"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="a7ce74e0-7dcb-4329-9cb7-36bfe513ba3c"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="d13478d2-5d81-4fd4-b385-258f8e4b0efd"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="9e584601-f2c2-4423-ba52-dde71fb822a1"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2b6b1be-a731-4ed3-99aa-89435d8827da'>Initialize</a></td><td style='width:75%' class='def'><p><a name="b2b6b1be-a731-4ed3-99aa-89435d8827da"></a></p>

<h3>Initialize (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize the specified parent.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="0ba1b832-69a3-415e-b85e-0bdf29d4d389"></a>
Parent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The initialize.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b256f6dd-681b-4797-9fa1-417ebc132745'>FindShape</a></td><td style='width:75%' ><p><a name="b256f6dd-681b-4797-9fa1-417ebc132745"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds a given shape by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="69e97695-cf6b-4f7b-8901-d0dac0411ae1"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoShape</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fafb0a52-f995-492f-b7d8-e959b2d0db89'>RecalculateGroupBounds</a></td><td style='width:75%' class='def'><p><a name="fafb0a52-f995-492f-b7d8-e959b2d0db89"></a></p>

<h3>RecalculateGroupBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the group bounds to encompass every <code>KimonoShape</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9560f7b9-43b5-40a7-931e-3a34b36e4d8e'>ReturnToSketch</a></td><td style='width:75%' ><p><a name="9560f7b9-43b5-40a7-931e-3a34b36e4d8e"></a></p>

<h3>ReturnToSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns to base parent <code>KimonoSketch</code> for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9ab74c3-3db6-4a27-9403-7120bb5e0cf6'>SelectShape</a></td><td style='width:75%' class='def'><p><a name="d9ab74c3-3db6-4a27-9403-7120bb5e0cf6"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="e28abb72-ca97-4308-991d-c6e3040a65aa"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdc6a11f-920d-41e2-8733-033494793997'>RecalculateLayerDepths</a></td><td style='width:75%' ><p><a name="cdc6a11f-920d-41e2-8733-033494793997"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2719c91-7913-4d5f-b199-3844f4fdf0aa'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="b2719c91-7913-4d5f-b199-3844f4fdf0aa"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a6098ce-c517-4048-bb57-53f67a57d7e5'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p><a name="7a6098ce-c517-4048-bb57-53f67a57d7e5"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab5ca128-e66f-4fe0-b575-a92e7888e416'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p><a name="ab5ca128-e66f-4fe0-b575-a92e7888e416"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77d37e01-d6f8-476a-81d5-854b80ac4509'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="77d37e01-d6f8-476a-81d5-854b80ac4509"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9dc1212-ba57-4c34-a5f0-896a9526c3cd'>AlignAllTop</a></td><td style='width:75%' class='def'><p><a name="c9dc1212-ba57-4c34-a5f0-896a9526c3cd"></a></p>

<h3>AlignAllTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b5dcee8-f2fd-49f1-a188-dd3879fc90dd'>AlignAllBottom</a></td><td style='width:75%' ><p><a name="9b5dcee8-f2fd-49f1-a188-dd3879fc90dd"></a></p>

<h3>AlignAllBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d3a7e68-759a-4d15-ac3c-37c36189df7a'>AlignAllLeft</a></td><td style='width:75%' class='def'><p><a name="0d3a7e68-759a-4d15-ac3c-37c36189df7a"></a></p>

<h3>AlignAllLeft ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#019866b4-ce9c-45c1-be90-cfd31663863b'>AlignAllRight</a></td><td style='width:75%' ><p><a name="019866b4-ce9c-45c1-be90-cfd31663863b"></a></p>

<h3>AlignAllRight ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#141a8673-fcc1-439d-8567-8c7668d9a1d3'>AlignAllCenter</a></td><td style='width:75%' class='def'><p><a name="141a8673-fcc1-439d-8567-8c7668d9a1d3"></a></p>

<h3>AlignAllCenter ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Centers all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#752f2cbe-7d0c-4909-8e9e-e898d64320ce'>AlignAllCenterHorizontal</a></td><td style='width:75%' ><p><a name="752f2cbe-7d0c-4909-8e9e-e898d64320ce"></a></p>

<h3>AlignAllCenterHorizontal ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center horizontal all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c967adc-b244-45cb-bbb2-929d56936408'>AlignAllCenterVertical</a></td><td style='width:75%' class='def'><p><a name="7c967adc-b244-45cb-bbb2-929d56936408"></a></p>

<h3>AlignAllCenterVertical ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center vertical all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e48f186-836c-4e9d-9dc0-6d78b0409c65'>DeleteColor</a></td><td style='width:75%' ><p><a name="4e48f186-836c-4e9d-9dc0-6d78b0409c65"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="9a772136-8e87-4e5f-99c4-2c958a689bd5"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10a13b4f-b54a-4e94-ab04-b0c72e45170e'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="10a13b4f-b54a-4e94-ab04-b0c72e45170e"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="243fb1b0-11f5-40c5-904a-d40cfa26ee1c"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdcd1353-daef-438c-9de5-ba714d8511f4'>AddShape</a></td><td style='width:75%' ><p><a name="cdcd1353-daef-438c-9de5-ba714d8511f4"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoShape</code> to the group if it isn't already a part of the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="cc187fe1-bda4-4ae0-b072-31ccf58418dc"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df98853e-d192-4a08-883e-57c4cc458b53'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="df98853e-d192-4a08-883e-57c4cc458b53"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#512ba9da-98b6-4257-b8cc-fe405582a735'>RemoveShape</a></td><td style='width:75%' ><p><a name="512ba9da-98b6-4257-b8cc-fe405582a735"></a></p>

<h3>RemoveShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given <code>KimonoShape</code> from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="566e973e-3faf-4973-9e3c-58a5eb56d7a5"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73084fb7-264e-44fc-8a5f-2981b1dc6786'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="73084fb7-264e-44fc-8a5f-2981b1dc6786"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46f800be-c5db-4fcf-85ec-5c0ce42bc6e5'>ShapeInGroup</a></td><td style='width:75%' ><p><a name="46f800be-c5db-4fcf-85ec-5c0ce42bc6e5"></a></p>

<h3>ShapeInGroup (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given <code>KimonoShape</code> is a part of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="65396479-044b-4b7d-80cb-773a9af43389"></a>
The <code>KimonoShape</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in shape is in the group, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73dbdf29-0459-4d9c-86f9-b23def8748d5'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="73dbdf29-0459-4d9c-86f9-b23def8748d5"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f72ea0c3-b3ea-480c-87b0-0b6a42c34836'>GroupShapes</a></td><td style='width:75%' ><p><a name="f72ea0c3-b3ea-480c-87b0-0b6a42c34836"></a></p>

<h3>GroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bae4277-37d4-4182-8a5d-49c7f338b086'>GroupShapes</a></td><td style='width:75%' class='def'><p><a name="2bae4277-37d4-4182-8a5d-49c7f338b086"></a></p>

<h3>GroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="77037fc3-eb4e-4a1b-83f1-949c14480b18"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a298634-821d-4f58-8574-04c0f9f04b67'>GroupShapes</a></td><td style='width:75%' ><p><a name="5a298634-821d-4f58-8574-04c0f9f04b67"></a></p>

<h3>GroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="33e93c8b-8628-4cf5-8dfe-c1b60b449cb4"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8bbf0ff-27f6-4e54-8d52-edc12999153c'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="f8bbf0ff-27f6-4e54-8d52-edc12999153c"></a></p>

<h3>UngroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89efa276-04f1-4411-83f5-7b26c0b64936'>UngroupShapes</a></td><td style='width:75%' ><p><a name="89efa276-04f1-4411-83f5-7b26c0b64936"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="6666104c-0813-461a-9e24-f642eb61a38a"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83781d7e-ec10-4e91-b3f1-bc60325f1c6e'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="83781d7e-ec10-4e91-b3f1-bc60325f1c6e"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="e8076b16-c68e-4a16-9d8d-5d1b3698f287"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c51241a7-e852-430b-9704-2bf2cd04b6a8'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="c51241a7-e852-430b-9704-2bf2cd04b6a8"></a></p>

<h3>DuplicateShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in a selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58610eb2-6f73-4e06-8ff9-641db0bb7e38'>DuplicateShapes</a></td><td style='width:75%' class='def'><p><a name="58610eb2-6f73-4e06-8ff9-641db0bb7e38"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="84156ad1-29a9-431e-9e5e-310a7271d19c"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#332502b1-0411-4553-9292-7354b1421f05'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="332502b1-0411-4553-9292-7354b1421f05"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="8f942a06-4841-4091-baf3-68c2dba82010"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd577836-a2a5-4b55-a03e-570090b9fa16'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="bd577836-a2a5-4b55-a03e-570090b9fa16"></a></p>

<h3>DeleteShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f4b3cee-bccb-43a6-b7cb-343d7a8a26fc'>DeleteShapes</a></td><td style='width:75%' ><p><a name="9f4b3cee-bccb-43a6-b7cb-343d7a8a26fc"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="dbb851f6-273a-4da8-b972-7e878224a14c"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2c38998-c444-40e1-9850-7352113b844c'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="c2c38998-c444-40e1-9850-7352113b844c"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="78451c6c-b568-4cae-afae-05e2a240b313"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d821c124-dab7-4fef-aac8-c2b49df7ce43'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="d821c124-dab7-4fef-aac8-c2b49df7ce43"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale adjustments to all <code>KimonoShapes</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68d671cb-f9ee-42e4-90e0-d5c53645bae0'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="68d671cb-f9ee-42e4-90e0-d5c53645bae0"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="2057d402-96c8-459d-8cbc-6d3f3b094941"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f5816e4-5873-4a4e-89bf-604e09770a42'>RemoveProperty</a></td><td style='width:75%' ><p><a name="4f5816e4-5873-4a4e-89bf-604e09770a42"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="d71e0e30-a293-4ae1-a8d1-2bbd12f1b6bd"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f5590c8-f754-4806-97e3-6ffcdd5b636a'>ToPath</a></td><td style='width:75%' class='def'><p><a name="4f5590c8-f754-4806-97e3-6ffcdd5b636a"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the group of shapes to a path.</p>

<h4>Returns</h4>

<p>The group of shapes as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dd5c820-f429-422f-98a7-ea452278c92c'>Draw</a></td><td style='width:75%' ><p><a name="5dd5c820-f429-422f-98a7-ea452278c92c"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw all the <code>KimonoShapes</code> that are part of this group into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="05947cd8-d25f-4122-a3f7-5e9f4e6e199f"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19b6245f-f184-4ec9-b950-55ac3e093760'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="19b6245f-f184-4ec9-b950-55ac3e093760"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3d3ac07-3e87-49c3-94f2-62c170b83b06'>EndEditing</a></td><td style='width:75%' ><p><a name="f3d3ac07-3e87-49c3-94f2-62c170b83b06"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fe91466-957e-4e4b-856b-bd5a34a73e1b'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="8fe91466-957e-4e4b-856b-bd5a34a73e1b"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8ca4c420-81f1-4311-9ca3-10e3160295ab"></a>
The <code>SKPoint</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the point was in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59d2a446-8d48-49e2-9ed7-31cd94877e33'>DragBounds</a></td><td style='width:75%' ><p><a name="59d2a446-8d48-49e2-9ed7-31cd94877e33"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a456892b-3657-47e4-83e5-c359db3b1d52"></a>
The new location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ca499d2-526e-416f-80aa-b8f01c41601b'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="0ca499d2-526e-416f-80aa-b8f01c41601b"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Update the bouds of this group when they have changed from either a move or a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86b867de-a5c4-4620-bbe4-70cc67fa4759'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="86b867de-a5c4-4620-bbe4-70cc67fa4759"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#098fa6d6-b3d8-48b4-b3ee-8d4a874565f6'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="098fa6d6-b3d8-48b4-b3ee-8d4a874565f6"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ce6fe67-241a-43d7-bc54-7a61df694ad5'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="2ce6fe67-241a-43d7-bc54-7a61df694ad5"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2720c617-72a0-4ddc-b117-fac78f7bd863'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="2720c617-72a0-4ddc-b117-fac78f7bd863"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="eddaa535-3142-4219-bd6a-89721d8234e9"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a56abf1-3195-4bd8-95da-aa84f2c6c2d1'>ToCode</a></td><td style='width:75%' ><p><a name="0a56abf1-3195-4bd8-95da-aa84f2c6c2d1"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="4828357a-b92f-44ba-a2b7-d3e1addc2c30"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="d7b3a13f-6328-46aa-b03b-ca56b4cf4240"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6f1746e4-5627-40b3-932f-07cd0d8caaa7"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e67ba160-0d8f-44e9-91f6-b389646c1bcc'>RelinkShape</a></td><td style='width:75%' class='def'><p><a name="e67ba160-0d8f-44e9-91f6-b389646c1bcc"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="d81d6471-dc72-49d5-b024-d7b3db3eef49"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7a8e855-4b7f-4238-8556-2fa0aab8b4f8'>Clone</a></td><td style='width:75%' ><p><a name="a7a8e855-4b7f-4238-8556-2fa0aab8b4f8"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b03c24b-5276-4d4c-9929-0dd99398a0a9'>ToolDown</a></td><td style='width:75%' class='def'><p><a name="1b03c24b-5276-4d4c-9929-0dd99398a0a9"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the group's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="70d9b780-e043-4f24-af6e-a3b8517c50eb"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="5a3eb709-5b4b-473f-b4b1-2081d22bd7f5"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="37fc9d31-7f0b-4d41-b8f2-7bf2c32760d6"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="98ff3cb4-e031-4c17-9338-ab73499d892d"></a>
##KimonoShapeGroupType

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3d06c62a-6e7f-456b-8446-7b4fb000ea79'>Selection</a></td><td style='width:75%' ><p><a name="3d06c62a-6e7f-456b-8446-7b4fb000ea79"></a>
<b>Selection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a current active selection.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#243e8447-6c2c-4d5f-ba89-44d40b7a3a6c'>DragSelect</a></td><td style='width:75%' class='def'><p><a name="243e8447-6c2c-4d5f-ba89-44d40b7a3a6c"></a>
<b>DragSelect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a drag to select selection that is underway.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89020cc9-3107-4b4f-8c99-350702b4b66b'>Collection</a></td><td style='width:75%' ><p><a name="89020cc9-3107-4b4f-8c99-350702b4b66b"></a>
<b>Collection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a collection of shape that have been grouped together and are treated as a single object in the editor.</p>
</td></tr></table></p>


---

<a name="fa8aeb6b-e55b-4117-9f22-9f0f795e101e"></a>
##KimonoShapeLine

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a line on the design surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#79e76b93-9a00-4bd2-8ae8-cd3549fe9bd8'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="79e76b93-9a00-4bd2-8ae8-cd3549fe9bd8"></a></p>

<h3>KimonoShapeLine ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fa8aeb6b-e55b-4117-9f22-9f0f795e101e">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#147c429c-ce95-4c04-9cee-394478c4687b'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p><a name="147c429c-ce95-4c04-9cee-394478c4687b"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fa8aeb6b-e55b-4117-9f22-9f0f795e101e">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="11094b2e-bd4d-4cad-8998-1079830553a6"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c5f34c26-d44c-433a-b3d5-85733c6c1f52"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f2e70de8-4347-41b8-948e-128fb46ed655"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="638e84c1-def3-4712-8ddd-92157c712889"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6b3ff62-6364-4a36-9b52-42865e360ade'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="b6b3ff62-6364-4a36-9b52-42865e360ade"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fa8aeb6b-e55b-4117-9f22-9f0f795e101e">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="314e8814-bb11-474a-a462-cc867036e7ee"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e7299100-3f45-4b2b-88ba-87862da3137a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="679a65eb-ee4c-4de0-a634-d6c302b1a4d0"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="88b53f31-b630-4842-9282-f47c22ea0729"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="9dfafaf5-7869-4a8b-b5f0-42f6d24b739e"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99f68527-41b4-4339-87df-5838468b2ad8'>Initialize</a></td><td style='width:75%' class='def'><p><a name="99f68527-41b4-4339-87df-5838468b2ad8"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eae5ba06-c1f3-4255-88f4-0c8ef3be0cf4'>ToPath</a></td><td style='width:75%' ><p><a name="eae5ba06-c1f3-4255-88f4-0c8ef3be0cf4"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#103ffa5f-8c9b-4425-aa92-8a06d8f0b2b1'>Draw</a></td><td style='width:75%' class='def'><p><a name="103ffa5f-8c9b-4425-aa92-8a06d8f0b2b1"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the line into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="27b08e4a-9156-470f-be95-47ec072749a4"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de8ff13d-2c69-4ed9-9458-24aa8735237b'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="de8ff13d-2c69-4ed9-9458-24aa8735237b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58e60f1b-7e96-43b8-b5e6-6889269c9e02'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="58e60f1b-7e96-43b8-b5e6-6889269c9e02"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d6db11a-6e2c-4863-ae72-6e404b5a9ca3'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="9d6db11a-6e2c-4863-ae72-6e404b5a9ca3"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a728d8f3-7483-46a2-9bb7-d6f61d7bd878'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="a728d8f3-7483-46a2-9bb7-d6f61d7bd878"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ab78bd4d-62ef-4c69-ab73-3caddd2810cb"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bdbcf3b-43b7-42de-b3fb-c3c140cdc537'>ToCode</a></td><td style='width:75%' ><p><a name="7bdbcf3b-43b7-42de-b3fb-c3c140cdc537"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="41af113f-7ce3-478d-8300-686ac33b7afa"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="613e9fca-be6a-41f7-8c7c-184f62a2cba8"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="41221d81-2dc7-4904-b485-ba2c3d330416"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fcc1122-6491-46f8-904d-96311c1930ea'>Clone</a></td><td style='width:75%' class='def'><p><a name="2fcc1122-6491-46f8-904d-96311c1930ea"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoLine</code>.</p>
</td></tr></table></p>


---

<a name="0d42c82a-e030-4f74-8062-783172a33d0e"></a>
##KimonoShapeOval

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws an oval into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#adcb5840-c0b8-44df-8101-fa795de56a20'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="adcb5840-c0b8-44df-8101-fa795de56a20"></a></p>

<h3>KimonoShapeOval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0d42c82a-e030-4f74-8062-783172a33d0e">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fe81810-03ad-46df-9ff3-a6b1a96386e0'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p><a name="1fe81810-03ad-46df-9ff3-a6b1a96386e0"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0d42c82a-e030-4f74-8062-783172a33d0e">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="bf41bfe3-ff67-4543-8d64-a7f86d14084b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="bdaf7aec-332f-4e18-aa42-695193e6be3c"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="9f648aa9-dfdf-40c6-869f-68ed5c1c89fb"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="4b560e69-6fc4-4adb-9ce7-b76b45efc045"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4645b3e1-094a-4115-b0ab-0fa28c0008ba'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="4645b3e1-094a-4115-b0ab-0fa28c0008ba"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0d42c82a-e030-4f74-8062-783172a33d0e">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="2ac7e78c-6ea7-4191-9c9b-f7f6a807578b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c58b591b-4c28-45ac-bb58-26345977f073"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="a6173795-bfe9-4275-ae81-f91d0b70c187"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f15b61bb-f950-4f3b-b0b2-c52b6e561a6c"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="fa91c24f-f054-4f6c-8912-937240dfd02c"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2e505db-54ba-4f18-a660-ec985130f473'>Initialize</a></td><td style='width:75%' class='def'><p><a name="c2e505db-54ba-4f18-a660-ec985130f473"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f067a10-944f-415c-841e-d6c0cea02e3e'>ToPath</a></td><td style='width:75%' ><p><a name="8f067a10-944f-415c-841e-d6c0cea02e3e"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1545baa-d969-4e72-9621-bac4a7e3160a'>Draw</a></td><td style='width:75%' class='def'><p><a name="c1545baa-d969-4e72-9621-bac4a7e3160a"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw the oval into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="e6c06f70-3a61-4f31-8fa9-866acd0eab52"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6e59b65-602b-41c2-9944-0e8c631e3b74'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="e6e59b65-602b-41c2-9944-0e8c631e3b74"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27f31cfe-5dca-42d8-8020-5074b55ae719'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="27f31cfe-5dca-42d8-8020-5074b55ae719"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62b18f4e-df02-4a6c-aae0-9b00c5b9c1ec'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="62b18f4e-df02-4a6c-aae0-9b00c5b9c1ec"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9cc2a9c-7773-4550-90bf-28d594b63cda'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="d9cc2a9c-7773-4550-90bf-28d594b63cda"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8ed6d410-d590-4875-94e9-a069682baf1d"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7f5bced-ec7f-4a06-84c4-26bbca9ff665'>ToCode</a></td><td style='width:75%' ><p><a name="b7f5bced-ec7f-4a06-84c4-26bbca9ff665"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="e1d43ada-98d6-4e7c-845e-926c1bb9471f"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e20527c9-d871-437a-97b6-44f8c2b7c593"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="3805e111-e4ab-421b-98fb-aff2be646807"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe724056-934a-4f52-8347-a3f41bf0fbb4'>Clone</a></td><td style='width:75%' class='def'><p><a name="fe724056-934a-4f52-8347-a3f41bf0fbb4"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoOval</code>.</p>
</td></tr></table></p>


---

<a name="302d607b-fa7d-4b05-9978-dc5018edd7d2"></a>
##KimonoShapePolygon

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a multi-sided polygon into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4fee6091-542e-496b-88ee-c4d7925df964'>NumberOfSides</a></td><td style='width:75%' ><p><a name="4fee6091-542e-496b-88ee-c4d7925df964"></a></p>

<h3>NumberOfSides</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of sides.</p>

<h4>Return Value</h4>

<p>The number of sides.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11895774-e360-4baf-a852-59adb132d1f0'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="11895774-e360-4baf-a852-59adb132d1f0"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d54f49b9-0f89-4160-9519-72917549de52'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="d54f49b9-0f89-4160-9519-72917549de52"></a></p>

<h3>KimonoShapePolygon ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#302d607b-fa7d-4b05-9978-dc5018edd7d2">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69b64e22-c673-4eba-b694-485795a134d5'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p><a name="69b64e22-c673-4eba-b694-485795a134d5"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#302d607b-fa7d-4b05-9978-dc5018edd7d2">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="688b1bdf-b41a-45a9-8f93-dfaeea65f0cd"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6b66e1a6-5684-4d5a-8f0d-6c27e3ed1d8d"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ad7a2bc8-440a-45a4-829d-581fab945948"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="954ae6d8-38bd-4b1a-8a55-cfbbb801aaac"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abe790d8-de6e-4d47-baeb-3077f5bd0eb1'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="abe790d8-de6e-4d47-baeb-3077f5bd0eb1"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#302d607b-fa7d-4b05-9978-dc5018edd7d2">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9db14f54-d505-4339-a2b2-5e00c759732d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="b8303bbe-b6f8-45f7-a701-aafbc56dfd0e"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="3b7a82b7-b102-4791-8b91-a07a9772bfcb"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="73536440-fc3f-4f23-a515-bc064a4d6b50"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="7c80bfdc-9333-44bc-b445-2ff490e40e49"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67ded8c4-f3c9-4961-9260-9f089d4c8119'>Initialize</a></td><td style='width:75%' class='def'><p><a name="67ded8c4-f3c9-4961-9260-9f089d4c8119"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df6a2ea7-0546-46ae-9c3a-fc8fb93a2219'>MakeSidePoints</a></td><td style='width:75%' ><p><a name="df6a2ea7-0546-46ae-9c3a-fc8fb93a2219"></a></p>

<h3>MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="76da1dfe-fa84-45c5-815e-b38c4d8c64e8"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="d46dcb94-7b8b-41d2-8117-e3474e07d50d"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="e50a387d-0de0-443a-87a6-8b270c3cb437"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="1a8e4e48-7ce4-4d0a-b138-d922e643e149"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#679c01bc-25f1-4422-a255-658a0d656292'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="679c01bc-25f1-4422-a255-658a0d656292"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="2ab05541-f62c-476d-a5b5-8e4a86ff0d0b"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64be794e-596d-4aea-a752-8d704a6633c9'>ToPath</a></td><td style='width:75%' ><p><a name="64be794e-596d-4aea-a752-8d704a6633c9"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27e9edd7-ab2b-4dde-90a7-0a66fbbd7c8d'>Draw</a></td><td style='width:75%' class='def'><p><a name="27e9edd7-ab2b-4dde-90a7-0a66fbbd7c8d"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the polygon into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="c44f1dd4-672f-48b3-a660-e6b7d0c26d87"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44c8d6d6-7833-4f0b-9ad8-d4701c699cf4'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="44c8d6d6-7833-4f0b-9ad8-d4701c699cf4"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05a17182-5836-45ee-a9b2-9a575578d01f'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="05a17182-5836-45ee-a9b2-9a575578d01f"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2b44f1d-c3eb-4a12-9e70-ab335b8d6be5'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="d2b44f1d-c3eb-4a12-9e70-ab335b8d6be5"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9aac03f7-06d4-4584-ae81-42cb713ab9a7'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="9aac03f7-06d4-4584-ae81-42cb713ab9a7"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d43752a8-77d2-44c2-9804-6ac689726a7e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#172d654c-aee9-40d8-98c4-82716545a582'>ToCode</a></td><td style='width:75%' ><p><a name="172d654c-aee9-40d8-98c4-82716545a582"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="1b1c97b8-8208-44b8-8121-342d5cdf4887"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8a816e41-036e-4554-a483-f4f6ab349175"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="01584d0b-cfc4-445b-b1e5-7fbf6cc7d20d"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24728417-c8ce-4b95-a2cc-222bc2ae00e1'>Clone</a></td><td style='width:75%' class='def'><p><a name="24728417-c8ce-4b95-a2cc-222bc2ae00e1"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoPloygon</code>.</p>
</td></tr></table></p>


---

<a name="ca0b823a-f127-4fba-b432-471416e39668"></a>
##KimonoShapeRect

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#74939a7e-c0e8-4b69-81bf-aaef8690fb41'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="74939a7e-c0e8-4b69-81bf-aaef8690fb41"></a></p>

<h3>KimonoShapeRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ca0b823a-f127-4fba-b432-471416e39668">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dd5d14f-9f39-490a-ba0a-06f323557747'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p><a name="9dd5d14f-9f39-490a-ba0a-06f323557747"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ca0b823a-f127-4fba-b432-471416e39668">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9b8819ab-1dd2-428c-b192-d77ea02d71bd"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="ce6d014b-2a4a-4b74-ba9c-01affe7fa607"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="714a5a0e-f9c8-4bf0-9146-0dfae3a4b483"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="c1f567c5-6e39-40ef-b2f5-ce830ef97d7a"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#556c2eb2-59df-4f92-93b0-5adc17e3a434'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="556c2eb2-59df-4f92-93b0-5adc17e3a434"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ca0b823a-f127-4fba-b432-471416e39668">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="852d1137-f795-44ec-9c64-57f5d96c3aab"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a03befa5-72c2-459f-b87b-48cdbbd9b0b8"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="35a04fd5-5257-4fcf-938d-f8ed29d503b1"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b6d9f81e-22f2-42e2-8998-d2712b2602b9"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="e8b76f18-06dc-4553-b0fc-8f55d07b9fda"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49eaaf4a-42f1-4ab9-b36e-29831ef03636'>Initialize</a></td><td style='width:75%' class='def'><p><a name="49eaaf4a-42f1-4ab9-b36e-29831ef03636"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25fc13c6-f345-40a2-abb6-6719511091d3'>ToPath</a></td><td style='width:75%' ><p><a name="25fc13c6-f345-40a2-abb6-6719511091d3"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b62c823c-f8a9-44d6-85a2-35520e6052f5'>Draw</a></td><td style='width:75%' class='def'><p><a name="b62c823c-f8a9-44d6-85a2-35520e6052f5"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="37097a2f-2263-49e8-88ec-c6a0e82b8060"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3dc47f5-2326-4831-81fa-d33a49c39f16'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="e3dc47f5-2326-4831-81fa-d33a49c39f16"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92d65299-45d6-40c4-9ad9-16e12d483ad6'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="92d65299-45d6-40c4-9ad9-16e12d483ad6"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4722180-a0b0-4e5a-a6b8-61d22d919376'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="d4722180-a0b0-4e5a-a6b8-61d22d919376"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d564dc8-70fb-4a55-937b-09feba05aecb'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="3d564dc8-70fb-4a55-937b-09feba05aecb"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="1847c217-5d6f-4964-b779-0cb917af0304"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90367a81-2f20-4df6-8585-582512a375b2'>ToCode</a></td><td style='width:75%' ><p><a name="90367a81-2f20-4df6-8585-582512a375b2"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="42a47cd7-6498-4af3-a5fb-5cd6e689c79c"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="3371e97e-37c0-4294-82d8-48ef8d5de077"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="bf37e248-e1f5-4c59-9b43-31c15b9f546f"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f283bbe5-60d5-4a95-9cd8-3fde9a6ef3c2'>Clone</a></td><td style='width:75%' class='def'><p><a name="f283bbe5-60d5-4a95-9cd8-3fde9a6ef3c2"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="629909ad-04aa-4750-84ca-c8faa6b0a5ce"></a>
##KimonoShapeRoundRect

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a rounded rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d2fb4f3b-97a7-4a55-baf2-aed886d2f3c2'>CornerRadius</a></td><td style='width:75%' ><p><a name="d2fb4f3b-97a7-4a55-baf2-aed886d2f3c2"></a></p>

<h3>CornerRadius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the corner radius.</p>

<h4>Return Value</h4>

<p>The corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d6f5c27-98ef-4c92-a1be-e4ee6ea51e8d'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="1d6f5c27-98ef-4c92-a1be-e4ee6ea51e8d"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9b3e6fe5-828a-44b0-8bf3-ca27b736bdd4'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="9b3e6fe5-828a-44b0-8bf3-ca27b736bdd4"></a></p>

<h3>KimonoShapeRoundRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#629909ad-04aa-4750-84ca-c8faa6b0a5ce">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29a90045-d54a-4697-b277-7bc72e991a29'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="29a90045-d54a-4697-b277-7bc72e991a29"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#629909ad-04aa-4750-84ca-c8faa6b0a5ce">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="bd142a88-5c8a-4aaf-8cfa-7a687e7e27f1"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="d640ffa0-aa52-4364-af13-786d3d2f90e3"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="cf9f1c07-07d0-43f8-ab04-d8f951abfc1b"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="8cc6d54d-bea0-4585-a0aa-fda774395be8"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1565926c-08e2-425a-a74e-7f1210f427fe'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="1565926c-08e2-425a-a74e-7f1210f427fe"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#629909ad-04aa-4750-84ca-c8faa6b0a5ce">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="7894710e-933e-4638-9528-8b9c6b165fb7"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c4527bcb-e2cc-4af2-b2a3-8423b1bfe744"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="87b13a29-5368-44c5-8085-3519adb2111f"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="803753fc-dd80-47c6-8da7-33f79fe225bf"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="88fed8af-38df-40fe-8ab8-3974ea4e6874"></a>
Corner radius.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a1b1419-9911-4c7f-976c-776f07622582'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="4a1b1419-9911-4c7f-976c-776f07622582"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#629909ad-04aa-4750-84ca-c8faa6b0a5ce">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="94a5da1d-170f-494d-833b-00c33151f61f"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="1afbde85-8ba2-461a-8998-c9786e47858c"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="0ea02bb2-7f0d-4cd3-9d26-cb4daa1330a7"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bde211d0-b83e-4ae3-a3ff-b904334d8ce9"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="4ecd83cb-73a5-4be1-bf82-5f220f1d0375"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8588e369-216c-4a15-91fd-b133e11bc4ca'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="8588e369-216c-4a15-91fd-b133e11bc4ca"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#629909ad-04aa-4750-84ca-c8faa6b0a5ce">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="be3c4ba1-e96b-417f-8ae3-2d8677857c42"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="b536e717-0ae5-4941-b2ce-43333965a0a1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="1b65e827-76b1-4e3f-a515-bffb46a58c2b"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="cc9f3e31-9752-4482-86fd-c1240f36b3f0"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="c246d7d5-2cd3-4014-88fc-c2031cde86e6"></a>
Corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="d6ec27ac-7956-4336-a8ac-7842bacaac18"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01143c6d-475b-482f-b5ba-33c9b3a4fd51'>Initialize</a></td><td style='width:75%' class='def'><p><a name="01143c6d-475b-482f-b5ba-33c9b3a4fd51"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f90c9f3-f6f7-4f80-b911-df2d666e1eb1'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="1f90c9f3-f6f7-4f80-b911-df2d666e1eb1"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="2db1a996-6665-470a-8fbc-e16c363f6170"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0d1a777-6766-4799-a5b8-e7c4f5f2d522'>ToPath</a></td><td style='width:75%' class='def'><p><a name="d0d1a777-6766-4799-a5b8-e7c4f5f2d522"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dedd4d64-d5ce-48e6-979a-8aaa2d1158f8'>Draw</a></td><td style='width:75%' ><p><a name="dedd4d64-d5ce-48e6-979a-8aaa2d1158f8"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the round rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="23bafa1d-db28-43cc-8c09-68984f8d9520"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#962204dc-1dcc-4c9c-8e3a-a16895e4d176'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="962204dc-1dcc-4c9c-8e3a-a16895e4d176"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c9a7575-9559-44b6-9a81-9ff90417cdc8'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="8c9a7575-9559-44b6-9a81-9ff90417cdc8"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53dba1f3-5a80-4fdd-aa43-04e309e4d94b'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="53dba1f3-5a80-4fdd-aa43-04e309e4d94b"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f8111e4-5f7a-46d8-8425-c163bf58796d'>ToCSharp</a></td><td style='width:75%' ><p><a name="1f8111e4-5f7a-46d8-8425-c163bf58796d"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="93917c9a-df4b-41c2-8a5f-05dd431af714"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#599ab868-87a8-4d46-8845-8e36cd743a3a'>ToCode</a></td><td style='width:75%' class='def'><p><a name="599ab868-87a8-4d46-8845-8e36cd743a3a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="dcc72008-ce78-4a92-bac4-371d75af7695"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="405aa217-53ee-4b31-9459-895eb953e76a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6ea2f7b9-eacc-43fb-81ba-f2018a257a55"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4d04d15-b896-4345-a608-aa870c70ee57'>Clone</a></td><td style='width:75%' ><p><a name="a4d04d15-b896-4345-a608-aa870c70ee57"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeRoundRect</code>.</p>
</td></tr></table></p>


---

<a name="f92fcb7d-1cc7-48aa-9a7c-65539304d244"></a>
##KimonoShapeStar

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a multi-sided star shape into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0adb0bce-b9d3-489b-8b51-f55d251a7e9a'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="0adb0bce-b9d3-489b-8b51-f55d251a7e9a"></a></p>

<h3>NumberOfPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of points.</p>

<h4>Return Value</h4>

<p>The number of points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#483e2f3d-253f-4b70-ba87-6bd0bcc9f1d4'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="483e2f3d-253f-4b70-ba87-6bd0bcc9f1d4"></a></p>

<h3>SkipPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the skip points.</p>

<h4>Return Value</h4>

<p>The skip points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71f9ac6e-75ca-43f4-bb5a-634cecea2da4'>DepthOffset</a></td><td style='width:75%' ><p><a name="71f9ac6e-75ca-43f4-bb5a-634cecea2da4"></a></p>

<h3>DepthOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the depth offset for the individual points.</p>

<h4>Return Value</h4>

<p>The depth offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab74f956-3ebd-414c-ba0f-56dcfca13f3a'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="ab74f956-3ebd-414c-ba0f-56dcfca13f3a"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f878be19-ecdb-4c3d-af06-a41acf8a8597'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="f878be19-ecdb-4c3d-af06-a41acf8a8597"></a></p>

<h3>KimonoShapeStar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f92fcb7d-1cc7-48aa-9a7c-65539304d244">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#442f6f16-3376-4cba-bdbe-07b55aa811e2'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p><a name="442f6f16-3376-4cba-bdbe-07b55aa811e2"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f92fcb7d-1cc7-48aa-9a7c-65539304d244">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6e256ea5-63f0-4a4d-a4b4-651d88a95d23"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="bdafffa1-9f01-4277-a29e-2a99a330e927"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="c7ef1322-c868-4279-b813-acd2c2272c8a"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="32c1b28e-d755-4812-a76e-369a3fc448f7"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92c9de52-0e1e-4b93-87c8-4fce5960ccc3'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="92c9de52-0e1e-4b93-87c8-4fce5960ccc3"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f92fcb7d-1cc7-48aa-9a7c-65539304d244">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9620324c-e093-42bf-92bb-54f95f7a5cf5"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="534f2b17-89ec-44f3-a8c0-99fba7566ad3"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b31713ac-d7f6-4dd8-870c-4bf06b8262f2"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="828ecbf8-efee-4b25-ad41-a1d1438e9291"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="f3629f40-d483-42b8-af4d-5ee291d73ef7"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb1f6395-384d-4a62-a5d4-8f98d5820df0'>Initialize</a></td><td style='width:75%' class='def'><p><a name="eb1f6395-384d-4a62-a5d4-8f98d5820df0"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#979eb8b2-d9fc-4d21-b6bc-5ebe7f9c1f6c'>MakeStarPoints</a></td><td style='width:75%' ><p><a name="979eb8b2-d9fc-4d21-b6bc-5ebe7f9c1f6c"></a></p>

<h3>MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="c9abaa19-21d6-4355-8ef9-c426874712b9"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="d7a267c2-3d06-45b5-961c-87056fa2e94b"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="edbf8b19-8761-44ad-bed6-e1639a2122f4"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="751f6aba-28cf-48a8-97c5-1afbd254270b"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c015bb8-4976-4b55-a02a-3c82c1aa82b7'>CalculateConcaveRadius</a></td><td style='width:75%' class='def'><p><a name="7c015bb8-4976-4b55-a02a-3c82c1aa82b7"></a></p>

<h3>CalculateConcaveRadius (System.Int32, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Calculates the concave radius.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p><a name="3b30e73e-96d7-4371-b4cd-5d2d16b7a560"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p><a name="cd18192a-ce7c-4804-80f8-055d0a159284"></a>
Skip.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The concave radius.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75403ff2-c1c7-4047-84ee-cc136730aa9c'>FindIntersection</a></td><td style='width:75%' ><p><a name="75403ff2-c1c7-4047-84ee-cc136730aa9c"></a></p>

<h3>FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean@, System.Boolean@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the intersection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p><a name="76d9795e-2c57-4ae9-bb0e-7371aae0a5cb"></a>
P1.</p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p><a name="932cb373-1e8c-4953-9a8d-273c5526acd4"></a>
P2.</p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p><a name="0c446667-0c7a-4a77-a141-b7da0e603826"></a>
P3.</p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p><a name="7c5d26d7-785f-43e0-9971-5179061ebb2f"></a>
P4.</p>
</td></tr><tr><td style='width:25%' class='term'>lines_intersect</td><td style='width:75%' ><p><a name="efb93ace-1a39-49f3-9177-7794d54b9ee6"></a>
If set to <code>true</code> lines intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>segments_intersect</td><td style='width:75%' class='def'><p><a name="7fcec06e-8e11-4295-b512-699f66cdd88d"></a>
If set to <code>true</code> segments intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>intersection</td><td style='width:75%' ><p><a name="7aecff23-33c3-41ec-838e-70000fdc48a9"></a>
Intersection.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p1</td><td style='width:75%' class='def'><p><a name="40af2f71-5db1-4ea7-92c2-a41982bc7c82"></a>
Close p1.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p2</td><td style='width:75%' ><p><a name="8bda3ca9-00d6-4aa2-acaa-38186ff65e9a"></a>
Close p2.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f266577-3b17-4de0-9479-90dae40aa54d'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="2f266577-3b17-4de0-9479-90dae40aa54d"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="03b5b461-05a2-4ba3-a467-ee4e73ffbf72"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b2784d8-0924-442b-bd70-0f2bc064abed'>ToPath</a></td><td style='width:75%' ><p><a name="0b2784d8-0924-442b-bd70-0f2bc064abed"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9402467-e55d-4d22-9d2a-2e10e1d9805f'>Draw</a></td><td style='width:75%' class='def'><p><a name="a9402467-e55d-4d22-9d2a-2e10e1d9805f"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the star into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="f7836f65-d8a4-43d3-82fb-93635ceb2a82"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b7d7893-77ac-40cb-97d6-588c619e4ede'>ToVector</a></td><td style='width:75%' ><p><a name="0b7d7893-77ac-40cb-97d6-588c619e4ede"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the star into a vector.</p>

<h4>Returns</h4>

<p>The <code>KimonoShapeVector</code> version of the star.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b641f2f8-ca47-429a-84a3-ba238113c5a0'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="b641f2f8-ca47-429a-84a3-ba238113c5a0"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15caac5b-abbe-44ac-9a9b-c41428c90487'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="15caac5b-abbe-44ac-9a9b-c41428c90487"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c733b92a-63c2-4dc8-8f48-79c504da81f2'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="c733b92a-63c2-4dc8-8f48-79c504da81f2"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#902ad9d4-1623-46a4-b284-40fcde2244b2'>ToCSharp</a></td><td style='width:75%' ><p><a name="902ad9d4-1623-46a4-b284-40fcde2244b2"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b236da3b-316a-4611-9f85-ca5814d38cec"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a9e082c-4487-41fc-98ef-b052f7cc9cac'>ToCode</a></td><td style='width:75%' class='def'><p><a name="9a9e082c-4487-41fc-98ef-b052f7cc9cac"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="9193fbb0-df70-48ed-b7ce-0a02426195af"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="0419e07c-14e3-4d99-806a-82ea4f96c208"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="611b3b72-cd06-4419-8397-f5a6d020e909"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2840345-ada6-47aa-b4e8-7474364edaed'>Clone</a></td><td style='width:75%' ><p><a name="e2840345-ada6-47aa-b4e8-7474364edaed"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeStar</code>.</p>
</td></tr></table></p>


---

<a name="bd3dcbc2-9a02-46b8-81db-cc253fd53092"></a>
##KimonoShapeState

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Holds the current state of a `KimonoShape` while it is being edited by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f095d6ed-4a08-4c7f-a27f-45a145651afd'>Unselected</a></td><td style='width:75%' ><p><a name="f095d6ed-4a08-4c7f-a27f-45a145651afd"></a>
<b>Unselected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is unselected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da1a0e6d-af7d-4607-ad92-8526c3eacaf8'>Selected</a></td><td style='width:75%' class='def'><p><a name="da1a0e6d-af7d-4607-ad92-8526c3eacaf8"></a>
<b>Selected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76f4b8a7-c0c2-45c6-9079-58c8874ba159'>Editing</a></td><td style='width:75%' ><p><a name="76f4b8a7-c0c2-45c6-9079-58c8874ba159"></a>
<b>Editing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#915e18a2-f7c5-49b6-b885-f01d6d4ae56c'>Finalizing</a></td><td style='width:75%' class='def'><p><a name="915e18a2-f7c5-49b6-b885-f01d6d4ae56c"></a>
<b>Finalizing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is leaving the edit mode and needs to be completed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cb40771-5f40-4b85-b7a6-2b6b83c8e23a'>Constructing</a></td><td style='width:75%' ><p><a name="0cb40771-5f40-4b85-b7a6-2b6b83c8e23a"></a>
<b>Constructing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the process of being built. For example, a set of shapes being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cfcbc75-74af-46fd-a46f-06a6ed3061f6'>Grouping</a></td><td style='width:75%' class='def'><p><a name="7cfcbc75-74af-46fd-a46f-06a6ed3061f6"></a>
<b>Grouping</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being added to a group.</p>
</td></tr></table></p>


---

<a name="a045ad92-135c-4664-9850-30e018da9a53"></a>
##KimonoShapeText

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a block of text into the Design Surface within the specifid bounds of this shape.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aabdbf60-a93d-4c11-aedc-f7a8e7eb9bf8'>Text</a></td><td style='width:75%' ><p><a name="aabdbf60-a93d-4c11-aedc-f7a8e7eb9bf8"></a></p>

<h3>Text</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text.</p>

<h4>Return Value</h4>

<p>The text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b05fc5e0-27d0-4307-a0aa-df6d7ade6b8e'>FontMetrics</a></td><td style='width:75%' class='def'><p><a name="b05fc5e0-27d0-4307-a0aa-df6d7ade6b8e"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65699f11-e607-4cfa-8958-b3556c53f5c7'>IsLinearText</a></td><td style='width:75%' ><p><a name="65699f11-e607-4cfa-8958-b3556c53f5c7"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#627e5f52-b897-4d84-83e2-d4220d4d20d6'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="627e5f52-b897-4d84-83e2-d4220d4d20d6"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c8f0605-5e73-4e35-9fc2-6cf476584f0e'>StrikeThruText</a></td><td style='width:75%' ><p><a name="6c8f0605-5e73-4e35-9fc2-6cf476584f0e"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e4a28e6-e9f6-4d90-bfdc-90577d31dc64'>TextAlign</a></td><td style='width:75%' class='def'><p><a name="7e4a28e6-e9f6-4d90-bfdc-90577d31dc64"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d77696a-1a1a-4c5a-aa18-00506e41d9e5'>TextEncoding</a></td><td style='width:75%' ><p><a name="2d77696a-1a1a-4c5a-aa18-00506e41d9e5"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a14b2aed-1cc9-4eb1-8ac3-bd86f4c8b287'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="a14b2aed-1cc9-4eb1-8ac3-bd86f4c8b287"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c429a91e-098d-4427-bab3-44030e9b142f'>TextSize</a></td><td style='width:75%' ><p><a name="c429a91e-098d-4427-bab3-44030e9b142f"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc99027d-0335-4fca-8aac-4cbab632b519'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="bc99027d-0335-4fca-8aac-4cbab632b519"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f474932f-fee8-47d3-a74e-87aad7912672'>Typeface</a></td><td style='width:75%' ><p><a name="f474932f-fee8-47d3-a74e-87aad7912672"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b86a3d55-a2a0-4f6c-adff-c64c7440a2c8'>FontFamilyName</a></td><td style='width:75%' class='def'><p><a name="b86a3d55-a2a0-4f6c-adff-c64c7440a2c8"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ae8327a-03e8-477c-8042-d1c5b3885531'>TypefaceStyle</a></td><td style='width:75%' ><p><a name="9ae8327a-03e8-477c-8042-d1c5b3885531"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79505d1a-cc7d-4d97-a8b7-1644273088c6'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="79505d1a-cc7d-4d97-a8b7-1644273088c6"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#caed6303-fa22-4e9d-8bfd-53dc1aa2336f'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="caed6303-fa22-4e9d-8bfd-53dc1aa2336f"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9d2272e1-32bd-4a55-b4b1-4edb483dfed1'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="9d2272e1-32bd-4a55-b4b1-4edb483dfed1"></a></p>

<h3>KimonoShapeText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20198f42-8883-44f3-8b23-2be9bc4b87d9'>KimonoShapeText</a></td><td style='width:75%' class='def'><p><a name="20198f42-8883-44f3-8b23-2be9bc4b87d9"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="d1ce94ce-3b01-441f-b284-8b54a6781bd9"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="3075f9e8-efa2-4e91-924b-bc8c911a328b"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="55e09c9c-21c4-4b02-990b-904c341843e8"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b6a8e596-9176-4a41-bf2a-d3173f2fa733"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cee44107-9696-4cc3-a92b-5ff8fd09192c'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="cee44107-9696-4cc3-a92b-5ff8fd09192c"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a045ad92-135c-4664-9850-30e018da9a53">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="682c711a-7109-45bd-94f8-07d2e22a8310"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a1b0869b-968b-4d35-9f66-7a8d87b68005"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="1e97bfa9-1ae2-4057-b259-391389a97e15"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="8fe546b7-cf11-4de2-bbdc-136a1337db16"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="37c8dcdf-6e9b-4d8d-abd4-5313e2e7c141"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba1a9c9b-21f6-47ec-bfd1-84d2af61e1bf'>Initialize</a></td><td style='width:75%' class='def'><p><a name="ba1a9c9b-21f6-47ec-bfd1-84d2af61e1bf"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#695832e2-735d-4289-931f-8457d1e7ae23'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="695832e2-735d-4289-931f-8457d1e7ae23"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="d3542b00-e6b5-4ba2-bb70-98cfc58e79ac"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#511fff1c-5431-424f-8f55-e6d6fc420563'>ToPath</a></td><td style='width:75%' class='def'><p><a name="511fff1c-5431-424f-8f55-e6d6fc420563"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fdef1b5-07c1-4169-b6bf-dddeb9c3c023'>Draw</a></td><td style='width:75%' ><p><a name="1fdef1b5-07c1-4169-b6bf-dddeb9c3c023"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the text block into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="cd5a6488-7217-4bb7-8217-39a312f25bea"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd57bc8b-1fe0-4070-b201-da9de560add0'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="cd57bc8b-1fe0-4070-b201-da9de560add0"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="0924a74b-8871-447b-ba52-4bfc8a82c200"></a>
The <code>SKPoint</code> to adjust the bounds by.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: Changing the bounds of a text box should optionally scale the size of the text within.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36f1cf20-5b21-4abe-a758-b66e0f94bffd'>DragBounds</a></td><td style='width:75%' ><p><a name="36f1cf20-5b21-4abe-a758-b66e0f94bffd"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="47308b9b-62f2-483a-922d-8512a4c46473"></a>
The <code>SKPoint</code> with the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e59bf2d0-49e3-48dc-a417-0176a84398c0'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="e59bf2d0-49e3-48dc-a417-0176a84398c0"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f0a7186-98dc-4463-944f-8676c6127974'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="2f0a7186-98dc-4463-944f-8676c6127974"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be8b1e61-25e3-4043-a92d-f2b46c476222'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="be8b1e61-25e3-4043-a92d-f2b46c476222"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63f29209-bba5-4ea2-b05b-53d0ae657433'>ToCSharp</a></td><td style='width:75%' ><p><a name="63f29209-bba5-4ea2-b05b-53d0ae657433"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="baf270e3-5c1c-4ad3-bbbd-4a5495eaca67"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a455e4d-67d5-49c0-88f4-fbd0e238fb2a'>ToCode</a></td><td style='width:75%' class='def'><p><a name="6a455e4d-67d5-49c0-88f4-fbd0e238fb2a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="484484fb-038d-4bbb-baf1-52442e07f315"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="dd08e292-b5d9-4aa4-b86c-37a2814b0d9a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9117b80f-2f23-4ff0-a29a-8c0a951adb27"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94f39799-dab9-47d7-8fb7-a2fa163c5b2e'>Clone</a></td><td style='width:75%' ><p><a name="94f39799-dab9-47d7-8fb7-a2fa163c5b2e"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeText</code>.</p>
</td></tr></table></p>


---

<a name="b323c416-06ca-44f1-830a-97d66fe8b496"></a>
##KimonoShapeTriangle

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Draws a triangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2c591c40-3662-4673-9c6f-097a450a5026'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="2c591c40-3662-4673-9c6f-097a450a5026"></a></p>

<h3>KimonoShapeTriangle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b323c416-06ca-44f1-830a-97d66fe8b496">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d300b5ec-4fab-4fde-82a1-628f13d5348a'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p><a name="d300b5ec-4fab-4fde-82a1-628f13d5348a"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b323c416-06ca-44f1-830a-97d66fe8b496">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="be190107-151c-4cda-ac7d-17d68f3eb5c1"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6d9ed7ab-000e-491c-a2f3-232dd0ce65ca"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="18e1b022-f6ce-471c-a902-b83c17ea39bb"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="870ccddc-5582-4e6c-9c37-c8b6cfff13f4"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d90a998d-4938-4397-807d-bf4e1754c4d5'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="d90a998d-4938-4397-807d-bf4e1754c4d5"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b323c416-06ca-44f1-830a-97d66fe8b496">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="d23da267-c342-433d-be31-b0331186a993"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="ef1934b6-21ed-499e-8d12-8289493c7b98"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="acf5295f-660e-4927-949c-f67ae19f5a22"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="71f5d2cc-9b7c-48a4-b636-782ccf6272d2"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="8e7cacec-4d11-4b27-942f-d61bc053a2ca"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5f10cd9-ea6b-4f0b-9984-8b489275da64'>Initialize</a></td><td style='width:75%' class='def'><p><a name="c5f10cd9-ea6b-4f0b-9984-8b489275da64"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39795aea-1a02-4ab2-9389-7a9b2310026b'>ToPath</a></td><td style='width:75%' ><p><a name="39795aea-1a02-4ab2-9389-7a9b2310026b"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66837c32-8653-4cd0-8af2-c4fd69437335'>Draw</a></td><td style='width:75%' class='def'><p><a name="66837c32-8653-4cd0-8af2-c4fd69437335"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the triangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="4f7c5bea-1337-4e3d-aae3-f12a08d26bf8"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f88fede2-c714-4d4e-bc38-19539f0e5933'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="f88fede2-c714-4d4e-bc38-19539f0e5933"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d58600f-cff1-459d-9176-9eef6a4f1cca'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="0d58600f-cff1-459d-9176-9eef6a4f1cca"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#364d38b6-5e54-417a-9477-e93e811d9b36'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="364d38b6-5e54-417a-9477-e93e811d9b36"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7b932d6-9343-43a8-906c-5b6daf1f8594'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="a7b932d6-9343-43a8-906c-5b6daf1f8594"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7146ee71-13ff-41de-a36f-edc698b2d164"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d9c7977-fd3b-4fd8-b1af-5e1a4f949779'>ToCode</a></td><td style='width:75%' ><p><a name="0d9c7977-fd3b-4fd8-b1af-5e1a4f949779"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="2cf8238d-c8a6-4f60-a742-6dd79a04863b"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="1c81c601-c9e7-4dbb-875f-2b7ef1505aec"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7cb7b7ef-be71-4192-94f0-8bea7653875a"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51a63cda-e55e-4438-8075-db81e57636e4'>Clone</a></td><td style='width:75%' class='def'><p><a name="51a63cda-e55e-4438-8075-db81e57636e4"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeTriangle</code>.</p>
</td></tr></table></p>


---

<a name="33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1"></a>
##KimonoShapeVector

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4e16e783-8163-4f0a-ad16-3099c108a1fa'>Points</a></td><td style='width:75%' ><p><a name="4e16e783-8163-4f0a-ad16-3099c108a1fa"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c63b2e9-4180-4da1-8318-8577d4c531bd'>Closed</a></td><td style='width:75%' class='def'><p><a name="6c63b2e9-4180-4da1-8318-8577d4c531bd"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a16daae6-1308-4dc2-83b5-7832309e5018'>IsEditable</a></td><td style='width:75%' ><p><a name="a16daae6-1308-4dc2-83b5-7832309e5018"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ae5df578-9ec9-45c2-8439-dad7ae9db249'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="ae5df578-9ec9-45c2-8439-dad7ae9db249"></a></p>

<h3>KimonoShapeVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcee08e1-602a-48f8-bfaa-095c2f73be83'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p><a name="fcee08e1-602a-48f8-bfaa-095c2f73be83"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="62f785fa-de96-40f3-9e1b-8db315710d2f"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="1de1c5da-1c10-4253-87e3-ca1abc8f5a9a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d74100f4-9bd7-415a-b738-ca1308d3e065"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f88849d9-646e-4d65-bd00-11be83606c1a"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fef04572-2ae1-44e2-bf0b-d77e741343ca'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="fef04572-2ae1-44e2-bf0b-d77e741343ca"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#33e2b611-4b6d-44ae-b9e4-58c53d7b8ea1">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6a5df4a9-a390-488a-bdcb-2ab87209470e"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e94d8936-1bc3-4b4f-8105-4289d49e1b2f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="7d746512-239f-474b-a760-11901f0568b4"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e6b435a3-9ee1-48f9-9335-90204c19e118"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="cc0efdb8-24de-4544-9ef8-8b0f6cd1a890"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c027b28-3179-4471-acab-de047b64c8cf'>Initialize</a></td><td style='width:75%' class='def'><p><a name="6c027b28-3179-4471-acab-de047b64c8cf"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#226db02f-e2ac-4e99-840f-2e05adf0442b'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="226db02f-e2ac-4e99-840f-2e05adf0442b"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e64bd167-ceda-4c64-b784-1a7f590c3592'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="e64bd167-ceda-4c64-b784-1a7f590c3592"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="a7ff6736-eed5-4fbc-bed8-dbdc6f919ba7"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="b7609a1e-84d3-4d7c-95f7-2d8397e741b3"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#593bf701-9f34-4d97-a865-b4c92df98d84'>AddPoint</a></td><td style='width:75%' ><p><a name="593bf701-9f34-4d97-a865-b4c92df98d84"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a3160d76-a36e-411c-ad22-995f76ba85ae"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fce87c5-65ff-4bcd-b459-557997cb7de9'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="6fce87c5-65ff-4bcd-b459-557997cb7de9"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="7465545f-3149-48f0-8352-57fbc5a0dc4e"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd341589-31d2-4395-b6c8-af41cfc0745e'>RemovePoint</a></td><td style='width:75%' ><p><a name="bd341589-31d2-4395-b6c8-af41cfc0745e"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="ab4cea1b-a8e7-4d3b-9956-995305f8414f"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#575d51f1-0fb9-4937-9b86-b4b4d564036a'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="575d51f1-0fb9-4937-9b86-b4b4d564036a"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54048e41-5fd0-4d73-8e94-0ceeedf9c263'>ToPath</a></td><td style='width:75%' ><p><a name="54048e41-5fd0-4d73-8e94-0ceeedf9c263"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5d2be15-60b8-4bcc-b841-afc91d054355'>Draw</a></td><td style='width:75%' class='def'><p><a name="c5d2be15-60b8-4bcc-b841-afc91d054355"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="e866ed32-8920-4d52-b969-815052ae5be2"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8520a00-f514-47f1-a3fc-83b8be5326d6'>PointInBound</a></td><td style='width:75%' ><p><a name="f8520a00-f514-47f1-a3fc-83b8be5326d6"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="6ab57e01-a87a-40d9-9028-27999d9e79ae"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34da5193-f07c-4122-9cff-3b439cc920f4'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="34da5193-f07c-4122-9cff-3b439cc920f4"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="12f73330-20db-4411-8aa7-19946c317061"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0342074-f195-4391-ab83-aa6c88750400'>BoundsChanged</a></td><td style='width:75%' ><p><a name="a0342074-f195-4391-ab83-aa6c88750400"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#117d54ba-f625-4398-afd0-f62c4fa7255b'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="117d54ba-f625-4398-afd0-f62c4fa7255b"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b57b4254-8a40-4156-9083-92e4e6e2e71e'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="b57b4254-8a40-4156-9083-92e4e6e2e71e"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8d1b760-7886-43c2-a716-f28e6a76f4f1'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="f8d1b760-7886-43c2-a716-f28e6a76f4f1"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2a7e5de-0567-4e30-93de-f60b8e446e2b'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="e2a7e5de-0567-4e30-93de-f60b8e446e2b"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0bbea4c-4b31-4c6f-a39c-c5b02afafb3e'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="b0bbea4c-4b31-4c6f-a39c-c5b02afafb3e"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d0e7a8c5-6981-4045-be09-2c4dfd1dd658"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9cc8edc0-6679-4a22-ae5c-40dec17dd26a'>ToCode</a></td><td style='width:75%' ><p><a name="9cc8edc0-6679-4a22-ae5c-40dec17dd26a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="9ed584c3-0ed1-47d9-9a68-ce2f0e7d4e4b"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="75ce5fef-c38f-49f8-adff-3d3fcbc2c12f"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8cfd1444-67c3-4936-915f-428c42c0d2b9"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b36376dd-61ae-4e74-96a6-1a844a693b77'>Clone</a></td><td style='width:75%' class='def'><p><a name="b36376dd-61ae-4e74-96a6-1a844a693b77"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="15bc4b30-d930-446d-be78-e8a76ae846b7"></a>
##KimonoProperty

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a property that can be attached to another Kimono object (such as a `KimonoColor`, `KimonoStyle` or `KimonoShape`) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7441e309-5bff-4a2b-ad0f-b3189e96bf1e'>UniqueID</a></td><td style='width:75%' ><p><a name="7441e309-5bff-4a2b-ad0f-b3189e96bf1e"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad7a31e3-db4f-4f60-8459-ee6f788fccd0'>Name</a></td><td style='width:75%' class='def'><p><a name="ad7a31e3-db4f-4f60-8459-ee6f788fccd0"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name as a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a710d75-8ea8-4846-bf54-82d79214dcf3'>Usage</a></td><td style='width:75%' ><p><a name="3a710d75-8ea8-4846-bf54-82d79214dcf3"></a></p>

<h3>Usage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the usage of this property.</p>

<h4>Return Value</h4>

<p>The <code>KimonoPropertyUsage</code> of this <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe4f1270-abb8-4b81-9bda-4f2fa8ab2409'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="fe4f1270-abb8-4b81-9bda-4f2fa8ab2409"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#15bc4b30-d930-446d-be78-e8a76ae846b7">KimonoProperty</a> is the result of an Obi Script.</p>

<h4>Return Value</h4>

<p><code>true</code> if is Obi Script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99d9a6e3-9e02-4bd9-878c-a1c94701f987'>ObiScript</a></td><td style='width:75%' ><p><a name="99d9a6e3-9e02-4bd9-878c-a1c94701f987"></a></p>

<h3>ObiScript</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the obi script that will be used to calculate the value of this <code>KimonoProperty</code>.</p>

<h4>Return Value</h4>

<p>The obi script.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2bc801a2-aabb-46a6-8ead-27b8920f34ca'>KimonoProperty</a></td><td style='width:75%' ><p><a name="2bc801a2-aabb-46a6-8ead-27b8920f34ca"></a></p>

<h3>KimonoProperty ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#15bc4b30-d930-446d-be78-e8a76ae846b7">KimonoProperty</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efa8bdbb-c0a6-4a2e-98a5-c1184553da35'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="efa8bdbb-c0a6-4a2e-98a5-c1184553da35"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10da2b48-1254-4e4d-af11-38b365bf2936'>ToRect</a></td><td style='width:75%' ><p><a name="10da2b48-1254-4e4d-af11-38b365bf2936"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96d4d537-3e9f-44fb-9fae-5e03d12d332a'>ToFloat</a></td><td style='width:75%' class='def'><p><a name="96d4d537-3e9f-44fb-9fae-5e03d12d332a"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0254bfef-cef0-42d7-851e-0933b6543b59'>ToInt</a></td><td style='width:75%' ><p><a name="0254bfef-cef0-42d7-851e-0933b6543b59"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fac0dabf-5624-46c5-a2e0-5a717fc29c2b'>ToStyle</a></td><td style='width:75%' class='def'><p><a name="fac0dabf-5624-46c5-a2e0-5a717fc29c2b"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b9a015f-1c8b-4691-bb83-c2789ff845c6'>ToBool</a></td><td style='width:75%' ><p><a name="6b9a015f-1c8b-4691-bb83-c2789ff845c6"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p>The <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55a94c23-67b2-40bf-9df2-93b0129700a6'>ToColor</a></td><td style='width:75%' class='def'><p><a name="55a94c23-67b2-40bf-9df2-93b0129700a6"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eb59231-d8f6-400d-90e2-342a9f2063dc'>ToGradient</a></td><td style='width:75%' ><p><a name="8eb59231-d8f6-400d-90e2-342a9f2063dc"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5281d3a-25ce-4425-b3eb-d55d8873834d'>Clone</a></td><td style='width:75%' class='def'><p><a name="f5281d3a-25ce-4425-b3eb-d55d8873834d"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="0a02f778-2f02-4752-b64a-d384a80d05f8"></a>
##KimonoPropertyUsage

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines how a `KimonoProperty` is used when it is attached to a `KimonoShape`, `KimonoSketch` or `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#10c082fc-248c-4f2f-b7af-a77510f27e0d'>LocalVariable</a></td><td style='width:75%' ><p><a name="10c082fc-248c-4f2f-b7af-a77510f27e0d"></a>
<b>LocalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a local variable in the  generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02b32488-d399-4526-921d-a9e3f4baa389'>GlobalVariable</a></td><td style='width:75%' class='def'><p><a name="02b32488-d399-4526-921d-a9e3f4baa389"></a>
<b>GlobalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a global variable in the generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aba7e8b6-7e4a-4e31-98c4-884e0175474d'>Parameter</a></td><td style='width:75%' ><p><a name="aba7e8b6-7e4a-4e31-98c4-884e0175474d"></a>
<b>Parameter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a passed parameter in the generated code for a Kimono object.</p>
</td></tr></table></p>


---

<a name="6eff130f-7847-461a-938d-4398ec2ab268"></a>
##KimonoPropertyConnectionPoint

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the point that a `KimonoProperty` value can be connected to another Kimono object such as the `Top` coordinate of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#122b509b-b0ba-4370-ba62-4d01f60b065e'>Undefined</a></td><td style='width:75%' ><p><a name="122b509b-b0ba-4370-ba62-4d01f60b065e"></a>
<b>Undefined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The connection point hasn't been defined.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12888d55-53e1-407d-9182-139168b958bf'>Rect</a></td><td style='width:75%' class='def'><p><a name="12888d55-53e1-407d-9182-139168b958bf"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The rectangle that defines the <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6b984a2-f587-41ca-aed5-f6ebdced0e5b'>Top</a></td><td style='width:75%' ><p><a name="d6b984a2-f587-41ca-aed5-f6ebdced0e5b"></a>
<b>Top</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Top coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#904de150-0a70-4c5d-9d5a-fa5b080f5c6b'>Left</a></td><td style='width:75%' class='def'><p><a name="904de150-0a70-4c5d-9d5a-fa5b080f5c6b"></a>
<b>Left</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Left coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#795eb529-7f1b-4458-99c2-34173740fe0c'>Bottom</a></td><td style='width:75%' ><p><a name="795eb529-7f1b-4458-99c2-34173740fe0c"></a>
<b>Bottom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Bottom coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18384432-08ac-4207-a867-27d8163427c0'>Right</a></td><td style='width:75%' class='def'><p><a name="18384432-08ac-4207-a867-27d8163427c0"></a>
<b>Right</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Right coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#155a4e1a-aec7-4a44-9bc0-f2db2aec858f'>Width</a></td><td style='width:75%' ><p><a name="155a4e1a-aec7-4a44-9bc0-f2db2aec858f"></a>
<b>Width</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Widht of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d41da7f5-95e9-4589-872a-9571d036f128'>Height</a></td><td style='width:75%' class='def'><p><a name="d41da7f5-95e9-4589-872a-9571d036f128"></a>
<b>Height</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Height of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f51ae5d8-b78d-4492-aca5-c9a5d3fa255f'>RotationDegrees</a></td><td style='width:75%' ><p><a name="f51ae5d8-b78d-4492-aca5-c9a5d3fa255f"></a>
<b>RotationDegrees</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Rotational Degrees of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e489a74e-c6f1-4a67-b0fb-f13d2a8d4f58'>Style</a></td><td style='width:75%' class='def'><p><a name="e489a74e-c6f1-4a67-b0fb-f13d2a8d4f58"></a>
<b>Style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The <code>KimonoStyle</code> of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da87b4ef-5b5e-42b4-a593-ac3a884faa47'>Visible</a></td><td style='width:75%' ><p><a name="da87b4ef-5b5e-42b4-a593-ac3a884faa47"></a>
<b>Visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfaebf36-a1ad-4117-a578-d397e373b6da'>HasStartHead</a></td><td style='width:75%' class='def'><p><a name="cfaebf36-a1ad-4117-a578-d397e373b6da"></a>
<b>HasStartHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has start head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4aaf6050-91c0-4c5d-bb0b-82e196631991'>HasEndHead</a></td><td style='width:75%' ><p><a name="4aaf6050-91c0-4c5d-bb0b-82e196631991"></a>
<b>HasEndHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has end head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47e5ced4-d3e6-46a6-83fc-5f640fd6e426'>HeadInnerRatio</a></td><td style='width:75%' class='def'><p><a name="47e5ced4-d3e6-46a6-83fc-5f640fd6e426"></a>
<b>HeadInnerRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head inner ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7d01a8f-ce09-447b-ab7e-a720f12f9fc5'>HeadOuterRatio</a></td><td style='width:75%' ><p><a name="f7d01a8f-ce09-447b-ab7e-a720f12f9fc5"></a>
<b>HeadOuterRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head outer ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d45dfbf8-a7f3-4c25-93ef-072ee8697ade'>IsStreamlined</a></td><td style='width:75%' class='def'><p><a name="d45dfbf8-a7f3-4c25-93ef-072ee8697ade"></a>
<b>IsStreamlined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is streamlined of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c2880c4-f843-44e5-a737-1164189888ef'>NumberOfSides</a></td><td style='width:75%' ><p><a name="2c2880c4-f843-44e5-a737-1164189888ef"></a>
<b>NumberOfSides</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of sides of a <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b72407b2-bd99-4d09-a3db-6308a0d885c6'>CornerRadius</a></td><td style='width:75%' class='def'><p><a name="b72407b2-bd99-4d09-a3db-6308a0d885c6"></a>
<b>CornerRadius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The corner radius of a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32ef925e-b895-4305-9ace-219b0871dcb2'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="32ef925e-b895-4305-9ace-219b0871dcb2"></a>
<b>NumberOfPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf9b93f0-6e74-415e-944e-54ac050d81e3'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="bf9b93f0-6e74-415e-944e-54ac050d81e3"></a>
<b>SkipPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The skip points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1721b195-b0b2-45dd-ae6f-8897ac8bdf34'>DepthOffset</a></td><td style='width:75%' ><p><a name="1721b195-b0b2-45dd-ae6f-8897ac8bdf34"></a>
<b>DepthOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The depth offset of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50a8fbe4-3c86-422a-8978-87d498d79eaa'>Text</a></td><td style='width:75%' class='def'><p><a name="50a8fbe4-3c86-422a-8978-87d498d79eaa"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text of a <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#134ab376-81e4-463b-a138-13d91bd921bb'>BaseColor</a></td><td style='width:75%' ><p><a name="134ab376-81e4-463b-a138-13d91bd921bb"></a>
<b>BaseColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base color of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c7cea53-d832-49e2-a9c4-8c7645fc5499'>AdjustsHue</a></td><td style='width:75%' class='def'><p><a name="7c7cea53-d832-49e2-a9c4-8c7645fc5499"></a>
<b>AdjustsHue</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts hue of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df817f56-f099-4742-9342-c690743eb877'>HueAdjustment</a></td><td style='width:75%' ><p><a name="df817f56-f099-4742-9342-c690743eb877"></a>
<b>HueAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The hue adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94bb8c4e-e2df-4c77-96a7-51e13f7089a1'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p><a name="94bb8c4e-e2df-4c77-96a7-51e13f7089a1"></a>
<b>AdjustsSaturation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts saturation of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2723a52-31eb-4e72-9a6b-233a09799fac'>SaturationAdjustment</a></td><td style='width:75%' ><p><a name="e2723a52-31eb-4e72-9a6b-233a09799fac"></a>
<b>SaturationAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The saturation adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#839fbd37-29dc-45a0-a112-dcb5009fcfff'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p><a name="839fbd37-29dc-45a0-a112-dcb5009fcfff"></a>
<b>AdjustsBrightness</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts brightness of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c592fac1-9944-47f2-8cae-3a6982c46812'>BrightnessAdjustment</a></td><td style='width:75%' ><p><a name="c592fac1-9944-47f2-8cae-3a6982c46812"></a>
<b>BrightnessAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The brightness adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38751c35-7c1d-4667-8d73-33f0833464fa'>AdjustsAlpha</a></td><td style='width:75%' class='def'><p><a name="38751c35-7c1d-4667-8d73-33f0833464fa"></a>
<b>AdjustsAlpha</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts alpha of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#991acab7-31f5-488f-a7b0-484f2e9c519d'>AlphaAdjustment</a></td><td style='width:75%' ><p><a name="991acab7-31f5-488f-a7b0-484f2e9c519d"></a>
<b>AlphaAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The alpha adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30fbb1be-52d2-4ab6-b14a-725268f9a6cb'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="30fbb1be-52d2-4ab6-b14a-725268f9a6cb"></a>
<b>HasFrame</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa692682-c75a-497f-816b-6d88bb398037'>HasFrameBlur</a></td><td style='width:75%' ><p><a name="aa692682-c75a-497f-816b-6d88bb398037"></a>
<b>HasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20ac6cff-6787-4984-a9c5-879a1a2d75f6'>FrameHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="20ac6cff-6787-4984-a9c5-879a1a2d75f6"></a>
<b>FrameHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a616b817-fe10-46df-80b3-1a6c9a09e8a6'>FrameVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="a616b817-fe10-46df-80b3-1a6c9a09e8a6"></a>
<b>FrameVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e60351f-5300-425d-b5b8-80835d8c18a1'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="4e60351f-5300-425d-b5b8-80835d8c18a1"></a>
<b>HasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5d658ac-7c5e-4fd3-9e23-a1dfce4fe21e'>FrameShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="a5d658ac-7c5e-4fd3-9e23-a1dfce4fe21e"></a>
<b>FrameShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2717bea1-d1c3-4228-bf0c-1acfcd036090'>FrameShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="2717bea1-d1c3-4228-bf0c-1acfcd036090"></a>
<b>FrameShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7742d835-cd68-4e6a-9d7d-68b51bf3b258'>FrameShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="7742d835-cd68-4e6a-9d7d-68b51bf3b258"></a>
<b>FrameShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow horizontal blur amount of a `KimonoStyle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#125f7282-8910-465d-bcfd-80d6c953ef7a'>FrameShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="125f7282-8910-465d-bcfd-80d6c953ef7a"></a>
<b>FrameShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56b0547c-93fd-4095-9b0d-9b725786eaee'>FrameShadowLinkedColor</a></td><td style='width:75%' ><p><a name="56b0547c-93fd-4095-9b0d-9b725786eaee"></a>
<b>FrameShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f40c7a9-e03f-4217-9390-662ecdac52a3'>HasFill</a></td><td style='width:75%' class='def'><p><a name="0f40c7a9-e03f-4217-9390-662ecdac52a3"></a>
<b>HasFill</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#451bcd29-820f-42e3-b3c0-bc1b333c8f0c'>HasFillBlur</a></td><td style='width:75%' ><p><a name="451bcd29-820f-42e3-b3c0-bc1b333c8f0c"></a>
<b>HasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d93e04e6-9fab-4d73-b4f5-91401aa0c001'>FillHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="d93e04e6-9fab-4d73-b4f5-91401aa0c001"></a>
<b>FillHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43b520fe-0c4f-45f5-b760-997d60d14863'>FillVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="43b520fe-0c4f-45f5-b760-997d60d14863"></a>
<b>FillVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53951bd2-f35b-45b6-90b3-da8a5e247bba'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="53951bd2-f35b-45b6-90b3-da8a5e247bba"></a>
<b>HasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54b7f489-7628-42d5-9852-49aad71848b3'>FillShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="54b7f489-7628-42d5-9852-49aad71848b3"></a>
<b>FillShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d9b0c77-6f14-4dff-8f2f-336fe658e7b7'>FillShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="6d9b0c77-6f14-4dff-8f2f-336fe658e7b7"></a>
<b>FillShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e5bea20-b93e-4b9e-b310-86e2fbcdfbc2'>FillShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="7e5bea20-b93e-4b9e-b310-86e2fbcdfbc2"></a>
<b>FillShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8d8164e-face-4d38-b7c3-b5fdab6847e6'>FillShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="f8d8164e-face-4d38-b7c3-b5fdab6847e6"></a>
<b>FillShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bbbfa9e-a00c-411f-9539-cae0793c4485'>FillShadowLinkedColor</a></td><td style='width:75%' ><p><a name="7bbbfa9e-a00c-411f-9539-cae0793c4485"></a>
<b>FillShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea93c5a0-70a3-4f4c-a9bf-ad08c8d769af'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="ea93c5a0-70a3-4f4c-a9bf-ad08c8d769af"></a>
<b>FrameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9773bf0e-958c-4eaf-8460-a23ef7987fd4'>FrameGradient</a></td><td style='width:75%' ><p><a name="9773bf0e-958c-4eaf-8460-a23ef7987fd4"></a>
<b>FrameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37dfaa11-21b8-4387-8720-aea1a92acb78'>FillColor</a></td><td style='width:75%' class='def'><p><a name="37dfaa11-21b8-4387-8720-aea1a92acb78"></a>
<b>FillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#833da0af-0662-4b19-8c3e-38dc3f0d756c'>FillGradient</a></td><td style='width:75%' ><p><a name="833da0af-0662-4b19-8c3e-38dc3f0d756c"></a>
<b>FillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b47729f7-fd97-430a-978b-0da1012aef39'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="b47729f7-fd97-430a-978b-0da1012aef39"></a>
<b>IsVerticalText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is vertical text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4bc019d1-8d33-46a7-bb5f-013ab2a91ae0'>StrikeThruText</a></td><td style='width:75%' ><p><a name="4bc019d1-8d33-46a7-bb5f-013ab2a91ae0"></a>
<b>StrikeThruText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The strike thru text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f1a1871-2160-411c-b876-883857efd7b8'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="6f1a1871-2160-411c-b876-883857efd7b8"></a>
<b>TextScaleX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text scale x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e00bc0db-36f2-4840-ba29-600e37d47ae6'>TextSize</a></td><td style='width:75%' ><p><a name="e00bc0db-36f2-4840-ba29-600e37d47ae6"></a>
<b>TextSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bb35912-8171-41b9-90ae-31f24676c54c'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="5bb35912-8171-41b9-90ae-31f24676c54c"></a>
<b>TextSkewX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text skew x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#922bd4d0-20f4-4e9e-9326-a167ada33437'>FontFamilyName</a></td><td style='width:75%' ><p><a name="922bd4d0-20f4-4e9e-9326-a167ada33437"></a>
<b>FontFamilyName</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The name of the font family of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#158785c2-8e82-45a1-ac18-00c4ffa529ec'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="158785c2-8e82-45a1-ac18-00c4ffa529ec"></a>
<b>UnderlineText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The underline text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fe4eba6-d38d-4fe5-90f0-30b576639e7f'>HasFrameJitter</a></td><td style='width:75%' ><p><a name="3fe4eba6-d38d-4fe5-90f0-30b576639e7f"></a>
<b>HasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#caab67ed-e07c-409f-a634-919f8186c52f'>FrameJitterLength</a></td><td style='width:75%' class='def'><p><a name="caab67ed-e07c-409f-a634-919f8186c52f"></a>
<b>FrameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79c8c093-df05-426a-ab8e-eb96f4c1a3df'>FrameJitterDeviation</a></td><td style='width:75%' ><p><a name="79c8c093-df05-426a-ab8e-eb96f4c1a3df"></a>
<b>FrameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ad3bba2-87c3-4254-9346-39fd661e9bd5'>HasFillJitter</a></td><td style='width:75%' class='def'><p><a name="4ad3bba2-87c3-4254-9346-39fd661e9bd5"></a>
<b>HasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d25ca10-5ada-47b9-ba64-6258ef11c690'>FillJitterLength</a></td><td style='width:75%' ><p><a name="7d25ca10-5ada-47b9-ba64-6258ef11c690"></a>
<b>FillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9f12ea9-c0cf-4e0d-b99f-8971da03ecc5'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="a9f12ea9-c0cf-4e0d-b99f-8971da03ecc5"></a>
<b>FillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0bdb8dc-57b6-40d4-8e8c-422333d6ada5'>HasFrameDash</a></td><td style='width:75%' ><p><a name="a0bdb8dc-57b6-40d4-8e8c-422333d6ada5"></a>
<b>HasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame dash of a <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="b208800f-6027-4ded-b45a-a4131c60a043"></a>
##KimonoPropertyConnection

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a connection between a given Kimono Object and a `KimonoProperty`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6265002d-465e-4128-ad15-f976f8c1e99e'>UniqueID</a></td><td style='width:75%' ><p><a name="6265002d-465e-4128-ad15-f976f8c1e99e"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd65a2e2-6477-4270-b03f-e0292f385044'>ConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="bd65a2e2-6477-4270-b03f-e0292f385044"></a></p>

<h3>ConnectionPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the point that a given <code>KimonoProperty</code> is connected to another Kimono Object.</p>

<h4>Return Value</h4>

<p>The connection point as a <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3940450-3fc7-42ed-ad18-c2337282f423'>ConnectedProperty</a></td><td style='width:75%' ><p><a name="e3940450-3fc7-42ed-ad18-c2337282f423"></a></p>

<h3>ConnectedProperty</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the connected property.</p>

<h4>Return Value</h4>

<p>The connected <code>KimonoProperty</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ad74baaf-e9bc-4e00-839c-599692b4048a'>KimonoPropertyConnection</a></td><td style='width:75%' ><p><a name="ad74baaf-e9bc-4e00-839c-599692b4048a"></a></p>

<h3>KimonoPropertyConnection ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b208800f-6027-4ded-b45a-a4131c60a043">KimonoPropertyConnection</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2344715d-5411-4a62-af6c-da6e5082ce2e'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p><a name="2344715d-5411-4a62-af6c-da6e5082ce2e"></a></p>

<h3>KimonoPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b208800f-6027-4ded-b45a-a4131c60a043">KimonoPropertyConnection</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="553743bb-dabd-4a05-983f-34eafb0abe85"></a>
Connection point.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="b4f1ca52-947e-434b-9df2-9b55ccba6371"></a>
Property.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b051c8e-99b6-4c46-b9f1-d9f2494670df'>Clone</a></td><td style='width:75%' ><p><a name="0b051c8e-99b6-4c46-b9f1-d9f2494670df"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="75063490-184b-469b-ad0b-738f456a6918"></a>
##ObiScriptResult

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the result of attempting to execute an Obi Script on a `KimonoProperty`
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#39249242-0f18-4806-a689-cde742133674'>Successful</a></td><td style='width:75%' ><p><a name="39249242-0f18-4806-a689-cde742133674"></a></p>

<h3>Successful</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the Obi Script ran successfully.</p>

<h4>Return Value</h4>

<p><code>true</code> if successful; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c22d403-b96d-4870-92ee-3fc9dfa58454'>ErrorMessage</a></td><td style='width:75%' class='def'><p><a name="4c22d403-b96d-4870-92ee-3fc9dfa58454"></a></p>

<h3>ErrorMessage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the error message if the Obi Script execution failed.</p>

<h4>Return Value</h4>

<p>The error message or "" if the script ran successfully.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#25c7473f-174d-4b9e-a29b-a07dbf0f01fb'>ObiScriptResult</a></td><td style='width:75%' ><p><a name="25c7473f-174d-4b9e-a29b-a07dbf0f01fb"></a></p>

<h3>ObiScriptResult ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#75063490-184b-469b-ad0b-738f456a6918">ObiScriptResult</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc2b330-ae5b-4c88-8fa6-870c3620c886'>ObiScriptResult</a></td><td style='width:75%' class='def'><p><a name="2fc2b330-ae5b-4c88-8fa6-870c3620c886"></a></p>

<h3>ObiScriptResult (System.Boolean, System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#75063490-184b-469b-ad0b-738f456a6918">ObiScriptResult</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>isSuccessful</td><td style='width:75%' ><p><a name="03305c47-b2a1-45f4-a8e2-2780af7f60dd"></a>
If set to <code>true</code> is successful.</p>
</td></tr><tr><td style='width:25%' class='term'>errorMessage</td><td style='width:75%' class='def'><p><a name="4bfe0ed5-ada5-4910-86e7-42f1e33cc233"></a>
Error message.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="1240a485-ca04-49c6-95b1-a16edc8d8ac2"></a>
##KimonoBezierPoint

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Holds the control and end point for a `KimonoShapeBezier` that define a quad section of the Bezier.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4d9459b6-d96b-438d-a257-68bc685c5bb9'>ControlPoint</a></td><td style='width:75%' ><p><a name="4d9459b6-d96b-438d-a257-68bc685c5bb9"></a></p>

<h3>ControlPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control point.</p>

<h4>Return Value</h4>

<p>The control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5757db35-577f-4f1c-9b5c-cd9971f2c16d'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="5757db35-577f-4f1c-9b5c-cd9971f2c16d"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5175bad8-79d5-4de0-a5f8-22416704a0ea'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="5175bad8-79d5-4de0-a5f8-22416704a0ea"></a></p>

<h3>KimonoBezierPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1240a485-ca04-49c6-95b1-a16edc8d8ac2">KimonoBezierPoint</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62e207ac-7888-4319-a38e-8995f434f1b0'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p><a name="62e207ac-7888-4319-a38e-8995f434f1b0"></a></p>

<h3>KimonoBezierPoint (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1240a485-ca04-49c6-95b1-a16edc8d8ac2">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlPoint</td><td style='width:75%' ><p><a name="d44190eb-9da1-40f5-874d-6ebb412c27ab"></a>
Control point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="1199dd73-bde7-4ca0-ad27-1c62aed64352"></a>
End point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13ea16bb-01fd-4ce4-aa93-ff1f82895b8d'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="13ea16bb-01fd-4ce4-aa93-ff1f82895b8d"></a></p>

<h3>KimonoBezierPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1240a485-ca04-49c6-95b1-a16edc8d8ac2">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="2f08240b-7ec8-44e4-9146-d5033cddb046"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="f7ae1d92-1982-40f6-98bf-53a20d298a86"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="b5b475b0-26b6-4f1f-8df3-2fafcad17b0b"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="e324beab-f127-4a75-a1d4-e22bd930a7db"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0591b3af-8ed2-4b3d-8b12-bdeb237b3777'>Clone</a></td><td style='width:75%' class='def'><p><a name="0591b3af-8ed2-4b3d-8b12-bdeb237b3777"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="10a5423f-991f-43f1-82db-00e8c2cf52ba"></a>
##KimonoBounds

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the outter bounding box for a `KimonoShape` and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#925310ed-0983-476a-9f35-39df66718d5b'>Rect</a></td><td style='width:75%' ><p><a name="925310ed-0983-476a-9f35-39df66718d5b"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base <code>SkRect</code> that holds the internal bounds of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#984da18d-bc30-46fe-b509-640cdbee85db'>PreviousCenter</a></td><td style='width:75%' class='def'><p><a name="984da18d-bc30-46fe-b509-640cdbee85db"></a>
<b>PreviousCenter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous center used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#574bcaff-c0cd-458a-9901-9f3eb797d084'>PreviousRect</a></td><td style='width:75%' ><p><a name="574bcaff-c0cd-458a-9901-9f3eb797d084"></a>
<b>PreviousRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous rect used in scaling operations.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c6784790-28af-47ea-bc7a-72593a666c98'>State</a></td><td style='width:75%' ><p><a name="c6784790-28af-47ea-bc7a-72593a666c98"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the current edit state of the <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04296989-8ad4-4314-b2c9-0cad924a714c'>Name</a></td><td style='width:75%' class='def'><p><a name="04296989-8ad4-4314-b2c9-0cad924a714c"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9732714-80b8-46af-8e82-a82b19094cab'>UniqueID</a></td><td style='width:75%' ><p><a name="c9732714-80b8-46af-8e82-a82b19094cab"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61e3fdec-09ae-4f5b-b316-a557de368e79'>Top</a></td><td style='width:75%' class='def'><p><a name="61e3fdec-09ae-4f5b-b316-a557de368e79"></a></p>

<h3>Top</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top.</p>

<h4>Return Value</h4>

<p>The top coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a8b31ee-3d6c-4503-9a70-1bda9a0e352a'>Left</a></td><td style='width:75%' ><p><a name="8a8b31ee-3d6c-4503-9a70-1bda9a0e352a"></a></p>

<h3>Left</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left.</p>

<h4>Return Value</h4>

<p>The left coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af7055bb-76c5-4d2c-ba5c-112e5845a7b3'>Bottom</a></td><td style='width:75%' class='def'><p><a name="af7055bb-76c5-4d2c-ba5c-112e5845a7b3"></a></p>

<h3>Bottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom.</p>

<h4>Return Value</h4>

<p>The bottom coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf1c7d77-cd72-4e42-b927-967f8429bf6a'>Right</a></td><td style='width:75%' ><p><a name="bf1c7d77-cd72-4e42-b927-967f8429bf6a"></a></p>

<h3>Right</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right.</p>

<h4>Return Value</h4>

<p>The right coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6375d244-4b2f-4e0d-9d34-75a825d505ab'>Width</a></td><td style='width:75%' class='def'><p><a name="6375d244-4b2f-4e0d-9d34-75a825d505ab"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4ee1749-c612-4411-a568-34648c13ac66'>Height</a></td><td style='width:75%' ><p><a name="b4ee1749-c612-4411-a568-34648c13ac66"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2eb9068b-10a2-4ce6-b33b-8d41eff8161b'>HorizontalCenter</a></td><td style='width:75%' class='def'><p><a name="2eb9068b-10a2-4ce6-b33b-8d41eff8161b"></a></p>

<h3>HorizontalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the horizontal center.</p>

<h4>Return Value</h4>

<p>The horizontal center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7edb286e-8132-4864-83b9-9d7305e57e98'>VerticalCenter</a></td><td style='width:75%' ><p><a name="7edb286e-8132-4864-83b9-9d7305e57e98"></a></p>

<h3>VerticalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the vertical center.</p>

<h4>Return Value</h4>

<p>The vertical center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fd37aa7-ee45-42aa-8ace-feee894351fa'>Center</a></td><td style='width:75%' class='def'><p><a name="1fd37aa7-ee45-42aa-8ace-feee894351fa"></a></p>

<h3>Center</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the center.</p>

<h4>Return Value</h4>

<p>The center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aeedc1c3-d489-4259-8ca8-b0aa74a22654'>RotationDegrees</a></td><td style='width:75%' ><p><a name="aeedc1c3-d489-4259-8ca8-b0aa74a22654"></a></p>

<h3>RotationDegrees</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the rotation degrees.</p>

<h4>Return Value</h4>

<p>The rotation degrees.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77156acf-2049-404b-a8b6-0bffdad53232'>TopLeftHandle</a></td><td style='width:75%' class='def'><p><a name="77156acf-2049-404b-a8b6-0bffdad53232"></a></p>

<h3>TopLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top left handle.</p>

<h4>Return Value</h4>

<p>The top left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7026d4e-b016-4af9-8691-e059d668ed56'>TopHandle</a></td><td style='width:75%' ><p><a name="d7026d4e-b016-4af9-8691-e059d668ed56"></a></p>

<h3>TopHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top handle.</p>

<h4>Return Value</h4>

<p>The top handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#037e1fed-4058-4a7c-a044-c3f66fe07b1a'>TopRightHandle</a></td><td style='width:75%' class='def'><p><a name="037e1fed-4058-4a7c-a044-c3f66fe07b1a"></a></p>

<h3>TopRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top right handle.</p>

<h4>Return Value</h4>

<p>The top right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0872a47f-7719-448c-8e89-cbf858c6d247'>RightHandle</a></td><td style='width:75%' ><p><a name="0872a47f-7719-448c-8e89-cbf858c6d247"></a></p>

<h3>RightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right handle.</p>

<h4>Return Value</h4>

<p>The right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51db5689-ce07-4ed8-9ef0-4ead74652173'>BottomRightHandle</a></td><td style='width:75%' class='def'><p><a name="51db5689-ce07-4ed8-9ef0-4ead74652173"></a></p>

<h3>BottomRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom right handle.</p>

<h4>Return Value</h4>

<p>The bottom right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c435538-4e96-4b3a-b833-488bd2878273'>BottomHandle</a></td><td style='width:75%' ><p><a name="0c435538-4e96-4b3a-b833-488bd2878273"></a></p>

<h3>BottomHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom handle.</p>

<h4>Return Value</h4>

<p>The bottom handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff18baa5-7148-4f3f-8028-bd4bc6c8aa4c'>BottomLeftHandle</a></td><td style='width:75%' class='def'><p><a name="ff18baa5-7148-4f3f-8028-bd4bc6c8aa4c"></a></p>

<h3>BottomLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom left handle.</p>

<h4>Return Value</h4>

<p>The bottom left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58cffb8b-952c-4dfc-af48-c33414986b16'>LeftHandle</a></td><td style='width:75%' ><p><a name="58cffb8b-952c-4dfc-af48-c33414986b16"></a></p>

<h3>LeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left handle.</p>

<h4>Return Value</h4>

<p>The left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e7455fa-de1e-4d35-ac42-204ea67b1a3b'>HitOffset</a></td><td style='width:75%' class='def'><p><a name="6e7455fa-de1e-4d35-ac42-204ea67b1a3b"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db16feb8-ab05-4f0b-94c2-7da998e55fc7'>HitHandle</a></td><td style='width:75%' ><p><a name="db16feb8-ab05-4f0b-94c2-7da998e55fc7"></a></p>

<h3>HitHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit handle.</p>

<h4>Return Value</h4>

<p>The hit handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cc688344-7402-495c-a42a-162108a3f7bf'>KimonoBounds</a></td><td style='width:75%' ><p><a name="cc688344-7402-495c-a42a-162108a3f7bf"></a></p>

<h3>KimonoBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#10a5423f-991f-43f1-82db-00e8c2cf52ba">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#087cee1b-784f-4b98-abec-af39e11ef192'>KimonoBounds</a></td><td style='width:75%' class='def'><p><a name="087cee1b-784f-4b98-abec-af39e11ef192"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#10a5423f-991f-43f1-82db-00e8c2cf52ba">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="03769806-ce67-43c3-9d09-4d393576526d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f71542ff-f13f-43f6-b8c5-67767150261f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="29d5f7c7-fb7c-4a01-87ed-5a496a7a5e58"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="4ede9220-df5f-4f62-b0c4-25ee2e30150e"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35870f85-db2a-4041-912b-f5cd55314d3c'>KimonoBounds</a></td><td style='width:75%' ><p><a name="35870f85-db2a-4041-912b-f5cd55314d3c"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#10a5423f-991f-43f1-82db-00e8c2cf52ba">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="83e01259-b248-4422-81f7-3c71b4408caa"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="5b3d8a99-42d2-4df8-b900-6bde857b35c6"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2fc66315-f0e5-4f09-8efb-16be987f095e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="72969f3a-2766-4834-b948-60588530623a"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="63390e48-1f28-4c03-b394-626fc5740406"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e33d4141-4b43-4335-b355-b91628dfb22a'>SavePreviousBounds</a></td><td style='width:75%' class='def'><p><a name="e33d4141-4b43-4335-b355-b91628dfb22a"></a></p>

<h3>SavePreviousBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0bec6a4-7433-47d3-9c17-f46a141552bb'>ValueBetween</a></td><td style='width:75%' ><p><a name="a0bec6a4-7433-47d3-9c17-f46a141552bb"></a></p>

<h3>ValueBetween (System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Checks to see if the given value is between the two given points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="23e0f5a0-9baf-4b68-8fa6-0c9f42bb339e"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p><a name="a62f95c5-a2ad-4cc9-855b-438ec40e81dc"></a>
The alpha component.</p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p><a name="f1293e59-03e9-4b39-900b-c43349c61f1f"></a>
The blue component.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>Boolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#098c4026-bd0b-4b3c-83fe-2fd3c061eb1b'>AddHandles</a></td><td style='width:75%' class='def'><p><a name="098c4026-bd0b-4b3c-83fe-2fd3c061eb1b"></a></p>

<h3>AddHandles (KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the control handles to the bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4189388-656a-4f3b-8032-2d6aec83c881'>RemoveHandles</a></td><td style='width:75%' ><p><a name="b4189388-656a-4f3b-8032-2d6aec83c881"></a></p>

<h3>RemoveHandles ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the control handles from the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd307975-15e1-4c4e-812c-f84bbdbe385f'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="bd307975-15e1-4c4e-812c-f84bbdbe385f"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates the location of the edit handles when the bounds has been relocated or resized.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#314f67f1-b188-4b16-9025-eb559227732b'>Draw</a></td><td style='width:75%' ><p><a name="314f67f1-b188-4b16-9025-eb559227732b"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bounding box and its edit handles into the given canvas</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="f78672e0-b3fd-4cfa-bbf4-c78325f848b0"></a>
Canvas.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8784d3d-2e77-4d94-a78a-08691fbcc38c'>Select</a></td><td style='width:75%' class='def'><p><a name="b8784d3d-2e77-4d94-a78a-08691fbcc38c"></a></p>

<h3>Select ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Puts the <code>KimonoShape</code> into the edit mode and creates the edit handles as required.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b51bd78c-14f8-4a6c-89b4-bfb0c0385bda'>PlaceUnderConstruction</a></td><td style='width:75%' ><p><a name="b51bd78c-14f8-4a6c-89b4-bfb0c0385bda"></a></p>

<h3>PlaceUnderConstruction (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the bounds under construction.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p><a name="6ab98f1d-5a82-41f5-8c18-1c7edf7a887c"></a>
If set to <code>true</code> needs handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9beb68b7-688a-42db-b044-d847184767ba'>StartGrouping</a></td><td style='width:75%' class='def'><p><a name="9beb68b7-688a-42db-b044-d847184767ba"></a></p>

<h3>StartGrouping ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts the bounds grouping.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3301ee0c-6c6b-435b-bffd-47b90333f369'>Unselect</a></td><td style='width:75%' ><p><a name="3301ee0c-6c6b-435b-bffd-47b90333f369"></a></p>

<h3>Unselect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Unselects the <code>KimonoShape</code> as the current edit target and removes any edit handles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83494b1a-ff84-4ef2-8bdf-08094cbeabe7'>ChangeBounds</a></td><td style='width:75%' class='def'><p><a name="83494b1a-ff84-4ef2-8bdf-08094cbeabe7"></a></p>

<h3>ChangeBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Changes the bounds to match the given values.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f069deb6-806f-4d24-92da-1bf530ed0d41"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="2c507cc5-36b6-4d8a-8446-68f72a14f55f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="22e2635d-d9a6-4d7e-b8f2-be416bac92a5"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bf27a6bd-00f1-4680-915a-7f354168093f"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e04cca9-e772-4c7f-8d6f-c9133568df7a'>GrowBounds</a></td><td style='width:75%' ><p><a name="1e04cca9-e772-4c7f-8d6f-c9133568df7a"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adjusts the size of the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="2bf55fad-4798-49b5-80aa-cdddf62fb209"></a>
The new size as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b943a31a-1dea-412b-8186-e0eafff67596'>MoveBounds</a></td><td style='width:75%' class='def'><p><a name="b943a31a-1dea-412b-8186-e0eafff67596"></a></p>

<h3>MoveBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the bounds to the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="1fa938a1-a329-4dd7-be46-cc8929de93d4"></a>
The new top, left location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f75a591-56cb-4c33-b206-aab70d94fca9'>DragBounds</a></td><td style='width:75%' ><p><a name="1f75a591-56cb-4c33-b206-aab70d94fca9"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="2a98047e-1c29-47a0-ba3b-93258d05ef29"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb475135-b99f-49b5-96c4-6091ebac3113'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="cb475135-b99f-49b5-96c4-6091ebac3113"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8451582b-d874-4ce7-9d82-fc809e63dcb2"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8427202a-b278-468f-bb98-434dae5cd4cd'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="8427202a-b278-468f-bb98-434dae5cd4cd"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea07ac6f-3508-4a15-b0e1-f440901ebf52'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="ea07ac6f-3508-4a15-b0e1-f440901ebf52"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49b2ce19-a236-460e-bb89-c8bcf8c0e660'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="49b2ce19-a236-460e-bb89-c8bcf8c0e660"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f587567-f49c-4f52-9fc0-318af88177c7'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="0f587567-f49c-4f52-9fc0-318af88177c7"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5745ae14-f107-4aa8-8406-1c8bbda2ab22"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53478e6b-01dc-485c-a266-ce4686557322'>ToCode</a></td><td style='width:75%' ><p><a name="53478e6b-01dc-485c-a266-ce4686557322"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="10cb6152-5cee-4e79-be29-ffa5dff68192"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5a973cd1-704d-4051-bbf0-2d68749ccab6"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8d02a09f-77a6-40d1-8f30-3784c735c441"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7c90e03-deb0-471e-835a-cb1884d97049'>Clone</a></td><td style='width:75%' class='def'><p><a name="a7c90e03-deb0-471e-835a-cb1884d97049"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="6acde3a1-1a2b-4971-bb44-a8eab78d5f36"></a>
##KimonoHandle

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines an edit handle that the user manipulates to edit the bounds of a `KimonoShape` or the control points of a Bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#96800add-2000-4846-b102-a7a098cd4f3b'>DrawWidth</a></td><td style='width:75%' ><p><a name="96800add-2000-4846-b102-a7a098cd4f3b"></a>
<b>DrawWidth</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The width of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#637a5843-a777-48ed-b189-20d144472cc6'>DrawOffset</a></td><td style='width:75%' class='def'><p><a name="637a5843-a777-48ed-b189-20d144472cc6"></a>
<b>DrawOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The draw offset of the drag handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#48c27c0b-a586-48bd-a77d-a8e7d49aa106'>Index</a></td><td style='width:75%' ><p><a name="48c27c0b-a586-48bd-a77d-a8e7d49aa106"></a></p>

<h3>Index</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the index.</p>

<h4>Return Value</h4>

<p>The index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d15852f8-bbc1-40b2-a554-158781d3ffd8'>HandleType</a></td><td style='width:75%' class='def'><p><a name="d15852f8-bbc1-40b2-a554-158781d3ffd8"></a></p>

<h3>HandleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the handle.</p>

<h4>Return Value</h4>

<p>The type of the handle as a <code>KimonoHandleType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f557e1b1-ea93-4137-be80-0f693fcf46f5'>UniqueID</a></td><td style='width:75%' ><p><a name="f557e1b1-ea93-4137-be80-0f693fcf46f5"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7076b58a-4030-4b6e-8dfc-e1cfd5ae2b78'>State</a></td><td style='width:75%' class='def'><p><a name="7076b58a-4030-4b6e-8dfc-e1cfd5ae2b78"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the edit state of the <code>KimonoHandle</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07e656d1-709e-4c48-8364-5009ab1d7145'>X</a></td><td style='width:75%' ><p><a name="07e656d1-709e-4c48-8364-5009ab1d7145"></a></p>

<h3>X</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the x value.</p>

<h4>Return Value</h4>

<p>The x coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80b85704-9870-4365-b906-d834b8dfcbc0'>Y</a></td><td style='width:75%' class='def'><p><a name="80b85704-9870-4365-b906-d834b8dfcbc0"></a></p>

<h3>Y</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the y value.</p>

<h4>Return Value</h4>

<p>The y coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f60f1f40-8880-43ee-8ec7-5c8fecba177e'>Rect</a></td><td style='width:75%' ><p><a name="f60f1f40-8880-43ee-8ec7-5c8fecba177e"></a></p>

<h3>Rect</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the rect.</p>

<h4>Return Value</h4>

<p>The rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f238f4eb-3950-4062-a252-550853a777c7'>Constraint</a></td><td style='width:75%' class='def'><p><a name="f238f4eb-3950-4062-a252-550853a777c7"></a></p>

<h3>Constraint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the edit constraint.</p>

<h4>Return Value</h4>

<p>The edit constraint as a <code>KimonoHandleConstraint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0f057ce-625b-4120-b534-0d33eefa1d4d'>HitOffset</a></td><td style='width:75%' ><p><a name="e0f057ce-625b-4120-b534-0d33eefa1d4d"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf48efef-48a9-450f-87bc-11c8eb7fa59b'>Color</a></td><td style='width:75%' class='def'><p><a name="cf48efef-48a9-450f-87bc-11c8eb7fa59b"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, this color will be used.</p>

<h4>Return Value</h4>

<p>The <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afdf556b-9aec-49c3-bbfc-89017cbdee44'>LinkedColor</a></td><td style='width:75%' ><p><a name="afdf556b-9aec-49c3-bbfc-89017cbdee44"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, the <code>Color</code> property will  be used instead.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6479cc11-177d-454b-8b6c-b994fb11c7a1'>RepresentedColor</a></td><td style='width:75%' class='def'><p><a name="6479cc11-177d-454b-8b6c-b994fb11c7a1"></a></p>

<h3>RepresentedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color that this handle represents.</p>

<h4>Return Value</h4>

<p>The color as a <code>SKColor</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3d543378-7c49-4c7b-96d1-6e7cde6168b5'>KimonoHandle</a></td><td style='width:75%' ><p><a name="3d543378-7c49-4c7b-96d1-6e7cde6168b5"></a></p>

<h3>KimonoHandle (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6acde3a1-1a2b-4971-bb44-a8eab78d5f36">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="c4406e65-7b27-48b7-a52e-8212de6ae306"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="0b0bf446-c6cb-4fa3-9d58-d51b02886e84"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc5ad319-666f-4b4e-b59e-ef3d6b412c1d'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="bc5ad319-666f-4b4e-b59e-ef3d6b412c1d"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6acde3a1-1a2b-4971-bb44-a8eab78d5f36">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="80d27328-194c-4a77-93a1-95e37b84a7c6"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="dbb1282e-1476-47f1-a02d-7897d487661d"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="08dcf53b-b231-4a7d-ad07-dd9906c38554"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#537ed59f-3a11-4f4e-a285-f2e62bd1d08a'>KimonoHandle</a></td><td style='width:75%' ><p><a name="537ed59f-3a11-4f4e-a285-f2e62bd1d08a"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6acde3a1-1a2b-4971-bb44-a8eab78d5f36">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="b9fe285d-bb69-4ab0-92d4-f021f693ad79"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="a92420c0-966f-42ed-a20d-cb6e7c1f3e8a"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="12481cd1-49de-4387-8862-cce6250c74cb"></a>
Constraint.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61e65a79-161f-4f96-8b4e-78511babfa0d'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="61e65a79-161f-4f96-8b4e-78511babfa0d"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6acde3a1-1a2b-4971-bb44-a8eab78d5f36">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="999f1910-9876-4b70-a5a9-1a758b15a514"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="fc27b42f-8df8-4756-8d66-d511aa2cefff"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="3c0bc781-dffe-4465-a56b-791fb10f1bc9"></a>
Constraint.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="3ae0a869-9200-4f6f-82a1-9a87d66e2f9a"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#544edd1a-9c28-4fe5-8012-94028f765e3b'>Draw</a></td><td style='width:75%' ><p><a name="544edd1a-9c28-4fe5-8012-94028f765e3b"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the hanled into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="934e9015-90f8-4c7d-b8f0-286f817cb0a5"></a>
The <code>SKCanvas</code> to draw the hanled into.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The draw.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fde183d1-c091-4455-b9a0-c321df60f64e'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="fde183d1-c091-4455-b9a0-c321df60f64e"></a></p>

<h3>MoveTo (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the handle to the given coordinates.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="72d14410-638f-4c7d-a2df-c043e543b671"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="f956a78e-3d08-40de-baf9-67838f9e4626"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6323d2e7-c3f9-415e-b85b-f2ef2b9bdfed'>PointInBound</a></td><td style='width:75%' ><p><a name="6323d2e7-c3f9-415e-b85b-f2ef2b9bdfed"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="953e771d-c56e-406e-a38d-e9d76656aecb"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#626ba983-332a-41ed-a768-443f7348c3ad'>DragHandle</a></td><td style='width:75%' class='def'><p><a name="626ba983-332a-41ed-a768-443f7348c3ad"></a></p>

<h3>DragHandle (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the handle.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="15c054f1-eccb-4aa2-9bcc-242610cc3473"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec5bbf90-6876-4950-85dd-5f00c2c0d038'>ToPoint</a></td><td style='width:75%' ><p><a name="ec5bbf90-6876-4950-85dd-5f00c2c0d038"></a></p>

<h3>ToPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoHandle</code> to a Skia Point.</p>

<h4>Returns</h4>

<p>The <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fabc083-8a4b-458e-955c-d201dfa12ee7'>Clone</a></td><td style='width:75%' class='def'><p><a name="8fabc083-8a4b-458e-955c-d201dfa12ee7"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6918c220-38b8-422e-a4b3-b74f1d5283f9'>RaiseMoved</a></td><td style='width:75%' ><p><a name="6918c220-38b8-422e-a4b3-b74f1d5283f9"></a></p>

<h3>RaiseMoved (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the moved event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d8916e06-845e-4fdf-89b1-8af6658c3383"></a>
Point.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#23da4c2d-106d-4c13-b341-8b03b532c24a'>Moved</a></td><td style='width:75%' ><p><a name="23da4c2d-106d-4c13-b341-8b03b532c24a"></a></p>

<h3>Moved</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when moved.</p>
</td></tr></table></p>


---

<a name="b763a01e-3cfe-4327-b919-09d62d7e7db7"></a>
##KimonoHandleConstraint

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Constrains the movement of a `KimonoHandle` when it is being moved by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#215d6628-3dbb-40c8-b0e0-e2a51bff9307'>None</a></td><td style='width:75%' ><p><a name="215d6628-3dbb-40c8-b0e0-e2a51bff9307"></a>
<b>None</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>No movement constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42e08632-ae8d-46fb-9b3e-0174ac02f138'>Horizontal</a></td><td style='width:75%' class='def'><p><a name="42e08632-ae8d-46fb-9b3e-0174ac02f138"></a>
<b>Horizontal</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2f06d4e-d95d-4833-8d66-8a5c3c33db17'>Vertical</a></td><td style='width:75%' ><p><a name="f2f06d4e-d95d-4833-8d66-8a5c3c33db17"></a>
<b>Vertical</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved vertically.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d1cd7b2-ae9a-4ec9-8699-8c3f5c67321c'>Locked</a></td><td style='width:75%' class='def'><p><a name="6d1cd7b2-ae9a-4ec9-8699-8c3f5c67321c"></a>
<b>Locked</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle is locked in place and cannot be moved.</p>
</td></tr></table></p>


---

<a name="5df34b9c-5bc0-4e10-9592-2fa27a7d09d7"></a>
##KimonoHandleType

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoHandle` that can be used as a general purpose control point to adjust the bounds of a `KimonoShape` or as a point for a vector or bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#585e70b0-3147-49d3-9f21-14beefc9444d'>ControlPoint</a></td><td style='width:75%' ><p><a name="585e70b0-3147-49d3-9f21-14beefc9444d"></a>
<b>ControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A general purpose handle for a shape's bound or a control point on a  vector or bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e2abdb8-4b44-451e-9dca-3589d61c556e'>GradientColor</a></td><td style='width:75%' class='def'><p><a name="6e2abdb8-4b44-451e-9dca-3589d61c556e"></a>
<b>GradientColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines a color inside of a gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23f2ebcf-c7a0-4fa4-9f9b-a30392b01b32'>GradientPosition</a></td><td style='width:75%' ><p><a name="23f2ebcf-c7a0-4fa4-9f9b-a30392b01b32"></a>
<b>GradientPosition</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the position of a gradient in a shape object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d5a5aa1-f5a6-4bc7-b122-825fd209e614'>BezierControlPoint</a></td><td style='width:75%' class='def'><p><a name="5d5a5aa1-f5a6-4bc7-b122-825fd209e614"></a>
<b>BezierControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the control point for a <code>KimonoShapeBezier</code> end point used to adjust the curve of a bezier quad section.</p>
</td></tr></table></p>


---

<a name="8323798b-4b54-45cc-8cc0-932c3f4f7dcf"></a>
##KimonoBlur

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a blur effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#71f9883e-b661-4ff1-b227-7487dd339c56'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="71f9883e-b661-4ff1-b227-7487dd339c56"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#017efe8c-1120-44df-8948-2f49a1ef9581'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="017efe8c-1120-44df-8948-2f49a1ef9581"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c6febf9e-15ff-446e-a0d8-43a88e042884'>Name</a></td><td style='width:75%' ><p><a name="c6febf9e-15ff-446e-a0d8-43a88e042884"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53e2c625-981a-40ac-8b76-28353ca53f8c'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="53e2c625-981a-40ac-8b76-28353ca53f8c"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8887c9d-81b8-49fc-99a8-d0668b63a3be'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="e8887c9d-81b8-49fc-99a8-d0668b63a3be"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37c9eb6d-9d94-4e10-ac2a-bed921d5c986'>BlurFilter</a></td><td style='width:75%' class='def'><p><a name="37c9eb6d-9d94-4e10-ac2a-bed921d5c986"></a></p>

<h3>BlurFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the blur filter represented by this blur effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#df88ac2f-98e9-45b4-bcfc-938baf30a922'>KimonoBlur</a></td><td style='width:75%' ><p><a name="df88ac2f-98e9-45b4-bcfc-938baf30a922"></a></p>

<h3>KimonoBlur ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8323798b-4b54-45cc-8cc0-932c3f4f7dcf">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86f310e8-d119-4056-9ded-5b971c636c74'>KimonoBlur</a></td><td style='width:75%' class='def'><p><a name="86f310e8-d119-4056-9ded-5b971c636c74"></a></p>

<h3>KimonoBlur (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8323798b-4b54-45cc-8cc0-932c3f4f7dcf">KimonoBlur</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p><a name="cb90ce50-f1be-44a3-88ba-bb62de02cbc7"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="62536ba0-7ffa-487a-9426-9b9307ab60e1"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc183435-e9d5-47fc-992b-0afd6787a85d'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="bc183435-e9d5-47fc-992b-0afd6787a85d"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#974feecc-d8e7-47ab-ad92-721446a36087'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="974feecc-d8e7-47ab-ad92-721446a36087"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e649b515-b1b5-4c09-909e-4083060edf39"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9edc6dcb-ee5d-47f3-a6f5-6de826af89df'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="9edc6dcb-ee5d-47f3-a6f5-6de826af89df"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the Skia library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d18f0d68-9c47-4dbb-b5f6-667d51b85b90'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="d18f0d68-9c47-4dbb-b5f6-667d51b85b90"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd10b9c4-7a30-457f-9c46-acd5ed5f2d95'>ToCode</a></td><td style='width:75%' ><p><a name="bd10b9c4-7a30-457f-9c46-acd5ed5f2d95"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="1353f0a2-3ac6-4461-84f9-59db8008597e"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="194a9ee4-2d8a-44a9-8448-ff8fbbb352fb"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6e9761ac-3e3b-4c4e-a18b-b3ad6ea9dc89"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb36c7e4-7e79-40f9-8f4b-f7187ac127c6'>Clone</a></td><td style='width:75%' class='def'><p><a name="eb36c7e4-7e79-40f9-8f4b-f7187ac127c6"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c804a28-111a-4d44-b72c-9ff46a1973fa'>RaiseBlurModified</a></td><td style='width:75%' ><p><a name="5c804a28-111a-4d44-b72c-9ff46a1973fa"></a></p>

<h3>RaiseBlurModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the blur modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d1a285a3-5488-41a8-975e-d77d81fef5c4'>BlurModified</a></td><td style='width:75%' ><p><a name="d1a285a3-5488-41a8-975e-d77d81fef5c4"></a></p>

<h3>BlurModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the blur is modified.</p>
</td></tr></table></p>


---

<a name="da41d5f6-0962-495f-9bde-c435d34bd286"></a>
##KimonoShadow

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a shadow effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#962fe16b-008e-4539-8ff0-f1614fa5a0a4'>_horizontalOffset</a></td><td style='width:75%' ><p><a name="962fe16b-008e-4539-8ff0-f1614fa5a0a4"></a>
<b>_horizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8fd96db-924e-4be3-b93e-14016bb20c42'>_verticalOffset</a></td><td style='width:75%' class='def'><p><a name="b8fd96db-924e-4be3-b93e-14016bb20c42"></a>
<b>_verticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a68678f0-c808-45b8-9160-d95e06b15249'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="a68678f0-c808-45b8-9160-d95e06b15249"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a563396d-b176-48a8-a75e-e1da5124e4fd'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="a563396d-b176-48a8-a75e-e1da5124e4fd"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f89bc69a-a682-4ae6-ad1a-7fde74ac64cb'>_color</a></td><td style='width:75%' ><p><a name="f89bc69a-a682-4ae6-ad1a-7fde74ac64cb"></a>
<b>_color</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32bdd8c7-7ef3-4e40-bea8-7c129ef492a5'>_linkedColor</a></td><td style='width:75%' class='def'><p><a name="32bdd8c7-7ef3-4e40-bea8-7c129ef492a5"></a>
<b>_linkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A linked <code>KimonoColor</code> to use as the shadow color.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2390670e-b839-4f8f-99c8-2d4369ed10ae'>Name</a></td><td style='width:75%' ><p><a name="2390670e-b839-4f8f-99c8-2d4369ed10ae"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#246bc879-8d8c-4766-bacd-c36eb38be7ec'>HorizontalOffset</a></td><td style='width:75%' class='def'><p><a name="246bc879-8d8c-4766-bacd-c36eb38be7ec"></a></p>

<h3>HorizontalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal offset.</p>

<h4>Return Value</h4>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a59c7baa-a75b-4a8a-8ba6-ef4ae9350a16'>VerticalOffset</a></td><td style='width:75%' ><p><a name="a59c7baa-a75b-4a8a-8ba6-ef4ae9350a16"></a></p>

<h3>VerticalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical offset.</p>

<h4>Return Value</h4>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c3530cf-ed96-4e82-ab73-9453891d8038'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="9c3530cf-ed96-4e82-ab73-9453891d8038"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c414ba35-ef49-4218-a643-2f6b8fd97506'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="c414ba35-ef49-4218-a643-2f6b8fd97506"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25083580-77c4-488c-998b-ffa040869279'>Color</a></td><td style='width:75%' class='def'><p><a name="25083580-77c4-488c-998b-ffa040869279"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddbc5194-46d6-4f18-bc0d-46970bab5a02'>LinkedColor</a></td><td style='width:75%' ><p><a name="ddbc5194-46d6-4f18-bc0d-46970bab5a02"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the linked.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f93f33a4-4cfc-4393-9fc9-5fe1bd8d15d7'>ShadowColor</a></td><td style='width:75%' class='def'><p><a name="f93f33a4-4cfc-4393-9fc9-5fe1bd8d15d7"></a></p>

<h3>ShadowColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color of the shadow as a <code>SKColor</code>.</p>

<h4>Remarks</h4>

<p>Returns either the custom color attached to this shadow or a linked color if it is being used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f389eedf-3a88-491c-8c86-0375a40289bd'>ShadowFilter</a></td><td style='width:75%' ><p><a name="f389eedf-3a88-491c-8c86-0375a40289bd"></a></p>

<h3>ShadowFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the shadoe filter represented by this shadow effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#292bdbf3-58e6-43df-b1c3-7e17b87f516a'>KimonoShadow</a></td><td style='width:75%' ><p><a name="292bdbf3-58e6-43df-b1c3-7e17b87f516a"></a></p>

<h3>KimonoShadow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#da41d5f6-0962-495f-9bde-c435d34bd286">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbab57a7-52c4-45c7-99b1-e69b22295619'>KimonoShadow</a></td><td style='width:75%' class='def'><p><a name="cbab57a7-52c4-45c7-99b1-e69b22295619"></a></p>

<h3>KimonoShadow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#da41d5f6-0962-495f-9bde-c435d34bd286">KimonoShadow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalOffset</td><td style='width:75%' ><p><a name="df36661f-59ac-4826-9c43-426ce61b1614"></a>
Horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' class='def'><p><a name="7e5765f1-023d-4a18-a315-84d59e9b6245"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalOffset</td><td style='width:75%' ><p><a name="d4789224-17bd-48c8-9dce-4210c8515620"></a>
Vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="2c340ee5-a684-4d1d-9042-6951f1692606"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2e9ae6f-e8a1-4708-91d4-d5c9ba1d5921'>HandleLinkedColorChanged</a></td><td style='width:75%' ><p><a name="b2e9ae6f-e8a1-4708-91d4-d5c9ba1d5921"></a></p>

<h3>HandleLinkedColorChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the linked color changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76cd74d2-158b-4785-ac20-fbc48cff6de0'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="76cd74d2-158b-4785-ac20-fbc48cff6de0"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a1d59f6-1b40-4d53-8bda-99ce015a882d'>ToCSharp</a></td><td style='width:75%' ><p><a name="0a1d59f6-1b40-4d53-8bda-99ce015a882d"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f74afe03-5076-4826-827a-e729227b31de"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85ca7cc5-435f-4d60-a10b-188a8f866757'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="85ca7cc5-435f-4d60-a10b-188a8f866757"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a8e9307-6ef1-44ab-aaa7-1f36c5f27ff2'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="7a8e9307-6ef1-44ab-aaa7-1f36c5f27ff2"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#327b8205-0559-4c6e-bbe3-f9e11af0bfce'>ToCode</a></td><td style='width:75%' class='def'><p><a name="327b8205-0559-4c6e-bbe3-f9e11af0bfce"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="2f4a67fc-4466-4450-b2d5-2cebebbe8b4f"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="b37a5758-89b4-4899-95d8-22cdf6ecb6db"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="69bbdb24-6dac-459f-8be8-a5a6672f09bd"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eae4ba4-98b1-4d62-8dbd-2238d298e80f'>Clone</a></td><td style='width:75%' ><p><a name="0eae4ba4-98b1-4d62-8dbd-2238d298e80f"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02723099-0635-4a3b-958f-841d633fc715'>RaiseShadowModified</a></td><td style='width:75%' class='def'><p><a name="02723099-0635-4a3b-958f-841d633fc715"></a></p>

<h3>RaiseShadowModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the shadow modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bde3ac35-5910-4c66-b6a2-a0d677722caf'>ShadowModified</a></td><td style='width:75%' ><p><a name="bde3ac35-5910-4c66-b6a2-a0d677722caf"></a></p>

<h3>ShadowModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the shadow is modified.</p>
</td></tr></table></p>


---

<a name="8a5a2509-cb91-4b01-b5e9-111349587eb1"></a>
##KimonoGradient

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a gradient as a collection of either `SKColor` or linked `KimonoColors` that can be applied to a `KimonoStyle` and used when drawing a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#09ddf56d-da59-49e6-a764-4cf36945ae4a'>_gradientType</a></td><td style='width:75%' ><p><a name="09ddf56d-da59-49e6-a764-4cf36945ae4a"></a>
<b>_gradientType</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8855ba6-c178-4f36-9c7f-6d7683cfc64e'>_startPoint</a></td><td style='width:75%' class='def'><p><a name="e8855ba6-c178-4f36-9c7f-6d7683cfc64e"></a>
<b>_startPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cde08d90-00f3-4d02-973a-1ae3b840cdaf'>_endPoint</a></td><td style='width:75%' ><p><a name="cde08d90-00f3-4d02-973a-1ae3b840cdaf"></a>
<b>_endPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b992121d-903a-483d-af19-e54bdd0ad490'>_radius</a></td><td style='width:75%' class='def'><p><a name="b992121d-903a-483d-af19-e54bdd0ad490"></a>
<b>_radius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radius for radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9655263d-88ef-4901-aad1-e8f14135f61a'>_tileMode</a></td><td style='width:75%' ><p><a name="9655263d-88ef-4901-aad1-e8f14135f61a"></a>
<b>_tileMode</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The gradient tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e6cf1cd-6096-4f55-bc44-d4977414b2ae'>_selectedHandle</a></td><td style='width:75%' class='def'><p><a name="7e6cf1cd-6096-4f55-bc44-d4977414b2ae"></a>
<b>_selectedHandle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5588d25b-2c57-4e00-8668-332191a60e24'>PerformingDrag</a></td><td style='width:75%' ><p><a name="5588d25b-2c57-4e00-8668-332191a60e24"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Is the user performing a drag operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#61abd0f7-fa18-41c7-838f-05bd313fe9ef'>GradientType</a></td><td style='width:75%' ><p><a name="61abd0f7-fa18-41c7-838f-05bd313fe9ef"></a></p>

<h3>GradientType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the gradient.</p>

<h4>Return Value</h4>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8b0cb7f-77ca-4ccf-874d-ce5adb3f6f65'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="b8b0cb7f-77ca-4ccf-874d-ce5adb3f6f65"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f79b2fff-1426-421b-9092-cd56a3c011cc'>ElementName</a></td><td style='width:75%' ><p><a name="f79b2fff-1426-421b-9092-cd56a3c011cc"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34a28476-c4fa-4d26-890c-abad47ad991c'>Name</a></td><td style='width:75%' class='def'><p><a name="34a28476-c4fa-4d26-890c-abad47ad991c"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78517ae7-efcb-4e34-bdd2-883d74dc5893'>BarWidth</a></td><td style='width:75%' ><p><a name="78517ae7-efcb-4e34-bdd2-883d74dc5893"></a></p>

<h3>BarWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the bar.</p>

<h4>Return Value</h4>

<p>The width of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab898c10-cf04-4638-9558-8a63b6d7875b'>BarHeight</a></td><td style='width:75%' class='def'><p><a name="ab898c10-cf04-4638-9558-8a63b6d7875b"></a></p>

<h3>BarHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the bar.</p>

<h4>Return Value</h4>

<p>The height of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2615e435-2d73-4e80-908e-0c99c8fc1b20'>PreviewWidth</a></td><td style='width:75%' ><p><a name="2615e435-2d73-4e80-908e-0c99c8fc1b20"></a></p>

<h3>PreviewWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the preview.</p>

<h4>Return Value</h4>

<p>The width of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f19fa6b-e604-4a7c-88b5-d31ef5a5aeae'>PreviewHeight</a></td><td style='width:75%' class='def'><p><a name="8f19fa6b-e604-4a7c-88b5-d31ef5a5aeae"></a></p>

<h3>PreviewHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the preview.</p>

<h4>Return Value</h4>

<p>The height of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a068bce4-d1fe-4972-933b-2cd4cd26290f'>StartPoint</a></td><td style='width:75%' ><p><a name="a068bce4-d1fe-4972-933b-2cd4cd26290f"></a></p>

<h3>StartPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the start point.</p>

<h4>Return Value</h4>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9186f356-9de9-42e7-84da-e7d6658ebb14'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="9186f356-9de9-42e7-84da-e7d6658ebb14"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b78492b-05c5-4f75-83e0-d3c5de2db353'>Radius</a></td><td style='width:75%' ><p><a name="5b78492b-05c5-4f75-83e0-d3c5de2db353"></a></p>

<h3>Radius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the radius used by radial and conical gradients.</p>

<h4>Return Value</h4>

<p>The radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e12778f-028a-4848-b4b4-74e992bd2868'>TileMode</a></td><td style='width:75%' class='def'><p><a name="1e12778f-028a-4848-b4b4-74e992bd2868"></a></p>

<h3>TileMode</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tile mode.</p>

<h4>Return Value</h4>

<p>The tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13cc134d-ebcd-4ef7-86ae-f35bbf188e8f'>ControlPoints</a></td><td style='width:75%' ><p><a name="13cc134d-ebcd-4ef7-86ae-f35bbf188e8f"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the color.</p>

<h4>Return Value</h4>

<p>The control points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01e12e77-24b9-4b84-ac6c-44505d28bab9'>SelectedHandle</a></td><td style='width:75%' class='def'><p><a name="01e12e77-24b9-4b84-ac6c-44505d28bab9"></a></p>

<h3>SelectedHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected handle.</p>

<h4>Return Value</h4>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41b838fa-e443-46f8-a26c-3f5e198e26fc'>SelectedColor</a></td><td style='width:75%' ><p><a name="41b838fa-e443-46f8-a26c-3f5e198e26fc"></a></p>

<h3>SelectedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the selected handle.</p>

<h4>Return Value</h4>

<p>The color of the selected handle or black if no handle is selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95f64f97-f89c-4e2b-ae8f-f7271e6d3a58'>Shader</a></td><td style='width:75%' class='def'><p><a name="95f64f97-f89c-4e2b-ae8f-f7271e6d3a58"></a></p>

<h3>Shader</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the Skia Shader that represents this gradient.</p>

<h4>Return Value</h4>

<p>The <code>SKShader</code> for this gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1644ec72-19e2-4a6f-b1e9-106746f28309'>KimonoGradient</a></td><td style='width:75%' ><p><a name="1644ec72-19e2-4a6f-b1e9-106746f28309"></a></p>

<h3>KimonoGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8a5a2509-cb91-4b01-b5e9-111349587eb1">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5498ff3-31b8-4820-b44f-bdb2e7ff4025'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="a5498ff3-31b8-4820-b44f-bdb2e7ff4025"></a></p>

<h3>KimonoGradient (KimonoCore.KimonoGradientType, KimonoCore.KimonoHandle, KimonoCore.KimonoHandle, System.Single, SkiaSharp.SKShaderTileMode, SkiaSharp.SKColor[], System.Single[])</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8a5a2509-cb91-4b01-b5e9-111349587eb1">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradientType</td><td style='width:75%' ><p><a name="6483e7e2-2ca8-42d5-97cf-3e33c8f49596"></a>
Gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="cd2eaa68-8eaa-4076-99c6-123a607570fc"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="f7276fa6-ec1e-4edf-a926-418e8bf0be7a"></a>
End point.</p>
</td></tr><tr><td style='width:25%' class='term'>radius</td><td style='width:75%' class='def'><p><a name="67d732b9-2a7b-48ae-beef-aa798ca9f0e6"></a>
Radius.</p>
</td></tr><tr><td style='width:25%' class='term'>tileMode</td><td style='width:75%' ><p><a name="2d61e234-461f-4262-b0a2-a944e1cdca35"></a>
Tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'>colors</td><td style='width:75%' class='def'><p><a name="0026dc08-ad63-4e92-8be4-c74664f02fca"></a>
Colors.</p>
</td></tr><tr><td style='width:25%' class='term'>weights</td><td style='width:75%' ><p><a name="08dd95b2-8eb1-4806-8a6d-ec961194f4a3"></a>
Weights.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5ba2ba4-8842-4e8a-b6cb-cf085610a31d'>KimonoGradient</a></td><td style='width:75%' ><p><a name="b5ba2ba4-8842-4e8a-b6cb-cf085610a31d"></a></p>

<h3>KimonoGradient (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8a5a2509-cb91-4b01-b5e9-111349587eb1">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="2a6a80b9-49ca-43cc-9f34-11048aecb9fa"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="3829254b-3054-49f1-a784-c8a4d0ddb0aa"></a>
Bar height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f77a9e20-421f-4fa2-ac7d-7f6037d03681'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="f77a9e20-421f-4fa2-ac7d-7f6037d03681"></a></p>

<h3>KimonoGradient (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8a5a2509-cb91-4b01-b5e9-111349587eb1">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="bc1a02a6-6980-47dc-8833-a7fa64ca0632"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="378cb2f8-1fb4-487d-b204-d90361a61c3e"></a>
Bar height.</p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p><a name="f6e21101-11a7-46b6-a2c2-e8218051b14f"></a>
Preview width.</p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p><a name="a88110e9-cdea-472a-8b30-1064c9e02a91"></a>
Preview height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24c9db27-133c-4d9e-9199-afb60c64a9a0'>Initialize</a></td><td style='width:75%' ><p><a name="24c9db27-133c-4d9e-9199-afb60c64a9a0"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58935254-259e-43be-8a47-85b6c7a0e68c'>SortedColors</a></td><td style='width:75%' class='def'><p><a name="58935254-259e-43be-8a47-85b6c7a0e68c"></a></p>

<h3>SortedColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list of sorted colors by their "X" location inside the gradient.</p>

<h4>Returns</h4>

<p>The sorted colors arrays.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c29728f3-634e-457c-8b6a-1cca102e873f'>SortedWeights</a></td><td style='width:75%' ><p><a name="c29728f3-634e-457c-8b6a-1cca102e873f"></a></p>

<h3>SortedWeights ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list a color weights by their "X" location in the gradient.</p>

<h4>Returns</h4>

<p>The sorted weights.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55b6a87e-4904-4e17-8513-099f428c3def'>ConformingShader</a></td><td style='width:75%' class='def'><p><a name="55b6a87e-4904-4e17-8513-099f428c3def"></a></p>

<h3>ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Generates a shader that conforms to a given start and end point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="f9e2ea60-305d-4c8f-91eb-c8ba9053cb29"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="396d900d-169e-4925-801c-8cfb39c3cdef"></a>
End point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>SKShader</code> for the gradient bound to a given shape's dimentions.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#924e273a-0023-4a4b-a7e3-c683a25f544f'>AddControlPoint</a></td><td style='width:75%' ><p><a name="924e273a-0023-4a4b-a7e3-c683a25f544f"></a></p>

<h3>AddControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new control point to the gradients collection and makes it the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94683005-96a5-4665-b985-879dc7c20f5d'>DeleteSelectedControlPoint</a></td><td style='width:75%' class='def'><p><a name="94683005-96a5-4665-b985-879dc7c20f5d"></a></p>

<h3>DeleteSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6effc584-ae85-4b0d-851c-9dd59fc291f0'>DuplicateSelectedControlPoint</a></td><td style='width:75%' ><p><a name="6effc584-ae85-4b0d-851c-9dd59fc291f0"></a></p>

<h3>DuplicateSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a24a1e2f-f986-47d0-9d10-b98a2016afd1'>FindHandle</a></td><td style='width:75%' class='def'><p><a name="a24a1e2f-f986-47d0-9d10-b98a2016afd1"></a></p>

<h3>FindHandle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the handle matching the given unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="f0b1940c-fca9-452d-91ae-b10388dba9e1"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The matching <code>KimonoHandle</code> or <code>null</code> if not found.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b40e8ed2-cfb8-4681-88bb-c9a6e13c1136'>DrawBar</a></td><td style='width:75%' ><p><a name="b40e8ed2-cfb8-4681-88bb-c9a6e13c1136"></a></p>

<h3>DrawBar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bar.</p>

<h4>Returns</h4>

<p>The bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14143d4f-9878-489f-ac44-8239746c2908'>DrawPreview</a></td><td style='width:75%' class='def'><p><a name="14143d4f-9878-489f-ac44-8239746c2908"></a></p>

<h3>DrawPreview ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the preview.</p>

<h4>Returns</h4>

<p>The preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dfffa81-4172-402c-aa04-424805b17529'>BarToolDown</a></td><td style='width:75%' ><p><a name="2dfffa81-4172-402c-aa04-424805b17529"></a></p>

<h3>BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="0ab8bd93-3eaf-4f75-8c91-5b392110aa91"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="0463dae0-7fea-42a1-95f9-bba3299e13e3"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="e5ac3541-6865-4cf4-880f-e7cf8790be98"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b134243-3e6a-4f42-9d4c-22ead71e38d0'>BarToolDrag</a></td><td style='width:75%' class='def'><p><a name="4b134243-3e6a-4f42-9d4c-22ead71e38d0"></a></p>

<h3>BarToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient design bar. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="bdec8368-13a0-448a-ab3c-58d367919638"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20b8be5c-9423-4cfa-9117-7307a71fdb37'>BarToolUp</a></td><td style='width:75%' ><p><a name="20b8be5c-9423-4cfa-9117-7307a71fdb37"></a></p>

<h3>BarToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="6b33b94f-4c39-4931-836e-36733404cdf4"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ca1a12e-1f54-4c9f-aaa4-3dfe4b6d9881'>PreviewToolDown</a></td><td style='width:75%' class='def'><p><a name="7ca1a12e-1f54-4c9f-aaa4-3dfe4b6d9881"></a></p>

<h3>PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="2bec7340-8830-4e06-8202-9911a6e5d8d9"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="7b291401-b8c8-4d9d-94cc-fd29fd1b8066"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="733bd50b-6df1-4ee1-ba9e-74bf140915b4"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#742bdb6c-a5db-4c46-8f82-2e980701ea05'>PreviewToolDrag</a></td><td style='width:75%' ><p><a name="742bdb6c-a5db-4c46-8f82-2e980701ea05"></a></p>

<h3>PreviewToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient preview. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="18d5cf3c-45a3-4cf4-98a6-b2e4e6d3c57e"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afec9096-286d-4f7c-ac19-e12846c7249b'>PreviewToolUp</a></td><td style='width:75%' class='def'><p><a name="afec9096-286d-4f7c-ac19-e12846c7249b"></a></p>

<h3>PreviewToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="bdc0ab57-b1db-47e6-af9f-96ee84767841"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94968a0a-a981-4058-8974-311f9dd3cc68'>ToObiScript</a></td><td style='width:75%' ><p><a name="94968a0a-a981-4058-8974-311f9dd3cc68"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c930d74-0500-41eb-afb8-4abe7ec227e8'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="7c930d74-0500-41eb-afb8-4abe7ec227e8"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1db9090f-aa06-4786-8cfa-72894fae332b'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="1db9090f-aa06-4786-8cfa-72894fae332b"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d85ab4a-c4ea-44de-9087-bd6b48b2d167'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="5d85ab4a-c4ea-44de-9087-bd6b48b2d167"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#837b557c-6df0-4a1a-b2ae-9c2a298d1375'>ColorsToCode</a></td><td style='width:75%' ><p><a name="837b557c-6df0-4a1a-b2ae-9c2a298d1375"></a></p>

<h3>ColorsToCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5ac6f48-caac-4f1a-a640-09d735d6324f'>ColorsToInitializer</a></td><td style='width:75%' class='def'><p><a name="b5ac6f48-caac-4f1a-a640-09d735d6324f"></a></p>

<h3>ColorsToInitializer (KimonoCore.CodeOutputLibrary, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7683293-9a39-44ab-a895-3f3990d3e085'>WeightsToSkiaCode</a></td><td style='width:75%' ><p><a name="d7683293-9a39-44ab-a895-3f3990d3e085"></a></p>

<h3>WeightsToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#749ce262-9e29-4fd7-b4ff-996117b10a95'>WeightsToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="749ce262-9e29-4fd7-b4ff-996117b10a95"></a></p>

<h3>WeightsToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19a322b3-a5fb-47e6-b542-be0da4e270f1'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="19a322b3-a5fb-47e6-b542-be0da4e270f1"></a></p>

<h3>ToCSharpSkia ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fa074f5-cf2a-4b0e-8feb-c4a6988abe41'>ToCSharpSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="3fa074f5-cf2a-4b0e-8feb-c4a6988abe41"></a></p>

<h3>ToCSharpSkiaInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77c5bc2b-735f-4bce-94fe-68c1ed88e4a1'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="77c5bc2b-735f-4bce-94fe-68c1ed88e4a1"></a></p>

<h3>ToCSharpSkia (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="6f0b5ba8-6c6a-47ce-a59d-8646c9ce0562"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="9af20791-0588-4296-bb12-9dfa201dbd57"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dba2e2d-caef-49d3-ae59-ae1532ef07e6'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="0dba2e2d-caef-49d3-ae59-ae1532ef07e6"></a></p>

<h3>ToCSharpKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6ed2db6-834c-4616-828a-56b699753b06'>ToCSharpKimonoCoreInitializer</a></td><td style='width:75%' ><p><a name="c6ed2db6-834c-4616-828a-56b699753b06"></a></p>

<h3>ToCSharpKimonoCoreInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a60b29f-91f7-49f3-93cf-588677304a00'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="9a60b29f-91f7-49f3-93cf-588677304a00"></a></p>

<h3>ToCSharpKimonoCore (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="b3e11519-163d-4e3b-a708-39a42c733313"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="1fb4454c-58df-4230-9272-ba8f03fc5eb9"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a3f77b3-6ec4-41b6-a440-1cb6606f4c81'>ToCSharp</a></td><td style='width:75%' ><p><a name="8a3f77b3-6ec4-41b6-a440-1cb6606f4c81"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="72df1200-c0de-4012-90d0-4dbc25f527bb"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7735f94-1706-4fae-91b7-14b6706ef270'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="b7735f94-1706-4fae-91b7-14b6706ef270"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d1467eb1-1918-40be-a3b1-14af1a348916"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42ee85de-b271-4d5a-9889-fc68d127cff4'>ToCSharp</a></td><td style='width:75%' ><p><a name="42ee85de-b271-4d5a-9889-fc68d127cff4"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ea679a7a-0c23-4949-9bb7-cfac9fa9b1f0"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="663680c2-7df6-4132-96c5-5b14a6b1c45c"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="6e8af952-b6ae-4f3e-be9a-70336c146c0c"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a83367a-444a-4b9b-af73-4c6dec21089a'>ToCode</a></td><td style='width:75%' class='def'><p><a name="8a83367a-444a-4b9b-af73-4c6dec21089a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="20c7d76b-b06e-4677-b0dd-6403188642c9"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="c323067d-bc5f-47af-8f89-1d0a8bed3993"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ca0b9e1f-0dfb-4c5f-b712-76347f6513a1"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d90b0433-c283-4405-8505-cb95c3ae0441'>Clone</a></td><td style='width:75%' ><p><a name="d90b0433-c283-4405-8505-cb95c3ae0441"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#067424b5-f09b-4f10-aebe-885f78cc3de1'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p><a name="067424b5-f09b-4f10-aebe-885f78cc3de1"></a></p>

<h3>RaiseGradientModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9713f914-5f05-4aa1-9855-f57c4ed44efc'>RaiseHandleSelected</a></td><td style='width:75%' ><p><a name="9713f914-5f05-4aa1-9855-f57c4ed44efc"></a></p>

<h3>RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="8f029094-7776-4d19-a280-e45f58dc9f50"></a>
Handle.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#158b17d7-a97c-46ee-a8e3-3392fd6372b1'>GradientModified</a></td><td style='width:75%' ><p><a name="158b17d7-a97c-46ee-a8e3-3392fd6372b1"></a></p>

<h3>GradientModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#772576e5-1bed-4b4d-80ef-b44045368395'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="772576e5-1bed-4b4d-80ef-b44045368395"></a></p>

<h3>HandleSelected</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="e698df07-aee0-4f0b-80de-f6dfafdc63a8"></a>
##KimonoGradientType

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Kimono gradient type.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d642a5fb-0ba0-4a21-97f3-395912ff12fb'>LinearGradient</a></td><td style='width:75%' ><p><a name="d642a5fb-0ba0-4a21-97f3-395912ff12fb"></a>
<b>LinearGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The linear gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ab1aa6c-c829-423e-a00e-2a40b7f51a92'>RadialGradient</a></td><td style='width:75%' class='def'><p><a name="5ab1aa6c-c829-423e-a00e-2a40b7f51a92"></a>
<b>RadialGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radial gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#791ed44c-6f77-4107-9398-86d554cd6356'>SweepGradient</a></td><td style='width:75%' ><p><a name="791ed44c-6f77-4107-9398-86d554cd6356"></a>
<b>SweepGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The sweep gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#318f89e9-2a9e-47d5-8e20-8c6bafaa75b3'>ConicalGradient</a></td><td style='width:75%' class='def'><p><a name="318f89e9-2a9e-47d5-8e20-8c6bafaa75b3"></a>
<b>ConicalGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The conical gradient.</p>
</td></tr></table></p>


---

<a name="d460dc02-2b42-47ca-86fd-eb637f258ef6"></a>
##KimonoStyle

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines as style that can be applied to a `KimonoShape` to control its appearance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8e65b032-c3d4-4956-9dd8-6b9d48f8817c'>_frameColor</a></td><td style='width:75%' ><p><a name="8e65b032-c3d4-4956-9dd8-6b9d48f8817c"></a>
<b>_frameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's frame color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fcfc268-7e15-46c3-980e-b5d3f4fb2f45'>_fillColor</a></td><td style='width:75%' class='def'><p><a name="7fcfc268-7e15-46c3-980e-b5d3f4fb2f45"></a>
<b>_fillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's fill color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14b1799f-fe82-4797-8456-88bf0d7aa5b4'>_frameGradient</a></td><td style='width:75%' ><p><a name="14b1799f-fe82-4797-8456-88bf0d7aa5b4"></a>
<b>_frameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c4194e6-fe19-4a82-a237-8802cba8e808'>_fillGradient</a></td><td style='width:75%' class='def'><p><a name="4c4194e6-fe19-4a82-a237-8802cba8e808"></a>
<b>_fillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#350d026f-567c-4399-badf-e50cfd786e7c'>_hasFrameJitter</a></td><td style='width:75%' ><p><a name="350d026f-567c-4399-badf-e50cfd786e7c"></a>
<b>_hasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83b02d34-fc79-4a73-a74a-e023faf5adb3'>_frameJitterLength</a></td><td style='width:75%' class='def'><p><a name="83b02d34-fc79-4a73-a74a-e023faf5adb3"></a>
<b>_frameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78a5d797-31da-460a-915b-61eccd3c8dae'>_frameJitterDeviation</a></td><td style='width:75%' ><p><a name="78a5d797-31da-460a-915b-61eccd3c8dae"></a>
<b>_frameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fa83bc6-9b64-4d58-a559-2cc2d4ccb599'>_hasFillJitter</a></td><td style='width:75%' class='def'><p><a name="4fa83bc6-9b64-4d58-a559-2cc2d4ccb599"></a>
<b>_hasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the fill uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f73efcfe-3e75-45ec-8882-61a5f81c86b9'>_fillJitterLength</a></td><td style='width:75%' ><p><a name="f73efcfe-3e75-45ec-8882-61a5f81c86b9"></a>
<b>_fillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f62038ed-9a44-46a0-a418-12094d6e1fee'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="f62038ed-9a44-46a0-a418-12094d6e1fee"></a>
<b>_fillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5367b79-35d6-4862-a493-e90e80dd9c4c'>_hasFrameDash</a></td><td style='width:75%' ><p><a name="d5367b79-35d6-4862-a493-e90e80dd9c4c"></a>
<b>_hasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame has a dash effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6edfeee2-d6a0-4337-b7a8-46b4c420a5b9'>_hasFillBlur</a></td><td style='width:75%' class='def'><p><a name="6edfeee2-d6a0-4337-b7a8-46b4c420a5b9"></a>
<b>_hasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d9971bc-5e59-4fb5-9352-98a6f9103114'>_fillBlur</a></td><td style='width:75%' ><p><a name="3d9971bc-5e59-4fb5-9352-98a6f9103114"></a>
<b>_fillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0125bca1-7a8c-4c2d-9014-7768083fae90'>_hasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="0125bca1-7a8c-4c2d-9014-7768083fae90"></a>
<b>_hasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0dbe06e-806c-48bd-9f67-f3576d8978a6'>_frameBlur</a></td><td style='width:75%' ><p><a name="a0dbe06e-806c-48bd-9f67-f3576d8978a6"></a>
<b>_frameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1bd33f1-93ab-45cb-b5aa-4d1637080a46'>_hasFillShadow</a></td><td style='width:75%' class='def'><p><a name="c1bd33f1-93ab-45cb-b5aa-4d1637080a46"></a>
<b>_hasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd279e5f-dfe0-4f37-aae1-e30a52c96291'>_fillShadow</a></td><td style='width:75%' ><p><a name="dd279e5f-dfe0-4f37-aae1-e30a52c96291"></a>
<b>_fillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3069a3e9-cf9f-4b8a-80f1-d478f4216806'>_hasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="3069a3e9-cf9f-4b8a-80f1-d478f4216806"></a>
<b>_hasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#649ba3bf-f209-49e5-9bd1-a3ca01219141'>_frameShadow</a></td><td style='width:75%' ><p><a name="649ba3bf-f209-49e5-9bd1-a3ca01219141"></a>
<b>_frameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#51ab48a8-b879-4fea-8dd6-26b2604354a6'>UniqueID</a></td><td style='width:75%' ><p><a name="51ab48a8-b879-4fea-8dd6-26b2604354a6"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a36ff01f-a3e1-4c7f-ac64-b13caec748c8'>ElementName</a></td><td style='width:75%' class='def'><p><a name="a36ff01f-a3e1-4c7f-ac64-b13caec748c8"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fea3cf4-b1bf-44c4-b19c-e91f0094cf6a'>Name</a></td><td style='width:75%' ><p><a name="7fea3cf4-b1bf-44c4-b19c-e91f0094cf6a"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e8bb16f-e405-4b22-a283-1372554d5174'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="2e8bb16f-e405-4b22-a283-1372554d5174"></a></p>

<h3>HasFrame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> has a frame.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b95a39b-0b8d-45ab-a496-150b55b4ad53'>Frame</a></td><td style='width:75%' ><p><a name="1b95a39b-0b8d-45ab-a496-150b55b4ad53"></a></p>

<h3>Frame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#233db319-060c-4a24-a4fc-fdd89a638ddb'>HasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="233db319-060c-4a24-a4fc-fdd89a638ddb"></a></p>

<h3>HasFrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> has frame blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d69159ba-418b-4531-8cc3-b75ef70c6e2c'>FrameBlur</a></td><td style='width:75%' ><p><a name="d69159ba-418b-4531-8cc3-b75ef70c6e2c"></a></p>

<h3>FrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c34209ef-c6ac-472b-947a-80663953f02f'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="c34209ef-c6ac-472b-947a-80663953f02f"></a></p>

<h3>HasFrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> has frame shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db633a73-1b69-469b-ac5a-64115dffc25d'>FrameShadow</a></td><td style='width:75%' ><p><a name="db633a73-1b69-469b-ac5a-64115dffc25d"></a></p>

<h3>FrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame shadow.</p>

<h4>Return Value</h4>

<p>The frame shadow as a <code>KimonoShadow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d02f224-08e3-41cb-aa73-ae77a7278c2f'>HasFillBlur</a></td><td style='width:75%' class='def'><p><a name="7d02f224-08e3-41cb-aa73-ae77a7278c2f"></a></p>

<h3>HasFillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> has fill blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d17b9f3c-52c0-4768-86f2-e5391d0397e9'>FillBlur</a></td><td style='width:75%' ><p><a name="d17b9f3c-52c0-4768-86f2-e5391d0397e9"></a></p>

<h3>FillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe3ee098-8e7f-47d9-80c1-56f522dfa63a'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="fe3ee098-8e7f-47d9-80c1-56f522dfa63a"></a></p>

<h3>HasFillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> has fill shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68a092bf-3018-4f5a-8196-592f7fcd9efb'>FillShadow</a></td><td style='width:75%' ><p><a name="68a092bf-3018-4f5a-8196-592f7fcd9efb"></a></p>

<h3>FillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill shadow.</p>

<h4>Return Value</h4>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31edbfe4-a5c9-494a-90d3-854af149eb95'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="31edbfe4-a5c9-494a-90d3-854af149eb95"></a></p>

<h3>FrameColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the frame as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28234e25-a1cd-4a65-bc50-1faf6b6fe9b4'>FrameGradient</a></td><td style='width:75%' ><p><a name="28234e25-a1cd-4a65-bc50-1faf6b6fe9b4"></a></p>

<h3>FrameGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame gradient.</p>

<h4>Return Value</h4>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3b11575-d922-494e-a80a-78e485ae9830'>HasFill</a></td><td style='width:75%' class='def'><p><a name="b3b11575-d922-494e-a80a-78e485ae9830"></a></p>

<h3>HasFill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> has fill.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef4dcd53-0e90-4301-a8ea-914a482ba518'>Fill</a></td><td style='width:75%' ><p><a name="ef4dcd53-0e90-4301-a8ea-914a482ba518"></a></p>

<h3>Fill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36a49f65-37b5-49c8-9729-bd018f60f036'>FillColor</a></td><td style='width:75%' class='def'><p><a name="36a49f65-37b5-49c8-9729-bd018f60f036"></a></p>

<h3>FillColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the fill as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2911c8a4-11b4-48e6-af63-fee44f93795a'>FillGradient</a></td><td style='width:75%' ><p><a name="2911c8a4-11b4-48e6-af63-fee44f93795a"></a></p>

<h3>FillGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill gradient.</p>

<h4>Return Value</h4>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d69d4e6-dc35-43f1-a489-b049bf1117e4'>StyleType</a></td><td style='width:75%' class='def'><p><a name="8d69d4e6-dc35-43f1-a489-b049bf1117e4"></a></p>

<h3>StyleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the style.</p>

<h4>Return Value</h4>

<p>The type of the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f47361d-dd4f-4ca5-955b-b03b8549ddfa'>FontMetrics</a></td><td style='width:75%' ><p><a name="7f47361d-dd4f-4ca5-955b-b03b8549ddfa"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#349dfdf1-6d87-49f9-b676-b2b0d85bad9f'>IsLinearText</a></td><td style='width:75%' class='def'><p><a name="349dfdf1-6d87-49f9-b676-b2b0d85bad9f"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ce82ff1-cc8b-48a3-b27c-5912a6e23f36'>IsVerticalText</a></td><td style='width:75%' ><p><a name="6ce82ff1-cc8b-48a3-b27c-5912a6e23f36"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bff58ca-69a7-48b5-baca-753cca209258'>StrikeThruText</a></td><td style='width:75%' class='def'><p><a name="0bff58ca-69a7-48b5-baca-753cca209258"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a6d66e3-efaf-4c1a-b6a1-10b65d128bf9'>TextAlign</a></td><td style='width:75%' ><p><a name="2a6d66e3-efaf-4c1a-b6a1-10b65d128bf9"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c4e1b4b-151f-48cb-aaf8-6a28e720c296'>TextEncoding</a></td><td style='width:75%' class='def'><p><a name="7c4e1b4b-151f-48cb-aaf8-6a28e720c296"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1a4ab2a-ae6d-4053-80db-2d83cbb65f99'>TextScaleX</a></td><td style='width:75%' ><p><a name="a1a4ab2a-ae6d-4053-80db-2d83cbb65f99"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38522d22-6987-469a-bacf-5cd2e42a24ef'>TextSize</a></td><td style='width:75%' class='def'><p><a name="38522d22-6987-469a-bacf-5cd2e42a24ef"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e7c894e-871a-4c7f-bcf7-62b80d4d9694'>TextSkewX</a></td><td style='width:75%' ><p><a name="1e7c894e-871a-4c7f-bcf7-62b80d4d9694"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#caf74574-277e-4b8f-bbf2-669511144c01'>Typeface</a></td><td style='width:75%' class='def'><p><a name="caf74574-277e-4b8f-bbf2-669511144c01"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31e410e1-bf1d-415b-9370-a22a85f27e01'>FontFamilyName</a></td><td style='width:75%' ><p><a name="31e410e1-bf1d-415b-9370-a22a85f27e01"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75796c3b-53ad-4959-b2dc-180b1500cbba'>TypefaceStyle</a></td><td style='width:75%' class='def'><p><a name="75796c3b-53ad-4959-b2dc-180b1500cbba"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcaf8c2e-8211-4105-9f13-29ced6d272e8'>UnderlineText</a></td><td style='width:75%' ><p><a name="fcaf8c2e-8211-4105-9f13-29ced6d272e8"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c87a99bd-8305-4b10-95df-a0fe6e0cdb15'>HasFrameJitter</a></td><td style='width:75%' class='def'><p><a name="c87a99bd-8305-4b10-95df-a0fe6e0cdb15"></a></p>

<h3>HasFrameJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63bb21df-8c7b-46a1-a472-9693626f82e4'>FrameJitterLength</a></td><td style='width:75%' ><p><a name="63bb21df-8c7b-46a1-a472-9693626f82e4"></a></p>

<h3>FrameJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the frame jitter.</p>

<h4>Return Value</h4>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f501ae8b-284d-4e8e-819f-ed34ae6e8dd4'>FrameJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="f501ae8b-284d-4e8e-819f-ed34ae6e8dd4"></a></p>

<h3>FrameJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame jitter deviation.</p>

<h4>Return Value</h4>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73c3f382-0852-473d-bf5c-f62765b46c1b'>HasFillJitter</a></td><td style='width:75%' ><p><a name="73c3f382-0852-473d-bf5c-f62765b46c1b"></a></p>

<h3>HasFillJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the fill jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fea816cf-8605-4842-beaa-d7113dcfd659'>FillJitterLength</a></td><td style='width:75%' class='def'><p><a name="fea816cf-8605-4842-beaa-d7113dcfd659"></a></p>

<h3>FillJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the fill jitter.</p>

<h4>Return Value</h4>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64d96560-0071-4ab9-b6f0-a9e9cec7cc01'>FillJitterDeviation</a></td><td style='width:75%' ><p><a name="64d96560-0071-4ab9-b6f0-a9e9cec7cc01"></a></p>

<h3>FillJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill jitter deviation.</p>

<h4>Return Value</h4>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f3f1375-5a19-479e-aea0-8194f8661cae'>HasFrameDash</a></td><td style='width:75%' class='def'><p><a name="4f3f1375-5a19-479e-aea0-8194f8661cae"></a></p>

<h3>HasFrameDash</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame has a dash.</p>

<h4>Return Value</h4>

<p><code>true</code> if the frame has a dash; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#609cba4c-2e0f-4e76-ab17-c022f0c2d2c7'>DashPattern</a></td><td style='width:75%' ><p><a name="609cba4c-2e0f-4e76-ab17-c022f0c2d2c7"></a></p>

<h3>DashPattern</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the dash pattern.</p>

<h4>Return Value</h4>

<p>The dash pattern.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e929320-42f7-4c3e-b7b7-6d0b17e23837'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="9e929320-42f7-4c3e-b7b7-6d0b17e23837"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoStyle</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a5860dd-6f14-43ef-993c-a1c91088bf4c'>PropertyConnections</a></td><td style='width:75%' ><p><a name="2a5860dd-6f14-43ef-993c-a1c91088bf4c"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9f3847f2-48d7-4eb0-a57a-b4cea8af1ff7'>ClonePaint</a></td><td style='width:75%' ><p><a name="9f3847f2-48d7-4eb0-a57a-b4cea8af1ff7"></a></p>

<h3>ClonePaint (SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPaint</code> object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p><a name="036932ac-698d-4761-bb16-78c46d9dedcb"></a>
The <code>SKPaint</code> object to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>SKPaint</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87981961-f496-4a4d-a609-fa683453e7f0'>KimonoStyle</a></td><td style='width:75%' class='def'><p><a name="87981961-f496-4a4d-a609-fa683453e7f0"></a></p>

<h3>KimonoStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d460dc02-2b42-47ca-86fd-eb637f258ef6">KimonoStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d7183bc-022c-4911-a899-0728ee703463'>Initialize</a></td><td style='width:75%' ><p><a name="1d7183bc-022c-4911-a899-0728ee703463"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ca13aac-e8db-4bcc-a851-d807d38e5d97'>HandleFrameBlurOrShadowChange</a></td><td style='width:75%' class='def'><p><a name="7ca13aac-e8db-4bcc-a851-d807d38e5d97"></a></p>

<h3>HandleFrameBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d17f4d4-483d-443e-9ea0-d39064cec730'>HandleFillBlurOrShadowChange</a></td><td style='width:75%' ><p><a name="4d17f4d4-483d-443e-9ea0-d39064cec730"></a></p>

<h3>HandleFillBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a06228a7-3f0f-4876-b571-6255c02567be'>HandleFrameColorChange</a></td><td style='width:75%' class='def'><p><a name="a06228a7-3f0f-4876-b571-6255c02567be"></a></p>

<h3>HandleFrameColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#157cf06f-5c78-4e8d-997b-6e3a0e8ec9bb'>HandleFillColorChange</a></td><td style='width:75%' ><p><a name="157cf06f-5c78-4e8d-997b-6e3a0e8ec9bb"></a></p>

<h3>HandleFillColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb4d95e8-b92a-45a7-870b-e5ca3c58ba10'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p><a name="bb4d95e8-b92a-45a7-870b-e5ca3c58ba10"></a></p>

<h3>HandleFrameGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41cb0342-283f-4149-addd-ba20e5de5011'>HandleFillGradientChange</a></td><td style='width:75%' ><p><a name="41cb0342-283f-4149-addd-ba20e5de5011"></a></p>

<h3>HandleFillGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dce5f65-a785-46d2-a9d5-7fa904a628d1'>MakeDashInterval</a></td><td style='width:75%' class='def'><p><a name="5dce5f65-a785-46d2-a9d5-7fa904a628d1"></a></p>

<h3>MakeDashInterval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the dash interval from the dash pattern.</p>

<h4>Returns</h4>

<p>The dash interval.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#764abea8-1d93-41db-9f61-6e0082876e9b'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="764abea8-1d93-41db-9f61-6e0082876e9b"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="2c5aacea-103d-458c-93ee-7a668c961b4c"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="8ea19a76-a621-40ff-88bb-84aead7e0465"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2be136f6-700c-4332-86f1-1ecd71efc8a0'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="2be136f6-700c-4332-86f1-1ecd71efc8a0"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="8cd6a155-9950-4066-a15a-4ba759abb6a1"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d171680-315e-421b-89f0-bbcbda840121'>RemoveProperty</a></td><td style='width:75%' ><p><a name="3d171680-315e-421b-89f0-bbcbda840121"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="522d1fe5-cac9-4320-9f10-db607f2800ea"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7872ce32-0215-436a-8f21-de71df69e54f'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="7872ce32-0215-436a-8f21-de71df69e54f"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoStyle</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbcf4397-e641-419c-9af7-91130e61e8f3'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="dbcf4397-e641-419c-9af7-91130e61e8f3"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="e7c8a9b1-8a17-4621-be93-12ee9d14ee94"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4e152bb-1aae-4307-b42a-f5fe86f8bbf0'>ApplyFrameEffects</a></td><td style='width:75%' class='def'><p><a name="a4e152bb-1aae-4307-b42a-f5fe86f8bbf0"></a></p>

<h3>ApplyFrameEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the frame effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0aa1a011-1274-472e-bce6-d83a815039aa'>ApplyFillEffects</a></td><td style='width:75%' ><p><a name="0aa1a011-1274-472e-bce6-d83a815039aa"></a></p>

<h3>ApplyFillEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the fill effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81a553bd-aa9b-405b-83c1-63a7ee7760bb'>ToObiScript</a></td><td style='width:75%' class='def'><p><a name="81a553bd-aa9b-405b-83c1-63a7ee7760bb"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb5ff7b9-f1a5-4087-83ff-b638cd46394d'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="fb5ff7b9-f1a5-4087-83ff-b638cd46394d"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2fbc600-e7d0-42ab-a074-26eeaf1619a4'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="f2fbc600-e7d0-42ab-a074-26eeaf1619a4"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c919710b-516f-4217-b9c2-8612939931cc'>FillToSkiaCode</a></td><td style='width:75%' ><p><a name="c919710b-516f-4217-b9c2-8612939931cc"></a></p>

<h3>FillToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25a13ca7-318c-4d5f-b7ca-67069fcda721'>FillToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="25a13ca7-318c-4d5f-b7ca-67069fcda721"></a></p>

<h3>FillToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdbc596c-a155-4b2d-aa6f-ce4ae3ec6879'>FrameToSkiaCode</a></td><td style='width:75%' ><p><a name="bdbc596c-a155-4b2d-aa6f-ce4ae3ec6879"></a></p>

<h3>FrameToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edaa503b-0e99-4e78-82a0-629882f8c02c'>FrameToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="edaa503b-0e99-4e78-82a0-629882f8c02c"></a></p>

<h3>FrameToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c0fc584-7c4e-451c-b8e8-84dd8cc7e6fe'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="8c0fc584-7c4e-451c-b8e8-84dd8cc7e6fe"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbd87700-fede-4476-b70b-83e67c053036'>ToKimonoCoreInitializer</a></td><td style='width:75%' class='def'><p><a name="bbd87700-fede-4476-b70b-83e67c053036"></a></p>

<h3>ToKimonoCoreInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbd624f3-196c-4d6e-a0e3-6c06ec5c3df2'>ToCSharp</a></td><td style='width:75%' ><p><a name="cbd624f3-196c-4d6e-a0e3-6c06ec5c3df2"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e7bca3e0-74d7-444e-9ee5-a8184ea65827"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c95a935-05a9-420e-9c19-b082732b99aa'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="7c95a935-05a9-420e-9c19-b082732b99aa"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="fd128cb8-2e3f-4311-87d7-95a2aee94856"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80cc4689-0c34-4289-865d-42f0b7bed9f3'>ToCode</a></td><td style='width:75%' ><p><a name="80cc4689-0c34-4289-865d-42f0b7bed9f3"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="a236a11b-4bcd-418b-b305-85bb67657aef"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="753854e0-f579-4d0d-9f81-8f54e24fc1b1"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="156f5784-215c-401a-bcbf-d094011082c2"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a3edbc8-93e1-4aac-9703-ecb6ea6059bc'>Clone</a></td><td style='width:75%' class='def'><p><a name="5a3edbc8-93e1-4aac-9703-ecb6ea6059bc"></a></p>

<h3>Clone (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p><a name="fd2a03f4-3ab2-4d5f-af4d-bbdae55781cc"></a>
If set to <code>true</code>, a deep clone of the style is made.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The a clone of the <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="9d46f18a-8e5a-45c4-b61d-08b40d68c61f"></a>
##KimonoStyleType

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoStyle` that will be used to draw a given `KimonoShape` in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4903020c-95b8-4a66-b731-d7816dfacd2a'>Default</a></td><td style='width:75%' ><p><a name="4903020c-95b8-4a66-b731-d7816dfacd2a"></a>
<b>Default</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default style for new shapes. This style cannot be deleted or renamed by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d00a819b-1ebf-4c26-880d-457d2c2ca66a'>Custom</a></td><td style='width:75%' class='def'><p><a name="d00a819b-1ebf-4c26-880d-457d2c2ca66a"></a>
<b>Custom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom style that belongs only to an individual shape instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e60476fa-3d6e-429c-9d43-cde79a6b400e'>CustomText</a></td><td style='width:75%' ><p><a name="e60476fa-3d6e-429c-9d43-cde79a6b400e"></a>
<b>CustomText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom text style that belongs only to an individual <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d809336-7a95-475f-8a41-b54c7801f454'>Standard</a></td><td style='width:75%' class='def'><p><a name="0d809336-7a95-475f-8a41-b54c7801f454"></a>
<b>Standard</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared style that can be applied to multiple <code>Kimonoshape</code> instances.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b93067cf-bf95-4831-ad61-129515ed35a6'>Text</a></td><td style='width:75%' ><p><a name="b93067cf-bf95-4831-ad61-129515ed35a6"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared text style that can be applied to multiple <code>KimonoShapeText</code> instances.</p>
</td></tr></table></p>


---

<a name="019dcf5a-79c3-4301-9ab7-43774ca8c2e1"></a>
##KimonoPropertyRect

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `SKRect`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e4240fa8-19ae-4bf0-a4bb-6698fc35199c'>Value</a></td><td style='width:75%' ><p><a name="e4240fa8-19ae-4bf0-a4bb-6698fc35199c"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value as a <code>SKRect</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#774c1f5d-9fe8-431b-9d1b-f74328e52b7a'>KimonoPropertyRect</a></td><td style='width:75%' ><p><a name="774c1f5d-9fe8-431b-9d1b-f74328e52b7a"></a></p>

<h3>KimonoPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#019dcf5a-79c3-4301-9ab7-43774ca8c2e1">KimonoPropertyRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a98aad23-ccb1-461c-91a7-290bfd987ff6'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="a98aad23-ccb1-461c-91a7-290bfd987ff6"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39dfa94c-1286-4174-b270-208d8ead19b0'>ToRect</a></td><td style='width:75%' ><p><a name="39dfa94c-1286-4174-b270-208d8ead19b0"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c99291d-af8a-4115-a22a-01080c3f2ec5'>Clone</a></td><td style='width:75%' class='def'><p><a name="5c99291d-af8a-4115-a22a-01080c3f2ec5"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="834c51a0-25f8-4673-bef6-7957d4cc45e1"></a>
##KimonoPropertyNumber

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `float` or `int` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ffdda23d-7d88-41b7-b964-17277cd2ff96'>Value</a></td><td style='width:75%' ><p><a name="ffdda23d-7d88-41b7-b964-17277cd2ff96"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>float</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c7dff390-8d6f-4ed9-94cc-367febec9bf5'>KimonoPropertyNumber</a></td><td style='width:75%' ><p><a name="c7dff390-8d6f-4ed9-94cc-367febec9bf5"></a></p>

<h3>KimonoPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#834c51a0-25f8-4673-bef6-7957d4cc45e1">KimonoPropertyNumber</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecc948e7-688d-4093-85c1-dec3a573c23e'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="ecc948e7-688d-4093-85c1-dec3a573c23e"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#673ac4ce-3e30-484e-a14e-4524b258b645'>ToFloat</a></td><td style='width:75%' ><p><a name="673ac4ce-3e30-484e-a14e-4524b258b645"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51a5806c-5f1a-4511-890e-a38676e734d3'>ToInt</a></td><td style='width:75%' class='def'><p><a name="51a5806c-5f1a-4511-890e-a38676e734d3"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c9abd78-2f6b-4f18-bd4e-9d6e96071649'>Clone</a></td><td style='width:75%' ><p><a name="7c9abd78-2f6b-4f18-bd4e-9d6e96071649"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="17855e00-4772-4f25-a9a8-9cbb07eb0c52"></a>
##KimonoPropertyStyle

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c07b149c-03f1-4090-860d-9adf918aa292'>Value</a></td><td style='width:75%' ><p><a name="c07b149c-03f1-4090-860d-9adf918aa292"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91d5b00b-991c-49fa-9600-c86db6d42a8b'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="91d5b00b-991c-49fa-9600-c86db6d42a8b"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#8e7df6a4-e527-4fd3-a523-dfdbd3141fc9">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#51c9b15b-ec61-4f87-91b5-626319a7cd67'>KimonoPropertyStyle</a></td><td style='width:75%' ><p><a name="51c9b15b-ec61-4f87-91b5-626319a7cd67"></a></p>

<h3>KimonoPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#17855e00-4772-4f25-a9a8-9cbb07eb0c52">KimonoPropertyStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad22cf96-669f-42e6-8170-f750f0750176'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="ad22cf96-669f-42e6-8170-f750f0750176"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7a4fa8b-086d-48e2-9a16-0b917d653e1a'>ToStyle</a></td><td style='width:75%' ><p><a name="c7a4fa8b-086d-48e2-9a16-0b917d653e1a"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42e89a6f-b347-40fd-a80f-951cfb5af1b2'>Clone</a></td><td style='width:75%' class='def'><p><a name="42e89a6f-b347-40fd-a80f-951cfb5af1b2"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="b09ad7ae-b4e6-4374-879c-c4e072ce4272"></a>
##KimonoPropertyBoolean

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `bool` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2c307f50-a609-410b-9885-d7a720e82b49'>Value</a></td><td style='width:75%' ><p><a name="2c307f50-a609-410b-9885-d7a720e82b49"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>bool</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a8918244-8358-4ed7-9e2b-7e3753e69b80'>KimonoPropertyBoolean</a></td><td style='width:75%' ><p><a name="a8918244-8358-4ed7-9e2b-7e3753e69b80"></a></p>

<h3>KimonoPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b09ad7ae-b4e6-4374-879c-c4e072ce4272">KimonoPropertyBoolean</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67ebed30-9b80-4ea9-b3c2-4d35f9d6d24f'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="67ebed30-9b80-4ea9-b3c2-4d35f9d6d24f"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#685cb28e-01e0-48cc-bbc8-e5c0476c3a93'>ToBool</a></td><td style='width:75%' ><p><a name="685cb28e-01e0-48cc-bbc8-e5c0476c3a93"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p><code>true</code>, if bool was toed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bef80e3-f963-42a9-bd3a-caae1da649a0'>Clone</a></td><td style='width:75%' class='def'><p><a name="0bef80e3-f963-42a9-bd3a-caae1da649a0"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="0953fd99-bf88-435f-9824-c4d25a2980c9"></a>
##KimonoPropertyText

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `string` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5e923248-1456-447a-b4dd-daeb33adf673'>Value</a></td><td style='width:75%' ><p><a name="5e923248-1456-447a-b4dd-daeb33adf673"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#07024478-725e-49d1-9aaa-9161f5d07099'>KimonoPropertyText</a></td><td style='width:75%' ><p><a name="07024478-725e-49d1-9aaa-9161f5d07099"></a></p>

<h3>KimonoPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0953fd99-bf88-435f-9824-c4d25a2980c9">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47261b7d-a319-449f-934c-15cfb973d96a'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="47261b7d-a319-449f-934c-15cfb973d96a"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c1e47d5-8174-4f2a-8bbc-f3cc90d0bc8b'>ToString</a></td><td style='width:75%' ><p><a name="0c1e47d5-8174-4f2a-8bbc-f3cc90d0bc8b"></a></p>

<h3>ToString ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>string</code>.</p>

<h4>Returns</h4>

<p>The <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b173bf8-55cb-4c01-a487-c437aa820e0b'>Clone</a></td><td style='width:75%' class='def'><p><a name="4b173bf8-55cb-4c01-a487-c437aa820e0b"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="8e7df6a4-e527-4fd3-a523-dfdbd3141fc9"></a>
##KimonoPropertyColor

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3c8ba1e7-662e-4301-bf0d-5088b0589763'>Value</a></td><td style='width:75%' ><p><a name="3c8ba1e7-662e-4301-bf0d-5088b0589763"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d67b8477-9028-4873-9577-4ebe478d3fa1'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="d67b8477-9028-4873-9577-4ebe478d3fa1"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#8e7df6a4-e527-4fd3-a523-dfdbd3141fc9">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4a7bfe9c-7671-46f0-8212-6e074170dec1'>KimonoPropertyColor</a></td><td style='width:75%' ><p><a name="4a7bfe9c-7671-46f0-8212-6e074170dec1"></a></p>

<h3>KimonoPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0953fd99-bf88-435f-9824-c4d25a2980c9">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecc85b41-ef45-4742-b4a3-b63d46cff3e3'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="ecc85b41-ef45-4742-b4a3-b63d46cff3e3"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7ae825b-e5d4-4d8a-8398-2931fb030263'>ToColor</a></td><td style='width:75%' ><p><a name="c7ae825b-e5d4-4d8a-8398-2931fb030263"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c257340-131b-4462-a6de-3fb01b8cadfa'>Clone</a></td><td style='width:75%' class='def'><p><a name="8c257340-131b-4462-a6de-3fb01b8cadfa"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="e2feeb79-abc3-47df-a1da-f55d81481fee"></a>
##KimonoPropertyGradient

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoGradient` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#502679c8-ac9e-48a7-b3ee-59e7b1d7822b'>Value</a></td><td style='width:75%' ><p><a name="502679c8-ac9e-48a7-b3ee-59e7b1d7822b"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75a286ee-3756-4124-b374-b7b9279782dc'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="75a286ee-3756-4124-b374-b7b9279782dc"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#8e7df6a4-e527-4fd3-a523-dfdbd3141fc9">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9a00f915-6a63-47fa-8eeb-9c5131ab1222'>KimonoPropertyGradient</a></td><td style='width:75%' ><p><a name="9a00f915-6a63-47fa-8eeb-9c5131ab1222"></a></p>

<h3>KimonoPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0953fd99-bf88-435f-9824-c4d25a2980c9">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#065a248c-1ab8-42e5-9f87-2ec52e198d60'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="065a248c-1ab8-42e5-9f87-2ec52e198d60"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17ebc66f-1aa8-43dd-b9d6-9d3d5bc9d04d'>ToGradient</a></td><td style='width:75%' ><p><a name="17ebc66f-1aa8-43dd-b9d6-9d3d5bc9d04d"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c98e35e-18ca-4f78-9d05-f11fa66161a2'>Clone</a></td><td style='width:75%' class='def'><p><a name="6c98e35e-18ca-4f78-9d05-f11fa66161a2"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="81709ecf-b192-4221-928d-69268a79bf31"></a>
##CodeOutputOS

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the OS that code will be generated for
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b0cda0ae-c965-4d95-aeb8-5ee4a1d0d1f0'>Windows</a></td><td style='width:75%' ><p><a name="b0cda0ae-c965-4d95-aeb8-5ee4a1d0d1f0"></a>
<b>Windows</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d008177-c553-4cbb-82bf-1225910b3b54'>WindowsUWP</a></td><td style='width:75%' class='def'><p><a name="9d008177-c553-4cbb-82bf-1225910b3b54"></a>
<b>WindowsUWP</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Universal Windows Platform.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12d5e118-9b18-435a-a2cc-65faede8d97d'>WindowsWPF</a></td><td style='width:75%' ><p><a name="12d5e118-9b18-435a-a2cc-65faede8d97d"></a>
<b>WindowsWPF</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Windows Presentation Foundation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54a06534-ce2f-4d1a-a38b-3d0e7ea36cab'>Android</a></td><td style='width:75%' class='def'><p><a name="54a06534-ce2f-4d1a-a38b-3d0e7ea36cab"></a>
<b>Android</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Android OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaa79e55-97b2-4579-93c0-eb9b4b3540d8'>iOS</a></td><td style='width:75%' ><p><a name="eaa79e55-97b2-4579-93c0-eb9b4b3540d8"></a>
<b>iOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For iOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8593160d-f843-4c2b-8dd5-6023561291bd'>tvOS</a></td><td style='width:75%' class='def'><p><a name="8593160d-f843-4c2b-8dd5-6023561291bd"></a>
<b>tvOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For tvOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f22bda3-c792-4fbd-8fb4-6c922c277c79'>macOS</a></td><td style='width:75%' ><p><a name="3f22bda3-c792-4fbd-8fb4-6c922c277c79"></a>
<b>macOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For macOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8208760-92f8-4b57-b1af-b87c93b2628b'>CrossPlatform</a></td><td style='width:75%' class='def'><p><a name="d8208760-92f8-4b57-b1af-b87c93b2628b"></a>
<b>CrossPlatform</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Cross-platform code.</p>
</td></tr></table></p>


---

<a name="7e7cd931-32a6-4ca4-9cc4-acb5d2df030f"></a>
##CodeOutputLanguage

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Defines the language that code will be output in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c9063e43-8dd6-43e1-b417-90201f20ca4c'>CSharp</a></td><td style='width:75%' ><p><a name="c9063e43-8dd6-43e1-b417-90201f20ca4c"></a>
<b>CSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for C#.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8aac17fd-14aa-46b4-9fbb-790494327c8d'>ObiScript</a></td><td style='width:75%' class='def'><p><a name="8aac17fd-14aa-46b4-9fbb-790494327c8d"></a>
<b>ObiScript</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for the internal ObiScript scripting language.</p>
</td></tr></table></p>


---

<a name="add24dce-0b9a-46c4-a407-3207833d873b"></a>
##CodeOutputLibrary

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Code output library.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#65d66517-0a9e-45e7-8aeb-a00edaa4efc2'>SkiaSharp</a></td><td style='width:75%' ><p><a name="65d66517-0a9e-45e7-8aeb-a00edaa4efc2"></a>
<b>SkiaSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output pure SkiaSharp code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eb0838d-4d1b-47d2-90eb-77adeccbbca0'>KimonoCore</a></td><td style='width:75%' class='def'><p><a name="8eb0838d-4d1b-47d2-90eb-77adeccbbca0"></a>
<b>KimonoCore</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output code using the helper <code>KimonoCore</code> classes.</p>
</td></tr></table></p>


---

<a name="0d8617a9-bebf-448e-bf54-3866da7dbbe3"></a>
##KimonoCodeGenerator

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

The Kimono Code Generator has routine to assist in the generation of output source code.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#488bac09-cd8b-4c10-9e01-1bbb2b3056ff'>NextElementNumber</a></td><td style='width:75%' ><p><a name="488bac09-cd8b-4c10-9e01-1bbb2b3056ff"></a>
<b>NextElementNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The next element number.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61d2b23b-4d5f-4315-8ba1-1617873cfd0a'>AddNumberToElementNames</a></td><td style='width:75%' class='def'><p><a name="61d2b23b-4d5f-4315-8ba1-1617873cfd0a"></a>
<b>AddNumberToElementNames</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Add number to element names when generating.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef71e425-f0f6-4168-b466-0514715d75a1'>SupportingColors</a></td><td style='width:75%' ><p><a name="ef71e425-f0f6-4168-b466-0514715d75a1"></a>
<b>SupportingColors</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting colors that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09ec3462-d0a2-42e2-9208-e49e64ed60ea'>SupportingGradients</a></td><td style='width:75%' class='def'><p><a name="09ec3462-d0a2-42e2-9208-e49e64ed60ea"></a>
<b>SupportingGradients</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting gradients that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d05d139b-6378-4e91-aa91-20da8499c342'>SupportingStyles</a></td><td style='width:75%' ><p><a name="d05d139b-6378-4e91-aa91-20da8499c342"></a>
<b>SupportingStyles</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting styles that are required for the object being converted to source code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#96386f07-3e6b-409e-afbb-d2fe5628dfdc'>ResetCodeGeneration</a></td><td style='width:75%' ><p><a name="96386f07-3e6b-409e-afbb-d2fe5628dfdc"></a></p>

<h3>ResetCodeGeneration ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Resets the code generation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b8a74dd-608c-4a88-80b6-de5629e68093'>AddSupportingColor</a></td><td style='width:75%' class='def'><p><a name="8b8a74dd-608c-4a88-80b6-de5629e68093"></a></p>

<h3>AddSupportingColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given color to the collection of named colors that are used in the generation of other Kimono Objects. If a color is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="7891fa0e-d0b8-41cb-9998-76c3714f1a7a"></a>
The <code>KimonoColor</code> to add to the collection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4164dff9-ec17-4e08-a8a3-43490559487b'>CodeForSupportingColors</a></td><td style='width:75%' ><p><a name="4164dff9-ec17-4e08-a8a3-43490559487b"></a></p>

<h3>CodeForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="81bdc76e-23b5-44c7-a8ca-083ced53e822"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="34e6a71f-6e4b-4177-91df-4127d858cfb9"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49b67641-fdf4-4bc4-8763-a6496e7e6c53'>PropertyForSupportingColors</a></td><td style='width:75%' class='def'><p><a name="49b67641-fdf4-4bc4-8763-a6496e7e6c53"></a></p>

<h3>PropertyForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="8cecc037-c3c6-46ad-938b-10e81bb26a4e"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="ff0ea07d-0904-48af-83e1-b47dcbe40843"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20688e40-62cb-4b64-bd5f-a2f5a9016dcd'>AddSupportingGradient</a></td><td style='width:75%' ><p><a name="20688e40-62cb-4b64-bd5f-a2f5a9016dcd"></a></p>

<h3>AddSupportingGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given gradient to the collection of named gradients that are used in the generation of other Kimono Objects. If a gradient is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="50b05fe7-c69d-4305-a050-388af7e5b90e"></a>
The <code>KimonoGradient</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4291a2f1-51b1-4adf-98f7-79d01324083d'>CodeForSupportGradients</a></td><td style='width:75%' class='def'><p><a name="4291a2f1-51b1-4adf-98f7-79d01324083d"></a></p>

<h3>CodeForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="24e896fc-42d7-452f-9ecc-01dfc924ef39"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="56c19457-3437-4541-b051-357598d15360"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4190a5f7-d22d-4086-9b6b-cb7f208c7a2a'>PrivateVariablesForSupportingGradients</a></td><td style='width:75%' ><p><a name="4190a5f7-d22d-4086-9b6b-cb7f208c7a2a"></a></p>

<h3>PrivateVariablesForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="8ad03be9-c400-48ba-9e26-7c0c6cf4da51"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="87aaf57f-05a0-45da-999f-f6b2ed503966"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e26d1503-85a8-40c9-8cdd-3b58d21858db'>PropertyForSupportingGradients</a></td><td style='width:75%' class='def'><p><a name="e26d1503-85a8-40c9-8cdd-3b58d21858db"></a></p>

<h3>PropertyForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="b3d61eb7-67cb-440d-b4c0-c36475f582cc"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="8a115117-c2ac-41e4-9b85-fa944aa4653d"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b85e1317-38f7-4908-920d-d39aa91f845c'>InitializerForSupportGradients</a></td><td style='width:75%' ><p><a name="b85e1317-38f7-4908-920d-d39aa91f845c"></a></p>

<h3>InitializerForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="3f94cb25-a9f2-4521-9ee1-b150b96149ac"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="309a2d53-e3ef-4b47-bb39-810eaf28f36e"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea183cd0-9e00-4174-8cd0-e1d1b01a119d'>AddSupportingStyle</a></td><td style='width:75%' class='def'><p><a name="ea183cd0-9e00-4174-8cd0-e1d1b01a119d"></a></p>

<h3>AddSupportingStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given style to the collection of named styles that are used in the generation of other Kimono Objects. If a style is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="3b441e8d-1be0-4ef6-9785-269c48bd9943"></a>
The <code>KimonoStyle</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#368144dc-47e3-4f65-9d10-ab7712016455'>CodeForSupportStyles</a></td><td style='width:75%' ><p><a name="368144dc-47e3-4f65-9d10-ab7712016455"></a></p>

<h3>CodeForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="b9927622-b24a-4bb6-a5fe-b538d77bc2c3"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="342b9945-70a4-439e-b787-eae0b1c359cf"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#315f483a-451e-4bb6-a1a4-0410e836fc01'>PropertyForSupportingStyles</a></td><td style='width:75%' class='def'><p><a name="315f483a-451e-4bb6-a1a4-0410e836fc01"></a></p>

<h3>PropertyForSupportingStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="2d31ac0e-3ba1-402e-bd18-3cefce001bc0"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="4ec6f857-551e-40c3-81ef-1c7cda2047b6"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29117622-2879-4b37-8405-5112938afbcb'>InitializerForSupportStyles</a></td><td style='width:75%' ><p><a name="29117622-2879-4b37-8405-5112938afbcb"></a></p>

<h3>InitializerForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="f413b920-2389-4cc7-b26d-5b6beece5ed4"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="ada894ac-6615-4554-8096-ed2b931a1d95"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17d69624-436a-48b5-8f0c-ac8edbdfc846'>MakeElementName</a></td><td style='width:75%' class='def'><p><a name="17d69624-436a-48b5-8f0c-ac8edbdfc846"></a></p>

<h3>MakeElementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes a valid source code name for the name of a given Kimono Object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="7dfcd324-b877-4838-98d9-ecfa49c8b3bb"></a>
The source Kimono Object name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The element name valid for use in source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54700171-7882-4a2c-9931-832d2da5339f'>IncreaseIndentLevel</a></td><td style='width:75%' ><p><a name="54700171-7882-4a2c-9931-832d2da5339f"></a></p>

<h3>IncreaseIndentLevel (System.String, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code by the given number of levels</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="5a664102-97c3-4391-8bc1-fb64bedd1efa"></a>
Source code.</p>
</td></tr><tr><td style='width:25%' class='term'>levels</td><td style='width:75%' class='def'><p><a name="b108da92-c3e5-4118-9ad1-756a01ac6d50"></a>
Levels.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The indent level.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41ae1f7e-158b-4d8e-923d-6377092ecee6'>IncreaseIndentLevel</a></td><td style='width:75%' class='def'><p><a name="41ae1f7e-158b-4d8e-923d-6377092ecee6"></a></p>

<h3>IncreaseIndentLevel (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="f3de2807-6ee4-4be4-8303-5fbfeab86475"></a>
The source code to indent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code indented by one tab.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69275a1d-9729-4933-89ea-92172a15a731'>ColorToCode</a></td><td style='width:75%' ><p><a name="69275a1d-9729-4933-89ea-92172a15a731"></a></p>

<h3>ColorToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given color to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b61b2950-ee04-49c0-bede-46b958661e62"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="5a78f265-cd58-4121-aabd-a508758d7924"></a>
The <code>SKColor</code> to create code for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04d458a1-637e-43a9-bac6-2961e3379ff8'>PointToCode</a></td><td style='width:75%' class='def'><p><a name="04d458a1-637e-43a9-bac6-2961e3379ff8"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c11b20d3-5910-4569-a3d0-3e696e68d76b"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="801230f1-f729-4fcf-824a-2bf1e2a92777"></a>
The <code>SKPoint</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2223caa5-1638-454d-8dee-3841de7f4416'>PointToCode</a></td><td style='width:75%' ><p><a name="2223caa5-1638-454d-8dee-3841de7f4416"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="053f8ba0-9586-412d-9b8b-7cc7a6fad660"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="96c0a0af-46bd-4054-8fa9-05598137ae41"></a>
The <code>KimonoHandle</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr></table></p>


---

<a name="c945e1b9-aa73-4792-b941-4296ad13d953"></a>
##IKimonoCodeGeneration

###Namespace

[KimonoCore](#29d4123d-03e1-4b22-bd09-3e39148c25cd)

###Added In API Version

01.00.00

###Summary

Interface for any Kimono Object that support source code generation.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#65aba06d-4b02-4f53-a762-325d5bf9556f'>Name</a></td><td style='width:75%' ><p><a name="65aba06d-4b02-4f53-a762-325d5bf9556f"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the name.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#02c3d0ff-4222-42df-a8eb-95de00c4d017'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="02c3d0ff-4222-42df-a8eb-95de00c4d017"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb581925-e697-4fcb-8c2d-2eb138157c38'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="cb581925-e697-4fcb-8c2d-2eb138157c38"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60f8fd20-3916-4ddb-be5f-d0fdd87caae1'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="60f8fd20-3916-4ddb-be5f-d0fdd87caae1"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d772c06-280d-406d-bff3-e05670ed4bcb'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="5d772c06-280d-406d-bff3-e05670ed4bcb"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f03aaec3-fb0c-46c2-8af2-5ecab6866a54"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#453cc610-d743-4f94-a9e6-8c745724426b'>ToCode</a></td><td style='width:75%' ><p><a name="453cc610-d743-4f94-a9e6-8c745724426b"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="682e307a-cee9-4cb4-9fed-55915c82390c"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="1fb363a4-fa91-49ed-9acc-7a05ff1188b6"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e7e77ece-b8d9-49ea-88d0-152c2a58eb74"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr></table></p>

