# API Documentation

#### Version 01.00.00

## Table of Contents

* [Summary](#Summary)
* [Remarks](#Remarks)
* [Namespaces](#Namespaces)
* [Types](#Types)

<a name="Summary"></a>
## Summary

Kimono Designer allows a developer to graphically edit Skia based graphic objects that can be converted to code and included in any cross-platform language and OS that SkiaSharp supports. KimonoCore.WinUWP is the Windows UWP specific version of the Kimono cross-platform library that provides a helper interface to SkiaSharp.

<a name="Remarks"></a>
## Remarks

Kimono Designer and the KimonoCore libraries were created by Microsoft, Inc. and released under the MIT License.

### License

**Kimono Designer**

Copyright (c) Microsoft Corporation

All rights reserved. 

MIT License

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
# Namespaces


---

<a name="8f9b0d76-5653-4ad0-96b3-560f4444b75f"></a>
## KimonoCore

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#84e8cd66-169a-4152-a62a-99a9f0d2a4de'>KimonoSketch</a></td><td style='width:75%' ><p>Holds a collection of <code>KimonoShapes</code> that are used to create a given image using Skia.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec3f0a06-9f07-45d7-a365-bf12f58f8811'>KimonoTool</a></td><td style='width:75%' class='def'><p>Defines the current tool that is active in a <code>KimonoSketch</code> that the user can use to create or modify a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6781695-6cb5-4c7a-8618-b183f94a5fd4'>Kimono</a></td><td style='width:75%' ><p>Holds a set of shared utilities that are used across the Kimono classes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#035bafdd-7b26-42a7-be68-b5baf315b517'>KimonoPortfolio</a></td><td style='width:75%' class='def'><p>A Kimono Portfolio holds a collection of <code>KimonoSketches</code>, <code>KimonoStyles</code> and <code>KimonoColors</code> that define a given Kimono Designer project.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f650aeee-c69a-464f-b831-0b9b15b3a564'>KimonoUndoHandler</a></td><td style='width:75%' ><p>Handles the undo/redo state for a <code>KimonoDesignSurface</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7ecc982-613a-459a-8e8d-06e8ebad6154'>KimonoShape</a></td><td style='width:75%' class='def'><p>Defines the based shape that all other Kimono Shape types will inherit from.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8706785-5054-4f35-ac08-bd35c4534e9e'>KimonoShapeArrow</a></td><td style='width:75%' ><p>Draws either an outlined or single line arrow with heads on one or both ends.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af4d21a2-42ef-4bb8-b8dc-077cc5e73d2d'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p>A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb524652-b106-411a-acfd-a8684826292b'>KimonoShapeGroup</a></td><td style='width:75%' ><p>A <code>KimonoShapeGroup</code> holds a collection of <code>KimonoShapes</code> that can be acted upon as a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93331952-3bca-4db8-a83d-1c2825a8db33'>KimonoShapeGroupType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#353d0236-1f21-49cc-8d43-eb056a6413b4'>KimonoShapeLine</a></td><td style='width:75%' ><p>Draws a line on the design surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60a0823f-aaf6-41d5-9972-3d1154b2023d'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p>Draws an oval into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#47c05ff9-2854-48cb-835e-279a4c1934c1'>KimonoShapePolygon</a></td><td style='width:75%' ><p>Draws a multi-sided polygon into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1de07b5c-5e65-4fb1-96b2-6d7d8feb85af'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p>Draws a rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06f856c1-f3d5-4e46-9c14-806d3a2efffe'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p>Draws a rounded rectangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c3d5f46-52b8-40d4-93d0-939867f6eabe'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p>Draws a multi-sided star shape into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d346396c-3c00-4318-8c82-ebafcfb6b108'>KimonoShapeState</a></td><td style='width:75%' ><p>Holds the current state of a <code>KimonoShape</code> while it is being edited by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24982fc8-412b-4c73-8fcf-2b48eb09e67f'>KimonoShapeText</a></td><td style='width:75%' class='def'><p>Draws a block of text into the Design Surface within the specifid bounds of this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#383ac657-8cef-469a-857b-bb42481a0ce3'>KimonoShapeTriangle</a></td><td style='width:75%' ><p>Draws a triangle into the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1d32782-f8dc-4add-962a-324097d3d34b'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p>A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b34e2caa-a148-40b0-a15d-9e805664db66'>KimonoProperty</a></td><td style='width:75%' ><p>Defines a property that can be attached to another Kimono object (such as a <code>KimonoColor</code>, <code>KimonoStyle</code> or <code>KimonoShape</code>) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94a18758-140b-44ea-9163-af36ce62b6e5'>KimonoPropertyUsage</a></td><td style='width:75%' class='def'><p>Defines how a <code>KimonoProperty</code> is used when it is attached to a <code>KimonoShape</code>, <code>KimonoSketch</code> or <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#457b2aa8-a89f-4ef0-8e32-986e966ba386'>KimonoPropertyConnectionPoint</a></td><td style='width:75%' ><p>Defines the point that a <code>KimonoProperty</code> value can be connected to another Kimono object such as the <code>Top</code> coordinate of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9fce7d9-c22e-426e-b931-7b5acb3639e2'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p>Defines a connection between a given Kimono Object and a <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dddec5a0-cd1a-4020-96ac-60fa04ed8c45'>ObiScriptResult</a></td><td style='width:75%' ><p>Defines the result of attempting to execute an Obi Script on a <code>KimonoProperty</code></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#230a9f15-e139-4b0d-a1ca-b10ca63df4cc'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p>Holds the control and end point for a <code>KimonoShapeBezier</code> that define a quad section of the Bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#55f3615a-5284-4338-ae4d-584e9f909e1d'>KimonoBounds</a></td><td style='width:75%' ><p>Defines the outter bounding box for a <code>KimonoShape</code> and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#141c5d64-7afe-45b5-93f7-db847d5285ec'>KimonoHandle</a></td><td style='width:75%' class='def'><p>Defines an edit handle that the user manipulates to edit the bounds of a <code>KimonoShape</code> or the control points of a Bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddcfbf9a-5844-49ad-b99b-e6064d792f6d'>KimonoHandleConstraint</a></td><td style='width:75%' ><p>Constrains the movement of a <code>KimonoHandle</code> when it is being moved by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56cbbbf7-82bf-4f53-958a-b26f0cc00b92'>KimonoHandleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoHandle</code> that can be used as a general purpose control point to adjust the bounds of a <code>KimonoShape</code> or as a point for a vector or bezier object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af98bc95-c176-46d5-9980-48a7908ff039'>KimonoBlur</a></td><td style='width:75%' ><p>Defines a blur effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8346526c-9b9a-4b49-ad94-95ca9b77aef7'>KimonoShadow</a></td><td style='width:75%' class='def'><p>Defines a shadow effect that can be attached to the fill or the frame of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a132d4cf-8cf6-4e06-b1d8-6b15c6d3e191'>KimonoGradient</a></td><td style='width:75%' ><p>Defines a gradient as a collection of either <code>SKColor</code> or linked <code>KimonoColors</code> that can be applied to a <code>KimonoStyle</code> and used when drawing a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a84cf60-472d-49b6-920d-2205ed0e01a5'>KimonoGradientType</a></td><td style='width:75%' class='def'><p>Kimono gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46c1096f-e31c-4843-abfa-ee248207a9d8'>KimonoStyle</a></td><td style='width:75%' ><p>Defines as style that can be applied to a <code>KimonoShape</code> to control its appearance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d328d70-920b-423c-9c80-356b9685b9f9'>KimonoStyleType</a></td><td style='width:75%' class='def'><p>Defines the type of a <code>KimonoStyle</code> that will be used to draw a given <code>KimonoShape</code> in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76d2da2e-c6b0-402e-adfb-ee1b722680e8'>KimonoPropertyRect</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>SKRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#86bdba1e-f610-4e7f-ba44-499671557e12'>KimonoPropertyNumber</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>float</code> or <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b7e6490-7c2c-4da0-95b9-58d985d6a2c2'>KimonoPropertyStyle</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8ae9bff-05de-4dcf-bdc1-91c986f1c993'>KimonoPropertyBoolean</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7582e65f-a4e4-40ab-8a53-a8a929f5667c'>KimonoPropertyText</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc0d1f51-c777-4035-bb47-fd7ea6bfa0f4'>KimonoPropertyColor</a></td><td style='width:75%' class='def'><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09e2a12a-c6e6-4f46-883f-cb3d2cc82d9e'>KimonoPropertyGradient</a></td><td style='width:75%' ><p>Defines a <code>KimonoProperty</code> that represents a <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f60550f-ed3f-4674-869c-50a5bb734427'>CodeOutputOS</a></td><td style='width:75%' class='def'><p>Defines the OS that code will be generated for</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccb21685-5215-4c79-a19b-2ace3554426b'>CodeOutputLanguage</a></td><td style='width:75%' ><p>Defines the language that code will be output in.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#006036ea-70ff-4355-975c-20de7e52ac2b'>CodeOutputLibrary</a></td><td style='width:75%' class='def'><p>Code output library.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bed72a88-fa7b-4b40-aa3d-d2a470d58898'>KimonoCodeGenerator</a></td><td style='width:75%' ><p>The Kimono Code Generator has routine to assist in the generation of output source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe535d44-38bf-48f6-be7b-e09267aca093'>IKimonoCodeGeneration</a></td><td style='width:75%' class='def'><p>Interface for any Kimono Object that support source code generation.</p>
</td></tr></table></p>


---

<a name="6cf3de51-1a6a-406c-9f4a-346b48f2fbe1"></a>
## KimonoCore.Kimono

<p><table style='width:100%'><tr><th style='width:25%'>Type</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7a2b9cd4-a155-473d-87a3-0efc8eb67312'>PortfolioEventDelegate</a></td><td style='width:75%' ><p>Portfolio event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#05ac79f0-535e-4099-ae1c-7c4633b443d5'>SketchEventDelegate</a></td><td style='width:75%' class='def'><p>Sketch event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5b1f028-e1de-4164-85ca-775388b14f66'>StyleEventDelegate</a></td><td style='width:75%' ><p>Style event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc5a2e34-eb5b-49cd-88e3-18caf2eb1a45'>ShapeEventDelegate</a></td><td style='width:75%' class='def'><p>Shape event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5402a3a-3a82-4baa-b305-8d4da6d4de43'>ToolEventDelegate</a></td><td style='width:75%' ><p>Tool event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d003ef1-1679-4ab2-8ca0-b853e611c519'>SkiaPointEventDelegate</a></td><td style='width:75%' class='def'><p>Skia point event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4baac2ff-cbb0-4808-b0cf-c7f406de407b'>GroupEventDelegate</a></td><td style='width:75%' ><p>Group event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#50adb16e-02fe-4fdc-902f-95211d7137f0'>ColorEventDelegate</a></td><td style='width:75%' class='def'><p>Color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a0ecae65-25e0-4c96-b8bf-ecee92797399'>SkiaColorEventDelegate</a></td><td style='width:75%' ><p>Skia color event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9b9d8aa-3d90-436c-a40d-2b63a4ae2612'>GradientEventDelegate</a></td><td style='width:75%' class='def'><p>Gradient event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32baa88b-c252-42c1-80cd-f916e5b5787a'>HandleEventDelegate</a></td><td style='width:75%' ><p>Handle event delegate.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3c992c6-f6ce-4bf3-acbf-18c88d895e83'>PropertyEventDelegate</a></td><td style='width:75%' class='def'><p>Property event delegate.</p>
</td></tr></table></p>

<a name="Types"></a>
# Types


---

<a name="84e8cd66-169a-4152-a62a-99a9f0d2a4de"></a>
## KimonoSketch

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Holds a collection of `KimonoShapes` that are used to create a given image using Skia.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#10822042-e47b-4424-a01b-3c880497c514'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="10822042-e47b-4424-a01b-3c880497c514"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d497fcf-faa1-47f9-9446-635505f5b8fd'>PreviousSize</a></td><td style='width:75%' class='def'><p><a name="1d497fcf-faa1-47f9-9446-635505f5b8fd"></a>
<b>PreviousSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the previous of a sketch for a rezise operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54bd0f4e-f1e0-44ad-9de9-a97152841399'>Size</a></td><td style='width:75%' ><p><a name="54bd0f4e-f1e0-44ad-9de9-a97152841399"></a>
<b>Size</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The current size of the sketch</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#463abd94-2845-4acf-859a-104ec2eed1db'>_tool</a></td><td style='width:75%' class='def'><p><a name="463abd94-2845-4acf-859a-104ec2eed1db"></a>
<b>_tool</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently <code>KimonoTool</code> that will be used to edit the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7332f5d1-cd90-4166-afd5-30327e92882d'>_canvasColor</a></td><td style='width:75%' ><p><a name="7332f5d1-cd90-4166-afd5-30327e92882d"></a>
<b>_canvasColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6b124ae-9faa-42dc-a715-3b94a69a77e9'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="a6b124ae-9faa-42dc-a715-3b94a69a77e9"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b583fdaa-d623-4468-bf19-d49d294184c3'>IgnoreDrag</a></td><td style='width:75%' ><p><a name="b583fdaa-d623-4468-bf19-d49d294184c3"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eeebc5a8-f627-435b-823e-3c8b3cea6804'>PerformingDrag</a></td><td style='width:75%' class='def'><p><a name="eeebc5a8-f627-435b-823e-3c8b3cea6804"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#28b29700-6ed0-45dd-8360-453db4fdb7e7'>ToolDownAt</a></td><td style='width:75%' ><p><a name="28b29700-6ed0-45dd-8360-453db4fdb7e7"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d1bbf169-9172-451f-897a-8710bc4dd872'>UniqueID</a></td><td style='width:75%' ><p><a name="d1bbf169-9172-451f-897a-8710bc4dd872"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a7ee61c-0b98-435f-8dc7-fa4cd66bfb33'>Portfolio</a></td><td style='width:75%' class='def'><p><a name="4a7ee61c-0b98-435f-8dc7-fa4cd66bfb33"></a></p>

<h3>Portfolio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the portfolio that this sketch belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca297dcf-880c-42e3-97db-3a27db271050'>ElementName</a></td><td style='width:75%' ><p><a name="ca297dcf-880c-42e3-97db-3a27db271050"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c546485c-c55e-4ecc-8a8b-b9e11fd37049'>Name</a></td><td style='width:75%' class='def'><p><a name="c546485c-c55e-4ecc-8a8b-b9e11fd37049"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed648a4c-6701-4e28-9d97-2c81168e1a46'>GenerateCodeToOuputToCanvas</a></td><td style='width:75%' ><p><a name="ed648a4c-6701-4e28-9d97-2c81168e1a46"></a></p>

<h3>GenerateCodeToOuputToCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, ouput a method that draws into the given SkiaSharp Canvas.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe9ac32c-02d8-47d9-bd45-43f544939a15'>GenerateCodeToOuputSkiaData</a></td><td style='width:75%' class='def'><p><a name="fe9ac32c-02d8-47d9-bd45-43f544939a15"></a></p>

<h3>GenerateCodeToOuputSkiaData</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the SkiaSharp Data (<code>SKData[]</code>) representing the Sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput skia data; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9c1ad72-088f-4c44-9b59-58217517fd0d'>GenerateCodeToOuputBitmapImage</a></td><td style='width:75%' ><p><a name="e9c1ad72-088f-4c44-9b59-58217517fd0d"></a></p>

<h3>GenerateCodeToOuputBitmapImage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as a OS specific bitmap image.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput bitmap image; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e906239-d34d-4c4c-a827-e84733b01389'>GenerateCodeToOuputToSkiaSharpViews</a></td><td style='width:75%' class='def'><p><a name="5e906239-d34d-4c4c-a827-e84733b01389"></a></p>

<h3>GenerateCodeToOuputToSkiaSharpViews</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>When converting this Sketch to source code, output a method that returns the Sketch as class based on the <code>SkiaSharp.Views</code> extension library.</p>

<h4>Return Value</h4>

<p><code>true</code> if generate code to ouput to skia sharp views; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3361c0be-4f27-4633-b40d-4edbfab00917'>Width</a></td><td style='width:75%' ><p><a name="3361c0be-4f27-4633-b40d-4edbfab00917"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d7dc070f-af07-4327-9bf0-1fb1e0ded12f'>Height</a></td><td style='width:75%' class='def'><p><a name="d7dc070f-af07-4327-9bf0-1fb1e0ded12f"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#171f2345-51c8-4b48-b0f4-7b3d1dcdf62c'>CanvasColor</a></td><td style='width:75%' ><p><a name="171f2345-51c8-4b48-b0f4-7b3d1dcdf62c"></a></p>

<h3>CanvasColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the canvas.</p>

<h4>Return Value</h4>

<p>The color of the canvas.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e194b68-3c1f-4f5b-8beb-aeedd1224589'>DrawCanvas</a></td><td style='width:75%' class='def'><p><a name="0e194b68-3c1f-4f5b-8beb-aeedd1224589"></a></p>

<h3>DrawCanvas</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#84e8cd66-169a-4152-a62a-99a9f0d2a4de">KimonoSketch</a> should draw  the canvas when it is included in another sketch.</p>

<h4>Return Value</h4>

<p><code>true</code> if draw canvas; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6482b185-caf9-48f8-bf38-debb9cbb9bf7'>Shapes</a></td><td style='width:75%' ><p><a name="6482b185-caf9-48f8-bf38-debb9cbb9bf7"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45c261a8-0370-453e-8981-3f3c185081e0'>Tool</a></td><td style='width:75%' class='def'><p><a name="45c261a8-0370-453e-8981-3f3c185081e0"></a></p>

<h3>Tool</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tool.</p>

<h4>Return Value</h4>

<p>The tool.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1018fd6-43e8-4501-80ea-57c82a7a14d2'>SelectedShape</a></td><td style='width:75%' ><p><a name="f1018fd6-43e8-4501-80ea-57c82a7a14d2"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#57bd4b0f-6511-40ad-9bbd-1e5b12df09e5'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="57bd4b0f-6511-40ad-9bbd-1e5b12df09e5"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8a660f8-25cd-454f-969b-4bdb9108b902'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="a8a660f8-25cd-454f-969b-4bdb9108b902"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#164d906b-9a44-40d6-8865-bc1157952243'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="164d906b-9a44-40d6-8865-bc1157952243"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e944b364-a680-436d-bb71-a97884ba2081'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="e944b364-a680-436d-bb71-a97884ba2081"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2698f49-60d9-4ec2-95bf-3a966cad82e1'>CanAlignShapes</a></td><td style='width:75%' class='def'><p><a name="e2698f49-60d9-4ec2-95bf-3a966cad82e1"></a></p>

<h3>CanAlignShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether alignment can be applied on a set of shapes.</p>

<h4>Return Value</h4>

<p><code>true</code> if can align shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80422e19-fe1f-4ee9-ac9b-3bc3626642c6'>CanGroupShapes</a></td><td style='width:75%' ><p><a name="80422e19-fe1f-4ee9-ac9b-3bc3626642c6"></a></p>

<h3>CanGroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be grouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1a2cf99-ed71-4465-a408-5b840a29087b'>CanUngroupShapes</a></td><td style='width:75%' class='def'><p><a name="f1a2cf99-ed71-4465-a408-5b840a29087b"></a></p>

<h3>CanUngroupShapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selection of shapes can be ungrouped.</p>

<h4>Return Value</h4>

<p><code>true</code> if can group shapes; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#842211fa-b310-42dc-a21e-f63372624a42'>KimonoSketch</a></td><td style='width:75%' ><p><a name="842211fa-b310-42dc-a21e-f63372624a42"></a></p>

<h3>KimonoSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#84e8cd66-169a-4152-a62a-99a9f0d2a4de">KimonoSketch</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0eb058a-3a66-4b0d-94b6-208e743ada64'>KimonoSketch</a></td><td style='width:75%' class='def'><p><a name="c0eb058a-3a66-4b0d-94b6-208e743ada64"></a></p>

<h3>KimonoSketch (System.String, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#84e8cd66-169a-4152-a62a-99a9f0d2a4de">KimonoSketch</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="675195d3-f7ee-4492-b4bc-bff58b3b398a"></a>
Name.</p>
</td></tr><tr><td style='width:25%' class='term'>width</td><td style='width:75%' class='def'><p><a name="8d47ba95-f330-4239-a0bb-c4b78f7d7d1e"></a>
Width.</p>
</td></tr><tr><td style='width:25%' class='term'>height</td><td style='width:75%' ><p><a name="18289f27-9ab1-4dfe-8be6-5bf78c35994a"></a>
Height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d1ab5f3-9114-412b-8896-0d5d861f9118'>Initialize</a></td><td style='width:75%' ><p><a name="8d1ab5f3-9114-412b-8896-0d5d861f9118"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c914845-4714-4efb-9815-df68285a726b'>SavePreviousSize</a></td><td style='width:75%' class='def'><p><a name="8c914845-4714-4efb-9815-df68285a726b"></a></p>

<h3>SavePreviousSize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous size of the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41bef84e-4bd5-4885-b97a-725401081753'>ApplySizeChange</a></td><td style='width:75%' ><p><a name="41bef84e-4bd5-4885-b97a-725401081753"></a></p>

<h3>ApplySizeChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the size change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4a0e8aa-4e31-4022-bd24-ebef9507ed52'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="d4a0e8aa-4e31-4022-bd24-ebef9507ed52"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="db70a64b-d485-4623-be93-468e332a6e48"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ef6d7e8-f240-455c-845d-1aa5810c82b4'>RemoveProperty</a></td><td style='width:75%' ><p><a name="3ef6d7e8-f240-455c-845d-1aa5810c82b4"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="eaf71498-c73f-4d93-bf24-2f05626998f7"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#665c9299-a42a-4c42-8723-033f022e1160'>FindShape</a></td><td style='width:75%' class='def'><p><a name="665c9299-a42a-4c42-8723-033f022e1160"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the shape specified by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="02cf29ec-c59a-4e74-ad0f-ab750ef0d5fd"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>If found, the <code>KimonoShape</code> will be returned, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42ebed36-73e3-4a3b-bb1e-4bd1d9a0646a'>Draw</a></td><td style='width:75%' ><p><a name="42ebed36-73e3-4a3b-bb1e-4bd1d9a0646a"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw this sketch into the give SkiaSharp canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="1ea95baa-ab48-422c-9a5a-ba980b1da083"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fab0ba04-e070-4777-8a13-1c8ec15d54b5'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="fab0ba04-e070-4777-8a13-1c8ec15d54b5"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#add6c369-f222-4053-9fb2-33f905978738'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p><a name="add6c369-f222-4053-9fb2-33f905978738"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d023834-325e-44ee-ab2c-da091b8b6493'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p><a name="4d023834-325e-44ee-ab2c-da091b8b6493"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a22d91ba-3017-400c-904c-42dff73ebba9'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="a22d91ba-3017-400c-904c-42dff73ebba9"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#13d3c440-4f87-4dd8-b706-5bbe806be3b5'>AddShape</a></td><td style='width:75%' class='def'><p><a name="13d3c440-4f87-4dd8-b706-5bbe806be3b5"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="da3ac4db-4f85-44ec-b6b1-dba613f6215c"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2159b248-1e90-49f7-82c4-d34c88fa395b'>RecalculateLayerDepths</a></td><td style='width:75%' ><p><a name="2159b248-1e90-49f7-82c4-d34c88fa395b"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb780acd-fa22-4bcc-8c4c-94ef7743aec4'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="bb780acd-fa22-4bcc-8c4c-94ef7743aec4"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a2bd716-1b7b-4f90-971c-3242054f7758'>DeleteSelectedShape</a></td><td style='width:75%' ><p><a name="0a2bd716-1b7b-4f90-971c-3242054f7758"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22003110-cbbe-48e0-92a6-4cc00be255f9'>SelectShape</a></td><td style='width:75%' class='def'><p><a name="22003110-cbbe-48e0-92a6-4cc00be255f9"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="c240c201-8f5b-43e6-8a65-dd8d9e805aec"></a>
The <code>KimonoShape</code> to select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99576ac5-6d1d-4c73-82ef-a259c0712753'>DeselectAll</a></td><td style='width:75%' ><p><a name="99576ac5-6d1d-4c73-82ef-a259c0712753"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#29611df8-50b5-4449-a708-a9ff333a058f'>GroupUngroupSelectedShapes</a></td><td style='width:75%' class='def'><p><a name="29611df8-50b5-4449-a708-a9ff333a058f"></a></p>

<h3>GroupUngroupSelectedShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups or ungroups the currently selected group of shapes based on the current selection type.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e32f81b2-6e38-48cb-8082-6f6d100c18fd'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="e32f81b2-6e38-48cb-8082-6f6d100c18fd"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#604d732c-ae71-4a67-ab2f-303a2081b6ec'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="604d732c-ae71-4a67-ab2f-303a2081b6ec"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e703da62-ebac-4aaa-b040-11bfbb439261'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="e703da62-ebac-4aaa-b040-11bfbb439261"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#688eebc7-b07c-4da1-8ce9-27f7ba7319d7'>BuildCsharpToCanvasMethod</a></td><td style='width:75%' class='def'><p><a name="688eebc7-b07c-4da1-8ce9-27f7ba7319d7"></a></p>

<h3>BuildCsharpToCanvasMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Build the method to draw into a specific SkiaSharp Canvas in C# source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="358e2bd7-0b28-414f-bf45-9cc74483034c"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the method.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a6d4b6a0-7d9d-4894-ab4b-0baf300c4a7b'>BuildCsharpToSkiaDataMethod</a></td><td style='width:75%' ><p><a name="a6d4b6a0-7d9d-4894-ab4b-0baf300c4a7b"></a></p>

<h3>BuildCsharpToSkiaDataMethod (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to SkiaSharp data (<code>SKData</code>).</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="466c1926-0d55-4dc8-ac23-7f6204f316e9"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The Sketch as <code>SKData</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aeb3a843-46d8-4680-bba8-4d840fc0faa5'>BuildCsharpToBitmapImage</a></td><td style='width:75%' class='def'><p><a name="aeb3a843-46d8-4680-bba8-4d840fc0faa5"></a></p>

<h3>BuildCsharpToBitmapImage (KimonoCore.CodeOutputOS)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Bulids the method to convert this Sketch to OS specific bitmap image format.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="aedbc9c1-c6e4-4132-8e12-8fc71063443e"></a>
Output os.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Sketch as a platform specific image.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa264b37-e5ce-4e77-989e-b897be529c66'>BuildCSharpCrossPlatformToImage</a></td><td style='width:75%' ><p><a name="fa264b37-e5ce-4e77-989e-b897be529c66"></a></p>

<h3>BuildCSharpCrossPlatformToImage (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# ToImage method for Cross Platform image support.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="1a6f23ba-7217-4e81-b9fa-9cf4cdbd1870"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>Conditionally compiled code to support all of the different image types.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9d20a7a6-99a5-4e56-9865-d4c43956c4d5'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="9d20a7a6-99a5-4e56-9865-d4c43956c4d5"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="40d02992-c80e-4fc6-8ff6-deea6e20adc5"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99b2ae14-e20b-4188-b02a-92c46a7036f3'>ToCSharpUsingStatements</a></td><td style='width:75%' ><p><a name="99b2ae14-e20b-4188-b02a-92c46a7036f3"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="2b21609b-7e11-44b0-b706-28f308e89077"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="5e14a5b9-8d01-4502-a561-20f554ddc0b2"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e4ac9f8-bb1c-41f6-ae74-6ef3b9d94ba2'>PortfolioSketchMethods</a></td><td style='width:75%' class='def'><p><a name="2e4ac9f8-bb1c-41f6-ae74-6ef3b9d94ba2"></a></p>

<h3>PortfolioSketchMethods (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary, System.String@, System.String@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the methods that a portfolio will use to draw the sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="975667fd-85b3-4881-ac29-32a241b6a179"></a>
The <code>CodeOutputOS</code> to generate code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="697f12dd-4b57-40d3-b960-f0076b573f57"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>privateMethodsCode</td><td style='width:75%' ><p><a name="36d74902-f43d-44f6-ace1-d3aac3e9d054"></a>
The private methods required by this sketch.</p>
</td></tr><tr><td style='width:25%' class='term'>publicMethodsCode</td><td style='width:75%' class='def'><p><a name="ca135c2a-1276-49c5-b3c1-f1c4dad74c7c"></a>
The public methods required by this sketch.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d59d6020-3149-4ecc-bda5-894750d09b0a'>ToCSharp</a></td><td style='width:75%' ><p><a name="d59d6020-3149-4ecc-bda5-894750d09b0a"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b2939528-e6e7-4302-8d28-1d67c9120b95"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b2ead30-7c92-433b-8b76-e81b952a50fa'>ToCSharpKimono</a></td><td style='width:75%' class='def'><p><a name="4b2ead30-7c92-433b-8b76-e81b952a50fa"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="083a3c2a-0122-4354-9951-4fbdf1a66d75"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="d913a245-fdda-4b2d-ae64-3d03d1fd1173"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="893b0a78-12bf-4b02-a0f4-b71f78b1c7b3"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d3b0ef8-1469-4247-82a4-5f1785074d92'>ToCode</a></td><td style='width:75%' ><p><a name="5d3b0ef8-1469-4247-82a4-5f1785074d92"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="20387602-7a9e-4f51-88dc-1032dd63f2b9"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="808ad081-872a-4129-bc6c-8da2beb053ca"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="9fe0b6a7-54a8-48fa-b081-51858153997c"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c13adfde-09ab-4ed4-84f1-eceb496e8e77'>RelinkShape</a></td><td style='width:75%' class='def'><p><a name="c13adfde-09ab-4ed4-84f1-eceb496e8e77"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="4cad67e8-9f82-4de0-854b-b89b42b257ee"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3a6b77e5-62dd-4580-b8d5-755bc9b8eb8a'>Clone</a></td><td style='width:75%' ><p><a name="3a6b77e5-62dd-4580-b8d5-755bc9b8eb8a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd899707-4eaf-4cd0-9056-339330935aca'>ToolDown</a></td><td style='width:75%' class='def'><p><a name="dd899707-4eaf-4cd0-9056-339330935aca"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="f1023467-c994-4148-9af4-33e0d4467291"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="7bf5060f-d447-4605-ba75-6700d847cb11"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="00a1f5fc-3b99-478c-8939-a7ca0b38d3d6"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f8b023b-8f8d-4e4e-a97b-8617f0536106'>ToolDrag</a></td><td style='width:75%' ><p><a name="0f8b023b-8f8d-4e4e-a97b-8617f0536106"></a></p>

<h3>ToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handle the user dragging the selected <code>KimonoTool</code> on the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="531c1aeb-8765-4c5a-923a-5f88f7a551f0"></a>
The <code>SKPoint</code> representing the new tool position on the Design Surface.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87ba5376-3e09-442f-bc01-46f97e5b4c69'>ToolUp</a></td><td style='width:75%' class='def'><p><a name="87ba5376-3e09-442f-bc01-46f97e5b4c69"></a></p>

<h3>ToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user lifting the current <code>KimonoTool</code> off of the sketch's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="6f092703-c1e2-4777-bf23-ba66cbf4faee"></a>
The <code>SKPoint</code> where the user lifted up the tool.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da08bbf4-8c3a-4ca0-88ca-1ef641d92655'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="da08bbf4-8c3a-4ca0-88ca-1ef641d92655"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84af3428-9ddb-4077-80e2-395cdd7c357c'>RaiseSketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="84af3428-9ddb-4077-80e2-395cdd7c357c"></a></p>

<h3>RaiseSketchSizeChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch size changed event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0397c493-2447-4821-b2ae-c9ec2b787ee7'>RaiseSketchModified</a></td><td style='width:75%' ><p><a name="0397c493-2447-4821-b2ae-c9ec2b787ee7"></a></p>

<h3>RaiseSketchModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketch modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b15bb772-3412-482c-b837-ee1127fa6e34'>RaiseImageBufferNeedsRefresh</a></td><td style='width:75%' class='def'><p><a name="b15bb772-3412-482c-b837-ee1127fa6e34"></a></p>

<h3>RaiseImageBufferNeedsRefresh ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the image buffer needs refresh event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e45d118b-f27c-495b-a008-7d9cce1e16c5'>RaiseSelectedShapeModified</a></td><td style='width:75%' ><p><a name="e45d118b-f27c-495b-a008-7d9cce1e16c5"></a></p>

<h3>RaiseSelectedShapeModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aee6deb6-f24d-4ed4-beb4-427ff2da676c'>RaiseSelectionChanged</a></td><td style='width:75%' class='def'><p><a name="aee6deb6-f24d-4ed4-beb4-427ff2da676c"></a></p>

<h3>RaiseSelectionChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selection changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="632339a3-9b03-4918-84e1-774250e4daca"></a>
Selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b689d096-302f-4ecb-80c6-b5c1d97956a9'>RaiseToolChanged</a></td><td style='width:75%' ><p><a name="b689d096-302f-4ecb-80c6-b5c1d97956a9"></a></p>

<h3>RaiseToolChanged (KimonoCore.KimonoTool)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the tool changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>tool</td><td style='width:75%' ><p><a name="33d03203-0390-4a98-8318-c93fc4aa3a85"></a>
The new <code>KimonoTool</code> that has been selected.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b81ccfb1-1cb4-4ec2-be64-d42b9470c1b3'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="b81ccfb1-1cb4-4ec2-be64-d42b9470c1b3"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab6da8c0-ab9d-424c-a077-75dc3fce6a9e'>SketchSizeChanged</a></td><td style='width:75%' class='def'><p><a name="ab6da8c0-ab9d-424c-a077-75dc3fce6a9e"></a></p>

<h3>SketchSizeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch size changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d52f783f-fa8f-43a2-83a4-40f2b39d6437'>SketchModified</a></td><td style='width:75%' ><p><a name="d52f783f-fa8f-43a2-83a4-40f2b39d6437"></a></p>

<h3>SketchModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketch modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31916876-ded8-401d-b0e0-a58a56637c74'>ImageBufferNeedsRefresh</a></td><td style='width:75%' class='def'><p><a name="31916876-ded8-401d-b0e0-a58a56637c74"></a></p>

<h3>ImageBufferNeedsRefresh</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when image buffer needs refresh.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2263b750-6be2-4142-8de9-2117e0ee983a'>SelectedShapeModified</a></td><td style='width:75%' ><p><a name="2263b750-6be2-4142-8de9-2117e0ee983a"></a></p>

<h3>SelectedShapeModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9c69d1a-eee1-49bf-abe8-5093d5ae27a5'>SelectionChanged</a></td><td style='width:75%' class='def'><p><a name="c9c69d1a-eee1-49bf-abe8-5093d5ae27a5"></a></p>

<h3>SelectionChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selection changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53290b66-3578-49c0-9219-f662d2f80c2f'>ToolChanged</a></td><td style='width:75%' ><p><a name="53290b66-3578-49c0-9219-f662d2f80c2f"></a></p>

<h3>ToolChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when tool changed.</p>
</td></tr></table></p>


---

<a name="ec3f0a06-9f07-45d7-a365-bf12f58f8811"></a>
## KimonoTool

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the current tool that is active in a `KimonoSketch` that the user can use to create or modify a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#31b9f111-73b3-4e7d-b8f6-ac28062e277c'>Cursor</a></td><td style='width:75%' ><p><a name="31b9f111-73b3-4e7d-b8f6-ac28062e277c"></a>
<b>Cursor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Cursor tool to modify an existing <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f5dcf29-9524-42ae-985e-78ae1ee7ba6d'>Line</a></td><td style='width:75%' class='def'><p><a name="8f5dcf29-9524-42ae-985e-78ae1ee7ba6d"></a>
<b>Line</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Line tool to add a new <code>KimonoShapeLine</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c677b0c3-a559-478c-9e85-b3cee1aeb589'>Arrow</a></td><td style='width:75%' ><p><a name="c677b0c3-a559-478c-9e85-b3cee1aeb589"></a>
<b>Arrow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Arrow tool to add a new <code>KimonoShapeArrow</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27b32f0e-eaa0-46b2-880b-82a2c5386d24'>Rectangle</a></td><td style='width:75%' class='def'><p><a name="27b32f0e-eaa0-46b2-880b-82a2c5386d24"></a>
<b>Rectangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Rectangle tool to add a new <code>KimonoShapeRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2aa6512d-e8cf-4c40-abf0-d680d63a92bb'>Oval</a></td><td style='width:75%' ><p><a name="2aa6512d-e8cf-4c40-abf0-d680d63a92bb"></a>
<b>Oval</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Oval tool to add a new <code>KimonoShapeOval</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6e210b55-9014-4dc8-94b9-6506da7707c3'>RoundRect</a></td><td style='width:75%' class='def'><p><a name="6e210b55-9014-4dc8-94b9-6506da7707c3"></a>
<b>RoundRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Round Rect tool to add a new <code>KimonoShapeRoundRect</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d42480e8-1207-4a45-9d79-c1b651314fda'>Star</a></td><td style='width:75%' ><p><a name="d42480e8-1207-4a45-9d79-c1b651314fda"></a>
<b>Star</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Star tool to add a new <code>KimonoShapeStar</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e967c5dc-61ec-4e98-acb3-534757a13869'>Polygon</a></td><td style='width:75%' class='def'><p><a name="e967c5dc-61ec-4e98-acb3-534757a13869"></a>
<b>Polygon</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Polygon tool to add a new <code>KimonoShapePolygon</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f515941-6d02-432f-b39b-f0fdc9e42729'>Triangle</a></td><td style='width:75%' ><p><a name="4f515941-6d02-432f-b39b-f0fdc9e42729"></a>
<b>Triangle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Triangle tool to add a new <code>KimonoShapeTriangle</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e363066a-9511-46e8-b32e-5b0f04a14a6e'>Vector</a></td><td style='width:75%' class='def'><p><a name="e363066a-9511-46e8-b32e-5b0f04a14a6e"></a>
<b>Vector</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Vector tool to add a new <code>KimonoShapeVector</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8dbc802-4b2b-42e8-80dc-f5d090f71944'>Bezier</a></td><td style='width:75%' ><p><a name="f8dbc802-4b2b-42e8-80dc-f5d090f71944"></a>
<b>Bezier</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Bezier tool to add a new <code>KimonoShapeBezier</code> to the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fced918-ee00-4e8d-ba8c-3a8e55b09485'>Text</a></td><td style='width:75%' class='def'><p><a name="7fced918-ee00-4e8d-ba8c-3a8e55b09485"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Use the Text tool to add a new <code>KimonoShapeText</code> to the sketch.</p>
</td></tr></table></p>


---

<a name="c6781695-6cb5-4c7a-8618-b183f94a5fd4"></a>
## Kimono

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Holds a set of shared utilities that are used across the Kimono classes.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7fd2ea3e-e2e8-4e9d-ae2c-3ec412849e19'>CharIsNumber</a></td><td style='width:75%' ><p><a name="7fd2ea3e-e2e8-4e9d-ae2c-3ec412849e19"></a></p>

<h3>CharIsNumber (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a number character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="feb3e756-a558-4fd8-a448-cc7ad56ca74a"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is character is a number, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3763b083-1b42-4089-845a-c4f6dae8771d'>CharIsLetter</a></td><td style='width:75%' class='def'><p><a name="3763b083-1b42-4089-845a-c4f6dae8771d"></a></p>

<h3>CharIsLetter (System.Char)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given character is a letter character.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>c</td><td style='width:75%' ><p><a name="44d3de0d-2760-447e-9027-ee6deb6b95ef"></a>
C.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if is letter was chared, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3734aed3-0c71-4aa7-96bc-732ea451dcb9'>IncrementName</a></td><td style='width:75%' ><p><a name="3734aed3-0c71-4aa7-96bc-732ea451dcb9"></a></p>

<h3>IncrementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increments the name by appending a number to the end or incrementing an existing number count.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="1591e2ce-0a69-4e8a-ac7c-c60fafea9ba2"></a>
Name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f33195e4-1379-4593-b736-c21ba8ad11ff'>CloneSKPoint</a></td><td style='width:75%' class='def'><p><a name="f33195e4-1379-4593-b736-c21ba8ad11ff"></a></p>

<h3>CloneSKPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPoint</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="da7c6c68-d7b2-43fe-b0ec-01dfbe3706a8"></a>
The <code>SKPoint</code> to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>A clone of the given point.</p>
</td></tr></table></p>


---

<a name="7a2b9cd4-a155-473d-87a3-0efc8eb67312"></a>
## PortfolioEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Portfolio event delegate.

---

<a name="05ac79f0-535e-4099-ae1c-7c4633b443d5"></a>
## SketchEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Sketch event delegate.

---

<a name="c5b1f028-e1de-4164-85ca-775388b14f66"></a>
## StyleEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Style event delegate.

---

<a name="cc5a2e34-eb5b-49cd-88e3-18caf2eb1a45"></a>
## ShapeEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Shape event delegate.

---

<a name="e5402a3a-3a82-4baa-b305-8d4da6d4de43"></a>
## ToolEventDelegate
 
### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Tool event delegate.

---

<a name="6d003ef1-1679-4ab2-8ca0-b853e611c519"></a>
## SkiaPointEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Skia point event delegate.

---

<a name="4baac2ff-cbb0-4808-b0cf-c7f406de407b"></a>
## GroupEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Group event delegate.

---

<a name="50adb16e-02fe-4fdc-902f-95211d7137f0"></a>
## ColorEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Color event delegate.

---

<a name="a0ecae65-25e0-4c96-b8bf-ecee92797399"></a>
## SkiaColorEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Skia color event delegate.

---

<a name="e9b9d8aa-3d90-436c-a40d-2b63a4ae2612"></a>
## GradientEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Gradient event delegate.

---

<a name="32baa88b-c252-42c1-80cd-f916e5b5787a"></a>
## HandleEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Handle event delegate.

---

<a name="b3c992c6-f6ce-4bf3-acbf-18c88d895e83"></a>
## PropertyEventDelegate

### Namespace

[KimonoCore.Kimono](#6cf3de51-1a6a-406c-9f4a-346b48f2fbe1)

### Added In API Version

01.00.00

### Summary

Property event delegate.

---

<a name="035bafdd-7b26-42a7-be68-b5baf315b517"></a>
## KimonoPortfolio

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

A Kimono Portfolio holds a collection of `KimonoSketches`, `KimonoStyles` and `KimonoColors` that define a given Kimono Designer project.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d9be4dcf-b9c7-4683-a004-a48dcca1db18'>_selectedSketch</a></td><td style='width:75%' ><p><a name="d9be4dcf-b9c7-4683-a004-a48dcca1db18"></a>
<b>_selectedSketch</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99c9cfbc-98b1-40f4-875d-fb34ac8f7e78'>NewSketchNumber</a></td><td style='width:75%' class='def'><p><a name="99c9cfbc-98b1-40f4-875d-fb34ac8f7e78"></a>
<b>NewSketchNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the number that will be assigned to the next new <code>KimonoSketch</code> created in this portfolio.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a408834b-5d57-4304-aa9e-c4f3aa976239'>UniqueID</a></td><td style='width:75%' ><p><a name="a408834b-5d57-4304-aa9e-c4f3aa976239"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65ffaf7c-b2dc-45c6-98c4-c74508e4cf2a'>ElementName</a></td><td style='width:75%' class='def'><p><a name="65ffaf7c-b2dc-45c6-98c4-c74508e4cf2a"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b08173b8-4b1f-4f2d-b0d1-4a2f44b684d9'>Name</a></td><td style='width:75%' ><p><a name="b08173b8-4b1f-4f2d-b0d1-4a2f44b684d9"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ed92f43a-ac35-4725-a127-728b875ad801'>Namespace</a></td><td style='width:75%' class='def'><p><a name="ed92f43a-ac35-4725-a127-728b875ad801"></a></p>

<h3>Namespace</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the namespace.</p>

<h4>Return Value</h4>

<p>The namespace.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8e9c85e-dd38-48bd-9ac0-e0923c88742d'>Author</a></td><td style='width:75%' ><p><a name="e8e9c85e-dd38-48bd-9ac0-e0923c88742d"></a></p>

<h3>Author</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the author.</p>

<h4>Return Value</h4>

<p>The author.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfb53b5f-9d60-45a5-9344-c28fdbe46cbd'>Copyright</a></td><td style='width:75%' class='def'><p><a name="bfb53b5f-9d60-45a5-9344-c28fdbe46cbd"></a></p>

<h3>Copyright</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the copyright.</p>

<h4>Return Value</h4>

<p>The copyright.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#41d03389-b079-4f0f-838c-c45dbb5a09cd'>Sketches</a></td><td style='width:75%' ><p><a name="41d03389-b079-4f0f-838c-c45dbb5a09cd"></a></p>

<h3>Sketches</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the sketches.</p>

<h4>Return Value</h4>

<p>The sketches.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e6577165-681a-4102-a65c-5961d5248c4a'>Styles</a></td><td style='width:75%' class='def'><p><a name="e6577165-681a-4102-a65c-5961d5248c4a"></a></p>

<h3>Styles</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the styles.</p>

<h4>Return Value</h4>

<p>The styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#998cdbc0-3392-49e3-a1e5-846b73375c0e'>Colors</a></td><td style='width:75%' ><p><a name="998cdbc0-3392-49e3-a1e5-846b73375c0e"></a></p>

<h3>Colors</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the colors.</p>

<h4>Return Value</h4>

<p>The colors.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e4eb0c1-d17d-4ec8-a687-1736b7011a63'>Gradients</a></td><td style='width:75%' class='def'><p><a name="5e4eb0c1-d17d-4ec8-a687-1736b7011a63"></a></p>

<h3>Gradients</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the gradients.</p>

<h4>Return Value</h4>

<p>The gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ceb4f61c-e6d4-49f4-8995-a4f16a79eabe'>Properties</a></td><td style='width:75%' ><p><a name="ceb4f61c-e6d4-49f4-8995-a4f16a79eabe"></a></p>

<h3>Properties</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the properties.</p>

<h4>Return Value</h4>

<p>The properties.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f214896b-b2cf-4832-86d4-6d388c1a5d74'>SelectedSketch</a></td><td style='width:75%' class='def'><p><a name="f214896b-b2cf-4832-86d4-6d388c1a5d74"></a></p>

<h3>SelectedSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected sketch.</p>

<h4>Return Value</h4>

<p>The selected sketch.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#18df924c-d81a-4f53-8015-2b8adbf6749f'>KimonoPortfolio</a></td><td style='width:75%' ><p><a name="18df924c-d81a-4f53-8015-2b8adbf6749f"></a></p>

<h3>KimonoPortfolio (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#035bafdd-7b26-42a7-be68-b5baf315b517">KimonoPortfolio</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>initialize</td><td style='width:75%' ><p><a name="325dfa43-6036-4bca-b7ce-279be11a6a54"></a>
If <code>true</code>, the new instance will be initialized with the default values.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p><code>initialize</code> is set to <code>false</code> when a clone is being made of given <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#375ed9a3-ce89-4bfd-b209-d310a7f35ee3'>Initialize</a></td><td style='width:75%' class='def'><p><a name="375ed9a3-ce89-4bfd-b209-d310a7f35ee3"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#442895d4-b309-4dfc-b914-de4e74e8f175'>FindSketch</a></td><td style='width:75%' ><p><a name="442895d4-b309-4dfc-b914-de4e74e8f175"></a></p>

<h3>FindSketch (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoSketch</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="2a9d8e42-9770-4603-8157-54aa0bb6ce11"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoSketch</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f713226-2255-47cf-8f2e-8ec87cd92761'>FindColor</a></td><td style='width:75%' class='def'><p><a name="8f713226-2255-47cf-8f2e-8ec87cd92761"></a></p>

<h3>FindColor (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoColor</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="b558649c-e4b5-42f6-8975-b505a073cc5a"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoColor</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9b58aca5-ec7d-46cd-9542-79e1e0b4c425'>FindProperty</a></td><td style='width:75%' ><p><a name="9b58aca5-ec7d-46cd-9542-79e1e0b4c425"></a></p>

<h3>FindProperty (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoProperty</code> by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="2a951378-c3ee-4f1c-8df3-bd62041c9ac5"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoProperty</code> if founs, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d2eed7a-e3d2-42de-9bf9-98e2324616ac'>FindGradient</a></td><td style='width:75%' class='def'><p><a name="1d2eed7a-e3d2-42de-9bf9-98e2324616ac"></a></p>

<h3>FindGradient (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the gradient by its unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="2b00254f-a176-47dc-ad22-c4daba0f5dea"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoGradient</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6696416-7a78-4964-97d8-1c01ead0dfed'>FindStyle</a></td><td style='width:75%' ><p><a name="d6696416-7a78-4964-97d8-1c01ead0dfed"></a></p>

<h3>FindStyle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the given <code>KimonoStyle</code> by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="f2144507-b6b6-4912-b786-4674cdab9a5c"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f270a36c-700f-4c23-ab51-48e3c2bf0dd9'>AddNewSketch</a></td><td style='width:75%' class='def'><p><a name="f270a36c-700f-4c23-ab51-48e3c2bf0dd9"></a></p>

<h3>AddNewSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoSketch</code> to this portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b34f718-6e75-4b29-8d12-e10f2766cd16'>DuplicateSelectedSketch</a></td><td style='width:75%' ><p><a name="6b34f718-6e75-4b29-8d12-e10f2766cd16"></a></p>

<h3>DuplicateSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c6b4e3a6-c78f-4c26-a819-3b4b2e43ac28'>DeleteSelectedSketch</a></td><td style='width:75%' class='def'><p><a name="c6b4e3a6-c78f-4c26-a819-3b4b2e43ac28"></a></p>

<h3>DeleteSelectedSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9169d547-1dbe-4f36-b996-aeacf0b0c1c8'>AddNewGradient</a></td><td style='width:75%' ><p><a name="9169d547-1dbe-4f36-b996-aeacf0b0c1c8"></a></p>

<h3>AddNewGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the new gradient.</p>

<h4>Returns</h4>

<p>The new gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1170687c-4be1-4062-a143-eec638d3be11'>AddNewColor</a></td><td style='width:75%' class='def'><p><a name="1170687c-4be1-4062-a143-eec638d3be11"></a></p>

<h3>AddNewColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio.</p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d54ce38-0e45-43eb-8e95-a38b6b315135'>AddNewColor</a></td><td style='width:75%' ><p><a name="5d54ce38-0e45-43eb-8e95-a38b6b315135"></a></p>

<h3>AddNewColor (SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new <code>KimonoColor</code> to this portfolio based off of a given <code>SKColor</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>baseColor</td><td style='width:75%' ><p><a name="6cb98b48-fe92-4c01-b3a2-9701e682173d"></a>
Base color.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a664b3f-80de-4beb-90ba-6cb2404c45dc'>AddPropertyBoolean</a></td><td style='width:75%' class='def'><p><a name="8a664b3f-80de-4beb-90ba-6cb2404c45dc"></a></p>

<h3>AddPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new boolean property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyBoolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b16bfb8c-c52f-472c-9a53-ee9a15cab04c'>AddPropertyColor</a></td><td style='width:75%' ><p><a name="b16bfb8c-c52f-472c-9a53-ee9a15cab04c"></a></p>

<h3>AddPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new color property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a7b6706-1f1b-4ef3-a92a-b6b79855fc9c'>AddPropertyGradient</a></td><td style='width:75%' class='def'><p><a name="6a7b6706-1f1b-4ef3-a92a-b6b79855fc9c"></a></p>

<h3>AddPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new gradient property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyGradient</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0041618-4917-4ca8-83d4-04c2955ab206'>AddPropertyNumber</a></td><td style='width:75%' ><p><a name="c0041618-4917-4ca8-83d4-04c2955ab206"></a></p>

<h3>AddPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new number property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyNumber</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f897f62c-4dc9-4b3f-b4f1-5e37b2fd7d74'>AddPropertyRect</a></td><td style='width:75%' class='def'><p><a name="f897f62c-4dc9-4b3f-b4f1-5e37b2fd7d74"></a></p>

<h3>AddPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new rect property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a37289c-0e66-4251-bb6f-a2a78c5d5923'>AddPropertyStyle</a></td><td style='width:75%' ><p><a name="9a37289c-0e66-4251-bb6f-a2a78c5d5923"></a></p>

<h3>AddPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new style property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#52d6f498-e984-44a3-a48f-697710bb9beb'>AddPropertyText</a></td><td style='width:75%' class='def'><p><a name="52d6f498-e984-44a3-a48f-697710bb9beb"></a></p>

<h3>AddPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new text property.</p>

<h4>Returns</h4>

<p>The new <code>KimonoPropertyText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ea78d88-196a-43d5-8f47-890b8cbd0388'>AddNewProperty</a></td><td style='width:75%' ><p><a name="4ea78d88-196a-43d5-8f47-890b8cbd0388"></a></p>

<h3>AddNewProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoProperty</code> to this portfolio</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="a1b40aa3-50bb-4897-8c21-43bca95f45cc"></a>
The <code>KimonoProperty</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b99b00f8-fb92-4df9-9567-4b10588d64d6'>DuplicateColor</a></td><td style='width:75%' class='def'><p><a name="b99b00f8-fb92-4df9-9567-4b10588d64d6"></a></p>

<h3>DuplicateColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoColor</code> and adds it to the portfolio's collection of colors.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="f2060976-f08f-4624-9253-56b30a1f2fa6"></a>
The <code>KimonoColor</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be2ea42e-597d-42ef-bfdd-252c8957c411'>DuplicateProperty</a></td><td style='width:75%' ><p><a name="be2ea42e-597d-42ef-bfdd-252c8957c411"></a></p>

<h3>DuplicateProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="82277766-3c5f-4ed3-a6b9-4660333205c2"></a>
The <code>KimonoProperty</code> to duplicate.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad6f005a-8af2-4597-8fa6-d2004dbae6fe'>DuplicateGradient</a></td><td style='width:75%' class='def'><p><a name="ad6f005a-8af2-4597-8fa6-d2004dbae6fe"></a></p>

<h3>DuplicateGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the gradient.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="6d274a75-8fcd-48f8-ae8b-c84bd78619de"></a>
The <code>KimonoGradient</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd54fec4-296c-40b7-a5c0-3f05b6590d34'>DeleteColor</a></td><td style='width:75%' ><p><a name="fd54fec4-296c-40b7-a5c0-3f05b6590d34"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="b8590eab-5a83-40e8-8c47-0bfe204a8986"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4cb6d36-e4a4-4efa-99e9-3aa257c7d119'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="e4cb6d36-e4a4-4efa-99e9-3aa257c7d119"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the portfolio.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="5984c9c2-b6cf-46b0-abd3-726ab0aa51f9"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#193823cf-13c8-498e-bd22-9db2f810f68b'>DeleteProperty</a></td><td style='width:75%' ><p><a name="193823cf-13c8-498e-bd22-9db2f810f68b"></a></p>

<h3>DeleteProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="782fbec8-32fe-4775-b559-3525a423269a"></a>
The <code>KimonoProperty</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6acb3700-597c-4d93-8e28-a4f21ca98864'>AddNewStyle</a></td><td style='width:75%' class='def'><p><a name="6acb3700-597c-4d93-8e28-a4f21ca98864"></a></p>

<h3>AddNewStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the a new <code>KimonoStyle</code> to the portfolio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92b3c4ba-c3f9-4a1e-b8e6-48e1e2111b0f'>DuplicateStyle</a></td><td style='width:75%' ><p><a name="92b3c4ba-c3f9-4a1e-b8e6-48e1e2111b0f"></a></p>

<h3>DuplicateStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the given <code>KimonoStyle</code> adding it to the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="093a8a03-decc-431e-9c37-63beae4636ec"></a>
The <code>KimonoStyle</code> to duplicate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cfa9045-be37-4495-84b9-b42de5a44daf'>ConvertSelectedShapeToStyle</a></td><td style='width:75%' class='def'><p><a name="1cfa9045-be37-4495-84b9-b42de5a44daf"></a></p>

<h3>ConvertSelectedShapeToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Takes the custom <code>KimonoStyle</code> of the currently selected <code>KimonoShape</code>, converts it to a named, shared style and adds it to the portfolio's collection of styles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#874754cf-c05d-4671-83c0-330b35ab1668'>DeleteStyle</a></td><td style='width:75%' ><p><a name="874754cf-c05d-4671-83c0-330b35ab1668"></a></p>

<h3>DeleteStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoStyle</code> from the portfolio's collection of styles.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="e6fca832-46d4-474a-9464-bd8d743689ec"></a>
Style.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a38d0f01-c418-4cbc-a7eb-149a7e74fcad'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="a38d0f01-c418-4cbc-a7eb-149a7e74fcad"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#776e31f4-8aa3-41ac-9c0b-c08a18039150'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="776e31f4-8aa3-41ac-9c0b-c08a18039150"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92ac4f05-457c-44dc-a082-4c6885152b1b'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="92ac4f05-457c-44dc-a082-4c6885152b1b"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e2b3099-240c-4cba-950b-86ba5766ee28'>ToCSharp</a></td><td style='width:75%' ><p><a name="9e2b3099-240c-4cba-950b-86ba5766ee28"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="18687aa9-4af7-4e43-8958-4d87f18c4274"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f7a2d89-5b05-40f1-99e4-da7c3493468a'>ToCSharpUsingStatements</a></td><td style='width:75%' class='def'><p><a name="2f7a2d89-5b05-40f1-99e4-da7c3493468a"></a></p>

<h3>ToCSharpUsingStatements (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Builds the C# using statements.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="5d303b12-ddcb-41b1-a490-90c46ef16ecf"></a>
The <code>CodeOutputOS</code> to write code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="353ec50f-1c17-464f-9c60-e2e1fac85971"></a>
Output library.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The required using statements based on what other features have been selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#516a2d6d-00df-4541-9cf4-2d2e68dfb97a'>ToCSharp</a></td><td style='width:75%' ><p><a name="516a2d6d-00df-4541-9cf4-2d2e68dfb97a"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f4b52256-c535-44ca-a57e-2ad060e0e245"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1d17df1-ce08-445c-912b-9ce5645b969f'>ToCSharpKimono</a></td><td style='width:75%' class='def'><p><a name="f1d17df1-ce08-445c-912b-9ce5645b969f"></a></p>

<h3>ToCSharpKimono (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this sketch to C# code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="ef551f04-bf77-4ab9-a7d7-4abe1bd0b11e"></a>
The <code>CodeOutputOS</code> to create code for.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="dfca389f-e1f7-4aa0-8cee-a636f232465f"></a>
The <code>CodeOutputLanguage</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="26754f99-b6dd-45ae-b6f5-cb9734214949"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The sketch as source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0d105c4-355c-4a2d-abaa-26575bba732a'>ToCode</a></td><td style='width:75%' ><p><a name="c0d105c4-355c-4a2d-abaa-26575bba732a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="cfab828b-c9ab-4935-a36e-a79782fc2414"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="366f1f14-5b16-4489-a4e7-8b15f5e9adbd"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="ae30621a-1a9c-437b-b0aa-bd79cdac9aaf"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d01da1c-ec45-4682-9ee6-3659b8fa623f'>RelinkColors</a></td><td style='width:75%' class='def'><p><a name="3d01da1c-ec45-4682-9ee6-3659b8fa623f"></a></p>

<h3>RelinkColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the colors after a clone operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ea4202a-08bd-46b1-88cc-06b3346d16de'>RelinkGradient</a></td><td style='width:75%' ><p><a name="9ea4202a-08bd-46b1-88cc-06b3346d16de"></a></p>

<h3>RelinkGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the gradient after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="5d350b46-919b-42e3-b6f6-9e801889a271"></a>
The <code>KimonoGradient</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5a27d9b-2d98-45bf-b7fc-0c9b02480a89'>RelinkStyle</a></td><td style='width:75%' class='def'><p><a name="f5a27d9b-2d98-45bf-b7fc-0c9b02480a89"></a></p>

<h3>RelinkStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoStyle</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="00a69559-6d98-406d-86f9-74cecb09fe7d"></a>
The <code>KimonoStyle</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fef08832-7e58-4c4b-bdd5-df1f775d8af5'>RelinkShape</a></td><td style='width:75%' ><p><a name="fef08832-7e58-4c4b-bdd5-df1f775d8af5"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoShape</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="5378ebf3-5890-4339-a935-10614b6b030b"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b27a4a93-fabf-49a4-879c-b6810190fe53'>RelinkSketch</a></td><td style='width:75%' class='def'><p><a name="b27a4a93-fabf-49a4-879c-b6810190fe53"></a></p>

<h3>RelinkSketch (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the given <code>KimonoSketch</code> after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="1508ee7e-3f67-497a-8a1b-04272c6d3a40"></a>
The <code>KimonoSketch</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f79b50fd-52c7-491a-89ee-fdd0771a44f6'>Clone</a></td><td style='width:75%' ><p><a name="f79b50fd-52c7-491a-89ee-fdd0771a44f6"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dda5db68-8954-4877-9e69-9f7213a5c11f'>RaisePropertyModified</a></td><td style='width:75%' class='def'><p><a name="dda5db68-8954-4877-9e69-9f7213a5c11f"></a></p>

<h3>RaisePropertyModified (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the property modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="d8173e79-d542-4178-88fc-b2a7eff6104d"></a>
The <code>KimonoProperty</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ad3a91e5-7f50-4e64-854b-152b3da52a99'>RaiseGradientsModified</a></td><td style='width:75%' ><p><a name="ad3a91e5-7f50-4e64-854b-152b3da52a99"></a></p>

<h3>RaiseGradientsModified (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradients modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="928d9d17-6480-4a03-8c29-321956f8ceed"></a>
The <code>KimonoGradient</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95f77dae-2199-4a77-b9ba-b629e1adf6cd'>RaiseRequestNewUndoPoint</a></td><td style='width:75%' class='def'><p><a name="95f77dae-2199-4a77-b9ba-b629e1adf6cd"></a></p>

<h3>RaiseRequestNewUndoPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the request new undo point event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b73d1b71-789a-4ab9-a7cf-b1ed72179d74'>RaiseSketchesModified</a></td><td style='width:75%' ><p><a name="b73d1b71-789a-4ab9-a7cf-b1ed72179d74"></a></p>

<h3>RaiseSketchesModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the sketches modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25e26a00-b11a-4aa8-894a-b4eeec851407'>RaiseSelectedSketchWillChange</a></td><td style='width:75%' class='def'><p><a name="25e26a00-b11a-4aa8-894a-b4eeec851407"></a></p>

<h3>RaiseSelectedSketchWillChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch will change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="7b0bf6f9-984e-4ce7-8a74-621ef89569bb"></a>
The <code>KimonoSketch</code> that will change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adb13f42-852c-4d2b-9499-a29274ab51df'>RaiseSelectedSketchDidChange</a></td><td style='width:75%' ><p><a name="adb13f42-852c-4d2b-9499-a29274ab51df"></a></p>

<h3>RaiseSelectedSketchDidChange (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected sketch did change event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="665910c3-4a12-499b-9b88-4ab145a906fe"></a>
The <code>KimonoSketch</code> that did change.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2f85bdf-2a55-4dd1-9a69-035494d7627d'>RaiseStylesModified</a></td><td style='width:75%' class='def'><p><a name="a2f85bdf-2a55-4dd1-9a69-035494d7627d"></a></p>

<h3>RaiseStylesModified (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the styles modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="eb106233-a5c2-425b-a763-a324cd5d6105"></a>
The <code>KimonoStyle</code> that was modified.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#573fee83-26c2-4ba3-9777-4f94ac4f602d'>RaiseSelectedShapeChanged</a></td><td style='width:75%' ><p><a name="573fee83-26c2-4ba3-9777-4f94ac4f602d"></a></p>

<h3>RaiseSelectedShapeChanged (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the selected shape changed event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>selected</td><td style='width:75%' ><p><a name="3a409c17-5288-4e55-ac52-cee20652da8e"></a>
The new <code>KimonoShape</code> that was selected.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ef896b1e-61e9-469d-b53f-fd5c741a148d'>RaiseColorsModified</a></td><td style='width:75%' class='def'><p><a name="ef896b1e-61e9-469d-b53f-fd5c741a148d"></a></p>

<h3>RaiseColorsModified (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the colors modified event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="a73b6f73-0caf-445b-8195-fddf261b3ebf"></a>
The <code>KimonoColor</code> that was modified.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#71f11f28-57a8-45cc-a383-d32e82d2448f'>RequestNewUndoPoint</a></td><td style='width:75%' ><p><a name="71f11f28-57a8-45cc-a383-d32e82d2448f"></a></p>

<h3>RequestNewUndoPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a new undo point is requested.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f59d6f3b-43ba-44be-b5bc-e113f40e300f'>SketchesModified</a></td><td style='width:75%' class='def'><p><a name="f59d6f3b-43ba-44be-b5bc-e113f40e300f"></a></p>

<h3>SketchesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when sketches collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc912df4-82b8-41cd-829c-d7753f68333b'>SelectedSketchWillChange</a></td><td style='width:75%' ><p><a name="bc912df4-82b8-41cd-829c-d7753f68333b"></a></p>

<h3>SelectedSketchWillChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch will change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3518d65c-d665-4006-b5da-3906c53fa194'>SelectedSketchDidChange</a></td><td style='width:75%' class='def'><p><a name="3518d65c-d665-4006-b5da-3906c53fa194"></a></p>

<h3>SelectedSketchDidChange</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected sketch did change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20d3e156-1e97-4481-9937-48089bfd7f45'>StylesModified</a></td><td style='width:75%' ><p><a name="20d3e156-1e97-4481-9937-48089bfd7f45"></a></p>

<h3>StylesModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when styles collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9aac84c2-3dbe-4839-b019-1938070df816'>SelectedShapeChanged</a></td><td style='width:75%' class='def'><p><a name="9aac84c2-3dbe-4839-b019-1938070df816"></a></p>

<h3>SelectedShapeChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when selected shape changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9a2792f-c26b-4472-9af9-663a3b9b40ca'>ColorsModified</a></td><td style='width:75%' ><p><a name="a9a2792f-c26b-4472-9af9-663a3b9b40ca"></a></p>

<h3>ColorsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when colors collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70454ebc-73cb-4138-8c2b-2733ee23c7c1'>GradientsModified</a></td><td style='width:75%' class='def'><p><a name="70454ebc-73cb-4138-8c2b-2733ee23c7c1"></a></p>

<h3>GradientsModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when gradients collection is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31e45d8e-b443-4482-9364-e4b9fc73ca94'>PropertyModified</a></td><td style='width:75%' ><p><a name="31e45d8e-b443-4482-9364-e4b9fc73ca94"></a></p>

<h3>PropertyModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when property collection is modified.</p>
</td></tr></table></p>


---

<a name="f650aeee-c69a-464f-b831-0b9b15b3a564"></a>
## KimonoUndoHandler

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Handles the undo/redo state for a `KimonoDesignSurface`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#66d082d9-9a97-4f52-a958-12f885d42af5'>MaximumUndoPoints</a></td><td style='width:75%' ><p><a name="66d082d9-9a97-4f52-a958-12f885d42af5"></a></p>

<h3>MaximumUndoPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the maximum undo points.</p>

<h4>Return Value</h4>

<p>The maximum undo points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a404eafb-14b9-43fc-9469-769d74544d88'>UndoStack</a></td><td style='width:75%' class='def'><p><a name="a404eafb-14b9-43fc-9469-769d74544d88"></a></p>

<h3>UndoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the undo stack.</p>

<h4>Return Value</h4>

<p>The undo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f24ef9c-3fd0-4b6a-9860-f3ddbc74fe0b'>RedoStack</a></td><td style='width:75%' ><p><a name="4f24ef9c-3fd0-4b6a-9860-f3ddbc74fe0b"></a></p>

<h3>RedoStack</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the redo stack.</p>

<h4>Return Value</h4>

<p>The redo stack.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bf3a023-f596-49f5-afc5-6f0f6d07a3cb'>CanUndo</a></td><td style='width:75%' class='def'><p><a name="6bf3a023-f596-49f5-afc5-6f0f6d07a3cb"></a></p>

<h3>CanUndo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can undo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can undo; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#737378ee-aa1c-40c0-909b-0f6cc2b9e69f'>CanRedo</a></td><td style='width:75%' ><p><a name="737378ee-aa1c-40c0-909b-0f6cc2b9e69f"></a></p>

<h3>CanRedo</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the user can redo their last action.</p>

<h4>Return Value</h4>

<p><code>true</code> if can redo; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#563ccc5f-5878-44bb-a61f-b6d4396fc1cb'>KimonoUndoHandler</a></td><td style='width:75%' ><p><a name="563ccc5f-5878-44bb-a61f-b6d4396fc1cb"></a></p>

<h3>KimonoUndoHandler ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f650aeee-c69a-464f-b831-0b9b15b3a564">KimonoUndoHandler</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2bf1e53-a9fc-4379-8cd8-58266ae25012'>PushUndoPoint</a></td><td style='width:75%' class='def'><p><a name="d2bf1e53-a9fc-4379-8cd8-58266ae25012"></a></p>

<h3>PushUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pushes the undo point onto the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="ad5770f6-8bec-4299-ab30-ae325d435198"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d46e5c7f-8875-4353-8a74-9e5b28d86503'>ReplaceLastUndoPoint</a></td><td style='width:75%' ><p><a name="d46e5c7f-8875-4353-8a74-9e5b28d86503"></a></p>

<h3>ReplaceLastUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Replaces the last undo point with the one being passed in.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="4df1e2a3-216a-4eb9-8ab4-54d5c29bc254"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b2edb2b-e76b-4e82-81d2-4f1825ebc334'>PopUndoPoint</a></td><td style='width:75%' class='def'><p><a name="7b2edb2b-e76b-4e82-81d2-4f1825ebc334"></a></p>

<h3>PopUndoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the undo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="c3e89e11-2676-478a-9b45-85d4e152faf9"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The prior state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d953278-20d6-482b-b45e-880f502c7129'>PopRedoPoint</a></td><td style='width:75%' ><p><a name="5d953278-20d6-482b-b45e-880f502c7129"></a></p>

<h3>PopRedoPoint (KimonoCore.KimonoPortfolio)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Pops the redo point off the stack.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>portfolio</td><td style='width:75%' ><p><a name="77dddd26-a849-4ff2-965b-aac6acd14478"></a>
The current state of the <code>KimonoPortfolio</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The previous state of the <code>KimonoPortfolio</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64b6b2cc-ae71-4ac2-b964-ace1117cd9b8'>RaiseUndoStateChanged</a></td><td style='width:75%' class='def'><p><a name="64b6b2cc-ae71-4ac2-b964-ace1117cd9b8"></a></p>

<h3>RaiseUndoStateChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the undo state changed event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2907f3e6-07b3-47f6-8378-8c602fd5f2b8'>UndoStateChanged</a></td><td style='width:75%' ><p><a name="2907f3e6-07b3-47f6-8378-8c602fd5f2b8"></a></p>

<h3>UndoStateChanged</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when undo state changed.</p>
</td></tr></table></p>


---

<a name="f7ecc982-613a-459a-8e8d-06e8ebad6154"></a>
## KimonoShape

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the based shape that all other Kimono Shape types will inherit from.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#45dccfe7-9412-48b9-8b8e-eedf69ad1957'>_name</a></td><td style='width:75%' ><p><a name="45dccfe7-9412-48b9-8b8e-eedf69ad1957"></a>
<b>_name</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default name of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0a430e1-52d3-4b39-ac89-70f7f273c7d0'>_style</a></td><td style='width:75%' class='def'><p><a name="f0a430e1-52d3-4b39-ac89-70f7f273c7d0"></a>
<b>_style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default, custom <code>KimonoStyle</code> that is attached to the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4176fba8-3771-4cdf-b28a-531a7259581b'>_visible</a></td><td style='width:75%' ><p><a name="4176fba8-3771-4cdf-b28a-531a7259581b"></a>
<b>_visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of the shape.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#64a691a8-c134-44c3-9691-55c6a4ff1251'>Name</a></td><td style='width:75%' ><p><a name="64a691a8-c134-44c3-9691-55c6a4ff1251"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#75537ac5-5d70-4d60-9d42-845f27f4a345'>ElementName</a></td><td style='width:75%' class='def'><p><a name="75537ac5-5d70-4d60-9d42-845f27f4a345"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84a501c9-1de5-4d28-bca7-18dd4958befc'>Style</a></td><td style='width:75%' ><p><a name="84a501c9-1de5-4d28-bca7-18dd4958befc"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> that will be used to draw this shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c055f7aa-1bbd-439b-a6a5-5c0aef294d25'>ControlPoints</a></td><td style='width:75%' class='def'><p><a name="c055f7aa-1bbd-439b-a6a5-5c0aef294d25"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the path of the shape.</p>

<h4>Return Value</h4>

<p>A collection of <code>KimonoHandle</code> objects.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d98cd287-fb99-4fdb-8d89-fb4eae0fbe75'>Visible</a></td><td style='width:75%' ><p><a name="d98cd287-fb99-4fdb-8d89-fb4eae0fbe75"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#f7ecc982-613a-459a-8e8d-06e8ebad6154">KimonoShape</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b043fa24-740f-4b25-9ce0-8a67b2e18c46'>IsEditable</a></td><td style='width:75%' class='def'><p><a name="b043fa24-740f-4b25-9ce0-8a67b2e18c46"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#f7ecc982-613a-459a-8e8d-06e8ebad6154">KimonoShape</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>An "Editable Shape" is one that is composed of a set of data points (such as <code>KimonoVector</code> or <code>KimonoBezier</code>) or a group of objects (such as <code>KimonoShapeGroup</code>).</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a167ede3-9f25-4130-943f-dcca0befdbbf'>LayerDepth</a></td><td style='width:75%' ><p><a name="a167ede3-9f25-4130-943f-dcca0befdbbf"></a></p>

<h3>LayerDepth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the layer depth from the bottom to the top controlling how shapes are overlapping on the design surface.</p>

<h4>Return Value</h4>

<p>The layer depth.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#238f1af3-38ed-4323-8843-a20c2f6d1a1b'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="238f1af3-38ed-4323-8843-a20c2f6d1a1b"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7e6b645-3aa7-43a5-95e7-3749b6429890'>PropertyConnections</a></td><td style='width:75%' ><p><a name="a7e6b645-3aa7-43a5-95e7-3749b6429890"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c1688e7b-8a2a-4c4a-92ee-e7a43f3bf6c2'>KimonoShape</a></td><td style='width:75%' ><p><a name="c1688e7b-8a2a-4c4a-92ee-e7a43f3bf6c2"></a></p>

<h3>KimonoShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f7ecc982-613a-459a-8e8d-06e8ebad6154">KimonoShape</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5088fe15-f470-4da6-ade8-3f12c11a705a'>KimonoShape</a></td><td style='width:75%' class='def'><p><a name="5088fe15-f470-4da6-ade8-3f12c11a705a"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f7ecc982-613a-459a-8e8d-06e8ebad6154">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="4e4a3039-41c0-4637-94cd-37b8423da2cd"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c4e02695-51fe-45cb-8dcd-cb6ea62404b4"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="3543cf0b-ebfb-4ab1-a8b8-9db6c0d65892"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="dab8cab7-9201-4a55-8647-873d00319ff0"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c26777f-6684-406b-a501-7c79bf5dd0d1'>KimonoShape</a></td><td style='width:75%' ><p><a name="8c26777f-6684-406b-a501-7c79bf5dd0d1"></a></p>

<h3>KimonoShape (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f7ecc982-613a-459a-8e8d-06e8ebad6154">KimonoShape</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="b0b8baf3-1683-4716-a44d-66f3585f8d28"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="33190e1b-5a99-4061-877d-fd0c80ba0df3"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="7d115f76-8ea8-4bee-b8fb-efe10de6d0f4"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="1db6e72e-440c-49f9-b717-b3b4a924b8ff"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="da9a9690-2290-496e-a927-06232a719ea0"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#516cad2b-26d4-47ac-b538-3e036b0f63e4'>Initialize</a></td><td style='width:75%' class='def'><p><a name="516cad2b-26d4-47ac-b538-3e036b0f63e4"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca9ca400-0c6a-44f7-9506-bcc10a2e645c'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="ca9ca400-0c6a-44f7-9506-bcc10a2e645c"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="46d4a7b7-925a-4469-8a88-6145c019936d"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="4c678184-3859-48ac-88f3-3434aee686c1"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#821cec97-7497-4364-afbb-f695191122ff'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="821cec97-7497-4364-afbb-f695191122ff"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="d83e08e3-cd6a-4822-974c-db9dfe72571f"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0ceebe74-0a7c-482f-a9b7-9afad7bef086'>RemoveProperty</a></td><td style='width:75%' ><p><a name="0ceebe74-0a7c-482f-a9b7-9afad7bef086"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="d50a1dc2-82c2-41b8-9c98-c1298fe44b69"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#95177766-2a7e-45fa-89b4-69ae630621c1'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="95177766-2a7e-45fa-89b4-69ae630621c1"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoShape</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3461dabe-beda-41dd-8edf-ca5cf87b2414'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="3461dabe-beda-41dd-8edf-ca5cf87b2414"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="c6e112e1-4605-4fed-bd99-dd1666207725"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afb530d3-ba4d-43d0-9350-a469b3e71299'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="afb530d3-ba4d-43d0-9350-a469b3e71299"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape in the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5da7668f-1286-4f14-99b5-f37bea38c819'>EndEditing</a></td><td style='width:75%' ><p><a name="5da7668f-1286-4f14-99b5-f37bea38c819"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends the editing mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4af348d7-d71a-476c-9e8b-e022733fa516'>UncoupleDeletedStyle</a></td><td style='width:75%' class='def'><p><a name="4af348d7-d71a-476c-9e8b-e022733fa516"></a></p>

<h3>UncoupleDeletedStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Uncouples the deleted style from the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deletedStyle</td><td style='width:75%' ><p><a name="fc3b0251-76a9-46b7-ae5b-d33b307dc9ae"></a>
The <code>KimonoStyle</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#da79a010-3c48-49c3-89bf-f6084791dffb'>ConformGradientToShape</a></td><td style='width:75%' ><p><a name="da79a010-3c48-49c3-89bf-f6084791dffb"></a></p>

<h3>ConformGradientToShape (KimonoCore.KimonoGradient, SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the gradient to shape by fitting it to the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="34dcf44b-a142-4c8e-aa04-0e1f7e0d284f"></a>
The <code>KimonoGradient</code> to conform.</p>
</td></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' class='def'><p><a name="6c5c2a3f-03fe-4c75-a235-641b718004f1"></a>
The <code>SKPaint</code> that the gradient is being attached to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f926cce-5c14-4dd4-8cfd-f8296b084eef'>ToVector</a></td><td style='width:75%' class='def'><p><a name="1f926cce-5c14-4dd4-8cfd-f8296b084eef"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a vector.</p>

<h4>Returns</h4>

<p>The shape as a <code>KimonoVector</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c502799-1988-4583-8d78-67d33c3ff783'>ToPath</a></td><td style='width:75%' ><p><a name="9c502799-1988-4583-8d78-67d33c3ff783"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b347459-f61c-4ce0-bd9b-5533e1b65a5c'>StyleFillPaintForCode</a></td><td style='width:75%' class='def'><p><a name="3b347459-f61c-4ce0-bd9b-5533e1b65a5c"></a></p>

<h3>StyleFillPaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style fill paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02c0f015-58b6-4be2-a516-f0f36a0574cb'>StyleFramePaintForCode</a></td><td style='width:75%' ><p><a name="02c0f015-58b6-4be2-a516-f0f36a0574cb"></a></p>

<h3>StyleFramePaintForCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the style frame paint for code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d02b5c89-6cfc-4692-9ff7-05d226988839'>ConformedFillGradientCode</a></td><td style='width:75%' class='def'><p><a name="d02b5c89-6cfc-4692-9ff7-05d226988839"></a></p>

<h3>ConformedFillGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e394850d-fab3-4ad6-bff1-4826cdb3c708"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The fill gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#43dfb143-0e05-4389-b21a-c91d428b0de9'>ConformedFrameGradientCode</a></td><td style='width:75%' ><p><a name="43dfb143-0e05-4389-b21a-c91d428b0de9"></a></p>

<h3>ConformedFrameGradientCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Conforms the attached gradient to the shapes bounds for code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b116960a-24d1-4189-8dec-0f777551f353"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The frame gradient conformed in code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b8a00f1c-7e9a-4241-b276-f474fa4d04dd'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="b8a00f1c-7e9a-4241-b276-f474fa4d04dd"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#088508c5-86c2-4297-b954-78be9a7ecc97'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="088508c5-86c2-4297-b954-78be9a7ecc97"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#749e1729-a65e-4e3f-9fd0-7ef14f170ea9'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="749e1729-a65e-4e3f-9fd0-7ef14f170ea9"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d9679ff-70fc-46fc-aed0-070015855ad5'>ToCSharp</a></td><td style='width:75%' ><p><a name="7d9679ff-70fc-46fc-aed0-070015855ad5"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7d6cb83e-b001-4385-ba30-5b4ef6be1950"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a7bc9f8d-625b-4083-8118-7644958356c1'>ToCode</a></td><td style='width:75%' class='def'><p><a name="a7bc9f8d-625b-4083-8118-7644958356c1"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="2e4a34dd-d0b4-465e-a0fe-44225f1d3e55"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="bc381ae8-bec5-4220-aadf-c8cc1b0e0f8b"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="71cb696b-e1c2-4b60-94e4-dc370d0830d6"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2fdfa453-949e-42a2-a139-2e3925b36aea'>CloneAttachedStyle</a></td><td style='width:75%' ><p><a name="2fdfa453-949e-42a2-a139-2e3925b36aea"></a></p>

<h3>CloneAttachedStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the attached style.</p>

<h4>Returns</h4>

<p>A duplicate <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe873b5c-a90c-49d3-87eb-c526b2be2877'>Clone</a></td><td style='width:75%' class='def'><p><a name="fe873b5c-a90c-49d3-87eb-c526b2be2877"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of this shape as a base <code>KimonoBounds</code>.</p>
</td></tr></table></p>


---

<a name="d8706785-5054-4f35-ac08-bd35c4534e9e"></a>
## KimonoShapeArrow

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws either an outlined or single line arrow with heads on one or both ends.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#cee00ca3-190f-4ec6-aca9-d66216994067'>HasStartHead</a></td><td style='width:75%' ><p><a name="cee00ca3-190f-4ec6-aca9-d66216994067"></a></p>

<h3>HasStartHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d8706785-5054-4f35-ac08-bd35c4534e9e">KimonoShapeArrow</a> has start head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has start head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1603eafc-c708-43da-bf4e-1bf0c2cf7dd2'>HasEndHead</a></td><td style='width:75%' class='def'><p><a name="1603eafc-c708-43da-bf4e-1bf0c2cf7dd2"></a></p>

<h3>HasEndHead</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d8706785-5054-4f35-ac08-bd35c4534e9e">KimonoShapeArrow</a> has end head.</p>

<h4>Return Value</h4>

<p><code>true</code> if has end head; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27881ef1-e0a4-4784-aeae-16f01bb84169'>HeadInnerRatio</a></td><td style='width:75%' ><p><a name="27881ef1-e0a4-4784-aeae-16f01bb84169"></a></p>

<h3>HeadInnerRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head inner ratio.</p>

<h4>Return Value</h4>

<p>The head inner ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#01d1b092-7940-4d52-9982-921804fa1836'>HeadOuterRatio</a></td><td style='width:75%' class='def'><p><a name="01d1b092-7940-4d52-9982-921804fa1836"></a></p>

<h3>HeadOuterRatio</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the head outer ratio.</p>

<h4>Return Value</h4>

<p>The head outer ratio.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaf2e2b4-3489-4f43-ae33-68e9e71534a2'>IsStreamlined</a></td><td style='width:75%' ><p><a name="eaf2e2b4-3489-4f43-ae33-68e9e71534a2"></a></p>

<h3>IsStreamlined</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#d8706785-5054-4f35-ac08-bd35c4534e9e">KimonoShapeArrow</a> is streamlined.</p>

<h4>Return Value</h4>

<p><code>true</code> if is streamlined; otherwise, <code>false</code>.</p>

<h4>Remarks</h4>

<p>A Streamlined Arrow, is drawn as a single line.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d0a082a-923b-4677-911b-45022ad95a23'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="4d0a082a-923b-4677-911b-45022ad95a23"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a5141c48-307e-4a3a-bc3d-da98b3e2c547'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="a5141c48-307e-4a3a-bc3d-da98b3e2c547"></a></p>

<h3>KimonoShapeArrow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d8706785-5054-4f35-ac08-bd35c4534e9e">KimonoShapeArrow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93d93770-12e1-4848-8ff6-799097cb5aff'>KimonoShapeArrow</a></td><td style='width:75%' class='def'><p><a name="93d93770-12e1-4848-8ff6-799097cb5aff"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d8706785-5054-4f35-ac08-bd35c4534e9e">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="847ee590-617a-4e39-9953-f08f2d91b30a"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="4b19d951-3863-447f-9667-31a54ae12ba8"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f73591bd-6b73-4204-bf80-8e76d8543b55"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="b60f2e63-d11d-4f78-95ba-ae1439532962"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6641de18-dcdb-4b21-8dcb-aa0ce480eba7'>KimonoShapeArrow</a></td><td style='width:75%' ><p><a name="6641de18-dcdb-4b21-8dcb-aa0ce480eba7"></a></p>

<h3>KimonoShapeArrow (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#d8706785-5054-4f35-ac08-bd35c4534e9e">KimonoShapeArrow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="dbffdeff-5cda-4ff8-b13d-51fbb11ecdae"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="7ca52bd9-b72d-428c-ad17-9d5813ed6f1d"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="45080bc6-c9b3-4f31-beff-dc55b8b862c6"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f00941a0-dd52-4a2a-991b-9636fe327c53"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="a1a1f6a0-d7cd-442e-b9e9-ec51162048f9"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#481e2fbf-c333-4fe3-93ae-7a4984db314a'>Initialize</a></td><td style='width:75%' class='def'><p><a name="481e2fbf-c333-4fe3-93ae-7a4984db314a"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61ff211f-22b8-48d4-b18b-b342db9ce555'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="61ff211f-22b8-48d4-b18b-b342db9ce555"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="6db200a8-6a2e-467d-b566-fe49e57f694f"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0fe5941-f69d-48a3-a268-56f341574e40'>ToPath</a></td><td style='width:75%' class='def'><p><a name="c0fe5941-f69d-48a3-a268-56f341574e40"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the arrow to a path.</p>

<h4>Returns</h4>

<p>The the arrow as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a235b13e-e4f3-47fe-be39-1f72c41c17aa'>Draw</a></td><td style='width:75%' ><p><a name="a235b13e-e4f3-47fe-be39-1f72c41c17aa"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the arrow into the specified Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="b596645d-ed42-4e9e-8acd-057f0d28109e"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8168b4b9-420a-4cac-8afc-ca040813587e'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="8168b4b9-420a-4cac-8afc-ca040813587e"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the arrow.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="bcb0cddf-1e4a-4973-87a7-c41aaa634ed0"></a>
The <code>SKPoint</code> containing the bounds adjustment.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f73be6f-d9c3-4668-8dee-5c1bdc6b17d0'>DragBounds</a></td><td style='width:75%' ><p><a name="7f73be6f-d9c3-4668-8dee-5c1bdc6b17d0"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the arrow to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="296ac34b-297c-42bd-843c-ab8fd793f289"></a>
The <code>SKPoint</code> specifying the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#072567e0-a0da-4bae-870a-5dfec11cae2e'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="072567e0-a0da-4bae-870a-5dfec11cae2e"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b47f5c4-c43f-465f-a8fb-3839c5fd2633'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="7b47f5c4-c43f-465f-a8fb-3839c5fd2633"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#78e2d1ea-328b-49b6-8d8b-a914f1b0da34'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="78e2d1ea-328b-49b6-8d8b-a914f1b0da34"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9ffc58db-8608-4918-a5ea-fb2cb2ed672d'>ToCSharp</a></td><td style='width:75%' ><p><a name="9ffc58db-8608-4918-a5ea-fb2cb2ed672d"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2ffba50f-b981-4519-9720-50b22acec0e7"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#84b975df-6e93-480f-b072-6d7151b2893a'>ToCode</a></td><td style='width:75%' class='def'><p><a name="84b975df-6e93-480f-b072-6d7151b2893a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="34ef4749-eb7b-4996-b4e1-cf277e43db95"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="bf1368ba-aba1-4ce9-8a2b-e52a99cadae0"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="bd99cc03-7106-4dac-8120-c310b2d5fa1d"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8758d607-c83b-4b47-9f70-a6980a62e22c'>Clone</a></td><td style='width:75%' ><p><a name="8758d607-c83b-4b47-9f70-a6980a62e22c"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoArrow</code>.</p>
</td></tr></table></p>


---

<a name="af4d21a2-42ef-4bb8-b8dc-077cc5e73d2d"></a>
## KimonoShapeBezier

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

A Kimono Bezier is a collection of control and end points that define the quad sections of a bezier shape to be drawn using SkiaSharp.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#87db7214-9a2a-47e9-bbf2-513118f972ec'>Points</a></td><td style='width:75%' ><p><a name="87db7214-9a2a-47e9-bbf2-513118f972ec"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0d8f870-36b8-4e26-b7ac-ca5a31bebe2a'>Closed</a></td><td style='width:75%' class='def'><p><a name="e0d8f870-36b8-4e26-b7ac-ca5a31bebe2a"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c08d0a2-908f-4399-8fb5-da1c7451c6f6'>IsEditable</a></td><td style='width:75%' ><p><a name="9c08d0a2-908f-4399-8fb5-da1c7451c6f6"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dfe1c6a-050d-48a7-b184-58dd199c8988'>LastPoint</a></td><td style='width:75%' class='def'><p><a name="2dfe1c6a-050d-48a7-b184-58dd199c8988"></a></p>

<h3>LastPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the last point in the collection of control points.</p>

<h4>Return Value</h4>

<p>The last point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#77d78957-198b-4f8b-8a04-db2159fc9a8b'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="77d78957-198b-4f8b-8a04-db2159fc9a8b"></a></p>

<h3>KimonoShapeBezier ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af4d21a2-42ef-4bb8-b8dc-077cc5e73d2d">KimonoShapeBezier</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc303f65-e315-4035-9023-080c32a1a844'>KimonoShapeBezier</a></td><td style='width:75%' class='def'><p><a name="cc303f65-e315-4035-9023-080c32a1a844"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af4d21a2-42ef-4bb8-b8dc-077cc5e73d2d">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="40d1c1f5-e893-4ad8-a575-7d04793ffbb6"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="fb4ccd71-f51c-4836-b116-e78a7a74d5c4"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="cc636097-300d-449f-99a2-94b0d5050d3f"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="df5dfe29-0011-4d2b-8a16-0c87e0f5725c"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5732ee0b-1644-4e0e-aec7-2129d5c874ec'>KimonoShapeBezier</a></td><td style='width:75%' ><p><a name="5732ee0b-1644-4e0e-aec7-2129d5c874ec"></a></p>

<h3>KimonoShapeBezier (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af4d21a2-42ef-4bb8-b8dc-077cc5e73d2d">KimonoShapeBezier</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="70e101e9-f6d8-43cb-a361-db1f891bdd7b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="258bc68b-65db-40f7-b008-74b575cbfca0"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="fe45b36c-b817-4f9a-8bb4-d88f24c9c847"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="3a8fb0b9-542d-43aa-887a-3fe5bb3e822d"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="f74f74e7-09aa-4e97-a51a-3a3b31247efa"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b986eca7-5c53-467b-a97b-8572946c5153'>Initialize</a></td><td style='width:75%' class='def'><p><a name="b986eca7-5c53-467b-a97b-8572946c5153"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e55918d7-d32c-4208-ae05-e733f3dd88c5'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="e55918d7-d32c-4208-ae05-e733f3dd88c5"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa035c62-35fa-41ae-a58c-df00e2c76218'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="aa035c62-35fa-41ae-a58c-df00e2c76218"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="1a8fa3c5-958a-4d57-8d21-7c982cf28701"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="3de3c788-56a3-4a52-b454-3feed8d72e72"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d53b95a-f741-4d56-a6d8-da2750e8bf8c'>AddPoint</a></td><td style='width:75%' ><p><a name="3d53b95a-f741-4d56-a6d8-da2750e8bf8c"></a></p>

<h3>AddPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="7c0d5199-5d8f-4577-86b0-b0f645153186"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="1e29644f-8aa9-4c6c-b1b1-f42b0290b3df"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="7b13f1cb-a692-4ccc-8cdc-fa35034a0859"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="6af24889-93f1-49a1-ad27-e45cfde55e14"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c7971e1-68ff-4891-9ca2-f413bf542761'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="3c7971e1-68ff-4891-9ca2-f413bf542761"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="8601e0b0-64b0-4941-b22c-1c3febf3e6a9"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5730dc1c-1e22-473e-a68b-0a267aca1f80'>AddHandlesForPoint</a></td><td style='width:75%' ><p><a name="5730dc1c-1e22-473e-a68b-0a267aca1f80"></a></p>

<h3>AddHandlesForPoint (System.Int32, KimonoCore.KimonoBezierPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the handles for the given bezier point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>index</td><td style='width:75%' ><p><a name="83c11e58-4d5c-43c1-a967-250866f23a87"></a>
The index of the <code>KimonoBezierPoint</code> that handles are being created for.</p>
</td></tr><tr><td style='width:25%' class='term'>bezierPoint</td><td style='width:75%' class='def'><p><a name="834ba942-6e7d-4691-aa98-c753ad821793"></a>
The <code>KimonoBezierPoint</code> that is getting handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df7847f4-107e-4c62-8942-72bf1cffa1ee'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="df7847f4-107e-4c62-8942-72bf1cffa1ee"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="9d27ffdb-7cad-4ca6-a021-a8eec400b607"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8a37a4e-5d7c-48a9-9834-7a1d8089b741'>RemovePoint</a></td><td style='width:75%' ><p><a name="f8a37a4e-5d7c-48a9-9834-7a1d8089b741"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="fa006f3a-3a25-4366-bcbb-88e5dda3a091"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb3c6c4d-6b97-440a-92a7-7da1da5ad4fb'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="cb3c6c4d-6b97-440a-92a7-7da1da5ad4fb"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#02af572e-c197-43cf-aa44-fb7e35268d1f'>ToPath</a></td><td style='width:75%' ><p><a name="02af572e-c197-43cf-aa44-fb7e35268d1f"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dae1feda-6735-4c73-892a-07378da0c7b2'>Draw</a></td><td style='width:75%' class='def'><p><a name="dae1feda-6735-4c73-892a-07378da0c7b2"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="11981b02-aa78-4ed5-998e-5259cdb9dab5"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a258fca-3c33-429d-a9ec-9a14dd928ce4'>PointInBound</a></td><td style='width:75%' ><p><a name="5a258fca-3c33-429d-a9ec-9a14dd928ce4"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="c91a7b64-9193-4334-b76f-bd165c717ac5"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#900cf43b-a8fd-4468-bf4c-26bec149599e'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="900cf43b-a8fd-4468-bf4c-26bec149599e"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="cb4412da-be04-46a5-931f-592e10a62523"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a52cbe0-5a48-422f-9e43-64f4b6485e71'>BoundsChanged</a></td><td style='width:75%' ><p><a name="5a52cbe0-5a48-422f-9e43-64f4b6485e71"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0eb535f8-62d1-44ce-928f-a42d9544306a'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="0eb535f8-62d1-44ce-928f-a42d9544306a"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9aef6ec-59c9-4f92-9f3c-56e00812c9e6'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="c9aef6ec-59c9-4f92-9f3c-56e00812c9e6"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d8f2dcd-fb70-425a-994b-88bbcf5cfe48'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="4d8f2dcd-fb70-425a-994b-88bbcf5cfe48"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b761c03-722a-4cbf-98e4-26351e790434'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="1b761c03-722a-4cbf-98e4-26351e790434"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ec1510ad-3f88-4c61-a2c6-34f0425e35ad'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="ec1510ad-3f88-4c61-a2c6-34f0425e35ad"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="4348f8ca-668d-4ad2-a8e8-3f2776edaaf5"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09a61968-42fd-46a1-a3b9-2d857a1d4bcf'>ToCode</a></td><td style='width:75%' ><p><a name="09a61968-42fd-46a1-a3b9-2d857a1d4bcf"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="71a77681-6a32-44d4-badf-264c5fb64912"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="83c9f568-18ea-4a09-9c96-e56643204486"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d5e754be-bd4e-4299-b4c2-1678ab3627ba"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae6da92e-0a07-4842-b298-a5713d652dc4'>Clone</a></td><td style='width:75%' class='def'><p><a name="ae6da92e-0a07-4842-b298-a5713d652dc4"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="fb524652-b106-411a-acfd-a8684826292b"></a>
## KimonoShapeGroup

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

A `KimonoShapeGroup` holds a collection of `KimonoShapes` that can be acted upon as a group.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7f275c6d-d992-4907-8d2d-7f3950b88f7e'>ShapeUnderConstruction</a></td><td style='width:75%' ><p><a name="7f275c6d-d992-4907-8d2d-7f3950b88f7e"></a>
<b>ShapeUnderConstruction</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape under construction.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8403f2c8-7d3f-4ba5-829d-e6a7de64fb33'>_selectedShape</a></td><td style='width:75%' class='def'><p><a name="8403f2c8-7d3f-4ba5-829d-e6a7de64fb33"></a>
<b>_selectedShape</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The currently selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#20d9ee9b-d8f9-4953-ae1a-19d8f451032d'>Dragging</a></td><td style='width:75%' ><p><a name="20d9ee9b-d8f9-4953-ae1a-19d8f451032d"></a>
<b>Dragging</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Marks if the group itself is being moved be the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f289fc04-5e6f-4c5a-aef0-955505049361'>IgnoreDrag</a></td><td style='width:75%' class='def'><p><a name="f289fc04-5e6f-4c5a-aef0-955505049361"></a>
<b>IgnoreDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the next drag event will be ignored.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eaea36a0-1479-4ba3-916f-768401baa3e1'>PerformingDrag</a></td><td style='width:75%' ><p><a name="eaea36a0-1479-4ba3-916f-768401baa3e1"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the user is performing a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3950cf31-804e-4f11-af96-fcaccc9f01e6'>ToolDownAt</a></td><td style='width:75%' class='def'><p><a name="3950cf31-804e-4f11-af96-fcaccc9f01e6"></a>
<b>ToolDownAt</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The last point that a <code>KimonoTool</code> went down on the sketch's Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#324773a1-ca45-4a9e-b179-bbe7e36f0da9'>_isMaskedGroup</a></td><td style='width:75%' ><p><a name="324773a1-ca45-4a9e-b179-bbe7e36f0da9"></a>
<b>_isMaskedGroup</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the top most shape in the group will act as a mask for the shapes below it.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#57685db5-6f39-4d0e-b7b2-5f3b179e8518'>Parent</a></td><td style='width:75%' ><p><a name="57685db5-6f39-4d0e-b7b2-5f3b179e8518"></a></p>

<h3>Parent</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code> that this <code>KimonoShapeGroup</code> belongs to.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d24f7f8-9765-4b63-8298-63262e77f24e'>ParentSketch</a></td><td style='width:75%' class='def'><p><a name="0d24f7f8-9765-4b63-8298-63262e77f24e"></a></p>

<h3>ParentSketch</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the parent sketch by scanning backwards through the chain of parent objects until a <code>KimonoSketch</code> is reached.</p>

<h4>Return Value</h4>

<p>The parent <code>KimonoSketch</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc0d6d37-d47b-46b4-8cdd-a1bfbd93b723'>Path</a></td><td style='width:75%' ><p><a name="fc0d6d37-d47b-46b4-8cdd-a1bfbd93b723"></a></p>

<h3>Path</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the full path from this group back to the parent <code>KimonoSketch</code>.</p>

<h4>Return Value</h4>

<p>The path representing the nesting level of this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b9232f9-0783-4524-857a-4185550db399'>Shapes</a></td><td style='width:75%' class='def'><p><a name="6b9232f9-0783-4524-857a-4185550db399"></a></p>

<h3>Shapes</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the shapes.</p>

<h4>Return Value</h4>

<p>The shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9f6babb-d31d-482f-914a-9413d3a3a64c'>SelectedShape</a></td><td style='width:75%' ><p><a name="b9f6babb-d31d-482f-914a-9413d3a3a64c"></a></p>

<h3>SelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected shape.</p>

<h4>Return Value</h4>

<p>The selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ba32ddc-e034-4be0-8aa0-9a28d4b95ce2'>DeeplySelectedShape</a></td><td style='width:75%' class='def'><p><a name="2ba32ddc-e034-4be0-8aa0-9a28d4b95ce2"></a></p>

<h3>DeeplySelectedShape</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected shape in a chain of groups.</p>

<h4>Return Value</h4>

<p>The deeply selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1dd5de5e-2bdf-470f-bacf-b3b8ac58adfd'>DeeplySelectedGroup</a></td><td style='width:75%' ><p><a name="1dd5de5e-2bdf-470f-bacf-b3b8ac58adfd"></a></p>

<h3>DeeplySelectedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the deepest selected group in a chain of groups that is in the edit mode.</p>

<h4>Return Value</h4>

<p>The deeply selected group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5c2883e-1479-488e-bb78-5a68372e2dd7'>GroupType</a></td><td style='width:75%' class='def'><p><a name="f5c2883e-1479-488e-bb78-5a68372e2dd7"></a></p>

<h3>GroupType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the group.</p>

<h4>Return Value</h4>

<p>The type of the group as a <code>KimonoShapeGroupType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fae5d50-8fbc-4bb9-bb23-268475dff529'>Style</a></td><td style='width:75%' ><p><a name="8fae5d50-8fbc-4bb9-bb23-268475dff529"></a></p>

<h3>Style</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the style of this group.</p>

<h4>Return Value</h4>

<p>The style as a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e98d287d-c357-443f-b82a-0982fe6438f8'>Visible</a></td><td style='width:75%' class='def'><p><a name="e98d287d-c357-443f-b82a-0982fe6438f8"></a></p>

<h3>Visible</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> is visible.</p>

<h4>Return Value</h4>

<p><code>true</code> if visible; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1bb8098-e2e5-49dc-b933-b7c01eb6e59f'>IsEditable</a></td><td style='width:75%' ><p><a name="b1bb8098-e2e5-49dc-b933-b7c01eb6e59f"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6a5606c-7f8c-4c42-95f0-cbbbb5402463'>SelectedShapeAtBottom</a></td><td style='width:75%' class='def'><p><a name="f6a5606c-7f8c-4c42-95f0-cbbbb5402463"></a></p>

<h3>SelectedShapeAtBottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the bottom.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at bottom; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4970b2e3-72f2-47d5-9fbc-252ec9495ee7'>SelectedShapeAtTop</a></td><td style='width:75%' ><p><a name="4970b2e3-72f2-47d5-9fbc-252ec9495ee7"></a></p>

<h3>SelectedShapeAtTop</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether the selected shape is at the top.</p>

<h4>Return Value</h4>

<p><code>true</code> if selected shape at top; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a4bc209-b4d4-4b3a-841b-c26b8738f63c'>IsBooleanConstruct</a></td><td style='width:75%' class='def'><p><a name="6a4bc209-b4d4-4b3a-841b-c26b8738f63c"></a></p>

<h3>IsBooleanConstruct</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> is a boolean construct.</p>

<h4>Return Value</h4>

<p><code>true</code> if is boolean construct; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dc3a9c1-2858-40e8-a01a-4b695437b0a7'>BooleanOperation</a></td><td style='width:75%' ><p><a name="3dc3a9c1-2858-40e8-a01a-4b695437b0a7"></a></p>

<h3>BooleanOperation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the boolean operation that will be applied to this group of objects.</p>

<h4>Return Value</h4>

<p>The boolean operation as a <code>SKPathOp</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#877b5ac1-784a-4e79-aeeb-768a41003e9a'>Mask</a></td><td style='width:75%' class='def'><p><a name="877b5ac1-784a-4e79-aeeb-768a41003e9a"></a></p>

<h3>Mask</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the <code>KimonoShape</code> that is acting as a mask for this group.</p>

<h4>Return Value</h4>

<p>The mask as a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82232755-84c2-4b5d-97bd-2240692d50d7'>IsMaskedGroup</a></td><td style='width:75%' ><p><a name="82232755-84c2-4b5d-97bd-2240692d50d7"></a></p>

<h3>IsMaskedGroup</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> is masked group.</p>

<h4>Return Value</h4>

<p><code>true</code> if is masked group; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c8d1ca35-b5b1-47b1-91fb-2e4d8f12869b'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="c8d1ca35-b5b1-47b1-91fb-2e4d8f12869b"></a></p>

<h3>KimonoShapeGroup (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="c2654ba2-d53e-49d5-b69a-45cfd442af73"></a>
The parent <code>KimonoSketch</code> or <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d2bfc07-a83a-4e90-a268-e43ec20aaa3d'>KimonoShapeGroup</a></td><td style='width:75%' class='def'><p><a name="5d2bfc07-a83a-4e90-a268-e43ec20aaa3d"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="7196d18d-fd90-4527-b43b-9fe6661079a2"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="4ae0406b-a7e2-45b5-8791-541635df809d"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="0f78f70d-8cb1-436a-b103-ea8101256b33"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="176d790e-c900-4b84-8e02-3b94a7e51338"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="c89af648-2d5a-40ea-b80e-9e9d68e3762d"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07621255-67ae-4e4a-a226-5121f9540e99'>KimonoShapeGroup</a></td><td style='width:75%' ><p><a name="07621255-67ae-4e4a-a226-5121f9540e99"></a></p>

<h3>KimonoShapeGroup (System.Object, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#fb524652-b106-411a-acfd-a8684826292b">KimonoShapeGroup</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="4d161b86-cf24-4453-ba97-edc0ddb3ea54"></a>
Parent.</p>
</td></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' class='def'><p><a name="397072d4-fe32-444b-bafe-faf7a19652ad"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' ><p><a name="696030f4-fe55-464d-9a9b-a2be1c92b345"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' class='def'><p><a name="7506914a-3018-45f1-80c3-0c3ef99a5c32"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' ><p><a name="143c6487-9f59-4513-b5b5-7cfadac6896a"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="5392555c-3b97-4626-8a03-550ff144be26"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3566a6e-8c74-4a0a-b365-db9b284f9aa8'>Initialize</a></td><td style='width:75%' class='def'><p><a name="e3566a6e-8c74-4a0a-b365-db9b284f9aa8"></a></p>

<h3>Initialize (System.Object)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize the specified parent.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>parent</td><td style='width:75%' ><p><a name="f3a0445a-75f3-4a05-b26d-76fbbb656d59"></a>
Parent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The initialize.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d72310b1-3a20-4cee-938c-b051cdd3f868'>FindShape</a></td><td style='width:75%' ><p><a name="d72310b1-3a20-4cee-938c-b051cdd3f868"></a></p>

<h3>FindShape (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds a given shape by its Unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="48e30ebf-2daa-48c0-8403-346d6c4f936e"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>KimonoShape</code> if found, else <code>null</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a7c95de-9c56-4fae-b072-07a6e30d72db'>RecalculateGroupBounds</a></td><td style='width:75%' class='def'><p><a name="2a7c95de-9c56-4fae-b072-07a6e30d72db"></a></p>

<h3>RecalculateGroupBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the group bounds to encompass every <code>KimonoShape</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ffd72a2a-155c-4db8-851c-7b92df99c102'>ReturnToSketch</a></td><td style='width:75%' ><p><a name="ffd72a2a-155c-4db8-851c-7b92df99c102"></a></p>

<h3>ReturnToSketch ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns to base parent <code>KimonoSketch</code> for this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87d270d1-c004-4a45-a387-8cbb4fa6ac4d'>SelectShape</a></td><td style='width:75%' class='def'><p><a name="87d270d1-c004-4a45-a387-8cbb4fa6ac4d"></a></p>

<h3>SelectShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Selects the given <code>KimonoShape</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="65d6e9a8-b81e-4814-a9aa-cd254fded5a3"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5360e9db-a88f-4022-a935-5669d3a799be'>RecalculateLayerDepths</a></td><td style='width:75%' ><p><a name="5360e9db-a88f-4022-a935-5669d3a799be"></a></p>

<h3>RecalculateLayerDepths ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the layer depths.</p>

<h4>Remarks</h4>

<p>Layer depths are used to maintain the front to back order of the <code>KimonoShapes</code> that for the sketch.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73676e99-22eb-4fd8-bf15-08d8529fe491'>MoveSelectedShapeToBottom</a></td><td style='width:75%' class='def'><p><a name="73676e99-22eb-4fd8-bf15-08d8529fe491"></a></p>

<h3>MoveSelectedShapeToBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38b62175-5fa9-4aad-8b9d-606bcdbda077'>MoveSelectedShapeBackwards</a></td><td style='width:75%' ><p><a name="38b62175-5fa9-4aad-8b9d-606bcdbda077"></a></p>

<h3>MoveSelectedShapeBackwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape backwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0ad0678-78a1-4707-b79e-00d74d015d3f'>MoveSelectedShapeToTop</a></td><td style='width:75%' class='def'><p><a name="c0ad0678-78a1-4707-b79e-00d74d015d3f"></a></p>

<h3>MoveSelectedShapeToTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape to top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67f41f23-9927-4e79-95b6-8fa651098b23'>MoveSelectedShapeForwards</a></td><td style='width:75%' ><p><a name="67f41f23-9927-4e79-95b6-8fa651098b23"></a></p>

<h3>MoveSelectedShapeForwards ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the selected shape forwards.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#80d7037c-a6ae-4599-a303-9572d6f8f2ad'>AlignAllTop</a></td><td style='width:75%' class='def'><p><a name="80d7037c-a6ae-4599-a303-9572d6f8f2ad"></a></p>

<h3>AlignAllTop ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the top.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#60291357-4a7d-41fb-b6d9-5f416ddb5f3a'>AlignAllBottom</a></td><td style='width:75%' ><p><a name="60291357-4a7d-41fb-b6d9-5f416ddb5f3a"></a></p>

<h3>AlignAllBottom ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group at the bottom.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b2093c3-f2c1-4097-a790-05ba074f00c0'>AlignAllLeft</a></td><td style='width:75%' class='def'><p><a name="2b2093c3-f2c1-4097-a790-05ba074f00c0"></a></p>

<h3>AlignAllLeft ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the left.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fc6e7fd-2ac4-4177-9e8e-dc561fe4ef07'>AlignAllRight</a></td><td style='width:75%' ><p><a name="3fc6e7fd-2ac4-4177-9e8e-dc561fe4ef07"></a></p>

<h3>AlignAllRight ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Aligns all shapes in the group to the right.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59ffed26-339b-439b-88ff-f5d19ae59845'>AlignAllCenter</a></td><td style='width:75%' class='def'><p><a name="59ffed26-339b-439b-88ff-f5d19ae59845"></a></p>

<h3>AlignAllCenter ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Centers all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45b960ae-9ed2-47bd-9e10-9524f037d6e3'>AlignAllCenterHorizontal</a></td><td style='width:75%' ><p><a name="45b960ae-9ed2-47bd-9e10-9524f037d6e3"></a></p>

<h3>AlignAllCenterHorizontal ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center horizontal all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d0f8833-8cc3-41b9-a492-88f43201c471'>AlignAllCenterVertical</a></td><td style='width:75%' class='def'><p><a name="2d0f8833-8cc3-41b9-a492-88f43201c471"></a></p>

<h3>AlignAllCenterVertical ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Center vertical all shapes in the group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97d4a8d0-4e25-4378-96c1-dd3c517ecec4'>DeleteColor</a></td><td style='width:75%' ><p><a name="97d4a8d0-4e25-4378-96c1-dd3c517ecec4"></a></p>

<h3>DeleteColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given <code>KimonoColor</code> from this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="836ee407-ee60-4023-9e67-8ba2e70f34ea"></a>
The <code>KimonoColor</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71c36649-7347-4aa2-bb85-f5c3ed476c69'>DeleteGradient</a></td><td style='width:75%' class='def'><p><a name="71c36649-7347-4aa2-bb85-f5c3ed476c69"></a></p>

<h3>DeleteGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the given gradient from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="2a45680c-d716-49c5-be7c-f9bc251df8ec"></a>
The <code>KimonoGradient</code> to delete.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3cc92ee2-4ef2-4817-8cde-83eec9089e56'>AddShape</a></td><td style='width:75%' ><p><a name="3cc92ee2-4ef2-4817-8cde-83eec9089e56"></a></p>

<h3>AddShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given <code>KimonoShape</code> to the group if it isn't already a part of the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="948c39ee-40ef-48d3-9f90-8df9eedbf81e"></a>
The <code>KimonoShape</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e12f8c9-e662-40fb-a0e8-0cae352e55d2'>DuplicateSelectedShape</a></td><td style='width:75%' class='def'><p><a name="9e12f8c9-e662-40fb-a0e8-0cae352e55d2"></a></p>

<h3>DuplicateSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#56a154cf-d665-4e7a-8bac-dbc654956f0e'>RemoveShape</a></td><td style='width:75%' ><p><a name="56a154cf-d665-4e7a-8bac-dbc654956f0e"></a></p>

<h3>RemoveShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given <code>KimonoShape</code> from the group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="13575bbf-b827-4655-96a5-1c0b36b2ec0c"></a>
Shape.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ac4c9a6-607c-4f10-90c7-cfc5bfeab932'>DeleteSelectedShape</a></td><td style='width:75%' class='def'><p><a name="7ac4c9a6-607c-4f10-90c7-cfc5bfeab932"></a></p>

<h3>DeleteSelectedShape ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31e6b80c-0624-44f4-820c-630159308de6'>ShapeInGroup</a></td><td style='width:75%' ><p><a name="31e6b80c-0624-44f4-820c-630159308de6"></a></p>

<h3>ShapeInGroup (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given <code>KimonoShape</code> is a part of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="199cf8d8-9740-47e1-bcf4-1a98688fffee"></a>
The <code>KimonoShape</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in shape is in the group, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdc7e688-887c-47d1-8c66-fa5013272a6f'>DeselectAll</a></td><td style='width:75%' class='def'><p><a name="cdc7e688-887c-47d1-8c66-fa5013272a6f"></a></p>

<h3>DeselectAll ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deselects all shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#be975ab4-5c9a-4605-8a42-04b1097e2f6a'>GroupShapes</a></td><td style='width:75%' ><p><a name="be975ab4-5c9a-4605-8a42-04b1097e2f6a"></a></p>

<h3>GroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3779876-9395-4043-8165-a92db2bc8f79'>GroupShapes</a></td><td style='width:75%' class='def'><p><a name="a3779876-9395-4043-8165-a92db2bc8f79"></a></p>

<h3>GroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="b2d0f298-e479-40f6-a1df-4fccce9c6e6e"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e0ce95f-8a30-47af-9c9a-dff18714f330'>GroupShapes</a></td><td style='width:75%' ><p><a name="5e0ce95f-8a30-47af-9c9a-dff18714f330"></a></p>

<h3>GroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Groups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="6bb47bd4-0c65-456d-be21-39e617924c31"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97be0bdb-f921-4978-b281-dba4adef557e'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="97be0bdb-f921-4978-b281-dba4adef557e"></a></p>

<h3>UngroupShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f154b127-850d-481d-b01d-d8b915e54265'>UngroupShapes</a></td><td style='width:75%' ><p><a name="f154b127-850d-481d-b01d-d8b915e54265"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="8141eef0-4d26-4b52-89ae-4c60960dc0ea"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#949fb1eb-e837-4200-bbc6-296a9d52ef59'>UngroupShapes</a></td><td style='width:75%' class='def'><p><a name="949fb1eb-e837-4200-bbc6-296a9d52ef59"></a></p>

<h3>UngroupShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ungroups the shapes in the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="7a7063e1-0235-4392-8c1c-6cc0d6640200"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27d388c4-dafe-4212-af0a-62110938b23b'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="27d388c4-dafe-4212-af0a-62110938b23b"></a></p>

<h3>DuplicateShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in a selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1fcb2188-d1bb-447c-9a52-abec022a19e9'>DuplicateShapes</a></td><td style='width:75%' class='def'><p><a name="1fcb2188-d1bb-447c-9a52-abec022a19e9"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="fa1facdc-4f9c-474e-9165-ea307740b991"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1e0d066-cb8e-49e6-b5bc-07b6ab9c1044'>DuplicateShapes</a></td><td style='width:75%' ><p><a name="f1e0d066-cb8e-49e6-b5bc-07b6ab9c1044"></a></p>

<h3>DuplicateShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the shapes in this selection group into the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="27b0904f-9da5-4cab-8f83-60df3fd9c85b"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bd5347e9-4cf9-427b-b45f-39c489f85a51'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="bd5347e9-4cf9-427b-b45f-39c489f85a51"></a></p>

<h3>DeleteShapes ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#88e2b4f3-414a-4aef-804f-66c37c338105'>DeleteShapes</a></td><td style='width:75%' ><p><a name="88e2b4f3-414a-4aef-804f-66c37c338105"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoSketch)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent sketch.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sketch</td><td style='width:75%' ><p><a name="92d4d1c4-3d80-404d-b1f8-bc8875b4d1a6"></a>
The parent <code>KimonoSketch</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e10cb367-667c-43e6-ba1f-44ca55a2170e'>DeleteShapes</a></td><td style='width:75%' class='def'><p><a name="e10cb367-667c-43e6-ba1f-44ca55a2170e"></a></p>

<h3>DeleteShapes (KimonoCore.KimonoShapeGroup)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the shapes in this selection group from the parent group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>group</td><td style='width:75%' ><p><a name="9da2469b-ae07-4f4d-87cc-485c962ae80e"></a>
The parent <code>KimonoShapeGroup</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ecb2fce6-40b2-4436-9479-dade48d2ae90'>ApplyMoveAndScale</a></td><td style='width:75%' ><p><a name="ecb2fce6-40b2-4436-9479-dade48d2ae90"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale adjustments to all <code>KimonoShapes</code> inside this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abcfbdbf-5b1c-4a8b-a604-ab71c4b77d36'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="abcfbdbf-5b1c-4a8b-a604-ab71c4b77d36"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="1ac2c032-ba1f-4b22-a735-b6b72d6d2c04"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#22bb8761-dcef-4948-bdbb-b78f59c3c0f0'>RemoveProperty</a></td><td style='width:75%' ><p><a name="22bb8761-dcef-4948-bdbb-b78f59c3c0f0"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="cb6bcae8-a125-4493-a063-2358add86a94"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db62ad20-21b0-4646-bec5-ebb406e1a35c'>ToPath</a></td><td style='width:75%' class='def'><p><a name="db62ad20-21b0-4646-bec5-ebb406e1a35c"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the group of shapes to a path.</p>

<h4>Returns</h4>

<p>The group of shapes as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8436cd82-e173-4252-bcd2-badfba8d8b1e'>Draw</a></td><td style='width:75%' ><p><a name="8436cd82-e173-4252-bcd2-badfba8d8b1e"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw all the <code>KimonoShapes</code> that are part of this group into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="700f5491-8757-4f22-9159-350437a96dca"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ac411f36-6829-4484-aeac-a843388c546b'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="ac411f36-6829-4484-aeac-a843388c546b"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#39310865-90ec-4585-82a2-d27845ab147f'>EndEditing</a></td><td style='width:75%' ><p><a name="39310865-90ec-4585-82a2-d27845ab147f"></a></p>

<h3>EndEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Ends editing this group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2234c211-3639-4101-9441-012c9b72405a'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="2234c211-3639-4101-9441-012c9b72405a"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="4734dcbc-4204-4159-b706-f2b8e6813208"></a>
The <code>SKPoint</code> to test for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if the point was in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90531adc-4d76-441d-b5ca-959ab2ce0fc5'>DragBounds</a></td><td style='width:75%' ><p><a name="90531adc-4d76-441d-b5ca-959ab2ce0fc5"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of this group.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="0e935202-4eb5-446e-b658-8ce1ce0904b3"></a>
The new location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9befc7ed-5989-47e8-bea7-51a8af89d403'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="9befc7ed-5989-47e8-bea7-51a8af89d403"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Update the bouds of this group when they have changed from either a move or a drag operation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#705e899f-a879-4e53-83ea-36ac7d5afe93'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="705e899f-a879-4e53-83ea-36ac7d5afe93"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79a13582-c625-451b-86c1-f071ab202b64'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="79a13582-c625-451b-86c1-f071ab202b64"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dcc7d197-1659-4e95-88bd-2c8c4a0657dd'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="dcc7d197-1659-4e95-88bd-2c8c4a0657dd"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0c51345-bf1f-427b-8af4-57e547b72c61'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="f0c51345-bf1f-427b-8af4-57e547b72c61"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="84ee18da-0d66-43b4-b9d3-474720d30932"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#022f0f2a-d4af-40aa-ba23-f91f0137caa3'>ToCode</a></td><td style='width:75%' ><p><a name="022f0f2a-d4af-40aa-ba23-f91f0137caa3"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="d4d5b1fe-fde9-4a56-8d45-bcaa032cf707"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="3ad8a79c-213b-4da2-82ef-1dbb35721593"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="18e5f40f-21fb-4e56-bbad-eb580402ac39"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aea48962-0627-4414-b757-76fd4f3ef7b6'>RelinkShape</a></td><td style='width:75%' class='def'><p><a name="aea48962-0627-4414-b757-76fd4f3ef7b6"></a></p>

<h3>RelinkShape (KimonoCore.KimonoShape)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Relinks the shape after a clone operation.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>shape</td><td style='width:75%' ><p><a name="27b7f122-e677-4b14-bd0e-92845b72b90f"></a>
The <code>KimonoShape</code> to relink.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf66ca57-3376-4e76-8794-4cb8f3ee698a'>Clone</a></td><td style='width:75%' ><p><a name="bf66ca57-3376-4e76-8794-4cb8f3ee698a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>A deep clone of this <code>KimonoShapeGroup</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#510dab01-1d88-4f2e-890e-205dcbecbbcf'>ToolDown</a></td><td style='width:75%' class='def'><p><a name="510dab01-1d88-4f2e-890e-205dcbecbbcf"></a></p>

<h3>ToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user placing the current <code>KimonoTool</code> down on the group's Design Surface.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="65f70aa3-77f0-453c-9c35-5bd837775be3"></a>
The <code>SKPoint</code> where the tool went down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="4a1d13ae-7fe2-4701-bbd3-b81bdb3828d1"></a>
The number of time the user clicked/tapped the tool down on the Design Surface.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="7b317eeb-e640-4361-b759-f9f0796d3fe5"></a>
If <code>true</code>, the user has started a multi-shape select process.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="93331952-3bca-4db8-a83d-1c2825a8db33"></a>
## KimonoShapeGroupType

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the type of a `KimonoShapeGroup`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#a6c6a18e-7245-4027-bcd9-6c21419b4a17'>Selection</a></td><td style='width:75%' ><p><a name="a6c6a18e-7245-4027-bcd9-6c21419b4a17"></a>
<b>Selection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a current active selection.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea4264db-d0cb-4052-9b48-6acb97457646'>DragSelect</a></td><td style='width:75%' class='def'><p><a name="ea4264db-d0cb-4052-9b48-6acb97457646"></a>
<b>DragSelect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a drag to select selection that is underway.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9b1ee23-d931-4607-96e0-56c76926877d'>Collection</a></td><td style='width:75%' ><p><a name="b9b1ee23-d931-4607-96e0-56c76926877d"></a>
<b>Collection</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The group is a collection of shape that have been grouped together and are treated as a single object in the editor.</p>
</td></tr></table></p>


---

<a name="353d0236-1f21-49cc-8d43-eb056a6413b4"></a>
## KimonoShapeLine

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a line on the design surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#34252c9d-5d89-4f3d-a3a4-2246d97a60cb'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="34252c9d-5d89-4f3d-a3a4-2246d97a60cb"></a></p>

<h3>KimonoShapeLine ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#353d0236-1f21-49cc-8d43-eb056a6413b4">KimonoShapeLine</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a890e45-51a4-4b9c-986f-e1cd3e09c5f4'>KimonoShapeLine</a></td><td style='width:75%' class='def'><p><a name="5a890e45-51a4-4b9c-986f-e1cd3e09c5f4"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#353d0236-1f21-49cc-8d43-eb056a6413b4">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="c12705f8-6e01-4e0f-85d8-48af856a129c"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="03280eef-6cfc-42d5-8159-4bb6d24895c0"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="f12b2cca-2e93-478c-8b94-c656346b9e4f"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="6aba3a9f-b91a-4830-bae3-99483dca2db0"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27a8c5fc-cc41-46e3-bef0-af3ef7dae5db'>KimonoShapeLine</a></td><td style='width:75%' ><p><a name="27a8c5fc-cc41-46e3-bef0-af3ef7dae5db"></a></p>

<h3>KimonoShapeLine (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#353d0236-1f21-49cc-8d43-eb056a6413b4">KimonoShapeLine</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="f994dd78-8768-4705-a79d-541cf0b4396c"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="275dc67a-2b59-4ee2-aa0b-112f91428f15"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="7e38b240-4fec-4fd4-b2ea-8004d0bd6b06"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="3d8fd9c0-94c9-49c0-9f9d-b1a4e3d230fe"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="ab3263f4-c37f-461c-ad2b-252faafbc36a"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9e2390d0-83fa-4350-9ef6-8c2390f3d3d8'>Initialize</a></td><td style='width:75%' class='def'><p><a name="9e2390d0-83fa-4350-9ef6-8c2390f3d3d8"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0bc50e7-9447-4879-b814-237c37d31a57'>ToPath</a></td><td style='width:75%' ><p><a name="c0bc50e7-9447-4879-b814-237c37d31a57"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b4dbc8c-dfbb-4a3b-9d5a-b5ff1c245f22'>Draw</a></td><td style='width:75%' class='def'><p><a name="5b4dbc8c-dfbb-4a3b-9d5a-b5ff1c245f22"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the line into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="b0286595-c909-4792-89a2-f3cdeb8f8798"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ccaa2627-12a6-475d-b26c-6e624972b0f8'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="ccaa2627-12a6-475d-b26c-6e624972b0f8"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b15093f8-90b5-4deb-aaa4-d32531b622ef'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="b15093f8-90b5-4deb-aaa4-d32531b622ef"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bf71edd1-156f-463d-9090-c11a3eb624a2'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="bf71edd1-156f-463d-9090-c11a3eb624a2"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea4ce6c3-a374-43d5-bf71-be773c57ed12'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="ea4ce6c3-a374-43d5-bf71-be773c57ed12"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="adaf320a-23ce-4cb4-b448-d2eae7d4d850"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8fdff8c7-073b-420a-927a-7cc36c5b655d'>ToCode</a></td><td style='width:75%' ><p><a name="8fdff8c7-073b-420a-927a-7cc36c5b655d"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="5c5e6a2d-db80-4041-998b-3f30abd43c36"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8a2c77aa-0904-4868-a582-671b99f01e73"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="8a8634c4-5129-47e4-a18c-40a57d742851"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fe7a49e-0d61-40b2-a9fe-1e214103e7e1'>Clone</a></td><td style='width:75%' class='def'><p><a name="6fe7a49e-0d61-40b2-a9fe-1e214103e7e1"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone of the <code>KimonoLine</code>.</p>
</td></tr></table></p>


---

<a name="60a0823f-aaf6-41d5-9972-3d1154b2023d"></a>
## KimonoShapeOval

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws an oval into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3318877b-7c4b-4ccf-ae59-b3b702bfd89a'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="3318877b-7c4b-4ccf-ae59-b3b702bfd89a"></a></p>

<h3>KimonoShapeOval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#60a0823f-aaf6-41d5-9972-3d1154b2023d">KimonoShapeOval</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8438bb5f-d5cb-45b7-aff8-d9228b5b71b2'>KimonoShapeOval</a></td><td style='width:75%' class='def'><p><a name="8438bb5f-d5cb-45b7-aff8-d9228b5b71b2"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#60a0823f-aaf6-41d5-9972-3d1154b2023d">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8dfedc64-cb80-41e0-bf63-22ca3bf5a49f"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6b403ab5-55a5-4427-a093-e09e5d2bcc3a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="61061c74-4108-4161-b97f-3f91282c2fd4"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="30b99829-b31a-45f0-a5f9-714746ef6a41"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ed76d04-4f66-4f6e-8b81-82cb986d0ec7'>KimonoShapeOval</a></td><td style='width:75%' ><p><a name="8ed76d04-4f66-4f6e-8b81-82cb986d0ec7"></a></p>

<h3>KimonoShapeOval (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#60a0823f-aaf6-41d5-9972-3d1154b2023d">KimonoShapeOval</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="9ce8a75a-f283-493f-bfcc-af4743edcbb0"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="99cf57e3-01f2-4a8a-b81d-c2382c5a124a"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="11bfc7fc-61cd-4689-b070-6a811e1a8939"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="8e9d1a4a-c555-48a2-aa64-5e8356a6f746"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="ca5565b6-d6ad-45ac-a4b0-a88bc69b75df"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b878ab27-dcd4-4356-b931-e89058de94ec'>Initialize</a></td><td style='width:75%' class='def'><p><a name="b878ab27-dcd4-4356-b931-e89058de94ec"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ec0098b-54f3-41ea-b0bd-0e1baff3c8d9'>ToPath</a></td><td style='width:75%' ><p><a name="2ec0098b-54f3-41ea-b0bd-0e1baff3c8d9"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4a2892f4-7be7-45ab-8dc2-f34536941007'>Draw</a></td><td style='width:75%' class='def'><p><a name="4a2892f4-7be7-45ab-8dc2-f34536941007"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draw the oval into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="8eccb0d7-cde8-4f87-97ec-f8954e49e36b"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8c0f6673-0c6c-40b5-91c9-1157fb26b48e'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="8c0f6673-0c6c-40b5-91c9-1157fb26b48e"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fad3ba4b-c300-47a8-a4bb-d87b32989dfc'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="fad3ba4b-c300-47a8-a4bb-d87b32989dfc"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d71f9a3d-5d46-4ce2-abac-c5655249a70f'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="d71f9a3d-5d46-4ce2-abac-c5655249a70f"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7aebd9b-7761-4002-b9f4-2e172ae009d5'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="c7aebd9b-7761-4002-b9f4-2e172ae009d5"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f01efd6c-c92c-4e64-baad-a513a0e7a34e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54b9cdc7-fc49-469d-a18c-0b9cd123f916'>ToCode</a></td><td style='width:75%' ><p><a name="54b9cdc7-fc49-469d-a18c-0b9cd123f916"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="a3bbe2bd-7647-4e1c-aedb-89a0c345eec8"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="7f628091-a382-48db-96db-accf79a3dae8"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e943e880-67e4-46d3-a3cf-d48fd0eec29b"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9796d6e5-cd3b-48eb-92bc-1c1b601aa268'>Clone</a></td><td style='width:75%' class='def'><p><a name="9796d6e5-cd3b-48eb-92bc-1c1b601aa268"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoOval</code>.</p>
</td></tr></table></p>


---

<a name="47c05ff9-2854-48cb-835e-279a4c1934c1"></a>
## KimonoShapePolygon

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a multi-sided polygon into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#3e948496-995e-44d9-b0a8-4c8f128e77fb'>NumberOfSides</a></td><td style='width:75%' ><p><a name="3e948496-995e-44d9-b0a8-4c8f128e77fb"></a></p>

<h3>NumberOfSides</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of sides.</p>

<h4>Return Value</h4>

<p>The number of sides.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5d35bd0-97b4-47be-b89a-db3ec83d161b'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="a5d35bd0-97b4-47be-b89a-db3ec83d161b"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fc3681ff-288a-448b-9cfd-271721993e59'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="fc3681ff-288a-448b-9cfd-271721993e59"></a></p>

<h3>KimonoShapePolygon ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#47c05ff9-2854-48cb-835e-279a4c1934c1">KimonoShapePolygon</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e3d5603c-3880-47ea-8aeb-97c567809d60'>KimonoShapePolygon</a></td><td style='width:75%' class='def'><p><a name="e3d5603c-3880-47ea-8aeb-97c567809d60"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#47c05ff9-2854-48cb-835e-279a4c1934c1">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="73d45dc6-c444-4980-9ac1-2b795b30c373"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="6c4e4285-626c-4f69-af14-53deb5e4c637"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ed8777fc-8405-4c8d-bf9f-71586fdac9fa"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="86097abd-9d64-4840-9d79-6c72518989e0"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b73c02f7-f20d-4087-b6bc-0dccf95643ab'>KimonoShapePolygon</a></td><td style='width:75%' ><p><a name="b73c02f7-f20d-4087-b6bc-0dccf95643ab"></a></p>

<h3>KimonoShapePolygon (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#47c05ff9-2854-48cb-835e-279a4c1934c1">KimonoShapePolygon</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8c14f224-4ba3-4f19-9e0f-e9552c513324"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="9ae7a8d6-47b3-4cff-a551-c0744fb83dd1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="0c274f27-e26f-4d2b-84b4-9468ae7c7967"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="0bee8808-0096-4f6c-acd9-be6adb7ed33c"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="09323c99-9b5a-486e-9d68-4b9c823ca3ea"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd280a1e-a63d-474e-a6bc-47d6d533b1d0'>Initialize</a></td><td style='width:75%' class='def'><p><a name="dd280a1e-a63d-474e-a6bc-47d6d533b1d0"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44e32793-c1d4-46e9-92ad-c3e487d6cfc3'>MakeSidePoints</a></td><td style='width:75%' ><p><a name="44e32793-c1d4-46e9-92ad-c3e487d6cfc3"></a></p>

<h3>MakeSidePoints (System.Double, System.Int32, SkiaSharp.SKRect)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="64341b58-4ae0-44e9-a9c9-8cec89f60a90"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="71be11f8-a54b-4f59-b42a-4dd4c6ee7861"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="c3c2dcc1-8cd2-4971-8613-10bec7cd217e"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="fde63bb7-f0cd-4806-8df7-c877685144e4"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a80d5563-6964-4608-903f-e67c3d5c76c5'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="a80d5563-6964-4608-903f-e67c3d5c76c5"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="f4dbb4e8-b994-4aa9-93bf-4468baefd479"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ba2720f-3bfa-4d1a-be94-26bdfa3bc4fc'>ToPath</a></td><td style='width:75%' ><p><a name="4ba2720f-3bfa-4d1a-be94-26bdfa3bc4fc"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb7ab6e5-d072-4632-8e27-dbddb1824987'>Draw</a></td><td style='width:75%' class='def'><p><a name="cb7ab6e5-d072-4632-8e27-dbddb1824987"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the polygon into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="f9716c7a-a8a3-48f7-9d8c-3786734fbc5e"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9453ff8-6304-40d0-ba02-fa9812263ef1'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="a9453ff8-6304-40d0-ba02-fa9812263ef1"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3598b6f-6520-4e9e-93c5-06edea9e9581'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="a3598b6f-6520-4e9e-93c5-06edea9e9581"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d00a16f6-2165-4e9f-ad5a-07501e82387c'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="d00a16f6-2165-4e9f-ad5a-07501e82387c"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3227ad51-b954-4314-a992-1c50bd26cc20'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="3227ad51-b954-4314-a992-1c50bd26cc20"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="133fead2-f4d8-4c46-84ca-c5cead5758ff"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b47f97a2-deaa-48db-8cb4-afd3e6df150a'>ToCode</a></td><td style='width:75%' ><p><a name="b47f97a2-deaa-48db-8cb4-afd3e6df150a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="205cc11c-3bff-485e-b3a4-c5aa9918a005"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="221bff7c-76b0-417f-8074-853d57e8ab44"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="447f5ebb-3e42-42c2-9b56-974995bcbbdb"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a175f3da-e72b-42a9-8489-d57b7ef950fe'>Clone</a></td><td style='width:75%' class='def'><p><a name="a175f3da-e72b-42a9-8489-d57b7ef950fe"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoPloygon</code>.</p>
</td></tr></table></p>


---

<a name="1de07b5c-5e65-4fb1-96b2-6d7d8feb85af"></a>
## KimonoShapeRect

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#13af236a-e7ff-4637-800b-1a3bd6b2afb6'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="13af236a-e7ff-4637-800b-1a3bd6b2afb6"></a></p>

<h3>KimonoShapeRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1de07b5c-5e65-4fb1-96b2-6d7d8feb85af">KimonoShapeRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e845db62-a83b-4d8f-8045-3195b878eba6'>KimonoShapeRect</a></td><td style='width:75%' class='def'><p><a name="e845db62-a83b-4d8f-8045-3195b878eba6"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1de07b5c-5e65-4fb1-96b2-6d7d8feb85af">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="7665368e-8aad-4c0c-bc33-c77e34e740b9"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="178605f8-4350-43c2-a593-b85d45ec308e"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="8ae7155d-b6e8-47de-b5fb-f6162f51db47"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="ff502d35-7be5-4090-8b0d-4c8d4e31d712"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d50b97a-d9d0-402a-878b-035022beea52'>KimonoShapeRect</a></td><td style='width:75%' ><p><a name="6d50b97a-d9d0-402a-878b-035022beea52"></a></p>

<h3>KimonoShapeRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#1de07b5c-5e65-4fb1-96b2-6d7d8feb85af">KimonoShapeRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="59b318c9-df44-4595-8e90-c31dc55ee378"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="b2f0930c-9baf-4848-9f39-eb63d642f2f2"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="105feaf6-3beb-4278-a331-363fac0ce015"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="db65ac67-f4d7-4afd-a9a0-e98bbb467480"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="2974612e-881b-409b-9da5-e1dff9e167c1"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59dcdd19-7b03-4dce-b0ff-8584409c2a87'>Initialize</a></td><td style='width:75%' class='def'><p><a name="59dcdd19-7b03-4dce-b0ff-8584409c2a87"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e9e7a6a-7a1a-45c4-a70d-c38084a553c0'>ToPath</a></td><td style='width:75%' ><p><a name="8e9e7a6a-7a1a-45c4-a70d-c38084a553c0"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c494210-b438-47a8-b6e5-177c1816d970'>Draw</a></td><td style='width:75%' class='def'><p><a name="7c494210-b438-47a8-b6e5-177c1816d970"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="041781a8-48a2-425e-bb46-335b72f80cab"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4ee76c5-c895-48e8-964c-e092be156178'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="b4ee76c5-c895-48e8-964c-e092be156178"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#74e1e57b-d5e5-4dcb-b33b-52e0453d11a7'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="74e1e57b-d5e5-4dcb-b33b-52e0453d11a7"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9ac901b-fcad-4c38-a632-a01cc42fa8ff'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="f9ac901b-fcad-4c38-a632-a01cc42fa8ff"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6dc7460b-1a98-4aea-961d-f06c55bcb18b'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="6dc7460b-1a98-4aea-961d-f06c55bcb18b"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="df9c2886-7e0f-491b-875d-a8307bee913d"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00685abd-3094-428a-a8aa-7e01ffd5394b'>ToCode</a></td><td style='width:75%' ><p><a name="00685abd-3094-428a-a8aa-7e01ffd5394b"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="ea6b7514-b4f3-4ea2-a0df-603d7aa85567"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="d1df6eeb-7b0c-4817-9598-5685d4639689"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="b49f4e1b-3a0c-40ae-9164-4a3ab08768c4"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9bb2a1e-3093-4580-a94b-644ad20d20b8'>Clone</a></td><td style='width:75%' class='def'><p><a name="d9bb2a1e-3093-4580-a94b-644ad20d20b8"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="06f856c1-f3d5-4e46-9c14-806d3a2efffe"></a>
## KimonoShapeRoundRect

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a rounded rectangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d13fd1f6-7413-40de-8440-85f9e274f804'>CornerRadius</a></td><td style='width:75%' ><p><a name="d13fd1f6-7413-40de-8440-85f9e274f804"></a></p>

<h3>CornerRadius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the corner radius.</p>

<h4>Return Value</h4>

<p>The corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#17432b6c-e6ab-4fe8-a1d4-b89abcee6d26'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="17432b6c-e6ab-4fe8-a1d4-b89abcee6d26"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#611b374e-b34c-4b83-ad60-b1cb5a5e0ca1'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="611b374e-b34c-4b83-ad60-b1cb5a5e0ca1"></a></p>

<h3>KimonoShapeRoundRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f856c1-f3d5-4e46-9c14-806d3a2efffe">KimonoShapeRoundRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#935f441f-5d00-496e-b616-21bec0040a54'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="935f441f-5d00-496e-b616-21bec0040a54"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f856c1-f3d5-4e46-9c14-806d3a2efffe">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="8e00002b-73b4-40c8-9a34-8a9a87d301db"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f6565ea7-937b-4876-9c95-8b5050827179"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="da52456b-35cb-4d0f-9f51-639e47b028c4"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="21c9a626-ca9c-4129-87c9-a1db9f8ea5bf"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f9994c0-5d08-40ff-8b95-e222e9700677'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="0f9994c0-5d08-40ff-8b95-e222e9700677"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f856c1-f3d5-4e46-9c14-806d3a2efffe">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="58faeb81-f927-452b-b697-1261be6b1f29"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f3067267-303b-459f-a50e-7549077b10f8"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="d5db1d0f-c842-4d8f-a187-5810828c4957"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="16e174af-75ea-4a2a-bb02-430893e498f3"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="09127694-b376-4661-9d30-7a8b7db920c9"></a>
Corner radius.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6ad0916d-709e-4c1f-9f5d-8b452d5ef7a1'>KimonoShapeRoundRect</a></td><td style='width:75%' class='def'><p><a name="6ad0916d-709e-4c1f-9f5d-8b452d5ef7a1"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f856c1-f3d5-4e46-9c14-806d3a2efffe">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="432bbbab-76c6-4232-9ec4-a522770437bc"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="5ab72d98-5293-44e6-bf75-55273544e33f"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="383aba86-a7b4-4ed9-90c3-71cc0a91e8aa"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="3bcee45e-2a5b-498a-b65c-b945eb31fd75"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="33da3ca6-3113-45ff-89a1-8f033b6fb7fd"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37f6a194-6cdf-4130-b48b-308d88297d59'>KimonoShapeRoundRect</a></td><td style='width:75%' ><p><a name="37f6a194-6cdf-4130-b48b-308d88297d59"></a></p>

<h3>KimonoShapeRoundRect (System.Single, System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#06f856c1-f3d5-4e46-9c14-806d3a2efffe">KimonoShapeRoundRect</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="71c9e323-c175-45d2-9fed-323b41f6ffd1"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="31d8cb1a-3522-45dd-80ca-5c47fc4c3fdb"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b1b9642e-1d96-4033-b88d-97a447974205"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="a501a550-1775-4677-ae76-20d11bdfd570"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>cornerRadius</td><td style='width:75%' ><p><a name="6808baba-2466-40d8-b0cf-8d77e11580a6"></a>
Corner radius.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="df1077b5-da22-4d62-bdea-e0a74536ed19"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d85caff-a841-4b16-aa4c-8fe841e08187'>Initialize</a></td><td style='width:75%' class='def'><p><a name="3d85caff-a841-4b16-aa4c-8fe841e08187"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a8432b48-dcee-4bf0-a374-2589374a910d'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="a8432b48-dcee-4bf0-a374-2589374a910d"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="dcdabb75-9ef2-47c1-a0a3-34a895449869"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c58cd341-b76a-4af2-8614-869642de4211'>ToPath</a></td><td style='width:75%' class='def'><p><a name="c58cd341-b76a-4af2-8614-869642de4211"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5d96b72d-0f7f-497c-b39c-54ecf6fef03d'>Draw</a></td><td style='width:75%' ><p><a name="5d96b72d-0f7f-497c-b39c-54ecf6fef03d"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the round rectangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="5a1d3839-6ca0-455b-8750-414263b62e4b"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#73a210d8-c9a5-42ee-a3aa-c28059018e7d'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="73a210d8-c9a5-42ee-a3aa-c28059018e7d"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9fd0620-fad3-46ae-b5d4-373feb943a97'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="b9fd0620-fad3-46ae-b5d4-373feb943a97"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f694514c-a002-4e99-b4e4-11623306b95a'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="f694514c-a002-4e99-b4e4-11623306b95a"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6cf9b5b-6cf5-4acb-9571-cb6c007cd570'>ToCSharp</a></td><td style='width:75%' ><p><a name="d6cf9b5b-6cf5-4acb-9571-cb6c007cd570"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="7b340397-6770-4a95-b22b-e61f04eacb3c"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#87855145-92f3-4a55-aef4-9e5c9621933e'>ToCode</a></td><td style='width:75%' class='def'><p><a name="87855145-92f3-4a55-aef4-9e5c9621933e"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="c1a54ab0-f152-42d7-8a41-8b57ad5e7587"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="19a5ada2-6956-47c4-8035-67c9b5d88595"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="dd850879-a24f-420f-bfd8-86770fcc160c"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42cca28d-868c-4ad8-b58e-696ef97be356'>Clone</a></td><td style='width:75%' ><p><a name="42cca28d-868c-4ad8-b58e-696ef97be356"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeRoundRect</code>.</p>
</td></tr></table></p>


---

<a name="6c3d5f46-52b8-40d4-93d0-939867f6eabe"></a>
## KimonoShapeStar

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a multi-sided star shape into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#277845fc-ea6d-41c1-9c37-335807109154'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="277845fc-ea6d-41c1-9c37-335807109154"></a></p>

<h3>NumberOfPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the number of points.</p>

<h4>Return Value</h4>

<p>The number of points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d3812b5-236d-49c5-90d7-04bb6023c47c'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="0d3812b5-236d-49c5-90d7-04bb6023c47c"></a></p>

<h3>SkipPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the skip points.</p>

<h4>Return Value</h4>

<p>The skip points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00bf3f58-c1f3-47d2-a592-e81594b8d3da'>DepthOffset</a></td><td style='width:75%' ><p><a name="00bf3f58-c1f3-47d2-a592-e81594b8d3da"></a></p>

<h3>DepthOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the depth offset for the individual points.</p>

<h4>Return Value</h4>

<p>The depth offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c99c7c1-b7db-4a3f-90b9-40b9042fe3f1'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="7c99c7c1-b7db-4a3f-90b9-40b9042fe3f1"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#11621bb9-ff82-4b45-8981-788630d72297'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="11621bb9-ff82-4b45-8981-788630d72297"></a></p>

<h3>KimonoShapeStar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c3d5f46-52b8-40d4-93d0-939867f6eabe">KimonoShapeStar</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff518537-763c-408d-8c21-1e53fc089fd6'>KimonoShapeStar</a></td><td style='width:75%' class='def'><p><a name="ff518537-763c-408d-8c21-1e53fc089fd6"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c3d5f46-52b8-40d4-93d0-939867f6eabe">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="0a239ffa-363c-4072-8cd9-65d24af5d976"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="f99ae9e3-9b96-4e00-8e03-4d9146683c36"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="a73d8b1f-ac96-463c-b7e8-8066ff0f2700"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="7b981848-1b60-4722-a7be-0e85b0e4bb17"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfc071f7-bf57-4091-b22d-3d66ea1710b9'>KimonoShapeStar</a></td><td style='width:75%' ><p><a name="bfc071f7-bf57-4091-b22d-3d66ea1710b9"></a></p>

<h3>KimonoShapeStar (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#6c3d5f46-52b8-40d4-93d0-939867f6eabe">KimonoShapeStar</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="3e931566-ddac-4908-89af-45091d8d65e7"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="556007a3-441d-4e68-afbc-cdf95dd328fa"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="ae25123e-5490-43af-85e4-bdee0a092c3e"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="c58f95b0-06a8-49d3-b4b0-84564e4464a7"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="dfdfc333-1217-431c-942f-492a8319d57a"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c28fd645-6ff3-4d7a-b2ad-0b8d359455ed'>Initialize</a></td><td style='width:75%' class='def'><p><a name="c28fd645-6ff3-4d7a-b2ad-0b8d359455ed"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#824dfc13-1b45-462c-8e16-dc99a41559ea'>MakeStarPoints</a></td><td style='width:75%' ><p><a name="824dfc13-1b45-462c-8e16-dc99a41559ea"></a></p>

<h3>MakeStarPoints (System.Double, System.Int32, System.Int32, SkiaSharp.SKRect, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the star points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startTheta</td><td style='width:75%' ><p><a name="7eb068e0-0f4b-43ec-a60b-343f5beba94e"></a>
Start theta.</p>
</td></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' class='def'><p><a name="cbe6f09a-3cc9-4fa8-9d6a-54d15fdb070e"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' ><p><a name="6e8d5d74-0279-408a-a217-738bdd71dbd4"></a>
Skip.</p>
</td></tr><tr><td style='width:25%' class='term'>rect</td><td style='width:75%' class='def'><p><a name="b1c80dc0-c5f7-4e97-af35-4611d369f962"></a>
Rect.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The star points.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e18208c3-6f9d-43e3-8f7e-7ea49f77a804'>CalculateConcaveRadius</a></td><td style='width:75%' class='def'><p><a name="e18208c3-6f9d-43e3-8f7e-7ea49f77a804"></a></p>

<h3>CalculateConcaveRadius (System.Int32, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Calculates the concave radius.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>numPoints</td><td style='width:75%' ><p><a name="3e4af20c-8f87-4987-899e-66647e47fce3"></a>
Number points.</p>
</td></tr><tr><td style='width:25%' class='term'>skip</td><td style='width:75%' class='def'><p><a name="19679f63-578a-4972-81bf-b7b6e9aa14ec"></a>
Skip.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The concave radius.</p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/draw-a-star-with-a-given-number-of-points-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a5584931-c6e1-4d7d-8264-30c344dc080e'>FindIntersection</a></td><td style='width:75%' ><p><a name="a5584931-c6e1-4d7d-8264-30c344dc080e"></a></p>

<h3>FindIntersection (SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, SkiaSharp.SKPoint, System.Boolean@, System.Boolean@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@, SkiaSharp.SKPoint@)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the intersection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>p1</td><td style='width:75%' ><p><a name="ab1cdd09-ffae-43e7-9315-02a52e289fa1"></a>
P1.</p>
</td></tr><tr><td style='width:25%' class='term'>p2</td><td style='width:75%' class='def'><p><a name="df3f4c90-433a-4e35-9084-97b904534662"></a>
P2.</p>
</td></tr><tr><td style='width:25%' class='term'>p3</td><td style='width:75%' ><p><a name="1ec41a87-8e77-42f7-bd75-f26a6f491826"></a>
P3.</p>
</td></tr><tr><td style='width:25%' class='term'>p4</td><td style='width:75%' class='def'><p><a name="64172168-2db0-4cc2-803e-db2ca9500bac"></a>
P4.</p>
</td></tr><tr><td style='width:25%' class='term'>lines_intersect</td><td style='width:75%' ><p><a name="375e6a2c-f019-412e-984b-c3df0f3214be"></a>
If set to <code>true</code> lines intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>segments_intersect</td><td style='width:75%' class='def'><p><a name="7d21e5ba-57b8-493f-8f8c-f6c2eb8ae0c3"></a>
If set to <code>true</code> segments intersect.</p>
</td></tr><tr><td style='width:25%' class='term'>intersection</td><td style='width:75%' ><p><a name="3be52e46-b1d5-4816-a019-770308866811"></a>
Intersection.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p1</td><td style='width:75%' class='def'><p><a name="cb28fab8-a59f-4745-ad3e-8797805d22ec"></a>
Close p1.</p>
</td></tr><tr><td style='width:25%' class='term'>close_p2</td><td style='width:75%' ><p><a name="f80563dc-32f9-42a3-afa4-553fd8f0d6a6"></a>
Close p2.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>This code adapted from http://csharphelper.com/blog/2014/08/determine-where-two-lines-intersect-in-c/ by Rod Stephens.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cfd71a6-ff42-4c9b-8ca3-d2f46b8172b5'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="8cfd71a6-ff42-4c9b-8ca3-d2f46b8172b5"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="d2d6789d-a9cc-40b0-8320-050b632bc2c6"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aa6ed7a1-5070-4cfa-abac-3f4b9a39ee34'>ToPath</a></td><td style='width:75%' ><p><a name="aa6ed7a1-5070-4cfa-abac-3f4b9a39ee34"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aef34966-3522-49f5-a49b-1a2092c98e65'>Draw</a></td><td style='width:75%' class='def'><p><a name="aef34966-3522-49f5-a49b-1a2092c98e65"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the star into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="f3f3bca2-f7f9-42e3-bd49-11324b178cf2"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2074481-3987-4fb8-a4fa-75349e44e2d3'>ToVector</a></td><td style='width:75%' ><p><a name="d2074481-3987-4fb8-a4fa-75349e44e2d3"></a></p>

<h3>ToVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the star into a vector.</p>

<h4>Returns</h4>

<p>The <code>KimonoShapeVector</code> version of the star.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f2564f73-4f84-4fbb-b810-fb0b26818dd4'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="f2564f73-4f84-4fbb-b810-fb0b26818dd4"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0773a82a-713c-4d9c-8197-d142209576bf'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="0773a82a-713c-4d9c-8197-d142209576bf"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6ff5bc0-4f48-4e2d-bdaf-230431fc9080'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="b6ff5bc0-4f48-4e2d-bdaf-230431fc9080"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c64e7c8-21be-495b-99a2-dc3db6d9f919'>ToCSharp</a></td><td style='width:75%' ><p><a name="3c64e7c8-21be-495b-99a2-dc3db6d9f919"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c46d16b4-cd65-4274-aa54-08bfd0c8fb0f"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9753cb32-7491-4c6c-a26f-0511321aad59'>ToCode</a></td><td style='width:75%' class='def'><p><a name="9753cb32-7491-4c6c-a26f-0511321aad59"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="6ffc8423-ac7e-467c-aed3-f308031c848b"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="09144879-76a9-4250-87b0-394fc6fd9e53"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="930521e1-7852-421f-838c-23dbcc5e62e7"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#49b366a9-a36e-4279-a82b-7f153d219cb6'>Clone</a></td><td style='width:75%' ><p><a name="49b366a9-a36e-4279-a82b-7f153d219cb6"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeStar</code>.</p>
</td></tr></table></p>


---

<a name="d346396c-3c00-4318-8c82-ebafcfb6b108"></a>
## KimonoShapeState

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Holds the current state of a `KimonoShape` while it is being edited by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6ba4a53a-7346-465a-a7a6-79a198f2c9e7'>Unselected</a></td><td style='width:75%' ><p><a name="6ba4a53a-7346-465a-a7a6-79a198f2c9e7"></a>
<b>Unselected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is unselected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3b71ddce-a89c-4969-ab45-8b64da5cc4f4'>Selected</a></td><td style='width:75%' class='def'><p><a name="3b71ddce-a89c-4969-ab45-8b64da5cc4f4"></a>
<b>Selected</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6583ae8-e686-4dc0-896d-eff8b6b9072f'>Editing</a></td><td style='width:75%' ><p><a name="d6583ae8-e686-4dc0-896d-eff8b6b9072f"></a>
<b>Editing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the edit mode and individual control points can be added, deleted, moved or adjusted.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d21bb3d-9505-460e-be1d-32f58adb21a3'>Finalizing</a></td><td style='width:75%' class='def'><p><a name="3d21bb3d-9505-460e-be1d-32f58adb21a3"></a>
<b>Finalizing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is leaving the edit mode and needs to be completed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b51c0972-209f-4573-a10d-d7a9b7138960'>Constructing</a></td><td style='width:75%' ><p><a name="b51c0972-209f-4573-a10d-d7a9b7138960"></a>
<b>Constructing</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is in the process of being built. For example, a set of shapes being added to a group.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8f61527b-4718-46b9-bc28-29ba3539b735'>Grouping</a></td><td style='width:75%' class='def'><p><a name="8f61527b-4718-46b9-bc28-29ba3539b735"></a>
<b>Grouping</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The shape is being added to a group.</p>
</td></tr></table></p>


---

<a name="24982fc8-412b-4c73-8fcf-2b48eb09e67f"></a>
## KimonoShapeText

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a block of text into the Design Surface within the specifid bounds of this shape.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4680367d-3085-4045-aaaf-0e3dbda3f258'>Text</a></td><td style='width:75%' ><p><a name="4680367d-3085-4045-aaaf-0e3dbda3f258"></a></p>

<h3>Text</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text.</p>

<h4>Return Value</h4>

<p>The text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9869e4e-74e1-4614-a99e-c2f0f4858678'>FontMetrics</a></td><td style='width:75%' class='def'><p><a name="b9869e4e-74e1-4614-a99e-c2f0f4858678"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d5dfd844-3157-4a29-933b-32280839d6dd'>IsLinearText</a></td><td style='width:75%' ><p><a name="d5dfd844-3157-4a29-933b-32280839d6dd"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d50c886f-921f-4038-aca5-3b1b7de9289f'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="d50c886f-921f-4038-aca5-3b1b7de9289f"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d87c870d-671f-4a5e-bffe-ed24318c46d8'>StrikeThruText</a></td><td style='width:75%' ><p><a name="d87c870d-671f-4a5e-bffe-ed24318c46d8"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65c01559-c124-4fc3-824d-7c8aee00b0e8'>TextAlign</a></td><td style='width:75%' class='def'><p><a name="65c01559-c124-4fc3-824d-7c8aee00b0e8"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44271462-cfe9-41d6-b1ae-b74ed21f6fe9'>TextEncoding</a></td><td style='width:75%' ><p><a name="44271462-cfe9-41d6-b1ae-b74ed21f6fe9"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44db3e03-3fdd-49e4-bbf1-e9c4969c7ae3'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="44db3e03-3fdd-49e4-bbf1-e9c4969c7ae3"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c26010fa-a554-448f-8a3a-d310f2bd6258'>TextSize</a></td><td style='width:75%' ><p><a name="c26010fa-a554-448f-8a3a-d310f2bd6258"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1b3ce9a1-1973-4918-821f-7aa80337f373'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="1b3ce9a1-1973-4918-821f-7aa80337f373"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f01f8c8-e1c1-4e08-9d5b-956d59769ba4'>Typeface</a></td><td style='width:75%' ><p><a name="5f01f8c8-e1c1-4e08-9d5b-956d59769ba4"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6a77d03e-520e-4dae-8c81-3f4cbc02107e'>FontFamilyName</a></td><td style='width:75%' class='def'><p><a name="6a77d03e-520e-4dae-8c81-3f4cbc02107e"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#51798ecc-c943-41fc-b19b-1ddb38c9159a'>TypefaceStyle</a></td><td style='width:75%' ><p><a name="51798ecc-c943-41fc-b19b-1ddb38c9159a"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5b3b10e2-785f-4e6c-b017-2097529ad776'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="5b3b10e2-785f-4e6c-b017-2097529ad776"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94813b22-f40c-4d94-91d0-dc9ae29a024e'>ConnectionPoints</a></td><td style='width:75%' ><p><a name="94813b22-f40c-4d94-91d0-dc9ae29a024e"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#83f76c68-f64a-462c-80fe-41e5eab8b42a'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="83f76c68-f64a-462c-80fe-41e5eab8b42a"></a></p>

<h3>KimonoShapeText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f4ccbfdf-cef1-4bbe-a3bf-115acea067db'>KimonoShapeText</a></td><td style='width:75%' class='def'><p><a name="f4ccbfdf-cef1-4bbe-a3bf-115acea067db"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="c66fcb94-cfa2-4f7d-82f0-d449f1a92e54"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="570000c4-325c-4a06-b486-164375bc513c"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="447f4975-1bc1-45fb-b0e0-db25611fa0bb"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="e64b9e53-3342-4e65-ba46-a8779e89b56c"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f63e31f6-92bc-480f-a33f-a1ba656b8256'>KimonoShapeText</a></td><td style='width:75%' ><p><a name="f63e31f6-92bc-480f-a33f-a1ba656b8256"></a></p>

<h3>KimonoShapeText (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#24982fc8-412b-4c73-8fcf-2b48eb09e67f">KimonoShapeText</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="92ea0499-ecdd-4124-9269-5ba32573a706"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="bea2d7ae-291e-4d51-9ca4-19025ba968ef"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="3d3de1b3-596b-4655-bdf0-e79c90bab321"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="674ddb7d-5931-4f49-b40d-68c6b5db8331"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="f720fc2b-1295-46a9-808d-f40a97f74777"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc585075-5b53-43a5-9a71-0598e9be4fbf'>Initialize</a></td><td style='width:75%' class='def'><p><a name="cc585075-5b53-43a5-9a71-0598e9be4fbf"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f588d310-84fb-45b4-8602-5a887dc5c0ce'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="f588d310-84fb-45b4-8602-5a887dc5c0ce"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoShape</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="0ea4dfe3-8bcb-4635-92e1-214eab9d0aed"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#158d44ca-7d44-41a1-967c-665818802bdf'>ToPath</a></td><td style='width:75%' class='def'><p><a name="158d44ca-7d44-41a1-967c-665818802bdf"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e1e3010b-2dae-406d-bb7e-7864403d562e'>Draw</a></td><td style='width:75%' ><p><a name="e1e3010b-2dae-406d-bb7e-7864403d562e"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the text block into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="0f6c3e17-93c0-4229-81af-7d1c5b5f3e65"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#19dfb3ce-23f1-486b-952b-4200d44aaa3f'>GrowBounds</a></td><td style='width:75%' class='def'><p><a name="19dfb3ce-23f1-486b-952b-4200d44aaa3f"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Grows the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="b25085b8-87f0-4f54-9353-ffdc012bd79d"></a>
The <code>SKPoint</code> to adjust the bounds by.</p>
</td></tr></table></p>

<h4>Remarks</h4>

<p>TODO: Changing the bounds of a text box should optionally scale the size of the text within.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4086d2c9-56e8-4435-a833-2d2fecb5cbcb'>DragBounds</a></td><td style='width:75%' ><p><a name="4086d2c9-56e8-4435-a833-2d2fecb5cbcb"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the text block.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="1f7c41cb-ce71-4a1b-9209-07bb602bdce2"></a>
The <code>SKPoint</code> with the new location of the bounds.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c9d36f5c-ecfa-4088-ad79-c6725df46b20'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="c9d36f5c-ecfa-4088-ad79-c6725df46b20"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30f9aeac-6006-414c-b5c2-efb184616134'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="30f9aeac-6006-414c-b5c2-efb184616134"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>

<h4>Remarks</h4>

<p>TODO: This routine currently breaks line on characters and it needs to be adjust to break on word boundaries.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7a75995-b843-4d63-b335-9e710eeedb75'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="f7a75995-b843-4d63-b335-9e710eeedb75"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#547d0266-552d-4630-9f65-951befc7b37f'>ToCSharp</a></td><td style='width:75%' ><p><a name="547d0266-552d-4630-9f65-951befc7b37f"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="16218903-4fb2-4718-b87f-335276afd35f"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea944fda-1755-45ea-9df1-4e3be0ae66ba'>ToCode</a></td><td style='width:75%' class='def'><p><a name="ea944fda-1755-45ea-9df1-4e3be0ae66ba"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="fee56d8f-a5b9-4a7a-a0f7-9a717a01818f"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8a1f32bb-4e7f-481e-a5e4-7069c452da8b"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f5ec40ab-5400-4ee3-bd71-77c40975fb38"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a113b389-f3e2-4ac8-b5e7-cf9f0f03ea6f'>Clone</a></td><td style='width:75%' ><p><a name="a113b389-f3e2-4ac8-b5e7-cf9f0f03ea6f"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeText</code>.</p>
</td></tr></table></p>


---

<a name="383ac657-8cef-469a-857b-bb42481a0ce3"></a>
## KimonoShapeTriangle

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Draws a triangle into the Design Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1c4c37c6-5cae-4f8f-b855-4ef19aa0f575'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="1c4c37c6-5cae-4f8f-b855-4ef19aa0f575"></a></p>

<h3>KimonoShapeTriangle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#383ac657-8cef-469a-857b-bb42481a0ce3">KimonoShapeTriangle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32f18193-6e32-4693-a2e1-8dda5bdfc938'>KimonoShapeTriangle</a></td><td style='width:75%' class='def'><p><a name="32f18193-6e32-4693-a2e1-8dda5bdfc938"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#383ac657-8cef-469a-857b-bb42481a0ce3">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="a832c488-ede1-455e-8d96-3631284371f4"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a86b8452-c7a4-4fec-a5bb-6c9715895db5"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="43500143-5f23-431c-87d9-91db2f81168a"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="de76cff4-c55e-4074-9ab0-9ef9a2e0fd96"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ba32cf11-0fbb-40af-bbcc-af3b8b13e327'>KimonoShapeTriangle</a></td><td style='width:75%' ><p><a name="ba32cf11-0fbb-40af-bbcc-af3b8b13e327"></a></p>

<h3>KimonoShapeTriangle (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#383ac657-8cef-469a-857b-bb42481a0ce3">KimonoShapeTriangle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="378885c3-bf8d-4b52-b67a-cc0ca2079128"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a44328f6-6b33-4132-8108-022565cf4de1"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="40a2adf1-e6b7-4fff-bfcd-31c0a064cbe2"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="43d5de55-3663-4209-9c58-b3be22134217"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="5feed93e-8678-41d1-abe1-5580b3543dec"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#53979ba5-0a41-43f9-a254-05a6383d7099'>Initialize</a></td><td style='width:75%' class='def'><p><a name="53979ba5-0a41-43f9-a254-05a6383d7099"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8733770-953b-48af-ad0a-b55d4893d9ba'>ToPath</a></td><td style='width:75%' ><p><a name="c8733770-953b-48af-ad0a-b55d4893d9ba"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce4d566d-3615-49f3-906d-e317687c7c05'>Draw</a></td><td style='width:75%' class='def'><p><a name="ce4d566d-3615-49f3-906d-e317687c7c05"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the triangle into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="fea0a718-aac1-486c-b963-195ac7d3632c"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d23c1943-4bf5-49ba-b7fd-4d8de45d6703'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="d23c1943-4bf5-49ba-b7fd-4d8de45d6703"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#994a1631-9505-4c0d-bae1-c11455c03b85'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="994a1631-9505-4c0d-bae1-c11455c03b85"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4094771a-0a5b-464e-b88c-e603287ec5c3'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="4094771a-0a5b-464e-b88c-e603287ec5c3"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99739646-305a-4bca-9222-82e513edf0d1'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="99739646-305a-4bca-9222-82e513edf0d1"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="73c45eca-715c-42bd-913b-5b7350ecaabe"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#698cb125-3152-44fc-a992-a7ae3d8831d4'>ToCode</a></td><td style='width:75%' ><p><a name="698cb125-3152-44fc-a992-a7ae3d8831d4"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="226b99fc-c893-478b-a33b-7562a5f936da"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="31da09f8-f28d-46e1-a80f-c4e9ff7414c4"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f4d26126-3edb-473d-b1c3-57e2ea35b6bc"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#16199c94-c38e-48f9-a739-978f7c9287bb'>Clone</a></td><td style='width:75%' class='def'><p><a name="16199c94-c38e-48f9-a739-978f7c9287bb"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeTriangle</code>.</p>
</td></tr></table></p>


---

<a name="a1d32782-f8dc-4add-962a-324097d3d34b"></a>
## KimonoShapeVector

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

A vector is a hard edged shape consisting of a set of datapoints that will be drawn into the Desing Surface.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ad37e47d-29f8-4008-9c9f-bba184480695'>Points</a></td><td style='width:75%' ><p><a name="ad37e47d-29f8-4008-9c9f-bba184480695"></a></p>

<h3>Points</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the points that define the shape.</p>

<h4>Return Value</h4>

<p>The points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8391d342-57aa-4d3a-a1f3-9e11357e7574'>Closed</a></td><td style='width:75%' class='def'><p><a name="8391d342-57aa-4d3a-a1f3-9e11357e7574"></a></p>

<h3>Closed</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> is closed.</p>

<h4>Return Value</h4>

<p><code>true</code> if closed; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8a563e9c-20e9-4dd7-a200-7977c7b9e356'>IsEditable</a></td><td style='width:75%' ><p><a name="8a563e9c-20e9-4dd7-a200-7977c7b9e356"></a></p>

<h3>IsEditable</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> is editable.</p>

<h4>Return Value</h4>

<p><code>true</code> if is editable; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#77df5b4b-1134-41b3-bbcf-554d21a43d98'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="77df5b4b-1134-41b3-bbcf-554d21a43d98"></a></p>

<h3>KimonoShapeVector ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd57962b-0e11-4366-826d-16a04a3371b5'>KimonoShapeVector</a></td><td style='width:75%' class='def'><p><a name="fd57962b-0e11-4366-826d-16a04a3371b5"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="3a727b5e-0370-4936-bb7e-97e6ecc63f15"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="a1f01dac-2737-47b0-8f3c-f976afc01155"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="39efbaa3-ec29-4491-95a3-3790ad27a0c4"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="f13ed31e-a922-4aba-ad9f-8737218fe778"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#329c0e51-26df-4a11-ac01-fbc5acfafc97'>KimonoShapeVector</a></td><td style='width:75%' ><p><a name="329c0e51-26df-4a11-ac01-fbc5acfafc97"></a></p>

<h3>KimonoShapeVector (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a1d32782-f8dc-4add-962a-324097d3d34b">KimonoShapeVector</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="5bd53d74-30c8-425f-80a2-c0127f94c44e"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="5d2c9344-459f-469f-a9b4-13e974e6bc67"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="697a9581-d78d-4527-9e74-274169e0a84c"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="808bbbe0-843d-47d2-bd26-86b8fb190fb4"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="fc6a6724-eb50-4e42-9410-acfa856424fc"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4318b08b-9930-4eea-8d1e-4ec458b567b0'>Initialize</a></td><td style='width:75%' class='def'><p><a name="4318b08b-9930-4eea-8d1e-4ec458b567b0"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#286c057f-1b31-45f2-a9a6-d75b006fd59f'>RecalculateVectorBounds</a></td><td style='width:75%' ><p><a name="286c057f-1b31-45f2-a9a6-d75b006fd59f"></a></p>

<h3>RecalculateVectorBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Recalculates the vector bounds to encompas all of the data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d4f874d-f05e-4b08-be6e-07e96d359c52'>AddPoint</a></td><td style='width:75%' class='def'><p><a name="6d4f874d-f05e-4b08-be6e-07e96d359c52"></a></p>

<h3>AddPoint (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="641bc08c-7cc7-4161-a99c-e3d04916d643"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="e6a55010-4191-47c3-88f5-012cc7fa53fe"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#527a3fc0-b000-49ed-87e9-aac92f3867d2'>AddPoint</a></td><td style='width:75%' ><p><a name="527a3fc0-b000-49ed-87e9-aac92f3867d2"></a></p>

<h3>AddPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given point to the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="56b2c2bf-0551-42c5-9f11-de68f59bac76"></a>
The new <code>SKPoint</code> to add.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#430d8553-b06b-421d-9118-483849ba15b8'>MoveLastPoint</a></td><td style='width:75%' class='def'><p><a name="430d8553-b06b-421d-9118-483849ba15b8"></a></p>

<h3>MoveLastPoint (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the last point added to the new position.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="80b7b3ee-79af-4bf1-8557-cf93ade934e2"></a>
The <code>SKPoint</code> for the new position.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fd5815c0-c892-4cc6-b9fb-88710f0ac852'>RemovePoint</a></td><td style='width:75%' ><p><a name="fd5815c0-c892-4cc6-b9fb-88710f0ac852"></a></p>

<h3>RemovePoint (System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>n</td><td style='width:75%' ><p><a name="92441c4c-5cfc-443b-8938-78ee4250b56e"></a>
The index of the point ot remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae00ec73-a657-4346-a604-6f36f097ccd1'>ApplyMoveAndScale</a></td><td style='width:75%' class='def'><p><a name="ae00ec73-a657-4346-a604-6f36f097ccd1"></a></p>

<h3>ApplyMoveAndScale ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the move and scale amount to the data point that make up the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6b0809f-a506-49f5-b84b-8ca9fd057b31'>ToPath</a></td><td style='width:75%' ><p><a name="b6b0809f-a506-49f5-b84b-8ca9fd057b31"></a></p>

<h3>ToPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the current shape to a path.</p>

<h4>Returns</h4>

<p>The shape as a <code>SKPath</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f6a3dbe-f3fa-4088-bde8-830f81dd0a6b'>Draw</a></td><td style='width:75%' class='def'><p><a name="6f6a3dbe-f3fa-4088-bde8-830f81dd0a6b"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the shape into the given Skia Canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="2ce90236-0793-44dc-a462-4b9bf1289725"></a>
The <code>SKCanvas</code> to draw into.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4e18ee0-5758-4886-94ae-8bb2be32985c'>PointInBound</a></td><td style='width:75%' ><p><a name="b4e18ee0-5758-4886-94ae-8bb2be32985c"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Tests to see if the given point is inside the bounds of the shape.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="dbe805c1-326b-457c-85f2-fa34a0f02604"></a>
The <code>SKPoint</code> to test.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bound was pointed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de9c3240-334c-4231-8eb2-767f6950130c'>DragBounds</a></td><td style='width:75%' class='def'><p><a name="de9c3240-334c-4231-8eb2-767f6950130c"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds of the shape to a new location.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="eabe72d4-1e76-477f-abea-c6138edd6f96"></a>
The <code>SKPoint</code> to drag the bounds to.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d42a6bcf-0ba5-47aa-941c-790b9eb24d0c'>BoundsChanged</a></td><td style='width:75%' ><p><a name="d42a6bcf-0ba5-47aa-941c-790b9eb24d0c"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the bounds of the shape being changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5efe2c5-55d2-4235-8929-e038dc353615'>StartEditing</a></td><td style='width:75%' class='def'><p><a name="c5efe2c5-55d2-4235-8929-e038dc353615"></a></p>

<h3>StartEditing ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the shape into the editing mode where the user can adjust the individual data points that define the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#32d3f4d3-042e-432c-94ef-68a7622df99b'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="32d3f4d3-042e-432c-94ef-68a7622df99b"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8e142cdd-7c54-4e32-968f-5bdef440c596'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="8e142cdd-7c54-4e32-968f-5bdef440c596"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#babed275-8f05-4622-9ce0-4fefb644b615'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="babed275-8f05-4622-9ce0-4fefb644b615"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#040c007a-a406-43da-9e12-007a8f3c30e8'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="040c007a-a406-43da-9e12-007a8f3c30e8"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="5511ba3b-74ec-43c0-8384-4b4314fae261"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b786fffe-ba86-41ed-a21a-2b37a58b49f1'>ToCode</a></td><td style='width:75%' ><p><a name="b786fffe-ba86-41ed-a21a-2b37a58b49f1"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="264401ac-7c0e-49db-bcd1-f9a8504ab6ff"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="d827ee3c-33d2-400a-9545-42a2a07075a5"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c809ed51-ff03-4c22-a981-9f375deaec72"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f05f00f3-81ee-4e4c-9944-d569cff8bb24'>Clone</a></td><td style='width:75%' class='def'><p><a name="f05f00f3-81ee-4e4c-9944-d569cff8bb24"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone <code>KimonoShapeVector</code>.</p>
</td></tr></table></p>


---

<a name="b34e2caa-a148-40b0-a15d-9e805664db66"></a>
## KimonoProperty

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a property that can be attached to another Kimono object (such as a `KimonoColor`, `KimonoStyle` or `KimonoShape`) and be used as a local variable, global variable or a  parameter or be the result of a calculation using the Obi Simple Scripting Language.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#407896e7-1113-4958-8510-b18469eaa504'>UniqueID</a></td><td style='width:75%' ><p><a name="407896e7-1113-4958-8510-b18469eaa504"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d9246f5a-faa4-4f1f-bd3a-92af7aa3a98d'>Name</a></td><td style='width:75%' class='def'><p><a name="d9246f5a-faa4-4f1f-bd3a-92af7aa3a98d"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name as a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a141c410-d2b3-4d7d-801d-d15bc7b5dbdd'>Usage</a></td><td style='width:75%' ><p><a name="a141c410-d2b3-4d7d-801d-d15bc7b5dbdd"></a></p>

<h3>Usage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the usage of this property.</p>

<h4>Return Value</h4>

<p>The <code>KimonoPropertyUsage</code> of this <code>KimonoProperty</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb3b80da-9cb6-4468-8129-a56d0076543b'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="cb3b80da-9cb6-4468-8129-a56d0076543b"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#b34e2caa-a148-40b0-a15d-9e805664db66">KimonoProperty</a> is the result of an Obi Script.</p>

<h4>Return Value</h4>

<p><code>true</code> if is Obi Script value; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cb0478b3-ffc6-457e-8cae-2c858e1e8be7'>ObiScript</a></td><td style='width:75%' ><p><a name="cb0478b3-ffc6-457e-8cae-2c858e1e8be7"></a></p>

<h3>ObiScript</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the obi script that will be used to calculate the value of this <code>KimonoProperty</code>.</p>

<h4>Return Value</h4>

<p>The obi script.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b2c62b9a-b2b9-46ec-bae1-333d27f0480e'>KimonoProperty</a></td><td style='width:75%' ><p><a name="b2c62b9a-b2b9-46ec-bae1-333d27f0480e"></a></p>

<h3>KimonoProperty ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#b34e2caa-a148-40b0-a15d-9e805664db66">KimonoProperty</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3dff2fb-04ee-4c9f-a343-838ad2b5365d'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="d3dff2fb-04ee-4c9f-a343-838ad2b5365d"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2e5821f-358f-43f8-a2b5-10f49d119e26'>ToRect</a></td><td style='width:75%' ><p><a name="d2e5821f-358f-43f8-a2b5-10f49d119e26"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64466212-31ac-46bd-ae52-7199ddf19975'>ToFloat</a></td><td style='width:75%' class='def'><p><a name="64466212-31ac-46bd-ae52-7199ddf19975"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c931568e-3cfb-4605-9c6b-e808d029e598'>ToInt</a></td><td style='width:75%' ><p><a name="c931568e-3cfb-4605-9c6b-e808d029e598"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96f6ff84-98a3-48e3-9d35-8d33351911ab'>ToStyle</a></td><td style='width:75%' class='def'><p><a name="96f6ff84-98a3-48e3-9d35-8d33351911ab"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dacfae43-5f7d-47d4-9cc5-a87d0474bf8c'>ToBool</a></td><td style='width:75%' ><p><a name="dacfae43-5f7d-47d4-9cc5-a87d0474bf8c"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p>The <code>bool</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9d79e1a-0f6e-4687-8967-94209d014f12'>ToColor</a></td><td style='width:75%' class='def'><p><a name="a9d79e1a-0f6e-4687-8967-94209d014f12"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adb61ee5-fb26-44a2-a987-cebe08e774a8'>ToGradient</a></td><td style='width:75%' ><p><a name="adb61ee5-fb26-44a2-a987-cebe08e774a8"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c10eaf96-563f-46f7-aa4c-59fd9a46b8bb'>Clone</a></td><td style='width:75%' class='def'><p><a name="c10eaf96-563f-46f7-aa4c-59fd9a46b8bb"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="94a18758-140b-44ea-9163-af36ce62b6e5"></a>
## KimonoPropertyUsage

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines how a `KimonoProperty` is used when it is attached to a `KimonoShape`, `KimonoSketch` or `KimonoPortfolio`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#1becf8f5-38a0-4624-b29f-7e34ea1c9454'>LocalVariable</a></td><td style='width:75%' ><p><a name="1becf8f5-38a0-4624-b29f-7e34ea1c9454"></a>
<b>LocalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a local variable in the  generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a2db27b4-34df-42e2-8765-74c9a7d4c2cc'>GlobalVariable</a></td><td style='width:75%' class='def'><p><a name="a2db27b4-34df-42e2-8765-74c9a7d4c2cc"></a>
<b>GlobalVariable</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a global variable in the generated code for a Kimono object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d882fb09-e613-4fdb-bbce-922572570635'>Parameter</a></td><td style='width:75%' ><p><a name="d882fb09-e613-4fdb-bbce-922572570635"></a>
<b>Parameter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The given <code>KimonoProperty</code> will be used as a passed parameter in the generated code for a Kimono object.</p>
</td></tr></table></p>


---

<a name="457b2aa8-a89f-4ef0-8e32-986e966ba386"></a>
## KimonoPropertyConnectionPoint

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the point that a `KimonoProperty` value can be connected to another Kimono object such as the `Top` coordinate of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0b2c1aee-67b8-4c0c-99d4-60ce8c9b6162'>Undefined</a></td><td style='width:75%' ><p><a name="0b2c1aee-67b8-4c0c-99d4-60ce8c9b6162"></a>
<b>Undefined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The connection point hasn't been defined.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b833bfb-32b0-4bea-b5af-65d44aa1a4c4'>Rect</a></td><td style='width:75%' class='def'><p><a name="6b833bfb-32b0-4bea-b5af-65d44aa1a4c4"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The rectangle that defines the <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8bb639a7-cb07-4c69-b040-0ae1495f3773'>Top</a></td><td style='width:75%' ><p><a name="8bb639a7-cb07-4c69-b040-0ae1495f3773"></a>
<b>Top</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Top coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efc3ce33-ef10-49ac-93b3-59f9885c6584'>Left</a></td><td style='width:75%' class='def'><p><a name="efc3ce33-ef10-49ac-93b3-59f9885c6584"></a>
<b>Left</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Left coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a3c35c7d-60e7-4b50-b3db-0e180d26b045'>Bottom</a></td><td style='width:75%' ><p><a name="a3c35c7d-60e7-4b50-b3db-0e180d26b045"></a>
<b>Bottom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Bottom coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e68a871b-d313-4f4a-a6b4-b76518e38369'>Right</a></td><td style='width:75%' class='def'><p><a name="e68a871b-d313-4f4a-a6b4-b76518e38369"></a>
<b>Right</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Right coordinate of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8013954d-7b19-47b4-9b3b-ac1ac3532004'>Width</a></td><td style='width:75%' ><p><a name="8013954d-7b19-47b4-9b3b-ac1ac3532004"></a>
<b>Width</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Widht of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b4cc3651-0626-4247-9a56-9c9503a98911'>Height</a></td><td style='width:75%' class='def'><p><a name="b4cc3651-0626-4247-9a56-9c9503a98911"></a>
<b>Height</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Height of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#98de1c25-0ea3-43bd-85df-f3bb0b791911'>RotationDegrees</a></td><td style='width:75%' ><p><a name="98de1c25-0ea3-43bd-85df-f3bb0b791911"></a>
<b>RotationDegrees</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The Rotational Degrees of a <code>KimonoShape</code> Bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9160fab5-5691-46eb-a818-ce56ba063b4c'>Style</a></td><td style='width:75%' class='def'><p><a name="9160fab5-5691-46eb-a818-ce56ba063b4c"></a>
<b>Style</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The <code>KimonoStyle</code> of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#64e7d912-98eb-4eed-889f-db605b8d5cb8'>Visible</a></td><td style='width:75%' ><p><a name="64e7d912-98eb-4eed-889f-db605b8d5cb8"></a>
<b>Visible</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The visibility of a <code>KimonoShape</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#61683d96-eecd-449d-93a8-6da2ffe396da'>HasStartHead</a></td><td style='width:75%' class='def'><p><a name="61683d96-eecd-449d-93a8-6da2ffe396da"></a>
<b>HasStartHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has start head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff478364-5f89-48a7-afff-8d8bcc1778c7'>HasEndHead</a></td><td style='width:75%' ><p><a name="ff478364-5f89-48a7-afff-8d8bcc1778c7"></a>
<b>HasEndHead</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has end head of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#abf8a327-14b0-4e29-93c6-db2ef703a18c'>HeadInnerRatio</a></td><td style='width:75%' class='def'><p><a name="abf8a327-14b0-4e29-93c6-db2ef703a18c"></a>
<b>HeadInnerRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head inner ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a630a251-338a-42e1-9b01-abdb14caad46'>HeadOuterRatio</a></td><td style='width:75%' ><p><a name="a630a251-338a-42e1-9b01-abdb14caad46"></a>
<b>HeadOuterRatio</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The head outer ratio of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24648c5c-f3fd-4911-8306-92ee12ee6b58'>IsStreamlined</a></td><td style='width:75%' class='def'><p><a name="24648c5c-f3fd-4911-8306-92ee12ee6b58"></a>
<b>IsStreamlined</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is streamlined of a <code>KimonoShapeArrow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5f79f6e5-9bdb-48ea-9652-e8967bab0d5e'>NumberOfSides</a></td><td style='width:75%' ><p><a name="5f79f6e5-9bdb-48ea-9652-e8967bab0d5e"></a>
<b>NumberOfSides</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of sides of a <code>KimonoShapePolygon</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#46abd053-45ef-49c3-a28d-1be0971d09d9'>CornerRadius</a></td><td style='width:75%' class='def'><p><a name="46abd053-45ef-49c3-a28d-1be0971d09d9"></a>
<b>CornerRadius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The corner radius of a <code>KimonoShapeRoundRect</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8dddf10c-bf60-4b4f-ac8f-ed7f2d8e6cbc'>NumberOfPoints</a></td><td style='width:75%' ><p><a name="8dddf10c-bf60-4b4f-ac8f-ed7f2d8e6cbc"></a>
<b>NumberOfPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The number of points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbf4a678-45f5-4813-81d7-14440cd8e832'>SkipPoints</a></td><td style='width:75%' class='def'><p><a name="dbf4a678-45f5-4813-81d7-14440cd8e832"></a>
<b>SkipPoints</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The skip points of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63f6f434-fa86-4e71-93d0-a6f45d00ceec'>DepthOffset</a></td><td style='width:75%' ><p><a name="63f6f434-fa86-4e71-93d0-a6f45d00ceec"></a>
<b>DepthOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The depth offset of a <code>KimonoShapeStar</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e0651014-c1a9-4366-a893-ea012e5e9e0d'>Text</a></td><td style='width:75%' class='def'><p><a name="e0651014-c1a9-4366-a893-ea012e5e9e0d"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text of a <code>KimonoShapeText</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a1c651ec-b806-48fb-96f4-bef25f50e140'>BaseColor</a></td><td style='width:75%' ><p><a name="a1c651ec-b806-48fb-96f4-bef25f50e140"></a>
<b>BaseColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base color of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab1e6614-a92b-49d8-875a-56f18861f5e0'>AdjustsHue</a></td><td style='width:75%' class='def'><p><a name="ab1e6614-a92b-49d8-875a-56f18861f5e0"></a>
<b>AdjustsHue</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts hue of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82f02e78-2497-4942-b1fd-1e5a88c19d9f'>HueAdjustment</a></td><td style='width:75%' ><p><a name="82f02e78-2497-4942-b1fd-1e5a88c19d9f"></a>
<b>HueAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The hue adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5585b7f2-ce6a-4141-8172-666ea5731ffa'>AdjustsSaturation</a></td><td style='width:75%' class='def'><p><a name="5585b7f2-ce6a-4141-8172-666ea5731ffa"></a>
<b>AdjustsSaturation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts saturation of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a624283f-9053-4cbb-b8dc-e2e079eb7b1f'>SaturationAdjustment</a></td><td style='width:75%' ><p><a name="a624283f-9053-4cbb-b8dc-e2e079eb7b1f"></a>
<b>SaturationAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The saturation adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f1979fa-f102-42eb-ae86-14e506ed2db0'>AdjustsBrightness</a></td><td style='width:75%' class='def'><p><a name="9f1979fa-f102-42eb-ae86-14e506ed2db0"></a>
<b>AdjustsBrightness</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts brightness of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7d25ce99-6e6e-4d22-af81-1a5612b3a139'>BrightnessAdjustment</a></td><td style='width:75%' ><p><a name="7d25ce99-6e6e-4d22-af81-1a5612b3a139"></a>
<b>BrightnessAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The brightness adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1702b9b-888e-4101-9d04-dc9b150618b7'>AdjustsAlpha</a></td><td style='width:75%' class='def'><p><a name="d1702b9b-888e-4101-9d04-dc9b150618b7"></a>
<b>AdjustsAlpha</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The adjusts alpha of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#38fd6f5c-950c-4ab1-933a-9f7c8842ccff'>AlphaAdjustment</a></td><td style='width:75%' ><p><a name="38fd6f5c-950c-4ab1-933a-9f7c8842ccff"></a>
<b>AlphaAdjustment</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The alpha adjustment of a <code>KimonoColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f5a7ea71-0927-4b00-811a-7c3b719e4b11'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="f5a7ea71-0927-4b00-811a-7c3b719e4b11"></a>
<b>HasFrame</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dea632ac-373a-4f65-99c0-df7f410ba0b0'>HasFrameBlur</a></td><td style='width:75%' ><p><a name="dea632ac-373a-4f65-99c0-df7f410ba0b0"></a>
<b>HasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ce8e7514-4dbc-4f7f-a21c-55a3e457df6b'>FrameHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="ce8e7514-4dbc-4f7f-a21c-55a3e457df6b"></a>
<b>FrameHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#82d5152f-8f54-4fec-a4c4-38db10eba6af'>FrameVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="82d5152f-8f54-4fec-a4c4-38db10eba6af"></a>
<b>FrameVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d2ca9ccd-5674-4a14-a535-12994dd6d0b5'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="d2ca9ccd-5674-4a14-a535-12994dd6d0b5"></a>
<b>HasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#df2e2624-7908-4fbd-b077-3d1d8ee9d947'>FrameShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="df2e2624-7908-4fbd-b077-3d1d8ee9d947"></a>
<b>FrameShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1d5dfc0c-a7cb-43f5-83a3-ab71cedb8dd5'>FrameShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="1d5dfc0c-a7cb-43f5-83a3-ab71cedb8dd5"></a>
<b>FrameShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5865401-f0d8-4e3e-a17a-caafa9fc1087'>FrameShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="b5865401-f0d8-4e3e-a17a-caafa9fc1087"></a>
<b>FrameShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow horizontal blur amount of a `KimonoStyle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6e67ac5-a50e-4da6-a409-d71762daadb0'>FrameShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="d6e67ac5-a50e-4da6-a409-d71762daadb0"></a>
<b>FrameShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#33f6ee60-353f-4915-8877-3f0b5c260626'>FrameShadowLinkedColor</a></td><td style='width:75%' ><p><a name="33f6ee60-353f-4915-8877-3f0b5c260626"></a>
<b>FrameShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#de1be766-f82b-41c6-bf65-4e263cd61415'>HasFill</a></td><td style='width:75%' class='def'><p><a name="de1be766-f82b-41c6-bf65-4e263cd61415"></a>
<b>HasFill</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ab2ff995-d736-43ba-948d-9596b81468db'>HasFillBlur</a></td><td style='width:75%' ><p><a name="ab2ff995-d736-43ba-948d-9596b81468db"></a>
<b>HasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0db6e183-fdf0-4c41-ab13-2fc118813d69'>FillHorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="0db6e183-fdf0-4c41-ab13-2fc118813d69"></a>
<b>FillHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6272e3c-eeff-4d25-b891-cd9f9b72763c'>FillVerticalBlurAmount</a></td><td style='width:75%' ><p><a name="f6272e3c-eeff-4d25-b891-cd9f9b72763c"></a>
<b>FillVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f48bf2fe-fc6f-4523-a10c-7576319a5429'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="f48bf2fe-fc6f-4523-a10c-7576319a5429"></a>
<b>HasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e903b222-f845-4a26-8082-18784e1fc2ea'>FillShadowHorizontalOffset</a></td><td style='width:75%' ><p><a name="e903b222-f845-4a26-8082-18784e1fc2ea"></a>
<b>FillShadowHorizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2360cfa9-392c-41d6-b219-def96fd9f0fb'>FillShadowVerticalOffset</a></td><td style='width:75%' class='def'><p><a name="2360cfa9-392c-41d6-b219-def96fd9f0fb"></a>
<b>FillShadowVerticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical offset of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc130ee8-3655-475b-b9d1-d7c141990bc6'>FillShadowHorizontalBlurAmount</a></td><td style='width:75%' ><p><a name="fc130ee8-3655-475b-b9d1-d7c141990bc6"></a>
<b>FillShadowHorizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow horizontal blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#023eb3e9-daba-4dfe-8cd2-37bc66469680'>FillShadowVerticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="023eb3e9-daba-4dfe-8cd2-37bc66469680"></a>
<b>FillShadowVerticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow vertical blur amount of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b51fcaad-b518-4335-8ee9-f381ce1c10a1'>FillShadowLinkedColor</a></td><td style='width:75%' ><p><a name="b51fcaad-b518-4335-8ee9-f381ce1c10a1"></a>
<b>FillShadowLinkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill shadow linked of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5bb57c45-2e84-4eb8-b821-c0c1af359a0b'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="5bb57c45-2e84-4eb8-b821-c0c1af359a0b"></a>
<b>FrameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the frame of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c26d03db-9659-4384-b849-bff34763f901'>FrameGradient</a></td><td style='width:75%' ><p><a name="c26d03db-9659-4384-b849-bff34763f901"></a>
<b>FrameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#af33d317-7619-49b5-befc-2d33c34b5045'>FillColor</a></td><td style='width:75%' class='def'><p><a name="af33d317-7619-49b5-befc-2d33c34b5045"></a>
<b>FillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the fill of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5219ffb0-b5e4-4fa0-95d0-a113667d1bd1'>FillGradient</a></td><td style='width:75%' ><p><a name="5219ffb0-b5e4-4fa0-95d0-a113667d1bd1"></a>
<b>FillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f33c8cb-1f10-4dd2-8911-66add1754201'>IsVerticalText</a></td><td style='width:75%' class='def'><p><a name="0f33c8cb-1f10-4dd2-8911-66add1754201"></a>
<b>IsVerticalText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The is vertical text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7b850a77-e2f9-4093-a8aa-b29cf829b5d3'>StrikeThruText</a></td><td style='width:75%' ><p><a name="7b850a77-e2f9-4093-a8aa-b29cf829b5d3"></a>
<b>StrikeThruText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The strike thru text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#570d8762-9d1c-494d-b4f4-6d9c4c1bca37'>TextScaleX</a></td><td style='width:75%' class='def'><p><a name="570d8762-9d1c-494d-b4f4-6d9c4c1bca37"></a>
<b>TextScaleX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text scale x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd0445d2-34a4-4e4c-822e-352998fbea25'>TextSize</a></td><td style='width:75%' ><p><a name="cd0445d2-34a4-4e4c-822e-352998fbea25"></a>
<b>TextSize</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The size of the text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cf733f9-9e9d-4679-a1c2-5e5bceb0b360'>TextSkewX</a></td><td style='width:75%' class='def'><p><a name="6cf733f9-9e9d-4679-a1c2-5e5bceb0b360"></a>
<b>TextSkewX</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The text skew x of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b1063c06-e91c-4554-a45c-6ec7bd60b8ae'>FontFamilyName</a></td><td style='width:75%' ><p><a name="b1063c06-e91c-4554-a45c-6ec7bd60b8ae"></a>
<b>FontFamilyName</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The name of the font family of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5e9a4847-6ede-480c-afda-480b7641e391'>UnderlineText</a></td><td style='width:75%' class='def'><p><a name="5e9a4847-6ede-480c-afda-480b7641e391"></a>
<b>UnderlineText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The underline text of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3fdb720a-5266-4198-aa8e-c0ade8a5a88a'>HasFrameJitter</a></td><td style='width:75%' ><p><a name="3fdb720a-5266-4198-aa8e-c0ade8a5a88a"></a>
<b>HasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7fd7f358-854c-4a99-9a48-ceb8cba3e4c3'>FrameJitterLength</a></td><td style='width:75%' class='def'><p><a name="7fd7f358-854c-4a99-9a48-ceb8cba3e4c3"></a>
<b>FrameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30d7d95f-3fb1-451e-ac38-b0142be1571a'>FrameJitterDeviation</a></td><td style='width:75%' ><p><a name="30d7d95f-3fb1-451e-ac38-b0142be1571a"></a>
<b>FrameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#703b1792-49f7-4dc1-890a-7ff66f9f438b'>HasFillJitter</a></td><td style='width:75%' class='def'><p><a name="703b1792-49f7-4dc1-890a-7ff66f9f438b"></a>
<b>HasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc1f03a7-e340-4e8d-b9f7-8eef87a3e163'>FillJitterLength</a></td><td style='width:75%' ><p><a name="bc1f03a7-e340-4e8d-b9f7-8eef87a3e163"></a>
<b>FillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#915328f7-73ee-4819-b424-aa796e522998'>FillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="915328f7-73ee-4819-b424-aa796e522998"></a>
<b>FillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation of a <code>KimonoStyle</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b9babb0c-ad89-4ec9-97b5-77ae70392046'>HasFrameDash</a></td><td style='width:75%' ><p><a name="b9babb0c-ad89-4ec9-97b5-77ae70392046"></a>
<b>HasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame dash of a <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="e9fce7d9-c22e-426e-b931-7b5acb3639e2"></a>
## KimonoPropertyConnection

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a connection between a given Kimono Object and a `KimonoProperty`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ee285a3e-d28c-435f-947f-cd4ead229e41'>UniqueID</a></td><td style='width:75%' ><p><a name="ee285a3e-d28c-435f-947f-cd4ead229e41"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7cad0a00-78f4-4b88-b17f-c8af2babbd04'>ConnectionPoint</a></td><td style='width:75%' class='def'><p><a name="7cad0a00-78f4-4b88-b17f-c8af2babbd04"></a></p>

<h3>ConnectionPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the point that a given <code>KimonoProperty</code> is connected to another Kimono Object.</p>

<h4>Return Value</h4>

<p>The connection point as a <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2a1a2791-7380-40d7-bc31-a68486a07cff'>ConnectedProperty</a></td><td style='width:75%' ><p><a name="2a1a2791-7380-40d7-bc31-a68486a07cff"></a></p>

<h3>ConnectedProperty</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the connected property.</p>

<h4>Return Value</h4>

<p>The connected <code>KimonoProperty</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#7c9bb14e-d923-4f30-ac0e-7fe93adc0d74'>KimonoPropertyConnection</a></td><td style='width:75%' ><p><a name="7c9bb14e-d923-4f30-ac0e-7fe93adc0d74"></a></p>

<h3>KimonoPropertyConnection ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e9fce7d9-c22e-426e-b931-7b5acb3639e2">KimonoPropertyConnection</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b98a4662-ae70-4d26-90fe-41b1ec0b908a'>KimonoPropertyConnection</a></td><td style='width:75%' class='def'><p><a name="b98a4662-ae70-4d26-90fe-41b1ec0b908a"></a></p>

<h3>KimonoPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#e9fce7d9-c22e-426e-b931-7b5acb3639e2">KimonoPropertyConnection</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="a1025ff5-a84e-4176-b95b-9efa586a8ce3"></a>
Connection point.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="33fbaf04-0f74-4625-8663-1323972fea89"></a>
Property.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#207870f2-4679-42b2-bdb0-549ab3689bdc'>Clone</a></td><td style='width:75%' ><p><a name="207870f2-4679-42b2-bdb0-549ab3689bdc"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="dddec5a0-cd1a-4020-96ac-60fa04ed8c45"></a>
##ObiScriptResult

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the result of attempting to execute an Obi Script on a `KimonoProperty`
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b3866c80-db65-4418-95d8-2ec1e94ffa18'>Successful</a></td><td style='width:75%' ><p><a name="b3866c80-db65-4418-95d8-2ec1e94ffa18"></a></p>

<h3>Successful</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the Obi Script ran successfully.</p>

<h4>Return Value</h4>

<p><code>true</code> if successful; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#db363ae4-cdf1-41f8-b93d-b363db6e860c'>ErrorMessage</a></td><td style='width:75%' class='def'><p><a name="db363ae4-cdf1-41f8-b93d-b363db6e860c"></a></p>

<h3>ErrorMessage</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the error message if the Obi Script execution failed.</p>

<h4>Return Value</h4>

<p>The error message or "" if the script ran successfully.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#dc4f1e6b-4cba-4dc1-909f-193b9f5221b9'>ObiScriptResult</a></td><td style='width:75%' ><p><a name="dc4f1e6b-4cba-4dc1-909f-193b9f5221b9"></a></p>

<h3>ObiScriptResult ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#dddec5a0-cd1a-4020-96ac-60fa04ed8c45">ObiScriptResult</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2a54eac-0e9a-410a-84fd-de48b4180aec'>ObiScriptResult</a></td><td style='width:75%' class='def'><p><a name="b2a54eac-0e9a-410a-84fd-de48b4180aec"></a></p>

<h3>ObiScriptResult (System.Boolean, System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#dddec5a0-cd1a-4020-96ac-60fa04ed8c45">ObiScriptResult</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>isSuccessful</td><td style='width:75%' ><p><a name="c7c1a3a3-6a14-49d8-aca5-c48edbcbc771"></a>
If set to <code>true</code> is successful.</p>
</td></tr><tr><td style='width:25%' class='term'>errorMessage</td><td style='width:75%' class='def'><p><a name="ccf9ab65-cf28-4f03-b27e-e39ba7231082"></a>
Error message.</p>
</td></tr></table></p>
</td></tr></table></p>


---

<a name="230a9f15-e139-4b0d-a1ca-b10ca63df4cc"></a>
## KimonoBezierPoint

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Holds the control and end point for a `KimonoShapeBezier` that define a quad section of the Bezier.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#afc4f0ad-aa5e-41f8-ac09-ba188b60721c'>ControlPoint</a></td><td style='width:75%' ><p><a name="afc4f0ad-aa5e-41f8-ac09-ba188b60721c"></a></p>

<h3>ControlPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control point.</p>

<h4>Return Value</h4>

<p>The control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c484615f-86d8-492a-a3fc-3f0f0b358331'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="c484615f-86d8-492a-a3fc-3f0f0b358331"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#2e33e25d-9390-49e9-afb1-d8f1dc9e0633'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="2e33e25d-9390-49e9-afb1-d8f1dc9e0633"></a></p>

<h3>KimonoBezierPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#230a9f15-e139-4b0d-a1ca-b10ca63df4cc">KimonoBezierPoint</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9bf8a6e2-30e3-4fa9-a9f9-cf666e159238'>KimonoBezierPoint</a></td><td style='width:75%' class='def'><p><a name="9bf8a6e2-30e3-4fa9-a9f9-cf666e159238"></a></p>

<h3>KimonoBezierPoint (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#230a9f15-e139-4b0d-a1ca-b10ca63df4cc">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlPoint</td><td style='width:75%' ><p><a name="81162cc1-f419-40dd-b0c6-bcac2f2d591d"></a>
Control point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="9efef82a-a409-44c3-9c04-713f69b2dc55"></a>
End point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#adec425c-8fd3-4423-886d-70490d07df6e'>KimonoBezierPoint</a></td><td style='width:75%' ><p><a name="adec425c-8fd3-4423-886d-70490d07df6e"></a></p>

<h3>KimonoBezierPoint (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#230a9f15-e139-4b0d-a1ca-b10ca63df4cc">KimonoBezierPoint</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>controlX</td><td style='width:75%' ><p><a name="b975260f-81c3-43cf-afda-6f774cfd77ba"></a>
Control x.</p>
</td></tr><tr><td style='width:25%' class='term'>controlY</td><td style='width:75%' class='def'><p><a name="67cb4ba0-e226-4777-a3db-93042c22416f"></a>
Control y.</p>
</td></tr><tr><td style='width:25%' class='term'>endX</td><td style='width:75%' ><p><a name="6545a45a-69de-4848-89cd-ae0e3c3cee79"></a>
End x.</p>
</td></tr><tr><td style='width:25%' class='term'>endY</td><td style='width:75%' class='def'><p><a name="6cf82533-ccba-4ac9-975f-a521fca390ef"></a>
End y.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c921fe7a-56aa-4713-9eee-1b8a03c76ed4'>Clone</a></td><td style='width:75%' class='def'><p><a name="c921fe7a-56aa-4713-9eee-1b8a03c76ed4"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="55f3615a-5284-4338-ae4d-584e9f909e1d"></a>
## KimonoBounds

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the outter bounding box for a `KimonoShape` and contains the routines required to draw the bounds and the control handles as the user edits and moves the shape.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8d6a3a95-f567-455e-97f4-a90bdb15fb8c'>Rect</a></td><td style='width:75%' ><p><a name="8d6a3a95-f567-455e-97f4-a90bdb15fb8c"></a>
<b>Rect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The base <code>SkRect</code> that holds the internal bounds of the shape.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6cdf9cbe-36c9-4683-b807-ac1997a3e187'>PreviousCenter</a></td><td style='width:75%' class='def'><p><a name="6cdf9cbe-36c9-4683-b807-ac1997a3e187"></a>
<b>PreviousCenter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous center used in scaling operations.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fdddc378-a3e2-452c-afa7-8239c82e58f9'>PreviousRect</a></td><td style='width:75%' ><p><a name="fdddc378-a3e2-452c-afa7-8239c82e58f9"></a>
<b>PreviousRect</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds the previous rect used in scaling operations.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#68f0808e-cc67-422a-908c-1c79345a8820'>State</a></td><td style='width:75%' ><p><a name="68f0808e-cc67-422a-908c-1c79345a8820"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the current edit state of the <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ed8632e-adb3-4711-bb47-25eeaadf5545'>Name</a></td><td style='width:75%' class='def'><p><a name="2ed8632e-adb3-4711-bb47-25eeaadf5545"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9eb5002-6a77-44da-91ae-892fa47ae8a2'>UniqueID</a></td><td style='width:75%' ><p><a name="a9eb5002-6a77-44da-91ae-892fa47ae8a2"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f7fb9629-6bc5-4f45-9da5-3993e55632e2'>Top</a></td><td style='width:75%' class='def'><p><a name="f7fb9629-6bc5-4f45-9da5-3993e55632e2"></a></p>

<h3>Top</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top.</p>

<h4>Return Value</h4>

<p>The top coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e96715a4-1ba4-4753-ba8a-f1f126171893'>Left</a></td><td style='width:75%' ><p><a name="e96715a4-1ba4-4753-ba8a-f1f126171893"></a></p>

<h3>Left</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left.</p>

<h4>Return Value</h4>

<p>The left coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4ac636e-b5ae-46ba-8345-17045d2a19c2'>Bottom</a></td><td style='width:75%' class='def'><p><a name="a4ac636e-b5ae-46ba-8345-17045d2a19c2"></a></p>

<h3>Bottom</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom.</p>

<h4>Return Value</h4>

<p>The bottom coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10f27b4b-991c-4650-84b5-05b75f1b6bae'>Right</a></td><td style='width:75%' ><p><a name="10f27b4b-991c-4650-84b5-05b75f1b6bae"></a></p>

<h3>Right</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right.</p>

<h4>Return Value</h4>

<p>The right coord location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9111aa78-5678-4553-bfe4-1c192c0cc097'>Width</a></td><td style='width:75%' class='def'><p><a name="9111aa78-5678-4553-bfe4-1c192c0cc097"></a></p>

<h3>Width</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width.</p>

<h4>Return Value</h4>

<p>The width of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dc069d8d-0c75-4d54-afea-809d699e4c4c'>Height</a></td><td style='width:75%' ><p><a name="dc069d8d-0c75-4d54-afea-809d699e4c4c"></a></p>

<h3>Height</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height.</p>

<h4>Return Value</h4>

<p>The height of the shape's bounding box.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2dd1b386-feb1-4d59-b835-650e2bc14c1a'>HorizontalCenter</a></td><td style='width:75%' class='def'><p><a name="2dd1b386-feb1-4d59-b835-650e2bc14c1a"></a></p>

<h3>HorizontalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the horizontal center.</p>

<h4>Return Value</h4>

<p>The horizontal center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7e2218c6-6cd6-4e85-b03b-d37279fc8462'>VerticalCenter</a></td><td style='width:75%' ><p><a name="7e2218c6-6cd6-4e85-b03b-d37279fc8462"></a></p>

<h3>VerticalCenter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the vertical center.</p>

<h4>Return Value</h4>

<p>The vertical center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd6a2b47-8724-4e43-80b1-e823c77c2842'>Center</a></td><td style='width:75%' class='def'><p><a name="cd6a2b47-8724-4e43-80b1-e823c77c2842"></a></p>

<h3>Center</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the center.</p>

<h4>Return Value</h4>

<p>The center.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#802f853d-a284-4704-9bf6-8a1e2c378f11'>RotationDegrees</a></td><td style='width:75%' ><p><a name="802f853d-a284-4704-9bf6-8a1e2c378f11"></a></p>

<h3>RotationDegrees</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the rotation degrees.</p>

<h4>Return Value</h4>

<p>The rotation degrees.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6fc417a7-bb34-4297-8d39-fb924e128ac5'>TopLeftHandle</a></td><td style='width:75%' class='def'><p><a name="6fc417a7-bb34-4297-8d39-fb924e128ac5"></a></p>

<h3>TopLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top left handle.</p>

<h4>Return Value</h4>

<p>The top left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b3902afb-7f9c-4a90-9fd1-24c034306e1b'>TopHandle</a></td><td style='width:75%' ><p><a name="b3902afb-7f9c-4a90-9fd1-24c034306e1b"></a></p>

<h3>TopHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top handle.</p>

<h4>Return Value</h4>

<p>The top handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#599c8379-41c9-48f9-bbb5-bc40fbe54ed3'>TopRightHandle</a></td><td style='width:75%' class='def'><p><a name="599c8379-41c9-48f9-bbb5-bc40fbe54ed3"></a></p>

<h3>TopRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the top right handle.</p>

<h4>Return Value</h4>

<p>The top right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fda7bdba-fcc6-4c2b-93f2-df2b2b04b2f5'>RightHandle</a></td><td style='width:75%' ><p><a name="fda7bdba-fcc6-4c2b-93f2-df2b2b04b2f5"></a></p>

<h3>RightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the right handle.</p>

<h4>Return Value</h4>

<p>The right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a621ce9f-faa7-4c0a-95ac-ab63f3e29bf8'>BottomRightHandle</a></td><td style='width:75%' class='def'><p><a name="a621ce9f-faa7-4c0a-95ac-ab63f3e29bf8"></a></p>

<h3>BottomRightHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom right handle.</p>

<h4>Return Value</h4>

<p>The bottom right handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c2e563d-359e-42d1-a532-19a30ee68da7'>BottomHandle</a></td><td style='width:75%' ><p><a name="1c2e563d-359e-42d1-a532-19a30ee68da7"></a></p>

<h3>BottomHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom handle.</p>

<h4>Return Value</h4>

<p>The bottom handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c889b51-711f-42f6-913c-676e726b9e83'>BottomLeftHandle</a></td><td style='width:75%' class='def'><p><a name="1c889b51-711f-42f6-913c-676e726b9e83"></a></p>

<h3>BottomLeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the bottom left handle.</p>

<h4>Return Value</h4>

<p>The bottom left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35b4f5d0-9418-4b0d-93d2-580fd611e139'>LeftHandle</a></td><td style='width:75%' ><p><a name="35b4f5d0-9418-4b0d-93d2-580fd611e139"></a></p>

<h3>LeftHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the left handle.</p>

<h4>Return Value</h4>

<p>The left handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3c418345-0e8d-4feb-bc3f-a0d335b15900'>HitOffset</a></td><td style='width:75%' class='def'><p><a name="3c418345-0e8d-4feb-bc3f-a0d335b15900"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e8825de3-f93b-4a82-835c-20212be38c4c'>HitHandle</a></td><td style='width:75%' ><p><a name="e8825de3-f93b-4a82-835c-20212be38c4c"></a></p>

<h3>HitHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit handle.</p>

<h4>Return Value</h4>

<p>The hit handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#4e0647b7-8fe0-484c-8c80-bbb3f7c8815d'>KimonoBounds</a></td><td style='width:75%' ><p><a name="4e0647b7-8fe0-484c-8c80-bbb3f7c8815d"></a></p>

<h3>KimonoBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#55f3615a-5284-4338-ae4d-584e9f909e1d">KimonoBounds</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9a159b58-4810-4d20-b503-2b43d326d88b'>KimonoBounds</a></td><td style='width:75%' class='def'><p><a name="9a159b58-4810-4d20-b503-2b43d326d88b"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#55f3615a-5284-4338-ae4d-584e9f909e1d">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="b0835e6e-d62c-4d63-8237-df1445639cf1"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="c2d93213-d4ca-436f-b977-931f971902ea"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="2e747257-1206-496e-8f21-31054306ccc3"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="261a4050-fdd5-4bd5-830c-19a35a8aed2f"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3294705e-70fe-4a2a-a10e-0c87ca76b9fb'>KimonoBounds</a></td><td style='width:75%' ><p><a name="3294705e-70fe-4a2a-a10e-0c87ca76b9fb"></a></p>

<h3>KimonoBounds (System.Single, System.Single, System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#55f3615a-5284-4338-ae4d-584e9f909e1d">KimonoBounds</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="7cc21bda-ed04-4694-871a-80f4468a7a8b"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="e30bce88-57af-47d6-8011-e283424621bf"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="b2be6244-4a39-4fcd-a11a-3b3a7c323170"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="24aad198-991f-4590-9ca3-15bc9f5d6379"></a>
Bottom.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="5a4cc1e6-d9b0-49ac-bd33-a85be8ef33e9"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e63ab392-574d-4971-aec3-057a416b77e1'>SavePreviousBounds</a></td><td style='width:75%' class='def'><p><a name="e63ab392-574d-4971-aec3-057a416b77e1"></a></p>

<h3>SavePreviousBounds ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Saves the previous bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e03f2bb9-26b4-45ea-9b9c-782aaa992d51'>ValueBetween</a></td><td style='width:75%' ><p><a name="e03f2bb9-26b4-45ea-9b9c-782aaa992d51"></a></p>

<h3>ValueBetween (System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Checks to see if the given value is between the two given points.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="1b4f06b4-aeaf-4085-a67b-5412a177c8ab"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>a</td><td style='width:75%' class='def'><p><a name="de0c437d-00df-4e1f-b0c3-3c45d652253d"></a>
The alpha component.</p>
</td></tr><tr><td style='width:25%' class='term'>b</td><td style='width:75%' ><p><a name="a34c9a35-af9e-4e60-a23c-5adc6b68d9dd"></a>
The blue component.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>Boolean</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fbcb5fb8-ea4e-45d7-b33f-1e2c8b4e618d'>AddHandles</a></td><td style='width:75%' class='def'><p><a name="fbcb5fb8-ea4e-45d7-b33f-1e2c8b4e618d"></a></p>

<h3>AddHandles (KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the control handles to the bounds</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ebc649f-1154-41f4-80e9-0bf4ec09a3d8'>RemoveHandles</a></td><td style='width:75%' ><p><a name="8ebc649f-1154-41f4-80e9-0bf4ec09a3d8"></a></p>

<h3>RemoveHandles ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the control handles from the bounds.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c169259e-60cd-41b7-a31e-2b1e7e0bfaca'>BoundsChanged</a></td><td style='width:75%' class='def'><p><a name="c169259e-60cd-41b7-a31e-2b1e7e0bfaca"></a></p>

<h3>BoundsChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates the location of the edit handles when the bounds has been relocated or resized.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#65cd71df-03e5-4cbc-bc37-b4259ccf45e3'>Draw</a></td><td style='width:75%' ><p><a name="65cd71df-03e5-4cbc-bc37-b4259ccf45e3"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bounding box and its edit handles into the given canvas</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="27f79a30-7333-4eda-88bd-fa70ce0fdbf3"></a>
Canvas.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0f332310-6ffc-4e09-91d3-0225b03f1280'>Select</a></td><td style='width:75%' class='def'><p><a name="0f332310-6ffc-4e09-91d3-0225b03f1280"></a></p>

<h3>Select ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Puts the <code>KimonoShape</code> into the edit mode and creates the edit handles as required.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#857d62cb-7803-4d11-8e64-0227c1885191'>PlaceUnderConstruction</a></td><td style='width:75%' ><p><a name="857d62cb-7803-4d11-8e64-0227c1885191"></a></p>

<h3>PlaceUnderConstruction (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Places the bounds under construction.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>needsHandles</td><td style='width:75%' ><p><a name="999749ca-ea4a-4cd1-9566-a82f62611fdb"></a>
If set to <code>true</code> needs handles.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93a847e6-c3a0-4d88-8153-8455d498bf4f'>StartGrouping</a></td><td style='width:75%' class='def'><p><a name="93a847e6-c3a0-4d88-8153-8455d498bf4f"></a></p>

<h3>StartGrouping ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Starts the bounds grouping.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d17c6166-f3d3-4f2a-bb91-db1b51f85ca9'>Unselect</a></td><td style='width:75%' ><p><a name="d17c6166-f3d3-4f2a-bb91-db1b51f85ca9"></a></p>

<h3>Unselect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Unselects the <code>KimonoShape</code> as the current edit target and removes any edit handles.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#774790c4-0619-4afe-a4d7-185ec6c64905'>ChangeBounds</a></td><td style='width:75%' class='def'><p><a name="774790c4-0619-4afe-a4d7-185ec6c64905"></a></p>

<h3>ChangeBounds (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Changes the bounds to match the given values.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>left</td><td style='width:75%' ><p><a name="4e1d2b43-faa3-4099-91de-b8d972ca9abc"></a>
Left.</p>
</td></tr><tr><td style='width:25%' class='term'>top</td><td style='width:75%' class='def'><p><a name="db6c94e6-63fe-4751-a847-d251f38f9049"></a>
Top.</p>
</td></tr><tr><td style='width:25%' class='term'>right</td><td style='width:75%' ><p><a name="64328726-b4d3-4e43-841d-5b118e8dc8ff"></a>
Right.</p>
</td></tr><tr><td style='width:25%' class='term'>bottom</td><td style='width:75%' class='def'><p><a name="50e4866e-55da-4276-8121-b05c2ba29c57"></a>
Bottom.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2714bf3f-88fa-4415-a3fb-d1a92e1aeb2e'>GrowBounds</a></td><td style='width:75%' ><p><a name="2714bf3f-88fa-4415-a3fb-d1a92e1aeb2e"></a></p>

<h3>GrowBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adjusts the size of the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d3c2ef96-c2dd-4a2b-9574-699631384117"></a>
The new size as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b5328bca-5f07-438d-81de-2f278cb9eec9'>MoveBounds</a></td><td style='width:75%' class='def'><p><a name="b5328bca-5f07-438d-81de-2f278cb9eec9"></a></p>

<h3>MoveBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the bounds to the given point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d408f018-059a-4673-9b8e-f236bfcde37c"></a>
The new top, left location as a <code>SKPoint</code>.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#25346e5c-de2d-4178-bfa4-4a00c9a0af73'>DragBounds</a></td><td style='width:75%' ><p><a name="25346e5c-de2d-4178-bfa4-4a00c9a0af73"></a></p>

<h3>DragBounds (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the bounds.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ec9a07ba-4ba8-44b3-9456-fbe46e4a3175"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#228665d9-ad4a-4cbc-85b6-4ded7b92d114'>PointInBound</a></td><td style='width:75%' class='def'><p><a name="228665d9-ad4a-4cbc-85b6-4ded7b92d114"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="3222b49f-1d51-48b2-9a35-879586511713"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#63bd6139-080d-4f62-8919-eee3fe90a3f7'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="63bd6139-080d-4f62-8919-eee3fe90a3f7"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23e20545-e4e9-4cc7-8ee0-b210d831524e'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="23e20545-e4e9-4cc7-8ee0-b210d831524e"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ff55df3-efaf-4985-99bb-dc5fc0eb9f16'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="2ff55df3-efaf-4985-99bb-dc5fc0eb9f16"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#601925e3-725f-46c8-8b60-d76ae39c2b25'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="601925e3-725f-46c8-8b60-d76ae39c2b25"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f61f1ab6-01d3-485a-b864-a8c3fbb181c2"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d4df0ded-b1cd-4cc4-b761-302884e0ead2'>ToCode</a></td><td style='width:75%' ><p><a name="d4df0ded-b1cd-4cc4-b761-302884e0ead2"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="bde9e5c8-3765-4e13-8efa-7b35dc7c20f4"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="72b8b3de-e471-48e2-bd12-d757886dca44"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0b57006f-e409-4dd9-b0b6-874a0e23f350"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ff7f7dc0-3a7d-414e-af56-9d100fb7a4b1'>Clone</a></td><td style='width:75%' class='def'><p><a name="ff7f7dc0-3a7d-414e-af56-9d100fb7a4b1"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="141c5d64-7afe-45b5-93f7-db847d5285ec"></a>
## KimonoHandle

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines an edit handle that the user manipulates to edit the bounds of a `KimonoShape` or the control points of a Bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#019ef146-15d1-4d37-bdd7-d79882c40fe5'>DrawWidth</a></td><td style='width:75%' ><p><a name="019ef146-15d1-4d37-bdd7-d79882c40fe5"></a>
<b>DrawWidth</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The width of the drag handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#483d4997-9219-4418-9696-bd1d4f8665bc'>DrawOffset</a></td><td style='width:75%' class='def'><p><a name="483d4997-9219-4418-9696-bd1d4f8665bc"></a>
<b>DrawOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The draw offset of the drag handle.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e7eebd87-7b44-411c-bc56-0019661a18db'>Index</a></td><td style='width:75%' ><p><a name="e7eebd87-7b44-411c-bc56-0019661a18db"></a></p>

<h3>Index</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the index.</p>

<h4>Return Value</h4>

<p>The index.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#562ca290-4843-40e3-8a45-4e8abc8302da'>HandleType</a></td><td style='width:75%' class='def'><p><a name="562ca290-4843-40e3-8a45-4e8abc8302da"></a></p>

<h3>HandleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the handle.</p>

<h4>Return Value</h4>

<p>The type of the handle as a <code>KimonoHandleType</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2d8273a9-d0ac-4bb3-be4f-7513616237f3'>UniqueID</a></td><td style='width:75%' ><p><a name="2d8273a9-d0ac-4bb3-be4f-7513616237f3"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d77fce6a-2f9a-4d4a-8e78-9bae9f23a7d3'>State</a></td><td style='width:75%' class='def'><p><a name="d77fce6a-2f9a-4d4a-8e78-9bae9f23a7d3"></a></p>

<h3>State</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the edit state of the <code>KimonoHandle</code>.</p>

<h4>Return Value</h4>

<p>The state as a <code>KimonoShapeState</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f8c3e585-cdc7-4a72-9166-fc84202dfc28'>X</a></td><td style='width:75%' ><p><a name="f8c3e585-cdc7-4a72-9166-fc84202dfc28"></a></p>

<h3>X</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the x value.</p>

<h4>Return Value</h4>

<p>The x coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#724aff77-e1dd-4e98-9c06-a41cf95f7e44'>Y</a></td><td style='width:75%' class='def'><p><a name="724aff77-e1dd-4e98-9c06-a41cf95f7e44"></a></p>

<h3>Y</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the y value.</p>

<h4>Return Value</h4>

<p>The y coord of the handle's top-left location.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40b8a450-9021-4066-9ed9-c9d4db87f3ab'>Rect</a></td><td style='width:75%' ><p><a name="40b8a450-9021-4066-9ed9-c9d4db87f3ab"></a></p>

<h3>Rect</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the rect.</p>

<h4>Return Value</h4>

<p>The rect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7e1a44a-927c-42f7-a6b9-28bce7db8ef6'>Constraint</a></td><td style='width:75%' class='def'><p><a name="c7e1a44a-927c-42f7-a6b9-28bce7db8ef6"></a></p>

<h3>Constraint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the edit constraint.</p>

<h4>Return Value</h4>

<p>The edit constraint as a <code>KimonoHandleConstraint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5a695bae-f003-41d4-8db3-91a9909b5742'>HitOffset</a></td><td style='width:75%' ><p><a name="5a695bae-f003-41d4-8db3-91a9909b5742"></a></p>

<h3>HitOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the hit offset.</p>

<h4>Return Value</h4>

<p>The hit offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d63eb04-8c4c-4b5d-9254-b388bff81870'>Color</a></td><td style='width:75%' class='def'><p><a name="8d63eb04-8c4c-4b5d-9254-b388bff81870"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, this color will be used.</p>

<h4>Return Value</h4>

<p>The <code>SKColor</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c2121d83-6315-4135-8fd2-412070cd136b'>LinkedColor</a></td><td style='width:75%' ><p><a name="c2121d83-6315-4135-8fd2-412070cd136b"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color that this handle represents in a gradient. If the <code>LinkedColor</code> property is <code>null</code>, the <code>Color</code> property will  be used instead.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0e36b3d4-e190-4d87-a956-c5b53a86ef2d'>RepresentedColor</a></td><td style='width:75%' class='def'><p><a name="0e36b3d4-e190-4d87-a956-c5b53a86ef2d"></a></p>

<h3>RepresentedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color that this handle represents.</p>

<h4>Return Value</h4>

<p>The color as a <code>SKColor</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#43289f5c-3705-45f4-a51b-e38eb8167e68'>KimonoHandle</a></td><td style='width:75%' ><p><a name="43289f5c-3705-45f4-a51b-e38eb8167e68"></a></p>

<h3>KimonoHandle (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#141c5d64-7afe-45b5-93f7-db847d5285ec">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="c0c03fdd-3314-4918-b9e5-1c8f3556cf33"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="5969d204-b7da-44cb-b011-bde9d5396006"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d10fe444-869a-493f-8a1e-883899ccb8c7'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="d10fe444-869a-493f-8a1e-883899ccb8c7"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#141c5d64-7afe-45b5-93f7-db847d5285ec">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="156ce8db-e6a0-4de9-a03b-4361d31b4714"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="ce62442d-4d46-4775-b6e2-ede57cc6102c"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' ><p><a name="9ccb893e-d1d6-4d6f-aabc-4817c1e7f2c2"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bff60065-1936-43ce-8202-fdf7db424af1'>KimonoHandle</a></td><td style='width:75%' ><p><a name="bff60065-1936-43ce-8202-fdf7db424af1"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#141c5d64-7afe-45b5-93f7-db847d5285ec">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="9bbb11ee-7d46-483d-bef6-f437a6bd3452"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="74ae53e6-81b1-43c6-9bee-95da5ba06443"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="86a93ed0-3918-4971-9575-7f8e9bc30df3"></a>
Constraint.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b4439af-70f9-4b91-938d-a32255f9d4a6'>KimonoHandle</a></td><td style='width:75%' class='def'><p><a name="2b4439af-70f9-4b91-938d-a32255f9d4a6"></a></p>

<h3>KimonoHandle (System.Single, System.Single, KimonoCore.KimonoHandleConstraint, KimonoCore.KimonoShapeState)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#141c5d64-7afe-45b5-93f7-db847d5285ec">KimonoHandle</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="d2f90bcd-4c1f-4b5f-bb2b-53b26396d2ce"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="68faf395-8ef6-4fb7-8e0b-4b4cd2850677"></a>
The y coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>constraint</td><td style='width:75%' ><p><a name="9805b454-4cba-49de-815e-1b5ea812cdb4"></a>
Constraint.</p>
</td></tr><tr><td style='width:25%' class='term'>state</td><td style='width:75%' class='def'><p><a name="b32121d5-aea6-4763-adc2-7708c6188a88"></a>
State.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cdec49ff-39ee-4f09-8384-4c2738269234'>Draw</a></td><td style='width:75%' ><p><a name="cdec49ff-39ee-4f09-8384-4c2738269234"></a></p>

<h3>Draw (SkiaSharp.SKCanvas)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the hanled into the given Skia canvas.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>canvas</td><td style='width:75%' ><p><a name="a76d90fb-2aaa-4c21-8827-517851cee2ae"></a>
The <code>SKCanvas</code> to draw the hanled into.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The draw.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#376f0b6c-d2f1-4b5d-99c8-ab8e5f13fca1'>MoveTo</a></td><td style='width:75%' class='def'><p><a name="376f0b6c-d2f1-4b5d-99c8-ab8e5f13fca1"></a></p>

<h3>MoveTo (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Moves the handle to the given coordinates.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>x</td><td style='width:75%' ><p><a name="0f20a4fa-e472-48eb-8bb3-5afef8513a38"></a>
The x coordinate.</p>
</td></tr><tr><td style='width:25%' class='term'>y</td><td style='width:75%' class='def'><p><a name="ac7e383f-95f3-47a3-82c8-5ac6b8976f51"></a>
The y coordinate.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9cad2018-0fb3-47aa-bc36-c3c70f8e09a4'>PointInBound</a></td><td style='width:75%' ><p><a name="9cad2018-0fb3-47aa-bc36-c3c70f8e09a4"></a></p>

<h3>PointInBound (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Test to see if the given point is inside of the current bounds</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="5262b3a8-833b-482c-bd3b-50047b800ddd"></a>
Point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p><code>true</code>, if in bounds, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d78b86a-01f1-431e-a4f4-03876b77da9f'>DragHandle</a></td><td style='width:75%' class='def'><p><a name="3d78b86a-01f1-431e-a4f4-03876b77da9f"></a></p>

<h3>DragHandle (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Drags the handle.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="d8c6e291-fbb3-41ff-bee9-b8f16529c4f7"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c67b7a6-a00e-4a01-99a3-46f9bceb01ad'>ToPoint</a></td><td style='width:75%' ><p><a name="9c67b7a6-a00e-4a01-99a3-46f9bceb01ad"></a></p>

<h3>ToPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoHandle</code> to a Skia Point.</p>

<h4>Returns</h4>

<p>The <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c766a175-ae74-4f71-9338-cbe6091472ca'>Clone</a></td><td style='width:75%' class='def'><p><a name="c766a175-ae74-4f71-9338-cbe6091472ca"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b73cb4bc-6725-4f7b-a87e-e3529e2602fe'>RaiseMoved</a></td><td style='width:75%' ><p><a name="b73cb4bc-6725-4f7b-a87e-e3529e2602fe"></a></p>

<h3>RaiseMoved (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the moved event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="ff6add4f-98e6-47c4-9abd-c39b44c2545b"></a>
Point.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#df64b806-c682-4d63-9780-610be9053b49'>Moved</a></td><td style='width:75%' ><p><a name="df64b806-c682-4d63-9780-610be9053b49"></a></p>

<h3>Moved</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when moved.</p>
</td></tr></table></p>


---

<a name="ddcfbf9a-5844-49ad-b99b-e6064d792f6d"></a>
## KimonoHandleConstraint

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Constrains the movement of a `KimonoHandle` when it is being moved by the user.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aa36ecc8-2747-47c1-ae5d-df136d0753df'>None</a></td><td style='width:75%' ><p><a name="aa36ecc8-2747-47c1-ae5d-df136d0753df"></a>
<b>None</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>No movement constraint.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54927fe0-c1e1-4aac-9937-5a068ef2017b'>Horizontal</a></td><td style='width:75%' class='def'><p><a name="54927fe0-c1e1-4aac-9937-5a068ef2017b"></a>
<b>Horizontal</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved horizontally.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5cc388ad-f953-4cab-bcbb-956a4faab852'>Vertical</a></td><td style='width:75%' ><p><a name="5cc388ad-f953-4cab-bcbb-956a4faab852"></a>
<b>Vertical</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle can only be moved vertically.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10a44d9f-ebeb-458e-a0ac-01c09872b969'>Locked</a></td><td style='width:75%' class='def'><p><a name="10a44d9f-ebeb-458e-a0ac-01c09872b969"></a>
<b>Locked</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The handle is locked in place and cannot be moved.</p>
</td></tr></table></p>


---

<a name="56cbbbf7-82bf-4f53-958a-b26f0cc00b92"></a>
## KimonoHandleType

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the type of a `KimonoHandle` that can be used as a general purpose control point to adjust the bounds of a `KimonoShape` or as a point for a vector or bezier object.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8bd85fca-c598-40b7-b5a7-de054dda523a'>ControlPoint</a></td><td style='width:75%' ><p><a name="8bd85fca-c598-40b7-b5a7-de054dda523a"></a>
<b>ControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A general purpose handle for a shape's bound or a control point on a  vector or bezier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6f823456-a739-4941-892b-d1562aff31de'>GradientColor</a></td><td style='width:75%' class='def'><p><a name="6f823456-a739-4941-892b-d1562aff31de"></a>
<b>GradientColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines a color inside of a gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2bd08552-7adc-4bc8-81b6-2aa29408dcb2'>GradientPosition</a></td><td style='width:75%' ><p><a name="2bd08552-7adc-4bc8-81b6-2aa29408dcb2"></a>
<b>GradientPosition</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the position of a gradient in a shape object.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bc876631-b9e6-4ba3-b426-4ffe0fc7fd0e'>BezierControlPoint</a></td><td style='width:75%' class='def'><p><a name="bc876631-b9e6-4ba3-b426-4ffe0fc7fd0e"></a>
<b>BezierControlPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Defines the control point for a <code>KimonoShapeBezier</code> end point used to adjust the curve of a bezier quad section.</p>
</td></tr></table></p>


---

<a name="af98bc95-c176-46d5-9980-48a7908ff039"></a>
## KimonoBlur

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a blur effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#073c16f4-f325-4b3b-a180-0d8224d7605b'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="073c16f4-f325-4b3b-a180-0d8224d7605b"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6dd40f5f-de10-4cb8-b997-5ecf6135f137'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="6dd40f5f-de10-4cb8-b997-5ecf6135f137"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#0e822f49-e746-4a50-a2e6-ce1ca9c7dac0'>Name</a></td><td style='width:75%' ><p><a name="0e822f49-e746-4a50-a2e6-ce1ca9c7dac0"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9f5b133a-528f-4cec-af68-12aca08fd733'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="9f5b133a-528f-4cec-af68-12aca08fd733"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#85b2a09d-55b5-4d76-b198-25f77934bada'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="85b2a09d-55b5-4d76-b198-25f77934bada"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b6b2ec18-821e-4274-a546-45f857e75f08'>BlurFilter</a></td><td style='width:75%' class='def'><p><a name="b6b2ec18-821e-4274-a546-45f857e75f08"></a></p>

<h3>BlurFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the blur filter represented by this blur effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8f5063a4-4eaa-43c3-9526-73350db2c600'>KimonoBlur</a></td><td style='width:75%' ><p><a name="8f5063a4-4eaa-43c3-9526-73350db2c600"></a></p>

<h3>KimonoBlur ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af98bc95-c176-46d5-9980-48a7908ff039">KimonoBlur</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71e80a19-9c07-46e0-b734-e7c81bae517f'>KimonoBlur</a></td><td style='width:75%' class='def'><p><a name="71e80a19-9c07-46e0-b734-e7c81bae517f"></a></p>

<h3>KimonoBlur (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#af98bc95-c176-46d5-9980-48a7908ff039">KimonoBlur</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' ><p><a name="20aba469-1e36-4c6b-87fe-7de9b5c863eb"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="608b2af7-bddc-42c1-b4ee-5842a02d6ca0"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c314b70-23ed-48bc-8f81-5c2be3a630fe'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="7c314b70-23ed-48bc-8f81-5c2be3a630fe"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03f1ada9-7278-46d4-80d8-a31642660dcd'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="03f1ada9-7278-46d4-80d8-a31642660dcd"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="69c72c77-6f19-4256-aff8-04041ddd0db4"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1ffe5c4e-db36-463a-8c9d-98021639c54d'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="1ffe5c4e-db36-463a-8c9d-98021639c54d"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the Skia library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c1825457-e5ca-456a-b3e1-907118207a62'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="c1825457-e5ca-456a-b3e1-907118207a62"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this blur effect to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The blur as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4eff8c18-6abb-4bcb-a2cc-d9455b3fe90a'>ToCode</a></td><td style='width:75%' ><p><a name="4eff8c18-6abb-4bcb-a2cc-d9455b3fe90a"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="0a87eb79-0e48-4c02-ad0a-26c491206ca3"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="229a6518-cb80-4ddb-8841-118fc2883dd6"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="55ed5006-67d8-49d7-8616-391a742f8ff4"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b2e90cb-bcfd-489e-9bc7-cac62193fce2'>Clone</a></td><td style='width:75%' class='def'><p><a name="2b2e90cb-bcfd-489e-9bc7-cac62193fce2"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23fafb75-cdf2-409b-b3b7-5dacba311937'>RaiseBlurModified</a></td><td style='width:75%' ><p><a name="23fafb75-cdf2-409b-b3b7-5dacba311937"></a></p>

<h3>RaiseBlurModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the blur modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#5b30b97b-0c3e-430c-9f1a-c9f7e5992a83'>BlurModified</a></td><td style='width:75%' ><p><a name="5b30b97b-0c3e-430c-9f1a-c9f7e5992a83"></a></p>

<h3>BlurModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the blur is modified.</p>
</td></tr></table></p>


---

<a name="8346526c-9b9a-4b49-ad94-95ca9b77aef7"></a>
## KimonoShadow

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a shadow effect that can be attached to the fill or the frame of a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#9069d818-60b7-4ff2-b902-777c72060612'>_horizontalOffset</a></td><td style='width:75%' ><p><a name="9069d818-60b7-4ff2-b902-777c72060612"></a>
<b>_horizontalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7162b53-8e35-45c4-ae43-481f6b7ad3fc'>_verticalOffset</a></td><td style='width:75%' class='def'><p><a name="e7162b53-8e35-45c4-ae43-481f6b7ad3fc"></a>
<b>_verticalOffset</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3292f051-de1f-4248-acd5-8973f3881d3c'>_horizontalBlurAmount</a></td><td style='width:75%' ><p><a name="3292f051-de1f-4248-acd5-8973f3881d3c"></a>
<b>_horizontalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4c7913c0-b93c-4b2b-8686-0b2127bb9861'>_verticalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="4c7913c0-b93c-4b2b-8686-0b2127bb9861"></a>
<b>_verticalBlurAmount</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2b6c7b44-da34-426a-ad53-7d8e9a5efc07'>_color</a></td><td style='width:75%' ><p><a name="2b6c7b44-da34-426a-ad53-7d8e9a5efc07"></a>
<b>_color</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The color of the shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c88becc1-7a47-4ef9-850e-9dc5034d6060'>_linkedColor</a></td><td style='width:75%' class='def'><p><a name="c88becc1-7a47-4ef9-850e-9dc5034d6060"></a>
<b>_linkedColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A linked <code>KimonoColor</code> to use as the shadow color.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d41ffc8a-c7c1-45ed-a3d9-c08a65234566'>Name</a></td><td style='width:75%' ><p><a name="d41ffc8a-c7c1-45ed-a3d9-c08a65234566"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#03478b5b-4beb-478f-b816-b5eeea4ee8a5'>HorizontalOffset</a></td><td style='width:75%' class='def'><p><a name="03478b5b-4beb-478f-b816-b5eeea4ee8a5"></a></p>

<h3>HorizontalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal offset.</p>

<h4>Return Value</h4>

<p>The horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#68280e8d-6097-4c84-a8a4-bcf24d37034c'>VerticalOffset</a></td><td style='width:75%' ><p><a name="68280e8d-6097-4c84-a8a4-bcf24d37034c"></a></p>

<h3>VerticalOffset</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical offset.</p>

<h4>Return Value</h4>

<p>The vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#810d772f-4c56-4fe8-b38f-c806ded44416'>HorizontalBlurAmount</a></td><td style='width:75%' class='def'><p><a name="810d772f-4c56-4fe8-b38f-c806ded44416"></a></p>

<h3>HorizontalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the horizontal blur amount.</p>

<h4>Return Value</h4>

<p>The horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fc2962a2-e3a3-4913-b4b2-4c1672f4fd63'>VerticalBlurAmount</a></td><td style='width:75%' ><p><a name="fc2962a2-e3a3-4913-b4b2-4c1672f4fd63"></a></p>

<h3>VerticalBlurAmount</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the vertical blur amount.</p>

<h4>Return Value</h4>

<p>The vertical blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7c1e8d77-bd3d-433a-a68b-98f767d5f831'>Color</a></td><td style='width:75%' class='def'><p><a name="7c1e8d77-bd3d-433a-a68b-98f767d5f831"></a></p>

<h3>Color</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eb599e50-ab08-4b19-a116-3155985f7a96'>LinkedColor</a></td><td style='width:75%' ><p><a name="eb599e50-ab08-4b19-a116-3155985f7a96"></a></p>

<h3>LinkedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the linked.</p>

<h4>Return Value</h4>

<p>The color of the linked.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#45d06839-9972-4c14-b012-ebe4f6b82b12'>ShadowColor</a></td><td style='width:75%' class='def'><p><a name="45d06839-9972-4c14-b012-ebe4f6b82b12"></a></p>

<h3>ShadowColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the shadow.</p>

<h4>Return Value</h4>

<p>The color of the shadow as a <code>SKColor</code>.</p>

<h4>Remarks</h4>

<p>Returns either the custom color attached to this shadow or a linked color if it is being used.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eeb7ec4b-b3ba-42ca-875b-9da1c180a061'>ShadowFilter</a></td><td style='width:75%' ><p><a name="eeb7ec4b-b3ba-42ca-875b-9da1c180a061"></a></p>

<h3>ShadowFilter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the shadoe filter represented by this shadow effect.</p>

<h4>Return Value</h4>

<p>The <code>SKImageFilter</code> for the blur filter.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#29542fc3-5b37-4abf-a613-376db4c2b270'>KimonoShadow</a></td><td style='width:75%' ><p><a name="29542fc3-5b37-4abf-a613-376db4c2b270"></a></p>

<h3>KimonoShadow ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8346526c-9b9a-4b49-ad94-95ca9b77aef7">KimonoShadow</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8cb0e7ca-0a15-4693-8caf-3041da9b5167'>KimonoShadow</a></td><td style='width:75%' class='def'><p><a name="8cb0e7ca-0a15-4693-8caf-3041da9b5167"></a></p>

<h3>KimonoShadow (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#8346526c-9b9a-4b49-ad94-95ca9b77aef7">KimonoShadow</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>horizontalOffset</td><td style='width:75%' ><p><a name="1ba1ab50-ce20-471e-8e93-8ba05fbec0e6"></a>
Horizontal offset.</p>
</td></tr><tr><td style='width:25%' class='term'>horizontalBlurAmount</td><td style='width:75%' class='def'><p><a name="b7ac1db1-8739-4c17-a776-824c1881adea"></a>
Horizontal blur amount.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalOffset</td><td style='width:75%' ><p><a name="a8f46755-4c60-42d4-93b8-93f405babb85"></a>
Vertical offset.</p>
</td></tr><tr><td style='width:25%' class='term'>verticalBlurAmount</td><td style='width:75%' class='def'><p><a name="eb670cfc-6bb0-4d10-9733-0a0ba746c746"></a>
Vertical blur amount.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7ac2bdca-65d6-406a-b169-afe6d56f1554'>HandleLinkedColorChanged</a></td><td style='width:75%' ><p><a name="7ac2bdca-65d6-406a-b169-afe6d56f1554"></a></p>

<h3>HandleLinkedColorChanged ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the linked color changed.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9db5027-6cf5-49f7-bc02-76d8d7e80936'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="f9db5027-6cf5-49f7-bc02-76d8d7e80936"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b62ee9fd-6dec-4e5d-8461-12f266b4e6e7'>ToCSharp</a></td><td style='width:75%' ><p><a name="b62ee9fd-6dec-4e5d-8461-12f266b4e6e7"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="eb48e702-e4b2-4645-a9f3-4e6da1aada9e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#527f4583-7a47-4031-beeb-8f3298785a8f'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="527f4583-7a47-4031-beeb-8f3298785a8f"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fb04377b-921d-46ee-9f67-2b7b25e49864'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="fb04377b-921d-46ee-9f67-2b7b25e49864"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shadow to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The shadow as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00e74b50-98de-43a0-8a61-e61dd195200d'>ToCode</a></td><td style='width:75%' class='def'><p><a name="00e74b50-98de-43a0-8a61-e61dd195200d"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="07bad4a5-7b50-4c0e-b510-5bfa13419229"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="2f714fce-0838-42c2-8e5c-a4be75726b89"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="d40f63e1-0f11-480d-8148-e4c17002d1fb"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9c65582a-dfd2-43e3-8387-6b6350e59737'>Clone</a></td><td style='width:75%' ><p><a name="9c65582a-dfd2-43e3-8387-6b6350e59737"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dbfe30a0-5947-4e17-bffb-e3ef4eac8c2a'>RaiseShadowModified</a></td><td style='width:75%' class='def'><p><a name="dbfe30a0-5947-4e17-bffb-e3ef4eac8c2a"></a></p>

<h3>RaiseShadowModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the shadow modified event.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#bf9e9e4a-c654-4bef-ae95-5edf63544c33'>ShadowModified</a></td><td style='width:75%' ><p><a name="bf9e9e4a-c654-4bef-ae95-5edf63544c33"></a></p>

<h3>ShadowModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the shadow is modified.</p>
</td></tr></table></p>


---

<a name="a132d4cf-8cf6-4e06-b1d8-6b15c6d3e191"></a>
## KimonoGradient

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a gradient as a collection of either `SKColor` or linked `KimonoColors` that can be applied to a `KimonoStyle` and used when drawing a `KimonoShape`.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8d56ef56-285f-4b29-a1cb-53ceb951bf76'>_gradientType</a></td><td style='width:75%' ><p><a name="8d56ef56-285f-4b29-a1cb-53ceb951bf76"></a>
<b>_gradientType</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dab8cede-c225-4d4d-9ec5-3472ea671b2e'>_startPoint</a></td><td style='width:75%' class='def'><p><a name="dab8cede-c225-4d4d-9ec5-3472ea671b2e"></a>
<b>_startPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c56b60c0-e7dc-4871-80e7-a7c3e9cacb5e'>_endPoint</a></td><td style='width:75%' ><p><a name="c56b60c0-e7dc-4871-80e7-a7c3e9cacb5e"></a>
<b>_endPoint</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5427b36-1046-4d1f-9376-0cdd6e004b97'>_radius</a></td><td style='width:75%' class='def'><p><a name="e5427b36-1046-4d1f-9376-0cdd6e004b97"></a>
<b>_radius</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radius for radial and conical gradients.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e5ce3c47-9a19-4fa9-b8d2-214c8436cdd6'>_tileMode</a></td><td style='width:75%' ><p><a name="e5ce3c47-9a19-4fa9-b8d2-214c8436cdd6"></a>
<b>_tileMode</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The gradient tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#15fc8e2f-4b25-4282-912b-5ed16fc9df88'>_selectedHandle</a></td><td style='width:75%' class='def'><p><a name="15fc8e2f-4b25-4282-912b-5ed16fc9df88"></a>
<b>_selectedHandle</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2f2ef91a-6d0b-47fd-aebd-aba1418e4dc1'>PerformingDrag</a></td><td style='width:75%' ><p><a name="2f2ef91a-6d0b-47fd-aebd-aba1418e4dc1"></a>
<b>PerformingDrag</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Is the user performing a drag operation.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#6a9a84c8-6303-4863-af15-4112f9ce8761'>GradientType</a></td><td style='width:75%' ><p><a name="6a9a84c8-6303-4863-af15-4112f9ce8761"></a></p>

<h3>GradientType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the gradient.</p>

<h4>Return Value</h4>

<p>The type of the gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7c775c6-bed0-4d99-89fd-8de12f0ffd98'>UniqueID</a></td><td style='width:75%' class='def'><p><a name="e7c775c6-bed0-4d99-89fd-8de12f0ffd98"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3ac3ae3e-91a2-4197-8368-98f2d361c988'>ElementName</a></td><td style='width:75%' ><p><a name="3ac3ae3e-91a2-4197-8368-98f2d361c988"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d687315d-24eb-45fc-9cfb-357d18f7e7a8'>Name</a></td><td style='width:75%' class='def'><p><a name="d687315d-24eb-45fc-9cfb-357d18f7e7a8"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3851a5c6-3140-40d3-9f9e-cd198acf6cd6'>BarWidth</a></td><td style='width:75%' ><p><a name="3851a5c6-3140-40d3-9f9e-cd198acf6cd6"></a></p>

<h3>BarWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the bar.</p>

<h4>Return Value</h4>

<p>The width of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8435204f-c304-4360-93ee-fb28bf8c44b4'>BarHeight</a></td><td style='width:75%' class='def'><p><a name="8435204f-c304-4360-93ee-fb28bf8c44b4"></a></p>

<h3>BarHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the bar.</p>

<h4>Return Value</h4>

<p>The height of the bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97088ac3-eb4e-4fce-8253-b065652b31e6'>PreviewWidth</a></td><td style='width:75%' ><p><a name="97088ac3-eb4e-4fce-8253-b065652b31e6"></a></p>

<h3>PreviewWidth</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the width of the preview.</p>

<h4>Return Value</h4>

<p>The width of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e2242e9b-1559-49a6-8b9b-2b84cb42d750'>PreviewHeight</a></td><td style='width:75%' class='def'><p><a name="e2242e9b-1559-49a6-8b9b-2b84cb42d750"></a></p>

<h3>PreviewHeight</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the height of the preview.</p>

<h4>Return Value</h4>

<p>The height of the preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4fa1c7af-c4f6-4ba2-a000-752a560e9179'>StartPoint</a></td><td style='width:75%' ><p><a name="4fa1c7af-c4f6-4ba2-a000-752a560e9179"></a></p>

<h3>StartPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the start point.</p>

<h4>Return Value</h4>

<p>The start point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2203ce41-964d-448f-ba5b-9893d31d9b73'>EndPoint</a></td><td style='width:75%' class='def'><p><a name="2203ce41-964d-448f-ba5b-9893d31d9b73"></a></p>

<h3>EndPoint</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the end point.</p>

<h4>Return Value</h4>

<p>The end point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44784033-c640-4377-bb21-917791d30da1'>Radius</a></td><td style='width:75%' ><p><a name="44784033-c640-4377-bb21-917791d30da1"></a></p>

<h3>Radius</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the radius used by radial and conical gradients.</p>

<h4>Return Value</h4>

<p>The radius.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c18a74ce-5313-4a17-ad9d-72d2c6566709'>TileMode</a></td><td style='width:75%' class='def'><p><a name="c18a74ce-5313-4a17-ad9d-72d2c6566709"></a></p>

<h3>TileMode</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the tile mode.</p>

<h4>Return Value</h4>

<p>The tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#911cb06c-9889-4d7d-bf1f-5ace4ac518a6'>ControlPoints</a></td><td style='width:75%' ><p><a name="911cb06c-9889-4d7d-bf1f-5ace4ac518a6"></a></p>

<h3>ControlPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the control points that define the color.</p>

<h4>Return Value</h4>

<p>The control points.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#efb4766e-7b8a-450f-b986-f60118541ab3'>SelectedHandle</a></td><td style='width:75%' class='def'><p><a name="efb4766e-7b8a-450f-b986-f60118541ab3"></a></p>

<h3>SelectedHandle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the selected handle.</p>

<h4>Return Value</h4>

<p>The selected handle.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#44c5c2d2-52b6-45b3-85a2-7d45ad50d38e'>SelectedColor</a></td><td style='width:75%' ><p><a name="44c5c2d2-52b6-45b3-85a2-7d45ad50d38e"></a></p>

<h3>SelectedColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the color of the selected handle.</p>

<h4>Return Value</h4>

<p>The color of the selected handle or black if no handle is selected.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f4aec7a-481f-4a22-879f-5cfa8856cc53'>Shader</a></td><td style='width:75%' class='def'><p><a name="7f4aec7a-481f-4a22-879f-5cfa8856cc53"></a></p>

<h3>Shader</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the Skia Shader that represents this gradient.</p>

<h4>Return Value</h4>

<p>The <code>SKShader</code> for this gradient.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#444c1e3b-6c43-47dc-8958-4efb931ad16d'>KimonoGradient</a></td><td style='width:75%' ><p><a name="444c1e3b-6c43-47dc-8958-4efb931ad16d"></a></p>

<h3>KimonoGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a132d4cf-8cf6-4e06-b1d8-6b15c6d3e191">KimonoGradient</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4f2313da-f0fc-411e-b340-b312971e6272'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="4f2313da-f0fc-411e-b340-b312971e6272"></a></p>

<h3>KimonoGradient (KimonoCore.KimonoGradientType, KimonoCore.KimonoHandle, KimonoCore.KimonoHandle, System.Single, SkiaSharp.SKShaderTileMode, SkiaSharp.SKColor[], System.Single[])</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a132d4cf-8cf6-4e06-b1d8-6b15c6d3e191">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradientType</td><td style='width:75%' ><p><a name="f793fd00-babc-4e16-819f-271d6ba882bb"></a>
Gradient type.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="b34300c6-9242-4075-8cd5-21dd7f59bb2c"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="ea5a5bee-a2be-4ecf-997e-31efeeb3b842"></a>
End point.</p>
</td></tr><tr><td style='width:25%' class='term'>radius</td><td style='width:75%' class='def'><p><a name="5696f25c-f599-4c63-b4cb-7bd6224655f6"></a>
Radius.</p>
</td></tr><tr><td style='width:25%' class='term'>tileMode</td><td style='width:75%' ><p><a name="14874f04-16ac-4169-b700-b6e1fb39475e"></a>
Tile mode.</p>
</td></tr><tr><td style='width:25%' class='term'>colors</td><td style='width:75%' class='def'><p><a name="84a9d97c-ae2e-473a-971b-e5808c8d88ad"></a>
Colors.</p>
</td></tr><tr><td style='width:25%' class='term'>weights</td><td style='width:75%' ><p><a name="6294d945-0368-4e84-980b-fbf8130fcc01"></a>
Weights.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9afbb156-0803-499f-a3e1-6d94405b7242'>KimonoGradient</a></td><td style='width:75%' ><p><a name="9afbb156-0803-499f-a3e1-6d94405b7242"></a></p>

<h3>KimonoGradient (System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a132d4cf-8cf6-4e06-b1d8-6b15c6d3e191">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="fb10684e-fb77-4643-97f7-3547c6a25d48"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="83f3fca8-61df-44ad-91cc-23410d17e1f1"></a>
Bar height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#367b9cff-20ee-4502-b4e3-e6546dfda6ef'>KimonoGradient</a></td><td style='width:75%' class='def'><p><a name="367b9cff-20ee-4502-b4e3-e6546dfda6ef"></a></p>

<h3>KimonoGradient (System.Single, System.Single, System.Single, System.Single)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#a132d4cf-8cf6-4e06-b1d8-6b15c6d3e191">KimonoGradient</a> class.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>barWidth</td><td style='width:75%' ><p><a name="2fda908f-e01d-485d-8904-0f6d3a3b68c1"></a>
Bar width.</p>
</td></tr><tr><td style='width:25%' class='term'>barHeight</td><td style='width:75%' class='def'><p><a name="01d4c8d8-de02-4c98-bb39-986b8cb1ef95"></a>
Bar height.</p>
</td></tr><tr><td style='width:25%' class='term'>previewWidth</td><td style='width:75%' ><p><a name="fc02c4e3-a0f8-41e4-b6b1-3fed2fe951ab"></a>
Preview width.</p>
</td></tr><tr><td style='width:25%' class='term'>previewHeight</td><td style='width:75%' class='def'><p><a name="643f6e5b-3d42-4b4f-a026-e1e981f2356e"></a>
Preview height.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0d11689-eb0c-4c62-95fc-e18e858d7e3d'>Initialize</a></td><td style='width:75%' ><p><a name="f0d11689-eb0c-4c62-95fc-e18e858d7e3d"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#315624e2-91cc-4fa6-9dca-dd2ecd20f313'>SortedColors</a></td><td style='width:75%' class='def'><p><a name="315624e2-91cc-4fa6-9dca-dd2ecd20f313"></a></p>

<h3>SortedColors ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list of sorted colors by their "X" location inside the gradient.</p>

<h4>Returns</h4>

<p>The sorted colors arrays.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#59b5de4a-82f5-402d-975e-b98681e8a2e3'>SortedWeights</a></td><td style='width:75%' ><p><a name="59b5de4a-82f5-402d-975e-b98681e8a2e3"></a></p>

<h3>SortedWeights ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns a list a color weights by their "X" location in the gradient.</p>

<h4>Returns</h4>

<p>The sorted weights.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c72544f0-dbaa-43ee-b536-a6259708cf7d'>ConformingShader</a></td><td style='width:75%' class='def'><p><a name="c72544f0-dbaa-43ee-b536-a6259708cf7d"></a></p>

<h3>ConformingShader (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Generates a shader that conforms to a given start and end point.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="53f4f782-6dea-438a-9b05-e40a3959daa5"></a>
Start point.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="780c00c0-d080-4cfa-a430-53fd3cc397f5"></a>
End point.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>SKShader</code> for the gradient bound to a given shape's dimentions.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f09d1e69-260b-410d-8f20-a86b01f0edd3'>AddControlPoint</a></td><td style='width:75%' ><p><a name="f09d1e69-260b-410d-8f20-a86b01f0edd3"></a></p>

<h3>AddControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds a new control point to the gradients collection and makes it the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c7878faf-7259-4a52-b2a7-b351e0e975cb'>DeleteSelectedControlPoint</a></td><td style='width:75%' class='def'><p><a name="c7878faf-7259-4a52-b2a7-b351e0e975cb"></a></p>

<h3>DeleteSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Deletes the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ab4c006-d8f1-412f-b904-ef2f7a19ec8e'>DuplicateSelectedControlPoint</a></td><td style='width:75%' ><p><a name="5ab4c006-d8f1-412f-b904-ef2f7a19ec8e"></a></p>

<h3>DuplicateSelectedControlPoint ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Duplicates the selected control point.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8d128351-32f0-4bbe-90d4-a3ec0a8f113c'>FindHandle</a></td><td style='width:75%' class='def'><p><a name="8d128351-32f0-4bbe-90d4-a3ec0a8f113c"></a></p>

<h3>FindHandle (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Finds the handle matching the given unique ID.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>uniqueID</td><td style='width:75%' ><p><a name="0e197747-2119-4a18-9851-7b99babeaed8"></a>
Unique identifier.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The matching <code>KimonoHandle</code> or <code>null</code> if not found.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9135e123-48b1-48fa-b397-3571d3e320c1'>DrawBar</a></td><td style='width:75%' ><p><a name="9135e123-48b1-48fa-b397-3571d3e320c1"></a></p>

<h3>DrawBar ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the bar.</p>

<h4>Returns</h4>

<p>The bar.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#70aea686-a4ca-4b60-b10f-a6955f21fc74'>DrawPreview</a></td><td style='width:75%' class='def'><p><a name="70aea686-a4ca-4b60-b10f-a6955f21fc74"></a></p>

<h3>DrawPreview ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Draws the preview.</p>

<h4>Returns</h4>

<p>The preview.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ae644826-5c25-4a5c-8e52-a10f44f82f37'>BarToolDown</a></td><td style='width:75%' ><p><a name="ae644826-5c25-4a5c-8e52-a10f44f82f37"></a></p>

<h3>BarToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="518991a0-527c-46ea-9397-421821669305"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="8d95d582-0f2c-4d9e-8b77-8533459ac5bf"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="323405a2-eea2-4621-b188-0d95b6fc0cee"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b686840-a6a8-40a0-8b60-e7cf2af1d2c8'>BarToolDrag</a></td><td style='width:75%' class='def'><p><a name="8b686840-a6a8-40a0-8b60-e7cf2af1d2c8"></a></p>

<h3>BarToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient design bar. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="94f6a1f1-aaf6-429c-9166-cf300862be38"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2deb97b5-7f1a-4299-b671-fee80f43ecef'>BarToolUp</a></td><td style='width:75%' ><p><a name="2deb97b5-7f1a-4299-b671-fee80f43ecef"></a></p>

<h3>BarToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient design bar.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="87fe44a5-4b0c-4e87-9618-f5ca2741af1d"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f9a85e02-3f49-45d4-b3b6-700f9072c82c'>PreviewToolDown</a></td><td style='width:75%' class='def'><p><a name="f9a85e02-3f49-45d4-b3b6-700f9072c82c"></a></p>

<h3>PreviewToolDown (SkiaSharp.SKPoint, System.Int32, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user clicking a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="20103f2e-85c2-43d4-8bfc-4c45aab79f62"></a>
The point the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>clicks</td><td style='width:75%' class='def'><p><a name="e1ae8198-7260-45a9-833e-0bc094b51a2f"></a>
The number of times the user clicked.</p>
</td></tr><tr><td style='width:25%' class='term'>multiSelect</td><td style='width:75%' ><p><a name="2f13d1f1-70f3-44f1-a835-9e3d19a58381"></a>
If set to <code>true</code> multi select.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#297a7d63-cd91-4acf-a9f7-3bf87b6215a3'>PreviewToolDrag</a></td><td style='width:75%' ><p><a name="297a7d63-cd91-4acf-a9f7-3bf87b6215a3"></a></p>

<h3>PreviewToolDrag (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user draging a control point in the gradient preview. </p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="1a4f16e5-cff0-43ed-8bcb-33afc32b7ac9"></a>
The new location.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e9f17eb7-2e5a-4cf5-9898-645ca506e00b'>PreviewToolUp</a></td><td style='width:75%' class='def'><p><a name="e9f17eb7-2e5a-4cf5-9898-645ca506e00b"></a></p>

<h3>PreviewToolUp (SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the user releasing a control point in the gradient preview.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' ><p><a name="c87bb0d3-a1f9-4e96-aa7f-a42934dfbdfd"></a>
Point.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96292b10-2aab-4684-8a41-89c11c2ec4b5'>ToObiScript</a></td><td style='width:75%' ><p><a name="96292b10-2aab-4684-8a41-89c11c2ec4b5"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b13816a-9b47-4677-b92d-3910426c4588'>ToSkiaSharpPath</a></td><td style='width:75%' class='def'><p><a name="4b13816a-9b47-4677-b92d-3910426c4588"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#81a92574-b975-4aeb-acdd-7db2d99a2f28'>ToSkiaSharp</a></td><td style='width:75%' ><p><a name="81a92574-b975-4aeb-acdd-7db2d99a2f28"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cc48b0a3-452f-45ef-a9fb-f51d3246d099'>ToKimonoCore</a></td><td style='width:75%' class='def'><p><a name="cc48b0a3-452f-45ef-a9fb-f51d3246d099"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5dfb1a50-ead4-4f93-9c02-ba201e7bf1ae'>ColorsToCode</a></td><td style='width:75%' ><p><a name="5dfb1a50-ead4-4f93-9c02-ba201e7bf1ae"></a></p>

<h3>ColorsToCode (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3aeb9739-4a04-48cb-a331-f91e0c765076'>ColorsToInitializer</a></td><td style='width:75%' class='def'><p><a name="3aeb9739-4a04-48cb-a331-f91e0c765076"></a></p>

<h3>ColorsToInitializer (KimonoCore.CodeOutputLibrary, System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this graidents colors to Skia code.</p>

<h4>Returns</h4>

<p>The color list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#97555290-5913-4989-87c1-bef3f5e0f69e'>WeightsToSkiaCode</a></td><td style='width:75%' ><p><a name="97555290-5913-4989-87c1-bef3f5e0f69e"></a></p>

<h3>WeightsToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#76122a41-a182-43c0-93f5-aa88e5b598d0'>WeightsToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="76122a41-a182-43c0-93f5-aa88e5b598d0"></a></p>

<h3>WeightsToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradients weights to Skia Code.</p>

<h4>Returns</h4>

<p>The weight list as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35e1afb7-c42a-431c-a387-0788351b2d5a'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="35e1afb7-c42a-431c-a387-0788351b2d5a"></a></p>

<h3>ToCSharpSkia ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#18d60832-5a39-4ff9-9063-566faebe43f1'>ToCSharpSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="18d60832-5a39-4ff9-9063-566faebe43f1"></a></p>

<h3>ToCSharpSkiaInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d34e85ed-36aa-47da-ba0b-90ba7c09baf7'>ToCSharpSkia</a></td><td style='width:75%' ><p><a name="d34e85ed-36aa-47da-ba0b-90ba7c09baf7"></a></p>

<h3>ToCSharpSkia (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the gradient to C# Skia csource code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="b38ad38e-5d07-451f-a51f-6398151106bd"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="90025dd5-47c3-4ca0-9afe-418db3066ea5"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#94d0a299-4c57-4033-a268-0fe73c903f98'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="94d0a299-4c57-4033-a268-0fe73c903f98"></a></p>

<h3>ToCSharpKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bac02370-f3cb-443b-a974-9b02bc18351e'>ToCSharpKimonoCoreInitializer</a></td><td style='width:75%' ><p><a name="bac02370-f3cb-443b-a974-9b02bc18351e"></a></p>

<h3>ToCSharpKimonoCoreInitializer ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0d10225-6f72-469e-b886-096714bcfa4c'>ToCSharpKimonoCore</a></td><td style='width:75%' class='def'><p><a name="f0d10225-6f72-469e-b886-096714bcfa4c"></a></p>

<h3>ToCSharpKimonoCore (SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this gradient to code using the KimonoCore library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' ><p><a name="620caa10-f495-40c8-a92c-c4a5046c3b0d"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' class='def'><p><a name="2707a72e-66ef-4d53-9c8c-20dc906f66e9"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The gradient as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a504a194-5db4-44b3-957a-976c29bffeff'>ToCSharp</a></td><td style='width:75%' ><p><a name="a504a194-5db4-44b3-957a-976c29bffeff"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="0b626834-ea11-40c4-8c0a-a0b7858fb43e"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5948ff09-501e-4a08-995d-46a62bd46389'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="5948ff09-501e-4a08-995d-46a62bd46389"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="94b45e24-06c2-4d77-9198-c6b6a7408f3d"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6c512ddc-04f6-45ac-872a-f181796d3c6d'>ToCSharp</a></td><td style='width:75%' ><p><a name="6c512ddc-04f6-45ac-872a-f181796d3c6d"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the object to C# source code for the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="eb3a8885-7750-488a-9d0a-e070d9bb8d91"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr><tr><td style='width:25%' class='term'>startPoint</td><td style='width:75%' class='def'><p><a name="6b70699d-8a47-42cd-9be0-2335a6f38c71"></a>
The starting <code>SKPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>endPoint</td><td style='width:75%' ><p><a name="e0df2720-3ebe-43d3-bf2e-7d699f5fa309"></a>
The ending <code>SKPoint</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The C# source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#deb8e871-db28-4f8a-9aaf-ce58fa2578ac'>ToCode</a></td><td style='width:75%' class='def'><p><a name="deb8e871-db28-4f8a-9aaf-ce58fa2578ac"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="983e2fd7-d5d8-45af-b5d7-6a9866bb9b83"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="8e0aa924-c76b-4ad6-b7ed-a6cfd87f2d6e"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="14221def-dab1-4d98-8011-8c611412db1e"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#754c5a68-a8c2-40ff-a0f8-16d2b0d032e3'>Clone</a></td><td style='width:75%' ><p><a name="754c5a68-a8c2-40ff-a0f8-16d2b0d032e3"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cff25673-2b3f-4f39-bb16-390c2513063e'>RaiseGradientModified</a></td><td style='width:75%' class='def'><p><a name="cff25673-2b3f-4f39-bb16-390c2513063e"></a></p>

<h3>RaiseGradientModified ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the gradient modified event.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48d67e5d-9560-45e0-92a9-cde8446f4aa0'>RaiseHandleSelected</a></td><td style='width:75%' ><p><a name="48d67e5d-9560-45e0-92a9-cde8446f4aa0"></a></p>

<h3>RaiseHandleSelected (KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Raises the handle selected event.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>handle</td><td style='width:75%' ><p><a name="313001ac-bf44-4d9b-928a-effa44e9e418"></a>
Handle.</p>
</td></tr></table></p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Events</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#49893e1a-5237-4915-a583-c092e6f94e97'>GradientModified</a></td><td style='width:75%' ><p><a name="49893e1a-5237-4915-a583-c092e6f94e97"></a></p>

<h3>GradientModified</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when the gradient is modified.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d0c4dbf1-1e67-4941-a614-75ca4b56136b'>HandleSelected</a></td><td style='width:75%' class='def'><p><a name="d0c4dbf1-1e67-4941-a614-75ca4b56136b"></a></p>

<h3>HandleSelected</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Occurs when a handle is selected.</p>
</td></tr></table></p>


---

<a name="8a84cf60-472d-49b6-920d-2205ed0e01a5"></a>
## KimonoGradientType

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Kimono gradient type.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#98171fc9-46cc-4454-b767-24a62e1d05e6'>LinearGradient</a></td><td style='width:75%' ><p><a name="98171fc9-46cc-4454-b767-24a62e1d05e6"></a>
<b>LinearGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The linear gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3978557a-e797-41ab-a1d2-33bc5e6054f7'>RadialGradient</a></td><td style='width:75%' class='def'><p><a name="3978557a-e797-41ab-a1d2-33bc5e6054f7"></a>
<b>RadialGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The radial gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea06fff1-ea81-4aed-985d-1cf59c432886'>SweepGradient</a></td><td style='width:75%' ><p><a name="ea06fff1-ea81-4aed-985d-1cf59c432886"></a>
<b>SweepGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The sweep gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7296c98c-f45e-4eed-9c6d-650c9beeada4'>ConicalGradient</a></td><td style='width:75%' class='def'><p><a name="7296c98c-f45e-4eed-9c6d-650c9beeada4"></a>
<b>ConicalGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The conical gradient.</p>
</td></tr></table></p>


---

<a name="46c1096f-e31c-4843-abfa-ee248207a9d8"></a>
## KimonoStyle

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines as style that can be applied to a `KimonoShape` to control its appearance.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#e353a136-375b-42cd-aa76-5c39283aecee'>_frameColor</a></td><td style='width:75%' ><p><a name="e353a136-375b-42cd-aa76-5c39283aecee"></a>
<b>_frameColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's frame color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8742aafa-8149-4669-ad81-d4d38f42f50f'>_fillColor</a></td><td style='width:75%' class='def'><p><a name="8742aafa-8149-4669-ad81-d4d38f42f50f"></a>
<b>_fillColor</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Holds a named <code>KimonoColor</code> attached to the style's fill color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#132addcc-236a-4188-a4b6-32d820a75763'>_frameGradient</a></td><td style='width:75%' ><p><a name="132addcc-236a-4188-a4b6-32d820a75763"></a>
<b>_frameGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6d10451b-55c1-4ffd-9c42-822f4c7cfc4f'>_fillGradient</a></td><td style='width:75%' class='def'><p><a name="6d10451b-55c1-4ffd-9c42-822f4c7cfc4f"></a>
<b>_fillGradient</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bbae989d-ea74-4d1e-8905-13339145c0bc'>_hasFrameJitter</a></td><td style='width:75%' ><p><a name="bbae989d-ea74-4d1e-8905-13339145c0bc"></a>
<b>_hasFrameJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#10626e23-c17e-4d42-90a9-bfa3b02971e2'>_frameJitterLength</a></td><td style='width:75%' class='def'><p><a name="10626e23-c17e-4d42-90a9-bfa3b02971e2"></a>
<b>_frameJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6b1cb69f-3535-4631-b3fc-5922a3cc3b57'>_frameJitterDeviation</a></td><td style='width:75%' ><p><a name="6b1cb69f-3535-4631-b3fc-5922a3cc3b57"></a>
<b>_frameJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cd9c70b6-3696-4ab5-8a4e-7c2aab5397ec'>_hasFillJitter</a></td><td style='width:75%' class='def'><p><a name="cd9c70b6-3696-4ab5-8a4e-7c2aab5397ec"></a>
<b>_hasFillJitter</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the fill uses the jitter effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#89b76c29-dded-456e-9b44-8935261f2309'>_fillJitterLength</a></td><td style='width:75%' ><p><a name="89b76c29-dded-456e-9b44-8935261f2309"></a>
<b>_fillJitterLength</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a686b845-4f2d-45be-a640-a0be5dd64f9b'>_fillJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="a686b845-4f2d-45be-a640-a0be5dd64f9b"></a>
<b>_fillJitterDeviation</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1c52128b-a565-41cd-a87a-867833ce40c7'>_hasFrameDash</a></td><td style='width:75%' ><p><a name="1c52128b-a565-41cd-a87a-867833ce40c7"></a>
<b>_hasFrameDash</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>If <code>true</code>, the frame has a dash effect.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c625954a-c92f-44ff-a757-65a3eb62edbb'>_hasFillBlur</a></td><td style='width:75%' class='def'><p><a name="c625954a-c92f-44ff-a757-65a3eb62edbb"></a>
<b>_hasFillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b2096b8b-90f8-4c27-98db-33a1d8f4b014'>_fillBlur</a></td><td style='width:75%' ><p><a name="b2096b8b-90f8-4c27-98db-33a1d8f4b014"></a>
<b>_fillBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#eea7d9fb-a867-4af2-a469-387d6e1d6b53'>_hasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="eea7d9fb-a867-4af2-a469-387d6e1d6b53"></a>
<b>_hasFrameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#978e95f3-4e82-4b62-b27b-b56b0bcfa653'>_frameBlur</a></td><td style='width:75%' ><p><a name="978e95f3-4e82-4b62-b27b-b56b0bcfa653"></a>
<b>_frameBlur</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame blur.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#afb654de-2e69-4b6b-bab2-9e350bd35c16'>_hasFillShadow</a></td><td style='width:75%' class='def'><p><a name="afb654de-2e69-4b6b-bab2-9e350bd35c16"></a>
<b>_hasFillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8b7e50da-e3af-484e-bf9f-b67b5cf3b793'>_fillShadow</a></td><td style='width:75%' ><p><a name="8b7e50da-e3af-484e-bf9f-b67b5cf3b793"></a>
<b>_fillShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d6fc1cb5-5347-4810-b1fc-b23347167879'>_hasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="d6fc1cb5-5347-4810-b1fc-b23347167879"></a>
<b>_hasFrameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The has frame shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c3fc221c-8db3-4ea8-a8ac-b4b1c4cbe189'>_frameShadow</a></td><td style='width:75%' ><p><a name="c3fc221c-8db3-4ea8-a8ac-b4b1c4cbe189"></a>
<b>_frameShadow</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The frame shadow.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8f4e9f00-654e-4e54-9c00-7ad28073da2f'>UniqueID</a></td><td style='width:75%' ><p><a name="8f4e9f00-654e-4e54-9c00-7ad28073da2f"></a></p>

<h3>UniqueID</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the unique identifier.</p>

<h4>Return Value</h4>

<p>The unique identifier.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#349173ca-44c6-4a6e-80ff-d8af077dd13c'>ElementName</a></td><td style='width:75%' class='def'><p><a name="349173ca-44c6-4a6e-80ff-d8af077dd13c"></a></p>

<h3>ElementName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the element as it will be called in generated source code.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40430100-3861-4c9c-ad0a-173f8e8ce552'>Name</a></td><td style='width:75%' ><p><a name="40430100-3861-4c9c-ad0a-173f8e8ce552"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name.</p>

<h4>Return Value</h4>

<p>The name.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e246ae1-7875-4ca7-9d44-581d9a1efce1'>HasFrame</a></td><td style='width:75%' class='def'><p><a name="2e246ae1-7875-4ca7-9d44-581d9a1efce1"></a></p>

<h3>HasFrame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> has a frame.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c78e36f3-1af2-47fa-bff5-2ce2fb13f8b2'>Frame</a></td><td style='width:75%' ><p><a name="c78e36f3-1af2-47fa-bff5-2ce2fb13f8b2"></a></p>

<h3>Frame</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#216163bf-167b-4a0e-a52a-2f9c77e765a1'>HasFrameBlur</a></td><td style='width:75%' class='def'><p><a name="216163bf-167b-4a0e-a52a-2f9c77e765a1"></a></p>

<h3>HasFrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> has frame blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5fa67b88-f5fb-44be-9e99-4341f6950734'>FrameBlur</a></td><td style='width:75%' ><p><a name="5fa67b88-f5fb-44be-9e99-4341f6950734"></a></p>

<h3>FrameBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#161def11-2143-4ca9-be86-bb18a3513f8a'>HasFrameShadow</a></td><td style='width:75%' class='def'><p><a name="161def11-2143-4ca9-be86-bb18a3513f8a"></a></p>

<h3>HasFrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> has frame shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c14dc602-0ef5-4e25-b9ce-65d620d30696'>FrameShadow</a></td><td style='width:75%' ><p><a name="c14dc602-0ef5-4e25-b9ce-65d620d30696"></a></p>

<h3>FrameShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame shadow.</p>

<h4>Return Value</h4>

<p>The frame shadow as a <code>KimonoShadow</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fa335e06-54a5-4c59-b990-eb70214a67b8'>HasFillBlur</a></td><td style='width:75%' class='def'><p><a name="fa335e06-54a5-4c59-b990-eb70214a67b8"></a></p>

<h3>HasFillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> has fill blur.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill blur; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67a59862-82b9-4ddf-a58a-6255795f7cb6'>FillBlur</a></td><td style='width:75%' ><p><a name="67a59862-82b9-4ddf-a58a-6255795f7cb6"></a></p>

<h3>FillBlur</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill blur.</p>

<h4>Return Value</h4>

<p>The <code>KimonoBlur</code> applied to the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#54211067-4bf8-42a2-9d4f-1e09b18f47ee'>HasFillShadow</a></td><td style='width:75%' class='def'><p><a name="54211067-4bf8-42a2-9d4f-1e09b18f47ee"></a></p>

<h3>HasFillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> has fill shadow.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill shadow; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#5ccb33c1-df2d-43e9-8a36-40798a401140'>FillShadow</a></td><td style='width:75%' ><p><a name="5ccb33c1-df2d-43e9-8a36-40798a401140"></a></p>

<h3>FillShadow</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill shadow.</p>

<h4>Return Value</h4>

<p>The fill shadow.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4ee9c446-19ec-4aac-a157-022b1db1041c'>FrameColor</a></td><td style='width:75%' class='def'><p><a name="4ee9c446-19ec-4aac-a157-022b1db1041c"></a></p>

<h3>FrameColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the frame as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the frame.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f02042d8-dbbf-49bd-865e-09b355fa313c'>FrameGradient</a></td><td style='width:75%' ><p><a name="f02042d8-dbbf-49bd-865e-09b355fa313c"></a></p>

<h3>FrameGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame gradient.</p>

<h4>Return Value</h4>

<p>The frame gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c85110b2-da08-4dd0-8427-aec72125f632'>HasFill</a></td><td style='width:75%' class='def'><p><a name="c85110b2-da08-4dd0-8427-aec72125f632"></a></p>

<h3>HasFill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> has fill.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#247ae383-b366-41a8-850e-e46bd0393f33'>Fill</a></td><td style='width:75%' ><p><a name="247ae383-b366-41a8-850e-e46bd0393f33"></a></p>

<h3>Fill</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill paint style.</p>

<h4>Return Value</h4>

<p>The <code>SKPaint</code> style for the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1392c6a2-6f19-4013-8514-81b13518de24'>FillColor</a></td><td style='width:75%' class='def'><p><a name="1392c6a2-6f19-4013-8514-81b13518de24"></a></p>

<h3>FillColor</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the color of the fill as a named Kimono Color.</p>

<h4>Return Value</h4>

<p>The color of the fill.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d1a310f4-dcda-437a-863b-ac68be11c781'>FillGradient</a></td><td style='width:75%' ><p><a name="d1a310f4-dcda-437a-863b-ac68be11c781"></a></p>

<h3>FillGradient</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill gradient.</p>

<h4>Return Value</h4>

<p>The fill gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#946b435d-f056-47c2-ba73-85374eef21bd'>StyleType</a></td><td style='width:75%' class='def'><p><a name="946b435d-f056-47c2-ba73-85374eef21bd"></a></p>

<h3>StyleType</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the type of the style.</p>

<h4>Return Value</h4>

<p>The type of the style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2ba041ff-811a-4ed9-b14d-32cb3e05e894'>FontMetrics</a></td><td style='width:75%' ><p><a name="2ba041ff-811a-4ed9-b14d-32cb3e05e894"></a></p>

<h3>FontMetrics</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the font metrics.</p>

<h4>Return Value</h4>

<p>The font metrics.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1cc926e0-126c-4b44-a69c-9025123d411f'>IsLinearText</a></td><td style='width:75%' class='def'><p><a name="1cc926e0-126c-4b44-a69c-9025123d411f"></a></p>

<h3>IsLinearText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> is linear text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is linear text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c69f6f9f-b55c-45ee-ab0c-83313041aa29'>IsVerticalText</a></td><td style='width:75%' ><p><a name="c69f6f9f-b55c-45ee-ab0c-83313041aa29"></a></p>

<h3>IsVerticalText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> is vertical text.</p>

<h4>Return Value</h4>

<p><code>true</code> if is vertical text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04e2aad7-830b-4ab6-a687-30c7b94fb0cd'>StrikeThruText</a></td><td style='width:75%' class='def'><p><a name="04e2aad7-830b-4ab6-a687-30c7b94fb0cd"></a></p>

<h3>StrikeThruText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> strike thru text.</p>

<h4>Return Value</h4>

<p><code>true</code> if strike thru text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d8a8f25a-ad74-4f77-84b3-0c112ea3533d'>TextAlign</a></td><td style='width:75%' ><p><a name="d8a8f25a-ad74-4f77-84b3-0c112ea3533d"></a></p>

<h3>TextAlign</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text align.</p>

<h4>Return Value</h4>

<p>The text align.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#712ed306-d007-45b4-a244-741bfb51489c'>TextEncoding</a></td><td style='width:75%' class='def'><p><a name="712ed306-d007-45b4-a244-741bfb51489c"></a></p>

<h3>TextEncoding</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text encoding.</p>

<h4>Return Value</h4>

<p>The text encoding.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#dd1dd5f1-6a24-41d4-8180-e7000e1133aa'>TextScaleX</a></td><td style='width:75%' ><p><a name="dd1dd5f1-6a24-41d4-8180-e7000e1133aa"></a></p>

<h3>TextScaleX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text scale x.</p>

<h4>Return Value</h4>

<p>The text scale x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8ce30033-5f9e-4561-bfa0-a7813dc54f38'>TextSize</a></td><td style='width:75%' class='def'><p><a name="8ce30033-5f9e-4561-bfa0-a7813dc54f38"></a></p>

<h3>TextSize</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the size of the text.</p>

<h4>Return Value</h4>

<p>The size of the text.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#549e9386-e087-432e-a231-66eea5aeed56'>TextSkewX</a></td><td style='width:75%' ><p><a name="549e9386-e087-432e-a231-66eea5aeed56"></a></p>

<h3>TextSkewX</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the text skew x.</p>

<h4>Return Value</h4>

<p>The text skew x.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#27361fdd-c019-4a9e-8d7d-71b0719e7daf'>Typeface</a></td><td style='width:75%' class='def'><p><a name="27361fdd-c019-4a9e-8d7d-71b0719e7daf"></a></p>

<h3>Typeface</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface.</p>

<h4>Return Value</h4>

<p>The typeface.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#273fec57-afc9-4920-9f9d-d954f67a7f11'>FontFamilyName</a></td><td style='width:75%' ><p><a name="273fec57-afc9-4920-9f9d-d954f67a7f11"></a></p>

<h3>FontFamilyName</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the name of the font family.</p>

<h4>Return Value</h4>

<p>The name of the font family.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#08896abb-f58a-4d8a-8d54-b41511fa44bc'>TypefaceStyle</a></td><td style='width:75%' class='def'><p><a name="08896abb-f58a-4d8a-8d54-b41511fa44bc"></a></p>

<h3>TypefaceStyle</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the typeface style.</p>

<h4>Return Value</h4>

<p>The typeface style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#31c15743-c641-4763-9656-d4dfe1e479a7'>UnderlineText</a></td><td style='width:75%' ><p><a name="31c15743-c641-4763-9656-d4dfe1e479a7"></a></p>

<h3>UnderlineText</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether this <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> underline text.</p>

<h4>Return Value</h4>

<p><code>true</code> if underline text; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bfa53dcb-855c-4ed6-8741-cf6efcf048d8'>HasFrameJitter</a></td><td style='width:75%' class='def'><p><a name="bfa53dcb-855c-4ed6-8741-cf6efcf048d8"></a></p>

<h3>HasFrameJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has frame jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f51256b0-11e6-4835-bd86-639b2bfd3324'>FrameJitterLength</a></td><td style='width:75%' ><p><a name="f51256b0-11e6-4835-bd86-639b2bfd3324"></a></p>

<h3>FrameJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the frame jitter.</p>

<h4>Return Value</h4>

<p>The length of the frame jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#316d93fc-b68f-4e31-9dc5-4c3064c5107c'>FrameJitterDeviation</a></td><td style='width:75%' class='def'><p><a name="316d93fc-b68f-4e31-9dc5-4c3064c5107c"></a></p>

<h3>FrameJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the frame jitter deviation.</p>

<h4>Return Value</h4>

<p>The frame jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d3905e1d-4888-4ae9-970c-1b64723d8aa4'>HasFillJitter</a></td><td style='width:75%' ><p><a name="d3905e1d-4888-4ae9-970c-1b64723d8aa4"></a></p>

<h3>HasFillJitter</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the fill jitter is used.</p>

<h4>Return Value</h4>

<p><code>true</code> if has fill jitter; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#30cfc28e-9803-4a75-8502-b828986cd576'>FillJitterLength</a></td><td style='width:75%' class='def'><p><a name="30cfc28e-9803-4a75-8502-b828986cd576"></a></p>

<h3>FillJitterLength</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the length of the fill jitter.</p>

<h4>Return Value</h4>

<p>The length of the fill jitter.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e7350364-c966-4201-832d-4ecd37b0a5c9'>FillJitterDeviation</a></td><td style='width:75%' ><p><a name="e7350364-c966-4201-832d-4ecd37b0a5c9"></a></p>

<h3>FillJitterDeviation</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the fill jitter deviation.</p>

<h4>Return Value</h4>

<p>The fill jitter deviation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#373172f0-1563-4806-b9c2-af5a1eb98954'>HasFrameDash</a></td><td style='width:75%' class='def'><p><a name="373172f0-1563-4806-b9c2-af5a1eb98954"></a></p>

<h3>HasFrameDash</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets a value indicating whether the frame has a dash.</p>

<h4>Return Value</h4>

<p><code>true</code> if the frame has a dash; otherwise, <code>false</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#40ce20e8-9640-41a0-9fe1-679f0202761d'>DashPattern</a></td><td style='width:75%' ><p><a name="40ce20e8-9640-41a0-9fe1-679f0202761d"></a></p>

<h3>DashPattern</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the dash pattern.</p>

<h4>Return Value</h4>

<p>The dash pattern.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e89c563b-45c2-47cd-a4f3-623897a4e88d'>ConnectionPoints</a></td><td style='width:75%' class='def'><p><a name="e89c563b-45c2-47cd-a4f3-623897a4e88d"></a></p>

<h3>ConnectionPoints</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the possible connection points that a <code>KimonoProperty</code> can be connected to this <code>KimonoStyle</code>.</p>

<h4>Return Value</h4>

<p>The array of <code>KimonoPropertyConnectionPoint</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f94eded0-7abc-4adc-a583-3107d39c7f6f'>PropertyConnections</a></td><td style='width:75%' ><p><a name="f94eded0-7abc-4adc-a583-3107d39c7f6f"></a></p>

<h3>PropertyConnections</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the list of <code>KimonoProperty</code> objects connected to the various  <code>KimonoPropertyConnectionPoint</code>s that will need to be evaulated before drawing this <code>KimonoShape</code>.</p>

<h4>Return Value</h4>

<p>The property connections.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#612a9079-08c6-4100-a733-98f806d43fef'>ClonePaint</a></td><td style='width:75%' ><p><a name="612a9079-08c6-4100-a733-98f806d43fef"></a></p>

<h3>ClonePaint (SkiaSharp.SKPaint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the given <code>SKPaint</code> object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>paint</td><td style='width:75%' ><p><a name="7d31bd96-aa37-4f29-8b8f-ee65c71e2b42"></a>
The <code>SKPaint</code> object to clone.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The new <code>SKPaint</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ddf1123a-e498-4530-8822-3401d335ac82'>KimonoStyle</a></td><td style='width:75%' class='def'><p><a name="ddf1123a-e498-4530-8822-3401d335ac82"></a></p>

<h3>KimonoStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#46c1096f-e31c-4843-abfa-ee248207a9d8">KimonoStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ced8aad9-8c75-438b-879f-da1e219c3f7c'>Initialize</a></td><td style='width:75%' ><p><a name="ced8aad9-8c75-438b-879f-da1e219c3f7c"></a></p>

<h3>Initialize ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initialize this instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#fe35568e-85b9-4ee7-94fd-1bd23047d15a'>HandleFrameBlurOrShadowChange</a></td><td style='width:75%' class='def'><p><a name="fe35568e-85b9-4ee7-94fd-1bd23047d15a"></a></p>

<h3>HandleFrameBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8eb7f6ae-a3c8-4579-9880-76be29c3551f'>HandleFillBlurOrShadowChange</a></td><td style='width:75%' ><p><a name="8eb7f6ae-a3c8-4579-9880-76be29c3551f"></a></p>

<h3>HandleFillBlurOrShadowChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill blur change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#72252be5-1ba2-44a6-a8fb-76f8f87fc078'>HandleFrameColorChange</a></td><td style='width:75%' class='def'><p><a name="72252be5-1ba2-44a6-a8fb-76f8f87fc078"></a></p>

<h3>HandleFrameColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#aeaf5c93-247a-48df-bcd0-1b6d6af77409'>HandleFillColorChange</a></td><td style='width:75%' ><p><a name="aeaf5c93-247a-48df-bcd0-1b6d6af77409"></a></p>

<h3>HandleFillColorChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill color change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#67962cf5-a1c7-4da5-b81f-863407592692'>HandleFrameGradientChange</a></td><td style='width:75%' class='def'><p><a name="67962cf5-a1c7-4da5-b81f-863407592692"></a></p>

<h3>HandleFrameGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the frame gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9febea18-7b8b-4981-942c-24208003c726'>HandleFillGradientChange</a></td><td style='width:75%' ><p><a name="9febea18-7b8b-4981-942c-24208003c726"></a></p>

<h3>HandleFillGradientChange ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Handles the fill gradient change.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#90b3d30c-de8f-4e85-986e-6d8acfdcd496'>MakeDashInterval</a></td><td style='width:75%' class='def'><p><a name="90b3d30c-de8f-4e85-986e-6d8acfdcd496"></a></p>

<h3>MakeDashInterval ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes the dash interval from the dash pattern.</p>

<h4>Returns</h4>

<p>The dash interval.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0d0a0a14-0464-49c0-81f3-1f703978c0d1'>AddPropertyConnection</a></td><td style='width:75%' ><p><a name="0d0a0a14-0464-49c0-81f3-1f703978c0d1"></a></p>

<h3>AddPropertyConnection (KimonoCore.KimonoPropertyConnectionPoint, KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Connects the given <code>KimonoProperty</code> to the given <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connectionPoint</td><td style='width:75%' ><p><a name="375e6a71-c721-45ce-9f0e-6c88e0b05672"></a>
The <code>KimonoPropertyConnectionPoint</code> to connect to.</p>
</td></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' class='def'><p><a name="9095b6ae-28d2-4523-9fca-f5e2cf4ef2af"></a>
The <code>KimonoProperty</code> to connect.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b37992ba-d4a2-4870-a38f-93e605e8809e'>RemovePropertyConnection</a></td><td style='width:75%' class='def'><p><a name="b37992ba-d4a2-4870-a38f-93e605e8809e"></a></p>

<h3>RemovePropertyConnection (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes the property connection.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="93757534-8f35-4f77-9130-acaa77e584e3"></a>
The <code>KimonoPropertyConnection</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2796e406-be96-4fae-b496-04fd104051b4'>RemoveProperty</a></td><td style='width:75%' ><p><a name="2796e406-be96-4fae-b496-04fd104051b4"></a></p>

<h3>RemoveProperty (KimonoCore.KimonoProperty)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Removes any connection using this property.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>property</td><td style='width:75%' ><p><a name="919cacde-1c84-4437-8b15-cb90ed6f465f"></a>
The <code>KimonoProperty</code> to remove.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ea2a3f8c-e03c-4126-a667-bba44edaf339'>EvaluateConnectedProperties</a></td><td style='width:75%' class='def'><p><a name="ea2a3f8c-e03c-4126-a667-bba44edaf339"></a></p>

<h3>EvaluateConnectedProperties ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluates all of the <code>KimonoProperty</code> objects attached to this <code>KimonoStyle</code> by executling their Obi Scripts and updating the values with the results.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cacc84af-92c8-4ec7-b32c-1b75e8e9ead9'>UpdatePropertyConnectionPoint</a></td><td style='width:75%' ><p><a name="cacc84af-92c8-4ec7-b32c-1b75e8e9ead9"></a></p>

<h3>UpdatePropertyConnectionPoint (KimonoCore.KimonoPropertyConnection)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Updates a <code>KimonoPropertyConnectionPoint</code> on this <code>KimonoStyle</code> with the results of a Obi Script run on an attached <code>KimonoProperty</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>connection</td><td style='width:75%' ><p><a name="8ee46622-9bc9-4f8b-afe0-111725ee8309"></a>
Connection.</p>
</td></tr></table></p>
</td></tr><tr><td style='width:25%' class='term'><a href='#b60ef22c-70dd-45e5-840c-112ea47c4cef'>ApplyFrameEffects</a></td><td style='width:75%' class='def'><p><a name="b60ef22c-70dd-45e5-840c-112ea47c4cef"></a></p>

<h3>ApplyFrameEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the frame effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f1f69b2d-957b-4a1c-b973-60015420a0f0'>ApplyFillEffects</a></td><td style='width:75%' ><p><a name="f1f69b2d-957b-4a1c-b973-60015420a0f0"></a></p>

<h3>ApplyFillEffects ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Applies the fill effects based on the style settings.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beb92b2c-3dc4-4a6e-a7f3-944e8f5b036c'>ToObiScript</a></td><td style='width:75%' class='def'><p><a name="beb92b2c-3dc4-4a6e-a7f3-944e8f5b036c"></a></p>

<h3>ToObiScript ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to Obi Script represnetation.</p>

<h4>Returns</h4>

<p>The obi script.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#99752aaa-d932-41bd-b289-cb0da94d6bab'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="99752aaa-d932-41bd-b289-cb0da94d6bab"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#547d50df-5e89-4f6b-9e35-ebf5ba90e1b3'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="547d50df-5e89-4f6b-9e35-ebf5ba90e1b3"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7f72ae1a-ede7-4c78-970e-a5ad75f60bb2'>FillToSkiaCode</a></td><td style='width:75%' ><p><a name="7f72ae1a-ede7-4c78-970e-a5ad75f60bb2"></a></p>

<h3>FillToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#36c39c36-4000-4477-9877-58c0b1e72131'>FillToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="36c39c36-4000-4477-9877-58c0b1e72131"></a></p>

<h3>FillToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Fill to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Fill <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3dd58504-5cf9-4e47-834d-0ab9e274d8be'>FrameToSkiaCode</a></td><td style='width:75%' ><p><a name="3dd58504-5cf9-4e47-834d-0ab9e274d8be"></a></p>

<h3>FrameToSkiaCode ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#7a828880-6127-4a81-9ba2-5a9dc3628a24'>FrameToSkiaInitializer</a></td><td style='width:75%' class='def'><p><a name="7a828880-6127-4a81-9ba2-5a9dc3628a24"></a></p>

<h3>FrameToSkiaInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style's Frame to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The Frame <code>SKPaint</code> as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23a3378e-1b66-4d37-8e27-00ff5c683591'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="23a3378e-1b66-4d37-8e27-00ff5c683591"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#330148c2-2685-450a-bced-186eefaa0371'>ToKimonoCoreInitializer</a></td><td style='width:75%' class='def'><p><a name="330148c2-2685-450a-bced-186eefaa0371"></a></p>

<h3>ToKimonoCoreInitializer (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this style to C# code using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c03ae959-a0ba-42f8-9637-d8abc6b08dca'>ToCSharp</a></td><td style='width:75%' ><p><a name="c03ae959-a0ba-42f8-9637-d8abc6b08dca"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="e1ab001e-0e22-43dd-8a73-15cf9fc79520"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#999dc24a-bac3-4797-804a-b16474c6264e'>ToCSharpInitializer</a></td><td style='width:75%' class='def'><p><a name="999dc24a-bac3-4797-804a-b16474c6264e"></a></p>

<h3>ToCSharpInitializer (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this styl to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="467450df-9ff9-40a2-983b-4e5d888e6dbe"></a>
The <code>CodeOutputLibrary</code> to generate code in.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The style as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c5914e8b-8469-4717-a718-b13a88c0841e'>ToCode</a></td><td style='width:75%' ><p><a name="c5914e8b-8469-4717-a718-b13a88c0841e"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="bd93aa22-8108-4c3b-a14a-62e499e00680"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="e38ab05d-ddfb-4ea4-a98a-0a3bcbb27175"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="a5739098-0aee-494e-82cb-4a5dd842e8d5"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#23c7c194-ed9b-4d45-b795-bc528fba3a69'>Clone</a></td><td style='width:75%' class='def'><p><a name="23c7c194-ed9b-4d45-b795-bc528fba3a69"></a></p>

<h3>Clone (System.Boolean)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clones the <code>KimonoStyle</code>.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>deepClone</td><td style='width:75%' ><p><a name="ead93ce9-8ee6-474d-b259-f2f3175a431b"></a>
If set to <code>true</code>, a deep clone of the style is made.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The a clone of the <code>KimonoStyle</code>.</p>
</td></tr></table></p>


---

<a name="0d328d70-920b-423c-9c80-356b9685b9f9"></a>
## KimonoStyleType

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the type of a `KimonoStyle` that will be used to draw a given `KimonoShape` in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c784ca53-60f2-4491-897f-0731f1db2f31'>Default</a></td><td style='width:75%' ><p><a name="c784ca53-60f2-4491-897f-0731f1db2f31"></a>
<b>Default</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The default style for new shapes. This style cannot be deleted or renamed by the user.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#96b98189-555c-47d9-bbfd-9961d6533487'>Custom</a></td><td style='width:75%' class='def'><p><a name="96b98189-555c-47d9-bbfd-9961d6533487"></a>
<b>Custom</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom style that belongs only to an individual shape instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#92a4299e-e152-4032-b368-adfe009a98da'>CustomText</a></td><td style='width:75%' ><p><a name="92a4299e-e152-4032-b368-adfe009a98da"></a>
<b>CustomText</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A custom text style that belongs only to an individual <code>KimonoShapeText</code> instance.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#09df3c37-75c0-4af2-a365-1809c1e5d246'>Standard</a></td><td style='width:75%' class='def'><p><a name="09df3c37-75c0-4af2-a365-1809c1e5d246"></a>
<b>Standard</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared style that can be applied to multiple <code>Kimonoshape</code> instances.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#bb91d8ac-2bd1-4c3b-80ab-bb96ef3691db'>Text</a></td><td style='width:75%' ><p><a name="bb91d8ac-2bd1-4c3b-80ab-bb96ef3691db"></a>
<b>Text</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A shared text style that can be applied to multiple <code>KimonoShapeText</code> instances.</p>
</td></tr></table></p>


---

<a name="76d2da2e-c6b0-402e-adfb-ee1b722680e8"></a>
## KimonoPropertyRect

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `SKRect`.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#53edf5d7-f196-4efc-a29a-6a2ca0708422'>Value</a></td><td style='width:75%' ><p><a name="53edf5d7-f196-4efc-a29a-6a2ca0708422"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value as a <code>SKRect</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#71d623b4-39cb-4e0f-a306-3830eabe4c0f'>KimonoPropertyRect</a></td><td style='width:75%' ><p><a name="71d623b4-39cb-4e0f-a306-3830eabe4c0f"></a></p>

<h3>KimonoPropertyRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#76d2da2e-c6b0-402e-adfb-ee1b722680e8">KimonoPropertyRect</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bff80c0-ac5f-4422-90b5-79480d02261a'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="6bff80c0-ac5f-4422-90b5-79480d02261a"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1983fbb2-5739-46ba-8b9b-f06c668e34cf'>ToRect</a></td><td style='width:75%' ><p><a name="1983fbb2-5739-46ba-8b9b-f06c668e34cf"></a></p>

<h3>ToRect ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>SKRect</code>.</p>

<h4>Returns</h4>

<p>The <code>SKRect</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0a9bab66-5e01-4f21-a39f-eb3168e7c28a'>Clone</a></td><td style='width:75%' class='def'><p><a name="0a9bab66-5e01-4f21-a39f-eb3168e7c28a"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="86bdba1e-f610-4e7f-ba44-499671557e12"></a>
## KimonoPropertyNumber

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `float` or `int` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#ef8c05f2-76de-4f2f-b473-8afedf3542cd'>Value</a></td><td style='width:75%' ><p><a name="ef8c05f2-76de-4f2f-b473-8afedf3542cd"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>float</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b38f68df-423e-4857-81eb-27bba35f677b'>KimonoPropertyNumber</a></td><td style='width:75%' ><p><a name="b38f68df-423e-4857-81eb-27bba35f677b"></a></p>

<h3>KimonoPropertyNumber ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#86bdba1e-f610-4e7f-ba44-499671557e12">KimonoPropertyNumber</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#93a333ef-a448-4db3-970d-ec249f30c42a'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="93a333ef-a448-4db3-970d-ec249f30c42a"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a662a7de-88b4-4658-be67-532b25c96bcc'>ToFloat</a></td><td style='width:75%' ><p><a name="a662a7de-88b4-4658-be67-532b25c96bcc"></a></p>

<h3>ToFloat ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>float</code>.</p>

<h4>Returns</h4>

<p>The <code>float</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f0de5dee-fbb2-4f59-a31e-b0d50a72613f'>ToInt</a></td><td style='width:75%' class='def'><p><a name="f0de5dee-fbb2-4f59-a31e-b0d50a72613f"></a></p>

<h3>ToInt ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to an <code>int</code>.</p>

<h4>Returns</h4>

<p>The <code>int</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#42c9dd73-b986-43c0-9f4b-46184eabbda0'>Clone</a></td><td style='width:75%' ><p><a name="42c9dd73-b986-43c0-9f4b-46184eabbda0"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="0b7e6490-7c2c-4da0-95b9-58d985d6a2c2"></a>
## KimonoPropertyStyle

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `KimonoStyle` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#62566ca8-2fae-44d4-b5a8-0773824dcb40'>Value</a></td><td style='width:75%' ><p><a name="62566ca8-2fae-44d4-b5a8-0773824dcb40"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1447e32f-fa29-4086-8e44-1d514308906e'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="1447e32f-fa29-4086-8e44-1d514308906e"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#cc0d1f51-c777-4035-bb47-fd7ea6bfa0f4">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#aaa440d0-5916-48cb-b8c2-6d9e8a18c904'>KimonoPropertyStyle</a></td><td style='width:75%' ><p><a name="aaa440d0-5916-48cb-b8c2-6d9e8a18c904"></a></p>

<h3>KimonoPropertyStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#0b7e6490-7c2c-4da0-95b9-58d985d6a2c2">KimonoPropertyStyle</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#35e53741-4c47-4697-a74d-f26ba7fe7784'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="35e53741-4c47-4697-a74d-f26ba7fe7784"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0c718796-98a7-4b1b-bde9-76c2849b580f'>ToStyle</a></td><td style='width:75%' ><p><a name="0c718796-98a7-4b1b-bde9-76c2849b580f"></a></p>

<h3>ToStyle ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoStyle</code>.</p>

<h4>Returns</h4>

<p>The <code>KimonoStyle</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#8721f28d-67e9-435c-a1b7-499c10374157'>Clone</a></td><td style='width:75%' class='def'><p><a name="8721f28d-67e9-435c-a1b7-499c10374157"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="f8ae9bff-05de-4dcf-bdc1-91c986f1c993"></a>
## KimonoPropertyBoolean

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `bool` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8db43b3a-32bf-458d-be53-fe7a8b619716'>Value</a></td><td style='width:75%' ><p><a name="8db43b3a-32bf-458d-be53-fe7a8b619716"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>bool</code> value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#d69b7c43-6207-48a9-8fb8-9a801763f9d1'>KimonoPropertyBoolean</a></td><td style='width:75%' ><p><a name="d69b7c43-6207-48a9-8fb8-9a801763f9d1"></a></p>

<h3>KimonoPropertyBoolean ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#f8ae9bff-05de-4dcf-bdc1-91c986f1c993">KimonoPropertyBoolean</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#beefb997-c5b5-4f11-b5c1-6dcf5dc7b1a1'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="beefb997-c5b5-4f11-b5c1-6dcf5dc7b1a1"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#06b2a973-1c86-4a8a-a7da-5744077899a9'>ToBool</a></td><td style='width:75%' ><p><a name="06b2a973-1c86-4a8a-a7da-5744077899a9"></a></p>

<h3>ToBool ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>bool</code>.</p>

<h4>Returns</h4>

<p><code>true</code>, if bool was toed, <code>false</code> otherwise.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#71dc1fc7-37af-496a-ac2a-e15a5baf9af5'>Clone</a></td><td style='width:75%' class='def'><p><a name="71dc1fc7-37af-496a-ac2a-e15a5baf9af5"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="7582e65f-a4e4-40ab-8a53-a8a929f5667c"></a>
## KimonoPropertyText

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `string` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#8b627bc1-94e9-471f-9976-769a4587c474'>Value</a></td><td style='width:75%' ><p><a name="8b627bc1-94e9-471f-9976-769a4587c474"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The value.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#b0998649-7d12-4f15-8add-44475a64f733'>KimonoPropertyText</a></td><td style='width:75%' ><p><a name="b0998649-7d12-4f15-8add-44475a64f733"></a></p>

<h3>KimonoPropertyText ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7582e65f-a4e4-40ab-8a53-a8a929f5667c">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a4e517a7-18ad-4cea-9a71-9155cd1e3cdc'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="a4e517a7-18ad-4cea-9a71-9155cd1e3cdc"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cf40b4a-55c1-4b7f-b336-b2c206874295'>ToString</a></td><td style='width:75%' ><p><a name="2cf40b4a-55c1-4b7f-b336-b2c206874295"></a></p>

<h3>ToString ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>string</code>.</p>

<h4>Returns</h4>

<p>The <code>string</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#597b830d-b7e3-4843-915e-dd06db0dd87e'>Clone</a></td><td style='width:75%' class='def'><p><a name="597b830d-b7e3-4843-915e-dd06db0dd87e"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="cc0d1f51-c777-4035-bb47-fd7ea6bfa0f4"></a>
## KimonoPropertyColor

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `KimonoColor` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#c80b868d-a804-4a23-ac78-6383579e985e'>Value</a></td><td style='width:75%' ><p><a name="c80b868d-a804-4a23-ac78-6383579e985e"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoColor</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#cecce4b2-12d1-4e6a-a9ea-9e0ad0c1a180'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="cecce4b2-12d1-4e6a-a9ea-9e0ad0c1a180"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#cc0d1f51-c777-4035-bb47-fd7ea6bfa0f4">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#fa32e9a6-b8aa-4808-a18f-a8187c52de0f'>KimonoPropertyColor</a></td><td style='width:75%' ><p><a name="fa32e9a6-b8aa-4808-a18f-a8187c52de0f"></a></p>

<h3>KimonoPropertyColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7582e65f-a4e4-40ab-8a53-a8a929f5667c">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#37416f33-c69c-4399-bed5-11c3e2ca36c8'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="37416f33-c69c-4399-bed5-11c3e2ca36c8"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#faaf27e3-e405-48b0-a5b2-3f7f5dbc429d'>ToColor</a></td><td style='width:75%' ><p><a name="faaf27e3-e405-48b0-a5b2-3f7f5dbc429d"></a></p>

<h3>ToColor ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoColor</code>.</p>

<h4>Returns</h4>

<p>The color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3d211803-f07e-4773-ba02-761d0c56b902'>Clone</a></td><td style='width:75%' class='def'><p><a name="3d211803-f07e-4773-ba02-761d0c56b902"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="09e2a12a-c6e6-4f46-883f-cb3d2cc82d9e"></a>
## KimonoPropertyGradient

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines a `KimonoProperty` that represents a `KimonoGradient` value.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#436fb944-c018-4399-9736-ecced934296e'>Value</a></td><td style='width:75%' ><p><a name="436fb944-c018-4399-9736-ecced934296e"></a></p>

<h3>Value</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets or sets the value.</p>

<h4>Return Value</h4>

<p>The <code>KimonoGradient</code> value.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#627c79f9-b024-4a6b-ade2-704807827158'>IsObiScriptValue</a></td><td style='width:75%' class='def'><p><a name="627c79f9-b024-4a6b-ade2-704807827158"></a></p>

<h3>IsObiScriptValue</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets a value indicating whether this <a href="#cc0d1f51-c777-4035-bb47-fd7ea6bfa0f4">KimonoPropertyColor</a> is obi script value.</p>

<h4>Return Value</h4>

<p><code>true</code> if is obi script value; otherwise, <code>false</code>.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#20f8b6e7-3bb3-42ed-aaf6-870b0fca4268'>KimonoPropertyGradient</a></td><td style='width:75%' ><p><a name="20f8b6e7-3bb3-42ed-aaf6-870b0fca4268"></a></p>

<h3>KimonoPropertyGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Initializes a new instance of the <a href="#7582e65f-a4e4-40ab-8a53-a8a929f5667c">KimonoPropertyText</a> class.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4d45c7c9-4f6b-419b-a182-72cc2b3e1b27'>Evaluate</a></td><td style='width:75%' class='def'><p><a name="4d45c7c9-4f6b-419b-a182-72cc2b3e1b27"></a></p>

<h3>Evaluate ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Evaluate this instance by executing any attached Obi Script to get the new value for the <code>KimonoProperty</code>.</p>

<h4>Returns</h4>

<p>The result of the Obi Script execution as a <code>ObiScriptResult</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#e4922391-4bae-4e95-92e0-1a9e927ea39f'>ToGradient</a></td><td style='width:75%' ><p><a name="e4922391-4bae-4e95-92e0-1a9e927ea39f"></a></p>

<h3>ToGradient ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this <code>KimonoProperty</code> to a <code>KimonoGradient</code>.</p>

<h4>Returns</h4>

<p>The gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9466697a-7f98-4fc2-8cd8-1ff7836461e5'>Clone</a></td><td style='width:75%' class='def'><p><a name="9466697a-7f98-4fc2-8cd8-1ff7836461e5"></a></p>

<h3>Clone ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Clone this instance.</p>

<h4>Returns</h4>

<p>The clone.</p>
</td></tr></table></p>


---

<a name="4f60550f-ed3f-4674-869c-50a5bb734427"></a>
## CodeOutputOS

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the OS that code will be generated for
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#834b7012-91e6-4ffb-a873-d152c0a2653c'>Windows</a></td><td style='width:75%' ><p><a name="834b7012-91e6-4ffb-a873-d152c0a2653c"></a>
<b>Windows</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#3072b61e-5d1b-4347-9fb3-5d027d7c2e03'>WindowsUWP</a></td><td style='width:75%' class='def'><p><a name="3072b61e-5d1b-4347-9fb3-5d027d7c2e03"></a>
<b>WindowsUWP</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Universal Windows Platform.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2e6dee33-f7b8-45cf-9ab2-b547dc3018c7'>WindowsWPF</a></td><td style='width:75%' ><p><a name="2e6dee33-f7b8-45cf-9ab2-b547dc3018c7"></a>
<b>WindowsWPF</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Windows OS based machines using Windows Presentation Foundation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0b800a0c-87a7-49bd-8346-029d23c189b6'>Android</a></td><td style='width:75%' class='def'><p><a name="0b800a0c-87a7-49bd-8346-029d23c189b6"></a>
<b>Android</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For Android OS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#517a2503-c38d-4add-b7b8-3f949912b484'>iOS</a></td><td style='width:75%' ><p><a name="517a2503-c38d-4add-b7b8-3f949912b484"></a>
<b>iOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For iOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#24cff071-71a9-471f-8402-ae1acc19a76c'>tvOS</a></td><td style='width:75%' class='def'><p><a name="24cff071-71a9-471f-8402-ae1acc19a76c"></a>
<b>tvOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For tvOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#340448ca-0800-419d-b6a4-9d37bb76fb8f'>macOS</a></td><td style='width:75%' ><p><a name="340448ca-0800-419d-b6a4-9d37bb76fb8f"></a>
<b>macOS</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>For macOS based machines.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a9a02f31-29bf-4b0f-8444-aaa098449414'>CrossPlatform</a></td><td style='width:75%' class='def'><p><a name="a9a02f31-29bf-4b0f-8444-aaa098449414"></a>
<b>CrossPlatform</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Cross-platform code.</p>
</td></tr></table></p>


---

<a name="ccb21685-5215-4c79-a19b-2ace3554426b"></a>
## CodeOutputLanguage

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Defines the language that code will be output in.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eb7be29c-e685-42f3-acfc-97783d4d50f4'>CSharp</a></td><td style='width:75%' ><p><a name="eb7be29c-e685-42f3-acfc-97783d4d50f4"></a>
<b>CSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for C#.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#9726b9b7-aaae-4e3c-9f72-de7bfc158966'>ObiScript</a></td><td style='width:75%' class='def'><p><a name="9726b9b7-aaae-4e3c-9f72-de7bfc158966"></a>
<b>ObiScript</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Generate code for the internal ObiScript scripting language.</p>
</td></tr></table></p>


---

<a name="006036ea-70ff-4355-975c-20de7e52ac2b"></a>
## CodeOutputLibrary

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Code output library.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#eeb2a166-4ce2-46c0-b2a9-48445d376150'>SkiaSharp</a></td><td style='width:75%' ><p><a name="eeb2a166-4ce2-46c0-b2a9-48445d376150"></a>
<b>SkiaSharp</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output pure SkiaSharp code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#2cbef926-b1c9-47a3-a1cd-5d7fea53e5bd'>KimonoCore</a></td><td style='width:75%' class='def'><p><a name="2cbef926-b1c9-47a3-a1cd-5d7fea53e5bd"></a>
<b>KimonoCore</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Output code using the helper <code>KimonoCore</code> classes.</p>
</td></tr></table></p>


---

<a name="bed72a88-fa7b-4b40-aa3d-d2a470d58898"></a>
## KimonoCodeGenerator

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

The Kimono Code Generator has routine to assist in the generation of output source code.
<p><table style='width:100%'><tr><th style='width:25%'>Fields</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#01009419-938d-47b1-8a6d-7fb2cb007fdb'>NextElementNumber</a></td><td style='width:75%' ><p><a name="01009419-938d-47b1-8a6d-7fb2cb007fdb"></a>
<b>NextElementNumber</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>The next element number.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6650a2fc-bffd-4552-bcb2-faa13ea9fac7'>AddNumberToElementNames</a></td><td style='width:75%' class='def'><p><a name="6650a2fc-bffd-4552-bcb2-faa13ea9fac7"></a>
<b>AddNumberToElementNames</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>Add number to element names when generating.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#07d1389c-dfa1-4937-b0e3-ae6abdebba83'>SupportingColors</a></td><td style='width:75%' ><p><a name="07d1389c-dfa1-4937-b0e3-ae6abdebba83"></a>
<b>SupportingColors</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting colors that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#48450c3c-a8c8-4410-a45b-7949f24c795b'>SupportingGradients</a></td><td style='width:75%' class='def'><p><a name="48450c3c-a8c8-4410-a45b-7949f24c795b"></a>
<b>SupportingGradients</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting gradients that are required for the object being converted to source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#34439706-4ae0-4378-a022-e1e79ada06da'>SupportingStyles</a></td><td style='width:75%' ><p><a name="34439706-4ae0-4378-a022-e1e79ada06da"></a>
<b>SupportingStyles</b></p>

<p><b>Added In API Version 01.00.00</b></p>

<p>A list of supporting styles that are required for the object being converted to source code.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#83a1fb2f-4612-443f-8f96-aed24e672d3c'>ResetCodeGeneration</a></td><td style='width:75%' ><p><a name="83a1fb2f-4612-443f-8f96-aed24e672d3c"></a></p>

<h3>ResetCodeGeneration ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Resets the code generation.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c59c7313-422b-4a5d-af17-7a7daf2ffa76'>AddSupportingColor</a></td><td style='width:75%' class='def'><p><a name="c59c7313-422b-4a5d-af17-7a7daf2ffa76"></a></p>

<h3>AddSupportingColor (KimonoCore.KimonoColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given color to the collection of named colors that are used in the generation of other Kimono Objects. If a color is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' ><p><a name="0b6c45f0-be0a-4f32-913f-1ea78b9876fb"></a>
The <code>KimonoColor</code> to add to the collection.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting color.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#04f2303f-8cbf-4db6-a59b-4ad8a8f17c5b'>CodeForSupportingColors</a></td><td style='width:75%' ><p><a name="04f2303f-8cbf-4db6-a59b-4ad8a8f17c5b"></a></p>

<h3>CodeForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="531dd254-a38d-416e-851a-4204431a6ef3"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="40524265-196a-4e5e-9f93-5cafe72f8ff3"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#815774e9-984a-4a70-8992-fd81384df93e'>PropertyForSupportingColors</a></td><td style='width:75%' class='def'><p><a name="815774e9-984a-4a70-8992-fd81384df93e"></a></p>

<h3>PropertyForSupportingColors (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="c57ef376-e381-45f1-9cb2-099d517a0767"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="bbbb5b96-4c10-47cb-bec7-00a7cb0d21bc"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#1f2b57dd-9973-4dd4-898a-b1234e522192'>AddSupportingGradient</a></td><td style='width:75%' ><p><a name="1f2b57dd-9973-4dd4-898a-b1234e522192"></a></p>

<h3>AddSupportingGradient (KimonoCore.KimonoGradient)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given gradient to the collection of named gradients that are used in the generation of other Kimono Objects. If a gradient is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>gradient</td><td style='width:75%' ><p><a name="a3f3fdb2-d554-4bf8-b628-11e9b1a2c3b8"></a>
The <code>KimonoGradient</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting gradient.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#66e8517d-ef68-464c-9d35-9a9def709cf9'>CodeForSupportGradients</a></td><td style='width:75%' class='def'><p><a name="66e8517d-ef68-464c-9d35-9a9def709cf9"></a></p>

<h3>CodeForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="8ee2eaf6-38ec-4b44-8690-c7b1d8453188"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="77f88e2e-f02a-419f-91c2-b550aeba39a1"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#ca699b5d-cb94-4a7b-b397-c5fae26b7a01'>PrivateVariablesForSupportingGradients</a></td><td style='width:75%' ><p><a name="ca699b5d-cb94-4a7b-b397-c5fae26b7a01"></a></p>

<h3>PrivateVariablesForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="d5d0d87f-d418-48cd-9735-b78139023e7e"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="c394d9ef-a87b-49d5-8460-51695a0f2e03"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f6178c7c-be96-4185-9940-e88f5c798927'>PropertyForSupportingGradients</a></td><td style='width:75%' class='def'><p><a name="f6178c7c-be96-4185-9940-e88f5c798927"></a></p>

<h3>PropertyForSupportingGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="91259720-5a4e-4ca2-b5d2-ca0847d94fb4"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="04d3479d-a9fe-4a97-8103-69206b6291e7"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#4b29148c-2f09-405d-9113-a0310e935150'>InitializerForSupportGradients</a></td><td style='width:75%' ><p><a name="4b29148c-2f09-405d-9113-a0310e935150"></a></p>

<h3>InitializerForSupportGradients (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting gradients used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="f3340783-b943-41fd-a41d-33952ce9031d"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="65bf6dca-ac97-422c-ac2b-f2690eb73a07"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6bf272ee-c7d1-4203-bada-f234dfdaccc4'>AddSupportingStyle</a></td><td style='width:75%' class='def'><p><a name="6bf272ee-c7d1-4203-bada-f234dfdaccc4"></a></p>

<h3>AddSupportingStyle (KimonoCore.KimonoStyle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Adds the given style to the collection of named styles that are used in the generation of other Kimono Objects. If a style is already in the collection, its <code>ElementName</code> is returned.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>style</td><td style='width:75%' ><p><a name="cafe9212-52e4-44e2-a5de-a3bf8734fb08"></a>
The <code>KimonoStyle</code> to add.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The <code>ElementName</code> for the supporting style.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#d83842a1-9560-4835-8c9c-d0f917eee259'>CodeForSupportStyles</a></td><td style='width:75%' ><p><a name="d83842a1-9560-4835-8c9c-d0f917eee259"></a></p>

<h3>CodeForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="f1f488df-ca91-4e5d-9e61-4870a1c0b4b9"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="a23c7336-ce9e-4a56-b38d-73709fa124f1"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#6877f4e5-72e2-43c4-84fd-6e068401d9a3'>PropertyForSupportingStyles</a></td><td style='width:75%' class='def'><p><a name="6877f4e5-72e2-43c4-84fd-6e068401d9a3"></a></p>

<h3>PropertyForSupportingStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting colors used in generating a higher level Kimono object as a public computed propert.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="314386c9-7ade-40d3-b150-a3d7cca7a000"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="e7a1ecb6-b14e-4f3a-8a6d-764846b76192"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoColors</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#79330fb9-6d96-4638-bc44-99008df242fc'>InitializerForSupportStyles</a></td><td style='width:75%' ><p><a name="79330fb9-6d96-4638-bc44-99008df242fc"></a></p>

<h3>InitializerForSupportStyles (KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Returns the source code for all of the supporting styles used in generating a higher level Kimono object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' ><p><a name="5d7687ed-ccb1-4826-97f6-3a8a9e5cdeb1"></a>
The <code>CodeOutputLanguage</code> for the generated code.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' class='def'><p><a name="f0a8588b-1b90-4040-8bc3-91dcb7703863"></a>
The <code>CodeOutputLibrary</code> of the generated code.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code for the supporting <code>KimonoGradients</code>.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#244c84ff-eb00-4092-8b19-8f70f2314751'>MakeElementName</a></td><td style='width:75%' class='def'><p><a name="244c84ff-eb00-4092-8b19-8f70f2314751"></a></p>

<h3>MakeElementName (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Makes a valid source code name for the name of a given Kimono Object.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>name</td><td style='width:75%' ><p><a name="e44efa13-30e4-4cff-b0b6-42c7ba224bd6"></a>
The source Kimono Object name.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The element name valid for use in source code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c0c98898-c3b8-41bc-9b98-b3f72147a670'>IncreaseIndentLevel</a></td><td style='width:75%' ><p><a name="c0c98898-c3b8-41bc-9b98-b3f72147a670"></a></p>

<h3>IncreaseIndentLevel (System.String, System.Int32)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code by the given number of levels</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="58fe5b48-1fa6-4dda-8abe-fb22213a8460"></a>
Source code.</p>
</td></tr><tr><td style='width:25%' class='term'>levels</td><td style='width:75%' class='def'><p><a name="e3e65840-a3b6-4edd-b6ae-5c1b0a8ebbe6"></a>
Levels.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The indent level.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#0770a966-46d0-4c8e-bc6f-c427f4a894da'>IncreaseIndentLevel</a></td><td style='width:75%' class='def'><p><a name="0770a966-46d0-4c8e-bc6f-c427f4a894da"></a></p>

<h3>IncreaseIndentLevel (System.String)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Increases the indent level of the given section of source code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>sourceCode</td><td style='width:75%' ><p><a name="a7cf01ad-9657-44df-b7f8-6e9d64d2f8e3"></a>
The source code to indent.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The source code indented by one tab.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#a00738f4-6478-4c9b-ab3c-a4b37137ff83'>ColorToCode</a></td><td style='width:75%' ><p><a name="a00738f4-6478-4c9b-ab3c-a4b37137ff83"></a></p>

<h3>ColorToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKColor)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given color to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="c42263c7-bdce-4418-a488-2eac0dc65d1e"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>color</td><td style='width:75%' class='def'><p><a name="d58af60f-5c2c-4143-b84c-88dae62c921e"></a>
The <code>SKColor</code> to create code for.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The color as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#f445214e-721c-4046-ac7c-ec52be4f7086'>PointToCode</a></td><td style='width:75%' class='def'><p><a name="f445214e-721c-4046-ac7c-ec52be4f7086"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, SkiaSharp.SKPoint)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="2fa862bc-b24c-44cf-ad48-8226e40e93cd"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="f6db35f2-d18f-4cba-b0b1-3a8878409c20"></a>
The <code>SKPoint</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#021d8b0e-cb0d-4e9f-a75e-314ea08b5e8c'>PointToCode</a></td><td style='width:75%' ><p><a name="021d8b0e-cb0d-4e9f-a75e-314ea08b5e8c"></a></p>

<h3>PointToCode (KimonoCore.CodeOutputLibrary, KimonoCore.KimonoHandle)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the given point to code using the given library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="048b1d1d-bff4-4530-a24f-39bca91359a1"></a>
The <code>CodeOutputLibrary</code> to encode to.</p>
</td></tr><tr><td style='width:25%' class='term'>point</td><td style='width:75%' class='def'><p><a name="263586fc-c185-41ad-bfba-bfbeb5c3bbf9"></a>
The <code>KimonoHandle</code> to encode.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The point as code.</p>
</td></tr></table></p>


---

<a name="fe535d44-38bf-48f6-be7b-e09267aca093"></a>
##IKimonoCodeGeneration

### Namespace

[KimonoCore](#8f9b0d76-5653-4ad0-96b3-560f4444b75f)

### Added In API Version

01.00.00

### Summary

Interface for any Kimono Object that support source code generation.
<p><table style='width:100%'><tr><th style='width:25%'>Properties</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#468426fa-6712-4f1d-a38f-37ac313d4c0d'>Name</a></td><td style='width:75%' ><p><a name="468426fa-6712-4f1d-a38f-37ac313d4c0d"></a></p>

<h3>Name</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Gets the name.</p>

<h4>Return Value</h4>

<p>The name of the element.</p>
</td></tr></table></p>

<p><table style='width:100%'><tr><th style='width:25%'>Methods</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'><a href='#99fa4cbb-f0f4-4782-b47f-f203718ecccc'>ToSkiaSharpPath</a></td><td style='width:75%' ><p><a name="99fa4cbb-f0f4-4782-b47f-f203718ecccc"></a></p>

<h3>ToSkiaSharpPath ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shapes path to C# Skia based code.</p>

<h4>Returns</h4>

<p>The path as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#c8d5a55b-5c10-471b-9320-d08817b60cf8'>ToSkiaSharp</a></td><td style='width:75%' class='def'><p><a name="c8d5a55b-5c10-471b-9320-d08817b60cf8"></a></p>

<h3>ToSkiaSharp ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts the shape to C# code using the Skia library.</p>

<h4>Returns</h4>

<p>The shape as code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#400cfdb5-23df-47b4-adec-c104f3ed823a'>ToKimonoCore</a></td><td style='width:75%' ><p><a name="400cfdb5-23df-47b4-adec-c104f3ed823a"></a></p>

<h3>ToKimonoCore ()</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape C# using the KimonoCore library.</p>

<h4>Returns</h4>

<p>The kimono core.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#043eb67c-b79f-4391-8594-adbfcea55aa6'>ToCSharp</a></td><td style='width:75%' class='def'><p><a name="043eb67c-b79f-4391-8594-adbfcea55aa6"></a></p>

<h3>ToCSharp (KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this shape to C# code.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="f7f888d8-6588-4430-a942-fd197a2a6672"></a>
The <code>CodeOutputLibrary</code> to use.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The shape as C# code.</p>
</td></tr><tr><td style='width:25%' class='term'><a href='#00f26d90-1130-4a3f-9d7d-3f51eae07d4f'>ToCode</a></td><td style='width:75%' ><p><a name="00f26d90-1130-4a3f-9d7d-3f51eae07d4f"></a></p>

<h3>ToCode (KimonoCore.CodeOutputOS, KimonoCore.CodeOutputLanguage, KimonoCore.CodeOutputLibrary)</h3>

<h4>Added In API Version</h4>

<p>01.00.00</p>

<h4>Summary</h4>

<p>Converts this object to source code for the given OS, Language and Library.</p>

<p><table style='width:100%'><tr><th style='width:25%'>Parameter</th><th style='width:75%'>Summary</th></tr><tr><td style='width:25%' class='term'>outputOS</td><td style='width:75%' ><p><a name="1b76ad73-6c0b-4cdb-bc9e-7f7e2c921467"></a>
The <code>CodeOutputOS</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLanguage</td><td style='width:75%' class='def'><p><a name="77c5286b-9faa-4cbb-8db3-657616c6d5b6"></a>
The <code>CodeOutputLanguage</code>.</p>
</td></tr><tr><td style='width:25%' class='term'>outputLibrary</td><td style='width:75%' ><p><a name="44c35e57-bcda-4ec8-94b1-e1899c2c2892"></a>
The <code>CodeOutputLibrary</code>.</p>
</td></tr></table></p>

<h4>Returns</h4>

<p>The object represented as source code in a <code>string</code>.</p>
</td></tr></table></p>

