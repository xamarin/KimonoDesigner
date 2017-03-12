#KimonoCore.Android API Documentation

####Version 01.00.00

##Table of Contents

* [Summary](#Summary)
* [Remarks](#Remarks)
* [Namespaces](#Namespaces)
* [Types](#Types)

<a name="Summary"></a>
##Summary

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can be converted to code and included in any cross-platform language and OS that SkiaSharp supports. KimonoCore.Android is the Xamarin.Android specific version of the Kimono cross-platform library that provides a helper interface to SkiaSharp.

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

<a name="c0812ff8-3c21-47b3-99b3-32aa3730fddb"></a>
##KimonoCore

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b414d032-2c6d-4a09-85cd-e59ee256073a'>KimonoSketch</a></td><td style='width:75%' ><p>Holds a collection of <code>KimonoShapes</code> that are used to create a given image using Skia.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44eef3b2-fce2-49ff-a6f1-47d172959bda'>KimonoTool</a></td><td style='width:75%' class='def'><p>Defines the current tool that is active in a <code>KimonoSketch</code> that the user can use to create or modify a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ce07704-1584-46d9-959d-2ce23e0861b3'>Kimono</a></td><td style='width:75%' ><p>Holds a set of shared utilities that are used across the Kimono classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca172a42-6f6f-4fe2-80e7-e979ad951ed4'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>A Kimono Portfolio holds a collection of <code>KimonoSketches</code>, <code>KimonoStyles</code> and <code>KimonoColors</code> that define a given Kimono Designer project.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0676851-e8fb-4704-8343-143e7b3a78fe'>KimonoUndoHandler</a></td><td style='width:75%' ><p>Handles the undo/redo state for a <code>KimonoDesignSurface</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#decb9848-2915-4f9d-87f2-3494d80a51e4'>KimonoShape</a></td><td style='width:75%' class='def'><p>Defines the based shape that all other Kimono Shape types will inherit from.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7'>KimonoShapeArrow</a></td><td style='width:75%' ><p>Draws either an outlined or single line arrow with heads on one or both ends.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be0d0bb6-42db-48b9-a105-33f4775ee49d'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p>A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff'>KimonoShapeGroup</a></td><td style='width:75%' ><p>A <code>KimonoShapeGroup</code> holds a collection of <code>KimonoShapes</code> that can be acted upon as a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d0e08b1-d1ef-4316-a980-1be7d44fc592'>KimonoShapeGroupType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0d46ca4-d194-4189-9a83-b3d627fb35a7'>KimonoShapeLine</a></td><td style='width:75%' ><p>Draws a line on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab1de522-c4bb-4664-8b3d-d191b743fb8a'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>Draws an oval into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f391a74-3808-4dbe-a20c-9d80e7506e3c'>KimonoShapePolygon</a></td><td style='width:75%' ><p>Draws a multi-sided polygon into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06f5b5d3-c112-493c-9bd6-9fd49b8fe23b'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>Draws a rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae7b85e3-1748-4fac-9f6f-9f9c01613eba'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>Draws a rounded rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#399f89e2-92e7-4ee5-bcb7-b7ead3240980'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>Draws a multi-sided star shape into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16f42f46-baf6-492a-9577-9a20420a0099'>KimonoShapeState</a></td><td style='width:75%' ><p>Holds the current state of a <code>KimonoShape</code> while it is being edited by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>Draws a block of text into the Design Surface within the specifid bounds of this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84d13fb7-559b-49d1-8b42-9ca6b629e69e'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>Draws a triangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d31a8b4-fa78-4128-baf0-032eff4dd0ec'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c492ff9-c1b6-41cf-b671-c93366c4e4ed'>KimonoProperty</a></td><td style='width:75%' ><p>Defines a property that can be attached to another Kimono object (such as a <code>KimonoColor</code>, <code>KimonoStyle</code> or <code>KimonoShape</code>) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#387e1df1-63dd-44b9-9b96-1b390179a471'>KimonoPropertyUsage</a></td><td style='width:75%' class='def'><p>Defines how a <code>KimonoProperty</code> is used when it is attached to a <code>KimonoShape</code>, <code>KimonoSketch</code> or <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#125f835e-6791-49dd-a86f-073560145ff9'>KimonoPropertyConnectionPoint</a></td><td style='width:75%' ><p>Defines the point that a <code>KimonoProperty</code> value can be connected to another Kimono object such as the <code>Top</code> coordinate of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#923a528f-c1f9-4df5-9d59-bcc90d51ba8c'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p>Defines a connection between a given Kimono Object and a <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#295465f0-8c61-49d9-b49f-9cc107dde55e'>ObiScriptResult</a></td><td style='width:75%' ><p>Defines the result of attempting to execute an Obi Script on a <code>KimonoProperty</code></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22ac5b44-3d41-43ae-9a97-b0f5c6147b00'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p>Holds the control and end point for a <code>KimonoShapeBezier</code> that define a quad section of the Bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#780c6cbd-fa5d-4b07-8956-be4697770c4b'>KimonoBounds</a></td><td style='width:75%' ><p>Defines the outter bounding box for a <code>KimonoShape</code> and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc41b61-b808-44e8-b693-79bd6bcc2f43'>KimonoHandle</a></td><td style='width:75%' class='def'><p>Defines an edit handle that the user manipulates to edit the bounds of a <code>KimonoShape</code> or the control points of a Bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a8e8357-be2d-4256-9931-69e28aeccbcf'>KimonoHandleConstraint</a></td><td style='width:75%' ><p>Constrains the movement of a <code>KimonoHandle</code> when it is being moved by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89ffb335-d560-45f7-a299-d7928b0dfd19'>KimonoHandleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoHandle</code> that can be used as a general purpose control point to adjust the bounds of a <code>KimonoShape</code> or as a point for a vector or bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ca0ae8d-c6c7-4152-93ff-91a64bea934f'>KimonoBlur</a></td><td style='width:75%' ><p>Defines a blur effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e95d9c4c-885c-423e-bce8-8c9818c2f0cd'>KimonoShadow</a></td><td style='width:75%' class='def'><p>Defines a shadow effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97d9de78-15ec-413e-bcb5-87e86f5120ba'>KimonoGradient</a></td><td style='width:75%' ><p>Defines a gradient as a collection of either <code>SKColor</code> or linked <code>KimonoColors</code> that can be applied to a <code>KimonoStyle</code> and used when drawing a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94a41559-8431-4070-899d-32afe0fb3de5'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>Kimono gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae402a36-7d15-4faf-8c84-e03e0a0ca155'>KimonoStyle</a></td><td style='width:75%' ><p>Defines as style that can be applied to a <code>KimonoShape</code> to control its appearance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#233c3d70-5be9-4b01-90a7-dbc5aad3f895'>KimonoStyleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoStyle</code> that will be used to draw a given <code>KimonoShape</code> in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5cddb40-355a-4469-9bdf-5f1cc55886c4'>KimonoPropertyRect</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>SKRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cf97a0b-f96d-4cca-a489-3ecca6552c9b'>KimonoPropertyNumber</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>float</code> or <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53be2972-f412-4e34-a25f-cdce98ca8db0'>KimonoPropertyStyle</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af7b536c-05a2-4cba-8bbd-75c0a140c6a0'>KimonoPropertyBoolean</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb6a73e3-8004-43f4-a2ac-a71e28fa9aeb'>KimonoPropertyText</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36dadc47-be4a-4179-902a-8eeb56d01b5f'>KimonoPropertyColor</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a8b6721-563a-4c67-b5fd-67d7cf6fafc2'>KimonoPropertyGradient</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07cf4a07-d845-46da-a292-dd90dbba6a9c'>CodeOutputOS</a></td><td style='width:75%' class='def'><p>Defines the OS that code will be generated for</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cab6013-5da2-4639-a386-d50491d0ed76'>CodeOutputLanguage</a></td><td style='width:75%' ><p>Defines the language that code will be output in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e83a1dd-144a-469f-8e10-63c70019eadf'>CodeOutputLibrary</a></td><td style='width:75%' class='def'><p>Code output library.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05494e65-778f-436a-830c-9270dd80b2ed'>KimonoCodeGenerator</a></td><td style='width:75%' ><p>The Kimono Code Generator has routine to assist in the generation of output source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#876eb41a-1a0a-4c85-8008-463a9f4e7e10'>IKimonoCodeGeneration</a></td><td style='width:75%' class='def'><p>Interface for any Kimono Object that support source code generation.</p>
</td></tr></table></p>


---

<a name="cac68d26-27dc-40aa-b2da-b3f6cb389a5c"></a>
##KimonoCore.Kimono

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0161a716-3bf8-45cc-8b46-bf61d1c61141'>PortfolioEventDelegate</a></td><td style='width:75%' ><p>Portfolio event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0cf1dbb-1791-46a2-93c6-e7f95ff829cd'>SketchEventDelegate</a></td><td style='width:75%' class='def'><p>Sketch event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d537d99-27cf-4ca7-bdf4-7055f2f3c2ae'>StyleEventDelegate</a></td><td style='width:75%' ><p>Style event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcabe1d6-b6f0-43df-a550-338a79b922de'>ShapeEventDelegate</a></td><td style='width:75%' class='def'><p>Shape event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aaf943b-9c3f-4dfb-999d-81d7486e021f'>ToolEventDelegate</a></td><td style='width:75%' ><p>Tool event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#437832f0-0445-4089-b70a-c75bcdf24363'>SkiaPointEventDelegate</a></td><td style='width:75%' class='def'><p>Skia point event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c481b543-5945-4c08-bf36-aa11e883ca9f'>GroupEventDelegate</a></td><td style='width:75%' ><p>Group event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26d5172b-f998-4c84-8d8c-8d2231fdfb96'>ColorEventDelegate</a></td><td style='width:75%' class='def'><p>Color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97078176-b7e5-4f66-bcc6-4881c8a2ad65'>SkiaColorEventDelegate</a></td><td style='width:75%' ><p>Skia color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#456d2e84-d5fb-4880-a8ce-ff2eb1a97045'>GradientEventDelegate</a></td><td style='width:75%' class='def'><p>Gradient event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69dd179e-7085-443f-a356-51f452e772cf'>HandleEventDelegate</a></td><td style='width:75%' ><p>Handle event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#798637c9-b74a-4cd9-80b7-c5df27ffba98'>PropertyEventDelegate</a></td><td style='width:75%' class='def'><p>Property event delegate.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="b414d032-2c6d-4a09-85cd-e59ee256073a"></a>
##KimonoSketch

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Holds a collection of `KimonoShapes` that are used to create a given image using Skia.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d7bd55c8-6d69-4f04-80ab-e956b400bc4d'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="d7bd55c8-6d69-4f04-80ab-e956b400bc4d"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#559544a7-4988-432e-9f37-7def23ad1d99'>PreviousSize</a></td><td style='width:75%' class='def'><p><a name="559544a7-4988-432e-9f37-7def23ad1d99"></a>
<b>PreviousSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the previous of a sketch for a rezise operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bce0dbf-7669-444b-a7f3-aee2e2558047'>Size</a></td><td style='width:75%' ><p><a name="8bce0dbf-7669-444b-a7f3-aee2e2558047"></a>
<b>Size</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The current size of the sketch</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73650883-13d3-4700-a796-5f50a1ab8420'>_tool</a></td><td style='width:75%' class='def'><p><a name="73650883-13d3-4700-a796-5f50a1ab8420"></a>
<b>_tool</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently <code>KimonoTool</code> that will be used to edit the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#286b56c2-cddf-4f9a-b24b-6dca342a8e6a'>_canvasColor</a></td><td style='width:75%' ><p><a name="286b56c2-cddf-4f9a-b24b-6dca342a8e6a"></a>
<b>_canvasColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2b234a0-3b0d-42a9-bca9-62feaba32def'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="d2b234a0-3b0d-42a9-bca9-62feaba32def"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b05bb45-961f-49b8-882d-9edc6e0e40fe'>IgnoreDrag</a></td><td style='width:75%' ><p><a name="7b05bb45-961f-49b8-882d-9edc6e0e40fe"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#922110db-a13f-4f17-8c60-9d20339ba16f'>PerformingDrag</a></td><td style='width:75%' class='def'><p><a name="922110db-a13f-4f17-8c60-9d20339ba16f"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a1182b8-6110-4b08-a325-07d98e91ad2b'>ToolDownAt</a></td><td style='width:75%' ><p><a name="5a1182b8-6110-4b08-a325-07d98e91ad2b"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b4fad55a-1f7f-4ef8-9917-2dddb86b3d5a'>UniqueID</a></td><td style='width:75%' ><p><a name="b4fad55a-1f7f-4ef8-9917-2dddb86b3d5a"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6c362cf-c5a6-46ad-b4ce-59ea18e8658e'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="f6c362cf-c5a6-46ad-b4ce-59ea18e8658e"></a></p>

<h3>Portfolio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the portfolio that this sketch belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#101dd093-e72e-4753-8a5b-464428d2ded7'>ElementName</a></td><td style='width:75%' ><p><a name="101dd093-e72e-4753-8a5b-464428d2ded7"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d997c0c-d66b-46f8-a29c-6098740f149b'>Name</a></td><td style='width:75%' class='def'><p><a name="4d997c0c-d66b-46f8-a29c-6098740f149b"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#637c0b73-49a1-4421-b522-93f1ab8fab99'>GenerateCodeToOuputToCanvas</a></td><td style='width:75%' ><p><a name="637c0b73-49a1-4421-b522-93f1ab8fab99"></a></p>

<h3>GenerateCodeToOuputToCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, ouput a method that draws into the given SkiaSharp Canvas.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22752b68-9fc1-4294-84c8-09e323e8931e'>GenerateCodeToOuputSkiaData</a></td><td style='width:75%' class='def'><p><a name="22752b68-9fc1-4294-84c8-09e323e8931e"></a></p>

<h3>GenerateCodeToOuputSkiaData</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the SkiaSharp Data (<code>SKData[]</code>) representing the Sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput skia data; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbbffc82-0e67-40af-a8cf-9ba0310e4952'>GenerateCodeToOuputBitmapImage</a></td><td style='width:75%' ><p><a name="cbbffc82-0e67-40af-a8cf-9ba0310e4952"></a></p>

<h3>GenerateCodeToOuputBitmapImage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as a OS specific bitmap image.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput bitmap image; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40ddc61d-6e19-4202-92bf-dcfe30aa3830'>GenerateCodeToOuputToSkiaSharpViews</a></td><td style='width:75%' class='def'><p><a name="40ddc61d-6e19-4202-92bf-dcfe30aa3830"></a></p>

<h3>GenerateCodeToOuputToSkiaSharpViews</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as class based on the <code>SkiaSharp.Views</code> extension library.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to skia sharp views; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dc785c2-94da-4cdb-9ae6-164f8f8ed4c9'>Width</a></td><td style='width:75%' ><p><a name="3dc785c2-94da-4cdb-9ae6-164f8f8ed4c9"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aaa3ee9a-eb22-4828-a4c6-9868b5c3988a'>Height</a></td><td style='width:75%' class='def'><p><a name="aaa3ee9a-eb22-4828-a4c6-9868b5c3988a"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94538501-29b1-489e-bf85-832de091f933'>CanvasColor</a></td><td style='width:75%' ><p><a name="94538501-29b1-489e-bf85-832de091f933"></a></p>

<h3>CanvasColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the canvas.</p>

<h4>Return Value</h4>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8be345b8-5095-4728-9ec0-53e2c2d1ea63'>DrawCanvas</a></td><td style='width:75%' class='def'><p><a name="8be345b8-5095-4728-9ec0-53e2c2d1ea63"></a></p>

<h3>DrawCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#b414d032-2c6d-4a09-85cd-e59ee256073a">KimonoSketch</a> should draw  the canvas when it is included in another sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if draw canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2d5c64e-b179-4ee0-8490-f83e54ca55d6'>Shapes</a></td><td style='width:75%' ><p><a name="f2d5c64e-b179-4ee0-8490-f83e54ca55d6"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9df95730-b160-4a07-9d97-5899dc045f49'>Tool</a></td><td style='width:75%' class='def'><p><a name="9df95730-b160-4a07-9d97-5899dc045f49"></a></p>

<h3>Tool</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tool.</p>

<h4>Return Value</h4>

<p>The tool.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3119cdd1-cb20-4739-a701-6a5da627623d'>SelectedShape</a></td><td style='width:75%' ><p><a name="3119cdd1-cb20-4739-a701-6a5da627623d"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd287b5c-c29d-401b-a30d-296b0d092a9e'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="cd287b5c-c29d-401b-a30d-296b0d092a9e"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c5df399-e00b-40c2-ba5b-cd1bb265cee3'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="5c5df399-e00b-40c2-ba5b-cd1bb265cee3"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b9bc6d8-aa82-4a6d-9c48-6a46457ba78d'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="2b9bc6d8-aa82-4a6d-9c48-6a46457ba78d"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd2b4d22-be20-4853-ab83-57212c6e18c0'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="bd2b4d22-be20-4853-ab83-57212c6e18c0"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4ffca85-1742-4f7f-a214-6bdc3b207272'>CanAlignShapes</a></td><td style='width:75%' class='def'><p><a name="e4ffca85-1742-4f7f-a214-6bdc3b207272"></a></p>

<h3>CanAlignShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether alignment can be applied on a set of shapes.</p>

<h4>Return Value</h4>

<p><code>true</code> if can align shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02f7fb5c-8240-4c93-9685-5550265840a2'>CanGroupShapes</a></td><td style='width:75%' ><p><a name="02f7fb5c-8240-4c93-9685-5550265840a2"></a></p>

<h3>CanGroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be grouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#471796cd-2c50-4b4e-9adf-fe7406e91cae'>CanUngroupShapes</a></td><td style='width:75%' class='def'><p><a name="471796cd-2c50-4b4e-9adf-fe7406e91cae"></a></p>

<h3>CanUngroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be ungrouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#58829bda-e466-4c89-8065-0db2b6d7006e'>ToImage</a></td><td style='width:75%' ><p><a name="58829bda-e466-4c89-8065-0db2b6d7006e"></a></p>

<h3>ToImage ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the sketch to a bitmap image.</p>

<h4>Returns</h4>

<p>The <code>UIImage</code> representation of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44f97ae0-97dd-4722-bcf7-06950e1d7f61'>KimonoSketch</a></td><td style='width:75%' class='def'><p><a name="44f97ae0-97dd-4722-bcf7-06950e1d7f61"></a></p>

<h3>KimonoSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b414d032-2c6d-4a09-85cd-e59ee256073a">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9f52fd7-e5ad-4ae0-b44f-5c2202ab0bef'>KimonoSketch</a></td><td style='width:75%' ><p><a name="b9f52fd7-e5ad-4ae0-b44f-5c2202ab0bef"></a></p>

<h3>KimonoSketch (System.String, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b414d032-2c6d-4a09-85cd-e59ee256073a">KimonoSketch</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="a6da79c6-8763-45b2-95bb-4a40b36c7f9f"></a>
Name.</p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p><a name="40ee1c00-3053-4b6f-8761-bbd1b5ecbf87"></a>
Width.</p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p><a name="acb81b7b-2bcf-48c5-a3f7-3741c1b9439c"></a>
Height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15a43bb1-27a6-46ce-af91-541a735bd088'>Initialize</a></td><td style='width:75%' class='def'><p><a name="15a43bb1-27a6-46ce-af91-541a735bd088"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96d577df-69e5-4f47-9a3b-ac5740c17782'>SavePreviousSize</a></td><td style='width:75%' ><p><a name="96d577df-69e5-4f47-9a3b-ac5740c17782"></a></p>

<h3>SavePreviousSize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous size of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2875753b-0fe6-41d9-aa76-33b0726cb313'>ApplySizeChange</a></td><td style='width:75%' class='def'><p><a name="2875753b-0fe6-41d9-aa76-33b0726cb313"></a></p>

<h3>ApplySizeChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the size change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#121f5a9f-bbff-49ea-b2fb-3bcec09113a4'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="121f5a9f-bbff-49ea-b2fb-3bcec09113a4"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="eef5a17f-85ef-4eb2-aae6-61c6b28f3ba5"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a622c72-5982-45a6-9fae-3f56c16203c9'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="4a622c72-5982-45a6-9fae-3f56c16203c9"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="a303ae11-dcd4-4061-b4b9-43020141c308"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84ac25c3-c38d-48a0-99e9-1dc439e9cb3c'>FindShape</a></td><td style='width:75%' ><p><a name="84ac25c3-c38d-48a0-99e9-1dc439e9cb3c"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the shape specified by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="1c1e9569-4671-483d-80f7-eb4cd70241fb"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>If found, the <code>KimonoShape</code> will be returned, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16d658f3-e1d3-4257-9777-20b82307c233'>Draw</a></td><td style='width:75%' class='def'><p><a name="16d658f3-e1d3-4257-9777-20b82307c233"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw this sketch into the give SkiaSharp canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="fc5a6619-4052-4f02-91e1-0587665755de"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76639958-51ab-433a-a5bb-ac29f9451f5a'>MoveSelectedShapeToBottom</a></td><td style='width:75%' ><p><a name="76639958-51ab-433a-a5bb-ac29f9451f5a"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#592ee38f-f51c-4e88-9914-dc5e5bbd9ce2'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p><a name="592ee38f-f51c-4e88-9914-dc5e5bbd9ce2"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29b74ff1-ef9c-403a-9d4b-a176abcbee7c'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p><a name="29b74ff1-ef9c-403a-9d4b-a176abcbee7c"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e0e28a0-4444-4174-97b7-e9f5f0eb3f41'>MoveSelectedShapeForwards</a></td><td style='width:75%' class='def'><p><a name="5e0e28a0-4444-4174-97b7-e9f5f0eb3f41"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#199e337c-1f0e-4767-b25d-9f87b52d2dfd'>AddShape</a></td><td style='width:75%' ><p><a name="199e337c-1f0e-4767-b25d-9f87b52d2dfd"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="17e94860-791e-4362-a963-74a9e4e67490"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba0879a4-f50e-459c-876c-c1515e2da180'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p><a name="ba0879a4-f50e-459c-876c-c1515e2da180"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#419a8eeb-fbd8-4ece-97bd-fe16ec9cd26b'>DuplicateSelectedShape</a></td><td style='width:75%' ><p><a name="419a8eeb-fbd8-4ece-97bd-fe16ec9cd26b"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9f2c2b2-1d2c-41f9-8366-aa31021fcd1f'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="f9f2c2b2-1d2c-41f9-8366-aa31021fcd1f"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2bd1fe5-ca52-49ac-9048-3a5ff3df1bf6'>SelectShape</a></td><td style='width:75%' ><p><a name="b2bd1fe5-ca52-49ac-9048-3a5ff3df1bf6"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="3b4db1d9-ffbe-47f4-9963-b0062a8555df"></a>
The <code>KimonoShape</code> to select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e20ca13-166e-4d83-9da4-d55607791580'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="3e20ca13-166e-4d83-9da4-d55607791580"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#209e2af1-fc4c-4c1f-bb4d-e2d6f5fb134a'>GroupUngroupSelectedShapes</a></td><td style='width:75%' ><p><a name="209e2af1-fc4c-4c1f-bb4d-e2d6f5fb134a"></a></p>

<h3>GroupUngroupSelectedShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b54be521-d21c-43e4-9028-bf11ca0440fe'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="b54be521-d21c-43e4-9028-bf11ca0440fe"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#253d0677-322c-4b2b-a923-9364ccb39b3c'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="253d0677-322c-4b2b-a923-9364ccb39b3c"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbed7d99-4b0a-4ea5-814e-b2b9528a4b0c'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="dbed7d99-4b0a-4ea5-814e-b2b9528a4b0c"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e4681e2-c119-4861-b91e-123875db60e4'>BuildCsharpToCanvasMethod</a></td><td style='width:75%' ><p><a name="0e4681e2-c119-4861-b91e-123875db60e4"></a></p>

<h3>BuildCsharpToCanvasMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Build the method to draw into a specific SkiaSharp Canvas in C# source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="daec9996-4fff-4a81-bb89-c80679917ecd"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the method.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#647811d1-5041-4d14-8d06-e44e3ddfc692'>BuildCsharpToSkiaDataMethod</a></td><td style='width:75%' class='def'><p><a name="647811d1-5041-4d14-8d06-e44e3ddfc692"></a></p>

<h3>BuildCsharpToSkiaDataMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to SkiaSharp data (<code>SKData</code>).</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5112e2ea-cb1b-4f42-a38e-215fd293a615"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Sketch as <code>SKData</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f85f476f-41d7-4f83-83d3-8cc55ce5b082'>BuildCsharpToBitmapImage</a></td><td style='width:75%' ><p><a name="f85f476f-41d7-4f83-83d3-8cc55ce5b082"></a></p>

<h3>BuildCsharpToBitmapImage (KimonoCore.CodeOutputOS)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to OS specific bitmap image format.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="92f9f1f1-1b44-4fde-8ece-e147e4c079f8"></a>
Output os.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Sketch as a platform specific image.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8010d8df-f720-4b2c-bb72-bf958e0420a8'>BuildCSharpCrossPlatformToImage</a></td><td style='width:75%' class='def'><p><a name="8010d8df-f720-4b2c-bb72-bf958e0420a8"></a></p>

<h3>BuildCSharpCrossPlatformToImage (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# ToImage method for Cross Platform image support.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f255b128-d9a3-49e3-85e8-72378b8b8d36"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Conditionally compiled code to support all of the different image types.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#161b5684-767e-493b-a854-82bc53fd3526'>ToCSharp</a></td><td style='width:75%' ><p><a name="161b5684-767e-493b-a854-82bc53fd3526"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="3cc38806-0484-408f-8dc6-8fba8a9d018a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b1462d5-959b-4a6d-87b6-f510c4ad5849'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="2b1462d5-959b-4a6d-87b6-f510c4ad5849"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="dabb21ca-bba3-4325-904f-a89160867c20"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="84c73420-b65d-4edf-b671-bdb152d225a4"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9106677-4203-4960-87c0-d3c080487384'>PortfolioSketchMethods</a></td><td style='width:75%' ><p><a name="a9106677-4203-4960-87c0-d3c080487384"></a></p>

<h3>PortfolioSketchMethods (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary, System.String@, System.String@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the methods that a portfolio will use to draw the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="b3214078-8b84-4442-900f-c8acd34c473e"></a>
The <code>CodeOutputOS</code> to generate code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="f9e396e0-ab8a-4274-a6d0-9b77a26eb5e1"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>privateMethodsCode</td><td style='width:75%' ><p><a name="322c84f1-c2cc-4816-8463-d54bc2d9994f"></a>
The private methods required by this sketch.</p>
</td></tr><tr><td style='width:25%' class='term'>publicMethodsCode</td><td style='width:75%' class='def'><p><a name="0d4ce4f5-a807-46d8-9c02-0cec97ececf8"></a>
The public methods required by this sketch.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c5eb7a3-b586-4661-ba31-9e5636fbae5a'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="9c5eb7a3-b586-4661-ba31-9e5636fbae5a"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="24c49723-881e-4310-8dbd-74e880933b55"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7c0e25f-397e-4737-b895-f721896dcc9a'>ToCSharpKimono</a></td><td style='width:75%' ><p><a name="a7c0e25f-397e-4737-b895-f721896dcc9a"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="b4c50ed3-4550-4e53-8c94-6209934d9916"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="a6fb9e11-afd0-4413-9da4-d79c0f51607b"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b7487151-d6c2-490a-a04c-aa34d5175e06"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fe864c9-400e-49f9-a7e5-96f79ded5369'>ToCode</a></td><td style='width:75%' class='def'><p><a name="5fe864c9-400e-49f9-a7e5-96f79ded5369"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="5e567de0-098e-49bd-86fd-8c3098e6c68a"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="9eb31b52-c48d-4224-af68-b999eb712681"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="74b84d58-75d9-4bdc-948b-91a7a14be6eb"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6919da3a-b805-4cf8-a0df-3d74bc681053'>RelinkShape</a></td><td style='width:75%' ><p><a name="6919da3a-b805-4cf8-a0df-3d74bc681053"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="710e1e6a-b20a-4ccd-933d-9186757876f0"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb40dbf5-b9a9-4ecc-9586-dedc717cebf7'>Clone</a></td><td style='width:75%' class='def'><p><a name="eb40dbf5-b9a9-4ecc-9586-dedc717cebf7"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae025881-5634-4552-a594-55854849da5d'>ToolDown</a></td><td style='width:75%' ><p><a name="ae025881-5634-4552-a594-55854849da5d"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="88e1036e-580e-42a0-9d09-37726ec7d99c"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="b50d2a15-daa1-4575-a62a-4143bb7a68ca"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="c158183c-d7ea-4c04-b776-9dfb119efcd8"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf0c5545-507d-437b-b56f-00f5b567f072'>ToolDrag</a></td><td style='width:75%' class='def'><p><a name="cf0c5545-507d-437b-b56f-00f5b567f072"></a></p>

<h3>ToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handle the user dragging the selected <code>KimonoTool</code> on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="566ec5ad-9fab-4052-8b14-67a2f5a3f0e1"></a>
The <code>SKPoint</code> representing the new tool position on the Design Surface.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51cb2c16-18fb-4b91-91a5-d8df06171f7e'>ToolUp</a></td><td style='width:75%' ><p><a name="51cb2c16-18fb-4b91-91a5-d8df06171f7e"></a></p>

<h3>ToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user lifting the current <code>KimonoTool</code> off of the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e1f8c0e1-cd6f-497c-aac1-38b3b1bfa6e7"></a>
The <code>SKPoint</code> where the user lifted up the tool.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f5e070b-8f0a-4d16-9920-6108b5675671'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="7f5e070b-8f0a-4d16-9920-6108b5675671"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f4f918d-f12f-42d2-aa8a-81e4c531550a'>RaiseSketchSizeChanged</a></td><td style='width:75%' ><p><a name="3f4f918d-f12f-42d2-aa8a-81e4c531550a"></a></p>

<h3>RaiseSketchSizeChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09d9ad1b-117a-4d4b-aeef-1355e88d6194'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p><a name="09d9ad1b-117a-4d4b-aeef-1355e88d6194"></a></p>

<h3>RaiseSketchModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b881e6b-6281-48a9-a9d2-415e23303c5f'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' ><p><a name="3b881e6b-6281-48a9-a9d2-415e23303c5f"></a></p>

<h3>RaiseImageBufferNeedsRefresh ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the image buffer needs refresh event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a281a175-8f86-4431-b3d4-a2103f963622'>RaiseSelectedShapeModified</a></td><td style='width:75%' class='def'><p><a name="a281a175-8f86-4431-b3d4-a2103f963622"></a></p>

<h3>RaiseSelectedShapeModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#008b5052-e0b6-4110-97ad-26115029de26'>RaiseSelectionChanged</a></td><td style='width:75%' ><p><a name="008b5052-e0b6-4110-97ad-26115029de26"></a></p>

<h3>RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="f25b1db5-6c80-49ec-8f4b-2cfe45ae008d"></a>
Selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ad1da32-19bf-45ad-afc4-aa6bf3556b58'>RaiseToolChanged</a></td><td style='width:75%' class='def'><p><a name="8ad1da32-19bf-45ad-afc4-aa6bf3556b58"></a></p>

<h3>RaiseToolChanged (KimonoCore.KimonoTool)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the tool changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="0f956c0f-6bb0-4faf-ab6c-c7df49997be7"></a>
The new <code>KimonoTool</code> that has been selected.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b902b6f0-e732-4ab7-a1e0-9c850871dcfb'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="b902b6f0-e732-4ab7-a1e0-9c850871dcfb"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a6694f5-d45d-4fcf-8a22-f00ccae88fb5'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="0a6694f5-d45d-4fcf-8a22-f00ccae88fb5"></a></p>

<h3>SketchSizeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47257318-bf92-41fb-9d63-565d18efb952'>SketchModified</a></td><td style='width:75%' ><p><a name="47257318-bf92-41fb-9d63-565d18efb952"></a></p>

<h3>SketchModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebcd5e9a-3c94-4bd3-832e-f6fca92a3f5c'>ImageBufferNeedsRefresh</a></td><td style='width:75%' class='def'><p><a name="ebcd5e9a-3c94-4bd3-832e-f6fca92a3f5c"></a></p>

<h3>ImageBufferNeedsRefresh</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when image buffer needs refresh.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c1d8509-4e40-4c3e-8dd9-bb3c2902d8de'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="5c1d8509-4e40-4c3e-8dd9-bb3c2902d8de"></a></p>

<h3>SelectedShapeModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14fc6226-4a73-4eb8-a4b0-869f26b52a00'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="14fc6226-4a73-4eb8-a4b0-869f26b52a00"></a></p>

<h3>SelectionChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82c4e0a9-194f-49e5-bcac-7ea20b8b944d'>ToolChanged</a></td><td style='width:75%' ><p><a name="82c4e0a9-194f-49e5-bcac-7ea20b8b944d"></a></p>

<h3>ToolChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when tool changed.</p>
</td></tr></table></p>


---

<a name="44eef3b2-fce2-49ff-a6f1-47d172959bda"></a>
##KimonoTool

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the current tool that is active in a `KimonoSketch` that the user can use to create or modify a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e7bcf89c-9534-4d19-ba93-dccb5dec7355'>Cursor</a></td><td style='width:75%' ><p><a name="e7bcf89c-9534-4d19-ba93-dccb5dec7355"></a>
<b>Cursor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Cursor tool to modify an existing <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67635b15-5a31-4257-b413-0ae9b8619846'>Line</a></td><td style='width:75%' class='def'><p><a name="67635b15-5a31-4257-b413-0ae9b8619846"></a>
<b>Line</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Line tool to add a new <code>KimonoShapeLine</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41ab1391-65ee-453c-b8c7-6fbd120f035e'>Arrow</a></td><td style='width:75%' ><p><a name="41ab1391-65ee-453c-b8c7-6fbd120f035e"></a>
<b>Arrow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Arrow tool to add a new <code>KimonoShapeArrow</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ee8907e-561d-4a86-a37b-49319c1b2ad1'>Rectangle</a></td><td style='width:75%' class='def'><p><a name="1ee8907e-561d-4a86-a37b-49319c1b2ad1"></a>
<b>Rectangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Rectangle tool to add a new <code>KimonoShapeRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e94186d-e33d-4222-8a9e-39d55b8cc009'>Oval</a></td><td style='width:75%' ><p><a name="6e94186d-e33d-4222-8a9e-39d55b8cc009"></a>
<b>Oval</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Oval tool to add a new <code>KimonoShapeOval</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0881bce-eee5-4f08-a77a-b69a1f80cea1'>RoundRect</a></td><td style='width:75%' class='def'><p><a name="c0881bce-eee5-4f08-a77a-b69a1f80cea1"></a>
<b>RoundRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Round Rect tool to add a new <code>KimonoShapeRoundRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6db1a950-4d97-4de2-b668-eaa48574e5a7'>Star</a></td><td style='width:75%' ><p><a name="6db1a950-4d97-4de2-b668-eaa48574e5a7"></a>
<b>Star</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Star tool to add a new <code>KimonoShapeStar</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc16f0e8-8e0d-48f4-be1c-b3c81fc75d2e'>Polygon</a></td><td style='width:75%' class='def'><p><a name="cc16f0e8-8e0d-48f4-be1c-b3c81fc75d2e"></a>
<b>Polygon</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Polygon tool to add a new <code>KimonoShapePolygon</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f396a04f-afe3-4614-a77f-76a87d849a85'>Triangle</a></td><td style='width:75%' ><p><a name="f396a04f-afe3-4614-a77f-76a87d849a85"></a>
<b>Triangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Triangle tool to add a new <code>KimonoShapeTriangle</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1ae0463-150f-4b83-8fe3-a81b15da0032'>Vector</a></td><td style='width:75%' class='def'><p><a name="a1ae0463-150f-4b83-8fe3-a81b15da0032"></a>
<b>Vector</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Vector tool to add a new <code>KimonoShapeVector</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93bbdfbd-dedb-4760-80e3-523171eca8ba'>Bezier</a></td><td style='width:75%' ><p><a name="93bbdfbd-dedb-4760-80e3-523171eca8ba"></a>
<b>Bezier</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Bezier tool to add a new <code>KimonoShapeBezier</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97f144a7-0941-4a33-9c59-83a8cb0b4c5c'>Text</a></td><td style='width:75%' class='def'><p><a name="97f144a7-0941-4a33-9c59-83a8cb0b4c5c"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Text tool to add a new <code>KimonoShapeText</code> to the sketch.</p>
</td></tr></table></p>


---

<a name="6ce07704-1584-46d9-959d-2ce23e0861b3"></a>
##Kimono

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Holds a set of shared utilities that are used across the Kimono classes.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#db0269e4-05e2-4acb-88a5-c077e73581c6'>CharIsNumber</a></td><td style='width:75%' ><p><a name="db0269e4-05e2-4acb-88a5-c077e73581c6"></a></p>

<h3>CharIsNumber (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a number character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="1e6c693d-20b7-47ad-9867-420ae24163b8"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is character is a number, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17056910-1bd0-4be4-ada1-b61896517ac0'>CharIsLetter</a></td><td style='width:75%' class='def'><p><a name="17056910-1bd0-4be4-ada1-b61896517ac0"></a></p>

<h3>CharIsLetter (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a letter character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="a09da726-1557-4807-b6ab-bbbc32dd13c1"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is letter was chared, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a643516c-73fe-4488-b6d1-4045fbfdf3cc'>IncrementName</a></td><td style='width:75%' ><p><a name="a643516c-73fe-4488-b6d1-4045fbfdf3cc"></a></p>

<h3>IncrementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increments the name by appending a number to the end or incrementing an existing number count.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="5bc3a7b8-b93a-40d3-9c27-111e65d48564"></a>
Name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9aee13d6-a872-430b-b332-56f381912a79'>CloneSKPoint</a></td><td style='width:75%' class='def'><p><a name="9aee13d6-a872-430b-b332-56f381912a79"></a></p>

<h3>CloneSKPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPoint</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ebc4069c-4d47-4d39-8be6-e3c1c6ce57e3"></a>
The <code>SKPoint</code> to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A clone of the given point.</p>
</td></tr></table></p>


---

<a name="0161a716-3bf8-45cc-8b46-bf61d1c61141"></a>
##PortfolioEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Portfolio event delegate.

---

<a name="e0cf1dbb-1791-46a2-93c6-e7f95ff829cd"></a>
##SketchEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Sketch event delegate.

---

<a name="1d537d99-27cf-4ca7-bdf4-7055f2f3c2ae"></a>
##StyleEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Style event delegate.

---

<a name="fcabe1d6-b6f0-43df-a550-338a79b922de"></a>
##ShapeEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Shape event delegate.

---

<a name="3aaf943b-9c3f-4dfb-999d-81d7486e021f"></a>
##ToolEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Tool event delegate.

---

<a name="437832f0-0445-4089-b70a-c75bcdf24363"></a>
##SkiaPointEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Skia point event delegate.

---

<a name="c481b543-5945-4c08-bf36-aa11e883ca9f"></a>
##GroupEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Group event delegate.

---

<a name="26d5172b-f998-4c84-8d8c-8d2231fdfb96"></a>
##ColorEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Color event delegate.

---

<a name="97078176-b7e5-4f66-bcc6-4881c8a2ad65"></a>
##SkiaColorEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Skia color event delegate.

---

<a name="456d2e84-d5fb-4880-a8ce-ff2eb1a97045"></a>
##GradientEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Gradient event delegate.

---

<a name="69dd179e-7085-443f-a356-51f452e772cf"></a>
##HandleEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Handle event delegate.

---

<a name="798637c9-b74a-4cd9-80b7-c5df27ffba98"></a>
##PropertyEventDelegate

###Namespace

[KimonoCore.Kimono](#cac68d26-27dc-40aa-b2da-b3f6cb389a5c)

###Added In API Version

01.00.00

###Summary

Property event delegate.

---

<a name="ca172a42-6f6f-4fe2-80e7-e979ad951ed4"></a>
##KimonoPortfolio

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

A Kimono Portfolio holds a collection of `KimonoSketches`, `KimonoStyles` and `KimonoColors` that define a given Kimono Designer project.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d3d9cf2c-aa44-493f-9f95-1bd477842bb8'>_selectedSketch</a></td><td style='width:75%' ><p><a name="d3d9cf2c-aa44-493f-9f95-1bd477842bb8"></a>
<b>_selectedSketch</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65bb11cf-98bc-44bc-a03c-6c6fc6fecb5b'>NewSketchNumber</a></td><td style='width:75%' class='def'><p><a name="65bb11cf-98bc-44bc-a03c-6c6fc6fecb5b"></a>
<b>NewSketchNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the number that will be assigned to the next new <code>KimonoSketch</code> created in this portfolio.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f46323d5-f5e0-4ed3-aec9-2647b0cc76a3'>UniqueID</a></td><td style='width:75%' ><p><a name="f46323d5-f5e0-4ed3-aec9-2647b0cc76a3"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b7c1cfb-23d6-4464-be81-2212a63f803a'>ElementName</a></td><td style='width:75%' class='def'><p><a name="6b7c1cfb-23d6-4464-be81-2212a63f803a"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e316b29-1c0a-4eba-9820-4853a474c728'>Name</a></td><td style='width:75%' ><p><a name="0e316b29-1c0a-4eba-9820-4853a474c728"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef459eaa-e9db-41f3-b8a1-b6f63cecf5d7'>Namespace</a></td><td style='width:75%' class='def'><p><a name="ef459eaa-e9db-41f3-b8a1-b6f63cecf5d7"></a></p>

<h3>Namespace</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the namespace.</p>

<h4>Return Value</h4>

<p>The namespace.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a484d2c9-e9c3-40c2-aa53-1ff2b6c74a3c'>Author</a></td><td style='width:75%' ><p><a name="a484d2c9-e9c3-40c2-aa53-1ff2b6c74a3c"></a></p>

<h3>Author</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the author.</p>

<h4>Return Value</h4>

<p>The author.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ecc58b4-dea4-4312-8165-58641f2e8152'>Copyright</a></td><td style='width:75%' class='def'><p><a name="8ecc58b4-dea4-4312-8165-58641f2e8152"></a></p>

<h3>Copyright</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the copyright.</p>

<h4>Return Value</h4>

<p>The copyright.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7bb14c2d-deaa-4f99-8a39-7f035cb95288'>Sketches</a></td><td style='width:75%' ><p><a name="7bb14c2d-deaa-4f99-8a39-7f035cb95288"></a></p>

<h3>Sketches</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the sketches.</p>

<h4>Return Value</h4>

<p>The sketches.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84bbb4e8-e0f1-43c0-a93a-e2bb52799cd6'>Styles</a></td><td style='width:75%' class='def'><p><a name="84bbb4e8-e0f1-43c0-a93a-e2bb52799cd6"></a></p>

<h3>Styles</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the styles.</p>

<h4>Return Value</h4>

<p>The styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35a2940b-4b66-41e7-84a1-8a9fd48d2b53'>Colors</a></td><td style='width:75%' ><p><a name="35a2940b-4b66-41e7-84a1-8a9fd48d2b53"></a></p>

<h3>Colors</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the colors.</p>

<h4>Return Value</h4>

<p>The colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fc4528b-b220-4dcd-b837-c3575b187666'>Gradients</a></td><td style='width:75%' class='def'><p><a name="5fc4528b-b220-4dcd-b837-c3575b187666"></a></p>

<h3>Gradients</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the gradients.</p>

<h4>Return Value</h4>

<p>The gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf24e70f-c8b2-4f42-a1ec-d171d0d6b3b2'>Properties</a></td><td style='width:75%' ><p><a name="bf24e70f-c8b2-4f42-a1ec-d171d0d6b3b2"></a></p>

<h3>Properties</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the properties.</p>

<h4>Return Value</h4>

<p>The properties.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04d8a278-22c8-40dd-a8fc-0aa50e029c01'>SelectedSketch</a></td><td style='width:75%' class='def'><p><a name="04d8a278-22c8-40dd-a8fc-0aa50e029c01"></a></p>

<h3>SelectedSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected sketch.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#747da0fb-e6f7-4e77-8053-917aff168f08'>KimonoPortfolio</a></td><td style='width:75%' ><p><a name="747da0fb-e6f7-4e77-8053-917aff168f08"></a></p>

<h3>KimonoPortfolio (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ca172a42-6f6f-4fe2-80e7-e979ad951ed4">KimonoPortfolio</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p><a name="939992c6-3b5c-416f-a064-c8d0b8997127"></a>
If <code>true</code>, the new instance will be initialized with the default values.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><code>initialize</code> is set to <code>false</code> when a clone is being made of given <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2a51166-203f-493a-9225-300cfc7098a4'>Initialize</a></td><td style='width:75%' class='def'><p><a name="c2a51166-203f-493a-9225-300cfc7098a4"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3c3ed02-625a-421f-8226-418fee5b2ae2'>FindSketch</a></td><td style='width:75%' ><p><a name="a3c3ed02-625a-421f-8226-418fee5b2ae2"></a></p>

<h3>FindSketch (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoSketch</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="7ef06718-6441-43fe-814a-61d8474adf99"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoSketch</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1491e752-50ac-4b6d-aaba-b77ef794b3fd'>FindColor</a></td><td style='width:75%' class='def'><p><a name="1491e752-50ac-4b6d-aaba-b77ef794b3fd"></a></p>

<h3>FindColor (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoColor</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="9d45c2a7-033f-4a4d-ab3f-5dc82d4b7d1e"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoColor</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70b3a3ca-63df-4866-96ff-be86956bc926'>FindProperty</a></td><td style='width:75%' ><p><a name="70b3a3ca-63df-4866-96ff-be86956bc926"></a></p>

<h3>FindProperty (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoProperty</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="6cb6de67-1552-43e4-bd44-d74d192c31cc"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoProperty</code> if founs, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d65dcb3b-e889-41e1-9f77-924c24a63a43'>FindGradient</a></td><td style='width:75%' class='def'><p><a name="d65dcb3b-e889-41e1-9f77-924c24a63a43"></a></p>

<h3>FindGradient (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the gradient by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="2e842421-70fc-4c89-8e20-d55fcd151076"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoGradient</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d477f9eb-22eb-4d09-9fea-ec561cfbb868'>FindStyle</a></td><td style='width:75%' ><p><a name="d477f9eb-22eb-4d09-9fea-ec561cfbb868"></a></p>

<h3>FindStyle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoStyle</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="ddcc0a78-76b2-49b7-8978-fb188344719b"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#682b2e84-8725-4c29-978b-934d8a90e3a6'>AddNewSketch</a></td><td style='width:75%' class='def'><p><a name="682b2e84-8725-4c29-978b-934d8a90e3a6"></a></p>

<h3>AddNewSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoSketch</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7356ea90-afac-4c6a-a079-1df6630630c3'>DuplicateSelectedSketch</a></td><td style='width:75%' ><p><a name="7356ea90-afac-4c6a-a079-1df6630630c3"></a></p>

<h3>DuplicateSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe8cc742-ffc1-4f31-a03e-2d9d5de48ce0'>DeleteSelectedSketch</a></td><td style='width:75%' class='def'><p><a name="fe8cc742-ffc1-4f31-a03e-2d9d5de48ce0"></a></p>

<h3>DeleteSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45e6fc8c-8540-46f0-8cad-fef536630bcf'>AddNewGradient</a></td><td style='width:75%' ><p><a name="45e6fc8c-8540-46f0-8cad-fef536630bcf"></a></p>

<h3>AddNewGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the new gradient.</p>

<h4>Returns</h4>

<p>The new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20803d28-2b8e-4538-be7c-f6671640e654'>AddNewColor</a></td><td style='width:75%' class='def'><p><a name="20803d28-2b8e-4538-be7c-f6671640e654"></a></p>

<h3>AddNewColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio.</p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2811a1d4-c1f7-462d-b856-8b42d0b44985'>AddNewColor</a></td><td style='width:75%' ><p><a name="2811a1d4-c1f7-462d-b856-8b42d0b44985"></a></p>

<h3>AddNewColor (SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio based off of a given <code>SKColor</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="f0973b4c-b8dd-4073-810c-d2db6af38ce0"></a>
Base color.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1994f03b-e649-48a4-92d8-1a23b54c6297'>AddPropertyBoolean</a></td><td style='width:75%' class='def'><p><a name="1994f03b-e649-48a4-92d8-1a23b54c6297"></a></p>

<h3>AddPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new boolean property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyBoolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25abed1b-1bf3-4c15-ac7f-cef65384e49a'>AddPropertyColor</a></td><td style='width:75%' ><p><a name="25abed1b-1bf3-4c15-ac7f-cef65384e49a"></a></p>

<h3>AddPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new color property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52d481fe-150d-4fb2-b835-98bdb6f53503'>AddPropertyGradient</a></td><td style='width:75%' class='def'><p><a name="52d481fe-150d-4fb2-b835-98bdb6f53503"></a></p>

<h3>AddPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new gradient property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ddc7c74-aed4-4688-814d-f7eca867a687'>AddPropertyNumber</a></td><td style='width:75%' ><p><a name="7ddc7c74-aed4-4688-814d-f7eca867a687"></a></p>

<h3>AddPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new number property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyNumber</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d01d70c1-e258-4f6f-b567-19a8d547d0df'>AddPropertyRect</a></td><td style='width:75%' class='def'><p><a name="d01d70c1-e258-4f6f-b567-19a8d547d0df"></a></p>

<h3>AddPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new rect property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#625cf7e7-edcf-42bb-8950-adbe3f47fa38'>AddPropertyStyle</a></td><td style='width:75%' ><p><a name="625cf7e7-edcf-42bb-8950-adbe3f47fa38"></a></p>

<h3>AddPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new style property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cbc23c1-784c-47c0-bc6a-970532221dd6'>AddPropertyText</a></td><td style='width:75%' class='def'><p><a name="0cbc23c1-784c-47c0-bc6a-970532221dd6"></a></p>

<h3>AddPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new text property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f38e65e1-ddfd-4e6b-945d-c714aa5edeb4'>AddNewProperty</a></td><td style='width:75%' ><p><a name="f38e65e1-ddfd-4e6b-945d-c714aa5edeb4"></a></p>

<h3>AddNewProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoProperty</code> to this portfolio</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="c2638553-1392-46cb-b827-082b08f59068"></a>
The <code>KimonoProperty</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2428bde-e001-41fa-a7c1-2274431c6b0c'>DuplicateColor</a></td><td style='width:75%' class='def'><p><a name="b2428bde-e001-41fa-a7c1-2274431c6b0c"></a></p>

<h3>DuplicateColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoColor</code> and adds it to the portfolio's collection of colors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="3db364da-1e76-4981-a28f-d80792200160"></a>
The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b94778b2-bbd9-4c24-af41-7c0e7b401a03'>DuplicateProperty</a></td><td style='width:75%' ><p><a name="b94778b2-bbd9-4c24-af41-7c0e7b401a03"></a></p>

<h3>DuplicateProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="0313c7de-afa8-4708-8c78-1d6dbbb0c00b"></a>
The <code>KimonoProperty</code> to duplicate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#850c1a19-6bb6-4460-84ec-988c158e160e'>DuplicateGradient</a></td><td style='width:75%' class='def'><p><a name="850c1a19-6bb6-4460-84ec-988c158e160e"></a></p>

<h3>DuplicateGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="a81ed587-26e4-41fa-8f41-c0112937c4ac"></a>
The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d369d635-be03-4f8e-b2b1-cff89ddb0aa8'>DeleteColor</a></td><td style='width:75%' ><p><a name="d369d635-be03-4f8e-b2b1-cff89ddb0aa8"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="c9e60115-28d2-40b4-974a-4c27200aaf6b"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08b4fe4c-cc3e-44b6-b88d-c170df9a9974'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="08b4fe4c-cc3e-44b6-b88d-c170df9a9974"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="8fea2995-e16e-4a4e-b418-56ae1365d79e"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f45ded2-65ad-434a-8e77-e777ce5883fb'>DeleteProperty</a></td><td style='width:75%' ><p><a name="3f45ded2-65ad-434a-8e77-e777ce5883fb"></a></p>

<h3>DeleteProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="4fee60a8-970a-44e4-8fc9-ce116276e495"></a>
The <code>KimonoProperty</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7510395-e225-442c-b042-b1bb103d9643'>AddNewStyle</a></td><td style='width:75%' class='def'><p><a name="b7510395-e225-442c-b042-b1bb103d9643"></a></p>

<h3>AddNewStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoStyle</code> to the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1933f88-697d-4da0-8bcf-0aa59205a706'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="b1933f88-697d-4da0-8bcf-0aa59205a706"></a></p>

<h3>DuplicateStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoStyle</code> adding it to the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="2df3f7aa-b7af-4913-a9c8-e3247070f9ad"></a>
The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6fa52ff-7a90-456c-a633-757ad7b3ba3c'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' class='def'><p><a name="c6fa52ff-7a90-456c-a633-757ad7b3ba3c"></a></p>

<h3>ConvertSelectedShapeToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Takes the custom <code>KimonoStyle</code> of the currently selected <code>KimonoShape</code>, converts it to a named, shared style and adds it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94a1b902-f91d-4b6b-b127-bc4c229b9db7'>DeleteStyle</a></td><td style='width:75%' ><p><a name="94a1b902-f91d-4b6b-b127-bc4c229b9db7"></a></p>

<h3>DeleteStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoStyle</code> from the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="b7c2a055-708e-49e1-a584-7cdba8adf4bc"></a>
Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7eaa5544-ad3b-4c87-a302-bb6ab6870c45'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="7eaa5544-ad3b-4c87-a302-bb6ab6870c45"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4088d28e-0097-472c-a8ef-452e9c573758'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="4088d28e-0097-472c-a8ef-452e9c573758"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cff9c99-8aff-44a8-9659-2842d900a313'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="0cff9c99-8aff-44a8-9659-2842d900a313"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f089ad0-7f55-4a8d-995b-71e974e319dc'>ToCSharp</a></td><td style='width:75%' ><p><a name="3f089ad0-7f55-4a8d-995b-71e974e319dc"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e157d366-9a8a-4dbe-bb90-3d4c52e3f4e2"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed837d0a-9273-460e-bf53-0aa6265fdb1c'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="ed837d0a-9273-460e-bf53-0aa6265fdb1c"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="586c0e0f-4dd7-446f-b486-41582b229816"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="f16d2461-5d76-4ec8-961f-df130a5a5578"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#feddb42d-ee49-4e50-a6a8-a0314d2d78a8'>ToCSharp</a></td><td style='width:75%' ><p><a name="feddb42d-ee49-4e50-a6a8-a0314d2d78a8"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a60e2e43-818a-4907-af15-5280d5942508"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e20f5c5-bf09-4431-92f4-5a75acbc90bf'>ToCSharpKimono</a></td><td style='width:75%' class='def'><p><a name="4e20f5c5-bf09-4431-92f4-5a75acbc90bf"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="f2688b9d-b178-4bef-9c6b-1ecef9cf31d9"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5b5877e2-26d7-49a6-b517-8671ca49e326"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="31e1d3a1-0a21-4cee-b427-ee046a5e53ac"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a78bd34-5bac-43e6-9084-564f6c8c0c60'>ToCode</a></td><td style='width:75%' ><p><a name="5a78bd34-5bac-43e6-9084-564f6c8c0c60"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="cde44f15-81f6-409e-9fc2-86627b71a7ce"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="122f0198-2356-4892-b3f8-7ba1e6cf522d"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="42fdedd4-a3a3-4cb5-bb66-d9ec44222811"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e5d5bb4-e4f6-434b-916f-9d60729870cc'>RelinkColors</a></td><td style='width:75%' class='def'><p><a name="4e5d5bb4-e4f6-434b-916f-9d60729870cc"></a></p>

<h3>RelinkColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the colors after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db700dad-7c48-45fe-8007-4bdbd10ebb67'>RelinkGradient</a></td><td style='width:75%' ><p><a name="db700dad-7c48-45fe-8007-4bdbd10ebb67"></a></p>

<h3>RelinkGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the gradient after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="45f23b1e-3851-494e-bac1-a5b0ed022ce6"></a>
The <code>KimonoGradient</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1fb9859-350c-43ed-9c12-7b0d4f9a9904'>RelinkStyle</a></td><td style='width:75%' class='def'><p><a name="e1fb9859-350c-43ed-9c12-7b0d4f9a9904"></a></p>

<h3>RelinkStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoStyle</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="e7d97d8f-bbdb-473f-b302-0561a090677a"></a>
The <code>KimonoStyle</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10457a83-fe20-48b5-b274-903dc387bd91'>RelinkShape</a></td><td style='width:75%' ><p><a name="10457a83-fe20-48b5-b274-903dc387bd91"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoShape</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="27c857b8-abc2-4d70-ad19-e4bc3d297df0"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f6addc4-e738-4066-b6e2-cd9b7006658f'>RelinkSketch</a></td><td style='width:75%' class='def'><p><a name="3f6addc4-e738-4066-b6e2-cd9b7006658f"></a></p>

<h3>RelinkSketch (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoSketch</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="0ddec7de-1277-4254-a4f5-71aa9aec0350"></a>
The <code>KimonoSketch</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2978acf1-5c6f-472c-94a8-c81d6e13e05f'>Clone</a></td><td style='width:75%' ><p><a name="2978acf1-5c6f-472c-94a8-c81d6e13e05f"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#792569d3-58f4-41cd-a9cb-80b42ff68ae1'>RaisePropertyModified</a></td><td style='width:75%' class='def'><p><a name="792569d3-58f4-41cd-a9cb-80b42ff68ae1"></a></p>

<h3>RaisePropertyModified (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the property modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="a21d4d42-1e4d-4ba1-83b6-7a407de0924b"></a>
The <code>KimonoProperty</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbfb2242-3faf-48cd-afbc-47c9743743d8'>RaiseGradientsModified</a></td><td style='width:75%' ><p><a name="bbfb2242-3faf-48cd-afbc-47c9743743d8"></a></p>

<h3>RaiseGradientsModified (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradients modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="ca341555-30d7-4b03-96aa-aef86abbbdc3"></a>
The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ec98c09-5d8e-4a82-92bd-bf2953e68840'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="7ec98c09-5d8e-4a82-92bd-bf2953e68840"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0580846-6f0a-4888-9a8b-5ae0fa746f91'>RaiseSketchesModified</a></td><td style='width:75%' ><p><a name="a0580846-6f0a-4888-9a8b-5ae0fa746f91"></a></p>

<h3>RaiseSketchesModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cbc42af-192e-426f-a92e-055a5132091c'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' class='def'><p><a name="0cbc42af-192e-426f-a92e-055a5132091c"></a></p>

<h3>RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch will change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="b891a111-6170-4045-aed5-2db49e70cb38"></a>
The <code>KimonoSketch</code> that will change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31a743c8-be9a-4961-906b-e2d4497c050b'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' ><p><a name="31a743c8-be9a-4961-906b-e2d4497c050b"></a></p>

<h3>RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch did change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="2f892924-88a7-4686-9a6a-216de5f7d040"></a>
The <code>KimonoSketch</code> that did change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#495a1e86-a4be-4d2d-8147-887dea33d1cb'>RaiseStylesModified</a></td><td style='width:75%' class='def'><p><a name="495a1e86-a4be-4d2d-8147-887dea33d1cb"></a></p>

<h3>RaiseStylesModified (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the styles modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="b33fbf3e-a274-430d-b86a-ea7ff3d5de01"></a>
The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98d9edf8-6821-4032-9886-4faca9f1a860'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p><a name="98d9edf8-6821-4032-9886-4faca9f1a860"></a></p>

<h3>RaiseSelectedShapeChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="b7384e5e-2bb0-439c-83cc-b5894c5e440d"></a>
The new <code>KimonoShape</code> that was selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16831646-e003-47fb-a547-b966284feacd'>RaiseColorsModified</a></td><td style='width:75%' class='def'><p><a name="16831646-e003-47fb-a547-b966284feacd"></a></p>

<h3>RaiseColorsModified (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the colors modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="da219247-4664-4e06-b5a8-6d6117c55c32"></a>
The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#945b4e4c-5420-4218-ac40-b2163c22d035'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="945b4e4c-5420-4218-ac40-b2163c22d035"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f19f4cd-e8d1-42ce-bed1-a252b10a17ad'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="0f19f4cd-e8d1-42ce-bed1-a252b10a17ad"></a></p>

<h3>SketchesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d636106-0820-4cb4-919f-0388f4b55d02'>SelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="9d636106-0820-4cb4-919f-0388f4b55d02"></a></p>

<h3>SelectedSketchWillChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch will change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#830834ed-7a7b-40bd-8623-b7ee8f44e9d6'>SelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="830834ed-7a7b-40bd-8623-b7ee8f44e9d6"></a></p>

<h3>SelectedSketchDidChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b564887a-26c3-4500-8dfd-632764ae8726'>StylesModified</a></td><td style='width:75%' ><p><a name="b564887a-26c3-4500-8dfd-632764ae8726"></a></p>

<h3>StylesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when styles collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3da6785f-fbea-4e80-9c6f-95f356ae83b3'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p><a name="3da6785f-fbea-4e80-9c6f-95f356ae83b3"></a></p>

<h3>SelectedShapeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afd0e029-b1aa-4655-8bda-783a9ca61543'>ColorsModified</a></td><td style='width:75%' ><p><a name="afd0e029-b1aa-4655-8bda-783a9ca61543"></a></p>

<h3>ColorsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34b31bcc-0b30-4441-8369-20e310e004bf'>GradientsModified</a></td><td style='width:75%' class='def'><p><a name="34b31bcc-0b30-4441-8369-20e310e004bf"></a></p>

<h3>GradientsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72783a14-9823-4c03-89fa-e8087817f11a'>PropertyModified</a></td><td style='width:75%' ><p><a name="72783a14-9823-4c03-89fa-e8087817f11a"></a></p>

<h3>PropertyModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when property collection is modified.</p>
</td></tr></table></p>


---

<a name="a0676851-e8fb-4704-8343-143e7b3a78fe"></a>
##KimonoUndoHandler

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Handles the undo/redo state for a `KimonoDesignSurface`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7f55192a-91f2-40c7-9cbc-9fcaa99da51f'>MaximumUndoPoints</a></td><td style='width:75%' ><p><a name="7f55192a-91f2-40c7-9cbc-9fcaa99da51f"></a></p>

<h3>MaximumUndoPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the maximum undo points.</p>

<h4>Return Value</h4>

<p>The maximum undo points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#979240bd-0d27-40a3-9309-130af4d5815f'>UndoStack</a></td><td style='width:75%' class='def'><p><a name="979240bd-0d27-40a3-9309-130af4d5815f"></a></p>

<h3>UndoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the undo stack.</p>

<h4>Return Value</h4>

<p>The undo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a4d9b80-e7a0-4878-aedd-98685b95d096'>RedoStack</a></td><td style='width:75%' ><p><a name="9a4d9b80-e7a0-4878-aedd-98685b95d096"></a></p>

<h3>RedoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the redo stack.</p>

<h4>Return Value</h4>

<p>The redo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5630f8c8-fd33-4405-9d9f-eab81d9f9450'>CanUndo</a></td><td style='width:75%' class='def'><p><a name="5630f8c8-fd33-4405-9d9f-eab81d9f9450"></a></p>

<h3>CanUndo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can undo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can undo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dade4e72-d688-4027-a480-c7357ddffd27'>CanRedo</a></td><td style='width:75%' ><p><a name="dade4e72-d688-4027-a480-c7357ddffd27"></a></p>

<h3>CanRedo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can redo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can redo; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#81647cf2-a9fa-458d-9d98-6c0d18a08c1d'>KimonoUndoHandler</a></td><td style='width:75%' ><p><a name="81647cf2-a9fa-458d-9d98-6c0d18a08c1d"></a></p>

<h3>KimonoUndoHandler ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a0676851-e8fb-4704-8343-143e7b3a78fe">KimonoUndoHandler</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6adc1903-bf3d-490f-b35a-2c19a58b3672'>PushUndoPoint</a></td><td style='width:75%' class='def'><p><a name="6adc1903-bf3d-490f-b35a-2c19a58b3672"></a></p>

<h3>PushUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pushes the undo point onto the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="f3c3e899-50e9-40da-ae20-714009c40c80"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9de9f11-e74d-46c2-8f43-df9fe019a68e'>ReplaceLastUndoPoint</a></td><td style='width:75%' ><p><a name="d9de9f11-e74d-46c2-8f43-df9fe019a68e"></a></p>

<h3>ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Replaces the last undo point with the one being passed in.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="b10bd1d2-2ceb-4adc-b691-1e1bc470370c"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16b27494-e467-427d-a687-aa8759332bd7'>PopUndoPoint</a></td><td style='width:75%' class='def'><p><a name="16b27494-e467-427d-a687-aa8759332bd7"></a></p>

<h3>PopUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the undo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="225b9daf-a936-40a1-a1e7-cfb899b11041"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The prior state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6254ff2-edb9-4128-834b-116ae709e8db'>PopRedoPoint</a></td><td style='width:75%' ><p><a name="b6254ff2-edb9-4128-834b-116ae709e8db"></a></p>

<h3>PopRedoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the redo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="79655873-1d4d-423a-a215-95bbfa9ad3c5"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The previous state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67337a97-1dca-4031-8c05-c7a12ecd9319'>RaiseUndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="67337a97-1dca-4031-8c05-c7a12ecd9319"></a></p>

<h3>RaiseUndoStateChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the undo state changed event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3df3db1f-5499-47f0-9fbc-03e2eca055f5'>UndoStateChanged</a></td><td style='width:75%' ><p><a name="3df3db1f-5499-47f0-9fbc-03e2eca055f5"></a></p>

<h3>UndoStateChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="decb9848-2915-4f9d-87f2-3494d80a51e4"></a>
##KimonoShape

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the based shape that all other Kimono Shape types will inherit from.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ac87d74f-2130-4b6b-b66c-3d2735c1734d'>_name</a></td><td style='width:75%' ><p><a name="ac87d74f-2130-4b6b-b66c-3d2735c1734d"></a>
<b>_name</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default name of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a691d3a-5a5b-46a4-8c6d-94290d3f3c15'>_style</a></td><td style='width:75%' class='def'><p><a name="7a691d3a-5a5b-46a4-8c6d-94290d3f3c15"></a>
<b>_style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default, custom <code>KimonoStyle</code> that is attached to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a82e4647-381b-4c06-8482-8cba7a89a39c'>_visible</a></td><td style='width:75%' ><p><a name="a82e4647-381b-4c06-8482-8cba7a89a39c"></a>
<b>_visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a65f81f1-b729-4ba3-92f5-3373011f2044'>Name</a></td><td style='width:75%' ><p><a name="a65f81f1-b729-4ba3-92f5-3373011f2044"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4cc2743-2da5-4fbf-8306-62c7299e6366'>ElementName</a></td><td style='width:75%' class='def'><p><a name="d4cc2743-2da5-4fbf-8306-62c7299e6366"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3526854e-dfaf-4f52-82c6-799fc862dd02'>Style</a></td><td style='width:75%' ><p><a name="3526854e-dfaf-4f52-82c6-799fc862dd02"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> that will be used to draw this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42a1fd03-263f-4c7a-9012-301bc02116e9'>ControlPoints</a></td><td style='width:75%' class='def'><p><a name="42a1fd03-263f-4c7a-9012-301bc02116e9"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the path of the shape.</p>

<h4>Return Value</h4>

<p>A collection of <code>KimonoHandle</code> objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1aadafe-e2c1-46ce-966b-a2d8b5061a75'>Visible</a></td><td style='width:75%' ><p><a name="d1aadafe-e2c1-46ce-966b-a2d8b5061a75"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#decb9848-2915-4f9d-87f2-3494d80a51e4">KimonoShape</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c30d1a2-2cc5-40e4-aaa8-0bb4f967c21f'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="5c30d1a2-2cc5-40e4-aaa8-0bb4f967c21f"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#decb9848-2915-4f9d-87f2-3494d80a51e4">KimonoShape</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>An "Editable Shape" is one that is composed of a set of data points (such as <code>KimonoVector</code> or <code>KimonoBezier</code>) or a group of objects (such as <code>KimonoShapeGroup</code>).</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f0689ca-49e1-4a7c-820a-40ec0ab528a4'>LayerDepth</a></td><td style='width:75%' ><p><a name="7f0689ca-49e1-4a7c-820a-40ec0ab528a4"></a></p>

<h3>LayerDepth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.</p>

<h4>Return Value</h4>

<p>The layer depth.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d96797b-56b4-41e6-8f0c-958393bb85e9'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="4d96797b-56b4-41e6-8f0c-958393bb85e9"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e6ab7dc-6701-450b-bb1e-d299677e1922'>PropertyConnections</a></td><td style='width:75%' ><p><a name="5e6ab7dc-6701-450b-bb1e-d299677e1922"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#52867d26-60f0-42c5-b63b-472b16594064'>KimonoShape</a></td><td style='width:75%' ><p><a name="52867d26-60f0-42c5-b63b-472b16594064"></a></p>

<h3>KimonoShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#decb9848-2915-4f9d-87f2-3494d80a51e4">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#612ca351-422f-4ef3-923d-79c4f89eb960'>KimonoShape</a></td><td style='width:75%' class='def'><p><a name="612ca351-422f-4ef3-923d-79c4f89eb960"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#decb9848-2915-4f9d-87f2-3494d80a51e4">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="28918b93-5b0c-4932-98c8-c3f669888876"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a63ad2d0-c113-4e22-b5a2-bbf7302ff86d"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="86d057b5-678d-4ba9-8fc2-0b4ad5b3757e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="56bb2270-4e76-4cbf-b708-7ce0c9b2fcda"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3b4c904-e0b3-451b-aea9-141b24975dfd'>KimonoShape</a></td><td style='width:75%' ><p><a name="d3b4c904-e0b3-451b-aea9-141b24975dfd"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#decb9848-2915-4f9d-87f2-3494d80a51e4">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8fed7194-2264-4836-9b72-b439ff23922a"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="05eacda3-4ddb-49f6-833d-81a1fbf9257b"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="c79d8be9-bd36-456b-8a3f-6f7e9d73e883"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="5780857e-0bf4-4880-9987-a601b8f94291"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="dad262d6-d990-4a6a-8e68-caf04c5c977c"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#633ce3d7-f872-4352-a2b1-ea40d2ba7742'>Initialize</a></td><td style='width:75%' class='def'><p><a name="633ce3d7-f872-4352-a2b1-ea40d2ba7742"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60b89ce6-774c-4435-b9cf-93eb8ca15152'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="60b89ce6-774c-4435-b9cf-93eb8ca15152"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="2fcc56cb-f5a2-42a1-9115-34f86b36dc46"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="037eb268-6fd4-4623-905d-05f977703791"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ffca813-3d45-47fc-9050-0a4dfb27d222'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="8ffca813-3d45-47fc-9050-0a4dfb27d222"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="aad1d8b2-670c-4af2-ab17-1020a32a2760"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbc36c2b-c2d5-4ad9-b5a2-803acff8cc13'>RemoveProperty</a></td><td style='width:75%' ><p><a name="bbc36c2b-c2d5-4ad9-b5a2-803acff8cc13"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="5c2a769b-a2bb-4ce2-9b7b-eef51f733504"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#116e6801-9d84-4360-a42d-7fbd0ce6d608'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="116e6801-9d84-4360-a42d-7fbd0ce6d608"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoShape</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2f0862c-42a1-4c8d-b0c2-8857360747f3'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="c2f0862c-42a1-4c8d-b0c2-8857360747f3"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="8e565fe4-3ce8-46b2-aca0-ca07149aba2f"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae5d0797-1471-44ba-91b8-e3accb10dea5'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="ae5d0797-1471-44ba-91b8-e3accb10dea5"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape in the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1a6df4d-21ac-40fc-b649-cfb12384ddca'>EndEditing</a></td><td style='width:75%' ><p><a name="b1a6df4d-21ac-40fc-b649-cfb12384ddca"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20b2b561-cf13-4b2a-aa0b-ab9e6bae549a'>UncoupleDeletedStyle</a></td><td style='width:75%' class='def'><p><a name="20b2b561-cf13-4b2a-aa0b-ab9e6bae549a"></a></p>

<h3>UncoupleDeletedStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Uncouples the deleted style from the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p><a name="93ed5482-2030-4dbb-b480-7b236fcc6a41"></a>
The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33e82a68-fa74-417c-903e-1736ad884e82'>ConformGradientToShape</a></td><td style='width:75%' ><p><a name="33e82a68-fa74-417c-903e-1736ad884e82"></a></p>

<h3>ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the gradient to shape by fitting it to the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="327431b6-a15f-4608-9277-bb1984750789"></a>
The <code>KimonoGradient</code> to conform.</p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p><a name="c5482673-5e1e-4f01-908b-05a214cdfc13"></a>
The <code>SKPaint</code> that the gradient is being attached to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7c7ad2b-d078-46e1-a51a-980324b779c3'>ToVector</a></td><td style='width:75%' class='def'><p><a name="c7c7ad2b-d078-46e1-a51a-980324b779c3"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a vector.</p>

<h4>Returns</h4>

<p>The shape as a <code>KimonoVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#917ecef0-a280-4247-813f-0a357236ba77'>ToPath</a></td><td style='width:75%' ><p><a name="917ecef0-a280-4247-813f-0a357236ba77"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b90a573-4106-45c8-8406-a5617bd856da'>StyleFillPaintForCode</a></td><td style='width:75%' class='def'><p><a name="3b90a573-4106-45c8-8406-a5617bd856da"></a></p>

<h3>StyleFillPaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style fill paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f49ffd6-bddd-4b76-b2f5-c2f94cd71ca1'>StyleFramePaintForCode</a></td><td style='width:75%' ><p><a name="9f49ffd6-bddd-4b76-b2f5-c2f94cd71ca1"></a></p>

<h3>StyleFramePaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style frame paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f27fcef7-b226-4ad6-947a-83e33d8d36be'>ConformedFillGradientCode</a></td><td style='width:75%' class='def'><p><a name="f27fcef7-b226-4ad6-947a-83e33d8d36be"></a></p>

<h3>ConformedFillGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="31590f6c-ae90-44f9-b53b-b4ccdbf48231"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The fill gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2596b92a-0c1f-4cbd-9103-f5508afabe76'>ConformedFrameGradientCode</a></td><td style='width:75%' ><p><a name="2596b92a-0c1f-4cbd-9103-f5508afabe76"></a></p>

<h3>ConformedFrameGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e9115e85-f9ce-4bb1-b4b7-a262363e672d"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The frame gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cac18041-9748-4097-9841-4eec47713869'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="cac18041-9748-4097-9841-4eec47713869"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3939edd-ab0d-465f-8561-3e061f29731f'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="f3939edd-ab0d-465f-8561-3e061f29731f"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f7ce295-80f9-4d66-a22c-79669f8629eb'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="0f7ce295-80f9-4d66-a22c-79669f8629eb"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c90d9767-7287-4520-97dc-85d1fbfb8b91'>ToCSharp</a></td><td style='width:75%' ><p><a name="c90d9767-7287-4520-97dc-85d1fbfb8b91"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e962b14e-45c4-4f3a-ba01-1cf203cd304a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5872371-ca44-467f-a227-48f2d6a400f2'>ToCode</a></td><td style='width:75%' class='def'><p><a name="f5872371-ca44-467f-a227-48f2d6a400f2"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="939498b1-67dd-4fb3-9ed6-68d91f1c6f63"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8c7a4f28-7f7c-4e3e-8e78-8fc75c54b14a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="17e48793-941c-414f-91bf-71e4fffe34e6"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bc91ccd-4e81-40d1-a1f1-0346b74756b4'>CloneAttachedStyle</a></td><td style='width:75%' ><p><a name="0bc91ccd-4e81-40d1-a1f1-0346b74756b4"></a></p>

<h3>CloneAttachedStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the attached style.</p>

<h4>Returns</h4>

<p>A duplicate <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99b92da8-bfa0-42c0-9065-4b20f9472b82'>Clone</a></td><td style='width:75%' class='def'><p><a name="99b92da8-bfa0-42c0-9065-4b20f9472b82"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of this shape as a base <code>KimonoBounds</code>.</p>
</td></tr></table></p>


---

<a name="4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7"></a>
##KimonoShapeArrow

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws either an outlined or single line arrow with heads on one or both ends.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b76e90e1-4669-40db-ad95-9cd93853c4e5'>HasStartHead</a></td><td style='width:75%' ><p><a name="b76e90e1-4669-40db-ad95-9cd93853c4e5"></a></p>

<h3>HasStartHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7">KimonoShapeArrow</a> has start head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has start head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41a5b117-e498-4391-8e02-b411dff8b5c0'>HasEndHead</a></td><td style='width:75%' class='def'><p><a name="41a5b117-e498-4391-8e02-b411dff8b5c0"></a></p>

<h3>HasEndHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7">KimonoShapeArrow</a> has end head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has end head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e358b21-94f2-47ab-a2c5-5a9cc5826d5b'>HeadInnerRatio</a></td><td style='width:75%' ><p><a name="0e358b21-94f2-47ab-a2c5-5a9cc5826d5b"></a></p>

<h3>HeadInnerRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head inner ratio.</p>

<h4>Return Value</h4>

<p>The head inner ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5410979-f56e-4f34-aa08-ae8fbcab6701'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p><a name="b5410979-f56e-4f34-aa08-ae8fbcab6701"></a></p>

<h3>HeadOuterRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head outer ratio.</p>

<h4>Return Value</h4>

<p>The head outer ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd4e81c3-9a59-411e-8d5f-031479d9632c'>IsStreamlined</a></td><td style='width:75%' ><p><a name="fd4e81c3-9a59-411e-8d5f-031479d9632c"></a></p>

<h3>IsStreamlined</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7">KimonoShapeArrow</a> is streamlined.</p>

<h4>Return Value</h4>

<p><code>true</code> if is streamlined; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>A Streamlined Arrow, is drawn as a single line.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c136d50-c13f-4e3e-b968-2d4b0246618d'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="7c136d50-c13f-4e3e-b968-2d4b0246618d"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5bdfe363-529f-4f90-bb62-e74acae1d18c'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="5bdfe363-529f-4f90-bb62-e74acae1d18c"></a></p>

<h3>KimonoShapeArrow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6dfb07e-85fd-4d18-9ab6-a2d562e2728d'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p><a name="e6dfb07e-85fd-4d18-9ab6-a2d562e2728d"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9292825b-3a34-4ca6-94dd-9fc81670cae2"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="22a2f115-1f79-4ec3-bbcb-83f14f3ca921"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="6457a7a7-2b67-4cea-825a-fd487fe54513"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="82342b2b-d11c-4622-95cf-646749b6fdd2"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c32a018a-a887-4cd0-9e4b-c24e3789c973'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="c32a018a-a887-4cd0-9e4b-c24e3789c973"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4b9c5b8b-82a6-4b45-8e40-f9a722deb2f7">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9cee1638-859c-434c-b06e-471c3b9984ee"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="21832780-3f4f-4b5c-9cd8-42561da7fbc0"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8568a7c7-a12e-426a-b8dc-8cb63ed818da"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="052b713d-fb45-4f98-bc49-c4a6de6e8db2"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="a1bf0007-4b15-4be0-8064-8bb3588cc7f1"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#274df8f2-4b60-48af-aa8b-4d01d5c4f88f'>Initialize</a></td><td style='width:75%' class='def'><p><a name="274df8f2-4b60-48af-aa8b-4d01d5c4f88f"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2df4ed1c-cbd0-4128-8f31-b8ad2a9535ea'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="2df4ed1c-cbd0-4128-8f31-b8ad2a9535ea"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="19c564b4-5c83-4b76-976c-588974499fb1"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfb1efaf-31bc-47d9-8654-21066e98a0bb'>ToPath</a></td><td style='width:75%' class='def'><p><a name="bfb1efaf-31bc-47d9-8654-21066e98a0bb"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the arrow to a path.</p>

<h4>Returns</h4>

<p>The the arrow as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#396ff452-83b6-447d-9793-c955a8b64d89'>Draw</a></td><td style='width:75%' ><p><a name="396ff452-83b6-447d-9793-c955a8b64d89"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the arrow into the specified Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="6abe5a03-e29f-47b6-84ba-e785a257b6cc"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e276274-3e27-4d94-8a02-831b158452d4'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="8e276274-3e27-4d94-8a02-831b158452d4"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the arrow.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="eba910cd-4880-4ca0-b3a5-8af654be72d4"></a>
The <code>SKPoint</code> containing the bounds adjustment.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c33acad-7406-4667-9351-69f61c11fc66'>DragBounds</a></td><td style='width:75%' ><p><a name="4c33acad-7406-4667-9351-69f61c11fc66"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the arrow to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a2fd844b-f71a-4e5e-a513-3638116274e2"></a>
The <code>SKPoint</code> specifying the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d33bb7a-445b-4561-9e47-d67174d3b72b'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="2d33bb7a-445b-4561-9e47-d67174d3b72b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8eb195a-1124-4e69-86d0-0568725a576b'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="b8eb195a-1124-4e69-86d0-0568725a576b"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8bf27a4-df1a-4a6c-86fd-025ef3b8737f'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="d8bf27a4-df1a-4a6c-86fd-025ef3b8737f"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff46523f-ca52-4e3e-b76a-a78421de245c'>ToCSharp</a></td><td style='width:75%' ><p><a name="ff46523f-ca52-4e3e-b76a-a78421de245c"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="eb394728-9bba-4e6a-9096-f0a69e874739"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0396dfdb-a3d0-4a42-9c45-ce7dbdd259ed'>ToCode</a></td><td style='width:75%' class='def'><p><a name="0396dfdb-a3d0-4a42-9c45-ce7dbdd259ed"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="c3be6781-1396-4425-b820-09258e7a3eff"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="482956bb-5e4a-4a9d-9edf-77c1f77b6ee1"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9c0f4fe3-c865-4da1-a2db-107d4c12b690"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a0b63c9-d741-4574-afdb-53de97eeda88'>Clone</a></td><td style='width:75%' ><p><a name="8a0b63c9-d741-4574-afdb-53de97eeda88"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoArrow</code>.</p>
</td></tr></table></p>


---

<a name="be0d0bb6-42db-48b9-a105-33f4775ee49d"></a>
##KimonoShapeBezier

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2107b38d-7240-42a3-aa8b-b01436db0a4a'>Points</a></td><td style='width:75%' ><p><a name="2107b38d-7240-42a3-aa8b-b01436db0a4a"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c8a97ba-7bd6-4253-b0ac-26be8a8267eb'>Closed</a></td><td style='width:75%' class='def'><p><a name="2c8a97ba-7bd6-4253-b0ac-26be8a8267eb"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a74f5b62-55f6-454c-8ab8-d16efa3cff6b'>IsEditable</a></td><td style='width:75%' ><p><a name="a74f5b62-55f6-454c-8ab8-d16efa3cff6b"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65ffe8ed-28e0-4db0-89d1-8c3f11f3aff9'>LastPoint</a></td><td style='width:75%' class='def'><p><a name="65ffe8ed-28e0-4db0-89d1-8c3f11f3aff9"></a></p>

<h3>LastPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the last point in the collection of control points.</p>

<h4>Return Value</h4>

<p>The last point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#73235c5d-6148-4f2d-8d6b-6a8edc15be58'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="73235c5d-6148-4f2d-8d6b-6a8edc15be58"></a></p>

<h3>KimonoShapeBezier ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#be0d0bb6-42db-48b9-a105-33f4775ee49d">KimonoShapeBezier</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d18393e-e6cc-46f4-8975-be8e455b6250'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p><a name="8d18393e-e6cc-46f4-8975-be8e455b6250"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#be0d0bb6-42db-48b9-a105-33f4775ee49d">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="be09e908-d98b-42d1-94e6-7f2b82e52f09"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="7b6e26c7-dc5e-40f8-9784-efeb2ec67945"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="555c429d-bc21-4000-921d-83a7f29d69e9"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="6d8a3a20-6e81-4173-9d14-e1d5622241ac"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9879b03-7cdc-4572-a922-babb76694e19'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="d9879b03-7cdc-4572-a922-babb76694e19"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#be0d0bb6-42db-48b9-a105-33f4775ee49d">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="21e7f0fe-2146-4c8e-aab5-15ae2f46173e"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="031099a0-6af7-4151-bb9d-269ffb9be276"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="6e31fab6-07cd-4c20-87fc-7b9846e62f2a"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f9abdb9c-e314-4c5d-9e2e-6f7157ec1b70"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="d6107cd4-77f3-402d-a95c-75b5fd8bf340"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb75e01a-4d90-4cd5-b5ac-b3f81da3dcf5'>Initialize</a></td><td style='width:75%' class='def'><p><a name="fb75e01a-4d90-4cd5-b5ac-b3f81da3dcf5"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#723b2b97-30be-43e9-8f6a-849e2dc82dc1'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="723b2b97-30be-43e9-8f6a-849e2dc82dc1"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af1274b0-dfc1-4f32-9bc4-7b33671a2768'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="af1274b0-dfc1-4f32-9bc4-7b33671a2768"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="3afff17b-9353-4458-b939-64041d9579d1"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="95440c0e-7df5-4a86-b87f-e061b393253c"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c1974fd-5887-4163-9d7f-86e50db49945'>AddPoint</a></td><td style='width:75%' ><p><a name="2c1974fd-5887-4163-9d7f-86e50db49945"></a></p>

<h3>AddPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="1111717e-633d-4c16-84de-d298185b8198"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="f2ebf05a-cb47-42ec-b90e-c3942f14f128"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="3ba07533-9fbf-4f2c-aea6-9b92ec81d258"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="6fba201c-3edd-4e0f-ab44-3e1921931cee"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37031b5e-8c61-47ea-932c-1154f30da840'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="37031b5e-8c61-47ea-932c-1154f30da840"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="f4acea6d-8d40-4ce7-ae35-0f225cca5196"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cb750d7-8c12-4103-a8ad-2ac028760fe8'>AddHandlesForPoint</a></td><td style='width:75%' ><p><a name="6cb750d7-8c12-4103-a8ad-2ac028760fe8"></a></p>

<h3>AddHandlesForPoint (System.Int32, KimonoCore.KimonoBezierPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the handles for the given bezier point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="33cfdad6-f3bc-48d8-9979-d7b538ae2078"></a>
The index of the <code>KimonoBezierPoint</code> that handles are being created for.</p>
</td></tr><tr><td style='width:25%' class='term'>bezierPoint</td><td style='width:75%' class='def'><p><a name="d30d56ef-b8b3-4415-9ca7-06af29450abc"></a>
The <code>KimonoBezierPoint</code> that is getting handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81bfb256-0fcb-4c23-b897-803e157e779d'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="81bfb256-0fcb-4c23-b897-803e157e779d"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d0c77bab-c742-44c7-a67a-039f0c85c08a"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e22ed51c-1a2d-492a-826e-5d95e4fe8c97'>RemovePoint</a></td><td style='width:75%' ><p><a name="e22ed51c-1a2d-492a-826e-5d95e4fe8c97"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="5265b2ac-7411-4d5d-88ce-6a80b3914346"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5ff71fe-493d-4e6d-937e-715f90c17100'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="d5ff71fe-493d-4e6d-937e-715f90c17100"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1ee61f4-6858-424d-89cb-72aa30ad70a7'>ToPath</a></td><td style='width:75%' ><p><a name="b1ee61f4-6858-424d-89cb-72aa30ad70a7"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#655ef248-58b0-4fbd-8c22-8f7772cb3ea9'>Draw</a></td><td style='width:75%' class='def'><p><a name="655ef248-58b0-4fbd-8c22-8f7772cb3ea9"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="aa3c5e04-c06b-4f90-8381-640845c974e2"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#800b1839-f023-4f5d-9f30-da85515816dd'>PointInBound</a></td><td style='width:75%' ><p><a name="800b1839-f023-4f5d-9f30-da85515816dd"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="48a0d03b-4efb-407c-93f5-5bed9978a34e"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c9f03c6-8ec7-4473-933d-d179f005fedb'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="7c9f03c6-8ec7-4473-933d-d179f005fedb"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="79b8d354-cb62-47e4-b96e-93bbe711ec3f"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ef67932-a5c5-4234-b7a9-4d584bc816bf'>BoundsChanged</a></td><td style='width:75%' ><p><a name="4ef67932-a5c5-4234-b7a9-4d584bc816bf"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f32d5d22-a7ed-47c1-bcd7-0660cb7e4655'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="f32d5d22-a7ed-47c1-bcd7-0660cb7e4655"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95014b31-9db5-40df-b8e1-37d453d32aff'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="95014b31-9db5-40df-b8e1-37d453d32aff"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0e03b51-172a-40e4-a575-b46e5cb5279d'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="f0e03b51-172a-40e4-a575-b46e5cb5279d"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3743ef8b-476c-48c9-8bdf-f2db437c71b3'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="3743ef8b-476c-48c9-8bdf-f2db437c71b3"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#323b7744-b3de-43b0-83f4-a566bb84d551'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="323b7744-b3de-43b0-83f4-a566bb84d551"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="291f3e7f-3ef6-438f-be28-c421322d0c04"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c18e9e08-1b21-4b95-9d7e-2094a931179a'>ToCode</a></td><td style='width:75%' ><p><a name="c18e9e08-1b21-4b95-9d7e-2094a931179a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="9d1f1a40-a275-4643-882f-1d2ebc0dbc2d"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="bf63231b-85eb-482c-8438-6cde1f446e74"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="de2c6242-fd7f-4d33-a3a9-8ddf17e7293a"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da4db014-444b-41e2-85dd-b8775e229a3b'>Clone</a></td><td style='width:75%' class='def'><p><a name="da4db014-444b-41e2-85dd-b8775e229a3b"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="73c65bf4-7704-41c7-8ad8-bd787d7bc4ff"></a>
##KimonoShapeGroup

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

A `KimonoShapeGroup` holds a collection of `KimonoShapes` that can be acted upon as a group.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6d606dea-e1bd-4a40-9468-2d16d3bc5ab2'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="6d606dea-e1bd-4a40-9468-2d16d3bc5ab2"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#020dc5bd-3622-4496-9eac-d0ae1ae5fa13'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="020dc5bd-3622-4496-9eac-d0ae1ae5fa13"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#931e1004-7352-4bae-86ae-dbd9d38e3378'>Dragging</a></td><td style='width:75%' ><p><a name="931e1004-7352-4bae-86ae-dbd9d38e3378"></a>
<b>Dragging</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Marks if the group itself is being moved be the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d324c8a7-928d-433d-bac6-e2efe8dee621'>IgnoreDrag</a></td><td style='width:75%' class='def'><p><a name="d324c8a7-928d-433d-bac6-e2efe8dee621"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fccd1f8-4684-4e99-bb24-d82cc70188d4'>PerformingDrag</a></td><td style='width:75%' ><p><a name="2fccd1f8-4684-4e99-bb24-d82cc70188d4"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75e6ffdc-61cf-49e3-9351-b2891e6d2f28'>ToolDownAt</a></td><td style='width:75%' class='def'><p><a name="75e6ffdc-61cf-49e3-9351-b2891e6d2f28"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7885764e-f7c0-46bb-99c6-91bf6cb4bf5b'>_isMaskedGroup</a></td><td style='width:75%' ><p><a name="7885764e-f7c0-46bb-99c6-91bf6cb4bf5b"></a>
<b>_isMaskedGroup</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the top most shape in the group will act as a mask for the shapes below it.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4fa730f1-042b-485b-bc4c-1bf4160cdd3b'>Parent</a></td><td style='width:75%' ><p><a name="4fa730f1-042b-485b-bc4c-1bf4160cdd3b"></a></p>

<h3>Parent</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code> that this <code>KimonoShapeGroup</code> belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dbd9372-798b-4731-a684-e12caafc3568'>ParentSketch</a></td><td style='width:75%' class='def'><p><a name="3dbd9372-798b-4731-a684-e12caafc3568"></a></p>

<h3>ParentSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the parent sketch by scanning backwards through the chain of parent objects until a <code>KimonoSketch</code> is reached.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd0c1e68-9431-48ad-962d-52c9da0d4b58'>Path</a></td><td style='width:75%' ><p><a name="bd0c1e68-9431-48ad-962d-52c9da0d4b58"></a></p>

<h3>Path</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the full path from this group back to the parent <code>KimonoSketch</code>.</p>

<h4>Return Value</h4>

<p>The path representing the nesting level of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c32e84e0-a608-493f-b8e6-cda1dc08830e'>Shapes</a></td><td style='width:75%' class='def'><p><a name="c32e84e0-a608-493f-b8e6-cda1dc08830e"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afbf3229-0048-4545-a6b0-8690e0292754'>SelectedShape</a></td><td style='width:75%' ><p><a name="afbf3229-0048-4545-a6b0-8690e0292754"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0255cad6-73f2-4878-a73b-88320fb50686'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="0255cad6-73f2-4878-a73b-88320fb50686"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3b9d1f8-0507-4a93-a1b6-98b004fde8c1'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="b3b9d1f8-0507-4a93-a1b6-98b004fde8c1"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60ad8960-e1d2-4901-94d0-b06d45b97612'>GroupType</a></td><td style='width:75%' class='def'><p><a name="60ad8960-e1d2-4901-94d0-b06d45b97612"></a></p>

<h3>GroupType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the group.</p>

<h4>Return Value</h4>

<p>The type of the group as a <code>KimonoShapeGroupType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9355d126-a4d8-4992-a4f2-8df5c7a7c9b9'>Style</a></td><td style='width:75%' ><p><a name="9355d126-a4d8-4992-a4f2-8df5c7a7c9b9"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style of this group.</p>

<h4>Return Value</h4>

<p>The style as a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee865c7e-74db-40ae-9675-e79c2d4eedaf'>Visible</a></td><td style='width:75%' class='def'><p><a name="ee865c7e-74db-40ae-9675-e79c2d4eedaf"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4cc96456-510c-4c6f-acdb-4e4cf313dabd'>IsEditable</a></td><td style='width:75%' ><p><a name="4cc96456-510c-4c6f-acdb-4e4cf313dabd"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03c7fcda-1c53-4b9e-9499-675c84f2d5bf'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="03c7fcda-1c53-4b9e-9499-675c84f2d5bf"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#100c95f9-af7a-4788-9a77-733a90567351'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="100c95f9-af7a-4788-9a77-733a90567351"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f60df721-aafd-40b1-8ddf-5f8abf1fbe48'>IsBooleanConstruct</a></td><td style='width:75%' class='def'><p><a name="f60df721-aafd-40b1-8ddf-5f8abf1fbe48"></a></p>

<h3>IsBooleanConstruct</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> is a boolean construct.</p>

<h4>Return Value</h4>

<p><code>true</code> if is boolean construct; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#888f0cec-b1a9-42f1-83cf-5ee38793a2c8'>BooleanOperation</a></td><td style='width:75%' ><p><a name="888f0cec-b1a9-42f1-83cf-5ee38793a2c8"></a></p>

<h3>BooleanOperation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the boolean operation that will be applied to this group of objects.</p>

<h4>Return Value</h4>

<p>The boolean operation as a <code>SKPathOp</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7e57f36-9f3f-4c71-9447-25ef713f487c'>Mask</a></td><td style='width:75%' class='def'><p><a name="f7e57f36-9f3f-4c71-9447-25ef713f487c"></a></p>

<h3>Mask</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoShape</code> that is acting as a mask for this group.</p>

<h4>Return Value</h4>

<p>The mask as a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b96f6f6a-b4bb-4fe3-b40d-45e455928f3b'>IsMaskedGroup</a></td><td style='width:75%' ><p><a name="b96f6f6a-b4bb-4fe3-b40d-45e455928f3b"></a></p>

<h3>IsMaskedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> is masked group.</p>

<h4>Return Value</h4>

<p><code>true</code> if is masked group; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bfc8dac9-a651-40d7-90ae-ccc99f1996b3'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="bfc8dac9-a651-40d7-90ae-ccc99f1996b3"></a></p>

<h3>KimonoShapeGroup (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="12a98379-b502-4d12-a42e-50c4d4c15bf9"></a>
The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9db860f-23f5-4f21-80c7-790b1ab1234d'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p><a name="e9db860f-23f5-4f21-80c7-790b1ab1234d"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="81360834-6afe-43b5-9a61-c90f9a75ec16"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="07ea9b14-8f2b-4ab8-ae90-c91917742a76"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="8fd7590e-6680-4c85-895e-d1234801b9b7"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="15c3a9db-3e64-491f-bed1-72144edaae09"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="93acab84-7de2-436e-94ac-c6a91e5b7b8e"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#208eb020-a09e-4794-ac47-d48b3c5513ea'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="208eb020-a09e-4794-ac47-d48b3c5513ea"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#73c65bf4-7704-41c7-8ad8-bd787d7bc4ff">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="63924b6a-47c8-4857-b22e-d759c3909045"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="983c626c-f655-4eb9-8f60-5078df5236d9"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="d3275aab-7668-4c88-9efb-31b1969a8ba1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="4dbd049c-6358-41c0-a2ba-54ecda053ee5"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="a4909dbf-64f3-442f-9c20-c51b72d04e2a"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="7888dff8-fde3-4db7-8385-2f29ac720ea5"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#faf96493-b9d7-41bb-abdd-338745feb165'>Initialize</a></td><td style='width:75%' class='def'><p><a name="faf96493-b9d7-41bb-abdd-338745feb165"></a></p>

<h3>Initialize (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize the specified parent.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="d6b44374-a5b5-4b7c-a906-e06207e9bfc3"></a>
Parent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The initialize.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d16b667-5c44-4188-bb4a-1d16dfef2d8a'>FindShape</a></td><td style='width:75%' ><p><a name="4d16b667-5c44-4188-bb4a-1d16dfef2d8a"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds a given shape by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="1659a517-34c1-4847-906f-c42cdccc59aa"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoShape</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbd3977d-3a47-4968-9b5c-fe023cf14b8d'>RecalculateGroupBounds</a></td><td style='width:75%' class='def'><p><a name="bbd3977d-3a47-4968-9b5c-fe023cf14b8d"></a></p>

<h3>RecalculateGroupBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the group bounds to encompass every <code>KimonoShape</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fcd080e-7f08-4b8c-9628-33788978572c'>ReturnToSketch</a></td><td style='width:75%' ><p><a name="3fcd080e-7f08-4b8c-9628-33788978572c"></a></p>

<h3>ReturnToSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns to base parent <code>KimonoSketch</code> for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#075329a1-5fd9-4d82-b2be-7e68f1109105'>SelectShape</a></td><td style='width:75%' class='def'><p><a name="075329a1-5fd9-4d82-b2be-7e68f1109105"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="437e058c-c9f5-41d4-aecf-52133609ce27"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12e1574c-af50-4afe-85b7-9db25e81a364'>RecalculateLayerDepths</a></td><td style='width:75%' ><p><a name="12e1574c-af50-4afe-85b7-9db25e81a364"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8082bac8-eb00-44f1-aa5e-077d4055b8fd'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="8082bac8-eb00-44f1-aa5e-077d4055b8fd"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35306da0-0529-4a29-8c99-b644cd7eab5a'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p><a name="35306da0-0529-4a29-8c99-b644cd7eab5a"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9a16141-351e-4c7c-8193-0dc1db098557'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p><a name="e9a16141-351e-4c7c-8193-0dc1db098557"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9906a97e-3de8-477a-92ff-13202fdcfeb1'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="9906a97e-3de8-477a-92ff-13202fdcfeb1"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80c0efb4-3c60-4ab3-86e4-62b8376d3cc3'>AlignAllTop</a></td><td style='width:75%' class='def'><p><a name="80c0efb4-3c60-4ab3-86e4-62b8376d3cc3"></a></p>

<h3>AlignAllTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#733caf48-028b-40b8-9e7b-b0b6a91a6f07'>AlignAllBottom</a></td><td style='width:75%' ><p><a name="733caf48-028b-40b8-9e7b-b0b6a91a6f07"></a></p>

<h3>AlignAllBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e1bb70e-9bc9-4337-8143-44835754cbfe'>AlignAllLeft</a></td><td style='width:75%' class='def'><p><a name="8e1bb70e-9bc9-4337-8143-44835754cbfe"></a></p>

<h3>AlignAllLeft ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30be2817-02a6-47ef-88e7-eb32d02f7292'>AlignAllRight</a></td><td style='width:75%' ><p><a name="30be2817-02a6-47ef-88e7-eb32d02f7292"></a></p>

<h3>AlignAllRight ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf3b7d1c-db19-411d-b575-22cf1405e8d7'>AlignAllCenter</a></td><td style='width:75%' class='def'><p><a name="bf3b7d1c-db19-411d-b575-22cf1405e8d7"></a></p>

<h3>AlignAllCenter ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Centers all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cc1a7d6-4b49-46a9-be02-851997179248'>AlignAllCenterHorizontal</a></td><td style='width:75%' ><p><a name="8cc1a7d6-4b49-46a9-be02-851997179248"></a></p>

<h3>AlignAllCenterHorizontal ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center horizontal all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4876602-635c-4382-aef2-eb8150a18761'>AlignAllCenterVertical</a></td><td style='width:75%' class='def'><p><a name="c4876602-635c-4382-aef2-eb8150a18761"></a></p>

<h3>AlignAllCenterVertical ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center vertical all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bb2555d-001d-409b-b847-7ae4d9a6e7e4'>DeleteColor</a></td><td style='width:75%' ><p><a name="2bb2555d-001d-409b-b847-7ae4d9a6e7e4"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="2ae1781a-f5db-4b30-88fc-8ab810faf4c6"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1058db67-72b3-4d99-aee8-b860185e569e'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="1058db67-72b3-4d99-aee8-b860185e569e"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="c2aff6f9-101c-43b7-970b-8025fe6bed43"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe00c1f1-70e4-4464-b70c-de1ee1895d25'>AddShape</a></td><td style='width:75%' ><p><a name="fe00c1f1-70e4-4464-b70c-de1ee1895d25"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoShape</code> to the group if it isn't already a part of the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="75f9bffd-03be-470f-8a95-6c810c9693ab"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b05109bc-cbe6-475e-9740-5c2c4f9ee989'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="b05109bc-cbe6-475e-9740-5c2c4f9ee989"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e5f9a52-3fcf-4660-8c17-6fffb40e6bd6'>RemoveShape</a></td><td style='width:75%' ><p><a name="0e5f9a52-3fcf-4660-8c17-6fffb40e6bd6"></a></p>

<h3>RemoveShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given <code>KimonoShape</code> from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="5ba80294-4161-4870-ae20-7cbcaa38da2a"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d578adcf-ac5c-449d-a59f-5a4f902b0806'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="d578adcf-ac5c-449d-a59f-5a4f902b0806"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5c59818-7dec-43c1-a0d7-921b0675af1b'>ShapeInGroup</a></td><td style='width:75%' ><p><a name="e5c59818-7dec-43c1-a0d7-921b0675af1b"></a></p>

<h3>ShapeInGroup (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given <code>KimonoShape</code> is a part of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="a8df0320-1694-4a8f-97d7-e54e5f19a08b"></a>
The <code>KimonoShape</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in shape is in the group, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4613fcb9-113b-485c-b219-2149f64a0608'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="4613fcb9-113b-485c-b219-2149f64a0608"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f96e9631-b26a-41cd-b600-336b5d25278a'>GroupShapes</a></td><td style='width:75%' ><p><a name="f96e9631-b26a-41cd-b600-336b5d25278a"></a></p>

<h3>GroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#526f0ae9-8499-491d-8279-7ae71f754e5f'>GroupShapes</a></td><td style='width:75%' class='def'><p><a name="526f0ae9-8499-491d-8279-7ae71f754e5f"></a></p>

<h3>GroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="dc5e123a-f4dd-47aa-bf79-de068fbf9c43"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db9a8a0c-8444-4216-9a46-6953bcf9caeb'>GroupShapes</a></td><td style='width:75%' ><p><a name="db9a8a0c-8444-4216-9a46-6953bcf9caeb"></a></p>

<h3>GroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="6843de42-d706-4695-afac-70406b04f90a"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8892297-e09c-4ab7-a74a-7c4088a08e12'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="d8892297-e09c-4ab7-a74a-7c4088a08e12"></a></p>

<h3>UngroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#427f7f70-68d8-4492-86fc-d22fa86ab535'>UngroupShapes</a></td><td style='width:75%' ><p><a name="427f7f70-68d8-4492-86fc-d22fa86ab535"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="10077f1d-783e-4e09-96e7-527ff4a87b5f"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9823adec-df44-42e8-97b4-c376c37a2edb'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="9823adec-df44-42e8-97b4-c376c37a2edb"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="f5c1db32-3806-4c07-9d3b-46d634320a1a"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57f2885b-dffd-4d63-9178-d50df276a8ba'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="57f2885b-dffd-4d63-9178-d50df276a8ba"></a></p>

<h3>DuplicateShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in a selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecd49a6e-4c7c-4d1f-aaf0-13453998c433'>DuplicateShapes</a></td><td style='width:75%' class='def'><p><a name="ecd49a6e-4c7c-4d1f-aaf0-13453998c433"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="76d18f7b-48d7-425c-8127-c22483d96636"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69524d8a-235c-4785-ab49-20e8efcbc828'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="69524d8a-235c-4785-ab49-20e8efcbc828"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="49097bff-c6b5-4655-a45a-d2136348fc70"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#feff3d7d-3484-4daa-add4-32a34f23092e'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="feff3d7d-3484-4daa-add4-32a34f23092e"></a></p>

<h3>DeleteShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#810c407a-4159-476f-ae99-212cafb8a789'>DeleteShapes</a></td><td style='width:75%' ><p><a name="810c407a-4159-476f-ae99-212cafb8a789"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="3a37d260-5715-49f1-b797-64d454b38250"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7d6ba4f-e43e-474f-90dd-6099b1a47869'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="a7d6ba4f-e43e-474f-90dd-6099b1a47869"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="3e3a98b4-f6ac-44de-af85-848d1f02a387"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa5897b0-7bb7-4934-9583-18e7a6748f42'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="aa5897b0-7bb7-4934-9583-18e7a6748f42"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale adjustments to all <code>KimonoShapes</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#569ba385-f7ed-4509-bd39-3a0a3a20281a'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="569ba385-f7ed-4509-bd39-3a0a3a20281a"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="17a645cf-1e1d-4925-9c59-92969a208699"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7dcba69-34d0-4df4-8746-cc7c9a35aee2'>RemoveProperty</a></td><td style='width:75%' ><p><a name="e7dcba69-34d0-4df4-8746-cc7c9a35aee2"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="b2fc0e42-a361-4a3c-a3a9-2c897e2659d4"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f15ffe8-f22c-44f7-a4a1-c406cac3fb65'>ToPath</a></td><td style='width:75%' class='def'><p><a name="1f15ffe8-f22c-44f7-a4a1-c406cac3fb65"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the group of shapes to a path.</p>

<h4>Returns</h4>

<p>The group of shapes as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8699353a-485a-4178-bb12-5f217d469858'>Draw</a></td><td style='width:75%' ><p><a name="8699353a-485a-4178-bb12-5f217d469858"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw all the <code>KimonoShapes</code> that are part of this group into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="14fc616a-b92c-4981-a54d-3028e130b85b"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5f1ab11-41ec-452e-9a6a-56fa2dadfa70'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="c5f1ab11-41ec-452e-9a6a-56fa2dadfa70"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e803bf5-bcc2-4b2f-ae6b-16ad82e50474'>EndEditing</a></td><td style='width:75%' ><p><a name="1e803bf5-bcc2-4b2f-ae6b-16ad82e50474"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d67ac463-e145-4d07-8ac6-e8e591272c7a'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="d67ac463-e145-4d07-8ac6-e8e591272c7a"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3cd65d2f-80d8-4518-ba15-c2f30994fa2b"></a>
The <code>SKPoint</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the point was in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cc2104d-31e3-498e-a557-285b43c41918'>DragBounds</a></td><td style='width:75%' ><p><a name="2cc2104d-31e3-498e-a557-285b43c41918"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="eba94ab8-eb12-4bc4-a810-2ea84f537cf1"></a>
The new location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9df3a597-a888-4a05-b5e7-468905c6a533'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="9df3a597-a888-4a05-b5e7-468905c6a533"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Update the bouds of this group when they have changed from either a move or a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89cd8f62-7550-42ca-bfba-e5ef4dc5b8f9'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="89cd8f62-7550-42ca-bfba-e5ef4dc5b8f9"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c97fdb8-65c9-4cd0-9a33-2e40c30eba24'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="8c97fdb8-65c9-4cd0-9a33-2e40c30eba24"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4824058c-90c0-47a6-b7b3-cc846d10dbcf'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="4824058c-90c0-47a6-b7b3-cc846d10dbcf"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17f284ed-3a7b-498b-a537-ed5f19472d0c'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="17f284ed-3a7b-498b-a537-ed5f19472d0c"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="64a5f62d-c51c-41a0-bc67-22037906efb0"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7267b7e7-9af9-40fd-9a08-2f6698663eb8'>ToCode</a></td><td style='width:75%' ><p><a name="7267b7e7-9af9-40fd-9a08-2f6698663eb8"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="1dd681a6-0396-4a0d-aa4f-89b625f24826"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8b699d06-38b3-4d92-b57c-514d72bdc51a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="91273e59-8dcf-4458-a372-8e454eef4f80"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6640a80-f702-4761-a4c5-67234a6c4d41'>RelinkShape</a></td><td style='width:75%' class='def'><p><a name="e6640a80-f702-4761-a4c5-67234a6c4d41"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="1b42dabb-0aef-49ef-944a-3fc5773c287f"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5986ab34-87b6-4b85-9065-f582fa2bfb21'>Clone</a></td><td style='width:75%' ><p><a name="5986ab34-87b6-4b85-9065-f582fa2bfb21"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9570ee33-c139-4a43-8e1c-f4525502c05f'>ToolDown</a></td><td style='width:75%' class='def'><p><a name="9570ee33-c139-4a43-8e1c-f4525502c05f"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the group's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="fbf8c011-b48c-47ee-898c-6dfdaf56efc7"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="442e3e81-415d-4cd2-b8ac-4bf462b59afc"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="292952dc-c4af-4c08-a516-390740063d9e"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="4d0e08b1-d1ef-4316-a980-1be7d44fc592"></a>
##KimonoShapeGroupType

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#dea69333-014a-4fda-853b-69c17d138241'>Selection</a></td><td style='width:75%' ><p><a name="dea69333-014a-4fda-853b-69c17d138241"></a>
<b>Selection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a current active selection.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aba38886-d5a1-45f7-b788-3b649cd0e0e2'>DragSelect</a></td><td style='width:75%' class='def'><p><a name="aba38886-d5a1-45f7-b788-3b649cd0e0e2"></a>
<b>DragSelect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a drag to select selection that is underway.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c3f139b-5c59-4b5e-91c9-7ac7253d9623'>Collection</a></td><td style='width:75%' ><p><a name="0c3f139b-5c59-4b5e-91c9-7ac7253d9623"></a>
<b>Collection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a collection of shape that have been grouped together and are treated as a single object in the editor.</p>
</td></tr></table></p>


---

<a name="f0d46ca4-d194-4189-9a83-b3d627fb35a7"></a>
##KimonoShapeLine

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a line on the design surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3f295479-74bf-4a72-bfe0-f35ef8616d91'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="3f295479-74bf-4a72-bfe0-f35ef8616d91"></a></p>

<h3>KimonoShapeLine ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0d46ca4-d194-4189-9a83-b3d627fb35a7">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66c3b673-3c44-4155-ab74-47747e1270f1'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p><a name="66c3b673-3c44-4155-ab74-47747e1270f1"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0d46ca4-d194-4189-9a83-b3d627fb35a7">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="dc5bd990-fe70-4f28-aa29-65598b55b1f2"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="06ffe865-4317-4722-81e5-0cf62b0bd32f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f7ace621-9c33-4144-adb0-e11c7da3b442"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="5ac577b5-383c-45bf-b16b-5360b7b6a418"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98435276-b7b3-43ce-ada0-773ed7612cf2'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="98435276-b7b3-43ce-ada0-773ed7612cf2"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0d46ca4-d194-4189-9a83-b3d627fb35a7">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="e7937004-7040-43e7-a2f5-209e62d0528c"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="cadb3b0a-af32-4805-b291-77c8c34f8e49"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="47ef9ad0-3931-4021-ac98-eefbba32370f"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a3ee6610-bc32-4769-abad-62a0891cf074"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="447f2245-e59d-4bec-91f2-94bf56d8f653"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b550dfd1-306a-4597-9e1f-7c8b803bf411'>Initialize</a></td><td style='width:75%' class='def'><p><a name="b550dfd1-306a-4597-9e1f-7c8b803bf411"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66a108d4-1a01-4186-8549-820fba8288b5'>ToPath</a></td><td style='width:75%' ><p><a name="66a108d4-1a01-4186-8549-820fba8288b5"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17ba7f3c-bb77-47e0-b87a-a0dbb62b0614'>Draw</a></td><td style='width:75%' class='def'><p><a name="17ba7f3c-bb77-47e0-b87a-a0dbb62b0614"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the line into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="e0853734-8d36-430c-8358-93bf1598c9f7"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57a1e6c2-d748-446b-8a57-fb7d67f1f09f'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="57a1e6c2-d748-446b-8a57-fb7d67f1f09f"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5168d84f-365f-4084-a3e5-65e9c03b32fa'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="5168d84f-365f-4084-a3e5-65e9c03b32fa"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#335d9814-afe1-4266-a214-8eb9b74c2592'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="335d9814-afe1-4266-a214-8eb9b74c2592"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d004a186-bb8f-4da4-8f39-03ea67ffb6c2'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="d004a186-bb8f-4da4-8f39-03ea67ffb6c2"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="25c8543d-8937-47e0-82fa-6a6c3516aeaa"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3c7c247-36f6-404e-bf22-fc77eb54fe35'>ToCode</a></td><td style='width:75%' ><p><a name="f3c7c247-36f6-404e-bf22-fc77eb54fe35"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="4124695d-ae62-4d23-90ac-3ec328f7d39c"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e52606ee-3093-4d21-9381-a55d9abb33d9"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2e117b13-4032-4585-8ce5-7820401908d2"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b129705-1558-4a99-86e0-ee54bd9212b3'>Clone</a></td><td style='width:75%' class='def'><p><a name="1b129705-1558-4a99-86e0-ee54bd9212b3"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoLine</code>.</p>
</td></tr></table></p>


---

<a name="ab1de522-c4bb-4664-8b3d-d191b743fb8a"></a>
##KimonoShapeOval

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws an oval into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9303039d-7b48-4b76-9b01-c35d5b254e45'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="9303039d-7b48-4b76-9b01-c35d5b254e45"></a></p>

<h3>KimonoShapeOval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ab1de522-c4bb-4664-8b3d-d191b743fb8a">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a8367aa-c9e8-4ee9-af6c-eb40824725cd'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p><a name="5a8367aa-c9e8-4ee9-af6c-eb40824725cd"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ab1de522-c4bb-4664-8b3d-d191b743fb8a">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f5349474-165f-4cdb-963f-afbbf3d94b05"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="0a124e3d-8a72-4ea7-9562-e15cf16a6946"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f34d00d7-5597-4cc3-85ca-3372bf29cd27"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="43b6f552-a5cb-43ad-88cc-20f9179c523f"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3d0bb41-e14d-4962-8b37-50bc23c5296f'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="a3d0bb41-e14d-4962-8b37-50bc23c5296f"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ab1de522-c4bb-4664-8b3d-d191b743fb8a">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="7bd26fbf-6c16-49d7-9ad6-6de17a64fa9c"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="506e8485-4fd3-463b-9bc6-4f7e5aedfd2a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="64478bdf-9abb-49cb-8295-0d637596137e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="46de711a-3c16-423f-add4-a228c4216ac7"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="3c4b42a7-44ae-4aaf-a38e-1f9521f566f8"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#338953cd-ee30-4374-bdcf-b67277d98aba'>Initialize</a></td><td style='width:75%' class='def'><p><a name="338953cd-ee30-4374-bdcf-b67277d98aba"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8db5b46-905a-4314-84a9-7c4918f2760b'>ToPath</a></td><td style='width:75%' ><p><a name="c8db5b46-905a-4314-84a9-7c4918f2760b"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6bba918-19d1-42c3-a484-8104f6acf1dc'>Draw</a></td><td style='width:75%' class='def'><p><a name="d6bba918-19d1-42c3-a484-8104f6acf1dc"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw the oval into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="b73d9fee-c03e-43e9-9447-f46698438321"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e779666b-d4d8-46ad-8350-d1db2f73c2c0'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="e779666b-d4d8-46ad-8350-d1db2f73c2c0"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5c7162f-d268-4d1e-bcc3-16b7bf3e645c'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="b5c7162f-d268-4d1e-bcc3-16b7bf3e645c"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4715dafa-1322-4dad-8480-8146128679d8'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="4715dafa-1322-4dad-8480-8146128679d8"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9c092cf-0c60-47c2-86a4-52d8e28e7301'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="f9c092cf-0c60-47c2-86a4-52d8e28e7301"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="25b45a0b-3f9c-4d6b-bc34-118a84f7529d"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3294c534-acf0-40ea-a3d9-31c19179f405'>ToCode</a></td><td style='width:75%' ><p><a name="3294c534-acf0-40ea-a3d9-31c19179f405"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="2c6bcf48-ff86-4580-a661-cf27ccdbce07"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="7e6d7917-e104-4f45-b76b-453aa6a54700"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="356b5a47-b732-45a9-ba18-2d567dad1129"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#477c6172-a491-4b23-9043-f7d79c6384b6'>Clone</a></td><td style='width:75%' class='def'><p><a name="477c6172-a491-4b23-9043-f7d79c6384b6"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoOval</code>.</p>
</td></tr></table></p>


---

<a name="2f391a74-3808-4dbe-a20c-9d80e7506e3c"></a>
##KimonoShapePolygon

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a multi-sided polygon into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7a8d3ac1-bf6d-48dc-88d0-61b7b4a12c6b'>NumberOfSides</a></td><td style='width:75%' ><p><a name="7a8d3ac1-bf6d-48dc-88d0-61b7b4a12c6b"></a></p>

<h3>NumberOfSides</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of sides.</p>

<h4>Return Value</h4>

<p>The number of sides.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a643aa2-9aea-411b-b0d1-dff428a7eb8e'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="3a643aa2-9aea-411b-b0d1-dff428a7eb8e"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c58c19fb-ff22-4a3b-b18a-7a1ebe36f8d3'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="c58c19fb-ff22-4a3b-b18a-7a1ebe36f8d3"></a></p>

<h3>KimonoShapePolygon ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2f391a74-3808-4dbe-a20c-9d80e7506e3c">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a155973f-2efb-4e8c-809e-71b97eb9daf1'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p><a name="a155973f-2efb-4e8c-809e-71b97eb9daf1"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2f391a74-3808-4dbe-a20c-9d80e7506e3c">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="5e65bb2e-608c-4897-bd6e-cff6590cba90"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e697cd36-c823-4282-bc85-cf21aa67f08c"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="74474828-817d-4744-92e5-507f93a01208"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1f736cae-4be0-45ab-9110-575000dd56ea"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2962ef2f-61b0-4198-81ba-f6575233e954'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="2962ef2f-61b0-4198-81ba-f6575233e954"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2f391a74-3808-4dbe-a20c-9d80e7506e3c">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="3fbe9872-fdd6-492d-a623-b4a080cfcff1"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="af219f8b-f431-4621-8fda-b0b346d14ee3"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d380eba4-5426-479f-b487-d791c11454eb"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b407fbfc-e860-4819-9e54-31ae95ececc5"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="e1356e0c-4c71-4e27-82e4-b469cc49e3f2"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f21ba4f3-e880-46fe-9a5b-cc0a9a557475'>Initialize</a></td><td style='width:75%' class='def'><p><a name="f21ba4f3-e880-46fe-9a5b-cc0a9a557475"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72363558-45be-4037-8831-f597c66a2b20'>MakeSidePoints</a></td><td style='width:75%' ><p><a name="72363558-45be-4037-8831-f597c66a2b20"></a></p>

<h3>MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="b321b889-76ca-4a8a-bf58-ba99579118c4"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="bb151ff3-7fb6-4c82-a9ab-11e6c308841b"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="4b40d49c-aacf-47fc-8a4d-6998eb649738"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="fa502a23-a96f-42e1-ac89-b3ae67fe6c12"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f84766a2-3989-4f38-920e-b1144a0cb91f'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="f84766a2-3989-4f38-920e-b1144a0cb91f"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="23fe070e-507a-44c9-bbda-3f3da4928bf9"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fdabf540-f5a5-47ba-a4af-038e54c51e79'>ToPath</a></td><td style='width:75%' ><p><a name="fdabf540-f5a5-47ba-a4af-038e54c51e79"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c80da71-04f3-4a0e-b977-776c0009b5dc'>Draw</a></td><td style='width:75%' class='def'><p><a name="9c80da71-04f3-4a0e-b977-776c0009b5dc"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the polygon into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="3f01ee1a-896b-42b4-a9a4-c3d7fdb23c4f"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab26b5e3-d8d2-4eae-9bee-7cae97308816'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="ab26b5e3-d8d2-4eae-9bee-7cae97308816"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c89a767-0a62-46ab-b8d2-4c55d0f7758a'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="9c89a767-0a62-46ab-b8d2-4c55d0f7758a"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ecf6391-2d3e-4464-8f23-da022a3b69b4'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="0ecf6391-2d3e-4464-8f23-da022a3b69b4"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71ccef0f-ba52-4e60-9cf0-f184b8032c97'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="71ccef0f-ba52-4e60-9cf0-f184b8032c97"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="362464cb-251a-4143-bcc7-a88eaa249a68"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efaae377-38c7-4a9e-950b-5aa08d8bce91'>ToCode</a></td><td style='width:75%' ><p><a name="efaae377-38c7-4a9e-950b-5aa08d8bce91"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="65771da7-0ed2-4f96-bff3-678bae29ff01"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="820b2014-5255-4f46-bb0f-6cde0ccd43f1"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2ff4a7dd-49b9-4f6f-a63f-644e9d52d958"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf18c23a-d999-4037-8f7c-4827b5cae58d'>Clone</a></td><td style='width:75%' class='def'><p><a name="bf18c23a-d999-4037-8f7c-4827b5cae58d"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoPloygon</code>.</p>
</td></tr></table></p>


---

<a name="06f5b5d3-c112-493c-9bd6-9fd49b8fe23b"></a>
##KimonoShapeRect

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#18e1e45c-2083-43da-b0af-7792f714cb24'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="18e1e45c-2083-43da-b0af-7792f714cb24"></a></p>

<h3>KimonoShapeRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f5b5d3-c112-493c-9bd6-9fd49b8fe23b">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1c6fef5-4175-4649-b03c-4e03cac635b7'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p><a name="e1c6fef5-4175-4649-b03c-4e03cac635b7"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f5b5d3-c112-493c-9bd6-9fd49b8fe23b">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="0dff7533-e61f-45dc-9b83-1b0cb6cd4809"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="02081c77-c03b-4bb9-a72b-d2ae8742f7ff"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2cbe4bdb-c95e-4295-801e-5ec9e9d92ae3"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bbc15c2b-ddaa-4a54-8e8c-5a6d387dd930"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58b7510c-0079-4fe4-a810-146601c36f4c'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="58b7510c-0079-4fe4-a810-146601c36f4c"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f5b5d3-c112-493c-9bd6-9fd49b8fe23b">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="64990049-7ef5-4d51-9a42-8db9c9d68721"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="2fac4a68-9b13-4fc7-a3b0-c0240bcdab31"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b2b4f087-5615-4b6d-b43b-f7a8841288d2"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e94077e0-281f-4de2-9096-c6cb69ed88b9"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="c76f7cd2-f525-489f-a87e-da0d824ae7da"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e390b84d-61b9-4643-be97-915c33210e6d'>Initialize</a></td><td style='width:75%' class='def'><p><a name="e390b84d-61b9-4643-be97-915c33210e6d"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0e2acb7-cee2-419e-96b4-d3e622fac671'>ToPath</a></td><td style='width:75%' ><p><a name="c0e2acb7-cee2-419e-96b4-d3e622fac671"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aaa4ebb8-3120-495f-8f41-584ce7b55fcb'>Draw</a></td><td style='width:75%' class='def'><p><a name="aaa4ebb8-3120-495f-8f41-584ce7b55fcb"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="d7e93024-879a-4e84-945d-fc15b4af7952"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#615fc111-b679-4342-8b9e-b28f245cfa02'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="615fc111-b679-4342-8b9e-b28f245cfa02"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d28ce06c-004e-46f0-8dd2-3f6cab74dc69'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="d28ce06c-004e-46f0-8dd2-3f6cab74dc69"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa26eef6-bb95-4800-bba7-42a29a42ca71'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="aa26eef6-bb95-4800-bba7-42a29a42ca71"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e01d6481-93a9-485c-b9d2-1de18167ccec'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="e01d6481-93a9-485c-b9d2-1de18167ccec"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="22ac8725-694d-46b2-9fc4-97bd175fb819"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22f05a64-5940-485d-95ae-00c22f4b04a3'>ToCode</a></td><td style='width:75%' ><p><a name="22f05a64-5940-485d-95ae-00c22f4b04a3"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="fb0e2f7d-062e-4ead-90ed-80749d85f838"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="3d2f246a-5a99-44fe-bb1e-591435b9827e"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="082c5608-934c-4d19-8bf6-2bddc1fe11f9"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60980ffe-739e-47fc-bfcb-59e1d668e892'>Clone</a></td><td style='width:75%' class='def'><p><a name="60980ffe-739e-47fc-bfcb-59e1d668e892"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="ae7b85e3-1748-4fac-9f6f-9f9c01613eba"></a>
##KimonoShapeRoundRect

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a rounded rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7bf12508-55e7-4ed7-a59c-96fa71bb8ab8'>CornerRadius</a></td><td style='width:75%' ><p><a name="7bf12508-55e7-4ed7-a59c-96fa71bb8ab8"></a></p>

<h3>CornerRadius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the corner radius.</p>

<h4>Return Value</h4>

<p>The corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a23eb6b0-b08b-4c29-a771-b51d0d891322'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="a23eb6b0-b08b-4c29-a771-b51d0d891322"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ef451709-bdf9-4c4a-bb30-2fc82c12a550'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="ef451709-bdf9-4c4a-bb30-2fc82c12a550"></a></p>

<h3>KimonoShapeRoundRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae7b85e3-1748-4fac-9f6f-9f9c01613eba">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb0190b2-561c-4815-858b-475642fe2257'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="eb0190b2-561c-4815-858b-475642fe2257"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae7b85e3-1748-4fac-9f6f-9f9c01613eba">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f9b20205-f1bf-4ba2-a328-324f17203718"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="7c0a6c71-dc31-49d8-9a80-7ee3bb70b631"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d6f7213c-be45-4b76-a3e9-3a93bf7434b8"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b807b986-fb76-4f0c-8647-2b0b98f40092"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dcedbc4-0183-467f-9ac9-4d7c93eee490'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="3dcedbc4-0183-467f-9ac9-4d7c93eee490"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae7b85e3-1748-4fac-9f6f-9f9c01613eba">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="d6e0953c-6ca5-4c8d-a0a3-4c263d4b6a56"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="8860f36b-228c-4e08-b74d-59e18bedbd3e"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8044a0bd-7a53-4c2f-b571-3b81805b08ad"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="355e49c6-10fa-485f-b20e-76d979e597ed"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="b96a8a51-cbc1-4945-87f1-80f85eab6610"></a>
Corner radius.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7dcb6140-2b3f-4502-a9d6-1bb5bf8941cc'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="7dcb6140-2b3f-4502-a9d6-1bb5bf8941cc"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae7b85e3-1748-4fac-9f6f-9f9c01613eba">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="1c18fa3b-d989-4d35-a861-03cce08007be"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="eac1003f-09a1-4447-941e-ff1bb15de493"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="10faee2e-8304-4567-9603-3cc55c7043fa"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="090568c1-1eae-43ff-aa49-1b1597efc0b6"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="49c6dd1f-dad7-4105-b5f5-4c221f2c5308"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f6fe60a-0447-41e3-9807-0514e029ee6b'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="1f6fe60a-0447-41e3-9807-0514e029ee6b"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae7b85e3-1748-4fac-9f6f-9f9c01613eba">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="4e8dbe3a-b5d1-47e3-a4d0-95643c833977"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e9b45aee-d971-4bea-aa53-9b7fa37ef437"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="931fe4c9-0df2-43ca-bae5-c4134d6dca8e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f2d071e1-5c47-43ad-af3f-b1030a293db2"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="6fd14b79-c854-4f5e-bfe9-47ac3076a361"></a>
Corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="646d8241-b639-4594-b3ba-74b78d5545c3"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5231882-400b-462f-81cf-fae1d5f5b8c9'>Initialize</a></td><td style='width:75%' class='def'><p><a name="f5231882-400b-462f-81cf-fae1d5f5b8c9"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5a37e84-ee43-4b49-9268-06f77ead4515'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="d5a37e84-ee43-4b49-9268-06f77ead4515"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="16821d5c-f578-49c6-a14a-9bf3c0c085e9"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc2d29c2-10d4-448b-aeaf-f6e949f187ec'>ToPath</a></td><td style='width:75%' class='def'><p><a name="fc2d29c2-10d4-448b-aeaf-f6e949f187ec"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a4471b1-d027-4450-9fbb-7643985e445b'>Draw</a></td><td style='width:75%' ><p><a name="2a4471b1-d027-4450-9fbb-7643985e445b"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the round rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="f3354296-41c1-479e-90c8-97ddc73213ff"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38eb3259-8116-414a-b1dc-6117241f342b'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="38eb3259-8116-414a-b1dc-6117241f342b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff0397d5-3847-4ed4-a338-2e22944b0c12'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="ff0397d5-3847-4ed4-a338-2e22944b0c12"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22e58819-74f8-46a0-94f8-9a553e8eb540'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="22e58819-74f8-46a0-94f8-9a553e8eb540"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c43d05e6-5f34-47ab-bdf7-baf858f63acb'>ToCSharp</a></td><td style='width:75%' ><p><a name="c43d05e6-5f34-47ab-bdf7-baf858f63acb"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="04700585-3d72-4cc1-a4c4-31a4a32c5da2"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0af49df-4376-4d55-adb6-f7e6293e652a'>ToCode</a></td><td style='width:75%' class='def'><p><a name="c0af49df-4376-4d55-adb6-f7e6293e652a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="9deb5559-cc6a-4f98-af79-2674fc32f63c"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="1af3651a-e65c-4dc0-aadd-cfd064a93285"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b8d4aab0-25c2-4ca6-a27e-8fb8373919b5"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df51e551-f83f-40cb-a140-8107a3324f5d'>Clone</a></td><td style='width:75%' ><p><a name="df51e551-f83f-40cb-a140-8107a3324f5d"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeRoundRect</code>.</p>
</td></tr></table></p>


---

<a name="399f89e2-92e7-4ee5-bcb7-b7ead3240980"></a>
##KimonoShapeStar

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a multi-sided star shape into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d5d313f6-fd42-46ae-b285-60ad19128e75'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="d5d313f6-fd42-46ae-b285-60ad19128e75"></a></p>

<h3>NumberOfPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of points.</p>

<h4>Return Value</h4>

<p>The number of points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#895ff01f-8a82-43a7-ae87-c5f5db655573'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="895ff01f-8a82-43a7-ae87-c5f5db655573"></a></p>

<h3>SkipPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the skip points.</p>

<h4>Return Value</h4>

<p>The skip points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa7055d9-9866-4d94-ba71-62a3cebcd666'>DepthOffset</a></td><td style='width:75%' ><p><a name="aa7055d9-9866-4d94-ba71-62a3cebcd666"></a></p>

<h3>DepthOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the depth offset for the individual points.</p>

<h4>Return Value</h4>

<p>The depth offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#819ea115-75c0-4a84-8c7d-5aa0c22f969a'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="819ea115-75c0-4a84-8c7d-5aa0c22f969a"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6ac7f648-fa1e-42e7-b16e-75114aa455d6'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="6ac7f648-fa1e-42e7-b16e-75114aa455d6"></a></p>

<h3>KimonoShapeStar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#399f89e2-92e7-4ee5-bcb7-b7ead3240980">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ac61057-ff04-44f6-a945-5650d2c6cabf'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p><a name="0ac61057-ff04-44f6-a945-5650d2c6cabf"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#399f89e2-92e7-4ee5-bcb7-b7ead3240980">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="1b4312d5-4ad3-4506-9f9e-8f19b57d3a30"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="3eb6d5bc-44bb-42cb-9a35-ac62d54c3851"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8aa5f6b9-bc8f-4af7-8a1c-e74598653c02"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="977fe7e9-342b-4e7d-9040-e801e0719c73"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#955900b8-eb6d-4904-8d36-ab7272e8b344'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="955900b8-eb6d-4904-8d36-ab7272e8b344"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#399f89e2-92e7-4ee5-bcb7-b7ead3240980">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="0e4624e4-aeca-40fb-b434-101de31e09e5"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e8b677e2-2005-405a-bac1-944ab3b5285d"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="71c5214c-77ed-40fc-bb4d-ff30ee55d77f"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="be549cdb-fb8c-41fb-8ac1-a3b6377c9c2a"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="44e0e34a-f500-4606-b38a-94c229dd6635"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db8ec26b-b2b2-48c6-bb7d-4313ca23c853'>Initialize</a></td><td style='width:75%' class='def'><p><a name="db8ec26b-b2b2-48c6-bb7d-4313ca23c853"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a348ab4-b2a2-418c-a289-7d910fdeb407'>MakeStarPoints</a></td><td style='width:75%' ><p><a name="0a348ab4-b2a2-418c-a289-7d910fdeb407"></a></p>

<h3>MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="24d205a4-386d-415b-bf29-57654aa6aff6"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="58a4f1c8-0718-46d3-b02e-592ee5a35d64"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="0e5bc4a0-935d-4bce-8912-05fb4ad6ba49"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="2e3e9300-ef36-47be-bac7-5c16c496120c"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22026bc5-7847-4f0b-a3ea-0bd932730941'>CalculateConcaveRadius</a></td><td style='width:75%' class='def'><p><a name="22026bc5-7847-4f0b-a3ea-0bd932730941"></a></p>

<h3>CalculateConcaveRadius (System.Int32, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Calculates the concave radius.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p><a name="a5b3566f-a7a5-4f98-9859-874ee6696dd3"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p><a name="1850b184-43ef-4bb0-8572-c4533e9a04d8"></a>
Skip.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The concave radius.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5678f10d-72dd-4ab7-9330-00e72cc2e2c2'>FindIntersection</a></td><td style='width:75%' ><p><a name="5678f10d-72dd-4ab7-9330-00e72cc2e2c2"></a></p>

<h3>FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean@, System.Boolean@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the intersection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p><a name="2e881b01-5c4e-4ca8-ba4b-624aff66ea67"></a>
P1.</p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p><a name="f842c5e1-ce09-4b8e-8ead-65f956a26f2f"></a>
P2.</p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p><a name="14a24d83-249d-4a2f-ad42-997ae8c01f0e"></a>
P3.</p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p><a name="b7297562-62db-418a-a13a-2f1e0e6f0c57"></a>
P4.</p>
</td></tr><tr><td style='width:25%' class='term'>lines_intersect</td><td style='width:75%' ><p><a name="76554033-8e1c-4751-b809-f4c6af049f76"></a>
If set to <code>true</code> lines intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>segments_intersect</td><td style='width:75%' class='def'><p><a name="84810ea4-1e31-43df-8723-2192c633bf54"></a>
If set to <code>true</code> segments intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>intersection</td><td style='width:75%' ><p><a name="85d005be-58cd-43ac-90fa-f5ca748535b8"></a>
Intersection.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p1</td><td style='width:75%' class='def'><p><a name="8641e37b-c7f9-492d-a127-c3aab828b870"></a>
Close p1.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p2</td><td style='width:75%' ><p><a name="ff76517e-177e-4ac1-baa8-79f9193d5325"></a>
Close p2.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6220733e-f83b-496c-8e76-bf604657b4a0'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="6220733e-f83b-496c-8e76-bf604657b4a0"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="49e0de31-3307-4d6d-89f2-fd3837634fa0"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab601d14-b1d2-418a-be95-bc0da98588ce'>ToPath</a></td><td style='width:75%' ><p><a name="ab601d14-b1d2-418a-be95-bc0da98588ce"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db27147d-f13f-405d-b7ed-a7a22b8daf8c'>Draw</a></td><td style='width:75%' class='def'><p><a name="db27147d-f13f-405d-b7ed-a7a22b8daf8c"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the star into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="9d00b658-85b2-4676-91bb-142c596137d0"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fc9e6fc-bbe7-4279-8bcb-9ffae6919e42'>ToVector</a></td><td style='width:75%' ><p><a name="6fc9e6fc-bbe7-4279-8bcb-9ffae6919e42"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the star into a vector.</p>

<h4>Returns</h4>

<p>The <code>KimonoShapeVector</code> version of the star.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71dd010e-4535-4b21-8b1b-99499b90e049'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="71dd010e-4535-4b21-8b1b-99499b90e049"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29ff2d0c-d7bd-4e2f-94e7-490aeb0ffa7e'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="29ff2d0c-d7bd-4e2f-94e7-490aeb0ffa7e"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47ae997a-256d-4c76-ac45-6bda1e15b4f8'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="47ae997a-256d-4c76-ac45-6bda1e15b4f8"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57ca88e4-4315-4f0f-9464-d33b2fe29a54'>ToCSharp</a></td><td style='width:75%' ><p><a name="57ca88e4-4315-4f0f-9464-d33b2fe29a54"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="3019c14e-c6ee-4f59-87b6-48f02a11e24c"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cffe06d7-0498-4621-88f7-993d59ee41fb'>ToCode</a></td><td style='width:75%' class='def'><p><a name="cffe06d7-0498-4621-88f7-993d59ee41fb"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="e0014c42-d650-4d5a-b20d-c82b90325542"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="ee0739e1-4964-476a-9045-ea572c6c12f2"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="3c938ce8-0c97-4b64-8930-d765f187a02a"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a056c5d8-16f4-41de-b9df-7f9d52c0b271'>Clone</a></td><td style='width:75%' ><p><a name="a056c5d8-16f4-41de-b9df-7f9d52c0b271"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeStar</code>.</p>
</td></tr></table></p>


---

<a name="16f42f46-baf6-492a-9577-9a20420a0099"></a>
##KimonoShapeState

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Holds the current state of a `KimonoShape` while it is being edited by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a6036ca0-763c-4dda-9ea9-93a070c7c0fe'>Unselected</a></td><td style='width:75%' ><p><a name="a6036ca0-763c-4dda-9ea9-93a070c7c0fe"></a>
<b>Unselected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is unselected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b80e6e2-7c18-44c9-b702-0fee749ca14f'>Selected</a></td><td style='width:75%' class='def'><p><a name="7b80e6e2-7c18-44c9-b702-0fee749ca14f"></a>
<b>Selected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2d1daee-e492-43f8-b105-a2c7c08b68f6'>Editing</a></td><td style='width:75%' ><p><a name="d2d1daee-e492-43f8-b105-a2c7c08b68f6"></a>
<b>Editing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03f5c0ff-8f43-43b3-86a1-363124276845'>Finalizing</a></td><td style='width:75%' class='def'><p><a name="03f5c0ff-8f43-43b3-86a1-363124276845"></a>
<b>Finalizing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is leaving the edit mode and needs to be completed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81033862-bcf9-40c5-b985-8620b0a7b0b7'>Constructing</a></td><td style='width:75%' ><p><a name="81033862-bcf9-40c5-b985-8620b0a7b0b7"></a>
<b>Constructing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the process of being built. For example, a set of shapes being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c522621c-b342-43b9-8213-ea8a2f9a0ef2'>Grouping</a></td><td style='width:75%' class='def'><p><a name="c522621c-b342-43b9-8213-ea8a2f9a0ef2"></a>
<b>Grouping</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being added to a group.</p>
</td></tr></table></p>


---

<a name="5a451a98-539b-4bd8-bbc8-9feaac4bdd4f"></a>
##KimonoShapeText

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a block of text into the Design Surface within the specifid bounds of this shape.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ed5fbfb5-553b-432b-9db9-89c97bd68b76'>Text</a></td><td style='width:75%' ><p><a name="ed5fbfb5-553b-432b-9db9-89c97bd68b76"></a></p>

<h3>Text</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text.</p>

<h4>Return Value</h4>

<p>The text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a20fa3d1-23bc-47cb-b190-9c1461221a37'>FontMetrics</a></td><td style='width:75%' class='def'><p><a name="a20fa3d1-23bc-47cb-b190-9c1461221a37"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0168ad16-7053-4078-9f65-748d93e9773a'>IsLinearText</a></td><td style='width:75%' ><p><a name="0168ad16-7053-4078-9f65-748d93e9773a"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2f90aae-c2bf-4ce7-b665-43e6299cae33'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="a2f90aae-c2bf-4ce7-b665-43e6299cae33"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81ca2662-bffb-4a3c-a498-d60edc045fb2'>StrikeThruText</a></td><td style='width:75%' ><p><a name="81ca2662-bffb-4a3c-a498-d60edc045fb2"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13067f75-7023-47a9-8e37-88933072fb8c'>TextAlign</a></td><td style='width:75%' class='def'><p><a name="13067f75-7023-47a9-8e37-88933072fb8c"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#491fce0e-b52a-4550-bd57-0f7cde826928'>TextEncoding</a></td><td style='width:75%' ><p><a name="491fce0e-b52a-4550-bd57-0f7cde826928"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be02eccc-2a02-4576-bcce-58499a2d2943'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="be02eccc-2a02-4576-bcce-58499a2d2943"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b89d4d2b-5b06-477e-b72c-40c7ec7a2804'>TextSize</a></td><td style='width:75%' ><p><a name="b89d4d2b-5b06-477e-b72c-40c7ec7a2804"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83f00f7c-0330-4417-8024-49294d7b06b9'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="83f00f7c-0330-4417-8024-49294d7b06b9"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f88c8307-655d-4e43-80c1-07cef5379a3c'>Typeface</a></td><td style='width:75%' ><p><a name="f88c8307-655d-4e43-80c1-07cef5379a3c"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#599e7207-961e-495f-81f6-69fec108e415'>FontFamilyName</a></td><td style='width:75%' class='def'><p><a name="599e7207-961e-495f-81f6-69fec108e415"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbfb490f-558b-48d5-98b1-7bb15f0228b9'>TypefaceStyle</a></td><td style='width:75%' ><p><a name="cbfb490f-558b-48d5-98b1-7bb15f0228b9"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bf28abb-2c86-45ed-b6a8-0d07e9388941'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="3bf28abb-2c86-45ed-b6a8-0d07e9388941"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5828d67f-3676-40b5-8a64-30530087789d'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="5828d67f-3676-40b5-8a64-30530087789d"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e847456c-4bd5-45bc-815d-15065248eaee'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="e847456c-4bd5-45bc-815d-15065248eaee"></a></p>

<h3>KimonoShapeText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beb53247-decb-41de-8abc-1cfb1e3e124f'>KimonoShapeText</a></td><td style='width:75%' class='def'><p><a name="beb53247-decb-41de-8abc-1cfb1e3e124f"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="06f83345-260e-473a-8f10-7e2c4eda6461"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="dcd2b787-66bd-401b-9141-233ab8bfb9c8"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="4e6b4359-c47e-4f2d-b7ca-fe93bb1619d0"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="69a82626-618f-4ccd-ac60-6f22927858d8"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d55da9b4-ee0f-403f-9e60-9384b19bee66'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="d55da9b4-ee0f-403f-9e60-9384b19bee66"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5a451a98-539b-4bd8-bbc8-9feaac4bdd4f">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="42f9fd91-fa0b-4798-a7df-db28e93f38ba"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6f7c68a4-8a2f-42f7-95c7-b2589c006a38"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="c392b2a6-b262-4637-841f-24b7edb043b5"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="d05ed0e2-5974-4fb2-8a04-e8eaed78a1b1"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="07547aef-22cc-40dd-bfc9-437b9f4c757a"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3195c07a-2d98-4034-a80d-911d654e83aa'>Initialize</a></td><td style='width:75%' class='def'><p><a name="3195c07a-2d98-4034-a80d-911d654e83aa"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01ba9938-adf2-463d-9159-89775fd5d746'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="01ba9938-adf2-463d-9159-89775fd5d746"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="e16d73d0-ad6b-4dd2-9335-59f8cfe9526a"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a0c0acf-8799-4f05-8a93-da499a94d952'>ToPath</a></td><td style='width:75%' class='def'><p><a name="1a0c0acf-8799-4f05-8a93-da499a94d952"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cae4b1f-c33c-4021-a7eb-054e4a7b8f66'>Draw</a></td><td style='width:75%' ><p><a name="2cae4b1f-c33c-4021-a7eb-054e4a7b8f66"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the text block into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="1a2ff318-32ee-48e3-891f-1497eaf3b636"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c658e9d-3c64-4ba5-a312-9ce01942ffc5'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="6c658e9d-3c64-4ba5-a312-9ce01942ffc5"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="85f17da5-7cfc-4112-bbcb-8cfe4de886f5"></a>
The <code>SKPoint</code> to adjust the bounds by.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: Changing the bounds of a text box should optionally scale the size of the text within.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6d2047b-9ee5-4017-8f1b-0f57f5eb9206'>DragBounds</a></td><td style='width:75%' ><p><a name="e6d2047b-9ee5-4017-8f1b-0f57f5eb9206"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3e58445c-5ceb-49c2-9f2f-463affc6efe5"></a>
The <code>SKPoint</code> with the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#141717ad-d380-422a-9c34-41262e616381'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="141717ad-d380-422a-9c34-41262e616381"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef648691-04d4-4ffa-a001-ee1d08cb201a'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="ef648691-04d4-4ffa-a001-ee1d08cb201a"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7f8fc64-91a7-401e-838e-288d0200ca80'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="b7f8fc64-91a7-401e-838e-288d0200ca80"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1534bcdd-6a3c-43bf-9c93-b14260c99a93'>ToCSharp</a></td><td style='width:75%' ><p><a name="1534bcdd-6a3c-43bf-9c93-b14260c99a93"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2733b8aa-51b6-47dc-b1a1-d4bc48843535"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c18b2d8c-a535-459a-b00c-bab9ce0761a4'>ToCode</a></td><td style='width:75%' class='def'><p><a name="c18b2d8c-a535-459a-b00c-bab9ce0761a4"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="2f3019dd-5721-46e9-8266-7225beb18a58"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="124403af-66d3-4d23-8fa5-a6a07bfcd330"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="59c8c3ed-df50-4660-8c59-a95176fc3653"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#491de0a0-f76f-4121-94fd-87445fe73796'>Clone</a></td><td style='width:75%' ><p><a name="491de0a0-f76f-4121-94fd-87445fe73796"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeText</code>.</p>
</td></tr></table></p>


---

<a name="84d13fb7-559b-49d1-8b42-9ca6b629e69e"></a>
##KimonoShapeTriangle

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Draws a triangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a9aba70c-dbd6-41c6-8e56-9ddea8c8d6cb'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="a9aba70c-dbd6-41c6-8e56-9ddea8c8d6cb"></a></p>

<h3>KimonoShapeTriangle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#84d13fb7-559b-49d1-8b42-9ca6b629e69e">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1340bade-ceb9-49f7-87cf-b71599620411'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p><a name="1340bade-ceb9-49f7-87cf-b71599620411"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#84d13fb7-559b-49d1-8b42-9ca6b629e69e">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="14909cf1-ecdf-4821-8085-71e8aad12a22"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="b2686508-9047-4694-9cb3-608767aaadd7"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="3343e7e6-d4b3-4b39-8c39-53b46c181b4e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="93906b71-9a0a-4dfe-ba14-302ab1daf51a"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0008b2d7-9959-469b-a59f-710b3bec3bd5'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="0008b2d7-9959-469b-a59f-710b3bec3bd5"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#84d13fb7-559b-49d1-8b42-9ca6b629e69e">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="5857cdf3-98ea-4910-bdd0-4a9f08923646"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="106e21d6-b515-4f07-ab2e-ef320a7ef79b"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="408424ff-aa1b-4fb6-bad2-a4d6cf9dd7a9"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b58fe8d2-c6d5-4bb3-a9e1-f325378ac279"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="2137c3c3-5996-4fb7-9809-fad014bb8253"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a711c8f7-7234-4152-9855-4b10fe2c23c2'>Initialize</a></td><td style='width:75%' class='def'><p><a name="a711c8f7-7234-4152-9855-4b10fe2c23c2"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa5cf801-03e2-4bfb-8774-9d26c451f2fc'>ToPath</a></td><td style='width:75%' ><p><a name="aa5cf801-03e2-4bfb-8774-9d26c451f2fc"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d673f798-4c4d-4a03-893c-a6f664f97c0b'>Draw</a></td><td style='width:75%' class='def'><p><a name="d673f798-4c4d-4a03-893c-a6f664f97c0b"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the triangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="ed255744-a0d0-4a26-b9fb-82bd751a1a70"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20e614a5-9946-4044-bcc8-23b4685a10d5'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="20e614a5-9946-4044-bcc8-23b4685a10d5"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d41322f1-6bb0-43e5-9262-4aed192bc86e'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="d41322f1-6bb0-43e5-9262-4aed192bc86e"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#632e192a-3f97-4494-a63d-34f6370b2685'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="632e192a-3f97-4494-a63d-34f6370b2685"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c2449d4-1004-4983-8244-48aa030cba97'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="6c2449d4-1004-4983-8244-48aa030cba97"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ffc70a38-ce11-48b2-8eff-1b0308a7eb88"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45b65032-7b68-4814-88b4-d4fc2cdc20a4'>ToCode</a></td><td style='width:75%' ><p><a name="45b65032-7b68-4814-88b4-d4fc2cdc20a4"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="f6d07341-d4e5-491d-8f05-9ebfffa0083e"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="ca1bedb8-9c3e-48bc-b990-cedf15033970"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="13c54972-f6ba-4e54-8cd0-b3032ef3a22a"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fb0392e-780c-4620-9f77-2e4aeece37b4'>Clone</a></td><td style='width:75%' class='def'><p><a name="5fb0392e-780c-4620-9f77-2e4aeece37b4"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeTriangle</code>.</p>
</td></tr></table></p>


---

<a name="9d31a8b4-fa78-4128-baf0-032eff4dd0ec"></a>
##KimonoShapeVector

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9018d8c0-08da-4545-8507-5008aef2bfb8'>Points</a></td><td style='width:75%' ><p><a name="9018d8c0-08da-4545-8507-5008aef2bfb8"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#904e3f92-4de6-4a78-a0ae-502f09f08714'>Closed</a></td><td style='width:75%' class='def'><p><a name="904e3f92-4de6-4a78-a0ae-502f09f08714"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1df975f9-9733-438d-920e-4355ff6dcf84'>IsEditable</a></td><td style='width:75%' ><p><a name="1df975f9-9733-438d-920e-4355ff6dcf84"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0ac06473-b7b6-4a66-8425-b55fd48d22bc'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="0ac06473-b7b6-4a66-8425-b55fd48d22bc"></a></p>

<h3>KimonoShapeVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c302a458-68bd-4cac-89d4-996a239ffe19'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p><a name="c302a458-68bd-4cac-89d4-996a239ffe19"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="cf4c9c01-daec-4f72-a280-3cb42fec8b1b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="43bba709-b5d3-4be1-84a8-eb3924c0ee24"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="5edf298f-5c7f-4e0f-88c4-8adfae17b1de"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="9cd2e8b9-c70c-4e1f-af42-960ad647c3f9"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#157e1391-7608-4371-9530-562a854c8938'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="157e1391-7608-4371-9530-562a854c8938"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9d31a8b4-fa78-4128-baf0-032eff4dd0ec">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="09993780-d90d-4e7c-87e7-d25d3247dc56"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="99e762c4-5879-47eb-89ef-41de9ba3dfe2"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ba051d38-8ba4-44a9-a703-584a0dd20aac"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bc2da05a-553f-40ae-8571-e99e452f2e32"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="5a82ed9c-d3b7-4cf7-ad3a-5789e64dd70e"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c960b91-baba-4495-83d2-3ebed72329e8'>Initialize</a></td><td style='width:75%' class='def'><p><a name="1c960b91-baba-4495-83d2-3ebed72329e8"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dc6aa32-4630-4e46-9894-86f0e933bb2e'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="0dc6aa32-4630-4e46-9894-86f0e933bb2e"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#601a2959-68e8-4935-bff5-75ad0fcdf5fe'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="601a2959-68e8-4935-bff5-75ad0fcdf5fe"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="cc74918f-eaa7-46a3-b60f-21eded90a375"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="86e11d92-8763-4bde-940b-7cf40607a847"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38ea1419-2775-4a36-95f6-0a8ae558cd8e'>AddPoint</a></td><td style='width:75%' ><p><a name="38ea1419-2775-4a36-95f6-0a8ae558cd8e"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="07785044-0700-48cc-8621-abfe0e167e9e"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b047b7db-6312-4f42-b55d-ca93143d439f'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="b047b7db-6312-4f42-b55d-ca93143d439f"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="0e738dfc-0efc-4f7d-b1e4-e99742b61d5e"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19046caf-587d-4b11-b663-97eb71dca910'>RemovePoint</a></td><td style='width:75%' ><p><a name="19046caf-587d-4b11-b663-97eb71dca910"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="40cce73b-b222-4000-983a-6eb80e7331dd"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c61d0bf7-a81c-4af7-b96d-1d2170efb8e7'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="c61d0bf7-a81c-4af7-b96d-1d2170efb8e7"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b39cc745-e4ee-4b07-a98b-9b14102c95e9'>ToPath</a></td><td style='width:75%' ><p><a name="b39cc745-e4ee-4b07-a98b-9b14102c95e9"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7963dc3b-9eec-4852-9ce2-fc300d69af92'>Draw</a></td><td style='width:75%' class='def'><p><a name="7963dc3b-9eec-4852-9ce2-fc300d69af92"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="4956b4b7-30fc-4d86-8df5-71282111bc19"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aaa8921b-8a8a-420d-81d2-aadd811ded86'>PointInBound</a></td><td style='width:75%' ><p><a name="aaa8921b-8a8a-420d-81d2-aadd811ded86"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="1b387195-e07a-4602-8ccf-118aec801369"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08804d03-1981-4e5b-99de-f2745b773029'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="08804d03-1981-4e5b-99de-f2745b773029"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="6fb862da-55bd-4e48-b0ee-e880d12cff3f"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18660412-4d12-4844-b880-26c67876f2b0'>BoundsChanged</a></td><td style='width:75%' ><p><a name="18660412-4d12-4844-b880-26c67876f2b0"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea37cde5-221d-40d7-a523-b9a38b1b47fb'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="ea37cde5-221d-40d7-a523-b9a38b1b47fb"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80f84ddf-cdcc-4c57-a84a-809bf34c57d1'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="80f84ddf-cdcc-4c57-a84a-809bf34c57d1"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#399e1b19-9825-4860-90da-455e2fdfc0e5'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="399e1b19-9825-4860-90da-455e2fdfc0e5"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9eca521a-a73a-4916-94b8-ac5f35524036'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="9eca521a-a73a-4916-94b8-ac5f35524036"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2abc4be-8e27-40ff-b1af-82bfb4a933c7'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="e2abc4be-8e27-40ff-b1af-82bfb4a933c7"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="43ba1f26-f5b4-414a-a841-e747b6a4bff8"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fdc667e-b224-4282-bddf-b56b86839c9e'>ToCode</a></td><td style='width:75%' ><p><a name="1fdc667e-b224-4282-bddf-b56b86839c9e"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="7858740b-8380-4446-8281-9a21348e8fe4"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="ff316dc6-81cd-4362-9f9d-74f3d5f893c9"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e089d501-1fc3-4013-b83c-4841b73ae9db"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27021666-38f8-4c72-9226-68ecc574d0ef'>Clone</a></td><td style='width:75%' class='def'><p><a name="27021666-38f8-4c72-9226-68ecc574d0ef"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="2c492ff9-c1b6-41cf-b671-c93366c4e4ed"></a>
##KimonoProperty

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a property that can be attached to another Kimono object (such as a `KimonoColor`, `KimonoStyle` or `KimonoShape`) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7de8f48f-8850-4b2d-b11c-ef7a26a15385'>UniqueID</a></td><td style='width:75%' ><p><a name="7de8f48f-8850-4b2d-b11c-ef7a26a15385"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23264f9d-a344-479a-b3fb-6ffb347dc48b'>Name</a></td><td style='width:75%' class='def'><p><a name="23264f9d-a344-479a-b3fb-6ffb347dc48b"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name as a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#586055ca-ce2b-40bc-8145-300b2953333a'>Usage</a></td><td style='width:75%' ><p><a name="586055ca-ce2b-40bc-8145-300b2953333a"></a></p>

<h3>Usage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the usage of this property.</p>

<h4>Return Value</h4>

<p>The <code>KimonoPropertyUsage</code> of this <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9b003aa-c9bf-4426-aa1d-fbb7ebde7e95'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="a9b003aa-c9bf-4426-aa1d-fbb7ebde7e95"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#2c492ff9-c1b6-41cf-b671-c93366c4e4ed">KimonoProperty</a> is the result of an Obi Script.</p>

<h4>Return Value</h4>

<p><code>true</code> if is Obi Script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e2c8b60-a2a3-4d3a-af76-40680f7874bd'>ObiScript</a></td><td style='width:75%' ><p><a name="9e2c8b60-a2a3-4d3a-af76-40680f7874bd"></a></p>

<h3>ObiScript</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the obi script that will be used to calculate the value of this <code>KimonoProperty</code>.</p>

<h4>Return Value</h4>

<p>The obi script.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#408b2797-0ced-4486-b6be-0193ea1657c9'>KimonoProperty</a></td><td style='width:75%' ><p><a name="408b2797-0ced-4486-b6be-0193ea1657c9"></a></p>

<h3>KimonoProperty ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2c492ff9-c1b6-41cf-b671-c93366c4e4ed">KimonoProperty</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b253680-002f-480b-be14-90de7fc25fec'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="2b253680-002f-480b-be14-90de7fc25fec"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#164f0341-3817-4640-8f94-0f03cf5e7a9b'>ToRect</a></td><td style='width:75%' ><p><a name="164f0341-3817-4640-8f94-0f03cf5e7a9b"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aec0cd96-9603-4f43-bcc7-358c41990e02'>ToFloat</a></td><td style='width:75%' class='def'><p><a name="aec0cd96-9603-4f43-bcc7-358c41990e02"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f03ccfe6-21cd-4a3d-adb9-c995273abfdb'>ToInt</a></td><td style='width:75%' ><p><a name="f03ccfe6-21cd-4a3d-adb9-c995273abfdb"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43032aaa-ed00-4a73-8082-6fe82288bb1f'>ToStyle</a></td><td style='width:75%' class='def'><p><a name="43032aaa-ed00-4a73-8082-6fe82288bb1f"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51380a57-fc30-4be4-b785-39cd466b9abe'>ToBool</a></td><td style='width:75%' ><p><a name="51380a57-fc30-4be4-b785-39cd466b9abe"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p>The <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4632183-209e-4733-a229-01db1a72628f'>ToColor</a></td><td style='width:75%' class='def'><p><a name="b4632183-209e-4733-a229-01db1a72628f"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b6092dc-b351-4679-b4a6-9d19d75f7003'>ToGradient</a></td><td style='width:75%' ><p><a name="6b6092dc-b351-4679-b4a6-9d19d75f7003"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a13d1093-1b9b-4f2a-86a4-34dd9ab1613b'>Clone</a></td><td style='width:75%' class='def'><p><a name="a13d1093-1b9b-4f2a-86a4-34dd9ab1613b"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="387e1df1-63dd-44b9-9b96-1b390179a471"></a>
##KimonoPropertyUsage

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines how a `KimonoProperty` is used when it is attached to a `KimonoShape`, `KimonoSketch` or `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e11fb785-b7d9-4ab0-a717-540cb7bef3b3'>LocalVariable</a></td><td style='width:75%' ><p><a name="e11fb785-b7d9-4ab0-a717-540cb7bef3b3"></a>
<b>LocalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a local variable in the  generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48b42c89-c2d0-410f-ad0a-64a24c2ce1ad'>GlobalVariable</a></td><td style='width:75%' class='def'><p><a name="48b42c89-c2d0-410f-ad0a-64a24c2ce1ad"></a>
<b>GlobalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a global variable in the generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9e8d5bc-2751-46bc-a813-043b240e42df'>Parameter</a></td><td style='width:75%' ><p><a name="f9e8d5bc-2751-46bc-a813-043b240e42df"></a>
<b>Parameter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a passed parameter in the generated code for a Kimono object.</p>
</td></tr></table></p>


---

<a name="125f835e-6791-49dd-a86f-073560145ff9"></a>
##KimonoPropertyConnectionPoint

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the point that a `KimonoProperty` value can be connected to another Kimono object such as the `Top` coordinate of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bd7141cf-f97b-42bd-b2ea-cd8c65c5e6f8'>Undefined</a></td><td style='width:75%' ><p><a name="bd7141cf-f97b-42bd-b2ea-cd8c65c5e6f8"></a>
<b>Undefined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The connection point hasn't been defined.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7838348a-5292-4bac-a39b-2b603b3a48d1'>Rect</a></td><td style='width:75%' class='def'><p><a name="7838348a-5292-4bac-a39b-2b603b3a48d1"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The rectangle that defines the <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4513e1b3-0497-4b66-afd7-66bf2366526e'>Top</a></td><td style='width:75%' ><p><a name="4513e1b3-0497-4b66-afd7-66bf2366526e"></a>
<b>Top</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Top coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84218822-b46c-4780-9011-e74f9eb7dbc8'>Left</a></td><td style='width:75%' class='def'><p><a name="84218822-b46c-4780-9011-e74f9eb7dbc8"></a>
<b>Left</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Left coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dd6bd58-bfc2-4c05-9c4b-065fb2e42549'>Bottom</a></td><td style='width:75%' ><p><a name="9dd6bd58-bfc2-4c05-9c4b-065fb2e42549"></a>
<b>Bottom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Bottom coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d085392a-ab0b-40ec-a66b-6f3fd4c02841'>Right</a></td><td style='width:75%' class='def'><p><a name="d085392a-ab0b-40ec-a66b-6f3fd4c02841"></a>
<b>Right</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Right coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dd64980-9417-4718-a75c-50dbebe422fa'>Width</a></td><td style='width:75%' ><p><a name="9dd64980-9417-4718-a75c-50dbebe422fa"></a>
<b>Width</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Widht of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a11a3a4f-d3ba-446c-8f00-275fbc91bf0d'>Height</a></td><td style='width:75%' class='def'><p><a name="a11a3a4f-d3ba-446c-8f00-275fbc91bf0d"></a>
<b>Height</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Height of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#260f83c3-3e23-45c3-bf59-72750bc2b9c6'>RotationDegrees</a></td><td style='width:75%' ><p><a name="260f83c3-3e23-45c3-bf59-72750bc2b9c6"></a>
<b>RotationDegrees</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Rotational Degrees of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68f0b30d-8013-4ee4-a0b0-ad60fac89916'>Style</a></td><td style='width:75%' class='def'><p><a name="68f0b30d-8013-4ee4-a0b0-ad60fac89916"></a>
<b>Style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The <code>KimonoStyle</code> of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#852e6dba-920a-4433-b948-35c5c55c78d0'>Visible</a></td><td style='width:75%' ><p><a name="852e6dba-920a-4433-b948-35c5c55c78d0"></a>
<b>Visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#edfd60b2-f3cc-42c3-9ab7-c52d01d4ff12'>HasStartHead</a></td><td style='width:75%' class='def'><p><a name="edfd60b2-f3cc-42c3-9ab7-c52d01d4ff12"></a>
<b>HasStartHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has start head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a808fd8-1b87-45b9-ba87-bf24a30286f2'>HasEndHead</a></td><td style='width:75%' ><p><a name="2a808fd8-1b87-45b9-ba87-bf24a30286f2"></a>
<b>HasEndHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has end head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82fcfabe-7bdc-491b-821a-8a3a9f9f7460'>HeadInnerRatio</a></td><td style='width:75%' class='def'><p><a name="82fcfabe-7bdc-491b-821a-8a3a9f9f7460"></a>
<b>HeadInnerRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head inner ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e71f702-2e8a-49ba-bf7b-b7648694b536'>HeadOuterRatio</a></td><td style='width:75%' ><p><a name="3e71f702-2e8a-49ba-bf7b-b7648694b536"></a>
<b>HeadOuterRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head outer ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e01695ca-c288-42df-bc93-4041c31d0458'>IsStreamlined</a></td><td style='width:75%' class='def'><p><a name="e01695ca-c288-42df-bc93-4041c31d0458"></a>
<b>IsStreamlined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is streamlined of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a042363e-7a5f-4b4f-8af5-53791bba5e0d'>NumberOfSides</a></td><td style='width:75%' ><p><a name="a042363e-7a5f-4b4f-8af5-53791bba5e0d"></a>
<b>NumberOfSides</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of sides of a <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dc11eae-7e9f-4292-b5b7-e8587422c115'>CornerRadius</a></td><td style='width:75%' class='def'><p><a name="3dc11eae-7e9f-4292-b5b7-e8587422c115"></a>
<b>CornerRadius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The corner radius of a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8aff4fa4-9709-406e-ba0d-4b8e0182c397'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="8aff4fa4-9709-406e-ba0d-4b8e0182c397"></a>
<b>NumberOfPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72b22fb1-c5f5-4244-be04-72520c694206'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="72b22fb1-c5f5-4244-be04-72520c694206"></a>
<b>SkipPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The skip points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ed66438-ee9c-4fe9-91a7-4cf3a68711a7'>DepthOffset</a></td><td style='width:75%' ><p><a name="8ed66438-ee9c-4fe9-91a7-4cf3a68711a7"></a>
<b>DepthOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The depth offset of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2616d7e7-898d-4e8a-9fb6-ccc469c6d287'>Text</a></td><td style='width:75%' class='def'><p><a name="2616d7e7-898d-4e8a-9fb6-ccc469c6d287"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text of a <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b17a1436-c08d-4f8f-a739-0253f3db22c2'>BaseColor</a></td><td style='width:75%' ><p><a name="b17a1436-c08d-4f8f-a739-0253f3db22c2"></a>
<b>BaseColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base color of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f67e568-d8fb-47c0-8149-fce50130cdb9'>AdjustsHue</a></td><td style='width:75%' class='def'><p><a name="9f67e568-d8fb-47c0-8149-fce50130cdb9"></a>
<b>AdjustsHue</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts hue of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffe9ecd4-df8a-40ba-a99e-7905d451f520'>HueAdjustment</a></td><td style='width:75%' ><p><a name="ffe9ecd4-df8a-40ba-a99e-7905d451f520"></a>
<b>HueAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The hue adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d259c93e-a6a0-41d3-bcce-5e2f3f273fc8'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p><a name="d259c93e-a6a0-41d3-bcce-5e2f3f273fc8"></a>
<b>AdjustsSaturation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts saturation of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac1b44f5-a459-4639-9e4b-1bcc1d60886a'>SaturationAdjustment</a></td><td style='width:75%' ><p><a name="ac1b44f5-a459-4639-9e4b-1bcc1d60886a"></a>
<b>SaturationAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The saturation adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cd064c0-6a07-4b63-9a09-1691db4d3691'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p><a name="6cd064c0-6a07-4b63-9a09-1691db4d3691"></a>
<b>AdjustsBrightness</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts brightness of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4916403-60eb-43b4-abf1-840475390891'>BrightnessAdjustment</a></td><td style='width:75%' ><p><a name="e4916403-60eb-43b4-abf1-840475390891"></a>
<b>BrightnessAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The brightness adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16e07534-4b3c-4969-8556-69d855ca3bd7'>AdjustsAlpha</a></td><td style='width:75%' class='def'><p><a name="16e07534-4b3c-4969-8556-69d855ca3bd7"></a>
<b>AdjustsAlpha</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts alpha of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbf3dfbb-d26d-4444-95f1-07d99ad016e3'>AlphaAdjustment</a></td><td style='width:75%' ><p><a name="fbf3dfbb-d26d-4444-95f1-07d99ad016e3"></a>
<b>AlphaAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The alpha adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53f88c40-8ae0-4145-b0c5-1ee85915dad3'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="53f88c40-8ae0-4145-b0c5-1ee85915dad3"></a>
<b>HasFrame</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ce14753-c4ff-498a-888d-af0405ada6d2'>HasFrameBlur</a></td><td style='width:75%' ><p><a name="9ce14753-c4ff-498a-888d-af0405ada6d2"></a>
<b>HasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fe9a056-1372-431c-9c04-5e3eab1a3286'>FrameHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="9fe9a056-1372-431c-9c04-5e3eab1a3286"></a>
<b>FrameHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#109a1175-46b5-4e9f-8d84-f20a127a414f'>FrameVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="109a1175-46b5-4e9f-8d84-f20a127a414f"></a>
<b>FrameVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f63645eb-f761-427e-8a99-f769833908df'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="f63645eb-f761-427e-8a99-f769833908df"></a>
<b>HasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccc843fb-4c04-45ed-b9a1-06e4c35d44b1'>FrameShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="ccc843fb-4c04-45ed-b9a1-06e4c35d44b1"></a>
<b>FrameShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7c3c587-ed29-494e-8493-e2d853bd7dea'>FrameShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="f7c3c587-ed29-494e-8493-e2d853bd7dea"></a>
<b>FrameShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba95917a-ce4f-4a8c-9389-c488cc8eb5f5'>FrameShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="ba95917a-ce4f-4a8c-9389-c488cc8eb5f5"></a>
<b>FrameShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow horizontal blur amount of a `KimonoStyle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df4428b1-81a7-48fe-be54-013f234a2298'>FrameShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="df4428b1-81a7-48fe-be54-013f234a2298"></a>
<b>FrameShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#931cce9d-53fe-4309-b297-5cdc965836f3'>FrameShadowLinkedColor</a></td><td style='width:75%' ><p><a name="931cce9d-53fe-4309-b297-5cdc965836f3"></a>
<b>FrameShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75fde85b-77d5-4d88-b579-85c5309a860c'>HasFill</a></td><td style='width:75%' class='def'><p><a name="75fde85b-77d5-4d88-b579-85c5309a860c"></a>
<b>HasFill</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#734f7264-845a-4a95-a782-4382cd308a11'>HasFillBlur</a></td><td style='width:75%' ><p><a name="734f7264-845a-4a95-a782-4382cd308a11"></a>
<b>HasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#292c9e03-a8ec-4480-ac19-6b9cee79c841'>FillHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="292c9e03-a8ec-4480-ac19-6b9cee79c841"></a>
<b>FillHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#598817ae-76e9-4573-9154-be4bf93355f8'>FillVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="598817ae-76e9-4573-9154-be4bf93355f8"></a>
<b>FillVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0cd8e1d-edd9-443e-8b6f-492ee71ffa35'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="c0cd8e1d-edd9-443e-8b6f-492ee71ffa35"></a>
<b>HasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06e92a8c-fd4a-4084-9def-aba9893d83fd'>FillShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="06e92a8c-fd4a-4084-9def-aba9893d83fd"></a>
<b>FillShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cc6e41f-1e51-4a00-9589-80c71cab04af'>FillShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="2cc6e41f-1e51-4a00-9589-80c71cab04af"></a>
<b>FillShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d51cf143-e069-455d-b51f-f72c51b4d712'>FillShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="d51cf143-e069-455d-b51f-f72c51b4d712"></a>
<b>FillShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a10dc031-f036-4f67-9eb2-348c20104d74'>FillShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="a10dc031-f036-4f67-9eb2-348c20104d74"></a>
<b>FillShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e61153f4-a9b2-4eec-b4a3-ebc166a22b90'>FillShadowLinkedColor</a></td><td style='width:75%' ><p><a name="e61153f4-a9b2-4eec-b4a3-ebc166a22b90"></a>
<b>FillShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1493d817-77ad-4c64-8bad-d382c46ebaf0'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="1493d817-77ad-4c64-8bad-d382c46ebaf0"></a>
<b>FrameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76724b8d-54a0-4274-bcd4-869756a66f7b'>FrameGradient</a></td><td style='width:75%' ><p><a name="76724b8d-54a0-4274-bcd4-869756a66f7b"></a>
<b>FrameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#305337cf-2ae3-4428-9345-7716871619f8'>FillColor</a></td><td style='width:75%' class='def'><p><a name="305337cf-2ae3-4428-9345-7716871619f8"></a>
<b>FillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c390af3e-e9cf-4689-b25c-ed7a40d70925'>FillGradient</a></td><td style='width:75%' ><p><a name="c390af3e-e9cf-4689-b25c-ed7a40d70925"></a>
<b>FillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d12aac9-50ea-453c-90f7-5341aeecf8d6'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="7d12aac9-50ea-453c-90f7-5341aeecf8d6"></a>
<b>IsVerticalText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is vertical text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c75491d-34c9-49b6-98ca-664a3cc006bf'>StrikeThruText</a></td><td style='width:75%' ><p><a name="2c75491d-34c9-49b6-98ca-664a3cc006bf"></a>
<b>StrikeThruText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The strike thru text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10394788-8d42-40c1-8b4d-994397e2654f'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="10394788-8d42-40c1-8b4d-994397e2654f"></a>
<b>TextScaleX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text scale x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#820636e5-c1a8-4d53-9af7-4da92bc194b1'>TextSize</a></td><td style='width:75%' ><p><a name="820636e5-c1a8-4d53-9af7-4da92bc194b1"></a>
<b>TextSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b412535-9335-4e24-a269-e82262e0f5f1'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="1b412535-9335-4e24-a269-e82262e0f5f1"></a>
<b>TextSkewX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text skew x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b865296-6b34-44de-a14f-eb9a4af91006'>FontFamilyName</a></td><td style='width:75%' ><p><a name="6b865296-6b34-44de-a14f-eb9a4af91006"></a>
<b>FontFamilyName</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The name of the font family of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4b2ef37-77e1-47f1-a434-c6d786b1dfd5'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="a4b2ef37-77e1-47f1-a434-c6d786b1dfd5"></a>
<b>UnderlineText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The underline text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#369cb58a-d232-4973-997f-eec352e35a0c'>HasFrameJitter</a></td><td style='width:75%' ><p><a name="369cb58a-d232-4973-997f-eec352e35a0c"></a>
<b>HasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#757f716d-e11b-41ee-ba28-9566aa7c5075'>FrameJitterLength</a></td><td style='width:75%' class='def'><p><a name="757f716d-e11b-41ee-ba28-9566aa7c5075"></a>
<b>FrameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e66bf1d3-4912-4e95-b22d-54e82a9fa61f'>FrameJitterDeviation</a></td><td style='width:75%' ><p><a name="e66bf1d3-4912-4e95-b22d-54e82a9fa61f"></a>
<b>FrameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1aaecbbf-e98e-4ba4-800f-a6787de3d49c'>HasFillJitter</a></td><td style='width:75%' class='def'><p><a name="1aaecbbf-e98e-4ba4-800f-a6787de3d49c"></a>
<b>HasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4696687c-f570-42b4-95cc-f829a903caf7'>FillJitterLength</a></td><td style='width:75%' ><p><a name="4696687c-f570-42b4-95cc-f829a903caf7"></a>
<b>FillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c225e47b-9827-4744-8b96-e9ad83906a1f'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="c225e47b-9827-4744-8b96-e9ad83906a1f"></a>
<b>FillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37c96a19-418f-43be-93e7-0887d114b9f7'>HasFrameDash</a></td><td style='width:75%' ><p><a name="37c96a19-418f-43be-93e7-0887d114b9f7"></a>
<b>HasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame dash of a <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="923a528f-c1f9-4df5-9d59-bcc90d51ba8c"></a>
##KimonoPropertyConnection

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a connection between a given Kimono Object and a `KimonoProperty`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8c779546-a545-42ed-9e16-66a56c323dad'>UniqueID</a></td><td style='width:75%' ><p><a name="8c779546-a545-42ed-9e16-66a56c323dad"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fdbf5e0-219d-4259-89b5-e79cda95a019'>ConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="1fdbf5e0-219d-4259-89b5-e79cda95a019"></a></p>

<h3>ConnectionPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the point that a given <code>KimonoProperty</code> is connected to another Kimono Object.</p>

<h4>Return Value</h4>

<p>The connection point as a <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7830df3b-78f3-436c-8b9c-e92f6c8ae881'>ConnectedProperty</a></td><td style='width:75%' ><p><a name="7830df3b-78f3-436c-8b9c-e92f6c8ae881"></a></p>

<h3>ConnectedProperty</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the connected property.</p>

<h4>Return Value</h4>

<p>The connected <code>KimonoProperty</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#791fa3ef-3e04-42be-927a-ffa61c9624c7'>KimonoPropertyConnection</a></td><td style='width:75%' ><p><a name="791fa3ef-3e04-42be-927a-ffa61c9624c7"></a></p>

<h3>KimonoPropertyConnection ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#923a528f-c1f9-4df5-9d59-bcc90d51ba8c">KimonoPropertyConnection</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2389171-cdf0-4a54-ae57-f8ac409867fc'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p><a name="c2389171-cdf0-4a54-ae57-f8ac409867fc"></a></p>

<h3>KimonoPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#923a528f-c1f9-4df5-9d59-bcc90d51ba8c">KimonoPropertyConnection</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="1a68cf2f-e6c7-44b8-a5a2-d71c39b5bba9"></a>
Connection point.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="e55f714b-48f0-4a1e-b148-aaf426d977ab"></a>
Property.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f59ce9da-b06d-4e37-8674-f65d2e28e8ba'>Clone</a></td><td style='width:75%' ><p><a name="f59ce9da-b06d-4e37-8674-f65d2e28e8ba"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="295465f0-8c61-49d9-b49f-9cc107dde55e"></a>
##ObiScriptResult

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the result of attempting to execute an Obi Script on a `KimonoProperty`
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e3e06f57-e5f9-48c4-933d-fa6c2953bcd7'>Successful</a></td><td style='width:75%' ><p><a name="e3e06f57-e5f9-48c4-933d-fa6c2953bcd7"></a></p>

<h3>Successful</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the Obi Script ran successfully.</p>

<h4>Return Value</h4>

<p><code>true</code> if successful; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd35620c-aa6c-4b1b-bcd8-e64b543a30ae'>ErrorMessage</a></td><td style='width:75%' class='def'><p><a name="cd35620c-aa6c-4b1b-bcd8-e64b543a30ae"></a></p>

<h3>ErrorMessage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the error message if the Obi Script execution failed.</p>

<h4>Return Value</h4>

<p>The error message or "" if the script ran successfully.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2ec81ed3-2ebf-45ae-a22c-9f6620a4858b'>ObiScriptResult</a></td><td style='width:75%' ><p><a name="2ec81ed3-2ebf-45ae-a22c-9f6620a4858b"></a></p>

<h3>ObiScriptResult ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#295465f0-8c61-49d9-b49f-9cc107dde55e">ObiScriptResult</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f885cb2e-cbb6-40e5-aabe-a3c3561e142c'>ObiScriptResult</a></td><td style='width:75%' class='def'><p><a name="f885cb2e-cbb6-40e5-aabe-a3c3561e142c"></a></p>

<h3>ObiScriptResult (System.Boolean, System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#295465f0-8c61-49d9-b49f-9cc107dde55e">ObiScriptResult</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>isSuccessful</td><td style='width:75%' ><p><a name="b1036998-e37b-415b-b7fa-54a512d39732"></a>
If set to <code>true</code> is successful.</p>
</td></tr><tr><td style='width:25%' class='term'>errorMessage</td><td style='width:75%' class='def'><p><a name="0ba7a5b5-51e7-4c4f-94fe-bc158b9678ae"></a>
Error message.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="22ac5b44-3d41-43ae-9a97-b0f5c6147b00"></a>
##KimonoBezierPoint

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Holds the control and end point for a `KimonoShapeBezier` that define a quad section of the Bezier.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#25bbed18-3bb4-4da8-937c-f268f3c2a536'>ControlPoint</a></td><td style='width:75%' ><p><a name="25bbed18-3bb4-4da8-937c-f268f3c2a536"></a></p>

<h3>ControlPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control point.</p>

<h4>Return Value</h4>

<p>The control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bb3326a-8b5c-4ccc-9158-6a40d0f909de'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="2bb3326a-8b5c-4ccc-9158-6a40d0f909de"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e1ca801a-decc-4112-b21e-5d71a6b33c53'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="e1ca801a-decc-4112-b21e-5d71a6b33c53"></a></p>

<h3>KimonoBezierPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#22ac5b44-3d41-43ae-9a97-b0f5c6147b00">KimonoBezierPoint</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30b95e18-872d-4080-ab0c-453d0c18734c'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p><a name="30b95e18-872d-4080-ab0c-453d0c18734c"></a></p>

<h3>KimonoBezierPoint (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#22ac5b44-3d41-43ae-9a97-b0f5c6147b00">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlPoint</td><td style='width:75%' ><p><a name="2d79b6bb-da9c-454f-abbe-60c6023dbd50"></a>
Control point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="5144cca1-006b-488f-97b9-e9de2972d3fb"></a>
End point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8d6268d-7491-4f0f-b5c4-039e8983c845'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="a8d6268d-7491-4f0f-b5c4-039e8983c845"></a></p>

<h3>KimonoBezierPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#22ac5b44-3d41-43ae-9a97-b0f5c6147b00">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="7e42cfa4-5f6e-4b80-af71-9ad155f82d2c"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="a60b4ff4-5596-4d41-b3aa-1538132cbb36"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="97a04d4e-2005-4f0e-ae18-b119888b2814"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="7d53549d-3ae4-401c-940d-48a0f53f534f"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22262724-c7f6-4580-aed1-f5a487fbd2e0'>Clone</a></td><td style='width:75%' class='def'><p><a name="22262724-c7f6-4580-aed1-f5a487fbd2e0"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="780c6cbd-fa5d-4b07-8956-be4697770c4b"></a>
##KimonoBounds

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the outter bounding box for a `KimonoShape` and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bd9b2c90-5a71-464b-aeb2-45e57ab3295f'>Rect</a></td><td style='width:75%' ><p><a name="bd9b2c90-5a71-464b-aeb2-45e57ab3295f"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base <code>SkRect</code> that holds the internal bounds of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f90df0c-c776-433b-add8-ce22c9128e74'>PreviousCenter</a></td><td style='width:75%' class='def'><p><a name="7f90df0c-c776-433b-add8-ce22c9128e74"></a>
<b>PreviousCenter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous center used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44a08e24-1d8d-4ede-ba37-42acfdd00559'>PreviousRect</a></td><td style='width:75%' ><p><a name="44a08e24-1d8d-4ede-ba37-42acfdd00559"></a>
<b>PreviousRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous rect used in scaling operations.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5e2f5dd7-f53a-4423-a475-e950bb11c4ed'>State</a></td><td style='width:75%' ><p><a name="5e2f5dd7-f53a-4423-a475-e950bb11c4ed"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the current edit state of the <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffedcf91-3e0a-46c2-8922-7fa7f44cc1af'>Name</a></td><td style='width:75%' class='def'><p><a name="ffedcf91-3e0a-46c2-8922-7fa7f44cc1af"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a5ae97e-9a24-40be-a665-dcbc0f54684a'>UniqueID</a></td><td style='width:75%' ><p><a name="0a5ae97e-9a24-40be-a665-dcbc0f54684a"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e41400f3-6004-4a4f-8d4a-89b54f317b0b'>Top</a></td><td style='width:75%' class='def'><p><a name="e41400f3-6004-4a4f-8d4a-89b54f317b0b"></a></p>

<h3>Top</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top.</p>

<h4>Return Value</h4>

<p>The top coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#856f34e8-3b96-4038-84d3-388569d9eacd'>Left</a></td><td style='width:75%' ><p><a name="856f34e8-3b96-4038-84d3-388569d9eacd"></a></p>

<h3>Left</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left.</p>

<h4>Return Value</h4>

<p>The left coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#160d27cb-d10b-435c-8375-37649d3a647b'>Bottom</a></td><td style='width:75%' class='def'><p><a name="160d27cb-d10b-435c-8375-37649d3a647b"></a></p>

<h3>Bottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom.</p>

<h4>Return Value</h4>

<p>The bottom coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e367ac6-1355-41ad-8116-94498187ed9e'>Right</a></td><td style='width:75%' ><p><a name="5e367ac6-1355-41ad-8116-94498187ed9e"></a></p>

<h3>Right</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right.</p>

<h4>Return Value</h4>

<p>The right coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1b53478-07f7-400b-b7b7-f034948b25e1'>Width</a></td><td style='width:75%' class='def'><p><a name="b1b53478-07f7-400b-b7b7-f034948b25e1"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61a5a4bb-f156-4e96-9b13-e2a8df984213'>Height</a></td><td style='width:75%' ><p><a name="61a5a4bb-f156-4e96-9b13-e2a8df984213"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57988e66-7139-4d86-ab78-037585cebe58'>HorizontalCenter</a></td><td style='width:75%' class='def'><p><a name="57988e66-7139-4d86-ab78-037585cebe58"></a></p>

<h3>HorizontalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the horizontal center.</p>

<h4>Return Value</h4>

<p>The horizontal center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d891be0-1b49-4b6d-94e1-7c978830f0da'>VerticalCenter</a></td><td style='width:75%' ><p><a name="9d891be0-1b49-4b6d-94e1-7c978830f0da"></a></p>

<h3>VerticalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the vertical center.</p>

<h4>Return Value</h4>

<p>The vertical center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc7c8894-aef5-4c3d-86ea-fd1428060d91'>Center</a></td><td style='width:75%' class='def'><p><a name="fc7c8894-aef5-4c3d-86ea-fd1428060d91"></a></p>

<h3>Center</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the center.</p>

<h4>Return Value</h4>

<p>The center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#659a3587-8eaf-447b-b4e7-ccd03a50065e'>RotationDegrees</a></td><td style='width:75%' ><p><a name="659a3587-8eaf-447b-b4e7-ccd03a50065e"></a></p>

<h3>RotationDegrees</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the rotation degrees.</p>

<h4>Return Value</h4>

<p>The rotation degrees.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d464497-d110-4d0d-a975-ed1b97c1e46d'>TopLeftHandle</a></td><td style='width:75%' class='def'><p><a name="9d464497-d110-4d0d-a975-ed1b97c1e46d"></a></p>

<h3>TopLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top left handle.</p>

<h4>Return Value</h4>

<p>The top left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca24a30d-537d-4c3a-ac72-75ec51ecfa4a'>TopHandle</a></td><td style='width:75%' ><p><a name="ca24a30d-537d-4c3a-ac72-75ec51ecfa4a"></a></p>

<h3>TopHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top handle.</p>

<h4>Return Value</h4>

<p>The top handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b900939-4963-481c-958c-b5c4a7aedc4b'>TopRightHandle</a></td><td style='width:75%' class='def'><p><a name="2b900939-4963-481c-958c-b5c4a7aedc4b"></a></p>

<h3>TopRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top right handle.</p>

<h4>Return Value</h4>

<p>The top right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92ab8395-edb4-41c5-bde3-54697a8c12bc'>RightHandle</a></td><td style='width:75%' ><p><a name="92ab8395-edb4-41c5-bde3-54697a8c12bc"></a></p>

<h3>RightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right handle.</p>

<h4>Return Value</h4>

<p>The right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b26299be-6375-48ff-8679-4f8beca89b4f'>BottomRightHandle</a></td><td style='width:75%' class='def'><p><a name="b26299be-6375-48ff-8679-4f8beca89b4f"></a></p>

<h3>BottomRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom right handle.</p>

<h4>Return Value</h4>

<p>The bottom right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef0de50b-5b03-4139-a1b3-a649083c0f26'>BottomHandle</a></td><td style='width:75%' ><p><a name="ef0de50b-5b03-4139-a1b3-a649083c0f26"></a></p>

<h3>BottomHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom handle.</p>

<h4>Return Value</h4>

<p>The bottom handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6436aa5-7cf2-419a-a5f0-9df6d854663f'>BottomLeftHandle</a></td><td style='width:75%' class='def'><p><a name="c6436aa5-7cf2-419a-a5f0-9df6d854663f"></a></p>

<h3>BottomLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom left handle.</p>

<h4>Return Value</h4>

<p>The bottom left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79a87a77-5b18-44b5-a7fd-a9c3d61a5a0c'>LeftHandle</a></td><td style='width:75%' ><p><a name="79a87a77-5b18-44b5-a7fd-a9c3d61a5a0c"></a></p>

<h3>LeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left handle.</p>

<h4>Return Value</h4>

<p>The left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d854d661-f0df-4081-9075-364728e72170'>HitOffset</a></td><td style='width:75%' class='def'><p><a name="d854d661-f0df-4081-9075-364728e72170"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ff541ea-22fa-42b8-ae9f-9ed10cade7b2'>HitHandle</a></td><td style='width:75%' ><p><a name="1ff541ea-22fa-42b8-ae9f-9ed10cade7b2"></a></p>

<h3>HitHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit handle.</p>

<h4>Return Value</h4>

<p>The hit handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d4fe2912-33d5-4339-baa8-4d03894120cc'>KimonoBounds</a></td><td style='width:75%' ><p><a name="d4fe2912-33d5-4339-baa8-4d03894120cc"></a></p>

<h3>KimonoBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#780c6cbd-fa5d-4b07-8956-be4697770c4b">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41b8e072-02ed-48d0-9392-dad24f7104bb'>KimonoBounds</a></td><td style='width:75%' class='def'><p><a name="41b8e072-02ed-48d0-9392-dad24f7104bb"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#780c6cbd-fa5d-4b07-8956-be4697770c4b">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="2e396bb9-c9f9-427a-99df-56c958e8009d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="54340e59-1e7b-4f82-9989-bc406dad0594"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="254c97e4-0000-43d1-b5db-f13489db811c"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a54f062b-1e02-498a-9eb2-eb12846196df"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#350ac919-f0c3-4b77-8cad-6025d7ee233f'>KimonoBounds</a></td><td style='width:75%' ><p><a name="350ac919-f0c3-4b77-8cad-6025d7ee233f"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#780c6cbd-fa5d-4b07-8956-be4697770c4b">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f282a0c5-3575-4ffe-8ed1-ce7a3d803ca7"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="49180704-5c22-49a2-8a12-b7f88a898d25"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="547a7c70-c0a5-4944-b96c-824e8b03db0e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e2f3f4f7-8e88-4e83-b0f9-eb161d0d7162"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="110dd71b-eab7-441d-bc37-1cba48da208a"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad14ccbe-8af7-48c9-9ecb-1ce1ecea8c4e'>SavePreviousBounds</a></td><td style='width:75%' class='def'><p><a name="ad14ccbe-8af7-48c9-9ecb-1ce1ecea8c4e"></a></p>

<h3>SavePreviousBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b785145c-b6a0-45bd-a50b-a12329dfbaf4'>ValueBetween</a></td><td style='width:75%' ><p><a name="b785145c-b6a0-45bd-a50b-a12329dfbaf4"></a></p>

<h3>ValueBetween (System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Checks to see if the given value is between the two given points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="76111764-33e1-4a76-9f52-9457713d2047"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p><a name="8f5c29d2-09ab-4d53-993c-7cf97fa4369d"></a>
The alpha component.</p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p><a name="c615a169-4aa3-4243-8e9e-32d5229ed86e"></a>
The blue component.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>Boolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5526e136-dfd9-4fbc-885b-53429c78e8ba'>AddHandles</a></td><td style='width:75%' class='def'><p><a name="5526e136-dfd9-4fbc-885b-53429c78e8ba"></a></p>

<h3>AddHandles (KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the control handles to the bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06247f32-0f9e-4b46-bfce-8d63facd0298'>RemoveHandles</a></td><td style='width:75%' ><p><a name="06247f32-0f9e-4b46-bfce-8d63facd0298"></a></p>

<h3>RemoveHandles ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the control handles from the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6adeeb38-af8a-4494-a044-83d2bb01c387'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="6adeeb38-af8a-4494-a044-83d2bb01c387"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates the location of the edit handles when the bounds has been relocated or resized.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a357bfae-04d9-4f71-a331-b55a5833442a'>Draw</a></td><td style='width:75%' ><p><a name="a357bfae-04d9-4f71-a331-b55a5833442a"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bounding box and its edit handles into the given canvas</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="07f668ae-7ccd-41e2-a6e0-3067bab6e9b9"></a>
Canvas.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56979df9-bd27-42dc-a229-d1001e39f1e9'>Select</a></td><td style='width:75%' class='def'><p><a name="56979df9-bd27-42dc-a229-d1001e39f1e9"></a></p>

<h3>Select ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Puts the <code>KimonoShape</code> into the edit mode and creates the edit handles as required.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de175617-9007-4c4e-9922-6c0ce1367d77'>PlaceUnderConstruction</a></td><td style='width:75%' ><p><a name="de175617-9007-4c4e-9922-6c0ce1367d77"></a></p>

<h3>PlaceUnderConstruction (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the bounds under construction.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p><a name="71b19299-d559-472a-8e90-0951f5cb05ab"></a>
If set to <code>true</code> needs handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8dbe2f3c-d5b8-44b6-bcdc-1decf181a983'>StartGrouping</a></td><td style='width:75%' class='def'><p><a name="8dbe2f3c-d5b8-44b6-bcdc-1decf181a983"></a></p>

<h3>StartGrouping ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts the bounds grouping.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45514737-72cb-425e-9f53-877400388c0d'>Unselect</a></td><td style='width:75%' ><p><a name="45514737-72cb-425e-9f53-877400388c0d"></a></p>

<h3>Unselect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Unselects the <code>KimonoShape</code> as the current edit target and removes any edit handles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3a2d40b-2ea6-40c8-a472-4e98abee0d3e'>ChangeBounds</a></td><td style='width:75%' class='def'><p><a name="a3a2d40b-2ea6-40c8-a472-4e98abee0d3e"></a></p>

<h3>ChangeBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Changes the bounds to match the given values.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="d210e93e-7f87-488a-9d80-2968fac70e5b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="8c56f36e-19af-4bae-9ed6-b26a60d12915"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="9773d134-d6f1-48f3-89a3-4773cc904881"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a7d9cdd7-5505-4f9c-82cc-8053b2719c63"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4911832-a590-4cf3-9ca0-6bad83455b34'>GrowBounds</a></td><td style='width:75%' ><p><a name="b4911832-a590-4cf3-9ca0-6bad83455b34"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adjusts the size of the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="39d2a2ea-3f72-4512-9fd8-746d97d95f7c"></a>
The new size as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1648aa1-5a9c-431c-b83f-e8df44d37c80'>MoveBounds</a></td><td style='width:75%' class='def'><p><a name="f1648aa1-5a9c-431c-b83f-e8df44d37c80"></a></p>

<h3>MoveBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the bounds to the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="57d60fba-5f02-478b-9557-afa1bd64912e"></a>
The new top, left location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45022ff9-e13c-4b07-8d47-115493f57669'>DragBounds</a></td><td style='width:75%' ><p><a name="45022ff9-e13c-4b07-8d47-115493f57669"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="23ada83f-d389-4550-a10b-10c487f5b43e"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d3d7e1a-400c-4b4f-9c1a-e11c084a6be4'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="2d3d7e1a-400c-4b4f-9c1a-e11c084a6be4"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e4e2442d-3207-4d51-a95e-26cb7790b0fc"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5921134-bb82-4bde-bdd5-1511216c60fb'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="c5921134-bb82-4bde-bdd5-1511216c60fb"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9ff93b6-bd7b-4c89-9f3e-ea56f57adedd'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="d9ff93b6-bd7b-4c89-9f3e-ea56f57adedd"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31baf7ac-0a84-44fe-a348-4ecfd7cac80a'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="31baf7ac-0a84-44fe-a348-4ecfd7cac80a"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1cbb863-d9e8-41d5-aa18-682e87047804'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="f1cbb863-d9e8-41d5-aa18-682e87047804"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ca7567e1-81b1-4716-95e3-19952845d722"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#595df5b7-1bab-4fc4-9608-b933a0a2d970'>ToCode</a></td><td style='width:75%' ><p><a name="595df5b7-1bab-4fc4-9608-b933a0a2d970"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="da0a27ab-e4d7-4891-a25c-5c3ad5176c2f"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8d1f4b2f-24e3-424b-82ff-5e58bf15133a"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7afa4316-d05b-4ee1-96a0-41ce63257dfb"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8baa2fa4-0942-4af8-ad90-40f45c6719ec'>Clone</a></td><td style='width:75%' class='def'><p><a name="8baa2fa4-0942-4af8-ad90-40f45c6719ec"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="2fc41b61-b808-44e8-b693-79bd6bcc2f43"></a>
##KimonoHandle

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines an edit handle that the user manipulates to edit the bounds of a `KimonoShape` or the control points of a Bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#81e10246-650d-4a49-9772-166431ffcc5b'>DrawWidth</a></td><td style='width:75%' ><p><a name="81e10246-650d-4a49-9772-166431ffcc5b"></a>
<b>DrawWidth</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The width of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c936b937-9249-4031-a861-f9377e0e07dc'>DrawOffset</a></td><td style='width:75%' class='def'><p><a name="c936b937-9249-4031-a861-f9377e0e07dc"></a>
<b>DrawOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The draw offset of the drag handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8a0e1250-1958-4d79-ac59-2c1055e02942'>Index</a></td><td style='width:75%' ><p><a name="8a0e1250-1958-4d79-ac59-2c1055e02942"></a></p>

<h3>Index</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the index.</p>

<h4>Return Value</h4>

<p>The index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8fd53aa-db42-4e53-93f9-ef09375a9ae9'>HandleType</a></td><td style='width:75%' class='def'><p><a name="e8fd53aa-db42-4e53-93f9-ef09375a9ae9"></a></p>

<h3>HandleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the handle.</p>

<h4>Return Value</h4>

<p>The type of the handle as a <code>KimonoHandleType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffe9b436-52e7-4b58-b6c0-85c283f99293'>UniqueID</a></td><td style='width:75%' ><p><a name="ffe9b436-52e7-4b58-b6c0-85c283f99293"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#520d20fb-e1d6-4667-a8fa-469fd41e083b'>State</a></td><td style='width:75%' class='def'><p><a name="520d20fb-e1d6-4667-a8fa-469fd41e083b"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the edit state of the <code>KimonoHandle</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31d2d38d-d5c8-4e1a-84ac-ea3e0b451abb'>X</a></td><td style='width:75%' ><p><a name="31d2d38d-d5c8-4e1a-84ac-ea3e0b451abb"></a></p>

<h3>X</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the x value.</p>

<h4>Return Value</h4>

<p>The x coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ac41ec2-86c3-4af8-9301-32664b557dcc'>Y</a></td><td style='width:75%' class='def'><p><a name="7ac41ec2-86c3-4af8-9301-32664b557dcc"></a></p>

<h3>Y</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the y value.</p>

<h4>Return Value</h4>

<p>The y coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c68d0fa-efd1-4d4c-9a09-b3426c43bc4a'>Rect</a></td><td style='width:75%' ><p><a name="7c68d0fa-efd1-4d4c-9a09-b3426c43bc4a"></a></p>

<h3>Rect</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the rect.</p>

<h4>Return Value</h4>

<p>The rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87471278-2b27-435a-ad89-e05208510e60'>Constraint</a></td><td style='width:75%' class='def'><p><a name="87471278-2b27-435a-ad89-e05208510e60"></a></p>

<h3>Constraint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the edit constraint.</p>

<h4>Return Value</h4>

<p>The edit constraint as a <code>KimonoHandleConstraint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e109a7bc-2b81-4cd5-87a4-152f97fcca62'>HitOffset</a></td><td style='width:75%' ><p><a name="e109a7bc-2b81-4cd5-87a4-152f97fcca62"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eecf5b5b-933e-4836-b292-c89970d15c98'>Color</a></td><td style='width:75%' class='def'><p><a name="eecf5b5b-933e-4836-b292-c89970d15c98"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, this color will be used.</p>

<h4>Return Value</h4>

<p>The <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#423f17ad-3889-42d6-8c39-691175211bfb'>LinkedColor</a></td><td style='width:75%' ><p><a name="423f17ad-3889-42d6-8c39-691175211bfb"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, the <code>Color</code> property will  be used instead.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cd118c5-3343-466f-b821-e008f0edec28'>RepresentedColor</a></td><td style='width:75%' class='def'><p><a name="6cd118c5-3343-466f-b821-e008f0edec28"></a></p>

<h3>RepresentedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color that this handle represents.</p>

<h4>Return Value</h4>

<p>The color as a <code>SKColor</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7568a61c-59cf-454d-b3e0-bb0681be78b8'>KimonoHandle</a></td><td style='width:75%' ><p><a name="7568a61c-59cf-454d-b3e0-bb0681be78b8"></a></p>

<h3>KimonoHandle (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2fc41b61-b808-44e8-b693-79bd6bcc2f43">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="695fb1b9-064a-4e50-9e51-29807e11ecb6"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="fbb19340-98f4-43b7-9db8-8572fa3e72c4"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3387e40-d6e3-40f2-8c07-8f86c51b95f7'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="c3387e40-d6e3-40f2-8c07-8f86c51b95f7"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2fc41b61-b808-44e8-b693-79bd6bcc2f43">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="10b08289-1557-4d67-a3d5-b4847165d4e2"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="ef2c80dd-45bb-4e53-81cb-71ea1a16f73b"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="3f86fe13-122d-4a7d-bca1-ad112d49bbeb"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e30c1462-a28b-42e1-92f6-203c6ab6127a'>KimonoHandle</a></td><td style='width:75%' ><p><a name="e30c1462-a28b-42e1-92f6-203c6ab6127a"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2fc41b61-b808-44e8-b693-79bd6bcc2f43">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="7bdfbb45-d547-4686-9901-63e2a0bf2a13"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="8a870705-d65f-4680-87d3-1d9b86635bc1"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="ac321586-48d9-4038-9a10-9bc73c7aab32"></a>
Constraint.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76dcca03-6bbf-4ea2-9403-70affa970fc0'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="76dcca03-6bbf-4ea2-9403-70affa970fc0"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#2fc41b61-b808-44e8-b693-79bd6bcc2f43">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="c594735b-2605-469a-ac3d-2c6288db8ce7"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="31b5bc4b-ff69-4141-9730-433154820713"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="4a5cd11f-81fd-4d6a-9225-683b84ad3e7f"></a>
Constraint.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="59116cbd-588e-4f83-9bc5-d6a48a16fd46"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1d8491f-88cc-4507-a80d-0ac71f132e11'>Draw</a></td><td style='width:75%' ><p><a name="b1d8491f-88cc-4507-a80d-0ac71f132e11"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the hanled into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="c0ce461e-b591-4144-b6f6-27a76fe0da9f"></a>
The <code>SKCanvas</code> to draw the hanled into.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The draw.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b285bd47-9e0f-4db5-af7c-431b57a3262b'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="b285bd47-9e0f-4db5-af7c-431b57a3262b"></a></p>

<h3>MoveTo (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the handle to the given coordinates.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="b9178d70-75fb-411e-984c-c9a36e948415"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="e0d7f956-dff3-4ff0-89c5-e6375785aa8c"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5937049f-4d08-4781-953a-811b976c3dd6'>PointInBound</a></td><td style='width:75%' ><p><a name="5937049f-4d08-4781-953a-811b976c3dd6"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="94cc0fa4-b8ae-4a36-ad22-0896ce654424"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e2d6838-ccdd-43dd-b41f-e30a7149953f'>DragHandle</a></td><td style='width:75%' class='def'><p><a name="5e2d6838-ccdd-43dd-b41f-e30a7149953f"></a></p>

<h3>DragHandle (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the handle.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="5578a31b-c313-437b-bec0-72c023b15881"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0781f8c-abda-4a17-8f5e-6dd0a77474a1'>ToPoint</a></td><td style='width:75%' ><p><a name="a0781f8c-abda-4a17-8f5e-6dd0a77474a1"></a></p>

<h3>ToPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoHandle</code> to a Skia Point.</p>

<h4>Returns</h4>

<p>The <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74b64d53-19fd-44f7-984c-7bdf1b9b010a'>Clone</a></td><td style='width:75%' class='def'><p><a name="74b64d53-19fd-44f7-984c-7bdf1b9b010a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a11971cb-60ab-48d2-ad11-bfcfa8618e93'>RaiseMoved</a></td><td style='width:75%' ><p><a name="a11971cb-60ab-48d2-ad11-bfcfa8618e93"></a></p>

<h3>RaiseMoved (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the moved event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="7d68f1db-4949-4eda-aa9f-315831214783"></a>
Point.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ea9859ca-367d-46f4-9756-9b598fc653b1'>Moved</a></td><td style='width:75%' ><p><a name="ea9859ca-367d-46f4-9756-9b598fc653b1"></a></p>

<h3>Moved</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when moved.</p>
</td></tr></table></p>


---

<a name="6a8e8357-be2d-4256-9931-69e28aeccbcf"></a>
##KimonoHandleConstraint

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Constrains the movement of a `KimonoHandle` when it is being moved by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#68ed1cdc-bd99-4d10-bb8e-1892fd279633'>None</a></td><td style='width:75%' ><p><a name="68ed1cdc-bd99-4d10-bb8e-1892fd279633"></a>
<b>None</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>No movement constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ead25158-ac1e-45c0-866b-d78f32c1e9e2'>Horizontal</a></td><td style='width:75%' class='def'><p><a name="ead25158-ac1e-45c0-866b-d78f32c1e9e2"></a>
<b>Horizontal</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32a95626-3459-4d7b-bb5d-b2b37a7c01a4'>Vertical</a></td><td style='width:75%' ><p><a name="32a95626-3459-4d7b-bb5d-b2b37a7c01a4"></a>
<b>Vertical</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved vertically.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c722fab-967a-4366-8332-40a3babe5c86'>Locked</a></td><td style='width:75%' class='def'><p><a name="2c722fab-967a-4366-8332-40a3babe5c86"></a>
<b>Locked</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle is locked in place and cannot be moved.</p>
</td></tr></table></p>


---

<a name="89ffb335-d560-45f7-a299-d7928b0dfd19"></a>
##KimonoHandleType

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoHandle` that can be used as a general purpose control point to adjust the bounds of a `KimonoShape` or as a point for a vector or bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#47fdf660-59c6-49a7-94a9-3702ff86ef58'>ControlPoint</a></td><td style='width:75%' ><p><a name="47fdf660-59c6-49a7-94a9-3702ff86ef58"></a>
<b>ControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A general purpose handle for a shape's bound or a control point on a  vector or bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80688e9c-a38f-4feb-8211-7ac4d4fd00f9'>GradientColor</a></td><td style='width:75%' class='def'><p><a name="80688e9c-a38f-4feb-8211-7ac4d4fd00f9"></a>
<b>GradientColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines a color inside of a gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf535958-a135-47ff-8a60-910a29a0cf31'>GradientPosition</a></td><td style='width:75%' ><p><a name="bf535958-a135-47ff-8a60-910a29a0cf31"></a>
<b>GradientPosition</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the position of a gradient in a shape object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63aaf83a-30be-4a31-b1b0-fb9d483cb2d8'>BezierControlPoint</a></td><td style='width:75%' class='def'><p><a name="63aaf83a-30be-4a31-b1b0-fb9d483cb2d8"></a>
<b>BezierControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the control point for a <code>KimonoShapeBezier</code> end point used to adjust the curve of a bezier quad section.</p>
</td></tr></table></p>


---

<a name="9ca0ae8d-c6c7-4152-93ff-91a64bea934f"></a>
##KimonoBlur

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a blur effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#87c4b370-708c-4145-8105-0f3aedde4216'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="87c4b370-708c-4145-8105-0f3aedde4216"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa451d21-a4df-4b6e-9964-ce822d46c6a3'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="aa451d21-a4df-4b6e-9964-ce822d46c6a3"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#41f3d788-4f63-41ec-bf27-07f735248175'>Name</a></td><td style='width:75%' ><p><a name="41f3d788-4f63-41ec-bf27-07f735248175"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55a0a25a-7579-4d07-9459-23e8d8536bd5'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="55a0a25a-7579-4d07-9459-23e8d8536bd5"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01657dcd-7bcb-4967-bfdd-ab6f0d5b0ed6'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="01657dcd-7bcb-4967-bfdd-ab6f0d5b0ed6"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f79f7bd5-4761-4f85-bdf2-420902269979'>BlurFilter</a></td><td style='width:75%' class='def'><p><a name="f79f7bd5-4761-4f85-bdf2-420902269979"></a></p>

<h3>BlurFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the blur filter represented by this blur effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a04ea0a5-5d55-446a-b790-e19c36df8622'>KimonoBlur</a></td><td style='width:75%' ><p><a name="a04ea0a5-5d55-446a-b790-e19c36df8622"></a></p>

<h3>KimonoBlur ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9ca0ae8d-c6c7-4152-93ff-91a64bea934f">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89576fc0-3662-46e6-8a09-56f2ccc2fb0a'>KimonoBlur</a></td><td style='width:75%' class='def'><p><a name="89576fc0-3662-46e6-8a09-56f2ccc2fb0a"></a></p>

<h3>KimonoBlur (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9ca0ae8d-c6c7-4152-93ff-91a64bea934f">KimonoBlur</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p><a name="b61e1187-0223-412a-9995-282265591283"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="b6794dbd-2cb5-467e-9df5-b79846ad2985"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7778cd5d-1e57-428e-967c-a9818c77e63f'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="7778cd5d-1e57-428e-967c-a9818c77e63f"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cf29177-3c9d-4eb4-a409-6bcb5972a94f'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="7cf29177-3c9d-4eb4-a409-6bcb5972a94f"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="458e0e15-c739-4665-ab90-ce591d089dd5"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45e6a270-175b-4840-bc1a-c5543feeae3e'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="45e6a270-175b-4840-bc1a-c5543feeae3e"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the Skia library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3bf4435b-a40c-4d8b-b976-f719cfbf1017'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="3bf4435b-a40c-4d8b-b976-f719cfbf1017"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5601ba0e-a553-42c9-b639-0f56867266de'>ToCode</a></td><td style='width:75%' ><p><a name="5601ba0e-a553-42c9-b639-0f56867266de"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="bbe3dd46-b3b0-4577-98cf-cce2013700a4"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8775a081-830e-42c3-a577-c9b9c0511a53"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2b907cbd-26bc-48ec-9f7f-9f78fb1e1137"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#086825a2-7965-4ede-8d32-d0fec2d5fe45'>Clone</a></td><td style='width:75%' class='def'><p><a name="086825a2-7965-4ede-8d32-d0fec2d5fe45"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8b747d7-8791-4ee1-84e9-3fd77e967bd0'>RaiseBlurModified</a></td><td style='width:75%' ><p><a name="d8b747d7-8791-4ee1-84e9-3fd77e967bd0"></a></p>

<h3>RaiseBlurModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the blur modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2fbd0218-0e47-4a4c-a0b5-dc360c5c0dc6'>BlurModified</a></td><td style='width:75%' ><p><a name="2fbd0218-0e47-4a4c-a0b5-dc360c5c0dc6"></a></p>

<h3>BlurModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the blur is modified.</p>
</td></tr></table></p>


---

<a name="e95d9c4c-885c-423e-bce8-8c9818c2f0cd"></a>
##KimonoShadow

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a shadow effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#05a33c42-2346-48b3-93db-eaa841cea2b6'>_horizontalOffset</a></td><td style='width:75%' ><p><a name="05a33c42-2346-48b3-93db-eaa841cea2b6"></a>
<b>_horizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23bb0c80-645a-4588-98e3-b48257a0672a'>_verticalOffset</a></td><td style='width:75%' class='def'><p><a name="23bb0c80-645a-4588-98e3-b48257a0672a"></a>
<b>_verticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#240a2253-abc8-4bfb-9191-a8a65bca7abd'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="240a2253-abc8-4bfb-9191-a8a65bca7abd"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c7e674d-8912-472d-9b73-696b32939c8e'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="0c7e674d-8912-472d-9b73-696b32939c8e"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6069bdbf-b0ec-455c-8157-67dd220113b4'>_color</a></td><td style='width:75%' ><p><a name="6069bdbf-b0ec-455c-8157-67dd220113b4"></a>
<b>_color</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07e6b71a-4bd4-4836-97c5-de4011b2b6fd'>_linkedColor</a></td><td style='width:75%' class='def'><p><a name="07e6b71a-4bd4-4836-97c5-de4011b2b6fd"></a>
<b>_linkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A linked <code>KimonoColor</code> to use as the shadow color.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5ce23ab0-704a-4a68-a240-db060cdd5a62'>Name</a></td><td style='width:75%' ><p><a name="5ce23ab0-704a-4a68-a240-db060cdd5a62"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a59874fc-4e7b-490d-9220-fff55f1dc3a1'>HorizontalOffset</a></td><td style='width:75%' class='def'><p><a name="a59874fc-4e7b-490d-9220-fff55f1dc3a1"></a></p>

<h3>HorizontalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal offset.</p>

<h4>Return Value</h4>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14663124-02e6-480a-99df-ade18e9458fb'>VerticalOffset</a></td><td style='width:75%' ><p><a name="14663124-02e6-480a-99df-ade18e9458fb"></a></p>

<h3>VerticalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical offset.</p>

<h4>Return Value</h4>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f95e2cb-9daf-4d06-806f-70e87f22cc48'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="8f95e2cb-9daf-4d06-806f-70e87f22cc48"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ec356f4-c673-4fa6-8a96-f51ecf29ea37'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="7ec356f4-c673-4fa6-8a96-f51ecf29ea37"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#272ce3f8-8fc8-4fe2-aba2-df74d887aa17'>Color</a></td><td style='width:75%' class='def'><p><a name="272ce3f8-8fc8-4fe2-aba2-df74d887aa17"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91e22d71-f56c-423f-a38e-a296ffb2e253'>LinkedColor</a></td><td style='width:75%' ><p><a name="91e22d71-f56c-423f-a38e-a296ffb2e253"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the linked.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#299c0fa2-45b3-461c-a750-d45e58f69761'>ShadowColor</a></td><td style='width:75%' class='def'><p><a name="299c0fa2-45b3-461c-a750-d45e58f69761"></a></p>

<h3>ShadowColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color of the shadow as a <code>SKColor</code>.</p>

<h4>Remarks</h4>

<p>Returns either the custom color attached to this shadow or a linked color if it is being used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14ae00e5-cc87-4e94-91ea-d8f60b562f2b'>ShadowFilter</a></td><td style='width:75%' ><p><a name="14ae00e5-cc87-4e94-91ea-d8f60b562f2b"></a></p>

<h3>ShadowFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the shadoe filter represented by this shadow effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f8dae9a1-3572-4cff-89e9-29d51baeb2ee'>KimonoShadow</a></td><td style='width:75%' ><p><a name="f8dae9a1-3572-4cff-89e9-29d51baeb2ee"></a></p>

<h3>KimonoShadow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e95d9c4c-885c-423e-bce8-8c9818c2f0cd">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0632eec-0ce1-43ca-8cd2-3962fac68afe'>KimonoShadow</a></td><td style='width:75%' class='def'><p><a name="c0632eec-0ce1-43ca-8cd2-3962fac68afe"></a></p>

<h3>KimonoShadow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e95d9c4c-885c-423e-bce8-8c9818c2f0cd">KimonoShadow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalOffset</td><td style='width:75%' ><p><a name="650b7f06-17a8-465c-a48a-147e45a07233"></a>
Horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' class='def'><p><a name="14e3a661-5d5e-438c-95ed-1f8c44b146ac"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalOffset</td><td style='width:75%' ><p><a name="3125c246-0d13-4668-b3c4-18b454de1588"></a>
Vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="7c6a4ece-a895-4533-99c0-5e3544e1a1b4"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b88f589f-22d6-40a8-9b84-fc66e471f41d'>HandleLinkedColorChanged</a></td><td style='width:75%' ><p><a name="b88f589f-22d6-40a8-9b84-fc66e471f41d"></a></p>

<h3>HandleLinkedColorChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the linked color changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe82767a-ef37-47ad-8efe-91902610e43a'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="fe82767a-ef37-47ad-8efe-91902610e43a"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fb1d376-5de1-4b89-b1c3-4a1c8e3bd93b'>ToCSharp</a></td><td style='width:75%' ><p><a name="1fb1d376-5de1-4b89-b1c3-4a1c8e3bd93b"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="01799c81-0f99-4ae1-82f5-edd0f7508f79"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#128e8788-59e9-4fd4-88ac-847721430483'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="128e8788-59e9-4fd4-88ac-847721430483"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e71fe6b-d90a-48c4-8c58-f14cf4ea8c74'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="4e71fe6b-d90a-48c4-8c58-f14cf4ea8c74"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9178759-75e7-4a95-805c-01c3989aae0f'>ToCode</a></td><td style='width:75%' class='def'><p><a name="e9178759-75e7-4a95-805c-01c3989aae0f"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="abe6f7b3-bb3b-4652-a248-7c4f157fee20"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="aef0fd00-9528-4ac3-b060-0b5d65e4f490"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b700b83d-6866-48cf-91f6-bafad397da8b"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#899ea1a7-302b-4026-8965-4d17ec787310'>Clone</a></td><td style='width:75%' ><p><a name="899ea1a7-302b-4026-8965-4d17ec787310"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3486f0b6-3069-4ca6-8331-bab00ac23d7f'>RaiseShadowModified</a></td><td style='width:75%' class='def'><p><a name="3486f0b6-3069-4ca6-8331-bab00ac23d7f"></a></p>

<h3>RaiseShadowModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the shadow modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#467f3d0e-aba4-4d99-8963-54ce2e183714'>ShadowModified</a></td><td style='width:75%' ><p><a name="467f3d0e-aba4-4d99-8963-54ce2e183714"></a></p>

<h3>ShadowModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the shadow is modified.</p>
</td></tr></table></p>


---

<a name="97d9de78-15ec-413e-bcb5-87e86f5120ba"></a>
##KimonoGradient

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a gradient as a collection of either `SKColor` or linked `KimonoColors` that can be applied to a `KimonoStyle` and used when drawing a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5d4dd492-5b6b-467d-9d4f-535af20e22aa'>_gradientType</a></td><td style='width:75%' ><p><a name="5d4dd492-5b6b-467d-9d4f-535af20e22aa"></a>
<b>_gradientType</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6ee01b8-4c61-4983-b15b-26a358a0ea67'>_startPoint</a></td><td style='width:75%' class='def'><p><a name="e6ee01b8-4c61-4983-b15b-26a358a0ea67"></a>
<b>_startPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51b5e06a-2b0f-4631-b1b0-0b9d93e6fb9c'>_endPoint</a></td><td style='width:75%' ><p><a name="51b5e06a-2b0f-4631-b1b0-0b9d93e6fb9c"></a>
<b>_endPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb7f7d64-5d6e-499e-b051-83680416abfe'>_radius</a></td><td style='width:75%' class='def'><p><a name="cb7f7d64-5d6e-499e-b051-83680416abfe"></a>
<b>_radius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radius for radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c506b19-9960-4bc3-80cd-4dca12a90e92'>_tileMode</a></td><td style='width:75%' ><p><a name="8c506b19-9960-4bc3-80cd-4dca12a90e92"></a>
<b>_tileMode</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The gradient tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d221ed9a-a6a8-4fb3-aba3-2c84bc758ba9'>_selectedHandle</a></td><td style='width:75%' class='def'><p><a name="d221ed9a-a6a8-4fb3-aba3-2c84bc758ba9"></a>
<b>_selectedHandle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#845d27d6-1649-47ad-8449-0ce5e42a261f'>PerformingDrag</a></td><td style='width:75%' ><p><a name="845d27d6-1649-47ad-8449-0ce5e42a261f"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Is the user performing a drag operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1ca7d99f-2693-4059-906f-607803c62a04'>GradientType</a></td><td style='width:75%' ><p><a name="1ca7d99f-2693-4059-906f-607803c62a04"></a></p>

<h3>GradientType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the gradient.</p>

<h4>Return Value</h4>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#784f8147-f800-4b9c-8596-b5f93467d85b'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="784f8147-f800-4b9c-8596-b5f93467d85b"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44895f67-7d0c-4fdb-a28a-cce3a30629fe'>ElementName</a></td><td style='width:75%' ><p><a name="44895f67-7d0c-4fdb-a28a-cce3a30629fe"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dbdaf47-2de9-411d-be58-04020f3c980e'>Name</a></td><td style='width:75%' class='def'><p><a name="3dbdaf47-2de9-411d-be58-04020f3c980e"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37c9c0fe-b08c-4669-9f91-d7244b9d8db5'>BarWidth</a></td><td style='width:75%' ><p><a name="37c9c0fe-b08c-4669-9f91-d7244b9d8db5"></a></p>

<h3>BarWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the bar.</p>

<h4>Return Value</h4>

<p>The width of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06a3121a-e934-481b-b6dd-eeca66cf2269'>BarHeight</a></td><td style='width:75%' class='def'><p><a name="06a3121a-e934-481b-b6dd-eeca66cf2269"></a></p>

<h3>BarHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the bar.</p>

<h4>Return Value</h4>

<p>The height of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b42be967-f5c9-405f-a2c8-5b9be7e01c59'>PreviewWidth</a></td><td style='width:75%' ><p><a name="b42be967-f5c9-405f-a2c8-5b9be7e01c59"></a></p>

<h3>PreviewWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the preview.</p>

<h4>Return Value</h4>

<p>The width of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#883a0c58-2337-4d6b-9124-2853135a35b7'>PreviewHeight</a></td><td style='width:75%' class='def'><p><a name="883a0c58-2337-4d6b-9124-2853135a35b7"></a></p>

<h3>PreviewHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the preview.</p>

<h4>Return Value</h4>

<p>The height of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#587f5780-3b4d-4948-9136-23689b125130'>StartPoint</a></td><td style='width:75%' ><p><a name="587f5780-3b4d-4948-9136-23689b125130"></a></p>

<h3>StartPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the start point.</p>

<h4>Return Value</h4>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db065208-357d-48b1-a023-25b73976f907'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="db065208-357d-48b1-a023-25b73976f907"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca1f40d5-6bae-4ef3-be73-1d2bce720913'>Radius</a></td><td style='width:75%' ><p><a name="ca1f40d5-6bae-4ef3-be73-1d2bce720913"></a></p>

<h3>Radius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the radius used by radial and conical gradients.</p>

<h4>Return Value</h4>

<p>The radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#699c5af2-2e0d-42d8-90b1-8173a92aab7a'>TileMode</a></td><td style='width:75%' class='def'><p><a name="699c5af2-2e0d-42d8-90b1-8173a92aab7a"></a></p>

<h3>TileMode</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tile mode.</p>

<h4>Return Value</h4>

<p>The tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3359b09b-7337-4520-9268-1ee09ce29f1b'>ControlPoints</a></td><td style='width:75%' ><p><a name="3359b09b-7337-4520-9268-1ee09ce29f1b"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the color.</p>

<h4>Return Value</h4>

<p>The control points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0220f745-3d15-458b-b3c9-991174171f4f'>SelectedHandle</a></td><td style='width:75%' class='def'><p><a name="0220f745-3d15-458b-b3c9-991174171f4f"></a></p>

<h3>SelectedHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected handle.</p>

<h4>Return Value</h4>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f58ac2ac-278c-4769-9e94-78752dad0d9f'>SelectedColor</a></td><td style='width:75%' ><p><a name="f58ac2ac-278c-4769-9e94-78752dad0d9f"></a></p>

<h3>SelectedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the selected handle.</p>

<h4>Return Value</h4>

<p>The color of the selected handle or black if no handle is selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2405f94c-e2a3-4d32-b56a-8a7a181a4c0e'>Shader</a></td><td style='width:75%' class='def'><p><a name="2405f94c-e2a3-4d32-b56a-8a7a181a4c0e"></a></p>

<h3>Shader</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the Skia Shader that represents this gradient.</p>

<h4>Return Value</h4>

<p>The <code>SKShader</code> for this gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cdf847fe-b831-4346-a468-44ddac8043c9'>KimonoGradient</a></td><td style='width:75%' ><p><a name="cdf847fe-b831-4346-a468-44ddac8043c9"></a></p>

<h3>KimonoGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#97d9de78-15ec-413e-bcb5-87e86f5120ba">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc142f0-0516-414f-9c5e-88468c0ed4e5'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="2fc142f0-0516-414f-9c5e-88468c0ed4e5"></a></p>

<h3>KimonoGradient (KimonoCore.KimonoGradientType, KimonoCore.KimonoHandle, KimonoCore.KimonoHandle, System.Single, SkiaSharp.SKShaderTileMode, SkiaSharp.SKColor[], System.Single[])</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#97d9de78-15ec-413e-bcb5-87e86f5120ba">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradientType</td><td style='width:75%' ><p><a name="886f1b84-c767-47dd-8b18-3fdc47d43a2c"></a>
Gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="a8cf27b4-32ff-433e-afcc-88c6e6b7ad2c"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="c27175e9-4af5-492f-afa0-13007fab45c1"></a>
End point.</p>
</td></tr><tr><td style='width:25%' class='term'>radius</td><td style='width:75%' class='def'><p><a name="63273d4e-40bf-41dc-931c-37c0719e993d"></a>
Radius.</p>
</td></tr><tr><td style='width:25%' class='term'>tileMode</td><td style='width:75%' ><p><a name="ac6ee8b6-9177-475a-818a-44cefbdf05ad"></a>
Tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'>colors</td><td style='width:75%' class='def'><p><a name="92352748-4d89-42e5-8563-b6e8fec251d8"></a>
Colors.</p>
</td></tr><tr><td style='width:25%' class='term'>weights</td><td style='width:75%' ><p><a name="171d295e-2efa-4bd9-a242-ba966cdfbf2f"></a>
Weights.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7158f80-fbe0-438e-bbaf-92f46c4fb92e'>KimonoGradient</a></td><td style='width:75%' ><p><a name="d7158f80-fbe0-438e-bbaf-92f46c4fb92e"></a></p>

<h3>KimonoGradient (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#97d9de78-15ec-413e-bcb5-87e86f5120ba">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="897e7bc2-bebb-4b8b-89a3-3c71291f14e6"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="91f655f5-254c-4a65-8e0c-1332808df500"></a>
Bar height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c6069ef-e2ff-490d-bc93-f182070a28e3'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="5c6069ef-e2ff-490d-bc93-f182070a28e3"></a></p>

<h3>KimonoGradient (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#97d9de78-15ec-413e-bcb5-87e86f5120ba">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="2bbc9fd8-05d0-4a1f-b8b9-7512289d8d5d"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="71c952fe-1587-45ee-a8aa-66bb15682731"></a>
Bar height.</p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p><a name="4d56e057-63c2-4c6e-86f8-506fc6529c83"></a>
Preview width.</p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p><a name="2eac6444-2df9-4b0d-a457-c488e60a91b5"></a>
Preview height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30a2ac8d-6df9-4ed8-9067-cac8f5b12d10'>Initialize</a></td><td style='width:75%' ><p><a name="30a2ac8d-6df9-4ed8-9067-cac8f5b12d10"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4edd688d-654d-49bb-80af-e64cf4b0c3ff'>SortedColors</a></td><td style='width:75%' class='def'><p><a name="4edd688d-654d-49bb-80af-e64cf4b0c3ff"></a></p>

<h3>SortedColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list of sorted colors by their "X" location inside the gradient.</p>

<h4>Returns</h4>

<p>The sorted colors arrays.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24a69518-d5e9-488b-bba5-69f58e737ae0'>SortedWeights</a></td><td style='width:75%' ><p><a name="24a69518-d5e9-488b-bba5-69f58e737ae0"></a></p>

<h3>SortedWeights ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list a color weights by their "X" location in the gradient.</p>

<h4>Returns</h4>

<p>The sorted weights.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#959ab9f2-c837-40c9-acfd-f14e79a69375'>ConformingShader</a></td><td style='width:75%' class='def'><p><a name="959ab9f2-c837-40c9-acfd-f14e79a69375"></a></p>

<h3>ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Generates a shader that conforms to a given start and end point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="32051fbd-4ba2-4048-a9fd-8dca613ada2b"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="4bf194b5-3f02-4438-ab33-2d8e65a72945"></a>
End point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>SKShader</code> for the gradient bound to a given shape's dimentions.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0909509-55b7-49ad-a275-daabdd206ef3'>AddControlPoint</a></td><td style='width:75%' ><p><a name="d0909509-55b7-49ad-a275-daabdd206ef3"></a></p>

<h3>AddControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new control point to the gradients collection and makes it the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2314eb69-bb2e-46c3-912c-5da0b13cb2d2'>DeleteSelectedControlPoint</a></td><td style='width:75%' class='def'><p><a name="2314eb69-bb2e-46c3-912c-5da0b13cb2d2"></a></p>

<h3>DeleteSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b7ae6aa-fe39-43e0-bed7-c014cd81e61d'>DuplicateSelectedControlPoint</a></td><td style='width:75%' ><p><a name="3b7ae6aa-fe39-43e0-bed7-c014cd81e61d"></a></p>

<h3>DuplicateSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b324575-9c86-4294-ba8b-1d05693a8ca5'>FindHandle</a></td><td style='width:75%' class='def'><p><a name="5b324575-9c86-4294-ba8b-1d05693a8ca5"></a></p>

<h3>FindHandle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the handle matching the given unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="54564408-64b6-496d-bd1c-4b8990536b08"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The matching <code>KimonoHandle</code> or <code>null</code> if not found.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b63af73-a6cf-471f-95a1-f3be511748e0'>DrawBar</a></td><td style='width:75%' ><p><a name="6b63af73-a6cf-471f-95a1-f3be511748e0"></a></p>

<h3>DrawBar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bar.</p>

<h4>Returns</h4>

<p>The bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6585f443-c118-4c0d-b65b-f0c06fbacbfa'>DrawPreview</a></td><td style='width:75%' class='def'><p><a name="6585f443-c118-4c0d-b65b-f0c06fbacbfa"></a></p>

<h3>DrawPreview ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the preview.</p>

<h4>Returns</h4>

<p>The preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c1e680f-eebd-41a3-a92e-c94f7e1b9e4d'>BarToolDown</a></td><td style='width:75%' ><p><a name="6c1e680f-eebd-41a3-a92e-c94f7e1b9e4d"></a></p>

<h3>BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ab2e0332-2c1a-4851-9b51-40aedc7a8626"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="00c9107c-59b3-4d13-9289-1b6ed8951eaa"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="3c79fd6c-2a3c-4396-b9e4-604f55102e4e"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa97180d-9f4a-47c2-85c0-4294c4a94633'>BarToolDrag</a></td><td style='width:75%' class='def'><p><a name="fa97180d-9f4a-47c2-85c0-4294c4a94633"></a></p>

<h3>BarToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient design bar. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="513cb00d-5ab9-42eb-90bf-598f5fa7225f"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5caa34a1-8173-4f24-8d9b-d76391303c02'>BarToolUp</a></td><td style='width:75%' ><p><a name="5caa34a1-8173-4f24-8d9b-d76391303c02"></a></p>

<h3>BarToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="87238072-97f4-4b43-8c42-5389cd36700f"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb6e461c-37c0-4195-a0a1-581f8ba80f1c'>PreviewToolDown</a></td><td style='width:75%' class='def'><p><a name="bb6e461c-37c0-4195-a0a1-581f8ba80f1c"></a></p>

<h3>PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="361d178b-0e03-4b9e-871e-6df735d8fd32"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="5d45741b-a87f-46fb-a32e-60bb17133b62"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="b2bd6fcb-08a1-4879-ad09-3d291c1691db"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9950b75-0423-4221-9a96-4b88304231da'>PreviewToolDrag</a></td><td style='width:75%' ><p><a name="c9950b75-0423-4221-9a96-4b88304231da"></a></p>

<h3>PreviewToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient preview. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d6211eba-dea6-45e9-a56b-b199e08bbcd5"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95d698d9-5eb9-4d8f-941f-5f84240205d9'>PreviewToolUp</a></td><td style='width:75%' class='def'><p><a name="95d698d9-5eb9-4d8f-941f-5f84240205d9"></a></p>

<h3>PreviewToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d3cd1147-ca07-4872-a84a-01ad07d86f51"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22910fc5-5de3-4ada-97eb-96995a741bf9'>ToObiScript</a></td><td style='width:75%' ><p><a name="22910fc5-5de3-4ada-97eb-96995a741bf9"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e707025-e9dd-4a11-9c40-9481b21aca97'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="5e707025-e9dd-4a11-9c40-9481b21aca97"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68347f3d-3f3c-459b-981b-720fc5acfb43'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="68347f3d-3f3c-459b-981b-720fc5acfb43"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#539c6b92-c8df-45c1-a701-b75f2c8b3e79'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="539c6b92-c8df-45c1-a701-b75f2c8b3e79"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67b8864e-0e47-4f90-a49d-526e179fb0d1'>ColorsToCode</a></td><td style='width:75%' ><p><a name="67b8864e-0e47-4f90-a49d-526e179fb0d1"></a></p>

<h3>ColorsToCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62f928f5-a2cc-4a40-8350-2105f04d774e'>ColorsToInitializer</a></td><td style='width:75%' class='def'><p><a name="62f928f5-a2cc-4a40-8350-2105f04d774e"></a></p>

<h3>ColorsToInitializer (KimonoCore.CodeOutputLibrary, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6594247-ee71-4872-9463-3458422289de'>WeightsToSkiaCode</a></td><td style='width:75%' ><p><a name="c6594247-ee71-4872-9463-3458422289de"></a></p>

<h3>WeightsToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f607e8a-c73a-40fd-8485-a818437f7020'>WeightsToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="7f607e8a-c73a-40fd-8485-a818437f7020"></a></p>

<h3>WeightsToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cc3cb4b-76b5-432c-81f9-c32ec8f3d5e3'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="3cc3cb4b-76b5-432c-81f9-c32ec8f3d5e3"></a></p>

<h3>ToCSharpSkia ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b0d5171-20c7-4f1d-afaf-3ac45f143e58'>ToCSharpSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="7b0d5171-20c7-4f1d-afaf-3ac45f143e58"></a></p>

<h3>ToCSharpSkiaInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81e21e83-7469-4907-85cf-b0f767473fd1'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="81e21e83-7469-4907-85cf-b0f767473fd1"></a></p>

<h3>ToCSharpSkia (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="c3242c8b-c7e2-477f-80c0-6928ee71a54d"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="81fc50c3-0d44-459f-9155-06d9acf33d32"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c1b5136-9ea9-428f-96fd-65e8822de51f'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="1c1b5136-9ea9-428f-96fd-65e8822de51f"></a></p>

<h3>ToCSharpKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1bf7ec3d-8649-483b-b400-c5ff1c550795'>ToCSharpKimonoCoreInitializer</a></td><td style='width:75%' ><p><a name="1bf7ec3d-8649-483b-b400-c5ff1c550795"></a></p>

<h3>ToCSharpKimonoCoreInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87be011e-a0ed-46e7-80ba-ac4aa8e72e07'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="87be011e-a0ed-46e7-80ba-ac4aa8e72e07"></a></p>

<h3>ToCSharpKimonoCore (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="657380bf-c3a1-40d8-935e-0ba2d12a6d5a"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="20861817-37f1-46a6-a8b8-09f9b423109b"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76c8ff19-74da-41e2-85dc-3478701d2ad6'>ToCSharp</a></td><td style='width:75%' ><p><a name="76c8ff19-74da-41e2-85dc-3478701d2ad6"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="64018d7a-8acb-4176-bc83-f1e97486006a"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9330e71a-3d24-4709-a810-c36418012276'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="9330e71a-3d24-4709-a810-c36418012276"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e94b86a5-7514-4962-b7c6-1e33af5d7c1b"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a5a2135-040a-4206-b71c-c7a2903002b9'>ToCSharp</a></td><td style='width:75%' ><p><a name="5a5a2135-040a-4206-b71c-c7a2903002b9"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5c71e96e-4a46-47ae-8eed-f93d977a0188"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="a74c2676-cfa2-4cb8-8b83-b015533d91b0"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="97c8685e-6689-42c7-a803-334434f9fefa"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6689f03c-7923-4442-866a-c388a1e15741'>ToCode</a></td><td style='width:75%' class='def'><p><a name="6689f03c-7923-4442-866a-c388a1e15741"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="844e9c09-7aaa-406e-8d4f-80093704e1c7"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e154ec8b-45b6-407b-90a8-175e1c66e5e7"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="bb2066cc-45c3-4c4b-9a7b-5edd9846e675"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9165c3c4-8537-4072-8e44-d8d34295373f'>Clone</a></td><td style='width:75%' ><p><a name="9165c3c4-8537-4072-8e44-d8d34295373f"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25e7b081-7ad3-41fc-8676-df67f26fe234'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p><a name="25e7b081-7ad3-41fc-8676-df67f26fe234"></a></p>

<h3>RaiseGradientModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85256de3-6ed4-45b2-818c-22a47a63ddf0'>RaiseHandleSelected</a></td><td style='width:75%' ><p><a name="85256de3-6ed4-45b2-818c-22a47a63ddf0"></a></p>

<h3>RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="21b1cc60-719f-40de-ba25-1430ad5714d7"></a>
Handle.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5cbdb2d1-0524-4a82-b9e9-a421fc9702f5'>GradientModified</a></td><td style='width:75%' ><p><a name="5cbdb2d1-0524-4a82-b9e9-a421fc9702f5"></a></p>

<h3>GradientModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8018152b-8374-44d0-ae4d-82f0c2791bf6'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="8018152b-8374-44d0-ae4d-82f0c2791bf6"></a></p>

<h3>HandleSelected</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="94a41559-8431-4070-899d-32afe0fb3de5"></a>
##KimonoGradientType

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Kimono gradient type.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1cc84292-1f1b-4425-b08f-967fdc45efe6'>LinearGradient</a></td><td style='width:75%' ><p><a name="1cc84292-1f1b-4425-b08f-967fdc45efe6"></a>
<b>LinearGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The linear gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe88e850-b223-45e9-83ff-f3b5a6964c3d'>RadialGradient</a></td><td style='width:75%' class='def'><p><a name="fe88e850-b223-45e9-83ff-f3b5a6964c3d"></a>
<b>RadialGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radial gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b48602a0-23bf-4666-bf16-ff072b01467e'>SweepGradient</a></td><td style='width:75%' ><p><a name="b48602a0-23bf-4666-bf16-ff072b01467e"></a>
<b>SweepGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The sweep gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea14e008-fe39-4a72-9edc-0af653673a10'>ConicalGradient</a></td><td style='width:75%' class='def'><p><a name="ea14e008-fe39-4a72-9edc-0af653673a10"></a>
<b>ConicalGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The conical gradient.</p>
</td></tr></table></p>


---

<a name="ae402a36-7d15-4faf-8c84-e03e0a0ca155"></a>
##KimonoStyle

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines as style that can be applied to a `KimonoShape` to control its appearance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4285b85d-604d-4aad-85c2-f409502199d1'>_frameColor</a></td><td style='width:75%' ><p><a name="4285b85d-604d-4aad-85c2-f409502199d1"></a>
<b>_frameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's frame color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6dbf7b8f-6299-49ed-a7fb-7ddefebf4da4'>_fillColor</a></td><td style='width:75%' class='def'><p><a name="6dbf7b8f-6299-49ed-a7fb-7ddefebf4da4"></a>
<b>_fillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's fill color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09157448-624d-4f5b-9725-eea86467cc3e'>_frameGradient</a></td><td style='width:75%' ><p><a name="09157448-624d-4f5b-9725-eea86467cc3e"></a>
<b>_frameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7b015fb-91b8-48e7-b5b3-c35618483a34'>_fillGradient</a></td><td style='width:75%' class='def'><p><a name="c7b015fb-91b8-48e7-b5b3-c35618483a34"></a>
<b>_fillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a730c9a-9ab0-4c64-aa28-aa6bd6b1e4fd'>_hasFrameJitter</a></td><td style='width:75%' ><p><a name="1a730c9a-9ab0-4c64-aa28-aa6bd6b1e4fd"></a>
<b>_hasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cb16c9d-7c90-4d93-8364-2cf1a973cc18'>_frameJitterLength</a></td><td style='width:75%' class='def'><p><a name="8cb16c9d-7c90-4d93-8364-2cf1a973cc18"></a>
<b>_frameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0694c964-bd58-4b8f-bb51-21059db216f3'>_frameJitterDeviation</a></td><td style='width:75%' ><p><a name="0694c964-bd58-4b8f-bb51-21059db216f3"></a>
<b>_frameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e254bc4-3cda-46ce-bc2b-069038eda296'>_hasFillJitter</a></td><td style='width:75%' class='def'><p><a name="6e254bc4-3cda-46ce-bc2b-069038eda296"></a>
<b>_hasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the fill uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#552bb875-58d3-4c50-b92e-f9da8f6c0969'>_fillJitterLength</a></td><td style='width:75%' ><p><a name="552bb875-58d3-4c50-b92e-f9da8f6c0969"></a>
<b>_fillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1319d18a-a3d9-4165-871e-524835ea5f06'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="1319d18a-a3d9-4165-871e-524835ea5f06"></a>
<b>_fillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aea10349-b4f6-4c62-8dd5-7023da9e862e'>_hasFrameDash</a></td><td style='width:75%' ><p><a name="aea10349-b4f6-4c62-8dd5-7023da9e862e"></a>
<b>_hasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame has a dash effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9ee4762-3592-4c17-9b8d-948c659547b6'>_hasFillBlur</a></td><td style='width:75%' class='def'><p><a name="e9ee4762-3592-4c17-9b8d-948c659547b6"></a>
<b>_hasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3354caf1-f44f-4f0c-ba22-ce42e901a3a9'>_fillBlur</a></td><td style='width:75%' ><p><a name="3354caf1-f44f-4f0c-ba22-ce42e901a3a9"></a>
<b>_fillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6c9aae8-98f0-4138-aac5-198559bc474a'>_hasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="b6c9aae8-98f0-4138-aac5-198559bc474a"></a>
<b>_hasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a6919e1-5236-4c69-ade9-02463e28c923'>_frameBlur</a></td><td style='width:75%' ><p><a name="5a6919e1-5236-4c69-ade9-02463e28c923"></a>
<b>_frameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab93867c-1f6b-4ccf-b5ad-6b9a390e11d7'>_hasFillShadow</a></td><td style='width:75%' class='def'><p><a name="ab93867c-1f6b-4ccf-b5ad-6b9a390e11d7"></a>
<b>_hasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#deece801-7048-4a51-8c5d-9fb54dc9b44f'>_fillShadow</a></td><td style='width:75%' ><p><a name="deece801-7048-4a51-8c5d-9fb54dc9b44f"></a>
<b>_fillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd968e7d-a452-494b-8f8c-b77c1458e3a0'>_hasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="fd968e7d-a452-494b-8f8c-b77c1458e3a0"></a>
<b>_hasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96f62e01-1d75-490a-aa37-200536a48c73'>_frameShadow</a></td><td style='width:75%' ><p><a name="96f62e01-1d75-490a-aa37-200536a48c73"></a>
<b>_frameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9739d9f7-d0a9-41ed-96f5-03145912b727'>UniqueID</a></td><td style='width:75%' ><p><a name="9739d9f7-d0a9-41ed-96f5-03145912b727"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21862647-5e9f-42be-b51a-c5f6f9e3637e'>ElementName</a></td><td style='width:75%' class='def'><p><a name="21862647-5e9f-42be-b51a-c5f6f9e3637e"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7d89a65-c58f-4b4c-82a4-2203509eb55d'>Name</a></td><td style='width:75%' ><p><a name="e7d89a65-c58f-4b4c-82a4-2203509eb55d"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbbf94c1-5a49-4ed5-98ff-6c0a5b4b2777'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="dbbf94c1-5a49-4ed5-98ff-6c0a5b4b2777"></a></p>

<h3>HasFrame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> has a frame.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82dc25c9-1ed7-4748-96c9-21e31f2e0132'>Frame</a></td><td style='width:75%' ><p><a name="82dc25c9-1ed7-4748-96c9-21e31f2e0132"></a></p>

<h3>Frame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02c7dc86-1efa-44a1-8748-d585db10d8b0'>HasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="02c7dc86-1efa-44a1-8748-d585db10d8b0"></a></p>

<h3>HasFrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> has frame blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2efc2ffb-cd84-4d48-a58e-676edb16b56d'>FrameBlur</a></td><td style='width:75%' ><p><a name="2efc2ffb-cd84-4d48-a58e-676edb16b56d"></a></p>

<h3>FrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dffbfb1-9757-434b-bf19-d44e1a73b344'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="0dffbfb1-9757-434b-bf19-d44e1a73b344"></a></p>

<h3>HasFrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> has frame shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52a5fe20-8bce-4231-880e-bcae87e8fa3e'>FrameShadow</a></td><td style='width:75%' ><p><a name="52a5fe20-8bce-4231-880e-bcae87e8fa3e"></a></p>

<h3>FrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame shadow.</p>

<h4>Return Value</h4>

<p>The frame shadow as a <code>KimonoShadow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f3ab0a6-5173-4b9a-a638-92b1a236452e'>HasFillBlur</a></td><td style='width:75%' class='def'><p><a name="5f3ab0a6-5173-4b9a-a638-92b1a236452e"></a></p>

<h3>HasFillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> has fill blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d023ac1-bf87-4636-9c26-9263c7fc59b9'>FillBlur</a></td><td style='width:75%' ><p><a name="6d023ac1-bf87-4636-9c26-9263c7fc59b9"></a></p>

<h3>FillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a76bcd8-67cd-4080-98b0-b3c61cb8d491'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="3a76bcd8-67cd-4080-98b0-b3c61cb8d491"></a></p>

<h3>HasFillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> has fill shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3d27cf6-effe-4986-978d-e9546474d00b'>FillShadow</a></td><td style='width:75%' ><p><a name="f3d27cf6-effe-4986-978d-e9546474d00b"></a></p>

<h3>FillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill shadow.</p>

<h4>Return Value</h4>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e831d1e4-30b5-4c59-912a-75cdc6b96822'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="e831d1e4-30b5-4c59-912a-75cdc6b96822"></a></p>

<h3>FrameColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the frame as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6dcd5ed-a0f6-4172-aa81-4e060e012bbe'>FrameGradient</a></td><td style='width:75%' ><p><a name="a6dcd5ed-a0f6-4172-aa81-4e060e012bbe"></a></p>

<h3>FrameGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame gradient.</p>

<h4>Return Value</h4>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf2468f1-e251-4cf7-bc09-b1f1e7055741'>HasFill</a></td><td style='width:75%' class='def'><p><a name="cf2468f1-e251-4cf7-bc09-b1f1e7055741"></a></p>

<h3>HasFill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> has fill.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb5ac701-2825-4db2-88db-a9ff444f37df'>Fill</a></td><td style='width:75%' ><p><a name="cb5ac701-2825-4db2-88db-a9ff444f37df"></a></p>

<h3>Fill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23a95762-df87-4cb0-a02b-adce0f82652e'>FillColor</a></td><td style='width:75%' class='def'><p><a name="23a95762-df87-4cb0-a02b-adce0f82652e"></a></p>

<h3>FillColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the fill as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8d6cd1d-0ab7-41e5-95c7-1b9502964fa0'>FillGradient</a></td><td style='width:75%' ><p><a name="d8d6cd1d-0ab7-41e5-95c7-1b9502964fa0"></a></p>

<h3>FillGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill gradient.</p>

<h4>Return Value</h4>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9ca3c25-c515-4629-b509-257153c4c1a9'>StyleType</a></td><td style='width:75%' class='def'><p><a name="a9ca3c25-c515-4629-b509-257153c4c1a9"></a></p>

<h3>StyleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the style.</p>

<h4>Return Value</h4>

<p>The type of the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15b0df35-bef1-444e-8dc4-9f28e855a7fa'>FontMetrics</a></td><td style='width:75%' ><p><a name="15b0df35-bef1-444e-8dc4-9f28e855a7fa"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0cdb029-fa01-4a59-bc1c-71733ebb3414'>IsLinearText</a></td><td style='width:75%' class='def'><p><a name="c0cdb029-fa01-4a59-bc1c-71733ebb3414"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbcd0b53-fe9d-4061-a06a-f00daf029a68'>IsVerticalText</a></td><td style='width:75%' ><p><a name="fbcd0b53-fe9d-4061-a06a-f00daf029a68"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#698534e2-d7bb-4ddb-a63f-a9b011df6df4'>StrikeThruText</a></td><td style='width:75%' class='def'><p><a name="698534e2-d7bb-4ddb-a63f-a9b011df6df4"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eb010fb-5db9-42fd-9679-4ec78f2ea0b8'>TextAlign</a></td><td style='width:75%' ><p><a name="8eb010fb-5db9-42fd-9679-4ec78f2ea0b8"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e47eaa1-2704-4604-a8c0-4246d2832833'>TextEncoding</a></td><td style='width:75%' class='def'><p><a name="9e47eaa1-2704-4604-a8c0-4246d2832833"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b434472-9f18-4fc1-ac16-7c06a1824acd'>TextScaleX</a></td><td style='width:75%' ><p><a name="7b434472-9f18-4fc1-ac16-7c06a1824acd"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e467ead9-fd0d-4fea-bb43-f6d58742888f'>TextSize</a></td><td style='width:75%' class='def'><p><a name="e467ead9-fd0d-4fea-bb43-f6d58742888f"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98dca508-89e3-4535-a06a-b38eb5530aa4'>TextSkewX</a></td><td style='width:75%' ><p><a name="98dca508-89e3-4535-a06a-b38eb5530aa4"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dd06397-a3e3-45fb-8c76-cfc737f0ed3e'>Typeface</a></td><td style='width:75%' class='def'><p><a name="9dd06397-a3e3-45fb-8c76-cfc737f0ed3e"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f0e5881-14c3-43b0-8010-576f52f2d2ec'>FontFamilyName</a></td><td style='width:75%' ><p><a name="9f0e5881-14c3-43b0-8010-576f52f2d2ec"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb749b69-acf9-4772-930d-8bc7fbc4172c'>TypefaceStyle</a></td><td style='width:75%' class='def'><p><a name="bb749b69-acf9-4772-930d-8bc7fbc4172c"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2377ff22-d198-4aa3-b61a-e16da95bb087'>UnderlineText</a></td><td style='width:75%' ><p><a name="2377ff22-d198-4aa3-b61a-e16da95bb087"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dc30ec6-f3a8-4079-9dc3-9d58debd43d2'>HasFrameJitter</a></td><td style='width:75%' class='def'><p><a name="0dc30ec6-f3a8-4079-9dc3-9d58debd43d2"></a></p>

<h3>HasFrameJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a87b09d-7e1f-4a67-a355-f27da667a45f'>FrameJitterLength</a></td><td style='width:75%' ><p><a name="5a87b09d-7e1f-4a67-a355-f27da667a45f"></a></p>

<h3>FrameJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the frame jitter.</p>

<h4>Return Value</h4>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab5f5588-00e5-487d-b22e-857e87129d03'>FrameJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="ab5f5588-00e5-487d-b22e-857e87129d03"></a></p>

<h3>FrameJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame jitter deviation.</p>

<h4>Return Value</h4>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9343653-d59e-4018-90d3-2bf5d3e13b42'>HasFillJitter</a></td><td style='width:75%' ><p><a name="d9343653-d59e-4018-90d3-2bf5d3e13b42"></a></p>

<h3>HasFillJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the fill jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de896320-57fe-4458-8ed8-27f83bd5abd5'>FillJitterLength</a></td><td style='width:75%' class='def'><p><a name="de896320-57fe-4458-8ed8-27f83bd5abd5"></a></p>

<h3>FillJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the fill jitter.</p>

<h4>Return Value</h4>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beef5f65-798a-495e-8663-94fd35fc1890'>FillJitterDeviation</a></td><td style='width:75%' ><p><a name="beef5f65-798a-495e-8663-94fd35fc1890"></a></p>

<h3>FillJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill jitter deviation.</p>

<h4>Return Value</h4>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd1a4e2e-5669-439d-a289-d8655fec6961'>HasFrameDash</a></td><td style='width:75%' class='def'><p><a name="cd1a4e2e-5669-439d-a289-d8655fec6961"></a></p>

<h3>HasFrameDash</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame has a dash.</p>

<h4>Return Value</h4>

<p><code>true</code> if the frame has a dash; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e12e4fb6-f24a-4dc4-8196-79ad3e447add'>DashPattern</a></td><td style='width:75%' ><p><a name="e12e4fb6-f24a-4dc4-8196-79ad3e447add"></a></p>

<h3>DashPattern</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the dash pattern.</p>

<h4>Return Value</h4>

<p>The dash pattern.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#250eb51f-1b4b-40bf-8117-b0a7ec222e72'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="250eb51f-1b4b-40bf-8117-b0a7ec222e72"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoStyle</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b68b850c-9c08-429d-b467-b5c68fd78c0a'>PropertyConnections</a></td><td style='width:75%' ><p><a name="b68b850c-9c08-429d-b467-b5c68fd78c0a"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7e960110-d743-4168-b8fc-a031338b8148'>ClonePaint</a></td><td style='width:75%' ><p><a name="7e960110-d743-4168-b8fc-a031338b8148"></a></p>

<h3>ClonePaint (SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPaint</code> object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p><a name="f59dada2-ea83-49e9-93d3-ee23e8894da9"></a>
The <code>SKPaint</code> object to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>SKPaint</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf533319-1fc5-4607-bf91-b308c5e1aa32'>KimonoStyle</a></td><td style='width:75%' class='def'><p><a name="cf533319-1fc5-4607-bf91-b308c5e1aa32"></a></p>

<h3>KimonoStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#ae402a36-7d15-4faf-8c84-e03e0a0ca155">KimonoStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e492da5d-bd43-4615-bea5-8795bd07ec64'>Initialize</a></td><td style='width:75%' ><p><a name="e492da5d-bd43-4615-bea5-8795bd07ec64"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a0786ee-d53c-4e0e-b2e8-0b0cf5b32247'>HandleFrameBlurOrShadowChange</a></td><td style='width:75%' class='def'><p><a name="9a0786ee-d53c-4e0e-b2e8-0b0cf5b32247"></a></p>

<h3>HandleFrameBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3ecb1dd-d143-4616-b682-5f9af0742d0e'>HandleFillBlurOrShadowChange</a></td><td style='width:75%' ><p><a name="f3ecb1dd-d143-4616-b682-5f9af0742d0e"></a></p>

<h3>HandleFillBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aea58764-b9a5-47c7-8de4-0a4c34ce184a'>HandleFrameColorChange</a></td><td style='width:75%' class='def'><p><a name="aea58764-b9a5-47c7-8de4-0a4c34ce184a"></a></p>

<h3>HandleFrameColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0232ba4f-6f6e-44b0-9d75-656aacf35c3a'>HandleFillColorChange</a></td><td style='width:75%' ><p><a name="0232ba4f-6f6e-44b0-9d75-656aacf35c3a"></a></p>

<h3>HandleFillColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1606081c-47c3-4919-8d1c-652a33db4f85'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p><a name="1606081c-47c3-4919-8d1c-652a33db4f85"></a></p>

<h3>HandleFrameGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f8c10ee-e36b-472e-88ee-ffaefad8dff4'>HandleFillGradientChange</a></td><td style='width:75%' ><p><a name="6f8c10ee-e36b-472e-88ee-ffaefad8dff4"></a></p>

<h3>HandleFillGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2af83c2a-ec1e-4bc7-93f6-147d9fcea837'>MakeDashInterval</a></td><td style='width:75%' class='def'><p><a name="2af83c2a-ec1e-4bc7-93f6-147d9fcea837"></a></p>

<h3>MakeDashInterval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the dash interval from the dash pattern.</p>

<h4>Returns</h4>

<p>The dash interval.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f0c0786-f18d-44b6-81e6-11b74132f95c'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="5f0c0786-f18d-44b6-81e6-11b74132f95c"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="348ad9f1-7dc0-4687-a4b0-0c33a2cfe432"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="e5a4507d-3eb9-4e5c-b8f5-435d3f77a485"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e6b1759-51b3-41cd-8ea6-d9539c21b1cb'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="3e6b1759-51b3-41cd-8ea6-d9539c21b1cb"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="51f5538d-fbf8-4131-9525-90c947f37ed6"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95a67bd2-9f6b-454e-8e80-99715ee91600'>RemoveProperty</a></td><td style='width:75%' ><p><a name="95a67bd2-9f6b-454e-8e80-99715ee91600"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="47b2efd2-c5a1-452f-a04f-6d5755dbfb1a"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#034ee5d8-304d-4d8e-ad96-00ebcacac9d7'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="034ee5d8-304d-4d8e-ad96-00ebcacac9d7"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoStyle</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f99c131-1991-4779-84af-bd1e60be2feb'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="3f99c131-1991-4779-84af-bd1e60be2feb"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="23b7c9b4-b765-4b6a-8c4e-003c6fdf0088"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#daadb186-31f7-43e6-9305-4864ebcb228b'>ApplyFrameEffects</a></td><td style='width:75%' class='def'><p><a name="daadb186-31f7-43e6-9305-4864ebcb228b"></a></p>

<h3>ApplyFrameEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the frame effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7892aa11-2ff9-4abf-ae45-ddbd3bef1013'>ApplyFillEffects</a></td><td style='width:75%' ><p><a name="7892aa11-2ff9-4abf-ae45-ddbd3bef1013"></a></p>

<h3>ApplyFillEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the fill effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3bb5e03-c635-49ce-b474-dd6cdfcedee0'>ToObiScript</a></td><td style='width:75%' class='def'><p><a name="e3bb5e03-c635-49ce-b474-dd6cdfcedee0"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f447d6f7-e997-4c47-a4a4-f5cfd4f4cde4'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="f447d6f7-e997-4c47-a4a4-f5cfd4f4cde4"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10805b1e-f94f-4b05-b4f5-d73bca331718'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="10805b1e-f94f-4b05-b4f5-d73bca331718"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f07be56-53d7-48e0-b1fd-2f390b1fea61'>FillToSkiaCode</a></td><td style='width:75%' ><p><a name="8f07be56-53d7-48e0-b1fd-2f390b1fea61"></a></p>

<h3>FillToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17b961e5-250d-4c7f-9f35-3ad6d48ac423'>FillToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="17b961e5-250d-4c7f-9f35-3ad6d48ac423"></a></p>

<h3>FillToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9d6b047-99ba-4fbb-bff5-d64ed5904565'>FrameToSkiaCode</a></td><td style='width:75%' ><p><a name="f9d6b047-99ba-4fbb-bff5-d64ed5904565"></a></p>

<h3>FrameToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aaa309df-a6b4-4694-9746-99befcde48e4'>FrameToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="aaa309df-a6b4-4694-9746-99befcde48e4"></a></p>

<h3>FrameToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9d75c74-22c1-45ca-a042-aff69335bed3'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="f9d75c74-22c1-45ca-a042-aff69335bed3"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e24754a9-8adc-4802-9f83-b053407c8d04'>ToKimonoCoreInitializer</a></td><td style='width:75%' class='def'><p><a name="e24754a9-8adc-4802-9f83-b053407c8d04"></a></p>

<h3>ToKimonoCoreInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3859c2b5-5e3b-4a41-a2e1-7f2ff3b07178'>ToCSharp</a></td><td style='width:75%' ><p><a name="3859c2b5-5e3b-4a41-a2e1-7f2ff3b07178"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a6244964-da1b-4bbc-9e5a-b17eb36bc522"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a8827f5-10fe-4687-8267-c2773c0b3f49'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="6a8827f5-10fe-4687-8267-c2773c0b3f49"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7f870d51-b0ca-4ee9-a83d-4dd5f909bab0"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb880d28-53ea-4011-a4c9-ba4bc5704667'>ToCode</a></td><td style='width:75%' ><p><a name="bb880d28-53ea-4011-a4c9-ba4bc5704667"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d7193478-bd45-4843-97d7-a177d83e6aa8"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="bd999546-c2b6-4a42-9683-d05fbd842664"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f3dd9263-c803-43b4-8775-2f0c6a9f4f64"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f605c4b-aa6f-4138-8f65-0b0a6bab5ae4'>Clone</a></td><td style='width:75%' class='def'><p><a name="9f605c4b-aa6f-4138-8f65-0b0a6bab5ae4"></a></p>

<h3>Clone (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p><a name="1266237e-4a6c-4864-9b6a-b24383700100"></a>
If set to <code>true</code>, a deep clone of the style is made.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The a clone of the <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="233c3d70-5be9-4b01-90a7-dbc5aad3f895"></a>
##KimonoStyleType

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the type of a `KimonoStyle` that will be used to draw a given `KimonoShape` in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4ea6684b-0f00-4c37-9c0f-ffcc0020a86a'>Default</a></td><td style='width:75%' ><p><a name="4ea6684b-0f00-4c37-9c0f-ffcc0020a86a"></a>
<b>Default</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default style for new shapes. This style cannot be deleted or renamed by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#082ea4ce-f130-4798-9c5a-d55f25b1af5e'>Custom</a></td><td style='width:75%' class='def'><p><a name="082ea4ce-f130-4798-9c5a-d55f25b1af5e"></a>
<b>Custom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom style that belongs only to an individual shape instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc4c1489-ccd2-4bd6-945c-ddf770d0b8d8'>CustomText</a></td><td style='width:75%' ><p><a name="cc4c1489-ccd2-4bd6-945c-ddf770d0b8d8"></a>
<b>CustomText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom text style that belongs only to an individual <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5e38444-638c-4c62-874f-41bd84380e2f'>Standard</a></td><td style='width:75%' class='def'><p><a name="f5e38444-638c-4c62-874f-41bd84380e2f"></a>
<b>Standard</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared style that can be applied to multiple <code>Kimonoshape</code> instances.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37fd121a-6dc7-480b-91c2-c7e27ff202e8'>Text</a></td><td style='width:75%' ><p><a name="37fd121a-6dc7-480b-91c2-c7e27ff202e8"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared text style that can be applied to multiple <code>KimonoShapeText</code> instances.</p>
</td></tr></table></p>


---

<a name="f5cddb40-355a-4469-9bdf-5f1cc55886c4"></a>
##KimonoPropertyRect

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `SKRect`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c5177c2e-237e-4fb0-9387-8ffa7e1687ad'>Value</a></td><td style='width:75%' ><p><a name="c5177c2e-237e-4fb0-9387-8ffa7e1687ad"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value as a <code>SKRect</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e9e223f2-0fe8-4a24-9e63-68e548eeef79'>KimonoPropertyRect</a></td><td style='width:75%' ><p><a name="e9e223f2-0fe8-4a24-9e63-68e548eeef79"></a></p>

<h3>KimonoPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f5cddb40-355a-4469-9bdf-5f1cc55886c4">KimonoPropertyRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c61a731-2bad-4e6f-8c7c-db1b51dc044b'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="9c61a731-2bad-4e6f-8c7c-db1b51dc044b"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24a03bde-90df-49ef-a271-ee00a806f0b2'>ToRect</a></td><td style='width:75%' ><p><a name="24a03bde-90df-49ef-a271-ee00a806f0b2"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccb08cc9-4669-4427-a3dc-a17b17d0c334'>Clone</a></td><td style='width:75%' class='def'><p><a name="ccb08cc9-4669-4427-a3dc-a17b17d0c334"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="6cf97a0b-f96d-4cca-a489-3ecca6552c9b"></a>
##KimonoPropertyNumber

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `float` or `int` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#da8a5625-f753-450c-b304-9818215ce46d'>Value</a></td><td style='width:75%' ><p><a name="da8a5625-f753-450c-b304-9818215ce46d"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>float</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4e750750-a3ef-4cc5-a718-0d0daaae44e1'>KimonoPropertyNumber</a></td><td style='width:75%' ><p><a name="4e750750-a3ef-4cc5-a718-0d0daaae44e1"></a></p>

<h3>KimonoPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6cf97a0b-f96d-4cca-a489-3ecca6552c9b">KimonoPropertyNumber</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05350add-3c08-404e-a60d-d8e0eabfe6ae'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="05350add-3c08-404e-a60d-d8e0eabfe6ae"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16652e66-ad2d-4b05-9b94-308136f4d63d'>ToFloat</a></td><td style='width:75%' ><p><a name="16652e66-ad2d-4b05-9b94-308136f4d63d"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f36cae7-a008-403d-bb5f-17bd9dea3a6c'>ToInt</a></td><td style='width:75%' class='def'><p><a name="4f36cae7-a008-403d-bb5f-17bd9dea3a6c"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d7141f9-a9d2-4526-8c6b-71fd1b58b2fc'>Clone</a></td><td style='width:75%' ><p><a name="3d7141f9-a9d2-4526-8c6b-71fd1b58b2fc"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="53be2972-f412-4e34-a25f-cdce98ca8db0"></a>
##KimonoPropertyStyle

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#db739303-1814-4867-a590-b5013cd6f38c'>Value</a></td><td style='width:75%' ><p><a name="db739303-1814-4867-a590-b5013cd6f38c"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6050041-38c0-4fb2-bea0-565e2d27c856'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="e6050041-38c0-4fb2-bea0-565e2d27c856"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#36dadc47-be4a-4179-902a-8eeb56d01b5f">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4c0d736e-b884-4de2-b491-d122d9bc8fae'>KimonoPropertyStyle</a></td><td style='width:75%' ><p><a name="4c0d736e-b884-4de2-b491-d122d9bc8fae"></a></p>

<h3>KimonoPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#53be2972-f412-4e34-a25f-cdce98ca8db0">KimonoPropertyStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9de097dc-c76f-4216-94a9-aa696ad610b4'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="9de097dc-c76f-4216-94a9-aa696ad610b4"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#711a6c0a-9c6c-4a0a-b5bf-87defc6e48c1'>ToStyle</a></td><td style='width:75%' ><p><a name="711a6c0a-9c6c-4a0a-b5bf-87defc6e48c1"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec215257-53b0-4963-881e-35b40d751943'>Clone</a></td><td style='width:75%' class='def'><p><a name="ec215257-53b0-4963-881e-35b40d751943"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="af7b536c-05a2-4cba-8bbd-75c0a140c6a0"></a>
##KimonoPropertyBoolean

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `bool` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3ca2980e-2414-4911-bcab-849166606f69'>Value</a></td><td style='width:75%' ><p><a name="3ca2980e-2414-4911-bcab-849166606f69"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>bool</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0ae7c49e-1538-4479-a798-f03b3c0f68b6'>KimonoPropertyBoolean</a></td><td style='width:75%' ><p><a name="0ae7c49e-1538-4479-a798-f03b3c0f68b6"></a></p>

<h3>KimonoPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af7b536c-05a2-4cba-8bbd-75c0a140c6a0">KimonoPropertyBoolean</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12aa66e9-1f94-4223-a9dc-6b72003768b0'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="12aa66e9-1f94-4223-a9dc-6b72003768b0"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21139a55-40f2-46ba-b6d3-339316506a9b'>ToBool</a></td><td style='width:75%' ><p><a name="21139a55-40f2-46ba-b6d3-339316506a9b"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p><code>true</code>, if bool was toed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1139d49-3136-4b5e-985e-93680d3fe67e'>Clone</a></td><td style='width:75%' class='def'><p><a name="d1139d49-3136-4b5e-985e-93680d3fe67e"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="cb6a73e3-8004-43f4-a2ac-a71e28fa9aeb"></a>
##KimonoPropertyText

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `string` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2892fb2e-926d-4818-a046-c68f590d90e9'>Value</a></td><td style='width:75%' ><p><a name="2892fb2e-926d-4818-a046-c68f590d90e9"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d6fca64d-073b-454b-a7fa-b385d5829327'>KimonoPropertyText</a></td><td style='width:75%' ><p><a name="d6fca64d-073b-454b-a7fa-b385d5829327"></a></p>

<h3>KimonoPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cb6a73e3-8004-43f4-a2ac-a71e28fa9aeb">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d51b522-ce77-4523-a834-28c7ad6c53e1'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="7d51b522-ce77-4523-a834-28c7ad6c53e1"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55704708-3638-45e4-8313-c8a4b2c82e30'>ToString</a></td><td style='width:75%' ><p><a name="55704708-3638-45e4-8313-c8a4b2c82e30"></a></p>

<h3>ToString ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>string</code>.</p>

<h4>Returns</h4>

<p>The <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ad3a07f-1266-4a4e-a70d-6b00d99b79a5'>Clone</a></td><td style='width:75%' class='def'><p><a name="0ad3a07f-1266-4a4e-a70d-6b00d99b79a5"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="36dadc47-be4a-4179-902a-8eeb56d01b5f"></a>
##KimonoPropertyColor

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#09ea5279-5be7-4ef1-9b8d-52442de7f6da'>Value</a></td><td style='width:75%' ><p><a name="09ea5279-5be7-4ef1-9b8d-52442de7f6da"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad478940-1787-453f-a9f2-0e2ed2939974'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="ad478940-1787-453f-a9f2-0e2ed2939974"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#36dadc47-be4a-4179-902a-8eeb56d01b5f">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f1d8fcf4-3d6b-4cca-9cf3-f6ff17b859c3'>KimonoPropertyColor</a></td><td style='width:75%' ><p><a name="f1d8fcf4-3d6b-4cca-9cf3-f6ff17b859c3"></a></p>

<h3>KimonoPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cb6a73e3-8004-43f4-a2ac-a71e28fa9aeb">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62b3b906-6bae-4521-8385-62b72b104016'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="62b3b906-6bae-4521-8385-62b72b104016"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d5d1061-2475-488f-92c7-ebd63f419bc1'>ToColor</a></td><td style='width:75%' ><p><a name="0d5d1061-2475-488f-92c7-ebd63f419bc1"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2199a37d-bdc3-47fb-a614-9e2f64182481'>Clone</a></td><td style='width:75%' class='def'><p><a name="2199a37d-bdc3-47fb-a614-9e2f64182481"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="9a8b6721-563a-4c67-b5fd-67d7cf6fafc2"></a>
##KimonoPropertyGradient

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines a `KimonoProperty` that represents a `KimonoGradient` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d3811d1c-8404-415f-b5c5-5cf3a8b2783e'>Value</a></td><td style='width:75%' ><p><a name="d3811d1c-8404-415f-b5c5-5cf3a8b2783e"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c971434-36e5-4173-ad26-b81e1056e073'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="1c971434-36e5-4173-ad26-b81e1056e073"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#36dadc47-be4a-4179-902a-8eeb56d01b5f">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d5e5d606-cd79-4e1b-a34c-a498c08e88ca'>KimonoPropertyGradient</a></td><td style='width:75%' ><p><a name="d5e5d606-cd79-4e1b-a34c-a498c08e88ca"></a></p>

<h3>KimonoPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cb6a73e3-8004-43f4-a2ac-a71e28fa9aeb">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#affda6c8-d53b-4056-95e1-a0da11b762f8'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="affda6c8-d53b-4056-95e1-a0da11b762f8"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3569f5fc-13d8-4bd8-b8f9-8923819f1aca'>ToGradient</a></td><td style='width:75%' ><p><a name="3569f5fc-13d8-4bd8-b8f9-8923819f1aca"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#548745be-5bc7-4143-9edb-eb90c250d6fb'>Clone</a></td><td style='width:75%' class='def'><p><a name="548745be-5bc7-4143-9edb-eb90c250d6fb"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="07cf4a07-d845-46da-a292-dd90dbba6a9c"></a>
##CodeOutputOS

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the OS that code will be generated for
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9ce4381e-cf9c-4305-9862-93a143d24589'>Windows</a></td><td style='width:75%' ><p><a name="9ce4381e-cf9c-4305-9862-93a143d24589"></a>
<b>Windows</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cca3b1a7-bb89-4b83-a458-452c337d4ad7'>WindowsUWP</a></td><td style='width:75%' class='def'><p><a name="cca3b1a7-bb89-4b83-a458-452c337d4ad7"></a>
<b>WindowsUWP</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Universal Windows Platform.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef4243cd-bd40-4997-9f9e-df37f9a8227d'>WindowsWPF</a></td><td style='width:75%' ><p><a name="ef4243cd-bd40-4997-9f9e-df37f9a8227d"></a>
<b>WindowsWPF</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Windows Presentation Foundation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f823db2-dc86-40d7-9b9f-f6f93c489cd9'>Android</a></td><td style='width:75%' class='def'><p><a name="4f823db2-dc86-40d7-9b9f-f6f93c489cd9"></a>
<b>Android</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Android OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea881161-c187-4179-8454-911b53fe80f3'>iOS</a></td><td style='width:75%' ><p><a name="ea881161-c187-4179-8454-911b53fe80f3"></a>
<b>iOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For iOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8aedfe4-4f6c-4491-a495-130a11ea12ef'>tvOS</a></td><td style='width:75%' class='def'><p><a name="b8aedfe4-4f6c-4491-a495-130a11ea12ef"></a>
<b>tvOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For tvOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57fffb68-7a2b-4563-985e-49d34b5dc384'>macOS</a></td><td style='width:75%' ><p><a name="57fffb68-7a2b-4563-985e-49d34b5dc384"></a>
<b>macOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For macOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f63906af-f1b3-40e6-822a-efe527031b0e'>CrossPlatform</a></td><td style='width:75%' class='def'><p><a name="f63906af-f1b3-40e6-822a-efe527031b0e"></a>
<b>CrossPlatform</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Cross-platform code.</p>
</td></tr></table></p>


---

<a name="4cab6013-5da2-4639-a386-d50491d0ed76"></a>
##CodeOutputLanguage

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Defines the language that code will be output in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b4e03863-1ded-49b7-bd50-cd15c30e6e37'>CSharp</a></td><td style='width:75%' ><p><a name="b4e03863-1ded-49b7-bd50-cd15c30e6e37"></a>
<b>CSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for C#.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c1cd95b-9d91-4461-bc14-36cb3fee8a91'>ObiScript</a></td><td style='width:75%' class='def'><p><a name="1c1cd95b-9d91-4461-bc14-36cb3fee8a91"></a>
<b>ObiScript</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for the internal ObiScript scripting language.</p>
</td></tr></table></p>


---

<a name="9e83a1dd-144a-469f-8e10-63c70019eadf"></a>
##CodeOutputLibrary

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Code output library.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2a8a556c-ffca-47f4-93f5-035f0e1ccbf5'>SkiaSharp</a></td><td style='width:75%' ><p><a name="2a8a556c-ffca-47f4-93f5-035f0e1ccbf5"></a>
<b>SkiaSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output pure SkiaSharp code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df968726-6051-4874-aee1-2ec85a27c236'>KimonoCore</a></td><td style='width:75%' class='def'><p><a name="df968726-6051-4874-aee1-2ec85a27c236"></a>
<b>KimonoCore</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output code using the helper <code>KimonoCore</code> classes.</p>
</td></tr></table></p>


---

<a name="05494e65-778f-436a-830c-9270dd80b2ed"></a>
##KimonoCodeGenerator

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

The Kimono Code Generator has routine to assist in the generation of output source code.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#90908bf1-e89a-4f6f-9bc9-3f6adbe6b0bb'>NextElementNumber</a></td><td style='width:75%' ><p><a name="90908bf1-e89a-4f6f-9bc9-3f6adbe6b0bb"></a>
<b>NextElementNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The next element number.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4cc0209-ebd3-40d6-9627-24e89d6447a7'>AddNumberToElementNames</a></td><td style='width:75%' class='def'><p><a name="b4cc0209-ebd3-40d6-9627-24e89d6447a7"></a>
<b>AddNumberToElementNames</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Add number to element names when generating.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5bbf943-7804-42d2-b9a5-c147025e3ad4'>SupportingColors</a></td><td style='width:75%' ><p><a name="b5bbf943-7804-42d2-b9a5-c147025e3ad4"></a>
<b>SupportingColors</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting colors that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd1c76d7-7066-422f-b029-387b388cceb0'>SupportingGradients</a></td><td style='width:75%' class='def'><p><a name="cd1c76d7-7066-422f-b029-387b388cceb0"></a>
<b>SupportingGradients</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting gradients that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#718c8171-4c34-4c51-8e75-b9e45a361e80'>SupportingStyles</a></td><td style='width:75%' ><p><a name="718c8171-4c34-4c51-8e75-b9e45a361e80"></a>
<b>SupportingStyles</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting styles that are required for the object being converted to source code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9deab7be-50bc-4a61-b837-e02a55c87282'>ResetCodeGeneration</a></td><td style='width:75%' ><p><a name="9deab7be-50bc-4a61-b837-e02a55c87282"></a></p>

<h3>ResetCodeGeneration ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Resets the code generation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4a242f9-155b-42d0-87dc-a49551c67f6f'>AddSupportingColor</a></td><td style='width:75%' class='def'><p><a name="b4a242f9-155b-42d0-87dc-a49551c67f6f"></a></p>

<h3>AddSupportingColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given color to the collection of named colors that are used in the generation of other Kimono Objects. If a color is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="d976fbbf-ee81-407b-8556-048da1a2238a"></a>
The <code>KimonoColor</code> to add to the collection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#add3cd50-9105-4c4a-8581-70eca4a0652e'>CodeForSupportingColors</a></td><td style='width:75%' ><p><a name="add3cd50-9105-4c4a-8581-70eca4a0652e"></a></p>

<h3>CodeForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="a7a687b0-5330-40ee-9610-87d0541eb70d"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="4df50f3b-55d7-4972-aff2-a6c65a88b8b7"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4e2a913-06b0-4e40-b9d8-372efaabe4e5'>PropertyForSupportingColors</a></td><td style='width:75%' class='def'><p><a name="c4e2a913-06b0-4e40-b9d8-372efaabe4e5"></a></p>

<h3>PropertyForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="ce08cf46-abd5-4286-afd6-cdd556737bce"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="71d5276c-60e3-4c77-a0a5-1a3d2ee07b6d"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4736b307-02be-4f67-b3f5-6952dec4ed1c'>AddSupportingGradient</a></td><td style='width:75%' ><p><a name="4736b307-02be-4f67-b3f5-6952dec4ed1c"></a></p>

<h3>AddSupportingGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given gradient to the collection of named gradients that are used in the generation of other Kimono Objects. If a gradient is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="acfc1a84-ea6e-4464-80b1-6181c01612f3"></a>
The <code>KimonoGradient</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7ef7df2-8686-482b-98c1-df99e6890725'>CodeForSupportGradients</a></td><td style='width:75%' class='def'><p><a name="f7ef7df2-8686-482b-98c1-df99e6890725"></a></p>

<h3>CodeForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="627a11ca-32ef-4e16-8a9e-57cce7ea69f1"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="38f2e2ec-44e1-413c-8652-87e343d6130c"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#446f30b6-12e2-4a31-bcb6-fef464570d35'>PrivateVariablesForSupportingGradients</a></td><td style='width:75%' ><p><a name="446f30b6-12e2-4a31-bcb6-fef464570d35"></a></p>

<h3>PrivateVariablesForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="4882fab0-eec3-47eb-99df-24a7211b8df5"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="9c1bdf8c-49d8-40ef-bdf4-06cddb01ef15"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5112a01f-6069-43f1-b5bc-e973d5e251e4'>PropertyForSupportingGradients</a></td><td style='width:75%' class='def'><p><a name="5112a01f-6069-43f1-b5bc-e973d5e251e4"></a></p>

<h3>PropertyForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="9aa499d5-4571-4b36-ba91-a7bd0257030f"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="c85ebca8-9fa6-4748-be8e-9151e5e1194a"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ee3bec0-b95c-4413-8efa-764e864e2fb1'>InitializerForSupportGradients</a></td><td style='width:75%' ><p><a name="8ee3bec0-b95c-4413-8efa-764e864e2fb1"></a></p>

<h3>InitializerForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="54283075-a1a0-4b37-baf6-a58cc7cb0202"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="f242a22c-dfd2-4bc0-99a9-89da3fa664f0"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ddfd442-49e2-413c-931d-0040270d740c'>AddSupportingStyle</a></td><td style='width:75%' class='def'><p><a name="3ddfd442-49e2-413c-931d-0040270d740c"></a></p>

<h3>AddSupportingStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given style to the collection of named styles that are used in the generation of other Kimono Objects. If a style is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="a1c84963-0956-46df-86e7-8454f64af35c"></a>
The <code>KimonoStyle</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5e25df3-bcbc-4a02-b22c-3476209efba8'>CodeForSupportStyles</a></td><td style='width:75%' ><p><a name="d5e25df3-bcbc-4a02-b22c-3476209efba8"></a></p>

<h3>CodeForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="351cb633-365a-47b2-9db9-4af525f595f9"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="4e2f59ed-9a7d-420b-a0c2-20a5cfa07021"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#245f398f-261c-4988-b83e-3c211563d0ee'>PropertyForSupportingStyles</a></td><td style='width:75%' class='def'><p><a name="245f398f-261c-4988-b83e-3c211563d0ee"></a></p>

<h3>PropertyForSupportingStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="2ee9229d-044c-4db8-aa4a-f3ba18a28a91"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="450121df-a9c6-44db-a69a-ac671eb4d35d"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2665ae0a-6ac1-4d84-bf6e-082ad8779189'>InitializerForSupportStyles</a></td><td style='width:75%' ><p><a name="2665ae0a-6ac1-4d84-bf6e-082ad8779189"></a></p>

<h3>InitializerForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="5b5f89f1-8a1f-41ea-a492-aafe541e3491"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="a5502c65-3f80-4b56-86b7-8df3fcc69fc8"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3db04751-fee6-478f-a9ee-856dd5796604'>MakeElementName</a></td><td style='width:75%' class='def'><p><a name="3db04751-fee6-478f-a9ee-856dd5796604"></a></p>

<h3>MakeElementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes a valid source code name for the name of a given Kimono Object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="982567fa-c3d4-4b1a-a334-c3a4c0562228"></a>
The source Kimono Object name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The element name valid for use in source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e77be0a6-35b8-4859-b965-10af95ac68fb'>IncreaseIndentLevel</a></td><td style='width:75%' ><p><a name="e77be0a6-35b8-4859-b965-10af95ac68fb"></a></p>

<h3>IncreaseIndentLevel (System.String, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code by the given number of levels</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="1bbb96ac-56ba-41d8-99ce-50844454229d"></a>
Source code.</p>
</td></tr><tr><td style='width:25%' class='term'>levels</td><td style='width:75%' class='def'><p><a name="9d280930-e963-4adc-a392-d1e0cc4d200a"></a>
Levels.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The indent level.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc066b18-7080-4642-b884-6c1c1b492f05'>IncreaseIndentLevel</a></td><td style='width:75%' class='def'><p><a name="dc066b18-7080-4642-b884-6c1c1b492f05"></a></p>

<h3>IncreaseIndentLevel (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="408ec86f-6eaa-465d-a377-2f40ca787838"></a>
The source code to indent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code indented by one tab.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e16e50e-4443-40b4-b9bc-01f89780f04a'>ColorToCode</a></td><td style='width:75%' ><p><a name="0e16e50e-4443-40b4-b9bc-01f89780f04a"></a></p>

<h3>ColorToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given color to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="aaec1057-9df5-48a3-b518-9e327300af2e"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="4aabb1a7-c1d4-4269-babb-dbfeb91949cd"></a>
The <code>SKColor</code> to create code for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac2c9053-4feb-49df-bc25-a8b9dacb1987'>PointToCode</a></td><td style='width:75%' class='def'><p><a name="ac2c9053-4feb-49df-bc25-a8b9dacb1987"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="518c89e1-18ed-40f1-8e4c-f882eed77b9c"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="7763d791-05fc-47e4-9046-1185f0a3e25f"></a>
The <code>SKPoint</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#122c4083-2d3a-421c-a0a8-6c3565bf8a1c'>PointToCode</a></td><td style='width:75%' ><p><a name="122c4083-2d3a-421c-a0a8-6c3565bf8a1c"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2c7c098f-9e09-4083-9a48-0936f5f82ddc"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="e1944acb-1cd7-4c65-bc92-190d1927d3f9"></a>
The <code>KimonoHandle</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr></table></p>


---

<a name="876eb41a-1a0a-4c85-8008-463a9f4e7e10"></a>
##IKimonoCodeGeneration

###Namespace

[KimonoCore](#c0812ff8-3c21-47b3-99b3-32aa3730fddb)

###Added In API Version

01.00.00

###Summary

Interface for any Kimono Object that support source code generation.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5081d17b-2870-43a2-bcb7-96703a75933b'>Name</a></td><td style='width:75%' ><p><a name="5081d17b-2870-43a2-bcb7-96703a75933b"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the name.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f712afe0-b800-4692-8786-c5fe12ab1653'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="f712afe0-b800-4692-8786-c5fe12ab1653"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd6ce4ec-ec51-41f6-b70f-8fab331291cf'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="fd6ce4ec-ec51-41f6-b70f-8fab331291cf"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10243e8f-ad72-4145-a16f-f009c73caa20'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="10243e8f-ad72-4145-a16f-f009c73caa20"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f1abba3-b0ec-4d49-88d0-d5004294e6bf'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="2f1abba3-b0ec-4d49-88d0-d5004294e6bf"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="bc0f77fa-5eac-4b8e-bf1c-f465cd179cc7"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2d2ca3b-93cf-4fdd-b522-04ec529d9c7d'>ToCode</a></td><td style='width:75%' ><p><a name="f2d2ca3b-93cf-4fdd-b522-04ec529d9c7d"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="ae22227b-4f34-487d-aa71-c12f4f561181"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5aabcc1d-e2d7-4dc6-ba78-2f56febff021"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="198bebf2-b572-40f5-9681-e76905dab632"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr></table></p>

