#KimonoCore.Mac API Documentation

####Version 01.01.00

##Table of Contents

* [Summary](#Summary)
* [Remarks](#Remarks)
* [Namespaces](#Namespaces)
* [Types](#Types)

<a name="Summary"></a>
##Summary

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can be converted to code and included in any cross-platform language and OS that SkiaSharp supports. KimonoCore.Mac is the Xamarin.Mac specific version of the Kimono cross-platform library that provides a helper interface to SkiaSharp.

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

<a name="b9d8b089-0169-49eb-a66f-710d9b0331f7"></a>
##KimonoCore

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1ffc151f-4f09-45db-9995-a5e1b6706d01'>CodeOutputLanguage</a></td><td style='width:75%' ><p>Defines the language that code will be output in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09aeb2df-1f81-4a6d-9206-eb721485f753'>CodeOutputLibrary</a></td><td style='width:75%' class='def'><p>Code output library.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f32344c1-2667-42f7-b1ed-6ca957315934'>CodeOutputOS</a></td><td style='width:75%' ><p>Defines the OS that code will be generated for</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad567551-8e07-4b61-a957-3fba660db11d'>IKimonoCodeGeneration</a></td><td style='width:75%' class='def'><p>Interface for any Kimono Object that support source code generation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3b7667e-16d0-498c-8c57-e05e419e4f73'>Kimono</a></td><td style='width:75%' ><p>Holds a set of shared utilities that are used across the Kimono classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p>Holds the control and end point for a <code>KimonoShapeBezier</code> that define a quad section of the Bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f51af2c9-f4b2-4244-ad4b-ba7e580ac918'>KimonoBlur</a></td><td style='width:75%' ><p>Defines a blur effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d07eefe-b52f-4276-a1c9-970a91ec6517'>KimonoBounds</a></td><td style='width:75%' class='def'><p>Defines the outter bounding box for a <code>KimonoShape</code> and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92776647-54fd-46d9-b8d2-ff7b70824564'>KimonoCodeGenerator</a></td><td style='width:75%' ><p>The Kimono Code Generator has routine to assist in the generation of output source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a61d428-669b-4b00-8f29-7eac9ab41f57'>KimonoColor</a></td><td style='width:75%' class='def'><p>The public <code>KimonoColor</code> class inherits from the <code>System.Object</code> class and is defined in the <code>KimonoCore</code> namespace. It defines 19 fields, 75 properties, 110 methods and one event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c314738-81b5-4ec9-8672-ec5609515d65'>KimonoGradient</a></td><td style='width:75%' ><p>Defines a gradient as a collection of either <code>SKColor</code> or linked <code>KimonoColors</code> that can be applied to a <code>KimonoStyle</code> and used when drawing a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2c4892c-ccec-401e-90e8-6969d7d016b4'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>Kimono gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f2ab0de-866d-4223-95e0-401140c85a02'>KimonoHandle</a></td><td style='width:75%' ><p>Defines an edit handle that the user manipulates to edit the bounds of a <code>KimonoShape</code> or the control points of a Bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f8a885e-3109-4027-9d9b-dcdaa359f471'>KimonoHandleConstraint</a></td><td style='width:75%' class='def'><p>Constrains the movement of a <code>KimonoHandle</code> when it is being moved by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2c0fd67-f515-479b-8550-0c3302019623'>KimonoHandleType</a></td><td style='width:75%' ><p>Defines the type of a <code>KimonoHandle</code> that can be used as a general purpose control point to adjust the bounds of a <code>KimonoShape</code> or as a point for a vector or bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83ce776d-3d2d-4903-8985-9bbd9862da9d'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>A Kimono Portfolio holds a collection of <code>KimonoSketches</code>, <code>KimonoStyles</code> and <code>KimonoColors</code> that define a given Kimono Designer project.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8'>KimonoProperty</a></td><td style='width:75%' ><p>Defines a property that can be attached to another Kimono object (such as a <code>KimonoColor</code>, <code>KimonoStyle</code> or <code>KimonoShape</code>) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7f95b58-feb6-4b41-aa87-2b3bc93b25cd'>KimonoPropertyBoolean</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6ae6723-ed8c-4d65-8e35-eabe2a6ee75e'>KimonoPropertyColor</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99d8645c-361a-4186-a17b-3aacc1b32251'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p>Defines a connection between a given Kimono Object and a <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21392678-5537-4b2b-85a4-fdf9d0c4e6cc'>KimonoPropertyConnectionPoint</a></td><td style='width:75%' ><p>Defines the point that a <code>KimonoProperty</code> value can be connected to another Kimono object such as the <code>Top</code> coordinate of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f306371-0ebf-41e9-b6c1-7346aac7c98c'>KimonoPropertyGradient</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ff008ad-e46a-4336-bf6c-f17d13cd68ce'>KimonoPropertyNumber</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>float</code> or <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#043d525b-f140-4894-8e78-d7d54d6bfef7'>KimonoPropertyRect</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>SKRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3822fbc9-3bf3-45ad-84aa-889b20302673'>KimonoPropertyStyle</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6045055f-2b8d-4f63-ba1c-c5c7c2de9c3d'>KimonoPropertyText</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb396ef5-9a89-402d-9618-fe8fd5a6656d'>KimonoPropertyUsage</a></td><td style='width:75%' ><p>Defines how a <code>KimonoProperty</code> is used when it is attached to a <code>KimonoShape</code>, <code>KimonoSketch</code> or <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aed70957-92e3-45b9-85a6-31d4dc128ed2'>KimonoShadow</a></td><td style='width:75%' class='def'><p>Defines a shadow effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0af74e3-5275-47e0-9ddb-991cda8b3f33'>KimonoShape</a></td><td style='width:75%' ><p>Defines the based shape that all other Kimono Shape types will inherit from.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc400c8a-7bc7-4da4-8328-b838796d0162'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p>Draws either an outlined or single line arrow with heads on one or both ends.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85aeca05-c3f1-4a14-87ee-2fe4aed6e686'>KimonoShapeBezier</a></td><td style='width:75%' ><p>A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60cba3d0-f26e-4095-ae97-6368fb3d255a'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p>A <code>KimonoShapeGroup</code> holds a collection of <code>KimonoShapes</code> that can be acted upon as a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b969c329-ae0d-472b-b8b1-5faa6cd3af5f'>KimonoShapeGroupType</a></td><td style='width:75%' ><p>Defines the type of a <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ad91fd7-0087-4c09-a682-87a9a80e7203'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p>Draws a line on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5639ac9b-4ddb-44a7-8f19-d4ee2e368170'>KimonoShapeOval</a></td><td style='width:75%' ><p>Draws an oval into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01c83867-0ee5-42f9-a497-2b55717b53c5'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p>Draws a multi-sided polygon into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d92efb79-b570-4344-9283-8d0e3f17291a'>KimonoShapeRect</a></td><td style='width:75%' ><p>Draws a rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d14fb996-2bf4-4e6b-b506-4c9871f39125'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p>Draws a rounded rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6946276-0101-4180-a5cc-b5024a03d6ac'>KimonoShapeStar</a></td><td style='width:75%' ><p>Draws a multi-sided star shape into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca'>KimonoShapeState</a></td><td style='width:75%' class='def'><p>Holds the current state of a <code>KimonoShape</code> while it is being edited by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d'>KimonoShapeText</a></td><td style='width:75%' ><p>Draws a block of text into the Design Surface within the specifid bounds of this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4bdbf7c9-fd02-4ed0-b14b-6e5bef5d262a'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p>Draws a triangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0e6cf79-ac13-4518-b06d-34c743043cf9'>KimonoShapeVector</a></td><td style='width:75%' ><p>A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d'>KimonoSketch</a></td><td style='width:75%' class='def'><p>Holds a collection of <code>KimonoShapes</code> that are used to create a given image using Skia.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58a59d79-7f6c-41a4-a720-ef39b100168e'>KimonoStyle</a></td><td style='width:75%' ><p>Defines as style that can be applied to a <code>KimonoShape</code> to control its appearance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63'>KimonoStyleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoStyle</code> that will be used to draw a given <code>KimonoShape</code> in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53114db4-e386-4582-9425-de1e67b5bd36'>KimonoTool</a></td><td style='width:75%' ><p>Defines the current tool that is active in a <code>KimonoSketch</code> that the user can use to create or modify a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f6ca193-4a1c-4cf3-85fd-9088380e8c9e'>KimonoUndoHandler</a></td><td style='width:75%' class='def'><p>Handles the undo/redo state for a <code>KimonoDesignSurface</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5567893-dd3b-4b40-ba41-82bf05be3488'>ObiScriptResult</a></td><td style='width:75%' ><p>Defines the result of attempting to execute an Obi Script on a <code>KimonoProperty</code></p>
</td></tr></table></p>


---

<a name="061e0818-454e-46ac-98c6-a8f0fe88d466"></a>
##KimonoCore.Kimono

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f1a2d0ae-1ce6-430b-b9e6-dc563b05a72d'>ColorEventDelegate</a></td><td style='width:75%' ><p>Color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67ce0094-ddce-4d9e-9750-53c6acab9831'>GradientEventDelegate</a></td><td style='width:75%' class='def'><p>Gradient event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0659477-ccde-4ff2-9bfe-ab73aee2d00a'>GroupEventDelegate</a></td><td style='width:75%' ><p>Group event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9df21535-8dff-4e02-9642-dead70cefcc6'>HandleEventDelegate</a></td><td style='width:75%' class='def'><p>Handle event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0830bfd-1679-4683-a9a2-e032ed9a1049'>PortfolioEventDelegate</a></td><td style='width:75%' ><p>Portfolio event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c56fc94-a4eb-4762-8a4e-d39c26f45a7b'>PropertyEventDelegate</a></td><td style='width:75%' class='def'><p>Property event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0'>ShapeEventDelegate</a></td><td style='width:75%' ><p>Shape event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fcae83b-ce08-45e3-b771-1d9a71087384'>SketchEventDelegate</a></td><td style='width:75%' class='def'><p>Sketch event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56e1dd0a-58dd-4c97-9d27-57cece6e1c75'>SkiaColorEventDelegate</a></td><td style='width:75%' ><p>Skia color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25e379a4-a7ed-43c6-8d15-70d0408d35ce'>SkiaPointEventDelegate</a></td><td style='width:75%' class='def'><p>Skia point event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fdfb734d-7652-477b-b864-cfa9870cd620'>StyleEventDelegate</a></td><td style='width:75%' ><p>Style event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64878777-41f3-4e4a-9955-da97b723a057'>ToolEventDelegate</a></td><td style='width:75%' class='def'><p>Tool event delegate.</p>
</td></tr></table></p>


---

<a name="e7d58f17-d3e3-48f5-bbac-a79af83dfd2b"></a>
##KimonoCore.Mac

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5902167f-bbf8-4117-bf1a-a4a75a7d1a4b'>KimonoDesignSurface</a></td><td style='width:75%' ><p>The Kimono Design Surface is a Xamarin.Mac specific editing surface that allows the user to modify a given <code>KimonoPortfolio</code> and the collection of <code>KimonoSketches</code> that it maintains.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p>The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92f5f4d2-68b0-4fd7-985f-991c59597b6d'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p>The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.</p>
</td></tr></table></p>

<a name="Types"></a>
#Types


---

<a name="1ffc151f-4f09-45db-9995-a5e1b6706d01"></a>
##Public Enum CodeOutputLanguage

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the language that code will be output in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ab93c66b-c9ab-4967-a1d8-66aafd9a93f6'>CSharp</a></td><td style='width:75%' ><p><a name="ab93c66b-c9ab-4967-a1d8-66aafd9a93f6"></a>
<b>Public Static Constant <a href="#1ffc151f-4f09-45db-9995-a5e1b6706d01">KimonoCore.CodeOutputLanguage</a> CSharp = <code>0</code></b></p>

<p>Generate code for C#.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a37f4ea-f1b5-4dc0-a54f-cf80be722ec0'>ObiScript</a></td><td style='width:75%' class='def'><p><a name="0a37f4ea-f1b5-4dc0-a54f-cf80be722ec0"></a>
<b>Public Static Constant <a href="#1ffc151f-4f09-45db-9995-a5e1b6706d01">KimonoCore.CodeOutputLanguage</a> ObiScript = <code>1</code></b></p>

<p>Generate code for the internal ObiScript scripting language.</p>
</td></tr></table></p>


---

<a name="09aeb2df-1f81-4a6d-9206-eb721485f753"></a>
##Public Enum CodeOutputLibrary

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Code output library.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0c3224a4-b930-4eb8-a323-03fba7045b0e'>KimonoCore</a></td><td style='width:75%' ><p><a name="0c3224a4-b930-4eb8-a323-03fba7045b0e"></a>
<b>Public Static Constant <a href="#09aeb2df-1f81-4a6d-9206-eb721485f753">KimonoCore.CodeOutputLibrary</a> KimonoCore = <code>1</code></b></p>

<p>Output code using the helper <code>KimonoCore</code> classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5a7fcca-2b9b-45b6-b1ce-7f1060a6e997'>SkiaSharp</a></td><td style='width:75%' class='def'><p><a name="f5a7fcca-2b9b-45b6-b1ce-7f1060a6e997"></a>
<b>Public Static Constant <a href="#09aeb2df-1f81-4a6d-9206-eb721485f753">KimonoCore.CodeOutputLibrary</a> SkiaSharp = <code>0</code></b></p>

<p>Output pure SkiaSharp code.</p>
</td></tr></table></p>


---

<a name="f32344c1-2667-42f7-b1ed-6ca957315934"></a>
##Public Enum CodeOutputOS

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the OS that code will be generated for
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fe56843d-ea19-430f-8225-d2897125db74'>Android</a></td><td style='width:75%' ><p><a name="fe56843d-ea19-430f-8225-d2897125db74"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> Android = <code>3</code></b></p>

<p>For Android OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc68c9b8-0b08-4527-941d-067b778b89c7'>CrossPlatform</a></td><td style='width:75%' class='def'><p><a name="dc68c9b8-0b08-4527-941d-067b778b89c7"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> CrossPlatform = <code>7</code></b></p>

<p>Cross-platform code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9e0f595-1369-4aa8-8140-2d90475bd33d'>iOS</a></td><td style='width:75%' ><p><a name="e9e0f595-1369-4aa8-8140-2d90475bd33d"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> iOS = <code>4</code></b></p>

<p>For iOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a4354fe-65bf-4385-9525-e02d9b769c86'>macOS</a></td><td style='width:75%' class='def'><p><a name="0a4354fe-65bf-4385-9525-e02d9b769c86"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> macOS = <code>6</code></b></p>

<p>For macOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#333c9c33-dea9-4e44-bd50-8ccece42c188'>tvOS</a></td><td style='width:75%' ><p><a name="333c9c33-dea9-4e44-bd50-8ccece42c188"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> tvOS = <code>5</code></b></p>

<p>For tvOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddc43f86-f5e6-4db1-978d-de25934470c5'>Windows</a></td><td style='width:75%' class='def'><p><a name="ddc43f86-f5e6-4db1-978d-de25934470c5"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> Windows = <code>0</code></b></p>

<p>For Windows OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc15f832-3c63-4d1f-8290-9eb53f12dce3'>WindowsUWP</a></td><td style='width:75%' ><p><a name="cc15f832-3c63-4d1f-8290-9eb53f12dce3"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> WindowsUWP = <code>1</code></b></p>

<p>For Windows OS based machines using Universal Windows Platform.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd8e77f2-78d5-44bf-a90b-5a9d9f084300'>WindowsWPF</a></td><td style='width:75%' class='def'><p><a name="dd8e77f2-78d5-44bf-a90b-5a9d9f084300"></a>
<b>Public Static Constant <a href="#f32344c1-2667-42f7-b1ed-6ca957315934">KimonoCore.CodeOutputOS</a> WindowsWPF = <code>2</code></b></p>

<p>For Windows OS based machines using Windows Presentation Foundation.</p>
</td></tr></table></p>


---

<a name="f1a2d0ae-1ce6-430b-b9e6-dc563b05a72d"></a>
##ColorEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Color event delegate.

---

<a name="67ce0094-ddce-4d9e-9750-53c6acab9831"></a>
##GradientEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Gradient event delegate.

---

<a name="a0659477-ccde-4ff2-9bfe-ab73aee2d00a"></a>
##GroupEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Group event delegate.

---

<a name="9df21535-8dff-4e02-9642-dead70cefcc6"></a>
##HandleEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Handle event delegate.

---

<a name="ad567551-8e07-4b61-a957-3fba660db11d"></a>
##Public Interface IKimonoCodeGeneration

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Summary

Interface for any Kimono Object that support source code generation.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d308790b-7a67-4520-8313-278cf54dbe58'>Name</a></td><td style='width:75%' ><p><a name="d308790b-7a67-4520-8313-278cf54dbe58"></a></p>

<h3>Public Virtual Read Only <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets the name.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a1e83493-f207-4c88-b8ab-7b5a1421b9e4'>ToCode</a></td><td style='width:75%' ><p><a name="a1e83493-f207-4c88-b8ab-7b5a1421b9e4"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="8407ae52-c602-4a23-bf21-4e257ea9b5d0"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="ff33fc95-38db-4d4a-9f94-6403d1633bc9"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="65d398cd-31fe-480c-9ed4-45de259f8643"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#304ab0b8-6e9e-40ce-95e5-16c043014ccc'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="304ab0b8-6e9e-40ce-95e5-16c043014ccc"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="de291163-a028-495d-bbcb-13521e77a812"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4783fb8-d237-4ebd-b652-d1e28e1b1261'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="e4783fb8-d237-4ebd-b652-d1e28e1b1261"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9629e126-746d-40dd-acf9-fcba104dbdd1'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="9629e126-746d-40dd-acf9-fcba104dbdd1"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bafeeb16-960c-462c-86ff-1d51ba067f64'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="bafeeb16-960c-462c-86ff-1d51ba067f64"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="e3b7667e-16d0-498c-8c57-e05e419e4f73"></a>
##Public Static Class Kimono

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Holds a set of shared utilities that are used across the Kimono classes.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d47ad581-6d18-4784-93e2-765372f04a70'>CharIsLetter</a></td><td style='width:75%' ><p><a name="d47ad581-6d18-4784-93e2-765372f04a70"></a></p>

<h3>Public Static <code>System.Boolean</code> CharIsLetter (System.Char)</h3>

<h4>Summary</h4>

<p>Test to see if the given character is a letter character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="d7c0b72f-6403-4acb-9c4f-3f2f400083ce"></a>
<b>System.Char c</b></p>

<p>C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is letter was chared, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2bb7d4e-bd02-49e1-aa63-21d27d372542'>CharIsNumber</a></td><td style='width:75%' class='def'><p><a name="d2bb7d4e-bd02-49e1-aa63-21d27d372542"></a></p>

<h3>Public Static <code>System.Boolean</code> CharIsNumber (System.Char)</h3>

<h4>Summary</h4>

<p>Test to see if the given character is a number character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="3694f644-58ec-4000-b177-069f0fc4db5b"></a>
<b>System.Char c</b></p>

<p>C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is character is a number, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a7658d5-d32e-4f3e-8132-f2ea2bf519ce'>CloneSKPoint</a></td><td style='width:75%' ><p><a name="6a7658d5-d32e-4f3e-8132-f2ea2bf519ce"></a></p>

<h3>Public Static <code>SkiaSharp.SKPoint</code> CloneSKPoint (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Clones the given <code>SKPoint</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3e366896-9861-42cc-a3e0-04e891b63478"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A clone of the given point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e9c003a-d73b-40a5-8041-3f019cbc0c06'>IncrementName</a></td><td style='width:75%' class='def'><p><a name="0e9c003a-d73b-40a5-8041-3f019cbc0c06"></a></p>

<h3>Public Static <code>System.String</code> IncrementName (System.String)</h3>

<h4>Summary</h4>

<p>Increments the name by appending a number to the end or incrementing an existing number count.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="2f69e1d9-e7fb-4e45-94a7-011bcaf57083"></a>
<b>System.String name</b></p>

<p>Name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The name.</p>
</td></tr></table></p>


---

<a name="d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb"></a>
##Public Class KimonoBezierPoint

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Holds the control and end point for a `KimonoShapeBezier` that define a quad section of the Bezier.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#006eabec-9cae-459d-a6ff-142e9c67ca65'>ControlPoint</a></td><td style='width:75%' ><p><a name="006eabec-9cae-459d-a6ff-142e9c67ca65"></a></p>

<h3>Public <code>SkiaSharp.SKPoint</code> ControlPoint</h3>

<h4>Summary</h4>

<p>Gets or sets the control point.</p>

<h4>Return Value</h4>

<p>The control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9ef3094-d818-4750-acfc-0d11c40b77a5'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="e9ef3094-d818-4750-acfc-0d11c40b77a5"></a></p>

<h3>Public <code>SkiaSharp.SKPoint</code> EndPoint</h3>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#200073cb-133c-4f4b-8cbf-af860d344dfe'>Clone</a></td><td style='width:75%' ><p><a name="200073cb-133c-4f4b-8cbf-af860d344dfe"></a></p>

<h3>Public <a href="#d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb">KimonoCore.KimonoBezierPoint</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d698f4a-6c5c-4cfb-b8e2-2a1455c0645f'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p><a name="1d698f4a-6c5c-4cfb-b8e2-2a1455c0645f"></a></p>

<h3>Public Void KimonoBezierPoint ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb">KimonoBezierPoint</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c6fc426-2807-463e-b501-5767cbf9c4c7'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="6c6fc426-2807-463e-b501-5767cbf9c4c7"></a></p>

<h3>Public Void KimonoBezierPoint (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlPoint</td><td style='width:75%' ><p><a name="f98925ab-32aa-4a2b-a30f-b5624a280b25"></a>
<b>SkiaSharp.SKPoint controlPoint</b></p>

<p>Control point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="8a70bb36-de89-42ab-a1cc-246180aec281"></a>
<b>SkiaSharp.SKPoint endPoint</b></p>

<p>End point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bdd0868-bcfc-4db5-85eb-deced5b264e9'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p><a name="5bdd0868-bcfc-4db5-85eb-deced5b264e9"></a></p>

<h3>Public Void KimonoBezierPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="4089ba01-0e37-47f4-bac8-17b299ba20d0"></a>
<b>System.Single controlX</b></p>

<p>Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="f856f482-adde-4ad2-b980-3d2a2320692b"></a>
<b>System.Single controlY</b></p>

<p>Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="bc06c0b4-bcb9-4198-aa99-fa72acce97e8"></a>
<b>System.Single endX</b></p>

<p>End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="bafb3c4e-e596-4d68-8113-72b23a08e458"></a>
<b>System.Single endY</b></p>

<p>End y.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="f51af2c9-f4b2-4244-ad4b-ba7e580ac918"></a>
##Public Class KimonoBlur

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines a blur effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6bb02c99-0365-4101-b214-0feac2e26c4b'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="6bb02c99-0365-4101-b214-0feac2e26c4b"></a>
<b>Private <code>System.Single</code> _horizontalBlurAmount</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0dade5d8-6a1e-4199-af70-171c360dba98'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="0dade5d8-6a1e-4199-af70-171c360dba98"></a>
<b>Private <code>System.Single</code> _verticalBlurAmount</b></p>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#230e905c-5b02-4cdc-970b-9f7649b3cedd'>BlurModified</a></td><td style='width:75%' ><p><a name="230e905c-5b02-4cdc-970b-9f7649b3cedd"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> BlurModified</b></p>

<p>The private <code>BlurModified</code> field of the <code>KimonoBlur</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#49fccf44-9ea8-4bc8-9e95-c195fa81d0f9'>BlurFilter</a></td><td style='width:75%' ><p><a name="49fccf44-9ea8-4bc8-9e95-c195fa81d0f9"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKImageFilter</code> BlurFilter</h3>

<h4>Summary</h4>

<p>Gets the blur filter represented by this blur effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#acbe74ac-659e-458a-939f-9a235c7315f5'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="acbe74ac-659e-458a-939f-9a235c7315f5"></a></p>

<h3>Public <code>System.Single</code> HorizontalBlurAmount</h3>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e442a3f3-94e9-416b-aec1-a39d1710a0ff'>Name</a></td><td style='width:75%' ><p><a name="e442a3f3-94e9-416b-aec1-a39d1710a0ff"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1dcb5bc9-4b27-4472-a389-9640645bd24f'>VerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="1dcb5bc9-4b27-4472-a389-9640645bd24f"></a></p>

<h3>Public <code>System.Single</code> VerticalBlurAmount</h3>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#60221d37-bd82-49e3-8c7a-20198bfdfd37'>Clone</a></td><td style='width:75%' ><p><a name="60221d37-bd82-49e3-8c7a-20198bfdfd37"></a></p>

<h3>Public <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoCore.KimonoBlur</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dad9d6b3-aae6-4228-81d0-ed20250a9758'>KimonoBlur</a></td><td style='width:75%' class='def'><p><a name="dad9d6b3-aae6-4228-81d0-ed20250a9758"></a></p>

<h3>Public Void KimonoBlur ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c7c8709-4a4a-4c46-b162-0e65d4d87311'>KimonoBlur</a></td><td style='width:75%' ><p><a name="3c7c8709-4a4a-4c46-b162-0e65d4d87311"></a></p>

<h3>Public Void KimonoBlur (System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoBlur</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p><a name="b901f15b-0041-4258-affa-6ffea77898bb"></a>
<b>System.Single horizontalBlurAmount</b></p>

<p>Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="7a4a6552-072b-4493-86f4-d9818fa4deb9"></a>
<b>System.Single verticalBlurAmount</b></p>

<p>Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccd40427-a27a-4d35-b556-0e91790d23f1'>RaiseBlurModified</a></td><td style='width:75%' class='def'><p><a name="ccd40427-a27a-4d35-b556-0e91790d23f1"></a></p>

<h3>Void RaiseBlurModified ()</h3>

<h4>Summary</h4>

<p>Raises the blur modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe5ca553-106b-4d46-8726-7a0d315ccde9'>ToCode</a></td><td style='width:75%' ><p><a name="fe5ca553-106b-4d46-8726-7a0d315ccde9"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="7cc0f76f-8e9e-45c3-aafd-98fa4c5a016f"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="cb1a80a4-24c5-4a15-8528-ff3c2480b40f"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5fae785a-9afc-4920-b3c6-7b51500e072d"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d63f410-6137-4902-ae04-f7c61a2203f4'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="7d63f410-6137-4902-ae04-f7c61a2203f4"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="56f042f6-d40e-4456-8fff-eaba19169184"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#988b1c64-2678-4504-be8e-5d4b4e783c27'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="988b1c64-2678-4504-be8e-5d4b4e783c27"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this blur effect to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#583a13db-9fe3-4185-8d78-bfc3c7d87181'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="583a13db-9fe3-4185-8d78-bfc3c7d87181"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts this blur effect to code using the Skia library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7809b13-5d5e-40f5-b542-c63cd60dd61b'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="a7809b13-5d5e-40f5-b542-c63cd60dd61b"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1f1709ab-a80c-41b9-9099-a28ec5ea8f22'>BlurModified</a></td><td style='width:75%' ><p><a name="1f1709ab-a80c-41b9-9099-a28ec5ea8f22"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> BlurModified</h3>

<h4>Summary</h4>

<p>Occurs when the blur is modified.</p>
</td></tr></table></p>


---

<a name="1d07eefe-b52f-4276-a1c9-970a91ec6517"></a>
##Public Class KimonoBounds

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines the outter bounding box for a `KimonoShape` and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#467de0d7-6ebf-4210-a2b9-f44b469802ef'>PreviousCenter</a></td><td style='width:75%' ><p><a name="467de0d7-6ebf-4210-a2b9-f44b469802ef"></a>
<b><code>SkiaSharp.SKPoint</code> PreviousCenter</b></p>

<p>Holds the previous center used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6812419e-36e5-481c-b6ef-48f16a6e1da1'>PreviousRect</a></td><td style='width:75%' class='def'><p><a name="6812419e-36e5-481c-b6ef-48f16a6e1da1"></a>
<b><code>SkiaSharp.SKRect</code> PreviousRect</b></p>

<p>Holds the previous rect used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d7a8c45-ac24-4da4-aa7d-15502b1506ea'>Rect</a></td><td style='width:75%' ><p><a name="4d7a8c45-ac24-4da4-aa7d-15502b1506ea"></a>
<b><code>SkiaSharp.SKRect</code> Rect</b></p>

<p>The base <code>SkRect</code> that holds the internal bounds of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#52db8418-d58f-40fc-a47e-4e82a0a961e5'>Bottom</a></td><td style='width:75%' ><p><a name="52db8418-d58f-40fc-a47e-4e82a0a961e5"></a></p>

<h3>Public <code>System.Single</code> Bottom</h3>

<h4>Summary</h4>

<p>Gets or sets the bottom.</p>

<h4>Return Value</h4>

<p>The bottom coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6574f7ad-7e6b-4410-9f53-5b07c91a8aa9'>BottomHandle</a></td><td style='width:75%' class='def'><p><a name="6574f7ad-7e6b-4410-9f53-5b07c91a8aa9"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> BottomHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the bottom handle.</p>

<h4>Return Value</h4>

<p>The bottom handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e322cf8-2b19-4caa-abf7-1a4c37c13c91'>BottomLeftHandle</a></td><td style='width:75%' ><p><a name="9e322cf8-2b19-4caa-abf7-1a4c37c13c91"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> BottomLeftHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the bottom left handle.</p>

<h4>Return Value</h4>

<p>The bottom left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90da2e69-615a-4a7a-b03f-a9f5986fce26'>BottomRightHandle</a></td><td style='width:75%' class='def'><p><a name="90da2e69-615a-4a7a-b03f-a9f5986fce26"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> BottomRightHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the bottom right handle.</p>

<h4>Return Value</h4>

<p>The bottom right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa8255a2-564c-4139-acb4-3099830d2305'>Center</a></td><td style='width:75%' ><p><a name="aa8255a2-564c-4139-acb4-3099830d2305"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKPoint</code> Center</h3>

<h4>Summary</h4>

<p>Gets the center.</p>

<h4>Return Value</h4>

<p>The center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6cd0c15-9e3e-4d4f-8d61-dced80a0d151'>Height</a></td><td style='width:75%' class='def'><p><a name="f6cd0c15-9e3e-4d4f-8d61-dced80a0d151"></a></p>

<h3>Public <code>System.Single</code> Height</h3>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#493dcbb3-4f53-4e9c-b956-bf3ec4896f54'>HitHandle</a></td><td style='width:75%' ><p><a name="493dcbb3-4f53-4e9c-b956-bf3ec4896f54"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> HitHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the hit handle.</p>

<h4>Return Value</h4>

<p>The hit handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#225971f3-3736-4e66-b859-ec2a3f92e2e6'>HitOffset</a></td><td style='width:75%' class='def'><p><a name="225971f3-3736-4e66-b859-ec2a3f92e2e6"></a></p>

<h3>Public <code>SkiaSharp.SKPoint</code> HitOffset</h3>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#620a9958-9a31-45d9-a347-344e6d489c89'>HorizontalCenter</a></td><td style='width:75%' ><p><a name="620a9958-9a31-45d9-a347-344e6d489c89"></a></p>

<h3>Public Read Only <code>System.Single</code> HorizontalCenter</h3>

<h4>Summary</h4>

<p>Gets the horizontal center.</p>

<h4>Return Value</h4>

<p>The horizontal center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d07a0fac-2cf5-4f3f-9c11-1d382b08cbf7'>Left</a></td><td style='width:75%' class='def'><p><a name="d07a0fac-2cf5-4f3f-9c11-1d382b08cbf7"></a></p>

<h3>Public <code>System.Single</code> Left</h3>

<h4>Summary</h4>

<p>Gets or sets the left.</p>

<h4>Return Value</h4>

<p>The left coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5df8643-16f9-4f61-924a-97ed647bbeee'>LeftHandle</a></td><td style='width:75%' ><p><a name="d5df8643-16f9-4f61-924a-97ed647bbeee"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> LeftHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the left handle.</p>

<h4>Return Value</h4>

<p>The left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#002d13ab-7b73-4834-b613-2520fac52409'>Name</a></td><td style='width:75%' class='def'><p><a name="002d13ab-7b73-4834-b613-2520fac52409"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e0a596d-8980-4ac5-9165-6e08cca2ebf7'>Right</a></td><td style='width:75%' ><p><a name="9e0a596d-8980-4ac5-9165-6e08cca2ebf7"></a></p>

<h3>Public <code>System.Single</code> Right</h3>

<h4>Summary</h4>

<p>Gets or sets the right.</p>

<h4>Return Value</h4>

<p>The right coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c1cd1f8-b53d-4bd2-a6bd-5e3d6730a7bf'>RightHandle</a></td><td style='width:75%' class='def'><p><a name="3c1cd1f8-b53d-4bd2-a6bd-5e3d6730a7bf"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> RightHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the right handle.</p>

<h4>Return Value</h4>

<p>The right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1d4d84e-9d73-48fa-88b6-87259c7a5ce3'>RotationDegrees</a></td><td style='width:75%' ><p><a name="d1d4d84e-9d73-48fa-88b6-87259c7a5ce3"></a></p>

<h3>Public <code>System.Int32</code> RotationDegrees</h3>

<h4>Summary</h4>

<p>Gets or sets the rotation degrees.</p>

<h4>Return Value</h4>

<p>The rotation degrees.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1c99ee6-318e-4147-827a-fa3fd33938b3'>State</a></td><td style='width:75%' class='def'><p><a name="f1c99ee6-318e-4147-827a-fa3fd33938b3"></a></p>

<h3>Public <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> State</h3>

<h4>Summary</h4>

<p>Gets the current edit state of the <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e752f424-228f-44bb-acfa-34c3b7cf468e'>Top</a></td><td style='width:75%' ><p><a name="e752f424-228f-44bb-acfa-34c3b7cf468e"></a></p>

<h3>Public <code>System.Single</code> Top</h3>

<h4>Summary</h4>

<p>Gets or sets the top.</p>

<h4>Return Value</h4>

<p>The top coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a810bf1-7172-4409-a4f3-e4dbafad6f6e'>TopHandle</a></td><td style='width:75%' class='def'><p><a name="3a810bf1-7172-4409-a4f3-e4dbafad6f6e"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> TopHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the top handle.</p>

<h4>Return Value</h4>

<p>The top handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70bc3353-3eb1-4534-a35a-052c5be6c73b'>TopLeftHandle</a></td><td style='width:75%' ><p><a name="70bc3353-3eb1-4534-a35a-052c5be6c73b"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> TopLeftHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the top left handle.</p>

<h4>Return Value</h4>

<p>The top left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17c84ab2-55bb-49e2-978a-8cebd78583cb'>TopRightHandle</a></td><td style='width:75%' class='def'><p><a name="17c84ab2-55bb-49e2-978a-8cebd78583cb"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> TopRightHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the top right handle.</p>

<h4>Return Value</h4>

<p>The top right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6642a42-a9ba-43e9-b873-4a5181926aef'>UniqueID</a></td><td style='width:75%' ><p><a name="b6642a42-a9ba-43e9-b873-4a5181926aef"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66f3dc50-217a-4f87-98f9-f743695907af'>VerticalCenter</a></td><td style='width:75%' class='def'><p><a name="66f3dc50-217a-4f87-98f9-f743695907af"></a></p>

<h3>Public Read Only <code>System.Single</code> VerticalCenter</h3>

<h4>Summary</h4>

<p>Gets the vertical center.</p>

<h4>Return Value</h4>

<p>The vertical center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdb0646d-ffe8-4a46-be99-9f56f3238429'>Width</a></td><td style='width:75%' ><p><a name="bdb0646d-ffe8-4a46-be99-9f56f3238429"></a></p>

<h3>Public <code>System.Single</code> Width</h3>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width of the shape's bounding box.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9e4efb2f-07be-47e0-b89e-404c19dab565'>AddHandles</a></td><td style='width:75%' ><p><a name="9e4efb2f-07be-47e0-b89e-404c19dab565"></a></p>

<h3>Void AddHandles (KimonoCore.KimonoShapeState)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Adds the control handles to the bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="33f01adc-19ba-4977-99aa-c1f0bfff744a"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>state</code> parameter of the AddHandles method takes a <code>KimonoCore.KimonoShapeState</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9620f511-bd94-46e2-b582-db9e1e90db23'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="9620f511-bd94-46e2-b582-db9e1e90db23"></a></p>

<h3>Public Virtual Void BoundsChanged ()</h3>

<h4>Summary</h4>

<p>Updates the location of the edit handles when the bounds has been relocated or resized.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfce3ec5-c88a-4f0e-ac01-3b6412d491d5'>ChangeBounds</a></td><td style='width:75%' ><p><a name="dfce3ec5-c88a-4f0e-ac01-3b6412d491d5"></a></p>

<h3>Public Virtual Void ChangeBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Changes the bounds to match the given values.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="13203887-0b67-4c20-adbf-ec7d1eede121"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6840fcba-be8b-408c-8fbd-e04d4fc5e053"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2c978685-955a-4751-bcb3-b30469e65353"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="5e7aa4ce-4a2f-4fd2-b7db-28c0cc4e239a"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fc6aadd-d3f4-4225-af65-036123b77211'>Clone</a></td><td style='width:75%' class='def'><p><a name="6fc6aadd-d3f4-4225-af65-036123b77211"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c544d183-8a1e-4a7c-926c-7bcdb00c40b6'>DragBounds</a></td><td style='width:75%' ><p><a name="c544d183-8a1e-4a7c-926c-7bcdb00c40b6"></a></p>

<h3>Public Virtual Void DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e2188d47-c334-4bb6-910c-57865a65ab3b"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40624792-9584-410f-8fa4-50a292bbb098'>Draw</a></td><td style='width:75%' class='def'><p><a name="40624792-9584-410f-8fa4-50a292bbb098"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the bounding box and its edit handles into the given canvas</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="e4647ac0-9dfb-464e-9490-bda8e30ab25e"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>Canvas.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3de7fbef-eba8-4cf0-ae7d-d08612e25a41'>GrowBounds</a></td><td style='width:75%' ><p><a name="3de7fbef-eba8-4cf0-ae7d-d08612e25a41"></a></p>

<h3>Public Virtual Void GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Adjusts the size of the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="fbf4ee40-aab8-4fa0-b60d-60e9d604ec22"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new size as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2372065d-3c64-4e3c-a9cd-bb98a83a11c7'>KimonoBounds</a></td><td style='width:75%' class='def'><p><a name="2372065d-3c64-4e3c-a9cd-bb98a83a11c7"></a></p>

<h3>Public Void KimonoBounds ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#046a1852-209c-4f5b-9d68-c07aee78d493'>KimonoBounds</a></td><td style='width:75%' ><p><a name="046a1852-209c-4f5b-9d68-c07aee78d493"></a></p>

<h3>Public Void KimonoBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f2640e37-d0b1-4b7a-984f-66a3e5373458"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="457e75c8-fc32-4712-ba7e-2f2b5950d3a6"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d226e188-574e-4f6e-8225-391d0d9d3096"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="ebc52ecf-28cf-44a6-b890-1e791c8a355f"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f43042d-ad4f-4d27-81b9-808f5fec5a8b'>KimonoBounds</a></td><td style='width:75%' class='def'><p><a name="8f43042d-ad4f-4d27-81b9-808f5fec5a8b"></a></p>

<h3>Public Void KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="4227dffa-5db6-4739-8d5b-c1b8c19e3282"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="9617d19b-89ca-445d-98b4-9b3e5046bad2"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ba4a25df-c4e8-4695-bf05-e1be0e205035"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1082c183-0169-4c39-96e6-b5afd62fbcf5"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="3de9278d-b866-4a98-b31e-56ed365b9e50"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#11e23035-3365-41f8-a31d-de8edea7f92c'>MoveBounds</a></td><td style='width:75%' ><p><a name="11e23035-3365-41f8-a31d-de8edea7f92c"></a></p>

<h3>Public Virtual Void MoveBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Moves the bounds to the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="22b65127-a0d9-48f4-8805-a9364fe99867"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new top, left location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60c9efe0-adff-4abb-ac51-02ae5fa961e2'>PlaceUnderConstruction</a></td><td style='width:75%' class='def'><p><a name="60c9efe0-adff-4abb-ac51-02ae5fa961e2"></a></p>

<h3>Public Void PlaceUnderConstruction (System.Boolean)</h3>

<h4>Summary</h4>

<p>Places the bounds under construction.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p><a name="7715c28d-3124-42f0-9a2a-32b1b94e9e03"></a>
<b>System.Boolean needsHandles</b></p>

<p>If set to <code>true</code> needs handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb98eaec-b1e9-4b95-a554-fd6e1f81d7c5'>PointInBound</a></td><td style='width:75%' ><p><a name="fb98eaec-b1e9-4b95-a554-fd6e1f81d7c5"></a></p>

<h3>Public Virtual <code>System.Boolean</code> PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="23e9c010-fbf2-4f2c-89bb-1c4831516d60"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c69c5df9-5bae-4140-9251-ba2e90650761'>RemoveHandles</a></td><td style='width:75%' class='def'><p><a name="c69c5df9-5bae-4140-9251-ba2e90650761"></a></p>

<h3>Void RemoveHandles ()</h3>

<h4>Summary</h4>

<p>Removes the control handles from the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#637851ae-c5a8-4704-ad98-d526a4387619'>SavePreviousBounds</a></td><td style='width:75%' ><p><a name="637851ae-c5a8-4704-ad98-d526a4387619"></a></p>

<h3>Void SavePreviousBounds ()</h3>

<h4>Summary</h4>

<p>Saves the previous bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f953710-a234-427e-a78e-6cc57b705f13'>Select</a></td><td style='width:75%' class='def'><p><a name="1f953710-a234-427e-a78e-6cc57b705f13"></a></p>

<h3>Public Void Select ()</h3>

<h4>Summary</h4>

<p>Puts the <code>KimonoShape</code> into the edit mode and creates the edit handles as required.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6918aee9-52fa-4e6d-9acb-5c34c66f6573'>StartGrouping</a></td><td style='width:75%' ><p><a name="6918aee9-52fa-4e6d-9acb-5c34c66f6573"></a></p>

<h3>Public Void StartGrouping ()</h3>

<h4>Summary</h4>

<p>Starts the bounds grouping.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#585cd282-3c6a-4dbd-841f-9cb148cfd249'>ToCode</a></td><td style='width:75%' class='def'><p><a name="585cd282-3c6a-4dbd-841f-9cb148cfd249"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="5dbed7b7-fe85-43bd-8fd8-a86e653a2c38"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="18f50167-bcc3-448d-8bab-0f53f59a97d7"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="52dfab0d-cea8-428a-937a-c763c8b7c7a6"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2929fbbf-8585-477c-9a01-7914631c4413'>ToCSharp</a></td><td style='width:75%' ><p><a name="2929fbbf-8585-477c-9a01-7914631c4413"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5015b5c6-e5fb-41a7-915c-53749ec9e134"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#522a8589-a20a-4482-bc3d-9060150916cf'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="522a8589-a20a-4482-bc3d-9060150916cf"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e723dfc4-f5fb-44f1-a0e3-37a94ccb22e9'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="e723dfc4-f5fb-44f1-a0e3-37a94ccb22e9"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01480e8c-cfae-4874-9267-1de834c6515f'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="01480e8c-cfae-4874-9267-1de834c6515f"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a720ca6-d55a-4da2-82c4-0cf8c03d0ded'>Unselect</a></td><td style='width:75%' ><p><a name="0a720ca6-d55a-4da2-82c4-0cf8c03d0ded"></a></p>

<h3>Public Void Unselect ()</h3>

<h4>Summary</h4>

<p>Unselects the <code>KimonoShape</code> as the current edit target and removes any edit handles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa8b28be-2a31-4b7f-8f46-a3001323a9b6'>ValueBetween</a></td><td style='width:75%' class='def'><p><a name="fa8b28be-2a31-4b7f-8f46-a3001323a9b6"></a></p>

<h3><code>System.Boolean</code> ValueBetween (System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Checks to see if the given value is between the two given points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="b4867cf5-4b20-418d-85c6-5fd69ff62122"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p><a name="b6465a54-5820-437a-a7de-6ea66dbe453b"></a>
<b>System.Single a</b></p>

<p>The alpha component.</p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p><a name="ee20366c-9f22-49e9-8079-e80aed6242b2"></a>
<b>System.Single b</b></p>

<p>The blue component.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>Boolean</code>.</p>
</td></tr></table></p>


---

<a name="92776647-54fd-46d9-b8d2-ff7b70824564"></a>
##Public Static Class KimonoCodeGenerator

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

The Kimono Code Generator has routine to assist in the generation of output source code.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#87ea0a72-0389-4eb0-926f-59f404594d3f'>AddNumberToElementNames</a></td><td style='width:75%' ><p><a name="87ea0a72-0389-4eb0-926f-59f404594d3f"></a>
<b>Public Static <code>System.Boolean</code> AddNumberToElementNames</b></p>

<p>Add number to element names when generating.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f132c878-3750-4a63-a612-a71fd93aaa08'>NextElementNumber</a></td><td style='width:75%' class='def'><p><a name="f132c878-3750-4a63-a612-a71fd93aaa08"></a>
<b>Public Static <code>System.Int32</code> NextElementNumber</b></p>

<p>The next element number.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef04b23e-338d-4e9e-94be-7686be4f164c'>SupportingColors</a></td><td style='width:75%' ><p><a name="ef04b23e-338d-4e9e-94be-7686be4f164c"></a>
<b>Public Static <code>System.Collections.Generic.List&lt;KimonoCore.KimonoColor&gt;</code> SupportingColors</b></p>

<p>A list of supporting colors that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5e86f90-ba62-4509-883d-12115edbbb29'>SupportingGradients</a></td><td style='width:75%' class='def'><p><a name="a5e86f90-ba62-4509-883d-12115edbbb29"></a>
<b>Public Static <code>System.Collections.Generic.List&lt;KimonoCore.KimonoGradient&gt;</code> SupportingGradients</b></p>

<p>A list of supporting gradients that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1eb0e02c-7075-46e6-a120-dc166b8cd7e8'>SupportingStyles</a></td><td style='width:75%' ><p><a name="1eb0e02c-7075-46e6-a120-dc166b8cd7e8"></a>
<b>Public Static <code>System.Collections.Generic.List&lt;KimonoCore.KimonoStyle&gt;</code> SupportingStyles</b></p>

<p>A list of supporting styles that are required for the object being converted to source code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#926a96a2-3e26-4a8b-b089-298ee5a8fd5e'>AddSupportingColor</a></td><td style='width:75%' ><p><a name="926a96a2-3e26-4a8b-b089-298ee5a8fd5e"></a></p>

<h3>Public Static <code>System.String</code> AddSupportingColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Adds the given color to the collection of named colors that are used in the generation of other Kimono Objects. If a color is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="71fba81a-0b9c-454e-8f6d-eb7f89a70397"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to add to the collection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e78fc204-4676-49e0-914e-7229fa58ba6f'>AddSupportingGradient</a></td><td style='width:75%' class='def'><p><a name="e78fc204-4676-49e0-914e-7229fa58ba6f"></a></p>

<h3>Public Static <code>System.String</code> AddSupportingGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Adds the given gradient to the collection of named gradients that are used in the generation of other Kimono Objects. If a gradient is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="e3dae804-9d05-4b10-be80-f851ed3176f4"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d751f4b1-5194-4a26-9d27-0bfb85a3ea2d'>AddSupportingStyle</a></td><td style='width:75%' ><p><a name="d751f4b1-5194-4a26-9d27-0bfb85a3ea2d"></a></p>

<h3>Public Static <code>System.String</code> AddSupportingStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Adds the given style to the collection of named styles that are used in the generation of other Kimono Objects. If a style is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="823d420b-ec1d-4a41-8749-a2479e7c4384"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e82ee956-cfda-43f7-801e-9616e754b704'>CodeForSupportGradients</a></td><td style='width:75%' class='def'><p><a name="e82ee956-cfda-43f7-801e-9616e754b704"></a></p>

<h3>Public Static <code>System.String</code> CodeForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="e30b5560-65b9-48cf-a4f8-560144d6e31f"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="058336eb-4d3d-4338-a872-4187d13a953e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#561f6222-b8b6-40e3-825f-d9cb1aa9a665'>CodeForSupportingColors</a></td><td style='width:75%' ><p><a name="561f6222-b8b6-40e3-825f-d9cb1aa9a665"></a></p>

<h3>Public Static <code>System.String</code> CodeForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="3036faaa-4125-4a93-b70b-1c2e36129ea8"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="e71a9c15-6877-4849-aebf-7fd9fb36fa7e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd2b3f57-b921-45c6-9ac1-3590a4f7d39d'>CodeForSupportStyles</a></td><td style='width:75%' class='def'><p><a name="fd2b3f57-b921-45c6-9ac1-3590a4f7d39d"></a></p>

<h3>Public Static <code>System.String</code> CodeForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="c2482a6f-6f84-4381-b6d0-0ab190b22a8d"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="751e809b-2340-4f2b-a331-1d9b50c90120"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2454ef62-dce4-405a-900a-e8319b3fa000'>ColorToCode</a></td><td style='width:75%' ><p><a name="2454ef62-dce4-405a-900a-e8319b3fa000"></a></p>

<h3>Public Static <code>System.String</code> ColorToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Converts the given color to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="07ba5428-c957-4959-bf19-ec7b5440ae73"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="f9901757-5d10-42b7-ad27-c0468b5338e1"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>The <code>SKColor</code> to create code for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8e9ac97-077c-45a3-8e10-ac2d35ba571f'>IncreaseIndentLevel</a></td><td style='width:75%' class='def'><p><a name="b8e9ac97-077c-45a3-8e10-ac2d35ba571f"></a></p>

<h3>Public Static <code>System.String</code> IncreaseIndentLevel (System.String)</h3>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="efd5d86b-1a28-4027-9c91-db1a0fee0069"></a>
<b>System.String sourceCode</b></p>

<p>The source code to indent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code indented by one tab.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f78167cd-31ce-43fa-8677-95c22df64357'>IncreaseIndentLevel</a></td><td style='width:75%' ><p><a name="f78167cd-31ce-43fa-8677-95c22df64357"></a></p>

<h3>Public Static <code>System.String</code> IncreaseIndentLevel (System.String, System.Int32)</h3>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code by the given number of levels</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="042801df-dd8a-4d85-9c85-1c693c50dbeb"></a>
<b>System.String sourceCode</b></p>

<p>Source code.</p>
</td></tr><tr><td style='width:25%' class='term'>levels</td><td style='width:75%' class='def'><p><a name="15244769-3a0b-4d12-8005-3b038fd8a3f8"></a>
<b>System.Int32 levels</b></p>

<p>Levels.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The indent level.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4004686-2a0a-44be-a5dc-e48a54237b4a'>InitializerForSupportGradients</a></td><td style='width:75%' class='def'><p><a name="e4004686-2a0a-44be-a5dc-e48a54237b4a"></a></p>

<h3>Public Static <code>System.String</code> InitializerForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="7832fc85-de1a-44e7-8049-3c744a163b46"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="634a4607-0b3b-427b-9872-a94a1687e272"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c235c0c-f608-4289-9484-10818abf3fbf'>InitializerForSupportStyles</a></td><td style='width:75%' ><p><a name="4c235c0c-f608-4289-9484-10818abf3fbf"></a></p>

<h3>Public Static <code>System.String</code> InitializerForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="a7afeb41-719a-417d-bd19-61104906ed9f"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="bccf0bfe-84d3-4519-bf19-548eb96c469e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8533743-c921-494c-9407-663a2bf1ed66'>KimonoCodeGenerator</a></td><td style='width:75%' class='def'><p><a name="a8533743-c921-494c-9407-663a2bf1ed66"></a></p>

<h3>Private Static Void KimonoCodeGenerator ()</h3>

<h4>Summary</h4>

<p>The private static <code>KimonoCodeGenerator ()</code> constructor for the <code>KimonoCodeGenerator</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69af390c-00ba-4778-bb8e-7cbb15de3628'>MakeElementName</a></td><td style='width:75%' ><p><a name="69af390c-00ba-4778-bb8e-7cbb15de3628"></a></p>

<h3>Public Static <code>System.String</code> MakeElementName (System.String)</h3>

<h4>Summary</h4>

<p>Makes a valid source code name for the name of a given Kimono Object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="2f42ea7d-eb88-46e0-a7f6-88eacc8d0b03"></a>
<b>System.String name</b></p>

<p>The source Kimono Object name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The element name valid for use in source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ea21323-b2ec-424c-9e9f-a75a9f82b872'>PointToCode</a></td><td style='width:75%' class='def'><p><a name="8ea21323-b2ec-424c-9e9f-a75a9f82b872"></a></p>

<h3>Public Static <code>System.String</code> PointToCode (KimonoCore.CodeOutputLibrary, KimonoCore.KimonoHandle)</h3>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8947c229-3579-43df-ace8-925c67c7f89e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="237e51c7-ea39-4712-898f-b5bbda257f88"></a>
<b>KimonoCore.KimonoHandle point</b></p>

<p>The <code>KimonoHandle</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88509554-cba3-4bb6-9813-de7a669f1355'>PointToCode</a></td><td style='width:75%' ><p><a name="88509554-cba3-4bb6-9813-de7a669f1355"></a></p>

<h3>Public Static <code>System.String</code> PointToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="51747b5e-8e5a-43ba-a78c-d3ba1fb002ef"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="28cb7084-e624-41eb-abe6-aea3606f8e0d"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1228bde4-de29-4345-acd9-3a9b4bf8c0e9'>PrivateVariablesForSupportingGradients</a></td><td style='width:75%' class='def'><p><a name="1228bde4-de29-4345-acd9-3a9b4bf8c0e9"></a></p>

<h3>Public Static <code>System.String</code> PrivateVariablesForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="15d2a8aa-705c-4b98-81ef-c125f768834d"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="ca5a3669-eb2e-43f2-9b8b-34e1e825328d"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5846b5d4-1957-4cdd-9dce-2f1ac8401ed5'>PropertyForSupportingColors</a></td><td style='width:75%' ><p><a name="5846b5d4-1957-4cdd-9dce-2f1ac8401ed5"></a></p>

<h3>Public Static <code>System.String</code> PropertyForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="03f61238-dc2e-460e-b5e1-d0506c271c87"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="0ca53bd8-6263-4aeb-baed-11db63762973"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44ec491d-de42-4469-99c3-959fcbf8caf7'>PropertyForSupportingGradients</a></td><td style='width:75%' class='def'><p><a name="44ec491d-de42-4469-99c3-959fcbf8caf7"></a></p>

<h3>Public Static <code>System.String</code> PropertyForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="946900a0-ccc9-46d7-93c8-a913b30e9406"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="32e7e989-6b49-4234-84c3-66135243fea3"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6886ce44-cef8-4c77-8faf-62c52abaa691'>PropertyForSupportingStyles</a></td><td style='width:75%' ><p><a name="6886ce44-cef8-4c77-8faf-62c52abaa691"></a></p>

<h3>Public Static <code>System.String</code> PropertyForSupportingStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="06b089f1-d6c7-4654-bfa1-e10ab50d8da6"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="415318f6-3547-4992-94ed-5334dd3fbbc5"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#886ea605-414f-4e9d-b8c0-d4409a1e21d3'>ResetCodeGeneration</a></td><td style='width:75%' class='def'><p><a name="886ea605-414f-4e9d-b8c0-d4409a1e21d3"></a></p>

<h3>Public Static Void ResetCodeGeneration ()</h3>

<h4>Summary</h4>

<p>Resets the code generation.</p>
</td></tr></table></p>


---

<a name="6a61d428-669b-4b00-8f29-7eac9ab41f57"></a>
##Public Class KimonoColor

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

The public `KimonoColor` class inherits from the `System.Object` class and is defined in the `KimonoCore` namespace. It defines 19 fields, 75 properties, 110 methods and one event.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4340c241-c169-487c-b0a6-596d9d370e4e'>_adjustAlpha</a></td><td style='width:75%' ><p><a name="4340c241-c169-487c-b0a6-596d9d370e4e"></a>
<b><code>System.Boolean</code> _adjustAlpha</b></p>

<p>Should adjust alpha transparency.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fc8f88f-5f0d-4833-8028-c753267e57bf'>_adjustBrightness</a></td><td style='width:75%' class='def'><p><a name="9fc8f88f-5f0d-4833-8028-c753267e57bf"></a>
<b><code>System.Boolean</code> _adjustBrightness</b></p>

<p>Should adjust brightness.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5291c4ce-0d20-4cdd-ab92-b70a42fcf109'>_adjustHue</a></td><td style='width:75%' ><p><a name="5291c4ce-0d20-4cdd-ab92-b70a42fcf109"></a>
<b><code>System.Boolean</code> _adjustHue</b></p>

<p>Should adjust hue.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfa5bd40-3511-4482-9e9e-c078658b3a49'>_adjustSaturation</a></td><td style='width:75%' class='def'><p><a name="cfa5bd40-3511-4482-9e9e-c078658b3a49"></a>
<b><code>System.Boolean</code> _adjustSaturation</b></p>

<p>Should adjust saturation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b442686-10cc-428f-bc87-a0de21ef3964'>_alphaAdjustment</a></td><td style='width:75%' ><p><a name="1b442686-10cc-428f-bc87-a0de21ef3964"></a>
<b><code>System.Int32</code> _alphaAdjustment</b></p>

<p>The alpha adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#280cc8d4-1ac1-4fe2-a2e2-b66ef54f568f'>_baseColor</a></td><td style='width:75%' class='def'><p><a name="280cc8d4-1ac1-4fe2-a2e2-b66ef54f568f"></a>
<b><a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> _baseColor</b></p>

<p>The <code>KiminoColor</code> this color is based off of.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53234a67-5f57-4502-97f2-f08f5b89758b'>_brightnessAdjustment</a></td><td style='width:75%' ><p><a name="53234a67-5f57-4502-97f2-f08f5b89758b"></a>
<b><code>System.Single</code> _brightnessAdjustment</b></p>

<p>The brightness adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#deb7f975-7068-4742-a779-e29f0b3c8294'>_color</a></td><td style='width:75%' class='def'><p><a name="deb7f975-7068-4742-a779-e29f0b3c8294"></a>
<b><code>SkiaSharp.SKColor</code> _color</b></p>

<p>The color value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5edcd3d9-c94d-4cdc-a45e-7b7d52970ccc'>_hueAdjustment</a></td><td style='width:75%' ><p><a name="5edcd3d9-c94d-4cdc-a45e-7b7d52970ccc"></a>
<b><code>System.Single</code> _hueAdjustment</b></p>

<p>The hue adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95db1c7a-991e-4d11-a831-df6ac346154b'>_saturationAdjustment</a></td><td style='width:75%' class='def'><p><a name="95db1c7a-991e-4d11-a831-df6ac346154b"></a>
<b><code>System.Single</code> _saturationAdjustment</b></p>

<p>The saturation adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#982d1fbe-272f-4865-952b-bf3c5c85b197'>Alpha</a></td><td style='width:75%' ><p><a name="982d1fbe-272f-4865-952b-bf3c5c85b197"></a>
<b><code>System.Int32</code> Alpha</b></p>

<p>The base alpha transparency value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#048b45c8-9cee-4798-8dee-8cf2e14dbc87'>Brightness</a></td><td style='width:75%' class='def'><p><a name="048b45c8-9cee-4798-8dee-8cf2e14dbc87"></a>
<b><code>System.Single</code> Brightness</b></p>

<p>The base brightness.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19a5bc49-af79-46bc-9c04-96fadc71db3a'>ColorChanged</a></td><td style='width:75%' ><p><a name="19a5bc49-af79-46bc-9c04-96fadc71db3a"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ColorChanged</b></p>

<p>The private <code>ColorChanged</code> field of the <code>KimonoColor</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cde36e41-6985-4070-b063-fffa52673945'>Hue</a></td><td style='width:75%' class='def'><p><a name="cde36e41-6985-4070-b063-fffa52673945"></a>
<b><code>System.Single</code> Hue</b></p>

<p>The base hue.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#471e56c4-a156-4513-88f9-f5dea860c69d'>Saturation</a></td><td style='width:75%' ><p><a name="471e56c4-a156-4513-88f9-f5dea860c69d"></a>
<b><code>System.Single</code> Saturation</b></p>

<p>The base saturation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3359993d-1f72-4f26-8821-52e644456d9f'>AdjustsAlpha</a></td><td style='width:75%' ><p><a name="3359993d-1f72-4f26-8821-52e644456d9f"></a></p>

<h3>Public <code>System.Boolean</code> AdjustsAlpha</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> adjusts alpha.</p>

<h4>Return Value</h4>

<p><code>true</code> if adjusts alpha; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4ce90c5-03d8-4bd5-a53a-c7b7838dc0b4'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p><a name="c4ce90c5-03d8-4bd5-a53a-c7b7838dc0b4"></a></p>

<h3>Public <code>System.Boolean</code> AdjustsBrightness</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> adjusts brightness.</p>

<h4>Return Value</h4>

<p><code>true</code> if adjusts brightness; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e1f7393-297e-45e5-8ffc-0e4b6486a0dd'>AdjustsHue</a></td><td style='width:75%' ><p><a name="7e1f7393-297e-45e5-8ffc-0e4b6486a0dd"></a></p>

<h3>Public <code>System.Boolean</code> AdjustsHue</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> adjusts hue.</p>

<h4>Return Value</h4>

<p><code>true</code> if adjusts hue; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a24ae2a-2d4e-4f36-baec-4dfcdbeed1df'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p><a name="0a24ae2a-2d4e-4f36-baec-4dfcdbeed1df"></a></p>

<h3>Public <code>System.Boolean</code> AdjustsSaturation</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> adjusts saturation.</p>

<h4>Return Value</h4>

<p><code>true</code> if adjusts saturation; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#581409e8-9a38-4e9f-9239-79fe09f2271e'>AlphaAdjustment</a></td><td style='width:75%' ><p><a name="581409e8-9a38-4e9f-9239-79fe09f2271e"></a></p>

<h3>Public <code>System.Int32</code> AlphaAdjustment</h3>

<h4>Summary</h4>

<p>Gets or sets the alpha adjustment.</p>

<h4>Return Value</h4>

<p>The alpha adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#903274b5-d3b8-4fac-abff-d7a6f024e992'>Aluminum</a></td><td style='width:75%' class='def'><p><a name="903274b5-d3b8-4fac-abff-d7a6f024e992"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Aluminum</h3>

<h4>Summary</h4>

<p>The public static read only <code>Aluminum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71c5e89c-7396-4b23-a9a0-d18e947e1a69'>Aqua</a></td><td style='width:75%' ><p><a name="71c5e89c-7396-4b23-a9a0-d18e947e1a69"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Aqua</h3>

<h4>Summary</h4>

<p>The public static read only <code>Aqua</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62b1cbfd-f493-44b0-9f9f-80eb7f18295e'>Asparagus</a></td><td style='width:75%' class='def'><p><a name="62b1cbfd-f493-44b0-9f9f-80eb7f18295e"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Asparagus</h3>

<h4>Summary</h4>

<p>The public static read only <code>Asparagus</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a933f35-4c55-49af-8e12-669ca0fbe779'>Banana</a></td><td style='width:75%' ><p><a name="6a933f35-4c55-49af-8e12-669ca0fbe779"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Banana</h3>

<h4>Summary</h4>

<p>The public static read only <code>Banana</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afd5e188-c51f-41bc-a5ed-06c1cb7e7208'>BaseColor</a></td><td style='width:75%' class='def'><p><a name="afd5e188-c51f-41bc-a5ed-06c1cb7e7208"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> BaseColor</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoColor</code> that this color is based off of.</p>

<h4>Return Value</h4>

<p>The base color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65c49c9e-4367-4877-8ddc-9bcaa35f64ed'>Black</a></td><td style='width:75%' ><p><a name="65c49c9e-4367-4877-8ddc-9bcaa35f64ed"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Black</h3>

<h4>Summary</h4>

<p>The public static read only <code>Black</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae6f9625-7e85-4afb-ba7c-c1f7310903c9'>Blue</a></td><td style='width:75%' class='def'><p><a name="ae6f9625-7e85-4afb-ba7c-c1f7310903c9"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Blue</h3>

<h4>Summary</h4>

<p>The public static read only <code>Blue</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2ecae6c-5595-48e8-a532-ac7c4dc2c97b'>Blueberry</a></td><td style='width:75%' ><p><a name="f2ecae6c-5595-48e8-a532-ac7c4dc2c97b"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Blueberry</h3>

<h4>Summary</h4>

<p>The public static read only <code>Blueberry</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12521ce8-0174-4314-8b63-e43eff072486'>BrightnessAdjustment</a></td><td style='width:75%' class='def'><p><a name="12521ce8-0174-4314-8b63-e43eff072486"></a></p>

<h3>Public <code>System.Single</code> BrightnessAdjustment</h3>

<h4>Summary</h4>

<p>Gets or sets the brightness adjustment.</p>

<h4>Return Value</h4>

<p>The brightness adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0fbcb32e-8bfc-4dd1-9bb4-ca69525aff4b'>Bubblegum</a></td><td style='width:75%' ><p><a name="0fbcb32e-8bfc-4dd1-9bb4-ca69525aff4b"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Bubblegum</h3>

<h4>Summary</h4>

<p>The public static read only <code>Bubblegum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c27d17e7-a004-493a-ad8d-c05558d028e0'>Cantalope</a></td><td style='width:75%' class='def'><p><a name="c27d17e7-a004-493a-ad8d-c05558d028e0"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Cantalope</h3>

<h4>Summary</h4>

<p>The public static read only <code>Cantalope</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#085bc0c6-60df-4ed0-b594-346f12611575'>Carnation</a></td><td style='width:75%' ><p><a name="085bc0c6-60df-4ed0-b594-346f12611575"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Carnation</h3>

<h4>Summary</h4>

<p>The public static read only <code>Carnation</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc37e994-bad5-48e7-9394-b24f993b52a4'>Cayenne</a></td><td style='width:75%' class='def'><p><a name="dc37e994-bad5-48e7-9394-b24f993b52a4"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Cayenne</h3>

<h4>Summary</h4>

<p>The public static read only <code>Cayenne</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e9218b2-7fe1-4dc4-8fb6-ac9bed079d90'>Clover</a></td><td style='width:75%' ><p><a name="0e9218b2-7fe1-4dc4-8fb6-ac9bed079d90"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Clover</h3>

<h4>Summary</h4>

<p>The public static read only <code>Clover</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f61786d-606b-4732-9192-e4e89f7fda2f'>Color</a></td><td style='width:75%' class='def'><p><a name="0f61786d-606b-4732-9192-e4e89f7fda2f"></a></p>

<h3>Public <code>SkiaSharp.SKColor</code> Color</h3>

<h4>Summary</h4>

<p>Gets or sets the color.</p>

<h4>Return Value</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e81ea8c-8a77-45ef-b80a-423695b9c5c8'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="3e81ea8c-8a77-45ef-b80a-423695b9c5c8"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoColor</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#963d14f7-6520-4241-bba0-9a978da41d41'>DarkGray</a></td><td style='width:75%' class='def'><p><a name="963d14f7-6520-4241-bba0-9a978da41d41"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> DarkGray</h3>

<h4>Summary</h4>

<p>The public static read only <code>DarkGray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79f800d5-ae2a-4252-a0c9-b8e97a71a909'>Eggplant</a></td><td style='width:75%' ><p><a name="79f800d5-ae2a-4252-a0c9-b8e97a71a909"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Eggplant</h3>

<h4>Summary</h4>

<p>The public static read only <code>Eggplant</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50090d73-1deb-446e-96b1-194cc532a95e'>ElementName</a></td><td style='width:75%' class='def'><p><a name="50090d73-1deb-446e-96b1-194cc532a95e"></a></p>

<h3>Private <code>System.String</code> ElementName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bbb9740-1e79-4ea4-b088-f3802f0d58b5'>Fern</a></td><td style='width:75%' ><p><a name="0bbb9740-1e79-4ea4-b088-f3802f0d58b5"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Fern</h3>

<h4>Summary</h4>

<p>The public static read only <code>Fern</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d17b933-1ab4-4f43-8684-ef1bdcfda5f2'>Flora</a></td><td style='width:75%' class='def'><p><a name="0d17b933-1ab4-4f43-8684-ef1bdcfda5f2"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Flora</h3>

<h4>Summary</h4>

<p>The public static read only <code>Flora</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d33a74c5-2356-470f-8337-64c8a3130a6e'>Grape</a></td><td style='width:75%' ><p><a name="d33a74c5-2356-470f-8337-64c8a3130a6e"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Grape</h3>

<h4>Summary</h4>

<p>The public static read only <code>Grape</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2f14492-8363-4c07-a23c-ba143e462490'>Gray</a></td><td style='width:75%' class='def'><p><a name="d2f14492-8363-4c07-a23c-ba143e462490"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Gray</h3>

<h4>Summary</h4>

<p>The public static read only <code>Gray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f936d52-5849-470d-b736-18ed8239a713'>Green</a></td><td style='width:75%' ><p><a name="5f936d52-5849-470d-b736-18ed8239a713"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Green</h3>

<h4>Summary</h4>

<p>The public static read only <code>Green</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7cb2a2a-335d-4dfe-b6fe-9c703b5c8462'>Honeydew</a></td><td style='width:75%' class='def'><p><a name="f7cb2a2a-335d-4dfe-b6fe-9c703b5c8462"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Honeydew</h3>

<h4>Summary</h4>

<p>The public static read only <code>Honeydew</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f37ab5f5-a301-497a-9c69-21efc89a26f9'>HueAdjustment</a></td><td style='width:75%' ><p><a name="f37ab5f5-a301-497a-9c69-21efc89a26f9"></a></p>

<h3>Public <code>System.Single</code> HueAdjustment</h3>

<h4>Summary</h4>

<p>Gets or sets the hue adjustment.</p>

<h4>Return Value</h4>

<p>The hue adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2da442a-d351-49d5-b08e-c183762cdb93'>Ice</a></td><td style='width:75%' class='def'><p><a name="a2da442a-d351-49d5-b08e-c183762cdb93"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Ice</h3>

<h4>Summary</h4>

<p>The public static read only <code>Ice</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94198fa9-b1b5-45ce-8115-3b80bc732075'>Iron</a></td><td style='width:75%' ><p><a name="94198fa9-b1b5-45ce-8115-3b80bc732075"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Iron</h3>

<h4>Summary</h4>

<p>The public static read only <code>Iron</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dbbd5f3-55c9-4e2a-8f41-d71baa09056c'>Lavender</a></td><td style='width:75%' class='def'><p><a name="5dbbd5f3-55c9-4e2a-8f41-d71baa09056c"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Lavender</h3>

<h4>Summary</h4>

<p>The public static read only <code>Lavender</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2f487f4-16a6-4cb7-bcc2-4303d5beb059'>Lead</a></td><td style='width:75%' ><p><a name="b2f487f4-16a6-4cb7-bcc2-4303d5beb059"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Lead</h3>

<h4>Summary</h4>

<p>The public static read only <code>Lead</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#917d91ef-fd1d-48e3-af73-7c205322e4dd'>Lemon</a></td><td style='width:75%' class='def'><p><a name="917d91ef-fd1d-48e3-af73-7c205322e4dd"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Lemon</h3>

<h4>Summary</h4>

<p>The public static read only <code>Lemon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fcd8236-8e13-4259-a740-41c6cf17688e'>Licorice</a></td><td style='width:75%' ><p><a name="9fcd8236-8e13-4259-a740-41c6cf17688e"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Licorice</h3>

<h4>Summary</h4>

<p>The public static read only <code>Licorice</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5a3336c-5b79-4b81-83b6-f6370d5c5e52'>LightGray</a></td><td style='width:75%' class='def'><p><a name="c5a3336c-5b79-4b81-83b6-f6370d5c5e52"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> LightGray</h3>

<h4>Summary</h4>

<p>The public static read only <code>LightGray</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#338838af-6bcb-421d-b9a3-01bdfd4a74d6'>Lime</a></td><td style='width:75%' ><p><a name="338838af-6bcb-421d-b9a3-01bdfd4a74d6"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Lime</h3>

<h4>Summary</h4>

<p>The public static read only <code>Lime</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a067b521-1e7d-4a69-af55-0bc5e1edff8f'>Magenta</a></td><td style='width:75%' class='def'><p><a name="a067b521-1e7d-4a69-af55-0bc5e1edff8f"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Magenta</h3>

<h4>Summary</h4>

<p>The public static read only <code>Magenta</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af2efdb7-f00f-4b32-8d40-6fa2bdbd953d'>Magnesium</a></td><td style='width:75%' ><p><a name="af2efdb7-f00f-4b32-8d40-6fa2bdbd953d"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Magnesium</h3>

<h4>Summary</h4>

<p>The public static read only <code>Magnesium</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d65585ba-b3a9-4d27-9fda-d87bd48ff5a2'>Maraschino</a></td><td style='width:75%' class='def'><p><a name="d65585ba-b3a9-4d27-9fda-d87bd48ff5a2"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Maraschino</h3>

<h4>Summary</h4>

<p>The public static read only <code>Maraschino</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6db45565-e231-48f4-b187-49ae0c45aae0'>Maroon</a></td><td style='width:75%' ><p><a name="6db45565-e231-48f4-b187-49ae0c45aae0"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Maroon</h3>

<h4>Summary</h4>

<p>The public static read only <code>Maroon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dc02ddd-4616-4177-80b6-3743b2ba10e3'>Mercury</a></td><td style='width:75%' class='def'><p><a name="9dc02ddd-4616-4177-80b6-3743b2ba10e3"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Mercury</h3>

<h4>Summary</h4>

<p>The public static read only <code>Mercury</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68815fe7-3011-459a-82ff-722f9d4c22a8'>Midnight</a></td><td style='width:75%' ><p><a name="68815fe7-3011-459a-82ff-722f9d4c22a8"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Midnight</h3>

<h4>Summary</h4>

<p>The public static read only <code>Midnight</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67fc0c55-40dc-43b7-9e8e-0445b4265141'>Mocha</a></td><td style='width:75%' class='def'><p><a name="67fc0c55-40dc-43b7-9e8e-0445b4265141"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Mocha</h3>

<h4>Summary</h4>

<p>The public static read only <code>Mocha</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73e90b67-56fc-4649-8012-8668f4764a73'>Moss</a></td><td style='width:75%' ><p><a name="73e90b67-56fc-4649-8012-8668f4764a73"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Moss</h3>

<h4>Summary</h4>

<p>The public static read only <code>Moss</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e97637f-cc14-4ad5-a656-4204272eb5bf'>Name</a></td><td style='width:75%' class='def'><p><a name="9e97637f-cc14-4ad5-a656-4204272eb5bf"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cf03f07-0188-40de-b595-141ed0483fb0'>Nickle</a></td><td style='width:75%' ><p><a name="1cf03f07-0188-40de-b595-141ed0483fb0"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Nickle</h3>

<h4>Summary</h4>

<p>The public static read only <code>Nickle</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#620ebff3-2e1c-49ec-91ac-164820685ea5'>Ocean</a></td><td style='width:75%' class='def'><p><a name="620ebff3-2e1c-49ec-91ac-164820685ea5"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Ocean</h3>

<h4>Summary</h4>

<p>The public static read only <code>Ocean</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6a0391c-bc3b-4aba-934b-e8b0c1d4ec7a'>Orange</a></td><td style='width:75%' ><p><a name="c6a0391c-bc3b-4aba-934b-e8b0c1d4ec7a"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Orange</h3>

<h4>Summary</h4>

<p>The public static read only <code>Orange</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cbacbd1-6bf1-4d74-9fb2-7a51f020d68b'>Orchid</a></td><td style='width:75%' class='def'><p><a name="3cbacbd1-6bf1-4d74-9fb2-7a51f020d68b"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Orchid</h3>

<h4>Summary</h4>

<p>The public static read only <code>Orchid</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff9d6bff-fac9-4b2b-810f-6b1411eba257'>Pink</a></td><td style='width:75%' ><p><a name="ff9d6bff-fac9-4b2b-810f-6b1411eba257"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Pink</h3>

<h4>Summary</h4>

<p>The public static read only <code>Pink</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4c5ddf0-a2c2-4cc1-8a7f-cab771f86161'>Plum</a></td><td style='width:75%' class='def'><p><a name="e4c5ddf0-a2c2-4cc1-8a7f-cab771f86161"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Plum</h3>

<h4>Summary</h4>

<p>The public static read only <code>Plum</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a66a431-e4e7-489b-8f93-34e1dc0f1dd5'>PropertyConnections</a></td><td style='width:75%' ><p><a name="7a66a431-e4e7-489b-8f93-34e1dc0f1dd5"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPropertyConnection&gt;</code> PropertyConnections</h3>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoColor</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fc68fb2-0683-4452-9adb-4ec38fad08dd'>Purple</a></td><td style='width:75%' class='def'><p><a name="2fc68fb2-0683-4452-9adb-4ec38fad08dd"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Purple</h3>

<h4>Summary</h4>

<p>The public static read only <code>Purple</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af0efc9c-a8c9-4be5-bb7b-a42c69cda543'>Red</a></td><td style='width:75%' ><p><a name="af0efc9c-a8c9-4be5-bb7b-a42c69cda543"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Red</h3>

<h4>Summary</h4>

<p>The public static read only <code>Red</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7150d8b0-2714-43ed-ae68-96bf7f0640ea'>Salmon</a></td><td style='width:75%' class='def'><p><a name="7150d8b0-2714-43ed-ae68-96bf7f0640ea"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Salmon</h3>

<h4>Summary</h4>

<p>The public static read only <code>Salmon</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af5dc170-473f-414b-a918-cd96da4db699'>SaturationAdjustment</a></td><td style='width:75%' ><p><a name="af5dc170-473f-414b-a918-cd96da4db699"></a></p>

<h3>Public <code>System.Single</code> SaturationAdjustment</h3>

<h4>Summary</h4>

<p>Gets or sets the saturation adjustment.</p>

<h4>Return Value</h4>

<p>The saturation adjustment.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a4c2611-1c34-4ee2-a123-7204ad7ca891'>SeaFoam</a></td><td style='width:75%' class='def'><p><a name="8a4c2611-1c34-4ee2-a123-7204ad7ca891"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> SeaFoam</h3>

<h4>Summary</h4>

<p>The public static read only <code>SeaFoam</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f14d523-fca3-4e5d-91c3-29cfd7143c09'>Silver</a></td><td style='width:75%' ><p><a name="5f14d523-fca3-4e5d-91c3-29cfd7143c09"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Silver</h3>

<h4>Summary</h4>

<p>The public static read only <code>Silver</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7bb48f6-8d6e-435a-a6c9-6e246e2bbf6d'>Sky</a></td><td style='width:75%' class='def'><p><a name="d7bb48f6-8d6e-435a-a6c9-6e246e2bbf6d"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Sky</h3>

<h4>Summary</h4>

<p>The public static read only <code>Sky</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3504296d-6cab-43a4-a410-d43f37400392'>Snow</a></td><td style='width:75%' ><p><a name="3504296d-6cab-43a4-a410-d43f37400392"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Snow</h3>

<h4>Summary</h4>

<p>The public static read only <code>Snow</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe65c76c-15e2-4a81-9daf-dbe3b42dd0fe'>Spindrift</a></td><td style='width:75%' class='def'><p><a name="fe65c76c-15e2-4a81-9daf-dbe3b42dd0fe"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Spindrift</h3>

<h4>Summary</h4>

<p>The public static read only <code>Spindrift</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b93725d5-7621-4e94-8391-ce05a99130a3'>Spring</a></td><td style='width:75%' ><p><a name="b93725d5-7621-4e94-8391-ce05a99130a3"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Spring</h3>

<h4>Summary</h4>

<p>The public static read only <code>Spring</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16f96387-4105-4493-8a8d-e91700d4f422'>Steel</a></td><td style='width:75%' class='def'><p><a name="16f96387-4105-4493-8a8d-e91700d4f422"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Steel</h3>

<h4>Summary</h4>

<p>The public static read only <code>Steel</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#405f83d0-a1fc-445e-8835-2fa30c6bf4fc'>Strawberry</a></td><td style='width:75%' ><p><a name="405f83d0-a1fc-445e-8835-2fa30c6bf4fc"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Strawberry</h3>

<h4>Summary</h4>

<p>The public static read only <code>Strawberry</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#925ad42a-ebaf-4ec0-8ad5-9570427ff853'>Tangerine</a></td><td style='width:75%' class='def'><p><a name="925ad42a-ebaf-4ec0-8ad5-9570427ff853"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Tangerine</h3>

<h4>Summary</h4>

<p>The public static read only <code>Tangerine</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c12af6f5-7253-44a1-84f9-7dfa4c3c1fea'>Teal</a></td><td style='width:75%' ><p><a name="c12af6f5-7253-44a1-84f9-7dfa4c3c1fea"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Teal</h3>

<h4>Summary</h4>

<p>The public static read only <code>Teal</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b508429f-8c6c-4cfa-8d63-be5ab401931a'>Tin</a></td><td style='width:75%' class='def'><p><a name="b508429f-8c6c-4cfa-8d63-be5ab401931a"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Tin</h3>

<h4>Summary</h4>

<p>The public static read only <code>Tin</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c4ecc97c-33c8-49a4-a8c6-1cb849a35587'>Tungsten</a></td><td style='width:75%' ><p><a name="c4ecc97c-33c8-49a4-a8c6-1cb849a35587"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Tungsten</h3>

<h4>Summary</h4>

<p>The public static read only <code>Tungsten</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89b2d67b-3ab5-4d39-9a40-35b50617eceb'>Turquoise</a></td><td style='width:75%' class='def'><p><a name="89b2d67b-3ab5-4d39-9a40-35b50617eceb"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Turquoise</h3>

<h4>Summary</h4>

<p>The public static read only <code>Turquoise</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d00d9165-1b79-4a40-8dcb-786ed2acad98'>UniqueID</a></td><td style='width:75%' ><p><a name="d00d9165-1b79-4a40-8dcb-786ed2acad98"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#776f0844-0aa9-47e4-b99c-f2275bd188b4'>White</a></td><td style='width:75%' class='def'><p><a name="776f0844-0aa9-47e4-b99c-f2275bd188b4"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> White</h3>

<h4>Summary</h4>

<p>The public static read only <code>White</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e58bf3b3-5aa8-4288-88f3-60b5c07002e8'>Yellow</a></td><td style='width:75%' ><p><a name="e58bf3b3-5aa8-4288-88f3-60b5c07002e8"></a></p>

<h3>Public Static Read Only <code>SkiaSharp.SKColor</code> Yellow</h3>

<h4>Summary</h4>

<p>The public static read only <code>Yellow</code> property of the <code>KimonoColor</code> class has a <code>SkiaSharp.SKColor</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6077d970-ff60-4381-ae4e-b611a41ae9e6'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="6077d970-ff60-4381-ae4e-b611a41ae9e6"></a></p>

<h3>Public Virtual Void AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoColor</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="79028ed4-4611-48c9-b9d0-84f00a577ad2"></a>
<b>KimonoCore.KimonoPropertyConnectionPoint connectionPoint</b></p>

<p>The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="9f5fd9ed-0274-4e71-b178-ae76c4865e44"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48aa76dc-c4fe-4d1f-a5db-2d3bd4f2aadd'>BaseColorChanged</a></td><td style='width:75%' class='def'><p><a name="48aa76dc-c4fe-4d1f-a5db-2d3bd4f2aadd"></a></p>

<h3>Private Void BaseColorChanged ()</h3>

<h4>Summary</h4>

<p>Handles the base color being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#148f69fd-9016-41ba-8127-5232102a36c4'>Clone</a></td><td style='width:75%' ><p><a name="148f69fd-9016-41ba-8127-5232102a36c4"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c441f59-fb05-4618-afab-0fdffe56881c'>CloneColor</a></td><td style='width:75%' class='def'><p><a name="4c441f59-fb05-4618-afab-0fdffe56881c"></a></p>

<h3>Public Static <code>SkiaSharp.SKColor</code> CloneColor (SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Clones the color.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="fdc00301-229d-43d5-982a-121c0c46468d"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c52c9f7-a9af-420d-8519-d93be9286660'>EvaluateConnectedProperties</a></td><td style='width:75%' ><p><a name="7c52c9f7-a9af-420d-8519-d93be9286660"></a></p>

<h3>Public Virtual Void EvaluateConnectedProperties ()</h3>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoColor</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d2475de-6047-491e-96b9-f422dcaf0444'>KimonoColor</a></td><td style='width:75%' class='def'><p><a name="2d2475de-6047-491e-96b9-f422dcaf0444"></a></p>

<h3>Public Void KimonoColor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d205d8b9-2141-4b55-8e67-09e29bc737b2'>KimonoColor</a></td><td style='width:75%' ><p><a name="d205d8b9-2141-4b55-8e67-09e29bc737b2"></a></p>

<h3>Public Void KimonoColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="ca3be294-2962-40bc-915d-6e07490bdf36"></a>
<b>KimonoCore.KimonoColor baseColor</b></p>

<p>Base color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ba5dd97-df37-456a-b7b1-f079f8d0851c'>KimonoColor</a></td><td style='width:75%' class='def'><p><a name="4ba5dd97-df37-456a-b7b1-f079f8d0851c"></a></p>

<h3>Public Void KimonoColor (SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="845ff289-6230-4009-976c-a29b59d15bf8"></a>
<b>SkiaSharp.SKColor color</b></p>

<p>Color.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#183f12b8-aea1-4de4-8083-8e8bfaaeb333'>KimonoColor</a></td><td style='width:75%' ><p><a name="183f12b8-aea1-4de4-8083-8e8bfaaeb333"></a></p>

<h3>Public Void KimonoColor (System.Int32, System.Int32, System.Int32, System.Int32)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoColor</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>red</td><td style='width:75%' ><p><a name="82ae4170-11bc-4e64-871a-95926b0560c5"></a>
<b>System.Int32 red</b></p>

<p>Red.</p>
</td></tr><tr><td style='width:25%' class='term'>green</td><td style='width:75%' class='def'><p><a name="d7e16c26-966a-4da7-87cc-207070e5f86e"></a>
<b>System.Int32 green</b></p>

<p>Green.</p>
</td></tr><tr><td style='width:25%' class='term'>blue</td><td style='width:75%' ><p><a name="2edeffc7-a0dc-4517-b01b-6a5bdd13a26a"></a>
<b>System.Int32 blue</b></p>

<p>Blue.</p>
</td></tr><tr><td style='width:25%' class='term'>alpha</td><td style='width:75%' class='def'><p><a name="f748bbeb-396b-4fb2-8cd9-2a617003c148"></a>
<b>System.Int32 alpha</b></p>

<p>Alpha.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1af77ff-7ce6-4f25-a67c-784672c6bc6c'>MixColor</a></td><td style='width:75%' class='def'><p><a name="f1af77ff-7ce6-4f25-a67c-784672c6bc6c"></a></p>

<h3>Private Void MixColor ()</h3>

<h4>Summary</h4>

<p>Mixes the color based on the base values and any adjustment that have been applied.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c9f5aa0-7086-4347-be8f-db52a440e7de'>RaiseColorChanged</a></td><td style='width:75%' ><p><a name="3c9f5aa0-7086-4347-be8f-db52a440e7de"></a></p>

<h3>Void RaiseColorChanged ()</h3>

<h4>Summary</h4>

<p>Raises the color changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3522b4ca-eb4a-44db-b8f3-4f6e81c650da'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="3522b4ca-eb4a-44db-b8f3-4f6e81c650da"></a></p>

<h3>Public Virtual Void RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="73ee4f76-6d65-4676-b532-5b4aacba80cd"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20bba4ef-37fd-4fe3-b110-5951be566400'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="20bba4ef-37fd-4fe3-b110-5951be566400"></a></p>

<h3>Public Virtual Void RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="76080ed3-1d73-4a76-9957-cf5a1ade8b83"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b24485c9-84cb-4144-abae-472915a5107c'>ToCode</a></td><td style='width:75%' class='def'><p><a name="b24485c9-84cb-4144-abae-472915a5107c"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="71c14d10-53c7-495b-9f01-69dfb78ae597"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="a7b18525-3cd9-4756-ab9d-cb28e1b4154f"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f2c43e6c-76e6-4893-8ffe-99fe6b82d521"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c86be219-019a-4238-98f0-243212ed7c05'>ToCSharp</a></td><td style='width:75%' ><p><a name="c86be219-019a-4238-98f0-243212ed7c05"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="287f6e8b-2f57-4fe6-bfa8-4e839974f721"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57e8ec0d-6768-408b-92cc-c597f8a0df02'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="57e8ec0d-6768-408b-92cc-c597f8a0df02"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0224478-18ae-4ddb-8588-a73185e441fb'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="c0224478-18ae-4ddb-8588-a73185e441fb"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba8152c3-8fab-426f-9742-85c278e6df09'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="ba8152c3-8fab-426f-9742-85c278e6df09"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b79c1b34-8e8c-4b01-b787-d6e337709a16'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="b79c1b34-8e8c-4b01-b787-d6e337709a16"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoColor</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="15d54318-f00d-40a4-a1f3-1226982d9b53"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6efe6138-0c70-4060-9bc1-263617c6c444'>ColorChanged</a></td><td style='width:75%' ><p><a name="6efe6138-0c70-4060-9bc1-263617c6c444"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ColorChanged</h3>

<h4>Summary</h4>

<p>Occurs when color changed.</p>
</td></tr></table></p>


---

<a name="5902167f-bbf8-4117-bf1a-a4a75a7d1a4b"></a>
##Public Class KimonoDesignSurface

###Namespace

[KimonoCore.Mac](#e7d58f17-d3e3-48f5-bbac-a79af83dfd2b)

###Inherits From

`AppKit.NSImageView`

###Summary

The Kimono Design Surface is a Xamarin.Mac specific editing surface that allows the user to modify a given `KimonoPortfolio` and the collection of `KimonoSketches` that it maintains.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e88385e5-963c-4dae-bcf3-18483a18441e'>_portfolio</a></td><td style='width:75%' ><p><a name="e88385e5-963c-4dae-bcf3-18483a18441e"></a>
<b>Private <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoCore.KimonoPortfolio</a> _portfolio</b></p>

<p>The portfolio currently being worked on.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36ae948d-2a75-4e55-bf02-546c7f53f68a'>ColorsModified</a></td><td style='width:75%' class='def'><p><a name="36ae948d-2a75-4e55-bf02-546c7f53f68a"></a>
<b>Private <a href="#f1a2d0ae-1ce6-430b-b9e6-dc563b05a72d">KimonoCore.Kimono.ColorEventDelegate</a> ColorsModified</b></p>

<p>The private <code>ColorsModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75366334-39d4-4ecd-891e-b91815b667f6'>GradientsModified</a></td><td style='width:75%' ><p><a name="75366334-39d4-4ecd-891e-b91815b667f6"></a>
<b>Private <a href="#67ce0094-ddce-4d9e-9750-53c6acab9831">KimonoCore.Kimono.GradientEventDelegate</a> GradientsModified</b></p>

<p>The private <code>GradientsModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#372b348d-11a0-4278-9319-f231904a1f66'>PropertyModified</a></td><td style='width:75%' class='def'><p><a name="372b348d-11a0-4278-9319-f231904a1f66"></a>
<b>Private <a href="#3c56fc94-a4eb-4762-8a4e-d39c26f45a7b">KimonoCore.Kimono.PropertyEventDelegate</a> PropertyModified</b></p>

<p>The private <code>PropertyModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PropertyEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eebc65ea-af56-42fd-8da6-a0deae34a751'>ReloadUI</a></td><td style='width:75%' ><p><a name="eebc65ea-af56-42fd-8da6-a0deae34a751"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ReloadUI</b></p>

<p>The private <code>ReloadUI</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00d05d93-def8-41ac-be61-8eefd630f12f'>SelectedShapeModified</a></td><td style='width:75%' class='def'><p><a name="00d05d93-def8-41ac-be61-8eefd630f12f"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SelectedShapeModified</b></p>

<p>The private <code>SelectedShapeModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef5eb91b-5193-4bb3-a409-aa9cc06de9a9'>SelectionChanged</a></td><td style='width:75%' ><p><a name="ef5eb91b-5193-4bb3-a409-aa9cc06de9a9"></a>
<b>Private <a href="#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0">KimonoCore.Kimono.ShapeEventDelegate</a> SelectionChanged</b></p>

<p>The private <code>SelectionChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30b53457-251d-4119-b734-3c2876dcf0d0'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="30b53457-251d-4119-b734-3c2876dcf0d0"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchesModified</b></p>

<p>The private <code>SketchesModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#493dec22-b69d-4640-ab2e-0dc5b06c8bce'>SketchModified</a></td><td style='width:75%' ><p><a name="493dec22-b69d-4640-ab2e-0dc5b06c8bce"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchModified</b></p>

<p>The private <code>SketchModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccffca98-4103-4acc-8f1a-2f9ce71ccb0d'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="ccffca98-4103-4acc-8f1a-2f9ce71ccb0d"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchSizeChanged</b></p>

<p>The private <code>SketchSizeChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b3c5885-3871-4882-a459-22a6b983a145'>StylesModified</a></td><td style='width:75%' ><p><a name="6b3c5885-3871-4882-a459-22a6b983a145"></a>
<b>Private <a href="#fdfb734d-7652-477b-b864-cfa9870cd620">KimonoCore.Kimono.StyleEventDelegate</a> StylesModified</b></p>

<p>The private <code>StylesModified</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3996070-7f3e-4e59-8beb-17688c5ab00a'>ToolChanged</a></td><td style='width:75%' class='def'><p><a name="a3996070-7f3e-4e59-8beb-17688c5ab00a"></a>
<b>Private <a href="#64878777-41f3-4e4a-9955-da97b723a057">KimonoCore.Kimono.ToolEventDelegate</a> ToolChanged</b></p>

<p>The private <code>ToolChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7803f59-3ab6-4a9f-b927-ca35c8a23c89'>UndoHandler</a></td><td style='width:75%' ><p><a name="b7803f59-3ab6-4a9f-b927-ca35c8a23c89"></a>
<b>Private <a href="#9f6ca193-4a1c-4cf3-85fd-9088380e8c9e">KimonoCore.KimonoUndoHandler</a> UndoHandler</b></p>

<p>The <code>KimonoUndoHandler</code> that handles undo and redo events for the  Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cca3558c-6004-4c51-9b06-a533c4822b4e'>UndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="cca3558c-6004-4c51-9b06-a533c4822b4e"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> UndoStateChanged</b></p>

<p>The private <code>UndoStateChanged</code> field of the <code>KimonoDesignSurface</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8138ba2c-4711-4b99-a010-0089fc0f03ce'>CanBecomeKeyView</a></td><td style='width:75%' ><p><a name="8138ba2c-4711-4b99-a010-0089fc0f03ce"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> CanBecomeKeyView</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#5902167f-bbf8-4117-bf1a-a4a75a7d1a4b">KimonoDesignSurface</a> can become key view.</p>

<h4>Return Value</h4>

<p><code>true</code> if can become key view; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a7a6514-2c66-44b4-b4fd-e6299cc40207'>CanRedo</a></td><td style='width:75%' class='def'><p><a name="3a7a6514-2c66-44b4-b4fd-e6299cc40207"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanRedo</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can redo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can redo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c60baf5-acd9-47c8-a2d5-bc7073c6b66f'>CanUndo</a></td><td style='width:75%' ><p><a name="5c60baf5-acd9-47c8-a2d5-bc7073c6b66f"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanUndo</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can undo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can undo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6ea70a8-32f9-4bfa-b0dd-a74777e81074'>DeeplySelectedGroup</a></td><td style='width:75%' class='def'><p><a name="a6ea70a8-32f9-4bfa-b0dd-a74777e81074"></a></p>

<h3>Public Read Only <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoCore.KimonoShapeGroup</a> DeeplySelectedGroup</h3>

<h4>Summary</h4>

<p>Gets the deeply selected group.</p>

<h4>Return Value</h4>

<p>The deeply selected <code>KimonoGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ae1be98-f910-4b38-8f71-9217c0313bf3'>DeeplySelectedShape</a></td><td style='width:75%' ><p><a name="6ae1be98-f910-4b38-8f71-9217c0313bf3"></a></p>

<h3>Public Read Only <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> DeeplySelectedShape</h3>

<h4>Summary</h4>

<p>Gets the deeply selected shape.</p>

<h4>Return Value</h4>

<p>The deeply selected <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c7490ea-7b86-43fe-b704-1f523083a31f'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="9c7490ea-7b86-43fe-b704-1f523083a31f"></a></p>

<h3>Public <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoCore.KimonoPortfolio</a> Portfolio</h3>

<h4>Summary</h4>

<p>Gets or sets the portfolio currently being worked on.</p>

<h4>Return Value</h4>

<p>The <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e281a0bc-4f67-4f54-8e02-a83923707abd'>SelectedShape</a></td><td style='width:75%' ><p><a name="e281a0bc-4f67-4f54-8e02-a83923707abd"></a></p>

<h3>Public <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79c9f8a4-1cce-4f52-8018-456df85a2f96'>SelectedSketch</a></td><td style='width:75%' class='def'><p><a name="79c9f8a4-1cce-4f52-8018-456df85a2f96"></a></p>

<h3>Public <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoCore.KimonoSketch</a> SelectedSketch</h3>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c360126-4aae-44b0-98f6-84584ff43848'>Tool</a></td><td style='width:75%' ><p><a name="1c360126-4aae-44b0-98f6-84584ff43848"></a></p>

<h3>Public <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Tool</h3>

<h4>Summary</h4>

<p>Gets or sets the tool.</p>

<h4>Return Value</h4>

<p>The current <code>KimonoTool</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7cc2e376-d7ec-4229-8e0e-ad59a42fe6b6'>AcceptsFirstResponder</a></td><td style='width:75%' ><p><a name="7cc2e376-d7ec-4229-8e0e-ad59a42fe6b6"></a></p>

<h3>Public Virtual <code>System.Boolean</code> AcceptsFirstResponder ()</h3>

<h4>Summary</h4>

<p>Accepts the first responder.</p>

<h4>Returns</h4>

<p><code>true</code>, if first responder was accepted, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09a0a022-d572-4db6-9c77-c97a97e97561'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p><a name="09a0a022-d572-4db6-9c77-c97a97e97561"></a></p>

<h3>Private <code>SkiaSharp.SKPoint</code> ConvertToCanvasPoint (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Converts a raw macOS mouse event point into the coordinates of the currently selected sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="ec382c7f-b75f-479d-80e9-d5c69923ed98"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The raw mouse <code>NSEvent</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>An <code>SKPoint</code> adjusted to the sketch's coordinate system.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13faeffb-fa90-4a0e-ba46-15fcc365e5fd'>DeleteSelectedShape</a></td><td style='width:75%' ><p><a name="13faeffb-fa90-4a0e-ba46-15fcc365e5fd"></a></p>

<h3>Public Void DeleteSelectedShape ()</h3>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f0285ed-0d5e-4d75-9f98-842e53b0dc0e'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="7f0285ed-0d5e-4d75-9f98-842e53b0dc0e"></a></p>

<h3>Public Void DuplicateSelectedShape ()</h3>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4e5c49bd-eb59-446e-ac8b-f1c18aad0acb'>HandleSketchChanging</a></td><td style='width:75%' ><p><a name="4e5c49bd-eb59-446e-ac8b-f1c18aad0acb"></a></p>

<h3>Private Void HandleSketchChanging (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Handles the currently selected sketch changing.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="56dc61e8-8d03-4008-870f-60fd8b5e8a2e"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The new <code>KimonoSketch</code> being selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17eb4b5c-dcc2-469d-9b53-ed554e563544'>Initialize</a></td><td style='width:75%' class='def'><p><a name="17eb4b5c-dcc2-469d-9b53-ed554e563544"></a></p>

<h3>Public Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70cc90a8-3472-44c2-8ea7-cfd9491e4d3e'>KimonoDesignSurface</a></td><td style='width:75%' ><p><a name="70cc90a8-3472-44c2-8ea7-cfd9491e4d3e"></a></p>

<h3>Public Void KimonoDesignSurface ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5902167f-bbf8-4117-bf1a-a4a75a7d1a4b">KimonoDesignSurface</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5551dea6-da90-4de0-b9a9-2aa945045922'>KimonoDesignSurface</a></td><td style='width:75%' class='def'><p><a name="5551dea6-da90-4de0-b9a9-2aa945045922"></a></p>

<h3>Public Void KimonoDesignSurface (CoreGraphics.CGRect)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5902167f-bbf8-4117-bf1a-a4a75a7d1a4b">KimonoDesignSurface</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="8dbd654d-1001-4cf2-b8a6-daa4231f8d5d"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f85bc57-776d-45a2-9bfd-06b4cd34d98c'>KimonoDesignSurface</a></td><td style='width:75%' ><p><a name="4f85bc57-776d-45a2-9bfd-06b4cd34d98c"></a></p>

<h3>Public Void KimonoDesignSurface (Foundation.NSCoder)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5902167f-bbf8-4117-bf1a-a4a75a7d1a4b">KimonoDesignSurface</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="77263a50-c290-496e-94be-330cc8626fb3"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14488a1a-078d-4149-b3e3-704b661d5210'>KimonoDesignSurface</a></td><td style='width:75%' class='def'><p><a name="14488a1a-078d-4149-b3e3-704b661d5210"></a></p>

<h3>Public Void KimonoDesignSurface (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5902167f-bbf8-4117-bf1a-a4a75a7d1a4b">KimonoDesignSurface</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="a2a3776f-5032-42dd-8325-667f722c10dd"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97dc0a36-346f-4c9e-85f6-b58d52539ea3'>MouseDown</a></td><td style='width:75%' ><p><a name="97dc0a36-346f-4c9e-85f6-b58d52539ea3"></a></p>

<h3>Public Virtual Void MouseDown (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user clicking the mouse</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="a73f4452-cce2-4744-be19-bf2ff472c763"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse down.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d6a01c2-a8e4-42cb-85b0-3bbd7beff6f9'>MouseDragged</a></td><td style='width:75%' class='def'><p><a name="8d6a01c2-a8e4-42cb-85b0-3bbd7beff6f9"></a></p>

<h3>Public Virtual Void MouseDragged (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user dragging the mouse.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="3e31edf1-2275-4f32-8084-3a42c4d73fc4"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse drag.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1896097e-e75b-4c2d-b2ea-b959a8c082fc'>MouseMoved</a></td><td style='width:75%' ><p><a name="1896097e-e75b-4c2d-b2ea-b959a8c082fc"></a></p>

<h3>Public Virtual Void MouseMoved (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user moving the mouse.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="688d42dd-04ec-4e54-85d8-9fbb823f3eb7"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse move.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e55c808-c63b-4e5f-979d-64da4a604d9b'>MouseUp</a></td><td style='width:75%' class='def'><p><a name="0e55c808-c63b-4e5f-979d-64da4a604d9b"></a></p>

<h3>Public Virtual Void MouseUp (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user releasing a mouse button.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="d972fb72-3952-44d5-8ada-bab17fa4261e"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse up.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97502003-ff3c-4982-90bc-db6cac89bbe1'>RaiseColorsModified</a></td><td style='width:75%' ><p><a name="97502003-ff3c-4982-90bc-db6cac89bbe1"></a></p>

<h3>Void RaiseColorsModified (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Raises the colors modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="497d471d-d43b-4ad3-8adf-b7082cafedf6"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f7f6f82-0b33-4e1d-bc41-63f443b0f87c'>RaiseGradientsModified</a></td><td style='width:75%' class='def'><p><a name="0f7f6f82-0b33-4e1d-bc41-63f443b0f87c"></a></p>

<h3>Void RaiseGradientsModified (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Raises the gradients modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="ec290495-5a9d-400a-b4cc-bd5fe92a4463"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20703254-749e-4224-844c-18d9a64c150a'>RaisePropertyModified</a></td><td style='width:75%' ><p><a name="20703254-749e-4224-844c-18d9a64c150a"></a></p>

<h3>Void RaisePropertyModified (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Raises the property modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="b5fe1b3f-093f-4cd5-9e9d-932b691c443d"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c8e3c85-b841-49e4-bb6f-06aa44fa55ac'>RaiseReloadUI</a></td><td style='width:75%' class='def'><p><a name="2c8e3c85-b841-49e4-bb6f-06aa44fa55ac"></a></p>

<h3>Void RaiseReloadUI ()</h3>

<h4>Summary</h4>

<p>Raises the reload user interface event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ef6cdf0-3cdb-4ce4-9054-2e9b2e92273b'>RaiseSelectedShapeModified</a></td><td style='width:75%' ><p><a name="5ef6cdf0-3cdb-4ce4-9054-2e9b2e92273b"></a></p>

<h3>Void RaiseSelectedShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6337b8e8-4423-4992-96a2-449f431c6c0c'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="6337b8e8-4423-4992-96a2-449f431c6c0c"></a></p>

<h3>Void RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="e8236f1d-5503-4c70-a737-6a7a90a7bc50"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>The new <code>KimonoShape</code> selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6be481d9-b772-4932-98a4-888fa8700c43'>RaiseSketchesModified</a></td><td style='width:75%' ><p><a name="6be481d9-b772-4932-98a4-888fa8700c43"></a></p>

<h3>Void RaiseSketchesModified ()</h3>

<h4>Summary</h4>

<p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a88173a-22ca-46c5-b739-c08a5a2999d3'>RaiseSketchModified</a></td><td style='width:75%' class='def'><p><a name="2a88173a-22ca-46c5-b739-c08a5a2999d3"></a></p>

<h3>Void RaiseSketchModified ()</h3>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be66fd7f-d6d4-4cce-be75-ea5dfa733c30'>RaiseSketchSizeChanged</a></td><td style='width:75%' ><p><a name="be66fd7f-d6d4-4cce-be75-ea5dfa733c30"></a></p>

<h3>Void RaiseSketchSizeChanged ()</h3>

<h4>Summary</h4>

<p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee1fa6b3-5c38-4099-997b-18ad67b65fc5'>RaiseStylesModified</a></td><td style='width:75%' class='def'><p><a name="ee1fa6b3-5c38-4099-997b-18ad67b65fc5"></a></p>

<h3>Void RaiseStylesModified (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the styles modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="b9da9263-0b7f-4902-aee1-05711f2dbbda"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92d51a74-572d-4d96-82f4-cd51a0fc4348'>RaiseToolChanged</a></td><td style='width:75%' ><p><a name="92d51a74-572d-4d96-82f4-cd51a0fc4348"></a></p>

<h3>Void RaiseToolChanged (KimonoCore.KimonoTool)</h3>

<h4>Summary</h4>

<p>Raises the tool changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="8e4729f1-4560-45f3-8727-da2cd449ad4f"></a>
<b>KimonoCore.KimonoTool tool</b></p>

<p>The new <code>KimonoTool</code> selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02e37bdb-e9c5-40ab-88b9-4aed2eba8baa'>RaiseUndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="02e37bdb-e9c5-40ab-88b9-4aed2eba8baa"></a></p>

<h3>Void RaiseUndoStateChanged ()</h3>

<h4>Summary</h4>

<p>Raises the undo state changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d2191d2-7afa-4172-95b2-47a0ca0a8171'>Redo</a></td><td style='width:75%' ><p><a name="1d2191d2-7afa-4172-95b2-47a0ca0a8171"></a></p>

<h3>Public Void Redo (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Redoes the last change.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="e1f87ba2-4e69-407b-8ec8-5f6eefec074a"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#568e39da-1a12-4d7b-821a-7f930f939e1f'>RedoChange</a></td><td style='width:75%' class='def'><p><a name="568e39da-1a12-4d7b-821a-7f930f939e1f"></a></p>

<h3>Public Void RedoChange ()</h3>

<h4>Summary</h4>

<p>Redoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a024d3aa-1f54-40db-a640-32f2926863ec'>RefreshView</a></td><td style='width:75%' ><p><a name="a024d3aa-1f54-40db-a640-32f2926863ec"></a></p>

<h3>Public Void RefreshView ()</h3>

<h4>Summary</h4>

<p>Refreshs the Design Surface's view by redrawing the currently selected <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4df1daa8-6224-4f74-afcd-e11a2419e09d'>ReplaceUndoPoint</a></td><td style='width:75%' class='def'><p><a name="4df1daa8-6224-4f74-afcd-e11a2419e09d"></a></p>

<h3>Public Void ReplaceUndoPoint ()</h3>

<h4>Summary</h4>

<p>Replaces the last undo point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ba11882-1c07-4af1-a1cc-698950ebd132'>SaveUndoPoint</a></td><td style='width:75%' ><p><a name="4ba11882-1c07-4af1-a1cc-698950ebd132"></a></p>

<h3>Public Void SaveUndoPoint ()</h3>

<h4>Summary</h4>

<p>Saves a new undo point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d031520-3f9e-4def-9232-9ef0f9f3d69e'>Undo</a></td><td style='width:75%' class='def'><p><a name="5d031520-3f9e-4def-9232-9ef0f9f3d69e"></a></p>

<h3>Public Void Undo (Foundation.NSObject)</h3>

<h4>Summary</h4>

<p>Udoes the last change.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sender</td><td style='width:75%' ><p><a name="9f03a43d-b95e-4898-855f-6f3f43b4ccf3"></a>
<b>Foundation.NSObject sender</b></p>

<p>Sender.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c51f5cc6-ffb6-4277-a781-f26b13cbff60'>UndoChange</a></td><td style='width:75%' ><p><a name="c51f5cc6-ffb6-4277-a781-f26b13cbff60"></a></p>

<h3>Public Void UndoChange ()</h3>

<h4>Summary</h4>

<p>Undoes the last change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7d4e015-7181-41a0-bf3f-7118a5a80f69'>UnwirePortfolioEvents</a></td><td style='width:75%' class='def'><p><a name="e7d4e015-7181-41a0-bf3f-7118a5a80f69"></a></p>

<h3>Private Void UnwirePortfolioEvents ()</h3>

<h4>Summary</h4>

<p>Unwires the portfolio events from this Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50193f68-62b1-4ce7-b756-85fe591f559a'>UnwireSketchEvents</a></td><td style='width:75%' ><p><a name="50193f68-62b1-4ce7-b756-85fe591f559a"></a></p>

<h3>Private Void UnwireSketchEvents (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Unwires the sketch events from this Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="d43a2e7d-ae3e-4848-9b39-e6c16565f596"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> to remove events from.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fcc18e6-9d95-4400-9a6f-74081b011288'>WireupPortfolioEvents</a></td><td style='width:75%' class='def'><p><a name="3fcc18e6-9d95-4400-9a6f-74081b011288"></a></p>

<h3>Private Void WireupPortfolioEvents ()</h3>

<h4>Summary</h4>

<p>Wireups the portfolio events to this Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85a52ff7-f464-4189-befd-913ce9c33f97'>WireUpSketchEvents</a></td><td style='width:75%' ><p><a name="85a52ff7-f464-4189-befd-913ce9c33f97"></a></p>

<h3>Private Void WireUpSketchEvents (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Wires up sketch events to this Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="250082df-edbe-4334-8ae2-0e5d927a5a58"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoStech</code> to wire events for.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#71f4533b-c945-4c6e-9484-4eb392087d63'>ColorsModified</a></td><td style='width:75%' ><p><a name="71f4533b-c945-4c6e-9484-4eb392087d63"></a></p>

<h3><a href="#f1a2d0ae-1ce6-430b-b9e6-dc563b05a72d">KimonoCore.Kimono.ColorEventDelegate</a> ColorsModified</h3>

<h4>Summary</h4>

<p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b81987b-b85a-4709-9894-1721d411f04a'>GradientsModified</a></td><td style='width:75%' class='def'><p><a name="0b81987b-b85a-4709-9894-1721d411f04a"></a></p>

<h3><a href="#67ce0094-ddce-4d9e-9750-53c6acab9831">KimonoCore.Kimono.GradientEventDelegate</a> GradientsModified</h3>

<h4>Summary</h4>

<p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96c9ab12-9a1d-400a-9ce7-f0f5969802c5'>PropertyModified</a></td><td style='width:75%' ><p><a name="96c9ab12-9a1d-400a-9ce7-f0f5969802c5"></a></p>

<h3><a href="#3c56fc94-a4eb-4762-8a4e-d39c26f45a7b">KimonoCore.Kimono.PropertyEventDelegate</a> PropertyModified</h3>

<h4>Summary</h4>

<p>Occurs when property collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51e84d86-4552-46fd-a2dc-0722d094eb4b'>ReloadUI</a></td><td style='width:75%' class='def'><p><a name="51e84d86-4552-46fd-a2dc-0722d094eb4b"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ReloadUI</h3>

<h4>Summary</h4>

<p>Occurs when the user interface needs to be fully reloaded.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85cb1404-bd28-4435-95a9-6b4571570b89'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="85cb1404-bd28-4435-95a9-6b4571570b89"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SelectedShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when the selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb228ccd-d52f-47e6-85c4-c266d84f3ca2'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="eb228ccd-d52f-47e6-85c4-c266d84f3ca2"></a></p>

<h3><a href="#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0">KimonoCore.Kimono.ShapeEventDelegate</a> SelectionChanged</h3>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcd95f19-d5ac-48c5-b728-5625b1cb0afb'>SketchesModified</a></td><td style='width:75%' ><p><a name="fcd95f19-d5ac-48c5-b728-5625b1cb0afb"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchesModified</h3>

<h4>Summary</h4>

<p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5b95de6-8309-462e-8e22-fe6a6218b3f8'>SketchModified</a></td><td style='width:75%' class='def'><p><a name="b5b95de6-8309-462e-8e22-fe6a6218b3f8"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchModified</h3>

<h4>Summary</h4>

<p>Occurs when a sketch is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0534da3e-fa1c-4810-bcb1-b61f66f8b169'>SketchSizeChanged</a></td><td style='width:75%' ><p><a name="0534da3e-fa1c-4810-bcb1-b61f66f8b169"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchSizeChanged</h3>

<h4>Summary</h4>

<p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e846ca5d-efaa-4b86-a1aa-d6523bea8c95'>StylesModified</a></td><td style='width:75%' class='def'><p><a name="e846ca5d-efaa-4b86-a1aa-d6523bea8c95"></a></p>

<h3><a href="#fdfb734d-7652-477b-b864-cfa9870cd620">KimonoCore.Kimono.StyleEventDelegate</a> StylesModified</h3>

<h4>Summary</h4>

<p>Occurs when styles collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c1d5c84-cff1-4117-a76b-4ca54d087803'>ToolChanged</a></td><td style='width:75%' ><p><a name="4c1d5c84-cff1-4117-a76b-4ca54d087803"></a></p>

<h3><a href="#64878777-41f3-4e4a-9955-da97b723a057">KimonoCore.Kimono.ToolEventDelegate</a> ToolChanged</h3>

<h4>Summary</h4>

<p>Occurs when tool changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bf181af-6a41-4d8c-a98d-f962897811fe'>UndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="8bf181af-6a41-4d8c-a98d-f962897811fe"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> UndoStateChanged</h3>

<h4>Summary</h4>

<p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="6c314738-81b5-4ec9-8672-ec5609515d65"></a>
##Public Class KimonoGradient

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines a gradient as a collection of either `SKColor` or linked `KimonoColors` that can be applied to a `KimonoStyle` and used when drawing a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#da597620-5879-4092-9998-6b4daf028497'>_endPoint</a></td><td style='width:75%' ><p><a name="da597620-5879-4092-9998-6b4daf028497"></a>
<b>Private <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> _endPoint</b></p>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34036aff-81a8-4bf6-87b8-2935bf492893'>_gradientType</a></td><td style='width:75%' class='def'><p><a name="34036aff-81a8-4bf6-87b8-2935bf492893"></a>
<b>Private <a href="#e2c4892c-ccec-401e-90e8-6969d7d016b4">KimonoCore.KimonoGradientType</a> _gradientType</b></p>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44ced386-3f28-45ef-86a4-3a5228ff2bc7'>_radius</a></td><td style='width:75%' ><p><a name="44ced386-3f28-45ef-86a4-3a5228ff2bc7"></a>
<b>Private <code>System.Single</code> _radius</b></p>

<p>The radius for radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e081b12-0ded-4d50-95c1-d8a9bf53ba07'>_selectedHandle</a></td><td style='width:75%' class='def'><p><a name="2e081b12-0ded-4d50-95c1-d8a9bf53ba07"></a>
<b>Private <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> _selectedHandle</b></p>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f43c5107-774f-4395-a14d-02ece57fb36f'>_startPoint</a></td><td style='width:75%' ><p><a name="f43c5107-774f-4395-a14d-02ece57fb36f"></a>
<b>Private <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> _startPoint</b></p>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5515bf36-2dc1-41c5-b61f-09be8025ebfc'>_tileMode</a></td><td style='width:75%' class='def'><p><a name="5515bf36-2dc1-41c5-b61f-09be8025ebfc"></a>
<b>Private <code>SkiaSharp.SKShaderTileMode</code> _tileMode</b></p>

<p>The gradient tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61a70b43-c4cf-4141-8f27-e49c69d291c2'>GradientModified</a></td><td style='width:75%' ><p><a name="61a70b43-c4cf-4141-8f27-e49c69d291c2"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> GradientModified</b></p>

<p>The private <code>GradientModified</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9477ec9-bbdf-454b-928d-14362b0c6beb'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="d9477ec9-bbdf-454b-928d-14362b0c6beb"></a>
<b>Private <a href="#9df21535-8dff-4e02-9642-dead70cefcc6">KimonoCore.Kimono.HandleEventDelegate</a> HandleSelected</b></p>

<p>The private <code>HandleSelected</code> field of the <code>KimonoGradient</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2aa7d7e1-9a9d-42aa-bb65-9917fe7c9f5a'>PerformingDrag</a></td><td style='width:75%' ><p><a name="2aa7d7e1-9a9d-42aa-bb65-9917fe7c9f5a"></a>
<b>Private <code>System.Boolean</code> PerformingDrag</b></p>

<p>Is the user performing a drag operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bb3a82b9-5377-40ba-9a93-c9a220a9cb0b'>BarHeight</a></td><td style='width:75%' ><p><a name="bb3a82b9-5377-40ba-9a93-c9a220a9cb0b"></a></p>

<h3>Public <code>System.Single</code> BarHeight</h3>

<h4>Summary</h4>

<p>Gets or sets the height of the bar.</p>

<h4>Return Value</h4>

<p>The height of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbdd371f-19eb-42d9-bad0-ea3a5d2f2e2b'>BarWidth</a></td><td style='width:75%' class='def'><p><a name="fbdd371f-19eb-42d9-bad0-ea3a5d2f2e2b"></a></p>

<h3>Public <code>System.Single</code> BarWidth</h3>

<h4>Summary</h4>

<p>Gets or sets the width of the bar.</p>

<h4>Return Value</h4>

<p>The width of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad552a2d-de10-48b0-a4b9-d1e32ea4f60f'>ControlPoints</a></td><td style='width:75%' ><p><a name="ad552a2d-de10-48b0-a4b9-d1e32ea4f60f"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoHandle&gt;</code> ControlPoints</h3>

<h4>Summary</h4>

<p>Gets or sets the control points that define the color.</p>

<h4>Return Value</h4>

<p>The control points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abeae27c-fb3d-4213-920d-2bc90d995d07'>ElementName</a></td><td style='width:75%' class='def'><p><a name="abeae27c-fb3d-4213-920d-2bc90d995d07"></a></p>

<h3>Private <code>System.String</code> ElementName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87a83b6c-9ec7-4f26-b951-b511c55af17f'>EndPoint</a></td><td style='width:75%' ><p><a name="87a83b6c-9ec7-4f26-b951-b511c55af17f"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> EndPoint</h3>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aaa632f1-4945-47f9-b0c5-9b7822c71ad1'>GradientType</a></td><td style='width:75%' class='def'><p><a name="aaa632f1-4945-47f9-b0c5-9b7822c71ad1"></a></p>

<h3>Public <a href="#e2c4892c-ccec-401e-90e8-6969d7d016b4">KimonoCore.KimonoGradientType</a> GradientType</h3>

<h4>Summary</h4>

<p>Gets or sets the type of the gradient.</p>

<h4>Return Value</h4>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7b7448d-7740-492a-af2a-7ef5012b0e6c'>Name</a></td><td style='width:75%' ><p><a name="c7b7448d-7740-492a-af2a-7ef5012b0e6c"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91c638b3-4daf-4a37-bed4-b7b68f75caf3'>PreviewHeight</a></td><td style='width:75%' class='def'><p><a name="91c638b3-4daf-4a37-bed4-b7b68f75caf3"></a></p>

<h3>Public <code>System.Single</code> PreviewHeight</h3>

<h4>Summary</h4>

<p>Gets or sets the height of the preview.</p>

<h4>Return Value</h4>

<p>The height of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70e297fe-859c-4c24-b2b8-1a646ce57737'>PreviewWidth</a></td><td style='width:75%' ><p><a name="70e297fe-859c-4c24-b2b8-1a646ce57737"></a></p>

<h3>Public <code>System.Single</code> PreviewWidth</h3>

<h4>Summary</h4>

<p>Gets or sets the width of the preview.</p>

<h4>Return Value</h4>

<p>The width of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be059656-8ef8-4245-9d5d-ea74f2344504'>Radius</a></td><td style='width:75%' class='def'><p><a name="be059656-8ef8-4245-9d5d-ea74f2344504"></a></p>

<h3>Public <code>System.Single</code> Radius</h3>

<h4>Summary</h4>

<p>Gets or sets the radius used by radial and conical gradients.</p>

<h4>Return Value</h4>

<p>The radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b7f733f-96c3-4c9b-840a-6a035d940120'>SelectedColor</a></td><td style='width:75%' ><p><a name="3b7f733f-96c3-4c9b-840a-6a035d940120"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKColor</code> SelectedColor</h3>

<h4>Summary</h4>

<p>Gets the color of the selected handle.</p>

<h4>Return Value</h4>

<p>The color of the selected handle or black if no handle is selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4bc58fa-e04d-4e4e-994e-6c3d8bdf3f00'>SelectedHandle</a></td><td style='width:75%' class='def'><p><a name="b4bc58fa-e04d-4e4e-994e-6c3d8bdf3f00"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> SelectedHandle</h3>

<h4>Summary</h4>

<p>Gets or sets the selected handle.</p>

<h4>Return Value</h4>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed47bcda-8dc9-4bdc-b07f-3f7821ac099f'>Shader</a></td><td style='width:75%' ><p><a name="ed47bcda-8dc9-4bdc-b07f-3f7821ac099f"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKShader</code> Shader</h3>

<h4>Summary</h4>

<p>Gets the Skia Shader that represents this gradient.</p>

<h4>Return Value</h4>

<p>The <code>SKShader</code> for this gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b080e0b3-2804-4885-b167-314600b3d901'>StartPoint</a></td><td style='width:75%' class='def'><p><a name="b080e0b3-2804-4885-b167-314600b3d901"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> StartPoint</h3>

<h4>Summary</h4>

<p>Gets or sets the start point.</p>

<h4>Return Value</h4>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#589d408c-cf45-47cb-8025-6998bc55553c'>TileMode</a></td><td style='width:75%' ><p><a name="589d408c-cf45-47cb-8025-6998bc55553c"></a></p>

<h3>Public <code>SkiaSharp.SKShaderTileMode</code> TileMode</h3>

<h4>Summary</h4>

<p>Gets or sets the tile mode.</p>

<h4>Return Value</h4>

<p>The tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1972d36c-9634-49b6-b092-950300b0c35f'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="1972d36c-9634-49b6-b092-950300b0c35f"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a215981e-1e15-4b52-98a2-59b32cf22bb6'>AddControlPoint</a></td><td style='width:75%' ><p><a name="a215981e-1e15-4b52-98a2-59b32cf22bb6"></a></p>

<h3>Public Void AddControlPoint ()</h3>

<h4>Summary</h4>

<p>Adds a new control point to the gradients collection and makes it the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3e41810-ca5c-4381-9097-fcc8e0d64193'>BarToolDown</a></td><td style='width:75%' class='def'><p><a name="f3e41810-ca5c-4381-9097-fcc8e0d64193"></a></p>

<h3>Public Void BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="2ac09197-be36-4897-af8d-83f680260ceb"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="abc0b6eb-14d5-45be-9e1a-6c0f563754cf"></a>
<b>System.Int32 clicks</b></p>

<p>The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="ad0cc789-b3ec-4772-8f88-3bcaf8a0e658"></a>
<b>System.Boolean multiSelect</b></p>

<p>If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad5e47e0-ba58-487f-99c1-4b3185abbf75'>BarToolDrag</a></td><td style='width:75%' ><p><a name="ad5e47e0-ba58-487f-99c1-4b3185abbf75"></a></p>

<h3>Public Void BarToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient design bar. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="34f48e19-22a7-4b56-9bf3-a02c71c9b91a"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e4ea24f-4c4b-4d2c-a6c1-649fbe5abd6f'>BarToolUp</a></td><td style='width:75%' class='def'><p><a name="6e4ea24f-4c4b-4d2c-a6c1-649fbe5abd6f"></a></p>

<h3>Public Void BarToolUp (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e6e9e78c-4ff2-4345-8620-81eb86ecbbe5"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e3d3c3d-706c-4245-bb08-ea171952dfb0'>Clone</a></td><td style='width:75%' ><p><a name="7e3d3c3d-706c-4245-bb08-ea171952dfb0"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e283a8b-ef8b-40d4-bc50-1fdaa7f830c2'>ColorsToCode</a></td><td style='width:75%' class='def'><p><a name="5e283a8b-ef8b-40d4-bc50-1fdaa7f830c2"></a></p>

<h3>Public Virtual <code>System.String</code> ColorsToCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6b1b330f-59b3-4d8d-bc05-83f30689451a"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputLibrary</code> parameter of the ColorsToCode method takes a <code>KimonoCore.CodeOutputLibrary</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fee6df96-b21f-4e5a-9186-3589547e3e67'>ColorsToInitializer</a></td><td style='width:75%' ><p><a name="fee6df96-b21f-4e5a-9186-3589547e3e67"></a></p>

<h3>Public Virtual <code>System.String</code> ColorsToInitializer (KimonoCore.CodeOutputLibrary, System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2c1df179-7d9d-4d64-9b24-152cbf1dc289"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputLibrary</code> parameter of the ColorsToInitializer method takes a <code>KimonoCore.CodeOutputLibrary</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>constructor</td><td style='width:75%' class='def'><p><a name="cb56f77a-f2ff-4a69-9f02-82576c1a4769"></a>
<b>System.Boolean constructor</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>constructor</code> parameter of the ColorsToInitializer method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32abb29e-583d-469c-a102-66cf160feb2f'>ConformingShader</a></td><td style='width:75%' class='def'><p><a name="32abb29e-583d-469c-a102-66cf160feb2f"></a></p>

<h3>Public <code>SkiaSharp.SKShader</code> ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Generates a shader that conforms to a given start and end point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="1acda724-d458-4d06-a95e-eee4f18903b8"></a>
<b>SkiaSharp.SKPoint startPoint</b></p>

<p>Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="0654addf-d28b-4d61-9c4a-824bcb5fa5ee"></a>
<b>SkiaSharp.SKPoint endPoint</b></p>

<p>End point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>SKShader</code> for the gradient bound to a given shape's dimentions.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fe04ae9-7279-4d58-8c23-36dd0a408df5'>DeleteSelectedControlPoint</a></td><td style='width:75%' ><p><a name="8fe04ae9-7279-4d58-8c23-36dd0a408df5"></a></p>

<h3>Public Void DeleteSelectedControlPoint ()</h3>

<h4>Summary</h4>

<p>Deletes the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5a59da2-d08b-443c-b761-e90711d95336'>DrawBar</a></td><td style='width:75%' class='def'><p><a name="e5a59da2-d08b-443c-b761-e90711d95336"></a></p>

<h3>Public <code>SkiaSharp.SKData</code> DrawBar ()</h3>

<h4>Summary</h4>

<p>Draws the bar.</p>

<h4>Returns</h4>

<p>The bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d99aa61-df48-490e-83b7-5baadeb5521e'>DrawPreview</a></td><td style='width:75%' ><p><a name="1d99aa61-df48-490e-83b7-5baadeb5521e"></a></p>

<h3>Public <code>SkiaSharp.SKData</code> DrawPreview ()</h3>

<h4>Summary</h4>

<p>Draws the preview.</p>

<h4>Returns</h4>

<p>The preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc7a89bf-64e9-4745-ac0e-952f6da113cf'>DuplicateSelectedControlPoint</a></td><td style='width:75%' class='def'><p><a name="cc7a89bf-64e9-4745-ac0e-952f6da113cf"></a></p>

<h3>Public Void DuplicateSelectedControlPoint ()</h3>

<h4>Summary</h4>

<p>Duplicates the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#253df57c-0af7-42a4-b748-de7041b32042'>FindHandle</a></td><td style='width:75%' ><p><a name="253df57c-0af7-42a4-b748-de7041b32042"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> FindHandle (System.String)</h3>

<h4>Summary</h4>

<p>Finds the handle matching the given unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="dbe3ceb4-7f27-4cbd-8a1f-4d9b3e7c1d1f"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The matching <code>KimonoHandle</code> or <code>null</code> if not found.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0582cd64-212f-41dd-89c0-4f482f256f5b'>Initialize</a></td><td style='width:75%' class='def'><p><a name="0582cd64-212f-41dd-89c0-4f482f256f5b"></a></p>

<h3>Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59f90cd1-fba3-4c52-85be-f6519552f0cb'>KimonoGradient</a></td><td style='width:75%' ><p><a name="59f90cd1-fba3-4c52-85be-f6519552f0cb"></a></p>

<h3>Public Void KimonoGradient ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#457eb984-e4fc-4913-af40-54ce799daf30'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="457eb984-e4fc-4913-af40-54ce799daf30"></a></p>

<h3>Public Void KimonoGradient (KimonoCore.KimonoGradientType, KimonoCore.KimonoHandle, KimonoCore.KimonoHandle, System.Single, SkiaSharp.SKShaderTileMode, SkiaSharp.SKColor[], System.Single[])</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradientType</td><td style='width:75%' ><p><a name="9028d228-fac7-4faa-9752-1e3f79536875"></a>
<b>KimonoCore.KimonoGradientType gradientType</b></p>

<p>Gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="6de85d56-d535-48eb-aaa8-087fcd74fd4a"></a>
<b>KimonoCore.KimonoHandle startPoint</b></p>

<p>Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="18d4e6b5-463a-4bae-a6ac-2231e1384c17"></a>
<b>KimonoCore.KimonoHandle endPoint</b></p>

<p>End point.</p>
</td></tr><tr><td style='width:25%' class='term'>radius</td><td style='width:75%' class='def'><p><a name="eb686be6-2447-45a2-aaab-39b75400428d"></a>
<b>System.Single radius</b></p>

<p>Radius.</p>
</td></tr><tr><td style='width:25%' class='term'>tileMode</td><td style='width:75%' ><p><a name="6e960225-e358-4ddc-8cf3-d7b831170897"></a>
<b>SkiaSharp.SKShaderTileMode tileMode</b></p>

<p>Tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'>colors</td><td style='width:75%' class='def'><p><a name="9e687263-d28d-4a8e-8663-5bde2cb40558"></a>
<b>SkiaSharp.SKColor[] colors</b></p>

<p>Colors.</p>
</td></tr><tr><td style='width:25%' class='term'>weights</td><td style='width:75%' ><p><a name="ae387e32-e630-4f0b-8d3c-6e6b8f3ae319"></a>
<b>System.Single[] weights</b></p>

<p>Weights.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c0c170c-4976-4acf-8702-ab2c286b12ea'>KimonoGradient</a></td><td style='width:75%' ><p><a name="5c0c170c-4976-4acf-8702-ab2c286b12ea"></a></p>

<h3>Public Void KimonoGradient (System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="ced5c218-e5ef-44b2-bc1a-cee83886dee9"></a>
<b>System.Single barWidth</b></p>

<p>Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="588a1ab3-1486-4f26-903f-ee2578166ef7"></a>
<b>System.Single barHeight</b></p>

<p>Bar height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47d889a3-1987-49bc-b5eb-ac6be5c927db'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="47d889a3-1987-49bc-b5eb-ac6be5c927db"></a></p>

<h3>Public Void KimonoGradient (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="83eaa67b-060a-40c1-8b2a-c5be206fb851"></a>
<b>System.Single barWidth</b></p>

<p>Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="a8eb49c4-3e9a-4553-97b8-22ac4f4483d6"></a>
<b>System.Single barHeight</b></p>

<p>Bar height.</p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p><a name="32487c85-b789-4926-9190-7a5d8e64e895"></a>
<b>System.Single previewWidth</b></p>

<p>Preview width.</p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p><a name="ce7e6720-e775-464f-82e7-9fb107381b8d"></a>
<b>System.Single previewHeight</b></p>

<p>Preview height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46212f74-3954-4416-bbf4-96b948e5ed18'>PreviewToolDown</a></td><td style='width:75%' ><p><a name="46212f74-3954-4416-bbf4-96b948e5ed18"></a></p>

<h3>Public Void PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="f3cdef67-c7a2-46d5-ab76-8e8ec89cbde4"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="d04f8eff-62b1-4af3-b05c-409cc19093d4"></a>
<b>System.Int32 clicks</b></p>

<p>The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="c1d6fcb0-4013-43c9-9a26-1a64d8f7b396"></a>
<b>System.Boolean multiSelect</b></p>

<p>If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ce84c5b-c3c2-4493-bb5f-a1ccdd8d63dc'>PreviewToolDrag</a></td><td style='width:75%' class='def'><p><a name="1ce84c5b-c3c2-4493-bb5f-a1ccdd8d63dc"></a></p>

<h3>Public Void PreviewToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient preview. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8a009d26-e771-4c0f-8eed-fb96b05449ff"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55e0d295-842e-449a-824b-a8b303136503'>PreviewToolUp</a></td><td style='width:75%' ><p><a name="55e0d295-842e-449a-824b-a8b303136503"></a></p>

<h3>Public Void PreviewToolUp (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="5b79b65d-1821-400d-9a66-68b30ae9ece8"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5534c267-1ce2-4e58-b796-98a832f9cc96'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p><a name="5534c267-1ce2-4e58-b796-98a832f9cc96"></a></p>

<h3>Void RaiseGradientModified ()</h3>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#361f792a-b4c9-4fa0-8270-1ecc159a99ed'>RaiseHandleSelected</a></td><td style='width:75%' ><p><a name="361f792a-b4c9-4fa0-8270-1ecc159a99ed"></a></p>

<h3>Void RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="b0ce9142-834e-4475-a335-de8002b35d21"></a>
<b>KimonoCore.KimonoHandle handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdb8cddf-9b60-47cc-a91c-85aaa8e6d86d'>SortedColors</a></td><td style='width:75%' class='def'><p><a name="bdb8cddf-9b60-47cc-a91c-85aaa8e6d86d"></a></p>

<h3>Private <code>SkiaSharp.SKColor[]</code> SortedColors ()</h3>

<h4>Summary</h4>

<p>Returns a list of sorted colors by their "X" location inside the gradient.</p>

<h4>Returns</h4>

<p>The sorted colors arrays.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27be05d1-f1b8-4330-9af9-493ac39b7a83'>SortedWeights</a></td><td style='width:75%' ><p><a name="27be05d1-f1b8-4330-9af9-493ac39b7a83"></a></p>

<h3>Private <code>System.Single[]</code> SortedWeights ()</h3>

<h4>Summary</h4>

<p>Returns a list a color weights by their "X" location in the gradient.</p>

<h4>Returns</h4>

<p>The sorted weights.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44922146-44e3-4a96-8e14-23c5f93bda68'>ToCode</a></td><td style='width:75%' class='def'><p><a name="44922146-44e3-4a96-8e14-23c5f93bda68"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="9f2056aa-1425-46d8-afc7-4a39110cc9ac"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="09c78cdf-8eb7-4694-ae06-5ceb9711a9db"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="96b08d96-e93b-4ad0-bc3e-1bd910b549b2"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9b5dcb0-a290-4a4b-a402-eb91371f29ee'>ToCSharp</a></td><td style='width:75%' ><p><a name="b9b5dcb0-a290-4a4b-a402-eb91371f29ee"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="bdee6935-f31e-40ac-ac5a-77146626aab6"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02ef96b9-7f58-42cd-8a84-d1ea7af7318f'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="02ef96b9-7f58-42cd-8a84-d1ea7af7318f"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="dc5be70c-f9fb-4634-aea6-b213354ffdeb"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="21bc23bd-6cc8-4400-b392-f31f52771aa0"></a>
<b>SkiaSharp.SKPoint startPoint</b></p>

<p>The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="7be22c27-1d3d-4ed4-a5be-a6a92dbb9022"></a>
<b>SkiaSharp.SKPoint endPoint</b></p>

<p>The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9fc58268-31e5-47cc-9ff4-663a25ce45ba'>ToCSharpInitializer</a></td><td style='width:75%' ><p><a name="9fc58268-31e5-47cc-9ff4-663a25ce45ba"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2da47003-212c-4eb3-bbe3-bd10aa950699"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#361fb906-a5ec-4008-a527-c55718e43b66'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="361fb906-a5ec-4008-a527-c55718e43b66"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c10868d-355e-44a5-adcb-92a80627487b'>ToCSharpKimonoCore</a></td><td style='width:75%' ><p><a name="1c10868d-355e-44a5-adcb-92a80627487b"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpKimonoCore (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="4a75f76a-85e9-4891-b2ef-166092e7ec8e"></a>
<b>SkiaSharp.SKPoint startPoint</b></p>

<p>The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="34ff5717-f0dc-44e3-bad2-da0a4d747079"></a>
<b>SkiaSharp.SKPoint endPoint</b></p>

<p>The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0030eb06-bb3a-4601-8ee8-cd3facf28d37'>ToCSharpKimonoCoreInitializer</a></td><td style='width:75%' class='def'><p><a name="0030eb06-bb3a-4601-8ee8-cd3facf28d37"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpKimonoCoreInitializer ()</h3>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0a56156-7f6a-44e5-9cd2-7e7cb2912ffd'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="a0a56156-7f6a-44e5-9cd2-7e7cb2912ffd"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpSkia ()</h3>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#283ba3ad-a079-4f33-98c7-ffea7c84f103'>ToCSharpSkia</a></td><td style='width:75%' class='def'><p><a name="283ba3ad-a079-4f33-98c7-ffea7c84f103"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpSkia (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="1aa508f8-fc8b-46a7-b890-cf319a2c5c9a"></a>
<b>SkiaSharp.SKPoint startPoint</b></p>

<p>The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="43d349b9-bc6c-49d5-9303-b31a3dcecfb5"></a>
<b>SkiaSharp.SKPoint endPoint</b></p>

<p>The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08b2e796-4cc6-4743-8942-e3e7b50e53c2'>ToCSharpSkiaInitializer</a></td><td style='width:75%' ><p><a name="08b2e796-4cc6-4743-8942-e3e7b50e53c2"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpSkiaInitializer ()</h3>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f8be6cc-a91f-4859-bee1-af35421abf51'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="2f8be6cc-a91f-4859-bee1-af35421abf51"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b75c3b26-333f-477d-acc7-352b1841662f'>ToObiScript</a></td><td style='width:75%' ><p><a name="b75c3b26-333f-477d-acc7-352b1841662f"></a></p>

<h3>Public Virtual <code>System.String</code> ToObiScript ()</h3>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c6b5bad-9d9e-4327-876b-807dcda5939f'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="6c6b5bad-9d9e-4327-876b-807dcda5939f"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08e96e90-5199-48f3-abd8-e253d138923a'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="08e96e90-5199-48f3-abd8-e253d138923a"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b847dfe-2881-45de-99d2-1339af090a9a'>WeightsToSkiaCode</a></td><td style='width:75%' class='def'><p><a name="7b847dfe-2881-45de-99d2-1339af090a9a"></a></p>

<h3>Public Virtual <code>System.String</code> WeightsToSkiaCode ()</h3>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d04fff6f-707b-43ff-82b1-c718eb7afb31'>WeightsToSkiaInitializer</a></td><td style='width:75%' ><p><a name="d04fff6f-707b-43ff-82b1-c718eb7afb31"></a></p>

<h3>Public Virtual <code>System.String</code> WeightsToSkiaInitializer (System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>constructor</td><td style='width:75%' ><p><a name="2b49c50f-2637-46c4-84d4-4384b56ab7ce"></a>
<b>System.Boolean constructor</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>constructor</code> parameter of the WeightsToSkiaInitializer method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#89074470-2c8b-4e87-82e8-dc84f1d730f8'>GradientModified</a></td><td style='width:75%' ><p><a name="89074470-2c8b-4e87-82e8-dc84f1d730f8"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> GradientModified</h3>

<h4>Summary</h4>

<p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe8cd06b-96b6-4432-bfd6-fc939d150329'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="fe8cd06b-96b6-4432-bfd6-fc939d150329"></a></p>

<h3><a href="#9df21535-8dff-4e02-9642-dead70cefcc6">KimonoCore.Kimono.HandleEventDelegate</a> HandleSelected</h3>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="82b87b8a-f3c3-4324-8eab-6116e1c4f0c9"></a>
##Public Class KimonoGradientDesignBar

###Namespace

[KimonoCore.Mac](#e7d58f17-d3e3-48f5-bbac-a79af83dfd2b)

###Inherits From

`AppKit.NSImageView`

###Summary

The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6b105ccb-a129-4017-91de-b70e81f99a58'>_gradient</a></td><td style='width:75%' ><p><a name="6b105ccb-a129-4017-91de-b70e81f99a58"></a>
<b>Private <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> _gradient</b></p>

<p>The private <code>_gradient</code> field of the <code>KimonoGradientDesignBar</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6605c22-ca5c-4a6f-923b-62fc61310cd1'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="f6605c22-ca5c-4a6f-923b-62fc61310cd1"></a>
<b>Private <a href="#9df21535-8dff-4e02-9642-dead70cefcc6">KimonoCore.Kimono.HandleEventDelegate</a> HandleSelected</b></p>

<p>The private <code>HandleSelected</code> field of the <code>KimonoGradientDesignBar</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f8935e90-5a26-46b3-a82c-ce4198120e86'>Gradient</a></td><td style='width:75%' ><p><a name="f8935e90-5a26-46b3-a82c-ce4198120e86"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> Gradient</h3>

<h4>Summary</h4>

<p>Gets or sets the gradient.</p>

<h4>Return Value</h4>

<p>The gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#afe54914-8450-4d7f-8f32-baf43793a0ee'>AcceptsFirstResponder</a></td><td style='width:75%' ><p><a name="afe54914-8450-4d7f-8f32-baf43793a0ee"></a></p>

<h3>Public Virtual <code>System.Boolean</code> AcceptsFirstResponder ()</h3>

<h4>Summary</h4>

<p>Acceptses the first responder.</p>

<h4>Returns</h4>

<p><code>true</code>, if first responder was accepted, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c556155-bd2f-4d75-becd-7a5744a38089'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p><a name="6c556155-bd2f-4d75-becd-7a5744a38089"></a></p>

<h3>Private <code>SkiaSharp.SKPoint</code> ConvertToCanvasPoint (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Converts a raw macOS mouse event point into the coordinates of the currently selected bar's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="fc655950-ea16-411d-ba64-78b1afa59889"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The raw mouse <code>NSEvent</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>An <code>SKPoint</code> adjusted to the bar's coordinate system.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38ccabb7-2f30-4780-bbdf-57a906727303'>HandleGradientModified</a></td><td style='width:75%' ><p><a name="38ccabb7-2f30-4780-bbdf-57a906727303"></a></p>

<h3>Public Void HandleGradientModified ()</h3>

<h4>Summary</h4>

<p>Handles the gradient being modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#098a90d2-b617-41f0-a172-5775a681b103'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p><a name="098a90d2-b617-41f0-a172-5775a681b103"></a></p>

<h3>Public Void KimonoGradientDesignBar ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e04eab60-9ee0-40d9-b1d0-1b503f3277c1'>KimonoGradientDesignBar</a></td><td style='width:75%' ><p><a name="e04eab60-9ee0-40d9-b1d0-1b503f3277c1"></a></p>

<h3>Public Void KimonoGradientDesignBar (CoreGraphics.CGRect)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="490b8a34-e05c-4d58-92c6-19722a5806c4"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc21dfe5-1747-4a0f-bb8d-019bdb6ee098'>KimonoGradientDesignBar</a></td><td style='width:75%' class='def'><p><a name="dc21dfe5-1747-4a0f-bb8d-019bdb6ee098"></a></p>

<h3>Public Void KimonoGradientDesignBar (Foundation.NSCoder)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="8b0c2199-7d60-4f87-a41b-2fcc7c9c67b2"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14a73ae2-04ec-4e93-82c1-f2d993495b46'>KimonoGradientDesignBar</a></td><td style='width:75%' ><p><a name="14a73ae2-04ec-4e93-82c1-f2d993495b46"></a></p>

<h3>Public Void KimonoGradientDesignBar (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="63880374-3878-42b8-bfb5-54633e00d36c"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf189c98-680a-4e60-8023-ee640cfdb7c3'>MouseDown</a></td><td style='width:75%' class='def'><p><a name="bf189c98-680a-4e60-8023-ee640cfdb7c3"></a></p>

<h3>Public Virtual Void MouseDown (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user clicking the mouse</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="82e31149-5910-42b8-9cf4-02a3cfa2ae70"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse down.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c569d211-48d0-4607-9655-e8f4834b4f8d'>MouseDragged</a></td><td style='width:75%' ><p><a name="c569d211-48d0-4607-9655-e8f4834b4f8d"></a></p>

<h3>Public Virtual Void MouseDragged (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user dragging the mouse.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="d5678979-b9ba-4a02-b02b-17e8d58f8a07"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse drag.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a36b515-f79f-4f17-8b29-7e42905b28a9'>MouseMoved</a></td><td style='width:75%' class='def'><p><a name="8a36b515-f79f-4f17-8b29-7e42905b28a9"></a></p>

<h3>Public Virtual Void MouseMoved (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user moving the mouse.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="060577fc-fad6-4d68-95a4-99a6a7ede818"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse move.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c52c66d0-2531-4223-9e22-4a8b50bf3413'>MouseUp</a></td><td style='width:75%' ><p><a name="c52c66d0-2531-4223-9e22-4a8b50bf3413"></a></p>

<h3>Public Virtual Void MouseUp (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user releasing a mouse button.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="7b422c04-2756-4274-a59e-1e0067fdaf24"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse up.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93912701-f377-4f4d-9a88-27bb970de174'>RaiseHandleSelected</a></td><td style='width:75%' class='def'><p><a name="93912701-f377-4f4d-9a88-27bb970de174"></a></p>

<h3>Void RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="942356fe-b01e-4c22-9e9e-e69a3be4ac60"></a>
<b>KimonoCore.KimonoHandle handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f2da594-0552-4fc2-80d8-d7d3069534b7'>RefreshView</a></td><td style='width:75%' ><p><a name="8f2da594-0552-4fc2-80d8-d7d3069534b7"></a></p>

<h3>Public Void RefreshView ()</h3>

<h4>Summary</h4>

<p>Refreshs the view by redrawing the gradient design bar.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a2c240a4-db11-424f-a38d-2c8c5a53950b'>HandleSelected</a></td><td style='width:75%' ><p><a name="a2c240a4-db11-424f-a38d-2c8c5a53950b"></a></p>

<h3><a href="#9df21535-8dff-4e02-9642-dead70cefcc6">KimonoCore.Kimono.HandleEventDelegate</a> HandleSelected</h3>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="92f5f4d2-68b0-4fd7-985f-991c59597b6d"></a>
##Public Class KimonoGradientDesignPreview

###Namespace

[KimonoCore.Mac](#e7d58f17-d3e3-48f5-bbac-a79af83dfd2b)

###Inherits From

`AppKit.NSImageView`

###Summary

The Kimono Gradient Design Bar handles the control points that a user uses to graphically design a gradient in the editor.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ff5d5d9a-a3be-4148-9443-8524aecd6357'>_gradient</a></td><td style='width:75%' ><p><a name="ff5d5d9a-a3be-4148-9443-8524aecd6357"></a>
<b>Private <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> _gradient</b></p>

<p>The private <code>_gradient</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b0cc6663-1c80-4266-8ab3-ef6bc2afe82a'>GradientModified</a></td><td style='width:75%' class='def'><p><a name="b0cc6663-1c80-4266-8ab3-ef6bc2afe82a"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> GradientModified</b></p>

<p>The private <code>GradientModified</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5311fc58-046c-495f-8775-fbbec53947c5'>HandleSelected</a></td><td style='width:75%' ><p><a name="5311fc58-046c-495f-8775-fbbec53947c5"></a>
<b>Private <a href="#9df21535-8dff-4e02-9642-dead70cefcc6">KimonoCore.Kimono.HandleEventDelegate</a> HandleSelected</b></p>

<p>The private <code>HandleSelected</code> field of the <code>KimonoGradientDesignPreview</code> class holds a <code>KimonoCore.Kimono.HandleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#73c5a8a9-d7e1-4ba2-9d39-f449dfdf238a'>Gradient</a></td><td style='width:75%' ><p><a name="73c5a8a9-d7e1-4ba2-9d39-f449dfdf238a"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> Gradient</h3>

<h4>Summary</h4>

<p>Gets or sets the gradient.</p>

<h4>Return Value</h4>

<p>The gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2ebb0800-d664-4200-8bf4-0110cf7c3537'>AcceptsFirstResponder</a></td><td style='width:75%' ><p><a name="2ebb0800-d664-4200-8bf4-0110cf7c3537"></a></p>

<h3>Public Virtual <code>System.Boolean</code> AcceptsFirstResponder ()</h3>

<h4>Summary</h4>

<p>Acceptses the first responder.</p>

<h4>Returns</h4>

<p><code>true</code>, if first responder was accepted, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aad78504-1692-45e0-b6a9-b1005851e774'>ConvertToCanvasPoint</a></td><td style='width:75%' class='def'><p><a name="aad78504-1692-45e0-b6a9-b1005851e774"></a></p>

<h3>Private <code>SkiaSharp.SKPoint</code> ConvertToCanvasPoint (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Converts a raw macOS mouse event point into the coordinates of the currently selected bar's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="5df48ad2-4954-4a6f-b39e-ffdcb44cda5c"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The raw mouse <code>NSEvent</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>An <code>SKPoint</code> adjusted to the bar's coordinate system.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7aaf9dc4-fdcf-4524-8c63-c731921db638'>HandleGradientModified</a></td><td style='width:75%' ><p><a name="7aaf9dc4-fdcf-4524-8c63-c731921db638"></a></p>

<h3>Public Void HandleGradientModified ()</h3>

<h4>Summary</h4>

<p>Handles the gradient being modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d15a2c6-265c-401c-9485-2704ed191761'>KimonoGradientDesignPreview</a></td><td style='width:75%' class='def'><p><a name="9d15a2c6-265c-401c-9485-2704ed191761"></a></p>

<h3>Public Void KimonoGradientDesignPreview ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5aeca481-563a-4e33-9ff9-2dc8443a6c3d'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p><a name="5aeca481-563a-4e33-9ff9-2dc8443a6c3d"></a></p>

<h3>Public Void KimonoGradientDesignPreview (CoreGraphics.CGRect)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>frameRect</td><td style='width:75%' ><p><a name="4605c911-7f82-454f-8fe3-ee0bf8437b1e"></a>
<b>CoreGraphics.CGRect frameRect</b></p>

<p>Frame rect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c1ca298-59cd-4076-ac4c-adf7a45eb5ba'>KimonoGradientDesignPreview</a></td><td style='width:75%' class='def'><p><a name="9c1ca298-59cd-4076-ac4c-adf7a45eb5ba"></a></p>

<h3>Public Void KimonoGradientDesignPreview (Foundation.NSCoder)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>coder</td><td style='width:75%' ><p><a name="9ada23c7-701f-4219-9cfe-b20800a2e962"></a>
<b>Foundation.NSCoder coder</b></p>

<p>Coder.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f8f18d1-8779-414d-8457-a9ffab77da38'>KimonoGradientDesignPreview</a></td><td style='width:75%' ><p><a name="0f8f18d1-8779-414d-8457-a9ffab77da38"></a></p>

<h3>Public Void KimonoGradientDesignPreview (System.IntPtr)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#82b87b8a-f3c3-4324-8eab-6116e1c4f0c9">KimonoGradientDesignBar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="accbb158-6a98-46b5-b5b6-98d222d6e53f"></a>
<b>System.IntPtr handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72343e63-264c-491d-903f-058473ef8d20'>MouseDown</a></td><td style='width:75%' class='def'><p><a name="72343e63-264c-491d-903f-058473ef8d20"></a></p>

<h3>Public Virtual Void MouseDown (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user clicking the mouse</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="dcc4f6e0-738f-4333-b955-5cb22a8c3828"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse down.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#913aa2fe-871d-4c66-9f1e-ec6ab1ff3480'>MouseDragged</a></td><td style='width:75%' ><p><a name="913aa2fe-871d-4c66-9f1e-ec6ab1ff3480"></a></p>

<h3>Public Virtual Void MouseDragged (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user dragging the mouse.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="74c71e1a-e001-4ea4-949b-45c0a9b2f514"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse drag.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40e4e719-1c70-4fd9-a41f-4970eff9997e'>MouseMoved</a></td><td style='width:75%' class='def'><p><a name="40e4e719-1c70-4fd9-a41f-4970eff9997e"></a></p>

<h3>Public Virtual Void MouseMoved (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user moving the mouse.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="7bca8117-1c9d-4930-8fd8-94b5dd3b8e4c"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse move.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f67e6dd7-7740-4cb4-883a-6924da263ec2'>MouseUp</a></td><td style='width:75%' ><p><a name="f67e6dd7-7740-4cb4-883a-6924da263ec2"></a></p>

<h3>Public Virtual Void MouseUp (AppKit.NSEvent)</h3>

<h4>Summary</h4>

<p>Handles the user releasing a mouse button.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>theEvent</td><td style='width:75%' ><p><a name="c12f17b2-d867-41fd-b0c1-457ecd611e81"></a>
<b>AppKit.NSEvent theEvent</b></p>

<p>The <code>NSEvent</code> representing the mouse up.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5d3f041-0f3b-46b1-ad36-508f05c7ff73'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p><a name="e5d3f041-0f3b-46b1-ad36-508f05c7ff73"></a></p>

<h3>Void RaiseGradientModified ()</h3>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a61a7da8-fe80-4174-a8ca-5a427d0d20b2'>RaiseHandleSelected</a></td><td style='width:75%' ><p><a name="a61a7da8-fe80-4174-a8ca-5a427d0d20b2"></a></p>

<h3>Void RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="66f59d98-b6e7-439f-9f52-3b7b1c82ecd7"></a>
<b>KimonoCore.KimonoHandle handle</b></p>

<p>Handle.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3807a29-3552-4487-b36e-7ca67716c4dd'>RefreshView</a></td><td style='width:75%' class='def'><p><a name="e3807a29-3552-4487-b36e-7ca67716c4dd"></a></p>

<h3>Public Void RefreshView ()</h3>

<h4>Summary</h4>

<p>Refreshs the view by redrawing the gradient design bar.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3ac5c198-b054-4492-88b8-d7b712a7a2b6'>GradientModified</a></td><td style='width:75%' ><p><a name="3ac5c198-b054-4492-88b8-d7b712a7a2b6"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> GradientModified</h3>

<h4>Summary</h4>

<p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1aaa7d02-9199-49f1-aceb-c062f6840cab'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="1aaa7d02-9199-49f1-aceb-c062f6840cab"></a></p>

<h3><a href="#9df21535-8dff-4e02-9642-dead70cefcc6">KimonoCore.Kimono.HandleEventDelegate</a> HandleSelected</h3>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="e2c4892c-ccec-401e-90e8-6969d7d016b4"></a>
##Public Enum KimonoGradientType

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Kimono gradient type.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#17bc884a-db88-4970-ba1e-7d71768e7f48'>ConicalGradient</a></td><td style='width:75%' ><p><a name="17bc884a-db88-4970-ba1e-7d71768e7f48"></a>
<b>Public Static Constant <a href="#e2c4892c-ccec-401e-90e8-6969d7d016b4">KimonoCore.KimonoGradientType</a> ConicalGradient = <code>3</code></b></p>

<p>The conical gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cd0f1b7-4a2e-4054-b004-f36f3fcb3cee'>LinearGradient</a></td><td style='width:75%' class='def'><p><a name="2cd0f1b7-4a2e-4054-b004-f36f3fcb3cee"></a>
<b>Public Static Constant <a href="#e2c4892c-ccec-401e-90e8-6969d7d016b4">KimonoCore.KimonoGradientType</a> LinearGradient = <code>0</code></b></p>

<p>The linear gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9101db17-ceb9-47c7-b2d9-c6fb05322959'>RadialGradient</a></td><td style='width:75%' ><p><a name="9101db17-ceb9-47c7-b2d9-c6fb05322959"></a>
<b>Public Static Constant <a href="#e2c4892c-ccec-401e-90e8-6969d7d016b4">KimonoCore.KimonoGradientType</a> RadialGradient = <code>1</code></b></p>

<p>The radial gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13f671b3-9bf4-427c-9421-ef6ebdd1fbd9'>SweepGradient</a></td><td style='width:75%' class='def'><p><a name="13f671b3-9bf4-427c-9421-ef6ebdd1fbd9"></a>
<b>Public Static Constant <a href="#e2c4892c-ccec-401e-90e8-6969d7d016b4">KimonoCore.KimonoGradientType</a> SweepGradient = <code>2</code></b></p>

<p>The sweep gradient.</p>
</td></tr></table></p>


---

<a name="4f2ab0de-866d-4223-95e0-401140c85a02"></a>
##Public Class KimonoHandle

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines an edit handle that the user manipulates to edit the bounds of a `KimonoShape` or the control points of a Bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d71b7ba3-4c45-489c-8c39-9216ec64fc55'>DrawOffset</a></td><td style='width:75%' ><p><a name="d71b7ba3-4c45-489c-8c39-9216ec64fc55"></a>
<b>Public Static <code>System.Single</code> DrawOffset</b></p>

<p>The draw offset of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#724749e2-57c9-44df-ad11-2d89d6a36728'>DrawWidth</a></td><td style='width:75%' class='def'><p><a name="724749e2-57c9-44df-ad11-2d89d6a36728"></a>
<b>Public Static <code>System.Single</code> DrawWidth</b></p>

<p>The width of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e5a5d59-91c1-451a-866b-eb9a6fe802e9'>Moved</a></td><td style='width:75%' ><p><a name="8e5a5d59-91c1-451a-866b-eb9a6fe802e9"></a>
<b>Private <a href="#25e379a4-a7ed-43c6-8d15-70d0408d35ce">KimonoCore.Kimono.SkiaPointEventDelegate</a> Moved</b></p>

<p>The private <code>Moved</code> field of the <code>KimonoHandle</code> class holds a <code>KimonoCore.Kimono.SkiaPointEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f1943cf1-be5b-4593-aa04-bef7cedee5e2'>Color</a></td><td style='width:75%' ><p><a name="f1943cf1-be5b-4593-aa04-bef7cedee5e2"></a></p>

<h3>Public <code>SkiaSharp.SKColor</code> Color</h3>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, this color will be used.</p>

<h4>Return Value</h4>

<p>The <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d89d3c64-19d3-43e6-bd0b-8d2999878d79'>Constraint</a></td><td style='width:75%' class='def'><p><a name="d89d3c64-19d3-43e6-bd0b-8d2999878d79"></a></p>

<h3>Public <a href="#0f8a885e-3109-4027-9d9b-dcdaa359f471">KimonoCore.KimonoHandleConstraint</a> Constraint</h3>

<h4>Summary</h4>

<p>Gets or sets the edit constraint.</p>

<h4>Return Value</h4>

<p>The edit constraint as a <code>KimonoHandleConstraint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d06699fb-2acb-4a1b-a563-c142da27ce5f'>HandleType</a></td><td style='width:75%' ><p><a name="d06699fb-2acb-4a1b-a563-c142da27ce5f"></a></p>

<h3>Public <a href="#f2c0fd67-f515-479b-8550-0c3302019623">KimonoCore.KimonoHandleType</a> HandleType</h3>

<h4>Summary</h4>

<p>Gets or sets the type of the handle.</p>

<h4>Return Value</h4>

<p>The type of the handle as a <code>KimonoHandleType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#233c0386-1078-43ac-9a92-3a561623902e'>HitOffset</a></td><td style='width:75%' class='def'><p><a name="233c0386-1078-43ac-9a92-3a561623902e"></a></p>

<h3>Public <code>SkiaSharp.SKPoint</code> HitOffset</h3>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0439faaf-4e0d-4826-8476-f9c81e4a49a1'>Index</a></td><td style='width:75%' ><p><a name="0439faaf-4e0d-4826-8476-f9c81e4a49a1"></a></p>

<h3>Public <code>System.Int32</code> Index</h3>

<h4>Summary</h4>

<p>Gets or sets the index.</p>

<h4>Return Value</h4>

<p>The index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d316fa1-c85e-4582-83bf-4d28483656ab'>LinkedColor</a></td><td style='width:75%' class='def'><p><a name="8d316fa1-c85e-4582-83bf-4d28483656ab"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> LinkedColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, the <code>Color</code> property will  be used instead.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68503420-42d4-4473-9d71-b5c5537cc7df'>Rect</a></td><td style='width:75%' ><p><a name="68503420-42d4-4473-9d71-b5c5537cc7df"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKRect</code> Rect</h3>

<h4>Summary</h4>

<p>Gets the rect.</p>

<h4>Return Value</h4>

<p>The rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3202942-6dd7-4533-8e78-11f124d903f6'>RepresentedColor</a></td><td style='width:75%' class='def'><p><a name="f3202942-6dd7-4533-8e78-11f124d903f6"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKColor</code> RepresentedColor</h3>

<h4>Summary</h4>

<p>Gets the color that this handle represents.</p>

<h4>Return Value</h4>

<p>The color as a <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a59b2f5-2499-4df6-9331-a3683a4cb98a'>State</a></td><td style='width:75%' ><p><a name="8a59b2f5-2499-4df6-9331-a3683a4cb98a"></a></p>

<h3>Public <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> State</h3>

<h4>Summary</h4>

<p>Gets the edit state of the <code>KimonoHandle</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3764c04d-bbb0-4da2-9014-c545a814bcba'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="3764c04d-bbb0-4da2-9014-c545a814bcba"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e84beaca-3066-4191-907a-147fc509f217'>X</a></td><td style='width:75%' ><p><a name="e84beaca-3066-4191-907a-147fc509f217"></a></p>

<h3>Public <code>System.Single</code> X</h3>

<h4>Summary</h4>

<p>Gets or sets the x value.</p>

<h4>Return Value</h4>

<p>The x coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bef4934b-d3c5-4687-b9d7-983840b7f063'>Y</a></td><td style='width:75%' class='def'><p><a name="bef4934b-d3c5-4687-b9d7-983840b7f063"></a></p>

<h3>Public <code>System.Single</code> Y</h3>

<h4>Summary</h4>

<p>Gets or sets the y value.</p>

<h4>Return Value</h4>

<p>The y coord of the handle's top-left location.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8d86aa84-fbd9-4ecf-a42e-4079b155a1b8'>Clone</a></td><td style='width:75%' ><p><a name="8d86aa84-fbd9-4ecf-a42e-4079b155a1b8"></a></p>

<h3>Public <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoCore.KimonoHandle</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6359119c-4fe5-48a7-843d-0fb06e502839'>DragHandle</a></td><td style='width:75%' class='def'><p><a name="6359119c-4fe5-48a7-843d-0fb06e502839"></a></p>

<h3>Public Void DragHandle (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the handle.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e551a98b-5d97-4b06-aa04-e44d409f978b"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1a9dcea-243e-41d5-9cce-619e321cd24a'>Draw</a></td><td style='width:75%' ><p><a name="a1a9dcea-243e-41d5-9cce-619e321cd24a"></a></p>

<h3>Public Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the hanled into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="ecaf198e-54d7-443b-b8ce-742a598aaf71"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw the hanled into.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The draw.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3be0dfe2-57d4-4088-8f44-ad8070dc072d'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="3be0dfe2-57d4-4088-8f44-ad8070dc072d"></a></p>

<h3>Private Static Void KimonoHandle ()</h3>

<h4>Summary</h4>

<p>The private static <code>KimonoHandle ()</code> constructor for the <code>KimonoHandle</code> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c429b43-1f14-4f70-b108-5099ebaf2b62'>KimonoHandle</a></td><td style='width:75%' ><p><a name="0c429b43-1f14-4f70-b108-5099ebaf2b62"></a></p>

<h3>Public Void KimonoHandle (System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="9760c2a3-5bb0-4174-b2bc-bf7044bfd5c5"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="dd8963c9-9b1c-4a0d-ba00-4526e18a1843"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac7cc30d-b9e3-438b-bb2a-b939d9520719'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="ac7cc30d-b9e3-438b-bb2a-b939d9520719"></a></p>

<h3>Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="4c86719f-096e-4e65-a6d2-0669bceb87d5"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="b2ce42b0-b3ea-42c7-bb54-2326c15fc5f5"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="2e0625e6-de36-4a09-ab34-4d9414fb93ce"></a>
<b>KimonoCore.KimonoHandleConstraint constraint</b></p>

<p>Constraint.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6710412-3365-465d-8f6d-56f6947cb12a'>KimonoHandle</a></td><td style='width:75%' ><p><a name="f6710412-3365-465d-8f6d-56f6947cb12a"></a></p>

<h3>Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="a71e191e-a928-43a4-aae5-631c639cb298"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="7d0740f7-205a-4068-91cf-f2dba4168c62"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="10e3e760-f870-4144-b04d-a710e0cd5ab0"></a>
<b>KimonoCore.KimonoHandleConstraint constraint</b></p>

<p>Constraint.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="c2716500-1500-44ac-8031-d475c2e4b125"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80b23f4d-0dd9-479e-beb1-522a58c4ebdd'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="80b23f4d-0dd9-479e-beb1-522a58c4ebdd"></a></p>

<h3>Public Void KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4f2ab0de-866d-4223-95e0-401140c85a02">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="bf870eb3-b50e-470d-8a8f-59b48c6c9be0"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="0e8745b9-1619-4475-8da1-85bc57dc0acc"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="2d7a3f28-60df-468c-a453-c3384c85fb1a"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e0adb0b-8b07-4928-881a-1adec2f8af54'>MoveTo</a></td><td style='width:75%' ><p><a name="9e0adb0b-8b07-4928-881a-1adec2f8af54"></a></p>

<h3>Public Void MoveTo (System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Moves the handle to the given coordinates.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="517b0f1e-81ad-4fc0-982b-e699f840a5f5"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="7f1b6c6f-cf2c-4430-91d0-3888cd311a20"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48198eba-45b8-4624-ad1a-d46fe455090d'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="48198eba-45b8-4624-ad1a-d46fe455090d"></a></p>

<h3>Public <code>System.Boolean</code> PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a79662f0-8343-40b8-8eb4-cff2d14ab0a2"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec7714bd-6922-4ca4-97f0-07130b0a0789'>RaiseMoved</a></td><td style='width:75%' ><p><a name="ec7714bd-6922-4ca4-97f0-07130b0a0789"></a></p>

<h3>Void RaiseMoved (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Raises the moved event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="91ec788d-3ba8-46ab-99c0-a1ffd54fe033"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a27963e-f945-4e29-95b6-efc19d2b74e3'>ToPoint</a></td><td style='width:75%' class='def'><p><a name="4a27963e-f945-4e29-95b6-efc19d2b74e3"></a></p>

<h3>Public <code>SkiaSharp.SKPoint</code> ToPoint ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoHandle</code> to a Skia Point.</p>

<h4>Returns</h4>

<p>The <code>SKPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f67b1ea6-acf3-4b0b-9b8a-6b23b6fac8ab'>Moved</a></td><td style='width:75%' ><p><a name="f67b1ea6-acf3-4b0b-9b8a-6b23b6fac8ab"></a></p>

<h3><a href="#25e379a4-a7ed-43c6-8d15-70d0408d35ce">KimonoCore.Kimono.SkiaPointEventDelegate</a> Moved</h3>

<h4>Summary</h4>

<p>Occurs when moved.</p>
</td></tr></table></p>


---

<a name="0f8a885e-3109-4027-9d9b-dcdaa359f471"></a>
##Public Enum KimonoHandleConstraint

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Constrains the movement of a `KimonoHandle` when it is being moved by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#20a2e844-7b35-4bdc-813e-18940d727579'>Horizontal</a></td><td style='width:75%' ><p><a name="20a2e844-7b35-4bdc-813e-18940d727579"></a>
<b>Public Static Constant <a href="#0f8a885e-3109-4027-9d9b-dcdaa359f471">KimonoCore.KimonoHandleConstraint</a> Horizontal = <code>1</code></b></p>

<p>The handle can only be moved horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02d26aa8-9f37-4ecb-a8c3-636a68fa0291'>Locked</a></td><td style='width:75%' class='def'><p><a name="02d26aa8-9f37-4ecb-a8c3-636a68fa0291"></a>
<b>Public Static Constant <a href="#0f8a885e-3109-4027-9d9b-dcdaa359f471">KimonoCore.KimonoHandleConstraint</a> Locked = <code>3</code></b></p>

<p>The handle is locked in place and cannot be moved.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79bbe971-e7dd-4dff-95e7-bb21411c4cb3'>None</a></td><td style='width:75%' ><p><a name="79bbe971-e7dd-4dff-95e7-bb21411c4cb3"></a>
<b>Public Static Constant <a href="#0f8a885e-3109-4027-9d9b-dcdaa359f471">KimonoCore.KimonoHandleConstraint</a> None = <code>0</code></b></p>

<p>No movement constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7814d5ed-5059-494d-81f0-d640cf34b474'>Vertical</a></td><td style='width:75%' class='def'><p><a name="7814d5ed-5059-494d-81f0-d640cf34b474"></a>
<b>Public Static Constant <a href="#0f8a885e-3109-4027-9d9b-dcdaa359f471">KimonoCore.KimonoHandleConstraint</a> Vertical = <code>2</code></b></p>

<p>The handle can only be moved vertically.</p>
</td></tr></table></p>


---

<a name="f2c0fd67-f515-479b-8550-0c3302019623"></a>
##Public Enum KimonoHandleType

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the type of a `KimonoHandle` that can be used as a general purpose control point to adjust the bounds of a `KimonoShape` or as a point for a vector or bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#985ad420-32c6-4cf3-89f1-e1c00d605001'>BezierControlPoint</a></td><td style='width:75%' ><p><a name="985ad420-32c6-4cf3-89f1-e1c00d605001"></a>
<b>Public Static Constant <a href="#f2c0fd67-f515-479b-8550-0c3302019623">KimonoCore.KimonoHandleType</a> BezierControlPoint = <code>3</code></b></p>

<p>Defines the control point for a <code>KimonoShapeBezier</code> end point used to adjust the curve of a bezier quad section.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d710255f-dca5-474f-b841-7fc2a0490477'>ControlPoint</a></td><td style='width:75%' class='def'><p><a name="d710255f-dca5-474f-b841-7fc2a0490477"></a>
<b>Public Static Constant <a href="#f2c0fd67-f515-479b-8550-0c3302019623">KimonoCore.KimonoHandleType</a> ControlPoint = <code>0</code></b></p>

<p>A general purpose handle for a shape's bound or a control point on a  vector or bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c08d56bf-0490-4daf-8688-c92a4974792a'>GradientColor</a></td><td style='width:75%' ><p><a name="c08d56bf-0490-4daf-8688-c92a4974792a"></a>
<b>Public Static Constant <a href="#f2c0fd67-f515-479b-8550-0c3302019623">KimonoCore.KimonoHandleType</a> GradientColor = <code>1</code></b></p>

<p>Defines a color inside of a gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5baba16-90f2-4bc2-920c-2a7a7962051b'>GradientPosition</a></td><td style='width:75%' class='def'><p><a name="d5baba16-90f2-4bc2-920c-2a7a7962051b"></a>
<b>Public Static Constant <a href="#f2c0fd67-f515-479b-8550-0c3302019623">KimonoCore.KimonoHandleType</a> GradientPosition = <code>2</code></b></p>

<p>Defines the position of a gradient in a shape object.</p>
</td></tr></table></p>


---

<a name="83ce776d-3d2d-4903-8985-9bbd9862da9d"></a>
##Public Class KimonoPortfolio

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

A Kimono Portfolio holds a collection of `KimonoSketches`, `KimonoStyles` and `KimonoColors` that define a given Kimono Designer project.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3e3fcba7-e88f-4e23-9c65-f2cc27ad23c3'>_selectedSketch</a></td><td style='width:75%' ><p><a name="3e3fcba7-e88f-4e23-9c65-f2cc27ad23c3"></a>
<b><a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoCore.KimonoSketch</a> _selectedSketch</b></p>

<p>The currently selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d880c344-c6ea-4c29-9bba-4acfcb24cc41'>ColorsModified</a></td><td style='width:75%' class='def'><p><a name="d880c344-c6ea-4c29-9bba-4acfcb24cc41"></a>
<b>Private <a href="#f1a2d0ae-1ce6-430b-b9e6-dc563b05a72d">KimonoCore.Kimono.ColorEventDelegate</a> ColorsModified</b></p>

<p>The private <code>ColorsModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.ColorEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01b5ef42-83e7-4db3-9cdb-54fa0f8f5c4d'>GradientsModified</a></td><td style='width:75%' ><p><a name="01b5ef42-83e7-4db3-9cdb-54fa0f8f5c4d"></a>
<b>Private <a href="#67ce0094-ddce-4d9e-9750-53c6acab9831">KimonoCore.Kimono.GradientEventDelegate</a> GradientsModified</b></p>

<p>The private <code>GradientsModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.GradientEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#587f577e-d4ae-4ee3-8399-7d3c76a3bd2c'>NewSketchNumber</a></td><td style='width:75%' class='def'><p><a name="587f577e-d4ae-4ee3-8399-7d3c76a3bd2c"></a>
<b><code>System.Int32</code> NewSketchNumber</b></p>

<p>Holds the number that will be assigned to the next new <code>KimonoSketch</code> created in this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f1a9570-fa03-4243-97e8-e6b5c09bad4b'>PropertyModified</a></td><td style='width:75%' ><p><a name="7f1a9570-fa03-4243-97e8-e6b5c09bad4b"></a>
<b>Private <a href="#3c56fc94-a4eb-4762-8a4e-d39c26f45a7b">KimonoCore.Kimono.PropertyEventDelegate</a> PropertyModified</b></p>

<p>The private <code>PropertyModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PropertyEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa038401-d9a4-4439-b56e-1bf6d6937bd8'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="aa038401-d9a4-4439-b56e-1bf6d6937bd8"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> RequestNewUndoPoint</b></p>

<p>The private <code>RequestNewUndoPoint</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0293b119-8149-44d0-8d52-c30c96fe6dc7'>SelectedShapeChanged</a></td><td style='width:75%' ><p><a name="0293b119-8149-44d0-8d52-c30c96fe6dc7"></a>
<b>Private <a href="#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0">KimonoCore.Kimono.ShapeEventDelegate</a> SelectedShapeChanged</b></p>

<p>The private <code>SelectedShapeChanged</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24c8593d-1ef3-4085-9f1a-265676ee2ae4'>SelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="24c8593d-1ef3-4085-9f1a-265676ee2ae4"></a>
<b>Private <a href="#3fcae83b-ce08-45e3-b771-1d9a71087384">KimonoCore.Kimono.SketchEventDelegate</a> SelectedSketchDidChange</b></p>

<p>The private <code>SelectedSketchDidChange</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40abe593-80fc-478d-8471-adf7fa4ed781'>SelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="40abe593-80fc-478d-8471-adf7fa4ed781"></a>
<b>Private <a href="#3fcae83b-ce08-45e3-b771-1d9a71087384">KimonoCore.Kimono.SketchEventDelegate</a> SelectedSketchWillChange</b></p>

<p>The private <code>SelectedSketchWillChange</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.SketchEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1de22e31-2a88-42dc-9e93-cdbaae9c7892'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="1de22e31-2a88-42dc-9e93-cdbaae9c7892"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchesModified</b></p>

<p>The private <code>SketchesModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18fd6ea3-aada-41e0-8cde-bf9b2591f991'>StylesModified</a></td><td style='width:75%' ><p><a name="18fd6ea3-aada-41e0-8cde-bf9b2591f991"></a>
<b>Private <a href="#fdfb734d-7652-477b-b864-cfa9870cd620">KimonoCore.Kimono.StyleEventDelegate</a> StylesModified</b></p>

<p>The private <code>StylesModified</code> field of the <code>KimonoPortfolio</code> class holds a <code>KimonoCore.Kimono.StyleEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7db968b8-1a51-4bca-848b-33cfd1c53c75'>Author</a></td><td style='width:75%' ><p><a name="7db968b8-1a51-4bca-848b-33cfd1c53c75"></a></p>

<h3>Public <code>System.String</code> Author</h3>

<h4>Summary</h4>

<p>Gets or sets the author.</p>

<h4>Return Value</h4>

<p>The author.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6efaa9aa-cdbd-4c98-9bcf-b6234d5a2483'>Colors</a></td><td style='width:75%' class='def'><p><a name="6efaa9aa-cdbd-4c98-9bcf-b6234d5a2483"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoColor&gt;</code> Colors</h3>

<h4>Summary</h4>

<p>Gets or sets the colors.</p>

<h4>Return Value</h4>

<p>The colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70c1626e-f3b9-46ec-92f1-a2d462a1d348'>Copyright</a></td><td style='width:75%' ><p><a name="70c1626e-f3b9-46ec-92f1-a2d462a1d348"></a></p>

<h3>Public <code>System.String</code> Copyright</h3>

<h4>Summary</h4>

<p>Gets or sets the copyright.</p>

<h4>Return Value</h4>

<p>The copyright.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0416a1ce-1d76-46fb-ad3d-99ba0e4a69f6'>ElementName</a></td><td style='width:75%' class='def'><p><a name="0416a1ce-1d76-46fb-ad3d-99ba0e4a69f6"></a></p>

<h3>Private <code>System.String</code> ElementName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50e4cd9f-7a96-46de-8d2e-fd18cb9e7b1b'>Gradients</a></td><td style='width:75%' ><p><a name="50e4cd9f-7a96-46de-8d2e-fd18cb9e7b1b"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoGradient&gt;</code> Gradients</h3>

<h4>Summary</h4>

<p>Gets or sets the gradients.</p>

<h4>Return Value</h4>

<p>The gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ef7e075-0876-4df1-8a18-231c19feeeed'>Name</a></td><td style='width:75%' class='def'><p><a name="9ef7e075-0876-4df1-8a18-231c19feeeed"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#574e21f1-90ee-4fbe-9e0f-e414375fedf3'>Namespace</a></td><td style='width:75%' ><p><a name="574e21f1-90ee-4fbe-9e0f-e414375fedf3"></a></p>

<h3>Public <code>System.String</code> Namespace</h3>

<h4>Summary</h4>

<p>Gets or sets the namespace.</p>

<h4>Return Value</h4>

<p>The namespace.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd6ad695-7127-4707-a128-25fe218f338e'>Properties</a></td><td style='width:75%' class='def'><p><a name="dd6ad695-7127-4707-a128-25fe218f338e"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoProperty&gt;</code> Properties</h3>

<h4>Summary</h4>

<p>Gets or sets the properties.</p>

<h4>Return Value</h4>

<p>The properties.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8357ba9-148d-471c-afb7-117f8b454179'>SelectedSketch</a></td><td style='width:75%' ><p><a name="a8357ba9-148d-471c-afb7-117f8b454179"></a></p>

<h3>Public <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoCore.KimonoSketch</a> SelectedSketch</h3>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc91dd5f-3378-4a44-a6e5-21169b0b2d56'>Sketches</a></td><td style='width:75%' class='def'><p><a name="cc91dd5f-3378-4a44-a6e5-21169b0b2d56"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoSketch&gt;</code> Sketches</h3>

<h4>Summary</h4>

<p>Gets or sets the sketches.</p>

<h4>Return Value</h4>

<p>The sketches.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d3aedf8-3a95-4c19-80f2-0c4cae161d2f'>Styles</a></td><td style='width:75%' ><p><a name="2d3aedf8-3a95-4c19-80f2-0c4cae161d2f"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoStyle&gt;</code> Styles</h3>

<h4>Summary</h4>

<p>Gets or sets the styles.</p>

<h4>Return Value</h4>

<p>The styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d155c92b-61d9-4ef4-b30a-821b3bb4fec1'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="d155c92b-61d9-4ef4-b30a-821b3bb4fec1"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5072e1d5-a1ba-4992-812d-f91ef3a48179'>AddNewColor</a></td><td style='width:75%' ><p><a name="5072e1d5-a1ba-4992-812d-f91ef3a48179"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> AddNewColor ()</h3>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio.</p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a579ada1-a846-4901-8c5d-6057ed340d1c'>AddNewColor</a></td><td style='width:75%' class='def'><p><a name="a579ada1-a846-4901-8c5d-6057ed340d1c"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> AddNewColor (SkiaSharp.SKColor)</h3>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio based off of a given <code>SKColor</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="ac193676-8348-46aa-8be0-e113449995b7"></a>
<b>SkiaSharp.SKColor baseColor</b></p>

<p>Base color.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41f4753e-4d4f-4fab-bb11-5c25afbebc63'>AddNewGradient</a></td><td style='width:75%' ><p><a name="41f4753e-4d4f-4fab-bb11-5c25afbebc63"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> AddNewGradient ()</h3>

<h4>Summary</h4>

<p>Adds the new gradient.</p>

<h4>Returns</h4>

<p>The new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e9b7970-b55d-42b4-9f33-3be6ac182572'>AddNewProperty</a></td><td style='width:75%' class='def'><p><a name="8e9b7970-b55d-42b4-9f33-3be6ac182572"></a></p>

<h3>Public Void AddNewProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Adds the given <code>KimonoProperty</code> to this portfolio</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="fef83f6b-96dc-4309-8cee-8c526ee16b79"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fed791f8-aaaa-45be-aa39-a743e6ec7d2f'>AddNewSketch</a></td><td style='width:75%' ><p><a name="fed791f8-aaaa-45be-aa39-a743e6ec7d2f"></a></p>

<h3>Public Void AddNewSketch ()</h3>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoSketch</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f946132c-51c4-450a-a419-299458740d9a'>AddNewStyle</a></td><td style='width:75%' class='def'><p><a name="f946132c-51c4-450a-a419-299458740d9a"></a></p>

<h3>Public Void AddNewStyle ()</h3>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoStyle</code> to the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51e2c26b-1253-4f1f-a96a-88110b48aa3f'>AddPropertyBoolean</a></td><td style='width:75%' ><p><a name="51e2c26b-1253-4f1f-a96a-88110b48aa3f"></a></p>

<h3>Public <a href="#f7f95b58-feb6-4b41-aa87-2b3bc93b25cd">KimonoCore.KimonoPropertyBoolean</a> AddPropertyBoolean ()</h3>

<h4>Summary</h4>

<p>Adds a new boolean property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyBoolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#562927cf-82ca-4932-9892-281ae826fefc'>AddPropertyColor</a></td><td style='width:75%' class='def'><p><a name="562927cf-82ca-4932-9892-281ae826fefc"></a></p>

<h3>Public <a href="#d6ae6723-ed8c-4d65-8e35-eabe2a6ee75e">KimonoCore.KimonoPropertyColor</a> AddPropertyColor ()</h3>

<h4>Summary</h4>

<p>Adds a new color property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#491ba13b-118d-4efc-94b8-01e7957df6d6'>AddPropertyGradient</a></td><td style='width:75%' ><p><a name="491ba13b-118d-4efc-94b8-01e7957df6d6"></a></p>

<h3>Public <a href="#5f306371-0ebf-41e9-b6c1-7346aac7c98c">KimonoCore.KimonoPropertyGradient</a> AddPropertyGradient ()</h3>

<h4>Summary</h4>

<p>Adds a new gradient property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef475709-0a09-4f97-885d-d448b4f4826a'>AddPropertyNumber</a></td><td style='width:75%' class='def'><p><a name="ef475709-0a09-4f97-885d-d448b4f4826a"></a></p>

<h3>Public <a href="#7ff008ad-e46a-4336-bf6c-f17d13cd68ce">KimonoCore.KimonoPropertyNumber</a> AddPropertyNumber ()</h3>

<h4>Summary</h4>

<p>Adds a new number property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyNumber</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca096fef-690b-4332-8156-f4440e1fb16e'>AddPropertyRect</a></td><td style='width:75%' ><p><a name="ca096fef-690b-4332-8156-f4440e1fb16e"></a></p>

<h3>Public <a href="#043d525b-f140-4894-8e78-d7d54d6bfef7">KimonoCore.KimonoPropertyRect</a> AddPropertyRect ()</h3>

<h4>Summary</h4>

<p>Adds a new rect property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19f5c636-dcce-4efc-878e-2f9554109c54'>AddPropertyStyle</a></td><td style='width:75%' class='def'><p><a name="19f5c636-dcce-4efc-878e-2f9554109c54"></a></p>

<h3>Public <a href="#3822fbc9-3bf3-45ad-84aa-889b20302673">KimonoCore.KimonoPropertyStyle</a> AddPropertyStyle ()</h3>

<h4>Summary</h4>

<p>Adds a new style property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5acd77a-785a-4729-8acb-5b5c5c3809ce'>AddPropertyText</a></td><td style='width:75%' ><p><a name="f5acd77a-785a-4729-8acb-5b5c5c3809ce"></a></p>

<h3>Public <a href="#6045055f-2b8d-4f63-ba1c-c5c7c2de9c3d">KimonoCore.KimonoPropertyText</a> AddPropertyText ()</h3>

<h4>Summary</h4>

<p>Adds a new text property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccdf3084-8043-41df-9df0-337a25346c25'>Clone</a></td><td style='width:75%' class='def'><p><a name="ccdf3084-8043-41df-9df0-337a25346c25"></a></p>

<h3>Public <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoCore.KimonoPortfolio</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a627136-1d4c-4479-83c3-dd1be2bfb69c'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' ><p><a name="3a627136-1d4c-4479-83c3-dd1be2bfb69c"></a></p>

<h3>Public Void ConvertSelectedShapeToStyle ()</h3>

<h4>Summary</h4>

<p>Takes the custom <code>KimonoStyle</code> of the currently selected <code>KimonoShape</code>, converts it to a named, shared style and adds it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#810b483c-da66-4549-b884-0eb71e725161'>DeleteColor</a></td><td style='width:75%' class='def'><p><a name="810b483c-da66-4549-b884-0eb71e725161"></a></p>

<h3>Public Void DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="9e5577cf-cd02-4aad-9c35-51beb4e10d53"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8128ff46-b8e5-4db5-86a7-d645d3c33909'>DeleteGradient</a></td><td style='width:75%' ><p><a name="8128ff46-b8e5-4db5-86a7-d645d3c33909"></a></p>

<h3>Public Void DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Deletes the given gradient from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="d450373b-f49a-4748-8d46-6f3daea29b4a"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45d57966-af6d-44c6-8954-e636246bccf9'>DeleteProperty</a></td><td style='width:75%' class='def'><p><a name="45d57966-af6d-44c6-8954-e636246bccf9"></a></p>

<h3>Public Void DeleteProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Deletes the given property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="a665f037-730a-4297-a8e6-9d523b1120cc"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99584b50-2bde-4924-a419-2e66007c4f72'>DeleteSelectedSketch</a></td><td style='width:75%' ><p><a name="99584b50-2bde-4924-a419-2e66007c4f72"></a></p>

<h3>Public Void DeleteSelectedSketch ()</h3>

<h4>Summary</h4>

<p>Deletes the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd59308e-98d1-4ea6-ac71-738a7ac62537'>DeleteStyle</a></td><td style='width:75%' class='def'><p><a name="fd59308e-98d1-4ea6-ac71-738a7ac62537"></a></p>

<h3>Public Void DeleteStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoStyle</code> from the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="b8169399-05ce-45c1-a487-3a5f3be6f13c"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a982981e-0af1-48a8-a065-b3470956b721'>DuplicateColor</a></td><td style='width:75%' ><p><a name="a982981e-0af1-48a8-a065-b3470956b721"></a></p>

<h3>Public Void DuplicateColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoColor</code> and adds it to the portfolio's collection of colors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="20cb17a6-04d6-4324-9bb8-4258c142e00a"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea37650a-3a73-4fe9-91ca-d4b0022dd476'>DuplicateGradient</a></td><td style='width:75%' class='def'><p><a name="ea37650a-3a73-4fe9-91ca-d4b0022dd476"></a></p>

<h3>Public Void DuplicateGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Duplicates the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="5daf2160-d967-48c6-927c-0a2f7ddf257d"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74803255-2721-464f-b09c-9412a849a8f7'>DuplicateProperty</a></td><td style='width:75%' ><p><a name="74803255-2721-464f-b09c-9412a849a8f7"></a></p>

<h3>Public <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> DuplicateProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Duplicates the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="a61a05db-3745-465a-8846-6b0897bb51d2"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to duplicate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7106458d-1ee9-4019-882b-aa2a27849e0c'>DuplicateSelectedSketch</a></td><td style='width:75%' class='def'><p><a name="7106458d-1ee9-4019-882b-aa2a27849e0c"></a></p>

<h3>Public Void DuplicateSelectedSketch ()</h3>

<h4>Summary</h4>

<p>Duplicates the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d20506aa-38dd-4825-aedd-94b2235a7d67'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="d20506aa-38dd-4825-aedd-94b2235a7d67"></a></p>

<h3>Public Void DuplicateStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoStyle</code> adding it to the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="3856abac-b7e7-49e4-911c-d0e89b62f6f4"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07ff15de-1770-4855-9169-750d5c45dd1e'>FindColor</a></td><td style='width:75%' class='def'><p><a name="07ff15de-1770-4855-9169-750d5c45dd1e"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> FindColor (System.String)</h3>

<h4>Summary</h4>

<p>Finds the given <code>KimonoColor</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="3ba41be5-447c-4fd6-9eb6-5c822e117978"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoColor</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a78f8670-0db7-4b07-a435-6347d147638b'>FindGradient</a></td><td style='width:75%' ><p><a name="a78f8670-0db7-4b07-a435-6347d147638b"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> FindGradient (System.String)</h3>

<h4>Summary</h4>

<p>Finds the gradient by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="53abf465-a809-4489-ab2c-d5f31ccba5c3"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoGradient</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#12c12ee8-eb68-407d-b588-63cf0e49a85d'>FindProperty</a></td><td style='width:75%' class='def'><p><a name="12c12ee8-eb68-407d-b588-63cf0e49a85d"></a></p>

<h3>Public <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> FindProperty (System.String)</h3>

<h4>Summary</h4>

<p>Finds the given <code>KimonoProperty</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="e81ebae0-952d-4a07-bc60-2ba8d5865b2a"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoProperty</code> if founs, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a783e891-1429-4ed2-8d2c-3e899022d070'>FindSketch</a></td><td style='width:75%' ><p><a name="a783e891-1429-4ed2-8d2c-3e899022d070"></a></p>

<h3>Public <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoCore.KimonoSketch</a> FindSketch (System.String)</h3>

<h4>Summary</h4>

<p>Finds the given <code>KimonoSketch</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="ce2e537e-a45b-4476-8d34-b98c1df827b7"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoSketch</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2337b98-5bde-4199-853e-6bf2a36c21b8'>FindStyle</a></td><td style='width:75%' class='def'><p><a name="c2337b98-5bde-4199-853e-6bf2a36c21b8"></a></p>

<h3>Public <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> FindStyle (System.String)</h3>

<h4>Summary</h4>

<p>Finds the given <code>KimonoStyle</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="c2ca7382-04ef-4fd2-81fc-d06371f379a8"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc08ca94-5b6a-4880-bfc2-bf60870252bb'>Initialize</a></td><td style='width:75%' ><p><a name="dc08ca94-5b6a-4880-bfc2-bf60870252bb"></a></p>

<h3>Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b01e994f-025e-4662-a475-46a085522670'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p><a name="b01e994f-025e-4662-a475-46a085522670"></a></p>

<h3>Public Void KimonoPortfolio (System.Boolean)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoPortfolio</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p><a name="9432e63c-02d9-4e2d-9a49-7b96fd69b6d5"></a>
<b>System.Boolean initialize</b></p>

<p>If <code>true</code>, the new instance will be initialized with the default values.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><code>initialize</code> is set to <code>false</code> when a clone is being made of given <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39a2adf7-5772-40fd-abef-f47e0e248497'>RaiseColorsModified</a></td><td style='width:75%' ><p><a name="39a2adf7-5772-40fd-abef-f47e0e248497"></a></p>

<h3>Void RaiseColorsModified (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Raises the colors modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="443d3e39-49d5-498e-9301-d25a8252119a"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41d0f03a-993d-41cd-ae95-0ae640a6e088'>RaiseGradientsModified</a></td><td style='width:75%' class='def'><p><a name="41d0f03a-993d-41cd-ae95-0ae640a6e088"></a></p>

<h3>Void RaiseGradientsModified (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Raises the gradients modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="149dd887-21b9-4d70-b42a-231577936e5d"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#692d8678-9491-49e8-8b06-307cd8e06c78'>RaisePropertyModified</a></td><td style='width:75%' ><p><a name="692d8678-9491-49e8-8b06-307cd8e06c78"></a></p>

<h3>Void RaisePropertyModified (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Raises the property modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="1859d640-73d7-45b0-b55a-4340a195ba56"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a878460e-a295-42f6-a000-25c9d90428ee'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="a878460e-a295-42f6-a000-25c9d90428ee"></a></p>

<h3>Void RaiseRequestNewUndoPoint ()</h3>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27411e31-0aeb-4f61-a8a7-3b31786c0e7a'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p><a name="27411e31-0aeb-4f61-a8a7-3b31786c0e7a"></a></p>

<h3>Void RaiseSelectedShapeChanged (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the selected shape changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="47e89b71-012f-4400-a672-6b2e570cc552"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>The new <code>KimonoShape</code> that was selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91309839-45f0-4635-a67e-c57c4bae8213'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="91309839-45f0-4635-a67e-c57c4bae8213"></a></p>

<h3>Void RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Raises the selected sketch did change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="b55f9ae8-e7f8-4333-8fc6-f9b95797e711"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> that did change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85beb500-df61-471f-a661-c6a3563d14d8'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="85beb500-df61-471f-a661-c6a3563d14d8"></a></p>

<h3>Void RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Raises the selected sketch will change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="b81c9057-d0c2-48a8-b04c-0fac96a18d58"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> that will change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b37f159d-19ee-4819-b1d4-be7706b952ae'>RaiseSketchesModified</a></td><td style='width:75%' class='def'><p><a name="b37f159d-19ee-4819-b1d4-be7706b952ae"></a></p>

<h3>Void RaiseSketchesModified ()</h3>

<h4>Summary</h4>

<p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe5df0e6-ab4a-45ee-849b-4427b38d1b13'>RaiseStylesModified</a></td><td style='width:75%' ><p><a name="fe5df0e6-ab4a-45ee-849b-4427b38d1b13"></a></p>

<h3>Void RaiseStylesModified (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Raises the styles modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="bd4ae457-e797-4295-b81c-f343a889b9fd"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa2ff9d1-5cfa-4083-820d-1ceeceea1896'>RelinkColors</a></td><td style='width:75%' class='def'><p><a name="fa2ff9d1-5cfa-4083-820d-1ceeceea1896"></a></p>

<h3>Void RelinkColors ()</h3>

<h4>Summary</h4>

<p>Relinks the colors after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e821f85-bc5f-4714-a1e5-89a0cb5b9309'>RelinkGradient</a></td><td style='width:75%' ><p><a name="9e821f85-bc5f-4714-a1e5-89a0cb5b9309"></a></p>

<h3>Void RelinkGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Relinks the gradient after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="0385afcc-1f7f-439f-8aa7-c5483fa98b2d"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83e99af9-1486-46f6-8aa9-33f0053c6622'>RelinkShape</a></td><td style='width:75%' class='def'><p><a name="83e99af9-1486-46f6-8aa9-33f0053c6622"></a></p>

<h3>Void RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoShape</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="149ff5a7-7c56-49f6-9fcd-0d1142d77160"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cadf87c4-593e-4f16-9fb8-fdb4e0efb40d'>RelinkSketch</a></td><td style='width:75%' ><p><a name="cadf87c4-593e-4f16-9fb8-fdb4e0efb40d"></a></p>

<h3>Void RelinkSketch (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoSketch</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="c5e6b8ad-02f4-4e61-b8b3-0b418a097b96"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The <code>KimonoSketch</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e39a6765-bcb8-4ba9-81b2-93a102d15027'>RelinkStyle</a></td><td style='width:75%' class='def'><p><a name="e39a6765-bcb8-4ba9-81b2-93a102d15027"></a></p>

<h3>Void RelinkStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoStyle</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="f646141f-2f1f-459e-abac-1814755dd3a2"></a>
<b>KimonoCore.KimonoStyle style</b></p>

<p>The <code>KimonoStyle</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd1732d2-cd4b-4edd-8896-61f39f9c0eb3'>ToCode</a></td><td style='width:75%' ><p><a name="cd1732d2-cd4b-4edd-8896-61f39f9c0eb3"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="ea8c906f-8594-41ee-820f-b2e36a2469ee"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="0aee05a3-db04-4211-b099-c78f75c9b803"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="67ce4030-71b1-4ddd-ba82-168349a2492f"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7183b7e-1942-41a8-acac-d2f7c2446d9d'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="d7183b7e-1942-41a8-acac-d2f7c2446d9d"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="4dc2c6f6-631a-4ffd-8532-bb959d79181f"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0db3ca26-d38c-4419-9490-d6389e4c8a70'>ToCSharp</a></td><td style='width:75%' ><p><a name="0db3ca26-d38c-4419-9490-d6389e4c8a70"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6f59abb8-edee-4ee1-9d16-de1890bd19b1"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' class='def'><p><a name="0cef2c69-13b6-4e1f-ba4f-1c1c8718e92b"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputOS</code> parameter of the ToCSharp method takes a <code>KimonoCore.CodeOutputOS</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="e5ade8d5-8c56-4d4d-a41b-f5a97cc66fd4"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputLanguage</code> parameter of the ToCSharp method takes a <code>KimonoCore.CodeOutputLanguage</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc338e95-1f38-42ce-be91-333c1074914b'>ToCSharpKimono</a></td><td style='width:75%' class='def'><p><a name="dc338e95-1f38-42ce-be91-333c1074914b"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="14fd0b71-10bc-4cf3-a1ca-9df220c7ee88"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="d85d9ba7-6718-4adb-8ec6-e162a26c12b1"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f634dcb6-b625-4d20-bdb9-14a33893f3fc"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8aef7b68-4a31-4820-bd1c-2596cf0a5c8f'>ToCSharpUsingStatements</a></td><td style='width:75%' ><p><a name="8aef7b68-4a31-4820-bd1c-2596cf0a5c8f"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d12ccd4b-cd91-44cb-91ce-a330ac844908"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="b5115765-e2ad-4f64-8d40-91a55434d0ec"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f1ac11b-7c34-42b7-900b-d6fae07a231d'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="5f1ac11b-7c34-42b7-900b-d6fae07a231d"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74451a8d-4344-41b9-96ce-2353ed33d260'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="74451a8d-4344-41b9-96ce-2353ed33d260"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34046639-dc62-4440-b9ef-d06f86e96cc0'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="34046639-dc62-4440-b9ef-d06f86e96cc0"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7ba62623-f6fc-499e-88e9-fe86174ef70a'>ColorsModified</a></td><td style='width:75%' ><p><a name="7ba62623-f6fc-499e-88e9-fe86174ef70a"></a></p>

<h3><a href="#f1a2d0ae-1ce6-430b-b9e6-dc563b05a72d">KimonoCore.Kimono.ColorEventDelegate</a> ColorsModified</h3>

<h4>Summary</h4>

<p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc4679c5-c678-425c-9eae-6b5c9ff796f8'>GradientsModified</a></td><td style='width:75%' class='def'><p><a name="fc4679c5-c678-425c-9eae-6b5c9ff796f8"></a></p>

<h3><a href="#67ce0094-ddce-4d9e-9750-53c6acab9831">KimonoCore.Kimono.GradientEventDelegate</a> GradientsModified</h3>

<h4>Summary</h4>

<p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a130656-4512-4ad5-9c68-34bcb2cb2b61'>PropertyModified</a></td><td style='width:75%' ><p><a name="6a130656-4512-4ad5-9c68-34bcb2cb2b61"></a></p>

<h3><a href="#3c56fc94-a4eb-4762-8a4e-d39c26f45a7b">KimonoCore.Kimono.PropertyEventDelegate</a> PropertyModified</h3>

<h4>Summary</h4>

<p>Occurs when property collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0df8765b-ae2c-4970-8b69-b61b9b672672'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="0df8765b-ae2c-4970-8b69-b61b9b672672"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> RequestNewUndoPoint</h3>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b32cf05-3242-4c3a-b421-3236f2402339'>SelectedShapeChanged</a></td><td style='width:75%' ><p><a name="6b32cf05-3242-4c3a-b421-3236f2402339"></a></p>

<h3><a href="#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0">KimonoCore.Kimono.ShapeEventDelegate</a> SelectedShapeChanged</h3>

<h4>Summary</h4>

<p>Occurs when selected shape changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#340dc76e-2b03-48cd-9fde-8bb5f4f33530'>SelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="340dc76e-2b03-48cd-9fde-8bb5f4f33530"></a></p>

<h3><a href="#3fcae83b-ce08-45e3-b771-1d9a71087384">KimonoCore.Kimono.SketchEventDelegate</a> SelectedSketchDidChange</h3>

<h4>Summary</h4>

<p>Occurs when selected sketch did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fb76a65-6e54-474c-894b-45db59dad9fe'>SelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="8fb76a65-6e54-474c-894b-45db59dad9fe"></a></p>

<h3><a href="#3fcae83b-ce08-45e3-b771-1d9a71087384">KimonoCore.Kimono.SketchEventDelegate</a> SelectedSketchWillChange</h3>

<h4>Summary</h4>

<p>Occurs when selected sketch will change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29b48546-1f74-47dd-92ba-05bf9aeb925a'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="29b48546-1f74-47dd-92ba-05bf9aeb925a"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchesModified</h3>

<h4>Summary</h4>

<p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10cbd2c4-e1db-4569-a434-0457b305dc41'>StylesModified</a></td><td style='width:75%' ><p><a name="10cbd2c4-e1db-4569-a434-0457b305dc41"></a></p>

<h3><a href="#fdfb734d-7652-477b-b864-cfa9870cd620">KimonoCore.Kimono.StyleEventDelegate</a> StylesModified</h3>

<h4>Summary</h4>

<p>Occurs when styles collection is modified.</p>
</td></tr></table></p>


---

<a name="0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8"></a>
##Public Class KimonoProperty

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines a property that can be attached to another Kimono object (such as a `KimonoColor`, `KimonoStyle` or `KimonoShape`) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#101b17fc-443f-4719-b743-95af40b2bea3'>IsObiScriptValue</a></td><td style='width:75%' ><p><a name="101b17fc-443f-4719-b743-95af40b2bea3"></a></p>

<h3>Public Virtual <code>System.Boolean</code> IsObiScriptValue</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoProperty</a> is the result of an Obi Script.</p>

<h4>Return Value</h4>

<p><code>true</code> if is Obi Script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8173171-2181-46fc-97c5-e40056394480'>Name</a></td><td style='width:75%' class='def'><p><a name="c8173171-2181-46fc-97c5-e40056394480"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name as a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b2d07a4-8a6a-4ffd-b42a-ba405ed0e95b'>ObiScript</a></td><td style='width:75%' ><p><a name="0b2d07a4-8a6a-4ffd-b42a-ba405ed0e95b"></a></p>

<h3>Public <code>System.String</code> ObiScript</h3>

<h4>Summary</h4>

<p>Gets or sets the obi script that will be used to calculate the value of this <code>KimonoProperty</code>.</p>

<h4>Return Value</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa4f47d3-4948-4239-827b-6ee60c68f8a3'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="aa4f47d3-4948-4239-827b-6ee60c68f8a3"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cc7da40-4319-4cbf-87d1-b12eaa8b9892'>Usage</a></td><td style='width:75%' ><p><a name="0cc7da40-4319-4cbf-87d1-b12eaa8b9892"></a></p>

<h3>Public <a href="#cb396ef5-9a89-402d-9618-fe8fd5a6656d">KimonoCore.KimonoPropertyUsage</a> Usage</h3>

<h4>Summary</h4>

<p>Gets or sets the usage of this property.</p>

<h4>Return Value</h4>

<p>The <code>KimonoPropertyUsage</code> of this <code>KimonoProperty</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#562360e4-0d2f-4c5c-a4fb-2ceca255e758'>Clone</a></td><td style='width:75%' ><p><a name="562360e4-0d2f-4c5c-a4fb-2ceca255e758"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a29087f3-3488-4bc9-bbe8-9af015a7b075'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="a29087f3-3488-4bc9-bbe8-9af015a7b075"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9281bf2a-f9b5-435d-aa9e-b0fe8fff7ecd'>KimonoProperty</a></td><td style='width:75%' ><p><a name="9281bf2a-f9b5-435d-aa9e-b0fe8fff7ecd"></a></p>

<h3>Public Void KimonoProperty ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoProperty</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2a038cc-4468-4fd7-ad09-0faf59e66fe9'>ToBool</a></td><td style='width:75%' class='def'><p><a name="a2a038cc-4468-4fd7-ad09-0faf59e66fe9"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ToBool ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p>The <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0bffde32-8468-4d22-a97c-4afd0e3aac7f'>ToColor</a></td><td style='width:75%' ><p><a name="0bffde32-8468-4d22-a97c-4afd0e3aac7f"></a></p>

<h3>Public Virtual <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> ToColor ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b17df9a-4c20-4608-8e75-c28a57f50d09'>ToFloat</a></td><td style='width:75%' class='def'><p><a name="7b17df9a-4c20-4608-8e75-c28a57f50d09"></a></p>

<h3>Public Virtual <code>System.Single</code> ToFloat ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e2fef02-2a00-49a7-9b7f-3ab32fcb39e9'>ToGradient</a></td><td style='width:75%' ><p><a name="5e2fef02-2a00-49a7-9b7f-3ab32fcb39e9"></a></p>

<h3>Public Virtual <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> ToGradient ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#821d5fd5-5c3c-4774-b6ae-52fddfd29260'>ToInt</a></td><td style='width:75%' class='def'><p><a name="821d5fd5-5c3c-4774-b6ae-52fddfd29260"></a></p>

<h3>Public Virtual <code>System.Int32</code> ToInt ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a78cccf0-be92-4149-ac66-a4d36d7617b8'>ToRect</a></td><td style='width:75%' ><p><a name="a78cccf0-be92-4149-ac66-a4d36d7617b8"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKRect</code> ToRect ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87e8dfee-04d8-4c80-bf1c-0ce41152971c'>ToStyle</a></td><td style='width:75%' class='def'><p><a name="87e8dfee-04d8-4c80-bf1c-0ce41152971c"></a></p>

<h3>Public Virtual <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> ToStyle ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr></table></p>


---

<a name="f7f95b58-feb6-4b41-aa87-2b3bc93b25cd"></a>
##Public Class KimonoPropertyBoolean

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `bool` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9baa4300-d14f-4811-ab95-2300e1db5d91'>Value</a></td><td style='width:75%' ><p><a name="9baa4300-d14f-4811-ab95-2300e1db5d91"></a></p>

<h3>Public <code>System.Boolean</code> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>bool</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bb31ac9c-63cb-40e6-94bc-b49a77fe6b68'>Clone</a></td><td style='width:75%' ><p><a name="bb31ac9c-63cb-40e6-94bc-b49a77fe6b68"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9dccb89c-0e8d-48ec-9e04-ac6c03ba8c85'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="9dccb89c-0e8d-48ec-9e04-ac6c03ba8c85"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ee8856a-c3f4-420a-a611-5ccaf24f67c9'>KimonoPropertyBoolean</a></td><td style='width:75%' ><p><a name="7ee8856a-c3f4-420a-a611-5ccaf24f67c9"></a></p>

<h3>Public Void KimonoPropertyBoolean ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f7f95b58-feb6-4b41-aa87-2b3bc93b25cd">KimonoPropertyBoolean</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c7b0af1-446d-48fa-b39d-dc66d5ffd31d'>ToBool</a></td><td style='width:75%' class='def'><p><a name="7c7b0af1-446d-48fa-b39d-dc66d5ffd31d"></a></p>

<h3>Public Virtual <code>System.Boolean</code> ToBool ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p><code>true</code>, if bool was toed, <code>false</code> otherwise.</p>
</td></tr></table></p>


---

<a name="d6ae6723-ed8c-4d65-8e35-eabe2a6ee75e"></a>
##Public Class KimonoPropertyColor

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a5f3451e-57ea-4ee9-9683-b3187329e524'>IsObiScriptValue</a></td><td style='width:75%' ><p><a name="a5f3451e-57ea-4ee9-9683-b3187329e524"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsObiScriptValue</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#d6ae6723-ed8c-4d65-8e35-eabe2a6ee75e">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c987e3d0-d633-4a38-9118-dd365f93fe51'>Value</a></td><td style='width:75%' class='def'><p><a name="c987e3d0-d633-4a38-9118-dd365f93fe51"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoColor</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d8c219a5-be17-4688-bd15-7332ff511a4c'>Clone</a></td><td style='width:75%' ><p><a name="d8c219a5-be17-4688-bd15-7332ff511a4c"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82f0a461-67c5-44aa-94b2-bd98e0dca33e'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="82f0a461-67c5-44aa-94b2-bd98e0dca33e"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e024deb6-5899-4d43-9420-a4c276e43a72'>KimonoPropertyColor</a></td><td style='width:75%' ><p><a name="e024deb6-5899-4d43-9420-a4c276e43a72"></a></p>

<h3>Public Void KimonoPropertyColor ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6045055f-2b8d-4f63-ba1c-c5c7c2de9c3d">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c652731-bf4d-43d0-8a9f-85dde1d2c528'>ToColor</a></td><td style='width:75%' class='def'><p><a name="3c652731-bf4d-43d0-8a9f-85dde1d2c528"></a></p>

<h3>Public Virtual <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> ToColor ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr></table></p>


---

<a name="99d8645c-361a-4186-a17b-3aacc1b32251"></a>
##Public Class KimonoPropertyConnection

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines a connection between a given Kimono Object and a `KimonoProperty`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b9fc2fe5-a52f-4df4-8eab-c0a13144b069'>ConnectedProperty</a></td><td style='width:75%' ><p><a name="b9fc2fe5-a52f-4df4-8eab-c0a13144b069"></a></p>

<h3>Public <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> ConnectedProperty</h3>

<h4>Summary</h4>

<p>Gets or sets the connected property.</p>

<h4>Return Value</h4>

<p>The connected <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#180fb36c-455b-4a9e-bafc-c7c003049a68'>ConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="180fb36c-455b-4a9e-bafc-c7c003049a68"></a></p>

<h3>Public <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> ConnectionPoint</h3>

<h4>Summary</h4>

<p>Gets or sets the point that a given <code>KimonoProperty</code> is connected to another Kimono Object.</p>

<h4>Return Value</h4>

<p>The connection point as a <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e06dd6a0-6663-42c6-b249-b539a17e4be9'>UniqueID</a></td><td style='width:75%' ><p><a name="e06dd6a0-6663-42c6-b249-b539a17e4be9"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f567cba6-dd66-4d15-af2e-6446afa97720'>Clone</a></td><td style='width:75%' ><p><a name="f567cba6-dd66-4d15-af2e-6446afa97720"></a></p>

<h3>Public <a href="#99d8645c-361a-4186-a17b-3aacc1b32251">KimonoCore.KimonoPropertyConnection</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1eaee71f-e390-4d1d-af7a-acdeedf5938a'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p><a name="1eaee71f-e390-4d1d-af7a-acdeedf5938a"></a></p>

<h3>Public Void KimonoPropertyConnection ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#99d8645c-361a-4186-a17b-3aacc1b32251">KimonoPropertyConnection</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f45e61b9-eea0-4306-a8b8-8ea8686fe6af'>KimonoPropertyConnection</a></td><td style='width:75%' ><p><a name="f45e61b9-eea0-4306-a8b8-8ea8686fe6af"></a></p>

<h3>Public Void KimonoPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#99d8645c-361a-4186-a17b-3aacc1b32251">KimonoPropertyConnection</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="24db9d4f-3f52-4720-8ba5-c8dc03ca2848"></a>
<b>KimonoCore.KimonoPropertyConnectionPoint connectionPoint</b></p>

<p>Connection point.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="b6acde87-65cf-43d4-964d-785ee6888141"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>Property.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="21392678-5537-4b2b-85a4-fdf9d0c4e6cc"></a>
##Public Enum KimonoPropertyConnectionPoint

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the point that a `KimonoProperty` value can be connected to another Kimono object such as the `Top` coordinate of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#848e5642-7748-41aa-945d-dac136ecc059'>AdjustsAlpha</a></td><td style='width:75%' ><p><a name="848e5642-7748-41aa-945d-dac136ecc059"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> AdjustsAlpha = <code>29</code></b></p>

<p>The adjusts alpha of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f892eac-b4df-4c69-98b3-9e3990635ad8'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p><a name="8f892eac-b4df-4c69-98b3-9e3990635ad8"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> AdjustsBrightness = <code>27</code></b></p>

<p>The adjusts brightness of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93878c9c-8f01-4f95-bc95-be2b2813ed46'>AdjustsHue</a></td><td style='width:75%' ><p><a name="93878c9c-8f01-4f95-bc95-be2b2813ed46"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> AdjustsHue = <code>23</code></b></p>

<p>The adjusts hue of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e064960e-0587-4114-9a5f-d9fee6992d2b'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p><a name="e064960e-0587-4114-9a5f-d9fee6992d2b"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> AdjustsSaturation = <code>25</code></b></p>

<p>The adjusts saturation of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#555bc343-cc7a-401c-b7af-49bf7abcab0e'>AlphaAdjustment</a></td><td style='width:75%' ><p><a name="555bc343-cc7a-401c-b7af-49bf7abcab0e"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> AlphaAdjustment = <code>30</code></b></p>

<p>The alpha adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e143608a-d3ee-476f-b198-c87e78d596b4'>BaseColor</a></td><td style='width:75%' class='def'><p><a name="e143608a-d3ee-476f-b198-c87e78d596b4"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> BaseColor = <code>22</code></b></p>

<p>The base color of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cbb2eba4-c19c-48aa-9a8a-3b1612d6d59d'>Bottom</a></td><td style='width:75%' ><p><a name="cbb2eba4-c19c-48aa-9a8a-3b1612d6d59d"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Bottom = <code>4</code></b></p>

<p>The Bottom coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c49b7b65-42f1-4751-a1e7-fb1f31d6bf9d'>BrightnessAdjustment</a></td><td style='width:75%' class='def'><p><a name="c49b7b65-42f1-4751-a1e7-fb1f31d6bf9d"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> BrightnessAdjustment = <code>28</code></b></p>

<p>The brightness adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b92195b-cbbc-4f81-8003-6e51c1732db3'>CornerRadius</a></td><td style='width:75%' ><p><a name="3b92195b-cbbc-4f81-8003-6e51c1732db3"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> CornerRadius = <code>17</code></b></p>

<p>The corner radius of a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#015acd4f-c697-4e72-a332-270f97f6c2c5'>DepthOffset</a></td><td style='width:75%' class='def'><p><a name="015acd4f-c697-4e72-a332-270f97f6c2c5"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> DepthOffset = <code>20</code></b></p>

<p>The depth offset of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4477ef87-4d2f-43ff-815f-62887858001e'>FillColor</a></td><td style='width:75%' ><p><a name="4477ef87-4d2f-43ff-815f-62887858001e"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillColor = <code>53</code></b></p>

<p>The color of the fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52d7ebe1-317d-4525-a6a6-1f48560e4c24'>FillGradient</a></td><td style='width:75%' class='def'><p><a name="52d7ebe1-317d-4525-a6a6-1f48560e4c24"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillGradient = <code>54</code></b></p>

<p>The fill gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81f1afa4-986e-46f3-821c-cb239e5861f9'>FillHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="81f1afa4-986e-46f3-821c-cb239e5861f9"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillHorizontalBlurAmount = <code>43</code></b></p>

<p>The fill horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88ea931a-7464-43ec-8ed6-b62424efbf65'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="88ea931a-7464-43ec-8ed6-b62424efbf65"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillJitterDeviation = <code>67</code></b></p>

<p>The fill jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89edd0f4-2515-4863-8e63-768286c105d9'>FillJitterLength</a></td><td style='width:75%' ><p><a name="89edd0f4-2515-4863-8e63-768286c105d9"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillJitterLength = <code>66</code></b></p>

<p>The length of the fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7746e6f-0b59-4104-b616-a3e5d98d5541'>FillShadowHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="a7746e6f-0b59-4104-b616-a3e5d98d5541"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillShadowHorizontalBlurAmount = <code>48</code></b></p>

<p>The fill shadow horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7166c6c7-e2bf-4170-bcb6-04fb6dce3f6a'>FillShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="7166c6c7-e2bf-4170-bcb6-04fb6dce3f6a"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillShadowHorizontalOffset = <code>46</code></b></p>

<p>The fill shadow horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#657658fd-7826-442c-bdcd-2d6da9524cca'>FillShadowLinkedColor</a></td><td style='width:75%' class='def'><p><a name="657658fd-7826-442c-bdcd-2d6da9524cca"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillShadowLinkedColor = <code>50</code></b></p>

<p>The color of the fill shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b6dba93-a34f-4a1f-ae42-2874f0abecac'>FillShadowVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="9b6dba93-a34f-4a1f-ae42-2874f0abecac"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillShadowVerticalBlurAmount = <code>49</code></b></p>

<p>The fill shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee6f6680-2c92-424a-96fb-e458c02508ad'>FillShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="ee6f6680-2c92-424a-96fb-e458c02508ad"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillShadowVerticalOffset = <code>47</code></b></p>

<p>The fill shadow vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97478d74-a1d2-41cb-8fdb-73f90269b91e'>FillVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="97478d74-a1d2-41cb-8fdb-73f90269b91e"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FillVerticalBlurAmount = <code>44</code></b></p>

<p>The fill vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#156f93a5-10df-45bb-98e5-9b46239c6883'>FontFamilyName</a></td><td style='width:75%' class='def'><p><a name="156f93a5-10df-45bb-98e5-9b46239c6883"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FontFamilyName = <code>60</code></b></p>

<p>The name of the font family of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58ec6b08-cbd9-4515-9da6-6c3870df733b'>FrameColor</a></td><td style='width:75%' ><p><a name="58ec6b08-cbd9-4515-9da6-6c3870df733b"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameColor = <code>51</code></b></p>

<p>The color of the frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#341db25e-7ad8-4814-9903-6184ca6a592e'>FrameGradient</a></td><td style='width:75%' class='def'><p><a name="341db25e-7ad8-4814-9903-6184ca6a592e"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameGradient = <code>52</code></b></p>

<p>The frame gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6c9c5c4-44f5-4cf9-91c8-840afb8d8bae'>FrameHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="e6c9c5c4-44f5-4cf9-91c8-840afb8d8bae"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameHorizontalBlurAmount = <code>33</code></b></p>

<p>The frame horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29569ffd-638a-4935-9f9c-27f558dbe479'>FrameJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="29569ffd-638a-4935-9f9c-27f558dbe479"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameJitterDeviation = <code>64</code></b></p>

<p>The frame jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#197bad98-4e2f-4876-9676-792b44a897b5'>FrameJitterLength</a></td><td style='width:75%' ><p><a name="197bad98-4e2f-4876-9676-792b44a897b5"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameJitterLength = <code>63</code></b></p>

<p>The length of the frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c97e6067-8e31-45a3-b397-19c0305e6b9a'>FrameShadowHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="c97e6067-8e31-45a3-b397-19c0305e6b9a"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameShadowHorizontalBlurAmount = <code>38</code></b></p>

<p>The frame shadow horizontal blur amount of a `KimonoStyle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a411378-91d9-4130-8751-f958c96f6a15'>FrameShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="9a411378-91d9-4130-8751-f958c96f6a15"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameShadowHorizontalOffset = <code>36</code></b></p>

<p>The frame horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d78fcb0d-9730-4f7e-8e73-a5b1ee594c13'>FrameShadowLinkedColor</a></td><td style='width:75%' class='def'><p><a name="d78fcb0d-9730-4f7e-8e73-a5b1ee594c13"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameShadowLinkedColor = <code>40</code></b></p>

<p>The color of the frame shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e66daf68-1b68-4871-9a7e-28aa51638cef'>FrameShadowVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="e66daf68-1b68-4871-9a7e-28aa51638cef"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameShadowVerticalBlurAmount = <code>39</code></b></p>

<p>The frame shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#502c7290-f7bb-4461-8539-87d5f407b441'>FrameShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="502c7290-f7bb-4461-8539-87d5f407b441"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameShadowVerticalOffset = <code>37</code></b></p>

<p>The frame vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec2ce17b-7083-465b-b493-89c37e3134b4'>FrameVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="ec2ce17b-7083-465b-b493-89c37e3134b4"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> FrameVerticalBlurAmount = <code>34</code></b></p>

<p>The frame vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9881f01b-3d5c-47dc-a7ad-0921ec72f7d8'>HasEndHead</a></td><td style='width:75%' class='def'><p><a name="9881f01b-3d5c-47dc-a7ad-0921ec72f7d8"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasEndHead = <code>12</code></b></p>

<p>The has end head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2503783d-77f3-4d2a-acd7-fc449ed7228d'>HasFill</a></td><td style='width:75%' ><p><a name="2503783d-77f3-4d2a-acd7-fc449ed7228d"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFill = <code>41</code></b></p>

<p>The has fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a13d95a4-e67a-4d8e-ac5b-04024d8b1d86'>HasFillBlur</a></td><td style='width:75%' class='def'><p><a name="a13d95a4-e67a-4d8e-ac5b-04024d8b1d86"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFillBlur = <code>42</code></b></p>

<p>The has fill blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bee1bf5-ce68-4d84-bdc7-a3ab60ebda94'>HasFillJitter</a></td><td style='width:75%' ><p><a name="2bee1bf5-ce68-4d84-bdc7-a3ab60ebda94"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFillJitter = <code>65</code></b></p>

<p>The has fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cb004ca-9b49-4726-a73f-75598e4a142d'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="2cb004ca-9b49-4726-a73f-75598e4a142d"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFillShadow = <code>45</code></b></p>

<p>The has fill shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a1f0b46-84f6-4416-a988-0ce4f5509082'>HasFrame</a></td><td style='width:75%' ><p><a name="5a1f0b46-84f6-4416-a988-0ce4f5509082"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFrame = <code>31</code></b></p>

<p>The has frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4293e7b0-708e-4b44-b8c8-0344df555a43'>HasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="4293e7b0-708e-4b44-b8c8-0344df555a43"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFrameBlur = <code>32</code></b></p>

<p>The has frame blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4664364-da80-4846-b899-707ae8b03345'>HasFrameDash</a></td><td style='width:75%' ><p><a name="a4664364-da80-4846-b899-707ae8b03345"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFrameDash = <code>68</code></b></p>

<p>The has frame dash of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#875d11a8-4c35-4cbe-a221-baa21fd75b13'>HasFrameJitter</a></td><td style='width:75%' class='def'><p><a name="875d11a8-4c35-4cbe-a221-baa21fd75b13"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFrameJitter = <code>62</code></b></p>

<p>The has frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#094540cc-cd66-4c6b-94a8-583e3b662405'>HasFrameShadow</a></td><td style='width:75%' ><p><a name="094540cc-cd66-4c6b-94a8-583e3b662405"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasFrameShadow = <code>35</code></b></p>

<p>The has frame shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87b20cc2-5a49-4a05-9648-de49cadc741a'>HasStartHead</a></td><td style='width:75%' class='def'><p><a name="87b20cc2-5a49-4a05-9648-de49cadc741a"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HasStartHead = <code>11</code></b></p>

<p>The has start head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#21370834-0668-4cbe-b6c6-24521ba43d79'>HeadInnerRatio</a></td><td style='width:75%' ><p><a name="21370834-0668-4cbe-b6c6-24521ba43d79"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HeadInnerRatio = <code>13</code></b></p>

<p>The head inner ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf59a5e1-cb66-450f-894f-cb4090deb986'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p><a name="bf59a5e1-cb66-450f-894f-cb4090deb986"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HeadOuterRatio = <code>14</code></b></p>

<p>The head outer ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c31fb51c-d68a-4942-9a34-86c3bed89fcb'>Height</a></td><td style='width:75%' ><p><a name="c31fb51c-d68a-4942-9a34-86c3bed89fcb"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Height = <code>7</code></b></p>

<p>The Height of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8855265-6046-4e2c-9b80-518b2b10e473'>HueAdjustment</a></td><td style='width:75%' class='def'><p><a name="c8855265-6046-4e2c-9b80-518b2b10e473"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> HueAdjustment = <code>24</code></b></p>

<p>The hue adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d068e35-2832-4507-b661-4c05bdb40f5d'>IsStreamlined</a></td><td style='width:75%' ><p><a name="3d068e35-2832-4507-b661-4c05bdb40f5d"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> IsStreamlined = <code>15</code></b></p>

<p>The is streamlined of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e51f30e-0fa6-4353-9608-82a4dba1be09'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="2e51f30e-0fa6-4353-9608-82a4dba1be09"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> IsVerticalText = <code>55</code></b></p>

<p>The is vertical text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ed999e1-cd4a-4699-a9df-004bed724527'>Left</a></td><td style='width:75%' ><p><a name="2ed999e1-cd4a-4699-a9df-004bed724527"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Left = <code>3</code></b></p>

<p>The Left coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b88aaa0-289d-4b29-87aa-79036ee1b2f0'>NumberOfPoints</a></td><td style='width:75%' class='def'><p><a name="7b88aaa0-289d-4b29-87aa-79036ee1b2f0"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> NumberOfPoints = <code>18</code></b></p>

<p>The number of points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b15683f-2d4b-45c6-9367-961740e55cf1'>NumberOfSides</a></td><td style='width:75%' ><p><a name="7b15683f-2d4b-45c6-9367-961740e55cf1"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> NumberOfSides = <code>16</code></b></p>

<p>The number of sides of a <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#309f740e-85f5-43d5-ac6a-c8d69ebb9084'>Rect</a></td><td style='width:75%' class='def'><p><a name="309f740e-85f5-43d5-ac6a-c8d69ebb9084"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Rect = <code>1</code></b></p>

<p>The rectangle that defines the <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#260d96a6-ebcd-46ba-92c5-45ee1aaec243'>Right</a></td><td style='width:75%' ><p><a name="260d96a6-ebcd-46ba-92c5-45ee1aaec243"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Right = <code>5</code></b></p>

<p>The Right coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e445ce61-cb7c-4128-8240-e332afd6b15f'>RotationDegrees</a></td><td style='width:75%' class='def'><p><a name="e445ce61-cb7c-4128-8240-e332afd6b15f"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> RotationDegrees = <code>8</code></b></p>

<p>The Rotational Degrees of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f45ff85-7801-423b-81e5-c825841b661b'>SaturationAdjustment</a></td><td style='width:75%' ><p><a name="6f45ff85-7801-423b-81e5-c825841b661b"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> SaturationAdjustment = <code>26</code></b></p>

<p>The saturation adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0787768c-bcea-4a20-9c4f-071e5970e2e0'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="0787768c-bcea-4a20-9c4f-071e5970e2e0"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> SkipPoints = <code>19</code></b></p>

<p>The skip points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cef27595-2304-49b9-bbb8-d56069f8e9f1'>StrikeThruText</a></td><td style='width:75%' ><p><a name="cef27595-2304-49b9-bbb8-d56069f8e9f1"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> StrikeThruText = <code>56</code></b></p>

<p>The strike thru text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd4e9511-641b-4635-9ae4-fe09acbfc016'>Style</a></td><td style='width:75%' class='def'><p><a name="dd4e9511-641b-4635-9ae4-fe09acbfc016"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Style = <code>9</code></b></p>

<p>The <code>KimonoStyle</code> of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82f65dc8-46ae-4f4c-9735-d43be1f26b89'>Text</a></td><td style='width:75%' ><p><a name="82f65dc8-46ae-4f4c-9735-d43be1f26b89"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Text = <code>21</code></b></p>

<p>The text of a <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b7a587a-4801-489d-aada-53e61f44aba4'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="9b7a587a-4801-489d-aada-53e61f44aba4"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> TextScaleX = <code>57</code></b></p>

<p>The text scale x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d92a52f-93a8-43fc-84eb-91501b6532ad'>TextSize</a></td><td style='width:75%' ><p><a name="1d92a52f-93a8-43fc-84eb-91501b6532ad"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> TextSize = <code>58</code></b></p>

<p>The size of the text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e3af44f-7dd2-4c46-ac26-52467b4bbc1e'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="2e3af44f-7dd2-4c46-ac26-52467b4bbc1e"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> TextSkewX = <code>59</code></b></p>

<p>The text skew x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a14165b3-11b5-4690-9c45-919178dcccf2'>Top</a></td><td style='width:75%' ><p><a name="a14165b3-11b5-4690-9c45-919178dcccf2"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Top = <code>2</code></b></p>

<p>The Top coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#033ac8f9-20a9-4e7e-9f02-f388817de942'>Undefined</a></td><td style='width:75%' class='def'><p><a name="033ac8f9-20a9-4e7e-9f02-f388817de942"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Undefined = <code>0</code></b></p>

<p>The connection point hasn't been defined.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85b99eb6-be74-47c7-b37b-51d4457f522c'>UnderlineText</a></td><td style='width:75%' ><p><a name="85b99eb6-be74-47c7-b37b-51d4457f522c"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> UnderlineText = <code>61</code></b></p>

<p>The underline text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f196948b-ee87-4d75-b20f-2860d3fa3a96'>Visible</a></td><td style='width:75%' class='def'><p><a name="f196948b-ee87-4d75-b20f-2860d3fa3a96"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Visible = <code>10</code></b></p>

<p>The visibility of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04914f33-535b-49bb-a759-ed5233dff49a'>Width</a></td><td style='width:75%' ><p><a name="04914f33-535b-49bb-a759-ed5233dff49a"></a>
<b>Public Static Constant <a href="#21392678-5537-4b2b-85a4-fdf9d0c4e6cc">KimonoCore.KimonoPropertyConnectionPoint</a> Width = <code>6</code></b></p>

<p>The Widht of a <code>KimonoShape</code> Bounds.</p>
</td></tr></table></p>


---

<a name="5f306371-0ebf-41e9-b6c1-7346aac7c98c"></a>
##Public Class KimonoPropertyGradient

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `KimonoGradient` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c6bbe5d9-49ce-49c7-9ee9-378f0a83930c'>IsObiScriptValue</a></td><td style='width:75%' ><p><a name="c6bbe5d9-49ce-49c7-9ee9-378f0a83930c"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsObiScriptValue</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#d6ae6723-ed8c-4d65-8e35-eabe2a6ee75e">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25c755de-cc34-43c2-8b7a-cea9773a0f6c'>Value</a></td><td style='width:75%' class='def'><p><a name="25c755de-cc34-43c2-8b7a-cea9773a0f6c"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoGradient</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#94db816c-1126-479e-92b4-e6115fca2ecb'>Clone</a></td><td style='width:75%' ><p><a name="94db816c-1126-479e-92b4-e6115fca2ecb"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6ebb6d7-e69f-4c3d-b792-08595f133a2c'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="d6ebb6d7-e69f-4c3d-b792-08595f133a2c"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c06b9f7-2499-48e0-977e-17e4c4f4222e'>KimonoPropertyGradient</a></td><td style='width:75%' ><p><a name="3c06b9f7-2499-48e0-977e-17e4c4f4222e"></a></p>

<h3>Public Void KimonoPropertyGradient ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6045055f-2b8d-4f63-ba1c-c5c7c2de9c3d">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1efc320c-ae6b-489d-8d95-5e72306e3e8c'>ToGradient</a></td><td style='width:75%' class='def'><p><a name="1efc320c-ae6b-489d-8d95-5e72306e3e8c"></a></p>

<h3>Public Virtual <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> ToGradient ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr></table></p>


---

<a name="7ff008ad-e46a-4336-bf6c-f17d13cd68ce"></a>
##Public Class KimonoPropertyNumber

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `float` or `int` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eb96e64c-55f4-4d02-be87-109a5fb49d22'>Value</a></td><td style='width:75%' ><p><a name="eb96e64c-55f4-4d02-be87-109a5fb49d22"></a></p>

<h3>Public <code>System.Single</code> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>float</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f4c0cf29-bce7-4207-a382-796531b701f0'>Clone</a></td><td style='width:75%' ><p><a name="f4c0cf29-bce7-4207-a382-796531b701f0"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#526de9e2-e2c9-4837-9e72-1f11588efdd2'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="526de9e2-e2c9-4837-9e72-1f11588efdd2"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cdba568-9177-49d8-80f2-f5238648cad2'>KimonoPropertyNumber</a></td><td style='width:75%' ><p><a name="8cdba568-9177-49d8-80f2-f5238648cad2"></a></p>

<h3>Public Void KimonoPropertyNumber ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7ff008ad-e46a-4336-bf6c-f17d13cd68ce">KimonoPropertyNumber</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0318223a-93b3-43c3-8717-4fbec77275dc'>ToFloat</a></td><td style='width:75%' class='def'><p><a name="0318223a-93b3-43c3-8717-4fbec77275dc"></a></p>

<h3>Public Virtual <code>System.Single</code> ToFloat ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9fb7ba8-611c-4238-8ebc-47cc16190ec2'>ToInt</a></td><td style='width:75%' ><p><a name="b9fb7ba8-611c-4238-8ebc-47cc16190ec2"></a></p>

<h3>Public Virtual <code>System.Int32</code> ToInt ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr></table></p>


---

<a name="043d525b-f140-4894-8e78-d7d54d6bfef7"></a>
##Public Class KimonoPropertyRect

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `SKRect`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9d37919f-fef8-4e6e-bb5a-0bad57ff9c67'>Value</a></td><td style='width:75%' ><p><a name="9d37919f-fef8-4e6e-bb5a-0bad57ff9c67"></a></p>

<h3>Public <code>SkiaSharp.SKRect</code> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value as a <code>SKRect</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b9c158e3-60b4-4e6b-8fca-e639607b1ef4'>Clone</a></td><td style='width:75%' ><p><a name="b9c158e3-60b4-4e6b-8fca-e639607b1ef4"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e780630-665c-4a40-9619-85264eda2c1a'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="5e780630-665c-4a40-9619-85264eda2c1a"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7571ede-9476-48cd-8c55-0327f7b8b865'>KimonoPropertyRect</a></td><td style='width:75%' ><p><a name="d7571ede-9476-48cd-8c55-0327f7b8b865"></a></p>

<h3>Public Void KimonoPropertyRect ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#043d525b-f140-4894-8e78-d7d54d6bfef7">KimonoPropertyRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51174a34-81ac-4bd6-8c7e-1c7cdfbe1697'>ToRect</a></td><td style='width:75%' class='def'><p><a name="51174a34-81ac-4bd6-8c7e-1c7cdfbe1697"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKRect</code> ToRect ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr></table></p>


---

<a name="3822fbc9-3bf3-45ad-84aa-889b20302673"></a>
##Public Class KimonoPropertyStyle

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#003d0d0c-2bce-454d-b37c-e7b32507ac19'>IsObiScriptValue</a></td><td style='width:75%' ><p><a name="003d0d0c-2bce-454d-b37c-e7b32507ac19"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsObiScriptValue</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#d6ae6723-ed8c-4d65-8e35-eabe2a6ee75e">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8a191e0-d697-42ad-b259-dc94ad99daa4'>Value</a></td><td style='width:75%' class='def'><p><a name="f8a191e0-d697-42ad-b259-dc94ad99daa4"></a></p>

<h3>Public <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e4a5d00d-c684-4b31-8ba0-10e9a44740b0'>Clone</a></td><td style='width:75%' ><p><a name="e4a5d00d-c684-4b31-8ba0-10e9a44740b0"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b997e629-c992-4d4f-b304-ff0a7806ecdc'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="b997e629-c992-4d4f-b304-ff0a7806ecdc"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1a86ed9a-fecf-4527-a36e-33cfbfac58dd'>KimonoPropertyStyle</a></td><td style='width:75%' ><p><a name="1a86ed9a-fecf-4527-a36e-33cfbfac58dd"></a></p>

<h3>Public Void KimonoPropertyStyle ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#3822fbc9-3bf3-45ad-84aa-889b20302673">KimonoPropertyStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3074b4b-8231-40b0-b7a7-72b4cec20c59'>ToStyle</a></td><td style='width:75%' class='def'><p><a name="f3074b4b-8231-40b0-b7a7-72b4cec20c59"></a></p>

<h3>Public Virtual <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> ToStyle ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr></table></p>


---

<a name="6045055f-2b8d-4f63-ba1c-c5c7c2de9c3d"></a>
##Public Class KimonoPropertyText

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoProperty](#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8)

###Summary

Defines a `KimonoProperty` that represents a `string` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f467e7f6-29a4-46fc-b41b-ce6a21e58174'>Value</a></td><td style='width:75%' ><p><a name="f467e7f6-29a4-46fc-b41b-ce6a21e58174"></a></p>

<h3>Public <code>System.String</code> Value</h3>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9cea4b4d-f909-469d-a8d8-88c6f1b62f79'>Clone</a></td><td style='width:75%' ><p><a name="9cea4b4d-f909-469d-a8d8-88c6f1b62f79"></a></p>

<h3>Public Virtual <a href="#0e9818ef-3d0a-4239-99b0-ccb9ceb18ef8">KimonoCore.KimonoProperty</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56b95e86-8ee3-45cc-9151-c9c0e2da4b79'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="56b95e86-8ee3-45cc-9151-c9c0e2da4b79"></a></p>

<h3>Public Virtual <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">KimonoCore.ObiScriptResult</a> Evaluate ()</h3>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a58fe5b1-694e-4ecf-9bd0-57d78af4fbe3'>KimonoPropertyText</a></td><td style='width:75%' ><p><a name="a58fe5b1-694e-4ecf-9bd0-57d78af4fbe3"></a></p>

<h3>Public Void KimonoPropertyText ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6045055f-2b8d-4f63-ba1c-c5c7c2de9c3d">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7bd36ce-2d4b-4a75-8baa-26919a107d83'>ToString</a></td><td style='width:75%' class='def'><p><a name="d7bd36ce-2d4b-4a75-8baa-26919a107d83"></a></p>

<h3>Public Virtual <code>System.String</code> ToString ()</h3>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>string</code>.</p>

<h4>Returns</h4>

<p>The <code>string</code> value.</p>
</td></tr></table></p>


---

<a name="cb396ef5-9a89-402d-9618-fe8fd5a6656d"></a>
##Public Enum KimonoPropertyUsage

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines how a `KimonoProperty` is used when it is attached to a `KimonoShape`, `KimonoSketch` or `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5f8e6e8d-ae66-41ed-aae8-d4c93a9b6b40'>GlobalVariable</a></td><td style='width:75%' ><p><a name="5f8e6e8d-ae66-41ed-aae8-d4c93a9b6b40"></a>
<b>Public Static Constant <a href="#cb396ef5-9a89-402d-9618-fe8fd5a6656d">KimonoCore.KimonoPropertyUsage</a> GlobalVariable = <code>1</code></b></p>

<p>The given <code>KimonoProperty</code> will be used as a global variable in the generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efae0380-4391-48a7-bdb0-390be73d3c17'>LocalVariable</a></td><td style='width:75%' class='def'><p><a name="efae0380-4391-48a7-bdb0-390be73d3c17"></a>
<b>Public Static Constant <a href="#cb396ef5-9a89-402d-9618-fe8fd5a6656d">KimonoCore.KimonoPropertyUsage</a> LocalVariable = <code>0</code></b></p>

<p>The given <code>KimonoProperty</code> will be used as a local variable in the  generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48c4d3f4-a7f6-43c5-a3ce-77620f3a6e71'>Parameter</a></td><td style='width:75%' ><p><a name="48c4d3f4-a7f6-43c5-a3ce-77620f3a6e71"></a>
<b>Public Static Constant <a href="#cb396ef5-9a89-402d-9618-fe8fd5a6656d">KimonoCore.KimonoPropertyUsage</a> Parameter = <code>2</code></b></p>

<p>The given <code>KimonoProperty</code> will be used as a passed parameter in the generated code for a Kimono object.</p>
</td></tr></table></p>


---

<a name="aed70957-92e3-45b9-85a6-31d4dc128ed2"></a>
##Public Class KimonoShadow

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines a shadow effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f6a93ff6-72da-46ca-b81c-e33ccf3eba0d'>_color</a></td><td style='width:75%' ><p><a name="f6a93ff6-72da-46ca-b81c-e33ccf3eba0d"></a>
<b>Private <code>SkiaSharp.SKColor</code> _color</b></p>

<p>The color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa125d2d-637b-4f11-9e07-3048e031ee36'>_horizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="aa125d2d-637b-4f11-9e07-3048e031ee36"></a>
<b>Private <code>System.Single</code> _horizontalBlurAmount</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc94ae82-1f4e-4776-9206-8e5cb2a6e2b4'>_horizontalOffset</a></td><td style='width:75%' ><p><a name="fc94ae82-1f4e-4776-9206-8e5cb2a6e2b4"></a>
<b>Public <code>System.Single</code> _horizontalOffset</b></p>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a16cbc1-e3c7-4e9f-91a7-52bedd605f68'>_linkedColor</a></td><td style='width:75%' class='def'><p><a name="7a16cbc1-e3c7-4e9f-91a7-52bedd605f68"></a>
<b>Private <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> _linkedColor</b></p>

<p>A linked <code>KimonoColor</code> to use as the shadow color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a537453-6c91-47e2-aaf5-60cee3248c16'>_verticalBlurAmount</a></td><td style='width:75%' ><p><a name="5a537453-6c91-47e2-aaf5-60cee3248c16"></a>
<b>Private <code>System.Single</code> _verticalBlurAmount</b></p>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48c83e38-ccca-4ee5-83d2-c8148cf2f838'>_verticalOffset</a></td><td style='width:75%' class='def'><p><a name="48c83e38-ccca-4ee5-83d2-c8148cf2f838"></a>
<b>Public <code>System.Single</code> _verticalOffset</b></p>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e1363dc-26ce-4ff5-955f-d52ca36e019a'>ShadowModified</a></td><td style='width:75%' ><p><a name="2e1363dc-26ce-4ff5-955f-d52ca36e019a"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ShadowModified</b></p>

<p>The private <code>ShadowModified</code> field of the <code>KimonoShadow</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#14b35ec1-7fa1-4b0f-af19-298922b64c86'>Color</a></td><td style='width:75%' ><p><a name="14b35ec1-7fa1-4b0f-af19-298922b64c86"></a></p>

<h3>Public <code>SkiaSharp.SKColor</code> Color</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93a313cb-51c0-40df-91c1-116cf01ece79'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="93a313cb-51c0-40df-91c1-116cf01ece79"></a></p>

<h3>Public <code>System.Single</code> HorizontalBlurAmount</h3>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed7e4e67-7cbf-4377-9c4d-3074ee45d8f3'>HorizontalOffset</a></td><td style='width:75%' ><p><a name="ed7e4e67-7cbf-4377-9c4d-3074ee45d8f3"></a></p>

<h3>Public <code>System.Single</code> HorizontalOffset</h3>

<h4>Summary</h4>

<p>Gets or sets the horizontal offset.</p>

<h4>Return Value</h4>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30048cd8-8279-4fbd-ba96-4882e5675727'>LinkedColor</a></td><td style='width:75%' class='def'><p><a name="30048cd8-8279-4fbd-ba96-4882e5675727"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> LinkedColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the linked.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f738359-a5c1-4815-908d-b7352182f34e'>Name</a></td><td style='width:75%' ><p><a name="4f738359-a5c1-4815-908d-b7352182f34e"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4761d6b4-5fda-4c9c-bbd1-4b2b6b04f0a6'>ShadowColor</a></td><td style='width:75%' class='def'><p><a name="4761d6b4-5fda-4c9c-bbd1-4b2b6b04f0a6"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKColor</code> ShadowColor</h3>

<h4>Summary</h4>

<p>Gets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color of the shadow as a <code>SKColor</code>.</p>

<h4>Remarks</h4>

<p>Returns either the custom color attached to this shadow or a linked color if it is being used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6edcd9e-7149-4bf4-986e-03f2ae9d70d0'>ShadowFilter</a></td><td style='width:75%' ><p><a name="b6edcd9e-7149-4bf4-986e-03f2ae9d70d0"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKImageFilter</code> ShadowFilter</h3>

<h4>Summary</h4>

<p>Gets the shadoe filter represented by this shadow effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c3b4e30-e677-4a3a-866b-231274e98769'>VerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="7c3b4e30-e677-4a3a-866b-231274e98769"></a></p>

<h3>Public <code>System.Single</code> VerticalBlurAmount</h3>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e21d0bb-c7ac-4c4b-ba92-164c42c43d80'>VerticalOffset</a></td><td style='width:75%' ><p><a name="1e21d0bb-c7ac-4c4b-ba92-164c42c43d80"></a></p>

<h3>Public <code>System.Single</code> VerticalOffset</h3>

<h4>Summary</h4>

<p>Gets or sets the vertical offset.</p>

<h4>Return Value</h4>

<p>The vertical offset.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cd6284aa-dc27-4ece-92db-0e2e6bb2df64'>Clone</a></td><td style='width:75%' ><p><a name="cd6284aa-dc27-4ece-92db-0e2e6bb2df64"></a></p>

<h3>Public <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoCore.KimonoShadow</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af24869e-48ec-40ca-881d-291469de5f48'>HandleLinkedColorChanged</a></td><td style='width:75%' class='def'><p><a name="af24869e-48ec-40ca-881d-291469de5f48"></a></p>

<h3>Private Void HandleLinkedColorChanged ()</h3>

<h4>Summary</h4>

<p>Handles the linked color changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67c343c9-a42c-41bb-b5d4-40fae081761d'>KimonoShadow</a></td><td style='width:75%' ><p><a name="67c343c9-a42c-41bb-b5d4-40fae081761d"></a></p>

<h3>Public Void KimonoShadow ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2806495c-07f3-4afc-8e29-b46d1faf1299'>KimonoShadow</a></td><td style='width:75%' class='def'><p><a name="2806495c-07f3-4afc-8e29-b46d1faf1299"></a></p>

<h3>Public Void KimonoShadow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoShadow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalOffset</td><td style='width:75%' ><p><a name="4a1c5a07-e9b4-4db0-b481-f2dd8f1523bc"></a>
<b>System.Single horizontalOffset</b></p>

<p>Horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' class='def'><p><a name="c1a00178-406f-40e4-947d-2b5616c9fedb"></a>
<b>System.Single horizontalBlurAmount</b></p>

<p>Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalOffset</td><td style='width:75%' ><p><a name="2302848d-5d9e-4f54-8c83-589adf887796"></a>
<b>System.Single verticalOffset</b></p>

<p>Vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="ff62715d-02a1-4770-bb03-2157ce36e383"></a>
<b>System.Single verticalBlurAmount</b></p>

<p>Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8766a7d-7072-4863-905b-2085e4a77c7f'>RaiseShadowModified</a></td><td style='width:75%' ><p><a name="b8766a7d-7072-4863-905b-2085e4a77c7f"></a></p>

<h3>Void RaiseShadowModified ()</h3>

<h4>Summary</h4>

<p>Raises the shadow modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68f1c901-18af-43df-a501-beeae2d1b45a'>ToCode</a></td><td style='width:75%' class='def'><p><a name="68f1c901-18af-43df-a501-beeae2d1b45a"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="eea685f0-7fd0-4a5e-8ae2-989e3f201fea"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="72d0a9f1-d31a-4bdd-bbfe-0de7241d683e"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8e1c968a-23e2-4b61-8cbc-f7c82300db0e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62c8ca9d-7615-4b54-ae4d-f2bcb54e8a2a'>ToCSharp</a></td><td style='width:75%' ><p><a name="62c8ca9d-7615-4b54-ae4d-f2bcb54e8a2a"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0f880250-4148-4e27-abbf-c39af2467e87"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd3e14a1-40e2-41f9-a6b3-fb27d69cc159'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="fd3e14a1-40e2-41f9-a6b3-fb27d69cc159"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d350676-b171-4930-929a-877d0978695d'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="2d350676-b171-4930-929a-877d0978695d"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb8a2b4c-c023-431e-a571-fd9f958d4178'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="fb8a2b4c-c023-431e-a571-fd9f958d4178"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eabcc991-60bd-4879-b8fb-32eab43f5431'>ShadowModified</a></td><td style='width:75%' ><p><a name="eabcc991-60bd-4879-b8fb-32eab43f5431"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ShadowModified</h3>

<h4>Summary</h4>

<p>Occurs when the shadow is modified.</p>
</td></tr></table></p>


---

<a name="f0af74e3-5275-47e0-9ddb-991cda8b3f33"></a>
##Public Class KimonoShape

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoBounds](#1d07eefe-b52f-4276-a1c9-970a91ec6517)

###Summary

Defines the based shape that all other Kimono Shape types will inherit from.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e5e21f5a-6b79-4921-b6ca-1f770706ff2a'>_name</a></td><td style='width:75%' ><p><a name="e5e21f5a-6b79-4921-b6ca-1f770706ff2a"></a>
<b>Private <code>System.String</code> _name</b></p>

<p>The default name of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93af09a0-b5ed-4f86-8fcc-94cf23ecddbb'>_style</a></td><td style='width:75%' class='def'><p><a name="93af09a0-b5ed-4f86-8fcc-94cf23ecddbb"></a>
<b><a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> _style</b></p>

<p>The default, custom <code>KimonoStyle</code> that is attached to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d948d90-c178-4e8c-b12d-cdc3acef0963'>_visible</a></td><td style='width:75%' ><p><a name="4d948d90-c178-4e8c-b12d-cdc3acef0963"></a>
<b><code>System.Boolean</code> _visible</b></p>

<p>The visibility of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#41933ab1-56d8-4125-b393-1103ec62716e'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="41933ab1-56d8-4125-b393-1103ec62716e"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30436636-286d-4484-a750-a8c2aeb8df5b'>ControlPoints</a></td><td style='width:75%' class='def'><p><a name="30436636-286d-4484-a750-a8c2aeb8df5b"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoHandle&gt;</code> ControlPoints</h3>

<h4>Summary</h4>

<p>Gets or sets the control points that define the path of the shape.</p>

<h4>Return Value</h4>

<p>A collection of <code>KimonoHandle</code> objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f60411c-f5e2-46c0-9520-04339c2d7995'>ElementName</a></td><td style='width:75%' ><p><a name="9f60411c-f5e2-46c0-9520-04339c2d7995"></a></p>

<h3>Private <code>System.String</code> ElementName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f2e0f25-27cb-4431-aef7-95fadda56f29'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="0f2e0f25-27cb-4431-aef7-95fadda56f29"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsEditable</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoShape</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>An "Editable Shape" is one that is composed of a set of data points (such as <code>KimonoVector</code> or <code>KimonoBezier</code>) or a group of objects (such as <code>KimonoShapeGroup</code>).</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7486a1b1-84d3-4e88-a4ef-08b8bb22956a'>LayerDepth</a></td><td style='width:75%' ><p><a name="7486a1b1-84d3-4e88-a4ef-08b8bb22956a"></a></p>

<h3>Public <code>System.Int32</code> LayerDepth</h3>

<h4>Summary</h4>

<p>Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.</p>

<h4>Return Value</h4>

<p>The layer depth.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#130c9ac3-4536-4dc1-9e2e-c7d5bcd841d4'>Name</a></td><td style='width:75%' class='def'><p><a name="130c9ac3-4536-4dc1-9e2e-c7d5bcd841d4"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6433cc28-cfcb-4424-82df-2916959bf2ae'>PropertyConnections</a></td><td style='width:75%' ><p><a name="6433cc28-cfcb-4424-82df-2916959bf2ae"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPropertyConnection&gt;</code> PropertyConnections</h3>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#000e5a33-766b-4b40-a341-b38cc3e2f37c'>Style</a></td><td style='width:75%' class='def'><p><a name="000e5a33-766b-4b40-a341-b38cc3e2f37c"></a></p>

<h3>Public Virtual <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> Style</h3>

<h4>Summary</h4>

<p>Gets or sets the style.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> that will be used to draw this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bdb37ae-0d99-472e-a4f7-5e6822293dde'>Visible</a></td><td style='width:75%' ><p><a name="6bdb37ae-0d99-472e-a4f7-5e6822293dde"></a></p>

<h3>Public Virtual <code>System.Boolean</code> Visible</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoShape</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c160e1e1-730a-4997-a1f0-5647b26bbc72'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="c160e1e1-730a-4997-a1f0-5647b26bbc72"></a></p>

<h3>Public Virtual Void AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="61136890-e1cc-49fd-a001-a0a49b87937a"></a>
<b>KimonoCore.KimonoPropertyConnectionPoint connectionPoint</b></p>

<p>The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="b46b9d42-1767-49df-8bd9-a51a8111b35f"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe016269-9f67-4571-bc88-6dd1530e125d'>CalculateConfromingGradientCoordinates</a></td><td style='width:75%' class='def'><p><a name="fe016269-9f67-4571-bc88-6dd1530e125d"></a></p>

<h3>Public Virtual Void CalculateConfromingGradientCoordinates (KimonoCore.KimonoGradient, SkiaSharp.SKPoint&amp;, SkiaSharp.SKPoint&amp;)</h3>

<h4>Summary</h4>

<p>The public virtual <code>CalculateConfromingGradientCoordinates (KimonoCore.KimonoGradient, SkiaSharp.SKPoint&amp;, SkiaSharp.SKPoint&amp;)</code> member of the <code>KimonoShape</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="e6018fe5-e2ab-46fe-be21-ef275d124720"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>gradient</code> parameter of the CalculateConfromingGradientCoordinates method takes a <code>KimonoCore.KimonoGradient</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref startPoint</td><td style='width:75%' class='def'><p><a name="a9a46688-5c80-4f12-9f29-a500d459e1f5"></a>
<b>SkiaSharp.SKPoint Out Ref startPoint</b></p>

<p>The <code>startPoint</code> parameter of the CalculateConfromingGradientCoordinates method takes a <code>SkiaSharp.SKPoint&amp;</code> value. Since <code>startPoint</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>startPoint</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref endPoint</td><td style='width:75%' ><p><a name="0ae3bbb7-4f33-465b-9fe2-1aea32442967"></a>
<b>SkiaSharp.SKPoint Out Ref endPoint</b></p>

<p>The <code>endPoint</code> parameter of the CalculateConfromingGradientCoordinates method takes a <code>SkiaSharp.SKPoint&amp;</code> value. Since <code>endPoint</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>out</code> modifier.Since <code>endPoint</code> returns any modifications to the caller, it <em>must</em> be passed with the <code>ref</code> modifier.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3b133a9-8f69-4ae7-8375-d37d8ed699fd'>Clone</a></td><td style='width:75%' ><p><a name="c3b133a9-8f69-4ae7-8375-d37d8ed699fd"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of this shape as a base <code>KimonoBounds</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ff46538-cb45-4fef-9c39-9e73d25730c7'>CloneAttachedStyle</a></td><td style='width:75%' class='def'><p><a name="4ff46538-cb45-4fef-9c39-9e73d25730c7"></a></p>

<h3><a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> CloneAttachedStyle ()</h3>

<h4>Summary</h4>

<p>Clones the attached style.</p>

<h4>Returns</h4>

<p>A duplicate <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c99f8ec-fbae-490a-8d6a-40970f63e44a'>ConformedFillGradientCode</a></td><td style='width:75%' ><p><a name="5c99f8ec-fbae-490a-8d6a-40970f63e44a"></a></p>

<h3>Public <code>System.String</code> ConformedFillGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="59936a3a-94fd-455f-b334-a6ef2eb69035"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The fill gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5b3ff7c-565c-46f2-bbf0-e3710d72ed69'>ConformedFrameGradientCode</a></td><td style='width:75%' class='def'><p><a name="d5b3ff7c-565c-46f2-bbf0-e3710d72ed69"></a></p>

<h3>Public <code>System.String</code> ConformedFrameGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c723c295-777d-4d49-84b1-a34a67d4bf52"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The frame gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e877fba-0245-4e55-8e9b-b8350858e4cc'>ConformGradientToShape</a></td><td style='width:75%' ><p><a name="9e877fba-0245-4e55-8e9b-b8350858e4cc"></a></p>

<h3>Public Virtual Void ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)</h3>

<h4>Summary</h4>

<p>Conforms the gradient to shape by fitting it to the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="f0ab864c-1ea8-4dc6-9435-3cab0850a84b"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to conform.</p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p><a name="dd5e4048-c57c-4461-b006-44a9f10f79aa"></a>
<b>SkiaSharp.SKPaint paint</b></p>

<p>The <code>SKPaint</code> that the gradient is being attached to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89d71c39-0a78-47ff-ba48-9d7e66df5652'>EndEditing</a></td><td style='width:75%' class='def'><p><a name="89d71c39-0a78-47ff-ba48-9d7e66df5652"></a></p>

<h3>Public Virtual Void EndEditing ()</h3>

<h4>Summary</h4>

<p>Ends the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4b0eab2-ada6-4a03-a246-2b1394844622'>EvaluateConnectedProperties</a></td><td style='width:75%' ><p><a name="e4b0eab2-ada6-4a03-a246-2b1394844622"></a></p>

<h3>Public Virtual Void EvaluateConnectedProperties ()</h3>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoShape</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e6a6e79-0b18-4612-bbe9-0918c2bd62a4'>Initialize</a></td><td style='width:75%' class='def'><p><a name="2e6a6e79-0b18-4612-bbe9-0918c2bd62a4"></a></p>

<h3>Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc24ff8d-7521-4fb6-a0eb-b7fd2013f92f'>KimonoShape</a></td><td style='width:75%' ><p><a name="dc24ff8d-7521-4fb6-a0eb-b7fd2013f92f"></a></p>

<h3>Public Void KimonoShape ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab3f0fbc-59e8-45b0-98c7-0240a2850233'>KimonoShape</a></td><td style='width:75%' class='def'><p><a name="ab3f0fbc-59e8-45b0-98c7-0240a2850233"></a></p>

<h3>Public Void KimonoShape (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="67c52bd2-c9e6-40e8-9d60-433102970107"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="ca7156cc-286b-47c3-9182-3320f1fdc5f5"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="990c75ca-541e-452a-b33c-dcf98618de66"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="489efaea-43dd-4da2-b56b-235d9dacc9cc"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d314e7b-6876-4303-82b4-e5be4227bfcb'>KimonoShape</a></td><td style='width:75%' ><p><a name="6d314e7b-6876-4303-82b4-e5be4227bfcb"></a></p>

<h3>Public Void KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="89447bc0-d616-4255-9ce1-463b2c5e7834"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="d7762b8d-bf1b-4198-8cd0-9bf495624bb0"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d058883f-7a61-4c7b-9a78-b3a7463c401d"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a4399712-3a34-4ea8-b646-6cf379e067de"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="593e72d7-4b7e-4397-8594-3e54bf2156d2"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddbe63b6-e4e2-4962-9ebb-f5ce43dcbbf6'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="ddbe63b6-e4e2-4962-9ebb-f5ce43dcbbf6"></a></p>

<h3>Public Virtual Void RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="8f68d594-4790-454a-a66b-aceb3d7e6541"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cacc7c57-d525-426a-b12a-827ac92a5d58'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="cacc7c57-d525-426a-b12a-827ac92a5d58"></a></p>

<h3>Public Virtual Void RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="d611b9e2-5380-4de8-9a05-e10c6a3a73d6"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a461848-ec54-4e3e-b1f6-d8b0711a1204'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="4a461848-ec54-4e3e-b1f6-d8b0711a1204"></a></p>

<h3>Public Virtual Void StartEditing ()</h3>

<h4>Summary</h4>

<p>Places the shape in the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e73de071-ae2c-4e83-b32e-dd9cb2cab694'>StyleFillPaintForCode</a></td><td style='width:75%' ><p><a name="e73de071-ae2c-4e83-b32e-dd9cb2cab694"></a></p>

<h3>Public <code>System.String</code> StyleFillPaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Gets the style fill paint for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="62793476-4293-480b-9afa-db5bc5a715c7"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputLibrary</code> parameter of the StyleFillPaintForCode method takes a <code>KimonoCore.CodeOutputLibrary</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#579bbcac-d035-4801-a47e-b8354f1a9df1'>StyleFramePaintForCode</a></td><td style='width:75%' class='def'><p><a name="579bbcac-d035-4801-a47e-b8354f1a9df1"></a></p>

<h3>Public <code>System.String</code> StyleFramePaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Gets the style frame paint for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2f60ac99-dd65-495e-9086-889a6c7533ee"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputLibrary</code> parameter of the StyleFramePaintForCode method takes a <code>KimonoCore.CodeOutputLibrary</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ca3e3b3-feff-4231-b2f9-1937190f142f'>ToCode</a></td><td style='width:75%' ><p><a name="6ca3e3b3-feff-4231-b2f9-1937190f142f"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="e1d693ca-c437-46c6-b089-9e08a1092523"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e2857f84-227c-4f30-9ec8-3d67f86589f0"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="428e0530-fb86-48e9-9b90-5d4897317bf7"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#928ecb4e-ab2b-463c-8e0e-fedd7b0454db'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="928ecb4e-ab2b-463c-8e0e-fedd7b0454db"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="062dee05-ebbe-4bf6-a825-6f97497ca3d4"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3bb200d-bb03-4eec-8d1c-82843b56cfdb'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="a3bb200d-bb03-4eec-8d1c-82843b56cfdb"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#980dd8ee-7267-4a59-b30b-436912833c9e'>ToPath</a></td><td style='width:75%' class='def'><p><a name="980dd8ee-7267-4a59-b30b-436912833c9e"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6646784-2002-4a02-a551-bbc1e9dd1306'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="e6646784-2002-4a02-a551-bbc1e9dd1306"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7680972-e2a9-4aa6-bf6d-c4378843085f'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="b7680972-e2a9-4aa6-bf6d-c4378843085f"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a4c4e52-1ba8-4d06-82f5-7df42a8daa29'>ToVector</a></td><td style='width:75%' ><p><a name="5a4c4e52-1ba8-4d06-82f5-7df42a8daa29"></a></p>

<h3>Public Virtual <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoCore.KimonoShapeVector</a> ToVector ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a vector.</p>

<h4>Returns</h4>

<p>The shape as a <code>KimonoVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52a201dd-1be4-4a01-af1c-7686c95063a6'>UncoupleDeletedStyle</a></td><td style='width:75%' class='def'><p><a name="52a201dd-1be4-4a01-af1c-7686c95063a6"></a></p>

<h3>Public Virtual Void UncoupleDeletedStyle (KimonoCore.KimonoStyle)</h3>

<h4>Summary</h4>

<p>Uncouples the deleted style from the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p><a name="98e1e937-f9b2-45a0-ab0b-f14941fc7ea9"></a>
<b>KimonoCore.KimonoStyle deletedStyle</b></p>

<p>The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cbd21cf-efee-40c8-95b6-140526eb0868'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="1cbd21cf-efee-40c8-95b6-140526eb0868"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="b3ed7a9e-9383-4ede-83db-fae0651c84e7"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="cc400c8a-7bc7-4da4-8328-b838796d0162"></a>
##Public Class KimonoShapeArrow

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws either an outlined or single line arrow with heads on one or both ends.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a291d54d-b876-4b9e-a5a6-83c18fdba4e0'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="a291d54d-b876-4b9e-a5a6-83c18fdba4e0"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d00dbe9-d68a-4846-a9bb-1772559adcc4'>HasEndHead</a></td><td style='width:75%' class='def'><p><a name="9d00dbe9-d68a-4846-a9bb-1772559adcc4"></a></p>

<h3>Public <code>System.Boolean</code> HasEndHead</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#cc400c8a-7bc7-4da4-8328-b838796d0162">KimonoShapeArrow</a> has end head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has end head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dc85fa8-8e45-4f70-8f23-c497f6dab250'>HasStartHead</a></td><td style='width:75%' ><p><a name="2dc85fa8-8e45-4f70-8f23-c497f6dab250"></a></p>

<h3>Public <code>System.Boolean</code> HasStartHead</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#cc400c8a-7bc7-4da4-8328-b838796d0162">KimonoShapeArrow</a> has start head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has start head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a969946-07ab-4f14-9ff7-d567aef37122'>HeadInnerRatio</a></td><td style='width:75%' class='def'><p><a name="7a969946-07ab-4f14-9ff7-d567aef37122"></a></p>

<h3>Public <code>System.Single</code> HeadInnerRatio</h3>

<h4>Summary</h4>

<p>Gets or sets the head inner ratio.</p>

<h4>Return Value</h4>

<p>The head inner ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e52e075-ee41-4100-8966-a0882e9c487f'>HeadOuterRatio</a></td><td style='width:75%' ><p><a name="5e52e075-ee41-4100-8966-a0882e9c487f"></a></p>

<h3>Public <code>System.Single</code> HeadOuterRatio</h3>

<h4>Summary</h4>

<p>Gets or sets the head outer ratio.</p>

<h4>Return Value</h4>

<p>The head outer ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab309cfd-4bba-483b-93ef-aee1d5ec113e'>IsStreamlined</a></td><td style='width:75%' class='def'><p><a name="ab309cfd-4bba-483b-93ef-aee1d5ec113e"></a></p>

<h3>Public <code>System.Boolean</code> IsStreamlined</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#cc400c8a-7bc7-4da4-8328-b838796d0162">KimonoShapeArrow</a> is streamlined.</p>

<h4>Return Value</h4>

<p><code>true</code> if is streamlined; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>A Streamlined Arrow, is drawn as a single line.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#238936ff-6561-4215-b912-8e0e0ddaf20a'>Clone</a></td><td style='width:75%' ><p><a name="238936ff-6561-4215-b912-8e0e0ddaf20a"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c744af9-e148-4892-8e7d-a2fd3bc81565'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="8c744af9-e148-4892-8e7d-a2fd3bc81565"></a></p>

<h3>Public Virtual Void DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the bounds of the arrow to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="cb04c045-c292-4b4a-817f-57faa0696395"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> specifying the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b686e6b2-53b6-4c0d-9fec-61aee98756ce'>Draw</a></td><td style='width:75%' ><p><a name="b686e6b2-53b6-4c0d-9fec-61aee98756ce"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the arrow into the specified Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="0d3b2897-bd08-42f0-a679-84141eab072a"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eedbb439-6c33-4b85-b6a1-eb31279a7cb2'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="eedbb439-6c33-4b85-b6a1-eb31279a7cb2"></a></p>

<h3>Public Virtual Void GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Grows the bounds of the arrow.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d0ce51b8-8acc-4588-b28c-77ea3f0b2297"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> containing the bounds adjustment.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41092d64-86ce-4102-939d-98fd506931da'>Initialize</a></td><td style='width:75%' ><p><a name="41092d64-86ce-4102-939d-98fd506931da"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0dddb03-1439-46e9-98df-ee2b1be5c396'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p><a name="d0dddb03-1439-46e9-98df-ee2b1be5c396"></a></p>

<h3>Public Void KimonoShapeArrow ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cc400c8a-7bc7-4da4-8328-b838796d0162">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#420108d4-66be-4028-9797-8c5661f38e41'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="420108d4-66be-4028-9797-8c5661f38e41"></a></p>

<h3>Public Void KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cc400c8a-7bc7-4da4-8328-b838796d0162">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="e7543dae-a078-4e09-8e28-013b10edd73d"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="b92c35e8-765b-455b-94e2-4b7a72cb19fc"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="5ae9d8bd-2010-4f07-8494-c72e7b896426"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="6366200e-937d-4f3c-ad1f-4d3d25018c14"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00eb82c0-174a-42f5-948b-ec62ddb49a74'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p><a name="00eb82c0-174a-42f5-948b-ec62ddb49a74"></a></p>

<h3>Public Void KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#cc400c8a-7bc7-4da4-8328-b838796d0162">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="128025b5-76ce-4313-bdcc-8a779f12e2ea"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="fbb4df4a-c39b-42d3-a3f1-f7c45d6b8f93"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="a888e64f-d471-40c5-b8e6-94464faf2400"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="df98bd46-1660-408d-a940-601864197676"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="0a01f23f-c558-410e-bb5b-f01bf6113e49"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd4e3efd-2d33-42f9-bd4f-8de31270635e'>ToCode</a></td><td style='width:75%' ><p><a name="cd4e3efd-2d33-42f9-bd4f-8de31270635e"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="74ded9f0-33a4-4edb-9f67-f4cc02622999"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5185df37-09fb-4706-98e4-807179087790"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="017feea1-ff67-4787-b03b-a0edb8aac614"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bbb5864-8462-4d61-b5a3-39883987c7d5'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="9bbb5864-8462-4d61-b5a3-39883987c7d5"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="611219d9-4923-43d2-8835-1e9bc4fe7f0c"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b10bc283-b0ce-490c-9277-cbfcf8b436b7'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="b10bc283-b0ce-490c-9277-cbfcf8b436b7"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e907271a-0e20-44a7-b142-3e2d567f9803'>ToPath</a></td><td style='width:75%' class='def'><p><a name="e907271a-0e20-44a7-b142-3e2d567f9803"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the arrow to a path.</p>

<h4>Returns</h4>

<p>The the arrow as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#befd41d7-afd1-43ca-8596-0030eacfe71a'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="befd41d7-afd1-43ca-8596-0030eacfe71a"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#302238b6-a2e5-4602-9cb9-57cc375da147'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="302238b6-a2e5-4602-9cb9-57cc375da147"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8110afb4-7a43-4150-b8f0-706d53e15213'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="8110afb4-7a43-4150-b8f0-706d53e15213"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="454d97b9-f928-4c82-8b2f-49761531c4be"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="85aeca05-c3f1-4a14-87ee-2fe4aed6e686"></a>
##Public Class KimonoShapeBezier

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#697a2a21-20e1-41bd-b3fc-2bf0e19d2089'>Closed</a></td><td style='width:75%' ><p><a name="697a2a21-20e1-41bd-b3fc-2bf0e19d2089"></a></p>

<h3>Public <code>System.Boolean</code> Closed</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b01c3e3-52fa-4e7a-94a4-514d47ce7b32'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="3b01c3e3-52fa-4e7a-94a4-514d47ce7b32"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsEditable</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2bc05c7-4e19-478d-a3f9-b46955bb0ff5'>LastPoint</a></td><td style='width:75%' ><p><a name="b2bc05c7-4e19-478d-a3f9-b46955bb0ff5"></a></p>

<h3>Public Read Only <a href="#d8b5b56c-78f6-4f82-b077-e2c3f8ad63bb">KimonoCore.KimonoBezierPoint</a> LastPoint</h3>

<h4>Summary</h4>

<p>Gets the last point in the collection of control points.</p>

<h4>Return Value</h4>

<p>The last point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83f125f3-d74c-447e-87fd-c6a08de31098'>Points</a></td><td style='width:75%' class='def'><p><a name="83f125f3-d74c-447e-87fd-c6a08de31098"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoBezierPoint&gt;</code> Points</h3>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0b9b89a9-f9e2-4157-aa94-5c3bbcfd753d'>AddHandlesForPoint</a></td><td style='width:75%' ><p><a name="0b9b89a9-f9e2-4157-aa94-5c3bbcfd753d"></a></p>

<h3>Public Void AddHandlesForPoint (System.Int32, KimonoCore.KimonoBezierPoint)</h3>

<h4>Summary</h4>

<p>Adds the handles for the given bezier point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="b3805175-e618-4d83-8bdc-4f0e8376716d"></a>
<b>System.Int32 index</b></p>

<p>The index of the <code>KimonoBezierPoint</code> that handles are being created for.</p>
</td></tr><tr><td style='width:25%' class='term'>bezierPoint</td><td style='width:75%' class='def'><p><a name="6961dd87-5aa7-4244-ad6f-bf201009587b"></a>
<b>KimonoCore.KimonoBezierPoint bezierPoint</b></p>

<p>The <code>KimonoBezierPoint</code> that is getting handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5c09d532-8014-4ea0-a277-0ede3bd5ffc5'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="5c09d532-8014-4ea0-a277-0ede3bd5ffc5"></a></p>

<h3>Public Void AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="bce19cd1-3464-4176-a9cd-b8471d1a2561"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee9e6595-413a-48f7-b3d6-f147aed993d1'>AddPoint</a></td><td style='width:75%' ><p><a name="ee9e6595-413a-48f7-b3d6-f147aed993d1"></a></p>

<h3>Public Void AddPoint (System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="f8eac865-7d15-4ad7-86af-56647dd0ac31"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="c2c747ae-94ce-44e2-bd1d-c19c9d240877"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#addc1c48-bc2b-4376-b287-50f4ab6291cd'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="addc1c48-bc2b-4376-b287-50f4ab6291cd"></a></p>

<h3>Public Void AddPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Adds the point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="36082beb-b270-4033-8491-57b1472acf21"></a>
<b>System.Single controlX</b></p>

<p>Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="2e2fd61b-f28d-4500-bed3-13abea175ff5"></a>
<b>System.Single controlY</b></p>

<p>Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="303c35e0-09cb-43bd-9cc0-ebb14525d136"></a>
<b>System.Single endX</b></p>

<p>End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="6e148720-c8af-4a39-9f3b-63a265b25368"></a>
<b>System.Single endY</b></p>

<p>End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27c76f3e-78a9-4640-9564-f62ecbd47ddd'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="27c76f3e-78a9-4640-9564-f62ecbd47ddd"></a></p>

<h3>Private Void ApplyMoveAndScale ()</h3>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d7a56de-2d59-427d-ac19-34df52b132ec'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="5d7a56de-2d59-427d-ac19-34df52b132ec"></a></p>

<h3>Public Virtual Void BoundsChanged ()</h3>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab160dd5-9a5a-44ab-b977-200d8196218c'>Clone</a></td><td style='width:75%' ><p><a name="ab160dd5-9a5a-44ab-b977-200d8196218c"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b674eff-ada5-455d-89c9-200864848fad'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="4b674eff-ada5-455d-89c9-200864848fad"></a></p>

<h3>Public Virtual Void DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="e2311f60-db81-457e-b941-cf447f3d1614"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22ac2b6e-bbb7-4665-a97b-658f827ed446'>Draw</a></td><td style='width:75%' ><p><a name="22ac2b6e-bbb7-4665-a97b-658f827ed446"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="310210a4-47d3-4681-a3c0-cdb2f9fa09a8"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fc0ccac-0dfb-4c08-8c77-33433cb78071'>Initialize</a></td><td style='width:75%' class='def'><p><a name="8fc0ccac-0dfb-4c08-8c77-33433cb78071"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd7d169f-4398-4d85-ac43-d009aec43945'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="fd7d169f-4398-4d85-ac43-d009aec43945"></a></p>

<h3>Public Void KimonoShapeBezier ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#85aeca05-c3f1-4a14-87ee-2fe4aed6e686">KimonoShapeBezier</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#751ca8c8-90e2-43cd-98b0-c301303048d7'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p><a name="751ca8c8-90e2-43cd-98b0-c301303048d7"></a></p>

<h3>Public Void KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#85aeca05-c3f1-4a14-87ee-2fe4aed6e686">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="fcae851f-5427-4357-8ca1-60127523430a"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="27a6b42f-55a5-4d9b-bf87-0dfba9dee6cb"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="45554b7f-1fa7-4ef5-835c-6d82d8409c3d"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f00b22b4-7446-443e-b876-67bb170cbf03"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfaa0af2-488a-48db-a517-a941545c767d'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="dfaa0af2-488a-48db-a517-a941545c767d"></a></p>

<h3>Public Void KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#85aeca05-c3f1-4a14-87ee-2fe4aed6e686">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f64e5671-baa4-47b1-997d-a3e19b5ac913"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c3cc0601-b3d0-4c1e-ba2b-3a25280649b6"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="40550efa-6d33-492c-b7e0-75ec7a662212"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1c481662-c50b-4119-9bbe-30f4e47daea3"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="ce7baebd-29a4-457d-8bee-34926cf9cb3c"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c1847a0-00e9-4577-8f1c-c1110ab99f82'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="8c1847a0-00e9-4577-8f1c-c1110ab99f82"></a></p>

<h3>Public Void MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d255ec96-8d6e-48d4-b852-c2792b2d0643"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a499a426-9a80-42ac-81da-55e6213b96f0'>PointInBound</a></td><td style='width:75%' ><p><a name="a499a426-9a80-42ac-81da-55e6213b96f0"></a></p>

<h3>Public Virtual <code>System.Boolean</code> PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ef3b9517-fa51-49a9-b7fd-d6efbaa8158a"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17d16604-418d-4a49-9441-1e4f5450c5a6'>RecalculateVectorBounds</a></td><td style='width:75%' class='def'><p><a name="17d16604-418d-4a49-9441-1e4f5450c5a6"></a></p>

<h3>Public Void RecalculateVectorBounds ()</h3>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#521efb1b-df7a-4b01-ad4a-7450409cf5bf'>RemovePoint</a></td><td style='width:75%' ><p><a name="521efb1b-df7a-4b01-ad4a-7450409cf5bf"></a></p>

<h3>Public Void RemovePoint (System.Int32)</h3>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="68ba6c32-6529-4a7c-b2a5-79275c262373"></a>
<b>System.Int32 n</b></p>

<p>The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c04fbb66-258b-49c3-b00a-6725504abfe9'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="c04fbb66-258b-49c3-b00a-6725504abfe9"></a></p>

<h3>Public Virtual Void StartEditing ()</h3>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40c50ba1-9586-4392-bbd7-f894d29a0f9c'>ToCode</a></td><td style='width:75%' ><p><a name="40c50ba1-9586-4392-bbd7-f894d29a0f9c"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="8dc19ec9-033d-4817-8151-c7b75ede848e"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="a40de702-867b-4615-9e38-dc0245594e40"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="4daf5c06-9be7-4849-88d7-86f6f68464a9"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5920775a-c890-4dc7-b45c-e6c732ae9afe'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="5920775a-c890-4dc7-b45c-e6c732ae9afe"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="dd87b371-db4f-42ab-8434-926e8da8a312"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a67cc584-a3e0-49cb-8941-60ccb2e87441'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="a67cc584-a3e0-49cb-8941-60ccb2e87441"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#77dbee06-43f8-444f-bb43-ffb637c965e4'>ToPath</a></td><td style='width:75%' class='def'><p><a name="77dbee06-43f8-444f-bb43-ffb637c965e4"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b351e36b-7da8-4d06-ae36-eb530c8b89a4'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="b351e36b-7da8-4d06-ae36-eb530c8b89a4"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8540ba6a-43b7-456f-a387-edbc26f0cf31'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="8540ba6a-43b7-456f-a387-edbc26f0cf31"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="60cba3d0-f26e-4095-ae97-6368fb3d255a"></a>
##Public Class KimonoShapeGroup

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

A `KimonoShapeGroup` holds a collection of `KimonoShapes` that can be acted upon as a group.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cc929f42-8000-486b-9de6-66636cfc3250'>_isMaskedGroup</a></td><td style='width:75%' ><p><a name="cc929f42-8000-486b-9de6-66636cfc3250"></a>
<b>Private <code>System.Boolean</code> _isMaskedGroup</b></p>

<p>If <code>true</code>, the top most shape in the group will act as a mask for the shapes below it.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f2d736d-2a02-4e81-bfc2-de10cc5f3cdf'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="0f2d736d-2a02-4e81-bfc2-de10cc5f3cdf"></a>
<b>Private <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> _selectedShape</b></p>

<p>The currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dea5bb93-892d-4220-b85d-043b7ecc4c10'>Dragging</a></td><td style='width:75%' ><p><a name="dea5bb93-892d-4220-b85d-043b7ecc4c10"></a>
<b>Private <code>System.Boolean</code> Dragging</b></p>

<p>Marks if the group itself is being moved be the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cc55b8c-303f-4c6f-a117-68216b2990bb'>IgnoreDrag</a></td><td style='width:75%' class='def'><p><a name="5cc55b8c-303f-4c6f-a117-68216b2990bb"></a>
<b>Private <code>System.Boolean</code> IgnoreDrag</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c2c8e4c-6176-44db-b446-7528e3be8054'>PerformingDrag</a></td><td style='width:75%' ><p><a name="8c2c8e4c-6176-44db-b446-7528e3be8054"></a>
<b>Private <code>System.Boolean</code> PerformingDrag</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67c04ea2-2398-4544-9d95-8e70f2049ccd'>ShapeUnderConstruction</a></td><td style='width:75%' class='def'><p><a name="67c04ea2-2398-4544-9d95-8e70f2049ccd"></a>
<b>Private <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> ShapeUnderConstruction</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd5be79e-822a-47e9-9e51-f25a850a4eb5'>ToolDownAt</a></td><td style='width:75%' ><p><a name="bd5be79e-822a-47e9-9e51-f25a850a4eb5"></a>
<b>Private <code>SkiaSharp.SKPoint</code> ToolDownAt</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5b5b4a3a-502f-4df8-9704-96a1fc53afc5'>BooleanOperation</a></td><td style='width:75%' ><p><a name="5b5b4a3a-502f-4df8-9704-96a1fc53afc5"></a></p>

<h3>Public <code>SkiaSharp.SKPathOp</code> BooleanOperation</h3>

<h4>Summary</h4>

<p>Gets or sets the boolean operation that will be applied to this group of objects.</p>

<h4>Return Value</h4>

<p>The boolean operation as a <code>SKPathOp</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6884d888-15da-4766-af10-2ae334e90a24'>DeeplySelectedGroup</a></td><td style='width:75%' class='def'><p><a name="6884d888-15da-4766-af10-2ae334e90a24"></a></p>

<h3>Public Read Only <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoCore.KimonoShapeGroup</a> DeeplySelectedGroup</h3>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be1817dd-0462-4e97-81f1-4950f83f681b'>DeeplySelectedShape</a></td><td style='width:75%' ><p><a name="be1817dd-0462-4e97-81f1-4950f83f681b"></a></p>

<h3>Public Read Only <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> DeeplySelectedShape</h3>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cf9f8d91-851b-457c-944a-485c07c15c8c'>GroupType</a></td><td style='width:75%' class='def'><p><a name="cf9f8d91-851b-457c-944a-485c07c15c8c"></a></p>

<h3>Public <a href="#b969c329-ae0d-472b-b8b1-5faa6cd3af5f">KimonoCore.KimonoShapeGroupType</a> GroupType</h3>

<h4>Summary</h4>

<p>Gets or sets the type of the group.</p>

<h4>Return Value</h4>

<p>The type of the group as a <code>KimonoShapeGroupType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d5efe56-7b6c-4c5e-be98-3ecd00f9e727'>IsBooleanConstruct</a></td><td style='width:75%' ><p><a name="7d5efe56-7b6c-4c5e-be98-3ecd00f9e727"></a></p>

<h3>Public <code>System.Boolean</code> IsBooleanConstruct</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> is a boolean construct.</p>

<h4>Return Value</h4>

<p><code>true</code> if is boolean construct; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c460c116-2105-4304-a169-05f3b251f940'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="c460c116-2105-4304-a169-05f3b251f940"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsEditable</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55108232-4871-490c-a0ab-6d3392cfe4fb'>IsMaskedGroup</a></td><td style='width:75%' ><p><a name="55108232-4871-490c-a0ab-6d3392cfe4fb"></a></p>

<h3>Public <code>System.Boolean</code> IsMaskedGroup</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> is masked group.</p>

<h4>Return Value</h4>

<p><code>true</code> if is masked group; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d181e363-96e2-42db-a593-ee053487cd34'>Mask</a></td><td style='width:75%' class='def'><p><a name="d181e363-96e2-42db-a593-ee053487cd34"></a></p>

<h3>Public <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> Mask</h3>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoShape</code> that is acting as a mask for this group.</p>

<h4>Return Value</h4>

<p>The mask as a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e55b4bc8-57c7-4f6c-8920-88e03a12a158'>Parent</a></td><td style='width:75%' ><p><a name="e55b4bc8-57c7-4f6c-8920-88e03a12a158"></a></p>

<h3>Public <code>System.Object</code> Parent</h3>

<h4>Summary</h4>

<p>Gets or sets the parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code> that this <code>KimonoShapeGroup</code> belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4db38e25-9562-424c-902e-49495a005aa9'>ParentSketch</a></td><td style='width:75%' class='def'><p><a name="4db38e25-9562-424c-902e-49495a005aa9"></a></p>

<h3>Public Read Only <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoCore.KimonoSketch</a> ParentSketch</h3>

<h4>Summary</h4>

<p>Gets the parent sketch by scanning backwards through the chain of parent objects until a <code>KimonoSketch</code> is reached.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#704367c1-3471-443c-9038-0d80a1dd322d'>Path</a></td><td style='width:75%' ><p><a name="704367c1-3471-443c-9038-0d80a1dd322d"></a></p>

<h3>Public Read Only <code>System.String</code> Path</h3>

<h4>Summary</h4>

<p>Gets the full path from this group back to the parent <code>KimonoSketch</code>.</p>

<h4>Return Value</h4>

<p>The path representing the nesting level of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06b82820-4c19-4789-8980-4fb4b15fcb0c'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="06b82820-4c19-4789-8980-4fb4b15fcb0c"></a></p>

<h3>Public <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c185fd1-c508-4227-a9b5-01503d276bed'>SelectedShapeAtBottom</a></td><td style='width:75%' ><p><a name="7c185fd1-c508-4227-a9b5-01503d276bed"></a></p>

<h3>Public Read Only <code>System.Boolean</code> SelectedShapeAtBottom</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#874a87c7-1d4a-4fb9-b328-e98be3bf08b5'>SelectedShapeAtTop</a></td><td style='width:75%' class='def'><p><a name="874a87c7-1d4a-4fb9-b328-e98be3bf08b5"></a></p>

<h3>Public Read Only <code>System.Boolean</code> SelectedShapeAtTop</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebdea1dc-5d07-44fc-a9ea-27f21dd732c3'>Shapes</a></td><td style='width:75%' ><p><a name="ebdea1dc-5d07-44fc-a9ea-27f21dd732c3"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoShape&gt;</code> Shapes</h3>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a2c8459-0490-4591-8de9-4b37406d453e'>Style</a></td><td style='width:75%' class='def'><p><a name="8a2c8459-0490-4591-8de9-4b37406d453e"></a></p>

<h3>Public Virtual <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> Style</h3>

<h4>Summary</h4>

<p>Gets or sets the style of this group.</p>

<h4>Return Value</h4>

<p>The style as a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35df0688-2fc2-49f8-924b-749f4e1b321c'>Visible</a></td><td style='width:75%' ><p><a name="35df0688-2fc2-49f8-924b-749f4e1b321c"></a></p>

<h3>Public Virtual <code>System.Boolean</code> Visible</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#508a2415-16f9-43bd-a586-bb68531f4f05'>AddShape</a></td><td style='width:75%' ><p><a name="508a2415-16f9-43bd-a586-bb68531f4f05"></a></p>

<h3>Public Void AddShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Adds the given <code>KimonoShape</code> to the group if it isn't already a part of the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="74374a8a-e937-4b90-b8a2-e183f688fc48"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fac2e1a-632a-4516-bbc9-bc6ad0822473'>AlignAllBottom</a></td><td style='width:75%' class='def'><p><a name="3fac2e1a-632a-4516-bbc9-bc6ad0822473"></a></p>

<h3>Public Void AlignAllBottom ()</h3>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#614a8b95-6fde-4b8e-a059-ba093f67c213'>AlignAllCenter</a></td><td style='width:75%' ><p><a name="614a8b95-6fde-4b8e-a059-ba093f67c213"></a></p>

<h3>Public Void AlignAllCenter ()</h3>

<h4>Summary</h4>

<p>Centers all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06518cb7-622b-4a5c-bb73-dd68acd05d96'>AlignAllCenterHorizontal</a></td><td style='width:75%' class='def'><p><a name="06518cb7-622b-4a5c-bb73-dd68acd05d96"></a></p>

<h3>Public Void AlignAllCenterHorizontal ()</h3>

<h4>Summary</h4>

<p>Center horizontal all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0010d2f6-8daf-42c2-819f-f7116e30e3ea'>AlignAllCenterVertical</a></td><td style='width:75%' ><p><a name="0010d2f6-8daf-42c2-819f-f7116e30e3ea"></a></p>

<h3>Public Void AlignAllCenterVertical ()</h3>

<h4>Summary</h4>

<p>Center vertical all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5efdba15-a397-4637-9959-1b41765f3ed9'>AlignAllLeft</a></td><td style='width:75%' class='def'><p><a name="5efdba15-a397-4637-9959-1b41765f3ed9"></a></p>

<h3>Public Void AlignAllLeft ()</h3>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c5aff2f-e8cf-4f82-8cd2-f3db41615491'>AlignAllRight</a></td><td style='width:75%' ><p><a name="1c5aff2f-e8cf-4f82-8cd2-f3db41615491"></a></p>

<h3>Public Void AlignAllRight ()</h3>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2042017b-ae72-4e14-aae0-27a9138f47b6'>AlignAllTop</a></td><td style='width:75%' class='def'><p><a name="2042017b-ae72-4e14-aae0-27a9138f47b6"></a></p>

<h3>Public Void AlignAllTop ()</h3>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ebb9470f-31b8-4b9b-a0fa-c42552e0e235'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="ebb9470f-31b8-4b9b-a0fa-c42552e0e235"></a></p>

<h3>Private Void ApplyMoveAndScale ()</h3>

<h4>Summary</h4>

<p>Applies the move and scale adjustments to all <code>KimonoShapes</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01b8fe74-ba9e-440b-8b34-a6c982be9d02'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="01b8fe74-ba9e-440b-8b34-a6c982be9d02"></a></p>

<h3>Public Virtual Void BoundsChanged ()</h3>

<h4>Summary</h4>

<p>Update the bouds of this group when they have changed from either a move or a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efc04eb0-d23d-4e9e-954f-69ce33f501e8'>Clone</a></td><td style='width:75%' ><p><a name="efc04eb0-d23d-4e9e-954f-69ce33f501e8"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfe484f4-c10b-42b1-937b-b8cc1f61bc38'>DeleteColor</a></td><td style='width:75%' class='def'><p><a name="dfe484f4-c10b-42b1-937b-b8cc1f61bc38"></a></p>

<h3>Public Void DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="ed7d7934-20e3-435f-a588-c841f09a01a9"></a>
<b>KimonoCore.KimonoColor color</b></p>

<p>The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13e5ee0b-b5e3-44e7-b2bc-ce60188514f8'>DeleteGradient</a></td><td style='width:75%' ><p><a name="13e5ee0b-b5e3-44e7-b2bc-ce60188514f8"></a></p>

<h3>Public Void DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Summary</h4>

<p>Deletes the given gradient from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="18a1cd4e-e985-40fe-8e84-3330cd54eeb3"></a>
<b>KimonoCore.KimonoGradient gradient</b></p>

<p>The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af1a10e8-dae3-4d62-876a-0722995fefc0'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="af1a10e8-dae3-4d62-876a-0722995fefc0"></a></p>

<h3>Public Void DeleteSelectedShape ()</h3>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb195492-bc12-4b0d-8577-60e9a548764e'>DeleteShapes</a></td><td style='width:75%' ><p><a name="fb195492-bc12-4b0d-8577-60e9a548764e"></a></p>

<h3>Public Void DeleteShapes ()</h3>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a739be8f-71a5-447b-81ea-b58afe21841a'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="a739be8f-71a5-447b-81ea-b58afe21841a"></a></p>

<h3>Public Void DeleteShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="413f85ae-a205-41ac-aca3-76360d2659ea"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0728416a-b91c-4943-b4f7-718744d93f15'>DeleteShapes</a></td><td style='width:75%' ><p><a name="0728416a-b91c-4943-b4f7-718744d93f15"></a></p>

<h3>Public Void DeleteShapes (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="c2c69c57-95bf-4adc-b406-e5ff4e13507c"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38d4d0c5-1689-4356-90bb-18159dc26357'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="38d4d0c5-1689-4356-90bb-18159dc26357"></a></p>

<h3>Public Void DeselectAll ()</h3>

<h4>Summary</h4>

<p>Deselects all shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de4ae1d6-11fc-487a-be49-c1afa6a2d3e2'>DragBounds</a></td><td style='width:75%' ><p><a name="de4ae1d6-11fc-487a-be49-c1afa6a2d3e2"></a></p>

<h3>Public Virtual Void DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="83a95c60-ca0f-495e-8760-e24d5a56400c"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f73220bb-e60a-41ec-913c-900759b67984'>Draw</a></td><td style='width:75%' class='def'><p><a name="f73220bb-e60a-41ec-913c-900759b67984"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draw all the <code>KimonoShapes</code> that are part of this group into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="46592b22-7574-4280-929a-38af6ac0bd0c"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a87fe6b3-03ff-4fce-9b8d-f37bd5104109'>DuplicateSelectedShape</a></td><td style='width:75%' ><p><a name="a87fe6b3-03ff-4fce-9b8d-f37bd5104109"></a></p>

<h3>Public Void DuplicateSelectedShape ()</h3>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ab24415-cf75-4380-96cc-36aea2c38282'>DuplicateShapes</a></td><td style='width:75%' class='def'><p><a name="8ab24415-cf75-4380-96cc-36aea2c38282"></a></p>

<h3>Public Void DuplicateShapes ()</h3>

<h4>Summary</h4>

<p>Duplicates the shapes in a selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b213a6e-d9e8-44ce-abcf-7273418d50cd'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="3b213a6e-d9e8-44ce-abcf-7273418d50cd"></a></p>

<h3>Public Void DuplicateShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="693870ff-08af-4c21-aace-66d1479d2d74"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4eba506-8834-4d4f-bd8f-21a08272e633'>DuplicateShapes</a></td><td style='width:75%' class='def'><p><a name="a4eba506-8834-4d4f-bd8f-21a08272e633"></a></p>

<h3>Public Void DuplicateShapes (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="ed2a95c2-7c67-443b-be55-f9efa524bea9"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d92b2e01-cce1-4025-b0b2-39dc421f3aa8'>EndEditing</a></td><td style='width:75%' ><p><a name="d92b2e01-cce1-4025-b0b2-39dc421f3aa8"></a></p>

<h3>Public Virtual Void EndEditing ()</h3>

<h4>Summary</h4>

<p>Ends editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7d8c4f0-2e71-417d-9a43-54a017c4d50e'>FindShape</a></td><td style='width:75%' class='def'><p><a name="e7d8c4f0-2e71-417d-9a43-54a017c4d50e"></a></p>

<h3>Public <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> FindShape (System.String)</h3>

<h4>Summary</h4>

<p>Finds a given shape by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="dbc134d1-2595-4a58-b483-863357ddb1cd"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoShape</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c507d5e0-fc25-4ed4-95be-a765590c6898'>GroupShapes</a></td><td style='width:75%' ><p><a name="c507d5e0-fc25-4ed4-95be-a765590c6898"></a></p>

<h3>Public Void GroupShapes ()</h3>

<h4>Summary</h4>

<p>Groups the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03df171a-0c09-46d4-bf9f-407c57a8cd57'>GroupShapes</a></td><td style='width:75%' class='def'><p><a name="03df171a-0c09-46d4-bf9f-407c57a8cd57"></a></p>

<h3>Public Void GroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Summary</h4>

<p>Groups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="848c457c-efe9-411e-86ff-bf8ae64346f2"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0e7f92d-c334-43d6-86d5-f472cd110298'>GroupShapes</a></td><td style='width:75%' ><p><a name="f0e7f92d-c334-43d6-86d5-f472cd110298"></a></p>

<h3>Public Void GroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Groups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="1febd386-94ae-48e7-ae0e-dd30453c566f"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fa555e9-6055-4086-b58d-7b060e20c9ec'>Initialize</a></td><td style='width:75%' class='def'><p><a name="1fa555e9-6055-4086-b58d-7b060e20c9ec"></a></p>

<h3>Private Void Initialize (System.Object)</h3>

<h4>Summary</h4>

<p>Initialize the specified parent.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="9a3c1284-283d-48c5-af0d-3ce783d33ed4"></a>
<b>System.Object parent</b></p>

<p>Parent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The initialize.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fe07b73-75de-4c30-9512-3148717f206f'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="3fe07b73-75de-4c30-9512-3148717f206f"></a></p>

<h3>Public Void KimonoShapeGroup (System.Object)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="7a03a5cb-05d4-468d-b63e-7899cb3c4f0e"></a>
<b>System.Object parent</b></p>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3df8320-1bc2-4835-b6cb-b6fde5f05f24'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p><a name="a3df8320-1bc2-4835-b6cb-b6fde5f05f24"></a></p>

<h3>Public Void KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="0f382da9-5fd2-41b1-9a9d-90c8a9d1d57e"></a>
<b>System.Object parent</b></p>

<p>Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="55d283c2-d4f5-4a0f-8fa0-9bae3812a68d"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="c5b9db80-793f-489e-87bc-b1df0db0fa16"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="3f8ce70e-d8b3-44d4-8b27-1cad617d160c"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="12f61cfb-3183-477f-9701-71c4479b32c3"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6eecec6d-3402-4900-86fe-e94ccae00168'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="6eecec6d-3402-4900-86fe-e94ccae00168"></a></p>

<h3>Public Void KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="936ed779-6473-4f57-9e73-38f593242e48"></a>
<b>System.Object parent</b></p>

<p>Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="59901766-8ec0-4437-b00b-94cd8a82722e"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="53d0daad-03f5-4b59-b143-4948b17555ed"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="9f2fc138-07a7-4d07-b061-5c37afadb543"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="21cfc084-1c01-4fdb-99e4-ed6f3b6793b7"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="d56ed057-3bed-47a2-9c71-e2c46e6913d6"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4898918-655b-4e0e-8d59-b1abaf7a2592'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p><a name="a4898918-655b-4e0e-8d59-b1abaf7a2592"></a></p>

<h3>Public Void MoveSelectedShapeBackwards ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#095d063c-4318-4604-887f-9b336465cc64'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="095d063c-4318-4604-887f-9b336465cc64"></a></p>

<h3>Public Void MoveSelectedShapeForwards ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf89f93b-1ca0-4bd8-8d82-cffe57e04235'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="bf89f93b-1ca0-4bd8-8d82-cffe57e04235"></a></p>

<h3>Public Void MoveSelectedShapeToBottom ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30a726f3-8b3d-43d4-852b-0c27e7197c12'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p><a name="30a726f3-8b3d-43d4-852b-0c27e7197c12"></a></p>

<h3>Public Void MoveSelectedShapeToTop ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e12876cb-0ef4-407f-9ef4-47b94e54a468'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="e12876cb-0ef4-407f-9ef4-47b94e54a468"></a></p>

<h3>Public Virtual <code>System.Boolean</code> PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Test to see if the given point is inside the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="882185c5-bbea-4051-b22d-62dc50b2cfe7"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the point was in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b526df41-54a2-45f9-8605-a1b5af248f80'>RecalculateGroupBounds</a></td><td style='width:75%' ><p><a name="b526df41-54a2-45f9-8605-a1b5af248f80"></a></p>

<h3>Public Void RecalculateGroupBounds ()</h3>

<h4>Summary</h4>

<p>Recalculates the group bounds to encompass every <code>KimonoShape</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5683dfd6-044b-4dab-a974-127e26fb7f24'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p><a name="5683dfd6-044b-4dab-a974-127e26fb7f24"></a></p>

<h3>Public Void RecalculateLayerDepths ()</h3>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78cab678-60ac-4a02-b65a-74796ae54f8f'>RelinkShape</a></td><td style='width:75%' ><p><a name="78cab678-60ac-4a02-b65a-74796ae54f8f"></a></p>

<h3>Void RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Relinks the shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="d5cc87a4-71e1-4a03-a86e-93294cbb682e"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b50c1c8f-002c-4511-9233-41cd88538233'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="b50c1c8f-002c-4511-9233-41cd88538233"></a></p>

<h3>Public Virtual Void RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="9c6e65a6-8215-4149-909a-468f9090016a"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0149d24b-33ce-4ca0-8a40-b42372f662f6'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="0149d24b-33ce-4ca0-8a40-b42372f662f6"></a></p>

<h3>Public Virtual Void RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="d4e46961-c4b2-4428-8068-c77c1715a56a"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc6925c8-9a00-4bf4-a053-56b3c2239877'>RemoveShape</a></td><td style='width:75%' class='def'><p><a name="dc6925c8-9a00-4bf4-a053-56b3c2239877"></a></p>

<h3>Public Void RemoveShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Removes the given <code>KimonoShape</code> from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="6c00e633-9b56-423e-a9cc-7128d79552d1"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33063194-e67a-40bc-9a39-a5a90f9b4fc9'>ReturnToSketch</a></td><td style='width:75%' ><p><a name="33063194-e67a-40bc-9a39-a5a90f9b4fc9"></a></p>

<h3>Public Void ReturnToSketch ()</h3>

<h4>Summary</h4>

<p>Returns to base parent <code>KimonoSketch</code> for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54601210-c1a8-4cea-b666-16a22353733e'>SelectShape</a></td><td style='width:75%' class='def'><p><a name="54601210-c1a8-4cea-b666-16a22353733e"></a></p>

<h3>Public Void SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Selects the given <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="f7e57a4d-a771-4650-b4a8-a228eddc8e15"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef0089bf-0ca7-4aa9-a070-07e84d508194'>ShapeInGroup</a></td><td style='width:75%' ><p><a name="ef0089bf-0ca7-4aa9-a070-07e84d508194"></a></p>

<h3>Public <code>System.Boolean</code> ShapeInGroup (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Test to see if the given <code>KimonoShape</code> is a part of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="dbe7e12d-5f91-47e3-9de3-3cb0b1cc976f"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in shape is in the group, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f09f3488-9b32-4d91-951c-fb582cb4d8b5'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="f09f3488-9b32-4d91-951c-fb582cb4d8b5"></a></p>

<h3>Public Virtual Void StartEditing ()</h3>

<h4>Summary</h4>

<p>Starts editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#377380a5-05d5-42f0-938e-9f7bacc40d82'>ToCode</a></td><td style='width:75%' ><p><a name="377380a5-05d5-42f0-938e-9f7bacc40d82"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="df222202-c287-4c03-bb95-f03ae94a5ac9"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="48840216-d642-4309-8b95-5de3b6379f94"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="38605b11-4599-4bad-8869-06da32fe0864"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#823fac7d-f9e3-4683-b928-142b7ab99f87'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="823fac7d-f9e3-4683-b928-142b7ab99f87"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="340f2ffe-215d-4151-a471-f811b5f1231f"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34c1b8b9-896e-4037-be8b-e155bfe4adb6'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="34c1b8b9-896e-4037-be8b-e155bfe4adb6"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b793da92-9bfe-491a-818c-9cd596304397'>ToolDown</a></td><td style='width:75%' class='def'><p><a name="b793da92-9bfe-491a-818c-9cd596304397"></a></p>

<h3>Public Void ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the group's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="7382f6b6-7ccd-4c63-a660-d7c4ae1c629b"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="6082b1ef-4b37-4e41-8335-da300c06b07e"></a>
<b>System.Int32 clicks</b></p>

<p>The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="2178e8bc-43c3-4516-b19b-4ead012734a1"></a>
<b>System.Boolean multiSelect</b></p>

<p>If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b42a9d6-cb87-4822-b4eb-c105b89b1770'>ToolDrag</a></td><td style='width:75%' ><p><a name="5b42a9d6-cb87-4822-b4eb-c105b89b1770"></a></p>

<h3>Public Void ToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>The public <code>ToolDrag (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ec696811-71cf-4456-8d28-c286f8a2cb8a"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>point</code> parameter of the ToolDrag method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ed87b23-bbfa-498e-aa38-d11e48ccdda8'>ToolUp</a></td><td style='width:75%' class='def'><p><a name="2ed87b23-bbfa-498e-aa38-d11e48ccdda8"></a></p>

<h3>Public Void ToolUp (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>The public <code>ToolUp (SkiaSharp.SKPoint)</code> member of the <code>KimonoShapeGroup</code> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="74d4fcad-9961-487b-87d1-00a23e550fa2"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>point</code> parameter of the ToolUp method takes a <code>SkiaSharp.SKPoint</code> value. </p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d22cec4-d9cd-47a5-b412-1477fe0097af'>ToPath</a></td><td style='width:75%' ><p><a name="0d22cec4-d9cd-47a5-b412-1477fe0097af"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the group of shapes to a path.</p>

<h4>Returns</h4>

<p>The group of shapes as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e04c9ea0-9cbc-48c1-9714-29d41357d372'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="e04c9ea0-9cbc-48c1-9714-29d41357d372"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84c70eba-454e-4342-8ff8-d1426d5ea8da'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="84c70eba-454e-4342-8ff8-d1426d5ea8da"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2c7953d-a6ff-44a6-9ba2-a39866ad9d0c'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="a2c7953d-a6ff-44a6-9ba2-a39866ad9d0c"></a></p>

<h3>Public Void UngroupShapes ()</h3>

<h4>Summary</h4>

<p>Ungroups the shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9074e1ad-2f43-4548-a48e-fdaf44b8bdf0'>UngroupShapes</a></td><td style='width:75%' ><p><a name="9074e1ad-2f43-4548-a48e-fdaf44b8bdf0"></a></p>

<h3>Public Void UngroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="4eec29e0-a095-4009-a337-e9c7027b10ab"></a>
<b>KimonoCore.KimonoShapeGroup group</b></p>

<p>The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c70a9ec0-85ca-40d7-8cd6-5e975c97b9c2'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="c70a9ec0-85ca-40d7-8cd6-5e975c97b9c2"></a></p>

<h3>Public Void UngroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="8e9ffd67-bbc0-4a61-a040-93448e71c199"></a>
<b>KimonoCore.KimonoSketch sketch</b></p>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="b969c329-ae0d-472b-b8b1-5faa6cd3af5f"></a>
##Public Enum KimonoShapeGroupType

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the type of a `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1795686c-10b1-4290-9155-f86ebba0b444'>Collection</a></td><td style='width:75%' ><p><a name="1795686c-10b1-4290-9155-f86ebba0b444"></a>
<b>Public Static Constant <a href="#b969c329-ae0d-472b-b8b1-5faa6cd3af5f">KimonoCore.KimonoShapeGroupType</a> Collection = <code>2</code></b></p>

<p>The group is a collection of shape that have been grouped together and are treated as a single object in the editor.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfd95ee5-9e19-4328-96b2-8377616ffc68'>DragSelect</a></td><td style='width:75%' class='def'><p><a name="dfd95ee5-9e19-4328-96b2-8377616ffc68"></a>
<b>Public Static Constant <a href="#b969c329-ae0d-472b-b8b1-5faa6cd3af5f">KimonoCore.KimonoShapeGroupType</a> DragSelect = <code>1</code></b></p>

<p>The group is a drag to select selection that is underway.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa9c782e-cfe0-4905-8212-fbcba474e1af'>Selection</a></td><td style='width:75%' ><p><a name="fa9c782e-cfe0-4905-8212-fbcba474e1af"></a>
<b>Public Static Constant <a href="#b969c329-ae0d-472b-b8b1-5faa6cd3af5f">KimonoCore.KimonoShapeGroupType</a> Selection = <code>0</code></b></p>

<p>The group is a current active selection.</p>
</td></tr></table></p>


---

<a name="3ad91fd7-0087-4c09-a682-87a9a80e7203"></a>
##Public Class KimonoShapeLine

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a line on the design surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6e760a84-cca7-4514-bb17-cb4b19a5b121'>Clone</a></td><td style='width:75%' ><p><a name="6e760a84-cca7-4514-bb17-cb4b19a5b121"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoLine</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4f22931-c5b3-4c9d-95b6-f33be7664f14'>Draw</a></td><td style='width:75%' class='def'><p><a name="d4f22931-c5b3-4c9d-95b6-f33be7664f14"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the line into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="78e092fd-e123-4ed4-8074-69abb1e3ccb4"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9678890b-fe1c-45ef-af22-2cf334788e61'>Initialize</a></td><td style='width:75%' ><p><a name="9678890b-fe1c-45ef-af22-2cf334788e61"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c7eb535-876e-4398-82fa-b470c245409c'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p><a name="3c7eb535-876e-4398-82fa-b470c245409c"></a></p>

<h3>Public Void KimonoShapeLine ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#3ad91fd7-0087-4c09-a682-87a9a80e7203">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ecadbce-687d-4831-8be0-ab0b966c947d'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="3ecadbce-687d-4831-8be0-ab0b966c947d"></a></p>

<h3>Public Void KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#3ad91fd7-0087-4c09-a682-87a9a80e7203">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="81ab3d55-8d53-48e7-a5a2-a2bf359f8c90"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="4d21bd4d-60b6-4e90-b850-b41398f313ce"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f0268003-a6ef-4e00-984e-e6767ae945df"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="938a69a4-10b0-4d0c-98c8-e356555962c3"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#495f3145-e2ce-49bf-9a11-c42c245b42bb'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p><a name="495f3145-e2ce-49bf-9a11-c42c245b42bb"></a></p>

<h3>Public Void KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#3ad91fd7-0087-4c09-a682-87a9a80e7203">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="e126424d-6662-4c0e-b635-7f0e805c663b"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="793fc579-3af0-45d0-b38e-0858005859c2"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="9ba966cf-1afb-44bb-b172-2b3fa8eb6b0f"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="abceaed0-ac60-4e8b-9231-04adbdd6d553"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="4eaece23-87d3-46a3-85f7-dedb6b37c059"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8e5c088-53de-4efa-bfb0-fd2d944dcc56'>ToCode</a></td><td style='width:75%' ><p><a name="b8e5c088-53de-4efa-bfb0-fd2d944dcc56"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="a3baf6d8-9057-467f-ad04-9e781789d7c0"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="6200a108-d36a-4726-9e29-fba588704b21"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9abf4427-bd22-43be-8f59-c41a5567ff1e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#284daf45-fc48-4435-86a9-66d9428e388c'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="284daf45-fc48-4435-86a9-66d9428e388c"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="33e8cc19-b013-4bac-bdf8-0ccc76a8f1d3"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c510400-e354-4391-863d-926285620823'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="9c510400-e354-4391-863d-926285620823"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2022b604-b623-4867-b10a-293190904272'>ToPath</a></td><td style='width:75%' class='def'><p><a name="2022b604-b623-4867-b10a-293190904272"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c12ef0d6-7a31-4b37-84fe-e1d7f8189e11'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="c12ef0d6-7a31-4b37-84fe-e1d7f8189e11"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d68331e6-8663-4a63-ac99-13572deb5475'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="d68331e6-8663-4a63-ac99-13572deb5475"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="5639ac9b-4ddb-44a7-8f19-d4ee2e368170"></a>
##Public Class KimonoShapeOval

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws an oval into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9f27237c-f571-4f49-b9d1-d8ac393af073'>Clone</a></td><td style='width:75%' ><p><a name="9f27237c-f571-4f49-b9d1-d8ac393af073"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoOval</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5be8b236-f708-4b1d-b87c-66a3dc8b51e0'>Draw</a></td><td style='width:75%' class='def'><p><a name="5be8b236-f708-4b1d-b87c-66a3dc8b51e0"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draw the oval into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="cdb1ddc2-efe4-450e-adfd-46437240fbfe"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1f1d231-cfdb-48d5-9227-6521d965d7be'>Initialize</a></td><td style='width:75%' ><p><a name="f1f1d231-cfdb-48d5-9227-6521d965d7be"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63dd9617-f6c4-40e2-b209-d56f24552017'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p><a name="63dd9617-f6c4-40e2-b209-d56f24552017"></a></p>

<h3>Public Void KimonoShapeOval ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5639ac9b-4ddb-44a7-8f19-d4ee2e368170">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8542f9e-0f0d-4f41-baa7-a968ed41bf46'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="a8542f9e-0f0d-4f41-baa7-a968ed41bf46"></a></p>

<h3>Public Void KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5639ac9b-4ddb-44a7-8f19-d4ee2e368170">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8fbb1bd6-47bd-4157-a734-aee69b239b33"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="76dcd388-2fd1-4e53-ae1a-9d4868e439d5"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="4eda6242-86f0-4082-bcb6-520cf746a8dc"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="caa1e839-f39d-4158-a349-a24e257c5749"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2c8e9a2-db45-40ac-a1f1-19b70168f109'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p><a name="e2c8e9a2-db45-40ac-a1f1-19b70168f109"></a></p>

<h3>Public Void KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#5639ac9b-4ddb-44a7-8f19-d4ee2e368170">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="46605ec9-34b4-45fb-be69-a4aaa600bddd"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="37824e18-c91c-4b94-98f1-df3c0344e85a"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2b8d5e28-c801-4b64-99f2-1f48f2c1db4a"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="fe4ed2dd-3f39-4fae-82e3-660407493c5e"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="7d86e68f-02b9-4d96-b310-8a3b20712e25"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0335131d-7309-4407-8c8f-fa261cf54e7a'>ToCode</a></td><td style='width:75%' ><p><a name="0335131d-7309-4407-8c8f-fa261cf54e7a"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="c3a9593a-9f6b-49a4-9fa6-11626ce25254"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="4f4d8048-43ae-4ad8-8719-e703672ca617"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ad45e988-2b3f-4bd6-bd7a-7b979554beb3"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#190d14e3-d606-4fca-adf6-5bed092cdbbf'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="190d14e3-d606-4fca-adf6-5bed092cdbbf"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="337185e8-4639-4b99-89f6-8d70dd2faa42"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc1ff3d6-5128-4ad3-95ec-f062bff4d5ca'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="bc1ff3d6-5128-4ad3-95ec-f062bff4d5ca"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8c32bed-a7be-492d-a091-9f88e681fa97'>ToPath</a></td><td style='width:75%' class='def'><p><a name="b8c32bed-a7be-492d-a091-9f88e681fa97"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c0faa1c-25c3-42c2-a3f6-a31605bd4397'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="3c0faa1c-25c3-42c2-a3f6-a31605bd4397"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#136d70c0-6d8a-4188-9ad5-58cacbd80797'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="136d70c0-6d8a-4188-9ad5-58cacbd80797"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="01c83867-0ee5-42f9-a497-2b55717b53c5"></a>
##Public Class KimonoShapePolygon

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a multi-sided polygon into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#db96503a-2b19-4181-b99a-ddae8f1b5fbe'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="db96503a-2b19-4181-b99a-ddae8f1b5fbe"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd1b2c12-83f3-49d5-9965-b62077b85aa6'>NumberOfSides</a></td><td style='width:75%' class='def'><p><a name="fd1b2c12-83f3-49d5-9965-b62077b85aa6"></a></p>

<h3>Public <code>System.Int32</code> NumberOfSides</h3>

<h4>Summary</h4>

<p>Gets or sets the number of sides.</p>

<h4>Return Value</h4>

<p>The number of sides.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7148b5fd-da97-48f0-b6d4-47f5f1f36ce5'>Clone</a></td><td style='width:75%' ><p><a name="7148b5fd-da97-48f0-b6d4-47f5f1f36ce5"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoPloygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9328a2e4-fb13-402e-8d7f-c15d7e7ec735'>Draw</a></td><td style='width:75%' class='def'><p><a name="9328a2e4-fb13-402e-8d7f-c15d7e7ec735"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the polygon into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="ef88e23a-b534-4381-a058-24bc04900b51"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5293a4c-d80e-4f92-ba35-b98fac983cef'>Initialize</a></td><td style='width:75%' ><p><a name="d5293a4c-d80e-4f92-ba35-b98fac983cef"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ca5f806-55d8-45e4-aa2a-cee7c77f5c0b'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p><a name="4ca5f806-55d8-45e4-aa2a-cee7c77f5c0b"></a></p>

<h3>Public Void KimonoShapePolygon ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#01c83867-0ee5-42f9-a497-2b55717b53c5">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a072e384-d794-4bef-a1ba-f78e0a9d977a'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="a072e384-d794-4bef-a1ba-f78e0a9d977a"></a></p>

<h3>Public Void KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#01c83867-0ee5-42f9-a497-2b55717b53c5">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="51ce6139-2996-4830-b392-8df4aaccd2f5"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="8caa590f-a72d-4ef5-91d3-a441f83ab58e"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="fffbcdb1-b400-4a1d-97a9-14faf7e334c7"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1718c0a3-ebb6-4d65-b9c2-c1f6d842e597"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd8a2c8b-b95c-4f08-8e32-6a4da0034df1'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p><a name="fd8a2c8b-b95c-4f08-8e32-6a4da0034df1"></a></p>

<h3>Public Void KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#01c83867-0ee5-42f9-a497-2b55717b53c5">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="66344fd0-c053-4878-8ba5-604be53c6b68"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="aca3ea59-7e22-4bf3-8421-1056fcdcac49"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="9fe607ae-42f4-4b87-b3aa-1e108a8148fb"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a8f4cb67-b89a-42bd-8705-e900ba9e9212"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="bbac1398-ea7b-42c6-8faa-21d8e7612e02"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75f5ded7-f2c5-4863-b0c9-a284538bb191'>MakeSidePoints</a></td><td style='width:75%' ><p><a name="75f5ded7-f2c5-4863-b0c9-a284538bb191"></a></p>

<h3>Private <code>SkiaSharp.SKPoint[]</code> MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="b470635a-5432-4272-8f38-dd6fc4539f3e"></a>
<b>System.Double startTheta</b></p>

<p>Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="342122eb-f7f6-4c33-a0b8-8a40301c7c92"></a>
<b>System.Int32 numPoints</b></p>

<p>Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' ><p><a name="e6eba58b-0919-45f5-b74d-562363304c1f"></a>
<b>SkiaSharp.SKRect rect</b></p>

<p>Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b484b284-f2f1-4c7d-bbb6-bcdbadfb4c23'>ToCode</a></td><td style='width:75%' class='def'><p><a name="b484b284-f2f1-4c7d-bbb6-bcdbadfb4c23"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="36df76a0-9a5d-4309-ad26-d7844679be77"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="307786d0-ca20-4d49-afe4-2bcfbd5a0103"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d2c852ad-7ee6-4b60-8928-cc7e9c633a79"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81ebae0c-43cc-46fa-ab7e-59d33c689f39'>ToCSharp</a></td><td style='width:75%' ><p><a name="81ebae0c-43cc-46fa-ab7e-59d33c689f39"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="6de761b3-dd39-4cb8-b669-f8eb4652dded"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0cbaaae1-a25a-4702-bc95-21ea0777471d'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="0cbaaae1-a25a-4702-bc95-21ea0777471d"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d082ea0-6a22-4ef4-80b7-d90fafd1dc33'>ToPath</a></td><td style='width:75%' ><p><a name="2d082ea0-6a22-4ef4-80b7-d90fafd1dc33"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af6ffd32-d79d-4262-842c-13c8968bdbfd'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="af6ffd32-d79d-4262-842c-13c8968bdbfd"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a39846e-a05f-4faf-88be-630e55d69522'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="3a39846e-a05f-4faf-88be-630e55d69522"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95e68a0f-050e-44ca-b4f8-9525bc3232ab'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="95e68a0f-050e-44ca-b4f8-9525bc3232ab"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="21c8eb41-c524-4403-b9b2-a214246ca46f"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="d92efb79-b570-4344-9283-8d0e3f17291a"></a>
##Public Class KimonoShapeRect

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9ac3c985-b7c2-4537-9284-6234f25e83ab'>Clone</a></td><td style='width:75%' ><p><a name="9ac3c985-b7c2-4537-9284-6234f25e83ab"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a9a03b7-06d8-4b56-83e8-59bb77580e51'>Draw</a></td><td style='width:75%' class='def'><p><a name="0a9a03b7-06d8-4b56-83e8-59bb77580e51"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="dbcc8f26-9aba-4aeb-a473-7f0e7cf5f79b"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7afe9a0d-18b4-48b3-ab22-1e39192e3d21'>Initialize</a></td><td style='width:75%' ><p><a name="7afe9a0d-18b4-48b3-ab22-1e39192e3d21"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a0c2d3c-6288-4b08-a8fe-fba24425a8c3'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p><a name="5a0c2d3c-6288-4b08-a8fe-fba24425a8c3"></a></p>

<h3>Public Void KimonoShapeRect ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d92efb79-b570-4344-9283-8d0e3f17291a">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#725f4c86-7fe4-4d24-800b-d3acc992437b'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="725f4c86-7fe4-4d24-800b-d3acc992437b"></a></p>

<h3>Public Void KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d92efb79-b570-4344-9283-8d0e3f17291a">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="6d3ff23f-2b67-47c1-9d75-c963c981efc3"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="d09e5d2f-7802-4ab6-8538-821a766c286d"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="95d9ea84-9c38-4882-8dfd-a02430eb97a5"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="282b0d3f-ace2-4275-830b-b111dccb3913"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#58970131-cd17-4807-b9d2-8e5790a678e3'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p><a name="58970131-cd17-4807-b9d2-8e5790a678e3"></a></p>

<h3>Public Void KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d92efb79-b570-4344-9283-8d0e3f17291a">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f34e2ada-cefb-4569-b6f5-12488d6312bd"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="799b0ea4-23e1-4f0d-9d24-070adb3612f2"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d9adfcba-e927-401d-a734-816f70e4dd2d"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="2b155323-0458-4627-a83a-738f14a83b95"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="e5003971-d06b-4ec2-bf97-65fdf4184f1b"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6c721b5-8e2c-43e4-a61a-c409c44072b0'>ToCode</a></td><td style='width:75%' ><p><a name="e6c721b5-8e2c-43e4-a61a-c409c44072b0"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="21eb7a7f-a39a-4987-96b1-3dae4fce67c3"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="984b4591-4470-46d0-9170-e6fb68ed3f8d"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="52350738-34ce-46b1-9e1a-f3f3f766171b"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96081410-c187-4f3b-983f-9f92b7dd9539'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="96081410-c187-4f3b-983f-9f92b7dd9539"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="080060fa-c99c-4954-ab70-ea9dda7e4dcb"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a014b30-4d0a-4741-b9e3-be2356e26b06'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="9a014b30-4d0a-4741-b9e3-be2356e26b06"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80d6c3a8-98eb-4ab3-82a8-7a83eae09fff'>ToPath</a></td><td style='width:75%' class='def'><p><a name="80d6c3a8-98eb-4ab3-82a8-7a83eae09fff"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce9b284f-45a5-4be7-9835-6d6e48ebc04d'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="ce9b284f-45a5-4be7-9835-6d6e48ebc04d"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#480d2974-ad6c-447d-8e7a-c1aa77560ab8'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="480d2974-ad6c-447d-8e7a-c1aa77560ab8"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="d14fb996-2bf4-4e6b-b506-4c9871f39125"></a>
##Public Class KimonoShapeRoundRect

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a rounded rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d7c3d0a1-e6ce-4a01-9175-e55c61081da2'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="d7c3d0a1-e6ce-4a01-9175-e55c61081da2"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7540b83b-793c-4202-b37c-b06a9ea4261a'>CornerRadius</a></td><td style='width:75%' class='def'><p><a name="7540b83b-793c-4202-b37c-b06a9ea4261a"></a></p>

<h3>Public <code>System.Single</code> CornerRadius</h3>

<h4>Summary</h4>

<p>Gets or sets the corner radius.</p>

<h4>Return Value</h4>

<p>The corner radius.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f4631ef8-b83a-4ceb-8b8e-40277590fa59'>Clone</a></td><td style='width:75%' ><p><a name="f4631ef8-b83a-4ceb-8b8e-40277590fa59"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#faa8db36-60f3-43a4-b86b-9befc6ce7a53'>Draw</a></td><td style='width:75%' class='def'><p><a name="faa8db36-60f3-43a4-b86b-9befc6ce7a53"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the round rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="7879f597-c150-42ef-8a2c-ce582a5f00bb"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f44a4c81-efe8-4649-8951-166bdec57d68'>Initialize</a></td><td style='width:75%' ><p><a name="f44a4c81-efe8-4649-8951-166bdec57d68"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#323b4a5b-7dfb-4765-aa27-48bd622c0176'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="323b4a5b-7dfb-4765-aa27-48bd622c0176"></a></p>

<h3>Public Void KimonoShapeRoundRect ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d14fb996-2bf4-4e6b-b506-4c9871f39125">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4a3539c-7ce9-48e7-b719-d410c5a3ff41'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="f4a3539c-7ce9-48e7-b719-d410c5a3ff41"></a></p>

<h3>Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d14fb996-2bf4-4e6b-b506-4c9871f39125">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8f2e4d48-14e1-4ed7-accd-836ac2daae8e"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="129baec2-194d-4e86-9dae-5310349380d6"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="1f7ed005-f4a3-442e-88ef-0b5975cae7a9"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="96108e8a-2a75-43ca-a3ba-c6ded22cae4c"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ace8e6ed-3c7b-45ff-b5c8-0f2c40687b02'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="ace8e6ed-3c7b-45ff-b5c8-0f2c40687b02"></a></p>

<h3>Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d14fb996-2bf4-4e6b-b506-4c9871f39125">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="0210c624-c2b2-4ad3-a3d3-83f5f901a7f2"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="bf3e0719-d7e5-4aa0-9514-1cbcdcfb601f"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="9a1e604e-e084-4b93-933a-65fa117656a6"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="ee5aa879-847d-4118-bf9c-36525e010435"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="89649afe-7899-4b10-b6e2-4d91d765b8f9"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6330968c-3cb4-429a-8de9-ec567b8b1668'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="6330968c-3cb4-429a-8de9-ec567b8b1668"></a></p>

<h3>Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d14fb996-2bf4-4e6b-b506-4c9871f39125">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="fb0e5c1d-0b35-4b34-9726-ec22fe469622"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a59a5b09-ac75-48ff-83f5-0684f2ad40bf"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ed20fe41-a177-4224-87f4-9617ee21dc6c"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f47c9bda-dc5d-4f78-bf4a-203543feafdb"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="77c43481-ce90-4581-889e-15e29a3540f7"></a>
<b>System.Single cornerRadius</b></p>

<p>Corner radius.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72c8295d-ccd3-4445-8a7c-ffdb9a78a447'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="72c8295d-ccd3-4445-8a7c-ffdb9a78a447"></a></p>

<h3>Public Void KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d14fb996-2bf4-4e6b-b506-4c9871f39125">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="5d49c9cf-737f-4d11-9566-399b50f528e1"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="0f914c4f-5223-4203-825c-cad6f8f8302a"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="7e24c54b-c20e-4cb0-9cc7-196531456e22"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="10db1f00-29e0-4702-be24-1a0513751485"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="41148574-afd4-412b-871f-fda84759b5c8"></a>
<b>System.Single cornerRadius</b></p>

<p>Corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="cdc0d1fc-decc-44d0-8faf-7267dc5002e4"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0829601e-377a-48da-b024-f7efbce69b01'>ToCode</a></td><td style='width:75%' ><p><a name="0829601e-377a-48da-b024-f7efbce69b01"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="83c57291-f082-4425-94e9-95be8f650ce9"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="395875d6-b0a1-4d38-bb6a-63bb9005f2bd"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="efa6b442-939b-459f-8bda-11a6962f4a41"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f57d8715-79aa-4e62-bee4-1dbd30a02059'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="f57d8715-79aa-4e62-bee4-1dbd30a02059"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="753a5107-1e43-4e21-8ec4-18f482254a35"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f53be502-5b35-488c-a66a-28a0045b79f3'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="f53be502-5b35-488c-a66a-28a0045b79f3"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ece7d125-40ce-4c7c-8003-bd91c3dc17c7'>ToPath</a></td><td style='width:75%' class='def'><p><a name="ece7d125-40ce-4c7c-8003-bd91c3dc17c7"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be05bfd9-d852-4eac-8cda-a0cde709da80'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="be05bfd9-d852-4eac-8cda-a0cde709da80"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6946c459-4e73-4040-8354-43055013965b'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="6946c459-4e73-4040-8354-43055013965b"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#311c74f2-93c0-4308-a13e-e61d3076544f'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="311c74f2-93c0-4308-a13e-e61d3076544f"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="6b51d00b-999d-4ec5-9e27-03345129e49c"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="f6946276-0101-4180-a5cc-b5024a03d6ac"></a>
##Public Class KimonoShapeStar

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a multi-sided star shape into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e6811ffb-ed22-4183-900c-bfda307d0338'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="e6811ffb-ed22-4183-900c-bfda307d0338"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a715f7e4-de6c-4c38-9624-be378fcc6197'>DepthOffset</a></td><td style='width:75%' class='def'><p><a name="a715f7e4-de6c-4c38-9624-be378fcc6197"></a></p>

<h3>Public <code>System.Int32</code> DepthOffset</h3>

<h4>Summary</h4>

<p>Gets or sets the depth offset for the individual points.</p>

<h4>Return Value</h4>

<p>The depth offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f47bec96-e131-4e58-bf81-8f92adf2a95f'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="f47bec96-e131-4e58-bf81-8f92adf2a95f"></a></p>

<h3>Public <code>System.Int32</code> NumberOfPoints</h3>

<h4>Summary</h4>

<p>Gets or sets the number of points.</p>

<h4>Return Value</h4>

<p>The number of points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75bb4408-a74b-4a55-800e-f22e09bbe6dd'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="75bb4408-a74b-4a55-800e-f22e09bbe6dd"></a></p>

<h3>Public <code>System.Int32</code> SkipPoints</h3>

<h4>Summary</h4>

<p>Gets or sets the skip points.</p>

<h4>Return Value</h4>

<p>The skip points.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9393b3b5-5cf9-4ad2-9bb5-eb3c8b962b06'>CalculateConcaveRadius</a></td><td style='width:75%' ><p><a name="9393b3b5-5cf9-4ad2-9bb5-eb3c8b962b06"></a></p>

<h3>Private <code>System.Double</code> CalculateConcaveRadius (System.Int32, System.Int32)</h3>

<h4>Summary</h4>

<p>Calculates the concave radius.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p><a name="9b2c479b-0e2c-480b-aad7-a7623de1aac6"></a>
<b>System.Int32 numPoints</b></p>

<p>Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p><a name="6c1e1a9f-6fbe-4570-954f-54b91eccf6b4"></a>
<b>System.Int32 skip</b></p>

<p>Skip.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The concave radius.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bd8509d-8cb8-4233-a05a-7051079d499f'>Clone</a></td><td style='width:75%' class='def'><p><a name="2bd8509d-8cb8-4233-a05a-7051079d499f"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7c10f7a-c98c-4076-b878-fd81426b4f29'>Draw</a></td><td style='width:75%' ><p><a name="e7c10f7a-c98c-4076-b878-fd81426b4f29"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the star into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="14fad2ca-5d19-4b73-be83-49c24d0ab377"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97450cdc-a000-46c3-82df-8534ab8a7458'>FindIntersection</a></td><td style='width:75%' class='def'><p><a name="97450cdc-a000-46c3-82df-8534ab8a7458"></a></p>

<h3>Private Void FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean&amp;, System.Boolean&amp;, SkiaSharp.SKPoint&amp;, SkiaSharp.SKPoint&amp;, SkiaSharp.SKPoint&amp;)</h3>

<h4>Summary</h4>

<p>Finds the intersection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p><a name="594f9fab-ebe6-42dc-8284-6c64661d5227"></a>
<b>SkiaSharp.SKPoint p1</b></p>

<p>P1.</p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p><a name="f0a5d870-38bf-4334-831c-ee2839a287f5"></a>
<b>SkiaSharp.SKPoint p2</b></p>

<p>P2.</p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p><a name="9b936d22-6f1b-44f2-91b9-53c211dcbf15"></a>
<b>SkiaSharp.SKPoint p3</b></p>

<p>P3.</p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p><a name="83848fc7-f4da-427b-ad7c-510dc8491e99"></a>
<b>SkiaSharp.SKPoint p4</b></p>

<p>P4.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref lines_intersect</td><td style='width:75%' ><p><a name="c352240c-ba59-4c39-b19d-75479e77e874"></a>
<b>System.Boolean Out Ref lines_intersect</b></p>

<p>If set to <code>true</code> lines intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref segments_intersect</td><td style='width:75%' class='def'><p><a name="8ba307cc-d7e9-45bd-992d-5b25dcfa5a16"></a>
<b>System.Boolean Out Ref segments_intersect</b></p>

<p>If set to <code>true</code> segments intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref intersection</td><td style='width:75%' ><p><a name="e87b6316-d8cc-43f9-a45b-e5075da00dd5"></a>
<b>SkiaSharp.SKPoint Out Ref intersection</b></p>

<p>Intersection.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref close_p1</td><td style='width:75%' class='def'><p><a name="a3032229-2f77-4460-a6fa-6c250b1db9e8"></a>
<b>SkiaSharp.SKPoint Out Ref close_p1</b></p>

<p>Close p1.</p>
</td></tr><tr><td style='width:25%' class='term'>Out Ref close_p2</td><td style='width:75%' ><p><a name="2dfa5b32-83a8-4134-b10c-b15960066b62"></a>
<b>SkiaSharp.SKPoint Out Ref close_p2</b></p>

<p>Close p2.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1e285463-d0fc-48b7-875e-eff8fdf7fa2e'>Initialize</a></td><td style='width:75%' ><p><a name="1e285463-d0fc-48b7-875e-eff8fdf7fa2e"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1e2d61f-b737-4021-9424-58a00a37ac59'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p><a name="f1e2d61f-b737-4021-9424-58a00a37ac59"></a></p>

<h3>Public Void KimonoShapeStar ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f6946276-0101-4180-a5cc-b5024a03d6ac">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1e547c1-c955-4906-8e71-2eda06de56fa'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="c1e547c1-c955-4906-8e71-2eda06de56fa"></a></p>

<h3>Public Void KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f6946276-0101-4180-a5cc-b5024a03d6ac">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9d9a92df-ff7f-46b4-b507-bd7d96c0ea9a"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f42de076-54ff-4318-912c-fe08d11b4e12"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="71eed435-355d-4cf3-9a27-ea9a4ee897e4"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a74c6318-41ea-4bea-9921-f961d3dfa340"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#602c4319-4459-419e-90c9-c4bdcbaeb6c9'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p><a name="602c4319-4459-419e-90c9-c4bdcbaeb6c9"></a></p>

<h3>Public Void KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f6946276-0101-4180-a5cc-b5024a03d6ac">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="1841a6e3-e739-47fb-a944-985f05b3aaad"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e44be6ce-fb0c-4d55-bf38-fc0fad586662"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="284679d5-8d0a-4ad2-95e7-d5080a1dfdce"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="bdf90aab-d249-4a49-b1c6-9b557d621ca6"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="ea5cb2ff-8363-4f67-8af1-59d3e25f82f8"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f3ae145c-6153-4c00-a9c0-5292f3e60f73'>MakeStarPoints</a></td><td style='width:75%' ><p><a name="f3ae145c-6153-4c00-a9c0-5292f3e60f73"></a></p>

<h3>Private <code>SkiaSharp.SKPoint[]</code> MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="b991105b-bde4-4895-9a25-a7afe2b85d36"></a>
<b>System.Double startTheta</b></p>

<p>Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="9eb77476-0eb5-4d2b-bed6-676ac531520c"></a>
<b>System.Int32 numPoints</b></p>

<p>Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="90613703-d99a-440b-b83c-70ff013fd697"></a>
<b>System.Int32 skip</b></p>

<p>Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="438d1a88-ac4b-4667-8422-0f1afe31675e"></a>
<b>SkiaSharp.SKRect rect</b></p>

<p>Rect.</p>
</td></tr><tr><td style='width:25%' class='term'>depth</td><td style='width:75%' ><p><a name="6a158a3a-2379-4019-b55e-f7bb31f37fed"></a>
<b>System.Single depth</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>depth</code> parameter of the MakeStarPoints method takes a <code>System.Single</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abc50225-b4d9-440d-ac9c-c2a7ef3c910d'>ToCode</a></td><td style='width:75%' class='def'><p><a name="abc50225-b4d9-440d-ac9c-c2a7ef3c910d"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="f4b87241-09fd-4e5e-8fd7-553b8d43581a"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="aeb8c01b-b5b9-4926-bcb0-b121afcf9ce2"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="55c160a4-6271-42c8-8011-f41135d4442e"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45ffc425-fc41-431a-a929-8154afcbefeb'>ToCSharp</a></td><td style='width:75%' ><p><a name="45ffc425-fc41-431a-a929-8154afcbefeb"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5e3b440d-2ac6-4de5-88b7-8e10efb3b476"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3b7da7e-8f9f-4159-8738-0e10dd0b946f'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="c3b7da7e-8f9f-4159-8738-0e10dd0b946f"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2faf3ba1-8d06-4d71-b3d9-419f5dc16a81'>ToPath</a></td><td style='width:75%' ><p><a name="2faf3ba1-8d06-4d71-b3d9-419f5dc16a81"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73c1caa6-7c83-42f2-ac8c-21ebd566bf59'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="73c1caa6-7c83-42f2-ac8c-21ebd566bf59"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b43380c4-f8bd-41bc-ac87-ba63dbf46ac7'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="b43380c4-f8bd-41bc-ac87-ba63dbf46ac7"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fdf833b-f66f-4923-9fd2-687d5b263bd6'>ToVector</a></td><td style='width:75%' class='def'><p><a name="7fdf833b-f66f-4923-9fd2-687d5b263bd6"></a></p>

<h3>Public Virtual <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoCore.KimonoShapeVector</a> ToVector ()</h3>

<h4>Summary</h4>

<p>Converts the star into a vector.</p>

<h4>Returns</h4>

<p>The <code>KimonoShapeVector</code> version of the star.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1aae0972-bd1e-4a3e-8a2b-dd33a0abcd7e'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="1aae0972-bd1e-4a3e-8a2b-dd33a0abcd7e"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="0d739674-182f-40f1-8820-eecceee22e57"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca"></a>
##Public Enum KimonoShapeState

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Holds the current state of a `KimonoShape` while it is being edited by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3bce4dc3-397c-4139-92a2-04ecf9ee8d05'>Constructing</a></td><td style='width:75%' ><p><a name="3bce4dc3-397c-4139-92a2-04ecf9ee8d05"></a>
<b>Public Static Constant <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> Constructing = <code>4</code></b></p>

<p>The shape is in the process of being built. For example, a set of shapes being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bdf952e-ede0-4823-8636-bb7fefd98ce2'>Editing</a></td><td style='width:75%' class='def'><p><a name="8bdf952e-ede0-4823-8636-bb7fefd98ce2"></a>
<b>Public Static Constant <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> Editing = <code>2</code></b></p>

<p>The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d2fe2e5-f30f-4a10-b49d-43895aebb5e3'>Finalizing</a></td><td style='width:75%' ><p><a name="5d2fe2e5-f30f-4a10-b49d-43895aebb5e3"></a>
<b>Public Static Constant <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> Finalizing = <code>3</code></b></p>

<p>The shape is leaving the edit mode and needs to be completed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac42d6ff-5363-4c83-8dab-46c0080c76ba'>Grouping</a></td><td style='width:75%' class='def'><p><a name="ac42d6ff-5363-4c83-8dab-46c0080c76ba"></a>
<b>Public Static Constant <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> Grouping = <code>5</code></b></p>

<p>The shape is being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a66a8e83-6762-497f-a348-d3bbc831e317'>Selected</a></td><td style='width:75%' ><p><a name="a66a8e83-6762-497f-a348-d3bbc831e317"></a>
<b>Public Static Constant <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> Selected = <code>1</code></b></p>

<p>The shape is being selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#62a74071-5a2d-47b0-b69b-c41ef1fb335d'>Unselected</a></td><td style='width:75%' class='def'><p><a name="62a74071-5a2d-47b0-b69b-c41ef1fb335d"></a>
<b>Public Static Constant <a href="#1d88302a-b5cf-4f1e-9a7b-50e4ecca88ca">KimonoCore.KimonoShapeState</a> Unselected = <code>0</code></b></p>

<p>The shape is unselected.</p>
</td></tr></table></p>


---

<a name="0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d"></a>
##Public Class KimonoShapeText

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a block of text into the Design Surface within the specifid bounds of this shape.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aa96c782-4bf2-4751-843f-822d3426dd64'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="aa96c782-4bf2-4751-843f-822d3426dd64"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b814232-9732-449b-ab7e-301dc1e59698'>FontFamilyName</a></td><td style='width:75%' class='def'><p><a name="2b814232-9732-449b-ab7e-301dc1e59698"></a></p>

<h3>Public <code>System.String</code> FontFamilyName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d875783e-1182-45c9-8f07-f654fc4440ca'>FontMetrics</a></td><td style='width:75%' ><p><a name="d875783e-1182-45c9-8f07-f654fc4440ca"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKFontMetrics</code> FontMetrics</h3>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9ce35c1-c36d-4793-9f17-47fe655ad1a0'>IsLinearText</a></td><td style='width:75%' class='def'><p><a name="e9ce35c1-c36d-4793-9f17-47fe655ad1a0"></a></p>

<h3>Public <code>System.Boolean</code> IsLinearText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dfc2c904-cdbe-4295-9c41-898ccca44466'>IsVerticalText</a></td><td style='width:75%' ><p><a name="dfc2c904-cdbe-4295-9c41-898ccca44466"></a></p>

<h3>Public <code>System.Boolean</code> IsVerticalText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aef69598-9b91-498c-93bd-c1c530a5eb36'>StrikeThruText</a></td><td style='width:75%' class='def'><p><a name="aef69598-9b91-498c-93bd-c1c530a5eb36"></a></p>

<h3>Public <code>System.Boolean</code> StrikeThruText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea4c8f35-ae2e-439f-8d02-e240f0ef74b8'>Text</a></td><td style='width:75%' ><p><a name="ea4c8f35-ae2e-439f-8d02-e240f0ef74b8"></a></p>

<h3>Public <code>System.String</code> Text</h3>

<h4>Summary</h4>

<p>Gets or sets the text.</p>

<h4>Return Value</h4>

<p>The text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07f593f8-55d3-4228-beb2-b3fe91203959'>TextAlign</a></td><td style='width:75%' class='def'><p><a name="07f593f8-55d3-4228-beb2-b3fe91203959"></a></p>

<h3>Public <code>SkiaSharp.SKTextAlign</code> TextAlign</h3>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1fe022e-1a3b-486f-85b7-970d99c6d003'>TextEncoding</a></td><td style='width:75%' ><p><a name="e1fe022e-1a3b-486f-85b7-970d99c6d003"></a></p>

<h3>Public <code>SkiaSharp.SKTextEncoding</code> TextEncoding</h3>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb5f14db-af57-43b7-81e5-ae2eff1a0913'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="cb5f14db-af57-43b7-81e5-ae2eff1a0913"></a></p>

<h3>Public <code>System.Single</code> TextScaleX</h3>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecaa4ba6-d30c-480b-ba37-9f93c88bd8ba'>TextSize</a></td><td style='width:75%' ><p><a name="ecaa4ba6-d30c-480b-ba37-9f93c88bd8ba"></a></p>

<h3>Public <code>System.Single</code> TextSize</h3>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#91647dbc-c8d6-4002-b156-4a21756478db'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="91647dbc-c8d6-4002-b156-4a21756478db"></a></p>

<h3>Public <code>System.Single</code> TextSkewX</h3>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2eb46d9-0f11-4fa1-8897-a9bb59f1fe14'>Typeface</a></td><td style='width:75%' ><p><a name="f2eb46d9-0f11-4fa1-8897-a9bb59f1fe14"></a></p>

<h3>Public <code>SkiaSharp.SKTypeface</code> Typeface</h3>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36684a79-9198-457f-903e-7087209ce947'>TypefaceStyle</a></td><td style='width:75%' class='def'><p><a name="36684a79-9198-457f-903e-7087209ce947"></a></p>

<h3>Public <code>SkiaSharp.SKTypefaceStyle</code> TypefaceStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c123d606-0f8f-4e64-8587-9dc23f6cd6c2'>UnderlineText</a></td><td style='width:75%' ><p><a name="c123d606-0f8f-4e64-8587-9dc23f6cd6c2"></a></p>

<h3>Public <code>System.Boolean</code> UnderlineText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#dd65687f-90e7-4704-af05-608f025d9fb8'>Clone</a></td><td style='width:75%' ><p><a name="dd65687f-90e7-4704-af05-608f025d9fb8"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57806ffc-e59c-4398-9652-72622ba23c85'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="57806ffc-e59c-4398-9652-72622ba23c85"></a></p>

<h3>Public Virtual Void DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="066a24af-222c-48c7-8270-9ce70f3c9ba7"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> with the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b7b23421-b972-4258-b906-2e6344308f29'>Draw</a></td><td style='width:75%' ><p><a name="b7b23421-b972-4258-b906-2e6344308f29"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the text block into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="6e82cf8f-b7ac-4331-a95b-0250b394d278"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bdd88828-ae73-446b-8627-2e58145ad5ae'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="bdd88828-ae73-446b-8627-2e58145ad5ae"></a></p>

<h3>Public Virtual Void GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Grows the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9f604c2f-260f-4d05-8764-3303b1e171fa"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to adjust the bounds by.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: Changing the bounds of a text box should optionally scale the size of the text within.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6f614a0-1586-4cf2-9083-1aa1182fb93b'>Initialize</a></td><td style='width:75%' ><p><a name="c6f614a0-1586-4cf2-9083-1aa1182fb93b"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75bd2be4-58d0-470c-8272-776017e1ac6f'>KimonoShapeText</a></td><td style='width:75%' class='def'><p><a name="75bd2be4-58d0-470c-8272-776017e1ac6f"></a></p>

<h3>Public Void KimonoShapeText ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a39208c2-b29e-4c18-bf6b-bccf3952f176'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="a39208c2-b29e-4c18-bf6b-bccf3952f176"></a></p>

<h3>Public Void KimonoShapeText (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="56791888-081f-420e-b480-ad9cf17751f2"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="7af00fa2-c5c5-4aef-92bc-0c214dfcfe8b"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="dd783015-19f7-4534-afee-005c368ee757"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="869a5e4b-4613-4784-9a15-5613e9f68ff8"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39b5236d-132c-4f95-b0e5-4b38d13b57ad'>KimonoShapeText</a></td><td style='width:75%' class='def'><p><a name="39b5236d-132c-4f95-b0e5-4b38d13b57ad"></a></p>

<h3>Public Void KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0eb1faa4-3ac2-46b9-9cd3-27c0e85f766d">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="be7b9030-0a5b-4d39-9046-fdd243361291"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="4026e5b0-adb5-413c-97d0-57d137a6b222"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="bdc590a0-11b5-40c7-9932-46ada782676b"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e76ebf9f-f345-47a8-b2e0-2ee1bcba9ff7"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="0cc78856-c7df-4dd3-97bc-dafd88ac6dbc"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#998cdcc2-2f38-456c-815b-1f99d1a2b45d'>ToCode</a></td><td style='width:75%' ><p><a name="998cdcc2-2f38-456c-815b-1f99d1a2b45d"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="4c2cee5e-bd8f-466b-aede-3524c2d3df4e"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="74f5b9d4-04d7-4422-95c8-80b56881dd3d"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="76580e04-189d-4dd2-a292-6e84c7c4f3de"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1897bbf-3abe-4616-9e29-8bf236eff849'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="a1897bbf-3abe-4616-9e29-8bf236eff849"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="4a6aa51d-0ae3-4015-89c3-691e4a3c3f84"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2011c00-9fd4-41c1-8786-cae75af6b5d1'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="a2011c00-9fd4-41c1-8786-cae75af6b5d1"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6897860-7e29-4761-a535-df126206da0d'>ToPath</a></td><td style='width:75%' class='def'><p><a name="a6897860-7e29-4761-a535-df126206da0d"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5cfa3e5-515c-41db-aa44-88371f86f005'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="e5cfa3e5-515c-41db-aa44-88371f86f005"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50357bca-afe9-423f-93f0-dea82221b606'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="50357bca-afe9-423f-93f0-dea82221b606"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d030ac3-3398-4cbd-8c5c-029561d75e3c'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="2d030ac3-3398-4cbd-8c5c-029561d75e3c"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="6a4f1f4e-ae24-4cdd-897f-f099cec2ecf6"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="4bdbf7c9-fd02-4ed0-b14b-6e5bef5d262a"></a>
##Public Class KimonoShapeTriangle

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

Draws a triangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3e2a8433-7880-4fe5-a2ce-11c3ec5b3152'>Clone</a></td><td style='width:75%' ><p><a name="3e2a8433-7880-4fe5-a2ce-11c3ec5b3152"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeTriangle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74983935-adc6-400f-8485-3f438c1dca68'>Draw</a></td><td style='width:75%' class='def'><p><a name="74983935-adc6-400f-8485-3f438c1dca68"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the triangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="8c61125b-5f0f-4d6c-bdc7-68251c24349a"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#365b42bf-aa5c-485c-8645-53cecebdcf4b'>Initialize</a></td><td style='width:75%' ><p><a name="365b42bf-aa5c-485c-8645-53cecebdcf4b"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1945f7df-ca22-478f-bccd-15050f709ca1'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p><a name="1945f7df-ca22-478f-bccd-15050f709ca1"></a></p>

<h3>Public Void KimonoShapeTriangle ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4bdbf7c9-fd02-4ed0-b14b-6e5bef5d262a">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4ee89b9-a81c-481d-bddd-ea68072d3056'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="d4ee89b9-a81c-481d-bddd-ea68072d3056"></a></p>

<h3>Public Void KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4bdbf7c9-fd02-4ed0-b14b-6e5bef5d262a">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="e359abc8-4e6a-4b37-bd54-c2ac6144bafd"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c8a934cd-d34f-449b-aa3a-3edc54d915f8"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="4fafcd9a-e57d-47ed-b5bb-e35ffe6be3d9"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="6d4fb8ab-a855-4b71-aa03-0275581aea4e"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6f0577d-2ac5-470f-9db8-0ce511d9e06b'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p><a name="d6f0577d-2ac5-470f-9db8-0ce511d9e06b"></a></p>

<h3>Public Void KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#4bdbf7c9-fd02-4ed0-b14b-6e5bef5d262a">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="b398ad7c-6909-4e45-82d0-829c9c15462a"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="77da5216-d4dd-4e86-9686-e887b36437e1"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2adf4ece-9f92-4728-9020-855e75edaa52"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b5c99b9f-9af1-46e0-b965-9c701e0c6793"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="8d861e8e-9c77-426f-9bac-3e868af0b3b5"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b132d2b-88a7-4679-aea6-1db4011d5f97'>ToCode</a></td><td style='width:75%' ><p><a name="3b132d2b-88a7-4679-aea6-1db4011d5f97"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="9ce683c8-7c8d-4f0f-8a66-8f241c408b7a"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="95913f83-54fc-4af7-93fe-7fcb8b44ccb2"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="cd65f005-cfcf-4520-8dff-3942770177e8"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25401eb5-5408-47e7-a5c1-a8b80add1e11'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="25401eb5-5408-47e7-a5c1-a8b80add1e11"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7b3fa0b9-775c-47c1-bdd5-725f911c32b6"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1e1e36c-fa7d-4c8a-8eb7-6b89669869db'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="d1e1e36c-fa7d-4c8a-8eb7-6b89669869db"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08db56fc-25ca-4b26-8cf6-bd18273ff1a2'>ToPath</a></td><td style='width:75%' class='def'><p><a name="08db56fc-25ca-4b26-8cf6-bd18273ff1a2"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7126198e-6aca-4ab9-81e0-5149b7fd04db'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="7126198e-6aca-4ab9-81e0-5149b7fd04db"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d90b333-7f97-4395-874b-b19496aba64f'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="6d90b333-7f97-4395-874b-b19496aba64f"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="f0e6cf79-ac13-4518-b06d-34c743043cf9"></a>
##Public Class KimonoShapeVector

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

[KimonoCore.KimonoShape](#f0af74e3-5275-47e0-9ddb-991cda8b3f33)

###Summary

A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ebcbe736-c4a1-4b5a-b48c-2ecb87726743'>Closed</a></td><td style='width:75%' ><p><a name="ebcbe736-c4a1-4b5a-b48c-2ecb87726743"></a></p>

<h3>Public <code>System.Boolean</code> Closed</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d880f00c-ad88-4f7c-8499-f67090035fcf'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="d880f00c-ad88-4f7c-8499-f67090035fcf"></a></p>

<h3>Public Virtual Read Only <code>System.Boolean</code> IsEditable</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35a1ee51-318b-4451-ae0d-863abd114be9'>Points</a></td><td style='width:75%' ><p><a name="35a1ee51-318b-4451-ae0d-863abd114be9"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;SkiaSharp.SKPoint&gt;</code> Points</h3>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#844bc7b8-78c8-402b-8b4f-5c041b0d28e9'>AddPoint</a></td><td style='width:75%' ><p><a name="844bc7b8-78c8-402b-8b4f-5c041b0d28e9"></a></p>

<h3>Public Void AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="0dab5ef4-7d59-4611-af12-7e91f5ca6ba3"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27858c2f-9894-4ac7-93ff-58b25cd6f0ea'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="27858c2f-9894-4ac7-93ff-58b25cd6f0ea"></a></p>

<h3>Public Void AddPoint (System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="fa7b1ffb-9541-4612-9dc4-154d31458e70"></a>
<b>System.Single x</b></p>

<p>The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="4b609d2d-bde2-429b-b6a0-43593d0bccc6"></a>
<b>System.Single y</b></p>

<p>The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eaeef39-9c1c-49ae-a0ef-9528a0b5cfc0'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="0eaeef39-9c1c-49ae-a0ef-9528a0b5cfc0"></a></p>

<h3>Private Void ApplyMoveAndScale ()</h3>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d0f5e11-07e6-4aed-991e-51ddeb6a9646'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="3d0f5e11-07e6-4aed-991e-51ddeb6a9646"></a></p>

<h3>Public Virtual Void BoundsChanged ()</h3>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e6e2618-e86b-4a30-9369-0ca90e986044'>Clone</a></td><td style='width:75%' ><p><a name="2e6e2618-e86b-4a30-9369-0ca90e986044"></a></p>

<h3>Public Virtual <a href="#1d07eefe-b52f-4276-a1c9-970a91ec6517">KimonoCore.KimonoBounds</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#052f83a0-060e-4aca-a6c3-bb5967ae7a59'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="052f83a0-060e-4aca-a6c3-bb5967ae7a59"></a></p>

<h3>Public Virtual Void DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9631d92d-ac9b-4270-b080-a6f7c1d72bd6"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d8ed106-732c-45aa-820a-3756acce3079'>Draw</a></td><td style='width:75%' ><p><a name="2d8ed106-732c-45aa-820a-3756acce3079"></a></p>

<h3>Public Virtual Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="580ad279-f4be-44ff-a2d7-ee9d439a64b1"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3f22ad45-172d-4649-bd11-e96e67cd788b'>Initialize</a></td><td style='width:75%' class='def'><p><a name="3f22ad45-172d-4649-bd11-e96e67cd788b"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92ae8778-30e6-4c17-87dc-bfc15b9d0c23'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="92ae8778-30e6-4c17-87dc-bfc15b9d0c23"></a></p>

<h3>Public Void KimonoShapeVector ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#520dec6a-f41f-4330-b470-03092d4b2566'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p><a name="520dec6a-f41f-4330-b470-03092d4b2566"></a></p>

<h3>Public Void KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="06a4b502-9016-4fa9-a288-71dd1492a0b2"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="8f489a3a-566c-4f6d-88fe-f0917fb7c7ed"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="132c1593-8310-4359-9f85-2a202cd991a2"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b4661265-1e62-4bf6-95f3-e1870b013938"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fd1c4e4-1848-4821-b221-8225986500e3'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="7fd1c4e4-1848-4821-b221-8225986500e3"></a></p>

<h3>Public Void KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f0e6cf79-ac13-4518-b06d-34c743043cf9">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="980ec120-d322-4174-b80d-6f418c778404"></a>
<b>System.Single left</b></p>

<p>Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c39be928-34cd-41c6-a8ac-8af81c9723e6"></a>
<b>System.Single top</b></p>

<p>Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="0d71b908-a4fb-43a8-8b6f-0fd9f1b0bf11"></a>
<b>System.Single right</b></p>

<p>Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="d40059ef-c213-4f2d-a5c6-f161fa000e83"></a>
<b>System.Single bottom</b></p>

<p>Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="1352a8f1-dd2a-44c1-8c02-0ffeef8f75ae"></a>
<b>KimonoCore.KimonoShapeState state</b></p>

<p>State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#514da65a-602f-48f1-91c7-3e1253c970a5'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="514da65a-602f-48f1-91c7-3e1253c970a5"></a></p>

<h3>Public Void MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="bebc6df3-def2-45c0-b32c-6294aafe8612"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eee08541-ae58-47e2-873f-0eff24009833'>PointInBound</a></td><td style='width:75%' ><p><a name="eee08541-ae58-47e2-873f-0eff24009833"></a></p>

<h3>Public Virtual <code>System.Boolean</code> PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9118e8dd-7d5b-4993-9bdb-470f4d027016"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5d35e2a-ce12-4a23-9899-59d53c225fa6'>RecalculateVectorBounds</a></td><td style='width:75%' class='def'><p><a name="b5d35e2a-ce12-4a23-9899-59d53c225fa6"></a></p>

<h3>Public Void RecalculateVectorBounds ()</h3>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ab7c4c2-af97-4843-ac89-546e2ec26ec2'>RemovePoint</a></td><td style='width:75%' ><p><a name="9ab7c4c2-af97-4843-ac89-546e2ec26ec2"></a></p>

<h3>Public Void RemovePoint (System.Int32)</h3>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="3e449bde-7069-448d-98b1-c55cd1d00443"></a>
<b>System.Int32 n</b></p>

<p>The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bda8ecf2-c7a8-48dd-90ad-e757f9e51926'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="bda8ecf2-c7a8-48dd-90ad-e757f9e51926"></a></p>

<h3>Public Virtual Void StartEditing ()</h3>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#daeffa38-ce4c-4f07-a090-555f5a1ffd6c'>ToCode</a></td><td style='width:75%' ><p><a name="daeffa38-ce4c-4f07-a090-555f5a1ffd6c"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="4afca4d0-47c9-44aa-a663-3878fd4eb7af"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="9e056027-2293-4ad4-90bd-790697b507ff"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f0feeba8-6249-4b1a-a425-c740bec201cb"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f11e524-0b13-47cc-bc8b-9ab3dbbfb319'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="0f11e524-0b13-47cc-bc8b-9ab3dbbfb319"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="3e964cb2-0a8d-4d82-b432-cc863cfc76f7"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81934341-3fbc-4942-aeec-9dab072e4d5b'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="81934341-3fbc-4942-aeec-9dab072e4d5b"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7d6831b-d78a-4cfe-8c79-209b53e7e3ff'>ToPath</a></td><td style='width:75%' class='def'><p><a name="e7d6831b-d78a-4cfe-8c79-209b53e7e3ff"></a></p>

<h3>Public Virtual <code>SkiaSharp.SKPath</code> ToPath ()</h3>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30aed100-b858-4489-988b-0ffecb0ddc94'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="30aed100-b858-4489-988b-0ffecb0ddc94"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cf2dad3-1b69-47bb-bf5b-6951fbfeca68'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="5cf2dad3-1b69-47bb-bf5b-6951fbfeca68"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>


---

<a name="f7ebfad5-f255-46f0-aca0-49cbc8cbc20d"></a>
##Public Class KimonoSketch

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Holds a collection of `KimonoShapes` that are used to create a given image using Skia.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8482ee71-8b9b-4dd9-8981-09eba6e0c26b'>_canvasColor</a></td><td style='width:75%' ><p><a name="8482ee71-8b9b-4dd9-8981-09eba6e0c26b"></a>
<b>Private <code>SkiaSharp.SKColor</code> _canvasColor</b></p>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f54fe7d-66c3-4661-a512-bff6a6dff3ba'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="4f54fe7d-66c3-4661-a512-bff6a6dff3ba"></a>
<b>Private <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> _selectedShape</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d89fe217-46f2-482a-b54b-00ab3f188f92'>_tool</a></td><td style='width:75%' ><p><a name="d89fe217-46f2-482a-b54b-00ab3f188f92"></a>
<b>Private <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> _tool</b></p>

<p>The currently <code>KimonoTool</code> that will be used to edit the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09e7538f-15a3-4a0f-8f3c-646819e53008'>IgnoreDrag</a></td><td style='width:75%' class='def'><p><a name="09e7538f-15a3-4a0f-8f3c-646819e53008"></a>
<b>Private <code>System.Boolean</code> IgnoreDrag</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#174c0c59-6346-495d-9536-1d19d75c9b7a'>ImageBufferNeedsRefresh</a></td><td style='width:75%' ><p><a name="174c0c59-6346-495d-9536-1d19d75c9b7a"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ImageBufferNeedsRefresh</b></p>

<p>The private <code>ImageBufferNeedsRefresh</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25e8de70-0094-4031-b72a-d9df1aca1cd2'>PerformingDrag</a></td><td style='width:75%' class='def'><p><a name="25e8de70-0094-4031-b72a-d9df1aca1cd2"></a>
<b>Private <code>System.Boolean</code> PerformingDrag</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04767490-9854-444d-a2dc-b8c85a7e04b0'>PreviousSize</a></td><td style='width:75%' ><p><a name="04767490-9854-444d-a2dc-b8c85a7e04b0"></a>
<b>Private <code>SkiaSharp.SKSize</code> PreviousSize</b></p>

<p>The size of the previous of a sketch for a rezise operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cff1a19a-0c3a-4e18-8448-2df769357b1f'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="cff1a19a-0c3a-4e18-8448-2df769357b1f"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> RequestNewUndoPoint</b></p>

<p>The private <code>RequestNewUndoPoint</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae8c1403-cd28-4538-acd2-092cdb0befd6'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="ae8c1403-cd28-4538-acd2-092cdb0befd6"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SelectedShapeModified</b></p>

<p>The private <code>SelectedShapeModified</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b77bd0d-5f86-40fb-aebf-762a1f05c012'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="2b77bd0d-5f86-40fb-aebf-762a1f05c012"></a>
<b>Private <a href="#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0">KimonoCore.Kimono.ShapeEventDelegate</a> SelectionChanged</b></p>

<p>The private <code>SelectionChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.ShapeEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f4427a7-de4a-4f64-9b30-3b5d4a784c82'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="9f4427a7-de4a-4f64-9b30-3b5d4a784c82"></a>
<b><a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> ShapeUnderConstruction</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d258fe35-0270-4a8c-bb2a-41ce5e74758c'>Size</a></td><td style='width:75%' class='def'><p><a name="d258fe35-0270-4a8c-bb2a-41ce5e74758c"></a>
<b>Private <code>SkiaSharp.SKSize</code> Size</b></p>

<p>The current size of the sketch</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9774baf-6d58-4105-8866-4521c18b570e'>SketchModified</a></td><td style='width:75%' ><p><a name="d9774baf-6d58-4105-8866-4521c18b570e"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchModified</b></p>

<p>The private <code>SketchModified</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57ba9513-4a6a-403d-b580-3e166bb621f4'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="57ba9513-4a6a-403d-b580-3e166bb621f4"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchSizeChanged</b></p>

<p>The private <code>SketchSizeChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dce0bf81-b510-4c23-8acc-7fa75123fc01'>ToolChanged</a></td><td style='width:75%' ><p><a name="dce0bf81-b510-4c23-8acc-7fa75123fc01"></a>
<b>Private <a href="#64878777-41f3-4e4a-9955-da97b723a057">KimonoCore.Kimono.ToolEventDelegate</a> ToolChanged</b></p>

<p>The private <code>ToolChanged</code> field of the <code>KimonoSketch</code> class holds a <code>KimonoCore.Kimono.ToolEventDelegate</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78e4784e-b2de-436f-a553-d0f761bef005'>ToolDownAt</a></td><td style='width:75%' class='def'><p><a name="78e4784e-b2de-436f-a553-d0f761bef005"></a>
<b>Private <code>SkiaSharp.SKPoint</code> ToolDownAt</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#13ce1c76-3677-4015-92f1-b977aa37f044'>CanAlignShapes</a></td><td style='width:75%' ><p><a name="13ce1c76-3677-4015-92f1-b977aa37f044"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanAlignShapes</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether alignment can be applied on a set of shapes.</p>

<h4>Return Value</h4>

<p><code>true</code> if can align shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#964c1aff-28d3-4543-b3b8-c557432dbb36'>CanGroupShapes</a></td><td style='width:75%' class='def'><p><a name="964c1aff-28d3-4543-b3b8-c557432dbb36"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanGroupShapes</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be grouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#14109812-b729-4850-af4b-257113e0ba0b'>CanUngroupShapes</a></td><td style='width:75%' ><p><a name="14109812-b729-4850-af4b-257113e0ba0b"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanUngroupShapes</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be ungrouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03e2eeeb-ba1f-44de-8df8-25242a3d205c'>CanvasColor</a></td><td style='width:75%' class='def'><p><a name="03e2eeeb-ba1f-44de-8df8-25242a3d205c"></a></p>

<h3>Public <code>SkiaSharp.SKColor</code> CanvasColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the canvas.</p>

<h4>Return Value</h4>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c23ad2b-ed99-49cf-bcc8-30d300ac6f3e'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="9c23ad2b-ed99-49cf-bcc8-30d300ac6f3e"></a></p>

<h3>Public Read Only <a href="#60cba3d0-f26e-4095-ae97-6368fb3d255a">KimonoCore.KimonoShapeGroup</a> DeeplySelectedGroup</h3>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1f435ee-349c-47cc-8ba4-0e91e9f14eb2'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="d1f435ee-349c-47cc-8ba4-0e91e9f14eb2"></a></p>

<h3>Public Read Only <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> DeeplySelectedShape</h3>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0fc29527-3e28-4031-bebf-4c48e4240775'>DrawCanvas</a></td><td style='width:75%' ><p><a name="0fc29527-3e28-4031-bebf-4c48e4240775"></a></p>

<h3>Public <code>System.Boolean</code> DrawCanvas</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoSketch</a> should draw  the canvas when it is included in another sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if draw canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d44e53ac-7d75-46af-912d-e9b46633e42e'>ElementName</a></td><td style='width:75%' class='def'><p><a name="d44e53ac-7d75-46af-912d-e9b46633e42e"></a></p>

<h3>Private <code>System.String</code> ElementName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8b2e45b-d350-4705-81cc-ae7e044ec5ec'>GenerateCodeToOuputBitmapImage</a></td><td style='width:75%' ><p><a name="b8b2e45b-d350-4705-81cc-ae7e044ec5ec"></a></p>

<h3>Public <code>System.Boolean</code> GenerateCodeToOuputBitmapImage</h3>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as a OS specific bitmap image.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput bitmap image; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e1093e2-6d98-4970-a6c9-9261bcd89a64'>GenerateCodeToOuputSkiaData</a></td><td style='width:75%' class='def'><p><a name="2e1093e2-6d98-4970-a6c9-9261bcd89a64"></a></p>

<h3>Public <code>System.Boolean</code> GenerateCodeToOuputSkiaData</h3>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the SkiaSharp Data (<code>SKData[]</code>) representing the Sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput skia data; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7c7e52b-3815-49f8-a7d1-7c42663494e3'>GenerateCodeToOuputToCanvas</a></td><td style='width:75%' ><p><a name="e7c7e52b-3815-49f8-a7d1-7c42663494e3"></a></p>

<h3>Public <code>System.Boolean</code> GenerateCodeToOuputToCanvas</h3>

<h4>Summary</h4>

<p>When converting this Sketch to source code, ouput a method that draws into the given SkiaSharp Canvas.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4415de51-3bde-432c-9089-637770d2b90b'>GenerateCodeToOuputToSkiaSharpViews</a></td><td style='width:75%' class='def'><p><a name="4415de51-3bde-432c-9089-637770d2b90b"></a></p>

<h3>Public <code>System.Boolean</code> GenerateCodeToOuputToSkiaSharpViews</h3>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as class based on the <code>SkiaSharp.Views</code> extension library.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to skia sharp views; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4872f89d-5920-4c2e-a3e7-41c584fdd0ab'>Height</a></td><td style='width:75%' ><p><a name="4872f89d-5920-4c2e-a3e7-41c584fdd0ab"></a></p>

<h3>Public <code>System.Single</code> Height</h3>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1eaba453-8ff5-419b-b60c-bce5fa25018d'>Name</a></td><td style='width:75%' class='def'><p><a name="1eaba453-8ff5-419b-b60c-bce5fa25018d"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8216f8c-b0fa-4034-9c33-4804be1b70c4'>Portfolio</a></td><td style='width:75%' ><p><a name="f8216f8c-b0fa-4034-9c33-4804be1b70c4"></a></p>

<h3>Public <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoCore.KimonoPortfolio</a> Portfolio</h3>

<h4>Summary</h4>

<p>Gets or sets the portfolio that this sketch belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0fa486c-d5e2-43d3-92d3-fd800a9985aa'>SelectedShape</a></td><td style='width:75%' class='def'><p><a name="c0fa486c-d5e2-43d3-92d3-fd800a9985aa"></a></p>

<h3>Public <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> SelectedShape</h3>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fa568f5-9b1d-43b3-a9d9-ec83731a9a06'>SelectedShapeAtBottom</a></td><td style='width:75%' ><p><a name="7fa568f5-9b1d-43b3-a9d9-ec83731a9a06"></a></p>

<h3>Public Read Only <code>System.Boolean</code> SelectedShapeAtBottom</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1462702f-44c9-4049-8d68-ef7a53115c25'>SelectedShapeAtTop</a></td><td style='width:75%' class='def'><p><a name="1462702f-44c9-4049-8d68-ef7a53115c25"></a></p>

<h3>Public Read Only <code>System.Boolean</code> SelectedShapeAtTop</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#708d71ce-85bd-42f4-af82-69b0d44e571c'>Shapes</a></td><td style='width:75%' ><p><a name="708d71ce-85bd-42f4-af82-69b0d44e571c"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoShape&gt;</code> Shapes</h3>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ffcaff1-9f66-4a33-aab0-3902d69d0772'>Tool</a></td><td style='width:75%' class='def'><p><a name="5ffcaff1-9f66-4a33-aab0-3902d69d0772"></a></p>

<h3>Public <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Tool</h3>

<h4>Summary</h4>

<p>Gets or sets the tool.</p>

<h4>Return Value</h4>

<p>The tool.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fbc2644-2be2-417a-b948-53b6f5e64aea'>UniqueID</a></td><td style='width:75%' ><p><a name="5fbc2644-2be2-417a-b948-53b6f5e64aea"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d20d7f7-182a-418d-b4c5-c5510a65e7e1'>Width</a></td><td style='width:75%' class='def'><p><a name="0d20d7f7-182a-418d-b4c5-c5510a65e7e1"></a></p>

<h3>Public <code>System.Single</code> Width</h3>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ce8f8c9d-db65-413a-8748-4003956335e9'>AddShape</a></td><td style='width:75%' ><p><a name="ce8f8c9d-db65-413a-8748-4003956335e9"></a></p>

<h3>Public Void AddShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Adds the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="8182c1a4-9c9c-44eb-ab82-23c7ecfdb174"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5429e14c-aab7-4c15-97b0-4cff749a0a30'>ApplySizeChange</a></td><td style='width:75%' class='def'><p><a name="5429e14c-aab7-4c15-97b0-4cff749a0a30"></a></p>

<h3>Private Void ApplySizeChange ()</h3>

<h4>Summary</h4>

<p>Applies the size change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e93b5f08-9057-469a-979c-21c77aa62513'>BuildCSharpCrossPlatformToImage</a></td><td style='width:75%' ><p><a name="e93b5f08-9057-469a-979c-21c77aa62513"></a></p>

<h3>Public Virtual <code>System.String</code> BuildCSharpCrossPlatformToImage (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Builds the C# ToImage method for Cross Platform image support.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="1f94bbd0-1a8d-4290-a122-d14a88838b33"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Conditionally compiled code to support all of the different image types.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36fb86a2-3bc3-4a21-9075-b6ad061e5c89'>BuildCsharpToBitmapImage</a></td><td style='width:75%' class='def'><p><a name="36fb86a2-3bc3-4a21-9075-b6ad061e5c89"></a></p>

<h3>Public Virtual <code>System.String</code> BuildCsharpToBitmapImage (KimonoCore.CodeOutputOS)</h3>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to OS specific bitmap image format.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="11ff90f4-a422-4ba2-bf83-2c20cfd6d229"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>Output os.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Sketch as a platform specific image.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b55490eb-cb20-4741-8377-fae209245caf'>BuildCsharpToCanvasMethod</a></td><td style='width:75%' ><p><a name="b55490eb-cb20-4741-8377-fae209245caf"></a></p>

<h3>Public Virtual <code>System.String</code> BuildCsharpToCanvasMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Build the method to draw into a specific SkiaSharp Canvas in C# source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f2ce2c10-2ff8-4f3d-883e-a18f9c580943"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the method.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#321d7fb3-3ad2-43d1-b826-ece78f6921e0'>BuildCsharpToSkiaDataMethod</a></td><td style='width:75%' class='def'><p><a name="321d7fb3-3ad2-43d1-b826-ece78f6921e0"></a></p>

<h3>Public Virtual <code>System.String</code> BuildCsharpToSkiaDataMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to SkiaSharp data (<code>SKData</code>).</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b9c70603-ab1e-446c-951b-60bb76ea57c4"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Sketch as <code>SKData</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1250fde-5ade-4e45-9be8-935cd97608f2'>Clone</a></td><td style='width:75%' ><p><a name="f1250fde-5ade-4e45-9be8-935cd97608f2"></a></p>

<h3>Public <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoCore.KimonoSketch</a> Clone ()</h3>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1df75f94-6f8e-4446-8442-4753b0c508a5'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="1df75f94-6f8e-4446-8442-4753b0c508a5"></a></p>

<h3>Public Void DeleteSelectedShape ()</h3>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b765621-9a46-404c-8d60-ad7d4c2d4111'>DeselectAll</a></td><td style='width:75%' ><p><a name="9b765621-9a46-404c-8d60-ad7d4c2d4111"></a></p>

<h3>Public Void DeselectAll ()</h3>

<h4>Summary</h4>

<p>Deselects all shapes in the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e120f53-d93a-4f7f-b526-8aebd6ac405d'>Draw</a></td><td style='width:75%' class='def'><p><a name="7e120f53-d93a-4f7f-b526-8aebd6ac405d"></a></p>

<h3>Public <code>SkiaSharp.SKData</code> Draw ()</h3>

<h4>Summary</h4>

<p>The public <code>Draw ()</code> member of the <code>KimonoSketch</code> class returns a <code>SkiaSharp.SKData</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba479091-2a61-4b34-b8c1-8c46c7fbedcf'>Draw</a></td><td style='width:75%' ><p><a name="ba479091-2a61-4b34-b8c1-8c46c7fbedcf"></a></p>

<h3>Public Void Draw (SkiaSharp.SKCanvas)</h3>

<h4>Summary</h4>

<p>Draw this sketch into the give SkiaSharp canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="4282acd7-e691-4dee-b9b1-987e20b7841f"></a>
<b>SkiaSharp.SKCanvas canvas</b></p>

<p>The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc073911-533e-4b79-a69e-2d4df45cd3d6'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="bc073911-533e-4b79-a69e-2d4df45cd3d6"></a></p>

<h3>Public Void DuplicateSelectedShape ()</h3>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f266f74e-e31c-41e9-9312-70df8cdc879a'>FindShape</a></td><td style='width:75%' ><p><a name="f266f74e-e31c-41e9-9312-70df8cdc879a"></a></p>

<h3>Public <a href="#f0af74e3-5275-47e0-9ddb-991cda8b3f33">KimonoCore.KimonoShape</a> FindShape (System.String)</h3>

<h4>Summary</h4>

<p>Finds the shape specified by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="290e4b0e-60ed-41b4-aeca-60a435a15c79"></a>
<b>System.String uniqueID</b></p>

<p>Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>If found, the <code>KimonoShape</code> will be returned, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7084bb9a-4774-4204-9247-92d2ad62fcea'>GroupUngroupSelectedShapes</a></td><td style='width:75%' class='def'><p><a name="7084bb9a-4774-4204-9247-92d2ad62fcea"></a></p>

<h3>Public Void GroupUngroupSelectedShapes ()</h3>

<h4>Summary</h4>

<p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aacf73af-f375-43df-8c85-c37d1ccde7fc'>Initialize</a></td><td style='width:75%' ><p><a name="aacf73af-f375-43df-8c85-c37d1ccde7fc"></a></p>

<h3>Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#547ff602-51ec-46cb-8381-d57011c32f2f'>KimonoSketch</a></td><td style='width:75%' class='def'><p><a name="547ff602-51ec-46cb-8381-d57011c32f2f"></a></p>

<h3>Public Void KimonoSketch ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4dd3a9ec-0c03-4997-ad51-3810f32ee970'>KimonoSketch</a></td><td style='width:75%' ><p><a name="4dd3a9ec-0c03-4997-ad51-3810f32ee970"></a></p>

<h3>Public Void KimonoSketch (System.String, System.Single, System.Single)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f7ebfad5-f255-46f0-aca0-49cbc8cbc20d">KimonoSketch</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="eedcbeb7-6bc6-4a48-a36c-413783504d3c"></a>
<b>System.String name</b></p>

<p>Name.</p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p><a name="3e1ef1dc-4ed9-4ae6-8de5-a3b4e9fe9ebb"></a>
<b>System.Single width</b></p>

<p>Width.</p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p><a name="77cb0f51-a2ef-4f4d-b120-eec4db1517bf"></a>
<b>System.Single height</b></p>

<p>Height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4bee770c-9392-43c7-b895-5d4fdc10d145'>MoveSelectedShapeBackwards</a></td><td style='width:75%' class='def'><p><a name="4bee770c-9392-43c7-b895-5d4fdc10d145"></a></p>

<h3>Public Void MoveSelectedShapeBackwards ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#037a81ff-41a7-40b8-9fc9-cf0a9345c43d'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="037a81ff-41a7-40b8-9fc9-cf0a9345c43d"></a></p>

<h3>Public Void MoveSelectedShapeForwards ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdb34d78-e244-41b4-99a0-a8e58ee7bf72'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="cdb34d78-e244-41b4-99a0-a8e58ee7bf72"></a></p>

<h3>Public Void MoveSelectedShapeToBottom ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75fdf783-7437-49eb-820a-f2aad6d2a569'>MoveSelectedShapeToTop</a></td><td style='width:75%' ><p><a name="75fdf783-7437-49eb-820a-f2aad6d2a569"></a></p>

<h3>Public Void MoveSelectedShapeToTop ()</h3>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc1d07e9-750a-44ff-97b1-56be23ff9b47'>PortfolioSketchMethods</a></td><td style='width:75%' class='def'><p><a name="cc1d07e9-750a-44ff-97b1-56be23ff9b47"></a></p>

<h3>Public Virtual Void PortfolioSketchMethods (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary, System.String&amp;, System.String&amp;)</h3>

<h4>Summary</h4>

<p>Returns the methods that a portfolio will use to draw the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="13c4fec6-5fb7-4a26-b906-ee6702957c45"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code> to generate code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="2e97c748-1754-404e-8d99-d6a4a57d4891"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>Ref privateMethodsCode</td><td style='width:75%' ><p><a name="dabdae83-638f-427a-bdf1-cc819bbd9236"></a>
<b>System.String Ref privateMethodsCode</b></p>

<p>The private methods required by this sketch.</p>
</td></tr><tr><td style='width:25%' class='term'>Ref publicMethodsCode</td><td style='width:75%' class='def'><p><a name="76dbfd63-2ba7-4015-aad5-0685ef423dd0"></a>
<b>System.String Ref publicMethodsCode</b></p>

<p>The public methods required by this sketch.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ffc8f15-dc3b-43f5-bf15-b1132e2ae1ba'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' ><p><a name="0ffc8f15-dc3b-43f5-bf15-b1132e2ae1ba"></a></p>

<h3>Void RaiseImageBufferNeedsRefresh ()</h3>

<h4>Summary</h4>

<p>Raises the image buffer needs refresh event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bde25417-c1e1-4ec2-85a5-3f4c8f9bf3ca'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="bde25417-c1e1-4ec2-85a5-3f4c8f9bf3ca"></a></p>

<h3>Void RaiseRequestNewUndoPoint ()</h3>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd519b7d-e2f6-450f-a765-625fb5a1753b'>RaiseSelectedShapeModified</a></td><td style='width:75%' ><p><a name="cd519b7d-e2f6-450f-a765-625fb5a1753b"></a></p>

<h3>Void RaiseSelectedShapeModified ()</h3>

<h4>Summary</h4>

<p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#83807460-c6f5-4c0f-b629-192bdc0d30f3'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="83807460-c6f5-4c0f-b629-192bdc0d30f3"></a></p>

<h3>Void RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="86d6cd1c-5cc6-4e90-be60-804233105a11"></a>
<b>KimonoCore.KimonoShape selected</b></p>

<p>Selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c30a086-e7f5-487d-bf97-97fca22f9af3'>RaiseSketchModified</a></td><td style='width:75%' ><p><a name="1c30a086-e7f5-487d-bf97-97fca22f9af3"></a></p>

<h3>Void RaiseSketchModified ()</h3>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a5a5cda-4b7f-4ccb-abef-f5207197d2ef'>RaiseSketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="8a5a5cda-4b7f-4ccb-abef-f5207197d2ef"></a></p>

<h3>Void RaiseSketchSizeChanged ()</h3>

<h4>Summary</h4>

<p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72745622-be4f-4096-ac41-b2d2b26b1180'>RaiseToolChanged</a></td><td style='width:75%' ><p><a name="72745622-be4f-4096-ac41-b2d2b26b1180"></a></p>

<h3>Void RaiseToolChanged (KimonoCore.KimonoTool)</h3>

<h4>Summary</h4>

<p>Raises the tool changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="b24c0154-21e8-4f4d-8527-753a7efce7a7"></a>
<b>KimonoCore.KimonoTool tool</b></p>

<p>The new <code>KimonoTool</code> that has been selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb21db75-7921-4d3d-abc3-8a8e99eefb44'>RecalculateLayerDepths</a></td><td style='width:75%' class='def'><p><a name="bb21db75-7921-4d3d-abc3-8a8e99eefb44"></a></p>

<h3>Public Void RecalculateLayerDepths ()</h3>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de7d1ca0-3fc5-4d60-9518-703878be45b6'>RelinkShape</a></td><td style='width:75%' ><p><a name="de7d1ca0-3fc5-4d60-9518-703878be45b6"></a></p>

<h3>Void RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Relinks the given shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="d77c9b0f-275a-4cf3-9004-9fc732296363"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#831935ab-9a72-49f3-8e6f-6f456761eceb'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="831935ab-9a72-49f3-8e6f-6f456761eceb"></a></p>

<h3>Public Void RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="faf799c0-593d-411a-bd7f-580ff511f4df"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d10f27c6-aa49-46b9-a7b8-58053a865cf1'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="d10f27c6-aa49-46b9-a7b8-58053a865cf1"></a></p>

<h3>Public Void RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="c82c1db2-409a-4a43-844e-0378a21866f0"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55f74c48-7052-42ae-b9ef-106f45f5325d'>SavePreviousSize</a></td><td style='width:75%' class='def'><p><a name="55f74c48-7052-42ae-b9ef-106f45f5325d"></a></p>

<h3>Private Void SavePreviousSize ()</h3>

<h4>Summary</h4>

<p>Saves the previous size of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7287e157-92e3-4b39-8b82-21ed08e3f53a'>SelectShape</a></td><td style='width:75%' ><p><a name="7287e157-92e3-4b39-8b82-21ed08e3f53a"></a></p>

<h3>Public Void SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Summary</h4>

<p>Selects the given shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="886a4984-1603-4d8b-b3d4-6efa11c403a9"></a>
<b>KimonoCore.KimonoShape shape</b></p>

<p>The <code>KimonoShape</code> to select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e0e31cd-0034-4334-b305-fe78fb780aaf'>ToCode</a></td><td style='width:75%' class='def'><p><a name="8e0e31cd-0034-4334-b305-fe78fb780aaf"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="260f7c9a-2681-4d44-a823-293622016b23"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="c5ed6547-3bdb-4cc9-a9fc-b6f08925a893"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="db162cfe-137f-4fc6-8602-626c3f6fe716"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9ed8d90-6d07-4638-ab9f-0ac5e5f89991'>ToCSharp</a></td><td style='width:75%' ><p><a name="d9ed8d90-6d07-4638-ab9f-0ac5e5f89991"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="fea542d9-301c-401c-b64c-f747aefdef6b"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#500e7c12-7765-4384-97e2-0625bef0969f'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="500e7c12-7765-4384-97e2-0625bef0969f"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a7511e61-cd76-41ed-b867-85642db84378"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' class='def'><p><a name="9ab34e4a-c174-42b7-bd86-c9ce368666c3"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputOS</code> parameter of the ToCSharp method takes a <code>KimonoCore.CodeOutputOS</code> value. </p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="cab76570-6cb6-4e1b-acc9-36394c59a3a1"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>outputLanguage</code> parameter of the ToCSharp method takes a <code>KimonoCore.CodeOutputLanguage</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8feac88b-cb73-4df4-ad95-4c1da8a7f40d'>ToCSharpKimono</a></td><td style='width:75%' ><p><a name="8feac88b-cb73-4df4-ad95-4c1da8a7f40d"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="b10f8b21-94dd-417b-8719-9ddff731cdb2"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="6fe73f43-d285-40e6-bded-8fe9cbce087b"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0351fb2b-10cb-451e-87be-82e0d2bd6453"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a8daa4b-6dda-40ec-a3eb-60d41e26ff77'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="7a8daa4b-6dda-40ec-a3eb-60d41e26ff77"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="87ca054d-9f4a-4c24-b838-8e205b79ce5f"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="5490422b-85ed-4675-8260-0b0b98909605"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce4a7093-0346-4172-8bb1-11147320a5c9'>ToImage</a></td><td style='width:75%' ><p><a name="ce4a7093-0346-4172-8bb1-11147320a5c9"></a></p>

<h3>Public <code>AppKit.NSImage</code> ToImage ()</h3>

<h4>Summary</h4>

<p>Converts the sketch to a bitmap image.</p>

<h4>Returns</h4>

<p>The <code>NSImage</code> representation of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3e855e5a-9cf4-48b9-b97b-de206113eceb'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="3e855e5a-9cf4-48b9-b97b-de206113eceb"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df27581a-4ce5-4656-97d7-f3162de9c032'>ToolDown</a></td><td style='width:75%' ><p><a name="df27581a-4ce5-4656-97d7-f3162de9c032"></a></p>

<h3>Public Void ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="135bce11-385b-40e0-a187-16b4b1dd60eb"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="60b06003-0540-4582-8e32-7dcab4c517f7"></a>
<b>System.Int32 clicks</b></p>

<p>The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="7489d37b-de98-444f-9c12-3388e3b10cd1"></a>
<b>System.Boolean multiSelect</b></p>

<p>If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddc47329-f775-4a14-b3b5-c554c1403853'>ToolDrag</a></td><td style='width:75%' class='def'><p><a name="ddc47329-f775-4a14-b3b5-c554c1403853"></a></p>

<h3>Public Void ToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Handle the user dragging the selected <code>KimonoTool</code> on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="42d5f45a-20f1-4bda-8218-5c17ef7d09f7"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> representing the new tool position on the Design Surface.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#409a7026-197b-4a5e-ae12-2fcdffaccbee'>ToolUp</a></td><td style='width:75%' ><p><a name="409a7026-197b-4a5e-ae12-2fcdffaccbee"></a></p>

<h3>Public Void ToolUp (SkiaSharp.SKPoint)</h3>

<h4>Summary</h4>

<p>Handles the user lifting the current <code>KimonoTool</code> off of the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="a37c5dc8-22de-44f9-97f6-f3dc4c4c775d"></a>
<b>SkiaSharp.SKPoint point</b></p>

<p>The <code>SKPoint</code> where the user lifted up the tool.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57fab6f4-0e16-4394-8b19-31b317edca4e'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="57fab6f4-0e16-4394-8b19-31b317edca4e"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23156eb1-9af2-4bad-89bd-dc6363492de7'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="23156eb1-9af2-4bad-89bd-dc6363492de7"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#71825052-e275-41f7-903f-f7e774d6d81b'>ImageBufferNeedsRefresh</a></td><td style='width:75%' ><p><a name="71825052-e275-41f7-903f-f7e774d6d81b"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> ImageBufferNeedsRefresh</h3>

<h4>Summary</h4>

<p>Occurs when image buffer needs refresh.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#feffca35-643f-4216-a44f-c708326f170c'>RequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="feffca35-643f-4216-a44f-c708326f170c"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> RequestNewUndoPoint</h3>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7af7c505-368a-410e-80b1-621afe8b871c'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="7af7c505-368a-410e-80b1-621afe8b871c"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SelectedShapeModified</h3>

<h4>Summary</h4>

<p>Occurs when selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd8ef266-86c4-470b-a534-d6e5e7145c75'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="fd8ef266-86c4-470b-a534-d6e5e7145c75"></a></p>

<h3><a href="#9c9c8a67-4f24-49e4-a08a-92d4a717f2a0">KimonoCore.Kimono.ShapeEventDelegate</a> SelectionChanged</h3>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ad0bb20-bc59-44e3-a06f-f6b5f6f74267'>SketchModified</a></td><td style='width:75%' ><p><a name="1ad0bb20-bc59-44e3-a06f-f6b5f6f74267"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchModified</h3>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5e9f6b6-b43e-48f8-ac2c-12ac1e1c5495'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="a5e9f6b6-b43e-48f8-ac2c-12ac1e1c5495"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> SketchSizeChanged</h3>

<h4>Summary</h4>

<p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1dd95d74-7fd0-427b-b347-265fdf26372e'>ToolChanged</a></td><td style='width:75%' ><p><a name="1dd95d74-7fd0-427b-b347-265fdf26372e"></a></p>

<h3><a href="#64878777-41f3-4e4a-9955-da97b723a057">KimonoCore.Kimono.ToolEventDelegate</a> ToolChanged</h3>

<h4>Summary</h4>

<p>Occurs when tool changed.</p>
</td></tr></table></p>


---

<a name="58a59d79-7f6c-41a4-a720-ef39b100168e"></a>
##Public Class KimonoStyle

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines as style that can be applied to a `KimonoShape` to control its appearance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#53bf9218-b810-4f28-819a-933816fe7df0'>_fillBlur</a></td><td style='width:75%' ><p><a name="53bf9218-b810-4f28-819a-933816fe7df0"></a>
<b>Private <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoCore.KimonoBlur</a> _fillBlur</b></p>

<p>The fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd3136ff-dde5-432d-8aa9-0aa958facaa8'>_fillColor</a></td><td style='width:75%' class='def'><p><a name="cd3136ff-dde5-432d-8aa9-0aa958facaa8"></a>
<b>Private <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> _fillColor</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's fill color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96242efd-d4ae-4fa9-a299-cfa44fa76413'>_fillGradient</a></td><td style='width:75%' ><p><a name="96242efd-d4ae-4fa9-a299-cfa44fa76413"></a>
<b>Private <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> _fillGradient</b></p>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a48248a-d514-4600-a3e8-4615fbd27576'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="6a48248a-d514-4600-a3e8-4615fbd27576"></a>
<b>Private <code>System.Single</code> _fillJitterDeviation</b></p>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cde6edc-8ff1-4eab-81c2-311aa5651272'>_fillJitterLength</a></td><td style='width:75%' ><p><a name="2cde6edc-8ff1-4eab-81c2-311aa5651272"></a>
<b>Private <code>System.Single</code> _fillJitterLength</b></p>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f400796-3e3c-414a-a9fc-3fcc5872a1de'>_fillShadow</a></td><td style='width:75%' class='def'><p><a name="7f400796-3e3c-414a-a9fc-3fcc5872a1de"></a>
<b>Private <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoCore.KimonoShadow</a> _fillShadow</b></p>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b71a11e-e4d8-4261-bc1b-f2b57fe04d62'>_frameBlur</a></td><td style='width:75%' ><p><a name="3b71a11e-e4d8-4261-bc1b-f2b57fe04d62"></a>
<b>Private <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoCore.KimonoBlur</a> _frameBlur</b></p>

<p>The frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c981074-d98e-4411-976e-02bbb5ba7157'>_frameColor</a></td><td style='width:75%' class='def'><p><a name="3c981074-d98e-4411-976e-02bbb5ba7157"></a>
<b>Private <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> _frameColor</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's frame color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79ceb233-9005-442f-97f1-b16b4ae0b2b1'>_frameGradient</a></td><td style='width:75%' ><p><a name="79ceb233-9005-442f-97f1-b16b4ae0b2b1"></a>
<b>Private <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> _frameGradient</b></p>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b11748bf-e54b-435c-97e9-41855fc0be40'>_frameJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="b11748bf-e54b-435c-97e9-41855fc0be40"></a>
<b>Private <code>System.Single</code> _frameJitterDeviation</b></p>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b9146ca-e40a-4fd6-9bcb-2430f7f4048a'>_frameJitterLength</a></td><td style='width:75%' ><p><a name="0b9146ca-e40a-4fd6-9bcb-2430f7f4048a"></a>
<b>Private <code>System.Single</code> _frameJitterLength</b></p>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fd7d7b4-020f-49dc-a37d-1f70d3fe8642'>_frameShadow</a></td><td style='width:75%' class='def'><p><a name="2fd7d7b4-020f-49dc-a37d-1f70d3fe8642"></a>
<b>Private <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoCore.KimonoShadow</a> _frameShadow</b></p>

<p>The frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c96d511-cba7-4930-aab5-4a94b3f25f53'>_hasFillBlur</a></td><td style='width:75%' ><p><a name="0c96d511-cba7-4930-aab5-4a94b3f25f53"></a>
<b>Private <code>System.Boolean</code> _hasFillBlur</b></p>

<p>The has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#550c23d3-37da-48fb-ae54-30d5192552b7'>_hasFillJitter</a></td><td style='width:75%' class='def'><p><a name="550c23d3-37da-48fb-ae54-30d5192552b7"></a>
<b>Private <code>System.Boolean</code> _hasFillJitter</b></p>

<p>If <code>true</code>, the fill uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4be4844a-f728-411b-88f3-c30811dcae20'>_hasFillShadow</a></td><td style='width:75%' ><p><a name="4be4844a-f728-411b-88f3-c30811dcae20"></a>
<b>Private <code>System.Boolean</code> _hasFillShadow</b></p>

<p>The has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8abbadfa-9b4d-413d-a1e6-6ccdba4a3d46'>_hasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="8abbadfa-9b4d-413d-a1e6-6ccdba4a3d46"></a>
<b>Private <code>System.Boolean</code> _hasFrameBlur</b></p>

<p>The has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb43aaeb-7adf-459b-8b7e-7bb71e2d7c45'>_hasFrameDash</a></td><td style='width:75%' ><p><a name="eb43aaeb-7adf-459b-8b7e-7bb71e2d7c45"></a>
<b>Private <code>System.Boolean</code> _hasFrameDash</b></p>

<p>If <code>true</code>, the frame has a dash effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#072e8bd9-7367-4bdf-a086-ca3193014f51'>_hasFrameJitter</a></td><td style='width:75%' class='def'><p><a name="072e8bd9-7367-4bdf-a086-ca3193014f51"></a>
<b>Private <code>System.Boolean</code> _hasFrameJitter</b></p>

<p>If <code>true</code>, the frame uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#605a867f-733a-43e3-b423-fb5949cd93c5'>_hasFrameShadow</a></td><td style='width:75%' ><p><a name="605a867f-733a-43e3-b423-fb5949cd93c5"></a>
<b>Private <code>System.Boolean</code> _hasFrameShadow</b></p>

<p>The has frame shadow.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#daea4d7f-2b35-41aa-82ee-5674befc2072'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="daea4d7f-2b35-41aa-82ee-5674befc2072"></a></p>

<h3>Public Virtual Read Only <code>KimonoCore.KimonoPropertyConnectionPoint[]</code> ConnectionPoints</h3>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoStyle</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1e6a699-1b43-496a-ad80-baf02fb73114'>DashPattern</a></td><td style='width:75%' class='def'><p><a name="e1e6a699-1b43-496a-ad80-baf02fb73114"></a></p>

<h3>Public <code>System.Boolean[]</code> DashPattern</h3>

<h4>Summary</h4>

<p>Gets or sets the dash pattern.</p>

<h4>Return Value</h4>

<p>The dash pattern.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#355ca2f0-981f-4b88-bd06-39a227235376'>ElementName</a></td><td style='width:75%' ><p><a name="355ca2f0-981f-4b88-bd06-39a227235376"></a></p>

<h3>Private <code>System.String</code> ElementName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c81b5c4-4390-40aa-912a-9515c6699e4a'>Fill</a></td><td style='width:75%' class='def'><p><a name="2c81b5c4-4390-40aa-912a-9515c6699e4a"></a></p>

<h3>Public <code>SkiaSharp.SKPaint</code> Fill</h3>

<h4>Summary</h4>

<p>Gets or sets the fill paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73c1ec27-d214-46e4-99cd-691ac557c390'>FillBlur</a></td><td style='width:75%' ><p><a name="73c1ec27-d214-46e4-99cd-691ac557c390"></a></p>

<h3>Public <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoCore.KimonoBlur</a> FillBlur</h3>

<h4>Summary</h4>

<p>Gets or sets the fill blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a978fef-04d6-43c7-a858-c5f5d7e96be3'>FillColor</a></td><td style='width:75%' class='def'><p><a name="4a978fef-04d6-43c7-a858-c5f5d7e96be3"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> FillColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the fill as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fdb660c-bb19-4a05-a6a4-433d8a3712cf'>FillGradient</a></td><td style='width:75%' ><p><a name="8fdb660c-bb19-4a05-a6a4-433d8a3712cf"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> FillGradient</h3>

<h4>Summary</h4>

<p>Gets or sets the fill gradient.</p>

<h4>Return Value</h4>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6beab7a-8d38-4dcd-a030-747092849d06'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="b6beab7a-8d38-4dcd-a030-747092849d06"></a></p>

<h3>Public <code>System.Single</code> FillJitterDeviation</h3>

<h4>Summary</h4>

<p>Gets or sets the fill jitter deviation.</p>

<h4>Return Value</h4>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bcb2870-0ca6-45bd-8172-a7ac75ab2c04'>FillJitterLength</a></td><td style='width:75%' ><p><a name="9bcb2870-0ca6-45bd-8172-a7ac75ab2c04"></a></p>

<h3>Public <code>System.Single</code> FillJitterLength</h3>

<h4>Summary</h4>

<p>Gets or sets the length of the fill jitter.</p>

<h4>Return Value</h4>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d464c7cd-c10f-46c4-a023-dec678edb111'>FillShadow</a></td><td style='width:75%' class='def'><p><a name="d464c7cd-c10f-46c4-a023-dec678edb111"></a></p>

<h3>Public <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoCore.KimonoShadow</a> FillShadow</h3>

<h4>Summary</h4>

<p>Gets or sets the fill shadow.</p>

<h4>Return Value</h4>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ceeef211-79d2-4fc9-86cf-d9075898a443'>FontFamilyName</a></td><td style='width:75%' ><p><a name="ceeef211-79d2-4fc9-86cf-d9075898a443"></a></p>

<h3>Public <code>System.String</code> FontFamilyName</h3>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd4bffe5-028d-4973-b67a-0d71257c32f3'>FontMetrics</a></td><td style='width:75%' class='def'><p><a name="cd4bffe5-028d-4973-b67a-0d71257c32f3"></a></p>

<h3>Public Read Only <code>SkiaSharp.SKFontMetrics</code> FontMetrics</h3>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#525e924f-ad6d-4ed7-a61c-eee4718d7fa2'>Frame</a></td><td style='width:75%' ><p><a name="525e924f-ad6d-4ed7-a61c-eee4718d7fa2"></a></p>

<h3>Public <code>SkiaSharp.SKPaint</code> Frame</h3>

<h4>Summary</h4>

<p>Gets or sets the frame paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61c5bdbe-8610-4e32-b061-386c1b779691'>FrameBlur</a></td><td style='width:75%' class='def'><p><a name="61c5bdbe-8610-4e32-b061-386c1b779691"></a></p>

<h3>Public <a href="#f51af2c9-f4b2-4244-ad4b-ba7e580ac918">KimonoCore.KimonoBlur</a> FrameBlur</h3>

<h4>Summary</h4>

<p>Gets or sets the frame blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68d6abdd-9587-41ac-8ccc-4d48c5528438'>FrameColor</a></td><td style='width:75%' ><p><a name="68d6abdd-9587-41ac-8ccc-4d48c5528438"></a></p>

<h3>Public <a href="#6a61d428-669b-4b00-8f29-7eac9ab41f57">KimonoCore.KimonoColor</a> FrameColor</h3>

<h4>Summary</h4>

<p>Gets or sets the color of the frame as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed0a8179-2ede-40bb-8040-b190fbd0f2df'>FrameGradient</a></td><td style='width:75%' class='def'><p><a name="ed0a8179-2ede-40bb-8040-b190fbd0f2df"></a></p>

<h3>Public <a href="#6c314738-81b5-4ec9-8672-ec5609515d65">KimonoCore.KimonoGradient</a> FrameGradient</h3>

<h4>Summary</h4>

<p>Gets or sets the frame gradient.</p>

<h4>Return Value</h4>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7afa201f-55d5-4d1c-ac6e-d431e962d440'>FrameJitterDeviation</a></td><td style='width:75%' ><p><a name="7afa201f-55d5-4d1c-ac6e-d431e962d440"></a></p>

<h3>Public <code>System.Single</code> FrameJitterDeviation</h3>

<h4>Summary</h4>

<p>Gets or sets the frame jitter deviation.</p>

<h4>Return Value</h4>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#26550c57-19c7-4905-880d-81a1165b341d'>FrameJitterLength</a></td><td style='width:75%' class='def'><p><a name="26550c57-19c7-4905-880d-81a1165b341d"></a></p>

<h3>Public <code>System.Single</code> FrameJitterLength</h3>

<h4>Summary</h4>

<p>Gets or sets the length of the frame jitter.</p>

<h4>Return Value</h4>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08e77428-d3b5-4771-961a-9353285925ee'>FrameShadow</a></td><td style='width:75%' ><p><a name="08e77428-d3b5-4771-961a-9353285925ee"></a></p>

<h3>Public <a href="#aed70957-92e3-45b9-85a6-31d4dc128ed2">KimonoCore.KimonoShadow</a> FrameShadow</h3>

<h4>Summary</h4>

<p>Gets or sets the frame shadow.</p>

<h4>Return Value</h4>

<p>The frame shadow as a <code>KimonoShadow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#789c2a27-6535-408b-b2c2-b841a920b9c8'>HasFill</a></td><td style='width:75%' class='def'><p><a name="789c2a27-6535-408b-b2c2-b841a920b9c8"></a></p>

<h3>Public <code>System.Boolean</code> HasFill</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> has fill.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca52edac-198e-4152-9ba2-9f273a6741a6'>HasFillBlur</a></td><td style='width:75%' ><p><a name="ca52edac-198e-4152-9ba2-9f273a6741a6"></a></p>

<h3>Public <code>System.Boolean</code> HasFillBlur</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> has fill blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18ea29c6-d0f4-4820-84d9-17d354b868ea'>HasFillJitter</a></td><td style='width:75%' class='def'><p><a name="18ea29c6-d0f4-4820-84d9-17d354b868ea"></a></p>

<h3>Public <code>System.Boolean</code> HasFillJitter</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the fill jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f28a9a96-9ab1-4924-8cd8-3fcfeea14362'>HasFillShadow</a></td><td style='width:75%' ><p><a name="f28a9a96-9ab1-4924-8cd8-3fcfeea14362"></a></p>

<h3>Public <code>System.Boolean</code> HasFillShadow</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> has fill shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3eeadf5d-33b5-43cb-bf54-340bcbee3c23'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="3eeadf5d-33b5-43cb-bf54-340bcbee3c23"></a></p>

<h3>Public <code>System.Boolean</code> HasFrame</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> has a frame.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3666109e-3642-48f9-8731-69d955346898'>HasFrameBlur</a></td><td style='width:75%' ><p><a name="3666109e-3642-48f9-8731-69d955346898"></a></p>

<h3>Public <code>System.Boolean</code> HasFrameBlur</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> has frame blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e91c545a-97ce-4d1c-b212-8076b652b79c'>HasFrameDash</a></td><td style='width:75%' class='def'><p><a name="e91c545a-97ce-4d1c-b212-8076b652b79c"></a></p>

<h3>Public <code>System.Boolean</code> HasFrameDash</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame has a dash.</p>

<h4>Return Value</h4>

<p><code>true</code> if the frame has a dash; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df1350d3-c4b0-4cc3-a4a1-9f1ef556f389'>HasFrameJitter</a></td><td style='width:75%' ><p><a name="df1350d3-c4b0-4cc3-a4a1-9f1ef556f389"></a></p>

<h3>Public <code>System.Boolean</code> HasFrameJitter</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e56e2bc2-dfa7-4f19-8479-0df124de166a'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="e56e2bc2-dfa7-4f19-8479-0df124de166a"></a></p>

<h3>Public <code>System.Boolean</code> HasFrameShadow</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> has frame shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c77e9d2-8e56-4b54-a232-c3efffb8565e'>IsLinearText</a></td><td style='width:75%' ><p><a name="8c77e9d2-8e56-4b54-a232-c3efffb8565e"></a></p>

<h3>Public <code>System.Boolean</code> IsLinearText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec357e98-d101-4168-97be-abda2e147558'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="ec357e98-d101-4168-97be-abda2e147558"></a></p>

<h3>Public <code>System.Boolean</code> IsVerticalText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd366ced-aea8-4b20-befb-c793bebb3c30'>Name</a></td><td style='width:75%' ><p><a name="dd366ced-aea8-4b20-befb-c793bebb3c30"></a></p>

<h3>Public <code>System.String</code> Name</h3>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33dc3638-0fa2-40e7-b2b6-4551923c2c31'>PropertyConnections</a></td><td style='width:75%' class='def'><p><a name="33dc3638-0fa2-40e7-b2b6-4551923c2c31"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPropertyConnection&gt;</code> PropertyConnections</h3>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a88e4536-a4e4-4ef1-8b78-6d863f9a34c4'>StrikeThruText</a></td><td style='width:75%' ><p><a name="a88e4536-a4e4-4ef1-8b78-6d863f9a34c4"></a></p>

<h3>Public <code>System.Boolean</code> StrikeThruText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bacfe89c-db57-4680-b574-6b6d96a11387'>StyleType</a></td><td style='width:75%' class='def'><p><a name="bacfe89c-db57-4680-b574-6b6d96a11387"></a></p>

<h3>Public <a href="#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63">KimonoCore.KimonoStyleType</a> StyleType</h3>

<h4>Summary</h4>

<p>Gets or sets the type of the style.</p>

<h4>Return Value</h4>

<p>The type of the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#916c2fc3-1230-48f6-b01a-c558f716d48c'>TextAlign</a></td><td style='width:75%' ><p><a name="916c2fc3-1230-48f6-b01a-c558f716d48c"></a></p>

<h3>Public <code>SkiaSharp.SKTextAlign</code> TextAlign</h3>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f273ba80-41ee-4a5f-a445-6882968d5b17'>TextEncoding</a></td><td style='width:75%' class='def'><p><a name="f273ba80-41ee-4a5f-a445-6882968d5b17"></a></p>

<h3>Public <code>SkiaSharp.SKTextEncoding</code> TextEncoding</h3>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#777f446f-f4b0-479e-902e-113ef96ec4e2'>TextScaleX</a></td><td style='width:75%' ><p><a name="777f446f-f4b0-479e-902e-113ef96ec4e2"></a></p>

<h3>Public <code>System.Single</code> TextScaleX</h3>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86f5c831-04c7-46f4-8220-87a1b4140cbf'>TextSize</a></td><td style='width:75%' class='def'><p><a name="86f5c831-04c7-46f4-8220-87a1b4140cbf"></a></p>

<h3>Public <code>System.Single</code> TextSize</h3>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cfcabeab-5c31-4048-9bc9-ebfd5b5c02ab'>TextSkewX</a></td><td style='width:75%' ><p><a name="cfcabeab-5c31-4048-9bc9-ebfd5b5c02ab"></a></p>

<h3>Public <code>System.Single</code> TextSkewX</h3>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#450876d3-60a1-4b4c-9943-f255706ea32e'>Typeface</a></td><td style='width:75%' class='def'><p><a name="450876d3-60a1-4b4c-9943-f255706ea32e"></a></p>

<h3>Public <code>SkiaSharp.SKTypeface</code> Typeface</h3>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30195627-d985-4e26-889a-e2b8af8e3aa2'>TypefaceStyle</a></td><td style='width:75%' ><p><a name="30195627-d985-4e26-889a-e2b8af8e3aa2"></a></p>

<h3>Public <code>SkiaSharp.SKTypefaceStyle</code> TypefaceStyle</h3>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81d686d2-c55a-4c11-9408-6a4e8fdcfb23'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="81d686d2-c55a-4c11-9408-6a4e8fdcfb23"></a></p>

<h3>Public <code>System.Boolean</code> UnderlineText</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d362e7b-4975-4aee-a7e8-d086ad2243fe'>UniqueID</a></td><td style='width:75%' ><p><a name="5d362e7b-4975-4aee-a7e8-d086ad2243fe"></a></p>

<h3>Public <code>System.String</code> UniqueID</h3>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e3d44e94-5dc1-49c6-8dbf-62944e4fb92a'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="e3d44e94-5dc1-49c6-8dbf-62944e4fb92a"></a></p>

<h3>Public Virtual Void AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="aaae267d-aa7b-4a84-adae-88326522674e"></a>
<b>KimonoCore.KimonoPropertyConnectionPoint connectionPoint</b></p>

<p>The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="a10d2ad2-85a9-498a-926a-be8c18eb3229"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#977e4a22-25f8-4af4-8459-87bbf5fc92e9'>ApplyFillEffects</a></td><td style='width:75%' class='def'><p><a name="977e4a22-25f8-4af4-8459-87bbf5fc92e9"></a></p>

<h3>Public Void ApplyFillEffects ()</h3>

<h4>Summary</h4>

<p>Applies the fill effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#877c9014-03fd-4267-a5f7-81307f82c9cc'>ApplyFrameEffects</a></td><td style='width:75%' ><p><a name="877c9014-03fd-4267-a5f7-81307f82c9cc"></a></p>

<h3>Public Void ApplyFrameEffects ()</h3>

<h4>Summary</h4>

<p>Applies the frame effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ec7fb95-084c-4ca6-92e5-492e7a9c6370'>Clone</a></td><td style='width:75%' class='def'><p><a name="4ec7fb95-084c-4ca6-92e5-492e7a9c6370"></a></p>

<h3>Public <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoCore.KimonoStyle</a> Clone (System.Boolean)</h3>

<h4>Summary</h4>

<p>Clones the <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p><a name="262323b8-dfd4-4a85-8ebb-5db02871b906"></a>
<b>System.Boolean deepClone</b></p>

<p>If set to <code>true</code>, a deep clone of the style is made.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The a clone of the <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7daf0d20-6d99-4248-aa49-ed5f569e27e8'>ClonePaint</a></td><td style='width:75%' ><p><a name="7daf0d20-6d99-4248-aa49-ed5f569e27e8"></a></p>

<h3>Public Static <code>SkiaSharp.SKPaint</code> ClonePaint (SkiaSharp.SKPaint)</h3>

<h4>Summary</h4>

<p>Clones the given <code>SKPaint</code> object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p><a name="91d68a55-28e5-4cec-a132-5c67df163de4"></a>
<b>SkiaSharp.SKPaint paint</b></p>

<p>The <code>SKPaint</code> object to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>SKPaint</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f133b64a-1c53-4248-8bad-169a0be0ca06'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="f133b64a-1c53-4248-8bad-169a0be0ca06"></a></p>

<h3>Public Virtual Void EvaluateConnectedProperties ()</h3>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoStyle</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5ea77ab-6f72-4a68-9d72-2c31bf269ed1'>FillToSkiaCode</a></td><td style='width:75%' ><p><a name="f5ea77ab-6f72-4a68-9d72-2c31bf269ed1"></a></p>

<h3>Public Virtual <code>System.String</code> FillToSkiaCode ()</h3>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcbe7b33-d675-4c15-ae81-7cfa18b66e02'>FillToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="fcbe7b33-d675-4c15-ae81-7cfa18b66e02"></a></p>

<h3>Public Virtual <code>System.String</code> FillToSkiaInitializer (System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>constructor</td><td style='width:75%' ><p><a name="a8d976b9-db0e-4e7e-8537-b1c87a537678"></a>
<b>System.Boolean constructor</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>constructor</code> parameter of the FillToSkiaInitializer method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d31cb370-a72c-41fa-ae9e-25ca6965c352'>FrameToSkiaCode</a></td><td style='width:75%' ><p><a name="d31cb370-a72c-41fa-ae9e-25ca6965c352"></a></p>

<h3>Public Virtual <code>System.String</code> FrameToSkiaCode ()</h3>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ee57a571-db77-478e-b85f-32d17736f2c1'>FrameToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="ee57a571-db77-478e-b85f-32d17736f2c1"></a></p>

<h3>Public Virtual <code>System.String</code> FrameToSkiaInitializer (System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>constructor</td><td style='width:75%' ><p><a name="47131a9d-04d5-4959-a80f-5c38020851dd"></a>
<b>System.Boolean constructor</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>constructor</code> parameter of the FrameToSkiaInitializer method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ed388b3-44af-4332-9b9d-79e74a1f4006'>HandleFillBlurOrShadowChange</a></td><td style='width:75%' ><p><a name="0ed388b3-44af-4332-9b9d-79e74a1f4006"></a></p>

<h3>Private Void HandleFillBlurOrShadowChange ()</h3>

<h4>Summary</h4>

<p>Handles the fill blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b175ca7b-0c03-4c47-9b01-3d68390aa1a2'>HandleFillColorChange</a></td><td style='width:75%' class='def'><p><a name="b175ca7b-0c03-4c47-9b01-3d68390aa1a2"></a></p>

<h3>Private Void HandleFillColorChange ()</h3>

<h4>Summary</h4>

<p>Handles the fill color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec9b3df0-b582-4e75-96da-a08e82888813'>HandleFillGradientChange</a></td><td style='width:75%' ><p><a name="ec9b3df0-b582-4e75-96da-a08e82888813"></a></p>

<h3>Private Void HandleFillGradientChange ()</h3>

<h4>Summary</h4>

<p>Handles the fill gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72a5ab52-1519-433a-984c-f984b6d432a4'>HandleFrameBlurOrShadowChange</a></td><td style='width:75%' class='def'><p><a name="72a5ab52-1519-433a-984c-f984b6d432a4"></a></p>

<h3>Private Void HandleFrameBlurOrShadowChange ()</h3>

<h4>Summary</h4>

<p>Handles the frame blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ce4eb6f-20e8-4bdf-a1a8-4c8390e5ee4e'>HandleFrameColorChange</a></td><td style='width:75%' ><p><a name="5ce4eb6f-20e8-4bdf-a1a8-4c8390e5ee4e"></a></p>

<h3>Private Void HandleFrameColorChange ()</h3>

<h4>Summary</h4>

<p>Handles the frame color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#186cc2e6-998f-4015-ae73-af49dd3a89f2'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p><a name="186cc2e6-998f-4015-ae73-af49dd3a89f2"></a></p>

<h3>Private Void HandleFrameGradientChange ()</h3>

<h4>Summary</h4>

<p>Handles the frame gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2c851793-620f-42ab-a37a-b05841962dae'>Initialize</a></td><td style='width:75%' ><p><a name="2c851793-620f-42ab-a37a-b05841962dae"></a></p>

<h3>Private Void Initialize ()</h3>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ef508e6-d9cb-4b1a-b938-41eb44910e5d'>KimonoStyle</a></td><td style='width:75%' class='def'><p><a name="0ef508e6-d9cb-4b1a-b938-41eb44910e5d"></a></p>

<h3>Public Void KimonoStyle ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#58a59d79-7f6c-41a4-a720-ef39b100168e">KimonoStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#968b719d-e5e3-4331-b609-5dcea1996282'>MakeDashInterval</a></td><td style='width:75%' ><p><a name="968b719d-e5e3-4331-b609-5dcea1996282"></a></p>

<h3>Private <code>System.Collections.Generic.List&lt;System.Single&gt;</code> MakeDashInterval ()</h3>

<h4>Summary</h4>

<p>Makes the dash interval from the dash pattern.</p>

<h4>Returns</h4>

<p>The dash interval.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#638820f1-ad9b-4e85-b2d2-495b61597040'>RemoveProperty</a></td><td style='width:75%' class='def'><p><a name="638820f1-ad9b-4e85-b2d2-495b61597040"></a></p>

<h3>Public Virtual Void RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="b0067446-faa6-4256-9e71-b016cb7c3c9f"></a>
<b>KimonoCore.KimonoProperty property</b></p>

<p>The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7699a563-aa8a-4598-b3cb-4a9d03ef26a5'>RemovePropertyConnection</a></td><td style='width:75%' ><p><a name="7699a563-aa8a-4598-b3cb-4a9d03ef26a5"></a></p>

<h3>Public Virtual Void RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="b309cc8f-cd5b-46d9-bfc0-9d7489314b1c"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1270091-89ba-4cd7-8182-1cf5f3c110fa'>ToCode</a></td><td style='width:75%' class='def'><p><a name="e1270091-89ba-4cd7-8182-1cf5f3c110fa"></a></p>

<h3>Public Virtual <code>System.String</code> ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="eb0b1fa5-5c9a-46b0-8362-441cf82b0608"></a>
<b>KimonoCore.CodeOutputOS outputOS</b></p>

<p>The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="5f2a22a8-65fd-4c3a-bdb9-5e8c9b90f645"></a>
<b>KimonoCore.CodeOutputLanguage outputLanguage</b></p>

<p>The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="cf36d367-0270-4f06-8bb9-7771044ad6fb"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ee1bd5b-f1c0-4cc8-bf2d-f964636dcbc8'>ToCSharp</a></td><td style='width:75%' ><p><a name="5ee1bd5b-f1c0-4cc8-bf2d-f964636dcbc8"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ed070622-762b-49b7-8514-669362aad854"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d6aee29-db2f-4134-a1a1-1fc708683192'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="0d6aee29-db2f-4134-a1a1-1fc708683192"></a></p>

<h3>Public Virtual <code>System.String</code> ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d125d9cc-8edd-4f42-ac50-47376e622c1a"></a>
<b>KimonoCore.CodeOutputLibrary outputLibrary</b></p>

<p>The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60235be2-eb31-4fe8-b9bf-cd369d5b02f1'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="60235be2-eb31-4fe8-b9bf-cd369d5b02f1"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCore ()</h3>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b3ca67b-a4d5-4647-bf75-6dfdb1ec4408'>ToKimonoCoreInitializer</a></td><td style='width:75%' class='def'><p><a name="1b3ca67b-a4d5-4647-bf75-6dfdb1ec4408"></a></p>

<h3>Public Virtual <code>System.String</code> ToKimonoCoreInitializer (System.Boolean)</h3>

<h4>Modified In API Version</h4>

<p>01.01.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>constructor</td><td style='width:75%' ><p><a name="c383b39e-026b-41bd-8481-c4bdc0adf1c4"></a>
<b>System.Boolean constructor</b></p>

<p><b>Added In API Version 01.01.00</b></p>

<p>The <code>constructor</code> parameter of the ToKimonoCoreInitializer method takes a <code>System.Boolean</code> value. </p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47e85b6c-a25f-40eb-bf61-5fe6e6d4e48e'>ToObiScript</a></td><td style='width:75%' ><p><a name="47e85b6c-a25f-40eb-bf61-5fe6e6d4e48e"></a></p>

<h3>Public Virtual <code>System.String</code> ToObiScript ()</h3>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4019c4e-24d3-4685-a6c4-831163242050'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="d4019c4e-24d3-4685-a6c4-831163242050"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharp ()</h3>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e971ad9-ac7e-4116-9cd0-744a7552561c'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="6e971ad9-ac7e-4116-9cd0-744a7552561c"></a></p>

<h3>Public Virtual <code>System.String</code> ToSkiaSharpPath ()</h3>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80395174-6000-4eeb-a736-3ed35b01dd87'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="80395174-6000-4eeb-a736-3ed35b01dd87"></a></p>

<h3>Public Virtual Void UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="1c494681-b6d5-4ab3-90dc-a3089f04188c"></a>
<b>KimonoCore.KimonoPropertyConnection connection</b></p>

<p>Connection.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="69ad9c7c-0d1a-49a5-8090-d9ac44c96b63"></a>
##Public Enum KimonoStyleType

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the type of a `KimonoStyle` that will be used to draw a given `KimonoShape` in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#df233cf6-dc90-407c-a23d-5d1da617e8d9'>Custom</a></td><td style='width:75%' ><p><a name="df233cf6-dc90-407c-a23d-5d1da617e8d9"></a>
<b>Public Static Constant <a href="#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63">KimonoCore.KimonoStyleType</a> Custom = <code>1</code></b></p>

<p>A custom style that belongs only to an individual shape instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01c3e95b-a54f-4fae-a47c-738831c80c28'>CustomText</a></td><td style='width:75%' class='def'><p><a name="01c3e95b-a54f-4fae-a47c-738831c80c28"></a>
<b>Public Static Constant <a href="#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63">KimonoCore.KimonoStyleType</a> CustomText = <code>2</code></b></p>

<p>A custom text style that belongs only to an individual <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9547214-8343-4cc1-8e41-59a34314fd66'>Default</a></td><td style='width:75%' ><p><a name="c9547214-8343-4cc1-8e41-59a34314fd66"></a>
<b>Public Static Constant <a href="#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63">KimonoCore.KimonoStyleType</a> Default = <code>0</code></b></p>

<p>The default style for new shapes. This style cannot be deleted or renamed by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#165b42ea-dd73-42e9-b824-26c0e1fc0439'>Standard</a></td><td style='width:75%' class='def'><p><a name="165b42ea-dd73-42e9-b824-26c0e1fc0439"></a>
<b>Public Static Constant <a href="#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63">KimonoCore.KimonoStyleType</a> Standard = <code>3</code></b></p>

<p>A shared style that can be applied to multiple <code>Kimonoshape</code> instances.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9552814d-8889-4348-96ee-c044915fbc28'>Text</a></td><td style='width:75%' ><p><a name="9552814d-8889-4348-96ee-c044915fbc28"></a>
<b>Public Static Constant <a href="#69ad9c7c-0d1a-49a5-8090-d9ac44c96b63">KimonoCore.KimonoStyleType</a> Text = <code>4</code></b></p>

<p>A shared text style that can be applied to multiple <code>KimonoShapeText</code> instances.</p>
</td></tr></table></p>


---

<a name="53114db4-e386-4582-9425-de1e67b5bd36"></a>
##Public Enum KimonoTool

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Enum`

###Summary

Defines the current tool that is active in a `KimonoSketch` that the user can use to create or modify a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9ee3cd2b-febe-4c0a-b69a-b79fc2041bdc'>Arrow</a></td><td style='width:75%' ><p><a name="9ee3cd2b-febe-4c0a-b69a-b79fc2041bdc"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Arrow = <code>2</code></b></p>

<p>Use the Arrow tool to add a new <code>KimonoShapeArrow</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d10276a7-4343-4563-b207-d5ca430d59b1'>Bezier</a></td><td style='width:75%' class='def'><p><a name="d10276a7-4343-4563-b207-d5ca430d59b1"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Bezier = <code>10</code></b></p>

<p>Use the Bezier tool to add a new <code>KimonoShapeBezier</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18646863-51ee-4c33-ba62-719f9d0ccc26'>Cursor</a></td><td style='width:75%' ><p><a name="18646863-51ee-4c33-ba62-719f9d0ccc26"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Cursor = <code>0</code></b></p>

<p>Use the Cursor tool to modify an existing <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3624419f-7cdf-4812-84ae-fe873b3fb5cb'>Line</a></td><td style='width:75%' class='def'><p><a name="3624419f-7cdf-4812-84ae-fe873b3fb5cb"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Line = <code>1</code></b></p>

<p>Use the Line tool to add a new <code>KimonoShapeLine</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fd3cf36-7706-4e55-8c3b-4d5708e22356'>Oval</a></td><td style='width:75%' ><p><a name="2fd3cf36-7706-4e55-8c3b-4d5708e22356"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Oval = <code>4</code></b></p>

<p>Use the Oval tool to add a new <code>KimonoShapeOval</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7509466c-2987-45d8-b4a6-f9dcde6e6b8d'>Polygon</a></td><td style='width:75%' class='def'><p><a name="7509466c-2987-45d8-b4a6-f9dcde6e6b8d"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Polygon = <code>7</code></b></p>

<p>Use the Polygon tool to add a new <code>KimonoShapePolygon</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db9d48d7-380b-445c-88e4-b09aa43a045d'>Rectangle</a></td><td style='width:75%' ><p><a name="db9d48d7-380b-445c-88e4-b09aa43a045d"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Rectangle = <code>3</code></b></p>

<p>Use the Rectangle tool to add a new <code>KimonoShapeRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eca96114-4af1-439b-b966-254ce0e3d94a'>RoundRect</a></td><td style='width:75%' class='def'><p><a name="eca96114-4af1-439b-b966-254ce0e3d94a"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> RoundRect = <code>5</code></b></p>

<p>Use the Round Rect tool to add a new <code>KimonoShapeRoundRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#706de7e0-df59-4a78-9600-1bf08e5e4409'>Star</a></td><td style='width:75%' ><p><a name="706de7e0-df59-4a78-9600-1bf08e5e4409"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Star = <code>6</code></b></p>

<p>Use the Star tool to add a new <code>KimonoShapeStar</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2804709-9310-431e-a842-27e5a2fbd429'>Text</a></td><td style='width:75%' class='def'><p><a name="f2804709-9310-431e-a842-27e5a2fbd429"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Text = <code>11</code></b></p>

<p>Use the Text tool to add a new <code>KimonoShapeText</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#69f3d64b-99b4-48f3-b8af-07869af8c0f3'>Triangle</a></td><td style='width:75%' ><p><a name="69f3d64b-99b4-48f3-b8af-07869af8c0f3"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Triangle = <code>8</code></b></p>

<p>Use the Triangle tool to add a new <code>KimonoShapeTriangle</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ce95126-794b-48a1-a152-10761f7355d8'>Vector</a></td><td style='width:75%' class='def'><p><a name="9ce95126-794b-48a1-a152-10761f7355d8"></a>
<b>Public Static Constant <a href="#53114db4-e386-4582-9425-de1e67b5bd36">KimonoCore.KimonoTool</a> Vector = <code>9</code></b></p>

<p>Use the Vector tool to add a new <code>KimonoShapeVector</code> to the sketch.</p>
</td></tr></table></p>


---

<a name="9f6ca193-4a1c-4cf3-85fd-9088380e8c9e"></a>
##Public Class KimonoUndoHandler

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Handles the undo/redo state for a `KimonoDesignSurface`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#19a59428-83bc-4ccc-b541-dde1966a3995'>UndoStateChanged</a></td><td style='width:75%' ><p><a name="19a59428-83bc-4ccc-b541-dde1966a3995"></a>
<b>Private <a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> UndoStateChanged</b></p>

<p>The private <code>UndoStateChanged</code> field of the <code>KimonoUndoHandler</code> class holds a <code>KimonoCore.Kimono.PortfolioEventDelegate</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#42d24bee-811b-4289-8984-9bff5e5efde6'>CanRedo</a></td><td style='width:75%' ><p><a name="42d24bee-811b-4289-8984-9bff5e5efde6"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanRedo</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can redo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can redo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a4b6097-ef21-4095-9ce3-4a11697f8e1f'>CanUndo</a></td><td style='width:75%' class='def'><p><a name="3a4b6097-ef21-4095-9ce3-4a11697f8e1f"></a></p>

<h3>Public Read Only <code>System.Boolean</code> CanUndo</h3>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can undo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can undo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75ba01dd-68bc-4a91-ae77-48ab4cd61568'>MaximumUndoPoints</a></td><td style='width:75%' ><p><a name="75ba01dd-68bc-4a91-ae77-48ab4cd61568"></a></p>

<h3>Public <code>System.Int32</code> MaximumUndoPoints</h3>

<h4>Summary</h4>

<p>Gets or sets the maximum undo points.</p>

<h4>Return Value</h4>

<p>The maximum undo points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5f83a1a-e3c9-4453-80d0-4f3ee69bc94b'>RedoStack</a></td><td style='width:75%' class='def'><p><a name="c5f83a1a-e3c9-4453-80d0-4f3ee69bc94b"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPortfolio&gt;</code> RedoStack</h3>

<h4>Summary</h4>

<p>Gets or sets the redo stack.</p>

<h4>Return Value</h4>

<p>The redo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1808fd24-6afc-4b58-9051-a37c399f5fed'>UndoStack</a></td><td style='width:75%' ><p><a name="1808fd24-6afc-4b58-9051-a37c399f5fed"></a></p>

<h3>Public <code>System.Collections.Generic.List&lt;KimonoCore.KimonoPortfolio&gt;</code> UndoStack</h3>

<h4>Summary</h4>

<p>Gets or sets the undo stack.</p>

<h4>Return Value</h4>

<p>The undo stack.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#93883af5-7aec-4bc3-932e-da5265ac32c8'>KimonoUndoHandler</a></td><td style='width:75%' ><p><a name="93883af5-7aec-4bc3-932e-da5265ac32c8"></a></p>

<h3>Public Void KimonoUndoHandler ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#9f6ca193-4a1c-4cf3-85fd-9088380e8c9e">KimonoUndoHandler</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28d588bd-a76b-4cdb-b59e-01b26f3eb7bf'>PopRedoPoint</a></td><td style='width:75%' class='def'><p><a name="28d588bd-a76b-4cdb-b59e-01b26f3eb7bf"></a></p>

<h3>Public <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoCore.KimonoPortfolio</a> PopRedoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Summary</h4>

<p>Pops the redo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="3f401715-8bec-4d88-a52f-37f5af481830"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The previous state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9874c3d9-1426-4168-85d7-28f0bda5d2b9'>PopUndoPoint</a></td><td style='width:75%' ><p><a name="9874c3d9-1426-4168-85d7-28f0bda5d2b9"></a></p>

<h3>Public <a href="#83ce776d-3d2d-4903-8985-9bbd9862da9d">KimonoCore.KimonoPortfolio</a> PopUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Summary</h4>

<p>Pops the undo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="857dda75-ecda-4d9a-8149-b582f402da29"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The prior state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63a52180-0091-4b0e-a92b-fd1eb39b5c16'>PushUndoPoint</a></td><td style='width:75%' class='def'><p><a name="63a52180-0091-4b0e-a92b-fd1eb39b5c16"></a></p>

<h3>Public Void PushUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Summary</h4>

<p>Pushes the undo point onto the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="5258885f-a19c-4767-b54d-866e67dfafde"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a88a4cc-e37b-4cab-8d49-240b854c6817'>RaiseUndoStateChanged</a></td><td style='width:75%' ><p><a name="4a88a4cc-e37b-4cab-8d49-240b854c6817"></a></p>

<h3>Void RaiseUndoStateChanged ()</h3>

<h4>Summary</h4>

<p>Raises the undo state changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fcd1172c-f6b1-43ff-aabe-7cc2a2207cd0'>ReplaceLastUndoPoint</a></td><td style='width:75%' class='def'><p><a name="fcd1172c-f6b1-43ff-aabe-7cc2a2207cd0"></a></p>

<h3>Public Void ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Summary</h4>

<p>Replaces the last undo point with the one being passed in.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="ddb0ccac-f688-4ac9-9936-d5263a4e7489"></a>
<b>KimonoCore.KimonoPortfolio portfolio</b></p>

<p>The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#17a3eb02-c375-4052-83fe-8675aa31c04f'>UndoStateChanged</a></td><td style='width:75%' ><p><a name="17a3eb02-c375-4052-83fe-8675aa31c04f"></a></p>

<h3><a href="#f0830bfd-1679-4683-a9a2-e032ed9a1049">KimonoCore.Kimono.PortfolioEventDelegate</a> UndoStateChanged</h3>

<h4>Summary</h4>

<p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="f5567893-dd3b-4b40-ba41-82bf05be3488"></a>
##Public Class ObiScriptResult

###Namespace

[KimonoCore](#b9d8b089-0169-49eb-a66f-710d9b0331f7)

###Inherits From

`System.Object`

###Summary

Defines the result of attempting to execute an Obi Script on a `KimonoProperty`
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#f0dc7160-3963-4620-8d71-12413b03aef4'>ErrorMessage</a></td><td style='width:75%' ><p><a name="f0dc7160-3963-4620-8d71-12413b03aef4"></a></p>

<h3>Public <code>System.String</code> ErrorMessage</h3>

<h4>Summary</h4>

<p>Gets or sets the error message if the Obi Script execution failed.</p>

<h4>Return Value</h4>

<p>The error message or "" if the script ran successfully.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6527df6-74ff-48b8-b0c5-b76c356b7910'>Successful</a></td><td style='width:75%' class='def'><p><a name="f6527df6-74ff-48b8-b0c5-b76c356b7910"></a></p>

<h3>Public <code>System.Boolean</code> Successful</h3>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the Obi Script ran successfully.</p>

<h4>Return Value</h4>

<p><code>true</code> if successful; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9bcb8d99-b8fd-4864-b3a2-9652c10f04b2'>ObiScriptResult</a></td><td style='width:75%' ><p><a name="9bcb8d99-b8fd-4864-b3a2-9652c10f04b2"></a></p>

<h3>Public Void ObiScriptResult ()</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">ObiScriptResult</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04ec6e15-94f4-4fbe-b4bf-a5c32c6b3948'>ObiScriptResult</a></td><td style='width:75%' class='def'><p><a name="04ec6e15-94f4-4fbe-b4bf-a5c32c6b3948"></a></p>

<h3>Public Void ObiScriptResult (System.Boolean, System.String)</h3>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f5567893-dd3b-4b40-ba41-82bf05be3488">ObiScriptResult</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>isSuccessful</td><td style='width:75%' ><p><a name="40d9d1a2-4a07-4210-9b47-085341576d7a"></a>
<b>System.Boolean isSuccessful</b></p>

<p>If set to <code>true</code> is successful.</p>
</td></tr><tr><td style='width:25%' class='term'>errorMessage</td><td style='width:75%' class='def'><p><a name="be4d12df-39d3-46fb-b56c-eeb489474fe8"></a>
<b>System.String errorMessage</b></p>

<p>Error message.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="f0830bfd-1679-4683-a9a2-e032ed9a1049"></a>
##PortfolioEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Portfolio event delegate.

---

<a name="3c56fc94-a4eb-4762-8a4e-d39c26f45a7b"></a>
##PropertyEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Property event delegate.

---

<a name="9c9c8a67-4f24-49e4-a08a-92d4a717f2a0"></a>
##ShapeEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Shape event delegate.

---

<a name="3fcae83b-ce08-45e3-b771-1d9a71087384"></a>
##SketchEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Sketch event delegate.

---

<a name="56e1dd0a-58dd-4c97-9d27-57cece6e1c75"></a>
##SkiaColorEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Skia color event delegate.

---

<a name="25e379a4-a7ed-43c6-8d15-70d0408d35ce"></a>
##SkiaPointEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Skia point event delegate.

---

<a name="fdfb734d-7652-477b-b864-cfa9870cd620"></a>
##StyleEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Style event delegate.

---

<a name="64878777-41f3-4e4a-9955-da97b723a057"></a>
##ToolEventDelegate

###Namespace

[KimonoCore.Kimono](#061e0818-454e-46ac-98c6-a8f0fe88d466)

###Summary

Tool event delegate.
